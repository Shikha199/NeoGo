using JEMEAWAPI.APIAL;
using JEMEAWAPI.APIDL;
using JEMEAWAPI.Models;
using JEMEAWAPI.RetWebObj;
using MABL.ATDataModal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JEMEAWAPI.Controllers
{
    public class SalesController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetLst()
        {
            ArrayList items = new ArrayList();
            try
            {

                HttpResponseMessage RetResponse = new HttpResponseMessage();
                string var_APIKey = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "APIKey", "");
                string var_APISecret = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "APISecret", "");
                string var_TokenID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "TokenID", "");
                string var_SessionID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "SessionID", "");
                
                string var_Company_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "CMPID", "0");
                string var_Branch_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "BRID", "0");
                string var_YearID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "YearID", "0");
                
                string var_User_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "UserID", "0");
                string var_User_Name = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "UserName", "");
                string var_ART = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "ART", "");
                string var_ReqTyp = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "ReqTyp", "");
                string var_HDRID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "HDRID", "0");
                string var_DTLID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "DTLID", "0");


                string strSQLFilter = "";

                strSQLFilter = " AND Fk_Company_ID=" + var_Company_ID + " AND  Fk_Branch_ID=" + var_Branch_ID;

               if (var_ART == "List")
                {

                    items = JEMEAWAPI.Models.SalesModels.Get_Sales_Common_Lst (strSQLFilter, "" );
                    if ((items != null) || (items.Count > 0))
                    {
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, true, "customer master get successfully", items)));
                    }
                    else
                    {
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, true, "no records found", null)));
                    }
                } 
                return RetResponse;
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(true, false, "internal server error " + Environment.NewLine + ex.Message, null)));
            }
        }

        [HttpGet]
        public HttpResponseMessage List()
        {
            ArrayList items = new ArrayList();
            try
            {

                HttpResponseMessage RetResponse = new HttpResponseMessage();
                string var_APIKey = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "APIKey", "");
                string var_APISecret = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "APISecret", "");
                string var_TokenID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "TokenID", "");
                string var_SessionID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "SessionID", "");

                string var_Company_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "CMPID", "0");
                string var_Branch_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "BRID", "0");
                string var_YearID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "YearID", "0");

                string var_User_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "UserID", "0");
                string var_User_Name = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "UserName", "");
                string var_ART = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "ART", "");
                string var_ReqTyp = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "ReqTyp", "");
                string var_HDRID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "HDRID", "0");
                string var_DTLID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "DTLID", "0");

                //--var_ReqTyp  INV,DN,CN,DNDN,Payment 
                

                if (var_ART == "List")
                {
                    string strSQLFilter = "";
                    strSQLFilter = " AND Fk_Company_ID=" + var_Company_ID + " AND  Fk_Branch_ID=" + var_Branch_ID;

                    if (var_ReqTyp == "INV")
                    {
                        items =SalesModels.Get_Sales_Invoice(Convert.ToInt64(var_HDRID), strSQLFilter, "");
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, false, "invalid request type", "[]")));
                    }
                    else if (var_ReqTyp == "DNCN")
                    {
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, false, "invalid request type", "[]")));
                    }
                    else if (var_ReqTyp == "DN")
                    {
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, false, "invalid request type", "[]")));
                    }
                    else if (var_ReqTyp == "CN")
                    {
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, false, "invalid request type", "[]")));
                    }
                    else
                    {
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, false, "invalid request type", "[]")));
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
        public HttpResponseMessage TaxInv(SalesModels.SalesHDR mpwObjSalesInvHDR)
        {
            object items = new object();
            try
            {

                HttpResponseMessage RetResponse = new HttpResponseMessage();
                string var_APIKey = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "APIKey", "");
                string var_APISecret = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "APISecret", "");
                string var_TokenID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "TokenID", "");
                string var_SessionID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "SessionID", "");

                string var_Company_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "CMPID", "0");
                string var_Branch_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "BRID", "0");
                string var_YearID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "YearID", "0");

                string var_User_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "UserID", "0");
                string var_User_Name = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "UserName", "");
                string var_ART = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "ART", "");
                string var_ReqTyp = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "ReqTyp", "");
                string var_HDRID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "HDRID", "0");
                string var_DTLID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "DTLID", "0");


                string strSQLFilter = "";

                strSQLFilter = " AND Fk_Company_ID=" + var_Company_ID + " AND  Fk_Branch_ID=" + var_Branch_ID;
                if (var_HDRID.Length > 0)
                {
                    if (Convert.ToInt64(var_HDRID) > 0)
                    {
                        strSQLFilter = strSQLFilter + " AND SINVHDR_ID=" + Convert.ToInt64(var_HDRID);
                    }

                }
                if (var_ART == "List") 
                {
                    items = items = SalesModels.Get_TaxInv_Lst(Convert.ToInt64(var_HDRID), strSQLFilter, "");
                    if (items != null)
                    {
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, true, "customer master get successfully", items)));
                    }
                    else
                    {
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, true, "no records found", "{[]}")));
                    }
                } 
                  
                if (var_ART == "RCUD")
                {
                    string varResMsg = "";
                    if (mpwObjSalesInvHDR != null)
                    {
                        mpwObjSalesInvHDR.Fk_Company_ID = Convert.ToInt64(var_Company_ID);
                        mpwObjSalesInvHDR.Fk_Branch_ID = Convert.ToInt64(var_Company_ID);
                        mpwObjSalesInvHDR.MDBSC_RowCreatedByUser_ID = Convert.ToInt16(var_User_ID);
                        mpwObjSalesInvHDR.MDBSC_RowCreatedByUserName = var_User_Name;
                        mpwObjSalesInvHDR.MDBSC_RowLupdnByUser_ID = Convert.ToInt16(var_User_ID);
                        mpwObjSalesInvHDR.MDBSC_RowLupdnUserName = var_User_Name;

                        MPAL.ParseObject(mpwObjSalesInvHDR);
                        for (int i = 0; i < mpwObjSalesInvHDR.SINVDTL.Count(); i++)
                        {
                            MPAL.ParseObject(mpwObjSalesInvHDR.SINVDTL[i]);
                        }

                        varResMsg = SalesModels.CU_Sales_InvHDR (mpwObjSalesInvHDR);
                        mpwObjSalesInvHDR.S_HDR_ID = Convert.ToInt64(varResMsg.Substring((varResMsg.IndexOf("|") + 1), (varResMsg.Length - varResMsg.IndexOf("|") - 1)));
                        varResMsg = varResMsg.Substring((0), (varResMsg.IndexOf("|")));
                        if (mpwObjSalesInvHDR.S_HDR_ID > 0)
                        {
                            items = SalesModels.Get_TaxInv_Lst(mpwObjSalesInvHDR.S_HDR_ID, "", "");
                        }
                        Boolean varRetStatus = false;
                        if ((varResMsg == "Added Successfully") || (varResMsg == "Updated Successfully"))
                        {
                            varRetStatus = true;
                        }
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, true, varResMsg, items)));
                    }
                    else
                    {
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, false, "invalid object", null)));
                    }
                }

                return RetResponse;
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(true, false, "internal server error " + Environment.NewLine + ex.Message, null)));
            }
        }

        [HttpPost]
        public HttpResponseMessage DCNC(SalesModels.SalesHDR mpwObjSalesInvHDR)
        {
            object items = new object();
            try
            {

                HttpResponseMessage RetResponse = new HttpResponseMessage();
                string var_APIKey = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "APIKey", "");
                string var_APISecret = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "APISecret", "");
                string var_TokenID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "TokenID", "");
                string var_SessionID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "SessionID", "");

                string var_Company_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "CMPID", "0");
                string var_Branch_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "BRID", "0");
                string var_YearID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "YearID", "0");

                string var_User_ID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "UserID", "0");
                string var_User_Name = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "UserName", "");
                string var_ART = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "ART", "");
                string var_ReqTyp = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "ReqTyp", "");
                string var_HDRID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "HDRID", "0");
                string var_DTLID = MaheshAF18.Application.CodeAssistance.GetHttpHeaderValue(Request, "DTLID", "0");


                string strSQLFilter = "";

                strSQLFilter = " AND Fk_Company_ID=" + var_Company_ID + " AND  Fk_Branch_ID=" + var_Branch_ID;
                if (var_HDRID.Length > 0)
                {
                    if (Convert.ToInt64(var_HDRID) > 0)
                    {
                        strSQLFilter = strSQLFilter + " AND DCNCHDR_ID=" + Convert.ToInt64(var_HDRID);
                    }

                }
                if (var_ART == "List")
                {
                    items = items = SalesModels.Get_DNCN_Lst(Convert.ToInt64(var_HDRID), strSQLFilter, "");
                    if (items != null)
                    {
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, true, "customer master get successfully", items)));
                    }
                    else
                    {
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, true, "no records found", "{[]}")));
                    }
                }

                if (var_ART == "RCUD")
                {
                    string varResMsg = "";
                    if (mpwObjSalesInvHDR != null)
                    {
                        mpwObjSalesInvHDR.Fk_Company_ID = Convert.ToInt64(var_Company_ID);
                        mpwObjSalesInvHDR.Fk_Branch_ID = Convert.ToInt64(var_Company_ID);
                        mpwObjSalesInvHDR.MDBSC_RowCreatedByUser_ID = Convert.ToInt16(var_User_ID);
                        mpwObjSalesInvHDR.MDBSC_RowCreatedByUserName = var_User_Name;
                        mpwObjSalesInvHDR.MDBSC_RowLupdnByUser_ID = Convert.ToInt16(var_User_ID);
                        mpwObjSalesInvHDR.MDBSC_RowLupdnUserName = var_User_Name;

                        MPAL.ParseObject(mpwObjSalesInvHDR);
                        for (int i = 0; i < mpwObjSalesInvHDR.SINVDTL.Count(); i++)
                        {
                            MPAL.ParseObject(mpwObjSalesInvHDR.SINVDTL[i]);
                        }

                        varResMsg = SalesModels.CU_Sales_DNCN(mpwObjSalesInvHDR);
                        mpwObjSalesInvHDR.S_HDR_ID = Convert.ToInt64(varResMsg.Substring((varResMsg.IndexOf("|") + 1), (varResMsg.Length - varResMsg.IndexOf("|") - 1)));
                        varResMsg = varResMsg.Substring((0), (varResMsg.IndexOf("|")));
                        if (mpwObjSalesInvHDR.S_HDR_ID > 0)
                        {
                            items = SalesModels.Get_DNCN_Lst(mpwObjSalesInvHDR.S_HDR_ID, "", "");
                        }
                        Boolean varRetStatus = false;
                        if ((varResMsg == "Added Successfully") || (varResMsg == "Updated Successfully"))
                        {
                            varRetStatus = true;
                        }
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, true, varResMsg, items)));
                    }
                    else
                    {
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, false, "invalid object", null)));
                    }
                }

                return RetResponse;
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(true, false, "internal server error " + Environment.NewLine + ex.Message, null)));
            }
        }

    }
}
