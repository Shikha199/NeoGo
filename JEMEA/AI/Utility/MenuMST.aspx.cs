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


namespace JEMEA.Utility
{
    public partial class MenuMST : Mahesh_Page
    {

        AAA_M_RT_App_MenuBO Obj_RT_AppMenu;
        protected void Page_Load(object sender, EventArgs e)
        {

            PageMenuID = Request.QueryString["ID"];
            //SessionData.UserAccess.MenuID = PageMenuID;

            Obj_RT_AppMenu = new AAA_M_RT_App_MenuBO();
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
               // btnListClose.Attributes.Add("onClick", "self.location.replace(\"" + Strings.Replace(SessionUserData.AdditionalInfo.DashboardPage, "~/", "") + "\"); return false;");


               


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
            M_RT_AM_ID.DataSource = MaheshAF18.Utility.M_DropDownList.Fill_Drop_Down_List("AAA_M_RT_App_Module", "M_RT_AM_ID", "MDBSC_App_ModuleName", " ", "", "Module", 0, "N", " ");
            M_RT_AM_ID.DataBind();
        }
        #endregion
        #region "Refrish Grid Functions"
        private void RefreshGrid(string SearchCriteria = "")
        {
            try
            {
                DataTable dt = default(DataTable);
                string var_STRSQL = "";
                if (M_RT_AppMenu_ID.SelectedIndex == 0)
                {
                    var_STRSQL = " SELECT *  " +
                                    " FROM AAA_M_RT_App_Menu      " +
                                    " WHERE  FK_MDBSC_Menu_ModuleID=" + M_RT_AM_ID.Text + " AND MDBSC_Menu_ParentID=0 "  +
                                    " ORDER BY MDBSC_Menu_SerialNo ASC ";


                }

                if (M_RT_AppMenu_ID.SelectedIndex > 0)
                {
                    var_STRSQL = " SELECT  *  " +
                                  " FROM AAA_M_RT_App_Menu      " +
                                  " WHERE  FK_MDBSC_Menu_ModuleID=" + M_RT_AM_ID.Text + " AND MDBSC_Menu_ParentID=" + M_RT_AppMenu_ID.Text +
                                  " ORDER BY MDBSC_Menu_SerialNo ASC ";


                }
                if (var_STRSQL.Length > 0)
                {

                    dt = MaheshAF18.Application.MEF.DA_GetDataTable(var_STRSQL);
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
                RefreshGrid();
                MultiView1.ActiveViewIndex = 0;
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
                 
                MultiView1.ActiveViewIndex = 1;
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

                if (gvList.Rows.Count == 0)
                {
                    ErrorMessage = ErrorMessage + "No Rows To Update <br>";
                }
               
                
              
                if (ErrorMessage.Length == 0)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        foreach (GridViewRow row in gvList.Rows)
                        {
                            TextBox MDBSC_Menu_SerialNo = (TextBox)row.FindControl("MDBSC_Menu_SerialNo");
                            Obj_RT_AppMenu = new AAA_M_RT_App_MenuBO();
                            Obj_RT_AppMenu.M_RT_AppMenu_ID = Convert.ToInt64("0" + row.Cells[0].Text);
                            Obj_RT_AppMenu.MDBSC_Menu_SerialNo = Convert.ToInt64("0" + MDBSC_Menu_SerialNo.Text);
                             
                            ErrorMessage = Obj_RT_AppMenu.Insert_Update(Obj_RT_AppMenu);                             
                            ErrorMessage = ErrorMessage.Substring((0), (ErrorMessage.IndexOf("|")));
                        }
                        scope.Complete();
                    }

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
               // e.Row.Cells[0].Visible = false;

            }
        }
      
        #endregion
        #region "Row DataBound"

        protected void gvList_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                TextBox MDBSC_Menu_SerialNo = (TextBox)e.Row.FindControl("MDBSC_Menu_SerialNo"); 

                SetValueType(TextType.NumericField, MDBSC_Menu_SerialNo);
              
            }
        }
        #endregion
        #region "Click Events"

        #endregion
        #region 'Print'

        #endregion
        #region "SelectedIndexChanged"
        protected void M_RT_AM_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Get_ParentMenu(M_RT_AM_ID.Text, "0");

                if (M_RT_AM_ID.SelectedIndex >0)
                {
                    RefreshGrid();
                }
                
            }
            catch (Exception ex)
            {
            }
        }
        protected void M_RT_AppMenu_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                RefreshGrid();
                
                
            }
            catch (Exception ex)
            {
            }
        }
       
        #endregion
        #region "Function"

        private void Get_ParentMenu(string ModuleID, string var_SetValue)
        {
            try
            {
                string var_STRSQL = " SELECT 0 value,'--Select Parent Menu--' Text,0 RSN,0 MDBSC_Menu_SerialNo " +
                                   " UNION ALL " +
                                   " SELECT M_RT_AppMenu_ID, MDBSC_Menu_Menu + ' [' + convert(varchar,MDBSC_Menu_SerialNo) + ']' Text,1 RSN,MDBSC_Menu_SerialNo " +
                                   " FROM  AAA_M_RT_App_Menu " +
                                   " WHERE MDBSC_Menu_ParentID=0 AND   FK_MDBSC_Menu_ModuleID=" + M_RT_AM_ID.Text +
                                   " ORDER BY RSN ASC, MDBSC_Menu_SerialNo ASC,Text asc ";

                M_RT_AppMenu_ID.Items.Clear();
                M_RT_AppMenu_ID.DataSource = MaheshAF18.Application.MEF.DA_GetDataTable(var_STRSQL);
                M_RT_AppMenu_ID.DataBind();

                if (var_SetValue != "0")
                {
                    M_RT_AppMenu_ID.Text = var_SetValue;
                }
                else
                {
                    M_RT_AppMenu_ID.SelectedIndex = 0;
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