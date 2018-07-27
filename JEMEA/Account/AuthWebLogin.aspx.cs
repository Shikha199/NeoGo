using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MaheshAF18.UIControlHelper.UILayout;


namespace JEMEA.Account
{
    public partial class AuthWebLogin : Mahesh_Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
              try
            {
                if (!IsPostBack)
                {
                  
                }
            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary(ex.Message);
            }
        }
        }
    }
