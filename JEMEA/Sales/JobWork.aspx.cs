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
using System.IO;


namespace JEMEA.JobWork
{
    public partial class JobWork : Mahesh_Page
    {
        M_AT_Proc_JW_AHDRBO ObjAT_JW_HDR;
        M_AT_Proc_JW_BDTLBO ObjAT_JW_DTL; 
        protected void Page_Load(object sender, EventArgs e)
        {

            PageMenuID = Request.QueryString["ID"];
            //SessionData.UserAccess.MenuID = PageMenuID;

            ObjAT_JW_HDR = new M_AT_Proc_JW_AHDRBO();
            ObjAT_JW_DTL = new M_AT_Proc_JW_BDTLBO();
          
             
            SetControlType();


            if (!IsPostBack)
            {
                MaheshAF18.UIControlHelper.GenricControl.GetOperatorList(ddOperator);
                MaheshAF18.UIControlHelper.GenricControl.GetFieldListByGrid(gvList, ddSearchBy);                
              
                FillDropdown();
                InitializeControls_HDR();
                RefreshGrid_HDR();
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
                RefreshGrid_HDR(SearchCriteria);
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
                btnListClose.Attributes.Add("onClick", "self.location.replace(" + SessionUserData.AppInfo.DefaultRedirect.ToString().Substring(1) + "); return false;");

                CE_JW_DT.EndDate = DateTime.Now;
                CE_JW_PO_DT.EndDate = DateTime.Now;


                SetValueType(TextType.DateField, Txt_FromDT);
                SetValueType(TextType.DateField, Txt_ToDT);
                SetValueType(TextType.AmountField, JW_QTY);
                SetValueType(TextType.AlphNumericField_4, JW_BasicRate);
                SetValueType(TextType.AmountField, JW_DiscountRate);

                SetValueType(TextType.DateField, JW_DT);
                SetValueType(TextType.NumericField, JW_CreditDays);
                SetValueType(TextType.DateField, JW_DueDT);
                SetValueType(TextType.DateField, JW_PO_DT);
                SetValueType(TextType.DateField, MDBSC_RowCreatedOn_DT);
                SetValueType(TextType.AmountField, JW_HDR_BasicAmt);
                SetValueType(TextType.AmountField, JW_HDR_DiscountAmt);
                SetValueType(TextType.AmountField, JW_HDR_Net_Amt);
                SetValueType(TextType.AmountField, JW_HDR_Freight_Charges);
                SetValueType(TextType.AmountField, JW_HDR_CGST_Amt);
                SetValueType(TextType.AmountField, JW_HDR_SGST_Amt);
                SetValueType(TextType.AmountField, JW_HDR_IGST_Amt);
                SetValueType(TextType.AmountField, JW_HDR_CESS_Amt);
                SetValueType(TextType.AmountField, JW_HDR_Gross_Amt);
                SetValueType(TextType.AmountField, JW_HDR_Round_Off_Amt);
                SetValueType(TextType.AmountField, JW_HDR_Total_Gross_Amt);
                SetValueType(TextType.AmountField, JW_HDR_Total_Tax_Amt);
                
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

            Fk_VendorID.DataSource = MaheshAF18.Utility.M_DropDownList.Fill_Drop_Down_List("v_M_AT_Mst_Vendor", "M_Ven_ID", "MVen_Name", "", "", "Vendor", 0, "N", "");
            Fk_VendorID.DataBind();

            Fk_MItem_ID.DataSource = MaheshAF18.Utility.M_DropDownList.Fill_Drop_Down_List("M_AT_Mst_ItemMaster", "MItem_ID", "Item_Name", "", "", "Item", 0, "N", "");
            Fk_MItem_ID.DataBind();

             DataTable dt = new DataTable();
            dt = MaheshAF18.Utility.M_DropDownList.Fill_Drop_Down_List("v_AAA_M_RT_GEO_State", "GStateID", "vStateDisplayName", "  ", "", "State", 0, "N", "");
            JW_ShippedFrom_State_ID.DataSource = dt;
            JW_ShippedFrom_State_ID.DataBind();

            JW_ShippTo_State_ID.DataSource = dt;
            JW_ShippTo_State_ID.DataBind();
            
           
        }
        #endregion
        #region "Refrish Grid Functions"
        private void RefreshGrid_HDR(string SearchCriteria = "")
        {
            try
            {
                string var_SQLFilter = "";
                var_SQLFilter = var_SQLFilter + " AND JW_Category ='Tax Purchase'";

                if ((Txt_FromDT.Text.Length > 0) && (Txt_ToDT.Text.Length > 0))
                {
                    var_SQLFilter = var_SQLFilter + " AND JW_DT BETWEEN  '" + Txt_FromDT.Text + "' AND  '" + Txt_ToDT.Text + "'";
                }
                DataTable dt = default(DataTable);
                dt = MABL.BL.AppDataModal.Get_JoBWork_List(0, var_SQLFilter, SearchCriteria);
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
        private void RefreshGrid_Item_DTL(string SearchCriteria = "")
        {
            try
            {
              



                DataTable dt = default(DataTable);
                dt = MABL.BL.AppDataModal.Get_JoBWork_Item_List(Convert.ToInt64(JW_HDR_ID.Text), Convert.ToInt64(JW_DTL_ID.Text),"", "");
                if (dt.Rows.Count > 0)
                {
                    gvdtl.DataSource = dt;
                    gvdtl.DataBind();
                    if (dt.Rows.Count < 50)
                    {
                        Msg_RCNTItem.Text = "Showing " + dt.Rows.Count + " Records  ";
                    }
                    else
                    {
                        Msg_RCNTItem.Text = "Showing 50 Of " + dt.Rows.Count + " Records  ";
                    }
                }
                else
                {
                    gvdtl.DataSource = null;
                    gvdtl.DataBind();
                    Msg_RCNTItem.Text = "No Records Found";
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void RefreshGrid_Tax_DTL(string SearchCriteria = "")
        {
            try
            {
                //DataTable dt = default(DataTable);
                //dt = dt = MABL.BL.AppDataModal.Get_Purchase_Tax_List(Convert.ToInt64(JW_HDR_ID.Text),0, "", "");
                //if (dt.Rows.Count > 0)
                //{
                //    gvdtl.DataSource = dt;
                //    gvdtl.DataBind();
                //    if (dt.Rows.Count < 50)
                //    {
                //        Msg_RCNTItem.Text = "Showing " + dt.Rows.Count + " Records  ";
                //    }
                //    else
                //    {
                //        Msg_RCNTItem.Text = "Showing 50 Of " + dt.Rows.Count + " Records  ";
                //    }
                //}
                //else
                //{
                //    gvdtl.DataSource = null;
                //    gvdtl.DataBind();
                //    Msg_RCNTItem.Text = "No Records Found";
                //}

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
                InitializeControls_HDR();
                InitializeControls_DTL();
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

                RefreshGrid_HDR();
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
                RefreshGrid_HDR();
            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary(ex.Message);
            }
        }

        #endregion
        #region "InitializeControls"
        private void InitializeControls_HDR()
        {
            try
            {
                Txt_FromDT.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(SessionUserData.Company.AccountingStartDate));
                Txt_ToDT.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
               
                JW_HDR_ID.Text = "0";               
                Fk_VendorID.SelectedIndex = 0;                
                Msg_ErrorMsg.Text = "";
               
                JW_Taxtype.Text = "";
                JW_No.Text = "";
                JW_DT.Text = "";

              
                JW_CreditDays.Text = "30";
                JW_DueDT.Text = "";
                JW_PONo.Text = "";
                JW_PO_DT.Text = "";
                JW_Remark.Text = "";
                MDBSC_RowStatus.Text = "";
                MDBSC_RowCreatedByUserName.Text = SessionUserData.UserData.UserName;
                MDBSC_RowCreatedOn_DT.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
                JW_HDR_BasicAmt.Text = "0.00";
                JW_HDR_DiscountAmt.Text = "0.00";
                JW_HDR_Net_Amt.Text = "0.00";
                JW_HDR_Freight_Charges.Text = "0.00";
                JW_HDR_CGST_Amt.Text = "0.00";
                JW_HDR_SGST_Amt.Text = "0.00";
                JW_HDR_IGST_Amt.Text = "0.00";
                JW_HDR_CESS_Amt.Text = "0.00";
                JW_HDR_Gross_Amt.Text = "0.00";
                JW_HDR_Round_Off_Amt.Text = "0.00";
                JW_HDR_Total_Gross_Amt.Text = "0.00";

                JW_HDR_Total_Tax_Amt.Text = "0.00";

                JW_CreditDays.Text = "0";
                JW_ShippedFrom_State_ID.SelectedIndex = 0;
                MVen_Reg_Add1.Text = "";
                MVen_Reg_Add2.Text = "";
                MVen_Reg_Add3.Text = "";
                MVen_Reg_Pincode.Text = "";
                MVen_Reg_City.Text = "";
                MVen_Reg_StateDisplayName.Text = "";
                MVen_Reg_Country.Text = "";
                MVen_BL_GSTNO.Text = "";
                MVen_BL_PANNO.Text = "";

                JW_ShippTo_State_ID.SelectedIndex = 0;
                JW_BillTo_Add1.Text = "";
                JW_BillTo_Add2.Text = "";
                JW_BillTo_Add3.Text = "";
                JW_BillTo_Pincode.Text = "";
                JW_BillTo_City.Text = "";
                JW_BillTo_StateDisplayName.Text = "";
                JW_BillTo_Country.Text = "";
                JW_BillTo_GSTNo.Text = "";
                JW_BillTo_PANNO.Text = "";


                JW_ShippTo_CompanyName.Text = "";
                JW_ShippTo_ContactPersone.Text = "";
                JW_ShippTo_CP_MobileNo.Text = "";
                JW_ShippTo_Add1.Text = "";
                JW_ShippTo_Add2.Text = "";
                JW_ShippTo_Add3.Text = "";

                JW_ShippedFrom_CompanyName.Text = "";
                JW_ShippedFrom_ContactPersone.Text = "";
                JW_ShippedFrom_CP_MobileNo.Text = "";
                JW_ShippedFrom_Add1.Text = "";
                JW_ShippedFrom_Add2.Text = "";
                JW_ShippedFrom_Add3.Text = "";
                JW_ShippedFrom_Pincode.Text = "";
                 
                JW_ShippedFrom_City.Text = "";
                 
                JW_ShippedFrom_Country.Text = "";
                JW_ShippedFrom_GSTNo.Text = "";
                JW_ShippedFrom_PANNO.Text = "";


                JW_ShippTo_Pincode.Text = "";
                JW_ShippTo_City.Text = "";

                JW_ShippTo_Country.Text = "";
                JW_ShippTo_GSTNo.Text = "";
                JW_ShippTo_PANNO.Text = "";
                
                TaxType_Toggel();

                gvdtl.DataSource = null;
                gvdtl.DataBind();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void InitializeControls_DTL()
        {
            try
            {

                JW_DTL_ID.Text = "0";
                Fk_MItem_ID.SelectedIndex = 0;
                JW_BasicRate.Text = "0";
                JW_HSNCode.Text="";
                JW_QTY.Text = "0"; 
                JW_DiscountRate.Text = "0";
               
                JW_ItemRemark_DTL.Text = "";
                TaxType_Toggel();
                RefreshGrid_Item_DTL();
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

                if (Fk_VendorID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Select Seller.<br>";
                }
                if (JW_No.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Seller Job no Cannot Be Blank.<br>";
                }

                if (JW_ShippedFrom_State_ID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Place Of Dispatch<br>";
                }
                 

                if (JW_ShippTo_State_ID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Place Of Supply<br>";
                }

                if (JW_ShippedFrom_GSTNo.Text.Length != 15)
                {
                    ErrorMessage = ErrorMessage + "Invalid Ship From GSTNO<br>";
                }
               
                if (JW_ShippedFrom_PANNO.Text.Length != 10)
                {
                    ErrorMessage = ErrorMessage + "Invalid Ship From PAN No<br>";
                }
              

                if ((JW_No.Text.Length > 0) && (Fk_VendorID.SelectedIndex > 0))
                {
                     if (SQLManager.CheckDuplicateRecord("M_AT_Proc_JW_AHDR", "JW_HDR_ID", Convert.ToInt32("0" + JW_HDR_ID.Text), "JW_No", JW_No.Text,
                                                        " AND Fk_Branch_ID=" + SessionUserData.Company.BranchID + " AND  Fk_VendorID=" + Fk_VendorID.Text))
                    {
                        ErrorMessage = ErrorMessage + "Selller Purchase Invoice Already Exist.<br>";
                    }
                }
                
                if (JW_DT.Text.Length != 11)
                {
                    ErrorMessage = ErrorMessage + "Invalid Seller Invoice Date.<br>";
                }
                if ((Fk_VendorID.SelectedIndex > 0 ) && (Convert.ToInt32(JW_HDR_ID.Text) == 0)) 
                {
                    if (Fk_MItem_ID.SelectedIndex == 0)
                    {
                        ErrorMessage = ErrorMessage + "Pls Select Item<br>";
                    }
                    if (JW_BasicRate.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Rate<br>";
                    }
                    if (JW_QTY.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Quantity<br>";
                    }
                    else
                    {
                        if (Convert.ToDecimal(JW_QTY.Text) <= 0)
                        {
                            ErrorMessage = ErrorMessage + "Invalid Item Quantity<br>";
                        }
                    }
                }
                if ((Convert.ToInt32(JW_HDR_ID.Text) > 0) && (Convert.ToInt32(JW_DTL_ID.Text) > 0) && (Fk_MItem_ID.SelectedIndex > 0))
                {
                    if (Fk_MItem_ID.SelectedIndex == 0)
                    {
                        ErrorMessage = ErrorMessage + "Pls Select Item<br>";
                    }
                    if (JW_BasicRate.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Rate<br>";
                    }
                    if (JW_QTY.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Quantity<br>";
                    }
                    else
                    {
                        if (Convert.ToDecimal(JW_QTY.Text) <= 0)
                        {
                            ErrorMessage = ErrorMessage + "Invalid Item Quantity<br>";
                        }
                    }
                }


                if (ErrorMessage.Length == 0)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (Convert.ToInt32(JW_HDR_ID.Text) == 0)
                        {
                            ObjAT_JW_HDR.Fk_Company_ID = SessionUserData.Company.CompanyID;
                            ObjAT_JW_HDR.Fk_Branch_ID = SessionUserData.Company.BranchID;
                            ObjAT_JW_HDR.Fk_Year_ID = SessionUserData.Company.YearID;
                            ObjAT_JW_HDR.Rec_Created_In ="HO";
                            ObjAT_JW_HDR.Rec_CreatedBy_ID = SessionUserData.Company.BranchID;
                            ObjAT_JW_HDR.Rec_CreatedFor_ID = SessionUserData.Company.BranchID;
                            ObjAT_JW_HDR.JW_CreationType = "Manual";
                            ObjAT_JW_HDR.JW_Category = "Tax Purchase";                
                            ObjAT_JW_HDR.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName;
                            ObjAT_JW_HDR.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                            

                        }
                        SetValuesToBO_HDR();
                        ErrorMessage = ObjAT_JW_HDR.Insert_Update(ObjAT_JW_HDR);
                        JW_HDR_ID.Text = ErrorMessage.Substring((ErrorMessage.IndexOf("|") + 1), (ErrorMessage.Length - ErrorMessage.IndexOf("|") - 1));
                        ErrorMessage = ErrorMessage.Substring((0), (ErrorMessage.IndexOf("|")));

                        if ((Convert.ToInt32(JW_HDR_ID.Text) > 0) && (Fk_MItem_ID.SelectedIndex > 0))
                        {
                            if (Convert.ToInt32(JW_DTL_ID.Text)== 0)
                            {
                                ObjAT_JW_DTL.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                                ObjAT_JW_DTL.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName; 
                            }

                            ObjAT_JW_DTL.JW_DTL_ID = Convert.ToInt64("0" + JW_DTL_ID.Text);
                           ObjAT_JW_DTL.Fk_JW_HDR_ID = Convert.ToInt64("0" + JW_HDR_ID.Text);
                            ObjAT_JW_DTL.Fk_MItem_ID = Convert.ToInt64("0" + Fk_MItem_ID.Text);
                            ObjAT_JW_DTL.JW_HSNCode = JW_HSNCode.Text;
                            ObjAT_JW_DTL.JW_QTY =Convert.ToDecimal( JW_QTY.Text);
                            ObjAT_JW_DTL.JW_BasicRate = Convert.ToDecimal(JW_BasicRate.Text);
                            ObjAT_JW_DTL.JW_DiscountRate = Convert.ToDecimal(JW_DiscountRate.Text);
                            ObjAT_JW_DTL.JW_CGST_ID = 0;
                            ObjAT_JW_DTL.JW_SGST_ID = 0;
                            ObjAT_JW_DTL.JW_IGST_ID = 0;
                            ObjAT_JW_DTL.JW_CESS_ID = 0;
                            
                            ObjAT_JW_DTL.JW_ItemRemark_DTL = JW_ItemRemark_DTL.Text;
                            ObjAT_JW_DTL.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
                            ObjAT_JW_DTL.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
                            ObjAT_JW_DTL.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));

                            ObjAT_JW_DTL.Insert_Update(ObjAT_JW_DTL);
                            
                            
                        }

                        scope.Complete();
                    }
                    if (Convert.ToInt32("0" + JW_HDR_ID.Text) > 0)
                    {
                        MABL.SQLManager.SQLProcedureCall.USP_Update_Tbl_Purchase(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, Convert.ToInt32(JW_HDR_ID.Text));
                        SetValueToControls_Edit_HDR(Convert.ToInt32("0" + JW_HDR_ID.Text));
                    }

                   
                    // DisplayCustomMessageSummary(ErrorMessage);
                }
                else
                {
                   // DisplayCustomMessageSummary(ErrorMessage);
                }
                Msg_ErrorMsg.Text = ErrorMessage;
            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary("Failed Save Data");
            }

        }
        #endregion
        #region "SetValue"
        private void SetValuesToBO_HDR()
        {
            try
            {

               ObjAT_JW_HDR.JW_HDR_ID = Convert.ToInt64("0" + JW_HDR_ID.Text);
               
               ObjAT_JW_HDR.JW_No = JW_No.Text;
               ObjAT_JW_HDR.JW_DT = JW_DT.Text;
               ObjAT_JW_HDR.Fk_VendorID =Convert.ToInt32( Fk_VendorID.Text);
              
               ObjAT_JW_HDR.JW_Remark = JW_Remark.Text;
               ObjAT_JW_HDR.MDBSC_RowStatus = MDBSC_RowStatus.Text;
               ObjAT_JW_HDR.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
               ObjAT_JW_HDR.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
               ObjAT_JW_HDR.MDBSC_RowLupdnOn_DT =  DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
               ObjAT_JW_HDR.JW_HDR_Freight_Charges = Convert.ToDecimal("0" + JW_HDR_Freight_Charges.Text);

              
               ObjAT_JW_HDR.JW_ShippTo_CompanyName = JW_ShippTo_CompanyName.Text;
               ObjAT_JW_HDR.JW_ShippTo_ContactPersone = JW_ShippTo_ContactPersone.Text;
               ObjAT_JW_HDR.JW_ShippTo_CP_MobileNo = JW_ShippTo_CP_MobileNo.Text;
               ObjAT_JW_HDR.JW_ShippTo_Add1 = JW_ShippTo_Add1.Text;
               ObjAT_JW_HDR.JW_ShippTo_Add2 = JW_ShippTo_Add2.Text;
               ObjAT_JW_HDR.JW_ShippTo_Add3 = JW_ShippTo_Add3.Text;
               ObjAT_JW_HDR.JW_ShippTo_Pincode = JW_ShippTo_Pincode.Text;

               ObjAT_JW_HDR.JW_ShippedFrom_CompanyName = JW_ShippedFrom_CompanyName.Text;
               ObjAT_JW_HDR.JW_ShippedFrom_ContactPersone = JW_ShippedFrom_ContactPersone.Text;
               ObjAT_JW_HDR.JW_ShippedFrom_CP_MobileNo = JW_ShippedFrom_CP_MobileNo.Text;
               ObjAT_JW_HDR.JW_ShippedFrom_Add1 = JW_ShippedFrom_Add1.Text;
               ObjAT_JW_HDR.JW_ShippedFrom_Add2 = JW_ShippedFrom_Add2.Text;
               ObjAT_JW_HDR.JW_ShippedFrom_Add3 = JW_ShippedFrom_Add3.Text;
               ObjAT_JW_HDR.JW_ShippedFrom_Pincode = JW_ShippedFrom_Pincode.Text;
                
               ObjAT_JW_HDR.JW_ShippedFrom_City = JW_ShippedFrom_City.Text;
               ObjAT_JW_HDR.JW_ShippedFrom_State_ID = Convert.ToInt64(JW_ShippedFrom_State_ID.Text);
               ObjAT_JW_HDR.JW_ShippedFrom_Country = JW_ShippedFrom_Country.Text;
               ObjAT_JW_HDR.JW_ShippedFrom_GSTNo = JW_ShippedFrom_GSTNo.Text;
               ObjAT_JW_HDR.JW_ShippedFrom_PANNO = JW_ShippedFrom_PANNO.Text;


               ObjAT_JW_HDR.JW_ShippTo_City = JW_ShippTo_City.Text;
               ObjAT_JW_HDR.JW_ShippTo_State_ID =Convert.ToInt64( JW_ShippTo_State_ID.Text);
               ObjAT_JW_HDR.JW_ShippTo_Country = JW_ShippTo_Country.Text;
               ObjAT_JW_HDR.JW_ShippTo_GSTNo = JW_ShippTo_GSTNo.Text;
               ObjAT_JW_HDR.JW_ShippTo_PANNO = JW_ShippTo_PANNO.Text;
                
            
              


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
     
        #endregion
        #region "EditValue"
        private void SetValueToControls_Edit_HDR(Int64 strPK)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = MABL.BL.AppDataModal.Get_JoBWork_List(strPK,"","");
                InitializeControls_HDR();
                InitializeControls_DTL();
                if (dt.Rows.Count > 0)
                { 
                    JW_HDR_ID.Text = dt.Rows[0]["JW_HDR_ID"].ToString();

                    JW_HDR_ID.Text = dt.Rows[0]["JW_HDR_ID"].ToString();
                  
                    JW_No.Text = dt.Rows[0]["JW_No"].ToString();
                    JW_DT.Text = dt.Rows[0]["vJW_DT"].ToString();
                    Fk_VendorID.Text = dt.Rows[0]["Fk_VendorID"].ToString();
                    JW_DueDT.Text = dt.Rows[0]["vJW_DueDT"].ToString();
                    JW_ModeOfDispatch.Text = dt.Rows[0]["JW_ModeOfDispatch"].ToString();
                   
                    JW_Remark.Text = dt.Rows[0]["JW_Remark"].ToString();
                   
                    MDBSC_RowStatus.Text = dt.Rows[0]["MDBSC_RowStatus"].ToString();
                  
                    MDBSC_RowCreatedByUserName.Text = dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
                    MDBSC_RowCreatedOn_DT.Text = dt.Rows[0]["vMDBSC_RowCreatedOn_DT"].ToString();
                   
                    JW_HDR_BasicAmt.Text = dt.Rows[0]["JW_HDR_BasicAmt"].ToString();
                  
                    JW_HDR_DiscountAmt.Text = dt.Rows[0]["JW_HDR_DiscountAmt"].ToString();
                    JW_HDR_Net_Amt.Text = dt.Rows[0]["JW_HDR_Net_Amt"].ToString();
                    JW_HDR_Freight_Charges.Text = dt.Rows[0]["JW_HDR_Freight_Charges"].ToString();
                     JW_HDR_CGST_Amt.Text = dt.Rows[0]["JW_HDR_CGST_Amt"].ToString();
                    
                    JW_HDR_SGST_Amt.Text = dt.Rows[0]["JW_HDR_SGST_Amt"].ToString();
                    
                    JW_HDR_IGST_Amt.Text = dt.Rows[0]["JW_HDR_IGST_Amt"].ToString();
                    
                    JW_HDR_CESS_Amt.Text = dt.Rows[0]["JW_HDR_CESS_Amt"].ToString();
                   
                    JW_HDR_Total_Tax_Amt.Text = dt.Rows[0]["JW_HDR_Total_Tax_Amt"].ToString();
                   
                    JW_HDR_Gross_Amt.Text = dt.Rows[0]["JW_HDR_Gross_Amt"].ToString();
                    JW_HDR_Round_Off_Amt.Text = dt.Rows[0]["JW_HDR_Round_Off_Amt"].ToString();
                    JW_HDR_Total_Gross_Amt.Text = dt.Rows[0]["JW_HDR_Total_Gross_Amt"].ToString();

                   //VENDOR
                    MVen_Reg_Add1.Text = dt.Rows[0]["MVen_Reg_Add1"].ToString();
                    MVen_Reg_Add2.Text = dt.Rows[0]["MVen_Reg_Add2"].ToString();
                    MVen_Reg_Add3.Text = dt.Rows[0]["MVen_Reg_Add3"].ToString();
                    MVen_Reg_Pincode.Text = dt.Rows[0]["MVen_Reg_Pincode"].ToString();
                    MVen_Reg_City.Text = dt.Rows[0]["MVen_Reg_City"].ToString();
                    MVen_Reg_StateDisplayName.Text = dt.Rows[0]["MVen_Reg_StateDisplayName"].ToString();
                    MVen_Reg_Country.Text = dt.Rows[0]["MVen_Reg_Country"].ToString();
                    MVen_BL_GSTNO.Text = dt.Rows[0]["MVen_BL_GSTNO"].ToString();
                    MVen_BL_PANNO.Text = dt.Rows[0]["MVen_BL_PANNO"].ToString();

                   //SHIP FROM 
                    JW_ShippedFrom_CompanyName.Text = dt.Rows[0]["JW_ShippedFrom_CompanyName"].ToString();
                    JW_ShippedFrom_ContactPersone.Text = dt.Rows[0]["JW_ShippedFrom_ContactPersone"].ToString();
                    JW_ShippedFrom_CP_MobileNo.Text = dt.Rows[0]["JW_ShippedFrom_CP_MobileNo"].ToString();
                    JW_ShippedFrom_Add1.Text = dt.Rows[0]["JW_ShippedFrom_Add1"].ToString();
                    JW_ShippedFrom_Add2.Text = dt.Rows[0]["JW_ShippedFrom_Add2"].ToString();
                    JW_ShippedFrom_Add3.Text = dt.Rows[0]["JW_ShippedFrom_Add3"].ToString();
                    JW_ShippedFrom_Pincode.Text = dt.Rows[0]["JW_ShippedFrom_Pincode"].ToString();
                     
                    JW_ShippedFrom_City.Text = dt.Rows[0]["JW_ShippedFrom_City"].ToString();
                    JW_ShippedFrom_State_ID.Text = dt.Rows[0]["JW_ShippedFrom_State_ID"].ToString();
                    JW_ShippedFrom_Country.Text = dt.Rows[0]["JW_ShippedFrom_Country"].ToString();
                    JW_ShippedFrom_GSTNo.Text = dt.Rows[0]["JW_ShippedFrom_GSTNo"].ToString();
                    JW_ShippedFrom_PANNO.Text = dt.Rows[0]["JW_ShippedFrom_PANNO"].ToString();
                    
                    //BILL TO
                    JW_BillTo_Add1.Text = dt.Rows[0]["BR_Reg_Add1"].ToString();
                    JW_BillTo_Add2.Text = dt.Rows[0]["BR_Reg_Add2"].ToString();
                    JW_BillTo_Add3.Text = dt.Rows[0]["BR_Reg_Add3"].ToString();
                    JW_BillTo_Pincode.Text = dt.Rows[0]["BR_Reg_Pincode"].ToString();
                    JW_BillTo_City.Text = dt.Rows[0]["BR_Reg_City"].ToString();
                    JW_BillTo_Country.Text = dt.Rows[0]["BR_Reg_Country"].ToString();
                    JW_BillTo_PANNO.Text = dt.Rows[0]["BL_PANNO"].ToString();
                    JW_BillTo_StateDisplayName.Text = dt.Rows[0]["BR_Reg_StateDisplayName"].ToString();
                    JW_BillTo_GSTNo.Text = dt.Rows[0]["BL_GSTNO"].ToString();
                    //SHIP TO
                    JW_ShippTo_CompanyName.Text = dt.Rows[0]["JW_ShippTo_CompanyName"].ToString();
                    JW_ShippTo_ContactPersone.Text = dt.Rows[0]["JW_ShippTo_ContactPersone"].ToString();
                    JW_ShippTo_CP_MobileNo.Text = dt.Rows[0]["JW_ShippTo_CP_MobileNo"].ToString();
                    JW_ShippTo_Add1.Text = dt.Rows[0]["JW_ShippTo_Add1"].ToString();
                    JW_ShippTo_Add2.Text = dt.Rows[0]["JW_ShippTo_Add2"].ToString();
                    JW_ShippTo_Add3.Text = dt.Rows[0]["JW_ShippTo_Add3"].ToString();
                    JW_ShippTo_Pincode.Text = dt.Rows[0]["JW_ShippTo_Pincode"].ToString();

                    JW_ShippTo_City.Text = dt.Rows[0]["JW_ShippTo_City"].ToString();
                    JW_ShippTo_State_ID.Text = dt.Rows[0]["JW_ShippTo_State_ID"].ToString();
                    JW_ShippTo_Country.Text = dt.Rows[0]["JW_ShippTo_Country"].ToString();
                    JW_ShippTo_GSTNo.Text = dt.Rows[0]["JW_ShippTo_GSTNo"].ToString();
                    JW_ShippTo_PANNO.Text = dt.Rows[0]["JW_ShippTo_PANNO"].ToString();

                    
                    TaxType_Toggel();
                    RefreshGrid_Item_DTL();

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
                SetValueToControls_Edit_HDR(0 + Convert.ToInt32(row.Cells[0].Text));
                MultiView1.ActiveViewIndex = 1;
            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary(ex.Message);
            }

        }

        protected void lnkItemEdit_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                ImageButton lnkItemEdit = (ImageButton)sender;
                GridViewRow row = (GridViewRow)lnkItemEdit.NamingContainer;
                lnkItemEdit = (ImageButton)row.FindControl("lnkItemEdit");                 
                InitializeControls_DTL();
                DataTable dt = new DataTable();
                dt =MABL.BL.AppDataModal.Get_JoBWork_Item_List (Convert.ToInt64(JW_HDR_ID.Text), Convert.ToInt64(row.Cells[0].Text),"", "");
                if (dt.Rows.Count > 0)
                {
                    JW_DTL_ID.Text = dt.Rows[0]["JW_DTL_ID"].ToString();
                    Fk_MItem_ID.Text = dt.Rows[0]["Fk_MItem_ID"].ToString();
                    JW_HSNCode.Text = dt.Rows[0]["JW_HSNCode"].ToString();
                    JW_QTY.Text = dt.Rows[0]["JW_QTY"].ToString();
                    JW_BasicRate.Text = dt.Rows[0]["JW_BasicRate"].ToString();
                    JW_DiscountRate.Text = dt.Rows[0]["JW_DiscountRate"].ToString();
                   
                    JW_ItemRemark_DTL.Text = dt.Rows[0]["JW_ItemRemark_DTL"].ToString();
                   
                }

            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary(ex.Message);
            }
        }
       
        #endregion
        #region "Delete"
        protected void lnkItemDelete_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                ImageButton lnkItemDelete = (ImageButton)sender;
                GridViewRow row = (GridViewRow)lnkItemDelete.NamingContainer;
                lnkItemDelete = (ImageButton)row.FindControl("lnkItemDelete");
                string RetMesg = MaheshAF18.Application.SQLManager.DeleteSRMD("", "M_AT_Proc_JW_BDTL", "Fk_JW_HDR_ID", Convert.ToInt64(0 + row.Cells[1].Text), "JW_DTL_ID", Convert.ToInt64(0 + row.Cells[0].Text), "C", "");
                MABL.SQLManager.SQLProcedureCall.USP_Update_Tbl_Purchase(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, Convert.ToInt32(JW_HDR_ID.Text));
                SetValueToControls_Edit_HDR(Convert.ToInt32(JW_HDR_ID.Text));
                DisplayCustomMessageSummary(RetMesg);
            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary(ex.Message);
            }
        }
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
        protected void gvdtl_RowCreated(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.Pager)
            {
                e.Row.Cells[0].Visible = true;
            }
            if (e.Row.RowType == DataControlRowType.DataRow | e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Visible = false;
                e.Row.Cells[1].Visible = false;
                e.Row.Cells[2].Visible = false;
                if (JW_Taxtype.Text == "IGST")
                {
                    e.Row.Cells[14].Visible = false;
                    e.Row.Cells[15].Visible = false;
                    e.Row.Cells[16].Visible = false;
                    e.Row.Cells[17].Visible = false;

                }
                if (JW_Taxtype.Text == "SGST")
                {
                    e.Row.Cells[18].Visible = false;
                    e.Row.Cells[19].Visible = false;
                }


            }
        }
        #endregion
        #region "Row DataBound"

