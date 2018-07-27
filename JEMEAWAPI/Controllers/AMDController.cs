using JEMEAWAPI.APIDL;
using JEMEAWAPI.Models;
using JEMEAWAPI.RetWebObj;
using MaheshAF18.Application;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
 


namespace JEMEAWAPI.Controllers
{
    public class AMDController : ApiController
    {
       [HttpGet]
       public HttpResponseMessage Get_Mst_UOM()
        {
            try
            {
                HttpResponseMessage RetResponse = new HttpResponseMessage();
                ArrayList items = new ArrayList();
                DataTable dt = new DataTable();
                dt = MaheshAF18.Utility.M_DropDownList.Fill_Drop_Down_List("M_AT_Mst_UOM", "UOM_ID", "UOM", "", "", "UOM", 0, "N", "");
                if (dt.Rows.Count > 0)
                {
                    items = MaheshAF18.Application.CodeAssistance.DropDown_DataTable_To_ArrayList(dt);
                    RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false,true, "uom get successfully", items)));
                }
                else
                {
                    RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false,true, "no records found", items)));
                }
                  
                return RetResponse;
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(true, false, "internal server error " + Environment.NewLine + ex.Message, null)));
            }
        }
       [HttpGet]
       public HttpResponseMessage Get_Mst_State()
       {
           try
           {

               HttpResponseMessage RetResponse = new HttpResponseMessage();
               string var_State_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "HDRID", "0");
               ArrayList items = new ArrayList();
               DataTable dt = new DataTable();
               dt = MABL.BL.AppDataModal.Get_Mst_State(Convert.ToInt64(var_State_ID), "", "");
               if (dt.Rows.Count > 0)
               {

                   if (dt.Rows.Count > 0)
                   {
                       foreach (DataRow row in dt.Rows)
                       {
                           var objList = new Dictionary<object, object>();
                           objList["GStateID"] = row["GStateID"];
                           objList["GStateName"] = row["GStateName"].ToString();
                           objList["GStateCodeNo"] = row["GStateCodeNo"].ToString();
                           objList["vStateDisplayName"] = row["vStateDisplayName"].ToString();
                            
                           items.Add(objList);
                       }
                   }

                   RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, true, "state get successfully", items)));
               }
               else
               {
                   RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, true, "no records found", items)));
               }

               return RetResponse;
           }
           catch (Exception ex)
           {
               return Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(true, false, "internal server error " + Environment.NewLine + ex.Message, null)));
           }
       } 
       [HttpGet]
       public HttpResponseMessage Get_Mst_TaxRate()
       {
           try
           {
               HttpResponseMessage RetResponse = new HttpResponseMessage();
                
               
               ArrayList items = new ArrayList();
               DataTable dt = new DataTable();
               dt = MABL.BL.AppBL.Get_Tax_DD("Integrated Tax", 0);
               if (dt.Rows.Count > 0)
               {
                   items = MaheshAF18.Application.CodeAssistance.DropDown_DataTable_To_ArrayList(dt);
                   RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false,true, "taxrate get successfully", items)));
               }
               else
               {
                   RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, true, "no records found", items)));
               }

               return RetResponse;
           }
           catch (Exception ex)
           {
               return Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(true,false, "internal server error " + Environment.NewLine + ex.Message, null)));
           }
       }
       [HttpGet]
       public HttpResponseMessage Get_Mst_HSNSAC()
       {
           try
           {
               
               HttpResponseMessage RetResponse = new HttpResponseMessage();
               string var_HS_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "HDRID", "0");
               string var_HS_Type = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "HS_Type","");
               string strSQLFilter="";
               if(var_HS_Type.Length>0)
               {
                   strSQLFilter=" AND HS_Type='" + var_HS_Type +"'";
               }
               if(var_HS_ID.Length>0)
               {
                   if (Convert.ToInt64(var_HS_ID) > 0)
                   {
                       strSQLFilter = strSQLFilter + " AND HS_ID=" + Convert.ToInt64(var_HS_ID);
                   }
                   
               }
               ArrayList items = new ArrayList();
               DataTable dt = new DataTable();
               dt = MABL.BL.AppDataModal.Get_Mst_HSN(Convert.ToInt64(var_HS_ID), strSQLFilter, "");
               if (dt.Rows.Count > 0)
               {

                   if (dt.Rows.Count > 0)
                   {
                       foreach (DataRow row in dt.Rows)
                       {
                           var objList = new Dictionary<object, object>();
                           objList["HS_ID"] = row["HS_ID"];
                           objList["HS_Type"] = row["HS_Type"].ToString();
                           objList["HS_CODE"] = row["HS_CODE"].ToString();
                           objList["HSN_Description"] = row["HSN_Description"].ToString();
                           items.Add(objList);
                       }
                   }
                                    
                   RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false,true, "hsn get successfully", items)));
               }
               else
               {
                   RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false,true, "no records found", items)));
               }

               return RetResponse;
           }
           catch (Exception ex)
           {
               return Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(true,false, "internal server error " + Environment.NewLine + ex.Message, null)));
           }
       } 



    
       
    }
}
