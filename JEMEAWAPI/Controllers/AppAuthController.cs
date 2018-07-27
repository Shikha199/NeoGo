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
     
    public class AppAuthController : ApiController
    {
       [HttpPost]
       public HttpResponseMessage AppUserLogin(AppUserModel objUser)
        {
            try
            {
                HttpResponseMessage RetResponse = new HttpResponseMessage();
                string var_LoginD = objUser.LoginID;
                string var_PasswordD =objUser.Password;
                string var_ErrorMsg = "";

                if (CodeAssistance.F_ValidateStrLen(var_LoginD, 25))
                {
                    var_ErrorMsg =var_ErrorMsg+ "invalid string length for LoginID";
                }
                if (CodeAssistance.F_ValidateStrLen(var_PasswordD, 25))
                {
                    var_ErrorMsg = var_ErrorMsg + "invalid string length for Password";
                }
                var_LoginD = CodeAssistance.F_ValidateString("ALL",var_LoginD, ".@");
                var_PasswordD = CodeAssistance.F_ValidateString("RemoveSingleQuote", var_PasswordD, "");
                var_PasswordD = CodeAssistance.F_ValidateString("RemoveNextLine", var_PasswordD, ".@");
                var_PasswordD = CodeAssistance.F_ValidateString("RemoveSpace", var_PasswordD, ""); ;
                var_PasswordD = CodeAssistance.F_ValidateString( "RemoveSingleQuote", var_PasswordD, "");

                if (var_LoginD.Length == 0)
                {
                    var_ErrorMsg = var_ErrorMsg + "LoginID cannot be blank";
                }
                if (var_PasswordD.Length == 0)
                {
                    var_ErrorMsg = var_ErrorMsg + "Password cannot be blank";
                } 

                if (var_ErrorMsg.Length==0)
                {
                     
                    if (MEF.Security_ValidateUser("APPUSER", var_LoginD, var_PasswordD))
                    {
                        //Create User Object
                        
                        objUser = AppData.Get_User_Data_By_LoginID(var_LoginD);
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, true, "Login Successfully", objUser)));
                    }
                    else
                    {
                        RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, true, "invalid userid or password", objUser)));
                    } 
                }
                else
                {
                    RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, true, var_ErrorMsg, null)));

                }
                return RetResponse;
            }
            catch (Exception ex)
            {
                return  Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(true,false, "internal server error " + Environment.NewLine + ex.Message, null)));
            } 
        }
       [HttpPost]
       public HttpResponseMessage AppCompany(AppUserModel objUser)
       {
           try
           {
               string var_ErrorMsg = "";
               HttpResponseMessage RetResponse = new HttpResponseMessage();
                
               if (objUser != null)
               {
                   ArrayList items = new ArrayList();
                   DataTable dt = new DataTable();
                   dt =  AppData.Get_DT_User_Company(objUser.UserID, "", "");
                   if (dt.Rows.Count > 0)
                   {
                       foreach (DataRow row in dt.Rows)
                       {
                           var objList = new Dictionary<object, object>();
                           objList["M_RT_CMP_ID"] = row["M_RT_CMP_ID"];
                           objList["UserID"] = objUser.UserID;
                           objList["MDBSC_CMP_Name"] = row["MDBSC_CMP_Name"].ToString();
                           objList["MDBSC_CMP_TradingName"] = row["MDBSC_CMP_TradingName"].ToString();
                           objList["MDBSC_RowStatus"] = row["MDBSC_RowStatus"].ToString();
                           objList["BR_CNT"] = row["BR_CNT"].ToString();
                           
                           items.Add(objList);
                       }

                       RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, true,"", items)));
                   }
                   else
                   {
                       RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, true,"", items)));
                   }
               }
                

               return RetResponse;
           }
           catch (Exception ex)
           {
               return Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(true,false, "internal server error " + Environment.NewLine + ex.Message, null)));
           } 
       }
       [HttpPost]
       public HttpResponseMessage AppCompanyWiseBranch(AppUserModel objUser)
       {
           try
           {
               string var_ErrorMsg = "";
               HttpResponseMessage RetResponse = new HttpResponseMessage();

               if (objUser != null)
               {
                   ArrayList items = new ArrayList();
                   DataTable dt = new DataTable();
                   dt = JEMEAWAPI.APIDL.AppData.Get_DT_User_Company_Wise_Branch(objUser.UserID, objUser.CompanyID, "","");
                   if (dt.Rows.Count > 0)
                   {
                       foreach (DataRow row in dt.Rows)
                       {
                         
                           var objList = new Dictionary<object, object>();
                           objList["FK_M_RT_CMP_ID"] = row["FK_M_RT_CMP_ID"].ToString();
                           objList["M_RT_CMP_BR_ID"] = row["M_RT_CMP_BR_ID"];
                           objList["MDBSC_CMP_Current_Year_ID"] = row["MDBSC_CMP_Current_Year_ID"];
                           objList["UserID"] = objUser.UserID;
                           objList["MDBSC_CMP_Name"] = row["MDBSC_CMP_Name"].ToString();
                           objList["MDBSC_CMP_TradingName"] = row["MDBSC_CMP_TradingName"].ToString();
                           objList["MDBSC_BR_Name"] = row["MDBSC_BR_Name"].ToString();
                           objList["MDBSC_BR_Type"] = row["MDBSC_BR_Type"].ToString();
                           objList["BL_GSTNO"] = row["BL_GSTNO"].ToString();

                           objList["BR_Reg_State_ID"] = row["BR_Reg_State_ID"].ToString();
                           objList["BR_Reg_State"] = row["BR_Reg_State"].ToString();
                           objList["BR_Reg_StateCode"] = row["BR_Reg_StateCode"].ToString();
                           objList["BR_Reg_StateDisplayName"] = row["BR_Reg_StateDisplayName"].ToString();
                           
                           items.Add(objList);
                       }

                       RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, true, "", items)));
                   }
                   else
                   {
                       RetResponse = Request.CreateResponse(HttpStatusCode.OK, (new JsonRetMessage(false, true, "", items)));
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
