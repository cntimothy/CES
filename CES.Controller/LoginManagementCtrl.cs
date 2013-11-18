using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CES.DataStructure;

namespace CES.Controller
{
    public class LoginManagementCtrl
    {
        public static bool Loginin(ref UserInfo userInfo, string id, string passwd, LoginType loginType, ref string exception)
        {
            if (loginType == LoginType.MANAGER && id == "manager")
            {
                userInfo.ID = "manager";
                userInfo.Name = "管理员";
                userInfo.UserType = UserType.MANAGER;
            }
            else if (loginType == LoginType.MANAGER && id == "super")
            {
                userInfo.ID = "super";
                userInfo.Name = "超级管理员";
                userInfo.UserType = UserType.SUPER;
            }
            else if (loginType == LoginType.NORMALUSER && id == "evaluated")
            {
                userInfo.ID = "evaluated";
                userInfo.Name = "被考评人";
                userInfo.UserType = UserType.EVALUATED;
            }
            else
            {
                userInfo.ID = "evaluator";
                userInfo.Name = "考评人";
                userInfo.UserType = UserType.EVALUATOR;
            }
            return true;
        }
    }
}
