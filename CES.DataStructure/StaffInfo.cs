using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CES.DataStructure;

namespace CES.DataStructure
{
    public class StaffInfo
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string ID { set; get; }
        
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { set; get; }
        
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { set; get; }
        
        /// <summary>
        /// 职务的ID
        /// </summary>
        public string JobID { set; get; }
        
        /// <summary>
        /// 分类
        /// </summary>
        public RoleType Role { set; get; }
        
        /// <summary>
        /// 电话
        /// </summary>
        public string Tele { set; get; }
        
        /// <summary>
        ///默认构造函数 
        /// </summary>
        public StaffInfo()
        { 
            
        }
    }
}
