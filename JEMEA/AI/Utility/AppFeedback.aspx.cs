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

namespace JEMEA.Utility
{
    public partial class AppFeedback : Mahesh_Page
    {
        AAA_M_RT_AppFeedbackBO ObjAT_MAF;
        protected void Page_Load(object sender, EventArgs e)
        {

            PageMenuID = Request.QueryString["ID"];
            ObjAT_MAF = new AAA_M_RT_AppFeedbackBO();
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


                SetValueType(TextType.DateField, Q_Date);
                 




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
            Q_BranchID.DataSource = MaheshAF18.Utility.M_DropDownList.Fill_Drop_Down_List("AAA_M_RT_CMP_Branch", "M_RT_CMP_BR_ID", "MDBSC_BR_Name", "", "", "Site", 0, "N", "");
            Q_BranchID.DataBind();

         


        }
        #endregion
        #region "Refrish Grid Functions"
        private void RefreshGrid(string SearchCriteria = "")
        {
            try
            {


                DataTable dt = default(DataTable);
                dt = MABL.BL.AppDataHelper.Get_AppFeedback(0, SearchCriteria);
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
                MAF_ID.Text = "0";



                Q_Date.Text = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
                Q_Module.SelectedIndex = 0;
                Q_BranchID.SelectedIndex = 0;
                Q_Title.Text = "";
                Q_Description.Text = "";
                Q_URL.Text = "";

                MDBSC_RowStatus.SelectedIndex = 0;
                Q_Priority.SelectedIndex = 0; 
                 
                MDBSC_RowCreatedByUserName.Text = SessionUserData.UserData.UserName;
              

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
                if (Q_BranchID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Select Site<br>";
                }

                if (Q_Date.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Invalid Feedback Date<br>";
                }

                if (Q_Module.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Select Module<br>";
                }

                if (Q_Title.Text.Length == 0)
                {
                    ErrorMessage = ErrorMessage + "Title Cannot Be Blank<br>";
                }


                if (MDBSC_RowStatus.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Select Feedback Status<br>";
                }

                if (Q_Priority.SelectedIndex== 0)
                {
                    ErrorMessage = ErrorMessage + "Select Priority<br>";
                }
                if (Q_Description.Text.Length== 0)
                {
                    ErrorMessage = ErrorMessage + "Description Cannto Be Blank<br>";
                }
                if (Q_URL.Text.Length== 0)
                {
                    ErrorMessage = ErrorMessage + "URL Cannot Be Blank<br>";
                }
               

                


                if (ErrorMessage.Length == 0)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (Convert.ToInt32(MAF_ID.Text) == 0)
                        {
                            ObjAT_MAF.UserID = SessionUserData.UserData.UserID;
                            ObjAT_MAF.Q_Date = Q_Date.Text;
                            ObjAT_MAF.MDBSC_RowCreatedByUser_ID = SessionUserData.UserData.UserID;
                            ObjAT_MAF.MDBSC_RowCreatedByUserName = SessionUserData.UserData.UserName; 
                        }
                        SetValuesToBO();
                        ErrorMessage = ObjAT_MAF.Insert_Update(ObjAT_MAF);
                        MAF_ID.Text = ErrorMessage.Substring((ErrorMessage.IndexOf("|") + 1), (ErrorMessage.Length - ErrorMessage.IndexOf("|") - 1));
                        ErrorMessage = ErrorMessage.Substring((0), (ErrorMessage.IndexOf("|")));
                        scope.Complete();
                    }
                     
                    SetValueToControls_Edit(Convert.ToInt64(MAF_ID.Text));
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



                ObjAT_MAF.MAF_ID = Convert.ToInt64(0 + MAF_ID.Text); 
                ObjAT_MAF.Q_Module = Q_Module.Text;
                ObjAT_MAF.Q_BranchID = Convert.ToInt64(0 + Q_BranchID.Text);  
                ObjAT_MAF.Q_Title = Q_Title.Text;
                ObjAT_MAF.Q_Description = Q_Description.Text;
                ObjAT_MAF.Q_URL = Q_URL.Text;
                ObjAT_MAF.Q_Priority = Q_Priority.Text;
               
                ObjAT_MAF.MDBSC_RowStatus = MDBSC_RowStatus.Text;


                ObjAT_MAF.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
                ObjAT_MAF.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
                ObjAT_MAF.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
                 
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
                dt = MABL.BL.AppDataHelper.Get_AppFeedback(strPK, "");
                InitializeControls();
                if (dt.Rows.Count > 0)
                {

                    MAF_ID.Text = dt.Rows[0]["MAF_ID"].ToString(); 
                    MAF_ID.Text = dt.Rows[0]["MAF_ID"].ToString();
                    Q_Priority.Text = dt.Rows[0]["Q_Priority"].ToString();
                    Q_Date.Text = dt.Rows[0]["vQ_Date"].ToString();
                    Q_Module.Text = dt.Rows[0]["Q_Module"].ToString();
                    Q_BranchID.Text = dt.Rows[0]["Q_BranchID"].ToString();
                    Q_Title.Text = dt.Rows[0]["Q_Title"].ToString();
                    Q_Description.Text = dt.Rows[0]["Q_Description"].ToString();
                    Q_URL.Text = dt.Rows[0]["Q_URL"].ToString(); 
                    MDBSC_RowStatus.Text = dt.Rows[0]["MDBSC_RowStatus"].ToString(); 
                    MDBSC_RowCreatedByUserName.Text = dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString(); 
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
        protected void btnETE_Click(object sender, System.EventArgs e)
        {
            try
            {

                ExportToExcel();

            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary("Failed To Generate Report Data");
            }

        }
        #endregion
        #region "SelectedIndexChanged"
       
        #endregion
        #region 'Print'

        #endregion
        #region "Function"
       
        private void ExportToExcel()
        {
            try
            {
                gvList_Export.DataSource = null;
                gvList_Export.DataBind();


                string CurrDateTime = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now)) +
                                      "_" + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString();

                Response.ClearContent();
                Response.Buffer = true;

                Response.AddHeader("content-disposition", string.Format("attachment; filename={0}", "Feedback_" + CurrDateTime + ".xls"));
                Response.ContentType = "application/ms-excel";

                Response.Cache.SetCacheability(HttpCacheability.NoCache);


                StringWriter sw = new StringWriter();
                HtmlTextWriter htw = new HtmlTextWriter(sw);

                string SearchCriteria = "";
                SearchCriteria = ddSearchBy.Text + "|" + ddOperator.Text + (searchvalue.Text.Length > 0 ? "|" : "") + searchvalue.Text;
                DataTable dt = default(DataTable);
                dt = MABL.BL.AppDataHelper.Get_AppFeedback(0, SearchCriteria);
                if (dt.Rows.Count > 0)
                {
                    gvList_Export.DataSource = dt;
                    gvList_Export.DataBind();
                }
                else
                {
                    gvList_Export.DataSource = null;
                    gvList_Export.DataBind();
                }



                gvList_Export.RenderControl(htw);
                Response.Write(sw.ToString());
                Response.End();

                gvList_Export.DataSource = null;
                gvList_Export.DataBind();





            }
            catch (Exception ex)
            {
            }
        }
        #endregion
    }
}