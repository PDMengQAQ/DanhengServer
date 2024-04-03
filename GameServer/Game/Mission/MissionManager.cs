﻿using EggLink.DanhengServer.Data;
using EggLink.DanhengServer.Database;
using EggLink.DanhengServer.Database.Inventory;
using EggLink.DanhengServer.Database.Mission;
using EggLink.DanhengServer.Enums;
using EggLink.DanhengServer.Game.Mission.FinishAction;
using EggLink.DanhengServer.Game.Mission.FinishType;
using EggLink.DanhengServer.Game.Player;
using EggLink.DanhengServer.Server.Packet.Send.Mission;
using EggLink.DanhengServer.Server.Packet.Send.Player;
using EggLink.DanhengServer.Server.Packet.Send.Scene;
using System.Reflection;

namespace EggLink.DanhengServer.Game.Mission
{
    public class MissionManager : BasePlayerManager
    {
        #region Initializer & Properties

        public MissionData Data;
        public Dictionary<FinishActionTypeEnum, MissionFinishActionHandler> ActionHandlers = [];
        public Dictionary<MissionFinishTypeEnum, MissionFinishTypeHandler> FinishTypeHandlers = [];

        public MissionManager(PlayerInstance player) : base(player)
        {
            Data = DatabaseHelper.Instance!.GetInstanceOrCreateNew<MissionData>(player.Uid);

            var types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in types)
            {
                var attr = type.GetCustomAttribute<MissionFinishActionAttribute>();
                if (attr != null)
                {
                    var handler = (MissionFinishActionHandler)Activator.CreateInstance(type, null)!;
                    ActionHandlers.Add(attr.FinishAction, handler);
                }
                var attr2 = type.GetCustomAttribute<MissionFinishTypeAttribute>();
                if (attr2 != null)
                {
                    var handler = (MissionFinishTypeHandler)Activator.CreateInstance(type, null)!;
                    FinishTypeHandlers.Add(attr2.FinishType, handler);
                }
            }
        }

        #endregion

        #region Mission Actions

        public List<Proto.MissionSync?> AcceptMainMission(int missionId, bool sendPacket = true)
        {
            if (Data.MissionInfo.ContainsKey(missionId)) return [];
            // Get entry sub mission
            GameData.MainMissionData.TryGetValue(missionId, out var mission);
            if (mission == null) return [];

            Data.MissionInfo.Add(missionId, []);
            Data.MainMissionInfo.Add(missionId, MissionPhaseEnum.Doing);

            var list = new List<Proto.MissionSync?>();
            mission.MissionInfo?.StartSubMissionList.ForEach(i => list.Add(AcceptSubMission(i, sendPacket)));
            return list;
        }

        public void AcceptSubMission(int missionId)
        {
            AcceptSubMission(missionId, true);
        }

        public Proto.MissionSync? AcceptSubMission(int missionId, bool sendPacket, bool doFinishTypeAction = true)
        {
            GameData.SubMissionData.TryGetValue(missionId, out var subMission);
            if (subMission == null) return null;
            var mainMissionId = subMission.MainMissionID;
            if (!Data.MissionInfo.TryGetValue(mainMissionId, out Dictionary<int, MissionInfo>? value)) return null;
            if (value == null || value.ContainsKey(missionId)) return null;
            // Get entry sub mission
            GameData.SubMissionData.TryGetValue(missionId, out var mission);
            if (mission == null) return null;

            value.Add(missionId, new MissionInfo()
            {
                Status = MissionPhaseEnum.Doing,
                MissionId = missionId,
            });
            var sync = new Proto.MissionSync();
            sync.MissionList.Add(new Proto.Mission()
            {
                Id = (uint)missionId,
                Status = Proto.MissionStatus.MissionDoing,
            });

            DatabaseHelper.Instance?.UpdateInstance(Data);
            if (sendPacket) Player.SendPacket(new PacketPlayerSyncScNotify(sync));
            Player.SceneInstance!.SyncGroupInfo();
            if (doFinishTypeAction && mission.SubMissionInfo != null)
            {
                FinishTypeHandlers.TryGetValue(mission.SubMissionInfo.FinishType, out var handler);
                handler?.Init(Player, mission.SubMissionInfo, null);
            }
            return sync;
        }

