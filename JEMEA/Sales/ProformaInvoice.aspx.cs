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


namespace JEMEA.Sales
{
    public partial class ProformaInvoice : Mahesh_Page
    {
        M_AT_Sales_PI_AHDRBO ObjAT_SPI_HDR;
        M_AT_Sales_PI_BDTLBO ObjAT_SPI_DTL;

        protected void Page_Load(object sender, EventArgs e)
        {

            PageMenuID = Request.QueryString["ID"];
            //SessionData.UserAccess.MenuID = PageMenuID;

            ObjAT_SPI_HDR = new M_AT_Sales_PI_AHDRBO();
            ObjAT_SPI_DTL = new M_AT_Sales_PI_BDTLBO();
           

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
                CE_SPI_DT.EndDate = DateTime.Now;
                CE_SPI_PO_DT.EndDate = DateTime.Now;

                SetValueType(TextType.DateField, Txt_FromDT);
                SetValueType(TextType.DateField, Txt_ToDT);
                SetValueType(TextType.AmountField, SPI_QTY);
                SetValueType(TextType.AlphNumericField_4, SPI_BasicRate);
                SetValueType(TextType.AmountField, SPI_DiscountRate);

                SetValueType(TextType.DateField, SPI_DT);
                SetValueType(TextType.NumericField, SPI_CreditDays);
                SetValueType(TextType.DateField, SPI_DueDT);
                SetValueType(TextType.DateField, SPI_PO_DT);
                SetValueType(TextType.DateField, MDBSC_RowCreatedOn_DT);
                SetValueType(TextType.AmountField, SPI_HDR_BasicAmt);
                SetValueType(TextType.AmountField, SPI_HDR_DiscountAmt);
                SetValueType(TextType.AmountField, SPI_HDR_Net_Amt);
                SetValueType(TextType.AmountField, SPI_HDR_Freight_Charges);
                SetValueType(TextType.AmountField, SPI_HDR_CGST_Amt);
                SetValueType(TextType.AmountField, SPI_HDR_SGST_Amt);
                SetValueType(TextType.AmountField, SPI_HDR_IGST_Amt);
                SetValueType(TextType.AmountField, SPI_HDR_CESS_Amt);
                SetValueType(TextType.AmountField, SPI_HDR_Gross_Amt);
                SetValueType(TextType.AmountField, SPI_HDR_Round_Off_Amt);
                SetValueType(TextType.AmountField, SPI_HDR_Total_Gross_Amt);
                SetValueType(TextType.AmountField, SPI_HDR_Total_Tax_Amt);

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

            Fk_CustomerID.DataSource = MaheshAF18.Utility.M_DropDownList.Fill_Drop_Down_List("v_M_AT_Mst_Customer", "M_Cust_ID", "MCust_Name", "", "", "Customer", 0, "N", "");
            Fk_CustomerID.DataBind();

            Fk_MItem_ID.DataSource = MaheshAF18.Utility.M_DropDownList.Fill_Drop_Down_List("M_AT_Mst_ItemMaster", "MItem_ID", "Item_Name", "", "", "Item", 0, "N", "");
            Fk_MItem_ID.DataBind();

            DataTable dt = new DataTable();
            dt = MaheshAF18.Utility.M_DropDownList.Fill_Drop_Down_List("v_AAA_M_RT_GEO_State", "GStateID", "vStateDisplayName", "  ", "", "State", 0, "N", "");
            SPI_ShippedFrom_State_ID.DataSource = dt;
            SPI_ShippedFrom_State_ID.DataBind();

            SPI_ShippTo_State_ID.DataSource = dt;
            SPI_ShippTo_State_ID.DataBind();


        }
        #endregion
        #region "Refrish Grid Functions"
        private void RefreshGrid_HDR(string SearchCriteria = "")
        {
            try
            {
                string var_SQLFilter = "";
                var_SQLFilter = "";

                if ((Txt_FromDT.Text.Length > 0) && (Txt_ToDT.Text.Length > 0))
                {
                    var_SQLFilter = var_SQLFilter + " AND SPI_DT BETWEEN  '" + Txt_FromDT.Text + "' AND  '" + Txt_ToDT.Text + "'";
                }
                DataTable dt = default(DataTable);
                dt = MABL.BL.AppDataModal.Get_Sales_PI_List(0, var_SQLFilter, SearchCriteria);
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
                dt = MABL.BL.AppDataModal.Get_Sales_PI_Item_List(Convert.ToInt64(SPIHDR_ID.Text), Convert.ToInt64(SPIDTL_ID.Text), "", "");
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
                //dt = dt = MABL.BL.AppDataModal.Get_Purchase_Tax_List(Convert.ToInt64(SPIHDR_ID.Text),0, "", "");
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

                SPIHDR_ID.Text = "0";
                Fk_CustomerID.SelectedIndex = 0;
                Msg_ErrorMsg.Text = "";

                SPI_Taxtype.Text = "";
                SPI_No.Text = MEF.GetRefNo(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, "Proforma Invoice", "SPI", "SPI", "Yes");
                SPI_DT.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));

