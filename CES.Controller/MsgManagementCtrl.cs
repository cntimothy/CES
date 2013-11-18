﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CES.DataStructure;

namespace CES.Controller
{
    public class MsgManagementCtrl
    {
        /// <summary>
        /// 获取指定类型的员工信息，查询成功且不为空返回true，否则返回false
        /// </summary>
        /// <param name="table">包含返回信息(ID, Name, Sex, Job, Role, Tele)</param>
        /// <param name="staffType">员工类型（所有人、考评人、被考评人）</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetAll(ref DataTable table, StaffType staffType, ref string exception)
        {
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Sex");
            table.Columns.Add("Job");
            table.Columns.Add("Role");
            table.Columns.Add("Tele");
            string[] row1 = new string[] { "0001", "高1", "男", "职务1", "领导", "13820000000" };
            string[] row2 = new string[] { "0002", "高1", "男", "职务1", "领导", "13820000000" };
            string[] row3 = new string[] { "0003", "高1", "男", "职务1", "领导", "13820000000" };
            string[] row4 = new string[] { "0004", "高1", "男", "职务1", "领导", "13820000000" };
            string[] row5 = new string[] { "0005", "高1", "男", "职务1", "领导", "13820000000" };
            string[] row6 = new string[] { "0006", "高1", "男", "职务1", "领导", "13820000000" };
            string[] row7 = new string[] { "0007", "高1", "男", "职务1", "领导", "13820000000" };
            string[] row8 = new string[] { "0008", "高1", "男", "职务1", "领导", "13820000000" };
            string[] row9 = new string[] { "0009", "高1", "男", "职务1", "中层干部", "13820000000" };
            string[] row10 = new string[] { "0010", "高1", "男", "职务1", "中层干部", "13820000000" };
            string[] row11 = new string[] { "0011", "高1", "男", "职务1", "中层干部", "13820000000" };
            string[] row12 = new string[] { "0012", "高1", "男", "职务1", "中层干部", "13820000000" };
            string[] row13 = new string[] { "0013", "高1", "男", "职务1", "中层干部", "13820000000" };
            string[] row14 = new string[] { "0014", "高1", "男", "职务1", "中层干部", "13820000000" };
            string[] row15 = new string[] { "0015", "高1", "男", "职务1", "中层干部", "13820000000" };
            string[] row16 = new string[] { "0016", "高1", "男", "职务1", "中层干部", "13820000000" };
            string[] row17 = new string[] { "0017", "高1", "男", "职务1", "群众", "13820000000" };
            string[] row18 = new string[] { "0018", "高1", "男", "职务1", "群众", "13820000000" };
            string[] row19 = new string[] { "0019", "高1", "男", "职务1", "群众", "13820000000" };
            string[] row20 = new string[] { "0020", "高1", "女", "职务1", "群众", "13820000000" };
            string[] row21 = new string[] { "0021", "高1", "女", "职务1", "群众", "13820000000" };
            string[] row22 = new string[] { "0022", "高1", "女", "职务1", "群众", "13820000000" };
            string[] row23 = new string[] { "0023", "高1", "女", "职务1", "群众", "13820000000" };
            string[] row24 = new string[] { "0024", "高1", "女", "职务1", "群众", "13820000000" };
            string[] row25 = new string[] { "0025", "高1", "女", "职务1", "群众", "13820000000" };
            string[] row26 = new string[] { "0026", "高1", "女", "职务1", "群众", "13820000000" };
            string[] row27 = new string[] { "0027", "高1", "女", "职务1", "群众", "13820000000" };
            string[] row28 = new string[] { "0028", "高1", "女", "职务1", "群众", "13820000000" };
            string[] row29 = new string[] { "0029", "高1", "女", "职务1", "群众", "13820000000" };
            string[] row30 = new string[] { "0030", "高1", "女", "职务1", "群众", "13820000000" };
            string[] row31 = new string[] { "0031", "高1", "女", "职务1", "群众", "13820000000" };
            return true;
        }

        /// <summary>
        /// 给指定的ID发送短信
        /// </summary>
        /// <param name="IDList">指定的ID</param>
        /// <param name="msg">短信内容</param>
        /// <param name="excpetion"></param>
        /// <returns></returns>
        public static bool SendMsgByIDs(List<string> IDList, string msg, ref string excpetion)
        {
            return true;
        }
    }
}