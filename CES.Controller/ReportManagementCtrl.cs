using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CES.DataStructure;

namespace CES.Controller
{
    public class ReportManagementCtrl
    {
        /// <summary>
        /// 根据ID查询述职报告，成功返回true，否则返回false
        /// </summary>
        /// <param name="report">述职报告</param>
        /// <param name="id">指定的ID</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetReportByID(ref string report, string id, ref string exception)
        {
            report = "gewagewga<b>gewagewga<br>geowpgaj<i>gewadca</i><br></b>";
            return true;
        }

        /// <summary>
        /// 更新指定ID的述职报告，成功返回true，否则返回false
        /// </summary>
        /// <param name="id"></param>
        /// <param name="report"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool UpdateReportByID(string id, string report, ref string exception)
        {
            return true;
        }
    }
}
