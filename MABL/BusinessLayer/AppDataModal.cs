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
     
    public static class AppDataModal
    {
       
        //MASTER DATA LIST 
        public static DataTable Get_Mst_Customer(Int64 M_Cust_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal(); 
                if (M_Cust_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Mst_Customer" + strWhereClause +
                                   " AND Fk_Company_ID="+ ObjSession.Company.CompanyID +  
                                   " AND Fk_Branch_ID="+  ObjSession.Company.BranchID + 
                                   StrFilterCriteria + " Order By MCust_Name asc";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Mst_Customer  " +
                                   " Where Fk_Company_ID="+ ObjSession.Company.CompanyID +  
                                   " AND   Fk_Branch_ID="+  ObjSession.Company.BranchID + " AND  M_Cust_ID=0" + M_Cust_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable Get_Mst_Invoice(Int64 EWBillHDR_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal();
                if (EWBillHDR_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Sales_Inv_AHDR" + strWhereClause +
                                   " AND Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND Fk_Branch_ID=" + ObjSession.Company.BranchID +
                                   StrFilterCriteria + " Order By MCust_Name asc";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Sales_Inv_AHDR  " +
                                   " Where Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND   Fk_Branch_ID=" + ObjSession.Company.BranchID + " AND  M_Cust_ID=0" + EWBillHDR_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_Mst_Vendor(Int64 M_Ven_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal(); 
                if (M_Ven_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Mst_Vendor" + strWhereClause +
                                   " AND Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND Fk_Branch_ID=" + ObjSession.Company.BranchID + 
                                    StrFilterCriteria + " Order By MVen_Name asc";
                }
                else
                {
                    strSqlString = " SELECT * FROM v_M_AT_Mst_Vendor  " + 
                                   " Where Fk_Company_ID="+ ObjSession.Company.CompanyID +  
                                   " AND   Fk_Branch_ID="+  ObjSession.Company.BranchID + " AND  M_Ven_ID=0" + M_Ven_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_Mst_Item(Int64 MItem_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal(); 
                if (MItem_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Mst_ItemMaster" + strWhereClause + StrFilterCriteria +
                                   " AND Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND Fk_Branch_ID=" + ObjSession.Company.BranchID +  "  Order By Item_Name ASC";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Mst_ItemMaster  " + StrFilterCriteria  +
                                   " Where Fk_Company_ID="+ ObjSession.Company.CompanyID +  
                                   " AND   Fk_Branch_ID="+  ObjSession.Company.BranchID + " AND   MItem_ID=0" + MItem_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

//HSNSAC
        public static DataTable Get_HSNSAC_Item(Int64 CHID_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal();
                if (CHID_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Mst_CMP_HSNSAC" + strWhereClause + StrFilterCriteria +
                                   " AND Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND Fk_Branch_ID=" + ObjSession.Company.BranchID + "  Order By HSNCode ASC";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Mst_CMP_HSNSAC  " + StrFilterCriteria +
                                   " Where Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND   Fk_Branch_ID=" + ObjSession.Company.BranchID + " AND   CHID_ID=0" + CHID_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable Get_Mst_UOM(Int64 UOM_ID, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal();
                if (UOM_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Mst_UOM" + strWhereClause + "  Order By v_UOM_DisplayName ASC";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Mst_UOM  " +
                                   " Where    UOM_ID=0" + UOM_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_Mst_HSN(Int64 HS_ID, string StrFilterCriteria, string SearchCriteria)

        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                if (HS_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Mst_HSNSAC" + strWhereClause + StrFilterCriteria + " Order By HS_CODE asc";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Mst_HSNSAC  " + " AND  HS_ID=0" + HS_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_Mst_State(Int64 State_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                if (State_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_AAA_M_RT_GEO_State" + strWhereClause + StrFilterCriteria + " Order By GStateName asc";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_AAA_M_RT_GEO_State  " + " AND  GStateID=0" + State_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // JOB WOrk
        public static DataTable Get_JoBWork_List(Int64 JW_HDR_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal();
                if (JW_HDR_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Proc_JW_AHDR" + strWhereClause +
                                   " AND Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND Fk_Branch_ID=" + ObjSession.Company.BranchID + StrFilterCriteria + "  ORDER BY   JW_HDR_ID desc  ";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Proc_JW_AHDR  " +
                                   " Where Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND   Fk_Branch_ID=" + ObjSession.Company.BranchID + " AND        JW_HDR_ID=0" + JW_HDR_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Job Work
        public static DataTable Get_JoBWork_Item_List(Int64 JW_HDR_ID, Int64 JW_DTL_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                if (JW_DTL_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Proc_JW_BDTL" + strWhereClause + StrFilterCriteria +
                                   " AND  Fk_JW_HDR_ID=" + JW_HDR_ID +
                                   "  ORDER BY    JW_DTL_ID ASC";
                }

                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Proc_JW_BDTL  Where Fk_JW_HDR_ID=" + JW_HDR_ID + " AND   JW_DTL_ID=0" + JW_DTL_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
       

        //PURCHASE
        public static DataTable Get_Purchase_List(Int64 PINVHDR_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal(); 
                if (PINVHDR_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Purchase_Inv_AHDR" + strWhereClause +
                                   " AND Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND Fk_Branch_ID=" + ObjSession.Company.BranchID + StrFilterCriteria + "  ORDER BY   PINVHDR_ID desc  ";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Purchase_Inv_AHDR  " +
                                   " Where Fk_Company_ID="+ ObjSession.Company.CompanyID +  
                                   " AND   Fk_Branch_ID="+  ObjSession.Company.BranchID + " AND      PINVHDR_ID=0" + PINVHDR_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_Purchase_Item_List(Int64 PINVHDR_ID, Int64 PINVDTL_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                
                if (PINVDTL_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Purchase_Inv_BDTL" + strWhereClause + StrFilterCriteria +
                                   " AND  Fk_PINVHDR_ID=" + PINVHDR_ID +
                                   "  ORDER BY    PINVDTL_ID ASC";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Purchase_Inv_BDTL  Where Fk_PINVHDR_ID=" + PINVHDR_ID + " AND   PINVDTL_ID=0" + PINVDTL_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_Purchase_Tax_List(Int64 PINVHDR_ID, Int64 PINVTDTL_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                if (PINVTDTL_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Purchase_Inv_TaxDTL" + strWhereClause + StrFilterCriteria + 
                                   " AND  PINVHDR_ID=" + PINVHDR_ID +
                                   "  Order By PINVTDTL_ID ASC";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Purchase_Inv_TaxDTL  Where PINVHDR_ID=" + PINVHDR_ID + " AND   PINVTDTL_ID=0" + PINVTDTL_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Job Purchase
        public static DataTable Get_JobPurchase_List(Int64 JWINVTDTL_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal();
                if (JWINVTDTL_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_JW_Inv_AHDR" + strWhereClause +
                                   " AND Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND Fk_Branch_ID=" + ObjSession.Company.BranchID + StrFilterCriteria + "  ORDER BY   JWINVTDTL_ID desc  ";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Purchase_Inv_AHDR  " +
                                   " Where Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND   Fk_Branch_ID=" + ObjSession.Company.BranchID + " AND      PINVHDR_ID=0" + JWINVTDTL_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_JOBPurchase_Item_List(Int64 JWINVHDR_ID, Int64 JWINVDTL_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);

                if (JWINVDTL_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_JW_Inv_BDTL" + strWhereClause + StrFilterCriteria +
                                   " AND  Fk_JWINVHDR_ID=" + JWINVHDR_ID +
                                   "  ORDER BY    JWINVDTL_ID ASC";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_JW_Inv_BDTL  Where Fk_JWINVHDR_ID=" + JWINVHDR_ID + " AND   JWINVDTL_ID=0" + JWINVDTL_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_JOBPurchase_Tax_List(Int64 JWINVHDR_ID, Int64 JWINVDTL_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                if (JWINVDTL_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_JW_Inv_TaxDTL" + strWhereClause + StrFilterCriteria +
                                   " AND  JWINVHDR_ID=" + JWINVHDR_ID +
                                   "  Order By JWINVDTL_ID ASC";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_JW_Inv_TaxDTL  Where JWINVHDR_ID=" + JWINVHDR_ID + " AND   JWINVDTL_ID=0" + JWINVDTL_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        // SALES
        public static DataTable Get_Sales_List(Int64 SINVHDR_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal(); 
                if (SINVHDR_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Sales_Inv_AHDR" + strWhereClause +
                                   " AND Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND Fk_Branch_ID=" + ObjSession.Company.BranchID + StrFilterCriteria + "  ORDER BY   SINVHDR_ID desc  ";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Sales_Inv_AHDR  " +
                                   " Where Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND   Fk_Branch_ID=" + ObjSession.Company.BranchID + " AND        SINVHDR_ID=0" + SINVHDR_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_Sales_Item_List(Int64 SINVHDR_ID, Int64 SINVDTL_ID, string StrFilterCriteria, string SearchCriteria)
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
        //Eway Bill
        public static DataTable Get_EwayBill_List(Int64 SEWB_HDR_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal();
                if (SEWB_HDR_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Sales_SEWB_AHDR" + strWhereClause +
                                    "  ORDER BY   SEWB_HDR_ID desc  ";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Sales_SEWB_AHDR  " + strWhereClause  +
                                    " AND SEWB_HDR_ID=0" + SEWB_HDR_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_EwayBill_Item_List(Int64 SEWB_HDR_ID, Int64 SEWB_CTL_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);

                if (SEWB_CTL_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Sales_SEWB_CDTL" + strWhereClause  +
                                   " AND  Fk_SEWB_HDR_ID=" + SEWB_HDR_ID +
                                   " ORDER BY    SEWB_CTL_ID ASC";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Sales_SEWB_CDTL  " + strWhereClause + 
                                    " AND  Fk_SEWB_HDR_ID=" + SEWB_HDR_ID +
                                   " And SEWB_CTL_ID=0" + SEWB_CTL_ID;
                    
                }

               
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_EwayBill_Tax_List(Int64 SEWB_HDR_ID, Int64 SEWB_DTL_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                if (SEWB_DTL_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Sales_SEWB_CDTL" + strWhereClause + StrFilterCriteria +
                                   " AND  SEWB_HDR_ID=" + SEWB_HDR_ID +
                                   "  Order By SEWB_DTL_ID ASC";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Sales_SEWB_CDTL  Where SEWB_HDR_ID=" + SEWB_HDR_ID + " AND   SEWB_DTL_ID=0" + SEWB_DTL_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
       
        // SALES PI
        public static DataTable Get_Sales_PI_List(Int64 SPIHDR_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal();
                if (SPIHDR_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Sales_PI_AHDR" + strWhereClause +
                                   " AND Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND Fk_Branch_ID=" + ObjSession.Company.BranchID + StrFilterCriteria + "  ORDER BY   SPIHDR_ID desc  ";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Sales_PI_AHDR  " +
                                   " Where Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND   Fk_Branch_ID=" + ObjSession.Company.BranchID + " AND        SPIHDR_ID=0" + SPIHDR_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_Sales_PI_Item_List(Int64 SPIHDR_ID, Int64 SPIDTL_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                if (SPIDTL_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Sales_PI_BDTL" + strWhereClause + StrFilterCriteria +
                                   " AND  Fk_SPIHDR_ID=" + SPIHDR_ID +
                                   "  ORDER BY    SPIDTL_ID ASC";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Sales_PI_BDTL  Where Fk_SPIHDR_ID=" + SPIHDR_ID + " AND   SINVDTL_ID=0" + SPIDTL_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // DC
        public static DataTable Get_Sales_DC_List(Int64 DCHDR_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal(); 
                if (DCHDR_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Sales_DC_AHDR " + strWhereClause +
                                   " AND Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND Fk_Branch_ID=" + ObjSession.Company.BranchID + StrFilterCriteria + "  ORDER BY   DCHDR_ID desc  ";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Sales_DC_AHDR  " +
                                   " Where Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND   Fk_Branch_ID=" + ObjSession.Company.BranchID + " AND        DCHDR_ID=0" + DCHDR_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_Sales_DC_Item_List(Int64 DCHDR_ID, Int64 DCDTL_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                if (DCDTL_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Sales_DC_BDTL" + strWhereClause + StrFilterCriteria +
                                   " AND  Fk_DCHDR_ID=" + DCHDR_ID +
                                   "  ORDER BY    DCDTL_ID ASC";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Sales_DC_BDTL  Where Fk_DCHDR_ID=" + DCHDR_ID + " AND   DCDTL_ID=0" + DCDTL_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Customer Payment
        public static DataTable Get_CustPayment_List(Int64 ACPHDR_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal(); 
                if (ACPHDR_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Acc_Payment_Customer_AHDR" + strWhereClause +
                                   " AND Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND Fk_Branch_ID=" + ObjSession.Company.BranchID + StrFilterCriteria + "  ORDER BY   ACPHDR_ID desc  ";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Acc_Payment_Customer_AHDR  " +
                                   " Where Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND   Fk_Branch_ID=" + ObjSession.Company.BranchID + " AND        ACPHDR_ID=0" + ACPHDR_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_CustPayment_Inv_List(Int64 ACPHDR_ID, Int64 ACPDTL_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal(); 
                strSqlString = " SELECT ACPDTL_ID,Fk_ACPHDRID,Fk_InvoiceID,SINV_No,vSINV_DT,Inv_Adjusted_Amt,SINV_HDR_Total_Gross_Amt,SINV_HDR_Paid_AsOn_Amt,SINV_HDR_Outstanding_AsOn_Amt " +
                                  " FROM   v_M_AT_Acc_Payment_Customer_BDTL " +
                                  " WHERE Fk_ACPHDRID=" + ACPHDR_ID +
                                  " UNION ALL " +
                                  " SELECT 0 ACPDTL_ID," + ACPHDR_ID + " Fk_ACPHDRID,SINVHDR_ID,SINV_No,vSINV_DT,0 Inv_Adjusted_Amt,SINV_HDR_Total_Gross_Amt,SINV_HDR_Paid_AsOn_Amt,SINV_HDR_Outstanding_AsOn_Amt " +
                                  " FROM   v_M_AT_Sales_Inv_AHDR " +
                                  " Where Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                  " AND   Fk_Branch_ID=" + ObjSession.Company.BranchID +
                                  " AND Fk_CustomerID IN (SELECT Fk_CustomerID FROM M_AT_Acc_Payment_Customer_AHDR WHERE ACPHDR_ID=" + ACPHDR_ID + " ) " +
                                  " AND SINVHDR_ID NOT IN (SELECT Fk_InvoiceID FROM M_AT_Acc_Payment_Customer_BDTL WHERE Fk_ACPHDRID=" + ACPHDR_ID + " ) " +
                                  " ORDER BY Fk_InvoiceID desc ";
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Vendor Payment
        public static DataTable Get_VenPayment_List(Int64 AVPHDR_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal(); 
                if (AVPHDR_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Acc_Payment_Vendor_AHDR " + strWhereClause +
                                   " AND Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND Fk_Branch_ID=" + ObjSession.Company.BranchID + StrFilterCriteria + "  ORDER BY   AVPHDR_ID desc  ";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Acc_Payment_Vendor_AHDR  " +
                                   " Where Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND   Fk_Branch_ID=" + ObjSession.Company.BranchID + " AND        AVPHDR_ID=0" + AVPHDR_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_VenPayment_Inv_List(Int64 AVPHDR_ID, Int64 AVPDTL_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal(); 
                strSqlString = " SELECT AVPDTL_ID,Fk_AVPHDRID,Fk_InvoiceID,PINV_No,vPINV_DT,Inv_Adjusted_Amt,PINV_HDR_Total_Gross_Amt,PINV_HDR_Paid_AsOn_Amt,PINV_HDR_Outstanding_AsOn_Amt " +
                                  " FROM   v_M_AT_Acc_Payment_Vendor_BDTL " +
                                  " WHERE Fk_AVPHDRID=" + AVPHDR_ID +
                                  " UNION ALL " +
                                  " SELECT 0 AVPDTL_ID," + AVPHDR_ID + " Fk_AVPHDRID,PINVHDR_ID,PINV_No,vPINV_DT,0 Inv_Adjusted_Amt,PINV_HDR_Total_Gross_Amt,PINV_HDR_Paid_AsOn_Amt,PINV_HDR_Outstanding_AsOn_Amt " +
                                  " FROM   v_M_AT_Purchase_Inv_AHDR " +
                                  " Where Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                  " AND   Fk_Branch_ID=" + ObjSession.Company.BranchID + 
                                  " AND Fk_VendorID IN (SELECT Fk_VendorID FROM M_AT_Acc_Payment_Vendor_AHDR WHERE AVPHDR_ID=" + AVPHDR_ID + " ) " +
                                  " AND PINVHDR_ID NOT IN (SELECT Fk_InvoiceID FROM M_AT_Acc_Payment_Vendor_BDTL WHERE Fk_AVPHDRID=" + AVPHDR_ID + " ) " +
                                  " ORDER BY Fk_InvoiceID desc ";
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Customer DCN
        public static DataTable Get_Cust_DCN_List(Int64 DCNCHDR_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal(); 
                if (DCNCHDR_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_DNC_Cust_AHDR" + strWhereClause +
                                   " AND Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND Fk_Branch_ID=" + ObjSession.Company.BranchID + StrFilterCriteria + "  ORDER BY   DCNCHDR_ID desc  ";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_DNC_Cust_AHDR  " +
                                   " Where Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND   Fk_Branch_ID=" + ObjSession.Company.BranchID + " AND DCNCHDR_ID=0" + DCNCHDR_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_Cust_DCN_Item_List(Int64 DCNCHDR_ID, Int64 DCNCDTL_ID, string StrFilterCriteria, string SearchCriteria)
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
                    strSqlString = "SELECT * FROM v_M_AT_DNC_Cust_BDTL  Where Fk_DCNCHDR_ID=" + DCNCHDR_ID + " AND   DCNCDTL_ID=0" + DCNCDTL_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Vendor DCN
        public static DataTable Get_Ven_DCN_List(Int64 DCNVHDR_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal(); 
                if (DCNVHDR_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_DNC_Ven_AHDR" + strWhereClause +
                                   " AND Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND Fk_Branch_ID=" + ObjSession.Company.BranchID + StrFilterCriteria + "  ORDER BY   DCNVHDR_ID desc  ";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_DNC_Ven_AHDR  " +
                                   " Where Fk_Company_ID=" + ObjSession.Company.CompanyID +
                                   " AND   Fk_Branch_ID=" + ObjSession.Company.BranchID + " AND    DCNVHDR_ID=0" + DCNVHDR_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable Get_Ven_DCN_Item_List(Int64 DCNVHDR_ID, Int64 DCNVDTL_ID, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                if (DCNVDTL_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_DNC_Ven_BDTL" + strWhereClause + StrFilterCriteria +
                                   " AND  Fk_DCNVHDR_ID=" + DCNVHDR_ID +
                                   "  ORDER BY    DCNVDTL_ID ASC";
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_DNC_Ven_BDTL  Where Fk_DCNVHDR_ID=" + DCNVHDR_ID + " AND   DCNVDTL_ID=0" + DCNVDTL_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static DataTable Get_Excel_File_Column_List(Int64 GSTIN, string StrFilterCriteria, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                MaheshAF18.WebSession.SessionPageLocal ObjSession = new MaheshAF18.WebSession.SessionPageLocal();
                strSqlString = "SELECT * FROM v_M_AT_Upload_File_BDTL" + strWhereClause +  StrFilterCriteria + "  ORDER BY   FUDTL_ID asc  ";
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
