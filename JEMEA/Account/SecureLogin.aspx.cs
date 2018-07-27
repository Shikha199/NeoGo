using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MaheshAF18.UIControlHelper.UILayout;

namespace JEMEA.Account
{
    public partial class SecureLogin : Mahesh_Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
              try
            {
                if (!IsPostBack)
                {
                  UserLoginRedirect();
                }
            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary(ex.Message);
            }
        }

        private void UserLoginRedirect()
        {
            try
            {
                Response.Redirect("~/AI/AppGateway/Company.aspx", false);              

            }
            catch 
            {
                 
                SessionUserData.AppInfo.UrlAuthRedirectMsg_A="authentication failed";
                Response.Redirect(SessionUserData.AppInfo.LoginPage, false);    
            }
        }

        }
    }
