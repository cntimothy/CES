using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CES.DataStructure;

namespace CES.Controller
{
    public class EvaluateTblManagementCtrl
    {
        /// <summary>
        /// 更新指定职务的考核表，如果没有则插入。成功返回true，否则返回false
        /// </summary>
        /// <param name="jobID">指定的职务</param>
        /// <param name="evaluateTbl">考核表</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool UpdateEvaluateTbl(string jobID, EvaluateTbl evaluateTbl, ref string exception)
        {
            return true;
        }
    }
}
