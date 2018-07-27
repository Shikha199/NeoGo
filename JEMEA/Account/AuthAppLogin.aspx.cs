using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MaheshAF18.UIControlHelper.UILayout;


namespace JEMEA.Account
{
    public partial class AuthAppLogin : Mahesh_Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    AuthenticateApplication();
                }
            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary(ex.Message);
            }
        }

        private void AuthenticateApplication()
        {
            try
            {

                //Check Is FIrst Session  Details
                //Check Company Details
                //Check Branch Details
                //Check Accounting  Details
                //Check Module  Details
                 
                Response.Redirect(SessionUserData.AppInfo.ModuleDashboardPage, false);

            }
            catch
            {

                SessionUserData.AppInfo.UrlAuthRedirectMsg_A = "authentication failed";
                Response.Redirect(SessionUserData.AppInfo.LoginPage, false);
            }
        }
    }
}