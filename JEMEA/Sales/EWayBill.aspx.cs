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


namespace JEMEA.EWayBill
{
    public partial class EWayBill : Mahesh_Page
    {
        M_AT_Sales_SEWB_AHDRBO ObjAT_SEWB_HDR;
        M_AT_Sales_SEWB_BDTLBO ObjAT_SEWB_DTL;
        M_AT_Sales_SEWB_CDTLBO ObjAT_SEWB_TDTL;



        protected void Page_Load(object sender, EventArgs e)
        {

            PageMenuID = Request.QueryString["ID"];
            //SessionData.UserAccess.MenuID = PageMenuID;

            ObjAT_SEWB_HDR = new M_AT_Sales_SEWB_AHDRBO();
            ObjAT_SEWB_DTL = new M_AT_Sales_SEWB_BDTLBO();
            ObjAT_SEWB_TDTL = new M_AT_Sales_SEWB_CDTLBO();

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


                CE_SEWB_PO_DT.EndDate = DateTime.Now;


                SetValueType(TextType.DateField, Txt_FromDT);
                SetValueType(TextType.DateField, Txt_ToDT);
                SetValueType(TextType.DateField, SEWB_Doc_Date);
                SetValueType(TextType.DateField, SEWB_Trans_Doc_Date);
                SetValueType(TextType.NumericField, SEWB_TransporterID);
                SetValueType(TextType.NumericField, SEWB_Distance);
                SetValueType(TextType.NumericField, SEWB_Doc_No);
                SetValueType(TextType.NumericField, SEWB_Vehicle_No);
                SetValueType(TextType.AmountField, SEWB_HDR_DiscountAmt);
                SetValueType(TextType.AmountField, SEWB_HDR_Net_Amt);
                SetValueType(TextType.AmountField, SEWB_HDR_Freight_Charges);
                SetValueType(TextType.AmountField, SEWB_HDR_CGST_Amt);
                SetValueType(TextType.AmountField, SEWB_HDR_SGST_Amt);
                SetValueType(TextType.AmountField, SEWB_HDR_IGST_Amt);
                SetValueType(TextType.AmountField, SEWB_HDR_CESS_Amt);
                SetValueType(TextType.AmountField, SEWB_HDR_Gross_Amt);
                SetValueType(TextType.AmountField, SEWB_HDR_Round_Off_Amt);
                SetValueType(TextType.AmountField, SEWB_HDR_Total_Gross_Amt);
                SetValueType(TextType.AmountField, SEWB_HDR_Total_Tax_Amt);

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

            Fk_VendorID.DataSource = MaheshAF18.Utility.M_DropDownList.Fill_Drop_Down_List("v_M_AT_Sales_Inv_AHDR", "SINVHDR_ID", "SINV_No", "", "", "Invoice", 0, "N", "");
            Fk_VendorID.DataBind();


            DataTable dt = new DataTable();
            dt = MaheshAF18.Utility.M_DropDownList.Fill_Drop_Down_List("v_AAA_M_RT_GEO_State", "GStateID", "vStateDisplayName", "  ", "", "State", 0, "N", "");

            SEWB_ShippFrom_State_ID.DataSource = dt;
            SEWB_ShippFrom_State_ID.DataBind();

            SEWB_ShippTo_State_ID.DataSource = dt;
            SEWB_ShippTo_State_ID.DataBind();


        }
        #endregion
        #region "Refrish Grid Functions"
        private void RefreshGrid_HDR(string SearchCriteria = "")
        {
            try
            {
                string var_SQLFilter = "";
                var_SQLFilter = var_SQLFilter + " AND SEWB_Category ='Eway Will'";

                if ((Txt_FromDT.Text.Length > 0) && (Txt_ToDT.Text.Length > 0))
                {
                    var_SQLFilter = var_SQLFilter + " AND SEWB_DT BETWEEN  '" + Txt_FromDT.Text + "' AND  '" + Txt_ToDT.Text + "'";
                }
                DataTable dt = default(DataTable);
                dt = MABL.BL.AppDataModal.Get_EwayBill_List(0, var_SQLFilter, SearchCriteria);
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
                dt = MABL.BL.AppDataModal.Get_EwayBill_Item_List(Convert.ToInt64(SEWB_HDR_ID.Text), Convert.ToInt64(SEWB_CTL_ID.Text), "", "");
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
                //dt = dt = MABL.BL.AppDataModal.Get_Purchase_Tax_List(Convert.ToInt64(SEWB_HDR_ID.Text),0, "", "");
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
                SetValueToControls_Edit(SessionUserData.Company.BranchID);
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

                SEWB_HDR_ID.Text = "0";
                Fk_VendorID.SelectedIndex = 0;
                Msg_ErrorMsg.Text = "";

                ddlSEWB_Trn_Type.Text = "";
                SEWB_Doc_No.Text = "";
                ddlSEWB_Trn_Doc_Type.SelectedIndex = 0;
                SEWB_Doc_Date.Text = "";
                SEWB_TranspoterName.Text = "";
                SEWB_TransporterID.Text = "";
                SEWB_Distance.Text = "";
                SEWB_Trn_SubDesc.Text = "";

                SEWB_HDR_DiscountAmt.Text = "0.00";
                SEWB_HDR_Net_Amt.Text = "0.00";
                SEWB_HDR_Freight_Charges.Text = "0.00";
                SEWB_HDR_CGST_Amt.Text = "0.00";
                SEWB_HDR_SGST_Amt.Text = "0.00";
                SEWB_HDR_IGST_Amt.Text = "0.00";
                SEWB_HDR_CESS_Amt.Text = "0.00";
                SEWB_HDR_Gross_Amt.Text = "0.00";
                SEWB_HDR_Round_Off_Amt.Text = "0.00";
                SEWB_HDR_Total_Gross_Amt.Text = "0.00";
                SEWB_HDR_Total_Tax_Amt.Text = "0.00";

                SEWB_ShippTo_ContactPersone.Text = "";
                SEWB_Trn_SubDesc.Text = "";
                SEWB_ShippTo_Add1.Text = "";
                SEWB_ShippTo_Add2.Text = "";
                SEWB_ShippTo_Add3.Text = "";
                SEWB_ShippTo_Pincode.Text = "";
                SEWB_ShippTo_Place.Text = "";
                SEWB_ShippTo_GSTNo.Text = "";
                MVen_Reg_StateDisplayName.Text="";
                SEWB_ShippFrom_State_ID.SelectedIndex = 0;

                //SEWB_ShippedFrom_ContactPersone.Text = "";
                //SEWB_ShippedFrom_Add1.Text = "";
                //SEWB_ShippedFrom_Add2.Text = "";
                //SEWB_ShippedFrom_Add3.Text = "";
                //SEWB_ShippedFrom_Pincode.Text = "";
                //SEWB_ShippFrom_Place.Text = "";
                //SEWB_ShippedFrom_GSTNo.Text = "";
                //SEWB_BillTo_StateDisplayName.Text = "";
                //SEWB_ShippTo_State_ID.SelectedIndex = 0;


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

                SEWB_CTL_ID.Text = "0";
                DDlVehicle.SelectedIndex = 0;
                ddlSEWB_Trans_Mode.SelectedIndex = 0;
                SEWB_Trans_Doc_No.Text = "";
                SEWB_Trans_Doc_Date.Text = "";
                SEWB_Vehicle_No.Text = "";

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

                //if (Fk_VendorID.SelectedIndex == 0)
                //{
                //    ErrorMessage = ErrorMessage + "Select Invoice.<br>";
                //}
                if (ddlSEWB_Trn_Type.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Sub Type can not be Blank.<br>";
                }
                if (SEWB_Doc_No.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Document No Cannot be Blank.<br>";
                }
                if (SEWB_Doc_No.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Document Type Cannot Be Blank.<br>";
                }
                if (SEWB_Doc_Date.Text.Length != 11)
                {
                    ErrorMessage = ErrorMessage + "Invalid Vendor Document Date.<br>";
                }
                if (SEWB_TranspoterName.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Transporter Name Cannot be Blank.<br>";
                }
                if (SEWB_TransporterID.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "TransporterId Cannot be Blank.<br>";
                }
                if (SEWB_Distance.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Distance should be more than 100 km.<br>";
                }
                if (SEWB_Trn_SubDesc.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "SubDiscription be Blank.<br>";
                }


                if (ddlSEWB_Trans_Mode.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Mode Of Transaction can not be blank<br>";
                }
                if (SEWB_Trans_Doc_No.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Transaction doc no can not be blank<br>";
                }

                if (SEWB_Trans_Doc_Date.Text.Length != 11)
                {
                    ErrorMessage = ErrorMessage + "Invalid Transporter Doc Date.<br>";
                }

                if (SEWB_ShippTo_State_ID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Select Supplier Place Of Supply<br>";
                }
                if (SEWB_ShippFrom_State_ID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Select Recipient Place Of Supply<br>";
                }


                if ((ddlSEWB_Trn_Type.Text.Length > 0) && (Fk_VendorID.SelectedIndex > 0))
                {
                    if (SQLManager.CheckDuplicateRecord("v_M_AT_Sales_SEWB_AHDR", "SEWB_HDR_ID", Convert.ToInt32("0" + SEWB_HDR_ID.Text), "SINV_No", ddlSEWB_Trn_Type.Text,
                                                        " AND Fk_Branch_ID=" + SessionUserData.Company.BranchID + " AND  Fk_VendorID=" + Fk_VendorID.Text))
                    {
                        ErrorMessage = ErrorMessage + "Vendor Purchase Invoice Already Exist.<br>";
                    }
                }


                if ((Fk_VendorID.SelectedIndex > 0) && (Convert.ToInt32(SEWB_HDR_ID.Text) == 0))
                {

                    if (ddlSEWB_Trans_Mode.SelectedIndex == 0)
                    {
                        ErrorMessage = ErrorMessage + "Mode Of Transaction can not be blank<br>";
                    }
                    if (SEWB_Trans_Doc_No.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Mode Of Transaction can not be blank<br>";
                    }

                    if (SEWB_Trans_Doc_Date.Text.Length != 11)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Vendor Transporter Doc Date Date.<br>";
                    }

                    else
                    {

                    }
                }
                if ((Convert.ToInt32(SEWB_HDR_ID.Text) > 0) && (Convert.ToInt32(SEWB_CTL_ID.Text) > 0) && (DDlVehicle.SelectedIndex > 0))
                    
                {

                    if (ddlSEWB_Trans_Mode.SelectedIndex == 0)
                    {
                        ErrorMessage = ErrorMessage + "Mode Of Transaction can not be blank<br>";
                    }
                    if (SEWB_Trans_Doc_No.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Mode Of Transaction can not be blank<br>";
                    }

                    if (SEWB_Trans_Doc_Date.Text.Length != 11)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Vendor Transporter Doc Date Date.<br>";
                    }
                    if (DDlVehicle.SelectedValue.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Select Vehicle Type.<br>";
                    }
                    else
                    {
                    }
                }


