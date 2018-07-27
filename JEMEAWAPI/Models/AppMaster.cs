using JEMEAWAPI.APIDL;
using MABL.ATDataModal;
using MaheshAF18.Application;
using MaheshAF18.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Transactions;
using System.Web;

namespace JEMEAWAPI.Models
{
    public class AppMaster
    {
        
        //ITEM MASTER
        //List
        public static ArrayList Get_Mst_Item_Lst(Int64 MItem_ID, string StrFilterCriteria, string SearchCriteria)
        { 
            ArrayList items = new ArrayList();
            DataTable dt = new DataTable();
            try
            {
                dt = AppData.Get_DT_Mst_Item(MItem_ID, StrFilterCriteria, SearchCriteria);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        var objList = new Dictionary<object, object>();
                        objList["MItem_ID"] = row["MItem_ID"];
                        objList["Item_Type"] = row["Item_Type"];
                        objList["Item_Code"] = row["Item_Code"];
                        objList["Item_Name"] = row["Item_Name"];
                        objList["Fk_UOM_ID"] = row["Fk_UOM_ID"];
                        objList["UOM"] = row["UOM"];
                        objList["MDBSC_RowStatus"] = row["MDBSC_RowStatus"];
                        objList["Item_Desc"] = row["Item_Desc"];
                        objList["Fk_HSN_ID"] = row["Fk_HSN_ID"];
                        objList["HSNCode"] = row["HSNCode"];
                        objList["HSN_Desc"] = row["HSN_Desc"];
                        objList["Item_Tax_GST_ID"] = row["Item_Tax_GST_ID"];
                        objList["Tax_Rate"] = row["Tax_Rate"];                        
                        objList["Item_Tax_GST_Effective_From"] = row["vItem_Tax_GST_Effective_From"];
                        objList["Item_CGST_Rate"] = row["Item_CGST_Rate"];
                        objList["Item_SGST_Rate"] = row["Item_SGST_Rate"];
                        objList["Item_IGST_Rate"] = row["Item_IGST_Rate"];
                        objList["Item_CESS_Rate"] = row["Item_CESS_Rate"];
                        objList["Item_Selling_Rate"] = row["Item_Selling_Rate"];
                        objList["Item_Purchase_Rate"] = row["Item_Purchase_Rate"];

                        items.Add(objList);
                    }
                    
                }
                else
                {
                    items = null;
                }
                return items;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //SAVE
        public static string CU_Mst_Item(M_AT_Mst_ItemMasterBO ObjItem)
        {
            M_AT_Mst_ItemMasterBO ObjBOAT_Item = new M_AT_Mst_ItemMasterBO();
            string strRetMst = "";
            DataTable dt = new DataTable();
            string var_ErrorMessage = "";
            try
            { 
               
                if (ObjItem.Item_Name.Length == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Item Name Cannot Be Blank \n";
                }

                if (SQLManager.CheckDuplicateRecord("M_AT_Mst_ItemMaster", "MItem_ID", Convert.ToInt32("0" + ObjItem.MItem_ID), "Item_Name", ObjItem.Item_Name,
                                                    " AND  Fk_Company_ID=" + ObjItem.Fk_Company_ID + " AND  Fk_Branch_ID=" + ObjItem.Fk_Branch_ID))
                {
                    var_ErrorMessage = var_ErrorMessage + "Item Already Exist. \n";
                }
                if (SQLManager.CheckDuplicateRecord("M_AT_Mst_ItemMaster", "MItem_ID", Convert.ToInt32("0" + ObjItem.MItem_ID), "HSNCode", ObjItem.HSNCode,
                                                    " AND  Fk_Company_ID=" + ObjItem.Fk_Company_ID + " AND  Fk_Branch_ID=" + ObjItem.Fk_Branch_ID))
                {
                    var_ErrorMessage = var_ErrorMessage + "Item Already Exist. \n";
                }
                if (ObjItem.Fk_UOM_ID <= 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Select Unit Of Measurment \n";
                }

                if (ObjItem.Item_Tax_GST_ID <= 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Select Integrated Tax Rate\n";
                }

                if (ObjItem.Item_Tax_GST_Effective_From.Length != 11)
                {
                    var_ErrorMessage = var_ErrorMessage + "Invalid Integrated Tax Rate Effective From Date\n";
                }

                if (ObjItem.Item_Code.Length == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Invalid Item Code \n";
                }

                if (var_ErrorMessage.Length == 0)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (Convert.ToInt32(ObjItem.MItem_ID) == 0)
                        {
                            ObjBOAT_Item.Fk_Company_ID = ObjItem.Fk_Company_ID;
                            ObjBOAT_Item.Fk_Branch_ID = ObjItem.Fk_Branch_ID;
                            ObjBOAT_Item.Fk_Year_ID = ObjItem.Fk_Year_ID;
                            ObjBOAT_Item.MDBSC_RowCreatedByUser_ID = ObjItem.MDBSC_RowCreatedByUser_ID;
                            ObjBOAT_Item.MDBSC_RowCreatedByUserName = ObjItem.MDBSC_RowCreatedByUserName;
                            ObjBOAT_Item.Item_SRNO = 0;
                            ObjBOAT_Item.Fk_MIC_ID = 1;
                            ObjBOAT_Item.Fk_IG_ID = 1;
                            ObjBOAT_Item.Fk_ISG_ID = 1;
                            ObjBOAT_Item.Item_Code = MEF.GenrateRefNo(ObjItem.Fk_Company_ID, ObjItem.Fk_Branch_ID, 0, "Item", "I-", "I-", "No", "", "", "", 0);

                        }


                        ObjBOAT_Item.MItem_ID = ObjItem.MItem_ID;
                        ObjBOAT_Item.Item_Type = ObjItem.Item_Type;
                        ObjBOAT_Item.Fk_UOM_ID = ObjItem.Fk_UOM_ID;
                        ObjBOAT_Item.Item_Name = ObjItem.Item_Name;
                        ObjBOAT_Item.HSNCode = ObjItem.HSNCode;
                        ObjBOAT_Item.Fk_HSN_ID = ObjItem.Fk_HSN_ID;
                        ObjBOAT_Item.HSN_Desc = ObjItem.HSN_Desc;
                        ObjBOAT_Item.Item_Tax_GST_ID = ObjItem.Item_Tax_GST_ID;
                        //decimal var_Tax_GST_Rate = Convert.ToDecimal(Item_Tax_GST_ID.SelectedItem.Text);
                        //decimal var_Tax_SGST_Rate = Math.Round((var_Tax_GST_Rate / 2), 2);
                        ObjBOAT_Item.Item_CGST_Rate = ObjItem.Item_CGST_Rate;
                        ObjBOAT_Item.Item_SGST_Rate = ObjItem.Item_SGST_Rate;
                        ObjBOAT_Item.Item_IGST_Rate = ObjItem.Item_IGST_Rate;

                        if (ObjItem.Item_Tax_GST_Effective_From.Length == 11)
                        {
                            ObjBOAT_Item.Item_Tax_GST_Effective_From = ObjItem.Item_Tax_GST_Effective_From;
                        }

                        ObjBOAT_Item.Item_CESS_Rate = ObjItem.Item_CESS_Rate;
                        ObjBOAT_Item.Item_Tax_CESS_ID = ObjItem.Item_Tax_CESS_ID;
                        ObjBOAT_Item.Item_Selling_Rate = ObjItem.Item_Selling_Rate;
                        ObjBOAT_Item.Item_Purchase_Rate = ObjItem.Item_Purchase_Rate;
                        ObjBOAT_Item.Item_Desc = ObjItem.Item_Desc;
                        ObjBOAT_Item.MDBSC_RowStatus = ObjItem.MDBSC_RowStatus;
                        ObjBOAT_Item.MDBSC_RowLupdnByUser_ID = ObjItem.MDBSC_RowLupdnByUser_ID;
                        ObjBOAT_Item.MDBSC_RowLupdnUserName = ObjItem.MDBSC_RowLupdnUserName;
                        ObjBOAT_Item.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
                        var_ErrorMessage = ObjBOAT_Item.Insert_Update(ObjBOAT_Item); 
                        //ObjItem.MItem_ID =Convert.ToInt64( var_ErrorMessage.Substring((var_ErrorMessage.IndexOf("|") + 1), (var_ErrorMessage.Length - var_ErrorMessage.IndexOf("|") - 1)));
                        //var_ErrorMessage = var_ErrorMessage.Substring((0), (var_ErrorMessage.IndexOf("|")));
                        scope.Complete();
                    }
                    strRetMst = var_ErrorMessage;                    
                   
                }
                else
                {
                    strRetMst = var_ErrorMessage+"|" + ObjItem.MItem_ID.ToString();
                }


