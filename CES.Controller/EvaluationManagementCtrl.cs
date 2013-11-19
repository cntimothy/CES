using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CES.DataStructure;

namespace CES.Controller
{
    public class EvaluationManagementCtrl
    {
        /// <summary>
        /// 获取所有被考评人信息，查询成功且不为空返回true，否则返回false
        /// 如果考评的当前状态不是已开始，则返回空table
        /// </summary>
        /// <param name="table"></param>
        /// <param name="evaluatorID">考评人ID</param>
        /// <param name="exception"></param>
        public static bool GetAllForEvaluate(ref DataTable table, string evaluatorID, ref string exception)
        {
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Sex");
            table.Columns.Add("Job");
            table.Columns.Add("Status");

            table.Rows.Add("0001", "高1", "男", "职务123", "已完成");
            table.Rows.Add("0001", "高1", "男", "职务123", "已完成");
            table.Rows.Add("0001", "高1", "男", "职务123", "已完成");
            table.Rows.Add("0001", "高1", "男", "职务123", "已完成");
            table.Rows.Add("0001", "高1", "男", "职务123", "已完成");
            table.Rows.Add("0001", "高1", "男", "职务123", "已完成");
            table.Rows.Add("0001", "高1", "男", "职务123", "未完成");
            table.Rows.Add("0001", "高1", "男", "职务123", "未完成");
            table.Rows.Add("0001", "高1", "男", "职务123", "未完成");
            table.Rows.Add("0001", "高1", "男", "职务123", "未完成");
            table.Rows.Add("0001", "高1", "男", "职务123", "未完成");
            table.Rows.Add("0001", "高1", "男", "职务123", "未完成");
            table.Rows.Add("0001", "高1", "男", "职务123", "已提交");
            table.Rows.Add("0001", "高1", "男", "职务123", "已提交");
            table.Rows.Add("0001", "高1", "男", "职务123", "已提交");
            table.Rows.Add("0001", "高1", "男", "职务123", "已提交");
            table.Rows.Add("0001", "高1", "男", "职务123", "已提交");
            table.Rows.Add("0001", "高1", "男", "职务123", "已提交");
            table.Rows.Add("0001", "高1", "男", "职务123", "已提交");
            return true;
        }

