using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CES.DataStructure;

namespace CES.Controller
{
    public class LoginManagementCtrl
    {
        /// <summary>
        /// 登录，登录成功返回true，否则返回false
        /// </summary>
        /// <param name="userInfo">包含需返回的用户信息</param>
        /// <param name="id">用户名</param>
        /// <param name="passwd">密码</param>
        /// <param name="loginType">登录类型（普通用户或者管理员）</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool Loginin(ref UserInfo userInfo, string id, string passwd, LoginType loginType, ref string exception)
        {
            if (id == "manager")
            {
                userInfo.ID = "manager";
                userInfo.Name = "管理员";
                userInfo.UserType = UserType.MANAGER;
            }
            else if (id == "super")
            {
                userInfo.ID = "super";
                userInfo.Name = "超级管理员";
                userInfo.UserType = UserType.SUPER;
            }
            else if (id == "evaluated")
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
