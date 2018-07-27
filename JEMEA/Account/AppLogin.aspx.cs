using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MaheshAF18.UIControlHelper.UILayout;

namespace JEMEA.Account
{
    public partial class AppLogin1 : Mahesh_Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //RegisterHyperLink.NavigateUrl = "Register.aspx";
            //OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];


            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                //  RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
            string requeststring = null;
            try
            {
                requeststring = Request.QueryString["action"].ToUpper();
            }
            catch 
            {
                requeststring = "";
            }
            if (requeststring == "LOGOUT" & !IsPostBack)
            {
                if ((SessionUserData != null))
                {
                    // Mahesh_SME.Security.UserValidation oUserLogOut = new Mahesh_SME.Security.UserValidation();
                    //   oUserLogOut.UserLoggedOut(SessionUserData.UserData.UserID, SessionUserData.UserData.SessionID, "Y", ComputerName, IPAddress, Browser);
                    Session.Clear();
                    Session.Abandon();
                }
            }

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
              Session.Clear();
              HttpRequest request = HttpContext.Current.Request;
              string strErrorMessage = "";
                if (IsValid)
                {
                    if (string.IsNullOrEmpty(userid.Text))
                    {
                        strErrorMessage = strErrorMessage + "Invalid User ID \n\n";
                    }
                    if (string.IsNullOrEmpty(Password.Text))
                    {
                        strErrorMessage = strErrorMessage + "Invalid Password \n\n";
                    }

                    if (strErrorMessage.Length == 0)
                    {
                        MaheshAF18.WebSession.SessionPageLocal ObjSessionData = new MaheshAF18.WebSession.SessionPageLocal();
                        ObjSessionData = MaheshAF18.Application.MEF.ProjectSession_AppUser(userid.Text,Password.Text,"","","","","");

                        if ((ObjSessionData.UserData.LoginStatus == true) && (ObjSessionData.Company.YearID == 1)
                            && (ObjSessionData.Company.CompanyID == 1)
                            )
                        {


                            if (ObjSessionData.UserData.TypeDesc == "SA")
                            {
                                 MaheshAF18.Application.MEF.ProjectSession_Company(SessionUserData.UserData.UserID.ToString(),
                                                                       SessionUserData.UserData.LoginID.ToString(),
                                                                       SessionUserData.UserData.UserCompanyID, 0, 0, "");
                                MaheshAF18.Application.MEF.ProjectSession_Company(SessionUserData.UserData.UserID.ToString(),
                                                                      SessionUserData.UserData.LoginID.ToString(),
                                                                      SessionUserData.UserData.UserCompanyID, SessionUserData.UserData.UserBranchID, 0, "");

                                MaheshAF18.Application.MEF.ProjectSession_AppModule(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID,
                                                                       0, SessionUserData.UserData.TypeID, SessionUserData.UserData.RoleID, SessionUserData.UserData.UserID, "SA");
 
                                Response.Redirect(SessionUserData.AppInfo.DefaultRedirect, false);    
                            }
                            if (ObjSessionData.UserData.TypeDesc == "TG")
                            {

                                MaheshAF18.Application.MEF.ProjectSession_Company(SessionUserData.UserData.UserID.ToString(),
                                                                       SessionUserData.UserData.LoginID.ToString(),
                                                                       SessionUserData.UserData.UserCompanyID, 0, 0, "");
                                MaheshAF18.Application.MEF.ProjectSession_Company(SessionUserData.UserData.UserID.ToString(),
                                                                      SessionUserData.UserData.LoginID.ToString(),
                                                                      SessionUserData.UserData.UserCompanyID, SessionUserData.UserData.UserBranchID, 0, "");

                                MaheshAF18.Application.MEF.ProjectSession_AppModule(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID,
                                                                       0, SessionUserData.UserData.TypeID, SessionUserData.UserData.RoleID, SessionUserData.UserData.UserID, "TG");

                                Response.Redirect(SessionUserData.AppInfo.DefaultRedirect);

                            }

                            if (ObjSessionData.UserData.TypeDesc == "WAU")
                            {
                                MaheshAF18.Application.MEF.ProjectSession_Company(SessionUserData.UserData.UserID.ToString(),
                                                                      SessionUserData.UserData.LoginID.ToString(),
                                                                      SessionUserData.UserData.UserCompanyID, 0, 0, "");
                                MaheshAF18.Application.MEF.ProjectSession_Company(SessionUserData.UserData.UserID.ToString(),
                                                                      SessionUserData.UserData.LoginID.ToString(),
                                                                      SessionUserData.UserData.UserCompanyID, SessionUserData.UserData.UserBranchID, 0, "");

                                MaheshAF18.Application.MEF.ProjectSession_AppModule(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID,
                                                                       0, SessionUserData.UserData.TypeID, SessionUserData.UserData.RoleID, SessionUserData.UserData.UserID,"WAU");

                                Response.Redirect(SessionUserData.AppInfo.DefaultRedirect, false);    
                            }
                            
                            
                                                   
                        }
                        else
                        {
                            strErrorMessage = "Invalid Username/Password ";
                        }
                    }
                    else
                    {
                        strErrorMessage = "Invalid Username/Password ";
                    }
                }
                DisplayCustomMessageSummary(strErrorMessage);
            }
            catch 
            {
                DisplayCustomMessageSummary("Invalid Username/Password ");
            }
        }

        

    }
}