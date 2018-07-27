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
    public partial class Vendor : Mahesh_Page
    {
        M_AT_Mst_VendorBO ObjAT_Ven;
        protected void Page_Load(object sender, EventArgs e)
        {
            PageMenuID = Request.QueryString["ID"];
            ObjAT_Ven = new M_AT_Mst_VendorBO();

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

                SetValueType(TextType.NumericField, MVen_Reg_Pincode);
                SetValueType(TextType.NumericField, MVen_DispatchFrom_Pincode);
                SetValueType(TextType.NumericField, MVen_DispatchFrom_CP_MobileNo);
                SetValueType(TextType.NumericField, MVen_DispatchFrom_Pincode);

                SetValueType(TextType.DateField, RecCreatedOn);

                SetValueType(TextType.NumericField, MVen_CreditDays);
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
            MVen_Reg_State_ID.DataSource = dt;
            MVen_Reg_State_ID.DataBind();
            MVen_DispatchFrom_State_ID.DataSource = dt;
            MVen_DispatchFrom_State_ID.DataBind();

            MVen_RegType.DataSource = MABL.APPDT.MADD.DT_Taxpayer_Type("", "", "Vendor Type");
            MVen_RegType.DataBind();
        }
        #endregion
        #region "Refrish Grid Functions"
        private void RefreshGrid(string SearchCriteria = "")
        {
            try
            {

                DataTable dt = default(DataTable);
                dt = MABL.BL.AppDataModal.Get_Mst_Vendor(0, "", SearchCriteria);
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
                M_Ven_ID.Text = "0";
                MVen_RegType.SelectedIndex = 0;
                MVen_Code.Text = MEF.GetRefNo(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, 0, "Vendor", "VEN", "VEN", "No");
                MVen_Name.Text = "";
                MVen_Reg_Add1.Text = "";
                MVen_Reg_Add2.Text = "";
                MVen_Reg_Add3.Text = "";
                MVen_BankName.Text = "";
                MVen_AccountHolderName.Text = "";
                MVen_CreditDays.Text = "30";
                MVen_IFSCNo.Text = "";
                MVen_AccountNo.Text = "";
                MVen_BankBranch.Text = "";
                MDBSC_RowStatus.SelectedIndex = 0;
                RecCreatedOn.Text = "";
                RecCreatedUser.Text = "";
                MVen_Primary_Contact_Designation.Text = "";
                MVen_Primary_Contact_Person.Text = "";
                MVen_Primary_CP_MobileNo.Text = "";

                MVen_Primary_CP_EmailID.Text = "";

                MVen_Primary_CP_PhoneNo.Text = "";

                MVen_Contact_Email_Admin.Text = "";

                MVen_Contact_FaxNo.Text = "";
                MVen_Contact_OfficeNo2.Text = "";
                MVen_Contact_OfficeNo1.Text = "";

                MVen_Contact_Website.Text = "";
                MVen_Reg_Country.Text = "India";
                MVen_Reg_State_ID.SelectedIndex = 0;
                MVen_Reg_City.Text = "";
                MVen_Reg_Pincode.Text = "";

                MVen_BL_PANNO.Text = "";

                MVen_TradeName.Text = "";

                MVen_DispatchFrom_State_ID.SelectedIndex = 0;
                MVen_DispatchFrom_CompanyName.Text = "";
                MVen_DispatchFrom_ContactPerson.Text = "";
                MVen_DispatchFrom_CP_MobileNo.Text = "";
                MVen_DispatchFrom_Add1.Text = "";
                MVen_DispatchFrom_Add2.Text = "";
                MVen_DispatchFrom_Add3.Text = "";
                MVen_DispatchFrom_Pincode.Text = "";

                MVen_DispatchFrom_City.Text = "";

                MVen_DispatchFrom_Country.Text = "";
                MVen_DispatchFrom_PANNO.Text = "";
                MVen_DispatchFrom_GSTNO.Text = "";
                MVen_DispatchFrom_ARNO.Text = "";

                MVen_BL_GSTNO.Text = "";
                
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
                if (MVen_RegType.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Pls Select Vendor Type<br>";
                }
                else
                {
                    if ((MVen_RegType.Text == "Registered Taxpayer") || (MVen_RegType.Text == "Composite Taxpayer"))
                    {
                        if (MVen_BL_GSTNO.Text.Length != 15)
                        {
                            ErrorMessage = ErrorMessage + "Billing GST No Cannot Be Blank<br>";
                        }
                        if (MVen_DispatchFrom_GSTNO.Text.Length != 15)
                        {
                            ErrorMessage = ErrorMessage + "Consigner GST No Cannot Be Blank<br>";
                        }

                        if (MVen_Reg_State_ID.SelectedIndex > 0)
                        {
                            if (MVen_BL_GSTNO.Text.Length > 2)
                            {
                                var_GSTState = MVen_BL_GSTNO.Text.Substring(0, 2);
                            }

                            var_StateCode = MVen_Reg_State_ID.SelectedItem.Text.Substring(0, 2);
                            if (var_GSTState != var_StateCode)
                            {
                                ErrorMessage = ErrorMessage + "Invlid Billing GST No For " + MVen_Reg_State_ID.SelectedItem.Text + " .<br>";
                            }
                        }


                        if (MVen_DispatchFrom_State_ID.SelectedIndex > 0)
                        {
                            if (MVen_DispatchFrom_GSTNO.Text.Length > 2)
                            {
                                var_GSTState = MVen_DispatchFrom_GSTNO.Text.Substring(0, 2);
                            }

                            var_StateCode = MVen_DispatchFrom_State_ID.SelectedItem.Text.Substring(0, 2);
                            if (var_GSTState != var_StateCode)
                            {
                                ErrorMessage = ErrorMessage + "Invlid Consigner GST No For " + MVen_DispatchFrom_State_ID.SelectedItem.Text + " .<br>";
                            }
                        }



                    }

                    if (MVen_RegType.Text == "Unregistered")
                    {

                    }


                }
               
                if (SQLManager.CheckDuplicateRecord("M_AT_Mst_Vendor", "M_Ven_ID", Convert.ToInt32("0" + M_Ven_ID.Text), "MVenCode", MVen_Code.Text, ""))
                {
                    ErrorMessage = ErrorMessage + "Vendor Code Already Exist.<br>";
                }

                if (SQLManager.CheckDuplicateRecord("M_AT_Mst_Vendor", "M_Ven_ID", Convert.ToInt32("0" + M_Ven_ID.Text), "MVenName", MVen_Name.Text, ""))
                {
                    ErrorMessage = ErrorMessage + "Vendor Name Already Exists.<br>";
                }

                if (MVen_Code.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Vendor Code No Cannot Be Blank.<br>";
                }

                if (MVen_Name.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Vendor Name Cannot Be Blank.<br>";
                }
                if (MVen_TradeName.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Vendor Trade Name Cannot Be Blank.<br>";
                }
                if (MVen_Reg_State_ID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Select Vendor State.<br>";
                }

                if (MVen_DispatchFrom_State_ID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Select Vendor Shipp To State.<br>";
                }

                if (ErrorMessage.Length == 0)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (Convert.ToInt32(M_Ven_ID.Text) == 0)
                        {
                            ObjAT_Ven.Fk_Company_ID = SessionUserData.Company.CompanyID;
                            ObjAT_Ven.Fk_Branch_ID = SessionUserData.Company.BranchID;
                            ObjAT_Ven.Fk_Year_ID = SessionUserData.Company.YearID;
                            ObjAT_Ven.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                            ObjAT_Ven.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName;
                            ObjAT_Ven.MVen_Code = MaheshAF18.Application.MEF.GenrateRefNo(SessionUserData.Company.CompanyID,
                                 SessionUserData.Company.BranchID, 0, "Vendor", "VEN", "VEN", "No", "", "", "", 0);
                        }
                        SetValuesToBO();
                        ErrorMessage = ObjAT_Ven.Insert_Update(ObjAT_Ven);
                        M_Ven_ID.Text = ErrorMessage.Substring((ErrorMessage.IndexOf("|") + 1), (ErrorMessage.Length - ErrorMessage.IndexOf("|") - 1));
                        ErrorMessage = ErrorMessage.Substring((0), (ErrorMessage.IndexOf("|")));
                        scope.Complete();
                    }

                    SetValueToControls_Edit(Convert.ToInt64(M_Ven_ID.Text));
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

                MVen_DispatchFrom_Add1.Text = "";
                MVen_DispatchFrom_Add2.Text = "";
                MVen_DispatchFrom_Add3.Text = "";
                MVen_DispatchFrom_Pincode.Text = "";
                MVen_DispatchFrom_City.Text = "";
                MVen_DispatchFrom_State_ID.SelectedIndex = 0;
                MVen_DispatchFrom_Country.Text = "";
                MVen_DispatchFrom_CompanyName.Text = "";
                MVen_DispatchFrom_ContactPerson.Text = "";
                MVen_DispatchFrom_CP_MobileNo.Text = "";
                MVen_DispatchFrom_PANNO.Text = "";
                MVen_DispatchFrom_GSTNO.Text = "";
                MVen_DispatchFrom_ARNO.Text = "";


                MVen_DispatchFrom_Add1.Text = MVen_Reg_Add1.Text;
                MVen_DispatchFrom_Add2.Text = MVen_Reg_Add2.Text;
                MVen_DispatchFrom_Add3.Text = MVen_Reg_Add3.Text;
                MVen_DispatchFrom_Pincode.Text = MVen_Reg_Pincode.Text;
                MVen_DispatchFrom_City.Text = MVen_Reg_City.Text;
                MVen_DispatchFrom_State_ID.Text = MVen_Reg_State_ID.Text;
                MVen_DispatchFrom_Country.Text = MVen_Reg_Country.Text;
                MVen_DispatchFrom_CompanyName.Text = MVen_TradeName.Text;
                MVen_DispatchFrom_ContactPerson.Text = MVen_Primary_Contact_Person.Text;
                MVen_DispatchFrom_CP_MobileNo.Text = MVen_Primary_CP_MobileNo.Text;
                MVen_DispatchFrom_PANNO.Text = MVen_BL_PANNO.Text;
                MVen_DispatchFrom_GSTNO.Text = MVen_BL_GSTNO.Text;
               
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
                ObjAT_Ven.M_Ven_ID = Convert.ToInt64(0 + M_Ven_ID.Text);

                ObjAT_Ven.MVen_Name = MVen_Name.Text;
                ObjAT_Ven.MVen_RegType = MVen_RegType.Text;
                ObjAT_Ven.MVen_TradeName = MVen_TradeName.Text;
                ObjAT_Ven.MVen_Reg_Add1 = MVen_Reg_Add1.Text;
                ObjAT_Ven.MVen_Reg_Add2 = MVen_Reg_Add2.Text;
                ObjAT_Ven.MVen_Reg_Add3 = MVen_Reg_Add3.Text;
                ObjAT_Ven.MVen_BankName = MVen_BankName.Text;
                ObjAT_Ven.MVen_AccountHolderName = MVen_AccountHolderName.Text;
                ObjAT_Ven.MVen_IFSCNo = MVen_IFSCNo.Text;
                ObjAT_Ven.MVen_AccountNo = MVen_AccountNo.Text;
                ObjAT_Ven.MVen_BankBranch = MVen_BankBranch.Text;
                ObjAT_Ven.MVen_CreditDays = Convert.ToInt32(MVen_CreditDays.Text);

                ObjAT_Ven.MDBSC_RowStatus = MDBSC_RowStatus.Text;
                ObjAT_Ven.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
                ObjAT_Ven.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
                ObjAT_Ven.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
              
                ObjAT_Ven.MVen_NatureOfBusiness = "";
                ObjAT_Ven.MVen_Primary_Contact_Designation = MVen_Primary_Contact_Designation.Text;
                ObjAT_Ven.MVen_Primary_Contact_Person = MVen_Primary_Contact_Person.Text;
                ObjAT_Ven.MVen_Primary_CP_MobileNo = MVen_Primary_CP_MobileNo.Text;
                ObjAT_Ven.MVen_Primary_CP_MobileNo_Alt = "";
                ObjAT_Ven.MVen_Primary_CP_EmailID = MVen_Primary_CP_EmailID.Text;
                ObjAT_Ven.MVen_Primary_CP_EmailID_Alt = "";

                ObjAT_Ven.MVen_Primary_CP_PhoneNo = MVen_Primary_CP_PhoneNo.Text;


                ObjAT_Ven.MVen_Contact_Email_Admin = MVen_Contact_Email_Admin.Text;
                ObjAT_Ven.MVen_Contact_FaxNo = MVen_Contact_FaxNo.Text;
                ObjAT_Ven.MVen_Contact_OfficeNo2 = MVen_Contact_OfficeNo2.Text;
                ObjAT_Ven.MVen_Contact_OfficeNo1 = MVen_Contact_OfficeNo1.Text;

                ObjAT_Ven.MVen_Contact_OfficeNo_Alt = "";
                
                
                ObjAT_Ven.MVen_Contact_Email_Info = "";
                ObjAT_Ven.MVen_Contact_Website = MVen_Contact_Website.Text;
                ObjAT_Ven.MVen_Reg_Country = MVen_Reg_Country.Text;
                ObjAT_Ven.MVen_Reg_State_ID = Convert.ToInt16(MVen_Reg_State_ID.Text);

                ObjAT_Ven.MVen_DispatchFrom_CompanyName = MVen_DispatchFrom_CompanyName.Text;
                ObjAT_Ven.MVen_DispatchFrom_ContactPerson = MVen_DispatchFrom_ContactPerson.Text;
                ObjAT_Ven.MVen_DispatchFrom_CP_MobileNo = MVen_DispatchFrom_CP_MobileNo.Text;
                ObjAT_Ven.MVen_DispatchFrom_Add1 = MVen_DispatchFrom_Add1.Text;
                ObjAT_Ven.MVen_DispatchFrom_Add2 = MVen_DispatchFrom_Add2.Text;
                ObjAT_Ven.MVen_DispatchFrom_Add3 = MVen_DispatchFrom_Add3.Text;
                ObjAT_Ven.MVen_DispatchFrom_Pincode = MVen_DispatchFrom_Pincode.Text;

                ObjAT_Ven.MVen_DispatchFrom_City = MVen_DispatchFrom_City.Text;
                ObjAT_Ven.MVen_DispatchFrom_State_ID = Convert.ToInt16(MVen_DispatchFrom_State_ID.Text);
                ObjAT_Ven.MVen_DispatchFrom_Country = MVen_DispatchFrom_Country.Text;
                 
                ObjAT_Ven.MVen_DispatchFrom_GSTNO = MVen_DispatchFrom_GSTNO.Text;
                ObjAT_Ven.MVen_DispatchFrom_ARNO = MVen_DispatchFrom_ARNO.Text;

                ObjAT_Ven.MVen_Reg_City = MVen_Reg_City.Text;
                ObjAT_Ven.MVen_Reg_Pincode = MVen_Reg_Pincode.Text;


                 
                ObjAT_Ven.MVen_BL_GSTNO = MVen_BL_GSTNO.Text;


                if (MVen_DispatchFrom_GSTNO.Text.Length == 15)
                {
                    ObjAT_Ven.MVen_DispatchFrom_PANNO = MVen_DispatchFrom_GSTNO.Text.Substring(2, 10);
                }
                else
                {
                    ObjAT_Ven.MVen_DispatchFrom_PANNO = MVen_DispatchFrom_PANNO.Text;
                }

                if (MVen_BL_GSTNO.Text.Length == 15)
                {
                    ObjAT_Ven.MVen_BL_PANNO = MVen_BL_GSTNO.Text.Substring(2, 10);
                }
                else
                {
                    ObjAT_Ven.MVen_BL_PANNO = MVen_BL_PANNO.Text;
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
                dt = MABL.BL.AppDataModal.Get_Mst_Vendor(strPK, "", "");
                InitializeControls();
                if (dt.Rows.Count > 0)
                {
                    M_Ven_ID.Text = dt.Rows[0]["M_Ven_ID"].ToString();
                    MVen_Code.Text = dt.Rows[0]["MVen_Code"].ToString();
                    MVen_Name.Text = dt.Rows[0]["MVen_Name"].ToString();
                    MVen_RegType.Text = dt.Rows[0]["MVen_RegType"].ToString();
                    MVen_TradeName.Text = dt.Rows[0]["MVen_TradeName"].ToString();
                    MVen_Reg_Add1.Text = dt.Rows[0]["MVen_Reg_Add1"].ToString();
                    MVen_Reg_Add2.Text = dt.Rows[0]["MVen_Reg_Add2"].ToString();
                    MVen_Reg_Add3.Text = dt.Rows[0]["MVen_Reg_Add3"].ToString();
                    MVen_BankName.Text = dt.Rows[0]["MVen_BankName"].ToString();
                    MVen_AccountHolderName.Text = dt.Rows[0]["MVen_AccountHolderName"].ToString();
                    MVen_IFSCNo.Text = dt.Rows[0]["MVen_IFSCNo"].ToString();
                    MVen_AccountNo.Text = dt.Rows[0]["MVen_AccountNo"].ToString();
                    MVen_BankBranch.Text = dt.Rows[0]["MVen_BankBranch"].ToString();
                    MDBSC_RowStatus.Text = dt.Rows[0]["MDBSC_RowStatus"].ToString();
                    MVen_Primary_Contact_Designation.Text = dt.Rows[0]["MVen_Primary_Contact_Designation"].ToString();
                    MVen_Primary_Contact_Person.Text = dt.Rows[0]["MVen_Primary_Contact_Person"].ToString();
                    MVen_Primary_CP_PhoneNo.Text = dt.Rows[0]["MVen_Primary_CP_PhoneNo"].ToString();
                    MVen_Primary_CP_MobileNo.Text = dt.Rows[0]["MVen_Primary_CP_MobileNo"].ToString();
                    MVen_Primary_CP_EmailID.Text = dt.Rows[0]["MVen_Primary_CP_EmailID"].ToString();
                    MVen_Contact_OfficeNo1.Text = dt.Rows[0]["MVen_Contact_OfficeNo1"].ToString();
                    MVen_Contact_OfficeNo2.Text = dt.Rows[0]["MVen_Contact_OfficeNo2"].ToString();
                    MVen_Contact_FaxNo.Text = dt.Rows[0]["MVen_Contact_FaxNo"].ToString();
                    MVen_Contact_Email_Admin.Text = dt.Rows[0]["MVen_Contact_Email_Admin"].ToString();
                    MVen_Contact_Website.Text = dt.Rows[0]["MVen_Contact_Website"].ToString();
                    MVen_Reg_Country.Text = dt.Rows[0]["MVen_Reg_Country"].ToString();
                    MVen_CreditDays.Text = dt.Rows[0]["MVen_CreditDays"].ToString();
                    MVen_Reg_State_ID.Text = dt.Rows[0]["MVen_Reg_State_ID"].ToString();
                    MVen_Reg_City.Text = dt.Rows[0]["MVen_Reg_City"].ToString();
                    MVen_Reg_Pincode.Text = dt.Rows[0]["MVen_Reg_Pincode"].ToString();
                    MVen_BL_PANNO.Text = dt.Rows[0]["MVen_BL_PANNO"].ToString();
                    MVen_BL_GSTNO.Text = dt.Rows[0]["MVen_BL_GSTNO"].ToString();
                     

                    MVen_DispatchFrom_CompanyName.Text = dt.Rows[0]["MVen_DispatchFrom_CompanyName"].ToString();
                    MVen_DispatchFrom_ContactPerson.Text = dt.Rows[0]["MVen_DispatchFrom_ContactPerson"].ToString();
                    MVen_DispatchFrom_CP_MobileNo.Text = dt.Rows[0]["MVen_DispatchFrom_CP_MobileNo"].ToString();
                    MVen_DispatchFrom_Add1.Text = dt.Rows[0]["MVen_DispatchFrom_Add1"].ToString();
                    MVen_DispatchFrom_Add2.Text = dt.Rows[0]["MVen_DispatchFrom_Add2"].ToString();
                    MVen_DispatchFrom_Add3.Text = dt.Rows[0]["MVen_DispatchFrom_Add3"].ToString();
                    MVen_DispatchFrom_Pincode.Text = dt.Rows[0]["MVen_DispatchFrom_Pincode"].ToString();

                    MVen_DispatchFrom_City.Text = dt.Rows[0]["MVen_DispatchFrom_City"].ToString();
                    MVen_DispatchFrom_State_ID.Text = dt.Rows[0]["MVen_DispatchFrom_State_ID"].ToString();
                    MVen_DispatchFrom_Country.Text = dt.Rows[0]["MVen_DispatchFrom_Country"].ToString();
                    MVen_DispatchFrom_PANNO.Text = dt.Rows[0]["MVen_DispatchFrom_PANNO"].ToString();
                    MVen_DispatchFrom_GSTNO.Text = dt.Rows[0]["MVen_DispatchFrom_GSTNO"].ToString();
                    MVen_DispatchFrom_ARNO.Text = dt.Rows[0]["MVen_DispatchFrom_ARNO"].ToString();
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