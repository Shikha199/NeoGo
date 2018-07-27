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
    public partial class CustDCN : Mahesh_Page
    {
        M_AT_DNC_Cust_AHDRBO ObjAT_DCNCHDR;
        M_AT_DNC_Cust_BDTLBO ObjAT_DCNCDTL;
             
             

      
        protected void Page_Load(object sender, EventArgs e)
        {

            PageMenuID = Request.QueryString["ID"];
            //SessionData.UserAccess.MenuID = PageMenuID;

            ObjAT_DCNCHDR = new M_AT_DNC_Cust_AHDRBO();
            ObjAT_DCNCDTL = new M_AT_DNC_Cust_BDTLBO();
             
             
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
                SetValueType(TextType.AmountField, DCNC_QTY);
                SetValueType(TextType.AmountField, DCNC_BasicRate);
                SetValueType(TextType.AmountField, DCNC_DiscountRate);
                SetValueType(TextType.AmountField, SINV_HDR_Total_Gross_Amt);
                 
                SetValueType(TextType.DateField, Inv_Txt_FromDT);
                SetValueType(TextType.DateField, Inv_Txt_ToDT);

                SetValueType(TextType.DateField, DCNC_DT);
             
                SetValueType(TextType.DateField, MDBSC_RowCreatedOn_DT);
                SetValueType(TextType.AmountField, DCNC_HDR_BasicAmt);
                SetValueType(TextType.AmountField, DCNC_HDR_DiscountAmt);
                SetValueType(TextType.AmountField, DCNC_HDR_Net_Amt);
                SetValueType(TextType.AmountField, DCNC_HDR_Freight_Charges);
                SetValueType(TextType.AmountField, DCNC_HDR_CGST_Amt);
                SetValueType(TextType.AmountField, DCNC_HDR_SGST_Amt);
                SetValueType(TextType.AmountField, DCNC_HDR_IGST_Amt);
                SetValueType(TextType.AmountField, DCNC_HDR_CESS_Amt);
                SetValueType(TextType.AmountField, DCNC_HDR_Gross_Amt);
                SetValueType(TextType.AmountField, DCNC_HDR_Round_Off_Amt);
                SetValueType(TextType.AmountField, DCNC_HDR_Total_Gross_Amt);
                SetValueType(TextType.AmountField, DCNC_HDR_Total_Tax_Amt);
                
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

            DCNC_Reason.DataSource = MABL.APPDT.MADD.DT_DCN_Reason("", "", "Note Reason");
            DCNC_Reason.DataBind();
            DataTable dt = new DataTable();
            dt = MaheshAF18.Utility.M_DropDownList.Fill_Drop_Down_List("v_AAA_M_RT_GEO_State", "GStateID", "vStateDisplayName", "  ", "", "State", 0, "N", "");

            DCNC_ShippTo_State_ID.DataSource = dt;
            DCNC_ShippTo_State_ID.DataBind();

            SINV_ShippedFrom_State_ID.DataSource = dt;
            SINV_ShippedFrom_State_ID.DataBind();
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
                dt = MABL.BL.AppDataModal.Get_Cust_DCN_List(0,"", SearchCriteria);
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
                dt = MABL.BL.AppDataModal.Get_Sales_List(0, "", SearchCriteria);
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
                dt = MABL.BL.AppDataModal.Get_Cust_DCN_Item_List(Convert.ToInt64(DCNCHDR_ID.Text), Convert.ToInt64(DCNCDTL_ID.Text),"", "");
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
                //dt = dt = MABL.BL.AppDataModal.Get_Purchase_Tax_List(Convert.ToInt64(DCNCHDR_ID.Text),0, "", "");
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

                DCNCHDR_ID.Text = "0";
                Fk_INVHDR_ID.Text = "0";
                           
                Msg_ErrorMsg.Text = "";

                SINV_Taxtype.Text = "";
                MCust_Name.Text = "";
                SINV_No.Text = "";
                vSINV_DT.Text = "";
                SINV_HDR_Total_Gross_Amt.Text = "0";
                DCNC_Reason.SelectedIndex = 0;
                DCNC_Type.Text = "";
                DCNC_No.Text = MEF.GetRefNo(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, "DCN", "DCN", "DCN", "Yes");
                DCNC_DT.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
                DCNC_ShippTo_State_ID.SelectedIndex = 0;
                SINV_ShippedFrom_State_ID.SelectedIndex = 0;
                SINV_ShippedFrom_State_ID.Enabled = false;
                DCNC_Remark.Text = "";
                MDBSC_RowStatus.Text = "";
                MDBSC_RowCreatedByUserName.Text = SessionUserData.UserData.UserName;
                MDBSC_RowCreatedOn_DT.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
                DCNC_HDR_BasicAmt.Text = "0.00";
                DCNC_HDR_DiscountAmt.Text = "0.00";
                DCNC_HDR_Net_Amt.Text = "0.00";
                DCNC_HDR_Freight_Charges.Text = "0.00";
                DCNC_HDR_CGST_Amt.Text = "0.00";
                DCNC_HDR_SGST_Amt.Text = "0.00";
                DCNC_HDR_IGST_Amt.Text = "0.00";
                DCNC_HDR_CESS_Amt.Text = "0.00";
                DCNC_HDR_Gross_Amt.Text = "0.00";
                DCNC_HDR_Round_Off_Amt.Text = "0.00";
                DCNC_HDR_Total_Gross_Amt.Text = "0.00";

                DCNC_HDR_Total_Tax_Amt.Text = "0.00";
             
                 
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

                DCNCDTL_ID.Text = "0";
                Fk_MItem_ID.SelectedIndex = 0;
                DCNC_BasicRate.Text = "0";
                DCNC_HSNCode.Text="";
                DCNC_QTY.Text = "0"; 
                DCNC_DiscountRate.Text = "0";
               
                DCNC_ItemRemark_DTL.Text = "";
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

                if (DCNC_Reason.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Pls Select Reason.<br>";
                }
                if (DCNC_No.Text.Length== 0)
                {
                    ErrorMessage = ErrorMessage + "Ref No Cannot Be Blank.<br>";
                }
                if (DCNC_DT.Text.Length != 11)
                {
                    ErrorMessage = ErrorMessage + "Invalid Entry Date.<br>";
                }
                if (DCNC_ShippTo_State_ID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Invalid Place Of Supply.<br>";
                }

                if ((Convert.ToInt64( Fk_INVHDR_ID.Text) > 0) && (Convert.ToInt64(DCNCHDR_ID.Text) == 0)) 
                {
                    if (Fk_MItem_ID.SelectedIndex == 0)
                    {
                        ErrorMessage = ErrorMessage + "Pls Select Item<br>";
                    }
                    if (DCNC_BasicRate.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Rate<br>";
                    }
                    if (DCNC_QTY.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Quantity<br>";
                    }
                }
                if ((Convert.ToInt32(DCNCHDR_ID.Text) > 0) && (Convert.ToInt32(DCNCDTL_ID.Text) > 0) && (Fk_MItem_ID.SelectedIndex > 0))
                {
                    if (Fk_MItem_ID.SelectedIndex == 0)
                    {
                        ErrorMessage = ErrorMessage + "Pls Select Item<br>";
                    }
                    if (DCNC_BasicRate.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Rate<br>";
                    }
                    if (DCNC_QTY.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Invalid Item Quantity<br>";
                    }
                }


                if (ErrorMessage.Length == 0)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (Convert.ToInt32(DCNCHDR_ID.Text) == 0)
                        {
                            ObjAT_DCNCHDR.Fk_Company_ID = SessionUserData.Company.CompanyID;
                            ObjAT_DCNCHDR.Fk_Branch_ID = SessionUserData.Company.BranchID;
                            ObjAT_DCNCHDR.Fk_Year_ID = SessionUserData.Company.YearID;
                            ObjAT_DCNCHDR.Rec_Created_In ="HO";
                            ObjAT_DCNCHDR.Rec_CreatedBy_ID = SessionUserData.Company.BranchID;
                            ObjAT_DCNCHDR.Rec_CreatedFor_ID = SessionUserData.Company.BranchID;
                            ObjAT_DCNCHDR.DCNC_CreationType = "Manual";
                            ObjAT_DCNCHDR.Fk_INVHDR_ID = Convert.ToInt64(Fk_INVHDR_ID.Text);                            
                            ObjAT_DCNCHDR.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName;
                            ObjAT_DCNCHDR.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                            ObjAT_DCNCHDR.DCNC_No = MEF.GenrateRefNo(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, "DCN", "DCN", "DCN", "Yes", "", "", "", 0);
                            ObjAT_DCNCHDR.DCNC_Type = DCNC_Type.Text;                
                        }
                        SetValuesToBO_HDR();
                        ErrorMessage = ObjAT_DCNCHDR.Insert_Update(ObjAT_DCNCHDR);
                        DCNCHDR_ID.Text = ErrorMessage.Substring((ErrorMessage.IndexOf("|") + 1), (ErrorMessage.Length - ErrorMessage.IndexOf("|") - 1));
                        ErrorMessage = ErrorMessage.Substring((0), (ErrorMessage.IndexOf("|")));

                        if (Convert.ToInt32(DCNCHDR_ID.Text) > 0)
                        {
                            if (Convert.ToInt32(DCNCDTL_ID.Text)== 0)
                            {
                                ObjAT_DCNCDTL.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                                ObjAT_DCNCDTL.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName; 
                            }

                            ObjAT_DCNCDTL.DCNCDTL_ID = Convert.ToInt64("0" + DCNCDTL_ID.Text);
                            ObjAT_DCNCDTL.Fk_DCNCHDR_ID = Convert.ToInt64("0" + DCNCHDR_ID.Text);
                            ObjAT_DCNCDTL.Fk_MItem_ID = Convert.ToInt64("0" + Fk_MItem_ID.Text);
                            ObjAT_DCNCDTL.DCNC_HSNCode = DCNC_HSNCode.Text;
                            ObjAT_DCNCDTL.DCNC_QTY =Convert.ToDecimal( DCNC_QTY.Text);
                            ObjAT_DCNCDTL.DCNC_BasicRate = Convert.ToDecimal(DCNC_BasicRate.Text);
                            ObjAT_DCNCDTL.DCNC_DiscountRate = Convert.ToDecimal(DCNC_DiscountRate.Text);
                            
                            
                            ObjAT_DCNCDTL.DCNC_ItemRemark_DTL = DCNC_ItemRemark_DTL.Text;
                            ObjAT_DCNCDTL.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
                            ObjAT_DCNCDTL.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
                            ObjAT_DCNCDTL.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));

                            ObjAT_DCNCDTL.Insert_Update(ObjAT_DCNCDTL);
                            
                            
                        }

                        scope.Complete();
                    }
                    MABL.SQLManager.SQLProcedureCall.USP_Update_Tbl_DCN_Cust(SessionUserData.Company.CompanyID,SessionUserData.Company.BranchID,SessionUserData.Company.YearID,  Convert.ToInt32(DCNCHDR_ID.Text));
                    SetValueToControls_Edit_HDR(Convert.ToInt32("0" + DCNCHDR_ID.Text));
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

               ObjAT_DCNCHDR.DCNCHDR_ID = Convert.ToInt64("0" + DCNCHDR_ID.Text);


               ObjAT_DCNCHDR.DCNC_ShippTo_State_ID = Convert.ToInt64(DCNC_ShippTo_State_ID.Text);
               ObjAT_DCNCHDR.DCNC_DT = DCNC_DT.Text;
               ObjAT_DCNCHDR.DCNC_Reason = DCNC_Reason.Text;
               ObjAT_DCNCHDR.DCNC_Remark = DCNC_Remark.Text;
               ObjAT_DCNCHDR.MDBSC_RowStatus = MDBSC_RowStatus.Text;
               ObjAT_DCNCHDR.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
               ObjAT_DCNCHDR.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
               ObjAT_DCNCHDR.MDBSC_RowLupdnOn_DT =  DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
               ObjAT_DCNCHDR.DCNC_HDR_Freight_Charges = Convert.ToDecimal("0" + DCNC_HDR_Freight_Charges.Text);
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
                dt = MABL.BL.AppDataModal.Get_Cust_DCN_List(strPK,"","");
                InitializeControls_HDR();
                InitializeControls_DTL();
                if (dt.Rows.Count > 0)
                { 
                    DCNCHDR_ID.Text = dt.Rows[0]["DCNCHDR_ID"].ToString();
                    Fk_INVHDR_ID.Text = dt.Rows[0]["Fk_INVHDR_ID"].ToString();
                  
                    SINV_Taxtype.Text = dt.Rows[0]["DCNC_Taxtype"].ToString();
                    MCust_Name.Text = dt.Rows[0]["MCust_Name"].ToString();
                    SINV_No.Text = dt.Rows[0]["SINV_No"].ToString();
                    vSINV_DT.Text = dt.Rows[0]["vSINV_DT"].ToString();
                    SINV_HDR_Total_Gross_Amt.Text = dt.Rows[0]["SINV_HDR_Total_Gross_Amt"].ToString();
                    DCNC_ShippTo_State_ID.Text = dt.Rows[0]["DCNC_ShippTo_State_ID"].ToString();
                    SINV_ShippedFrom_State_ID.Text = dt.Rows[0]["SINV_ShippedFrom_State_ID"].ToString();
                    DCNC_Reason.Text = dt.Rows[0]["DCNC_Reason"].ToString();
                    DCNC_No.Text = dt.Rows[0]["DCNC_No"].ToString();
                    DCNC_DT.Text = dt.Rows[0]["vDCNC_DT"].ToString();
                    DCNC_Type.Text = dt.Rows[0]["DCNC_Type"].ToString();
                  
                    DCNC_Remark.Text = dt.Rows[0]["DCNC_Remark"].ToString();
                    MDBSC_RowStatus.Text = dt.Rows[0]["MDBSC_RowStatus"].ToString();
                    DCNC_HDR_BasicAmt.Text = dt.Rows[0]["DCNC_HDR_BasicAmt"].ToString();
                    DCNC_HDR_DiscountAmt.Text = dt.Rows[0]["DCNC_HDR_DiscountAmt"].ToString();
                    DCNC_HDR_Net_Amt.Text = dt.Rows[0]["DCNC_HDR_Net_Amt"].ToString();
                    DCNC_HDR_Freight_Charges.Text = dt.Rows[0]["DCNC_HDR_Freight_Charges"].ToString();
                    DCNC_HDR_CGST_Amt.Text = dt.Rows[0]["DCNC_HDR_CGST_Amt"].ToString();
                    DCNC_HDR_SGST_Amt.Text = dt.Rows[0]["DCNC_HDR_SGST_Amt"].ToString();
                    DCNC_HDR_IGST_Amt.Text = dt.Rows[0]["DCNC_HDR_IGST_Amt"].ToString();
                    DCNC_HDR_CESS_Amt.Text = dt.Rows[0]["DCNC_HDR_CESS_Amt"].ToString();
                    DCNC_HDR_Gross_Amt.Text = dt.Rows[0]["DCNC_HDR_Gross_Amt"].ToString();
                    DCNC_HDR_Total_Tax_Amt.Text = dt.Rows[0]["DCNC_HDR_Total_Tax_Amt"].ToString();
                    DCNC_HDR_Round_Off_Amt.Text = dt.Rows[0]["DCNC_HDR_Round_Off_Amt"].ToString();
                    DCNC_HDR_Total_Gross_Amt.Text = dt.Rows[0]["DCNC_HDR_Total_Gross_Amt"].ToString();
                    
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
                dt = MABL.BL.AppDataModal.Get_Sales_List(strPK, "", "");
                InitializeControls_HDR();
                InitializeControls_DTL();
                if (dt.Rows.Count > 0)
                {
                    Fk_INVHDR_ID.Text = dt.Rows[0]["SINVHDR_ID"].ToString();
                    SINV_Taxtype.Text = dt.Rows[0]["SINV_Taxtype"].ToString();
                    SINV_HDR_Total_Gross_Amt.Text = dt.Rows[0]["SINV_HDR_Total_Gross_Amt"].ToString();
                    MCust_Name.Text = dt.Rows[0]["MCust_Name"].ToString();
                    vSINV_DT.Text = dt.Rows[0]["vSINV_DT"].ToString();
                    MCust_Name.Text = dt.Rows[0]["MCust_Name"].ToString();
                    SINV_No.Text = dt.Rows[0]["SINV_No"].ToString();
                    DCNC_ShippTo_State_ID.Text = dt.Rows[0]["SINV_ShippTo_State_ID"].ToString();
                    SINV_ShippedFrom_State_ID.Text = dt.Rows[0]["SINV_ShippedFrom_State_ID"].ToString();
                    
                     
                  
                     
                  

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
                    DCNC_Type.Text = "Debit Note";
                }
                if (lnkSelectInv.CommandArgument == "CreditNote")
                {
                    DCNC_Type.Text = "Credit Note";
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
                dt =MABL.BL.AppDataModal.Get_Cust_DCN_Item_List (Convert.ToInt64(DCNCHDR_ID.Text), Convert.ToInt64(row.Cells[0].Text),"", "");
                if (dt.Rows.Count > 0)
                {
                    DCNCDTL_ID.Text = dt.Rows[0]["DCNCDTL_ID"].ToString();
                    Fk_MItem_ID.Text = dt.Rows[0]["Fk_MItem_ID"].ToString();
                    DCNC_HSNCode.Text = dt.Rows[0]["DCNC_HSNCode"].ToString();
                    DCNC_QTY.Text = dt.Rows[0]["DCNC_QTY"].ToString();
                    DCNC_BasicRate.Text = dt.Rows[0]["DCNC_BasicRate"].ToString();
                    DCNC_DiscountRate.Text = dt.Rows[0]["DCNC_DiscountRate"].ToString();
                   
                    DCNC_ItemRemark_DTL.Text = dt.Rows[0]["DCNC_ItemRemark_DTL"].ToString();
                   
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
                string RetMesg = MaheshAF18.Application.SQLManager.DeleteSRMD("", "M_AT_DNC_Cust_BDTL", "Fk_DCNCHDR_ID", Convert.ToInt64(0 + row.Cells[1].Text), "DCNCDTL_ID", Convert.ToInt64(0 + row.Cells[0].Text), "C", "");
                MABL.SQLManager.SQLProcedureCall.USP_Update_Tbl_DCN_Cust(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, Convert.ToInt32(DCNCHDR_ID.Text));
                SetValueToControls_Edit_HDR(Convert.ToInt32(DCNCHDR_ID.Text));
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
                if (SINV_Taxtype.Text == "IGST")
                {
                    e.Row.Cells[13].Visible = false;
                    e.Row.Cells[14].Visible = false;
                    e.Row.Cells[15].Visible = false;
                    e.Row.Cells[16].Visible = false;
                     

                }
                if (SINV_Taxtype.Text == "SGST")
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

                SessionUserData.AppInfo.TempStrVariable_1 = SINV_Taxtype.Text;
                SessionUserData.AppInfo.TempIntVariable_1 = Convert.ToInt64(DCNCHDR_ID.Text);
                Response.Write("<script type='text/javascript'>detailedresults=window.open('" + MABL.BL.AppVariable.Project_Constant("RptBrowse") + "/ReportBrowser/CustDCN.aspx');</script>");


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
                DCNC_HSNCode.Text = dt.Rows[0]["HSNCode"].ToString();
                //DCNC_BasicRate.Text = dt.Rows[0]["Item_Purchase_Amt"].ToString();
                DCNC_QTY.Text = "0";
            }
            else
            {
                DCNC_HSNCode.Text = "";
                DCNC_BasicRate.Text = "0";
                DCNC_QTY.Text = "0";
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

               
                if (DCNC_ShippTo_State_ID.Text == SINV_ShippedFrom_State_ID.Text)
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