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
    public partial class VendorPay : Mahesh_Page
    {
        M_AT_Acc_Payment_Vendor_AHDRBO ObjAT_VPHDR;
        M_AT_Acc_Payment_Vendor_BDTLBO ObjAT_VPDTL;
        protected void Page_Load(object sender, EventArgs e)
        {

            PageMenuID = Request.QueryString["ID"];
            ObjAT_VPHDR = new M_AT_Acc_Payment_Vendor_AHDRBO();
            ObjAT_VPDTL = new M_AT_Acc_Payment_Vendor_BDTLBO();
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
                SetValueType(TextType.DateField, VP_DT);
                SetValueType(TextType.DateField, VP_Ref_DT); 
                SetValueType(TextType.AmountField, VP_Received_Amt);
                SetValueType(TextType.AmountField, VP_Adjusted_Amt);
                SetValueType(TextType.AmountField, VP_OnAccount_Amt); 
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

            VP_Payment_Mode.DataSource = MABL.APPDT.MADD.DT_PaymentMode("", "", "Payment Mode");
            VP_Payment_Mode.DataBind();
        }
        #endregion
        #region "Refrish Grid Functions"
        private void RefreshGrid(string SearchCriteria = "")
        {
            try
            {


                DataTable dt = default(DataTable);
                dt = MABL.BL.AppDataModal.Get_VenPayment_List(0,"", SearchCriteria);
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
                dt = MABL.BL.AppDataModal.Get_VenPayment_Inv_List(Convert.ToInt64(AVPHDR_ID.Text),0, "", SearchCriteria);
                if (dt.Rows.Count > 0)
                {
                    gv_VP_Inv.DataSource = dt;
                    gv_VP_Inv.DataBind();
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
                    gv_VP_Inv.DataSource = null;
                    gv_VP_Inv.DataBind();
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
        protected void gv_VP_Inv_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            try
            {
                gv_VP_Inv.PageIndex = e.NewPageIndex;
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
              
                AVPHDR_ID.Text = "0";

                VP_No.Text = MEF.GetRefNo(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, "Vendor Payment", "VP", "VP", "Yes");
                VP_DT.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));

              
                Fk_VendorID.SelectedIndex = 0;
                VP_Received_Amt.Text = "0";
                VP_Adjusted_Amt.Text = "0";
                VP_OnAccount_Amt.Text = "0";
                VP_Payment_Mode.SelectedIndex = 0;
                VP_Ref_No.Text = "";
                VP_Ref_DT.Text = "";
                VP_Narration.Text = "";
                gv_VP_Inv.DataSource = null;
                gv_VP_Inv.DataBind();
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

                if (VP_DT.Text.Length != 11)
                {
                    ErrorMessage = ErrorMessage + "Invalid Entry Date<br>";
                }

                if (VP_No.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Invalid Ref No<br>";
                }

                if (Fk_VendorID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Pls Select Customer<br>";
                }

                if (VP_Received_Amt.Text.Length == 0)
                {
                     
                    ErrorMessage = ErrorMessage + "Received Amount Cannot Be Zero Or Blank<br>";
                }
                else
                {
                    if ( Convert.ToDecimal( VP_Received_Amt.Text) <= 0)
                    {

                        ErrorMessage = ErrorMessage + "Received Amount Cannot Be Zero Or Blank<br>";
                    }
                }

                decimal var_T_Received_Amt = Convert.ToDecimal (VP_Received_Amt.Text);
                decimal var_T_Adjusted_Amt = Convert.ToDecimal(VP_Adjusted_Amt.Text);
                decimal var_T_OnAccount_Amt = Convert.ToDecimal(VP_OnAccount_Amt.Text);
                decimal var_T_InvAdjust_Amt = 0;
                foreach (GridViewRow row in gv_VP_Inv.Rows)
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
                        if (Convert.ToInt32(AVPHDR_ID.Text) == 0)
                        {
                           
                            ObjAT_VPHDR.Fk_Company_ID = SessionUserData.Company.CompanyID;
                            ObjAT_VPHDR.Fk_Branch_ID = SessionUserData.Company.BranchID;
                            ObjAT_VPHDR.Fk_Year_ID = SessionUserData.Company.YearID;
                            ObjAT_VPHDR.Rec_Created_In = "Self";
                            ObjAT_VPHDR.Rec_CreatedBy_ID = SessionUserData.Company.BranchID;
                            ObjAT_VPHDR.Rec_CreatedFor_ID = SessionUserData.Company.BranchID;
                            ObjAT_VPHDR.VP_CreationType = "Manually";
                            ObjAT_VPHDR.PC_Type = "";
             
                            ObjAT_VPHDR.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                            ObjAT_VPHDR.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName;
                            ObjAT_VPHDR.VP_No = MEF.GenrateRefNo(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, SessionUserData.Company.YearID, "Vendor Payment", "VP", "VP", "No", "", "", "", 0);
                            
                        }
                        SetValuesToBO();
                        ErrorMessage = ObjAT_VPHDR.Insert_Update(ObjAT_VPHDR);
                        AVPHDR_ID.Text = ErrorMessage.Substring((ErrorMessage.IndexOf("|") + 1), (ErrorMessage.Length - ErrorMessage.IndexOf("|") - 1));
                        ErrorMessage = ErrorMessage.Substring((0), (ErrorMessage.IndexOf("|")));

                        foreach (GridViewRow row in gv_VP_Inv.Rows)
                        {
                            TextBox gv_Inv_Adjusted_Amt = (TextBox)row.FindControl("Inv_Adjusted_Amt");
                            if (Convert.ToDecimal(gv_Inv_Adjusted_Amt.Text) > 0)
                            {
                                ObjAT_VPDTL = new M_AT_Acc_Payment_Vendor_BDTLBO();
                                ObjAT_VPDTL.AVPDTL_ID = Convert.ToInt64(row.Cells[0].Text);
                                ObjAT_VPDTL.Fk_AVPHDRID = Convert.ToInt64(AVPHDR_ID.Text);
                                ObjAT_VPDTL.Fk_InvoiceID = Convert.ToInt64(row.Cells[2].Text);
                                ObjAT_VPDTL.Inv_Adjusted_Amt = Convert.ToDecimal(gv_Inv_Adjusted_Amt.Text);
                                ErrorMessage = ObjAT_VPDTL.Insert_Update(ObjAT_VPDTL);
                                ErrorMessage = ErrorMessage.Substring((0), (ErrorMessage.IndexOf("|")));
                            }
                            else
                            {
                                if (Convert.ToInt64(row.Cells[0].Text) > 0)
                                {
                                    MaheshAF18.Application.SQLManager.DeleteSRMD("M_AT_Acc_Payment_Vendor_AHDR", "M_AT_Acc_Payment_Vendor_BDTL", "AVPHDR_ID", Convert.ToInt64(0 + row.Cells[1].Text), "AVPDTL_ID", Convert.ToInt64(0 + row.Cells[0].Text), "C", "");
                                }
                            }
                        }
                        scope.Complete(); 
                    }
                    MABL.SQLManager.SQLProcedureCall.USP_Update_Tbl_Payment_Vendor(Convert.ToInt32(AVPHDR_ID.Text));
                    SetValueToControls_Edit(Convert.ToInt64(AVPHDR_ID.Text));
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

                ObjAT_VPHDR.AVPHDR_ID = Convert.ToInt64(0 + AVPHDR_ID.Text);
             
                ObjAT_VPHDR.VP_DT = VP_DT.Text;
                ObjAT_VPHDR.Fk_VendorID = Convert.ToInt64(Fk_VendorID.Text);
                ObjAT_VPHDR.VP_Received_Amt =Convert.ToDecimal( VP_Received_Amt.Text);
                ObjAT_VPHDR.VP_Adjusted_Amt = 0;
                ObjAT_VPHDR.VP_OnAccount_Amt = 0;
                ObjAT_VPHDR.VP_Payment_Mode = VP_Payment_Mode.Text;
                ObjAT_VPHDR.VP_Ref_No = VP_Ref_No.Text;
                if (VP_Ref_DT.Text.Length == 11)
                {
                    ObjAT_VPHDR.VP_Ref_DT = VP_Ref_DT.Text;
                }
                
                ObjAT_VPHDR.VP_Narration = VP_Narration.Text;
                ObjAT_VPHDR.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
                ObjAT_VPHDR.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
                ObjAT_VPHDR.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
               


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
                dt = MABL.BL.AppDataModal.Get_VenPayment_List(strPK,"", "");
                InitializeControls();
                if (dt.Rows.Count > 0)
                { 

                    AVPHDR_ID.Text = dt.Rows[0]["AVPHDR_ID"].ToString();
                    VP_No.Text = dt.Rows[0]["VP_No"].ToString();
                    VP_DT.Text = dt.Rows[0]["vVP_DT"].ToString();
                    Fk_VendorID.Text = dt.Rows[0]["Fk_VendorID"].ToString();
                    VP_Received_Amt.Text = dt.Rows[0]["VP_Received_Amt"].ToString();
                    VP_Adjusted_Amt.Text = dt.Rows[0]["VP_Adjusted_Amt"].ToString();
                    VP_OnAccount_Amt.Text = dt.Rows[0]["VP_OnAccount_Amt"].ToString();
                    VP_Payment_Mode.Text = dt.Rows[0]["VP_Payment_Mode"].ToString();
                    VP_Ref_No.Text = dt.Rows[0]["VP_Ref_No"].ToString();
                    VP_Ref_DT.Text = dt.Rows[0]["vVP_Ref_DT"].ToString();
                    VP_Narration.Text = dt.Rows[0]["VP_Narration"].ToString();
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
        protected void gv_VP_Inv_RowCreated(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
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
        protected void gv_VP_Inv_OnRowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
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