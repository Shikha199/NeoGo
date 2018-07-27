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


namespace JEMEA.Purchase
{
    public partial class PurchaseInv : Mahesh_Page
    {
        M_AT_Purchase_Inv_AHDRBO ObjAT_PINV_HDR;
            M_AT_Purchase_Inv_BDTLBO ObjAT_PINV_DTL;
            M_AT_Purchase_Inv_TaxDTLBO ObjAT_PINV_TDTL;
             

      
        protected void Page_Load(object sender, EventArgs e)
        {

            PageMenuID = Request.QueryString["ID"];
            //SessionData.UserAccess.MenuID = PageMenuID;

            ObjAT_PINV_HDR = new M_AT_Purchase_Inv_AHDRBO();
            ObjAT_PINV_DTL = new M_AT_Purchase_Inv_BDTLBO();
            ObjAT_PINV_TDTL = new M_AT_Purchase_Inv_TaxDTLBO();
             
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

                CE_PINV_DT.EndDate = DateTime.Now;
                CE_PINV_PO_DT.EndDate = DateTime.Now;


                SetValueType(TextType.DateField, Txt_FromDT);
                SetValueType(TextType.DateField, Txt_ToDT);
                SetValueType(TextType.AmountField, PINV_QTY);
                SetValueType(TextType.AlphNumericField_4, PINV_BasicRate);
                SetValueType(TextType.AmountField, PINV_DiscountRate);

                SetValueType(TextType.DateField, PINV_DT);
                SetValueType(TextType.NumericField, PINV_CreditDays);
                SetValueType(TextType.DateField, PINV_DueDT);
                SetValueType(TextType.DateField, PINV_PO_DT);
                SetValueType(TextType.DateField, MDBSC_RowCreatedOn_DT);
                SetValueType(TextType.AmountField, PINV_HDR_BasicAmt);
                SetValueType(TextType.AmountField, PINV_HDR_DiscountAmt);
                SetValueType(TextType.AmountField, PINV_HDR_Net_Amt);
                SetValueType(TextType.AmountField, PINV_HDR_Freight_Charges);
                SetValueType(TextType.AmountField, PINV_HDR_CGST_Amt);
                SetValueType(TextType.AmountField, PINV_HDR_SGST_Amt);
                SetValueType(TextType.AmountField, PINV_HDR_IGST_Amt);
                SetValueType(TextType.AmountField, PINV_HDR_CESS_Amt);
                SetValueType(TextType.AmountField, PINV_HDR_Gross_Amt);
                SetValueType(TextType.AmountField, PINV_HDR_Round_Off_Amt);
                SetValueType(TextType.AmountField, PINV_HDR_Total_Gross_Amt);
                SetValueType(TextType.AmountField, PINV_HDR_Total_Tax_Amt);
                
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
            PINV_ShippedFrom_State_ID.DataSource = dt;
            PINV_ShippedFrom_State_ID.DataBind();

            PINV_ShippTo_State_ID.DataSource = dt;
            PINV_ShippTo_State_ID.DataBind();
            
           
        }
        #endregion
        #region "Refrish Grid Functions"
        private void RefreshGrid_HDR(string SearchCriteria = "")
        {
            try
            {
                string var_SQLFilter = "";
                var_SQLFilter = var_SQLFilter + " AND PINV_Category ='Tax Purchase'";

                if ((Txt_FromDT.Text.Length > 0) && (Txt_ToDT.Text.Length > 0))
                {
                    var_SQLFilter = var_SQLFilter + " AND PINV_DT BETWEEN  '" + Txt_FromDT.Text + "' AND  '" + Txt_ToDT.Text + "'";
                }
                DataTable dt = default(DataTable);
                dt = MABL.BL.AppDataModal.Get_Purchase_List(0, var_SQLFilter, SearchCriteria);
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
                dt = MABL.BL.AppDataModal.Get_Purchase_Item_List(Convert.ToInt64(PINVHDR_ID.Text), Convert.ToInt64(PINVDTL_ID.Text),"", "");
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
                //dt = dt = MABL.BL.AppDataModal.Get_Purchase_Tax_List(Convert.ToInt64(PINVHDR_ID.Text),0, "", "");
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
               
                PINVHDR_ID.Text = "0";               
                Fk_VendorID.SelectedIndex = 0;                
                Msg_ErrorMsg.Text = "";
               
                PINV_Taxtype.Text = "";
                PINV_No.Text = "";
                PINV_DT.Text = "";

              
                PINV_CreditDays.Text = "30";
                PINV_DueDT.Text = "";
                PINV_PONo.Text = "";
                PINV_PO_DT.Text = "";
                PINV_Remark.Text = "";
                MDBSC_RowStatus.Text = "";
                MDBSC_RowCreatedByUserName.Text = SessionUserData.UserData.UserName;
                MDBSC_RowCreatedOn_DT.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
                PINV_HDR_BasicAmt.Text = "0.00";
                PINV_HDR_DiscountAmt.Text = "0.00";
                PINV_HDR_Net_Amt.Text = "0.00";
                PINV_HDR_Freight_Charges.Text = "0.00";
                PINV_HDR_CGST_Amt.Text = "0.00";
                PINV_HDR_SGST_Amt.Text = "0.00";
                PINV_HDR_IGST_Amt.Text = "0.00";
                PINV_HDR_CESS_Amt.Text = "0.00";
                PINV_HDR_Gross_Amt.Text = "0.00";
                PINV_HDR_Round_Off_Amt.Text = "0.00";
                PINV_HDR_Total_Gross_Amt.Text = "0.00";

                PINV_HDR_Total_Tax_Amt.Text = "0.00";

                PINV_CreditDays.Text = "0";
                PINV_ShippedFrom_State_ID.SelectedIndex = 0;
                MVen_Reg_Add1.Text = "";
                MVen_Reg_Add2.Text = "";
                MVen_Reg_Add3.Text = "";
                MVen_Reg_Pincode.Text = "";
                MVen_Reg_City.Text = "";
                MVen_Reg_StateDisplayName.Text = "";
                MVen_Reg_Country.Text = "";
                MVen_BL_GSTNO.Text = "";
                MVen_BL_PANNO.Text = "";

                PINV_ShippTo_State_ID.SelectedIndex = 0;
                PINV_BillTo_Add1.Text = "";
                PINV_BillTo_Add2.Text = "";
                PINV_BillTo_Add3.Text = "";
                PINV_BillTo_Pincode.Text = "";
                PINV_BillTo_City.Text = "";
                PINV_BillTo_StateDisplayName.Text = "";
                PINV_BillTo_Country.Text = "";
                PINV_BillTo_GSTNo.Text = "";
                PINV_BillTo_PANNO.Text = "";


                PINV_ShippTo_CompanyName.Text = "";
                PINV_ShippTo_ContactPersone.Text = "";
                PINV_ShippTo_CP_MobileNo.Text = "";
                PINV_ShippTo_Add1.Text = "";
                PINV_ShippTo_Add2.Text = "";
                PINV_ShippTo_Add3.Text = "";

                PINV_ShippedFrom_CompanyName.Text = "";
                PINV_ShippedFrom_ContactPersone.Text = "";
                PINV_ShippedFrom_CP_MobileNo.Text = "";
                PINV_ShippedFrom_Add1.Text = "";
                PINV_ShippedFrom_Add2.Text = "";
                PINV_ShippedFrom_Add3.Text = "";
                PINV_ShippedFrom_Pincode.Text = "";
                 
                PINV_ShippedFrom_City.Text = "";
                 
                PINV_ShippedFrom_Country.Text = "";
                PINV_ShippedFrom_GSTNo.Text = "";
                PINV_ShippedFrom_PANNO.Text = "";


                PINV_ShippTo_Pincode.Text = "";
                PINV_ShippTo_City.Text = "";

                PINV_ShippTo_Country.Text = "";
                PINV_ShippTo_GSTNo.Text = "";
                PINV_ShippTo_PANNO.Text = "";
                
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

                PINVDTL_ID.Text = "0";
                Fk_MItem_ID.SelectedIndex = 0;
                PINV_BasicRate.Text = "0";
                PINV_HSNCode.Text="";
                PINV_QTY.Text = "0"; 
                PINV_DiscountRate.Text = "0";
                PINV_ItemRemark_DTL.Text = "";
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
                    ErrorMessage = ErrorMessage + "Select Vendor.<br>";
                }
                if (PINV_No.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Vendor Invoice No Cannot Be Blank.<br>";
                }

                if (PINV_ShippedFrom_State_ID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Place Of Dispatch<br>";
                }


                if (PINV_ShippTo_State_ID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Place Of Supply<br>";
                }

                if (PINV_ShippedFrom_GSTNo.Text.Length != 15)
                {
                    ErrorMessage = ErrorMessage + "Invalid Ship From GSTNO<br>";
                }
                if (PINV_ShippTo_GSTNo.Text.Length != 15)
                {
                    ErrorMessage = ErrorMessage + "Invalid Ship To GSTNO<br>";
                }

                if (PINV_ShippedFrom_PANNO.Text.Length != 10)
                {
                    ErrorMessage = ErrorMessage + "Invalid Ship From PAN No<br>";
                }
                if (PINV_ShippTo_PANNO.Text.Length != 10)
                {
                    ErrorMessage = ErrorMessage + "Invalid Ship To PAN No<br>";
                }



                if ((PINV_No.Text.Length > 0) && (Fk_VendorID.SelectedIndex > 0))
                {
                     if (SQLManager.CheckDuplicateRecord("M_AT_Purchase_Inv_AHDR", "PINVHDR_ID", Convert.ToInt32("0" + PINVHDR_ID.Text), "PINV_No", PINV_No.Text,
                                                        " AND Fk_Branch_ID=" + SessionUserData.Company.BranchID + " AND  Fk_VendorID=" + Fk_VendorID.Text))
                    {
                        ErrorMessage = ErrorMessage + "Vendor Purchase Invoice Already Exist.<br>";
                    }
                }
                
                if (PINV_DT.Text.Length != 11)
                {
                    ErrorMessage = ErrorMessage + "Invalid Vendor Invoice Date.<br>";
                }
                if ((Fk_VendorID.SelectedIndex > 0 ) && (Convert.ToInt32(PINVHDR_ID.Text) == 0)) 
                {
                    if (Fk_MItem_ID.SelectedIndex == 0)
                    {
                        ErrorMessage = ErrorMessage + "Pls Select Item<br>";
                    }
                    if (PINV_BasicRate.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Rate<br>";
                    }
                    if (PINV_QTY.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Quantity<br>";
                    }
                    else
                    {
                        if (Convert.ToDecimal(PINV_QTY.Text) <= 0)
                        {
                            ErrorMessage = ErrorMessage + "Invalid Item Quantity<br>";
                        }
                    }
                }
                if ((Convert.ToInt32(PINVHDR_ID.Text) > 0) && (Convert.ToInt32(PINVDTL_ID.Text) > 0) && (Fk_MItem_ID.SelectedIndex > 0))
                {
                    if (Fk_MItem_ID.SelectedIndex == 0)
                    {
                        ErrorMessage = ErrorMessage + "Pls Select Item<br>";
                    }
                    if (PINV_BasicRate.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Rate<br>";
                    }
                    if (PINV_QTY.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Quantity<br>";
                    }
                    else
                    {
                        if (Convert.ToDecimal(PINV_QTY.Text) <= 0)
                        {
                            ErrorMessage = ErrorMessage + "Invalid Item Quantity<br>";
                        }
                    }
                }


                if (ErrorMessage.Length == 0)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (Convert.ToInt32(PINVHDR_ID.Text) == 0)
                        {
                            ObjAT_PINV_HDR.Fk_Company_ID = SessionUserData.Company.CompanyID;
                            ObjAT_PINV_HDR.Fk_Branch_ID = SessionUserData.Company.BranchID;
                            ObjAT_PINV_HDR.Fk_Year_ID = SessionUserData.Company.YearID;
                            ObjAT_PINV_HDR.Rec_Created_In ="HO";
                            ObjAT_PINV_HDR.Rec_CreatedBy_ID = SessionUserData.Company.BranchID;
                            ObjAT_PINV_HDR.Rec_CreatedFor_ID = SessionUserData.Company.BranchID;
                            ObjAT_PINV_HDR.PINV_CreationType = "Manual";
                            ObjAT_PINV_HDR.PINV_Category = "Tax Purchase";                
                            ObjAT_PINV_HDR.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName;
                            ObjAT_PINV_HDR.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                            

                        }
                        SetValuesToBO_HDR();
                        ErrorMessage = ObjAT_PINV_HDR.Insert_Update(ObjAT_PINV_HDR);
                        PINVHDR_ID.Text = ErrorMessage.Substring((ErrorMessage.IndexOf("|") + 1), (ErrorMessage.Length - ErrorMessage.IndexOf("|") - 1));
                        ErrorMessage = ErrorMessage.Substring((0), (ErrorMessage.IndexOf("|")));

                        if ((Convert.ToInt32(PINVHDR_ID.Text) > 0) && (Fk_MItem_ID.SelectedIndex > 0))
                        {
                            if (Convert.ToInt32(PINVDTL_ID.Text)== 0)
                            {
                                ObjAT_PINV_DTL.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                                ObjAT_PINV_DTL.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName; 
                            }

                            ObjAT_PINV_DTL.PINVDTL_ID = Convert.ToInt64("0" + PINVDTL_ID.Text);
                            ObjAT_PINV_DTL.Fk_PINVHDR_ID = Convert.ToInt64("0" + PINVHDR_ID.Text);
                            ObjAT_PINV_DTL.Fk_MItem_ID = Convert.ToInt64("0" + Fk_MItem_ID.Text);
                            ObjAT_PINV_DTL.PINV_HSNCode = PINV_HSNCode.Text;
                            ObjAT_PINV_DTL.PINV_QTY =Convert.ToDecimal( PINV_QTY.Text);
                            ObjAT_PINV_DTL.PINV_Final_Qty = Convert.ToDecimal(PINV_QTY.Text);
                            ObjAT_PINV_DTL.PINV_BasicRate = Convert.ToDecimal(PINV_BasicRate.Text);
                            ObjAT_PINV_DTL.PINV_DiscountRate = Convert.ToDecimal(PINV_DiscountRate.Text);
                            ObjAT_PINV_DTL.PINV_CGST_ID = 0;
                            ObjAT_PINV_DTL.PINV_SGST_ID = 0;
                            ObjAT_PINV_DTL.PINV_IGST_ID = 0;
                            ObjAT_PINV_DTL.PINV_CESS_ID = 0;
                            
                            ObjAT_PINV_DTL.PINV_ItemRemark_DTL = PINV_ItemRemark_DTL.Text;
                            ObjAT_PINV_DTL.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
                            ObjAT_PINV_DTL.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
                            ObjAT_PINV_DTL.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));

