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
using System.IO;

namespace JEMEA.Master
{
    public partial class Customer : Mahesh_Page
    {
        M_AT_Mst_CustomerBO ObjAT_Cust;
        protected void Page_Load(object sender, EventArgs e)
        {
            PageMenuID = Request.QueryString["ID"];
            ObjAT_Cust = new M_AT_Mst_CustomerBO();

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
                 
                SetValueType(TextType.NumericField, MCust_Reg_Pincode);
                SetValueType(TextType.NumericField, MCust_ShippTo_Pincode);
                SetValueType(TextType.NumericField, MCust_ShippTo_CP_MobileNo);
                SetValueType(TextType.NumericField, MCust_ShippTo_Pincode);
                SetValueType(TextType.NumericField, MCust_CreditDays);
                SetValueType(TextType.DateField, RecCreatedOn);
             
                 
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
            DataTable dt = new DataTable();
            dt = MaheshAF18.Utility.M_DropDownList.Fill_Drop_Down_List("v_AAA_M_RT_GEO_State", "GStateID", "vStateDisplayName", "  ", "", "State", 0, "N", "");
            MCust_Reg_State_ID.DataSource = dt;
            MCust_Reg_State_ID.DataBind();
            MCust_ShippTo_State_ID.DataSource = dt;
            MCust_ShippTo_State_ID.DataBind();

            MCust_RegType.DataSource = MABL.APPDT.MADD.DT_Taxpayer_Type("", "", "Customer Type");
            MCust_RegType.DataBind();
        }
        #endregion
        #region "Refrish Grid Functions"
        private void RefreshGrid(string SearchCriteria = "")
        {
            try
            {

                DataTable dt = default(DataTable);
                dt = MABL.BL.AppDataModal.Get_Mst_Customer(0, "", SearchCriteria);
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
                M_Cust_ID.Text = "0";
                MCust_Code.Text = MEF.GetRefNo(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, 0, "Customer", "CUST", "CUST", "No");
                MCust_Name.Text = "";                
                MCust_Reg_Add1.Text = "";
                MCust_Reg_Add2.Text = "";
                MCust_Reg_Add3.Text = "";
              
                MCust_RegType.SelectedIndex = 0;
              
               
                MCust_CreditDays.Text = "30";
                RecCreatedOn.Text = "";
                RecCreatedUser.Text = "";                
                MCust_Primary_Contact_Designation.Text = "";
                MCust_Primary_Contact_Person.Text = "";
                MCust_Primary_CP_MobileNo.Text = "";
                
                MCust_Primary_CP_EmailID.Text = "";

            MCust_Primary_CP_PhoneNo.Text="";

            MCust_Contact_Email_Admin.Text = "";

         MCust_Contact_FaxNo.Text="";
               MCust_Contact_OfficeNo2.Text="";
               MCust_Contact_OfficeNo1.Text="";
             
                MCust_Contact_Website.Text = "";
                MCust_Reg_Country.Text = "India";
                MCust_Reg_State_ID.SelectedIndex = 0;
                MCust_Reg_City.Text = "";
                MCust_Reg_Pincode.Text = "";
             
                 MCust_BL_PANNO.Text = "";
             
                MCust_TradeName.Text="";

                MCust_ShippTo_State_ID.SelectedIndex = 0;
                MCust_ShippTo_CompanyName.Text = "";
                MCust_ShippTo_ContactPerson.Text = "";
                MCust_ShippTo_CP_MobileNo.Text = "";
                MCust_ShippTo_Add1.Text = "";
                MCust_ShippTo_Add2.Text = "";
                MCust_ShippTo_Add3.Text = "";
                MCust_ShippTo_Pincode.Text = "";
                
                MCust_ShippTo_City.Text = "";
            
                MCust_ShippTo_Country.Text = "";
                MCust_ShippTo_PANNO.Text = "";
                MCust_ShippTo_GSTNO.Text = "";
                MCust_ShippTo_ARNO.Text = "";

                MCust_BL_GSTNO.Text = "";
                
                RecCreatedOn.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
                RecCreatedUser.Text = SessionUserData.UserData.UserName;
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
                string var_GSTState = "";
                string var_StateCode = "";
                if (MCust_RegType.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Pls Select Customer Type<br>";
                }
                else
                {
                    if( (MCust_RegType.Text == "Registered Taxpayer")  || (MCust_RegType.Text == "Composite Taxpayer"))
                    {
                        if (MCust_BL_GSTNO.Text.Length != 15)
                        {
                            ErrorMessage = ErrorMessage + "Billing GST No Cannot Be Blank<br>";
                        }
                        if (MCust_ShippTo_GSTNO.Text.Length != 15)
                        {
                            ErrorMessage = ErrorMessage + "Consignee GST No Cannot Be Blank<br>";
                        }

                        if (MCust_Reg_State_ID.SelectedIndex>0)
                        {
                            if (MCust_BL_GSTNO.Text.Length > 2)
                            {
                                var_GSTState = MCust_BL_GSTNO.Text.Substring(0, 2);
                            }
                            
                            var_StateCode = MCust_Reg_State_ID.SelectedItem.Text.Substring(0, 2);
                            if (var_GSTState != var_StateCode)
                            {
                                ErrorMessage = ErrorMessage + "Invlid Billing GST No For " + MCust_Reg_State_ID.SelectedItem.Text + " .<br>";
                            }
                        }


                        if (MCust_ShippTo_State_ID.SelectedIndex > 0)
                        {
                            if (MCust_ShippTo_GSTNO.Text.Length > 2)
                            {
                                var_GSTState = MCust_ShippTo_GSTNO.Text.Substring(0, 2);
                            }

                            var_StateCode = MCust_ShippTo_State_ID.SelectedItem.Text.Substring(0, 2);
                           if (var_GSTState != var_StateCode)
                            {
                                ErrorMessage = ErrorMessage + "Invlid Consignee GST No For " + MCust_ShippTo_State_ID.SelectedItem.Text + " .<br>";
                            }
                        }


                        
                    }
                    
                    if (MCust_RegType.Text == "Unregistered")
                    {

                    }
                    

                }
                 

                if (SQLManager.CheckDuplicateRecord("M_AT_Mst_Customer", "M_Cust_ID", Convert.ToInt32("0" + M_Cust_ID.Text), "MCustCode", MCust_Code.Text, ""))
                {
                    ErrorMessage = ErrorMessage + "Customer Code Already Exist.<br>";
                }

                if (SQLManager.CheckDuplicateRecord("M_AT_Mst_Customer", "M_Cust_ID", Convert.ToInt32("0" + M_Cust_ID.Text), "MCustName", MCust_Name.Text, ""))
                {
                    ErrorMessage = ErrorMessage + "Customer Name Already Exists.<br>";
                }

                if (MCust_Code.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Customer Code No Cannot Be Blank.<br>";
                }

                if (MCust_Name.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Customer Name Cannot Be Blank.<br>";
                }
                if (MCust_TradeName.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Customer Trade Name Cannot Be Blank.<br>";
                }
                if (MCust_Reg_State_ID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Select Customer State.<br>";
                }
                

                if (MCust_ShippTo_State_ID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Select Customer Shipp To State.<br>";
                }
                

                if (ErrorMessage.Length == 0)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (Convert.ToInt32(M_Cust_ID.Text) == 0)
                        {
                            ObjAT_Cust.Fk_Company_ID = SessionUserData.Company.CompanyID;
                            ObjAT_Cust.Fk_Branch_ID = SessionUserData.Company.BranchID;
                            ObjAT_Cust.Fk_Year_ID = SessionUserData.Company.YearID;
                            ObjAT_Cust.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                            ObjAT_Cust.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName;
                            ObjAT_Cust.MCust_Code = MaheshAF18.Application.MEF.GenrateRefNo(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, 0, "Customer", "CUST", "CUST", "No", "", "", "", 0);
                        }
                        SetValuesToBO();
                        ErrorMessage = ObjAT_Cust.Insert_Update(ObjAT_Cust);
                        M_Cust_ID.Text = ErrorMessage.Substring((ErrorMessage.IndexOf("|") + 1), (ErrorMessage.Length - ErrorMessage.IndexOf("|") - 1));
                        ErrorMessage = ErrorMessage.Substring((0), (ErrorMessage.IndexOf("|")));
                        scope.Complete();
                    }

                    SetValueToControls_Edit(Convert.ToInt64(M_Cust_ID.Text));
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

        protected void btnAddressCopy_Click(object sender, System.EventArgs e)
        {
            try
            {
                MCust_ShippTo_Add1.Text = "";
                MCust_ShippTo_Add2.Text = "";
                MCust_ShippTo_Add3.Text = "";
                MCust_ShippTo_Pincode.Text = "";
                MCust_ShippTo_City.Text = "";
                MCust_ShippTo_State_ID.SelectedIndex = 0;
                MCust_ShippTo_Country.Text = "";
                MCust_ShippTo_CompanyName.Text = "";
                MCust_ShippTo_ContactPerson.Text = "";
                MCust_ShippTo_CP_MobileNo.Text = "";
                MCust_ShippTo_PANNO.Text = "";
                MCust_ShippTo_GSTNO.Text = "";
                MCust_ShippTo_ARNO.Text = "";


                MCust_ShippTo_Add1.Text = MCust_Reg_Add1.Text;
                MCust_ShippTo_Add2.Text = MCust_Reg_Add2.Text;
                MCust_ShippTo_Add3.Text = MCust_Reg_Add3.Text;
                MCust_ShippTo_Pincode.Text = MCust_Reg_Pincode.Text;
                MCust_ShippTo_City.Text = MCust_Reg_City.Text;
                MCust_ShippTo_State_ID.Text = MCust_Reg_State_ID.Text;
                MCust_ShippTo_Country.Text = MCust_Reg_Country.Text;
                MCust_ShippTo_CompanyName.Text = MCust_TradeName.Text;
                MCust_ShippTo_ContactPerson.Text = MCust_Primary_Contact_Person.Text;
                MCust_ShippTo_CP_MobileNo.Text = MCust_Primary_CP_MobileNo.Text;
                MCust_ShippTo_PANNO.Text = MCust_BL_PANNO.Text;
                MCust_ShippTo_GSTNO.Text = MCust_BL_GSTNO.Text;
                 
               
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
                ObjAT_Cust.M_Cust_ID = Convert.ToInt64(0 + M_Cust_ID.Text);

                ObjAT_Cust.MCust_Name = MCust_Name.Text;
                ObjAT_Cust.MCust_RegType = MCust_RegType.Text;
                ObjAT_Cust.MCust_CreditDays = Convert.ToInt32(MCust_CreditDays.Text);
                 
                ObjAT_Cust.MCust_TradeName = MCust_TradeName.Text;
                ObjAT_Cust.MCust_Reg_Add1 = MCust_Reg_Add1.Text;
                ObjAT_Cust.MCust_Reg_Add2 = MCust_Reg_Add2.Text;
                ObjAT_Cust.MCust_Reg_Add3 = MCust_Reg_Add3.Text;
               
                
                

                ObjAT_Cust.MDBSC_RowStatus = MDBSC_RowStatus.Text;
                ObjAT_Cust.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
                ObjAT_Cust.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
                ObjAT_Cust.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
              
                ObjAT_Cust.MCust_NatureOfBusiness = "";
                ObjAT_Cust.MCust_Primary_Contact_Designation = MCust_Primary_Contact_Designation.Text;
                ObjAT_Cust.MCust_Primary_Contact_Person = MCust_Primary_Contact_Person.Text;
                ObjAT_Cust.MCust_Primary_CP_MobileNo = MCust_Primary_CP_MobileNo.Text;
                ObjAT_Cust.MCust_Primary_CP_MobileNo_Alt = "";
                ObjAT_Cust.MCust_Primary_CP_EmailID = MCust_Primary_CP_EmailID.Text;
                ObjAT_Cust.MCust_Primary_CP_EmailID_Alt = "";

                ObjAT_Cust.MCust_Primary_CP_PhoneNo = MCust_Primary_CP_PhoneNo.Text;


                ObjAT_Cust.MCust_Contact_Email_Admin = MCust_Contact_Email_Admin.Text;
                ObjAT_Cust.MCust_Contact_FaxNo = MCust_Contact_FaxNo.Text;
                ObjAT_Cust.MCust_Contact_OfficeNo2 = MCust_Contact_OfficeNo2.Text;
                ObjAT_Cust.MCust_Contact_OfficeNo1 = MCust_Contact_OfficeNo1.Text;
                
                ObjAT_Cust.MCust_Contact_OfficeNo_Alt = "";
                 
                ObjAT_Cust.MCust_Contact_Email_Info = "";
                ObjAT_Cust.MCust_Contact_Website = MCust_Contact_Website.Text;
                ObjAT_Cust.MCust_Reg_Country = MCust_Reg_Country.Text;
                ObjAT_Cust.MCust_Reg_State_ID =Convert.ToInt16( MCust_Reg_State_ID.Text);

                ObjAT_Cust.MCust_ShippTo_CompanyName = MCust_ShippTo_CompanyName.Text;
                ObjAT_Cust.MCust_ShippTo_ContactPerson = MCust_ShippTo_ContactPerson.Text;
                ObjAT_Cust.MCust_ShippTo_CP_MobileNo = MCust_ShippTo_CP_MobileNo.Text;
                ObjAT_Cust.MCust_ShippTo_Add1 = MCust_ShippTo_Add1.Text;
                ObjAT_Cust.MCust_ShippTo_Add2 = MCust_ShippTo_Add2.Text;
                ObjAT_Cust.MCust_ShippTo_Add3 = MCust_ShippTo_Add3.Text;
                ObjAT_Cust.MCust_ShippTo_Pincode = MCust_ShippTo_Pincode.Text;
                
                ObjAT_Cust.MCust_ShippTo_City = MCust_ShippTo_City.Text;
                ObjAT_Cust.MCust_ShippTo_State_ID = Convert.ToInt16(MCust_ShippTo_State_ID.Text);
                ObjAT_Cust.MCust_ShippTo_Country = MCust_ShippTo_Country.Text;
                
                ObjAT_Cust.MCust_ShippTo_GSTNO = MCust_ShippTo_GSTNO.Text;

                if (MCust_ShippTo_GSTNO.Text.Length == 15)
                {
                    ObjAT_Cust.MCust_ShippTo_PANNO = MCust_ShippTo_GSTNO.Text.Substring(2,10);
                }
                else
                {
                    ObjAT_Cust.MCust_ShippTo_PANNO = MCust_ShippTo_PANNO.Text;
                }

                ObjAT_Cust.MCust_ShippTo_ARNO = MCust_ShippTo_ARNO.Text;

                ObjAT_Cust.MCust_Reg_City = MCust_Reg_City.Text;
                ObjAT_Cust.MCust_Reg_Pincode = MCust_Reg_Pincode.Text;
               

                 
                ObjAT_Cust.MCust_BL_GSTNO = MCust_BL_GSTNO.Text;
                if (MCust_BL_GSTNO.Text.Length == 15)
                {
                    ObjAT_Cust.MCust_BL_PANNO = MCust_BL_GSTNO.Text.Substring(2, 10);
                }
                else
                {
                    ObjAT_Cust.MCust_BL_PANNO = MCust_BL_PANNO.Text;
                }
                 
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
                dt = MABL.BL.AppDataModal.Get_Mst_Customer(strPK, "", "");
                InitializeControls();
                if (dt.Rows.Count > 0)
                { 
                    M_Cust_ID.Text = dt.Rows[0]["M_Cust_ID"].ToString(); 
                    MCust_Code.Text = dt.Rows[0]["MCust_Code"].ToString();
                    MCust_RegType.Text = dt.Rows[0]["MCust_RegType"].ToString();
                    MCust_Name.Text = dt.Rows[0]["MCust_Name"].ToString(); 
                    MCust_TradeName.Text = dt.Rows[0]["MCust_TradeName"].ToString();
                    MCust_Reg_Add1.Text = dt.Rows[0]["MCust_Reg_Add1"].ToString();
                    MCust_Reg_Add2.Text = dt.Rows[0]["MCust_Reg_Add2"].ToString();
                    MCust_Reg_Add3.Text = dt.Rows[0]["MCust_Reg_Add3"].ToString();
                    MCust_CreditDays.Text = dt.Rows[0]["MCust_CreditDays"].ToString();
                   
                    MDBSC_RowStatus.Text = dt.Rows[0]["MDBSC_RowStatus"].ToString(); 
                    MCust_Primary_Contact_Designation.Text = dt.Rows[0]["MCust_Primary_Contact_Designation"].ToString();
                    MCust_Primary_Contact_Person.Text = dt.Rows[0]["MCust_Primary_Contact_Person"].ToString();
                    MCust_Primary_CP_PhoneNo.Text = dt.Rows[0]["MCust_Primary_CP_PhoneNo"].ToString();
                    MCust_Primary_CP_MobileNo.Text = dt.Rows[0]["MCust_Primary_CP_MobileNo"].ToString(); 
                    MCust_Primary_CP_EmailID.Text = dt.Rows[0]["MCust_Primary_CP_EmailID"].ToString(); 
                    MCust_Contact_OfficeNo1.Text = dt.Rows[0]["MCust_Contact_OfficeNo1"].ToString();
                    MCust_Contact_OfficeNo2.Text = dt.Rows[0]["MCust_Contact_OfficeNo2"].ToString(); 
                    MCust_Contact_FaxNo.Text = dt.Rows[0]["MCust_Contact_FaxNo"].ToString();
                    MCust_Contact_Email_Admin.Text = dt.Rows[0]["MCust_Contact_Email_Admin"].ToString();
                     MCust_Contact_Website.Text = dt.Rows[0]["MCust_Contact_Website"].ToString();
                    MCust_Reg_Country.Text = dt.Rows[0]["MCust_Reg_Country"].ToString();
                     
                    MCust_Reg_State_ID.Text = dt.Rows[0]["MCust_Reg_State_ID"].ToString();
                    MCust_Reg_City.Text = dt.Rows[0]["MCust_Reg_City"].ToString();
                    MCust_Reg_Pincode.Text = dt.Rows[0]["MCust_Reg_Pincode"].ToString();
                    MCust_BL_PANNO.Text = dt.Rows[0]["MCust_BL_PANNO"].ToString();
                    MCust_BL_GSTNO.Text = dt.Rows[0]["MCust_BL_GSTNO"].ToString();
                    

                    MCust_ShippTo_CompanyName.Text = dt.Rows[0]["MCust_ShippTo_CompanyName"].ToString();
                    MCust_ShippTo_ContactPerson.Text = dt.Rows[0]["MCust_ShippTo_ContactPerson"].ToString();
                    MCust_ShippTo_CP_MobileNo.Text = dt.Rows[0]["MCust_ShippTo_CP_MobileNo"].ToString();
                    MCust_ShippTo_Add1.Text = dt.Rows[0]["MCust_ShippTo_Add1"].ToString();
                    MCust_ShippTo_Add2.Text = dt.Rows[0]["MCust_ShippTo_Add2"].ToString();
                    MCust_ShippTo_Add3.Text = dt.Rows[0]["MCust_ShippTo_Add3"].ToString();
                    MCust_ShippTo_Pincode.Text = dt.Rows[0]["MCust_ShippTo_Pincode"].ToString();
                    
                    MCust_ShippTo_City.Text = dt.Rows[0]["MCust_ShippTo_City"].ToString();
                    MCust_ShippTo_State_ID.Text = dt.Rows[0]["MCust_ShippTo_State_ID"].ToString();
                    MCust_ShippTo_Country.Text = dt.Rows[0]["MCust_ShippTo_Country"].ToString();
                    MCust_ShippTo_PANNO.Text = dt.Rows[0]["MCust_ShippTo_PANNO"].ToString();
                    MCust_ShippTo_GSTNO.Text = dt.Rows[0]["MCust_ShippTo_GSTNO"].ToString();
                    MCust_ShippTo_ARNO.Text = dt.Rows[0]["MCust_ShippTo_ARNO"].ToString();
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
        #region "SelectedIndexChanged"
        
        #endregion
        #region 'Print'

        #endregion
        #region "Function"
      
        #endregion

    }
}