                return strRetMst;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //CUSTOMER MASTER
        public static ArrayList Get_Mst_Customer_Lst(Int64 mvCustomerID, string StrFilterCriteria, string SearchCriteria)
        {
            ArrayList items = new ArrayList();
            DataTable dt = new DataTable();
            try
            {
                dt = AppData.Get_DT_Mst_Customer(mvCustomerID, StrFilterCriteria, SearchCriteria);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        var objList = new Dictionary<object, object>();
                        objList["M_Cust_ID"] = row["M_Cust_ID"];
                        objList["MCust_Code"] = row["MCust_Code"];

                        objList["MCust_Name"] = row["MCust_Name"];
                        objList["MCust_DisplayName"] = row["MCust_DisplayName"];
                        objList["MCust_TradeName"] = row["MCust_TradeName"];
                        objList["MCust_RegType"] = row["MCust_RegType"];


                        objList["MCust_Reg_Add1"] = row["MCust_Reg_Add1"];
                        objList["MCust_Reg_Add2"] = row["MCust_Reg_Add2"];
                        objList["MCust_Reg_Pincode"] = row["MCust_Reg_Pincode"];
                        objList["MCust_Reg_City"] = row["MCust_Reg_City"];
                        objList["MCust_Reg_State_ID"] = row["MCust_Reg_State_ID"];
                        objList["MCust_Reg_Country"] = row["MCust_Reg_Country"];
                        objList["MCust_BL_PANNO"] = row["MCust_BL_PANNO"];
                        objList["MCust_BL_GSTNO"] = row["MCust_BL_GSTNO"];

                        objList["MCust_Primary_Contact_Person"] = row["MCust_Primary_Contact_Person"];
                        objList["MCust_Primary_CP_MobileNo"] = row["MCust_Primary_CP_MobileNo"];
                        objList["MCust_Primary_CP_PhoneNo"] = row["MCust_Primary_CP_PhoneNo"];
                        objList["MCust_Primary_CP_EmailID"] = row["MCust_Primary_CP_EmailID"];



                        objList["MCust_ShippTo_CompanyName"] = row["MCust_ShippTo_CompanyName"];
                        objList["MCust_ShippTo_ContactPerson"] = row["MCust_ShippTo_ContactPerson"];
                        objList["MCust_ShippTo_CP_MobileNo"] = row["MCust_ShippTo_CP_MobileNo"];


                        objList["MCust_ShippTo_Add1"] = row["MCust_ShippTo_Add1"];
                        objList["MCust_ShippTo_Add2"] = row["MCust_ShippTo_Add2"];

                        objList["MCust_ShippTo_Pincode"] = row["MCust_ShippTo_Pincode"];

                        objList["MCust_ShippTo_City"] = row["MCust_ShippTo_City"];
                        objList["MCust_ShippTo_State_ID"] = row["MCust_ShippTo_State_ID"];
                        objList["MCust_ShippTo_Country"] = row["MCust_ShippTo_Country"];
                        objList["MCust_ShippTo_PANNO"] = row["MCust_ShippTo_PANNO"];
                        objList["MCust_ShippTo_GSTNO"] = row["MCust_ShippTo_GSTNO"];

                        objList["MDBSC_RowStatus"] = row["MDBSC_RowStatus"];

                        objList["MCust_CreditDays"] = row["MCust_CreditDays"];

                        objList["MDBSC_RowLupdnByUser_ID"] = row["MDBSC_RowLupdnByUser_ID"];
                        objList["MDBSC_RowLupdnUserName"] = row["MDBSC_RowLupdnUserName"];


                        objList["MCust_Contact_FaxNo"] = row["MCust_Contact_FaxNo"];
                        objList["MCust_Contact_OfficeNo1"] = row["MCust_Contact_OfficeNo1"];
                        objList["MCust_Contact_OfficeNo2"] = row["MCust_Contact_OfficeNo2"];
                        objList["MCust_Contact_Email_Admin"] = row["MCust_Contact_Email_Admin"];
                        objList["MCust_Contact_Website"] = row["MCust_Contact_Website"];
                        objList["MCust_Primary_Contact_Designation"] = row["MCust_Primary_Contact_Designation"];


                        items.Add(objList);
                    }

                }
                else
                {
                    items = null;
                }
                return items;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //SAVE
        public static string CU_Mst_Customer(M_AT_Mst_CustomerBO mvObjCust)
        {
            M_AT_Mst_CustomerBO ObjAT_Cust = new M_AT_Mst_CustomerBO();
            string strRetMst = "";
            DataTable dt = new DataTable();
            string var_ErrorMessage = "";
            try
            {

                if (mvObjCust.MCust_RegType.Length == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Pls Select Customer Type<br>";
                }
                if (SQLManager.CheckDuplicateRecord("M_AT_Mst_Customer", "M_Cust_ID", mvObjCust.M_Cust_ID, "MCustCode", mvObjCust.MCust_Code, ""))
                {
                    var_ErrorMessage = var_ErrorMessage + "Customer Code Already Exist.<br>";
                }

                if (SQLManager.CheckDuplicateRecord("M_AT_Mst_Customer", "M_Cust_ID", mvObjCust.M_Cust_ID, "MCust_Name", mvObjCust.MCust_Name, ""))
                {
                    var_ErrorMessage = var_ErrorMessage + "Customer Name Already Exists.<br>";
                }

                if (mvObjCust.MCust_Code.Length == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Customer Code No Cannot Be Blank.<br>";
                }

                if (mvObjCust.MCust_Name.Length == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Customer Name Cannot Be Blank.<br>";
                }
                if (mvObjCust.MCust_TradeName.Length == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Customer Trade Name Cannot Be Blank.<br>";
                }
                if (mvObjCust.MCust_Reg_State_ID == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Select Customer State.<br>";
                }

                if (mvObjCust.MCust_ShippTo_State_ID == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Select Customer Shipp To State.<br>";
                }
                 
                if (var_ErrorMessage.Length == 0)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (Convert.ToInt32(mvObjCust.M_Cust_ID) == 0)
                        {
                            ObjAT_Cust.Fk_Company_ID = mvObjCust.Fk_Company_ID;
                            ObjAT_Cust.Fk_Branch_ID = mvObjCust.Fk_Branch_ID;
                            ObjAT_Cust.Fk_Year_ID = mvObjCust.Fk_Year_ID;
                            ObjAT_Cust.MDBSC_RowCreatedByUser_ID = mvObjCust.MDBSC_RowCreatedByUser_ID;
                            ObjAT_Cust.MDBSC_RowCreatedByUserName = mvObjCust.MDBSC_RowCreatedByUserName;
                            ObjAT_Cust.MCust_Code = MaheshAF18.Application.MEF.GenrateRefNo(mvObjCust.Fk_Company_ID, mvObjCust.Fk_Branch_ID, 0, "Customer", "CUST", "CUST", "No", "", "", "", 0);

                        }


                        ObjAT_Cust.M_Cust_ID = mvObjCust.M_Cust_ID;
                        ObjAT_Cust.MCust_Name = mvObjCust.MCust_Name;                         
                        ObjAT_Cust.MCust_TradeName = mvObjCust.MCust_TradeName;
                        ObjAT_Cust.MCust_RegType = mvObjCust.MCust_RegType;
                        ObjAT_Cust.MCust_CreditDays = mvObjCust.MCust_CreditDays;
                        
                        ObjAT_Cust.MCust_Reg_Add1 = mvObjCust.MCust_Reg_Add1;
                        ObjAT_Cust.MCust_Reg_Add2 = mvObjCust.MCust_Reg_Add2;
                        ObjAT_Cust.MCust_Reg_Pincode = mvObjCust.MCust_Reg_Pincode;
                        ObjAT_Cust.MCust_Reg_City = mvObjCust.MCust_Reg_City;
                        ObjAT_Cust.MCust_Reg_State_ID = mvObjCust.MCust_Reg_State_ID;
                        ObjAT_Cust.MCust_Reg_Country = mvObjCust.MCust_Reg_Country;
                        ObjAT_Cust.MCust_BL_PANNO = mvObjCust.MCust_BL_PANNO;
                        ObjAT_Cust.MCust_BL_GSTNO = mvObjCust.MCust_BL_GSTNO;

                        ObjAT_Cust.MCust_Primary_Contact_Person = mvObjCust.MCust_Primary_Contact_Person;
                        
                        ObjAT_Cust.MCust_Primary_CP_MobileNo = mvObjCust.MCust_Primary_CP_MobileNo;
                        ObjAT_Cust.MCust_Primary_CP_PhoneNo = mvObjCust.MCust_Primary_CP_PhoneNo;
                        ObjAT_Cust.MCust_Primary_CP_EmailID = mvObjCust.MCust_Primary_CP_EmailID;
                        

                        
                        ObjAT_Cust.MCust_ShippTo_CompanyName = mvObjCust.MCust_ShippTo_CompanyName;
                        ObjAT_Cust.MCust_ShippTo_ContactPerson = mvObjCust.MCust_ShippTo_ContactPerson;
                        ObjAT_Cust.MCust_ShippTo_CP_MobileNo = mvObjCust.MCust_ShippTo_CP_MobileNo;


                        ObjAT_Cust.MCust_ShippTo_Add1 = mvObjCust.MCust_ShippTo_Add1;
                        ObjAT_Cust.MCust_ShippTo_Add2 = mvObjCust.MCust_ShippTo_Add2;
                         
                        ObjAT_Cust.MCust_ShippTo_Pincode = mvObjCust.MCust_ShippTo_Pincode;
                         
                        ObjAT_Cust.MCust_ShippTo_City = mvObjCust.MCust_ShippTo_City;
                        ObjAT_Cust.MCust_ShippTo_State_ID = mvObjCust.MCust_ShippTo_State_ID;
                        ObjAT_Cust.MCust_ShippTo_Country = mvObjCust.MCust_ShippTo_Country;
                        ObjAT_Cust.MCust_ShippTo_PANNO = mvObjCust.MCust_ShippTo_PANNO;
                        ObjAT_Cust.MCust_ShippTo_GSTNO = mvObjCust.MCust_ShippTo_GSTNO;
                         
                        ObjAT_Cust.MDBSC_RowStatus = mvObjCust.MDBSC_RowStatus;

                         

                        ObjAT_Cust.MDBSC_RowLupdnByUser_ID = mvObjCust.MDBSC_RowLupdnByUser_ID;
                        ObjAT_Cust.MDBSC_RowLupdnUserName = mvObjCust.MDBSC_RowLupdnUserName;
                        ObjAT_Cust.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));


