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
    public partial class VenDCN : Mahesh_Page
    {
        M_AT_DNC_Ven_AHDRBO ObjAT_DCNVHDR;
        M_AT_DNC_Ven_BDTLBO ObjAT_DCNVDTL; 
      
        protected void Page_Load(object sender, EventArgs e)
        {

            PageMenuID = Request.QueryString["ID"];
            //SessionData.UserAccess.MenuID = PageMenuID;

            ObjAT_DCNVHDR = new M_AT_DNC_Ven_AHDRBO();
            ObjAT_DCNVDTL = new M_AT_DNC_Ven_BDTLBO();
             
             
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
        protected void Inv_ImgButtonGo_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            try
            {
                string SearchCriteria = "";
                SearchCriteria = Inv_ddSearchBy.Text + "|" + Inv_ddOperator.Text + (Inv_searchvalue.Text.Length > 0 ? "|" : "") + Inv_searchvalue.Text;
                RefreshGrid_Cust_Ivn(SearchCriteria);
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

                SetValueType(TextType.DateField, Txt_FromDT);
                SetValueType(TextType.DateField, Txt_ToDT);
                SetValueType(TextType.AmountField, DCNV_QTY);
                SetValueType(TextType.AlphNumericField_4, DCNV_BasicRate);
                SetValueType(TextType.AmountField, DCNV_DiscountRate);

                SetValueType(TextType.DateField, Inv_Txt_FromDT);
                SetValueType(TextType.DateField, Inv_Txt_ToDT);

                SetValueType(TextType.DateField, DCNV_DT);
             
                SetValueType(TextType.DateField, MDBSC_RowCreatedOn_DT);
                SetValueType(TextType.AmountField, DCNV_HDR_BasicAmt);
                SetValueType(TextType.AmountField, DCNV_HDR_DiscountAmt);
                SetValueType(TextType.AmountField, DCNV_HDR_Net_Amt);
                SetValueType(TextType.AmountField, DCNV_HDR_Freight_Charges);
                SetValueType(TextType.AmountField, DCNV_HDR_CGST_Amt);
                SetValueType(TextType.AmountField, DCNV_HDR_SGST_Amt);
                SetValueType(TextType.AmountField, DCNV_HDR_IGST_Amt);
                SetValueType(TextType.AmountField, DCNV_HDR_CESS_Amt);
                SetValueType(TextType.AmountField, DCNV_HDR_Gross_Amt);
                SetValueType(TextType.AmountField, DCNV_HDR_Round_Off_Amt);
                SetValueType(TextType.AmountField, DCNV_HDR_Total_Gross_Amt);
                SetValueType(TextType.AmountField, DCNV_HDR_Total_Tax_Amt);
                
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

           

            Fk_MItem_ID.DataSource = MaheshAF18.Utility.M_DropDownList.Fill_Drop_Down_List("M_AT_Mst_ItemMaster", "MItem_ID", "Item_Name", "", "", "Item", 0, "N", "");
            Fk_MItem_ID.DataBind();
            DCNV_Reason.DataSource = MABL.APPDT.MADD.DT_DCN_Reason("", "", "Note Reason");
            DCNV_Reason.DataBind();
            DataTable dt = new DataTable();
            dt = MaheshAF18.Utility.M_DropDownList.Fill_Drop_Down_List("v_AAA_M_RT_GEO_State", "GStateID", "vStateDisplayName", "  ", "", "State", 0, "N", "");
           
            PINV_ShippedFrom_State_ID.DataSource = dt;
            PINV_ShippedFrom_State_ID.DataBind();

            DCNV_ShippTo_State_ID.DataSource = dt;
            DCNV_ShippTo_State_ID.DataBind();
           
        }
        #endregion
        #region "Refrish Grid Functions"
        private void RefreshGrid_HDR(string SearchCriteria = "")
        {
            try
            {
                if ((Txt_FromDT.Text.Length > 0) && (Txt_ToDT.Text.Length > 0))
                {
                    //  var_DTWSQL = " AND MDBSC_RowCreatedOn_DT BETWEEN  '" + Txt_FromDT.Text + "' AND  '" + Txt_ToDT.Text + "'";
                }
                DataTable dt = default(DataTable);
                dt = MABL.BL.AppDataModal.Get_Ven_DCN_List(0,"", SearchCriteria);
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
        private void RefreshGrid_Cust_Ivn(string SearchCriteria = "")
        {
            try
            {
                if ((Inv_Txt_FromDT.Text.Length > 0) && (Inv_Txt_ToDT.Text.Length > 0))
                {
                    //  var_DTWSQL = " AND MDBSC_RowCreatedOn_DT BETWEEN  '" + Txt_FromDT.Text + "' AND  '" + Txt_ToDT.Text + "'";
                }
                DataTable dt = default(DataTable);
                dt = MABL.BL.AppDataModal.Get_Purchase_List(0, "", SearchCriteria);
                if (dt.Rows.Count > 0)
                {
                    gvList_Inv.DataSource = dt;
                    gvList_Inv.DataBind();
                    if (dt.Rows.Count < 50)
                    {
                        Inv_Msg_RCNT.Text = "Showing " + dt.Rows.Count + " Records  ";
                    }
                    else
                    {
                        Inv_Msg_RCNT.Text = "Showing 50 Of " + dt.Rows.Count + " Records  ";
                    }
                }
                else
                {
                    gvList_Inv.DataSource = null;
                    gvList_Inv.DataBind();
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
                dt = MABL.BL.AppDataModal.Get_Ven_DCN_Item_List(Convert.ToInt64(DCNVHDR_ID.Text), Convert.ToInt64(DCNVDTL_ID.Text),"", "");
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
                //dt = dt = MABL.BL.AppDataModal.Get_Purchase_Tax_List(Convert.ToInt64(DCNVHDR_ID.Text),0, "", "");
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
                RefreshGrid_Cust_Ivn();
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
        protected void gvList_Inv_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            try
            {
                gvList_Inv.PageIndex = e.NewPageIndex;
                RefreshGrid_Cust_Ivn();
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

                Inv_Txt_FromDT.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(SessionUserData.Company.AccountingStartDate));
                Inv_Txt_ToDT.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));

                DCNVHDR_ID.Text = "0";
                Fk_INVHDR_ID.Text = "0";
                           
                Msg_ErrorMsg.Text = "";

                PINV_Taxtype.Text = "";
                MVen_Name.Text = "";
                PINV_No.Text = "";
                vPINV_DT.Text = "";
                DCNV_Reason.SelectedIndex = 0;
                DCNV_ShippTo_State_ID.SelectedIndex = 0;
                DCNV_Type.Text = "";
                DCNV_No.Text = MEF.GetRefNo(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, "DCN", "DCN", "DCN", "Yes");
                DCNV_DT.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
               
             
                DCNV_Remark.Text = "";
                MDBSC_RowStatus.Text = "";
                MDBSC_RowCreatedByUserName.Text = SessionUserData.UserData.UserName;
                MDBSC_RowCreatedOn_DT.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
                DCNV_HDR_BasicAmt.Text = "0.00";
                DCNV_HDR_DiscountAmt.Text = "0.00";
                DCNV_HDR_Net_Amt.Text = "0.00";
                DCNV_HDR_Freight_Charges.Text = "0.00";
                DCNV_HDR_CGST_Amt.Text = "0.00";
                DCNV_HDR_SGST_Amt.Text = "0.00";
                DCNV_HDR_IGST_Amt.Text = "0.00";
                DCNV_HDR_CESS_Amt.Text = "0.00";
                DCNV_HDR_Gross_Amt.Text = "0.00";
                DCNV_HDR_Round_Off_Amt.Text = "0.00";
                DCNV_HDR_Total_Gross_Amt.Text = "0.00";

                DCNV_HDR_Total_Tax_Amt.Text = "0.00";
                PINV_ShippedFrom_State_ID.SelectedIndex = 0;
                PINV_ShippedFrom_State_ID.Enabled = false;
                
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

                DCNVDTL_ID.Text = "0";
                Fk_MItem_ID.SelectedIndex = 0;
                DCNV_BasicRate.Text = "0";
                DCNV_HSNCode.Text="";
                DCNV_QTY.Text = "0"; 
                DCNV_DiscountRate.Text = "0";
                 
                DCNV_ItemRemark_DTL.Text = "";
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

                if (DCNV_Reason.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Pls Select Reason.<br>";
                }
                if (DCNV_No.Text.Length== 0)
                {
                    ErrorMessage = ErrorMessage + "Ref No Cannot Be Blank.<br>";
                }
                if (DCNV_DT.Text.Length != 11)
                {
                    ErrorMessage = ErrorMessage + "Invalid Entry Date.<br>";
                }

                if (DCNV_ShippTo_State_ID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Invalid Place Of Supply.<br>";
                }


                if ((Convert.ToInt64( Fk_INVHDR_ID.Text) > 0) && (Convert.ToInt64(DCNVHDR_ID.Text) == 0)) 
                {
                    if (Fk_MItem_ID.SelectedIndex == 0)
                    {
                        ErrorMessage = ErrorMessage + "Pls Select Item<br>";
                    }
                    if (DCNV_BasicRate.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Rate<br>";
                    }
                    if (DCNV_QTY.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Quantity<br>";
                    }
                }
                if ((Convert.ToInt32(DCNVHDR_ID.Text) > 0) && (Convert.ToInt32(DCNVDTL_ID.Text) > 0) && (Fk_MItem_ID.SelectedIndex > 0))
                {
                    if (Fk_MItem_ID.SelectedIndex == 0)
                    {
                        ErrorMessage = ErrorMessage + "Pls Select Item<br>";
                    }
                    if (DCNV_BasicRate.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Rate<br>";
                    }
                    if (DCNV_QTY.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Quantity<br>";
                    }
                }


                if (ErrorMessage.Length == 0)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (Convert.ToInt32(DCNVHDR_ID.Text) == 0)
                        {
                            ObjAT_DCNVHDR.Fk_Company_ID = SessionUserData.Company.CompanyID;
                            ObjAT_DCNVHDR.Fk_Branch_ID = SessionUserData.Company.BranchID;
                            ObjAT_DCNVHDR.Fk_Year_ID = SessionUserData.Company.YearID;
                            ObjAT_DCNVHDR.Rec_Created_In ="HO";
                            ObjAT_DCNVHDR.Rec_CreatedBy_ID = SessionUserData.Company.BranchID;
                            ObjAT_DCNVHDR.Rec_CreatedFor_ID = SessionUserData.Company.BranchID;
                            ObjAT_DCNVHDR.DCNV_CreationType = "Manual";
                            ObjAT_DCNVHDR.Fk_INVHDR_ID = Convert.ToInt64(Fk_INVHDR_ID.Text);                            
                            ObjAT_DCNVHDR.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName;
                            ObjAT_DCNVHDR.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                            ObjAT_DCNVHDR.DCNV_No = MEF.GenrateRefNo(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, "DCN", "DCN", "DCN", "Yes", "", "", "", 0);
                            ObjAT_DCNVHDR.DCNV_Type = DCNV_Type.Text;                
                        }
                        SetValuesToBO_HDR();
                        ErrorMessage = ObjAT_DCNVHDR.Insert_Update(ObjAT_DCNVHDR);
                        DCNVHDR_ID.Text = ErrorMessage.Substring((ErrorMessage.IndexOf("|") + 1), (ErrorMessage.Length - ErrorMessage.IndexOf("|") - 1));
                        ErrorMessage = ErrorMessage.Substring((0), (ErrorMessage.IndexOf("|")));

                        if (Convert.ToInt32(DCNVHDR_ID.Text) > 0)
                        {
                            if (Convert.ToInt32(DCNVDTL_ID.Text)== 0)
                            {
                                ObjAT_DCNVDTL.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                                ObjAT_DCNVDTL.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName; 
                            }

                            ObjAT_DCNVDTL.DCNVDTL_ID = Convert.ToInt64("0" + DCNVDTL_ID.Text);
                            ObjAT_DCNVDTL.Fk_DCNVHDR_ID = Convert.ToInt64("0" + DCNVHDR_ID.Text);
                            ObjAT_DCNVDTL.Fk_MItem_ID = Convert.ToInt64("0" + Fk_MItem_ID.Text);
                            ObjAT_DCNVDTL.DCNV_HSNCode = DCNV_HSNCode.Text;
                            ObjAT_DCNVDTL.DCNV_QTY =Convert.ToDecimal( DCNV_QTY.Text);
                            ObjAT_DCNVDTL.DCNV_BasicRate = Convert.ToDecimal(DCNV_BasicRate.Text);
                            ObjAT_DCNVDTL.DCNV_DiscountRate = Convert.ToDecimal(DCNV_DiscountRate.Text);
                           
                            
                            ObjAT_DCNVDTL.DCNV_ItemRemark_DTL = DCNV_ItemRemark_DTL.Text;
                            ObjAT_DCNVDTL.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
                            ObjAT_DCNVDTL.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
                            ObjAT_DCNVDTL.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));

                            ObjAT_DCNVDTL.Insert_Update(ObjAT_DCNVDTL);
                            
                            
                        }

                        scope.Complete();
                    }
                    MABL.SQLManager.SQLProcedureCall.USP_Update_Tbl_DCN_Ven(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, Convert.ToInt32(DCNVHDR_ID.Text));
                    SetValueToControls_Edit_HDR(Convert.ToInt32("0" + DCNVHDR_ID.Text));
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

               ObjAT_DCNVHDR.DCNVHDR_ID = Convert.ToInt64("0" + DCNVHDR_ID.Text);
               ObjAT_DCNVHDR.DCNV_Reason = DCNV_Reason.Text;
                 
               ObjAT_DCNVHDR.DCNV_DT = DCNV_DT.Text;
               ObjAT_DCNVHDR.DCNV_ShippTo_State_ID =Convert.ToInt64("0" + DCNV_ShippTo_State_ID.Text);
                
               ObjAT_DCNVHDR.DCNV_Remark = DCNV_Remark.Text;
               ObjAT_DCNVHDR.MDBSC_RowStatus = MDBSC_RowStatus.Text;
               ObjAT_DCNVHDR.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
               ObjAT_DCNVHDR.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
               ObjAT_DCNVHDR.MDBSC_RowLupdnOn_DT =  DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
               ObjAT_DCNVHDR.DCNV_HDR_Freight_Charges = Convert.ToDecimal("0" + DCNV_HDR_Freight_Charges.Text);
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
                dt = MABL.BL.AppDataModal.Get_Ven_DCN_List(strPK, "", "");
                InitializeControls_HDR();
                InitializeControls_DTL();
                if (dt.Rows.Count > 0)
                { 
                    DCNVHDR_ID.Text = dt.Rows[0]["DCNVHDR_ID"].ToString();
                    Fk_INVHDR_ID.Text = dt.Rows[0]["Fk_INVHDR_ID"].ToString();
                    DCNV_Reason.Text = dt.Rows[0]["DCNV_Reason"].ToString();
                  
                    PINV_Taxtype.Text = dt.Rows[0]["DCNV_Taxtype"].ToString();
                    MVen_Name.Text = dt.Rows[0]["MVen_Name"].ToString();
                    PINV_No.Text = dt.Rows[0]["PINV_No"].ToString();
                    vPINV_DT.Text = dt.Rows[0]["vPINV_DT"].ToString();
                    DCNV_ShippTo_State_ID.Text = dt.Rows[0]["DCNV_ShippTo_State_ID"].ToString();
                    PINV_ShippedFrom_State_ID.Text = dt.Rows[0]["PINV_ShippedFrom_State_ID"].ToString();

                    DCNV_No.Text = dt.Rows[0]["DCNV_No"].ToString();
                    DCNV_DT.Text = dt.Rows[0]["vDCNV_DT"].ToString();
                    DCNV_Type.Text = dt.Rows[0]["DCNV_Type"].ToString();
                  
                    DCNV_Remark.Text = dt.Rows[0]["DCNV_Remark"].ToString();
                    MDBSC_RowStatus.Text = dt.Rows[0]["MDBSC_RowStatus"].ToString();
                    DCNV_HDR_BasicAmt.Text = dt.Rows[0]["DCNV_HDR_BasicAmt"].ToString();
                    DCNV_HDR_DiscountAmt.Text = dt.Rows[0]["DCNV_HDR_DiscountAmt"].ToString();
                    DCNV_HDR_Net_Amt.Text = dt.Rows[0]["DCNV_HDR_Net_Amt"].ToString();
                    DCNV_HDR_Freight_Charges.Text = dt.Rows[0]["DCNV_HDR_Freight_Charges"].ToString();
                    DCNV_HDR_CGST_Amt.Text = dt.Rows[0]["DCNV_HDR_CGST_Amt"].ToString();
                    DCNV_HDR_SGST_Amt.Text = dt.Rows[0]["DCNV_HDR_SGST_Amt"].ToString();
                    DCNV_HDR_IGST_Amt.Text = dt.Rows[0]["DCNV_HDR_IGST_Amt"].ToString();
                    DCNV_HDR_CESS_Amt.Text = dt.Rows[0]["DCNV_HDR_CESS_Amt"].ToString();
                    DCNV_HDR_Gross_Amt.Text = dt.Rows[0]["DCNV_HDR_Gross_Amt"].ToString();
                    DCNV_HDR_Total_Tax_Amt.Text = dt.Rows[0]["DCNV_HDR_Total_Tax_Amt"].ToString();
                    DCNV_HDR_Round_Off_Amt.Text = dt.Rows[0]["DCNV_HDR_Round_Off_Amt"].ToString();
                    DCNV_HDR_Total_Gross_Amt.Text = dt.Rows[0]["DCNV_HDR_Total_Gross_Amt"].ToString();
                     
                    

                    MDBSC_RowCreatedByUserName.Text = dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
                    MDBSC_RowCreatedOn_DT.Text = dt.Rows[0]["vMDBSC_RowCreatedOn_DT"].ToString();

                    TaxType_Toggel();
                    RefreshGrid_Item_DTL();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void SetValueToControls_Edit_Invoice(Int64 strPK)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = MABL.BL.AppDataModal.Get_Purchase_List(strPK, "", "");
                InitializeControls_HDR();
                InitializeControls_DTL();
                if (dt.Rows.Count > 0)
                {
                    Fk_INVHDR_ID.Text = dt.Rows[0]["PINVHDR_ID"].ToString();
                    PINV_Taxtype.Text = dt.Rows[0]["PINV_Taxtype"].ToString();
                    MVen_Name.Text = dt.Rows[0]["MVen_Name"].ToString();
                    vPINV_DT.Text = dt.Rows[0]["vPINV_DT"].ToString();
                    DCNV_ShippTo_State_ID.Text = dt.Rows[0]["PINV_ShippTo_State_ID"].ToString();
                    PINV_No.Text = dt.Rows[0]["PINV_No"].ToString();
                    PINV_ShippedFrom_State_ID.Text = dt.Rows[0]["PINV_ShippedFrom_State_ID"].ToString();
                     
                  
                  
                  

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
                MultiView1.ActiveViewIndex = 2;
            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary(ex.Message);
            }

        }
        protected void LnkDCN_Click(object sender, System.EventArgs e)
        {
            try
            {
                LinkButton lnkSelectInv = (LinkButton)sender;
                GridViewRow row = (GridViewRow)lnkSelectInv.NamingContainer;
                SetValueToControls_Edit_Invoice(Convert.ToInt64(row.Cells[0].Text));
                if (lnkSelectInv.CommandArgument == "DebitNote")
                {
                    DCNV_Type.Text = "Debit Note";
                }
                if (lnkSelectInv.CommandArgument == "CreditNote")
                {
                    DCNV_Type.Text = "Credit Note";
                }
                MultiView1.ActiveViewIndex = 2;
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
                dt =MABL.BL.AppDataModal.Get_Ven_DCN_Item_List (Convert.ToInt64(DCNVHDR_ID.Text), Convert.ToInt64(row.Cells[0].Text),"", "");
                if (dt.Rows.Count > 0)
                {
                    DCNVDTL_ID.Text = dt.Rows[0]["DCNVDTL_ID"].ToString();
                    Fk_MItem_ID.Text = dt.Rows[0]["Fk_MItem_ID"].ToString();
                    DCNV_HSNCode.Text = dt.Rows[0]["DCNV_HSNCode"].ToString();
                    DCNV_QTY.Text = dt.Rows[0]["DCNV_QTY"].ToString();
                    DCNV_BasicRate.Text = dt.Rows[0]["DCNV_BasicRate"].ToString();
                    DCNV_DiscountRate.Text = dt.Rows[0]["DCNV_DiscountRate"].ToString();
                    
                    DCNV_ItemRemark_DTL.Text = dt.Rows[0]["DCNV_ItemRemark_DTL"].ToString();
                   
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
                string RetMesg = MaheshAF18.Application.SQLManager.DeleteSRMD("", "M_AT_DNC_Ven_BDTL", "Fk_DCNVHDR_ID", Convert.ToInt64(0 + row.Cells[1].Text), "DCNVDTL_ID", Convert.ToInt64(0 + row.Cells[0].Text), "C", "");
                MABL.SQLManager.SQLProcedureCall.USP_Update_Tbl_DCN_Ven(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, Convert.ToInt32(DCNVHDR_ID.Text));
                SetValueToControls_Edit_HDR(Convert.ToInt32(DCNVHDR_ID.Text));
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
        protected void gvList_Inv_RowCreated(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
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
                    e.Row.Cells[13].Visible = false;
                    e.Row.Cells[14].Visible = false;
                    e.Row.Cells[15].Visible = false;
                    e.Row.Cells[16].Visible = false;

                }
                if (PINV_Taxtype.Text == "SGST")
                {
                    e.Row.Cells[17].Visible = false;
                    e.Row.Cells[18].Visible = false;
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
                SessionUserData.AppInfo.TempStrVariable_1 = PINV_Taxtype.Text;
                SessionUserData.AppInfo.TempIntVariable_1 = Convert.ToInt64(DCNVHDR_ID.Text);
                Response.Write("<script type='text/javascript'>detailedresults=window.open('" + MABL.BL.AppVariable.Project_Constant("RptBrowse") + "/ReportBrowser/VenDCN.aspx');</script>");

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
                DCNV_HSNCode.Text = dt.Rows[0]["HSNCode"].ToString();
                DCNV_BasicRate.Text = dt.Rows[0]["Item_Purchase_Rate"].ToString();
                DCNV_QTY.Text = "0";
            }
            else
            {
                DCNV_HSNCode.Text = "";
                DCNV_BasicRate.Text = "0";
                DCNV_QTY.Text = "0";
            }

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

                if (PINV_ShippedFrom_State_ID.Text == DCNV_ShippTo_State_ID.Text)
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