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
    public class PurchaseModels
    {
        public class PurchaseHDR
        {
            public Int64 P_HDR_ID { get; set; }
            public Int64 Fk_Company_ID { get; set; }
            public Int64 Fk_Branch_ID { get; set; }
            public Int64 Fk_Year_ID { get; set; }
            public Int64 P_Fk_INVHDR_ID { get; set; }
            public Int64 P_Fk_VendorID { get; set; }
            public String P_Category { get; set; }
            public String P_TrnType { get; set; }
            public String P_Type { get; set; }
            public String P_Taxtype { get; set; }
            public String P_RCM { get; set; }

            public String P_No { get; set; }
            public String P_DT { get; set; }
            public String P_MVen_Name { get; set; }

            public String P_MVen_BL_GSTNO { get; set; }
            public String P_BL_GSTNO { get; set; }
            public String P_BR_Reg_StateDisplayName { get; set; }
            public String P_MVen_Reg_StateDisplayName { get; set; }

            public String P_DCNC_No { get; set; }
            public String P_DCNC_DT { get; set; }

            public Int64 P_CreditDays { get; set; }
            public String P_DueDT { get; set; }
            public Int64 P_State_ID { get; set; }
            public String P_PONo { get; set; }
            public String P_PO_DT { get; set; }

            public String P_BillTo_CompanyName { get; set; }
            public String P_BillTo_ContactPersone { get; set; }
            public String P_BillTo_CP_MobileNo { get; set; }
            public String P_BillTo_Add1 { get; set; }
            public String P_BillTo_Add2 { get; set; }
            public String P_BillTo_Add3 { get; set; }

            public String P_BillTo_Pincode { get; set; }
            public String P_BillTo_Area { get; set; }
            public String P_BillTo_City { get; set; }
            public Int64 P_BillTo_State_ID { get; set; }
            public String P_BillTo_Country { get; set; }
            public String P_BillTo_GSTNo { get; set; }
            public String P_BillTo_PANNO { get; set; }

            public String P_ShippTo_CompanyName { get; set; }
            public String P_ShippTo_ContactPersone { get; set; }
            public String P_ShippTo_CP_MobileNo { get; set; }
            public String P_ShippTo_Add1 { get; set; }
            public String P_ShippTo_Add2 { get; set; }
            public String P_ShippTo_Add3 { get; set; }
            public String P_ShippTo_Pincode { get; set; }
            public String P_ShippTo_Area { get; set; }
            public String P_ShippTo_City { get; set; }
            public Int64 P_ShippTo_State_ID { get; set; }
            public String P_ShippTo_Country { get; set; }
            public String P_ShippTo_GSTNo { get; set; }
            public String P_ShippTo_PANNO { get; set; }

            public String P_ShippedFrom_CompanyName { get; set; }
            public String P_ShippedFrom_ContactPersone { get; set; }
            public String P_ShippedFrom_CP_MobileNo { get; set; }
            public String P_ShippedFrom_Add1 { get; set; }
            public String P_ShippedFrom_Add2 { get; set; }
            public String P_ShippedFrom_Add3 { get; set; }
            public String P_ShippedFrom_Pincode { get; set; }
            public String P_ShippedFrom_Area { get; set; }
            public String P_ShippedFrom_City { get; set; }
            public Int64 P_ShippedFrom_State_ID { get; set; }
            public String P_ShippedFrom_Country { get; set; }
            public String P_ShippedFrom_GSTNo { get; set; }
            public String P_ShippedFrom_PANNO { get; set; }

            public String P_PaymentTerms { get; set; }
            public String P_DelvieryPeriod { get; set; }
            public String P_DeliveryCharges { get; set; }
            public String P_ExciseDuty { get; set; }
            public String P_CompletionPeriod { get; set; }
            public String P_ModeOfDispatch { get; set; }
            public String P_TranspoterName { get; set; }
            public String P_VehicleNumber { get; set; }
            public String P_PlaceOfDelivery { get; set; }
            public String P_FreigthCharge_Txt { get; set; }
            public String P_Insurance_Txt { get; set; }
            public String P_Remark { get; set; }
            public Int16 P_DTL_CNT { get; set; }
            public Decimal P_HDR_BasicAmt { get; set; }
            public Decimal P_HDR_DiscountRate { get; set; }
            public Decimal P_HDR_DiscountAmt { get; set; }
            public Decimal P_HDR_Net_Amt { get; set; }
            public Decimal P_HDR_Freight_Charges { get; set; }
            public Decimal P_HDR_Loading_N_Packing_Charges { get; set; }
            public Decimal P_HDR_Insurance_Charges { get; set; }
            public String P_HDR_Other_Charges_Txt { get; set; }
            public Decimal P_HDR_Other_Charges_Amt { get; set; }
            public Decimal P_HDR_Taxable_Amt { get; set; }
            public Decimal P_HDR_CGST_Amt { get; set; }
            public Decimal P_HDR_CGST_Taxable_Amt { get; set; }
            public Decimal P_HDR_SGST_Amt { get; set; }
            public Decimal P_HDR_SGST_Taxable_Amt { get; set; }
            public Decimal P_HDR_IGST_Amt { get; set; }
            public Decimal P_HDR_IGST_Taxable_Amt { get; set; }
            public Decimal P_HDR_CESS_Amt { get; set; }
            public Decimal P_HDR_CESS_Taxable_Amt { get; set; }
            public Int16 P_HDR_OtherTax_ID { get; set; }
            public Decimal P_HDR_OtherTax_Rate { get; set; }
            public Decimal P_HDR_OtherTax_Amt { get; set; }
            public Decimal P_HDR_Other_Taxable_Amt { get; set; }
            public Decimal P_HDR_Total_Tax_Amt { get; set; }
            public Decimal P_HDR_ItemGross_Total_Amt { get; set; }
            public Decimal P_HDR_Gross_Amt { get; set; }
            public Decimal P_HDR_Round_Off_Amt { get; set; }
            public Decimal P_HDR_Total_Gross_Amt { get; set; }
            public String P_HDR_Gross_AmtInWords { get; set; }
            public Decimal P_HDR_CreditNote_AsOn_Amt { get; set; }
            public Decimal P_HDR_DebitNote_AsOn_Amt { get; set; }
            public Decimal P_HDR_TDS_Rate { get; set; }
            public Decimal P_HDR_TDS_Amt { get; set; }
            public Decimal P_HDR_Paid_AsOn_Amt { get; set; }
            public Decimal P_HDR_Outstanding_AsOn_Amt { get; set; }

            public String MDBSC_RowStatus { get; set; }
            public Int16 MDBSC_RowCreatedByUser_ID { get; set; }
            public String MDBSC_RowCreatedByUserName { get; set; }
            public String MDBSC_RowCreatedOn_DT { get; set; }
            public Int16 MDBSC_RowLupdnByUser_ID { get; set; }
            public String MDBSC_RowLupdnUserName { get; set; }
            public String MDBSC_RowLupdnOn_DT { get; set; }


            public List<PurchaseDTL> PINVDTL { get; set; }

        }
        public class PurchaseDTL
        {
            public Int64 PI_DTL_ID { get; set; }
            public Int64 PI_HDR_ID { get; set; }
            public Int64 PI_Fk_MItem_ID { get; set; }
            public String PI_HSNCode { get; set; }
            public String PI_Item_Type { get; set; }
            public String PI_Item_Code { get; set; }
            public String PI_Item_Name { get; set; }
            public String PI_UOM { get; set; }


            public String PI_Computation_Type { get; set; }
            public Decimal PI_QTY { get; set; }
            public Decimal PI_BasicRate { get; set; }
            public Decimal PI_NetRate { get; set; }
            public Decimal PI_BasicAmt { get; set; }
            public Decimal PI_DiscountRate { get; set; }
            public Decimal PI_DiscountAmt { get; set; }
            public Decimal PI_NetTaxableAmt { get; set; }
            public Int16 PI_GST_TaxRate_ID { get; set; }
            public Decimal PI_GST_TaxRate { get; set; }
            public Int16 PI_CGST_ID { get; set; }
            public Decimal PI_CGST_Rate { get; set; }
            public Decimal PI_CGST_Amt { get; set; }
            public Decimal PI_CGST_TaxableAmt { get; set; }
            public Int16 PI_SGST_ID { get; set; }
            public Decimal PI_SGST_Rate { get; set; }
            public Decimal PI_SGST_Amt { get; set; }
            public Decimal PI_SGST_TaxableAmt { get; set; }
            public Int16 PI_IGST_ID { get; set; }
            public Decimal PI_IGST_Rate { get; set; }
            public Decimal PI_IGST_Amt { get; set; }
            public Decimal PI_IGST_TaxableAmt { get; set; }
            public Int16 PI_CESS_ID { get; set; }
            public Decimal PI_CESS_Rate { get; set; }
            public Decimal PI_CESS_Amt { get; set; }
            public Decimal PI_CESS_TaxableAmt { get; set; }
            public Int16 PI_OtherTax_ID { get; set; }
            public Decimal PI_OtherTax_Rate { get; set; }
            public Decimal PI_OtherTax_Amt { get; set; }
            public Decimal PI_OtherTax_TaxableAmt { get; set; }
            public Decimal PI_TotalTax { get; set; }
            public Decimal PI_GrossRateWithTax { get; set; }

            public String PI_ItemRemark_DTL { get; set; }
            public String IsDelete { get; set; }
            public String MDBSC_RowStatus { get; set; }

        }


        //List
        public static ArrayList Get_Purchase_Common_Lst(string StrFilterCriteria, string SearchCriteria)
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
        public static ArrayList Get_Purchase_Invoice(Int64 mvPINVHDR_ID, string StrFilterCriteria, string SearchCriteria)
        {
            ArrayList items = new ArrayList();
            DataTable dt = new DataTable();
            try
            {

                dt = AppData.Get_DT_Sales_HDR_List(mvPINVHDR_ID, StrFilterCriteria, SearchCriteria);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        PurchaseHDR objINV = new PurchaseHDR();
                        objINV.P_HDR_ID = Convert.ToInt64(dt.Rows[i]["PINVHDR_ID"].ToString());
                        objINV.Fk_Company_ID = Convert.ToInt64(dt.Rows[i]["Fk_Company_ID"].ToString());
                        objINV.Fk_Branch_ID = Convert.ToInt64(dt.Rows[i]["Fk_Branch_ID"].ToString());
                        objINV.Fk_Year_ID = Convert.ToInt64(dt.Rows[i]["Fk_Year_ID"].ToString());

                        objINV.P_Category = dt.Rows[i]["PINV_Category"].ToString();

                        objINV.P_TrnType = dt.Rows[i]["PINV_TrnType"].ToString();
                        objINV.P_Type = dt.Rows[i]["PINV_Type"].ToString();
                        objINV.P_Taxtype = dt.Rows[i]["PINV_Taxtype"].ToString();






                        objINV.P_No = dt.Rows[i]["PINV_No"].ToString();
                        objINV.P_DT = dt.Rows[i]["vPINV_DT"].ToString();
                        objINV.P_Fk_VendorID = Convert.ToInt64(dt.Rows[i]["Fk_VendorID"].ToString());
                        objINV.P_MVen_Name = dt.Rows[i]["MVen_Name"].ToString();
                        objINV.P_CreditDays = Convert.ToInt64(dt.Rows[i]["PINV_CreditDays"].ToString());
                        objINV.P_DueDT = dt.Rows[i]["vPINV_DueDT"].ToString();
                        objINV.P_DTL_CNT = Convert.ToInt16(dt.Rows[i]["PINV_DTL_CNT"].ToString());
                        objINV.MDBSC_RowStatus = dt.Rows[i]["MDBSC_RowStatus"].ToString();
                        objINV.MDBSC_RowCreatedByUserName = dt.Rows[i]["MDBSC_RowCreatedByUserName"].ToString();
                        objINV.MDBSC_RowCreatedOn_DT = dt.Rows[i]["vMDBSC_RowCreatedOn_DT"].ToString();
                        objINV.MDBSC_RowLupdnUserName = dt.Rows[i]["MDBSC_RowLupdnUserName"].ToString();
                        objINV.MDBSC_RowLupdnOn_DT = dt.Rows[i]["vMDBSC_RowLupdnOn_DT"].ToString();
                        objINV.P_HDR_BasicAmt = Convert.ToDecimal(dt.Rows[i]["PINV_HDR_BasicAmt"].ToString());
                        objINV.P_HDR_DiscountRate = Convert.ToDecimal(dt.Rows[i]["PINV_HDR_DiscountRate"].ToString());
                        objINV.P_HDR_DiscountAmt = Convert.ToDecimal(dt.Rows[i]["PINV_HDR_DiscountAmt"].ToString());
                        objINV.P_HDR_Net_Amt = Convert.ToDecimal(dt.Rows[i]["PINV_HDR_Net_Amt"].ToString());
                        objINV.P_HDR_Total_Gross_Amt = Convert.ToDecimal(dt.Rows[i]["PINV_HDR_Total_Gross_Amt"].ToString());
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


        public static PurchaseHDR Get_TaxInv_Lst(Int64 mvPINVHDR_ID, string StrFilterCriteria, string SearchCriteria)
        {

            DataTable dt = new DataTable();
            try
            {
                PurchaseHDR objINV = new PurchaseHDR();
                objINV.PINVDTL = new List<PurchaseDTL>();
                dt = AppData.Get_DT_Sales_HDR_List(mvPINVHDR_ID, StrFilterCriteria, SearchCriteria);
                if (dt.Rows.Count > 0)
                {
                    objINV.P_HDR_ID = Convert.ToInt64(dt.Rows[0]["PINVHDR_ID"].ToString());
                    objINV.Fk_Company_ID = Convert.ToInt64(dt.Rows[0]["Fk_Company_ID"].ToString());
                    objINV.Fk_Branch_ID = Convert.ToInt64(dt.Rows[0]["Fk_Branch_ID"].ToString());
                    objINV.Fk_Year_ID = Convert.ToInt64(dt.Rows[0]["Fk_Year_ID"].ToString());

                    objINV.P_MVen_Name = dt.Rows[0]["MVen_Name"].ToString();

                    objINV.P_Category = dt.Rows[0]["PINV_Category"].ToString();

                    objINV.P_BillTo_State_ID = Convert.ToInt64(dt.Rows[0]["MVen_Reg_State_ID"].ToString());
                    objINV.P_State_ID = Convert.ToInt64(dt.Rows[0]["BR_Reg_State_ID"].ToString());



                    objINV.P_TrnType = dt.Rows[0]["PINV_TrnType"].ToString();
                    objINV.P_Type = dt.Rows[0]["PINV_Type"].ToString();
                    objINV.P_Taxtype = dt.Rows[0]["PINV_Taxtype"].ToString();

                    objINV.P_MVen_BL_GSTNO = dt.Rows[0]["MVen_BL_GSTNO"].ToString();
                    objINV.P_BL_GSTNO = dt.Rows[0]["BL_GSTNO"].ToString();

                    objINV.P_No = dt.Rows[0]["PINV_No"].ToString();
                    objINV.P_DT = dt.Rows[0]["vPINV_DT"].ToString();
                    objINV.P_Fk_VendorID = Convert.ToInt64(dt.Rows[0]["Fk_VendorID"].ToString());
                    objINV.P_CreditDays = Convert.ToInt64(dt.Rows[0]["PINV_CreditDays"].ToString());
                    objINV.P_DueDT = dt.Rows[0]["vPINV_DueDT"].ToString();
                    objINV.P_State_ID = Convert.ToInt64(dt.Rows[0]["PINV_State_ID"].ToString());
                    objINV.P_PONo = dt.Rows[0]["PINV_PONo"].ToString();
                    objINV.P_PO_DT = dt.Rows[0]["vPINV_PO_DT"].ToString();
                    objINV.P_BillTo_CompanyName = dt.Rows[0]["PINV_BillTo_CompanyName"].ToString();
                    objINV.P_BillTo_ContactPersone = dt.Rows[0]["PINV_BillTo_ContactPersone"].ToString();
                    objINV.P_BillTo_CP_MobileNo = dt.Rows[0]["PINV_BillTo_CP_MobileNo"].ToString();
                    objINV.P_BillTo_Add1 = dt.Rows[0]["PINV_BillTo_Add1"].ToString();
                    objINV.P_BillTo_Add2 = dt.Rows[0]["PINV_BillTo_Add2"].ToString();
                    objINV.P_BillTo_Add3 = dt.Rows[0]["PINV_BillTo_Add3"].ToString();
                    objINV.P_BillTo_Pincode = dt.Rows[0]["PINV_BillTo_Pincode"].ToString();
                    objINV.P_BillTo_Area = dt.Rows[0]["PINV_BillTo_Area"].ToString();
                    objINV.P_BillTo_City = dt.Rows[0]["PINV_BillTo_City"].ToString();
                    objINV.P_BillTo_State_ID = Convert.ToInt64(dt.Rows[0]["PINV_BillTo_State_ID"].ToString());
                    objINV.P_BillTo_Country = dt.Rows[0]["PINV_BillTo_Country"].ToString();
                    objINV.P_BillTo_GSTNo = dt.Rows[0]["PINV_BillTo_GSTNo"].ToString();
                    objINV.P_BillTo_PANNO = dt.Rows[0]["PINV_BillTo_PANNO"].ToString();
                    objINV.P_ShippTo_CompanyName = dt.Rows[0]["PINV_ShippTo_CompanyName"].ToString();
                    objINV.P_ShippTo_ContactPersone = dt.Rows[0]["PINV_ShippTo_ContactPersone"].ToString();
                    objINV.P_ShippTo_CP_MobileNo = dt.Rows[0]["PINV_ShippTo_CP_MobileNo"].ToString();
                    objINV.P_ShippTo_Add1 = dt.Rows[0]["PINV_ShippTo_Add1"].ToString();
                    objINV.P_ShippTo_Add2 = dt.Rows[0]["PINV_ShippTo_Add2"].ToString();
                    objINV.P_ShippTo_Add3 = dt.Rows[0]["PINV_ShippTo_Add3"].ToString();
                    objINV.P_ShippTo_Pincode = dt.Rows[0]["PINV_ShippTo_Pincode"].ToString();
                    objINV.P_ShippTo_Area = dt.Rows[0]["PINV_ShippTo_Area"].ToString();
                    objINV.P_ShippTo_City = dt.Rows[0]["PINV_ShippTo_City"].ToString();
                    objINV.P_ShippTo_State_ID = Convert.ToInt64(dt.Rows[0]["PINV_ShippTo_State_ID"].ToString());
                    objINV.P_ShippTo_Country = dt.Rows[0]["PINV_ShippTo_Country"].ToString();
                    objINV.P_ShippTo_GSTNo = dt.Rows[0]["PINV_ShippTo_GSTNo"].ToString();
                    objINV.P_ShippTo_PANNO = dt.Rows[0]["PINV_ShippTo_PANNO"].ToString();
                    objINV.P_ShippedFrom_CompanyName = dt.Rows[0]["PINV_ShippedFrom_CompanyName"].ToString();
                    objINV.P_ShippedFrom_ContactPersone = dt.Rows[0]["PINV_ShippedFrom_ContactPersone"].ToString();
                    objINV.P_ShippedFrom_CP_MobileNo = dt.Rows[0]["PINV_ShippedFrom_CP_MobileNo"].ToString();
                    objINV.P_ShippedFrom_Add1 = dt.Rows[0]["PINV_ShippedFrom_Add1"].ToString();
                    objINV.P_ShippedFrom_Add2 = dt.Rows[0]["PINV_ShippedFrom_Add2"].ToString();
                    objINV.P_ShippedFrom_Add3 = dt.Rows[0]["PINV_ShippedFrom_Add3"].ToString();
                    objINV.P_ShippedFrom_Pincode = dt.Rows[0]["PINV_ShippedFrom_Pincode"].ToString();
                    objINV.P_ShippedFrom_Area = dt.Rows[0]["PINV_ShippedFrom_Area"].ToString();
                    objINV.P_ShippedFrom_City = dt.Rows[0]["PINV_ShippedFrom_City"].ToString();
                    objINV.P_ShippedFrom_State_ID = Convert.ToInt64(dt.Rows[0]["PINV_ShippedFrom_State_ID"].ToString());
                    objINV.P_ShippedFrom_Country = dt.Rows[0]["PINV_ShippedFrom_Country"].ToString();
                    objINV.P_ShippedFrom_GSTNo = dt.Rows[0]["PINV_ShippedFrom_GSTNo"].ToString();
                    objINV.P_ShippedFrom_PANNO = dt.Rows[0]["PINV_ShippedFrom_PANNO"].ToString();
                    objINV.P_PaymentTerms = dt.Rows[0]["PINV_PaymentTerms"].ToString();
                    objINV.P_DelvieryPeriod = dt.Rows[0]["PINV_DelvieryPeriod"].ToString();
                    objINV.P_DeliveryCharges = dt.Rows[0]["PINV_DeliveryCharges"].ToString();
                    objINV.P_ExciseDuty = dt.Rows[0]["PINV_ExciseDuty"].ToString();
                    objINV.P_CompletionPeriod = dt.Rows[0]["PINV_CompletionPeriod"].ToString();
                    objINV.P_ModeOfDispatch = dt.Rows[0]["PINV_ModeOfDispatch"].ToString();
                    objINV.P_TranspoterName = dt.Rows[0]["PINV_TranspoterName"].ToString();
                    objINV.P_VehicleNumber = dt.Rows[0]["PINV_VehicleNumber"].ToString();
                    objINV.P_PlaceOfDelivery = dt.Rows[0]["PINV_PlaceOfDelivery"].ToString();
                    objINV.P_FreigthCharge_Txt = dt.Rows[0]["PINV_FreigthCharge_Txt"].ToString();
                    objINV.P_Insurance_Txt = dt.Rows[0]["PINV_Insurance_Txt"].ToString();
                    objINV.P_Remark = dt.Rows[0]["PINV_Remark"].ToString();
                    objINV.P_DTL_CNT = Convert.ToInt16(dt.Rows[0]["PINV_DTL_CNT"].ToString());
                    objINV.MDBSC_RowStatus = dt.Rows[0]["MDBSC_RowStatus"].ToString();

                    objINV.MDBSC_RowCreatedByUserName = dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
                    objINV.MDBSC_RowCreatedOn_DT = dt.Rows[0]["vMDBSC_RowCreatedOn_DT"].ToString();
                    objINV.MDBSC_RowLupdnUserName = dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
                    objINV.MDBSC_RowLupdnOn_DT = dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
                    objINV.P_HDR_BasicAmt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_BasicAmt"].ToString());
                    objINV.P_HDR_DiscountRate = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_DiscountRate"].ToString());
                    objINV.P_HDR_DiscountAmt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_DiscountAmt"].ToString());
                    objINV.P_HDR_Net_Amt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_Net_Amt"].ToString());
                    objINV.P_HDR_Freight_Charges = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_Freight_Charges"].ToString());
                    objINV.P_HDR_Loading_N_Packing_Charges = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_Loading_N_Packing_Charges"].ToString());
                    objINV.P_HDR_Insurance_Charges = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_Insurance_Charges"].ToString());
                    objINV.P_HDR_Other_Charges_Txt = dt.Rows[0]["PINV_HDR_Other_Charges_Txt"].ToString();
                    objINV.P_HDR_Other_Charges_Amt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_Other_Charges_Amt"].ToString());
                    objINV.P_HDR_Taxable_Amt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_Taxable_Amt"].ToString());
                    objINV.P_HDR_CGST_Amt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_CGST_Amt"].ToString());
                    objINV.P_HDR_CGST_Taxable_Amt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_CGST_Taxable_Amt"].ToString());
                    objINV.P_HDR_SGST_Amt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_SGST_Amt"].ToString());
                    objINV.P_HDR_SGST_Taxable_Amt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_SGST_Taxable_Amt"].ToString());
                    objINV.P_HDR_IGST_Amt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_IGST_Amt"].ToString());
                    objINV.P_HDR_IGST_Taxable_Amt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_IGST_Taxable_Amt"].ToString());
                    objINV.P_HDR_CESS_Amt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_CESS_Amt"].ToString());
                    objINV.P_HDR_CESS_Taxable_Amt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_CESS_Taxable_Amt"].ToString());
                    objINV.P_HDR_OtherTax_ID = Convert.ToInt16(dt.Rows[0]["PINV_HDR_OtherTax_ID"].ToString());
                    objINV.P_HDR_OtherTax_Rate = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_OtherTax_Rate"].ToString());
                    objINV.P_HDR_OtherTax_Amt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_OtherTax_Amt"].ToString());
                    objINV.P_HDR_Other_Taxable_Amt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_Other_Taxable_Amt"].ToString());
                    objINV.P_HDR_Total_Tax_Amt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_Total_Tax_Amt"].ToString());
                    objINV.P_HDR_ItemGross_Total_Amt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_ItemGross_Total_Amt"].ToString());
                    objINV.P_HDR_Gross_Amt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_Gross_Amt"].ToString());
                    objINV.P_HDR_Round_Off_Amt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_Round_Off_Amt"].ToString());
                    objINV.P_HDR_Total_Gross_Amt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_Total_Gross_Amt"].ToString());
                    objINV.P_HDR_Gross_AmtInWords = dt.Rows[0]["PINV_HDR_Gross_AmtInWords"].ToString();
                    objINV.P_HDR_CreditNote_AsOn_Amt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_CreditNote_AsOn_Amt"].ToString());
                    objINV.P_HDR_DebitNote_AsOn_Amt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_DebitNote_AsOn_Amt"].ToString());
                    objINV.P_HDR_TDS_Rate = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_TDS_Rate"].ToString());
                    objINV.P_HDR_TDS_Amt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_TDS_Amt"].ToString());
                    objINV.P_HDR_Paid_AsOn_Amt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_Paid_AsOn_Amt"].ToString());
                    objINV.P_HDR_Outstanding_AsOn_Amt = Convert.ToDecimal(dt.Rows[0]["PINV_HDR_Outstanding_AsOn_Amt"].ToString());
                    if (mvPINVHDR_ID > 0)
                    {
                        DataTable dt_Item = default(DataTable);
                        dt_Item = MABL.BL.AppDataModal.Get_Sales_Item_List(objINV.P_HDR_ID, 0, "", "");


                        //List<SalePINVDTL> ObjItem = new List<SalePINVDTL>();
                        for (int i = 0; i < dt_Item.Rows.Count; i++)
                        {

                            PurchaseDTL ObjItem = new PurchaseDTL();
                            ObjItem.PI_DTL_ID = Convert.ToInt64(dt_Item.Rows[i]["PINVDTL_ID"].ToString());
                            ObjItem.PI_HDR_ID = Convert.ToInt64(dt_Item.Rows[i]["Fk_PINVHDR_ID"].ToString());
                            ObjItem.PI_Fk_MItem_ID = Convert.ToInt64(dt_Item.Rows[i]["Fk_MItem_ID"].ToString());

                            ObjItem.PI_Item_Type = dt_Item.Rows[i]["Item_Type"].ToString();
                            ObjItem.PI_Item_Code = dt_Item.Rows[i]["Item_Code"].ToString();
                            ObjItem.PI_Item_Name = dt_Item.Rows[i]["Item_Name"].ToString();
                            ObjItem.PI_UOM = dt_Item.Rows[i]["UOM"].ToString();



                            ObjItem.PI_HSNCode = dt_Item.Rows[i]["PINV_HSNCode"].ToString();
                            ObjItem.PI_QTY = Convert.ToDecimal(dt_Item.Rows[i]["PINV_QTY"].ToString());
                            ObjItem.PI_BasicRate = Convert.ToDecimal(dt_Item.Rows[i]["PINV_BasicRate"].ToString());
                            ObjItem.PI_NetRate = Convert.ToDecimal(dt_Item.Rows[i]["PINV_NetRate"].ToString());
                            ObjItem.PI_BasicAmt = Convert.ToDecimal(dt_Item.Rows[i]["PINV_BasicAmt"].ToString());
                            ObjItem.PI_DiscountRate = Convert.ToDecimal(dt_Item.Rows[i]["PINV_DiscountRate"].ToString());
                            ObjItem.PI_DiscountAmt = Convert.ToDecimal(dt_Item.Rows[i]["PINV_DiscountAmt"].ToString());
                            ObjItem.PI_NetTaxableAmt = Convert.ToDecimal(dt_Item.Rows[i]["PINV_NetTaxableAmt"].ToString());
                            ObjItem.PI_GST_TaxRate_ID = Convert.ToInt16(dt_Item.Rows[i]["PINV_GST_TaxRate_ID"].ToString());
                            ObjItem.PI_GST_TaxRate = Convert.ToDecimal(dt_Item.Rows[i]["PINV_GST_TaxRate"].ToString());
                            ObjItem.PI_CGST_ID = Convert.ToInt16(dt_Item.Rows[i]["PINV_CGST_ID"].ToString());
                            ObjItem.PI_CGST_Rate = Convert.ToDecimal(dt_Item.Rows[i]["PINV_CGST_Rate"].ToString());
                            ObjItem.PI_CGST_Amt = Convert.ToDecimal(dt_Item.Rows[i]["PINV_CGST_Amt"].ToString());
                            ObjItem.PI_CGST_TaxableAmt = Convert.ToDecimal(dt_Item.Rows[i]["PINV_CGST_TaxableAmt"].ToString());
                            ObjItem.PI_SGST_ID = Convert.ToInt16(dt_Item.Rows[i]["PINV_SGST_ID"].ToString());
                            ObjItem.PI_SGST_Rate = Convert.ToDecimal(dt_Item.Rows[i]["PINV_SGST_Rate"].ToString());
                            ObjItem.PI_SGST_Amt = Convert.ToDecimal(dt_Item.Rows[i]["PINV_SGST_Amt"].ToString());
                            ObjItem.PI_SGST_TaxableAmt = Convert.ToDecimal(dt_Item.Rows[i]["PINV_SGST_TaxableAmt"].ToString());
                            ObjItem.PI_IGST_ID = Convert.ToInt16(dt_Item.Rows[i]["PINV_IGST_ID"].ToString());
                            ObjItem.PI_IGST_Rate = Convert.ToDecimal(dt_Item.Rows[i]["PINV_IGST_Rate"].ToString());
                            ObjItem.PI_IGST_Amt = Convert.ToDecimal(dt_Item.Rows[i]["PINV_IGST_Amt"].ToString());
                            ObjItem.PI_IGST_TaxableAmt = Convert.ToDecimal(dt_Item.Rows[i]["PINV_IGST_TaxableAmt"].ToString());
                            ObjItem.PI_CESS_ID = Convert.ToInt16(dt_Item.Rows[i]["PINV_CESS_ID"].ToString());
                            ObjItem.PI_CESS_Rate = Convert.ToDecimal(dt_Item.Rows[i]["PINV_CESS_Rate"].ToString());
                            ObjItem.PI_CESS_Amt = Convert.ToDecimal(dt_Item.Rows[i]["PINV_CESS_Amt"].ToString());
                            ObjItem.PI_CESS_TaxableAmt = Convert.ToDecimal(dt_Item.Rows[i]["PINV_CESS_TaxableAmt"].ToString());
                            ObjItem.PI_TotalTax = Convert.ToDecimal(dt_Item.Rows[i]["PINV_TotalTax"].ToString());
                            ObjItem.PI_GrossRateWithTax = Convert.ToDecimal(dt_Item.Rows[i]["PINV_GrossRateWithTax"].ToString());
                            ObjItem.PI_ItemRemark_DTL = dt_Item.Rows[i]["PINV_ItemRemark_DTL"].ToString();
                            objINV.PINVDTL.Add(ObjItem);
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
        public static string CU_Sales_InvHDR(PurchaseHDR mobj_PurchaseHDR)
        {
            M_AT_Purchase_Inv_AHDRBO ObjAT_PINVHDR = new M_AT_Purchase_Inv_AHDRBO();
            string strRetMst = "";
            string strSQLDeleteQuery = "";
            DataTable dt = new DataTable();
            string var_ErrorMessage = "";
            try
            {

                if (mobj_PurchaseHDR.P_Fk_VendorID == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Select Customer.<br>";
                }
                if (mobj_PurchaseHDR.P_No.Length == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Customer Invoice No Cannot Be Blank.<br>";
                }

                if (mobj_PurchaseHDR.P_ShippedFrom_State_ID == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Place Of Dispatch<br>";
                }


                if (mobj_PurchaseHDR.P_ShippTo_State_ID == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Place Of Supply<br>";
                }



                if ((mobj_PurchaseHDR.P_No.Length > 0) && (mobj_PurchaseHDR.P_Fk_VendorID > 0))
                {
                    if (SQLManager.CheckDuplicateRecord("M_AT_Purchase_Inv_AHDR", "PINVHDR_ID", Convert.ToInt32("0" + mobj_PurchaseHDR.P_HDR_ID), "PINV_No", mobj_PurchaseHDR.P_No,
                                                       " AND Fk_Branch_ID=" + mobj_PurchaseHDR.Fk_Branch_ID))
                    {
                        var_ErrorMessage = var_ErrorMessage + "Customer Invoice Already Exist.<br>";
                    }
                }

                if (mobj_PurchaseHDR.P_DT.Length != 11)
                {
                    var_ErrorMessage = var_ErrorMessage + "Invalid Vendor Invoice Date.<br>";
                }

                if ((mobj_PurchaseHDR.P_Fk_VendorID > 0) && (Convert.ToInt32(mobj_PurchaseHDR.P_HDR_ID) == 0))
                {
                    if (mobj_PurchaseHDR.PINVDTL.Count() == 0)
                    {
                        var_ErrorMessage = var_ErrorMessage + "Pls add atleast one Item to create invoice<br>";
                    }
                    else
                    {
                        foreach (var item in mobj_PurchaseHDR.PINVDTL)
                        {

                            if (item.PI_BasicRate <= 0)
                            {
                                var_ErrorMessage = var_ErrorMessage + "Invalid Item Rate<br>";
                            }
                            if (item.PI_QTY <= 0)
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
                        if (Convert.ToInt32(mobj_PurchaseHDR.P_HDR_ID) == 0)
                        {
                            ObjAT_PINVHDR.Fk_Company_ID = mobj_PurchaseHDR.Fk_Company_ID;
                            ObjAT_PINVHDR.Fk_Branch_ID = mobj_PurchaseHDR.Fk_Branch_ID;
                            ObjAT_PINVHDR.Fk_Year_ID = mobj_PurchaseHDR.Fk_Year_ID;
                            ObjAT_PINVHDR.Rec_Created_In = "HO";
                            ObjAT_PINVHDR.Rec_CreatedBy_ID = mobj_PurchaseHDR.Fk_Branch_ID;
                            ObjAT_PINVHDR.Rec_CreatedFor_ID = mobj_PurchaseHDR.Fk_Branch_ID;
                            ObjAT_PINVHDR.PINV_CreationType = "Manual";
                            ObjAT_PINVHDR.PINV_Category = "Tax Invoice";
                            ObjAT_PINVHDR.MDBSC_RowCreatedByUserName = mobj_PurchaseHDR.MDBSC_RowCreatedByUserName;
                            ObjAT_PINVHDR.MDBSC_RowCreatedByUser_ID = mobj_PurchaseHDR.MDBSC_RowCreatedByUser_ID;
                            ObjAT_PINVHDR.PINV_No = MaheshAF18.Application.MEF.GenrateRefNo(mobj_PurchaseHDR.Fk_Company_ID, mobj_PurchaseHDR.Fk_Branch_ID, mobj_PurchaseHDR.Fk_Year_ID, "INV", "INV", "INV/" + MaheshAF18.Utility.DateHelper.DateYearPrefix("YYMM"), "Yes", "", "", "", 0);


                        }


                        ObjAT_PINVHDR.PINVHDR_ID = Convert.ToInt64("0" + mobj_PurchaseHDR.P_HDR_ID);


                        ObjAT_PINVHDR.PINV_DT = mobj_PurchaseHDR.P_DT;
                        ObjAT_PINVHDR.Fk_VendorID = Convert.ToInt32(mobj_PurchaseHDR.P_Fk_VendorID);
                        ObjAT_PINVHDR.PINV_CreditDays = Convert.ToInt32("0" + mobj_PurchaseHDR.P_CreditDays);
                        ObjAT_PINVHDR.PINV_PONo = mobj_PurchaseHDR.P_PONo;
                        if (mobj_PurchaseHDR.P_PO_DT.Length == 11)
                        {
                            ObjAT_PINVHDR.PINV_PO_DT = mobj_PurchaseHDR.P_PO_DT;
                        }
                        ObjAT_PINVHDR.PINV_Remark = mobj_PurchaseHDR.P_Remark;
                        ObjAT_PINVHDR.MDBSC_RowStatus = mobj_PurchaseHDR.MDBSC_RowStatus;
                        ObjAT_PINVHDR.MDBSC_RowLupdnByUser_ID = mobj_PurchaseHDR.MDBSC_RowCreatedByUser_ID;
                        ObjAT_PINVHDR.MDBSC_RowLupdnUserName = mobj_PurchaseHDR.MDBSC_RowCreatedByUserName;
                        ObjAT_PINVHDR.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
                        ObjAT_PINVHDR.PINV_HDR_Freight_Charges = Convert.ToDecimal("0" + mobj_PurchaseHDR.P_HDR_Freight_Charges);

                        ObjAT_PINVHDR.PINV_BillTo_Add1 = mobj_PurchaseHDR.P_BillTo_Add1;
                        ObjAT_PINVHDR.PINV_BillTo_Add2 = mobj_PurchaseHDR.P_BillTo_Add2;
                        ObjAT_PINVHDR.PINV_BillTo_Add3 = mobj_PurchaseHDR.P_BillTo_Add3;
                        ObjAT_PINVHDR.PINV_BillTo_Pincode = mobj_PurchaseHDR.P_BillTo_Pincode;
                        ObjAT_PINVHDR.PINV_BillTo_City = mobj_PurchaseHDR.P_BillTo_City;
                        ObjAT_PINVHDR.PINV_BillTo_Country = mobj_PurchaseHDR.P_BillTo_Country;
                        ObjAT_PINVHDR.PINV_BillTo_PANNO = mobj_PurchaseHDR.P_BillTo_PANNO;
                        ObjAT_PINVHDR.PINV_BillTo_GSTNo = mobj_PurchaseHDR.P_BillTo_GSTNo;


                        ObjAT_PINVHDR.PINV_ShippTo_CompanyName = mobj_PurchaseHDR.P_ShippTo_CompanyName;
                        ObjAT_PINVHDR.PINV_ShippTo_ContactPersone = mobj_PurchaseHDR.P_ShippTo_ContactPersone;
                        ObjAT_PINVHDR.PINV_ShippTo_CP_MobileNo = mobj_PurchaseHDR.P_ShippTo_CP_MobileNo;
                        ObjAT_PINVHDR.PINV_ShippTo_Add1 = mobj_PurchaseHDR.P_ShippTo_Add1;
                        ObjAT_PINVHDR.PINV_ShippTo_Add2 = mobj_PurchaseHDR.P_ShippTo_Add2;
                        ObjAT_PINVHDR.PINV_ShippTo_Add3 = mobj_PurchaseHDR.P_ShippTo_Add3;
                        ObjAT_PINVHDR.PINV_ShippTo_Pincode = mobj_PurchaseHDR.P_ShippTo_Pincode;

                        ObjAT_PINVHDR.PINV_ShippedFrom_CompanyName = "";
                        ObjAT_PINVHDR.PINV_ShippedFrom_ContactPersone = "";
                        ObjAT_PINVHDR.PINV_ShippedFrom_CP_MobileNo = "";
                        ObjAT_PINVHDR.PINV_ShippedFrom_Add1 = "";
                        ObjAT_PINVHDR.PINV_ShippedFrom_Add2 = "";
                        ObjAT_PINVHDR.PINV_ShippedFrom_Add3 = "";
                        ObjAT_PINVHDR.PINV_ShippedFrom_Pincode = "";

                        ObjAT_PINVHDR.PINV_ShippedFrom_City = "";
                        ObjAT_PINVHDR.PINV_ShippedFrom_State_ID = Convert.ToInt64(mobj_PurchaseHDR.P_ShippedFrom_State_ID);
                        ObjAT_PINVHDR.PINV_ShippedFrom_Country = "";
                        ObjAT_PINVHDR.PINV_ShippedFrom_GSTNo = "";
                        ObjAT_PINVHDR.PINV_ShippedFrom_PANNO = "";


                        ObjAT_PINVHDR.PINV_ShippTo_City = mobj_PurchaseHDR.P_ShippTo_City;
                        ObjAT_PINVHDR.PINV_ShippTo_State_ID = Convert.ToInt64(mobj_PurchaseHDR.P_ShippTo_State_ID);
                        ObjAT_PINVHDR.PINV_ShippTo_Country = mobj_PurchaseHDR.P_ShippTo_Country;
                        ObjAT_PINVHDR.PINV_ShippTo_GSTNo = mobj_PurchaseHDR.P_ShippTo_GSTNo;
                        ObjAT_PINVHDR.PINV_ShippTo_PANNO = mobj_PurchaseHDR.P_ShippTo_PANNO;


                        ObjAT_PINVHDR.PINV_ModeOfDispatch = mobj_PurchaseHDR.P_ModeOfDispatch;
                        ObjAT_PINVHDR.PINV_PaymentTerms = mobj_PurchaseHDR.P_PaymentTerms;
                        ObjAT_PINVHDR.PINV_DelvieryPeriod = mobj_PurchaseHDR.P_DelvieryPeriod;
                        ObjAT_PINVHDR.PINV_TranspoterName = mobj_PurchaseHDR.P_TranspoterName;

                        ObjAT_PINVHDR.PINV_PlaceOfDelivery = mobj_PurchaseHDR.P_PlaceOfDelivery;
                        ObjAT_PINVHDR.PINV_VehicleNumber = mobj_PurchaseHDR.P_VehicleNumber;

                        var_ErrorMessage = ObjAT_PINVHDR.Insert_Update(ObjAT_PINVHDR);
                        mobj_PurchaseHDR.P_HDR_ID = Convert.ToInt64(var_ErrorMessage.Substring((var_ErrorMessage.IndexOf("|") + 1), (var_ErrorMessage.Length - var_ErrorMessage.IndexOf("|") - 1)));
                        //   var_ErrorMessage = var_ErrorMessage.Substring((0), (var_ErrorMessage.IndexOf("|")));

                        if ((mobj_PurchaseHDR.P_HDR_ID > 0) && (mobj_PurchaseHDR.PINVDTL.Count() > 0))
                        {
                            for (int i = 0; i < mobj_PurchaseHDR.PINVDTL.Count(); i++)
                            {
                                M_AT_Purchase_Inv_BDTLBO ObjAT_PINVDTL = new M_AT_Purchase_Inv_BDTLBO();
                                if (mobj_PurchaseHDR.PINVDTL[i].IsDelete == "Y")
                                {
                                    strSQLDeleteQuery = strSQLDeleteQuery + mobj_PurchaseHDR.PINVDTL[i].PI_DTL_ID + ",";
                                }
                                else
                                {
                                    ObjAT_PINVDTL.PINVDTL_ID = mobj_PurchaseHDR.PINVDTL[i].PI_DTL_ID;
                                    ObjAT_PINVDTL.Fk_PINVHDR_ID = mobj_PurchaseHDR.P_HDR_ID;

                                    ObjAT_PINVDTL.MDBSC_RowCreatedByUser_ID = mobj_PurchaseHDR.MDBSC_RowCreatedByUser_ID;
                                    ObjAT_PINVDTL.MDBSC_RowCreatedByUserName = mobj_PurchaseHDR.MDBSC_RowCreatedByUserName;


                                    ObjAT_PINVDTL.Fk_MItem_ID = mobj_PurchaseHDR.PINVDTL[i].PI_Fk_MItem_ID;
                                    ObjAT_PINVDTL.PINV_HSNCode = mobj_PurchaseHDR.PINVDTL[i].PI_HSNCode;
                                    ObjAT_PINVDTL.PINV_QTY = mobj_PurchaseHDR.PINVDTL[i].PI_QTY;
                                    ObjAT_PINVDTL.PINV_Final_Qty = mobj_PurchaseHDR.PINVDTL[i].PI_QTY;
                                    ObjAT_PINVDTL.PINV_BasicRate = mobj_PurchaseHDR.PINVDTL[i].PI_BasicRate;
                                    ObjAT_PINVDTL.PINV_DiscountRate = mobj_PurchaseHDR.PINVDTL[i].PI_DiscountRate;
                                    ObjAT_PINVDTL.PINV_CGST_ID = 0;
                                    ObjAT_PINVDTL.PINV_SGST_ID = 0;
                                    ObjAT_PINVDTL.PINV_IGST_ID = 0;
                                    ObjAT_PINVDTL.PINV_CESS_ID = 0;

                                    ObjAT_PINVDTL.PINV_ItemRemark_DTL = mobj_PurchaseHDR.PINVDTL[i].PI_ItemRemark_DTL;
                                    ObjAT_PINVDTL.MDBSC_RowLupdnByUser_ID = mobj_PurchaseHDR.MDBSC_RowCreatedByUser_ID;
                                    ObjAT_PINVDTL.MDBSC_RowLupdnUserName = mobj_PurchaseHDR.MDBSC_RowCreatedByUserName;
                                    ObjAT_PINVDTL.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));


                                    ObjAT_PINVDTL.Insert_Update(ObjAT_PINVDTL);
                                }
                            }
                        }
                        scope.Complete();
                    }

                    if (strSQLDeleteQuery.Length > 0)
                    {
                        strSQLDeleteQuery = strSQLDeleteQuery.Remove(strSQLDeleteQuery.Length - 1);
                        strSQLDeleteQuery = "DELETE FROM M_AT_Purchase_Inv_BDTL WHERE Fk_PINVHDR_ID=" + mobj_PurchaseHDR.P_HDR_ID + " AND   PINVDTL_ID IN (" + strSQLDeleteQuery + ")";
                        MaheshAF18.Application.MEF.DA_ExecuteQuery(strSQLDeleteQuery);
                    }

                    if (mobj_PurchaseHDR.P_HDR_ID > 0)
                    {
                        MABL.SQLManager.SQLProcedureCall.USP_Update_Tbl_Purchase(mobj_PurchaseHDR.Fk_Company_ID, mobj_PurchaseHDR.Fk_Branch_ID, mobj_PurchaseHDR.Fk_Year_ID, mobj_PurchaseHDR.P_HDR_ID);

                    }

                    strRetMst = var_ErrorMessage;

                }
                else
                {
                    strRetMst = var_ErrorMessage + "|" + mobj_PurchaseHDR.P_HDR_ID.ToString();
                }


                return strRetMst;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static PurchaseHDR Get_DNCN_Lst(Int64 mvPINVHDR_ID, string StrFilterCriteria, string SearchCriteria)
        {

            DataTable dt = new DataTable();
            try
            {
                PurchaseHDR obj_DCNC = new PurchaseHDR();
                obj_DCNC.PINVDTL = new List<PurchaseDTL>();
                dt = AppData.Get_DT_Sales_DNCN_HDR_List(mvPINVHDR_ID, StrFilterCriteria, SearchCriteria);
                if (dt.Rows.Count > 0)
                {
                    obj_DCNC.P_HDR_ID = Convert.ToInt64(dt.Rows[0]["DCNVHDR_ID"].ToString());
                    obj_DCNC.Fk_Company_ID = Convert.ToInt64(dt.Rows[0]["Fk_Company_ID"].ToString());
                    obj_DCNC.Fk_Branch_ID = Convert.ToInt64(dt.Rows[0]["Fk_Branch_ID"].ToString());
                    obj_DCNC.Fk_Year_ID = Convert.ToInt64(dt.Rows[0]["Fk_Year_ID"].ToString());

                    obj_DCNC.P_Type = dt.Rows[0]["DCNC_Type"].ToString();
                    obj_DCNC.P_Category = dt.Rows[0]["DCNC_Category"].ToString();
                    obj_DCNC.P_TrnType = dt.Rows[0]["DCNC_TrnType"].ToString();
                    obj_DCNC.P_Taxtype = dt.Rows[0]["DCNC_Taxtype"].ToString();


                    obj_DCNC.P_No = dt.Rows[0]["DCNC_No"].ToString();
                    obj_DCNC.P_DT = dt.Rows[0]["vDCNC_DT"].ToString();
                    obj_DCNC.P_MVen_Name = dt.Rows[0]["MVen_Name"].ToString();

                    obj_DCNC.P_MVen_BL_GSTNO = dt.Rows[0]["MVen_BL_GSTNO"].ToString();
                    obj_DCNC.P_BL_GSTNO = dt.Rows[0]["BL_GSTNO"].ToString();
                    obj_DCNC.P_BR_Reg_StateDisplayName = dt.Rows[0]["BR_Reg_StateDisplayName"].ToString();
                    obj_DCNC.P_MVen_Reg_StateDisplayName = dt.Rows[0]["MVen_Reg_StateDisplayName"].ToString();


                    obj_DCNC.P_No = dt.Rows[0]["PINV_No"].ToString();
                    obj_DCNC.P_DT = dt.Rows[0]["vPINV_DT"].ToString();



                    obj_DCNC.P_Remark = dt.Rows[0]["DCNC_Remark"].ToString();
                    obj_DCNC.P_DTL_CNT = Convert.ToInt16(dt.Rows[0]["DCNC_DTL_CNT"].ToString());
                    obj_DCNC.MDBSC_RowStatus = dt.Rows[0]["MDBSC_RowStatus"].ToString();

                    obj_DCNC.MDBSC_RowCreatedByUserName = dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
                    obj_DCNC.MDBSC_RowCreatedOn_DT = dt.Rows[0]["vMDBSC_RowCreatedOn_DT"].ToString();
                    obj_DCNC.MDBSC_RowLupdnUserName = dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
                    obj_DCNC.MDBSC_RowLupdnOn_DT = dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
                    obj_DCNC.P_HDR_BasicAmt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_BasicAmt"].ToString());
                    obj_DCNC.P_HDR_DiscountRate = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_DiscountRate"].ToString());
                    obj_DCNC.P_HDR_DiscountAmt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_DiscountAmt"].ToString());
                    obj_DCNC.P_HDR_Net_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_Net_Amt"].ToString());
                    obj_DCNC.P_HDR_Freight_Charges = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_Freight_Charges"].ToString());
                    obj_DCNC.P_HDR_Loading_N_Packing_Charges = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_Loading_N_Packing_Charges"].ToString());
                    obj_DCNC.P_HDR_Insurance_Charges = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_Insurance_Charges"].ToString());
                    obj_DCNC.P_HDR_Other_Charges_Txt = dt.Rows[0]["DCNC_HDR_Other_Charges_Txt"].ToString();
                    obj_DCNC.P_HDR_Other_Charges_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_Other_Charges_Amt"].ToString());
                    obj_DCNC.P_HDR_Taxable_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_Taxable_Amt"].ToString());
                    obj_DCNC.P_HDR_CGST_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_CGST_Amt"].ToString());
                    obj_DCNC.P_HDR_CGST_Taxable_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_CGST_Taxable_Amt"].ToString());
                    obj_DCNC.P_HDR_SGST_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_SGST_Amt"].ToString());
                    obj_DCNC.P_HDR_SGST_Taxable_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_SGST_Taxable_Amt"].ToString());
                    obj_DCNC.P_HDR_IGST_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_IGST_Amt"].ToString());
                    obj_DCNC.P_HDR_IGST_Taxable_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_IGST_Taxable_Amt"].ToString());
                    obj_DCNC.P_HDR_CESS_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_CESS_Amt"].ToString());
                    obj_DCNC.P_HDR_CESS_Taxable_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_CESS_Taxable_Amt"].ToString());
                    obj_DCNC.P_HDR_OtherTax_ID = Convert.ToInt16(dt.Rows[0]["DCNC_HDR_OtherTax_ID"].ToString());
                    obj_DCNC.P_HDR_OtherTax_Rate = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_OtherTax_Rate"].ToString());
                    obj_DCNC.P_HDR_OtherTax_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_OtherTax_Amt"].ToString());
                    obj_DCNC.P_HDR_Other_Taxable_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_Other_Taxable_Amt"].ToString());
                    obj_DCNC.P_HDR_Total_Tax_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_Total_Tax_Amt"].ToString());
                    obj_DCNC.P_HDR_ItemGross_Total_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_ItemGross_Total_Amt"].ToString());
                    obj_DCNC.P_HDR_Gross_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_Gross_Amt"].ToString());
                    obj_DCNC.P_HDR_Round_Off_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_Round_Off_Amt"].ToString());
                    obj_DCNC.P_HDR_Total_Gross_Amt = Convert.ToDecimal(dt.Rows[0]["DCNC_HDR_Total_Gross_Amt"].ToString());
                    obj_DCNC.P_HDR_Gross_AmtInWords = dt.Rows[0]["DCNC_HDR_Gross_AmtInWords"].ToString();


                    if (mvPINVHDR_ID > 0)
                    {
                        DataTable dt_Item = default(DataTable);
                        dt_Item = MABL.BL.AppDataModal.Get_Cust_DCN_Item_List(obj_DCNC.P_HDR_ID, 0, "", "");


                        //List<SalePINVDTL> ObjItem = new List<SalePINVDTL>();
                        for (int i = 0; i < dt_Item.Rows.Count; i++)
                        {

                            PurchaseDTL ObjItem = new PurchaseDTL();
                            ObjItem.PI_DTL_ID = Convert.ToInt64(dt_Item.Rows[i]["DCNVDTL_ID"].ToString());
                            ObjItem.PI_HDR_ID = Convert.ToInt64(dt_Item.Rows[i]["Fk_DCNVHDR_ID"].ToString());
                            ObjItem.PI_Fk_MItem_ID = Convert.ToInt64(dt_Item.Rows[i]["Fk_MItem_ID"].ToString());

                            ObjItem.PI_Item_Type = dt_Item.Rows[i]["Item_Type"].ToString();
                            ObjItem.PI_Item_Code = dt_Item.Rows[i]["Item_Code"].ToString();
                            ObjItem.PI_Item_Name = dt_Item.Rows[i]["Item_Name"].ToString();
                            ObjItem.PI_UOM = dt_Item.Rows[i]["UOM"].ToString();

                            ObjItem.PI_HSNCode = dt_Item.Rows[i]["DCNC_HSNCode"].ToString();
                            ObjItem.PI_QTY = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_QTY"].ToString());
                            ObjItem.PI_BasicRate = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_BasicRate"].ToString());
                            ObjItem.PI_NetRate = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_NetRate"].ToString());
                            ObjItem.PI_BasicAmt = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_BasicAmt"].ToString());
                            ObjItem.PI_DiscountRate = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_DiscountRate"].ToString());
                            ObjItem.PI_DiscountAmt = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_DiscountAmt"].ToString());
                            ObjItem.PI_NetTaxableAmt = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_NetTaxableAmt"].ToString());
                            ObjItem.PI_GST_TaxRate_ID = Convert.ToInt16(dt_Item.Rows[i]["DCNC_GST_TaxRate_ID"].ToString());
                            ObjItem.PI_GST_TaxRate = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_GST_TaxRate"].ToString());
                            ObjItem.PI_CGST_ID = Convert.ToInt16(dt_Item.Rows[i]["DCNC_CGST_ID"].ToString());
                            ObjItem.PI_CGST_Rate = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_CGST_Rate"].ToString());
                            ObjItem.PI_CGST_Amt = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_CGST_Amt"].ToString());
                            ObjItem.PI_CGST_TaxableAmt = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_CGST_TaxableAmt"].ToString());
                            ObjItem.PI_SGST_ID = Convert.ToInt16(dt_Item.Rows[i]["DCNC_SGST_ID"].ToString());
                            ObjItem.PI_SGST_Rate = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_SGST_Rate"].ToString());
                            ObjItem.PI_SGST_Amt = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_SGST_Amt"].ToString());
                            ObjItem.PI_SGST_TaxableAmt = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_SGST_TaxableAmt"].ToString());
                            ObjItem.PI_IGST_ID = Convert.ToInt16(dt_Item.Rows[i]["DCNC_IGST_ID"].ToString());
                            ObjItem.PI_IGST_Rate = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_IGST_Rate"].ToString());
                            ObjItem.PI_IGST_Amt = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_IGST_Amt"].ToString());
                            ObjItem.PI_IGST_TaxableAmt = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_IGST_TaxableAmt"].ToString());
                            ObjItem.PI_CESS_ID = Convert.ToInt16(dt_Item.Rows[i]["DCNC_CESS_ID"].ToString());
                            ObjItem.PI_CESS_Rate = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_CESS_Rate"].ToString());
                            ObjItem.PI_CESS_Amt = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_CESS_Amt"].ToString());
                            ObjItem.PI_CESS_TaxableAmt = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_CESS_TaxableAmt"].ToString());
                            ObjItem.PI_TotalTax = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_TotalTax"].ToString());
                            ObjItem.PI_GrossRateWithTax = Convert.ToDecimal(dt_Item.Rows[i]["DCNC_GrossRateWithTax"].ToString());
                            ObjItem.PI_ItemRemark_DTL = dt_Item.Rows[i]["DCNC_ItemRemark_DTL"].ToString();
                            obj_DCNC.PINVDTL.Add(ObjItem);
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

        public static string CU_Purchase_DNCN(PurchaseHDR mobj_DCNV)
        {
            M_AT_DNC_Ven_AHDRBO ObjAT_DNCN_HDR = new M_AT_DNC_Ven_AHDRBO();
            string strRetMst = "";
            string strSQLDeleteQuery = "";
            DataTable dt = new DataTable();
            string var_ErrorMessage = "";
            try
            {
                if (mobj_DCNV.P_Type.Length == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Select Debit Not Or Credit Note.<br>";
                }

                if (mobj_DCNV.P_DCNC_No.Length == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "DNCN No Cannot Be Blank.<br>";
                }

                if (mobj_DCNV.P_DCNC_DT.Length != 11)
                {
                    var_ErrorMessage = var_ErrorMessage + "Invalid DNCN Date.<br>";
                }

                if (mobj_DCNV.P_Fk_INVHDR_ID == 0)
                {
                    var_ErrorMessage = var_ErrorMessage + "Invalid Invoice No.<br>";
                }

                if ((mobj_DCNV.P_Fk_VendorID > 0) && (Convert.ToInt32(mobj_DCNV.P_HDR_ID) == 0))
                {
                    if (mobj_DCNV.PINVDTL.Count() == 0)
                    {
                        var_ErrorMessage = var_ErrorMessage + "Pls add atleast one Item to create DNCN<br>";
                    }
                    else
                    {
                        foreach (var item in mobj_DCNV.PINVDTL)
                        {

                            if (item.PI_BasicRate <= 0)
                            {
                                var_ErrorMessage = var_ErrorMessage + "Invalid Item Rate<br>";
                            }
                            if (item.PI_QTY <= 0)
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
                        if (Convert.ToInt32(mobj_DCNV.P_HDR_ID) == 0)
                        {
                            ObjAT_DNCN_HDR.Fk_Company_ID = mobj_DCNV.Fk_Company_ID;
                            ObjAT_DNCN_HDR.Fk_Branch_ID = mobj_DCNV.Fk_Branch_ID;
                            ObjAT_DNCN_HDR.Fk_Year_ID = mobj_DCNV.Fk_Year_ID;
                            ObjAT_DNCN_HDR.Rec_Created_In = "HO";
                            ObjAT_DNCN_HDR.Rec_CreatedBy_ID = mobj_DCNV.Fk_Branch_ID;
                            ObjAT_DNCN_HDR.Rec_CreatedFor_ID = mobj_DCNV.Fk_Branch_ID;
                            ObjAT_DNCN_HDR.DCNV_CreationType = "Manual";
                            ObjAT_DNCN_HDR.DCNV_Category = mobj_DCNV.P_Category;

                            ObjAT_DNCN_HDR.DCNV_TrnType = mobj_DCNV.P_TrnType;
                            ObjAT_DNCN_HDR.DCNV_Type = mobj_DCNV.P_Type;



                            ObjAT_DNCN_HDR.MDBSC_RowCreatedByUserName = mobj_DCNV.MDBSC_RowCreatedByUserName;
                            ObjAT_DNCN_HDR.MDBSC_RowCreatedByUser_ID = mobj_DCNV.MDBSC_RowCreatedByUser_ID;
                            ObjAT_DNCN_HDR.DCNV_No = MaheshAF18.Application.MEF.GenrateRefNo(mobj_DCNV.Fk_Company_ID, mobj_DCNV.Fk_Branch_ID, mobj_DCNV.Fk_Year_ID, "INV", "INV", "INV/" + MaheshAF18.Utility.DateHelper.DateYearPrefix("YYMM"), "Yes", "", "", "", 0);


                        }


                        ObjAT_DNCN_HDR.DCNVHDR_ID = Convert.ToInt64("0" + mobj_DCNV.P_HDR_ID);


                        ObjAT_DNCN_HDR.DCNV_DT = mobj_DCNV.P_DCNC_DT;
                        ObjAT_DNCN_HDR.Fk_INVHDR_ID = Convert.ToInt32(mobj_DCNV.P_Fk_INVHDR_ID);



                        ObjAT_DNCN_HDR.DCNV_Remark = mobj_DCNV.P_Remark;
                        ObjAT_DNCN_HDR.MDBSC_RowStatus = mobj_DCNV.MDBSC_RowStatus;
                        ObjAT_DNCN_HDR.MDBSC_RowLupdnByUser_ID = mobj_DCNV.MDBSC_RowCreatedByUser_ID;
                        ObjAT_DNCN_HDR.MDBSC_RowLupdnUserName = mobj_DCNV.MDBSC_RowCreatedByUserName;
                        ObjAT_DNCN_HDR.MDBSC_RowLupdnOn_DT = DateHelper.ConvertToDataBase(DateHelper.ConvertToForm(DateTime.Now));
                        ObjAT_DNCN_HDR.DCNV_HDR_Freight_Charges = Convert.ToDecimal("0" + mobj_DCNV.P_HDR_Freight_Charges);


                        var_ErrorMessage = ObjAT_DNCN_HDR.Insert_Update(ObjAT_DNCN_HDR);
                        mobj_DCNV.P_HDR_ID = Convert.ToInt64(var_ErrorMessage.Substring((var_ErrorMessage.IndexOf("|") + 1), (var_ErrorMessage.Length - var_ErrorMessage.IndexOf("|") - 1)));
                        //   var_ErrorMessage = var_ErrorMessage.Substring((0), (var_ErrorMessage.IndexOf("|")));

                        if ((mobj_DCNV.P_HDR_ID > 0) && (mobj_DCNV.PINVDTL.Count() > 0))
                        {
                            for (int i = 0; i < mobj_DCNV.PINVDTL.Count(); i++)
                            {
                                M_AT_DNC_Ven_BDTLBO ObjAT_DNCN_DTL = new M_AT_DNC_Ven_BDTLBO();
                                if (mobj_DCNV.PINVDTL[i].IsDelete == "Y")
                                {
                                    strSQLDeleteQuery = strSQLDeleteQuery + mobj_DCNV.PINVDTL[i].PI_DTL_ID + ",";
                                }
                                else
                                {

                                    ObjAT_DNCN_DTL.MDBSC_RowCreatedByUser_ID = mobj_DCNV.MDBSC_RowCreatedByUser_ID;
                                    ObjAT_DNCN_DTL.MDBSC_RowCreatedByUserName = mobj_DCNV.MDBSC_RowCreatedByUserName;
                                    ObjAT_DNCN_DTL.DCNVDTL_ID = mobj_DCNV.PINVDTL[i].PI_DTL_ID;
                                    ObjAT_DNCN_DTL.Fk_DCNVHDR_ID = mobj_DCNV.P_HDR_ID;
                                    ObjAT_DNCN_DTL.Fk_MItem_ID = mobj_DCNV.PINVDTL[i].PI_Fk_MItem_ID;
                                    ObjAT_DNCN_DTL.DCNV_HSNCode = mobj_DCNV.PINVDTL[i].PI_HSNCode;
                                    ObjAT_DNCN_DTL.DCNV_QTY = mobj_DCNV.PINVDTL[i].PI_QTY;
                                    ObjAT_DNCN_DTL.DCNV_BasicRate = mobj_DCNV.PINVDTL[i].PI_BasicRate;
                                    ObjAT_DNCN_DTL.DCNV_DiscountRate = mobj_DCNV.PINVDTL[i].PI_DiscountRate;
                                    ObjAT_DNCN_DTL.DCNV_CGST_ID = 0;
                                    ObjAT_DNCN_DTL.DCNV_SGST_ID = 0;
                                    ObjAT_DNCN_DTL.DCNV_IGST_ID = 0;
                                    ObjAT_DNCN_DTL.DCNV_CESS_ID = 0;

                                    ObjAT_DNCN_DTL.DCNV_ItemRemark_DTL = mobj_DCNV.PINVDTL[i].PI_ItemRemark_DTL;
                                    ObjAT_DNCN_DTL.MDBSC_RowLupdnByUser_ID = mobj_DCNV.MDBSC_RowCreatedByUser_ID;
                                    ObjAT_DNCN_DTL.MDBSC_RowLupdnUserName = mobj_DCNV.MDBSC_RowCreatedByUserName;
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
                        strSQLDeleteQuery = "DELETE FROM M_AT_DNC_Ven_BDTL WHERE Fk_DCNVHDR_ID=" + mobj_DCNV.P_HDR_ID + " AND   DCNVDTL_ID IN (" + strSQLDeleteQuery + ")";
                        MaheshAF18.Application.MEF.DA_ExecuteQuery(strSQLDeleteQuery);
                    }   

                    if (mobj_DCNV.P_HDR_ID > 0)
                    {
                        MABL.SQLManager.SQLProcedureCall.USP_Update_Tbl_DCN_Ven(mobj_DCNV.Fk_Company_ID, mobj_DCNV.Fk_Branch_ID, mobj_DCNV.Fk_Year_ID, mobj_DCNV.P_HDR_ID);

                    }

                    strRetMst = var_ErrorMessage;

                }
                else
                {
                    strRetMst = var_ErrorMessage + "|" + mobj_DCNV.P_HDR_ID.ToString();
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