        /// <summary>
        /// 根据ID查询考评表（包含分数），查询成功返回true，否则返回false
        /// </summary>
        /// <param name="evaluateTbl">考评表（包含分数）</param>
        /// <param name="evaluatorID">考评人ID</param>
        /// <param name="evaluatedID">被考评人ID</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetEvaluateTblByID(ref EvaluateTbl evaluateTbl, string evaluatorID, string evaluatedID, ref string exception)
        {
            evaluateTbl.KeyResponse.Add(new Quota("组织纪律", new string[] { "1、不迟到、早退、串岗、离岗。2、服从和完成院领导下达的工作任务。3、仪表端庄，穿着整齐，佩戴胸卡。4、参加院部组织的业务学习、政治学习及其它集体活动。5、相互尊重，团结协作，同事关系融洽。" }, 52));
            evaluateTbl.KeyResponse.Add(new Quota("规章制度", new string[] { "1、严格执行首诊负责制。2、严格执行会诊制度及疑难病例讨论制度。3、严格执行门诊手册书写制度，每个门诊病人均需书写门诊手册。4、严格执行转诊制度，转诊病人必须是经本院相关检查后无法确诊或无法治疗，经主治以上医师会诊同意后方能转诊。5、落实其他相关制度(如传染病登记报告等)。工作认真负责，杜绝差错事故。" }, 85));
            evaluateTbl.KeyResponse.Add(new Quota("诊疗规范", new string[] { "1、处方书写合格率100%。2、检查合理，做到不漏检、不乱检；申请单书写内容齐全，目的要求明确，字体清楚。3、用药规范合理，无大处方，滥用药现象，严格控制药品收入比例。4、积极、合理收住病人，对有指征入院的病人要收到相关科室住院，不得截留病人延误病情。" }, -1));

            evaluateTbl.KeyQualify.Add(new Quota("专业知识", new string[] { "精通本岗位工作所需要的相关专业知识，理论、实践经验丰富，并能指导他人进行工作，知识面广", "掌握本岗位工作所需要的专业知识，具有一定的理论实践经验，能运用掌握的知识指导本职工作，知识面较广", "基本熟悉本岗位工作所需要的相关知识，需要在别人的指导下完成工作", "对本岗位所需要的专业知识不太熟悉，经常需要指导" }, 86));
            evaluateTbl.KeyQualify.Add(new Quota("人际交往", new string[] { "对人际交往保持高度的兴趣，能够赢得他人的尊重和信赖，从而赢得良好的人际交往氛围", "对人际交往有较高兴趣，能够赢得他人的尊重和信赖，能够和人建立良好的人际关系", "对人际交往有兴趣，通过努力能够与人建立人际关系", "性格较孤僻，不宜与人沟通，难以与人建立关系" }, 86));
            evaluateTbl.KeyQualify.Add(new Quota("表达能力", new string[] { "准确地以口头、书面等方式进行工作部署或有效沟通，能快速把握工作要领并礼貌用语，态度亲善", "能比较准确的以口头或书面形式进行有效沟通，能掌握工作要领并礼貌用语,态度亲善", "能进行口头或书面沟通,通常有明显沟通效果,能使用礼貌用语且态度亲善", "难以进行有效沟通,不注意使用礼貌用语且态度差" }, -1));

            evaluateTbl.KeyAttitude.Add(new Quota("进取心", new string[] { "有强烈的使命感和事业心，主动迎接工作挑战", "具备较强的事业心，坚持学习吸收新知识", "具有一定的事业心，能主动学习，注重自己能力提高", "满足现状，局限于完成现有工作" }, 78));
            evaluateTbl.KeyAttitude.Add(new Quota("主动性及执行力", new string[] { "能够认真主动地开展工作、执行领导的工作安排，积极解决问题，工作效果很好", "能够执行领导的工作安排，并能在规定的时间内完成，效果较好", "能够执行领导的工作安排，通常能在规定的时间内完成", "经常不接受领导安排的工作或越级汇报；阳奉阴违、影响部门工作开展；工作需经常督促才能勉强完成" }, 80));

            evaluateTbl.Response.Add(new Quota("组织纪律", new string[] { "1、不迟到、早退、串岗、离岗。2、服从和完成院领导下达的工作任务。3、仪表端庄，穿着整齐，佩戴胸卡。4、参加院部组织的业务学习、政治学习及其它集体活动。5、相互尊重，团结协作，同事关系融洽。" }, 52));
            evaluateTbl.Response.Add(new Quota("规章制度", new string[] { "1、严格执行首诊负责制。2、严格执行会诊制度及疑难病例讨论制度。3、严格执行门诊手册书写制度，每个门诊病人均需书写门诊手册。4、严格执行转诊制度，转诊病人必须是经本院相关检查后无法确诊或无法治疗，经主治以上医师会诊同意后方能转诊。5、落实其他相关制度(如传染病登记报告等)。工作认真负责，杜绝差错事故。" }, 85));
            evaluateTbl.Response.Add(new Quota("诊疗规范", new string[] { "1、处方书写合格率100%。2、检查合理，做到不漏检、不乱检；申请单书写内容齐全，目的要求明确，字体清楚。3、用药规范合理，无大处方，滥用药现象，严格控制药品收入比例。4、积极、合理收住病人，对有指征入院的病人要收到相关科室住院，不得截留病人延误病情。" }, -1));

            evaluateTbl.Qualify.Add(new Quota("专业知识", new string[] { "精通本岗位工作所需要的相关专业知识，理论、实践经验丰富，并能指导他人进行工作，知识面广", "掌握本岗位工作所需要的专业知识，具有一定的理论实践经验，能运用掌握的知识指导本职工作，知识面较广", "基本熟悉本岗位工作所需要的相关知识，需要在别人的指导下完成工作", "对本岗位所需要的专业知识不太熟悉，经常需要指导" }, 86));
            evaluateTbl.Qualify.Add(new Quota("人际交往", new string[] { "对人际交往保持高度的兴趣，能够赢得他人的尊重和信赖，从而赢得良好的人际交往氛围", "对人际交往有较高兴趣，能够赢得他人的尊重和信赖，能够和人建立良好的人际关系", "对人际交往有兴趣，通过努力能够与人建立人际关系", "性格较孤僻，不宜与人沟通，难以与人建立关系" }, 86));
            evaluateTbl.Qualify.Add(new Quota("表达能力", new string[] { "准确地以口头、书面等方式进行工作部署或有效沟通，能快速把握工作要领并礼貌用语，态度亲善", "能比较准确的以口头或书面形式进行有效沟通，能掌握工作要领并礼貌用语,态度亲善", "能进行口头或书面沟通,通常有明显沟通效果,能使用礼貌用语且态度亲善", "难以进行有效沟通,不注意使用礼貌用语且态度差" }, -1));

            evaluateTbl.Attitude.Add(new Quota("进取心", new string[] { "有强烈的使命感和事业心，主动迎接工作挑战", "具备较强的事业心，坚持学习吸收新知识", "具有一定的事业心，能主动学习，注重自己能力提高", "满足现状，局限于完成现有工作" }, 78));
            evaluateTbl.Attitude.Add(new Quota("主动性及执行力", new string[] { "能够认真主动地开展工作、执行领导的工作安排，积极解决问题，工作效果很好", "能够执行领导的工作安排，并能在规定的时间内完成，效果较好", "能够执行领导的工作安排，通常能在规定的时间内完成", "经常不接受领导安排的工作或越级汇报；阳奉阴违、影响部门工作开展；工作需经常督促才能勉强完成" }, 80));

            evaluateTbl.Reject.Add(new Quota("严重违反规章制度", new string[] { "累计旷工3天以上的；违背职业道德，向病人及家属收取红包；严重失职，营私舞弊，给本单位造成3000元以上经济损失或者其它严重后果的；被依法追究刑事责任的" }, -1));
            evaluateTbl.Reject.Add(new Quota("其他", new string[] { "" }, -1));
            return true;
        }

