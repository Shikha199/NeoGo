using JEMEAWAPI.APIDL;
using MABL.ATDataModal;
using MaheshAF18.Application;
using MaheshAF18.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Transactions;
using System.Web;

namespace JEMEAWAPI.Models
{
    public class SalesModels
    {
        public class SalesHDR
        {
            public Int64 S_HDR_ID { get; set; }
            public Int64 Fk_Company_ID { get; set; }
            public Int64 Fk_Branch_ID { get; set; }
            public Int64 Fk_Year_ID { get; set; }
            public Int64 S_Fk_INVHDR_ID { get; set; }
            public Int64 S_Fk_CustomerID { get; set; }

            public String S_Category { get; set; }
            public String S_TrnType { get; set; }
            public String S_Type { get; set; }
            public String S_Taxtype { get; set; }
            public String S_RCM { get; set; }

            public String S_No { get; set; }
            public String S_DT { get; set; }
            public String S_MCust_Name { get; set; }





            public String S_DCNC_No { get; set; }
            public String S_DCNC_DT { get; set; }

            public Int64 S_BR_Reg_State_ID { get; set; }
            public String S_BR_Reg_StateDisplayName { get; set; }
            public String S_BL_GSTNO { get; set; }
            public String S_BL_PANNO { get; set; }


            public Int64 S_MCust_Reg_State_ID { get; set; }
            public String S_MCust_Reg_StateDisplayName { get; set; }
            public String S_MCust_BL_GSTNO { get; set; }
            public String S_MCust_BL_PANNO { get; set; }

            public Int64 S_BillTo_State_ID { get; set; }
            public String S_BillTo_StateDisplayName { get; set; }
            public String S_BillTo_GSTNo { get; set; }
            public String S_BillTo_PANNO { get; set; }


            public Int64 S_ShippTo_State_ID { get; set; }
            public String S_ShippTo_StateDisplayName { get; set; }
            public String S_ShippTo_GSTNo { get; set; }
            public String S_ShippTo_PANNO { get; set; }


            public Int64 S_ShippedFrom_State_ID { get; set; }
            public String S_ShippedFrom_StateDisplayName { get; set; }
            public String S_ShippedFrom_GSTNo { get; set; }
            public String S_ShippedFrom_PANNO { get; set; }


            public Int64 S_CreditDays { get; set; }
            public String S_DueDT { get; set; }
          
            public String S_PONo { get; set; }
            public String S_PO_DT { get; set; }

            public String S_BillTo_CompanyName { get; set; }
            public String S_BillTo_ContactPersone { get; set; }
            public String S_BillTo_CP_MobileNo { get; set; }
            public String S_BillTo_Add1 { get; set; }
            public String S_BillTo_Add2 { get; set; }
            public String S_BillTo_Add3 { get; set; }

            public String S_BillTo_Pincode { get; set; }
            public String S_BillTo_Area { get; set; }
            public String S_BillTo_City { get; set; }

            public String S_BillTo_Country { get; set; }

            public String S_ShippTo_CompanyName { get; set; }
            public String S_ShippTo_ContactPersone { get; set; }
            public String S_ShippTo_CP_MobileNo { get; set; }
            public String S_ShippTo_Add1 { get; set; }
            public String S_ShippTo_Add2 { get; set; }
            public String S_ShippTo_Add3 { get; set; }
            public String S_ShippTo_Pincode { get; set; }
            public String S_ShippTo_Area { get; set; }
            public String S_ShippTo_City { get; set; }

            public String S_ShippTo_Country { get; set; }

            public String S_ShippedFrom_CompanyName { get; set; }
            public String S_ShippedFrom_ContactPersone { get; set; }
            public String S_ShippedFrom_CP_MobileNo { get; set; }
            public String S_ShippedFrom_Add1 { get; set; }
            public String S_ShippedFrom_Add2 { get; set; }
            public String S_ShippedFrom_Add3 { get; set; }
            public String S_ShippedFrom_Pincode { get; set; }
            public String S_ShippedFrom_Area { get; set; }
            public String S_ShippedFrom_City { get; set; }

            public String S_ShippedFrom_Country { get; set; }

            public String S_PaymentTerms { get; set; }
            public String S_DelvieryPeriod { get; set; }
            public String S_DeliveryCharges { get; set; }
            public String S_ExciseDuty { get; set; }
            public String S_CompletionPeriod { get; set; }
            public String S_ModeOfDispatch { get; set; }
            public String S_TranspoterName { get; set; }
            public String S_VehicleNumber { get; set; }
            public String S_PlaceOfDelivery { get; set; }
            public String S_FreigthCharge_Txt { get; set; }
            public String S_Insurance_Txt { get; set; }
            public String S_Remark { get; set; }
            public Int16 S_DTL_CNT { get; set; }
            public Decimal S_HDR_BasicAmt { get; set; }
            public Decimal S_HDR_DiscountRate { get; set; }
            public Decimal S_HDR_DiscountAmt { get; set; }
            public Decimal S_HDR_Net_Amt { get; set; }
            public Decimal S_HDR_Freight_Charges { get; set; }
            public Decimal S_HDR_Loading_N_Packing_Charges { get; set; }
            public Decimal S_HDR_Insurance_Charges { get; set; }
            public String S_HDR_Other_Charges_Txt { get; set; }
            public Decimal S_HDR_Other_Charges_Amt { get; set; }
            public Decimal S_HDR_Taxable_Amt { get; set; }
            public Decimal S_HDR_CGST_Amt { get; set; }
            public Decimal S_HDR_CGST_Taxable_Amt { get; set; }
            public Decimal S_HDR_SGST_Amt { get; set; }
            public Decimal S_HDR_SGST_Taxable_Amt { get; set; }
            public Decimal S_HDR_IGST_Amt { get; set; }
            public Decimal S_HDR_IGST_Taxable_Amt { get; set; }
            public Decimal S_HDR_CESS_Amt { get; set; }
            public Decimal S_HDR_CESS_Taxable_Amt { get; set; }
            public Int16 S_HDR_OtherTax_ID { get; set; }
            public Decimal S_HDR_OtherTax_Rate { get; set; }
            public Decimal S_HDR_OtherTax_Amt { get; set; }
            public Decimal S_HDR_Other_Taxable_Amt { get; set; }
            public Decimal S_HDR_Total_Tax_Amt { get; set; }
            public Decimal S_HDR_ItemGross_Total_Amt { get; set; }
            public Decimal S_HDR_Gross_Amt { get; set; }
            public Decimal S_HDR_Round_Off_Amt { get; set; }
            public Decimal S_HDR_Total_Gross_Amt { get; set; }
            public String S_HDR_Gross_AmtInWords { get; set; }
            public Decimal S_HDR_CreditNote_AsOn_Amt { get; set; }
            public Decimal S_HDR_DebitNote_AsOn_Amt { get; set; }
            public Decimal S_HDR_TDS_Rate { get; set; }
            public Decimal S_HDR_TDS_Amt { get; set; }
            public Decimal S_HDR_Paid_AsOn_Amt { get; set; }
            public Decimal S_HDR_Outstanding_AsOn_Amt { get; set; }

            public String MDBSC_RowStatus { get; set; }
            public Int16 MDBSC_RowCreatedByUser_ID { get; set; }
            public String MDBSC_RowCreatedByUserName { get; set; }
            public String MDBSC_RowCreatedOn_DT { get; set; }
            public Int16 MDBSC_RowLupdnByUser_ID { get; set; }
            public String MDBSC_RowLupdnUserName { get; set; }
            public String MDBSC_RowLupdnOn_DT { get; set; }


            public List<SalesDTL> SINVDTL { get; set; }

        }
        public class SalesDTL
        {
            public Int64 SI_DTL_ID { get; set; }
            public Int64 SI_HDR_ID { get; set; }
            public Int64 SI_Fk_MItem_ID { get; set; }
            public String SI_HSNCode { get; set; }
            public String SI_Item_Type { get; set; }
            public String SI_Item_Code { get; set; }
            public String SI_Item_Name { get; set; }
            public String SI_UOM { get; set; }


            public String SI_Computation_Type { get; set; }
            public Decimal SI_QTY { get; set; }
            public Decimal SI_BasicRate { get; set; }
            public Decimal SI_NetRate { get; set; }
            public Decimal SI_BasicAmt { get; set; }
            public Decimal SI_DiscountRate { get; set; }
            public Decimal SI_DiscountAmt { get; set; }
            public Decimal SI_NetTaxableAmt { get; set; }
            public Int16 SI_GST_TaxRate_ID { get; set; }
            public Decimal SI_GST_TaxRate { get; set; }
            public Int16 SI_CGST_ID { get; set; }
            public Decimal SI_CGST_Rate { get; set; }
            public Decimal SI_CGST_Amt { get; set; }
            public Decimal SI_CGST_TaxableAmt { get; set; }
            public Int16 SI_SGST_ID { get; set; }
            public Decimal SI_SGST_Rate { get; set; }
            public Decimal SI_SGST_Amt { get; set; }
            public Decimal SI_SGST_TaxableAmt { get; set; }
            public Int16 SI_IGST_ID { get; set; }
            public Decimal SI_IGST_Rate { get; set; }
            public Decimal SI_IGST_Amt { get; set; }
            public Decimal SI_IGST_TaxableAmt { get; set; }
            public Int16 SI_CESS_ID { get; set; }
            public Decimal SI_CESS_Rate { get; set; }
            public Decimal SI_CESS_Amt { get; set; }
            public Decimal SI_CESS_TaxableAmt { get; set; }
            public Int16 SI_OtherTax_ID { get; set; }
            public Decimal SI_OtherTax_Rate { get; set; }
            public Decimal SI_OtherTax_Amt { get; set; }
            public Decimal SI_OtherTax_TaxableAmt { get; set; }
            public Decimal SI_TotalTax { get; set; }
            public Decimal SI_GrossRateWithTax { get; set; }
            