                if (ErrorMessage.Length == 0)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (Convert.ToInt32(SEWB_HDR_ID.Text) == 0)
                        {
                            ObjAT_SEWB_HDR.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName;
                            ObjAT_SEWB_HDR.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;


                        }
                        SetValuesToBO_HDR();
                        ErrorMessage = ObjAT_SEWB_HDR.Insert_Update(ObjAT_SEWB_HDR);
                        SEWB_HDR_ID.Text = ErrorMessage.Substring((ErrorMessage.IndexOf("|") + 1), (ErrorMessage.Length - ErrorMessage.IndexOf("|") - 1));
                        ErrorMessage = ErrorMessage.Substring((0), (ErrorMessage.IndexOf("|")));

                        if ((Convert.ToInt32(SEWB_HDR_ID.Text) > 0) && (DDlVehicle.SelectedIndex >= 0))
                        {
                            if (Convert.ToInt32(SEWB_CTL_ID.Text) == 0)
                            {
                                ObjAT_SEWB_DTL.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                                ObjAT_SEWB_DTL.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName;
                            }

                            ObjAT_SEWB_TDTL.SEWB_CTL_ID = Convert.ToInt64("0" + SEWB_CTL_ID.Text);
                            ObjAT_SEWB_TDTL.Fk_SEWB_HDR_ID = Convert.ToInt64("0" + SEWB_HDR_ID.Text);
                            ObjAT_SEWB_TDTL.SEWB_Trans_Mode = ddlSEWB_Trans_Mode.SelectedValue;
                            ObjAT_SEWB_TDTL.SEWB_Vehicle_Type = DDlVehicle.SelectedValue;
                            ObjAT_SEWB_TDTL.SEWB_Vehicle_No = SEWB_Vehicle_No.Text;
                            ObjAT_SEWB_TDTL.SEWB_Trans_Doc_No = SEWB_Trans_Doc_No.Text;
                            ObjAT_SEWB_TDTL.SEWB_Trans_Doc_Date = SEWB_Trans_Doc_Date.Text;
                            ObjAT_SEWB_DTL.SEWB_CGST_ID = 0;
                            ObjAT_SEWB_DTL.SEWB_SGST_ID = 0;
                            ObjAT_SEWB_DTL.SEWB_IGST_ID = 0;
                            ObjAT_SEWB_DTL.SEWB_CESS_ID = 0;
                            ObjAT_SEWB_TDTL.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
                            ObjAT_SEWB_TDTL.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
                            ObjAT_SEWB_TDTL.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));

