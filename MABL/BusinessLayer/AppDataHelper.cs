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
    public static class AppDataHelper
    {
        public static DataTable Get_ItemGroup_ByMainCategory(string MIC_ID)
        {
            string strSqlString = "";
            try
            {

                strSqlString = " Select  0 value,'--Select Item Group--' Text,0 RSN " +
                               " UNION ALL " +
                               " Select IG_ID ,Item_Group,1 RSN " +
                               " from M_AT_Mst_ItemGroup " +
                               " WHERE Fk_MIC_ID=" + MIC_ID +
                               " Order By RSN asc, Text asc ";

                return MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_ItemSubGroup_ByItemGroup(string IG_ID)
        {
            string strSqlString = "";
            try
            {

                strSqlString = " Select  0 value,'--Select Sub Group--' Text,0 RSN " +
                               " UNION ALL " +
                               " Select ISG_ID ,Item_SubGroup,1 RSN " +
                               " from M_AT_Mst_ItemSubGroup " +
                               " WHERE Fk_IG_ID=" + IG_ID +
                               " Order By RSN asc, Text asc ";

                return MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_AppFeedback(Int64 MAF_ID, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                if (MAF_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_AAA_M_RT_AppFeedback" + strWhereClause + " ORDER BY  MAF_ID DESC";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_AAA_M_RT_AppFeedback  Where   MAF_ID=0" + MAF_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
