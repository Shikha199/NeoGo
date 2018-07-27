using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MaheshAF18.UIControlHelper.UILayout;
using System.Web.Security;
using System.Data;

namespace JEMEA.AI.LayoutEnterprise
{
    public partial class MPEA : Mahesh_MasterPage
    {
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;

        protected void Page_Init(object sender, EventArgs e)
        {
            // The code below helps to protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set Anti-XSRF token
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            }
            else
            {
                // Validate the Anti-XSRF token
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Contents.Count > 0)
            {
                MyMenu.Items.Clear();
                MyMenu = GenerateMainMenu(MyMenu);
                SetUI_Heading();
            }

            if (!IsPostBack)
            {

            }
        }
        public Menu GenerateMainMenu(Menu MyMenu)
        {
            try
            {
                MyMenu.Items.Clear();
                if (SessionUserData.AppInfo.ModuleID > 0)
                {
                    
                    string strMenuString = Get_Menu_SQL();
                    DataTable DT_Menu = new DataTable();
                    DT_Menu = MaheshAF18.Application.MEF.DA_GetDataTable(strMenuString);
                    DataView DT_Menu_View = new DataView(DT_Menu);
                    DT_Menu_View.RowFilter = " AParent  =0  ";
                    foreach (DataRowView row in DT_Menu_View)
                    {
                        MenuItem menuItem = new MenuItem(row["MDBSC_Menu_Menu"].ToString(), row["M_RT_AppMenu_ID"].ToString());
                        menuItem.NavigateUrl = row["URL"].ToString();
                        MyMenu.Items.Add(menuItem);
                        AddChildItems(DT_Menu, menuItem);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return MyMenu;

        }
        private void AddChildItems(DataTable DT_Menu, MenuItem MenuItem)
        {
            DataView Item_View = new DataView(DT_Menu);
            Item_View.RowFilter = "AParent='" + MenuItem.Value + "'";
            foreach (DataRowView ChildView in Item_View)
            {
                MenuItem childItem = new MenuItem(ChildView["MDBSC_Menu_Menu"].ToString(), ChildView["M_RT_AppMenu_ID"].ToString());
                childItem.NavigateUrl = ChildView["URL"].ToString();
                MenuItem.ChildItems.Add(childItem);
                AddChildItems(DT_Menu, childItem);
            }
        }
        private void SetUI_Heading()
        {
            if (SessionUserData.UserData == null)
            {
                //Response.Redirect("Login.aspx");
            }
            else
            {
              //  tr_CompanyName.InnerHtml = "Company : " + SessionUserData.Company.CompanyName;
                tr_CompanyName.Text = "Company : " + SessionUserData.Company.CompanyName;
               
                tr_YearDesc.InnerHtml = "Year : " + SessionUserData.Company.YearDesc;
                               
                tr_UserName.InnerHtml = "Welcome : " + SessionUserData.UserData.UserName;
              //  App_DiaplayName.InnerHtml =   SessionUserData.Company.CompanyName + " - " + SessionUserData.AppInfo.ModuleName ;

                if (SessionUserData.UserData.TypeDesc == "SA")
                {
                  
                 
                 //   tr_Feedback.PostBackUrl = "~/AI/Utility/AppFeedback.aspx";
                }
                else
                {
                    tr_CompanyName.Enabled = false;
                  
                 //   tr_Feedback.Enabled = false;
                }
                 
            }




        }
        private string Get_Menu_SQL()
        {
            string strMenuString = "";
            try
            {
                
                if (SessionUserData.AppInfo.ModuleID < 0)
                {
                    SessionUserData.AppInfo.ModuleID = -1 * SessionUserData.AppInfo.ModuleID;
                }

                string var_ModuleFor = SessionUserData.AppInfo.ModuleFor;
                string var_ModuleID = SessionUserData.AppInfo.ModuleID.ToString();


                if (SessionUserData.UserData.TypeDesc == "SA")
                {
                  
                    
                    if (SessionUserData.AppInfo.IsBranchApp == "No")
                    {
                        var_ModuleFor = "'SA','HO'";
                        var_ModuleID = "1,2";
                    }
                    if (SessionUserData.AppInfo.IsBranchApp == "Yes")
                    {
                        var_ModuleFor = "'WAU'";
                        var_ModuleID = "3";
                    }
                    
                    strMenuString = " SELECT CC.M_RT_AppMenu_ID,CC.MDBSC_Menu_For,CC.MDBSC_Menu_Menu,CC.MDBSC_Menu_Level,CC.MDBSC_Menu_ParentID AParent, " +
                                   " CASE when CC.MDBSC_Menu_Url='#'  then '' else (CC.MDBSC_Menu_Url +'?ID='+convert(varchar,CC.M_RT_AppMenu_ID)) end  URL, " +
                                   " CC.MDBSC_Menu_SerialNo,CC.MDBSC_Menu_IsShow,CC.MDBSC_RowStatus " +
                                   " FROM  AAA_M_RT_App_Menu_UserPermission AA " +
                                   " INNER JOIN AAA_M_RT_App_User BB ON BB.M_RT_User_ID=AA.FK_M_RT_User_ID " +
                                   " INNER JOIN  AAA_M_RT_App_Menu   CC ON CC.M_RT_AppMenu_ID=AA.FK_M_RT_AppMenu_ID " +
                                   " INNER JOIN  AAA_M_RT_App_Module DD ON DD.M_RT_AM_ID=CC.FK_MDBSC_Menu_ModuleID " +
                                   " WHERE DD.MDBSC_App_Module_For IN  (" + var_ModuleFor + " ) " +
                                   " AND   DD.M_RT_AM_ID IN (" + var_ModuleID + " ) " +
                                   " AND   BB.M_RT_User_ID='" + SessionUserData.UserData.UserID + "' " +
                                   " AND   AA.MDBSC_App_UserRolePermissionVal='1111111' " +
                                   " AND CC.MDBSC_Menu_IsShow='Yes' " +
                                   " ORDER BY CC.FK_MDBSC_Menu_ModuleID ASC ,CC.MDBSC_Menu_SerialNo ASC ";

                }

                if (SessionUserData.UserData.TypeDesc == "TG")
                {
                    strMenuString = " SELECT CC.M_RT_AppMenu_ID,CC.MDBSC_Menu_For,CC.MDBSC_Menu_Menu,CC.MDBSC_Menu_Level,CC.MDBSC_Menu_ParentID AParent, " +
                                  " CASE when CC.MDBSC_Menu_Url='#'  then '' else (CC.MDBSC_Menu_Url +'?ID='+convert(varchar,CC.M_RT_AppMenu_ID)) end  URL, " +
                                  " CC.MDBSC_Menu_SerialNo,CC.MDBSC_Menu_IsShow,CC.MDBSC_RowStatus " +
                                  " FROM  AAA_M_RT_App_Menu_UserPermission AA " +
                                  " INNER JOIN AAA_M_RT_App_User BB ON BB.M_RT_User_ID=AA.FK_M_RT_User_ID " +
                                  " INNER JOIN  AAA_M_RT_App_Menu   CC ON CC.M_RT_AppMenu_ID=AA.FK_M_RT_AppMenu_ID " +
                                  " INNER JOIN  AAA_M_RT_App_Module DD ON DD.M_RT_AM_ID=CC.FK_MDBSC_Menu_ModuleID " +
                                  " WHERE DD.MDBSC_App_Module_For='" + var_ModuleFor + "' " +
                                  " AND   DD.M_RT_AM_ID='" + var_ModuleID + "' " +
                                  " AND   BB.M_RT_User_ID='" + SessionUserData.UserData.UserID + "' " +
                                  " AND   AA.MDBSC_App_UserRolePermissionVal='1111111' " +
                                  " AND CC.MDBSC_Menu_IsShow='Yes' " +
                                  " ORDER BY CC.FK_MDBSC_Menu_ModuleID ASC ,CC.MDBSC_Menu_SerialNo ASC ";

                }

                if (SessionUserData.UserData.TypeDesc == "WAU")
                {
                    strMenuString = " SELECT CC.M_RT_AppMenu_ID,CC.MDBSC_Menu_For,CC.MDBSC_Menu_Menu,CC.MDBSC_Menu_Level,CC.MDBSC_Menu_ParentID AParent, " +
                                    " CASE when CC.MDBSC_Menu_Url='#'  then '' else (CC.MDBSC_Menu_Url +'?ID='+convert(varchar,CC.M_RT_AppMenu_ID)) end  URL, " +
                                    " CC.MDBSC_Menu_SerialNo,CC.MDBSC_Menu_IsShow,CC.MDBSC_RowStatus " +
                                    " FROM  AAA_M_RT_App_Menu_UserPermission AA " +
                                    " INNER JOIN AAA_M_RT_App_User BB ON BB.M_RT_User_ID=AA.FK_M_RT_User_ID " +
                                    " INNER JOIN  AAA_M_RT_App_Menu   CC ON CC.M_RT_AppMenu_ID=AA.FK_M_RT_AppMenu_ID " +
                                    " INNER JOIN  AAA_M_RT_App_Module DD ON DD.M_RT_AM_ID=CC.FK_MDBSC_Menu_ModuleID " +
                                    " WHERE DD.MDBSC_App_Module_For='" + var_ModuleFor + "' " +
                                    " AND   DD.M_RT_AM_ID='" + var_ModuleID + "' " +
                                    " AND   BB.M_RT_User_ID='" + SessionUserData.UserData.UserID + "' " +
                                    " AND   AA.MDBSC_App_UserRolePermissionVal='1111111' " +
                                    " AND CC.MDBSC_Menu_IsShow='Yes' " +
                                    " ORDER BY CC.FK_MDBSC_Menu_ModuleID ASC , CC.MDBSC_Menu_SerialNo ASC ";

                }



                return strMenuString;
            }
            catch
            {
                return strMenuString;
            }

           
        }
    }
}