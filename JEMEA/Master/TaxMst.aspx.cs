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

namespace JEMEA.Master
{
    public partial class TaxMst : Mahesh_Page
    {
        M_AT_Mst_TaxBO Obj_AT_Tax;
        protected void Page_Load(object sender, EventArgs e)
        {

            PageMenuID = Request.QueryString["ID"];
            Obj_AT_Tax = new M_AT_Mst_TaxBO();
            SetControlType();


            if (!IsPostBack)
            {
                MaheshAF18.UIControlHelper.GenricControl.GetOperatorList(ddOperator);
                MaheshAF18.UIControlHelper.GenricControl.GetFieldListByGrid(gvList, ddSearchBy);
                FillDropdown();
                InitializeControls();
                RefreshGrid();
               
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
                //btnListClose.Attributes.Add("onClick", "self.location.replace(\"" + Strings.Replace(SessionUserData.AdditionalInfo.DashboardPage, "~/", "") + "\"); return false;");

                SetValueType(TextType.AmountField, Tax_Rate);




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

        }
        #endregion
        #region "Refrish Grid Functions"
        private void RefreshGrid(string SearchCriteria = "")
        {
            try
            {
                DataTable dt = default(DataTable);
                dt = Obj_AT_Tax.List(0, SearchCriteria);
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
        #endregion
        #region "Click New List Close"
        protected void btnClose_Click(object sender, System.EventArgs e)
        {
            try
            {
                Response.Redirect(SessionUserData.AppInfo.ModuleDashboardPage);


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

        #endregion
        #region "InitializeControls"
        private void InitializeControls()
        {
            try
            {
                Tax_ID.Text = "0";
                Tax_Rate.Text = "0";
                Tax_Category.SelectedIndex = 0;
              
                Tax_Desc.Text = "";
               
                 
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
                if (Tax_Category.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Select Tax Category.<br>";
                }
                if (Tax_Rate.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Invalid Tax Rate.<br>";
                }
                

                if (SQLManager.CheckDuplicateRecord("M_AT_Mst_Tax", "Tax_ID", Convert.ToInt32("0" + Tax_ID.Text), "Tax_Rate", Tax_Rate.Text, " AND Tax_Category=" + Tax_Category.Text))
                {
                    ErrorMessage = ErrorMessage + "Tax Already Exist<br>";
                }
                string var_tax_Name = Tax_Category.Text + " @" + Tax_Rate.Text + " %";
                if (SQLManager.CheckDuplicateRecord("M_AT_Mst_Tax", "Tax_ID", Convert.ToInt32("0" + Tax_ID.Text), "Tax", var_tax_Name, " AND Tax_Category=" + Tax_Category.Text))
                {
                    ErrorMessage = ErrorMessage + "Tax Already Exist<br>";
                }
                
                if (ErrorMessage.Length == 0)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (Convert.ToInt32(Tax_ID.Text) == 0)
                        {
                            Obj_AT_Tax.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                            Obj_AT_Tax.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName;
                        }
                        SetValuesToBO();
                        ErrorMessage = Obj_AT_Tax.Insert_Update(Obj_AT_Tax);
                        Tax_ID.Text = ErrorMessage.Substring((ErrorMessage.IndexOf("|") + 1), (ErrorMessage.Length - ErrorMessage.IndexOf("|") - 1));
                        ErrorMessage = ErrorMessage.Substring((0), (ErrorMessage.IndexOf("|")));
                        scope.Complete();
                    }

                    InitializeControls();
                    RefreshGrid();
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
                Obj_AT_Tax.Tax_ID = Convert.ToInt32("0" + Tax_ID.Text);
                Obj_AT_Tax.Tax = Tax_Category.Text + " @" + Tax_Rate.Text + " %";
                Obj_AT_Tax.Tax_Rate =Convert.ToDecimal(Tax_Rate.Text);
                Obj_AT_Tax.Tax_DisplayName = Tax_Category.Text + " @" + Tax_Rate.Text + " %";
                Obj_AT_Tax.Tax_Category = Tax_Category.Text;
                
                Obj_AT_Tax.Tax_Desc = Tax_Desc.Text;
                Obj_AT_Tax.MDBSC_RowStatus = "Active";
                Obj_AT_Tax.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
                Obj_AT_Tax.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
                Obj_AT_Tax.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
                
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
                dt = Obj_AT_Tax.List(strPK, "");
                InitializeControls();
                if (dt.Rows.Count > 0)
                {
                    Tax_ID.Text = dt.Rows[0]["Tax_ID"].ToString();
                    Tax_Category.Text = dt.Rows[0]["Tax_Category"].ToString(); 
                    Tax_Rate.Text = dt.Rows[0]["Tax_Rate"].ToString();
                    Tax_Desc.Text = dt.Rows[0]["Tax_Desc"].ToString(); 
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
          #endregion
        #region "Row DataBound"

     
        #endregion
        #region "Click Events"

        #endregion
        #region 'Print'

        #endregion
        #region "Function"

        #endregion
    }
}