                SPI_CreditDays.Text = "30";
                SPI_DueDT.Text = "";
                SPI_PONo.Text = "";
                SPI_PO_DT.Text = "";
                SPI_Remark.Text = "";
                MDBSC_RowStatus.Text = "";
                MDBSC_RowCreatedByUserName.Text = SessionUserData.UserData.UserName;
                MDBSC_RowCreatedOn_DT.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
                SPI_HDR_BasicAmt.Text = "0.00";
                SPI_HDR_DiscountAmt.Text = "0.00";
                SPI_HDR_Net_Amt.Text = "0.00";
                SPI_HDR_Freight_Charges.Text = "0.00";
                SPI_HDR_CGST_Amt.Text = "0.00";
                SPI_HDR_SGST_Amt.Text = "0.00";
                SPI_HDR_IGST_Amt.Text = "0.00";
                SPI_HDR_CESS_Amt.Text = "0.00";
                SPI_HDR_Gross_Amt.Text = "0.00";
                SPI_HDR_Round_Off_Amt.Text = "0.00";
                SPI_HDR_Total_Gross_Amt.Text = "0.00";

                SPI_HDR_Total_Tax_Amt.Text = "0.00";

                SPI_CreditDays.Text = "0";
                SPI_ShippedFrom_State_ID.SelectedIndex = 0;
               
                MCust_Reg_StateDisplayName.Text = "";
              
                SPI_ShippTo_State_ID.SelectedIndex = 0;
                SPI_BillTo_Add1.Text = "";
                SPI_BillTo_Add2.Text = "";
                SPI_BillTo_Add3.Text = "";
                SPI_BillTo_Pincode.Text = "";
                SPI_BillTo_City.Text = "";
              
                SPI_BillTo_Country.Text = "";
                SPI_BillTo_GSTNo.Text = "";
                SPI_BillTo_PANNO.Text = "";


                SPI_ShippTo_CompanyName.Text = "";
                SPI_ShippTo_ContactPersone.Text = "";
                SPI_ShippTo_CP_MobileNo.Text = "";
                SPI_ShippTo_Add1.Text = "";
                SPI_ShippTo_Add2.Text = "";
                SPI_ShippTo_Add3.Text = "";

           


                SPI_ShippTo_Pincode.Text = "";
                SPI_ShippTo_City.Text = "";

                SPI_ShippTo_Country.Text = "";
                SPI_ShippTo_GSTNo.Text = "";
                SPI_ShippTo_PANNO.Text = "";

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

                SPIDTL_ID.Text = "0";
                Fk_MItem_ID.SelectedIndex = 0;
                SPI_BasicRate.Text = "0";
                SPI_HSNCode.Text = "";
                SPI_QTY.Text = "0";
                SPI_DiscountRate.Text = "0";

                SPI_ItemRemark_DTL.Text = "";
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

                if (Fk_CustomerID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Select Customer.<br>";
                }
                if (SPI_No.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Customer Invoice No Cannot Be Blank.<br>";
                }

                if (SPI_ShippedFrom_State_ID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Place Of Dispatch<br>";
                }


                if (SPI_ShippTo_State_ID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Place Of Supply<br>";
                }

               
                if (SPI_ShippTo_GSTNo.Text.Length != 15)
                {
                    ErrorMessage = ErrorMessage + "Invalid Ship To GSTNO<br>";
                }

                
                if (SPI_ShippTo_PANNO.Text.Length != 10)
                {
                    ErrorMessage = ErrorMessage + "Invalid Ship To PAN No<br>";
                }