                        ObjAT_Cust.MCust_Contact_FaxNo = mvObjCust.MCust_Contact_FaxNo;
                        ObjAT_Cust.MCust_Contact_OfficeNo1 = mvObjCust.MCust_Contact_OfficeNo1;
                        ObjAT_Cust.MCust_Contact_OfficeNo2 = mvObjCust.MCust_Contact_OfficeNo2;
                        ObjAT_Cust.MCust_Contact_Email_Admin = mvObjCust.MCust_Contact_Email_Admin;
                        ObjAT_Cust.MCust_Contact_Website = mvObjCust.MCust_Contact_Website;
                        ObjAT_Cust.MCust_Primary_Contact_Designation = mvObjCust.MCust_Primary_Contact_Designation;
                        
                        
                        var_ErrorMessage = ObjAT_Cust.Insert_Update(ObjAT_Cust);
                        //ObjItem.MItem_ID =Convert.ToInt64( var_ErrorMessage.Substring((var_ErrorMessage.IndexOf("|") + 1), (var_ErrorMessage.Length - var_ErrorMessage.IndexOf("|") - 1)));
                        //var_ErrorMessage = var_ErrorMessage.Substring((0), (var_ErrorMessage.IndexOf("|")));
                        scope.Complete();
                    }
                    strRetMst = var_ErrorMessage;

                }
                else
                {
                    strRetMst = var_ErrorMessage + "|" + mvObjCust.M_Cust_ID.ToString();
                }


                return strRetMst;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Vendor MASTER
        public static ArrayList Get_Mst_Vendor_Lst(Int64 mvVendorID, string StrFilterCriteria, string SearchCriteria)
        {
            ArrayList items = new ArrayList();
            DataTable dt = new DataTable();
            try
            {
                dt = AppData.Get_DT_Mst_Vendor(mvVendorID, StrFilterCriteria, SearchCriteria);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        var objList = new Dictionary<object, object>();
                        objList["M_Ven_ID"] = row["M_Ven_ID"];
                        objList["MVen_Code"] = row["MVen_Code"];
                         
                        objList["MVen_Name"] = row["MVen_Name"];
                        objList["MVen_DisplayName"] = row["MVen_DisplayName"];
                        objList["MVen_TradeName"] = row["MVen_TradeName"];
                        objList["MVen_RegType"] = row["MVen_RegType"];


                        objList["MVen_Reg_Add1"] = row["MVen_Reg_Add1"];
                        objList["MVen_Reg_Add2"] = row["MVen_Reg_Add2"];
                        objList["MVen_Reg_Pincode"] = row["MVen_Reg_Pincode"];
                        objList["MVen_Reg_City"] = row["MVen_Reg_City"];
                        objList["MVen_Reg_State_ID"] = row["MVen_Reg_State_ID"];
                        objList["MVen_Reg_Country"] = row["MVen_Reg_Country"];
                        objList["MVen_BL_PANNO"] = row["MVen_BL_PANNO"];
                        objList["MVen_BL_GSTNO"] = row["MVen_BL_GSTNO"];

                        objList["MVen_Primary_Contact_Person"] = row["MVen_Primary_Contact_Person"];
                        objList["MVen_Primary_CP_MobileNo"] = row["MVen_Primary_CP_MobileNo"];
                        objList["MVen_Primary_CP_PhoneNo"] = row["MVen_Primary_CP_PhoneNo"];
                        objList["MVen_Primary_CP_EmailID"] = row["MVen_Primary_CP_EmailID"];


                        objList["MVen_CreditDays"] = row["MVen_CreditDays"];
                        objList["MVen_DispatchFrom_CompanyName"] = row["MVen_DispatchFrom_CompanyName"];
                        objList["MVen_DispatchFrom_ContactPerson"] = row["MVen_DispatchFrom_ContactPerson"];
                        objList["MVen_DispatchFrom_CP_MobileNo"] = row["MVen_DispatchFrom_CP_MobileNo"];


                        objList["MVen_DispatchFrom_Add1"] = row["MVen_DispatchFrom_Add1"];
                        objList["MVen_DispatchFrom_Add2"] = row["MVen_DispatchFrom_Add2"];

                        objList["MVen_DispatchFrom_Pincode"] = row["MVen_DispatchFrom_Pincode"];

                        objList["MVen_DispatchFrom_City"] = row["MVen_DispatchFrom_City"];
                        objList["MVen_DispatchFrom_State_ID"] = row["MVen_DispatchFrom_State_ID"];
                        objList["MVen_DispatchFrom_Country"] = row["MVen_DispatchFrom_Country"];
                        objList["MVen_DispatchFrom_PANNO"] = row["MVen_DispatchFrom_PANNO"];
                        objList["MVen_DispatchFrom_GSTNO"] = row["MVen_DispatchFrom_GSTNO"];

                        objList["MDBSC_RowStatus"] = row["MDBSC_RowStatus"];

                        objList["MVen_Contact_FaxNo"] = row["MVen_Contact_FaxNo"];
                        objList["MVen_Contact_OfficeNo1"] = row["MVen_Contact_OfficeNo1"];
                        objList["MVen_Contact_OfficeNo2"] = row["MVen_Contact_OfficeNo2"];
                        objList["MVen_Contact_Email_Admin"] = row["MVen_Contact_Email_Admin"];
                        objList["MVen_Contact_Website"] = row["MVen_Contact_Website"];
                        objList["MVen_Primary_Contact_Designation"] = row["MVen_Primary_Contact_Designation"];

                        items.Add(objList);
                    }

                }
                else
                {
                    items = null;
                }
                return items;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //SAVE
        public static string CU_Mst_Vendor(M_AT_Mst_VendorBO mvObjVen)
        {
            M_AT_Mst_VendorBO ObjAT_Ven = new M_AT_Mst_VendorBO();
            string strRetMst = "";
            DataTable dt = new DataTable();
            string var_ErrorMessage = "";
            try
            {

                if (mvObjVen.MVen_RegType.Length == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Pls Select Vendor Type<br>";
                }
                if (SQLManager.CheckDuplicateRecord("M_AT_Mst_Vendor", "M_Ven_ID", mvObjVen.M_Ven_ID, "MVenCode", mvObjVen.MVen_Code, ""))
                {
                    var_ErrorMessage = var_ErrorMessage + "Vendor Code Already Exist.<br>";
                }

                if (SQLManager.CheckDuplicateRecord("M_AT_Mst_Vendor", "M_Ven_ID", mvObjVen.M_Ven_ID, "MVen_Name", mvObjVen.MVen_Name, ""))
                {
                    var_ErrorMessage = var_ErrorMessage + "Vendor Name Already Exists.<br>";
                }

                if (mvObjVen.MVen_Code.Length == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Vendor Code No Cannot Be Blank.<br>";
                }

                if (mvObjVen.MVen_Name.Length == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Vendor Name Cannot Be Blank.<br>";
                }
                if (mvObjVen.MVen_TradeName.Length == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Vendor Trade Name Cannot Be Blank.<br>";
                }

                if (mvObjVen.MVen_Reg_State_ID == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Select Customer State.<br>";
                }

                if (mvObjVen.MVen_DispatchFrom_State_ID == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Select Customer Shipp To State.<br>";
                }
                 

                if (var_ErrorMessage.Length == 0)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (Convert.ToInt32(mvObjVen.M_Ven_ID) == 0)
                        {
                            ObjAT_Ven.Fk_Company_ID = mvObjVen.Fk_Company_ID;
                            ObjAT_Ven.Fk_Branch_ID = mvObjVen.Fk_Branch_ID;
                            ObjAT_Ven.Fk_Year_ID = mvObjVen.Fk_Year_ID;
                            ObjAT_Ven.MDBSC_RowCreatedByUser_ID = mvObjVen.MDBSC_RowCreatedByUser_ID;
                            ObjAT_Ven.MDBSC_RowCreatedByUserName = mvObjVen.MDBSC_RowCreatedByUserName;
                            ObjAT_Ven.MVen_Code = MaheshAF18.Application.MEF.GenrateRefNo(mvObjVen.Fk_Company_ID, mvObjVen.Fk_Branch_ID, 0, "Vendor", "Ven", "Ven", "No", "", "", "", 0);

                        }


                        ObjAT_Ven.M_Ven_ID = mvObjVen.M_Ven_ID;
                        ObjAT_Ven.MVen_Name = mvObjVen.MVen_Name;
                        ObjAT_Ven.MVen_DisplayName = mvObjVen.MVen_DisplayName;
                        ObjAT_Ven.MVen_TradeName = mvObjVen.MVen_TradeName;
                        ObjAT_Ven.MVen_RegType = mvObjVen.MVen_RegType;
                        ObjAT_Ven.MVen_CreditDays = mvObjVen.MVen_CreditDays;
                        

                        ObjAT_Ven.MVen_Reg_Add1 = mvObjVen.MVen_Reg_Add1;
                        ObjAT_Ven.MVen_Reg_Add2 = mvObjVen.MVen_Reg_Add2;
                        ObjAT_Ven.MVen_Reg_Pincode = mvObjVen.MVen_Reg_Pincode;
                        ObjAT_Ven.MVen_Reg_City = mvObjVen.MVen_Reg_City;
                        ObjAT_Ven.MVen_Reg_State_ID = mvObjVen.MVen_Reg_State_ID;
                        ObjAT_Ven.MVen_Reg_Country = mvObjVen.MVen_Reg_Country;
                        ObjAT_Ven.MVen_BL_PANNO = mvObjVen.MVen_BL_PANNO;
                        ObjAT_Ven.MVen_BL_GSTNO = mvObjVen.MVen_BL_GSTNO;

                        ObjAT_Ven.MVen_Primary_Contact_Person = mvObjVen.MVen_Primary_Contact_Person;
                        ObjAT_Ven.MVen_Primary_CP_MobileNo = mvObjVen.MVen_Primary_CP_MobileNo;
                        ObjAT_Ven.MVen_Primary_CP_PhoneNo = mvObjVen.MVen_Primary_CP_PhoneNo;
                        ObjAT_Ven.MVen_Primary_CP_EmailID = mvObjVen.MVen_Primary_CP_EmailID;



                        ObjAT_Ven.MVen_DispatchFrom_CompanyName = mvObjVen.MVen_DispatchFrom_CompanyName;
                        ObjAT_Ven.MVen_DispatchFrom_ContactPerson = mvObjVen.MVen_DispatchFrom_ContactPerson;
                        ObjAT_Ven.MVen_DispatchFrom_CP_MobileNo = mvObjVen.MVen_DispatchFrom_CP_MobileNo;


                        ObjAT_Ven.MVen_DispatchFrom_Add1 = mvObjVen.MVen_DispatchFrom_Add1;
                        ObjAT_Ven.MVen_DispatchFrom_Add2 = mvObjVen.MVen_DispatchFrom_Add2;

                        ObjAT_Ven.MVen_DispatchFrom_Pincode = mvObjVen.MVen_DispatchFrom_Pincode;

                        ObjAT_Ven.MVen_DispatchFrom_City = mvObjVen.MVen_DispatchFrom_City;
                        ObjAT_Ven.MVen_DispatchFrom_State_ID = mvObjVen.MVen_DispatchFrom_State_ID;
                        ObjAT_Ven.MVen_DispatchFrom_Country = mvObjVen.MVen_DispatchFrom_Country;
                        ObjAT_Ven.MVen_DispatchFrom_PANNO = mvObjVen.MVen_DispatchFrom_PANNO;
                        ObjAT_Ven.MVen_DispatchFrom_GSTNO = mvObjVen.MVen_DispatchFrom_GSTNO;

                        ObjAT_Ven.MDBSC_RowStatus = mvObjVen.MDBSC_RowStatus;



                        ObjAT_Ven.MDBSC_RowLupdnByUser_ID = mvObjVen.MDBSC_RowLupdnByUser_ID;
                        ObjAT_Ven.MDBSC_RowLupdnUserName = mvObjVen.MDBSC_RowLupdnUserName;
                        ObjAT_Ven.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));


                        ObjAT_Ven.MVen_Contact_FaxNo = mvObjVen.MVen_Contact_FaxNo;
                        ObjAT_Ven.MVen_Contact_OfficeNo1 = mvObjVen.MVen_Contact_OfficeNo1;
                        ObjAT_Ven.MVen_Contact_OfficeNo2 = mvObjVen.MVen_Contact_OfficeNo2;
                        ObjAT_Ven.MVen_Contact_Email_Admin = mvObjVen.MVen_Contact_Email_Admin;
                        ObjAT_Ven.MVen_Contact_Website = mvObjVen.MVen_Contact_Website;
                        ObjAT_Ven.MVen_Primary_Contact_Designation = mvObjVen.MVen_Primary_Contact_Designation;

                    

                        var_ErrorMessage = ObjAT_Ven.Insert_Update(ObjAT_Ven);
                        //ObjItem.MItem_ID =Convert.ToInt64( var_ErrorMessage.Substring((var_ErrorMessage.IndexOf("|") + 1), (var_ErrorMessage.Length - var_ErrorMessage.IndexOf("|") - 1)));
                        //var_ErrorMessage = var_ErrorMessage.Substring((0), (var_ErrorMessage.IndexOf("|")));
                        scope.Complete();
                    }
                    strRetMst = var_ErrorMessage;

                }
                else
                {
                    strRetMst = var_ErrorMessage + "|" + mvObjVen.M_Ven_ID.ToString();
                }


                return strRetMst;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}