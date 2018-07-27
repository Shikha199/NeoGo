using MaheshAF18.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MABL.BL
{
    public static class AppBL
    {
        public static DataTable Get_App_Branch_List(Int64 M_RT_CMP_BR_ID, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                MaheshAF18.WebSession.SessionPageLocal ObjSessionData = new MaheshAF18.WebSession.SessionPageLocal();
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);

                string varStrCond = "";

               // varStrCond = " AND M_RT_CMP_BR_ID IN (1)  ";

                if (varStrCond.Length > 0)
                {
                    if (M_RT_CMP_BR_ID == 0)
                    {
                        strSqlString = "SELECT * FROM v_AAA_M_RT_CMP_Branch" + strWhereClause + " AND FK_M_RT_CMP_ID=" + ObjSessionData.Company.CompanyID + varStrCond;
                    }
                    else
                    {
                        strSqlString = "SELECT * FROM v_AAA_M_RT_CMP_Branch  Where  M_RT_CMP_BR_ID=0" + M_RT_CMP_BR_ID + varStrCond;
                    }

                }
                else
                {
                    strSqlString = "SELECT * FROM v_AAA_M_RT_CMP_Branch  Where  FK_M_RT_CMP_ID=" + ObjSessionData.Company.CompanyID + " AND  M_RT_CMP_BR_ID=0" + M_RT_CMP_BR_ID + varStrCond;
                }

                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_Tax_DD(String Tax_Category, Int64 Tax_ID)
        {
            string strSqlString = "";
            try
            {
                if (Tax_ID > 0)
                {
                    strSqlString = " Select  0 value,'--Select Tax --' Text,0 RSN " +
                                   " UNION ALL " +
                                   " Select Tax_ID ,CONVERT(varchar(6),Tax_Rate) Text,1 RSN " +
                                   " from v_M_AT_Mst_Tax " +
                                   " WHERE Tax_Category='" + Tax_Category + "' AND Tax_ID=" + Tax_ID +
                                   " Order By RSN asc, Text asc ";

                }
                else
                {
                    strSqlString = " Select  0 value,'--Select Tax --' Text,0 RSN " +
                              " UNION ALL " +
                              " Select Tax_ID ,CONVERT(varchar(6),Tax_Rate) Text,1 RSN " +
                              " from v_M_AT_Mst_Tax " +
                              " WHERE Tax_Category='" + Tax_Category + "'" +
                              " Order By RSN asc, Text asc ";

                }

                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable DD_Get_YearList(Int32 CurrentYear)
        {

            try
            {
                DataTable dt = new DataTable("YearList");
                dt.Columns.Add("Value", typeof(int));
                dt.Columns.Add("Text", typeof(string));

                Int32 varYear = 1;
                varYear = CurrentYear - 1;

                if (CurrentYear > 0)
                {
                    dt.Rows.Add(0, "--Select Year--");
                    dt.Rows.Add(CurrentYear, CurrentYear.ToString());
                    dt.Rows.Add(varYear, varYear.ToString());
                }
                else
                {
                    dt.Rows.Add(0, "--Select Year--");
                    dt.Rows.Add(CurrentYear, CurrentYear.ToString());
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
    }
}