                            ObjAT_SEWB_TDTL.Insert_Update(ObjAT_SEWB_TDTL);


                        }

                        scope.Complete();
                    }
                    if (Convert.ToInt32("0" + SEWB_HDR_ID.Text) > 0)
                    {
                        MABL.SQLManager.SQLProcedureCall.USP_Update_Tbl_EWayBill(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, Convert.ToInt32(SEWB_HDR_ID.Text));
                        SetValueToControls_Edit_HDR(Convert.ToInt32("0" + SEWB_HDR_ID.Text));
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

                ObjAT_SEWB_HDR.SEWB_HDR_ID = Convert.ToInt64("0" + SEWB_HDR_ID.Text);
                ObjAT_SEWB_HDR.SINV_No = Fk_VendorID.SelectedItem.Text;
                ObjAT_SEWB_HDR.SEWB_Trn_SubType = ddlSEWB_Trn_Type.Text;
                ObjAT_SEWB_HDR.SEWB_Trn_Doc_No = SEWB_Doc_No.Text;
                ObjAT_SEWB_HDR.SEWB_Trn_Doc_Type = ddlSEWB_Trn_Doc_Type.Text;
                ObjAT_SEWB_HDR.SEWB_Trn_Doc_Date = SEWB_Doc_Date.Text;
                ObjAT_SEWB_HDR.SEWB_TranspoterName = SEWB_TranspoterName.Text;
                ObjAT_SEWB_HDR.SEWB_TranspoterNo = SEWB_TransporterID.Text;
                ObjAT_SEWB_HDR.SEWB_Distance = SEWB_Distance.Text;
                ObjAT_SEWB_HDR.SEWB_Trn_SubDesc = SEWB_Trn_SubDesc.Text;
                ObjAT_SEWB_HDR.SEWB_Transpoter_DOC_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));

                //SHIP FROM 
                ObjAT_SEWB_HDR.SEWB_Supplier_Name = SEWB_ShippedFrom_ContactPersone.Text;
                ObjAT_SEWB_HDR.SEWB_Supplier_Add1 = SEWB_ShippedFrom_Add1.Text;
                ObjAT_SEWB_HDR.SEWB_Supplier_Add2 = SEWB_ShippedFrom_Add2.Text;
                ObjAT_SEWB_HDR.SEWB_Supplier_Add3 = SEWB_ShippedFrom_Add3.Text;
                ObjAT_SEWB_HDR.SEWB_Supplier_Pincode = SEWB_ShippedFrom_Pincode.Text;
                ObjAT_SEWB_HDR.SEWB_Supplier_State = MVen_Reg_StateDisplayName.Text;
                ObjAT_SEWB_HDR.SEWB_Supplier_GSTIN = SEWB_ShippedFrom_GSTNo.Text;
                ObjAT_SEWB_HDR.SEWB_Supplier_Place = SEWB_ShippFrom_Place.Text;
                ObjAT_SEWB_HDR.SEWB_Supplier_POS = SEWB_ShippFrom_State_ID.Text;

                //SHIP TO
                ObjAT_SEWB_HDR.SEWB_Recipient_Name = SEWB_ShippTo_ContactPersone.Text;
                ObjAT_SEWB_HDR.SEWB_Recipient_Add1 = SEWB_ShippTo_Add1.Text;
                ObjAT_SEWB_HDR.SEWB_Recipient_Add2 = SEWB_ShippTo_Add2.Text;
                ObjAT_SEWB_HDR.SEWB_Recipient_Add3 = SEWB_ShippTo_Add3.Text;
                ObjAT_SEWB_HDR.SEWB_Recipient_Pincode = SEWB_ShippTo_Pincode.Text;
                ObjAT_SEWB_HDR.SEWB_Recipient_State = SEWB_BillTo_StateDisplayName.Text;
                ObjAT_SEWB_HDR.SEWB_Recipient_GSTIN = SEWB_ShippTo_GSTNo.Text;
                ObjAT_SEWB_HDR.SEWB_Recipient_Place = SEWB_ShippTo_Place.Text;
                ObjAT_SEWB_HDR.SEWB_Recipient_POS = SEWB_ShippTo_State_ID.Text;

                ObjAT_SEWB_HDR.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
                ObjAT_SEWB_HDR.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
                ObjAT_SEWB_HDR.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        private void SetValueToControls_Edit(Int64 strPK)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = MABL.BL.AppBL.Get_App_Branch_List(strPK, "");
                InitializeControls_HDR();
                if (dt.Rows.Count > 0)
                {

                    SEWB_ShippedFrom_ContactPersone.Text = dt.Rows[0]["BR_Primary_Contact_Person"].ToString();
                    SEWB_ShippedFrom_Add1.Text = dt.Rows[0]["BR_Reg_Add1"].ToString();
                    SEWB_ShippedFrom_Add2.Text = dt.Rows[0]["BR_Reg_Add2"].ToString();
                    SEWB_ShippedFrom_Add3.Text = dt.Rows[0]["BR_Reg_Add3"].ToString();
                    SEWB_ShippedFrom_Pincode.Text = dt.Rows[0]["BR_Reg_Pincode"].ToString();
                    MVen_Reg_StateDisplayName.Text = dt.Rows[0]["BR_Reg_State_ID"].ToString();
                    SEWB_ShippedFrom_GSTNo.Text = dt.Rows[0]["BL_GSTNO"].ToString();
                    SEWB_ShippFrom_Place.Text = dt.Rows[0]["BR_Reg_City"].ToString();
                    SEWB_ShippFrom_State_ID.Text = dt.Rows[0]["BR_Consignee_State_ID"].ToString();



                    //ObjAT_SEWB_HDR.SEWB_Supplier_Name = SEWB_ShippedFrom_ContactPersone.Text;
                    //ObjAT_SEWB_HDR.SEWB_Supplier_Add1 = SEWB_ShippedFrom_Add1.Text;
                    //ObjAT_SEWB_HDR.SEWB_Supplier_Add2 = SEWB_ShippedFrom_Add2.Text;
                    //ObjAT_SEWB_HDR.SEWB_Supplier_Add3 = SEWB_ShippedFrom_Add3.Text;
                    //ObjAT_SEWB_HDR.SEWB_Supplier_Pincode = SEWB_ShippedFrom_Pincode.Text;
                    //ObjAT_SEWB_HDR.SEWB_Supplier_State = MVen_Reg_StateDisplayName.Text;
                    //ObjAT_SEWB_HDR.SEWB_Supplier_GSTIN = SEWB_ShippedFrom_GSTNo.Text;
                    //ObjAT_SEWB_HDR.SEWB_Supplier_Place = SEWB_ShippFrom_Place.Text;
                    //ObjAT_SEWB_HDR.SEWB_Supplier_POS = SEWB_ShippFrom_State_ID.Text;

                }

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
                dt = MABL.BL.AppDataModal.Get_EwayBill_List(strPK, "", "");
                InitializeControls_HDR();
                InitializeControls_DTL();
                if (dt.Rows.Count > 0)
                {
                    SEWB_HDR_ID.Text = dt.Rows[0]["SEWB_HDR_ID"].ToString();
                    SEWB_HDR_ID.Text = dt.Rows[0]["SEWB_HDR_ID"].ToString();
                    Fk_VendorID.SelectedItem.Text = dt.Rows[0]["SINV_No"].ToString();
                    ddlSEWB_Trn_Type.SelectedValue = dt.Rows[0]["SEWB_Trn_SubType"].ToString();
                    SEWB_Doc_No.Text = dt.Rows[0]["SEWB_Trn_Doc_No"].ToString();
                    ddlSEWB_Trn_Doc_Type.SelectedValue = dt.Rows[0]["SEWB_Trn_Doc_Type"].ToString();
                    SEWB_Doc_Date.Text = dt.Rows[0]["vSEWB_Trn_Doc_Date"].ToString();
                    SEWB_TranspoterName.Text = dt.Rows[0]["SEWB_TranspoterName"].ToString();
                    SEWB_TransporterID.Text = dt.Rows[0]["SEWB_TranspoterNo"].ToString();
                    SEWB_Distance.Text = dt.Rows[0]["SEWB_Distance"].ToString();
                    SEWB_Trn_SubDesc.Text = dt.Rows[0]["SEWB_Trn_SubDesc"].ToString();
                    SEWB_HDR_DiscountAmt.Text = dt.Rows[0]["SEWB_HDR_Discount_Amt"].ToString();
                    SEWB_HDR_CGST_Amt.Text = dt.Rows[0]["SEWB_HDR_CGST_Amt"].ToString();
                    SEWB_HDR_SGST_Amt.Text = dt.Rows[0]["SEWB_HDR_SGST_Amt"].ToString();
                    SEWB_HDR_IGST_Amt.Text = dt.Rows[0]["SEWB_HDR_IGST_Amt"].ToString();
                    SEWB_HDR_CESS_Amt.Text = dt.Rows[0]["SEWB_HDR_CESS_Amt"].ToString();
                    SEWB_HDR_Gross_Amt.Text = dt.Rows[0]["SEWB_HDR_Gross_Amt"].ToString();

                    //SHIP FROM 
                    //SEWB_ShippedFrom_ContactPersone.Text = dt.Rows[0]["SEWB_Supplier_Name"].ToString();
                    //SEWB_ShippedFrom_Add1.Text = dt.Rows[0]["SEWB_Supplier_Add1"].ToString();
                    //SEWB_ShippedFrom_Add2.Text = dt.Rows[0]["SEWB_Supplier_Add2"].ToString();
                    //SEWB_ShippedFrom_Add3.Text = dt.Rows[0]["SEWB_Supplier_Add3"].ToString();
                    //SEWB_ShippedFrom_Pincode.Text = dt.Rows[0]["SEWB_Supplier_Pincode"].ToString();
                    //MVen_Reg_StateDisplayName.Text = dt.Rows[0]["SEWB_Supplier_State"].ToString();
                    //SEWB_ShippedFrom_GSTNo.Text = dt.Rows[0]["SEWB_Supplier_GSTIN"].ToString();
                    //SEWB_ShippFrom_Place.Text = dt.Rows[0]["SEWB_Supplier_Place"].ToString();
                    //SEWB_ShippFrom_State_ID.SelectedValue = dt.Rows[0]["SEWB_Supplier_POS"].ToString();

                    //SHIP TO
                    SEWB_ShippTo_ContactPersone.Text = dt.Rows[0]["SEWB_Recipient_Name"].ToString();
                    SEWB_ShippTo_Add1.Text = dt.Rows[0]["SEWB_Recipient_Add1"].ToString();
                    SEWB_ShippTo_Add2.Text = dt.Rows[0]["SEWB_Recipient_Add2"].ToString();
                    SEWB_ShippTo_Add3.Text = dt.Rows[0]["SEWB_Recipient_Add3"].ToString();
                    SEWB_ShippTo_Pincode.Text = dt.Rows[0]["SEWB_Recipient_Pincode"].ToString();
                    SEWB_BillTo_StateDisplayName.Text = dt.Rows[0]["SEWB_Recipient_State"].ToString();
                    SEWB_ShippTo_GSTNo.Text = dt.Rows[0]["SEWB_Recipient_GSTIN"].ToString();
                    SEWB_ShippTo_Place.Text = dt.Rows[0]["SEWB_Recipient_Place"].ToString();
                    SEWB_ShippFrom_State_ID.SelectedValue = dt.Rows[0]["SEWB_Recipient_POS"].ToString();

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
                dt = MABL.BL.AppDataModal.Get_EwayBill_Item_List(Convert.ToInt64(SEWB_HDR_ID.Text), Convert.ToInt64(row.Cells[0].Text), "", "");
                if (dt.Rows.Count > 0)
                {
                    SEWB_CTL_ID.Text = dt.Rows[0]["SEWB_CTL_ID"].ToString();
                    ddlSEWB_Trans_Mode.Text = dt.Rows[0]["SEWB_Trans_Mode"].ToString();
                    DDlVehicle.SelectedValue = dt.Rows[0]["SEWB_Vehicle_Type"].ToString();
                    SEWB_Vehicle_No.Text = dt.Rows[0]["SEWB_Vehicle_No"].ToString();
                    SEWB_Trans_Doc_No.Text = dt.Rows[0]["SEWB_Trans_Doc_No"].ToString();
                    SEWB_Trans_Doc_Date.Text = dt.Rows[0]["vSEWB_Trans_Doc_Date"].ToString();
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
                string RetMesg = MaheshAF18.Application.SQLManager.DeleteSRMD("", "M_AT_Sales_SEWB_CDTL", "Fk_SEWB_HDR_ID", Convert.ToInt64(0 + row.Cells[1].Text), "SEWB_CTL_ID", Convert.ToInt64(0 + row.Cells[0].Text), "C", "");
                MABL.SQLManager.SQLProcedureCall.USP_Update_Tbl_Purchase(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, Convert.ToInt32(SEWB_HDR_ID.Text));
                SetValueToControls_Edit_HDR(Convert.ToInt32(SEWB_HDR_ID.Text));
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
                e.Row.Cells[2].Visible = true;
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
                // MABL.AppVariable.PrintDosReport_Invoice(SEWB_HDR_ID.Text);
                //if ((Inv_TaxType.Text == "SGST") || (Inv_TaxType.Text == "IGST"))
                //{
                // //   Response.Write("<script type='text/javascript'>detailedresults=window.open('" + MABL.AppVariable.Project_Constant("RptBrowse") + "/ReportBrowser/GSTInvBrowser.aspx?InvoiceType=" + Inv_TaxType.Text + "&INVID=" + SEWB_HDR_ID.Text + "');</script>");
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
        protected void Fk_VendorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = MABL.BL.AppDataModal.Get_Sales_List(Convert.ToInt64(Fk_VendorID.Text), "", "");
            if (dt.Rows.Count > 0)
            {
                SEWB_ShippTo_ContactPersone.Text = dt.Rows[0]["SINV_ShippTo_ContactPersone"].ToString();
                SEWB_ShippTo_Add1.Text = dt.Rows[0]["SINV_ShippTo_Add1"].ToString();
                SEWB_ShippTo_Add2.Text = dt.Rows[0]["SINV_ShippTo_Add2"].ToString();
                SEWB_ShippTo_Add3.Text = dt.Rows[0]["SINV_ShippTo_Add3"].ToString();
                SEWB_ShippTo_Pincode.Text = dt.Rows[0]["SINV_ShippTo_Pincode"].ToString();
                SEWB_BillTo_StateDisplayName.Text = dt.Rows[0]["SINV_ShippTo_State_ID"].ToString();
                SEWB_ShippTo_GSTNo.Text = dt.Rows[0]["SINV_ShippTo_GSTNo"].ToString();
                SEWB_ShippTo_Place.Text = dt.Rows[0]["SINV_ShippTo_City"].ToString();
                SEWB_ShippTo_State_ID.Text = dt.Rows[0]["SINV_ShippTo_State_ID"].ToString();
            }
            TaxType_Toggel();
        }

        protected void ddlSEWB_Trans_Mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlSEWB_Trans_Mode.SelectedValue == "Road")
            {
                DDlVehicle.Enabled = true;
                SEWB_Vehicle_No.Enabled = true;
            }
            else
            {
                DDlVehicle.Enabled = false;
                SEWB_Vehicle_No.Enabled = false;
            }
            DDlVehicle.SelectedIndex = 0;
            SEWB_Vehicle_No.Text = "";
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
                Div_CGST_HDR.Visible = true;
                Div_SGST_HDR.Visible = true;
                Div_IGST_HDR.Visible = true;

                if (SEWB_ShippFrom_State_ID.Text == SEWB_ShippTo_State_ID.Text)
                {
                    // SEWB_Taxtype.Text = "SGST";
                }
                else
                {
                    //SEWB_Taxtype.Text = "IGST";
                }


                // if (SEWB_Taxtype.Text == "IGST")
                {
                    // Div_IGST_HDR.Visible = true;

                }
                //if (SEWB_Taxtype.Text == "SGST")
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