                            ObjAT_PINV_DTL.Insert_Update(ObjAT_PINV_DTL);
                            
                            
                        }

                        scope.Complete();
                    }
                    if (Convert.ToInt32("0" + PINVHDR_ID.Text) > 0)
                    {
                        MABL.SQLManager.SQLProcedureCall.USP_Update_Tbl_Purchase(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, Convert.ToInt32(PINVHDR_ID.Text));
                        SetValueToControls_Edit_HDR(Convert.ToInt32("0" + PINVHDR_ID.Text));
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

               ObjAT_PINV_HDR.PINVHDR_ID = Convert.ToInt64("0" + PINVHDR_ID.Text);
               
               ObjAT_PINV_HDR.PINV_No = PINV_No.Text;
               ObjAT_PINV_HDR.PINV_DT = PINV_DT.Text;
               ObjAT_PINV_HDR.Fk_VendorID =Convert.ToInt32( Fk_VendorID.Text);
               ObjAT_PINV_HDR.PINV_CreditDays = Convert.ToInt32("0" + PINV_CreditDays.Text);  
               ObjAT_PINV_HDR.PINV_PONo = PINV_PONo.Text;
               if (PINV_PO_DT.Text.Length == 11)
               {
                   ObjAT_PINV_HDR.PINV_PO_DT = PINV_PO_DT.Text;
               }
               ObjAT_PINV_HDR.PINV_Remark = PINV_Remark.Text;
               ObjAT_PINV_HDR.MDBSC_RowStatus = MDBSC_RowStatus.Text;
               ObjAT_PINV_HDR.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
               ObjAT_PINV_HDR.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
               ObjAT_PINV_HDR.MDBSC_RowLupdnOn_DT =  DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
               ObjAT_PINV_HDR.PINV_HDR_Freight_Charges = Convert.ToDecimal("0" + PINV_HDR_Freight_Charges.Text);
               
               ObjAT_PINV_HDR.PINV_BillTo_Add1 = PINV_BillTo_Add1.Text;
               ObjAT_PINV_HDR.PINV_BillTo_Add2 = PINV_BillTo_Add2.Text;
               ObjAT_PINV_HDR.PINV_BillTo_Add3 = PINV_BillTo_Add3.Text;
               ObjAT_PINV_HDR.PINV_BillTo_Pincode = PINV_BillTo_Pincode.Text;
               ObjAT_PINV_HDR.PINV_BillTo_City = PINV_BillTo_City.Text;
               ObjAT_PINV_HDR.PINV_BillTo_Country = PINV_BillTo_Country.Text;
               ObjAT_PINV_HDR.PINV_BillTo_PANNO = PINV_BillTo_PANNO.Text;
               ObjAT_PINV_HDR.PINV_ShippTo_CompanyName = PINV_ShippTo_CompanyName.Text;
               ObjAT_PINV_HDR.PINV_ShippTo_ContactPersone = PINV_ShippTo_ContactPersone.Text;
               ObjAT_PINV_HDR.PINV_ShippTo_CP_MobileNo = PINV_ShippTo_CP_MobileNo.Text;
               ObjAT_PINV_HDR.PINV_ShippTo_Add1 = PINV_ShippTo_Add1.Text;
               ObjAT_PINV_HDR.PINV_ShippTo_Add2 = PINV_ShippTo_Add2.Text;
               ObjAT_PINV_HDR.PINV_ShippTo_Add3 = PINV_ShippTo_Add3.Text;
               ObjAT_PINV_HDR.PINV_ShippTo_Pincode = PINV_ShippTo_Pincode.Text;

               ObjAT_PINV_HDR.PINV_ShippedFrom_CompanyName = PINV_ShippedFrom_CompanyName.Text;
               ObjAT_PINV_HDR.PINV_ShippedFrom_ContactPersone = PINV_ShippedFrom_ContactPersone.Text;
               ObjAT_PINV_HDR.PINV_ShippedFrom_CP_MobileNo = PINV_ShippedFrom_CP_MobileNo.Text;
               ObjAT_PINV_HDR.PINV_ShippedFrom_Add1 = PINV_ShippedFrom_Add1.Text;
               ObjAT_PINV_HDR.PINV_ShippedFrom_Add2 = PINV_ShippedFrom_Add2.Text;
               ObjAT_PINV_HDR.PINV_ShippedFrom_Add3 = PINV_ShippedFrom_Add3.Text;
               ObjAT_PINV_HDR.PINV_ShippedFrom_Pincode = PINV_ShippedFrom_Pincode.Text;
                
               ObjAT_PINV_HDR.PINV_ShippedFrom_City = PINV_ShippedFrom_City.Text;
               ObjAT_PINV_HDR.PINV_ShippedFrom_State_ID = Convert.ToInt64(PINV_ShippedFrom_State_ID.Text);
               ObjAT_PINV_HDR.PINV_ShippedFrom_Country = PINV_ShippedFrom_Country.Text;
               ObjAT_PINV_HDR.PINV_ShippedFrom_GSTNo = PINV_ShippedFrom_GSTNo.Text;
               ObjAT_PINV_HDR.PINV_ShippedFrom_PANNO = PINV_ShippedFrom_PANNO.Text;


               ObjAT_PINV_HDR.PINV_ShippTo_City = PINV_ShippTo_City.Text;
               ObjAT_PINV_HDR.PINV_ShippTo_State_ID =Convert.ToInt64( PINV_ShippTo_State_ID.Text);
               ObjAT_PINV_HDR.PINV_ShippTo_Country = PINV_ShippTo_Country.Text;
               ObjAT_PINV_HDR.PINV_ShippTo_GSTNo = PINV_ShippTo_GSTNo.Text;
               ObjAT_PINV_HDR.PINV_ShippTo_PANNO = PINV_ShippTo_PANNO.Text;
                
            
              


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
                dt = MABL.BL.AppDataModal.Get_Purchase_List(strPK,"","");
                InitializeControls_HDR();
                InitializeControls_DTL();
                if (dt.Rows.Count > 0)
                { 
                    PINVHDR_ID.Text = dt.Rows[0]["PINVHDR_ID"].ToString();

                    PINVHDR_ID.Text = dt.Rows[0]["PINVHDR_ID"].ToString();
                    PINV_Taxtype.Text = dt.Rows[0]["PINV_Taxtype"].ToString();
                    PINV_No.Text = dt.Rows[0]["PINV_No"].ToString();
                    PINV_DT.Text = dt.Rows[0]["vPINV_DT"].ToString();
                    Fk_VendorID.Text = dt.Rows[0]["Fk_VendorID"].ToString();
                    PINV_CreditDays.Text = dt.Rows[0]["PINV_CreditDays"].ToString();
                    PINV_DueDT.Text = dt.Rows[0]["vPINV_DueDT"].ToString();
                    PINV_PONo.Text = dt.Rows[0]["PINV_PONo"].ToString();
                    PINV_PO_DT.Text = dt.Rows[0]["vPINV_PO_DT"].ToString(); 
                  
                    PINV_ModeOfDispatch.Text = dt.Rows[0]["PINV_ModeOfDispatch"].ToString();
                   
                    PINV_Remark.Text = dt.Rows[0]["PINV_Remark"].ToString();
                   
                    MDBSC_RowStatus.Text = dt.Rows[0]["MDBSC_RowStatus"].ToString();
                  
                    MDBSC_RowCreatedByUserName.Text = dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
                    MDBSC_RowCreatedOn_DT.Text = dt.Rows[0]["vMDBSC_RowCreatedOn_DT"].ToString();
                   
                    PINV_HDR_BasicAmt.Text = dt.Rows[0]["PINV_HDR_BasicAmt"].ToString();
                  
                    PINV_HDR_DiscountAmt.Text = dt.Rows[0]["PINV_HDR_DiscountAmt"].ToString();
                    PINV_HDR_Net_Amt.Text = dt.Rows[0]["PINV_HDR_Net_Amt"].ToString();
                    PINV_HDR_Freight_Charges.Text = dt.Rows[0]["PINV_HDR_Freight_Charges"].ToString();
                     PINV_HDR_CGST_Amt.Text = dt.Rows[0]["PINV_HDR_CGST_Amt"].ToString();
                    
                    PINV_HDR_SGST_Amt.Text = dt.Rows[0]["PINV_HDR_SGST_Amt"].ToString();
                    
                    PINV_HDR_IGST_Amt.Text = dt.Rows[0]["PINV_HDR_IGST_Amt"].ToString();
                    
                    PINV_HDR_CESS_Amt.Text = dt.Rows[0]["PINV_HDR_CESS_Amt"].ToString();
                   
                    PINV_HDR_Total_Tax_Amt.Text = dt.Rows[0]["PINV_HDR_Total_Tax_Amt"].ToString();
                   
                    PINV_HDR_Gross_Amt.Text = dt.Rows[0]["PINV_HDR_Gross_Amt"].ToString();
                    PINV_HDR_Round_Off_Amt.Text = dt.Rows[0]["PINV_HDR_Round_Off_Amt"].ToString();
                    PINV_HDR_Total_Gross_Amt.Text = dt.Rows[0]["PINV_HDR_Total_Gross_Amt"].ToString();

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
                    PINV_ShippedFrom_CompanyName.Text = dt.Rows[0]["PINV_ShippedFrom_CompanyName"].ToString();
                    PINV_ShippedFrom_ContactPersone.Text = dt.Rows[0]["PINV_ShippedFrom_ContactPersone"].ToString();
                    PINV_ShippedFrom_CP_MobileNo.Text = dt.Rows[0]["PINV_ShippedFrom_CP_MobileNo"].ToString();
                    PINV_ShippedFrom_Add1.Text = dt.Rows[0]["PINV_ShippedFrom_Add1"].ToString();
                    PINV_ShippedFrom_Add2.Text = dt.Rows[0]["PINV_ShippedFrom_Add2"].ToString();
                    PINV_ShippedFrom_Add3.Text = dt.Rows[0]["PINV_ShippedFrom_Add3"].ToString();
                    PINV_ShippedFrom_Pincode.Text = dt.Rows[0]["PINV_ShippedFrom_Pincode"].ToString();
                     
                    PINV_ShippedFrom_City.Text = dt.Rows[0]["PINV_ShippedFrom_City"].ToString();
                    PINV_ShippedFrom_State_ID.Text = dt.Rows[0]["PINV_ShippedFrom_State_ID"].ToString();
                    PINV_ShippedFrom_Country.Text = dt.Rows[0]["PINV_ShippedFrom_Country"].ToString();
                    PINV_ShippedFrom_GSTNo.Text = dt.Rows[0]["PINV_ShippedFrom_GSTNo"].ToString();
                    PINV_ShippedFrom_PANNO.Text = dt.Rows[0]["PINV_ShippedFrom_PANNO"].ToString();
                    
                    //BILL TO
                    PINV_BillTo_Add1.Text = dt.Rows[0]["BR_Reg_Add1"].ToString();
                    PINV_BillTo_Add2.Text = dt.Rows[0]["BR_Reg_Add2"].ToString();
                    PINV_BillTo_Add3.Text = dt.Rows[0]["BR_Reg_Add3"].ToString();
                    PINV_BillTo_Pincode.Text = dt.Rows[0]["BR_Reg_Pincode"].ToString();
                    PINV_BillTo_City.Text = dt.Rows[0]["BR_Reg_City"].ToString();
                    PINV_BillTo_Country.Text = dt.Rows[0]["BR_Reg_Country"].ToString();
                    PINV_BillTo_PANNO.Text = dt.Rows[0]["BL_PANNO"].ToString();
                    PINV_BillTo_StateDisplayName.Text = dt.Rows[0]["BR_Reg_StateDisplayName"].ToString();
                    PINV_BillTo_GSTNo.Text = dt.Rows[0]["BL_GSTNO"].ToString();
                    //SHIP TO
                    PINV_ShippTo_CompanyName.Text = dt.Rows[0]["PINV_ShippTo_CompanyName"].ToString();
                    PINV_ShippTo_ContactPersone.Text = dt.Rows[0]["PINV_ShippTo_ContactPersone"].ToString();
                    PINV_ShippTo_CP_MobileNo.Text = dt.Rows[0]["PINV_ShippTo_CP_MobileNo"].ToString();
                    PINV_ShippTo_Add1.Text = dt.Rows[0]["PINV_ShippTo_Add1"].ToString();
                    PINV_ShippTo_Add2.Text = dt.Rows[0]["PINV_ShippTo_Add2"].ToString();
                    PINV_ShippTo_Add3.Text = dt.Rows[0]["PINV_ShippTo_Add3"].ToString();
                    PINV_ShippTo_Pincode.Text = dt.Rows[0]["PINV_ShippTo_Pincode"].ToString();

                    PINV_ShippTo_City.Text = dt.Rows[0]["PINV_ShippTo_City"].ToString();
                    PINV_ShippTo_State_ID.Text = dt.Rows[0]["PINV_ShippTo_State_ID"].ToString();
                    PINV_ShippTo_Country.Text = dt.Rows[0]["PINV_ShippTo_Country"].ToString();
                    PINV_ShippTo_GSTNo.Text = dt.Rows[0]["PINV_ShippTo_GSTNo"].ToString();
                    PINV_ShippTo_PANNO.Text = dt.Rows[0]["PINV_ShippTo_PANNO"].ToString();

                    
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
                dt =MABL.BL.AppDataModal.Get_Purchase_Item_List (Convert.ToInt64(PINVHDR_ID.Text), Convert.ToInt64(row.Cells[0].Text),"", "");
                if (dt.Rows.Count > 0)
                {
                    PINVDTL_ID.Text = dt.Rows[0]["PINVDTL_ID"].ToString();
                    Fk_MItem_ID.Text = dt.Rows[0]["Fk_MItem_ID"].ToString();
                    PINV_HSNCode.Text = dt.Rows[0]["PINV_HSNCode"].ToString();
                    PINV_QTY.Text = dt.Rows[0]["PINV_QTY"].ToString();
                    PINV_BasicRate.Text = dt.Rows[0]["PINV_BasicRate"].ToString();
                    PINV_DiscountRate.Text = dt.Rows[0]["PINV_DiscountRate"].ToString();
                   
                    PINV_ItemRemark_DTL.Text = dt.Rows[0]["PINV_ItemRemark_DTL"].ToString();
                   
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
                string RetMesg = MaheshAF18.Application.SQLManager.DeleteSRMD("", "M_AT_Purchase_Inv_BDTL", "Fk_PINVHDR_ID", Convert.ToInt64(0 + row.Cells[1].Text), "PINVDTL_ID", Convert.ToInt64(0 + row.Cells[0].Text), "C", "");
                MABL.SQLManager.SQLProcedureCall.USP_Update_Tbl_Purchase(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, Convert.ToInt32(PINVHDR_ID.Text));
                SetValueToControls_Edit_HDR(Convert.ToInt32(PINVHDR_ID.Text));
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
                if (PINV_Taxtype.Text == "IGST")
                {
                    e.Row.Cells[14].Visible = false;
                    e.Row.Cells[15].Visible = false;
                    e.Row.Cells[16].Visible = false;
                    e.Row.Cells[17].Visible = false;

                }
                if (PINV_Taxtype.Text == "SGST")
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
               // MABL.AppVariable.PrintDosReport_Invoice(PINVHDR_ID.Text);
                //if ((Inv_TaxType.Text == "SGST") || (Inv_TaxType.Text == "IGST"))
                //{
                // //   Response.Write("<script type='text/javascript'>detailedresults=window.open('" + MABL.AppVariable.Project_Constant("RptBrowse") + "/ReportBrowser/GSTInvBrowser.aspx?InvoiceType=" + Inv_TaxType.Text + "&INVID=" + PINVHDR_ID.Text + "');</script>");
                //}
                //else
                //{
                //    DisplayCustomMessageSummary("Invalid Invoice Type");
                //}
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
                PINV_HSNCode.Text = dt.Rows[0]["HSNCode"].ToString();
                PINV_BasicRate.Text = dt.Rows[0]["Item_Purchase_Rate"].ToString();
                PINV_QTY.Text = "1";
                PINV_DiscountRate.Text = "0";
                PINV_ItemRemark_DTL.Text = dt.Rows[0]["Item_Desc"].ToString();
            }
            else
            {
                PINV_HSNCode.Text = "";
                PINV_BasicRate.Text = "0";
                PINV_QTY.Text = "1";
                PINV_DiscountRate.Text = "0";
                PINV_ItemRemark_DTL.Text = "";
            }

        }
        protected void Fk_VendorID_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = MABL.BL.AppDataModal.Get_Mst_Vendor(Convert.ToInt64(Fk_VendorID.Text), "","");
            if (dt.Rows.Count > 0)
            {
                PINV_CreditDays.Text = dt.Rows[0]["MVen_CreditDays"].ToString();
                PINV_ShippedFrom_State_ID.Text = dt.Rows[0]["MVen_DispatchFrom_State_ID"].ToString();
                MVen_Reg_Add1.Text = dt.Rows[0]["MVen_Reg_Add1"].ToString();
                MVen_Reg_Add2.Text = dt.Rows[0]["MVen_Reg_Add2"].ToString();
                MVen_Reg_Add3.Text = dt.Rows[0]["MVen_Reg_Add3"].ToString();
                MVen_Reg_Pincode.Text = dt.Rows[0]["MVen_Reg_Pincode"].ToString();
                MVen_Reg_City.Text = dt.Rows[0]["MVen_Reg_City"].ToString();
                MVen_Reg_StateDisplayName.Text = dt.Rows[0]["MVen_Reg_StateDisplayName"].ToString();
                MVen_Reg_Country.Text = dt.Rows[0]["MVen_Reg_Country"].ToString();
                MVen_BL_GSTNO.Text = dt.Rows[0]["MVen_BL_GSTNO"].ToString();
                MVen_BL_PANNO.Text = dt.Rows[0]["MVen_BL_PANNO"].ToString();


                PINV_ShippedFrom_CompanyName.Text = dt.Rows[0]["MVen_DispatchFrom_CompanyName"].ToString();
                PINV_ShippedFrom_ContactPersone.Text = dt.Rows[0]["MVen_DispatchFrom_ContactPerson"].ToString();
                PINV_ShippedFrom_CP_MobileNo.Text = dt.Rows[0]["MVen_DispatchFrom_CP_MobileNo"].ToString();
                PINV_ShippedFrom_Add1.Text = dt.Rows[0]["MVen_DispatchFrom_Add1"].ToString();
                PINV_ShippedFrom_Add2.Text = dt.Rows[0]["MVen_DispatchFrom_Add2"].ToString();
                PINV_ShippedFrom_Add3.Text = dt.Rows[0]["MVen_DispatchFrom_Add3"].ToString();
                PINV_ShippedFrom_Pincode.Text = dt.Rows[0]["MVen_DispatchFrom_Pincode"].ToString();
                PINV_ShippedFrom_City.Text = dt.Rows[0]["MVen_DispatchFrom_City"].ToString();
                PINV_ShippedFrom_Country.Text = dt.Rows[0]["MVen_DispatchFrom_Country"].ToString();
                PINV_ShippedFrom_GSTNo.Text = dt.Rows[0]["MVen_DispatchFrom_GSTNO"].ToString();
                PINV_ShippedFrom_PANNO.Text = dt.Rows[0]["MVen_DispatchFrom_PANNO"].ToString(); 

            }
            else
            {
                PINV_CreditDays.Text = "0";
                PINV_ShippedFrom_State_ID.SelectedIndex = 0;
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
            dt_BranchDetails = MABL.BL.AppBL.Get_App_Branch_List(SessionUserData.Company.BranchID, "");
            if (dt.Rows.Count > 0)
            {
                //Branch Details
                PINV_ShippTo_State_ID.Text = dt_BranchDetails.Rows[0]["BR_Consignee_State_ID"].ToString();
                PINV_BillTo_Add1.Text = dt_BranchDetails.Rows[0]["BR_Reg_Add1"].ToString();
                PINV_BillTo_Add2.Text = dt_BranchDetails.Rows[0]["BR_Reg_Add2"].ToString();
                PINV_BillTo_Add3.Text = dt_BranchDetails.Rows[0]["BR_Reg_Add3"].ToString();
                PINV_BillTo_Pincode.Text = dt_BranchDetails.Rows[0]["BR_Reg_Pincode"].ToString();
                PINV_BillTo_City.Text = dt_BranchDetails.Rows[0]["BR_Reg_City"].ToString();
                PINV_BillTo_StateDisplayName.Text = dt_BranchDetails.Rows[0]["BR_Reg_StateDisplayName"].ToString();
                PINV_BillTo_Country.Text = dt_BranchDetails.Rows[0]["BR_Reg_Country"].ToString();
                PINV_BillTo_GSTNo.Text = dt_BranchDetails.Rows[0]["BL_GSTNO"].ToString();
                PINV_BillTo_PANNO.Text = dt_BranchDetails.Rows[0]["BL_PANNO"].ToString();

                PINV_ShippTo_CompanyName.Text = dt_BranchDetails.Rows[0]["BR_Buyer_CompanyName"].ToString();
                PINV_ShippTo_ContactPersone.Text = dt_BranchDetails.Rows[0]["BR_Consignee_Contact_Person"].ToString();
                PINV_ShippTo_CP_MobileNo.Text = dt_BranchDetails.Rows[0]["BR_Consignee_CP_MobileNo"].ToString();
                PINV_ShippTo_Add1.Text = dt_BranchDetails.Rows[0]["BR_Consignee_Add1"].ToString();
                PINV_ShippTo_Add2.Text = dt_BranchDetails.Rows[0]["BR_Consignee_Add2"].ToString();
                PINV_ShippTo_Add3.Text = dt_BranchDetails.Rows[0]["BR_Consignee_Add3"].ToString();

                PINV_ShippTo_Pincode.Text = dt_BranchDetails.Rows[0]["BR_Consignee_Pincode"].ToString();
                PINV_ShippTo_City.Text = dt_BranchDetails.Rows[0]["BR_Consignee_City"].ToString();

                PINV_ShippTo_Country.Text = dt_BranchDetails.Rows[0]["BR_Consignee_Country"].ToString();
                PINV_ShippTo_GSTNo.Text = dt_BranchDetails.Rows[0]["BR_Consignee_GSTNO"].ToString();
                PINV_ShippTo_PANNO.Text = dt_BranchDetails.Rows[0]["BR_Consignee_PANNO"].ToString();


            }
            else
            {
                //Branch Details
                PINV_ShippTo_State_ID.SelectedIndex = 0;
                PINV_BillTo_Add1.Text = "";
                PINV_BillTo_Add2.Text = "";
                PINV_BillTo_Add3.Text = "";
                PINV_BillTo_Pincode.Text = "";
                PINV_BillTo_City.Text = "";
                PINV_BillTo_StateDisplayName.Text = "";
                PINV_BillTo_Country.Text = "";
                PINV_BillTo_GSTNo.Text = "";
                PINV_BillTo_PANNO.Text = "";


                PINV_ShippTo_CompanyName.Text = "";
                PINV_ShippTo_ContactPersone.Text = "";
                PINV_ShippTo_CP_MobileNo.Text = "";
                PINV_ShippTo_Add1.Text = "";
                PINV_ShippTo_Add2.Text = "";
                PINV_ShippTo_Add3.Text = "";

                PINV_ShippTo_Pincode.Text = "";
                PINV_ShippTo_City.Text = "";

                PINV_ShippTo_Country.Text = "";
                PINV_ShippTo_GSTNo.Text = "";
                PINV_ShippTo_PANNO.Text = "";
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

                if (PINV_ShippedFrom_State_ID.Text == PINV_ShippTo_State_ID.Text)
                {
                    PINV_Taxtype.Text = "SGST";
                }
                else
                {
                    PINV_Taxtype.Text = "IGST";
                }


                if (PINV_Taxtype.Text == "IGST")
                {
                    Div_IGST_HDR.Visible = true;
                    
                }
                if (PINV_Taxtype.Text == "SGST")
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