        /// <summary>
        /// 更新指定ID被考评人的分数，更新成功返回true，否则返回false
        /// </summary>
        /// <param name="evaluateTbl">包含分数的考评表</param>
        /// <param name="evaluatorID">考评人ID</param>
        /// <param name="evaluatedID">被考评人ID</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool UpdateScoreByID(EvaluateTbl evaluateTbl, string evaluatorID, string evaluatedID, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 提交指定考评人的所有分数
        /// </summary>
        /// <param name="evaluatorID"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool SubmitScoreByID(string evaluatorID, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 获取所有被考评人信息，查询成功且不为空返回true，否则返回false
        /// 如果考评的当前状态不是已开始，则返回空table
        /// </summary>
        /// <param name="table">(ID, Name, Sex, Job, Leader, Cadres, People, Sum)</param>
        /// <param name="excpetion"></param>
        /// <returns></returns>
        public static bool GetAllForCheck(ref DataTable table, ref string excpetion)
        {
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Sex");
            table.Columns.Add("Job");
            table.Columns.Add("Leader");
            table.Columns.Add("Cadres");
            table.Columns.Add("People");
            table.Columns.Add("Sum");

            table.Rows.Add("0001", "高1", "男", "职务123", "85", "28", "86", "45");
            table.Rows.Add("0001", "高1", "男", "职务123", "85", "28", "86", "45");
            table.Rows.Add("0001", "高1", "男", "职务123", "85", "28", "86", "45");
            table.Rows.Add("0001", "高1", "男", "职务123", "85", "28", "86", "45");
            table.Rows.Add("0001", "高1", "男", "职务123", "85", "28", "86", "45");
            table.Rows.Add("0001", "高1", "男", "职务123", "85", "28", "86", "45");
            table.Rows.Add("0001", "高1", "男", "职务123", "85", "28", "86", "45");
            table.Rows.Add("0001", "高1", "男", "职务123", "85", "28", "86", "45");
            table.Rows.Add("0001", "高1", "男", "职务123", "85", "28", "86", "45");
            table.Rows.Add("0001", "高1", "男", "职务123", "85", "28", "86", "45");
            table.Rows.Add("0001", "高1", "男", "职务123", "85", "28", "86", "45");
            table.Rows.Add("0001", "高1", "男", "职务123", "85", "28", "86", "45");
            table.Rows.Add("0001", "高1", "男", "职务123", "85", "28", "86", "45");
            table.Rows.Add("0001", "高1", "男", "职务123", "85", "28", "86", "45");
            table.Rows.Add("0001", "高1", "男", "职务123", "85", "28", "86", "45");
            table.Rows.Add("0001", "高1", "男", "职务123", "85", "28", "86", "45");
            table.Rows.Add("0001", "高1", "男", "职务123", "85", "28", "86", "45");
            table.Rows.Add("0001", "高1", "男", "职务123", "85", "28", "86", "45");
            table.Rows.Add("0001", "高1", "男", "职务123", "85", "28", "86", "45");
            return true;
        }

        /// <summary>
        /// 获取指定ID的详细分数
        /// </summary>
        /// <param name="scoreList">详细分数列表</param>
        /// <param name="id">被考评人ID</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetScoresByID(ref List<int> scoreList, string id, ref string exception)
        {
            scoreList.AddRange(new int[] { 52, 56, 85, 52, 56, 85, 52, 56, 85, 52, 56, 85, 52, 56, 85, 52, 56, 85, 52, 56, 85, 52, 56, 85, 52, 56, 85, 52, 56, 85, 52, 56, 85});
            return true;
        }
    }
}