            public String SI_ItemRemark_DTL { get; set; }
            public String IsDelete { get; set; }
            public String MDBSC_RowStatus { get; set; }

        }


        //List
        public static ArrayList Get_Sales_Common_Lst(string StrFilterCriteria, string SearchCriteria)
        {
            ArrayList items = new ArrayList();
            DataTable dt = new DataTable();
            try
            {
                dt = AppData.Get_DT_Sales_Common_List(StrFilterCriteria, SearchCriteria);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        var objList = new Dictionary<object, object>();

                        objList["RecType"] = row["RecType"];
                        objList["TrnType"] = row["TrnType"];
                         
                        objList["TrnHDR_ID"] = row["TrnHDR_ID"];
                        objList["Fk_Company_ID"] = row["Fk_Company_ID"];
                        objList["Fk_Branch_ID"] = row["Fk_Branch_ID"];
                        objList["Fk_Year_ID"] = row["Fk_Year_ID"];
                        objList["TrnNo"] = row["TrnNo"];
                        objList["TrnDT"] = row["TrnDT"];
                        objList["PartyType"] = row["PartyType"];
                        objList["PartyID"] = row["PartyID"];
                        objList["PartyName"] = row["PartyName"];
                        objList["NoOFDtl"] = row["NoOFDtl"];
                        objList["TrnTotalAmt"] = row["TrnTotalAmt"];


                        items.Add(objList);
                    }

                }
                else
                {
                    items = null;
                }
                return items;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static ArrayList Get_Sales_Invoice(Int64 mvSINVHDR_ID, string StrFilterCriteria, string SearchCriteria)
        {
            ArrayList items = new ArrayList();
            DataTable dt = new DataTable();
            try
            {
                 
                dt = AppData.Get_DT_Sales_HDR_List(mvSINVHDR_ID, StrFilterCriteria, SearchCriteria);
                 
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        SalesHDR objINV = new SalesHDR();
                        objINV.S_HDR_ID = Convert.ToInt64(dt.Rows[i]["SINVHDR_ID"].ToString());
                        objINV.Fk_Company_ID = Convert.ToInt64(dt.Rows[i]["Fk_Company_ID"].ToString());
                        objINV.Fk_Branch_ID = Convert.ToInt64(dt.Rows[i]["Fk_Branch_ID"].ToString());
                        objINV.Fk_Year_ID = Convert.ToInt64(dt.Rows[i]["Fk_Year_ID"].ToString());

                        objINV.S_Category = dt.Rows[i]["SINV_Category"].ToString();

                        objINV.S_TrnType = dt.Rows[i]["SINV_TrnType"].ToString();
                        objINV.S_Type = dt.Rows[i]["SINV_Type"].ToString();
                        objINV.S_Taxtype = dt.Rows[i]["SINV_Taxtype"].ToString();
                        
                       




                        objINV.S_No = dt.Rows[i]["SINV_No"].ToString();
                        objINV.S_DT = dt.Rows[i]["vSINV_DT"].ToString();
                        objINV.S_Fk_CustomerID = Convert.ToInt64(dt.Rows[i]["Fk_CustomerID"].ToString());
                        objINV.S_MCust_Name = dt.Rows[i]["MCust_Name"].ToString();                        
                        objINV.S_CreditDays = Convert.ToInt64(dt.Rows[i]["SINV_CreditDays"].ToString());
                        objINV.S_DueDT = dt.Rows[i]["vSINV_DueDT"].ToString(); 
                        objINV.S_DTL_CNT = Convert.ToInt16(dt.Rows[i]["SINV_DTL_CNT"].ToString());
                        objINV.MDBSC_RowStatus = dt.Rows[i]["MDBSC_RowStatus"].ToString(); 
                        objINV.MDBSC_RowCreatedByUserName = dt.Rows[i]["MDBSC_RowCreatedByUserName"].ToString();
                        objINV.MDBSC_RowCreatedOn_DT = dt.Rows[i]["vMDBSC_RowCreatedOn_DT"].ToString();
                        objINV.MDBSC_RowLupdnUserName = dt.Rows[i]["MDBSC_RowLupdnUserName"].ToString();
                        objINV.MDBSC_RowLupdnOn_DT = dt.Rows[i]["vMDBSC_RowLupdnOn_DT"].ToString();
                        objINV.S_HDR_BasicAmt = Convert.ToDecimal(dt.Rows[i]["SINV_HDR_BasicAmt"].ToString());
                        objINV.S_HDR_DiscountRate = Convert.ToDecimal(dt.Rows[i]["SINV_HDR_DiscountRate"].ToString());
                        objINV.S_HDR_DiscountAmt = Convert.ToDecimal(dt.Rows[i]["SINV_HDR_DiscountAmt"].ToString());
                        objINV.S_HDR_Net_Amt = Convert.ToDecimal(dt.Rows[i]["SINV_HDR_Net_Amt"].ToString());
                        objINV.S_HDR_Total_Gross_Amt = Convert.ToDecimal(dt.Rows[i]["SINV_HDR_Total_Gross_Amt"].ToString()); 
                        items.Add(objINV);
                    }

                }
                else
                {
                    items = null;
                }
                return items;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static SalesHDR Get_TaxInv_Lst(Int64 mvSINVHDR_ID, string StrFilterCriteria, string SearchCriteria) 
        {
            
            DataTable dt = new DataTable();
            try
            {
                SalesHDR objINV = new SalesHDR();
                objINV.SINVDTL = new List<SalesDTL>();
                dt = AppData.Get_DT_Sales_HDR_List(mvSINVHDR_ID,StrFilterCriteria, SearchCriteria);
                if (dt.Rows.Count > 0)
                {
                    objINV.S_HDR_ID = Convert.ToInt64(dt.Rows[0]["SINVHDR_ID"].ToString());
                    objINV.Fk_Company_ID = Convert.ToInt64(dt.Rows[0]["Fk_Company_ID"].ToString());
                    objINV.Fk_Branch_ID = Convert.ToInt64(dt.Rows[0]["Fk_Branch_ID"].ToString());
                    objINV.Fk_Year_ID = Convert.ToInt64(dt.Rows[0]["Fk_Year_ID"].ToString());

                    objINV.S_Category = dt.Rows[0]["SINV_Category"].ToString();
                    objINV.S_TrnType = dt.Rows[0]["SINV_TrnType"].ToString();
                    objINV.S_Type = dt.Rows[0]["SINV_Type"].ToString();
                    objINV.S_Taxtype = dt.Rows[0]["SINV_Taxtype"].ToString();
                    objINV.S_Fk_CustomerID = Convert.ToInt64(dt.Rows[0]["Fk_CustomerID"].ToString());
                    objINV.S_MCust_Name = dt.Rows[0]["MCust_Name"].ToString();
                    objINV.S_No = dt.Rows[0]["SINV_No"].ToString();
                    objINV.S_DT = dt.Rows[0]["vSINV_DT"].ToString();
  

                    objINV.S_BR_Reg_State_ID = Convert.ToInt64(dt.Rows[0]["BR_Reg_State_ID"].ToString());
                    objINV.S_BR_Reg_StateDisplayName = dt.Rows[0]["BR_Reg_StateDisplayName"].ToString();
                    objINV.S_BL_GSTNO = dt.Rows[0]["BL_GSTNO"].ToString();
                    objINV.S_BL_PANNO = dt.Rows[0]["BL_PANNO"].ToString();




                    objINV.S_MCust_Reg_State_ID = Convert.ToInt64(dt.Rows[0]["MCust_Reg_State_ID"].ToString());
                    objINV.S_MCust_Reg_StateDisplayName = dt.Rows[0]["MCust_Reg_StateDisplayName"].ToString();
                    objINV.S_MCust_BL_GSTNO = dt.Rows[0]["MCust_BL_GSTNO"].ToString();
                    objINV.S_MCust_BL_PANNO = dt.Rows[0]["MCust_BL_PANNO"].ToString();


                    objINV.S_BillTo_State_ID = Convert.ToInt64(dt.Rows[0]["SINV_BillTo_State_ID"].ToString());
                    objINV.S_BillTo_StateDisplayName = dt.Rows[0]["SINV_BillTo_StateDisplayName"].ToString();
                    objINV.S_BillTo_GSTNo = dt.Rows[0]["SINV_BillTo_GSTNo"].ToString();
                    objINV.S_BillTo_PANNO = dt.Rows[0]["SINV_BillTo_PANNO"].ToString();


                    objINV.S_ShippTo_State_ID = Convert.ToInt64(dt.Rows[0]["SINV_ShippTo_State_ID"].ToString());
                    objINV.S_ShippTo_StateDisplayName = dt.Rows[0]["SINV_ShippTo_StateDisplayName"].ToString();
                    objINV.S_ShippTo_GSTNo = dt.Rows[0]["SINV_ShippTo_GSTNo"].ToString();
                    objINV.S_ShippTo_PANNO = dt.Rows[0]["SINV_ShippTo_PANNO"].ToString();

                    objINV.S_ShippedFrom_State_ID = Convert.ToInt64(dt.Rows[0]["SINV_ShippedFrom_State_ID"].ToString());
                    objINV.S_ShippedFrom_StateDisplayName = dt.Rows[0]["SINV_ShippedFrom_StateDisplayName"].ToString();
                    objINV.S_ShippedFrom_GSTNo = dt.Rows[0]["SINV_ShippedFrom_GSTNo"].ToString();
                    objINV.S_ShippedFrom_PANNO = dt.Rows[0]["SINV_ShippedFrom_PANNO"].ToString(); 

                    
                    objINV.S_CreditDays = Convert.ToInt64(dt.Rows[0]["SINV_CreditDays"].ToString());
                    objINV.S_DueDT = dt.Rows[0]["vSINV_DueDT"].ToString();
                    objINV.S_PONo = dt.Rows[0]["SINV_PONo"].ToString();
                    objINV.S_PO_DT = dt.Rows[0]["vSINV_PO_DT"].ToString();
                    objINV.S_BillTo_CompanyName = dt.Rows[0]["SINV_BillTo_CompanyName"].ToString();
                    objINV.S_BillTo_ContactPersone = dt.Rows[0]["SINV_BillTo_ContactPersone"].ToString();
                    objINV.S_BillTo_CP_MobileNo = dt.Rows[0]["SINV_BillTo_CP_MobileNo"].ToString();
                    objINV.S_BillTo_Add1 = dt.Rows[0]["SINV_BillTo_Add1"].ToString();
                    objINV.S_BillTo_Add2 = dt.Rows[0]["SINV_BillTo_Add2"].ToString();
                    objINV.S_BillTo_Add3 = dt.Rows[0]["SINV_BillTo_Add3"].ToString();
                    objINV.S_BillTo_Pincode = dt.Rows[0]["SINV_BillTo_Pincode"].ToString();
                    objINV.S_BillTo_Area = dt.Rows[0]["SINV_BillTo_Area"].ToString();
                    objINV.S_BillTo_City = dt.Rows[0]["SINV_BillTo_City"].ToString();
                    objINV.S_BillTo_Country = dt.Rows[0]["SINV_BillTo_Country"].ToString();
                    objINV.S_ShippTo_CompanyName = dt.Rows[0]["SINV_ShippTo_CompanyName"].ToString();
                    objINV.S_ShippTo_ContactPersone = dt.Rows[0]["SINV_ShippTo_ContactPersone"].ToString();
                    objINV.S_ShippTo_CP_MobileNo = dt.Rows[0]["SINV_ShippTo_CP_MobileNo"].ToString();
                    objINV.S_ShippTo_Add1 = dt.Rows[0]["SINV_ShippTo_Add1"].ToString();
                    objINV.S_ShippTo_Add2 = dt.Rows[0]["SINV_ShippTo_Add2"].ToString();
                    objINV.S_ShippTo_Add3 = dt.Rows[0]["SINV_ShippTo_Add3"].ToString();
                    objINV.S_ShippTo_Pincode = dt.Rows[0]["SINV_ShippTo_Pincode"].ToString();
                    objINV.S_ShippTo_Area = dt.Rows[0]["SINV_ShippTo_Area"].ToString();
                    objINV.S_ShippTo_City = dt.Rows[0]["SINV_ShippTo_City"].ToString();
                    objINV.S_ShippTo_Country = dt.Rows[0]["SINV_ShippTo_Country"].ToString();
                    objINV.S_ShippedFrom_CompanyName = dt.Rows[0]["SINV_ShippedFrom_CompanyName"].ToString();
                    objINV.S_ShippedFrom_ContactPersone = dt.Rows[0]["SINV_ShippedFrom_ContactPersone"].ToString();
                    objINV.S_ShippedFrom_CP_MobileNo = dt.Rows[0]["SINV_ShippedFrom_CP_MobileNo"].ToString();
                    objINV.S_ShippedFrom_Add1 = dt.Rows[0]["SINV_ShippedFrom_Add1"].ToString();
                    objINV.S_ShippedFrom_Add2 = dt.Rows[0]["SINV_ShippedFrom_Add2"].ToString();
                    objINV.S_ShippedFrom_Add3 = dt.Rows[0]["SINV_ShippedFrom_Add3"].ToString();
                    objINV.S_ShippedFrom_Pincode = dt.Rows[0]["SINV_ShippedFrom_Pincode"].ToString();
                    objINV.S_ShippedFrom_Area = dt.Rows[0]["SINV_ShippedFrom_Area"].ToString();
                    objINV.S_ShippedFrom_City = dt.Rows[0]["SINV_ShippedFrom_City"].ToString();
                    objINV.S_ShippedFrom_Country = dt.Rows[0]["SINV_ShippedFrom_Country"].ToString();
                    objINV.S_PaymentTerms = dt.Rows[0]["SINV_PaymentTerms"].ToString();
                    objINV.S_DelvieryPeriod = dt.Rows[0]["SINV_DelvieryPeriod"].ToString();
                    objINV.S_DeliveryCharges = dt.Rows[0]["SINV_DeliveryCharges"].ToString();
                    objINV.S_ExciseDuty = dt.Rows[0]["SINV_ExciseDuty"].ToString();
                    objINV.S_CompletionPeriod = dt.Rows[0]["SINV_CompletionPeriod"].ToString();
                    objINV.S_ModeOfDispatch = dt.Rows[0]["SINV_ModeOfDispatch"].ToString();
                    objINV.S_TranspoterName = dt.Rows[0]["SINV_TranspoterName"].ToString();
                    objINV.S_VehicleNumber = dt.Rows[0]["SINV_VehicleNumber"].ToString();
                    objINV.S_PlaceOfDelivery = dt.Rows[0]["SINV_PlaceOfDelivery"].ToString();
                    objINV.S_FreigthCharge_Txt = dt.Rows[0]["SINV_FreigthCharge_Txt"].ToString();
                    objINV.S_Insurance_Txt = dt.Rows[0]["SINV_Insurance_Txt"].ToString();
                    objINV.S_Remark = dt.Rows[0]["SINV_Remark"].ToString();
                    objINV.S_DTL_CNT = Convert.ToInt16(dt.Rows[0]["SINV_DTL_CNT"].ToString());
                    objINV.MDBSC_RowStatus = dt.Rows[0]["MDBSC_RowStatus"].ToString();

                    objINV.MDBSC_RowCreatedByUserName = dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
                    objINV.MDBSC_RowCreatedOn_DT = dt.Rows[0]["vMDBSC_RowCreatedOn_DT"].ToString();
                    objINV.MDBSC_RowLupdnUserName = dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
                    objINV.MDBSC_RowLupdnOn_DT = dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
                    objINV.S_HDR_BasicAmt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_BasicAmt"].ToString());
                    objINV.S_HDR_DiscountRate = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_DiscountRate"].ToString());
                    objINV.S_HDR_DiscountAmt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_DiscountAmt"].ToString());
                    objINV.S_HDR_Net_Amt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_Net_Amt"].ToString());
                    objINV.S_HDR_Freight_Charges = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_Freight_Charges"].ToString());
                    objINV.S_HDR_Loading_N_Packing_Charges = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_Loading_N_Packing_Charges"].ToString());
                    objINV.S_HDR_Insurance_Charges = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_Insurance_Charges"].ToString());
                    objINV.S_HDR_Other_Charges_Txt = dt.Rows[0]["SINV_HDR_Other_Charges_Txt"].ToString();
                    objINV.S_HDR_Other_Charges_Amt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_Other_Charges_Amt"].ToString());
                    objINV.S_HDR_Taxable_Amt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_Taxable_Amt"].ToString());
                    objINV.S_HDR_CGST_Amt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_CGST_Amt"].ToString());
                    objINV.S_HDR_CGST_Taxable_Amt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_CGST_Taxable_Amt"].ToString());
                    objINV.S_HDR_SGST_Amt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_SGST_Amt"].ToString());
                    objINV.S_HDR_SGST_Taxable_Amt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_SGST_Taxable_Amt"].ToString());
                    objINV.S_HDR_IGST_Amt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_IGST_Amt"].ToString());
                    objINV.S_HDR_IGST_Taxable_Amt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_IGST_Taxable_Amt"].ToString());
                    objINV.S_HDR_CESS_Amt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_CESS_Amt"].ToString());
                    objINV.S_HDR_CESS_Taxable_Amt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_CESS_Taxable_Amt"].ToString());
                    objINV.S_HDR_OtherTax_ID = Convert.ToInt16(dt.Rows[0]["SINV_HDR_OtherTax_ID"].ToString());
                    objINV.S_HDR_OtherTax_Rate = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_OtherTax_Rate"].ToString());
                    objINV.S_HDR_OtherTax_Amt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_OtherTax_Amt"].ToString());
                    objINV.S_HDR_Other_Taxable_Amt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_Other_Taxable_Amt"].ToString());
                    objINV.S_HDR_Total_Tax_Amt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_Total_Tax_Amt"].ToString());
                    objINV.S_HDR_ItemGross_Total_Amt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_ItemGross_Total_Amt"].ToString());
                    objINV.S_HDR_Gross_Amt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_Gross_Amt"].ToString());
                    objINV.S_HDR_Round_Off_Amt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_Round_Off_Amt"].ToString());
                    objINV.S_HDR_Total_Gross_Amt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_Total_Gross_Amt"].ToString());
                    objINV.S_HDR_Gross_AmtInWords = dt.Rows[0]["SINV_HDR_Gross_AmtInWords"].ToString();
                    objINV.S_HDR_CreditNote_AsOn_Amt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_CreditNote_AsOn_Amt"].ToString());
                    objINV.S_HDR_DebitNote_AsOn_Amt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_DebitNote_AsOn_Amt"].ToString());
                    objINV.S_HDR_TDS_Rate = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_TDS_Rate"].ToString());
                    objINV.S_HDR_TDS_Amt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_TDS_Amt"].ToString());
                    objINV.S_HDR_Paid_AsOn_Amt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_Paid_AsOn_Amt"].ToString());
                    objINV.S_HDR_Outstanding_AsOn_Amt = Convert.ToDecimal(dt.Rows[0]["SINV_HDR_Outstanding_AsOn_Amt"].ToString());
                    if (mvSINVHDR_ID > 0)
                    {
                        DataTable dt_Item = default(DataTable);
                        dt_Item = MABL.BL.AppDataModal.Get_Sales_Item_List(objINV.S_HDR_ID, 0, "", "");
                        
                         
                        //List<SalesInvDTL> ObjItem = new List<SalesInvDTL>();
                        for (int i = 0; i < dt_Item.Rows.Count; i++)
                        {

                            SalesDTL ObjItem = new SalesDTL();
                            ObjItem.SI_DTL_ID = Convert.ToInt64(dt_Item.Rows[i]["SINVDTL_ID"].ToString());
                            ObjItem.SI_HDR_ID = Convert.ToInt64(dt_Item.Rows[i]["Fk_SINVHDR_ID"].ToString());
                            ObjItem.SI_Fk_MItem_ID = Convert.ToInt64(dt_Item.Rows[i]["Fk_MItem_ID"].ToString());

                            ObjItem.SI_Item_Type = dt_Item.Rows[i]["Item_Type"].ToString();
                            ObjItem.SI_Item_Code = dt_Item.Rows[i]["Item_Code"].ToString();
                            ObjItem.SI_Item_Name = dt_Item.Rows[i]["Item_Name"].ToString();
                            ObjItem.SI_UOM = dt_Item.Rows[i]["UOM"].ToString();

                            

                            ObjItem.SI_HSNCode = dt_Item.Rows[i]["SINV_HSNCode"].ToString();
                            ObjItem.SI_QTY = Convert.ToDecimal(dt_Item.Rows[i]["SINV_QTY"].ToString());
                            ObjItem.SI_BasicRate = Convert.ToDecimal(dt_Item.Rows[i]["SINV_BasicRate"].ToString());
                            ObjItem.SI_NetRate = Convert.ToDecimal(dt_Item.Rows[i]["SINV_NetRate"].ToString());
                            ObjItem.SI_BasicAmt = Convert.ToDecimal(dt_Item.Rows[i]["SINV_BasicAmt"].ToString());
                            ObjItem.SI_DiscountRate = Convert.ToDecimal(dt_Item.Rows[i]["SINV_DiscountRate"].ToString());
                            ObjItem.SI_DiscountAmt = Convert.ToDecimal(dt_Item.Rows[i]["SINV_DiscountAmt"].ToString());
                            ObjItem.SI_NetTaxableAmt = Convert.ToDecimal(dt_Item.Rows[i]["SINV_NetTaxableAmt"].ToString());
                            ObjItem.SI_GST_TaxRate_ID = Convert.ToInt16(dt_Item.Rows[i]["SINV_GST_TaxRate_ID"].ToString());
                            ObjItem.SI_GST_TaxRate = Convert.ToDecimal(dt_Item.Rows[i]["SINV_GST_TaxRate"].ToString());
                            ObjItem.SI_CGST_ID = Convert.ToInt16(dt_Item.Rows[i]["SINV_CGST_ID"].ToString());
                            ObjItem.SI_CGST_Rate = Convert.ToDecimal(dt_Item.Rows[i]["SINV_CGST_Rate"].ToString());
                            ObjItem.SI_CGST_Amt = Convert.ToDecimal(dt_Item.Rows[i]["SINV_CGST_Amt"].ToString());
                            ObjItem.SI_CGST_TaxableAmt = Convert.ToDecimal(dt_Item.Rows[i]["SINV_CGST_TaxableAmt"].ToString());
                            ObjItem.SI_SGST_ID = Convert.ToInt16(dt_Item.Rows[i]["SINV_SGST_ID"].ToString());
                            ObjItem.SI_SGST_Rate = Convert.ToDecimal(dt_Item.Rows[i]["SINV_SGST_Rate"].ToString());
                            ObjItem.SI_SGST_Amt = Convert.ToDecimal(dt_Item.Rows[i]["SINV_SGST_Amt"].ToString());
                            ObjItem.SI_SGST_TaxableAmt = Convert.ToDecimal(dt_Item.Rows[i]["SINV_SGST_TaxableAmt"].ToString());
                            ObjItem.SI_IGST_ID = Convert.ToInt16(dt_Item.Rows[i]["SINV_IGST_ID"].ToString());
                            ObjItem.SI_IGST_Rate = Convert.ToDecimal(dt_Item.Rows[i]["SINV_IGST_Rate"].ToString());
                            ObjItem.SI_IGST_Amt = Convert.ToDecimal(dt_Item.Rows[i]["SINV_IGST_Amt"].ToString());
                            ObjItem.SI_IGST_TaxableAmt = Convert.ToDecimal(dt_Item.Rows[i]["SINV_IGST_TaxableAmt"].ToString());
                            ObjItem.SI_CESS_ID = Convert.ToInt16(dt_Item.Rows[i]["SINV_CESS_ID"].ToString());
                            ObjItem.SI_CESS_Rate = Convert.ToDecimal(dt_Item.Rows[i]["SINV_CESS_Rate"].ToString());
                            ObjItem.SI_CESS_Amt = Convert.ToDecimal(dt_Item.Rows[i]["SINV_CESS_Amt"].ToString());
                            ObjItem.SI_CESS_TaxableAmt = Convert.ToDecimal(dt_Item.Rows[i]["SINV_CESS_TaxableAmt"].ToString());
                            ObjItem.SI_TotalTax = Convert.ToDecimal(dt_Item.Rows[i]["SINV_TotalTax"].ToString());
                            ObjItem.SI_GrossRateWithTax = Convert.ToDecimal(dt_Item.Rows[i]["SINV_GrossRateWithTax"].ToString());
                            ObjItem.SI_ItemRemark_DTL = dt_Item.Rows[i]["SINV_ItemRemark_DTL"].ToString();
                            objINV.SINVDTL.Add(ObjItem);
                        } 
                    }  
                }
                else
                {
                    
                }
                return objINV;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static string CU_Sales_InvHDR(SalesHDR mobj_SalesHDR)
        {
            M_AT_Sales_Inv_AHDRBO ObjAT_SINVHDR = new M_AT_Sales_Inv_AHDRBO();
            string strRetMst = "";
            string strSQLDeleteQuery = "";
            DataTable dt = new DataTable();
            string var_ErrorMessage = "";
            try
            {

                if (mobj_SalesHDR.S_Fk_CustomerID == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Select Customer.<br>";
                }
                if (mobj_SalesHDR.S_No.Length == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Customer Invoice No Cannot Be Blank.<br>";
                }

                if (mobj_SalesHDR.S_ShippedFrom_State_ID == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Place Of Dispatch<br>";
                }


                if (mobj_SalesHDR.S_ShippTo_State_ID == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Place Of Supply<br>";
                }



                if ((mobj_SalesHDR.S_No.Length > 0) && (mobj_SalesHDR.S_Fk_CustomerID > 0))
                {
                    if (SQLManager.CheckDuplicateRecord("M_AT_Sales_Inv_AHDR", "SINVHDR_ID", Convert.ToInt32("0" + mobj_SalesHDR.S_HDR_ID), "SINV_No", mobj_SalesHDR.S_No,
                                                       " AND Fk_Branch_ID=" + mobj_SalesHDR.Fk_Branch_ID))
                    {
                        var_ErrorMessage = var_ErrorMessage + "Customer Invoice Already Exist.<br>";
                    }
                }

                if (mobj_SalesHDR.S_DT.Length != 11)
                {
                    var_ErrorMessage = var_ErrorMessage + "Invalid Customer Invoice Date.<br>";
                }

                if ((mobj_SalesHDR.S_Fk_CustomerID > 0) && (Convert.ToInt32(mobj_SalesHDR.S_HDR_ID) == 0))
                {
                    if (mobj_SalesHDR.SINVDTL.Count() == 0)
                    {
                        var_ErrorMessage = var_ErrorMessage + "Pls add atleast one Item to create invoice<br>";
                    }
                    else
                    {
                        foreach (var item in mobj_SalesHDR.SINVDTL)
                        {

                            if (item.SI_BasicRate <= 0)
                            {
                                var_ErrorMessage = var_ErrorMessage + "Invalid Item Rate<br>";
                            }
                            if (item.SI_QTY <= 0)
                            {
                                var_ErrorMessage = var_ErrorMessage + "Invalid Item Quantity<br>";
                            }
                        }
                    }



                }


                if (var_ErrorMessage.Length == 0)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (Convert.ToInt32(mobj_SalesHDR.S_HDR_ID) == 0)
                        {
                            ObjAT_SINVHDR.Fk_Company_ID = mobj_SalesHDR.Fk_Company_ID;
                            ObjAT_SINVHDR.Fk_Branch_ID = mobj_SalesHDR.Fk_Branch_ID;
                            ObjAT_SINVHDR.Fk_Year_ID = mobj_SalesHDR.Fk_Year_ID;
                            ObjAT_SINVHDR.Rec_Created_In = "HO";
                            ObjAT_SINVHDR.Rec_CreatedBy_ID = mobj_SalesHDR.Fk_Branch_ID;
                            ObjAT_SINVHDR.Rec_CreatedFor_ID = mobj_SalesHDR.Fk_Branch_ID;
                            ObjAT_SINVHDR.SINV_CreationType = "Manual";
                            ObjAT_SINVHDR.SINV_Category = "Tax Invoice";
                            ObjAT_SINVHDR.MDBSC_RowCreatedByUserName = mobj_SalesHDR.MDBSC_RowCreatedByUserName;
                            ObjAT_SINVHDR.MDBSC_RowCreatedByUser_ID = mobj_SalesHDR.MDBSC_RowCreatedByUser_ID;
                            ObjAT_SINVHDR.SINV_No = MaheshAF18.Application.MEF.GenrateRefNo(mobj_SalesHDR.Fk_Company_ID, mobj_SalesHDR.Fk_Branch_ID, mobj_SalesHDR.Fk_Year_ID, "INV", "INV", "INV/" + MaheshAF18.Utility.DateHelper.DateYearPrefix("YYMM"), "Yes", "", "", "", 0);


                        }


                        ObjAT_SINVHDR.SINVHDR_ID = Convert.ToInt64("0" + mobj_SalesHDR.S_HDR_ID);


                        ObjAT_SINVHDR.SINV_DT = mobj_SalesHDR.S_DT;
                        ObjAT_SINVHDR.Fk_CustomerID = Convert.ToInt32(mobj_SalesHDR.S_Fk_CustomerID);
                        ObjAT_SINVHDR.SINV_CreditDays = Convert.ToInt32("0" + mobj_SalesHDR.S_CreditDays);
                        ObjAT_SINVHDR.SINV_PONo = mobj_SalesHDR.S_PONo;
                        if (mobj_SalesHDR.S_PO_DT.Length == 11)
                        {
                            ObjAT_SINVHDR.SINV_PO_DT = mobj_SalesHDR.S_PO_DT;
                        }
                        ObjAT_SINVHDR.SINV_Remark = mobj_SalesHDR.S_Remark;
                        ObjAT_SINVHDR.MDBSC_RowStatus = mobj_SalesHDR.MDBSC_RowStatus;
                        ObjAT_SINVHDR.MDBSC_RowLupdnByUser_ID = mobj_SalesHDR.MDBSC_RowCreatedByUser_ID;
                        ObjAT_SINVHDR.MDBSC_RowLupdnUserName = mobj_SalesHDR.MDBSC_RowCreatedByUserName;
                        ObjAT_SINVHDR.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
                        ObjAT_SINVHDR.SINV_HDR_Freight_Charges = Convert.ToDecimal("0" + mobj_SalesHDR.S_HDR_Freight_Charges);

                        ObjAT_SINVHDR.SINV_BillTo_Add1 = mobj_SalesHDR.S_BillTo_Add1;
                        ObjAT_SINVHDR.SINV_BillTo_Add2 = mobj_SalesHDR.S_BillTo_Add2;
                        ObjAT_SINVHDR.SINV_BillTo_Add3 = mobj_SalesHDR.S_BillTo_Add3;
                        ObjAT_SINVHDR.SINV_BillTo_Pincode = mobj_SalesHDR.S_BillTo_Pincode;
                        ObjAT_SINVHDR.SINV_BillTo_City = mobj_SalesHDR.S_BillTo_City;
                        ObjAT_SINVHDR.SINV_BillTo_Country = mobj_SalesHDR.S_BillTo_Country;
                        ObjAT_SINVHDR.SINV_BillTo_PANNO = mobj_SalesHDR.S_BillTo_PANNO;
                        ObjAT_SINVHDR.SINV_BillTo_GSTNo = mobj_SalesHDR.S_BillTo_GSTNo;


                        ObjAT_SINVHDR.SINV_ShippTo_CompanyName = mobj_SalesHDR.S_ShippTo_CompanyName;
                        ObjAT_SINVHDR.SINV_ShippTo_ContactPersone = mobj_SalesHDR.S_ShippTo_ContactPersone;
                        ObjAT_SINVHDR.SINV_ShippTo_CP_MobileNo = mobj_SalesHDR.S_ShippTo_CP_MobileNo;
                        ObjAT_SINVHDR.SINV_ShippTo_Add1 = mobj_SalesHDR.S_ShippTo_Add1;
                        ObjAT_SINVHDR.SINV_ShippTo_Add2 = mobj_SalesHDR.S_ShippTo_Add2;
                        ObjAT_SINVHDR.SINV_ShippTo_Add3 = mobj_SalesHDR.S_ShippTo_Add3;
                        ObjAT_SINVHDR.SINV_ShippTo_Pincode = mobj_SalesHDR.S_ShippTo_Pincode;

                        ObjAT_SINVHDR.SINV_ShippedFrom_CompanyName = "";
                        ObjAT_SINVHDR.SINV_ShippedFrom_ContactPersone = "";
                        ObjAT_SINVHDR.SINV_ShippedFrom_CP_MobileNo = "";
                        ObjAT_SINVHDR.SINV_ShippedFrom_Add1 = "";
                        ObjAT_SINVHDR.SINV_ShippedFrom_Add2 = "";
                        ObjAT_SINVHDR.SINV_ShippedFrom_Add3 = "";
                        ObjAT_SINVHDR.SINV_ShippedFrom_Pincode = "";

                        ObjAT_SINVHDR.SINV_ShippedFrom_City = "";
                        ObjAT_SINVHDR.SINV_ShippedFrom_State_ID = Convert.ToInt64(mobj_SalesHDR.S_ShippedFrom_State_ID);
                        ObjAT_SINVHDR.SINV_ShippedFrom_Country = "";
                        ObjAT_SINVHDR.SINV_ShippedFrom_GSTNo = "";
                        ObjAT_SINVHDR.SINV_ShippedFrom_PANNO = "";


                        ObjAT_SINVHDR.SINV_ShippTo_City = mobj_SalesHDR.S_ShippTo_City;
                        ObjAT_SINVHDR.SINV_ShippTo_State_ID = Convert.ToInt64(mobj_SalesHDR.S_ShippTo_State_ID);
                        ObjAT_SINVHDR.SINV_ShippTo_Country = mobj_SalesHDR.S_ShippTo_Country;
                        ObjAT_SINVHDR.SINV_ShippTo_GSTNo = mobj_SalesHDR.S_ShippTo_GSTNo;
                        ObjAT_SINVHDR.SINV_ShippTo_PANNO = mobj_SalesHDR.S_ShippTo_PANNO;


                        ObjAT_SINVHDR.SINV_ModeOfDispatch = mobj_SalesHDR.S_ModeOfDispatch;
                        ObjAT_SINVHDR.SINV_PaymentTerms = mobj_SalesHDR.S_PaymentTerms;
                        ObjAT_SINVHDR.SINV_DelvieryPeriod = mobj_SalesHDR.S_DelvieryPeriod;
                        ObjAT_SINVHDR.SINV_TranspoterName = mobj_SalesHDR.S_TranspoterName;

                        ObjAT_SINVHDR.SINV_PlaceOfDelivery = mobj_SalesHDR.S_PlaceOfDelivery;
                        ObjAT_SINVHDR.SINV_VehicleNumber = mobj_SalesHDR.S_VehicleNumber;

                        var_ErrorMessage = ObjAT_SINVHDR.Insert_Update(ObjAT_SINVHDR);
                        mobj_SalesHDR.S_HDR_ID = Convert.ToInt64(var_ErrorMessage.Substring((var_ErrorMessage.IndexOf("|") + 1), (var_ErrorMessage.Length - var_ErrorMessage.IndexOf("|") - 1)));
                        //   var_ErrorMessage = var_ErrorMessage.Substring((0), (var_ErrorMessage.IndexOf("|")));

                        if ((mobj_SalesHDR.S_HDR_ID > 0) && (mobj_SalesHDR.SINVDTL.Count() > 0))
                        {
                            for (int i = 0; i < mobj_SalesHDR.SINVDTL.Count(); i++)
                            {
                                M_AT_Sales_Inv_BDTLBO ObjAT_SINVDTL = new M_AT_Sales_Inv_BDTLBO();
                                if (mobj_SalesHDR.SINVDTL[i].IsDelete == "Y")
                                {
                                    strSQLDeleteQuery = strSQLDeleteQuery + mobj_SalesHDR.SINVDTL[i].SI_DTL_ID + ",";
                                }
                                else
                                {
                                    ObjAT_SINVDTL.SINVDTL_ID = mobj_SalesHDR.SINVDTL[i].SI_DTL_ID;
                                    ObjAT_SINVDTL.Fk_SINVHDR_ID = mobj_SalesHDR.S_HDR_ID;
                                    
                                    ObjAT_SINVDTL.MDBSC_RowCreatedByUser_ID = mobj_SalesHDR.MDBSC_RowCreatedByUser_ID;
                                    ObjAT_SINVDTL.MDBSC_RowCreatedByUserName = mobj_SalesHDR.MDBSC_RowCreatedByUserName;
                                    
                                    
                                    ObjAT_SINVDTL.Fk_MItem_ID = mobj_SalesHDR.SINVDTL[i].SI_Fk_MItem_ID;
                                    ObjAT_SINVDTL.SINV_HSNCode = mobj_SalesHDR.SINVDTL[i].SI_HSNCode;
                                    ObjAT_SINVDTL.SINV_QTY = mobj_SalesHDR.SINVDTL[i].SI_QTY;
                                    ObjAT_SINVDTL.SINV_Final_Qty = mobj_SalesHDR.SINVDTL[i].SI_QTY;
                                    ObjAT_SINVDTL.SINV_BasicRate = mobj_SalesHDR.SINVDTL[i].SI_BasicRate;
                                    ObjAT_SINVDTL.SINV_DiscountRate = mobj_SalesHDR.SINVDTL[i].SI_DiscountRate;
                                    ObjAT_SINVDTL.SINV_CGST_ID = 0;
                                    ObjAT_SINVDTL.SINV_SGST_ID = 0;
                                    ObjAT_SINVDTL.SINV_IGST_ID = 0;
                                    ObjAT_SINVDTL.SINV_CESS_ID = 0;

                                    ObjAT_SINVDTL.SINV_ItemRemark_DTL = mobj_SalesHDR.SINVDTL[i].SI_ItemRemark_DTL;
                                    ObjAT_SINVDTL.MDBSC_RowLupdnByUser_ID = mobj_SalesHDR.MDBSC_RowCreatedByUser_ID;
                                    ObjAT_SINVDTL.MDBSC_RowLupdnUserName = mobj_SalesHDR.MDBSC_RowCreatedByUserName;
                                    ObjAT_SINVDTL.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));


                                    ObjAT_SINVDTL.Insert_Update(ObjAT_SINVDTL);
                                }
                            }
                        }
                        scope.Complete();
                    }

                    if (strSQLDeleteQuery.Length > 0)
                    {
                        strSQLDeleteQuery = strSQLDeleteQuery.Remove(strSQLDeleteQuery.Length - 1);
                        strSQLDeleteQuery = "DELETE FROM M_AT_Sales_Inv_BDTL WHERE Fk_SINVHDR_ID=" + mobj_SalesHDR.S_HDR_ID + " AND   SINVDTL_ID IN (" + strSQLDeleteQuery + ")";
                        MaheshAF18.Application.MEF.DA_ExecuteQuery(strSQLDeleteQuery);
                    }

                    if (mobj_SalesHDR.S_HDR_ID > 0)
                    {
                        MABL.SQLManager.SQLProcedureCall.USP_Update_Tbl_Sales(mobj_SalesHDR.Fk_Company_ID, mobj_SalesHDR.Fk_Branch_ID, mobj_SalesHDR.Fk_Year_ID, mobj_SalesHDR.S_HDR_ID);

                    }

                    strRetMst = var_ErrorMessage;

                }
                else
                {
                    strRetMst = var_ErrorMessage + "|" + mobj_SalesHDR.S_HDR_ID.ToString();
                }


