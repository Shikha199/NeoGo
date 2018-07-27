using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MABL.MCore.STDataModal;
using MaheshAF18.UIControlHelper.UILayout;
using System.Data;

namespace JEMEA.AI.AppGateway
{
    public partial class App_Module : Mahesh_Page
    {
       AAA_M_RT_App_ModuleBO Obj_RT_AppModule;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Obj_RT_AppModule = new AAA_M_RT_App_ModuleBO();
                SessionUserData.AppInfo.ModuleID = -103;
                SessionUserData.AppInfo.ModuleName = "Module Selection";
               
                if (!IsPostBack)
                {
                 
                    RefreshGrid_Module(); 
                }
            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary(ex.Message);
            }
        }

        private void RefreshGrid_Module(string SearchCriteria = "")
        {
            try
            {
                 
                DataTable dt = default(DataTable);
                dt = MaheshAF18.Application.MEF.ProjectSession_AppModule(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID,
                                                                        0, SessionUserData.UserData.TypeID, SessionUserData.UserData.RoleID, SessionUserData.UserData.UserID, SessionUserData.UserData.TypeDesc);

                if (dt.Rows.Count == 1)
                {
                    SessionUserData.AppInfo.ModuleFor = dt.Rows[0]["MDBSC_App_Module_For"].ToString();
                    SessionUserData.AppInfo.ModuleID = Convert.ToInt16("0" + dt.Rows[0]["M_RT_AM_ID"].ToString());
                    SessionUserData.AppInfo.ModuleName = dt.Rows[0]["MDBSC_App_ModuleName"].ToString();
                    SessionUserData.AppInfo.ModuleDashboardPage = dt.Rows[0]["MDBSC_App_ModuleDashboardUrl"].ToString();

                    Response.Redirect(SessionUserData.AppInfo.DefaultRedirect);
                }
                else if (dt.Rows.Count > 1)
                {

                }
                else
                {
                    Response.Redirect(SessionUserData.AppInfo.DefaultRedirect);
                    //  Response.Redirect(SessionUserData.AppInfo.DefaultRedirect);

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #region "Search"
        
        #endregion
        #region "Row Created"

      

        #endregion
        #region "Row DataBound"

     

        #endregion
        protected void btnClose_Click(object sender, System.EventArgs e)
        {
            try
            {
                Response.Redirect( SessionUserData.AppInfo.LoginPage);


            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary(ex.Message);
            }
        }

       
    }
}