                if ((SPI_No.Text.Length > 0) && (Fk_CustomerID.SelectedIndex > 0))
                {
                    if (SQLManager.CheckDuplicateRecord("M_AT_Sales_Inv_AHDR", "SPIHDR_ID", Convert.ToInt32("0" + SPIHDR_ID.Text), "SPI_No", SPI_No.Text,
                                                       " AND Fk_Branch_ID=" + SessionUserData.Company.BranchID ))
                    {
                        ErrorMessage = ErrorMessage + "Customer Invoice Already Exist.<br>";
                    }
                }

                if (SPI_DT.Text.Length != 11)
                {
                    ErrorMessage = ErrorMessage + "Invalid Customer Invoice Date.<br>";
                }
                if ((Fk_CustomerID.SelectedIndex > 0) && (Convert.ToInt32(SPIHDR_ID.Text) == 0))
                {
                    if (Fk_MItem_ID.SelectedIndex == 0)
                    {
                        ErrorMessage = ErrorMessage + "Pls Select Item<br>";
                    }
                    if (SPI_BasicRate.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Rate<br>";
                    }
                    if (SPI_QTY.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Quantity<br>";
                    }
                    else
                    {
                        if (Convert.ToDecimal(SPI_QTY.Text) <= 0)
                        {
                            ErrorMessage = ErrorMessage + "Invalid Item Quantity<br>";
                        }
                    }
                }
                if ((Convert.ToInt32(SPIHDR_ID.Text) > 0) && (Convert.ToInt32(SPIDTL_ID.Text) > 0) && (Fk_MItem_ID.SelectedIndex > 0))
                {
                    if (Fk_MItem_ID.SelectedIndex == 0)
                    {
                        ErrorMessage = ErrorMessage + "Pls Select Item<br>";
                    }
                    if (SPI_BasicRate.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Rate<br>";
                    }
                    if (SPI_QTY.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Quantity<br>";
                    }
                    else
                    {
                        if (Convert.ToDecimal(SPI_QTY.Text) <= 0)
                        {
                            ErrorMessage = ErrorMessage + "Invalid Item Quantity<br>";
                        }
                    }
                }


                if (ErrorMessage.Length == 0)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (Convert.ToInt32(SPIHDR_ID.Text) == 0)
                        {
                            ObjAT_SPI_HDR.Fk_Company_ID = SessionUserData.Company.CompanyID;
                            ObjAT_SPI_HDR.Fk_Branch_ID = SessionUserData.Company.BranchID;
                            ObjAT_SPI_HDR.Fk_Year_ID = SessionUserData.Company.YearID;
                            ObjAT_SPI_HDR.Rec_Created_In = "HO";
                            ObjAT_SPI_HDR.Rec_CreatedBy_ID = SessionUserData.Company.BranchID;
                            ObjAT_SPI_HDR.Rec_CreatedFor_ID = SessionUserData.Company.BranchID;
                            ObjAT_SPI_HDR.SPI_CreationType = "Manual";
                            ObjAT_SPI_HDR.SPI_Category = "";
                            ObjAT_SPI_HDR.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName;
                            ObjAT_SPI_HDR.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                            ObjAT_SPI_HDR.SPI_No = MEF.GenrateRefNo(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, "Proforma Invoice", "SPI", "SPI", "Yes", "", "", "", 0);

                        }
                        SetValuesToBO_HDR();
                        ErrorMessage = ObjAT_SPI_HDR.Insert_Update(ObjAT_SPI_HDR);
                        SPIHDR_ID.Text = ErrorMessage.Substring((ErrorMessage.IndexOf("|") + 1), (ErrorMessage.Length - ErrorMessage.IndexOf("|") - 1));
                        ErrorMessage = ErrorMessage.Substring((0), (ErrorMessage.IndexOf("|")));

