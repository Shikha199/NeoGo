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
    public partial class TaxInvoice : Mahesh_Page
    {
        M_AT_Sales_Inv_AHDRBO ObjAT_SINV_HDR;
        M_AT_Sales_Inv_BDTLBO ObjAT_SINV_DTL;

        protected void Page_Load(object sender, EventArgs e)
        {

            PageMenuID = Request.QueryString["ID"];
            //SessionData.UserAccess.MenuID = PageMenuID;

            ObjAT_SINV_HDR = new M_AT_Sales_Inv_AHDRBO();
            ObjAT_SINV_DTL = new M_AT_Sales_Inv_BDTLBO();
           

            SetControlType();


            if (!IsPostBack)
            {
                MaheshAF18.UIControlHelper.GenricControl.GetOperatorList(ddOperator);
                MaheshAF18.UIControlHelper.GenricControl.GetFieldListByGrid(gvList, ddSearchBy);
                MaheshAF18.UIControlHelper.GenricControl.GetFieldListByGrid(gvEwayBill, ddSearchBy);

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
                CE_SINV_DT.EndDate = DateTime.Now;
                CE_SINV_PO_DT.EndDate = DateTime.Now;

                SetValueType(TextType.DateField, Txt_FromDT);
                SetValueType(TextType.DateField, Txt_ToDT);
                SetValueType(TextType.AmountField, SINV_QTY);
                SetValueType(TextType.AmountField, SINV_BasicRate);
                SetValueType(TextType.AmountField, SINV_DiscountRate);
                SetValueType(TextType.DateField, SINV_DT);
                SetValueType(TextType.NumericField, SINV_CreditDays);
                SetValueType(TextType.DateField, SINV_DueDT);
                SetValueType(TextType.DateField, SINV_PO_DT);
                SetValueType(TextType.DateField, MDBSC_RowCreatedOn_DT);
                SetValueType(TextType.AmountField, SINV_HDR_BasicAmt);
                SetValueType(TextType.AmountField, SINV_HDR_DiscountAmt);
                SetValueType(TextType.AmountField, SINV_HDR_Net_Amt);
                SetValueType(TextType.AmountField, SINV_HDR_Freight_Charges);
                SetValueType(TextType.AmountField, SINV_HDR_CGST_Amt);
                SetValueType(TextType.AmountField, SINV_HDR_SGST_Amt);
                SetValueType(TextType.AmountField, SINV_HDR_IGST_Amt);
                SetValueType(TextType.AmountField, SINV_HDR_CESS_Amt);
                SetValueType(TextType.AmountField, SINV_HDR_Gross_Amt);
                SetValueType(TextType.AmountField, SINV_HDR_Round_Off_Amt);
                SetValueType(TextType.AmountField, SINV_HDR_Total_Gross_Amt);
                SetValueType(TextType.AmountField, SINV_HDR_Total_Tax_Amt);
                SetValueType(TextType.AmountField, SINV_ewbill_Amount);

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

            Fk_MItem_ID.DataSource = MaheshAF18.Utility.M_DropDownList.Fill_Drop_Down_List("v_M_AT_Mst_ItemMaster", "MItem_ID", "vItem_TxtDD", "", "", "Item", 0, "N", "");
            Fk_MItem_ID.DataBind();

            DataTable dt = new DataTable();
            dt = MaheshAF18.Utility.M_DropDownList.Fill_Drop_Down_List("v_AAA_M_RT_GEO_State", "GStateID", "vStateDisplayName", "  ", "", "State", 0, "N", "");
            SINV_ShippedFrom_State_ID.DataSource = dt;
            SINV_ShippedFrom_State_ID.DataBind();

            SINV_ShippTo_State_ID.DataSource = dt;
            SINV_ShippTo_State_ID.DataBind();


        }
        #endregion
        #region "Refrish Grid Functions"
        private void RefreshGrid_HDR(string SearchCriteria = "")
        {
            try
            {
                string var_SQLFilter = "";
                var_SQLFilter = var_SQLFilter + " AND SINV_Category ='Tax Invoice'";

                if ((Txt_FromDT.Text.Length > 0) && (Txt_ToDT.Text.Length > 0))
                {
                    var_SQLFilter = var_SQLFilter + " AND SINV_DT BETWEEN  '" + Txt_FromDT.Text + "' AND  '" + Txt_ToDT.Text + "'";
                }
                DataTable dt = default(DataTable);
                dt = MABL.BL.AppDataModal.Get_Sales_List(0, var_SQLFilter, SearchCriteria);
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
                dt = MABL.BL.AppDataModal.Get_Sales_Item_List(Convert.ToInt64(SINVHDR_ID.Text), Convert.ToInt64(SINVDTL_ID.Text), "", "");
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
                //dt = dt = MABL.BL.AppDataModal.Get_Purchase_Tax_List(Convert.ToInt64(SINVHDR_ID.Text),0, "", "");
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
            //panelEwawill.Visible = false;
            //divEway.Visible = false;
            //panelEwawill2.Visible = false;
            //ViewINV11.Visible = true;
            //PnlTotal.Visible = true;
            //item_Id.Visible = true;
            //hr2.Visible = false;
            //hr1.Visible = true;
            EwabillDiv.Visible = false;
            ItemListdiv.Visible = true;
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

                SINVHDR_ID.Text = "0";
                Fk_CustomerID.SelectedIndex = 0;
                Msg_ErrorMsg.Text = "";

                SINV_Taxtype.Text = "";
                SINV_No.Text = MEF.GetRefNo(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, "Tax Invoice", "TINV", "TINV", "Yes");
                SINV_DT.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));

                SINV_CreditDays.Text = "30";
                SINV_DueDT.Text = "";
                SINV_PONo.Text = "";
                SINV_PO_DT.Text = "";
                SINV_Remark.Text = "";
                MDBSC_RowStatus.Text = "";
                MDBSC_RowCreatedByUserName.Text = SessionUserData.UserData.UserName;
                MDBSC_RowCreatedOn_DT.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
                SINV_HDR_BasicAmt.Text = "0.00";
                SINV_HDR_DiscountAmt.Text = "0.00";
                SINV_HDR_Net_Amt.Text = "0.00";
                SINV_HDR_Freight_Charges.Text = "0.00";
                SINV_HDR_CGST_Amt.Text = "0.00";
                SINV_HDR_SGST_Amt.Text = "0.00";
                SINV_HDR_IGST_Amt.Text = "0.00";
                SINV_HDR_CESS_Amt.Text = "0.00";
                SINV_HDR_Gross_Amt.Text = "0.00";
                SINV_HDR_Round_Off_Amt.Text = "0.00";
                SINV_HDR_Total_Gross_Amt.Text = "0.00";

                SINV_HDR_Total_Tax_Amt.Text = "0.00";
                SINV_ewb_Amount.Text = "0.00";

                SINV_CreditDays.Text = "0";
                SINV_ShippedFrom_State_ID.SelectedIndex = 0;
                
                MCust_Reg_StateDisplayName.Text = "";
              
                SINV_ShippTo_State_ID.SelectedIndex = 0;
                SINV_BillTo_Add1.Text = "";
                SINV_BillTo_Add2.Text = "";
                SINV_BillTo_Add3.Text = "";
                SINV_BillTo_Pincode.Text = "";
                SINV_BillTo_City.Text = "";
              
                SINV_BillTo_Country.Text = "";
                SINV_BillTo_GSTNo.Text = "";
                SINV_BillTo_PANNO.Text = "";


                SINV_ShippTo_CompanyName.Text = "";
                SINV_ShippTo_ContactPersone.Text = "";
                SINV_ShippTo_CP_MobileNo.Text = "";
                SINV_ShippTo_Add1.Text = "";
                SINV_ShippTo_Add2.Text = "";
                SINV_ShippTo_Add3.Text = "";


                SINV_ModeOfDispatch.Text = "";
                SINV_PaymentTerms.Text = "";
                SINV_DelvieryPeriod.Text = "";
                SINV_TranspoterName.Text = "";
                SINV_PlaceOfDelivery.Text = "";
                SINV_VehicleNumber.Text = "";
                SINV_LRNumber.Text = "";
                SINV_ShippTo_Pincode.Text = "";
                SINV_ShippTo_City.Text = "";

                SINV_ShippTo_Country.Text = "";
                SINV_ShippTo_GSTNo.Text = "";
                SINV_ShippTo_PANNO.Text = "";

                //SINV_ewb_TransDocNo.Text = "";
                SINV_ewb_TransDocNo.Text = MEF.GetRefNo(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, "Tax Invoice", "TINV", "TINV", "Yes");
                SINV_ewb_TransDocDate.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
                SINV_ewb_Distance.Text = "0";
                SINV_ewb_TransporterId.Text = "0";
                //SINV_ewb_TransporterName.Text = "";
                SINV_ewb_TransactionType.Text = "";
                SINV_ewb_TransactionSubType.Text = "";
                SINV_ewb_VehicleType.Text = "";

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

                SINVDTL_ID.Text = "0";
                Fk_MItem_ID.SelectedIndex = 0;
                SINV_BasicRate.Text = "0";
                SINV_HSNCode.Text = "";
                SINV_QTY.Text = "0";
                SINV_DiscountRate.Text = "0";

                SINV_ItemRemark_DTL.Text = "";
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
                if (SINV_No.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Customer Invoice No Cannot Be Blank.<br>";
                }

                if (SINV_ShippedFrom_State_ID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Place Of Dispatch<br>";
                }


                if (SINV_ShippTo_State_ID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Place Of Supply<br>";
                }

               
                //if (SINV_ShippTo_GSTNo.Text.Length != 15)
                //{
                //    ErrorMessage = ErrorMessage + "Invalid Ship To GSTNO<br>";
                //}

                
                //if (SINV_ShippTo_PANNO.Text.Length != 10)
                //{
                //    ErrorMessage = ErrorMessage + "Invalid Ship To PAN No<br>";
                //}



                if ((SINV_No.Text.Length > 0) && (Fk_CustomerID.SelectedIndex > 0))
                {
                    if (SQLManager.CheckDuplicateRecord("M_AT_Sales_Inv_AHDR", "SINVHDR_ID", Convert.ToInt32("0" + SINVHDR_ID.Text), "SINV_No", SINV_No.Text,
                                                       " AND Fk_Branch_ID=" + SessionUserData.Company.BranchID ))
                    {
                        ErrorMessage = ErrorMessage + "Customer Invoice Already Exist.<br>";
                    }
                }

                if (SINV_DT.Text.Length != 11)
                {
                    ErrorMessage = ErrorMessage + "Invalid Customer Invoice Date.<br>";
                }
                if ((Fk_CustomerID.SelectedIndex > 0) && (Convert.ToInt32(SINVHDR_ID.Text) == 0))
                {
                    if (Fk_MItem_ID.SelectedIndex == 0)
                    {
                        ErrorMessage = ErrorMessage + "Pls Select Item<br>";
                    }
                    if (SINV_BasicRate.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Rate<br>";
                    }
                    if (SINV_QTY.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Quantity<br>";
                    }
                    else
                    {
                        if (Convert.ToDecimal(SINV_QTY.Text) <= 0)
                        {
                            ErrorMessage = ErrorMessage + "Invalid Item Quantity<br>";
                        }
                    }
                }
                if ((Convert.ToInt32(SINVHDR_ID.Text) > 0) && (Convert.ToInt32(SINVDTL_ID.Text) > 0) && (Fk_MItem_ID.SelectedIndex > 0))
                {
                    if (Fk_MItem_ID.SelectedIndex == 0)
                    {
                        ErrorMessage = ErrorMessage + "Pls Select Item<br>";
                    }
                    if (SINV_BasicRate.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Rate<br>";
                    }
                    if (SINV_QTY.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Quantity<br>";
                    }
                    else
                    {
                        if (Convert.ToDecimal(SINV_QTY.Text) <= 0)
                        {
                            ErrorMessage = ErrorMessage + "Invalid Item Quantity<br>";
                        }
                    }
                }


                if (ErrorMessage.Length == 0)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (Convert.ToInt32(SINVHDR_ID.Text) == 0)
                        {
                            ObjAT_SINV_HDR.Fk_Company_ID = SessionUserData.Company.CompanyID;
                            ObjAT_SINV_HDR.Fk_Branch_ID = SessionUserData.Company.BranchID;
                            ObjAT_SINV_HDR.Fk_Year_ID = SessionUserData.Company.YearID;
                            ObjAT_SINV_HDR.Rec_Created_In = "HO";
                            ObjAT_SINV_HDR.Rec_CreatedBy_ID = SessionUserData.Company.BranchID;
                            ObjAT_SINV_HDR.Rec_CreatedFor_ID = SessionUserData.Company.BranchID;
                            ObjAT_SINV_HDR.SINV_CreationType = "Manual";
                            ObjAT_SINV_HDR.SINV_Category = "Tax Invoice";
                            ObjAT_SINV_HDR.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName;
                            ObjAT_SINV_HDR.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                            ObjAT_SINV_HDR.SINV_No = MEF.GenrateRefNo(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, "Tax Invoice", "TINV", "TINV", "Yes", "", "", "", 0);

                        }
                        SetValuesToBO_HDR();
                        ErrorMessage = ObjAT_SINV_HDR.Insert_Update(ObjAT_SINV_HDR);
                        SINVHDR_ID.Text = ErrorMessage.Substring((ErrorMessage.IndexOf("|") + 1), (ErrorMessage.Length - ErrorMessage.IndexOf("|") - 1));
                        ErrorMessage = ErrorMessage.Substring((0), (ErrorMessage.IndexOf("|")));

                        if ((Convert.ToInt32(SINVHDR_ID.Text) > 0) && (Fk_MItem_ID.SelectedIndex > 0))
                        {
                            if (Convert.ToInt32(SINVDTL_ID.Text) == 0)
                            {
                                ObjAT_SINV_DTL.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                                ObjAT_SINV_DTL.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName;
                            }

                            ObjAT_SINV_DTL.SINVDTL_ID = Convert.ToInt64("0" + SINVDTL_ID.Text);
                            ObjAT_SINV_DTL.Fk_SINVHDR_ID = Convert.ToInt64("0" + SINVHDR_ID.Text);
                            ObjAT_SINV_DTL.Fk_MItem_ID = Convert.ToInt64("0" + Fk_MItem_ID.Text);
                            ObjAT_SINV_DTL.SINV_HSNCode = SINV_HSNCode.Text;
                            ObjAT_SINV_DTL.SINV_QTY = Convert.ToDecimal(SINV_QTY.Text);
                            ObjAT_SINV_DTL.SINV_Final_Qty = Convert.ToDecimal(SINV_QTY.Text);
                            ObjAT_SINV_DTL.SINV_BasicRate = Convert.ToDecimal(SINV_BasicRate.Text);
                            ObjAT_SINV_DTL.SINV_DiscountRate = Convert.ToDecimal(SINV_DiscountRate.Text);
                            ObjAT_SINV_DTL.SINV_CGST_ID = 0;
                            ObjAT_SINV_DTL.SINV_SGST_ID = 0;
                            ObjAT_SINV_DTL.SINV_IGST_ID = 0;
                            ObjAT_SINV_DTL.SINV_CESS_ID = 0;

                            ObjAT_SINV_DTL.SINV_ItemRemark_DTL = SINV_ItemRemark_DTL.Text;
                            ObjAT_SINV_DTL.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
                            ObjAT_SINV_DTL.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
                            ObjAT_SINV_DTL.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));

                            ObjAT_SINV_DTL.Insert_Update(ObjAT_SINV_DTL);


                        }

                        scope.Complete();
                    }

                    if (Convert.ToInt32("0" + SINVHDR_ID.Text) > 0)
                    {
                        MABL.SQLManager.SQLProcedureCall.USP_Update_Tbl_Sales(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, Convert.ToInt32(SINVHDR_ID.Text));
                        SetValueToControls_Edit_HDR(Convert.ToInt32("0" + SINVHDR_ID.Text));
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

        #region "Save Eway Bill"
        protected void btnGenerateEwayBill_Click(object sender, System.EventArgs e)
        {
            //panelEwawill.Visible = true;
            //divEway.Visible = true;
            //panelEwawill2.Visible = true;
            //ViewINV11.Visible = false;
            //PnlTotal.Visible = false;
            //item_Id.Visible = false;
            //hr2.Visible = true;
            //hr1.Visible = false;
            EwabillDiv.Visible = true;
            ItemListdiv.Visible = false;

           // MultiView1.ActiveViewIndex = 1;
        }

        protected void btnUpdate_Click(object sender, System.EventArgs e)
        {
            //MultiView1.ActiveViewIndex = 0;
            try
            {
                if (SINV_ewb_TransactionSubType.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Transaction SubType Can not be Blank.<br>";
                }

                if (SINV_ewb_TransporterId.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Transaction Id Cant be Blank.<br>";
                }
                if (SINV_ewb_TransDocNo.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Customer Document No Cannot Be Blank.<br>";
                }
                if (SINV_ewb_VehicleType.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Invalid Ship To VehicleType<br>";
                }
                if (SINV_ewb_Distance.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Invalid Distance<br>";
                }
                if (SINV_ewb_TransactionType.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Transaction Type Can not be blank<br>";
                }
                if ((SINV_ewb_TransDocNo.Text.Length > 0) && (Fk_CustomerID.SelectedIndex > 0))
                {
                    if (SQLManager.CheckDuplicateRecord("M_AT_Sales_Inv_AHDR", "SINVHDR_ID", Convert.ToInt32("0" + SINVHDR_ID.Text), "SINV_No", SINV_ewb_TransDocNo.Text,
                                                       " AND Fk_Branch_ID=" + SessionUserData.Company.BranchID))
                    {
                        ErrorMessage = ErrorMessage + "Customer Invoice Already Exist.<br>";
                    }
                }

                if (SINV_ewb_TransDocDate.Text.Length != 11)
                {
                    ErrorMessage = ErrorMessage + "Invalid Document Invoice Date.<br>";
                }
                
                

                if (ErrorMessage.Length == 0)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (Convert.ToInt32(SINVHDR_ID.Text) == 0)
                        {
                            ObjAT_SINV_HDR.Fk_Company_ID = SessionUserData.Company.CompanyID;
                            ObjAT_SINV_HDR.Fk_Branch_ID = SessionUserData.Company.BranchID;
                            ObjAT_SINV_HDR.Fk_Year_ID = SessionUserData.Company.YearID;
                            ObjAT_SINV_HDR.Rec_Created_In = "HO";
                            ObjAT_SINV_HDR.Rec_CreatedBy_ID = SessionUserData.Company.BranchID;
                            ObjAT_SINV_HDR.Rec_CreatedFor_ID = SessionUserData.Company.BranchID;
                            ObjAT_SINV_HDR.SINV_CreationType = "Manual";
                            ObjAT_SINV_HDR.SINV_Category = "Tax Invoice";
                            ObjAT_SINV_HDR.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName;
                            ObjAT_SINV_HDR.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                            ObjAT_SINV_HDR.SINV_No = MEF.GenrateRefNo(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, "Tax Invoice", "TINV", "TINV", "Yes", "", "", "", 0);
                           // ObjAT_SINV_HDR.SINV_ewb_TransDocNo = MEF.GenrateRefNo(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, "Tax Invoice", "TINV", "TINV", "Yes", "", "", "", 0);

                        }
                        SetValuesToBO_HDR();
                        ErrorMessage = ObjAT_SINV_HDR.Insert_Update(ObjAT_SINV_HDR);
                        SINVHDR_ID.Text = ErrorMessage.Substring((ErrorMessage.IndexOf("|") + 1), (ErrorMessage.Length - ErrorMessage.IndexOf("|") - 1));
                        ErrorMessage = ErrorMessage.Substring((0), (ErrorMessage.IndexOf("|")));

                        if ((Convert.ToInt32(SINVHDR_ID.Text) > 0) && (Fk_MItem_ID.SelectedIndex > 0))
                        {
                            if (Convert.ToInt32(SINVDTL_ID.Text) == 0)
                            {
                                ObjAT_SINV_DTL.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                                ObjAT_SINV_DTL.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName;
                            }

                            ObjAT_SINV_DTL.SINVDTL_ID = Convert.ToInt64("0" + SINVDTL_ID.Text);
                            ObjAT_SINV_DTL.Fk_SINVHDR_ID = Convert.ToInt64("0" + SINVHDR_ID.Text);
                            ObjAT_SINV_DTL.Fk_MItem_ID = Convert.ToInt64("0" + Fk_MItem_ID.Text);
                            ObjAT_SINV_DTL.SINV_HSNCode = SINV_HSNCode.Text;
                            ObjAT_SINV_DTL.SINV_QTY = Convert.ToDecimal(SINV_QTY.Text);
                            ObjAT_SINV_DTL.SINV_Final_Qty = Convert.ToDecimal(SINV_QTY.Text);
                            ObjAT_SINV_DTL.SINV_BasicRate = Convert.ToDecimal(SINV_BasicRate.Text);
                            ObjAT_SINV_DTL.SINV_DiscountRate = Convert.ToDecimal(SINV_DiscountRate.Text);
                            ObjAT_SINV_DTL.SINV_CGST_ID = 0;
                            ObjAT_SINV_DTL.SINV_SGST_ID = 0;
                            ObjAT_SINV_DTL.SINV_IGST_ID = 0;
                            ObjAT_SINV_DTL.SINV_CESS_ID = 0;

                            ObjAT_SINV_DTL.SINV_ItemRemark_DTL = SINV_ItemRemark_DTL.Text;
                            ObjAT_SINV_DTL.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
                            ObjAT_SINV_DTL.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
                            ObjAT_SINV_DTL.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));

                            ObjAT_SINV_DTL.Insert_Update(ObjAT_SINV_DTL);


                        }

                        scope.Complete();
                    }

                    if (Convert.ToInt32("0" + SINVHDR_ID.Text) > 0)
                    {
                        MABL.SQLManager.SQLProcedureCall.USP_Update_Tbl_Sales(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, Convert.ToInt32(SINVHDR_ID.Text));
                        SetValueToControls_Edit_HDR(Convert.ToInt32("0" + SINVHDR_ID.Text));
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
        protected void btnExit_Click(object sender, System.EventArgs e)
        {
            //try
            //{
            //    Response.Redirect(SessionUserData.AppInfo.DefaultRedirect);
            //}
            //catch (Exception ex)
            //{
            //    DisplayCustomMessageSummary(ex.Message);
            //}
            EwabillDiv.Visible = false;
            ItemListdiv.Visible = true;
        }
        #endregion
        #region "SetValue"
        private void SetValuesToBO_HDR()
        {
            try
            {

                ObjAT_SINV_HDR.SINVHDR_ID = Convert.ToInt64("0" + SINVHDR_ID.Text);

                
                ObjAT_SINV_HDR.SINV_DT = SINV_DT.Text;
                ObjAT_SINV_HDR.Fk_CustomerID = Convert.ToInt32(Fk_CustomerID.Text);
                ObjAT_SINV_HDR.SINV_CreditDays = Convert.ToInt32("0" + SINV_CreditDays.Text);
                ObjAT_SINV_HDR.SINV_PONo = SINV_PONo.Text;
                if (SINV_PO_DT.Text.Length == 11)
                {
                    ObjAT_SINV_HDR.SINV_PO_DT = SINV_PO_DT.Text;
                }
                ObjAT_SINV_HDR.SINV_Remark = SINV_Remark.Text;
                ObjAT_SINV_HDR.MDBSC_RowStatus = MDBSC_RowStatus.Text;
                ObjAT_SINV_HDR.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
                ObjAT_SINV_HDR.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
                ObjAT_SINV_HDR.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
                ObjAT_SINV_HDR.SINV_HDR_Freight_Charges = Convert.ToDecimal("0" + SINV_HDR_Freight_Charges.Text);

                ObjAT_SINV_HDR.SINV_BillTo_Add1 = SINV_BillTo_Add1.Text;
                ObjAT_SINV_HDR.SINV_BillTo_Add2 = SINV_BillTo_Add2.Text;
                ObjAT_SINV_HDR.SINV_BillTo_Add3 = SINV_BillTo_Add3.Text;
                ObjAT_SINV_HDR.SINV_BillTo_Pincode = SINV_BillTo_Pincode.Text;
                ObjAT_SINV_HDR.SINV_BillTo_City = SINV_BillTo_City.Text;
                ObjAT_SINV_HDR.SINV_BillTo_Country = SINV_BillTo_Country.Text;
                ObjAT_SINV_HDR.SINV_BillTo_PANNO = SINV_BillTo_PANNO.Text;
                ObjAT_SINV_HDR.SINV_BillTo_GSTNo = SINV_BillTo_GSTNo.Text;
               

                ObjAT_SINV_HDR.SINV_ShippTo_CompanyName = SINV_ShippTo_CompanyName.Text;
                ObjAT_SINV_HDR.SINV_ShippTo_ContactPersone = SINV_ShippTo_ContactPersone.Text;
                ObjAT_SINV_HDR.SINV_ShippTo_CP_MobileNo = SINV_ShippTo_CP_MobileNo.Text;
                ObjAT_SINV_HDR.SINV_ShippTo_Add1 = SINV_ShippTo_Add1.Text;
                ObjAT_SINV_HDR.SINV_ShippTo_Add2 = SINV_ShippTo_Add2.Text;
                ObjAT_SINV_HDR.SINV_ShippTo_Add3 = SINV_ShippTo_Add3.Text;
                ObjAT_SINV_HDR.SINV_ShippTo_Pincode = SINV_ShippTo_Pincode.Text;

                ObjAT_SINV_HDR.SINV_ShippedFrom_CompanyName = "";
                ObjAT_SINV_HDR.SINV_ShippedFrom_ContactPersone = "";
                ObjAT_SINV_HDR.SINV_ShippedFrom_CP_MobileNo = "";
                ObjAT_SINV_HDR.SINV_ShippedFrom_Add1 = "";
                ObjAT_SINV_HDR.SINV_ShippedFrom_Add2 = "";
                ObjAT_SINV_HDR.SINV_ShippedFrom_Add3 = "";
                ObjAT_SINV_HDR.SINV_ShippedFrom_Pincode = "";

                ObjAT_SINV_HDR.SINV_ShippedFrom_City = "";
                ObjAT_SINV_HDR.SINV_ShippedFrom_State_ID = Convert.ToInt64(SINV_ShippedFrom_State_ID.Text);
                ObjAT_SINV_HDR.SINV_ShippedFrom_Country = "";
                ObjAT_SINV_HDR.SINV_ShippedFrom_GSTNo = "";
                ObjAT_SINV_HDR.SINV_ShippedFrom_PANNO = "";


                ObjAT_SINV_HDR.SINV_ShippTo_City = SINV_ShippTo_City.Text;
                ObjAT_SINV_HDR.SINV_ShippTo_State_ID = Convert.ToInt64(SINV_ShippTo_State_ID.Text);
                ObjAT_SINV_HDR.SINV_ShippTo_Country = SINV_ShippTo_Country.Text;
                ObjAT_SINV_HDR.SINV_ShippTo_GSTNo = SINV_ShippTo_GSTNo.Text;
                ObjAT_SINV_HDR.SINV_ShippTo_PANNO = SINV_ShippTo_PANNO.Text;

              
                ObjAT_SINV_HDR.SINV_ModeOfDispatch = SINV_ModeOfDispatch.Text;
                ObjAT_SINV_HDR.SINV_PaymentTerms = SINV_PaymentTerms.Text;
                ObjAT_SINV_HDR.SINV_DelvieryPeriod = SINV_DelvieryPeriod.Text;
                ObjAT_SINV_HDR.SINV_TranspoterName = SINV_TranspoterName.Text;

                ObjAT_SINV_HDR.SINV_PlaceOfDelivery = SINV_PlaceOfDelivery.Text;
                ObjAT_SINV_HDR.SINV_VehicleNumber = SINV_VehicleNumber.Text;
                ObjAT_SINV_HDR.SINV_LRNumber = SINV_LRNumber.Text;

                ObjAT_SINV_HDR.SINV_ewb_EwayBillNo = SINV_ewb_TransDocNo.Text;
               // ObjAT_SINV_HDR.SINV_ewb_TransDocNo = Convert.ToInt64(SINV_ewb_TransDocNo.Text);
                if (SINV_ewb_TransDocDate.Text.Length == 11)
                {
                    ObjAT_SINV_HDR.SINV_ewb_TransDocDate = SINV_ewb_TransDocDate.Text;
                }
                ObjAT_SINV_HDR.SINV_ewb_Distance = Convert.ToInt64(SINV_ewb_Distance.Text);
                ObjAT_SINV_HDR.SINV_ewb_TransporterId = Convert.ToInt64(SINV_ewb_TransporterId.Text);
                ObjAT_SINV_HDR.SINV_ewb_TransactionType = SINV_ewb_TransactionType.Text;
                ObjAT_SINV_HDR.SINV_ewb_TransactionSubType = SINV_ewb_TransactionSubType.Text;
                ObjAT_SINV_HDR.SINV_ewb_VehicleType = SINV_ewb_VehicleType.Text;
                ObjAT_SINV_HDR.SINV_ewb_Amount = Convert.ToDecimal(" " + SINV_ewb_Amount.Text);
                //ObjAT_SINV_HDR.SINV_HDR_Freight_Charges = Convert.ToDecimal("0" + SINV_HDR_Freight_Charges.Text);
      
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
                dt = MABL.BL.AppDataModal.Get_Sales_List(strPK, "", "");
                InitializeControls_HDR();
                InitializeControls_DTL();
                if (dt.Rows.Count > 0)
                {
                    SINVHDR_ID.Text = dt.Rows[0]["SINVHDR_ID"].ToString();

                    SINVHDR_ID.Text = dt.Rows[0]["SINVHDR_ID"].ToString();
                    SINV_Taxtype.Text = dt.Rows[0]["SINV_Taxtype"].ToString();
                    SINV_No.Text = dt.Rows[0]["SINV_No"].ToString();
                    SINV_DT.Text = dt.Rows[0]["vSINV_DT"].ToString();
                    Fk_CustomerID.Text = dt.Rows[0]["Fk_CustomerID"].ToString();
                    SINV_CreditDays.Text = dt.Rows[0]["SINV_CreditDays"].ToString();
                    SINV_DueDT.Text = dt.Rows[0]["vSINV_DueDT"].ToString();
                    SINV_PONo.Text = dt.Rows[0]["SINV_PONo"].ToString();
                    SINV_PO_DT.Text = dt.Rows[0]["vSINV_PO_DT"].ToString();

                    SINV_ModeOfDispatch.Text = dt.Rows[0]["SINV_ModeOfDispatch"].ToString();

                    SINV_PaymentTerms.Text = dt.Rows[0]["SINV_PaymentTerms"].ToString();
                    SINV_DelvieryPeriod.Text = dt.Rows[0]["SINV_DelvieryPeriod"].ToString();
                    SINV_TranspoterName.Text = dt.Rows[0]["SINV_TranspoterName"].ToString();
                    SINV_PlaceOfDelivery.Text = dt.Rows[0]["SINV_PlaceOfDelivery"].ToString();
                    SINV_VehicleNumber.Text = dt.Rows[0]["SINV_VehicleNumber"].ToString();
                    SINV_LRNumber.Text = dt.Rows[0]["SINV_LRNumber"].ToString();
 


                    SINV_Remark.Text = dt.Rows[0]["SINV_Remark"].ToString();

                    MDBSC_RowStatus.Text = dt.Rows[0]["MDBSC_RowStatus"].ToString();

                    MDBSC_RowCreatedByUserName.Text = dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
                    MDBSC_RowCreatedOn_DT.Text = dt.Rows[0]["vMDBSC_RowCreatedOn_DT"].ToString();

                    SINV_HDR_BasicAmt.Text = dt.Rows[0]["SINV_HDR_BasicAmt"].ToString();

                    SINV_HDR_DiscountAmt.Text = dt.Rows[0]["SINV_HDR_DiscountAmt"].ToString();
                    SINV_HDR_Net_Amt.Text = dt.Rows[0]["SINV_HDR_Net_Amt"].ToString();
                    SINV_HDR_Freight_Charges.Text = dt.Rows[0]["SINV_HDR_Freight_Charges"].ToString();
                    SINV_HDR_CGST_Amt.Text = dt.Rows[0]["SINV_HDR_CGST_Amt"].ToString();

                    SINV_HDR_SGST_Amt.Text = dt.Rows[0]["SINV_HDR_SGST_Amt"].ToString();

                    SINV_HDR_IGST_Amt.Text = dt.Rows[0]["SINV_HDR_IGST_Amt"].ToString();

                    SINV_HDR_CESS_Amt.Text = dt.Rows[0]["SINV_HDR_CESS_Amt"].ToString();

                    SINV_HDR_Total_Tax_Amt.Text = dt.Rows[0]["SINV_HDR_Total_Tax_Amt"].ToString();

                    SINV_HDR_Gross_Amt.Text = dt.Rows[0]["SINV_HDR_Gross_Amt"].ToString();
                    SINV_HDR_Round_Off_Amt.Text = dt.Rows[0]["SINV_HDR_Round_Off_Amt"].ToString();
                    SINV_HDR_Total_Gross_Amt.Text = dt.Rows[0]["SINV_HDR_Total_Gross_Amt"].ToString();

                    //Customer
                 
                    MCust_Reg_StateDisplayName.Text = dt.Rows[0]["MCust_Reg_StateDisplayName"].ToString();
                 

                    //SHIP FROM 
                  
                    //BILL TO
                    SINV_BillTo_Add1.Text = dt.Rows[0]["SINV_BillTo_Add1"].ToString();
                    SINV_BillTo_Add2.Text = dt.Rows[0]["SINV_BillTo_Add2"].ToString();
                    SINV_BillTo_Add3.Text = dt.Rows[0]["SINV_BillTo_Add3"].ToString();
                    SINV_BillTo_Pincode.Text = dt.Rows[0]["SINV_BillTo_Pincode"].ToString();
                    SINV_BillTo_City.Text = dt.Rows[0]["SINV_BillTo_City"].ToString();
                    SINV_BillTo_Country.Text = dt.Rows[0]["SINV_BillTo_Country"].ToString();
                    SINV_BillTo_PANNO.Text = dt.Rows[0]["SINV_BillTo_PANNO"].ToString();

                    SINV_BillTo_GSTNo.Text = dt.Rows[0]["SINV_BillTo_GSTNo"].ToString();
                    //SHIP TO
                    SINV_ShippTo_CompanyName.Text = dt.Rows[0]["SINV_ShippTo_CompanyName"].ToString();
                    SINV_ShippTo_ContactPersone.Text = dt.Rows[0]["SINV_ShippTo_ContactPersone"].ToString();
                    SINV_ShippTo_CP_MobileNo.Text = dt.Rows[0]["SINV_ShippTo_CP_MobileNo"].ToString();
                    SINV_ShippTo_Add1.Text = dt.Rows[0]["SINV_ShippTo_Add1"].ToString();
                    SINV_ShippTo_Add2.Text = dt.Rows[0]["SINV_ShippTo_Add2"].ToString();
                    SINV_ShippTo_Add3.Text = dt.Rows[0]["SINV_ShippTo_Add3"].ToString();
                    SINV_ShippTo_Pincode.Text = dt.Rows[0]["SINV_ShippTo_Pincode"].ToString();

                    SINV_ShippTo_City.Text = dt.Rows[0]["SINV_ShippTo_City"].ToString();
                    SINV_ShippTo_State_ID.Text = dt.Rows[0]["SINV_ShippTo_State_ID"].ToString();
                    SINV_ShippedFrom_State_ID.Text = dt.Rows[0]["SINV_ShippedFrom_State_ID"].ToString();
                    SINV_ShippTo_Country.Text = dt.Rows[0]["SINV_ShippTo_Country"].ToString();
                    SINV_ShippTo_GSTNo.Text = dt.Rows[0]["SINV_ShippTo_GSTNo"].ToString();
                    SINV_ShippTo_PANNO.Text = dt.Rows[0]["SINV_ShippTo_PANNO"].ToString();

                    //SINV_ewb_TransDocNo.Text = dt.Rows[0]["SINV_ewb_TransDocNo"].ToString();
                    SINV_ewb_TransDocNo.Text = dt.Rows[0]["SINV_No"].ToString();
                    SINV_ewb_TransDocDate.Text = dt.Rows[0]["vSINV_ewb_TransDocDate"].ToString();
                    SINV_ewb_Distance.Text = dt.Rows[0]["SINV_ewb_Distance"].ToString();
                    SINV_ewb_TransporterId.Text = dt.Rows[0]["SINV_ewb_TransporterId"].ToString();
                    SINV_ewb_TransactionType.Text = dt.Rows[0]["SINV_ewb_TransactionType"].ToString();
                    SINV_ewb_TransactionSubType.Text = dt.Rows[0]["SINV_ewb_TransactionSubType"].ToString();
                    SINV_ewb_VehicleType.Text = dt.Rows[0]["SINV_ewb_VehicleType"].ToString();
                    SINV_ewb_Amount.Text = dt.Rows[0]["SINV_ewb_Amount"].ToString();


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
            EwabillDiv.Visible = true;
            ItemListdiv.Visible = true;
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
                dt = MABL.BL.AppDataModal.Get_Sales_Item_List(Convert.ToInt64(SINVHDR_ID.Text), Convert.ToInt64(row.Cells[0].Text), "", "");
                if (dt.Rows.Count > 0)
                {
                    SINVDTL_ID.Text = dt.Rows[0]["SINVDTL_ID"].ToString();
                    Fk_MItem_ID.Text = dt.Rows[0]["Fk_MItem_ID"].ToString();
                    SINV_HSNCode.Text = dt.Rows[0]["SINV_HSNCode"].ToString();
                    SINV_QTY.Text = dt.Rows[0]["SINV_QTY"].ToString();
                    SINV_BasicRate.Text = dt.Rows[0]["SINV_BasicRate"].ToString();
                    SINV_DiscountRate.Text = dt.Rows[0]["SINV_DiscountRate"].ToString();

                    SINV_ItemRemark_DTL.Text = dt.Rows[0]["SINV_ItemRemark_DTL"].ToString();

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
                string RetMesg = MaheshAF18.Application.SQLManager.DeleteSRMD("", "M_AT_Sales_Inv_BDTL", "Fk_SINVHDR_ID", Convert.ToInt64(0 + row.Cells[1].Text), "SINVDTL_ID", Convert.ToInt64(0 + row.Cells[0].Text), "C", "");
                MABL.SQLManager.SQLProcedureCall.USP_Update_Tbl_Sales(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, Convert.ToInt32(SINVHDR_ID.Text));
                SetValueToControls_Edit_HDR(Convert.ToInt32(SINVHDR_ID.Text));
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

        protected void gvEwayBill_RowCreated(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
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
                if (SINV_Taxtype.Text == "IGST")
                {
                    e.Row.Cells[14].Visible = false;
                    e.Row.Cells[15].Visible = false;
                    e.Row.Cells[16].Visible = false;
                    e.Row.Cells[17].Visible = false;

                }
                if (SINV_Taxtype.Text == "SGST")
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

        protected void gvEwayBill_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
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

                SessionUserData.AppInfo.TempStrVariable_1 = SINV_Taxtype.Text;
                SessionUserData.AppInfo.TempIntVariable_1 =Convert.ToInt64( SINVHDR_ID.Text);
                Response.Write("<script type='text/javascript'>detailedresults=window.open('" + MABL.BL.AppVariable.Project_Constant("RptBrowse")  + "/ReportBrowser/TaxInvoice.aspx');</script>");

               
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
                    // Response.Write("<script type='text/javascript'>detailedresults=window.open('" + MABL.AppVariable.Project_Constant("RptBrowse") + "/ReportBrowser/GSTInvBrowser.aspx?InvoiceType=" + row.Cells[5].Text + "&INVID=" + row.Cells[0].Text + "');</script>");
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
                SINV_HSNCode.Text = dt.Rows[0]["HSNCode"].ToString();
                SINV_BasicRate.Text = dt.Rows[0]["Item_Selling_Rate"].ToString();
                SINV_QTY.Text = "1";
                SINV_DiscountRate.Text = "0";
                SINV_ItemRemark_DTL.Text = dt.Rows[0]["Item_Desc"].ToString();
            }
            else
            {
                SINV_HSNCode.Text = "";
                SINV_BasicRate.Text = "0";
                SINV_QTY.Text = "1";
                SINV_DiscountRate.Text = "0";
                SINV_ItemRemark_DTL.Text = "";
            }

        }
        protected void Fk_CustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = MABL.BL.AppDataModal.Get_Mst_Customer(Convert.ToInt64(Fk_CustomerID.Text), "", "");
            if (dt.Rows.Count > 0)
            {
                SINV_CreditDays.Text = dt.Rows[0]["MCust_CreditDays"].ToString();
                SINV_ShippTo_State_ID.Text = dt.Rows[0]["MCust_ShippTo_State_ID"].ToString();
                SINV_BillTo_Add1.Text = dt.Rows[0]["MCust_Reg_Add1"].ToString();
                SINV_BillTo_Add2.Text = dt.Rows[0]["MCust_Reg_Add2"].ToString();
                SINV_BillTo_Add3.Text = dt.Rows[0]["MCust_Reg_Add3"].ToString();
                SINV_BillTo_Pincode.Text = dt.Rows[0]["MCust_Reg_Pincode"].ToString();
                SINV_BillTo_City.Text = dt.Rows[0]["MCust_Reg_City"].ToString();
                MCust_Reg_StateDisplayName.Text = dt.Rows[0]["MCust_Reg_StateDisplayName"].ToString();
                SINV_BillTo_Country.Text = dt.Rows[0]["MCust_Reg_Country"].ToString();
                SINV_BillTo_GSTNo.Text = dt.Rows[0]["MCust_BL_GSTNO"].ToString();
                SINV_BillTo_PANNO.Text = dt.Rows[0]["MCust_BL_PANNO"].ToString();


                SINV_ShippTo_CompanyName.Text = dt.Rows[0]["MCust_ShippTo_CompanyName"].ToString();
                SINV_ShippTo_ContactPersone.Text = dt.Rows[0]["MCust_ShippTo_ContactPerson"].ToString();
                SINV_ShippTo_CP_MobileNo.Text = dt.Rows[0]["MCust_ShippTo_CP_MobileNo"].ToString();
                SINV_ShippTo_Add1.Text = dt.Rows[0]["MCust_ShippTo_Add1"].ToString();
                SINV_ShippTo_Add2.Text = dt.Rows[0]["MCust_ShippTo_Add2"].ToString();
                SINV_ShippTo_Add3.Text = dt.Rows[0]["MCust_ShippTo_Add3"].ToString();
                SINV_ShippTo_Pincode.Text = dt.Rows[0]["MCust_ShippTo_Pincode"].ToString();
                SINV_ShippTo_City.Text = dt.Rows[0]["MCust_ShippTo_City"].ToString();
                SINV_ShippTo_Country.Text = dt.Rows[0]["MCust_ShippTo_Country"].ToString();
                SINV_ShippTo_GSTNo.Text = dt.Rows[0]["MCust_ShippTo_GSTNO"].ToString();
                SINV_ShippTo_PANNO.Text = dt.Rows[0]["MCust_ShippTo_PANNO"].ToString();




            }
            else
            {
                SINV_CreditDays.Text = "";
                SINV_ShippTo_State_ID.SelectedIndex = 0;
                SINV_BillTo_Add1.Text = "";
                SINV_BillTo_Add2.Text ="";
                SINV_BillTo_Add3.Text = "";
                SINV_BillTo_Pincode.Text = "";
                SINV_BillTo_City.Text ="";
                MCust_Reg_StateDisplayName.Text = "";
                SINV_BillTo_Country.Text ="";
                SINV_BillTo_GSTNo.Text ="";
                SINV_BillTo_PANNO.Text ="";


                SINV_ShippTo_CompanyName.Text ="";
                SINV_ShippTo_ContactPersone.Text = "";
                SINV_ShippTo_CP_MobileNo.Text = "";
                SINV_ShippTo_Add1.Text ="";
                SINV_ShippTo_Add2.Text = "";
                SINV_ShippTo_Add3.Text ="";
                SINV_ShippTo_Pincode.Text ="";
                SINV_ShippTo_City.Text ="";
                SINV_ShippTo_Country.Text ="";
                SINV_ShippTo_GSTNo.Text ="";
                SINV_ShippTo_PANNO.Text ="";
            }

            DataTable dt_BranchDetails = new DataTable();
            dt_BranchDetails = MABL.BL.AppBL.Get_App_Branch_List(SessionUserData.Company.BranchID, "");
            if (dt.Rows.Count > 0)
            {
                //Branch Details
                SINV_ShippedFrom_State_ID.Text = dt_BranchDetails.Rows[0]["BR_Consignee_State_ID"].ToString();
                 


            }
            else
            {
                //Branch Details
                SINV_ShippTo_State_ID.SelectedIndex = 0;
                
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
                Div_EwayBill_HDR.Visible = false;

                if (SINV_ShippedFrom_State_ID.Text == SINV_ShippTo_State_ID.Text)
                {
                    SINV_Taxtype.Text = "SGST";
                }
                else
                {
                    SINV_Taxtype.Text = "IGST";
                }


                if (SINV_Taxtype.Text == "IGST")
                {
                    Div_IGST_HDR.Visible = true;

                }
                if (SINV_Taxtype.Text == "SGST")
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