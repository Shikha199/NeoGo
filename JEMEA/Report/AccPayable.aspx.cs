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
    public partial class AccPayable : Mahesh_Page
    {
       
             

      
        protected void Page_Load(object sender, EventArgs e)
        {

            PageMenuID = Request.QueryString["ID"];
            //SessionData.UserAccess.MenuID = PageMenuID;

          
            SetControlType();


            if (!IsPostBack)
            {
                MaheshAF18.UIControlHelper.GenricControl.GetOperatorList(ddOperator);
                MaheshAF18.UIControlHelper.GenricControl.GetFieldListByGrid(gvList, ddSearchBy);
                MaheshAF18.UIControlHelper.GenricControl.GetOperatorList(Dtl_ddOperator);
                MaheshAF18.UIControlHelper.GenricControl.GetFieldListByGrid(gvdtl, Dtl_ddSearchBy);                
              

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
        protected void Dtl_imgButtonGo_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            try
            {
                string SearchCriteria = "";
                SearchCriteria = Dtl_ddSearchBy.Text + "|" + Dtl_ddOperator.Text + (Dtl_searchvalue.Text.Length > 0 ? "|" : "") + Dtl_searchvalue.Text;
                RefreshGrid_Item_DTL(SearchCriteria);
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

                SetValueType(TextType.DateField, Dtl_Txt_FromDT);
                SetValueType(TextType.DateField, Dtl_Txt_ToDT);
                 
                
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
        private void RefreshGrid_HDR(string SearchCriteria = "")
        {
            try
            {
                string var_SQLFilter = "";
                if ((Txt_FromDT.Text.Length > 0) && (Txt_ToDT.Text.Length > 0))
                {
                    var_SQLFilter = " AND PINV_DT BETWEEN  '" + Txt_FromDT.Text + "' AND  '" + Txt_ToDT.Text + "'";
                }
                DataTable dt = default(DataTable);
                dt = MABL.BL.AppRptDP.Rpt_Get_Acc_Payable_Summary(var_SQLFilter, SearchCriteria);
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
                string var_SQLFilter = "";
                if ((Dtl_Txt_FromDT.Text.Length > 0) && (Dtl_Txt_ToDT.Text.Length > 0))
                {
                    var_SQLFilter = " AND PINV_DT BETWEEN  '" + Dtl_Txt_FromDT.Text + "' AND  '" + Dtl_Txt_ToDT.Text + "'";
                }

                DataTable dt = default(DataTable);
                dt = MABL.BL.AppRptDP.Rpt_Get_Acc_Payable_Detail(var_SQLFilter, SearchCriteria);
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
        protected void LnkRptSummary_Click(object sender, System.EventArgs e)
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
        protected void btnDetail_Click(object sender, System.EventArgs e)
        {
            try
            {

                RefreshGrid_Item_DTL();
                MultiView1.ActiveViewIndex =1;
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
                string SearchCriteria = "";
                SearchCriteria = ddSearchBy.Text + "|" + ddOperator.Text + (searchvalue.Text.Length > 0 ? "|" : "") + searchvalue.Text;
                RefreshGrid_HDR(SearchCriteria);
            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary(ex.Message);
            }
        }
        protected void gvdtl_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            try
            {
                gvdtl.PageIndex = e.NewPageIndex;
                string SearchCriteria = "";
                SearchCriteria = Dtl_ddSearchBy.Text + "|" + Dtl_ddOperator.Text + (Dtl_searchvalue.Text.Length > 0 ? "|" : "") + Dtl_searchvalue.Text;
                RefreshGrid_Item_DTL(SearchCriteria);
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

                Dtl_Txt_FromDT.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(SessionUserData.Company.AccountingStartDate));
                Dtl_Txt_ToDT.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));

                gvdtl.DataSource = null;
                gvdtl.DataBind();

                 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    

        #endregion
        #region "Save"
       
        #endregion
        #region "SetValue"
      
     
        #endregion
        #region "EditValue"
       

        #endregion
        #region "Edit Click"
       
      
       
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
        protected void gvdtl_RowCreated(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
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
        #region "SelectedIndexChanged"

       
        #endregion
        #region "Function"
     
     
        #endregion
    }
}