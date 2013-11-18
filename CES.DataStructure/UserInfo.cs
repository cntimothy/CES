using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CES.DataStructure
{
    public class UserInfo
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string ID { set; get; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 用户类型
        /// </summary>
        public UserType UserType {set; get;}

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="id">用户名</param>
        /// <param name="name">姓名</param>
        /// <param name="userType">用户类型</param>
        public UserInfo(string id, string name, UserType userType)
        {
            this.ID = id;
            this.Name = name;
            this.UserType = userType;
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public UserInfo()
        {
            
        }
    }
}
