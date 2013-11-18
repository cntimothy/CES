using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CES.Controller
{
    public class StaffManagementCtrl
    {
        /// <summary>
        /// 导入指定路径的Excel文件，导入成功返回true，否则返回false
        /// </summary>
        /// <param name="path">指定的路径</param>
        /// <param name="createCount">新增的记录数量</param>
        /// <param name="updateCount">更新的记录数量</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool InportExcel(string path, ref int createCount, ref int updateCount, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 删除指定id的记录，删除成功返回true，否则返回false
        /// </summary>
        /// <param name="idList">指定的id</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool DeleteByIDs(List<string> idList, ref string exception)
        {
            return true;
        }
    }
}
