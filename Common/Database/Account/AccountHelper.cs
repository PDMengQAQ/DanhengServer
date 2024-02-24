﻿using EggLink.DanhengServer.Util;

namespace EggLink.DanhengServer.Database.Account
{
    public static class AccountHelper
    {
        public static void CreateAccount(string username, long uid)
        {
            if (AccountData.GetAccountByUserName(username) != null)
            {
                throw new Exception("Account already exists");
            }
            if (AccountData.GetAccountByUid(uid) != null)
            {

            }
            long newUid = uid;
            if (uid == 0)
            {
                newUid = 10000;  // start from 10000
                while (AccountData.GetAccountByUid(newUid) != null)
                {
                    newUid++;
                }
            }
            var per = ConfigManager.Config.ServerOption.DefaultPermissions;
            var perStr = string.Join(",", per);
            var account = new AccountData(username,newUid, permissions: perStr);
            account.SaveToDatabase();
        }
    }
}