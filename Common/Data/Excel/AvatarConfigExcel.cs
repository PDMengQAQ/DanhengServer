﻿using EggLink.DanhengServer.Data.Config;
using EggLink.DanhengServer.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Text.RegularExpressions;

namespace EggLink.DanhengServer.Data.Excel
{
    [ResourceEntity("AvatarConfig.json", true)]
    public class AvatarConfigExcel : ExcelResource
    {
        public int AvatarID { get; set; } = 0;
        public HashName AvatarName { get; set; } = new();
        public int ExpGroup { get; set; } = 0;
        public List<int> RankIDList { get; set; } = [];
        public string? JsonPath { get; set; } = "";

        [JsonConverter(typeof(StringEnumConverter))]
        public RarityEnum Rarity { get; set; } = 0;

        [JsonConverter(typeof(StringEnumConverter))]
        public DamageTypeEnum DamageType { get; set; } = 0;

        [JsonIgnore()]
        public List<AvatarSkillTreeConfigExcel> DefaultSkillTree = [];

        [JsonIgnore()]
        public int RankUpItemId { get; set; }

        [JsonIgnore()]
        public string NameKey { get; set; } = "";

        [JsonIgnore()]
        public AbilityInfo? MazeSkill { get; set; }
        [JsonIgnore()]
        public AbilityInfo? MazeAtk { get; set; }

        public override int GetId()
        {
            return AvatarID;
        }

        public override void Loaded()
        {
            GameData.AvatarConfigData.Add(AvatarID, this);
            RankUpItemId = AvatarID + 10000;

            var regex = new Regex(@"(?<=Avatar_)(.*?)(?=_Config)");
            var match = regex.Match(JsonPath??"");
            if (match.Success)
            {
                NameKey = match.Value;
            }
            JsonPath = null;
        }
    }
}