                        if ((Convert.ToInt32(SPIHDR_ID.Text) > 0) && (Fk_MItem_ID.SelectedIndex > 0))
                        {
                            if (Convert.ToInt32(SPIDTL_ID.Text) == 0)
                            {
                                ObjAT_SPI_DTL.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                                ObjAT_SPI_DTL.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName;
                            }

                            ObjAT_SPI_DTL.SPIDTL_ID = Convert.ToInt64("0" + SPIDTL_ID.Text);
                            ObjAT_SPI_DTL.Fk_SPIHDR_ID = Convert.ToInt64("0" + SPIHDR_ID.Text);
                            ObjAT_SPI_DTL.Fk_MItem_ID = Convert.ToInt64("0" + Fk_MItem_ID.Text);
                            ObjAT_SPI_DTL.SPI_HSNCode = SPI_HSNCode.Text;
                            ObjAT_SPI_DTL.SPI_QTY = Convert.ToDecimal(SPI_QTY.Text);
                            ObjAT_SPI_DTL.SPI_Final_Qty = Convert.ToDecimal(SPI_QTY.Text);
                            ObjAT_SPI_DTL.SPI_BasicRate = Convert.ToDecimal(SPI_BasicRate.Text);
                            ObjAT_SPI_DTL.SPI_DiscountRate = Convert.ToDecimal(SPI_DiscountRate.Text);
                            ObjAT_SPI_DTL.SPI_CGST_ID = 0;
                            ObjAT_SPI_DTL.SPI_SGST_ID = 0;
                            ObjAT_SPI_DTL.SPI_IGST_ID = 0;
                            ObjAT_SPI_DTL.SPI_CESS_ID = 0;

                            ObjAT_SPI_DTL.SPI_ItemRemark_DTL = SPI_ItemRemark_DTL.Text;
                            ObjAT_SPI_DTL.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
                            ObjAT_SPI_DTL.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
                            ObjAT_SPI_DTL.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));

