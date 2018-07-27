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
    public partial class ItemMaster : Mahesh_Page
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
                 
                SetValueType(TextType.DateField, MDBSC_RowCreatedOn_DT);
                SetValueType(TextType.DateField, Item_Tax_GST_Effective_From);

                SetValueType(TextType.AmountField, Item_CGST_Rate);
                SetValueType(TextType.AmountField, Item_SGST_Rate);
                SetValueType(TextType.AmountField, Item_IGST_Rate);
                SetValueType(TextType.AmountField, Item_CESS_Rate);
                

                SetValueType(TextType.AmountField, Item_Selling_Rate);
                SetValueType(TextType.AmountField, Item_Purchase_Rate); 
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
            UOM_ID.DataSource = MaheshAF18.Utility.M_DropDownList.Fill_Drop_Down_List("M_AT_Mst_UOM", "UOM_ID", "UOM", "", "", "UOM", 0, "N", "");
            UOM_ID.DataBind();


            Item_Tax_GST_ID.DataSource = MABL.BL.AppBL.Get_Tax_DD("Integrated Tax", 0);
            Item_Tax_GST_ID.DataBind();
           
            
        }
        #endregion
        #region "Refrish Grid Functions"
        private void RefreshGrid(string SearchCriteria = "")
        {
            try
            {


                DataTable dt = default(DataTable);
                dt = MABL.BL.AppDataModal.Get_Mst_Item(0, "", SearchCriteria);
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
                MItem_ID.Text = "0";
                UOM_ID.SelectedIndex = 0;
                Item_Code.Text = MEF.GetRefNo(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, 0, "Item", "IC", "IC", "No");
                HSNCode.Text = "";
                Item_Type.SelectedIndex = 0;
                Item_Name.Text = "";
                Item_Selling_Rate.Text = "0";
                Item_Purchase_Rate.Text = "0";
                Item_Desc.Text = "";
               
                Item_Tax_GST_Effective_From.Text = "01-Jul-2017";
                Item_CGST_Rate.Text = "0";
                Item_SGST_Rate.Text = "0";
                Item_IGST_Rate.Text = "0";

                Item_Tax_GST_ID.SelectedIndex = 0;
                Item_CESS_Rate.Text = "0";
               
              

                MDBSC_RowStatus.SelectedIndex = 0;

                MDBSC_RowCreatedByUserName.Text = SessionUserData.UserData.UserName;
                MDBSC_RowCreatedOn_DT.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));

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
                
                if (SQLManager.CheckDuplicateRecord("M_AT_Mst_ItemMaster", "MItem_ID", Convert.ToInt32("0" + MItem_ID.Text), "Item_Name", Item_Name.Text, ""))
                {
                    ErrorMessage = ErrorMessage + "Item Already Exist.<br>";
                }
                if (Item_Name.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Item Name Cannot Be Blank<br>";
                }
                

                

               
                if (UOM_ID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Select Unit Of Measurment<br>";
                }

                if (Item_Tax_GST_ID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Select Integrated Tax Rate<br>";
                }

                if (Item_Tax_GST_Effective_From.Text.Length != 11)
                {
                    ErrorMessage = ErrorMessage + "Invalid Integrated Tax Rate Effective From Date<br>";
                }

                if (Item_Code.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Invalid Item Code <br>";
                }
                  
                if (ErrorMessage.Length == 0)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (Convert.ToInt32(MItem_ID.Text) == 0)
                        {
                           
                            ObjBOAT_Item.Fk_Company_ID = SessionUserData.Company.CompanyID;
                            ObjBOAT_Item.Fk_Branch_ID = SessionUserData.Company.BranchID;
                            ObjBOAT_Item.Fk_Year_ID = SessionUserData.Company.YearID;
                            ObjBOAT_Item.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                            ObjBOAT_Item.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName;
                            ObjBOAT_Item.Item_SRNO = 0;
                            ObjBOAT_Item.Fk_MIC_ID = 1;
                            ObjBOAT_Item.Fk_IG_ID = 1;
                            ObjBOAT_Item.Fk_ISG_ID = 1;
                            ObjBOAT_Item.Item_Code = MEF.GenrateRefNo(SessionUserData.Company.CompanyID, SessionUserData.Company.BranchID, 0, "Item", "IC", "IC", "No", "", "", "", 0);
                           
                        }
                        SetValuesToBO();
                        ErrorMessage = ObjBOAT_Item.Insert_Update(ObjBOAT_Item);
                        MItem_ID.Text = ErrorMessage.Substring((ErrorMessage.IndexOf("|") + 1), (ErrorMessage.Length - ErrorMessage.IndexOf("|") - 1));
                        ErrorMessage = ErrorMessage.Substring((0), (ErrorMessage.IndexOf("|")));
                        scope.Complete();
                    }
                     
                    SetValueToControls_Edit(Convert.ToInt64(MItem_ID.Text));
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

                ObjBOAT_Item.MItem_ID = Convert.ToInt64(0 + MItem_ID.Text); 
                ObjBOAT_Item.Item_Type = Item_Type.Text; 
                ObjBOAT_Item.Fk_UOM_ID = Convert.ToInt32(0 + UOM_ID.Text);
                ObjBOAT_Item.Item_Name = Item_Name.Text;
                ObjBOAT_Item.Item_Inv_Desc = Item_Name.Text;
                
                ObjBOAT_Item.HSNCode = HSNCode.Text;
                ObjBOAT_Item.Item_Tax_GST_ID = Convert.ToInt64(Item_Tax_GST_ID.Text);
                decimal var_Tax_GST_Rate = Convert.ToDecimal(Item_Tax_GST_ID.SelectedItem.Text);
                decimal var_Tax_SGST_Rate = Math.Round((var_Tax_GST_Rate / 2), 2);
                ObjBOAT_Item.Item_CGST_Rate = var_Tax_SGST_Rate;
                ObjBOAT_Item.Item_SGST_Rate = var_Tax_SGST_Rate;
                ObjBOAT_Item.Item_IGST_Rate = var_Tax_GST_Rate;
                ObjBOAT_Item.I_UserCode = "";
                
                if (Item_Tax_GST_Effective_From.Text.Length == 11)
                {
                    ObjBOAT_Item.Item_Tax_GST_Effective_From = Item_Tax_GST_Effective_From.Text;
                }


                ObjBOAT_Item.Item_CESS_Rate = Convert.ToDecimal(Item_CESS_Rate.Text);

                ObjBOAT_Item.I_Asset_Code = "";
                ObjBOAT_Item.Item_Selling_Rate = Convert.ToDecimal(Item_Selling_Rate.Text);
                ObjBOAT_Item.Item_Purchase_Rate = Convert.ToDecimal(Item_Purchase_Rate.Text); 
                ObjBOAT_Item.Item_Desc = Item_Desc.Text; 
                ObjBOAT_Item.MDBSC_RowStatus = MDBSC_RowStatus.Text; 
                ObjBOAT_Item.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
                ObjBOAT_Item.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
                ObjBOAT_Item.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));


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
                dt = MABL.BL.AppDataModal.Get_Mst_Item(strPK, "", "");
                InitializeControls();
                if (dt.Rows.Count > 0)
                {

                    MItem_ID.Text = dt.Rows[0]["MItem_ID"].ToString();
                    HSNCode.Text = dt.Rows[0]["HSNCode"].ToString();
                    Item_Purchase_Rate.Text = dt.Rows[0]["Item_Purchase_Rate"].ToString();
                    Item_Selling_Rate.Text = dt.Rows[0]["Item_Selling_Rate"].ToString();
                    Item_Type.Text = dt.Rows[0]["Item_Type"].ToString();
                    
                    Item_Tax_GST_ID.Text = dt.Rows[0]["Item_Tax_GST_ID"].ToString();
                    Item_CESS_Rate.Text = dt.Rows[0]["Item_CESS_Rate"].ToString();

                
                    Item_Tax_GST_Effective_From.Text = dt.Rows[0]["vItem_Tax_GST_Effective_From"].ToString();

                    Item_CGST_Rate.Text = dt.Rows[0]["Item_CGST_Rate"].ToString();
                    Item_SGST_Rate.Text = dt.Rows[0]["Item_SGST_Rate"].ToString();
                    Item_IGST_Rate.Text = dt.Rows[0]["Item_IGST_Rate"].ToString(); 


                    UOM_ID.Text = dt.Rows[0]["Fk_UOM_ID"].ToString();
                    Item_Code.Text = dt.Rows[0]["Item_Code"].ToString();
                    Item_Name.Text = dt.Rows[0]["Item_Name"].ToString();
                    MDBSC_RowStatus.Text = dt.Rows[0]["MDBSC_RowStatus"].ToString();
                    MDBSC_RowCreatedOn_DT.Text = dt.Rows[0]["vMDBSC_RowCreatedOn_DT"].ToString();
                    MDBSC_RowCreatedByUserName.Text = dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
                    Item_Desc.Text = dt.Rows[0]["Item_Desc"].ToString();
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