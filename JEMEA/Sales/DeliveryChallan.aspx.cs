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
    public partial class DeliveryChallan : Mahesh_Page
    {
        M_AT_Sales_DC_AHDRBO ObjAT_DC_HDR;
        M_AT_Sales_DC_BDTLBO ObjAT_DC_DTL;

        protected void Page_Load(object sender, EventArgs e)
        {

            PageMenuID = Request.QueryString["ID"];
            //SessionData.UserAccess.MenuID = PageMenuID;

            ObjAT_DC_HDR = new M_AT_Sales_DC_AHDRBO();
            ObjAT_DC_DTL = new M_AT_Sales_DC_BDTLBO();


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
                CE_DC_DT.EndDate = DateTime.Now;
                 
                SetValueType(TextType.DateField, Txt_FromDT);
                SetValueType(TextType.DateField, Txt_ToDT);
                SetValueType(TextType.AmountField, DC_QTY);
                SetValueType(TextType.AlphNumericField_4, DC_BasicRate);
                SetValueType(TextType.AmountField, DC_DiscountRate);

                SetValueType(TextType.DateField, DC_DT);
               
              
                
                SetValueType(TextType.DateField, MDBSC_RowCreatedOn_DT);
                SetValueType(TextType.AmountField, DC_HDR_BasicAmt);
                SetValueType(TextType.AmountField, DC_HDR_DiscountAmt);

                SetValueType(TextType.AmountField, DC_HDR_Freight_Charges);

                SetValueType(TextType.AmountField, DC_HDR_Gross_Amt);
                SetValueType(TextType.AmountField, DC_HDR_Round_Off_Amt);
                SetValueType(TextType.AmountField, DC_HDR_Total_Gross_Amt);


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

            Fk_MItem_ID.DataSource = MaheshAF18.Utility.M_DropDownList.Fill_Drop_Down_List("M_AT_Mst_ItemMaster", "MItem_ID", "Item_Name", " AND  Item_Type='Goods' ", "", "Item", 0, "N", "");
            Fk_MItem_ID.DataBind();

            DataTable dt = new DataTable();
            dt = MaheshAF18.Utility.M_DropDownList.Fill_Drop_Down_List("v_AAA_M_RT_GEO_State", "GStateID", "vStateDisplayName", "  ", "", "State", 0, "N", "");
            DC_ShippedFrom_State_ID.DataSource = dt;
            DC_ShippedFrom_State_ID.DataBind();

            DC_ShippTo_State_ID.DataSource = dt;
            DC_ShippTo_State_ID.DataBind();


        }
        #endregion
        #region "Refrish Grid Functions"
        private void RefreshGrid_HDR(string SearchCriteria = "")
        {
            try
            {
                string var_SQLFilter = "";
                var_SQLFilter = var_SQLFilter + " AND DC_Category =''";

                if ((Txt_FromDT.Text.Length > 0) && (Txt_ToDT.Text.Length > 0))
                {
                    var_SQLFilter = var_SQLFilter + " AND DC_DT BETWEEN  '" + Txt_FromDT.Text + "' AND  '" + Txt_ToDT.Text + "'";
                }
                DataTable dt = default(DataTable);
                dt = MABL.BL.AppDataModal.Get_Sales_DC_List(0, var_SQLFilter, SearchCriteria);
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
                dt = MABL.BL.AppDataModal.Get_Sales_DC_Item_List(Convert.ToInt64(DCHDR_ID.Text), Convert.ToInt64(DCDTL_ID.Text), "", "");
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
                //dt = dt = MABL.BL.AppDataModal.Get_Purchase_Tax_List(Convert.ToInt64(DCHDR_ID.Text),0, "", "");
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

                DCHDR_ID.Text = "0";
                Fk_CustomerID.SelectedIndex = 0;
                Msg_ErrorMsg.Text = "";


                DC_No.Text = MEF.GetRefNo(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, "Delivery Challan", "DC", "DC", "Yes");
                DC_DT.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));

            
              
               
                DC_Remark.Text = "";
                MDBSC_RowStatus.Text = "";
                MDBSC_RowCreatedByUserName.Text = SessionUserData.UserData.UserName;
                MDBSC_RowCreatedOn_DT.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
                DC_HDR_BasicAmt.Text = "0.00";
                DC_HDR_DiscountAmt.Text = "0.00";

                DC_HDR_Freight_Charges.Text = "0.00";

                DC_HDR_Gross_Amt.Text = "0.00";
                DC_HDR_Round_Off_Amt.Text = "0.00";
                DC_HDR_Total_Gross_Amt.Text = "0.00";



              
                DC_ShippedFrom_State_ID.SelectedIndex = 0;

                MCust_Reg_StateDisplayName.Text = "";

                DC_ShippTo_State_ID.SelectedIndex = 0;
                DC_BillTo_Add1.Text = "";
                DC_BillTo_Add2.Text = "";
                DC_BillTo_Add3.Text = "";
                DC_BillTo_Pincode.Text = "";
                DC_BillTo_City.Text = "";

                DC_BillTo_Country.Text = "";
                DC_BillTo_GSTNo.Text = "";
                DC_BillTo_PANNO.Text = "";


                DC_ShippTo_CompanyName.Text = "";
                DC_ShippTo_ContactPersone.Text = "";
                DC_ShippTo_CP_MobileNo.Text = "";
                DC_ShippTo_Add1.Text = "";
                DC_ShippTo_Add2.Text = "";
                DC_ShippTo_Add3.Text = "";




                DC_ShippTo_Pincode.Text = "";
                DC_ShippTo_City.Text = "";

                DC_ShippTo_Country.Text = "";
                DC_ShippTo_GSTNo.Text = "";
                DC_ShippTo_PANNO.Text = "";



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

                DCDTL_ID.Text = "0";
                Fk_MItem_ID.SelectedIndex = 0;
                DC_BasicRate.Text = "0";
                DC_HSNCode.Text = "";
                DC_QTY.Text = "0";
                DC_DiscountRate.Text = "0";

                DC_ItemRemark_DTL.Text = "";

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
                if (DC_No.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Customer Invoice No Cannot Be Blank.<br>";
                }

                if (DC_ShippedFrom_State_ID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Place Of Dispatch<br>";
                }


                if (DC_ShippTo_State_ID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Place Of Supply<br>";
                }


                if (DC_ShippTo_GSTNo.Text.Length != 15)
                {
                    ErrorMessage = ErrorMessage + "Invalid Ship To GSTNO<br>";
                }


                if (DC_ShippTo_PANNO.Text.Length != 10)
                {
                    ErrorMessage = ErrorMessage + "Invalid Ship To PAN No<br>";
                }



                if ((DC_No.Text.Length > 0) && (Fk_CustomerID.SelectedIndex > 0))
                {
                    if (SQLManager.CheckDuplicateRecord("M_AT_Sales_Inv_AHDR", "DCHDR_ID", Convert.ToInt32("0" + DCHDR_ID.Text), "DC_No", DC_No.Text,
                                                       " AND Fk_Branch_ID=" + SessionUserData.Company.BranchID))
                    {
                        ErrorMessage = ErrorMessage + "Customer Invoice Already Exist.<br>";
                    }
                }

                if (DC_DT.Text.Length != 11)
                {
                    ErrorMessage = ErrorMessage + "Invalid Customer Invoice Date.<br>";
                }
                if ((Fk_CustomerID.SelectedIndex > 0) && (Convert.ToInt32(DCHDR_ID.Text) == 0))
                {
                    if (Fk_MItem_ID.SelectedIndex == 0)
                    {
                        ErrorMessage = ErrorMessage + "Pls Select Item<br>";
                    }
                    if (DC_BasicRate.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Rate<br>";
                    }
                    if (DC_QTY.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Quantity<br>";
                    }
                    else
                    {
                        if (Convert.ToDecimal(DC_QTY.Text) <= 0)
                        {
                            ErrorMessage = ErrorMessage + "Invalid Item Quantity<br>";
                        }
                    }
                }
                if ((Convert.ToInt32(DCHDR_ID.Text) > 0) && (Convert.ToInt32(DCDTL_ID.Text) > 0) && (Fk_MItem_ID.SelectedIndex > 0))
                {
                    if (Fk_MItem_ID.SelectedIndex == 0)
                    {
                        ErrorMessage = ErrorMessage + "Pls Select Item<br>";
                    }
                    if (DC_BasicRate.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Rate<br>";
                    }
                    if (DC_QTY.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Quantity<br>";
                    }
                    else
                    {
                        if (Convert.ToDecimal(DC_QTY.Text) <= 0)
                        {
                            ErrorMessage = ErrorMessage + "Invalid Item Quantity<br>";
                        }
                    }
                }


                if (ErrorMessage.Length == 0)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (Convert.ToInt32(DCHDR_ID.Text) == 0)
                        {
                            ObjAT_DC_HDR.Fk_Company_ID = SessionUserData.Company.CompanyID;
                            ObjAT_DC_HDR.Fk_Branch_ID = SessionUserData.Company.BranchID;
                            ObjAT_DC_HDR.Fk_Year_ID = SessionUserData.Company.YearID;
                            ObjAT_DC_HDR.Rec_Created_In = "HO";
                            ObjAT_DC_HDR.Rec_CreatedBy_ID = SessionUserData.Company.BranchID;
                            ObjAT_DC_HDR.Rec_CreatedFor_ID = SessionUserData.Company.BranchID;
                            ObjAT_DC_HDR.DC_CreationType = "Manual";
                            ObjAT_DC_HDR.DC_Category = "";
                            ObjAT_DC_HDR.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName;
                            ObjAT_DC_HDR.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                            ObjAT_DC_HDR.DC_No = MEF.GenrateRefNo(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, "Delivery Challan", "DC", "DC", "Yes", "", "", "", 0);

                        }
                        SetValuesToBO_HDR();
                        ErrorMessage = ObjAT_DC_HDR.Insert_Update(ObjAT_DC_HDR);
                        DCHDR_ID.Text = ErrorMessage.Substring((ErrorMessage.IndexOf("|") + 1), (ErrorMessage.Length - ErrorMessage.IndexOf("|") - 1));
                        ErrorMessage = ErrorMessage.Substring((0), (ErrorMessage.IndexOf("|")));

                        if ((Convert.ToInt32(DCHDR_ID.Text) > 0) && (Fk_MItem_ID.SelectedIndex > 0))
                        {
                            if (Convert.ToInt32(DCDTL_ID.Text) == 0)
                            {
                                ObjAT_DC_DTL.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                                ObjAT_DC_DTL.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName;
                            }

                            ObjAT_DC_DTL.DCDTL_ID = Convert.ToInt64("0" + DCDTL_ID.Text);
                            ObjAT_DC_DTL.Fk_DCHDR_ID = Convert.ToInt64("0" + DCHDR_ID.Text);
                            ObjAT_DC_DTL.Fk_MItem_ID = Convert.ToInt64("0" + Fk_MItem_ID.Text);
                            ObjAT_DC_DTL.DC_HSNCode = DC_HSNCode.Text;
                            ObjAT_DC_DTL.DC_QTY = Convert.ToDecimal(DC_QTY.Text);
                            ObjAT_DC_DTL.DC_Final_Qty = Convert.ToDecimal(DC_QTY.Text);
                            ObjAT_DC_DTL.DC_BasicRate = Convert.ToDecimal(DC_BasicRate.Text);
                            ObjAT_DC_DTL.DC_DiscountRate = Convert.ToDecimal(DC_DiscountRate.Text);
                            ObjAT_DC_DTL.DC_CGST_ID = 0;
                            ObjAT_DC_DTL.DC_SGST_ID = 0;
                            ObjAT_DC_DTL.DC_IGST_ID = 0;
                            ObjAT_DC_DTL.DC_CESS_ID = 0;

                            ObjAT_DC_DTL.DC_ItemRemark_DTL = DC_ItemRemark_DTL.Text;
                            ObjAT_DC_DTL.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
                            ObjAT_DC_DTL.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
                            ObjAT_DC_DTL.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));

                            ObjAT_DC_DTL.Insert_Update(ObjAT_DC_DTL);


                        }

                        scope.Complete();
                    }
                    MABL.SQLManager.SQLProcedureCall.USP_Update_Tbl_Sales_DC(SessionUserData.Company.CompanyID,SessionUserData.Company.BranchID,SessionUserData.Company.YearID, Convert.ToInt32(DCHDR_ID.Text));
                    SetValueToControls_Edit_HDR(Convert.ToInt32("0" + DCHDR_ID.Text));
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

                ObjAT_DC_HDR.DCHDR_ID = Convert.ToInt64("0" + DCHDR_ID.Text);

              
                ObjAT_DC_HDR.DC_DT = DC_DT.Text;
                ObjAT_DC_HDR.Fk_CustomerID = Convert.ToInt32(Fk_CustomerID.Text);
                ObjAT_DC_HDR.DC_CreditDays = 0;
               
                ObjAT_DC_HDR.DC_Remark = DC_Remark.Text;
                ObjAT_DC_HDR.MDBSC_RowStatus = MDBSC_RowStatus.Text;
                ObjAT_DC_HDR.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
                ObjAT_DC_HDR.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
                ObjAT_DC_HDR.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
                ObjAT_DC_HDR.DC_HDR_Freight_Charges = Convert.ToDecimal("0" + DC_HDR_Freight_Charges.Text);

                ObjAT_DC_HDR.DC_BillTo_Add1 = DC_BillTo_Add1.Text;
                ObjAT_DC_HDR.DC_BillTo_Add2 = DC_BillTo_Add2.Text;
                ObjAT_DC_HDR.DC_BillTo_Add3 = DC_BillTo_Add3.Text;
                ObjAT_DC_HDR.DC_BillTo_Pincode = DC_BillTo_Pincode.Text;
                ObjAT_DC_HDR.DC_BillTo_City = DC_BillTo_City.Text;
                ObjAT_DC_HDR.DC_BillTo_Country = DC_BillTo_Country.Text;
                ObjAT_DC_HDR.DC_BillTo_PANNO = DC_BillTo_PANNO.Text;
                ObjAT_DC_HDR.DC_ShippTo_CompanyName = DC_ShippTo_CompanyName.Text;
                ObjAT_DC_HDR.DC_ShippTo_ContactPersone = DC_ShippTo_ContactPersone.Text;
                ObjAT_DC_HDR.DC_ShippTo_CP_MobileNo = DC_ShippTo_CP_MobileNo.Text;
                ObjAT_DC_HDR.DC_ShippTo_Add1 = DC_ShippTo_Add1.Text;
                ObjAT_DC_HDR.DC_ShippTo_Add2 = DC_ShippTo_Add2.Text;
                ObjAT_DC_HDR.DC_ShippTo_Add3 = DC_ShippTo_Add3.Text;
                ObjAT_DC_HDR.DC_ShippTo_Pincode = DC_ShippTo_Pincode.Text;

                ObjAT_DC_HDR.DC_ShippedFrom_CompanyName = "";
                ObjAT_DC_HDR.DC_ShippedFrom_ContactPersone = "";
                ObjAT_DC_HDR.DC_ShippedFrom_CP_MobileNo = "";
                ObjAT_DC_HDR.DC_ShippedFrom_Add1 = "";
                ObjAT_DC_HDR.DC_ShippedFrom_Add2 = "";
                ObjAT_DC_HDR.DC_ShippedFrom_Add3 = "";
                ObjAT_DC_HDR.DC_ShippedFrom_Pincode = "";

                ObjAT_DC_HDR.DC_ShippedFrom_City = "";
                ObjAT_DC_HDR.DC_ShippedFrom_State_ID = Convert.ToInt64(DC_ShippedFrom_State_ID.Text);
                ObjAT_DC_HDR.DC_ShippedFrom_Country = "";
                ObjAT_DC_HDR.DC_ShippedFrom_GSTNo = "";
                ObjAT_DC_HDR.DC_ShippedFrom_PANNO = "";


                ObjAT_DC_HDR.DC_ShippTo_City = DC_ShippTo_City.Text;
                ObjAT_DC_HDR.DC_ShippTo_State_ID = Convert.ToInt64(DC_ShippTo_State_ID.Text);
                ObjAT_DC_HDR.DC_ShippTo_Country = DC_ShippTo_Country.Text;
                ObjAT_DC_HDR.DC_ShippTo_GSTNo = DC_ShippTo_GSTNo.Text;
                ObjAT_DC_HDR.DC_ShippTo_PANNO = DC_ShippTo_PANNO.Text;





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
                dt = MABL.BL.AppDataModal.Get_Sales_DC_List(strPK, "", "");
                InitializeControls_HDR();
                InitializeControls_DTL();
                if (dt.Rows.Count > 0)
                {
                    DCHDR_ID.Text = dt.Rows[0]["DCHDR_ID"].ToString();

                    DCHDR_ID.Text = dt.Rows[0]["DCHDR_ID"].ToString();

                    DC_No.Text = dt.Rows[0]["DC_No"].ToString();
                    DC_DT.Text = dt.Rows[0]["vDC_DT"].ToString();
                    Fk_CustomerID.Text = dt.Rows[0]["Fk_CustomerID"].ToString();
                 
                  
                  
                    DC_ModeOfDispatch.Text = dt.Rows[0]["DC_ModeOfDispatch"].ToString();

                    DC_Remark.Text = dt.Rows[0]["DC_Remark"].ToString();

                    MDBSC_RowStatus.Text = dt.Rows[0]["MDBSC_RowStatus"].ToString();

                    MDBSC_RowCreatedByUserName.Text = dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
                    MDBSC_RowCreatedOn_DT.Text = dt.Rows[0]["vMDBSC_RowCreatedOn_DT"].ToString();

                    DC_HDR_BasicAmt.Text = dt.Rows[0]["DC_HDR_BasicAmt"].ToString();

                    DC_HDR_DiscountAmt.Text = dt.Rows[0]["DC_HDR_DiscountAmt"].ToString();

                    DC_HDR_Freight_Charges.Text = dt.Rows[0]["DC_HDR_Freight_Charges"].ToString();


                    DC_HDR_Gross_Amt.Text = dt.Rows[0]["DC_HDR_Gross_Amt"].ToString();
                    DC_HDR_Round_Off_Amt.Text = dt.Rows[0]["DC_HDR_Round_Off_Amt"].ToString();
                    DC_HDR_Total_Gross_Amt.Text = dt.Rows[0]["DC_HDR_Total_Gross_Amt"].ToString();

                    //Customer

                    MCust_Reg_StateDisplayName.Text = dt.Rows[0]["MCust_Reg_StateDisplayName"].ToString();


                    //SHIP FROM 

                    //BILL TO
                    DC_BillTo_Add1.Text = dt.Rows[0]["DC_BillTo_Add1"].ToString();
                    DC_BillTo_Add2.Text = dt.Rows[0]["DC_BillTo_Add2"].ToString();
                    DC_BillTo_Add3.Text = dt.Rows[0]["DC_BillTo_Add3"].ToString();
                    DC_BillTo_Pincode.Text = dt.Rows[0]["DC_BillTo_Pincode"].ToString();
                    DC_BillTo_City.Text = dt.Rows[0]["DC_BillTo_City"].ToString();
                    DC_BillTo_Country.Text = dt.Rows[0]["DC_BillTo_Country"].ToString();
                    DC_BillTo_PANNO.Text = dt.Rows[0]["DC_BillTo_PANNO"].ToString();

                    DC_BillTo_GSTNo.Text = dt.Rows[0]["DC_BillTo_GSTNo"].ToString();
                    //SHIP TO
                    DC_ShippTo_CompanyName.Text = dt.Rows[0]["DC_ShippTo_CompanyName"].ToString();
                    DC_ShippTo_ContactPersone.Text = dt.Rows[0]["DC_ShippTo_ContactPersone"].ToString();
                    DC_ShippTo_CP_MobileNo.Text = dt.Rows[0]["DC_ShippTo_CP_MobileNo"].ToString();
                    DC_ShippTo_Add1.Text = dt.Rows[0]["DC_ShippTo_Add1"].ToString();
                    DC_ShippTo_Add2.Text = dt.Rows[0]["DC_ShippTo_Add2"].ToString();
                    DC_ShippTo_Add3.Text = dt.Rows[0]["DC_ShippTo_Add3"].ToString();
                    DC_ShippTo_Pincode.Text = dt.Rows[0]["DC_ShippTo_Pincode"].ToString();

                    DC_ShippTo_City.Text = dt.Rows[0]["DC_ShippTo_City"].ToString();
                    DC_ShippTo_State_ID.Text = dt.Rows[0]["DC_ShippTo_State_ID"].ToString();
                    DC_ShippedFrom_State_ID.Text = dt.Rows[0]["DC_ShippedFrom_State_ID"].ToString();
                    DC_ShippTo_Country.Text = dt.Rows[0]["DC_ShippTo_Country"].ToString();
                    DC_ShippTo_GSTNo.Text = dt.Rows[0]["DC_ShippTo_GSTNo"].ToString();
                    DC_ShippTo_PANNO.Text = dt.Rows[0]["DC_ShippTo_PANNO"].ToString();



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
                dt = MABL.BL.AppDataModal.Get_Sales_DC_Item_List(Convert.ToInt64(DCHDR_ID.Text), Convert.ToInt64(row.Cells[0].Text), "", "");
                if (dt.Rows.Count > 0)
                {
                    DCDTL_ID.Text = dt.Rows[0]["DCDTL_ID"].ToString();
                    Fk_MItem_ID.Text = dt.Rows[0]["Fk_MItem_ID"].ToString();
                    DC_HSNCode.Text = dt.Rows[0]["DC_HSNCode"].ToString();
                    DC_QTY.Text = dt.Rows[0]["DC_QTY"].ToString();
                    DC_BasicRate.Text = dt.Rows[0]["DC_BasicRate"].ToString();
                    DC_DiscountRate.Text = dt.Rows[0]["DC_DiscountRate"].ToString();

                    DC_ItemRemark_DTL.Text = dt.Rows[0]["DC_ItemRemark_DTL"].ToString();

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
                string RetMesg = MaheshAF18.Application.SQLManager.DeleteSRMD("", "M_AT_Sales_DC_BDTL", "Fk_DCHDR_ID", Convert.ToInt64(0 + row.Cells[1].Text), "DCDTL_ID", Convert.ToInt64(0 + row.Cells[0].Text), "C", "");
                MABL.SQLManager.SQLProcedureCall.USP_Update_Tbl_Sales_DC(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, Convert.ToInt32(DCHDR_ID.Text));
                SetValueToControls_Edit_HDR(Convert.ToInt32(DCHDR_ID.Text));
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
                
                SessionUserData.AppInfo.TempIntVariable_1 = Convert.ToInt64(DCHDR_ID.Text);
                Response.Write("<script type='text/javascript'>detailedresults=window.open('" + MABL.BL.AppVariable.Project_Constant("RptBrowse") + "/ReportBrowser/DeliveryChallan.aspx');</script>");
 
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
                DC_HSNCode.Text = dt.Rows[0]["HSNCode"].ToString();
                DC_BasicRate.Text = dt.Rows[0]["Item_Purchase_Rate"].ToString();
                DC_QTY.Text = "1";
                DC_DiscountRate.Text = "0";
                DC_ItemRemark_DTL.Text = dt.Rows[0]["Item_Desc"].ToString();
            }
            else
            {
                DC_HSNCode.Text = "";
                DC_BasicRate.Text = "0";
                DC_QTY.Text = "1";
                DC_DiscountRate.Text = "0";
                DC_ItemRemark_DTL.Text = "";
            }

        }
        protected void Fk_CustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = MABL.BL.AppDataModal.Get_Mst_Customer(Convert.ToInt64(Fk_CustomerID.Text), "", "");
            if (dt.Rows.Count > 0)
            {
             
                DC_ShippTo_State_ID.Text = dt.Rows[0]["MCust_ShippTo_State_ID"].ToString();
                DC_BillTo_Add1.Text = dt.Rows[0]["MCust_Reg_Add1"].ToString();
                DC_BillTo_Add2.Text = dt.Rows[0]["MCust_Reg_Add2"].ToString();
                DC_BillTo_Add3.Text = dt.Rows[0]["MCust_Reg_Add3"].ToString();
                DC_BillTo_Pincode.Text = dt.Rows[0]["MCust_Reg_Pincode"].ToString();
                DC_BillTo_City.Text = dt.Rows[0]["MCust_Reg_City"].ToString();
                MCust_Reg_StateDisplayName.Text = dt.Rows[0]["MCust_Reg_StateDisplayName"].ToString();
                DC_BillTo_Country.Text = dt.Rows[0]["MCust_Reg_Country"].ToString();
                DC_BillTo_GSTNo.Text = dt.Rows[0]["MCust_BL_GSTNO"].ToString();
                DC_BillTo_PANNO.Text = dt.Rows[0]["MCust_BL_PANNO"].ToString();


                DC_ShippTo_CompanyName.Text = dt.Rows[0]["MCust_ShippTo_CompanyName"].ToString();
                DC_ShippTo_ContactPersone.Text = dt.Rows[0]["MCust_ShippTo_ContactPerson"].ToString();
                DC_ShippTo_CP_MobileNo.Text = dt.Rows[0]["MCust_ShippTo_CP_MobileNo"].ToString();
                DC_ShippTo_Add1.Text = dt.Rows[0]["MCust_ShippTo_Add1"].ToString();
                DC_ShippTo_Add2.Text = dt.Rows[0]["MCust_ShippTo_Add2"].ToString();
                DC_ShippTo_Add3.Text = dt.Rows[0]["MCust_ShippTo_Add3"].ToString();
                DC_ShippTo_Pincode.Text = dt.Rows[0]["MCust_ShippTo_Pincode"].ToString();
                DC_ShippTo_City.Text = dt.Rows[0]["MCust_ShippTo_City"].ToString();
                DC_ShippTo_Country.Text = dt.Rows[0]["MCust_ShippTo_Country"].ToString();
                DC_ShippTo_GSTNo.Text = dt.Rows[0]["MCust_ShippTo_GSTNO"].ToString();
                DC_ShippTo_PANNO.Text = dt.Rows[0]["MCust_ShippTo_PANNO"].ToString();




            }
            else
            {
            
                DC_ShippTo_State_ID.SelectedIndex = 0;
                DC_BillTo_Add1.Text = "";
                DC_BillTo_Add2.Text = "";
                DC_BillTo_Add3.Text = "";
                DC_BillTo_Pincode.Text = "";
                DC_BillTo_City.Text = "";
                MCust_Reg_StateDisplayName.Text = "";
                DC_BillTo_Country.Text = "";
                DC_BillTo_GSTNo.Text = "";
                DC_BillTo_PANNO.Text = "";


                DC_ShippTo_CompanyName.Text = "";
                DC_ShippTo_ContactPersone.Text = "";
                DC_ShippTo_CP_MobileNo.Text = "";
                DC_ShippTo_Add1.Text = "";
                DC_ShippTo_Add2.Text = "";
                DC_ShippTo_Add3.Text = "";
                DC_ShippTo_Pincode.Text = "";
                DC_ShippTo_City.Text = "";
                DC_ShippTo_Country.Text = "";
                DC_ShippTo_GSTNo.Text = "";
                DC_ShippTo_PANNO.Text = "";
            }

            DataTable dt_BranchDetails = new DataTable();
            dt_BranchDetails = MABL.BL.AppBL.Get_App_Branch_List(SessionUserData.Company.BranchID, "");
            if (dt.Rows.Count > 0)
            {
                //Branch Details
                DC_ShippedFrom_State_ID.Text = dt_BranchDetails.Rows[0]["BR_Consignee_State_ID"].ToString();



            }
            else
            {
                //Branch Details
                DC_ShippTo_State_ID.SelectedIndex = 0;

            }



        }
        protected void SalesState_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        #endregion
        #region "Function"

        //private void TaxType_Toggel()
        //{
        //    try
        //    {
        //        Div_CGST_HDR.Visible = false;
        //        Div_SGST_HDR.Visible = false;
        //        Div_IGST_HDR.Visible = false;

        //        if (SINV_ShippedFrom_State_ID.Text == SINV_ShippTo_State_ID.Text)
        //        {
        //            SINV_Taxtype.Text = "SGST";
        //        }
        //        else
        //        {
        //            SINV_Taxtype.Text = "IGST";
        //        }


        //        if (SINV_Taxtype.Text == "IGST")
        //        {
        //            Div_IGST_HDR.Visible = true;

        //        }
        //        if (SINV_Taxtype.Text == "SGST")
        //        {
        //            Div_CGST_HDR.Visible = true;
        //            Div_SGST_HDR.Visible = true;



        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        #endregion
    }
}