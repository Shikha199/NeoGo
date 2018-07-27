using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MABL.SQLManager
{
    public static class SQLProcedureCall
    {
        
      
        public static void USP_Update_Tbl_Purchase(Int64 CompanyID, Int64 BranchID, Int64 YearID, Int64 PurchaseID)
        {
            string strSqlString = "";
            try
            {
                strSqlString = " AAA_M_USP_Update_Tbl_Purchase  " + CompanyID + "," + BranchID + "," + YearID + "," + PurchaseID + ",0";
                MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void USP_Update_Tbl_EWayBill(Int64 CompanyID, Int64 BranchID, Int64 YearID, Int64 SEWB_HDR_ID)
        {
            string strSqlString = "";
            try
            {

                strSqlString = " AAA_M_USP_Update_Tbl_EWayBill  " + CompanyID + "," + BranchID + "," + YearID + "," + SEWB_HDR_ID + ",0";
                MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void USP_Update_Tbl_Sales(Int64 CompanyID, Int64 BranchID, Int64 YearID, Int64 SINVHDRID)
        {
            string strSqlString = "";
            try
            {

                strSqlString = " AAA_M_USP_Update_Tbl_Sales  " + CompanyID + "," + BranchID + "," + YearID + "," + SINVHDRID + ",0";
                MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void USP_Update_Tbl_Sales_DC(Int64 CompanyID, Int64 BranchID, Int64 YearID, Int64 DCHDR_ID)
        {
            string strSqlString = "";
            try
            {
                strSqlString = " AAA_M_USP_Update_Tbl_Sales_DC  " + CompanyID + "," + BranchID + "," + YearID + "," + DCHDR_ID + ",0";
                
                MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public static void USP_Update_Tbl_Sales_PI(Int64 SPIHDR_ID)
        {
            string strSqlString = "";
            try
            {
                MaheshAF18.WebSession.SessionPageLocal ObjSessionData = new MaheshAF18.WebSession.SessionPageLocal();
                strSqlString = " AAA_M_USP_Update_Tbl_Sales_PI  " +
                                 ObjSessionData.Company.CompanyID + "," +
                                 ObjSessionData.Company.BranchID + "," +
                                 ObjSessionData.Company.YearID + "," + SPIHDR_ID + ",0";
                MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void USP_Update_Tbl_Payment_Customer(Int64 CPHDRID)
        {
            string strSqlString = "";
            try
            {
                MaheshAF18.WebSession.SessionPageLocal ObjSessionData = new MaheshAF18.WebSession.SessionPageLocal();
                strSqlString = " AAA_M_USP_Update_Tbl_Payment_Customer  " +
                                 ObjSessionData.Company.CompanyID + "," +
                                 ObjSessionData.Company.BranchID + "," +
                                 ObjSessionData.Company.YearID + "," + CPHDRID + ",0";
                MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void USP_Update_Tbl_Payment_Vendor(Int64 VPHDRID)
        {
            string strSqlString = "";
            try
            {
                MaheshAF18.WebSession.SessionPageLocal ObjSessionData = new MaheshAF18.WebSession.SessionPageLocal();
                strSqlString = " AAA_M_USP_Update_Tbl_Payment_Vendor  " +
                                 ObjSessionData.Company.CompanyID + "," +
                                 ObjSessionData.Company.BranchID + "," +
                                 ObjSessionData.Company.YearID + "," + VPHDRID + ",0";
                MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void USP_Update_Tbl_DCN_Cust(Int64 CompanyID, Int64 BranchID, Int64 YearID, Int64 DCNCHDRID)
        {
            string strSqlString = "";
            try
            {
                strSqlString = " AAA_M_USP_Update_Tbl_DCN_Customer  " + CompanyID + "," + BranchID + "," + YearID + "," + DCNCHDRID + ",0";
                MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void USP_Update_Tbl_DCN_Ven(Int64 CompanyID, Int64 BranchID, Int64 YearID, Int64 DCNVHDRID)
        {
            string strSqlString = "";
            try
            {
                strSqlString = " AAA_M_USP_Update_Tbl_DCN_Vendor  " + CompanyID + "," + BranchID + "," + YearID + "," + DCNVHDRID + ",0";
                MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        
         
    }
}
