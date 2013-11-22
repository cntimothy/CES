using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FineUI;
using System.Data;
using CES.DataStructure;
using CES.Controller;

namespace CES.UI.Pages.EvaluationManagement
{
    public partial class iframe_Evaluate : PageBase
    {
        #region Page Init
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                WriteUserIDToViewState();   //将UserID写入ViewState
                WriteEvaluatedIDToViewState();
                setButtonEvent();           //设置按钮事件
                loadEvaluateTbl();
            }
        }
        #endregion

        #region Event
        #endregion

        #region Prvate Method
        /// <summary>
        /// 设置按钮事件
        /// </summary>
        private void setButtonEvent()
        {
            Button_Close.OnClientClick = ActiveWindow.GetConfirmHidePostBackReference();
            Button_Close_Shadow.OnClientClick = ActiveWindow.GetConfirmHidePostBackReference();
        }

        /// <summary>
        /// 载入考核表
        /// </summary>
        private void loadEvaluateTbl()
        {
            string exception = "";
            EvaluateTbl evaluateTbl = new EvaluateTbl();
            string evaluatorID = getEvaluatorID();
            string evaluatedID = ViewState["EvaluatedID"].ToString();
            if (EvaluationManagementCtrl.GetEvaluateTblByID(ref evaluateTbl, evaluatorID, evaluatedID, ref exception))
            {
                //关键岗位职责指标
                DataTable table1 = new DataTable();
                table1.Columns.Add("Title");
                table1.Columns.Add("Quota");
                table1.Columns.Add("Score");
                foreach (Quota item in evaluateTbl.KeyResponse)
                {
                    table1.Rows.Add(item.Title, item.Content[0], item.Score);
                }
                Grid1.DataSource = table1;
                Grid1.DataBind();

                //关键岗位胜任能力指标
                DataTable table2 = new DataTable();
                table2.Columns.Add("Title");
                table2.Columns.Add("Quota1");
                table2.Columns.Add("Quota2");
                table2.Columns.Add("Quota3");
                table2.Columns.Add("Quota4");
                table2.Columns.Add("Score");
                foreach (Quota item in evaluateTbl.KeyQualify)
                {
                    table2.Rows.Add(item.Title, item.Content[0], item.Content[1], item.Content[2], item.Content[3], item.Score);
                }
                Grid2.DataSource = table2;
                Grid2.DataBind();

                //关键岗位工作态度指标
                DataTable table3 = new DataTable();
                table3.Columns.Add("Title");
                table3.Columns.Add("Quota1");
                table3.Columns.Add("Quota2");
                table3.Columns.Add("Quota3");
                table3.Columns.Add("Quota4");
                table3.Columns.Add("Score");
                foreach (Quota item in evaluateTbl.KeyAttitude)
                {
                    table3.Rows.Add(item.Title, item.Content[0], item.Content[1], item.Content[2], item.Content[3], item.Score);
                }
                Grid3.DataSource = table3;
                Grid3.DataBind();

                //岗位职责指标
                DataTable table4 = new DataTable();
                table4.Columns.Add("Title");
                table4.Columns.Add("Quota");
                table4.Columns.Add("Score");
                foreach (Quota item in evaluateTbl.Response)
                {
                    table4.Rows.Add(item.Title, item.Content[0], item.Score);
                }
                Grid4.DataSource = table4;
                Grid4.DataBind();

                //岗位胜任能力指标
                DataTable table5 = new DataTable();
                table5.Columns.Add("Title");
                table5.Columns.Add("Quota1");
                table5.Columns.Add("Quota2");
                table5.Columns.Add("Quota3");
                table5.Columns.Add("Quota4");
                table5.Columns.Add("Score");
                foreach (Quota item in evaluateTbl.Qualify)
                {
                    table5.Rows.Add(item.Title, item.Content[0], item.Content[1], item.Content[2], item.Content[3], item.Score);
                }
                Grid5.DataSource = table5;
                Grid5.DataBind();

                //岗位工作态度指标
                DataTable table6 = new DataTable();
                table6.Columns.Add("Title");
                table6.Columns.Add("Quota1");
                table6.Columns.Add("Quota2");
                table6.Columns.Add("Quota3");
                table6.Columns.Add("Quota4");
                table6.Columns.Add("Score");
                foreach (Quota item in evaluateTbl.Attitude)
                {
                    table6.Rows.Add(item.Title, item.Content[0], item.Content[1], item.Content[2], item.Content[3], item.Score);
                }
                Grid6.DataSource = table6;
                Grid6.DataBind();

                //否决指标
                DataTable table7 = new DataTable();
                table7.Columns.Add("Title");
                table7.Columns.Add("Quota");
                foreach (Quota item in evaluateTbl.Reject)
                {
                    table7.Rows.Add(item.Title, item.Content[0]);
                }
                Grid7.DataSource = table7;
                Grid7.DataBind();
                System.Web.UI.WebControls.DropDownList ddl = Grid7.Rows[0].FindControl("DropDownList_Reject") as System.Web.UI.WebControls.DropDownList;
                ddl.Visible = true;
                ddl.SelectedValue = evaluateTbl.Reject[0].Score.ToString();
            }
        }

        /// <summary>
        /// 将被考评人id写入ViewState
        /// </summary>
        private void WriteEvaluatedIDToViewState()
        {
            string evaluatedID = Request.QueryString["id"];
            ViewState["EvaluatedID"] = evaluatedID;
        }

        /// <summary>
        /// 获取考评人ID
        /// </summary>
        /// <returns></returns>
        private string getEvaluatorID()
        {
            string returnValue = "";
            try
            {
                returnValue = Session["UserID"].ToString();
            }
            catch (Exception e)
            {
                PageContext.Redirect("../../Login.aspx");
            }
            return returnValue;
        }
        #endregion
    }
}