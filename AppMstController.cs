using JEMEAWAPI.APIAL;
using JEMEAWAPI.APIDL;
using JEMEAWAPI.Models;
using JEMEAWAPI.RetWebObj;
using MABL.ATDataModal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;

namespace JEMEAWAPI.Controllers
{
    public class AppMstController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage ItemMaster(M_AT_Mst_ItemMasterBO ObjItem)
        {
            ArrayList items = new ArrayList();
            try
            {
               
                HttpResponseMessage RetResponse = new HttpResponseMessage();
                string var_Company_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "CMPID", "0");
                string var_Branch_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "BRID", "0");
                string var_User_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "UserID", "0");
                string var_User_Name = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "UserName", "");
                string var_ART = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "ART", "");
                string var_MItem_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "HDRID", "0");
                string var_Item_Type = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "Item_Type", "");
                
                string strSQLFilter = "";

                strSQLFilter = " AND Fk_Company_ID=" + var_Company_ID + " AND  Fk_Branch_ID=" + var_Branch_ID; 
                if (var_Item_Type.Length > 0)
                {
                    strSQLFilter =strSQLFilter + " AND Item_Type='" + var_Item_Type + "'";
                }
                if (var_MItem_ID.Length > 0)
                {
                    if (Convert.ToInt64(var_MItem_ID) > 0)
                    {
                        strSQLFilter = strSQLFilter + " AND MItem_ID=" + Convert.ToInt64(var_MItem_ID);
                    }

                }

                if (var_ART == "List")
                {
                    
                    items = AppMaster.Get_Mst_Item_Lst(Convert.ToInt64(var_MItem_ID), strSQLFilter, "");
                    if (items != null)  
                    {
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, true, "item master get successfully", items)));
                    }
                    else
                    {
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, true, "no records found", "[]")));
                    }
                }

                if (var_ART == "RCUD")
                {
                    string varResMsg = "";
                    if (ObjItem != null)
                    {
                        ObjItem.Fk_Company_ID = Convert.ToInt64(var_Company_ID);
                        ObjItem.Fk_Branch_ID = Convert.ToInt64(var_Company_ID);
                        ObjItem.MDBSC_RowCreatedByUser_ID = Convert.ToInt16(var_User_ID);
                        ObjItem.MDBSC_RowCreatedByUserName = var_User_Name;
                        ObjItem.MDBSC_RowLupdnByUser_ID = Convert.ToInt16(var_User_ID);
                        ObjItem.MDBSC_RowLupdnUserName = var_User_Name;

                        varResMsg = AppMaster.CU_Mst_Item(ObjItem);
                        ObjItem.MItem_ID = Convert.ToInt64(varResMsg.Substring((varResMsg.IndexOf("|") + 1), (varResMsg.Length - varResMsg.IndexOf("|") - 1)));
                        varResMsg = varResMsg.Substring((0), (varResMsg.IndexOf("|")));
                        if (ObjItem.MItem_ID > 0)
                        {
                            items = AppMaster.Get_Mst_Item_Lst(ObjItem.MItem_ID, strSQLFilter, "");
                        }
                        Boolean varRetStatus = false;
                        if ((varResMsg == "Added Successfully") || (varResMsg == "Updated Successfully"))
                        {
                            varRetStatus = true;
                        }
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, varRetStatus, varResMsg, items)));
                    }
                    else
                    {
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, false, "invalid item master object", "[]")));
                    }
                }
                 
                return RetResponse;
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(true, false, "internal server error " + Environment.NewLine + ex.Message, "[]")));
            }
        }
        [HttpPost]
        public HttpResponseMessage CustomerMaster(M_AT_Mst_CustomerBO ObjCust)
        {
            ArrayList items = new ArrayList();
            try
            {

                HttpResponseMessage RetResponse = new HttpResponseMessage();
                string var_Company_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "CMPID", "0");
                string var_Branch_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "BRID", "0");
                string var_User_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "UserID", "0");
                string var_User_Name = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "UserName", "");
                string var_ART = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "ART", "");
                string var_M_Cust_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "HDRID", "0");
                 

                string strSQLFilter = "";

                strSQLFilter = " AND Fk_Company_ID=" + var_Company_ID + " AND  Fk_Branch_ID=" + var_Branch_ID;

                if (var_M_Cust_ID.Length > 0)
                {
                    if (Convert.ToInt64(var_M_Cust_ID) > 0)
                    {
                        strSQLFilter = strSQLFilter + " AND M_Cust_ID=" + Convert.ToInt64(var_M_Cust_ID);
                    }

                }

                if (var_ART == "List")
                {

                    items = AppMaster.Get_Mst_Customer_Lst(Convert.ToInt64(var_M_Cust_ID), strSQLFilter, "");
                    if ((items != null) || (items.Count > 0))
                    {
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, true, "customer master get successfully", items)));
                    }
                    else
                    {
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, true, "no records found", "[]")));
                    }
                }

                if (var_ART == "RCUD")
                {
                    string varResMsg = "";
                    if (ObjCust != null)
                    {
                        ObjCust.Fk_Company_ID = Convert.ToInt64(var_Company_ID);
                        ObjCust.Fk_Branch_ID = Convert.ToInt64(var_Company_ID);
                        ObjCust.MDBSC_RowCreatedByUser_ID = Convert.ToInt16(var_User_ID);
                        ObjCust.MDBSC_RowCreatedByUserName = var_User_Name;
                        ObjCust.MDBSC_RowLupdnByUser_ID = Convert.ToInt16(var_User_ID);
                        ObjCust.MDBSC_RowLupdnUserName = var_User_Name;

                        //PropertyInfo[] properties =ObjCust.GetType().GetProperties();
                        //foreach (var property in properties)
                        //{
                        //    if (property.PropertyType == typeof(string) && property.GetValue( != null)
                        //    {
                        //        string newvalue = GetUpdatedValue();
                        //        property.SetValue(this, newvalue);
                        //    }
                        //}

                         MPAL.ParseObject(ObjCust);

                        varResMsg = AppMaster.CU_Mst_Customer(ObjCust);
                        ObjCust.M_Cust_ID = Convert.ToInt64(varResMsg.Substring((varResMsg.IndexOf("|") + 1), (varResMsg.Length - varResMsg.IndexOf("|") - 1)));
                        varResMsg = varResMsg.Substring((0), (varResMsg.IndexOf("|")));
                        if (ObjCust.M_Cust_ID > 0)
                        {
                            items = AppMaster.Get_Mst_Customer_Lst(ObjCust.M_Cust_ID, strSQLFilter, "");
                        }
                        Boolean varRetStatus = false;
                        if ((varResMsg == "Added Successfully") || (varResMsg == "Updated Successfully"))
                        {
                            varRetStatus = true;
                        }
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, varRetStatus, varResMsg, items)));
                    }
                    else
                    {
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, false, "invalid item master object", "[]")));
                    }
                }

                return RetResponse;
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(true, false, "internal server error " + Environment.NewLine + ex.Message, "[]")));
            }
        }
        [HttpPost]
        public HttpResponseMessage VendorMaster(M_AT_Mst_VendorBO ObjVen)
        {
            ArrayList items = new ArrayList();
            try
            {

                HttpResponseMessage RetResponse = new HttpResponseMessage();
                string var_Company_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "CMPID", "0");
                string var_Branch_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "BRID", "0");
                string var_User_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "UserID", "0");
                string var_User_Name = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "UserName", "");
                string var_ART = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "ART", "");
                string var_M_Ven_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "HDRID", "0");


                string strSQLFilter = "";

                strSQLFilter = " AND Fk_Company_ID=" + var_Company_ID + " AND  Fk_Branch_ID=" + var_Branch_ID;

                if (var_M_Ven_ID.Length > 0)
                {
                    if (Convert.ToInt64(var_M_Ven_ID) > 0)
                    {
                        strSQLFilter = strSQLFilter + " AND M_Ven_ID=" + Convert.ToInt64(var_M_Ven_ID);
                    }

                }

                if (var_ART == "List")
                {

                    items = AppMaster.Get_Mst_Vendor_Lst(Convert.ToInt64(var_M_Ven_ID), strSQLFilter, "");
                    if ((items != null) || (items.Count > 0))
                    {
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, true, "Vendor master get successfully", items)));
                    }
                    else
                    {
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, true, "no records found", "[]")));
                    }
                }

                if (var_ART == "RCUD")
                {
                    string varResMsg = "";
                    if (ObjVen != null)
                    {
                        ObjVen.Fk_Company_ID = Convert.ToInt64(var_Company_ID);
                        ObjVen.Fk_Branch_ID = Convert.ToInt64(var_Company_ID);
                        ObjVen.MDBSC_RowCreatedByUser_ID = Convert.ToInt16(var_User_ID);
                        ObjVen.MDBSC_RowCreatedByUserName = var_User_Name;
                        ObjVen.MDBSC_RowLupdnByUser_ID = Convert.ToInt16(var_User_ID);
                        ObjVen.MDBSC_RowLupdnUserName = var_User_Name;
                        MPAL.ParseObject(ObjVen);
                        varResMsg = AppMaster.CU_Mst_Vendor(ObjVen);
                        ObjVen.M_Ven_ID = Convert.ToInt64(varResMsg.Substring((varResMsg.IndexOf("|") + 1), (varResMsg.Length - varResMsg.IndexOf("|") - 1)));
                        varResMsg = varResMsg.Substring((0), (varResMsg.IndexOf("|")));
                        if (ObjVen.M_Ven_ID > 0)
                        {
                            items = AppMaster.Get_Mst_Vendor_Lst(ObjVen.M_Ven_ID, strSQLFilter, "");
                        }

                        Boolean varRetStatus = false;
                        if((varResMsg =="Added Successfully")  || (varResMsg == "Updated Successfully"))
                        {
                            varRetStatus = true;
                        }


                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, varRetStatus, varResMsg, items)));
                    }
                    else
                    {
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, false, "invalid vebdor object", "[]")));
                    }
                }

                return RetResponse;
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(true, false, "internal server error " + Environment.NewLine + ex.Message, "[]")));
            }
        }

        
    }
}
