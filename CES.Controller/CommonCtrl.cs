using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CES.DataStructure;

namespace CES.Controller
{
    public class CommonCtrl
    {
        /// <summary>
        /// 查询当前考评状态，成功返回true，否则返回false
        /// </summary>
        /// <param name="evaluationStage">当前考评状态</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetCurrentStage(ref EvaluationStage evaluationStage, ref string exception)
        {
            evaluationStage = EvaluationStage.STARTED;
            return true;
        }

        /// <summary>
        /// 获取职务ID名称字典
        /// </summary>
        /// <param name="idNameDic"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetJobIDNameDic(ref Dictionary<string, string> idNameDic, ref string exception)
        {
            idNameDic.Add("01", "医务科科长");
            idNameDic.Add("02", "门诊办公室主任");
            idNameDic.Add("03", "口腔科主任");
            idNameDic.Add("04", "预防保健科科长");
            idNameDic.Add("05", "三楼病区护士长");
            return true;
        }
    }
}
