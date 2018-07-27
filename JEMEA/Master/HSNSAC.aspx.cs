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
    public partial class HSNSAC : Mahesh_Page
    {
        M_AT_Mst_CMP_HSNSACBO ObjBOAT_HSNSAC;
        protected void Page_Load(object sender, EventArgs e)
        {

            PageMenuID = Request.QueryString["ID"];
            ObjBOAT_HSNSAC = new M_AT_Mst_CMP_HSNSACBO();
            SetControlType();
            if (!IsPostBack)
            {
                MaheshAF18.UIControlHelper.GenricControl.GetOperatorList(ddOperator);
                MaheshAF18.UIControlHelper.GenricControl.GetFieldListByGrid(gvList, ddSearchBy);
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
                dt = MABL.BL.AppDataModal.Get_HSNSAC_Item(0, "", SearchCriteria);
                if (dt.Rows.Count > 0)
                {
                    gvList.DataSource = dt;
                    gvList.DataBind();
                    if (dt.Rows.Count < 250)
                    {
                        Msg_RCNT.Text = "Showing " + dt.Rows.Count + " Records  ";
                    }
                    else
                    {
                        Msg_RCNT.Text = "Showing 250 Of " + dt.Rows.Count + " Records  ";
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

        #endregion
        #region "InitializeControls"

        private void InitializeControls()
        {
            try
            {
                CHID_ID.Text = "0";
                HSN_Code.Text = "";
                HSN_Desc.Text = "";
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
                if (SQLManager.CheckDuplicateRecord("M_AT_Mst_CMP_HSNSAC", "CHID_ID", Convert.ToInt32("0" + CHID_ID.Text), "HSN_Code", HSN_Code.Text, ""))
                {
                    ErrorMessage = ErrorMessage + "HSN/SAC Item Already Exist.<br>";
                }
                if (HSN_Code.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + " Invalid HSN/SAC Code <br>";
                }

                if (HSN_Desc.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "HSN/SAC Item Name Cannot Be Blank<br>";
                }

                if (ErrorMessage.Length == 0)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (Convert.ToInt32(CHID_ID.Text) == 0)
                        {

                            ObjBOAT_HSNSAC.Fk_Company_ID = SessionUserData.Company.CompanyID;
                            ObjBOAT_HSNSAC.Fk_Branch_ID = SessionUserData.Company.BranchID;
                        }
                        SetValuesToBO();
                        ErrorMessage = ObjBOAT_HSNSAC.Insert_Update(ObjBOAT_HSNSAC);
                        CHID_ID.Text = ErrorMessage.Substring((ErrorMessage.IndexOf("|") + 1), (ErrorMessage.Length - ErrorMessage.IndexOf("|") - 1));
                        ErrorMessage = ErrorMessage.Substring((0), (ErrorMessage.IndexOf("|")));
                        scope.Complete();
                    }
                    SetValueToControls_Edit(Convert.ToInt64(HSN_Code.Text));
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
                ObjBOAT_HSNSAC.CHID_ID = Convert.ToInt64(0 + CHID_ID.Text);
                ObjBOAT_HSNSAC.HSNCode = HSN_Code.Text;
                ObjBOAT_HSNSAC.HSN_Desc = HSN_Desc.Text;
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
                dt = MABL.BL.AppDataModal.Get_HSNSAC_Item(strPK, "", "");
                InitializeControls();
                if (dt.Rows.Count > 0)
                {
                    CHID_ID.Text = dt.Rows[0]["CHID_ID"].ToString();
                    HSN_Code.Text = dt.Rows[0]["HSNCode"].ToString();
                    HSN_Desc.Text = dt.Rows[0]["HSN_Desc"].ToString();
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
        protected void lnkItemDelete_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                ImageButton lnkItemDelete = (ImageButton)sender;
                GridViewRow row = (GridViewRow)lnkItemDelete.NamingContainer;
                lnkItemDelete = (ImageButton)row.FindControl("lnkItemDelete");
                string RetMesg = MaheshAF18.Application.SQLManager.DeleteSRMD("M_AT_Mst_CMP_HSNSAC", "", "CHID_ID", Convert.ToInt64(0 + row.Cells[0].Text), "", 0, "S", "");
                SetValueToControls_Edit(Convert.ToInt32(CHID_ID.Text));
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

        #endregion
        #region "Row DataBound"


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