                return strRetMst;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static SalesHDR Get_DNCN_Lst(Int64 mvSINVHDR_ID, string StrFilterCriteria, string SearchCriteria)
        {

            DataTable dt = new DataTable();
            try
            {
                SalesHDR obj_DCNC = new SalesHDR();
                obj_DCNC.SINVDTL = new List<SalesDTL>();
                dt = AppData.Get_DT_Sales_DNCN_HDR_List(mvSINVHDR_ID, StrFilterCriteria, SearchCriteria);
                if (dt.Rows.Count > 0)
                {
                    obj_DCNC.S_HDR_ID = Convert.ToInt64(dt.Rows[0]["DCNCHDR_ID"].ToString());
                    obj_DCNC.Fk_Company_ID = Convert.ToInt64(dt.Rows[0]["Fk_Company_ID"].ToString());
                    obj_DCNC.Fk_Branch_ID = Convert.ToInt64(dt.Rows[0]["Fk_Branch_ID"].ToString());
                    obj_DCNC.Fk_Year_ID = Convert.ToInt64(dt.Rows[0]["Fk_Year_ID"].ToString());
                   
                  


                    obj_DCNC.S_Type = dt.Rows[0]["DCNC_Type"].ToString();
                    obj_DCNC.S_Category = dt.Rows[0]["DCNC_Category"].ToString();
                    obj_DCNC.S_TrnType = dt.Rows[0]["DCNC_TrnType"].ToString();
                    obj_DCNC.S_Taxtype = dt.Rows[0]["DCNC_Taxtype"].ToString();

                    obj_DCNC.S_DCNC_No = dt.Rows[0]["DCNC_No"].ToString();
                    obj_DCNC.S_DCNC_DT = dt.Rows[0]["vDCNC_DT"].ToString();

                    obj_DCNC.S_No = dt.Rows[0]["SINV_No"].ToString();
                    obj_DCNC.S_DT = dt.Rows[0]["vSINV_DT"].ToString();
                    obj_DCNC.S_Fk_INVHDR_ID = Convert.ToInt64(dt.Rows[0]["Fk_INVHDR_ID"].ToString());
                    obj_DCNC.S_Fk_CustomerID =Convert.ToInt64( dt.Rows[0]["Fk_CustomerID"].ToString());
                    obj_DCNC.S_MCust_Name = dt.Rows[0]["MCust_Name"].ToString();


                    ////
                    obj_DCNC.S_BR_Reg_State_ID =Convert.ToInt64( dt.Rows[0]["BR_Reg_State_ID"].ToString());
                    obj_DCNC.S_BR_Reg_StateDisplayName = dt.Rows[0]["BR_Reg_StateDisplayName"].ToString();
                    obj_DCNC.S_BL_GSTNO = dt.Rows[0]["BL_GSTNO"].ToString();
                    obj_DCNC.S_BL_PANNO = dt.Rows[0]["BL_PANNO"].ToString();




                    obj_DCNC.S_MCust_Reg_State_ID =Convert.ToInt64(  dt.Rows[0]["MCust_Reg_State_ID"].ToString());
                    obj_DCNC.S_MCust_Reg_StateDisplayName = dt.Rows[0]["MCust_Reg_StateDisplayName"].ToString();
                    obj_DCNC.S_MCust_BL_GSTNO = dt.Rows[0]["MCust_BL_GSTNO"].ToString();
                    obj_DCNC.S_MCust_BL_PANNO = dt.Rows[0]["MCust_BL_PANNO"].ToString();


                    obj_DCNC.S_BillTo_State_ID =Convert.ToInt64(  dt.Rows[0]["SINV_BillTo_State_ID"].ToString());
                    obj_DCNC.S_BillTo_StateDisplayName = dt.Rows[0]["SINV_BillTo_StateDisplayName"].ToString();
                    obj_DCNC.S_BillTo_GSTNo = dt.Rows[0]["SINV_BillTo_GSTNo"].ToString();
                    obj_DCNC.S_BillTo_PANNO = dt.Rows[0]["SINV_BillTo_PANNO"].ToString();


                    obj_DCNC.S_ShippTo_State_ID = Convert.ToInt64(dt.Rows[0]["SINV_ShippTo_State_ID"].ToString());
                    obj_DCNC.S_ShippTo_StateDisplayName = dt.Rows[0]["SINV_ShippTo_StateDisplayName"].ToString();
                    obj_DCNC.S_ShippTo_GSTNo = dt.Rows[0]["SINV_ShippTo_GSTNo"].ToString();
                    obj_DCNC.S_ShippTo_PANNO = dt.Rows[0]["SINV_ShippTo_PANNO"].ToString();

                    obj_DCNC.S_ShippedFrom_State_ID =Convert.ToInt64(  dt.Rows[0]["SINV_ShippedFrom_State_ID"].ToString());
                    obj_DCNC.S_ShippedFrom_StateDisplayName = dt.Rows[0]["SINV_ShippedFrom_StateDisplayName"].ToString();
                    obj_DCNC.S_ShippedFrom_GSTNo = dt.Rows[0]["SINV_ShippedFrom_GSTNo"].ToString();
                    obj_DCNC.S_ShippedFrom_PANNO = dt.Rows[0]["SINV_ShippedFrom_PANNO"].ToString();

////


















                    obj_DCNC.S_BL_GSTNO = dt.Rows[0]["BL_GSTNO"].ToString();
                    obj_DCNC.S_MCust_BL_GSTNO = dt.Rows[0]["MCust_BL_GSTNO"].ToString();
                    
                    
                    obj_DCNC.S_BR_Reg_StateDisplayName = dt.Rows[0]["BR_Reg_StateDisplayName"].ToString();
                    obj_DCNC.S_MCust_Reg_StateDisplayName = dt.Rows[0]["MCust_Reg_StateDisplayName"].ToString();


                


                    obj_DCNC.S_Remark = dt.Rows[0]["DCNC_Remark"].ToString();
                    obj_DCNC.S_DTL_CNT = Convert.ToInt16(dt.Rows[0]["DCNC_DTL_CNT"].ToString());
                    obj_DCNC.MDBSC_RowStatus = dt.Rows[0]["MDBSC_RowStatus"].ToString();

                    obj_DCNC.MDBSC_RowCreatedByUserName = dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
                    obj_DCNC.MDBSC_RowCreatedOn_DT = dt.Rows[0]["vMDBSC_RowCreatedOn_DT"].ToString();
                    obj_DCNC.MDBSC_RowLupdnUserName = dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
                    obj_DCNC.MDBSC_RowLupdnOn_DT = dt.Rows[0]["vMDBSC_RowLupdnOn_DT"].ToString();
                    obj_DCNC.S_HDR_BasicAmt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_BasicAmt"].ToString());
                    obj_DCNC.S_HDR_DiscountRate = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_DiscountRate"].ToString());
                    obj_DCNC.S_HDR_DiscountAmt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_DiscountAmt"].ToString());
                    obj_DCNC.S_HDR_Net_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_Net_Amt"].ToString());
                    obj_DCNC.S_HDR_Freight_Charges = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_Freight_Charges"].ToString());
                    obj_DCNC.S_HDR_Loading_N_Packing_Charges = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_Loading_N_Packing_Charges"].ToString());
                    obj_DCNC.S_HDR_Insurance_Charges = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_Insurance_Charges"].ToString());
                    obj_DCNC.S_HDR_Other_Charges_Txt = dt.Rows[0]["DCNC_HDR_Other_Charges_Txt"].ToString();
                    obj_DCNC.S_HDR_Other_Charges_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_Other_Charges_Amt"].ToString());
                    obj_DCNC.S_HDR_Taxable_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_Taxable_Amt"].ToString());
                    obj_DCNC.S_HDR_CGST_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_CGST_Amt"].ToString());
                    obj_DCNC.S_HDR_CGST_Taxable_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_CGST_Taxable_Amt"].ToString());
                    obj_DCNC.S_HDR_SGST_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_SGST_Amt"].ToString());
                    obj_DCNC.S_HDR_SGST_Taxable_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_SGST_Taxable_Amt"].ToString());
                    obj_DCNC.S_HDR_IGST_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_IGST_Amt"].ToString());
                    obj_DCNC.S_HDR_IGST_Taxable_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_IGST_Taxable_Amt"].ToString());
                    obj_DCNC.S_HDR_CESS_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_CESS_Amt"].ToString());
                    obj_DCNC.S_HDR_CESS_Taxable_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_CESS_Taxable_Amt"].ToString());
                    obj_DCNC.S_HDR_OtherTax_ID = Convert.ToInt16(dt.Rows[0]["DCNC_HDR_OtherTax_ID"].ToString());
                    obj_DCNC.S_HDR_OtherTax_Rate = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_OtherTax_Rate"].ToString());
                    obj_DCNC.S_HDR_OtherTax_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_OtherTax_Amt"].ToString());
                    obj_DCNC.S_HDR_Other_Taxable_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_Other_Taxable_Amt"].ToString());
                    obj_DCNC.S_HDR_Total_Tax_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_Total_Tax_Amt"].ToString());
                    obj_DCNC.S_HDR_ItemGross_Total_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_ItemGross_Total_Amt"].ToString());
                    obj_DCNC.S_HDR_Gross_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_Gross_Amt"].ToString());
                    obj_DCNC.S_HDR_Round_Off_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_Round_Off_Amt"].ToString());
                    obj_DCNC.S_HDR_Total_Gross_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_Total_Gross_Amt"].ToString());
                    obj_DCNC.S_HDR_Gross_AmtInWords = dt.Rows[0]["DCNC_HDR_Gross_AmtInWords"].ToString();


                    if (mvSINVHDR_ID > 0)
                    {
                        DataTable dt_Item = default(DataTable);
                        dt_Item = MABL.BL.AppDataModal.Get_Cust_DCN_Item_List(obj_DCNC.S_HDR_ID, 0, "", "");


                        //List<SalesInvDTL> ObjItem = new List<SalesInvDTL>();
                        for (int i = 0; i < dt_Item.Rows.Count; i++)
                        {

                            SalesDTL ObjItem = new SalesDTL();
                            ObjItem.SI_DTL_ID = Convert.ToInt64(dt_Item.Rows[i]["DCNCDTL_ID"].ToString());
                            ObjItem.SI_HDR_ID = Convert.ToInt64(dt_Item.Rows[i]["Fk_DCNCHDR_ID"].ToString());
                            ObjItem.SI_Fk_MItem_ID = Convert.ToInt64(dt_Item.Rows[i]["Fk_MItem_ID"].ToString());

                            ObjItem.SI_Item_Type = dt_Item.Rows[i]["Item_Type"].ToString();
                            ObjItem.SI_Item_Code = dt_Item.Rows[i]["Item_Code"].ToString();
                            ObjItem.SI_Item_Name = dt_Item.Rows[i]["Item_Name"].ToString();
                            ObjItem.SI_UOM = dt_Item.Rows[i]["UOM"].ToString();

                            ObjItem.SI_HSNCode = dt_Item.Rows[i]["DCNC_HSNCode"].ToString();
                            ObjItem.SI_QTY = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_QTY"].ToString());
                            ObjItem.SI_BasicRate = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_BasicRate"].ToString());
                            ObjItem.SI_NetRate = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_NetRate"].ToString());
                            ObjItem.SI_BasicAmt = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_BasicAmt"].ToString());
                            ObjItem.SI_DiscountRate = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_DiscountRate"].ToString());
                            ObjItem.SI_DiscountAmt = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_DiscountAmt"].ToString());
                            ObjItem.SI_NetTaxableAmt = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_NetTaxableAmt"].ToString());
                            ObjItem.SI_GST_TaxRate_ID = Convert.ToInt16(dt_Item.Rows[i]["DCNC_GST_TaxRate_ID"].ToString());
                            ObjItem.SI_GST_TaxRate = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_GST_TaxRate"].ToString());
                            ObjItem.SI_CGST_ID = Convert.ToInt16(dt_Item.Rows[i]["DCNC_CGST_ID"].ToString());
                            ObjItem.SI_CGST_Rate = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_CGST_Rate"].ToString());
                            ObjItem.SI_CGST_Amt = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_CGST_Amt"].ToString());
                            ObjItem.SI_CGST_TaxableAmt = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_CGST_TaxableAmt"].ToString());
                            ObjItem.SI_SGST_ID = Convert.ToInt16(dt_Item.Rows[i]["DCNC_SGST_ID"].ToString());
                            ObjItem.SI_SGST_Rate = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_SGST_Rate"].ToString());
                            ObjItem.SI_SGST_Amt = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_SGST_Amt"].ToString());
                            ObjItem.SI_SGST_TaxableAmt = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_SGST_TaxableAmt"].ToString());
                            ObjItem.SI_IGST_ID = Convert.ToInt16(dt_Item.Rows[i]["DCNC_IGST_ID"].ToString());
                            ObjItem.SI_IGST_Rate = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_IGST_Rate"].ToString());
                            ObjItem.SI_IGST_Amt = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_IGST_Amt"].ToString());
                            ObjItem.SI_IGST_TaxableAmt = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_IGST_TaxableAmt"].ToString());
                            ObjItem.SI_CESS_ID = Convert.ToInt16(dt_Item.Rows[i]["DCNC_CESS_ID"].ToString());
                            ObjItem.SI_CESS_Rate = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_CESS_Rate"].ToString());
                            ObjItem.SI_CESS_Amt = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_CESS_Amt"].ToString());
                            ObjItem.SI_CESS_TaxableAmt = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_CESS_TaxableAmt"].ToString());
                            ObjItem.SI_TotalTax = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_TotalTax"].ToString());
                            ObjItem.SI_GrossRateWithTax = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_GrossRateWithTax"].ToString());
                            ObjItem.SI_ItemRemark_DTL = dt_Item.Rows[i]["DCNC_ItemRemark_DTL"].ToString();
                            obj_DCNC.SINVDTL.Add(ObjItem);
                        }
                    }
                }
                else
                {

                }
                return obj_DCNC;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string CU_Sales_DNCN(SalesHDR mobj_DCNC)
        {
            M_AT_DNC_Cust_AHDRBO ObjAT_DNCN_HDR = new M_AT_DNC_Cust_AHDRBO();
            string strRetMst = "";
            string strSQLDeleteQuery = "";
            DataTable dt = new DataTable();
            string var_ErrorMessage = "";
            try
            {
                if (mobj_DCNC.S_Type.Length == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Select Debit Not Or Credit Note.<br>";
                }

                if (mobj_DCNC.S_DCNC_No.Length == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "DNCN No Cannot Be Blank.<br>";
                }

                if (mobj_DCNC.S_DCNC_DT.Length != 11)
                {
                    var_ErrorMessage = var_ErrorMessage + "Invalid DNCN Date.<br>";
                }

                if (mobj_DCNC.S_Fk_INVHDR_ID == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Invalid Invoice No.<br>";
                }

                if ((mobj_DCNC.S_Fk_CustomerID > 0) && (Convert.ToInt32(mobj_DCNC.S_HDR_ID) == 0))
                {
                    if (mobj_DCNC.SINVDTL.Count() == 0)
                    {
                        var_ErrorMessage = var_ErrorMessage + "Pls add atleast one Item to create DNCN<br>";
                    }
                    else
                    {
                        foreach (var item in mobj_DCNC.SINVDTL)
                        {

                            if (item.SI_BasicRate <= 0)
                            {
                                var_ErrorMessage = var_ErrorMessage + "Invalid Item Rate<br>";
                            }
                            if (item.SI_QTY <= 0)
                            {
                                var_ErrorMessage = var_ErrorMessage + "Invalid Item Quantity<br>";
                            }
                        }
                    }



                }


                if (var_ErrorMessage.Length == 0)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (Convert.ToInt32(mobj_DCNC.S_HDR_ID) == 0)
                        {
                            ObjAT_DNCN_HDR.Fk_Company_ID = mobj_DCNC.Fk_Company_ID;
                            ObjAT_DNCN_HDR.Fk_Branch_ID = mobj_DCNC.Fk_Branch_ID;
                            ObjAT_DNCN_HDR.Fk_Year_ID = mobj_DCNC.Fk_Year_ID;
                            ObjAT_DNCN_HDR.Rec_Created_In = "HO";
                            ObjAT_DNCN_HDR.Rec_CreatedBy_ID = mobj_DCNC.Fk_Branch_ID;
                            ObjAT_DNCN_HDR.Rec_CreatedFor_ID = mobj_DCNC.Fk_Branch_ID;
                            ObjAT_DNCN_HDR.DCNC_CreationType = "Manual";
                            ObjAT_DNCN_HDR.DCNC_Category = mobj_DCNC.S_Category;

                            ObjAT_DNCN_HDR.DCNC_TrnType = mobj_DCNC.S_TrnType;
                            ObjAT_DNCN_HDR.DCNC_Type = mobj_DCNC.S_Type;
                           


                            ObjAT_DNCN_HDR.MDBSC_RowCreatedByUserName = mobj_DCNC.MDBSC_RowCreatedByUserName;
                            ObjAT_DNCN_HDR.MDBSC_RowCreatedByUser_ID = mobj_DCNC.MDBSC_RowCreatedByUser_ID;
                            ObjAT_DNCN_HDR.DCNC_No = MaheshAF18.Application.MEF.GenrateRefNo(mobj_DCNC.Fk_Company_ID, mobj_DCNC.Fk_Branch_ID, mobj_DCNC.Fk_Year_ID, "INV", "INV", "INV/" + MaheshAF18.Utility.DateHelper.DateYearPrefix("YYMM"), "Yes", "", "", "", 0);


                        }


                        ObjAT_DNCN_HDR.DCNCHDR_ID = Convert.ToInt64("0" + mobj_DCNC.S_HDR_ID);


                        ObjAT_DNCN_HDR.DCNC_DT = mobj_DCNC.S_DCNC_DT;
                        ObjAT_DNCN_HDR.Fk_INVHDR_ID = Convert.ToInt32(mobj_DCNC.S_Fk_INVHDR_ID);



                        ObjAT_DNCN_HDR.DCNC_Remark = mobj_DCNC.S_Remark;
                        ObjAT_DNCN_HDR.MDBSC_RowStatus = mobj_DCNC.MDBSC_RowStatus;
                        ObjAT_DNCN_HDR.MDBSC_RowLupdnByUser_ID = mobj_DCNC.MDBSC_RowCreatedByUser_ID;
                        ObjAT_DNCN_HDR.MDBSC_RowLupdnUserName = mobj_DCNC.MDBSC_RowCreatedByUserName;
                        ObjAT_DNCN_HDR.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
                        ObjAT_DNCN_HDR.DCNC_HDR_Freight_Charges = Convert.ToDecimal("0" + mobj_DCNC.S_HDR_Freight_Charges);


                        var_ErrorMessage = ObjAT_DNCN_HDR.Insert_Update(ObjAT_DNCN_HDR);
                        mobj_DCNC.S_HDR_ID = Convert.ToInt64(var_ErrorMessage.Substring((var_ErrorMessage.IndexOf("|") + 1), (var_ErrorMessage.Length - var_ErrorMessage.IndexOf("|") - 1)));
                        //   var_ErrorMessage = var_ErrorMessage.Substring((0), (var_ErrorMessage.IndexOf("|")));

                        if ((mobj_DCNC.S_HDR_ID > 0) && (mobj_DCNC.SINVDTL.Count() > 0))
                        {
                            for (int i = 0; i < mobj_DCNC.SINVDTL.Count(); i++)
                            {
                                M_AT_DNC_Cust_BDTLBO ObjAT_DNCN_DTL = new M_AT_DNC_Cust_BDTLBO();
                                if (mobj_DCNC.SINVDTL[i].IsDelete == "Y")
                                {
                                    strSQLDeleteQuery = strSQLDeleteQuery + mobj_DCNC.SINVDTL[i].SI_DTL_ID + ",";
                                }
                                else
                                {

                                    ObjAT_DNCN_DTL.MDBSC_RowCreatedByUser_ID = mobj_DCNC.MDBSC_RowCreatedByUser_ID;
                                    ObjAT_DNCN_DTL.MDBSC_RowCreatedByUserName = mobj_DCNC.MDBSC_RowCreatedByUserName;
                                    ObjAT_DNCN_DTL.DCNCDTL_ID = mobj_DCNC.SINVDTL[i].SI_DTL_ID;
                                    ObjAT_DNCN_DTL.Fk_DCNCHDR_ID = mobj_DCNC.S_HDR_ID;
                                    ObjAT_DNCN_DTL.Fk_MItem_ID = mobj_DCNC.SINVDTL[i].SI_Fk_MItem_ID;
                                    ObjAT_DNCN_DTL.DCNC_HSNCode = mobj_DCNC.SINVDTL[i].SI_HSNCode;
                                    ObjAT_DNCN_DTL.DCNC_QTY = mobj_DCNC.SINVDTL[i].SI_QTY;
                                    ObjAT_DNCN_DTL.DCNC_BasicRate = mobj_DCNC.SINVDTL[i].SI_BasicRate;
                                    ObjAT_DNCN_DTL.DCNC_DiscountRate = mobj_DCNC.SINVDTL[i].SI_DiscountRate;
                                    ObjAT_DNCN_DTL.DCNC_CGST_ID = 0;
                                    ObjAT_DNCN_DTL.DCNC_SGST_ID = 0;
                                    ObjAT_DNCN_DTL.DCNC_IGST_ID = 0;
                                    ObjAT_DNCN_DTL.DCNC_CESS_ID = 0;

                                    ObjAT_DNCN_DTL.DCNC_ItemRemark_DTL = mobj_DCNC.SINVDTL[i].SI_ItemRemark_DTL;
                                    ObjAT_DNCN_DTL.MDBSC_RowLupdnByUser_ID = mobj_DCNC.MDBSC_RowCreatedByUser_ID;
                                    ObjAT_DNCN_DTL.MDBSC_RowLupdnUserName = mobj_DCNC.MDBSC_RowCreatedByUserName;
                                    ObjAT_DNCN_DTL.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));


                                    ObjAT_DNCN_DTL.Insert_Update(ObjAT_DNCN_DTL);
                                }
                            }
                        }
                        scope.Complete();
                    }

                    if (strSQLDeleteQuery.Length > 0)
                    {
                        strSQLDeleteQuery = strSQLDeleteQuery.Remove(strSQLDeleteQuery.Length - 1);
                        strSQLDeleteQuery = "DELETE FROM M_AT_DNC_Cust_BDTL WHERE Fk_DCNCHDR_ID=" + mobj_DCNC.S_HDR_ID + " AND   DCNCDTL_ID IN (" + strSQLDeleteQuery + ")";
                        MaheshAF18.Application.MEF.DA_ExecuteQuery(strSQLDeleteQuery);
                    }

                    if (mobj_DCNC.S_HDR_ID > 0)
                    {
                        MABL.SQLManager.SQLProcedureCall.USP_Update_Tbl_DCN_Cust(mobj_DCNC.Fk_Company_ID, mobj_DCNC.Fk_Branch_ID, mobj_DCNC.Fk_Year_ID, mobj_DCNC.S_HDR_ID);

                    }

                    strRetMst = var_ErrorMessage;

                }
                else
                {
                    strRetMst = var_ErrorMessage + "|" + mobj_DCNC.S_HDR_ID.ToString();
                }


                return strRetMst;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}