using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CES.UI.Pages.MsgManagement
{
    public partial class SendMsg : System.Web.UI.Page
    {
        #region Page Init
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Event
        /// <summary>
        /// 换页事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Grid1_PageIndexChange(object sender, FineUI.GridPageEventArgs e)
        {
            //syncSelectedRowIndexArrayToHiddenField();

            //Grid1.PageIndex = e.NewPageIndex;

            //updateSelectedRowIndexArray();

        }
        #endregion

        #region Private Method
        #endregion
    }
}