        public void FinishMainMission(int missionId)
        {
            if (!Data.MainMissionInfo.TryGetValue(missionId, out var value)) return;
            if (value != MissionPhaseEnum.Doing) return;
            Data.MainMissionInfo[missionId] = MissionPhaseEnum.Finish;
            var sync = new Proto.MissionSync();
            sync.MainMissionIdList.Add((uint)missionId);
            // get next main mission
            foreach (var nextMission in GameData.MainMissionData.Values)
            {
                if (!nextMission.IsEqual(Data)) continue;
                var res = AcceptMainMission(nextMission.MainMissionID, false);
                foreach (var subMission in res)
                {
                    if (subMission != null)
                    {
                        sync.MissionList.AddRange(subMission.MissionList);
                    }
                }
            }

            Player.SendPacket(new PacketPlayerSyncScNotify(sync));
            Player.SendPacket(new PacketStartFinishMainMissionScNotify(missionId));
            HandleMissionReward(missionId);

            DatabaseHelper.Instance?.UpdateInstance(Data);
        }

        public void FinishSubMission(int missionId)
        {
            GameData.SubMissionData.TryGetValue(missionId, out var subMission);
            if (subMission == null) return;
            var mainMissionId = subMission.MainMissionID;
            if (!Data.MissionInfo.TryGetValue(mainMissionId, out var value)) return;
            GameData.MainMissionData.TryGetValue(mainMissionId, out var mainMission);
            if (mainMission == null) return;
            if (value == null || !value.TryGetValue(missionId, out var mission)) return;
            if (mission.Status != MissionPhaseEnum.Doing) return;
            mission.Status = MissionPhaseEnum.Finish;
            var sync = new Proto.MissionSync();
            sync.MissionList.Add(new Proto.Mission()
            {
                Id = (uint)missionId,
                Status = Proto.MissionStatus.MissionFinish,
                Progress = (uint)(subMission.SubMissionInfo?.Progress ?? 1)
            });

            // get next sub mission
            foreach (var nextMission in mainMission.MissionInfo?.SubMissionList ?? [])
            {
                bool canAccept = true;
                foreach (var id in nextMission.TakeParamIntList)
                {
                    if (GetSubMissionStatus(id) != MissionPhaseEnum.Finish)
                    {
                        canAccept = false;
                    }
                }
                if (canAccept)
                {
                    var s = AcceptSubMission(nextMission.ID, false, true);
                    if (s != null)
                    {
                        sync.MissionList.Add(new Proto.Mission()
                        {
                            Id = (uint)nextMission.ID,
                            Status = Proto.MissionStatus.MissionDoing,
                        });
                    }
                }
            }
            if (mainMission.MissionInfo != null)
                HandleFinishAction(mainMission.MissionInfo, missionId);
            Player.SendPacket(new PacketPlayerSyncScNotify(sync));
            Player.SendPacket(new PacketStartFinishSubMissionScNotify(missionId));

            // Get if it should finish main mission
            // get current main mission
            var shouldFinish = true;
            mainMission.MissionInfo?.FinishSubMissionList.ForEach(id =>
            {
                if (GetSubMissionStatus(id) != MissionPhaseEnum.Finish)
                {
                    shouldFinish = false;
                }
            });

            foreach (var nextMission in GetRunningSubMissionList())
            {
                FinishTypeHandlers.TryGetValue(nextMission.FinishType, out var handler);
                handler?.HandleFinishType(Player, nextMission, null);
            }

            if (shouldFinish)
            {
                FinishMainMission(mainMissionId);
            }

            DatabaseHelper.Instance?.UpdateInstance(Data);
        }

        public void HandleFinishAction(Data.Config.MissionInfo info, int subMissionId)
        {
            var subMission = info.SubMissionList.Find(x => x.ID == subMissionId);
            if (subMission == null) return;

            foreach (var action in subMission.FinishActionList)
            {
                HandleFinishAction(action);
            }
        }

        public void HandleFinishAction(Data.Config.FinishActionInfo actionInfo)
        {
            ActionHandlers.TryGetValue(actionInfo.FinishActionType, out var handler);
            handler?.OnHandle(actionInfo.FinishActionPara, Player);
        }