                            ObjAT_SPI_DTL.Insert_Update(ObjAT_SPI_DTL);


                        }

                        scope.Complete();
                    }
                    MABL.SQLManager.SQLProcedureCall.USP_Update_Tbl_Sales_PI(Convert.ToInt32(SPIHDR_ID.Text));
                    SetValueToControls_Edit_HDR(Convert.ToInt32("0" + SPIHDR_ID.Text));
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

                ObjAT_SPI_HDR.SPIHDR_ID = Convert.ToInt64("0" + SPIHDR_ID.Text);

                
                ObjAT_SPI_HDR.SPI_DT = SPI_DT.Text;
                ObjAT_SPI_HDR.Fk_CustomerID = Convert.ToInt32(Fk_CustomerID.Text);
                ObjAT_SPI_HDR.SPI_CreditDays = Convert.ToInt32("0" + SPI_CreditDays.Text);
                ObjAT_SPI_HDR.SPI_PONo = SPI_PONo.Text;
                if (SPI_PO_DT.Text.Length == 11)
                {
                    ObjAT_SPI_HDR.SPI_PO_DT = SPI_PO_DT.Text;
                }
                ObjAT_SPI_HDR.SPI_Remark = SPI_Remark.Text;
                ObjAT_SPI_HDR.MDBSC_RowStatus = MDBSC_RowStatus.Text;
                ObjAT_SPI_HDR.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
                ObjAT_SPI_HDR.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
                ObjAT_SPI_HDR.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
                ObjAT_SPI_HDR.SPI_HDR_Freight_Charges = Convert.ToDecimal("0" + SPI_HDR_Freight_Charges.Text);

                ObjAT_SPI_HDR.SPI_BillTo_Add1 = SPI_BillTo_Add1.Text;
                ObjAT_SPI_HDR.SPI_BillTo_Add2 = SPI_BillTo_Add2.Text;
                ObjAT_SPI_HDR.SPI_BillTo_Add3 = SPI_BillTo_Add3.Text;
                ObjAT_SPI_HDR.SPI_BillTo_Pincode = SPI_BillTo_Pincode.Text;
                ObjAT_SPI_HDR.SPI_BillTo_City = SPI_BillTo_City.Text;
                ObjAT_SPI_HDR.SPI_BillTo_Country = SPI_BillTo_Country.Text;
                ObjAT_SPI_HDR.SPI_BillTo_PANNO = SPI_BillTo_PANNO.Text;
                ObjAT_SPI_HDR.SPI_ShippTo_CompanyName = SPI_ShippTo_CompanyName.Text;
                ObjAT_SPI_HDR.SPI_ShippTo_ContactPersone = SPI_ShippTo_ContactPersone.Text;
                ObjAT_SPI_HDR.SPI_ShippTo_CP_MobileNo = SPI_ShippTo_CP_MobileNo.Text;
                ObjAT_SPI_HDR.SPI_ShippTo_Add1 = SPI_ShippTo_Add1.Text;
                ObjAT_SPI_HDR.SPI_ShippTo_Add2 = SPI_ShippTo_Add2.Text;
                ObjAT_SPI_HDR.SPI_ShippTo_Add3 = SPI_ShippTo_Add3.Text;
                ObjAT_SPI_HDR.SPI_ShippTo_Pincode = SPI_ShippTo_Pincode.Text;

                ObjAT_SPI_HDR.SPI_ShippedFrom_CompanyName = "";
                ObjAT_SPI_HDR.SPI_ShippedFrom_ContactPersone = "";
                ObjAT_SPI_HDR.SPI_ShippedFrom_CP_MobileNo = "";
                ObjAT_SPI_HDR.SPI_ShippedFrom_Add1 = "";
                ObjAT_SPI_HDR.SPI_ShippedFrom_Add2 = "";
                ObjAT_SPI_HDR.SPI_ShippedFrom_Add3 = "";
                ObjAT_SPI_HDR.SPI_ShippedFrom_Pincode = "";

                ObjAT_SPI_HDR.SPI_ShippedFrom_City = "";
                ObjAT_SPI_HDR.SPI_ShippedFrom_State_ID = Convert.ToInt64(SPI_ShippedFrom_State_ID.Text);
                ObjAT_SPI_HDR.SPI_ShippedFrom_Country = "";
                ObjAT_SPI_HDR.SPI_ShippedFrom_GSTNo = "";
                ObjAT_SPI_HDR.SPI_ShippedFrom_PANNO = "";


                ObjAT_SPI_HDR.SPI_ShippTo_City = SPI_ShippTo_City.Text;
                ObjAT_SPI_HDR.SPI_ShippTo_State_ID = Convert.ToInt64(SPI_ShippTo_State_ID.Text);
                ObjAT_SPI_HDR.SPI_ShippTo_Country = SPI_ShippTo_Country.Text;
                ObjAT_SPI_HDR.SPI_ShippTo_GSTNo = SPI_ShippTo_GSTNo.Text;
                ObjAT_SPI_HDR.SPI_ShippTo_PANNO = SPI_ShippTo_PANNO.Text;





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
                dt = MABL.BL.AppDataModal.Get_Sales_PI_List(strPK, "", "");
                InitializeControls_HDR();
                InitializeControls_DTL();
                if (dt.Rows.Count > 0)
                {
                    SPIHDR_ID.Text = dt.Rows[0]["SPIHDR_ID"].ToString();

                    SPIHDR_ID.Text = dt.Rows[0]["SPIHDR_ID"].ToString();
                    SPI_Taxtype.Text = dt.Rows[0]["SPI_Taxtype"].ToString();
                    SPI_No.Text = dt.Rows[0]["SPI_No"].ToString();
                    SPI_DT.Text = dt.Rows[0]["vSPI_DT"].ToString();
                    Fk_CustomerID.Text = dt.Rows[0]["Fk_CustomerID"].ToString();
                    SPI_CreditDays.Text = dt.Rows[0]["SPI_CreditDays"].ToString();
                    SPI_DueDT.Text = dt.Rows[0]["vSPI_DueDT"].ToString();
                    SPI_PONo.Text = dt.Rows[0]["SPI_PONo"].ToString();
                    SPI_PO_DT.Text = dt.Rows[0]["vSPI_PO_DT"].ToString();

                    SPI_ModeOfDispatch.Text = dt.Rows[0]["SPI_ModeOfDispatch"].ToString();

                    SPI_Remark.Text = dt.Rows[0]["SPI_Remark"].ToString();

                    MDBSC_RowStatus.Text = dt.Rows[0]["MDBSC_RowStatus"].ToString();

                    MDBSC_RowCreatedByUserName.Text = dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
                    MDBSC_RowCreatedOn_DT.Text = dt.Rows[0]["vMDBSC_RowCreatedOn_DT"].ToString();

                    SPI_HDR_BasicAmt.Text = dt.Rows[0]["SPI_HDR_BasicAmt"].ToString();

                    SPI_HDR_DiscountAmt.Text = dt.Rows[0]["SPI_HDR_DiscountAmt"].ToString();
                    SPI_HDR_Net_Amt.Text = dt.Rows[0]["SPI_HDR_Net_Amt"].ToString();
                    SPI_HDR_Freight_Charges.Text = dt.Rows[0]["SPI_HDR_Freight_Charges"].ToString();
                    SPI_HDR_CGST_Amt.Text = dt.Rows[0]["SPI_HDR_CGST_Amt"].ToString();

                    SPI_HDR_SGST_Amt.Text = dt.Rows[0]["SPI_HDR_SGST_Amt"].ToString();

                    SPI_HDR_IGST_Amt.Text = dt.Rows[0]["SPI_HDR_IGST_Amt"].ToString();

                    SPI_HDR_CESS_Amt.Text = dt.Rows[0]["SPI_HDR_CESS_Amt"].ToString();

                    SPI_HDR_Total_Tax_Amt.Text = dt.Rows[0]["SPI_HDR_Total_Tax_Amt"].ToString();

                    SPI_HDR_Gross_Amt.Text = dt.Rows[0]["SPI_HDR_Gross_Amt"].ToString();
                    SPI_HDR_Round_Off_Amt.Text = dt.Rows[0]["SPI_HDR_Round_Off_Amt"].ToString();
                    SPI_HDR_Total_Gross_Amt.Text = dt.Rows[0]["SPI_HDR_Total_Gross_Amt"].ToString();

                    //Customer
                 
                    MCust_Reg_StateDisplayName.Text = dt.Rows[0]["MCust_Reg_StateDisplayName"].ToString();
                 

                    //SHIP FROM 
                  
                    //BILL TO
                    SPI_BillTo_Add1.Text = dt.Rows[0]["SPI_BillTo_Add1"].ToString();
                    SPI_BillTo_Add2.Text = dt.Rows[0]["SPI_BillTo_Add2"].ToString();
                    SPI_BillTo_Add3.Text = dt.Rows[0]["SPI_BillTo_Add3"].ToString();
                    SPI_BillTo_Pincode.Text = dt.Rows[0]["SPI_BillTo_Pincode"].ToString();
                    SPI_BillTo_City.Text = dt.Rows[0]["SPI_BillTo_City"].ToString();
                    SPI_BillTo_Country.Text = dt.Rows[0]["SPI_BillTo_Country"].ToString();
                    SPI_BillTo_PANNO.Text = dt.Rows[0]["SPI_BillTo_PANNO"].ToString();

                    SPI_BillTo_GSTNo.Text = dt.Rows[0]["SPI_BillTo_GSTNo"].ToString();
                    //SHIP TO
                    SPI_ShippTo_CompanyName.Text = dt.Rows[0]["SPI_ShippTo_CompanyName"].ToString();
                    SPI_ShippTo_ContactPersone.Text = dt.Rows[0]["SPI_ShippTo_ContactPersone"].ToString();
                    SPI_ShippTo_CP_MobileNo.Text = dt.Rows[0]["SPI_ShippTo_CP_MobileNo"].ToString();
                    SPI_ShippTo_Add1.Text = dt.Rows[0]["SPI_ShippTo_Add1"].ToString();
                    SPI_ShippTo_Add2.Text = dt.Rows[0]["SPI_ShippTo_Add2"].ToString();
                    SPI_ShippTo_Add3.Text = dt.Rows[0]["SPI_ShippTo_Add3"].ToString();
                    SPI_ShippTo_Pincode.Text = dt.Rows[0]["SPI_ShippTo_Pincode"].ToString();

                    SPI_ShippTo_City.Text = dt.Rows[0]["SPI_ShippTo_City"].ToString();
                    SPI_ShippTo_State_ID.Text = dt.Rows[0]["SPI_ShippTo_State_ID"].ToString();
                    SPI_ShippedFrom_State_ID.Text = dt.Rows[0]["SPI_ShippedFrom_State_ID"].ToString();
                    SPI_ShippTo_Country.Text = dt.Rows[0]["SPI_ShippTo_Country"].ToString();
                    SPI_ShippTo_GSTNo.Text = dt.Rows[0]["SPI_ShippTo_GSTNo"].ToString();
                    SPI_ShippTo_PANNO.Text = dt.Rows[0]["SPI_ShippTo_PANNO"].ToString();


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
                dt = MABL.BL.AppDataModal.Get_Sales_PI_Item_List(Convert.ToInt64(SPIHDR_ID.Text), Convert.ToInt64(row.Cells[0].Text), "", "");
                if (dt.Rows.Count > 0)
                {
                    SPIDTL_ID.Text = dt.Rows[0]["SPIDTL_ID"].ToString();
                    Fk_MItem_ID.Text = dt.Rows[0]["Fk_MItem_ID"].ToString();
                    SPI_HSNCode.Text = dt.Rows[0]["SPI_HSNCode"].ToString();
                    SPI_QTY.Text = dt.Rows[0]["SPI_QTY"].ToString();
                    SPI_BasicRate.Text = dt.Rows[0]["SPI_BasicRate"].ToString();
                    SPI_DiscountRate.Text = dt.Rows[0]["SPI_DiscountRate"].ToString();

                    SPI_ItemRemark_DTL.Text = dt.Rows[0]["SPI_ItemRemark_DTL"].ToString();

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
                string RetMesg = MaheshAF18.Application.SQLManager.DeleteSRMD("", "M_AT_Sales_Inv_BDTL", "Fk_SPIHDR_ID", Convert.ToInt64(0 + row.Cells[1].Text), "SPIDTL_ID", Convert.ToInt64(0 + row.Cells[0].Text), "C", "");
                MABL.SQLManager.SQLProcedureCall.USP_Update_Tbl_Sales_PI(Convert.ToInt32(SPIHDR_ID.Text));
                SetValueToControls_Edit_HDR(Convert.ToInt32(SPIHDR_ID.Text));
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
                if (SPI_Taxtype.Text == "IGST")
                {
                    e.Row.Cells[14].Visible = false;
                    e.Row.Cells[15].Visible = false;
                    e.Row.Cells[16].Visible = false;
                    e.Row.Cells[17].Visible = false;

                }
                if (SPI_Taxtype.Text == "SGST")
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
                // MABL.AppVariable.PrintDosReport_Invoice(SPIHDR_ID.Text);
                //if ((Inv_TaxType.Text == "SGST") || (Inv_TaxType.Text == "IGST"))
                //{
                // //   Response.Write("<script type='text/javascript'>detailedresults=window.open('" + MABL.AppVariable.Project_Constant("RptBrowse") + "/ReportBrowser/GSTInvBrowser.aspx?InvoiceType=" + Inv_TaxType.Text + "&INVID=" + SPIHDR_ID.Text + "');</script>");
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
                SPI_HSNCode.Text = dt.Rows[0]["HSNCode"].ToString();
                SPI_BasicRate.Text = dt.Rows[0]["Item_Purchase_Rate"].ToString();
                SPI_QTY.Text = "1";
                SPI_DiscountRate.Text = "0";
                SPI_ItemRemark_DTL.Text = dt.Rows[0]["Item_Desc"].ToString();
            }
            else
            {
                SPI_HSNCode.Text = "";
                SPI_BasicRate.Text = "0";
                SPI_QTY.Text = "1";
                SPI_DiscountRate.Text = "0";
                SPI_ItemRemark_DTL.Text = "";
            }

        }
        protected void Fk_CustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = MABL.BL.AppDataModal.Get_Mst_Customer(Convert.ToInt64(Fk_CustomerID.Text), "", "");
            if (dt.Rows.Count > 0)
            {
                SPI_CreditDays.Text = dt.Rows[0]["MCust_CreditDays"].ToString();
                SPI_ShippTo_State_ID.Text = dt.Rows[0]["MCust_ShippTo_State_ID"].ToString();
                SPI_BillTo_Add1.Text = dt.Rows[0]["MCust_Reg_Add1"].ToString();
                SPI_BillTo_Add2.Text = dt.Rows[0]["MCust_Reg_Add2"].ToString();
                SPI_BillTo_Add3.Text = dt.Rows[0]["MCust_Reg_Add3"].ToString();
                SPI_BillTo_Pincode.Text = dt.Rows[0]["MCust_Reg_Pincode"].ToString();
                SPI_BillTo_City.Text = dt.Rows[0]["MCust_Reg_City"].ToString();
                MCust_Reg_StateDisplayName.Text = dt.Rows[0]["MCust_Reg_StateDisplayName"].ToString();
                SPI_BillTo_Country.Text = dt.Rows[0]["MCust_Reg_Country"].ToString();
                SPI_BillTo_GSTNo.Text = dt.Rows[0]["MCust_BL_GSTNO"].ToString();
                SPI_BillTo_PANNO.Text = dt.Rows[0]["MCust_BL_PANNO"].ToString();


                SPI_ShippTo_CompanyName.Text = dt.Rows[0]["MCust_ShippTo_CompanyName"].ToString();
                SPI_ShippTo_ContactPersone.Text = dt.Rows[0]["MCust_ShippTo_ContactPerson"].ToString();
                SPI_ShippTo_CP_MobileNo.Text = dt.Rows[0]["MCust_ShippTo_CP_MobileNo"].ToString();
                SPI_ShippTo_Add1.Text = dt.Rows[0]["MCust_ShippTo_Add1"].ToString();
                SPI_ShippTo_Add2.Text = dt.Rows[0]["MCust_ShippTo_Add2"].ToString();
                SPI_ShippTo_Add3.Text = dt.Rows[0]["MCust_ShippTo_Add3"].ToString();
                SPI_ShippTo_Pincode.Text = dt.Rows[0]["MCust_ShippTo_Pincode"].ToString();
                SPI_ShippTo_City.Text = dt.Rows[0]["MCust_ShippTo_City"].ToString();
                SPI_ShippTo_Country.Text = dt.Rows[0]["MCust_ShippTo_Country"].ToString();
                SPI_ShippTo_GSTNo.Text = dt.Rows[0]["MCust_ShippTo_GSTNO"].ToString();
                SPI_ShippTo_PANNO.Text = dt.Rows[0]["MCust_ShippTo_PANNO"].ToString();




            }
            else
            {
                SPI_CreditDays.Text = "";
                SPI_ShippTo_State_ID.SelectedIndex = 0;
                SPI_BillTo_Add1.Text = "";
                SPI_BillTo_Add2.Text ="";
                SPI_BillTo_Add3.Text = "";
                SPI_BillTo_Pincode.Text = "";
                SPI_BillTo_City.Text ="";
                MCust_Reg_StateDisplayName.Text = "";
                SPI_BillTo_Country.Text ="";
                SPI_BillTo_GSTNo.Text ="";
                SPI_BillTo_PANNO.Text ="";


                SPI_ShippTo_CompanyName.Text ="";
                SPI_ShippTo_ContactPersone.Text = "";
                SPI_ShippTo_CP_MobileNo.Text = "";
                SPI_ShippTo_Add1.Text ="";
                SPI_ShippTo_Add2.Text = "";
                SPI_ShippTo_Add3.Text ="";
                SPI_ShippTo_Pincode.Text ="";
                SPI_ShippTo_City.Text ="";
                SPI_ShippTo_Country.Text ="";
                SPI_ShippTo_GSTNo.Text ="";
                SPI_ShippTo_PANNO.Text ="";
            }

            DataTable dt_BranchDetails = new DataTable();
            dt_BranchDetails = MABL.BL.AppBL.Get_App_Branch_List(SessionUserData.Company.BranchID, "");
            if (dt.Rows.Count > 0)
            {
                //Branch Details
                SPI_ShippedFrom_State_ID.Text = dt_BranchDetails.Rows[0]["BR_Consignee_State_ID"].ToString();
                 


            }
            else
            {
                //Branch Details
                SPI_ShippTo_State_ID.SelectedIndex = 0;
                
            }

            TaxType_Toggel();

        }
        protected void SalesState_SelectedIndexChanged(object sender, EventArgs e)
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

                if (SPI_ShippedFrom_State_ID.Text == SPI_ShippTo_State_ID.Text)
                {
                    SPI_Taxtype.Text = "SGST";
                }
                else
                {
                    SPI_Taxtype.Text = "IGST";
                }


                if (SPI_Taxtype.Text == "IGST")
                {
                    Div_IGST_HDR.Visible = true;

                }
                if (SPI_Taxtype.Text == "SGST")
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