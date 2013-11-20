using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CES.Controller;

namespace CES.UI.Pages.AccountManagement
{
    public partial class ChangePasswd : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //将UserID写入ViewState
                WriteUserIDToViewState();
            }
        }

        protected void Button_ChangePassword_Click(object sender, EventArgs e)
        {
            string exception = "";
            string oldPassword = TextBox1.Text.Trim();
            string newPassword = TextBox2.Text.Trim();
            if (oldPassword.Length != 6 || newPassword.Length != 6)
            {
                showError("修改失败！", "密码必须六位！");
                return;
            }
            if (checkNull(oldPassword, newPassword))
            {
                string id = Session["UserID"].ToString();
                if (AccountManagementCtrl.ChangePassword(id, newPassword, oldPassword, ref exception))
                {
                    showInformation("修改成功！");
                }
                else
                {
                    showError("修改失败！", exception);
                }
            }
        }

        private bool checkNull(params string[] items)
        {
            foreach (string item in items)
            {
                if (item == "")
                {
                    return false;
                }
            }
            return true;
        }
    }
}