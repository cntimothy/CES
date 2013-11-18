using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CES.DataStructure
{
    public class Quota
    {
        #region Private Field
        string title;
        string[] content;
        int score;
        #endregion

        #region Public Field
        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        /// <summary>
        /// 指标内容
        /// </summary>
        public string[] Content
        {
            get { return content; }
            set { content = value; }
        }

        /// <summary>
        /// 分数
        /// </summary>
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// 如果content的数量不为1或者4，抛出Exception
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="content">指标内容</param>
        /// <param name="score">分数（为-1表示尚没有分数）</param>
        public Quota(string title, string[] content, int score)
        {
            if (content.Length == 1)
            {
                this.title = title;
                this.content = new string[1];
                this.content[0] = content[0];
                this.score = score;
            }
            else if (content.Length == 4)
            {
                this.title = title;
                this.content = new string[4];
                for (int i = 0; i < 4; i++)
                {
                    this.content[i] = content[i];
                }
                this.score = score;
            }
            else 
            {
                Exception e = new Exception("指标数目错误");
                throw e;
            }
        }
        #endregion

    }

    public class EvaluateTbl
    {
        #region Private Field
        List<Quota> keyResponse;
        List<Quota> keyQualify;
        List<Quota> keyAttitude;
        List<Quota> response;
        List<Quota> qualify;
        List<Quota> attitude;
        List<Quota> reject;
        #endregion

        #region Public Field
        /// <summary>
        /// 关键岗位职责指标
        /// </summary>
        public List<Quota> KeyResponse
        {
            get { return keyResponse; }
            set { keyResponse = value; }
        }

        /// <summary>
        /// 关键岗位胜任能力指标
        /// </summary>
        public List<Quota> KeyQualify
        {
            get { return keyQualify; }
            set { keyQualify = value; }
        }

        /// <summary>
        /// 关键工作态度指标
        /// </summary>
        public List<Quota> KeyAttitude
        {
            get { return keyAttitude; }
            set { keyAttitude = value; }
        }

        /// <summary>
        /// 岗位职责指标
        /// </summary>
        public List<Quota> Response
        {
            get { return response; }
            set { response = value; }
        }

        /// <summary>
        /// 岗位胜任能力指标
        /// </summary>
        public List<Quota> Qualify
        {
            get { return qualify; }
            set { qualify = value; }
        }

        /// <summary>
        /// 工作态度指标
        /// </summary>
        public List<Quota> Attitude
        {
            get { return attitude; }
            set { attitude = value; }
        }

        /// <summary>
        /// 否决指标
        /// </summary>
        public List<Quota> Reject
        {
            get { return reject; }
            set { reject = value; }
        }
        #endregion

        #region Constructor
        public EvaluateTbl()
        { 
            keyResponse = new List<Quota>();
            keyQualify = new List<Quota>();
            keyAttitude = new List<Quota>();
            response = new List<Quota>();
            qualify = new List<Quota>();
            attitude = new List<Quota>();
            reject = new List<Quota>();
        }
        #endregion


    }
}
