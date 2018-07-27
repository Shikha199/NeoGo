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
    public partial class ItemMstBulkUpdate : Mahesh_Page
    {
        M_AT_Mst_ItemMasterBO ObjBOAT_Item;
        protected void Page_Load(object sender, EventArgs e)
        {

            PageMenuID = Request.QueryString["ID"];
            ObjBOAT_Item = new M_AT_Mst_ItemMasterBO();
            SetControlType();
            if (!IsPostBack)
            {

                MaheshAF18.UIControlHelper.GenricControl.GetOperatorList(ddOperator);
                MaheshAF18.UIControlHelper.GenricControl.GetFieldListByGrid(gv_BulkItemUpdate, ddSearchBy);
                FillDropdown();
                InitializeControls();
                RefreshGrid_BulkUpdate();
                

            }
        }
        #region "Search"
        protected void imgButtonGo_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            try
            {
                string SearchCriteria = "";
                SearchCriteria = ddSearchBy.Text + "|" + ddOperator.Text + (searchvalue.Text.Length > 0 ? "|" : "") + searchvalue.Text;
                RefreshGrid_BulkUpdate(SearchCriteria);
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
      
        private void RefreshGrid_BulkUpdate(string SearchCriteria = "")
        {
            try
            {


                DataTable dt = default(DataTable);
                dt = MABL.BL.AppDataModal.Get_Mst_Item(0, "",SearchCriteria);
                if (dt.Rows.Count > 0)
                {
                    gv_BulkItemUpdate.DataSource = dt;
                    gv_BulkItemUpdate.DataBind();
                    if (dt.Rows.Count < 250)
                    {
                        Msg_RCNT_BIU.Text = "Showing " + dt.Rows.Count + " Records  ";
                    }
                    else
                    {
                        Msg_RCNT_BIU.Text = "Showing 250 Of " + dt.Rows.Count + " Records  ";
                    }
                }
                else
                {
                    gv_BulkItemUpdate.DataSource = null;
                    gv_BulkItemUpdate.DataBind();
                    Msg_RCNT_BIU.Text = " No Records Found";
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
        
        
       
        #endregion
        #region "Grid Function"
        protected void gvList_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            try
            {
                gv_BulkItemUpdate.PageIndex = e.NewPageIndex;
                RefreshGrid_BulkUpdate();
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
        
        protected void LnkBulkUpdateSave_Click(object sender, System.EventArgs e)
        {
            try
            {
                Int64 var_RecCNT = 0;

                foreach (GridViewRow row in gv_BulkItemUpdate.Rows)
                {
                    ErrorMessage = "";
                    TextBox gv_Item_Name = (TextBox)row.FindControl("Item_Name");
                    TextBox gv_Item_Inv_Desc = (TextBox)row.FindControl("Item_Inv_Desc");
                    TextBox gv_I_UserCode = (TextBox)row.FindControl("I_UserCode");
                    TextBox gv_Item_Selling_Rate = (TextBox)row.FindControl("Item_Selling_Rate");
                    TextBox gv_Item_Purchase_Rate = (TextBox)row.FindControl("Item_Purchase_Rate");
                   
                    if (gv_Item_Name.Text.Length == 0)
                    {
                        ErrorMessage = ErrorMessage + "Item Name Cannot Be Blank<br>";
                    }
                    else
                    {
                        if (SQLManager.CheckDuplicateRecord("M_AT_Mst_ItemMaster", "MItem_ID", Convert.ToInt32("0" + row.Cells[0].Text), "Item_Name", gv_Item_Name.Text, ""))
                        {
                            ErrorMessage = ErrorMessage + "Item Already Exist.<br>";
                        }
                    }

                    if (gv_Item_Inv_Desc.Text.Length == 0)
                    {
                        gv_Item_Inv_Desc.Text = gv_Item_Name.Text;
                    }

                    if (SQLManager.CheckDuplicateRecord("M_AT_Mst_ItemMaster", "MItem_ID", Convert.ToInt32("0" + row.Cells[0].Text), "Item_Inv_Desc", gv_Item_Inv_Desc.Text, ""))
                    {
                        ErrorMessage = ErrorMessage + "Item Inv Description Already Exist.<br>";
                    }

                   
                    if (MaheshAF18.Application.CodeAssistance.F_IsNumeric(gv_Item_Selling_Rate.Text) == false)
                    {
                        gv_Item_Selling_Rate.Text = "0";
                    }
                    if (MaheshAF18.Application.CodeAssistance.F_IsNumeric(gv_Item_Purchase_Rate.Text) == false)
                    {
                        gv_Item_Purchase_Rate.Text = "0";
                    }


                    if (ErrorMessage.Length == 0)
                    {

                        if (Convert.ToDecimal(row.Cells[0].Text) > 0)
                        {
                            using (TransactionScope scope = new TransactionScope())
                            {
                                M_AT_Mst_ItemMasterBO ObjBOAT_Item = new M_AT_Mst_ItemMasterBO();
                                ObjBOAT_Item.MItem_ID = Convert.ToInt64(0 + row.Cells[0].Text);
                                ObjBOAT_Item.Item_Name = gv_Item_Name.Text;

                                ObjBOAT_Item.Item_Inv_Desc = gv_Item_Inv_Desc.Text;
                                
                             
                                ObjBOAT_Item.I_UserCode = gv_I_UserCode.Text;
                                ObjBOAT_Item.Item_Selling_Rate = Convert.ToDecimal(gv_Item_Selling_Rate.Text);
                                ObjBOAT_Item.Item_Purchase_Rate = Convert.ToDecimal(gv_Item_Purchase_Rate.Text);
                                ErrorMessage = ObjBOAT_Item.Insert_Update(ObjBOAT_Item);

                                ErrorMessage = ErrorMessage.Substring((0), (ErrorMessage.IndexOf("|")));
                                var_RecCNT = var_RecCNT + 1;
                                scope.Complete();
                            }
                        }
                    }



                }

                RefreshGrid_BulkUpdate();
                DisplayCustomMessageSummary(ErrorMessage + " <br>  " + var_RecCNT.ToString() + " Record Updated");

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
      
        protected void btnsaveItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                Button btnsaveItem = (Button)sender;
                GridViewRow row = (GridViewRow)btnsaveItem.NamingContainer;
                btnsaveItem = (Button)row.FindControl("btnsaveItem");

                TextBox gv_Item_Name = (TextBox)row.FindControl("Item_Name");
                TextBox gv_I_UserCode = (TextBox)row.FindControl("I_UserCode");
                TextBox gv_Item_Selling_Rate = (TextBox)row.FindControl("Item_Selling_Rate");
                TextBox gv_Item_Purchase_Rate = (TextBox)row.FindControl("Item_Purchase_Rate");
              
                if (gv_Item_Name.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Item Name Cannot Be Blank<br>";
                }
                else
                {
                    if (SQLManager.CheckDuplicateRecord("M_AT_Mst_ItemMaster", "MItem_ID", Convert.ToInt32("0" + row.Cells[0].Text), "Item_Name", gv_Item_Name.Text, ""))
                    {
                        ErrorMessage = ErrorMessage + "Item Already Exist.<br>";
                    }
                }

               
                if (MaheshAF18.Application.CodeAssistance.F_IsNumeric(gv_Item_Selling_Rate.Text) == false)
                {
                    gv_Item_Selling_Rate.Text = "0";
                }
                if (MaheshAF18.Application.CodeAssistance.F_IsNumeric(gv_Item_Purchase_Rate.Text) == false)
                {
                    gv_Item_Purchase_Rate.Text = "0";
                }


                if (ErrorMessage.Length == 0)
                {

                    if (Convert.ToDecimal(row.Cells[0].Text) > 0)
                    {
                        using (TransactionScope scope = new TransactionScope())
                        {
                            M_AT_Mst_ItemMasterBO ObjBOAT_Item = new M_AT_Mst_ItemMasterBO();
                            ObjBOAT_Item.MItem_ID = Convert.ToInt64(0 + row.Cells[0].Text);
                            ObjBOAT_Item.Item_Name = gv_Item_Name.Text;
                            ObjBOAT_Item.HSNCode = gv_I_UserCode.Text;
                             ObjBOAT_Item.I_UserCode = gv_I_UserCode.Text;
                            ObjBOAT_Item.Item_Selling_Rate = Convert.ToDecimal(gv_Item_Selling_Rate.Text);
                            ObjBOAT_Item.Item_Purchase_Rate = Convert.ToDecimal(gv_Item_Purchase_Rate.Text);
                            ErrorMessage = ObjBOAT_Item.Insert_Update(ObjBOAT_Item);

                            ErrorMessage = ErrorMessage.Substring((0), (ErrorMessage.IndexOf("|")));
                            scope.Complete();
                        }
                    }
                }

                RefreshGrid_BulkUpdate();
                DisplayCustomMessageSummary(ErrorMessage);
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

       
        protected void gv_BulkItemUpdate_OnRowCreated(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.Pager)
            {
                e.Row.Cells[0].Visible = true;
            }
            if (e.Row.RowType == DataControlRowType.DataRow | e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Visible = false;
                e.Row.Cells[1].Visible = false;

            }
        }
        #endregion
        #region "Row DataBound"

        protected void gv_BulkItemUpdate_OnRowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                TextBox gv_Item_Name = (TextBox)e.Row.FindControl("Item_Name");
                TextBox gv_I_UserCode = (TextBox)e.Row.FindControl("I_UserCode");
                TextBox gv_Item_Selling_Rate = (TextBox)e.Row.FindControl("Item_Selling_Rate");
                TextBox gv_Item_Purchase_Rate = (TextBox)e.Row.FindControl("Item_Purchase_Rate");
             
           

                SetValueType(TextType.AmountField, gv_Item_Purchase_Rate);
                SetValueType(TextType.AmountField, gv_Item_Selling_Rate);


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