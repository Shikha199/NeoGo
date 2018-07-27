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
    public partial class CustomerPay : Mahesh_Page
    {
        M_AT_Acc_Payment_Customer_AHDRBO ObjAT_CPHDR;
        M_AT_Acc_Payment_Customer_BDTLBO ObjAT_CPDTL;
        protected void Page_Load(object sender, EventArgs e)
        {

            PageMenuID = Request.QueryString["ID"];
            ObjAT_CPHDR = new M_AT_Acc_Payment_Customer_AHDRBO();
            ObjAT_CPDTL = new M_AT_Acc_Payment_Customer_BDTLBO();
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
                SetValueType(TextType.DateField, Txt_FromDT);
                SetValueType(TextType.DateField, Txt_ToDT);
                SetValueType(TextType.DateField, CP_DT);
                SetValueType(TextType.DateField, CP_Ref_DT); 
                SetValueType(TextType.AmountField, CP_Received_Amt);
                SetValueType(TextType.AmountField, CP_Adjusted_Amt);
                SetValueType(TextType.AmountField, CP_OnAccount_Amt); 
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

            CP_Payment_Mode.DataSource = MABL.APPDT.MADD.DT_PaymentMode("", "", "Payment Mode");
            CP_Payment_Mode.DataBind();
        }
        #endregion
        #region "Refrish Grid Functions"
        private void RefreshGrid(string SearchCriteria = "")
        {
            try
            {


                DataTable dt = default(DataTable);
                dt = MABL.BL.AppDataModal.Get_CustPayment_List(0,"", SearchCriteria);
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
        private void RefreshGrid_DTL_Inv(string SearchCriteria = "")
        {
            try
            {


                DataTable dt = default(DataTable);
                dt = MABL.BL.AppDataModal.Get_CustPayment_Inv_List(Convert.ToInt64(ACPHDR_ID.Text),0, "", SearchCriteria);
                if (dt.Rows.Count > 0)
                {
                    gv_CP_Inv.DataSource = dt;
                    gv_CP_Inv.DataBind();
                    if (dt.Rows.Count < 25)
                    {
                        Msg_RCNT_DTL.Text = "Showing " + dt.Rows.Count + " Records  ";
                    }
                    else
                    {
                        Msg_RCNT_DTL.Text = "Showing 25 Of " + dt.Rows.Count + " Records  ";
                    }
                }
                else
                {
                    gv_CP_Inv.DataSource = null;
                    gv_CP_Inv.DataBind();
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
        protected void gv_CP_Inv_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            try
            {
                gv_CP_Inv.PageIndex = e.NewPageIndex;
                RefreshGrid_DTL_Inv();
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
                Txt_FromDT.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(SessionUserData.Company.AccountingStartDate));
                Txt_ToDT.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
              
                ACPHDR_ID.Text = "0";
                CP_No.Text = MEF.GetRefNo(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, "Customer Payment", "CP", "CP", "Yes");
                CP_DT.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
                Fk_CustomerID.SelectedIndex = 0;
                CP_Received_Amt.Text = "0";
                CP_Adjusted_Amt.Text = "0";
                CP_OnAccount_Amt.Text = "0";
                CP_Payment_Mode.SelectedIndex = 0;
                CP_Ref_No.Text = "";
                CP_Ref_DT.Text = "";
                CP_Narration.Text = "";
                gv_CP_Inv.DataSource = null;
                gv_CP_Inv.DataBind();
                Msg_RCNT.Text = " No Records Found";
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

                if (CP_DT.Text.Length != 11)
                {
                    ErrorMessage = ErrorMessage + "Invalid Entry Date<br>";
                }

                if (CP_No.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Invalid Ref No<br>";
                }

                if (Fk_CustomerID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Pls Select Customer<br>";
                }

                if (CP_Received_Amt.Text.Length == 0)
                {
                     
                    ErrorMessage = ErrorMessage + "Received Amount Cannot Be Zero Or Blank<br>";
                }
                else
                {
                    if ( Convert.ToDecimal( CP_Received_Amt.Text) <= 0)
                    {

                        ErrorMessage = ErrorMessage + "Received Amount Cannot Be Zero Or Blank<br>";
                    }
                }

                decimal var_T_Received_Amt = Convert.ToDecimal (CP_Received_Amt.Text);
                decimal var_T_Adjusted_Amt = Convert.ToDecimal(CP_Adjusted_Amt.Text);
                decimal var_T_OnAccount_Amt = Convert.ToDecimal(CP_OnAccount_Amt.Text);
                decimal var_T_InvAdjust_Amt = 0;
                foreach (GridViewRow row in gv_CP_Inv.Rows)
                {
                    TextBox gv_Inv_Adjusted_Amt = (TextBox)row.FindControl("Inv_Adjusted_Amt");
                    if (Convert.ToDecimal(gv_Inv_Adjusted_Amt.Text) > 0)
                    {
                        var_T_InvAdjust_Amt = var_T_InvAdjust_Amt + Convert.ToDecimal(gv_Inv_Adjusted_Amt.Text);
                    }
                    
                }

                if (var_T_Received_Amt < var_T_InvAdjust_Amt)
                {
                    ErrorMessage = ErrorMessage + "Sum Of Adjust Amount In Invoice Cannot Be Greater Than Received Amount <br> Adjusted Amt Sum : " + var_T_InvAdjust_Amt;
                }



                if (ErrorMessage.Length == 0)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (Convert.ToInt32(ACPHDR_ID.Text) == 0)
                        {
                           
                            ObjAT_CPHDR.Fk_Company_ID = SessionUserData.Company.CompanyID;
                            ObjAT_CPHDR.Fk_Branch_ID = SessionUserData.Company.BranchID;
                            ObjAT_CPHDR.Fk_Year_ID = SessionUserData.Company.YearID;
                            ObjAT_CPHDR.Rec_Created_In = "Self";
                            ObjAT_CPHDR.Rec_CreatedBy_ID = SessionUserData.Company.BranchID;
                            ObjAT_CPHDR.Rec_CreatedFor_ID = SessionUserData.Company.BranchID;
                            ObjAT_CPHDR.CP_CreationType = "Manually";
                            ObjAT_CPHDR.PC_Type = "";
             
                            ObjAT_CPHDR.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                            ObjAT_CPHDR.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName;
                            ObjAT_CPHDR.CP_No = MEF.GenrateRefNo(0, 0, 0, "Customer Payment", "Customer Payment", "CP-", "No", "", "", "", 0);
                            
                        }
                        SetValuesToBO();
                        ErrorMessage = ObjAT_CPHDR.Insert_Update(ObjAT_CPHDR);
                        ACPHDR_ID.Text = ErrorMessage.Substring((ErrorMessage.IndexOf("|") + 1), (ErrorMessage.Length - ErrorMessage.IndexOf("|") - 1));
                        ErrorMessage = ErrorMessage.Substring((0), (ErrorMessage.IndexOf("|")));

                        foreach (GridViewRow row in gv_CP_Inv.Rows)
                        {
                            TextBox gv_Inv_Adjusted_Amt = (TextBox)row.FindControl("Inv_Adjusted_Amt");
                            if (Convert.ToDecimal(gv_Inv_Adjusted_Amt.Text) > 0)
                            {
                                ObjAT_CPDTL = new M_AT_Acc_Payment_Customer_BDTLBO();
                                ObjAT_CPDTL.ACPDTL_ID = Convert.ToInt64(row.Cells[0].Text);
                                ObjAT_CPDTL.Fk_ACPHDRID = Convert.ToInt64(ACPHDR_ID.Text);
                                ObjAT_CPDTL.Fk_InvoiceID = Convert.ToInt64(row.Cells[2].Text);
                                ObjAT_CPDTL.Inv_Adjusted_Amt = Convert.ToDecimal(gv_Inv_Adjusted_Amt.Text);
                                ErrorMessage = ObjAT_CPDTL.Insert_Update(ObjAT_CPDTL);
                                ErrorMessage = ErrorMessage.Substring((0), (ErrorMessage.IndexOf("|")));
                            }
                            else
                            {
                                if (Convert.ToInt64(row.Cells[0].Text) > 0)
                                {
                                    MaheshAF18.Application.SQLManager.DeleteSRMD("M_AT_Acc_Payment_Customer_AHDR", "M_AT_Acc_Payment_Customer_BDTL", "ACPHDR_ID", Convert.ToInt64(0 + row.Cells[1].Text), "ACPDTL_ID", Convert.ToInt64(0 + row.Cells[0].Text), "C", "");
                                }
                            }
                        }
                        scope.Complete(); 
                    }
                    MABL.SQLManager.SQLProcedureCall.USP_Update_Tbl_Payment_Customer(Convert.ToInt32(ACPHDR_ID.Text));
                    SetValueToControls_Edit(Convert.ToInt64(ACPHDR_ID.Text));
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
        #endregion
        #region "SetValue"
        private void SetValuesToBO()
        {
            try
            {

                ObjAT_CPHDR.ACPHDR_ID = Convert.ToInt64(0 + ACPHDR_ID.Text);
             
                ObjAT_CPHDR.CP_DT = CP_DT.Text;
                ObjAT_CPHDR.Fk_CustomerID = Convert.ToInt64(Fk_CustomerID.Text);
                ObjAT_CPHDR.CP_Received_Amt =Convert.ToDecimal( CP_Received_Amt.Text);
                ObjAT_CPHDR.CP_Adjusted_Amt = 0;
                ObjAT_CPHDR.CP_OnAccount_Amt = 0;
                ObjAT_CPHDR.CP_Payment_Mode = CP_Payment_Mode.Text;
                ObjAT_CPHDR.CP_Ref_No = CP_Ref_No.Text;
                if (CP_Ref_DT.Text.Length == 11)
                {
                    ObjAT_CPHDR.CP_Ref_DT = CP_Ref_DT.Text;
                }
                
                ObjAT_CPHDR.CP_Narration = CP_Narration.Text;
                ObjAT_CPHDR.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
                ObjAT_CPHDR.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
                ObjAT_CPHDR.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
               


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
                dt = MABL.BL.AppDataModal.Get_CustPayment_List(strPK,"", "");
                InitializeControls();
                if (dt.Rows.Count > 0)
                { 

                    ACPHDR_ID.Text = dt.Rows[0]["ACPHDR_ID"].ToString();
                    CP_No.Text = dt.Rows[0]["CP_No"].ToString();
                    CP_DT.Text = dt.Rows[0]["vCP_DT"].ToString();
                    Fk_CustomerID.Text = dt.Rows[0]["Fk_CustomerID"].ToString();
                    CP_Received_Amt.Text = dt.Rows[0]["CP_Received_Amt"].ToString();
                    CP_Adjusted_Amt.Text = dt.Rows[0]["CP_Adjusted_Amt"].ToString();
                    CP_OnAccount_Amt.Text = dt.Rows[0]["CP_OnAccount_Amt"].ToString();
                    CP_Payment_Mode.Text = dt.Rows[0]["CP_Payment_Mode"].ToString();
                    CP_Ref_No.Text = dt.Rows[0]["CP_Ref_No"].ToString();
                    CP_Ref_DT.Text = dt.Rows[0]["vCP_Ref_DT"].ToString();
                    CP_Narration.Text = dt.Rows[0]["CP_Narration"].ToString();
                    RefreshGrid_DTL_Inv();
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
        protected void gv_CP_Inv_RowCreated(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
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
        protected void gv_CP_Inv_OnRowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                TextBox gv_Inv_Adjusted_Amt = (TextBox)e.Row.FindControl("Inv_Adjusted_Amt");



                SetValueType(TextType.AmountField, gv_Inv_Adjusted_Amt);


            }
        }


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