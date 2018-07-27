using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MABL.ATDataModal;
using MaheshAF18.Application;
using MaheshAF18.Utility;
using MaheshAF18.UIControlHelper.UILayout;
using MABL.MCore.STDataModal;


namespace JEMEA.Master
{
    public partial class User : Mahesh_Page
    {

        AAA_M_RT_App_UserBO Obj_RT_AppUser;
        protected void Page_Load(object sender, EventArgs e)
        {

            PageMenuID = Request.QueryString["ID"];
            //SessionData.UserAccess.MenuID = PageMenuID;

            Obj_RT_AppUser = new AAA_M_RT_App_UserBO();
            SetControlType();


            if (!IsPostBack)
            {
                MaheshAF18.UIControlHelper.GenricControl.GetOperatorList(ddOperator);
                MaheshAF18.UIControlHelper.GenricControl.GetFieldListByGrid(gvList, ddSearchBy);                
              
                FillDropdown();
                InitializeControls();
                RefreshGrid();
                MultiView1.ActiveViewIndex = 0;
            }
        }
        #region "Search"
        protected void imgButtonGo_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            try
            {
                string SearchCriteria = "";
                SearchCriteria = ddSearchBy.Text + "|" + ddOperator.Text + (searchvalue.Text.Length > 0 ? "|" : "") + searchvalue.Text;
                RefreshGrid(SearchCriteria);
            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary(ex.Message);
            }
        }
        #endregion
        #region "Page Setting"
        private void SetControlType()
        {
            try
            {
               // btnListClose.Attributes.Add("onClick", "self.location.replace(\"" + Strings.Replace(SessionUserData.AdditionalInfo.DashboardPage, "~/", "") + "\"); return false;");


               


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region "Fill Drop Down"
        private void FillDropdown()
        {
          
             
        }
        #endregion
        #region "Refrish Grid Functions"
        private void RefreshGrid(string SearchCriteria = "")
        {
            try
            {
                MaheshAF18.Application.MEF.DA_ExecuteQuery("AAA_M_RSP_App_Generate_MenuPermission");
                DataTable dt = default(DataTable);
                dt = Obj_RT_AppUser.List(0, SearchCriteria);
                if (dt.Rows.Count > 0)
                {
                    gvList.DataSource = dt;
                    gvList.DataBind();
                    if (dt.Rows.Count < 50)
                    {
                        Msg_RCNT.Text = "Showing " + dt.Rows.Count + " Records  ";
                    }
                    else
                    {
                        Msg_RCNT.Text = "Showing 50 Of " + dt.Rows.Count + " Records  ";
                    }
                }
                else
                {
                    gvList.DataSource = null;
                    gvList.DataBind();
                    Msg_RCNT.Text = " No Records Found";
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        #endregion
        #region "Click New List Close"
        protected void btnClose_Click(object sender, System.EventArgs e)
        {
            try
            {
                Response.Redirect(SessionUserData.AppInfo.DefaultRedirect);


            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary(ex.Message);
            }
        }
        protected void LnkNew_Click(object sender, System.EventArgs e)
        {
            try
            {
                InitializeControls();
                MultiView1.ActiveViewIndex = 1;
            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary(ex.Message);
            }
        }
        protected void btnBack_Click(object sender, System.EventArgs e)
        {
            try
            {
                InitializeControls();
                RefreshGrid();
                MultiView1.ActiveViewIndex = 0;
            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary(ex.Message);
            }
        }

        #endregion
        #region "Grid Function"
        protected void gvList_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            try
            {
                gvList.PageIndex = e.NewPageIndex;
                RefreshGrid();
            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary(ex.Message);
            }
        }

        #endregion
        #region "InitializeControls"
        private void InitializeControls()
        {
            try
            {
                M_RT_User_ID.Text = "0";
                MDBSC_App_User_LoginID.Text = "";
                MDBSC_App_User_FName.Text = "";
                MDBSC_App_User_Password.Text = "";
                ConfirmPassword.Text = "";
               
                Rec_Status.SelectedIndex = 0;
           
               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
        #region "Save"
        protected void btnsave_Click(object sender, System.EventArgs e)
        {
            try
            {

                if (SQLManager.CheckDuplicateRecord("AAA_M_RT_App_User", "M_RT_User_ID", Convert.ToInt32("0" + M_RT_User_ID.Text), "MDBSC_App_User_LoginID", MDBSC_App_User_LoginID.Text, ""))
                {
                    ErrorMessage = ErrorMessage + "User ID Already Exist.<br>";
                }


                if (MDBSC_App_User_LoginID.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "User Login Id Cannot Be Blank.<br>";
                }


                if (MDBSC_App_User_FName.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "User Name Cannto Be Blank.<br>";
                }
                if (MDBSC_App_User_Password.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Password Cannot Be Blank.<br>";
                }
                else
                {
                    if (MDBSC_App_User_Password.Text.Length < 4)
                    {
                        ErrorMessage = ErrorMessage + "Minimum 4 Character Required For Password.<br>";
                    }
                    if (MDBSC_App_User_Password.Text != ConfirmPassword.Text)
                    {
                        ErrorMessage = ErrorMessage + "Password And Confirm Password Did Not Match.<br>";
                    }

                }


              
               
                
              
                if (ErrorMessage.Length == 0)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (Convert.ToInt32(M_RT_User_ID.Text) == 0)
                        {
                            Obj_RT_AppUser.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                            Obj_RT_AppUser.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName; 
                           
                        }
                        SetValuesToBO();
                        ErrorMessage = Obj_RT_AppUser.Insert_Update(Obj_RT_AppUser);
                        M_RT_User_ID.Text = ErrorMessage.Substring((ErrorMessage.IndexOf("|") + 1), (ErrorMessage.Length - ErrorMessage.IndexOf("|") - 1));
                        ErrorMessage = ErrorMessage.Substring((0), (ErrorMessage.IndexOf("|")));
                        scope.Complete();
                    }
                     
                    SetValueToControls_Edit(Convert.ToInt32("0" + M_RT_User_ID.Text));
                    DisplayCustomMessageSummary(ErrorMessage);
                }
                else
                {
                    DisplayCustomMessageSummary(ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary("Failed Save Data");
            }

        }
        #endregion 
        #region "SetValue"
        private void SetValuesToBO()
        {
            try
            {

                Obj_RT_AppUser.M_RT_User_ID = Convert.ToInt16("0" + M_RT_User_ID.Text);
                Obj_RT_AppUser.FK_M_RT_CMP_ID = 1;  
                Obj_RT_AppUser.FK_M_RT_CMP_BR_ID = 1;  
                Obj_RT_AppUser.FK_M_RT_UserType_ID = 3;
                Obj_RT_AppUser.FK_M_RT_UserRole_ID =3; 
                Obj_RT_AppUser.MDBSC_App_User_LoginID = MDBSC_App_User_LoginID.Text;
                Obj_RT_AppUser.MDBSC_App_User_FName = MDBSC_App_User_FName.Text;
                Obj_RT_AppUser.MDBSC_App_User_MName = "";
                Obj_RT_AppUser.MDBSC_App_User_LName = "";
                Obj_RT_AppUser.MDBSC_App_User_Password = MaheshAF18.Application.MEF.Security_EncryptString(MDBSC_App_User_LoginID.Text + MDBSC_App_User_Password.Text);
                Obj_RT_AppUser.MDBSC_App_User_RegEmailID = "";
                Obj_RT_AppUser.MDBSC_App_User_RegMobileNo = "";
                Obj_RT_AppUser.MDBSC_App_User_Status = Rec_Status.Text;
                Obj_RT_AppUser.MDBSC_App_User_ProfileImgPath = "";
                Obj_RT_AppUser.MDBSC_RowStatus = Rec_Status.Text;
                Obj_RT_AppUser.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
                Obj_RT_AppUser.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
                Obj_RT_AppUser.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
                   
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region "EditValue"
        private void SetValueToControls_Edit(Int64 strPK)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Obj_RT_AppUser.List(strPK, "");
                InitializeControls();
                if (dt.Rows.Count > 0)
                {

                    M_RT_User_ID.Text = dt.Rows[0]["M_RT_User_ID"].ToString();
                    
                    
                   
                
                    Rec_Status.Text = dt.Rows[0]["MDBSC_RowStatus"].ToString();
                  
                     
                  
                    MDBSC_App_User_LoginID.Text = dt.Rows[0]["MDBSC_App_User_LoginID"].ToString();
                    
                    MDBSC_App_User_FName.Text = dt.Rows[0]["MDBSC_App_User_FName"].ToString();
                    
                    MDBSC_App_User_Password.Text = MaheshAF18.Application.MEF.Security_UserPassword("APPUSER", dt.Rows[0]["MDBSC_App_User_LoginID"].ToString());
                     

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
        #region "Edit Click"
        protected void lnkEdit_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            try
            {
                ImageButton lnkEdit = (ImageButton)sender;
                GridViewRow row = (GridViewRow)lnkEdit.NamingContainer;
                lnkEdit = (ImageButton)row.FindControl("lnkEdit");
                SetValueToControls_Edit(0 + Convert.ToInt32(row.Cells[0].Text));
                MultiView1.ActiveViewIndex = 1;
            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary(ex.Message);
            }

        }
        #endregion
        #region "Delete"
        
        #endregion
        #region "Row Created"

        protected void gvList_RowCreated(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.Pager)
            {
                e.Row.Cells[0].Visible = true;
            }
            if (e.Row.RowType == DataControlRowType.DataRow | e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Visible = false;

            }
        }
      
        #endregion
        #region "Row DataBound"

         
        #endregion
        #region "Click Events"

        #endregion
        #region 'Print'

        #endregion
        #region "SelectedIndexChanged"
      
        #endregion
        #region "Function"

    
    
        #endregion

    }
}