        public void HandleMissionReward(int mainMissionId)
        {
            GameData.MainMissionData.TryGetValue(mainMissionId, out var mainMission);
            if (mainMission == null) return;
            GameData.RewardDataData.TryGetValue(mainMission.RewardID, out var reward);
            var ItemList = new Proto.ItemList();
            reward?.GetItems().ForEach(i =>
            {
                var res = Player.InventoryManager!.AddItem(i.Item1, i.Item2, false);
                if (res != null)
                {
                    ItemList.ItemList_.Add(res.ToProto());
                }
            });

            mainMission.SubRewardList.ForEach(i =>
            {
                GameData.RewardDataData.TryGetValue(i, out var reward);
                reward?.GetItems().ForEach(j =>
                {
                    var res = Player.InventoryManager!.AddItem(j.Item1, j.Item2, false);
                    if (res != null)
                    {
                        ItemList.ItemList_.Add(res.ToProto());
                    }
                });
            });

            Player.SendPacket(new PacketMissionRewardScNotify(mainMissionId, 0, ItemList));
            Player.SendPacket(new PacketScenePlaneEventScNotify(ItemList));
        }

        public void HandleFinishType(MissionFinishTypeEnum finishType, object? arg = null)
        {
            FinishTypeHandlers.TryGetValue(finishType, out var handler);
            foreach (var mission in GetRunningSubMissionList())
            {
                if (mission.FinishType == finishType)
                {
                    handler?.HandleFinishType(Player, mission, arg);
                }
            }
        }

        #endregion

        #region Mission Status

        public MissionPhaseEnum GetMainMissionStatus(int missionId)
        {
            if (Data.MainMissionInfo.TryGetValue(missionId, out var info))
            {
                return info!;
            }
            return MissionPhaseEnum.None;
        }

        public MissionPhaseEnum GetSubMissionStatus(int missionId)
        {
            GameData.SubMissionData.TryGetValue(missionId, out var subMission);
            if (subMission == null) return MissionPhaseEnum.None;
            var mainMissionId = subMission.MainMissionID;
            if (Data.MissionInfo.TryGetValue(mainMissionId, out var info))
            {
                if (info.TryGetValue(missionId, out var mission))
                {
                    return mission.Status;
                }
            }
            return MissionPhaseEnum.None;
        }

        public Data.Config.SubMissionInfo? GetSubMissionInfo(int missionId)
        {
            GameData.SubMissionData.TryGetValue(missionId, out var subMission);
            if (subMission == null) return null;
            return subMission.SubMissionInfo;
        }

        public List<int> GetRunningSubMissionIdList()
        {
            var list = new List<int>();
            foreach (var mainMission in Data.MissionInfo.Values)
            {
                foreach (var subMission in mainMission.Values)
                {
                    if (subMission.Status == MissionPhaseEnum.Doing)
                    {
                        list.Add(subMission.MissionId);
                    }
                }
            }
            return list;
        }

        public List<Data.Config.SubMissionInfo> GetRunningSubMissionList()
        {
            var list = new List<Data.Config.SubMissionInfo>();
            foreach (var mainMission in Data.MissionInfo.Values)
            {
                foreach (var subMission in mainMission.Values)
                {
                    if (subMission.Status == MissionPhaseEnum.Doing)
                    {
                        GameData.SubMissionData.TryGetValue(subMission.MissionId, out var mission);
                        if (mission != null && mission.SubMissionInfo != null)
                        {
                            list.Add(mission.SubMissionInfo);
                        }
                    }
                }
            }
            return list;
        }

        #endregion

        #region Handlers

        public void OnBattleFinish(Proto.PVEBattleResultCsReq req)
        {
            foreach (var mission in GetRunningSubMissionIdList())
            {
                var subMission = GetSubMissionInfo(mission);
                if (subMission != null && (subMission.FinishType == MissionFinishTypeEnum.StageWin || subMission.FinishType == MissionFinishTypeEnum.KillMonster) && req.EndStatus == Proto.BattleEndStatus.BattleEndWin)  // TODO: Move to handler
                {
                    FinishSubMission(mission);
                }
            }
        }

        public void OnPlayerInteractWithProp()
        {
            foreach (var id in GetRunningSubMissionIdList())
            {
                if (GetSubMissionInfo(id)?.FinishType == MissionFinishTypeEnum.PropState)
                {
                    FinishTypeHandlers.TryGetValue(MissionFinishTypeEnum.PropState, out var handler);
                    handler?.HandleFinishType(Player, GetSubMissionInfo(id)!, null);
                }
            }
        }

        #endregion
    }
}
