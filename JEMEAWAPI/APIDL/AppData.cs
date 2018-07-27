using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JEMEAWAPI.Models;
using System.Data;

namespace JEMEAWAPI.APIDL
{
    public class AppData
    {
        public static AppUserModel Get_User_Data_By_LoginID(string mvLoginID)
        {
            try
            {
                AppUserModel objUser = new AppUserModel();
                string strSQL = "Select * from v_AAA_M_RT_App_User WHERE MDBSC_App_User_LoginID='" + mvLoginID + "'  ";
                DataTable dtUser = new DataTable();
                dtUser = MaheshAF18.Application.MEF.DA_GetDataTable(strSQL);
                if (dtUser.Rows.Count > 0)
                {
                    objUser.UserID = Convert.ToInt64( dtUser.Rows[0]["M_RT_User_ID"].ToString());
                    objUser.LoginID = dtUser.Rows[0]["MDBSC_App_User_LoginID"].ToString();
                    objUser.UserName = dtUser.Rows[0]["UserName"].ToString();
                    objUser.RoleID = Convert.ToInt64(dtUser.Rows[0]["FK_M_RT_UserRole_ID"].ToString());
                    objUser.RoleDesc = dtUser.Rows[0]["MDBSC_App_UserRole"].ToString();
                    objUser.TypeID =Convert.ToInt64( dtUser.Rows[0]["FK_M_RT_UserType_ID"].ToString());
                    objUser.TypeDesc = dtUser.Rows[0]["MDBSC_App_UserType"].ToString();
                    objUser.UserStatus = dtUser.Rows[0]["MDBSC_RowStatus"].ToString();
                            
                }
                else
                {
                    objUser.UserID = 0;
                    objUser.LoginID = mvLoginID;
                    objUser.UserName ="";
                    objUser.RoleID = 0;
                    objUser.RoleDesc = "";
                    objUser.TypeID = 0;
                    objUser.TypeDesc = "";
                    objUser.UserStatus = "user not found";
                }
                return objUser;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_DT_User_Company(Int64 mvUserID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);

                strSqlString = "    SELECT AA.M_RT_CMP_ID,AA.MDBSC_CMP_Name,AA.MDBSC_CMP_TradingName,AA.MDBSC_RowStatus,ISNULL(CC.BR_CNT,0) BR_CNT  " +
                                  " FROM v_AAA_M_RT_CMP_Info AA " +
                                  " INNER JOIN AAA_M_RT_App_User BB ON BB.FK_M_RT_CMP_ID=AA.M_RT_CMP_ID " +
                                  " LEFT OUTER JOIN (SELECT FK_M_RT_CMP_ID,COUNT(FK_M_RT_CMP_ID) BR_CNT FROM AAA_M_RT_CMP_Branch GROUP BY FK_M_RT_CMP_ID ) CC ON CC.FK_M_RT_CMP_ID=AA.M_RT_CMP_ID " +
                                   strWhereClause + StrFilterCriteria + " AND  M_RT_User_ID=" + mvUserID + "   Order By MDBSC_CMP_Name ASC";
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_DT_User_Company_Wise_Branch(Int64 mvUserID, Int64 mvCompanyID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);

                strSqlString = " SELECT AA.M_RT_CMP_BR_ID,AA.FK_M_RT_CMP_ID,BB.MDBSC_CMP_Current_Year_ID,AA.MDBSC_CMP_Name,AA.MDBSC_CMP_TradingName,AA.MDBSC_BR_Name,AA.MDBSC_BR_Type,AA.BL_GSTNO,BR_Reg_State_ID,BR_Reg_State,BR_Reg_StateCode,BR_Reg_StateDisplayName  " +
                                  " FROM v_AAA_M_RT_CMP_Branch AA " +
                                  " INNER JOIN v_AAA_M_RT_CMP_Info BB ON BB.M_RT_CMP_ID=AA.FK_M_RT_CMP_ID " +
                                  " INNER JOIN AAA_M_RT_App_User CC ON CC.FK_M_RT_CMP_ID=BB.M_RT_CMP_ID " +
                                   strWhereClause + StrFilterCriteria + " AND  M_RT_User_ID=" + mvUserID + "   Order By MDBSC_BR_Name ASC";
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_DT_Mst_Item(Int64 MItem_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                 
                if (MItem_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Mst_ItemMaster" + strWhereClause + StrFilterCriteria + "  Order By Item_Name ASC";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Mst_ItemMaster  " + strWhereClause + " AND   MItem_ID=0" + MItem_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_DT_Mst_Customer(Int64 mvCustomerID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);

                if (mvCustomerID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Mst_Customer" + strWhereClause + StrFilterCriteria + "  Order By MCust_Name ASC";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Mst_Customer  " + strWhereClause + " AND   M_Cust_ID=0" + mvCustomerID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_DT_Mst_Vendor(Int64 mvVendorID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);

                if (mvVendorID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Mst_Vendor" + strWhereClause + StrFilterCriteria + "  Order By MVen_Name ASC";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Mst_Vendor  " + strWhereClause + " AND   M_Ven_ID=0" + mvVendorID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        //SALES
        public static DataTable Get_DT_Sales_Common_List( string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal();
                strSqlString = " select SINV_TrnType RecType,SINV_Type TrnType,SINVHDR_ID TrnHDR_ID,  " +
                                 " Fk_Company_ID,Fk_Branch_ID,Fk_Year_ID,SINV_No TrnNo,vSINV_DT TrnDT,'Customer' PartyType, Fk_CustomerID PartyID, " +
                                 " MCust_Name PartyName,SINV_DTL_CNT NoOFDtl,SINV_HDR_Total_Gross_Amt TrnTotalAmt " +
                                 " FROM v_M_AT_Sales_Inv_AHDR " +
                                 strWhereClause + StrFilterCriteria +
                                 " UNION ALL  " +
                                 " select 'DNCN' RecType,DCNC_Type TrnType,DCNCHDR_ID TrnHDR_ID,   " + 
                                 " Fk_Company_ID,Fk_Branch_ID,Fk_Year_ID,DCNC_No TrnNo,vDCNC_DT TrnDT,'Customer' PartyType, 0 PartyID,  " + 
                                 " MCust_Name PartyName,DCNC_DTL_CNT NoOFDtl,DCNC_HDR_Total_Gross_Amt TrnTotalAmt " +
                                 " FROM v_M_AT_DNC_Cust_AHDR " +
                                  strWhereClause + StrFilterCriteria;

                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        
        public static DataTable Get_DT_Sales_HDR_List(Int64 SINVHDR_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
            
                if (SINVHDR_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Sales_Inv_AHDR" + strWhereClause +  StrFilterCriteria + "  ORDER BY   SINVHDR_ID desc  ";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Sales_Inv_AHDR  " + strWhereClause + " AND        SINVHDR_ID=0" + SINVHDR_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_DT_Sales_DTL_List(Int64 SINVHDR_ID, Int64 SINVDTL_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                if (SINVDTL_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Sales_Inv_BDTL" + strWhereClause + StrFilterCriteria +
                                   " AND  Fk_SINVHDR_ID=" + SINVHDR_ID +
                                   "  ORDER BY    SINVDTL_ID ASC";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Sales_Inv_BDTL  Where Fk_SINVHDR_ID=" + SINVHDR_ID + " AND   SINVDTL_ID=0" + SINVDTL_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable Get_DT_Sales_DNCN_HDR_List(Int64 DCNCHDR_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);

                if (DCNCHDR_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_DNC_Cust_AHDR" + strWhereClause + StrFilterCriteria + "  ORDER BY   DCNCHDR_ID desc  ";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_DNC_Cust_AHDR  " + strWhereClause + " AND        DCNCHDR_ID=0" + DCNCHDR_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_DT_Sales_DNCN_DTL_List(Int64 DCNCHDR_ID, Int64 DCNCDTL_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                if (DCNCDTL_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_DNC_Cust_BDTL" + strWhereClause + StrFilterCriteria +
                                   " AND  Fk_DCNCHDR_ID=" + DCNCHDR_ID +
                                   "  ORDER BY    DCNCDTL_ID ASC";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_DNC_Cust_BDTL  Where Fk_DCNCHDR_ID=" + DCNCHDR_ID + " AND   SINVDTL_ID=0" + DCNCDTL_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        //Purchase
        public static DataTable Get_DT_Purchase_Common_List(string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal();
                strSqlString = " select PINV_TrnType RecType,PINV_Type TrnType,SINVHDR_ID TrnHDR_ID,  " +
                                 " Fk_Company_ID,Fk_Branch_ID,Fk_Year_ID,PINV_No TrnNo,vPINV_DT TrnDT,'Customer' PartyType, Fk_CustomerID PartyID, " +
                                 " MCust_Name PartyName,PINV_DTL_CNT NoOFDtl,PINV_HDR_Total_Gross_Amt TrnTotalAmt " +
                                 " FROM v_M_AT_Purchase_Inv_AHDR " +
                                 strWhereClause + StrFilterCriteria +
                                 " UNION ALL  " +
                                 " select 'DNCN' RecType,DCNV_Type TrnType,DCNCHDR_ID TrnHDR_ID,   " +
                                 " Fk_Company_ID,Fk_Branch_ID,Fk_Year_ID,DCNV_No TrnNo,vDCNV_DT TrnDT,'Customer' PartyType, 0 PartyID,  " +
                                 " MCust_Name PartyName,DCNV_DTL_CNT NoOFDtl,DCNV_HDR_Total_Gross_Amt TrnTotalAmt " +
                                 " FROM v_M_AT_DNC_Ven_AHDR " +
                                  strWhereClause + StrFilterCriteria;

                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}