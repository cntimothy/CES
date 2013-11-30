using System;
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
        /// <param name="table">包含返回信息(ID, Name, Sex, Job, Role, Tele, Status(已完成/未完成))</param>
        /// <param name="onlyShowUnsubmitted">表示是否只显示未提交分数的员工，为true时只显示未提交分数的员工</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetAll(ref DataTable table, bool onlyShowUnsubmitted, ref string exception)
        {
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Sex");
            table.Columns.Add("Job");
            table.Columns.Add("Role");
            table.Columns.Add("Tele");
            table.Columns.Add("Status");
            if (!onlyShowUnsubmitted)
            {
                string[] row1 = new string[] { "0001", "高1", "男", "职务1", "领导", "13820000000", "已提交" };
                string[] row2 = new string[] { "0002", "高1", "男", "职务1", "领导", "13820000000", "已提交" };
                string[] row3 = new string[] { "0003", "高1", "男", "职务1", "领导", "13820000000", "已提交" };
                string[] row4 = new string[] { "0004", "高1", "男", "职务1", "领导", "13820000000", "已提交" };
                string[] row5 = new string[] { "0005", "高1", "男", "职务1", "领导", "13820000000", "已提交" };
                string[] row6 = new string[] { "0006", "高1", "男", "职务1", "领导", "13820000000", "已提交" };
                string[] row7 = new string[] { "0007", "高1", "男", "职务1", "领导", "13820000000", "已提交" };
                string[] row8 = new string[] { "0008", "高1", "男", "职务1", "领导", "13820000000", "已提交" };
                string[] row9 = new string[] { "0009", "高1", "男", "职务1", "中层干部", "13820000000", "已提交" };
                string[] row10 = new string[] { "0010", "高1", "男", "职务1", "中层干部", "13820000000", "已提交" };
                string[] row11 = new string[] { "0011", "高1", "男", "职务1", "中层干部", "13820000000", "已提交" };
                string[] row12 = new string[] { "0012", "高1", "男", "职务1", "中层干部", "13820000000", "未提交" };
                string[] row13 = new string[] { "0013", "高1", "男", "职务1", "中层干部", "13820000000", "未提交" };
                string[] row14 = new string[] { "0014", "高1", "男", "职务1", "中层干部", "13820000000", "未提交" };
                string[] row15 = new string[] { "0015", "高1", "男", "职务1", "中层干部", "13820000000", "未提交" };
                string[] row16 = new string[] { "0016", "高1", "男", "职务1", "中层干部", "13820000000", "未提交" };
                string[] row17 = new string[] { "0017", "高1", "男", "职务1", "群众", "13820000000", "未提交" };
                string[] row18 = new string[] { "0018", "高1", "男", "职务1", "群众", "13820000000", "未提交" };
                string[] row19 = new string[] { "0019", "高1", "男", "职务1", "群众", "13820000000", "未提交" };
                string[] row20 = new string[] { "0020", "高1", "女", "职务1", "群众", "13820000000", "未提交" };
                string[] row21 = new string[] { "0021", "高1", "女", "职务1", "群众", "13820000000", "未提交" };
                string[] row22 = new string[] { "0022", "高1", "女", "职务1", "群众", "13820000000", "未提交" };
                string[] row23 = new string[] { "0023", "高1", "女", "职务1", "群众", "13820000000", "未提交" };
                string[] row24 = new string[] { "0024", "高1", "女", "职务1", "群众", "13820000000", "未提交" };
                string[] row25 = new string[] { "0025", "高1", "女", "职务1", "群众", "13820000000", "未提交" };
                string[] row26 = new string[] { "0026", "高1", "女", "职务1", "群众", "13820000000", "未提交" };
                string[] row27 = new string[] { "0027", "高1", "女", "职务1", "群众", "13820000000", "未提交" };
                string[] row28 = new string[] { "0028", "高1", "女", "职务1", "群众", "13820000000", "未提交" };
                string[] row29 = new string[] { "0029", "高1", "女", "职务1", "群众", "13820000000", "未提交" };
                string[] row30 = new string[] { "0030", "高1", "女", "职务1", "群众", "13820000000", "未提交" };
                string[] row31 = new string[] { "0031", "高1", "女", "职务1", "群众", "13820000000", "未提交" };
                table.Rows.Add(row1);
                table.Rows.Add(row2);
                table.Rows.Add(row3);
                table.Rows.Add(row4);
                table.Rows.Add(row5);
                table.Rows.Add(row6);
                table.Rows.Add(row7);
                table.Rows.Add(row8);
                table.Rows.Add(row9);
                table.Rows.Add(row10);
                table.Rows.Add(row11);
                table.Rows.Add(row12);
                table.Rows.Add(row13);
                table.Rows.Add(row14);
                table.Rows.Add(row15);
                table.Rows.Add(row16);
                table.Rows.Add(row17);
                table.Rows.Add(row18);
                table.Rows.Add(row19);
                table.Rows.Add(row20);
                table.Rows.Add(row21);
                table.Rows.Add(row22);
                table.Rows.Add(row23);
                table.Rows.Add(row24);
                table.Rows.Add(row25);
                table.Rows.Add(row26);
                table.Rows.Add(row27);
                table.Rows.Add(row28);
                table.Rows.Add(row29);
                table.Rows.Add(row30);
                table.Rows.Add(row31);
            }
            else
            {
                string[] row1 = new string[] { "0001", "高1", "男", "职务1", "领导", "13820000000", "未提交" };
                string[] row2 = new string[] { "0002", "高1", "男", "职务1", "领导", "13820000000", "未提交" };
                string[] row3 = new string[] { "0003", "高1", "男", "职务1", "领导", "13820000000", "未提交" };
                string[] row4 = new string[] { "0004", "高1", "男", "职务1", "领导", "13820000000", "未提交" };
                string[] row5 = new string[] { "0005", "高1", "男", "职务1", "领导", "13820000000", "未提交" };
                string[] row6 = new string[] { "0006", "高1", "男", "职务1", "领导", "13820000000", "未提交" };
                string[] row7 = new string[] { "0007", "高1", "男", "职务1", "领导", "13820000000", "未提交" };
                string[] row8 = new string[] { "0008", "高1", "男", "职务1", "领导", "13820000000", "未提交" };
                string[] row9 = new string[] { "0009", "高1", "男", "职务1", "中层干部", "13820000000", "未提交" };
                string[] row10 = new string[] { "0010", "高1", "男", "职务1", "中层干部", "13820000000", "未提交" };
                string[] row11 = new string[] { "0011", "高1", "男", "职务1", "中层干部", "13820000000", "未提交" };
                table.Rows.Add(row1);
                table.Rows.Add(row2);
                table.Rows.Add(row3);
                table.Rows.Add(row4);
                table.Rows.Add(row5);
                table.Rows.Add(row6);
                table.Rows.Add(row7);
                table.Rows.Add(row8);
                table.Rows.Add(row9);
                table.Rows.Add(row10);
                table.Rows.Add(row11);
            }
            return true;
        }

        /// <summary>
        /// 给指定的ID发送短信
        /// </summary>
        /// <param name="IDList">指定的ID</param>
        /// <param name="msg">短信内容</param>
        /// <param name="addMsg">是否自动加上用户名和密码</param>
        /// <param name="excpetion"></param>
        /// <returns></returns>
        public static bool SendMsgByIDs(List<string> IDList, string msg, bool addMsg, ref string excpetion)
        {
            return true;
        }
    }
}
