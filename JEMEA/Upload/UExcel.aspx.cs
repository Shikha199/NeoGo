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
using System.Data.OleDb;

namespace JEMEA.Upload
{
    public partial class UExcel : Mahesh_Page
    {
        M_AT_Upload_File_BDTLBO ObjBOAT_FUDTL;
        protected void Page_Load(object sender, EventArgs e)
        {

            PageMenuID = Request.QueryString["ID"];
            ObjBOAT_FUDTL = new M_AT_Upload_File_BDTLBO();
            SetControlType();
            if (!IsPostBack)
            {

               
                FillDropdown();
                InitializeControls();
                RefreshGrid();
               
            }
        }
        #region "Search"
      
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
        
        }
        #endregion
        #region "Refrish Grid Functions"
        private void RefreshGrid(string SearchCriteria = "")
        {
            try
            {
                DataTable dt = default(DataTable);
                dt = MABL.BL.AppDataModal.Get_Excel_File_Column_List(0, " AND GSTIN='" + GSTIN.Text + "'", SearchCriteria);
                if (dt.Rows.Count > 0)
                {
                    gv_UserColumn.DataSource = dt;
                    gv_UserColumn.DataBind();
                    if (dt.Rows.Count < 50)
                    {
                        Msg_RCNT_User.Text = "Showing " + dt.Rows.Count + " Records  ";
                    }
                    else
                    {
                        Msg_RCNT_User.Text = "Showing 50 Of " + dt.Rows.Count + " Records  ";
                    }
                }
                else
                {
                    gv_UserColumn.DataSource = null;
                    gv_UserColumn.DataBind();
                    Msg_RCNT_User.Text = " No Records Found";
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
        protected void btnExtractColumn_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (GSTIN.Text.Length != 15)
                {
                    ErrorMessage = ErrorMessage + "Invalid GSTIN No<br>";
                }
                if (ErrorMessage.Length == 0)
                {
                    Set_UserFileLink();
                    ExtractExcel_Column();
                }
                else
                {
                    DisplayCustomMessageSummary(ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary("Server Error");
            }

        }
        protected void btnUpdateColumnMapping_Click(object sender, System.EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary("Server Error");
            }

        }
        #endregion
        #region "SetValue"
        private void SetValuesToBO()
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
        #region "EditValue"
        private void SetValueToControls_Edit(Int64 strPK)
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
        #region "Edit Click"
        
        #endregion
        #region "Delete"
        #endregion
        #region "Row Created"
        protected void gv_UserColumn_RowCreated(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
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
        protected void gv_UserColumn_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
               
                
            }
        }

        #endregion
        #region "Click Events"
        protected void btnRefreshPageOnFileUpload_Click(object sender, System.EventArgs e)
        {
            try
            {
                Set_UserFileLink();
            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary("Failed Save Data");
            }

        }
        #endregion
        #region "SelectedIndexChanged"
     
    
      
        #endregion
        #region 'Print'

        #endregion
        #region "Function"
        private void Set_UserFileLink()
        {
            try
            {
                string strPath_DB = "";
                DataTable dt_File = new DataTable();
                dt_File = MaheshAF18.Application.MEF.DA_GetDataTable("SELECT * from M_AT_Upload_File WHERE PartyID=" + SessionUserData.UserData.UserID);
                if (dt_File.Rows.Count > 0)
                {
                    strPath_DB = dt_File.Rows[0]["FilePath"].ToString();
                    if (File.Exists(Server.MapPath(strPath_DB)))
                    {
                        Hlnk_AF_UserExcel.Attributes.Add("href", strPath_DB.Replace("~", ".."));
                        Hlnk_AF_UserExcel.Attributes.Add("target", "_blank");
                        Hlnk_AF_UserExcel.InnerHtml = "Click To Download/View File";
                    }
                    else
                    {
                        Hlnk_AF_UserExcel.InnerHtml = "No File Avaliable To Download/View";

                    }


                  
                }
                else
                {
                    Hlnk_AF_UserExcel.InnerHtml = "No File Avaliable To Download/View";
                    
                }




            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        protected void ExtractExcel_Column()
        {
            try
            {


                string strPath_DB = "";
                string strFileExt = "";
                Int64 var_FileID = 0;
                Int64 var_ColumnCNT = 0;
                Int64 var_ProcessColumnCNT = 0;
                DataTable dt_File = new DataTable();
                dt_File = MaheshAF18.Application.MEF.DA_GetDataTable("SELECT * from M_AT_Upload_File WHERE GSTIN='" + GSTIN.Text +"'");
                if (dt_File.Rows.Count > 0)
                {
                    strPath_DB = dt_File.Rows[0]["FilePath"].ToString();
                    strFileExt = dt_File.Rows[0]["FileExt"].ToString();
                    var_FileID = Convert.ToInt64(dt_File.Rows[0]["FU_ID"].ToString());
                    if (File.Exists(Server.MapPath(strPath_DB)))
                    {
                        DataSet dsSourceDataSet = new DataSet();
                        dsSourceDataSet = GetExcelWorkSheet(strPath_DB, strFileExt, 0);
                        DataTable dtSourceTable = new DataTable();
                        dtSourceTable = dsSourceDataSet.Tables[0];
                        if (dtSourceTable.Rows.Count > 0)
                        {
                            var_ColumnCNT = dtSourceTable.Columns.Count;
                            foreach (DataColumn column in dtSourceTable.Columns)
                            {
                                ObjBOAT_FUDTL = new M_AT_Upload_File_BDTLBO();
                                ObjBOAT_FUDTL.FUDTL_ID = 0;
                                ObjBOAT_FUDTL.Fk_FU_ID = var_FileID;
                                ObjBOAT_FUDTL.FU_UserColumn = column.ColumnName;
                                ErrorMessage = ObjBOAT_FUDTL.Insert_Update(ObjBOAT_FUDTL);
                                var_ProcessColumnCNT = var_ProcessColumnCNT + 1;
                            }
                       

                        }
                        DisplayCustomMessageSummary("Extracted " + var_ProcessColumnCNT + " Column Successfully");


                    }
                    else
                    {

                        DisplayCustomMessageSummary("Excel File Not Found");
                    }



                }
                else
                {
                    DisplayCustomMessageSummary("Excel File Not Found");

                }




                Set_UserFileLink();
                 
               

            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary("Failed Save Data");
            }

        }
        private DataSet GetExcelWorkSheet(string FilePath, string FileExt, int workSheetNumber)
        {
            DataSet ExcelDataSet = new DataSet();
            try
            {

                string Var_ExcelConStr = "";
                if (FileExt == ".xls")
                {
                    Var_ExcelConStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath(FilePath) + ";Extended Properties=Excel 8.0;";
                    Var_ExcelConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath(FilePath) + ";Extended Properties=Excel 12.0;";

                }
                else if (FileExt == ".xlsx")
                {
                    Var_ExcelConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath(FilePath) + ";Extended Properties=Excel 12.0;";

                }

                System.Data.OleDb.OleDbConnection ExcelConnection = new OleDbConnection(Var_ExcelConStr);
                System.Data.OleDb.OleDbCommand ExcelCommand = new System.Data.OleDb.OleDbCommand();
                ExcelCommand.Connection = ExcelConnection;
                OleDbDataAdapter ExcelAdapter = new OleDbDataAdapter(ExcelCommand);
                ExcelConnection.Open();
                DataTable ExcelSheets = ExcelConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                string SpreadSheetName = "[" + ExcelSheets.Rows[workSheetNumber]["TABLE_NAME"].ToString() + "]";
                ExcelCommand.CommandText = "SELECT * FROM " + SpreadSheetName + "";
                ExcelAdapter.Fill(ExcelDataSet);
                ExcelConnection.Close();
                return ExcelDataSet;
            }

            catch (Exception ex)
            {

                DisplayCustomMessageSummary(ex.Message);
                return ExcelDataSet;
            }

        }
        #endregion
        #region "Active Tab Changed"
        protected void On_Active_Tab_Changed(object sender, System.EventArgs e)
        {
            try
            {
                if (M_ATab_C.ActiveTabIndex == 0)
                {

                }
                if (M_ATab_C.ActiveTabIndex == 1)
                {
                    if (GSTIN.Text.Length != 15)
                    {
                        M_ATab_C.ActiveTabIndex = 0;
                        DisplayCustomMessageSummary("In Valid GSTIN No");
                    }
                    else
                    {
                        lblGSTIN.Text = "";
                        lblGSTIN.Text = "GSTIN : " + GSTIN.Text;
                        RefreshGrid();
                    }
                    
                }

              
                 
            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary("Failed Save Data");
            }

        }
        #endregion
          
        #region "Upload"
        protected void AF_UserExcel_FileUpload(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
        {

            if (GSTIN.Text.Length == 15)
            {
                System.Threading.Thread.Sleep(1000);
                if (AF_UserExcel_Upload.HasFile)
                {
                    string strFileExt = Path.GetExtension(e.FileName);
                    string strFileName = MaheshAF18.Utility.DateHelper.DateYearPrefix("YYMMDD") + "" + Path.GetExtension(e.FileName);
                    string strPath_DB = MABL.BL.AppVariable.Customer_Document_Location("UExcel") + "/" + strFileName;
                    string strPath = MapPath(strPath_DB);
                    AF_UserExcel_Upload.SaveAs(strPath);
                    string varSQL = " TRUNCATE TABLE  M_AT_Upload_File " +
                                    " TRUNCATE TABLE  M_AT_Upload_File_BDTL " +
                                    " INSERT INTO M_AT_Upload_File " +
                                    " (GSTIN,UserFileName,FileExt,FilePath) " +
                                    " SELECT '" + GSTIN.Text + "','" + strFileName + "','" + strFileExt + "','" + strPath_DB + "'";
                    MaheshAF18.Application.MEF.DA_ExecuteQuery(varSQL);


                }
            }
            

        }
        #endregion

    }
}