        protected void gvdtl_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {

               

            }
        }


        #endregion
        #region "Click Events"

        #endregion
        #region 'Print'
        protected void btnPrint_Click(object sender, System.EventArgs e)
        {
            try
            {
                //SessionUserData.AppInfo.TempStrVariable_1 = JW_Taxtype.Text;
                //SessionUserData.AppInfo.TempIntVariable_1 = Convert.ToInt64(JW_HDR_ID.Text);
                //Response.Write("<script type='text/javascript'>detailedresults=window.open('" + MABL.BL.AppVariable.Project_Constant("RptBrowse") + "/ReportBrowser/JobWork.aspx');</script>");
                SessionUserData.AppInfo.TempIntVariable_1 = Convert.ToInt64(JW_HDR_ID.Text);
               // Response.Write("<script type='text/javascript'>detailedresults=window.open('" + MABL.BL.AppVariable.Project_Constant("RptBrowse") + "/ReportBrowser/JobWorkRpt.aspx');</script>");
               Response.Write("<script type='text/javascript'>detailedresults=window.open('" + MABL.BL.AppVariable.Project_Constant("RptBrowse") + "/ReportBrowser/JW.aspx');</script>");
 

            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary("Failed To Load Report Data");
            }

        }
        protected void lnkPrint_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            try
            {
                ImageButton lnkPrint = (ImageButton)sender;
                GridViewRow row = (GridViewRow)lnkPrint.NamingContainer;
                if ((row.Cells[5].Text == "SGST") || (row.Cells[5].Text == "IGST"))
                {
                  //  Response.Write("<script type='text/javascript'>detailedresults=window.open('" + MABL.AppVariable.Project_Constant("RptBrowse") + "/ReportBrowser/GSTInvBrowser.aspx?InvoiceType=" + row.Cells[5].Text + "&INVID=" + row.Cells[0].Text + "');</script>");
                }
                else
                {
                    DisplayCustomMessageSummary("Invalid Invoice Type");
                }
                
                //  MABL.AppVariable.PrintDosReport_Invoice(row.Cells[0].Text);
                
            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary(ex.Message);
            }
        }
        #endregion
        #region "SelectedIndexChanged"

        protected void Fk_MItem_ID_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = MABL.BL.AppDataModal.Get_Mst_Item(Convert.ToInt64(Fk_MItem_ID.Text), "", "");
            if (dt.Rows.Count > 0)
            {
                JW_HSNCode.Text = dt.Rows[0]["HSNCode"].ToString();
                JW_BasicRate.Text = dt.Rows[0]["Item_Purchase_Rate"].ToString();
                JW_QTY.Text = "1";
                JW_DiscountRate.Text = "0";
                JW_ItemRemark_DTL.Text = dt.Rows[0]["Item_Desc"].ToString();
            }
            else
            {
                JW_HSNCode.Text ="";
                JW_BasicRate.Text = "0";
                JW_QTY.Text = "1";
                JW_DiscountRate.Text = "0";
                JW_ItemRemark_DTL.Text = "";
            }

        }
        protected void Fk_VendorID_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = MABL.BL.AppDataModal.Get_Mst_Vendor(Convert.ToInt64(Fk_VendorID.Text), "","");
            if (dt.Rows.Count > 0)
            {
                JW_CreditDays.Text = dt.Rows[0]["MVen_CreditDays"].ToString();
                JW_ShippedFrom_State_ID.Text = dt.Rows[0]["MVen_DispatchFrom_State_ID"].ToString();
                MVen_Reg_Add1.Text = dt.Rows[0]["MVen_Reg_Add1"].ToString();
                MVen_Reg_Add2.Text = dt.Rows[0]["MVen_Reg_Add2"].ToString();
                MVen_Reg_Add3.Text = dt.Rows[0]["MVen_Reg_Add3"].ToString();
                MVen_Reg_Pincode.Text = dt.Rows[0]["MVen_Reg_Pincode"].ToString();
                MVen_Reg_City.Text = dt.Rows[0]["MVen_Reg_City"].ToString();
                MVen_Reg_StateDisplayName.Text = dt.Rows[0]["MVen_Reg_StateDisplayName"].ToString();
                MVen_Reg_Country.Text = dt.Rows[0]["MVen_Reg_Country"].ToString();
                MVen_BL_GSTNO.Text = dt.Rows[0]["MVen_BL_GSTNO"].ToString();
                MVen_BL_PANNO.Text = dt.Rows[0]["MVen_BL_PANNO"].ToString();


                JW_ShippedFrom_CompanyName.Text = dt.Rows[0]["MVen_DispatchFrom_CompanyName"].ToString();
                JW_ShippedFrom_ContactPersone.Text = dt.Rows[0]["MVen_DispatchFrom_ContactPerson"].ToString();
                JW_ShippedFrom_CP_MobileNo.Text = dt.Rows[0]["MVen_DispatchFrom_CP_MobileNo"].ToString();
                JW_ShippedFrom_Add1.Text = dt.Rows[0]["MVen_DispatchFrom_Add1"].ToString();
                JW_ShippedFrom_Add2.Text = dt.Rows[0]["MVen_DispatchFrom_Add2"].ToString();
                JW_ShippedFrom_Add3.Text = dt.Rows[0]["MVen_DispatchFrom_Add3"].ToString();
                JW_ShippedFrom_Pincode.Text = dt.Rows[0]["MVen_DispatchFrom_Pincode"].ToString();
                JW_ShippedFrom_City.Text = dt.Rows[0]["MVen_DispatchFrom_City"].ToString();
                JW_ShippedFrom_Country.Text = dt.Rows[0]["MVen_DispatchFrom_Country"].ToString();
                JW_ShippedFrom_GSTNo.Text = dt.Rows[0]["MVen_DispatchFrom_GSTNO"].ToString();
                JW_ShippedFrom_PANNO.Text = dt.Rows[0]["MVen_DispatchFrom_PANNO"].ToString(); 




            }
            else
            {
                JW_CreditDays.Text = "0";
                JW_ShippedFrom_State_ID.SelectedIndex = 0;
                MVen_Reg_Add1.Text = "";
                MVen_Reg_Add2.Text = "";
                MVen_Reg_Add3.Text = "";
                MVen_Reg_Pincode.Text = "";
                MVen_Reg_City.Text = "";
                MVen_Reg_StateDisplayName.Text = "";
                MVen_Reg_Country.Text = "";
                MVen_BL_GSTNO.Text = "";
                MVen_BL_PANNO.Text = ""; 
            }

            DataTable dt_BranchDetails = new DataTable();
            if (dt.Rows.Count > 0)
            {
            }
            else
            {
                //Branch Details
                JW_ShippTo_State_ID.SelectedIndex = 0;
                JW_BillTo_Add1.Text = "";
                JW_BillTo_Add2.Text = "";
                JW_BillTo_Add3.Text = "";
                JW_BillTo_Pincode.Text = "";
                JW_BillTo_City.Text = "";
                JW_BillTo_StateDisplayName.Text = "";
                JW_BillTo_Country.Text = "";
                JW_BillTo_GSTNo.Text = "";
                JW_BillTo_PANNO.Text = "";


                JW_ShippTo_CompanyName.Text = "";
                JW_ShippTo_ContactPersone.Text = "";
                JW_ShippTo_CP_MobileNo.Text = "";
                JW_ShippTo_Add1.Text = "";
                JW_ShippTo_Add2.Text = "";
                JW_ShippTo_Add3.Text = "";

                JW_ShippTo_Pincode.Text = "";
                JW_ShippTo_City.Text = "";

                JW_ShippTo_Country.Text = "";
                JW_ShippTo_GSTNo.Text = "";
                JW_ShippTo_PANNO.Text = "";
            }
                       
            TaxType_Toggel();

        }
        protected void PurchaseState_SelectedIndexChanged(object sender, EventArgs e)
        {

            TaxType_Toggel();

        }
      
        #endregion
        #region "Function"
        private void TaxType_Toggel()
        {
            try
            {
                Div_CGST_HDR.Visible = false;
                Div_SGST_HDR.Visible = false;
                Div_IGST_HDR.Visible = false;

                if (JW_ShippedFrom_State_ID.Text == JW_ShippTo_State_ID.Text)
                {
                    JW_Taxtype.Text = "SGST";
                }
                else
                {
                    JW_Taxtype.Text = "IGST";
                }


                if (JW_Taxtype.Text == "IGST")
                {
                    Div_IGST_HDR.Visible = true;
                    
                }
                if (JW_Taxtype.Text == "SGST")
                {
                    Div_CGST_HDR.Visible = true;
                    Div_SGST_HDR.Visible = true;

                   

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
     
        #endregion
    }
}