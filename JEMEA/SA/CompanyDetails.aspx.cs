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

namespace JEMEA.SA
{
    public partial class CompanyDetails : Mahesh_Page
    {
        AAA_M_RT_CMP_BranchBO Obj_RT_Branch;
        protected void Page_Load(object sender, EventArgs e)
        {
            PageMenuID = Request.QueryString["ID"];
            Obj_RT_Branch = new AAA_M_RT_CMP_BranchBO();
            Page.Form.Attributes.Add("enctype", "multipart/form-data");
            SetControlType();
            if (!IsPostBack)
            {
            
                FillDropdown();
                InitializeControls();
                SetValueToControls_Edit(SessionUserData.Company.BranchID);
                 
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

                SetValueType(TextType.NumericField, BR_Reg_Pincode);
                SetValueType(TextType.NumericField, BR_Consignee_Pincode);
             
                
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
            DataTable dt = new DataTable();
            dt = MaheshAF18.Utility.M_DropDownList.Fill_Drop_Down_List("v_AAA_M_RT_GEO_State", "GStateID", "vStateDisplayName", "  ", "", "State", 0, "N", "");
            BR_Reg_State_ID.DataSource = dt;
            BR_Reg_State_ID.DataBind();

            BR_Consignee_State_ID.DataSource = dt;
            BR_Consignee_State_ID.DataBind();
            BR_RegType.DataSource = MABL.APPDT.MADD.DT_Taxpayer_Type("", "", "Taxpayer Type");
            BR_RegType.DataBind();

            
        }
        #endregion
        #region "Refrish Grid Functions"
        private void RefreshGrid(string SearchCriteria = "")
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
      
        

        #endregion
        #region "Grid Function"

        #endregion
        #region "InitializeControls"
        private void InitializeControls()
        {
            try
            {
                M_RT_CMP_BR_ID.Text = "0";

                BR_BankName.Text = "";
                BR_AccountHolderName.Text = "";
                BR_IFSCNo.Text = "";
                BR_AccountNo.Text = "";
                BR_BankBranch.Text = "";
                

                MDBSC_BR_Name.Text = "";
                BR_RegType.SelectedIndex = 0;
                MDBSC_BR_Perfix.Text = "";
                MDBSC_BR_Print_HeaderTxt.Text = "";
                MDBSC_BR_Print_Rpt_Default_Declaration.Text = "";
                BR_Reg_State_ID.SelectedIndex = 0;
                BR_Consignee_GSTNO.Text = "";
                BR_Consignee_ARNNO.Text = "";
                BR_Consignee_PANNO.Text = "";
                BL_ARNNO.Text = "";

                BR_Reg_Add1.Text = "";
                BR_Reg_Add2.Text = "";
                BR_Reg_Add3.Text = "";


                BR_Primary_Contact_Designation.Text = "";
                BR_Primary_Contact_Person.Text = "";
                BR_Primary_CP_PhoneNo.Text = "";
                BR_Primary_CP_MobileNo.Text = "";

                BR_Primary_CP_EmailID.Text = "";

                BR_Contact_OfficeNo1.Text = "";
                BR_Contact_OfficeNo2.Text = "";

                BR_Contact_FaxNo.Text = "";
                BR_Contact_Email_Admin.Text = "";

                BR_Consignee_State_ID.SelectedIndex = 0;
                 



                BR_Reg_Country.Text = "";
               
                BR_Reg_City.Text = "";

                BR_Reg_Pincode.Text = "";
              
                BL_PANNO.Text = "";
                 
                 
                BR_Consignee_Contact_Person.Text = "";
                BR_Consignee_CP_MobileNo.Text = "";

                BR_Buyer_Contact_Person.Text = "";
                BR_Buyer_CP_MobileNo.Text = "";
 
               

              
                BL_GSTNO.Text = "";
                BR_Consignee_Add1.Text = "";
                BR_Consignee_Add2.Text = "";
                BR_Consignee_Add3.Text = "";

                BR_Consignee_PhoneNo1.Text = "";
                BR_Consignee_PhoneNo2.Text = "";
                BR_Consignee_FaxNo.Text = "";
                BR_Consignee_EmailID.Text = "";
                BR_Consignee_Country.Text = "";
            
                BR_Consignee_City.Text = "";

                BR_Consignee_Pincode.Text = "";

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
                if (BR_RegType.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Pls Taxpayer Type<br>";
                }
                
                
                
                if (BR_Reg_State_ID.SelectedIndex == 0)
                {
                    ErrorMessage = ErrorMessage + "Please select state<br>";
                }

                if (ErrorMessage.Length == 0)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {

                        SetValuesToBO();
                        ErrorMessage = Obj_RT_Branch.Insert_Update(Obj_RT_Branch);
                        M_RT_CMP_BR_ID.Text = ErrorMessage.Substring((ErrorMessage.IndexOf("|") + 1), (ErrorMessage.Length - ErrorMessage.IndexOf("|") - 1));
                        ErrorMessage = ErrorMessage.Substring((0), (ErrorMessage.IndexOf("|")));
                        scope.Complete();
                    }

                    SetValueToControls_Edit(Convert.ToInt64(M_RT_CMP_BR_ID.Text));
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
                Obj_RT_Branch.M_RT_CMP_BR_ID = Convert.ToByte(0 + M_RT_CMP_BR_ID.Text);
                Obj_RT_Branch.BR_Reg_State_ID = Convert.ToInt16(0 + BR_Reg_State_ID.Text);
                Obj_RT_Branch.BR_Consignee_State_ID = Convert.ToInt16(0 + BR_Consignee_State_ID.Text);

                Obj_RT_Branch.MDBSC_BR_Name = MDBSC_BR_Name.Text;
                Obj_RT_Branch.MDBSC_BR_Print_HeaderTxt = MDBSC_BR_Print_HeaderTxt.Text;
                Obj_RT_Branch.MDBSC_BR_Print_Rpt_Default_Declaration = MDBSC_BR_Print_Rpt_Default_Declaration.Text;
                Obj_RT_Branch.BR_RegType = BR_RegType.Text;
                
                Obj_RT_Branch.BR_Reg_Add1 = BR_Reg_Add1.Text;
                Obj_RT_Branch.BR_Reg_Add2 = BR_Reg_Add2.Text;
                Obj_RT_Branch.BR_Reg_Add3 = BR_Reg_Add3.Text;
                Obj_RT_Branch.BR_Reg_Add4 = "";

                Obj_RT_Branch.BR_Primary_Contact_Designation = BR_Primary_Contact_Designation.Text;
                Obj_RT_Branch.BR_Primary_Contact_Person = BR_Primary_Contact_Person.Text;
                Obj_RT_Branch.BR_Primary_CP_PhoneNo = BR_Primary_CP_PhoneNo.Text;
                Obj_RT_Branch.BR_Primary_CP_MobileNo = BR_Primary_CP_MobileNo.Text;
                Obj_RT_Branch.BR_Primary_CP_EmailID = BR_Primary_CP_EmailID.Text;
                Obj_RT_Branch.BR_Contact_OfficeNo1 = BR_Contact_OfficeNo1.Text;
                Obj_RT_Branch.BR_Contact_OfficeNo2 = BR_Contact_OfficeNo2.Text;
                Obj_RT_Branch.BR_Contact_FaxNo = BR_Contact_FaxNo.Text;
                Obj_RT_Branch.BR_Contact_Email_Admin = BR_Contact_Email_Admin.Text;
                 
                  

                Obj_RT_Branch.BR_Reg_Country = BR_Reg_Country.Text;
                 
                Obj_RT_Branch.BR_Reg_City = BR_Reg_City.Text;

                Obj_RT_Branch.BR_Consignee_Add1 = BR_Consignee_Add1.Text;
                Obj_RT_Branch.BR_Consignee_Add2 = BR_Consignee_Add2.Text;
                Obj_RT_Branch.BR_Consignee_Add3 = BR_Consignee_Add3.Text;

                Obj_RT_Branch.BR_Consignee_PhoneNo1 = BR_Consignee_PhoneNo1.Text;
                Obj_RT_Branch.BR_Consignee_PhoneNo2 = BR_Consignee_PhoneNo2.Text;
                Obj_RT_Branch.BR_Consignee_FaxNo = BR_Consignee_FaxNo.Text;
                Obj_RT_Branch.BR_Consignee_EmailID = BR_Consignee_EmailID.Text;
                Obj_RT_Branch.BR_Consignee_Country = BR_Consignee_Country.Text;
                 
                Obj_RT_Branch.BR_Consignee_City = BR_Consignee_City.Text;

                Obj_RT_Branch.BR_Consignee_Pincode = BR_Consignee_Pincode.Text;

                Obj_RT_Branch.BR_Reg_Pincode = BR_Reg_Pincode.Text;
               
                Obj_RT_Branch.BL_PANNO = BL_PANNO.Text;

             
                Obj_RT_Branch.BL_GSTNO = BL_GSTNO.Text;

                Obj_RT_Branch.BR_BankName = BR_BankName.Text;
                Obj_RT_Branch.BR_AccountHolderName = BR_AccountHolderName.Text;
                Obj_RT_Branch.BR_IFSCNo = BR_IFSCNo.Text;
                Obj_RT_Branch.BR_AccountNo = BR_AccountNo.Text;
                Obj_RT_Branch.BR_BankBranch = BR_BankBranch.Text;
                
                 
                 
                Obj_RT_Branch.BR_Consignee_Contact_Person = BR_Consignee_Contact_Person.Text;
                Obj_RT_Branch.BR_Consignee_CP_MobileNo = BR_Consignee_CP_MobileNo.Text;

                Obj_RT_Branch.BR_Buyer_Contact_Person = BR_Buyer_Contact_Person.Text;
                Obj_RT_Branch.BR_Buyer_CP_MobileNo = BR_Buyer_CP_MobileNo.Text;


                Obj_RT_Branch.BR_Consignee_GSTNO = BR_Consignee_GSTNO.Text;
                Obj_RT_Branch.BR_Consignee_ARNNO = BR_Consignee_ARNNO.Text;
                Obj_RT_Branch.BR_Consignee_PANNO = BR_Consignee_PANNO.Text;
                Obj_RT_Branch.BL_ARNNO = BL_ARNNO.Text;

               

                Obj_RT_Branch.MDBSC_RowLupdnByUser_ID = SessionUserData.UserData.UserID;
                Obj_RT_Branch.MDBSC_RowLupdnUserName = SessionUserData.UserData.UserName;
                Obj_RT_Branch.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));


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
                dt =MABL.BL.AppBL.Get_App_Branch_List(strPK, "");
                InitializeControls();
                if (dt.Rows.Count > 0)
                {
                    M_RT_CMP_BR_ID.Text = dt.Rows[0]["M_RT_CMP_BR_ID"].ToString();
                    BR_RegType.Text = dt.Rows[0]["BR_RegType"].ToString();
                   
                    MDBSC_BR_Name.Text = dt.Rows[0]["MDBSC_BR_Name"].ToString();
                    MDBSC_BR_Perfix.Text = dt.Rows[0]["MDBSC_BR_Perfix"].ToString();
                    MDBSC_BR_Print_HeaderTxt.Text = dt.Rows[0]["MDBSC_BR_Print_HeaderTxt"].ToString();
                    MDBSC_BR_Print_Rpt_Default_Declaration.Text = dt.Rows[0]["MDBSC_BR_Print_Rpt_Default_Declaration"].ToString();
                    BR_Reg_Add1.Text = dt.Rows[0]["BR_Reg_Add1"].ToString();
                    BR_Reg_Add2.Text = dt.Rows[0]["BR_Reg_Add2"].ToString();
                    BR_Reg_Add3.Text = dt.Rows[0]["BR_Reg_Add3"].ToString();
                    BR_Primary_Contact_Designation.Text = dt.Rows[0]["BR_Primary_Contact_Designation"].ToString();
                    BR_Primary_Contact_Person.Text = dt.Rows[0]["BR_Primary_Contact_Person"].ToString();
                    BR_Primary_CP_PhoneNo.Text = dt.Rows[0]["BR_Primary_CP_PhoneNo"].ToString();
                    BR_Primary_CP_MobileNo.Text = dt.Rows[0]["BR_Primary_CP_MobileNo"].ToString();
                    BR_Primary_CP_EmailID.Text = dt.Rows[0]["BR_Primary_CP_EmailID"].ToString();
                    BR_Contact_OfficeNo1.Text = dt.Rows[0]["BR_Contact_OfficeNo1"].ToString();
                    BR_Contact_OfficeNo2.Text = dt.Rows[0]["BR_Contact_OfficeNo2"].ToString();
                    BR_Contact_FaxNo.Text = dt.Rows[0]["BR_Contact_FaxNo"].ToString();
                    BR_Contact_Email_Admin.Text = dt.Rows[0]["BR_Contact_Email_Admin"].ToString();

                    BR_BankName.Text = dt.Rows[0]["BR_BankName"].ToString();
                    BR_AccountHolderName.Text = dt.Rows[0]["BR_AccountHolderName"].ToString();
                    BR_IFSCNo.Text = dt.Rows[0]["BR_IFSCNo"].ToString();

                    BR_AccountNo.Text = dt.Rows[0]["BR_AccountNo"].ToString();
                    BR_BankBranch.Text = dt.Rows[0]["BR_BankBranch"].ToString();
                    

                    BR_Reg_State_ID.Text = dt.Rows[0]["BR_Reg_State_ID"].ToString();
                    BR_Consignee_State_ID.Text = dt.Rows[0]["BR_Consignee_State_ID"].ToString();
 
                     
                    BR_Consignee_Contact_Person.Text = dt.Rows[0]["BR_Consignee_Contact_Person"].ToString();
                    BR_Consignee_CP_MobileNo.Text = dt.Rows[0]["BR_Consignee_CP_MobileNo"].ToString();

                    BR_Buyer_Contact_Person.Text = dt.Rows[0]["BR_Buyer_Contact_Person"].ToString();
                    BR_Buyer_CP_MobileNo.Text = dt.Rows[0]["BR_Buyer_CP_MobileNo"].ToString();

                    BR_Reg_Country.Text = dt.Rows[0]["BR_Reg_Country"].ToString();
                   
                    BR_Reg_City.Text = dt.Rows[0]["BR_Reg_City"].ToString();
                    BR_Reg_Pincode.Text = dt.Rows[0]["BR_Reg_Pincode"].ToString();
                  
                    BL_PANNO.Text = dt.Rows[0]["BL_PANNO"].ToString();
                   
                    BL_GSTNO.Text = dt.Rows[0]["BL_GSTNO"].ToString();

                    BR_Consignee_Add1.Text = dt.Rows[0]["BR_Consignee_Add1"].ToString();
                    BR_Consignee_Add2.Text = dt.Rows[0]["BR_Consignee_Add2"].ToString();
                    BR_Consignee_Add3.Text = dt.Rows[0]["BR_Consignee_Add3"].ToString();

                    BR_Consignee_PhoneNo1.Text = dt.Rows[0]["BR_Consignee_PhoneNo1"].ToString();
                    BR_Consignee_PhoneNo2.Text = dt.Rows[0]["BR_Consignee_PhoneNo2"].ToString();
                    BR_Consignee_FaxNo.Text = dt.Rows[0]["BR_Consignee_FaxNo"].ToString();
                    BR_Consignee_EmailID.Text = dt.Rows[0]["BR_Consignee_EmailID"].ToString();
                    BR_Consignee_Country.Text = dt.Rows[0]["BR_Consignee_Country"].ToString();
                   
                    BR_Consignee_City.Text = dt.Rows[0]["BR_Consignee_City"].ToString();

                    BR_Consignee_Pincode.Text = dt.Rows[0]["BR_Consignee_Pincode"].ToString();

                    BR_Consignee_GSTNO.Text = dt.Rows[0]["BR_Consignee_GSTNO"].ToString();
                    BR_Consignee_ARNNO.Text = dt.Rows[0]["BR_Consignee_ARNNO"].ToString();
                    BR_Consignee_PANNO.Text = dt.Rows[0]["BR_Consignee_PANNO"].ToString();
                    BL_ARNNO.Text = dt.Rows[0]["BL_ARNNO"].ToString();

                    Set_File_Lnk();

               

                }

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
        protected void btnRefreshPageOnFileUpload_Click(object sender, System.EventArgs e)
        {
            try
            {
                Set_File_Lnk();
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
        private void Set_File_Lnk()
        {
            try
            {
                string strPath_DB = "";
                DataTable dt_File = new DataTable();
                dt_File = MaheshAF18.Application.MEF.DA_GetDataTable("SELECT * from AAA_M_RT_CMP_Branch WHERE M_RT_CMP_BR_ID=" + M_RT_CMP_BR_ID.Text);
                if (dt_File.Rows.Count > 0)
                {
                    strPath_DB = dt_File.Rows[0]["BL_Logo_Url"].ToString();
                    if (File.Exists(Server.MapPath(strPath_DB)))
                    {
                        HLnk_CF_CMPLogo.Attributes.Add("href", strPath_DB.Replace("~", ".."));
                        HLnk_CF_CMPLogo.Attributes.Add("target", "_blank");
                        HLnk_CF_CMPLogo.InnerHtml = "Click To Download/View File";
                    }
                    else
                    {
                        HLnk_CF_CMPLogo.InnerHtml = "No File Avaliable To Download/View";

                    }
 

                }
                else
                {
                    HLnk_CF_CMPLogo.InnerHtml = "No File Avaliable To Download/View";
                  
                }




            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region "Upload"
        protected void CF_CMPLogo_FileUpload(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
        {
            if (Convert.ToInt64(M_RT_CMP_BR_ID.Text) > 0)
            {
              //  System.Threading.Thread.Sleep(200);
                if (CF_CMPLogo_Upload.HasFile)
                {
                    string strPath_DB = MABL.BL.AppVariable.Customer_Document_Location("SETUP") + "/" + M_RT_CMP_BR_ID.Text + "_Logo" + Path.GetExtension(e.FileName);
                    string strPath = MapPath(strPath_DB);
                    CF_CMPLogo_Upload.SaveAs(strPath);
                    MaheshAF18.Application.MEF.DA_ExecuteQuery("UPDATE AAA_M_RT_CMP_Branch  SET  BL_Logo_Url='" + strPath_DB + "' WHERE M_RT_CMP_BR_ID=" + M_RT_CMP_BR_ID.Text);
                }
            }
            else
            {
                DisplayCustomMessageSummary("Failed to update logo pls try again");
            }

        }
        #endregion
      
    }
}