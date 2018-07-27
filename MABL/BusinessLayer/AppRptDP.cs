using MaheshAF18.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaheshAF18.Application;

namespace MABL.BL
{
    public static class AppRptDP
    {
        //PURCHASE
        public static DataTable Rpt_Get_Purchase_Summary(string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal();
                strSqlString = "SELECT * FROM v_M_AT_Purchase_Inv_AHDR" + strWhereClause +
                                 " AND Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                 " AND Fk_Branch_ID=" + ObjSession.Company.BranchID + StrFilterCriteria + "  ORDER BY   PINVHDR_ID desc  ";
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Rpt_Get_Purchase_Detail(  string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal();
                strSqlString = " SELECT * FROM v_M_AT_Purchase_Inv_BDTL" + strWhereClause +
                               " AND Fk_Company_ID=" + ObjSession.Company.CompanyID +
                               " AND Fk_Branch_ID=" + ObjSession.Company.BranchID + StrFilterCriteria +
                               " ORDER BY PINVDTL_ID ASC"; 
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //SALES
        public static DataTable Rpt_Get_Sales_Summary(string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal();
                strSqlString = "SELECT * FROM v_M_AT_Sales_Inv_AHDR" + strWhereClause +
                                 " AND Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                 " AND Fk_Branch_ID=" + ObjSession.Company.BranchID + StrFilterCriteria + "  ORDER BY   SINVHDR_ID desc  ";
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Rpt_Get_Sales_Detail(string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal();
                strSqlString = " SELECT * FROM v_M_AT_Sales_Inv_BDTL" + strWhereClause +
                               " AND Fk_Company_ID=" + ObjSession.Company.CompanyID +
                               " AND Fk_Branch_ID=" + ObjSession.Company.BranchID + StrFilterCriteria +
                               " ORDER BY SINVDTL_ID ASC";
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //SALES DC
        public static DataTable Rpt_Get_Sales_DC_Summary(string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal();
                strSqlString = "SELECT * FROM v_M_AT_Sales_DC_AHDR" + strWhereClause +
                                 " AND Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                 " AND Fk_Branch_ID=" + ObjSession.Company.BranchID + StrFilterCriteria + "  ORDER BY   DCHDR_ID desc  ";
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Rpt_Get_Sales_DC_Detail(string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal();
                strSqlString = " SELECT * FROM v_M_AT_Sales_DC_BDTL" + strWhereClause +
                               " AND Fk_Company_ID=" + ObjSession.Company.CompanyID +
                               " AND Fk_Branch_ID=" + ObjSession.Company.BranchID + StrFilterCriteria +
                               " ORDER BY DCDTL_ID ASC";
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Account Payable
        public static DataTable Rpt_Get_Acc_Payable_Summary(string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal();
                strSqlString = " SELECT AA.Fk_VendorID,AA.MVen_Code, AA.MVen_Name,COUNT(AA.MVen_Name)NoOfInv, " +
                               " SUM(CASE WHEN DATEDIFF( d,AA.PINV_DT,Getdate() ) BETWEEN 0 AND 30 THEN AA.PINV_HDR_Outstanding_AsOn_Amt ELSE 0 END) ThirtyDays, " +
                               " SUM(CASE WHEN DATEDIFF( d,AA.PINV_DT,Getdate() ) BETWEEN 31 AND 60 THEN AA.PINV_HDR_Outstanding_AsOn_Amt ELSE 0 END) SixtyDays, " +
                               " SUM(CASE WHEN DATEDIFF( d,AA.PINV_DT,Getdate() ) BETWEEN 61 AND 90 THEN AA.PINV_HDR_Outstanding_AsOn_Amt ELSE 0 END) NintyDays, " +
                               " SUM(CASE WHEN DATEDIFF( d,AA.PINV_DT,Getdate() ) > 91 THEN AA.PINV_HDR_Outstanding_AsOn_Amt ELSE 0 END) AboveNintyDays	 " +
                               " FROM v_M_AT_Purchase_Inv_AHDR AA  " + strWhereClause +
                               " AND AA.Fk_Company_ID=" + ObjSession.Company.CompanyID +
                               " AND AA.Fk_Branch_ID=" + ObjSession.Company.BranchID +
                               " AND AA.MDBSC_RowStatus='' " +
                               " AND AA.PINV_HDR_Outstanding_AsOn_Amt >0   " +
                                 StrFilterCriteria +
                               " GROUP BY AA.Fk_VendorID,AA.MVen_Code, AA.MVen_Name ";

                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Rpt_Get_Acc_Payable_Detail(string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal();
                strSqlString = " SELECT AA.Fk_VendorID, AA.MVen_Code, AA.MVen_Name,PINV_No,vPINV_DT,PINV_HDR_Total_Gross_Amt, " +
                                " SUM(CASE WHEN DATEDIFF( d,AA.PINV_DT,Getdate() ) BETWEEN 0 AND 30 THEN AA.PINV_HDR_Outstanding_AsOn_Amt ELSE 0 END) ThirtyDays, " +
                                " SUM(CASE WHEN DATEDIFF( d,AA.PINV_DT,Getdate() ) BETWEEN 31 AND 60 THEN AA.PINV_HDR_Outstanding_AsOn_Amt ELSE 0 END) SixtyDays, " +
                                " SUM(CASE WHEN DATEDIFF( d,AA.PINV_DT,Getdate() ) BETWEEN 61 AND 90 THEN AA.PINV_HDR_Outstanding_AsOn_Amt ELSE 0 END) NintyDays, " +
                                " SUM(CASE WHEN DATEDIFF( d,AA.PINV_DT,Getdate() ) > 91 THEN AA.PINV_HDR_Outstanding_AsOn_Amt ELSE 0 END) AboveNintyDays	 " +
                                " FROM v_M_AT_Purchase_Inv_AHDR AA  " + strWhereClause +
                                " AND AA.Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                " AND AA.Fk_Branch_ID=" + ObjSession.Company.BranchID +
                                " AND AA.MDBSC_RowStatus='' " +
                                " AND AA.PINV_HDR_Outstanding_AsOn_Amt >0   " +
                                  StrFilterCriteria +
                                " GROUP BY AA.Fk_VendorID, AA.MVen_Code, AA.MVen_Name,PINV_No,vPINV_DT,PINV_HDR_Total_Gross_Amt ";
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Account Receviable
        public static DataTable Rpt_Get_Acc_Receivable_Summary(string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal();
                strSqlString = " SELECT AA.Fk_CustomerID,AA.MCust_Code, AA.MCust_Name,COUNT(AA.MCust_Name)NoOfInv, " +
                               " SUM(CASE WHEN DATEDIFF( d,AA.SINV_DT,Getdate() ) BETWEEN 0 AND 30 THEN AA.SINV_HDR_Outstanding_AsOn_Amt ELSE 0 END) ThirtyDays, " +
                               " SUM(CASE WHEN DATEDIFF( d,AA.SINV_DT,Getdate() ) BETWEEN 31 AND 60 THEN AA.SINV_HDR_Outstanding_AsOn_Amt ELSE 0 END) SixtyDays, " +
                               " SUM(CASE WHEN DATEDIFF( d,AA.SINV_DT,Getdate() ) BETWEEN 61 AND 90 THEN AA.SINV_HDR_Outstanding_AsOn_Amt ELSE 0 END) NintyDays, " +
                               " SUM(CASE WHEN DATEDIFF( d,AA.SINV_DT,Getdate() ) > 91 THEN AA.SINV_HDR_Outstanding_AsOn_Amt ELSE 0 END) AboveNintyDays	 " +
                               " FROM v_M_AT_Sales_Inv_AHDR AA  " + strWhereClause +
                               " AND AA.Fk_Company_ID=" + ObjSession.Company.CompanyID +
                               " AND AA.Fk_Branch_ID=" + ObjSession.Company.BranchID +
                               " AND AA.MDBSC_RowStatus='' " +
                               " AND AA.SINV_HDR_Outstanding_AsOn_Amt >0   " +
                                 StrFilterCriteria +
                               " GROUP BY AA.Fk_CustomerID,AA.MCust_Code, AA.MCust_Name ";

                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Rpt_Get_Acc_Receivable_Detail(string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal();
                strSqlString = " SELECT AA.Fk_CustomerID, AA.MCust_Code, AA.MCust_Name,SINV_No,vSINV_DT,SINV_HDR_Total_Gross_Amt, " +
                                " SUM(CASE WHEN DATEDIFF( d,AA.SINV_DT,Getdate() ) BETWEEN 0 AND 30 THEN AA.SINV_HDR_Outstanding_AsOn_Amt ELSE 0 END) ThirtyDays, " +
                                " SUM(CASE WHEN DATEDIFF( d,AA.SINV_DT,Getdate() ) BETWEEN 31 AND 60 THEN AA.SINV_HDR_Outstanding_AsOn_Amt ELSE 0 END) SixtyDays, " +
                                " SUM(CASE WHEN DATEDIFF( d,AA.SINV_DT,Getdate() ) BETWEEN 61 AND 90 THEN AA.SINV_HDR_Outstanding_AsOn_Amt ELSE 0 END) NintyDays, " +
                                " SUM(CASE WHEN DATEDIFF( d,AA.SINV_DT,Getdate() ) > 91 THEN AA.SINV_HDR_Outstanding_AsOn_Amt ELSE 0 END) AboveNintyDays	 " +
                                " FROM v_M_AT_Sales_Inv_AHDR AA  " + strWhereClause +
                                " AND AA.Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                " AND AA.Fk_Branch_ID=" + ObjSession.Company.BranchID +
                                " AND AA.MDBSC_RowStatus='' " +
                                " AND AA.SINV_HDR_Outstanding_AsOn_Amt >0   " +
                                  StrFilterCriteria +
                                " GROUP BY AA.Fk_CustomerID, AA.MCust_Code, AA.MCust_Name,SINV_No,vSINV_DT,SINV_HDR_Total_Gross_Amt ";
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
