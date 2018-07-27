using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal
{
    public class M_AT_Sales_DC_AHDRBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public M_AT_Sales_DC_AHDRBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "DCHDR_ID";
        private string _TableName = "M_AT_Sales_DC_AHDR";
        private string _PrimaryKeyValue = "0";
        private ArrayList _UpdateFieldName = new ArrayList();
        public string TableName
        {
            get { return _TableName; }
            set { this._TableName = value; }
        }
        public string PrimaryKeyName
        {
            get { return _PrimaryKeyName; }
            set { this._PrimaryKeyName = value; }
        }
        public string PrimaryKeyValue
        {
            get { return _PrimaryKeyValue; }
            set { this._PrimaryKeyValue = value; }
        }
        public ArrayList UpdateFieldName
        {
            get { return _UpdateFieldName; }
            set { this._UpdateFieldName = value; }
        }
        #endregion
        #region Table Properties

        private Int64 _DCHDR_ID;
        private Int64 _Fk_PIHDR_ID;
        private Int64 _Fk_Company_ID;
        private Int64 _Fk_Branch_ID;
        private Int64 _Fk_Year_ID;
        private Int32 _Fk_Currency_ID;
        private String _Rec_Created_In;
        private Int64 _Rec_CreatedBy_ID;
        private Int64 _Rec_CreatedFor_ID;
        private String _DC_CreationType;
        private String _DC_Type;
        private String _DC_Category;
        private String _DC_Taxtype;
        private String _DC_No;
        private String _DC_DT;
        private Int64 _Fk_CustomerID;
        private Int64 _DC_CreditDays;
        private String _DC_DueDT;
        private Int64 _DC_State_ID;
        private String _DC_PONo;
        private String _DC_PO_DT;
        private String _DC_BillTo_CompanyName;
        private String _DC_BillTo_ContactPersone;
        private String _DC_BillTo_CP_MobileNo;
        private String _DC_BillTo_Add1;
        private String _DC_BillTo_Add2;
        private String _DC_BillTo_Add3;
        private String _DC_BillTo_Pincode;
        private String _DC_BillTo_Area;
        private String _DC_BillTo_City;
        private Int64 _DC_BillTo_State_ID;
        private String _DC_BillTo_Country;
        private String _DC_BillTo_GSTNo;
        private String _DC_BillTo_PANNO;
        private String _DC_ShippTo_CompanyName;
        private String _DC_ShippTo_ContactPersone;
        private String _DC_ShippTo_CP_MobileNo;
        private String _DC_ShippTo_Add1;
        private String _DC_ShippTo_Add2;
        private String _DC_ShippTo_Add3;
        private String _DC_ShippTo_Pincode;
        private String _DC_ShippTo_Area;
        private String _DC_ShippTo_City;
        private Int64 _DC_ShippTo_State_ID;
        private String _DC_ShippTo_Country;
        private String _DC_ShippTo_GSTNo;
        private String _DC_ShippTo_PANNO;
        private String _DC_ShippedFrom_CompanyName;
        private String _DC_ShippedFrom_ContactPersone;
        private String _DC_ShippedFrom_CP_MobileNo;
        private String _DC_ShippedFrom_Add1;
        private String _DC_ShippedFrom_Add2;
        private String _DC_ShippedFrom_Add3;
        private String _DC_ShippedFrom_Pincode;
        private String _DC_ShippedFrom_Area;
        private String _DC_ShippedFrom_City;
        private Int64 _DC_ShippedFrom_State_ID;
        private String _DC_ShippedFrom_Country;
        private String _DC_ShippedFrom_GSTNo;
        private String _DC_ShippedFrom_PANNO;
        private String _DC_PaymentTerms;
        private String _DC_DelvieryPeriod;
        private String _DC_DeliveryCharges;
        private String _DC_ExciseDuty;
        private String _DC_CompletionPeriod;
        private String _DC_ModeOfDispatch;
        private String _DC_TranspoterName;
        private String _DC_VehicleNumber;
        private String _DC_PlaceOfDelivery;
        private String _DC_FreigthCharge_Txt;
        private String _DC_Insurance_Txt;
        private String _DC_Remark;
        private Int16 _DC_L1AuthorizeID;
        private String _DC_L1AuthorizeBy;
        private String _DC_L1AuthorizeDT;
        private Int16 _DC_L2AuthorizeID;
        private String _DC_L2AuthorizeBy;
        private String _DC_L2AuthorizeDT;
        private String _DC_AuthRemark;
        private Int16 _DC_DTL_CNT;
        private String _MDBSC_RowStatus;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;
        private Decimal _DC_HDR_BasicAmt;
        private Decimal _DC_HDR_DiscountRate;
        private Decimal _DC_HDR_DiscountAmt;
        private Decimal _DC_HDR_Net_Amt;
        private Decimal _DC_HDR_Freight_Charges;
        private Decimal _DC_HDR_Loading_N_Packing_Charges;
        private Decimal _DC_HDR_Insurance_Charges;
        private String _DC_HDR_Other_Charges_Txt;
        private Decimal _DC_HDR_Other_Charges_Amt;
        private Decimal _DC_HDR_Taxable_Amt;
        private Decimal _DC_HDR_CGST_Amt;
        private Decimal _DC_HDR_CGST_Taxable_Amt;
        private Decimal _DC_HDR_SGST_Amt;
        private Decimal _DC_HDR_SGST_Taxable_Amt;
        private Decimal _DC_HDR_IGST_Amt;
        private Decimal _DC_HDR_IGST_Taxable_Amt;
        private Decimal _DC_HDR_CESS_Amt;
        private Decimal _DC_HDR_CESS_Taxable_Amt;
        private Int16 _DC_HDR_OtherTax_ID;
        private Decimal _DC_HDR_OtherTax_Rate;
        private Decimal _DC_HDR_OtherTax_Amt;
        private Decimal _DC_HDR_Other_Taxable_Amt;
        private Decimal _DC_HDR_Total_Tax_Amt;
        private Decimal _DC_HDR_ItemGross_Total_Amt;
        private Decimal _DC_HDR_Gross_Amt;
        private Decimal _DC_HDR_Round_Off_Amt;
        private Decimal _DC_HDR_Total_Gross_Amt;
        private String _DC_HDR_Gross_AmtInWords;
        private Decimal _DC_HDR_CreditNote_AsOn_Amt;
        private Decimal _DC_HDR_DebitNote_AsOn_Amt;
        private Decimal _DC_HDR_TDS_Rate;
        private Decimal _DC_HDR_TDS_Amt;
        private Decimal _DC_HDR_Paid_AsOn_Amt;
        private Decimal _DC_HDR_Outstanding_AsOn_Amt;

        public Int64 DCHDR_ID
        {
            get
            {
                return this._DCHDR_ID;
            }
            set
            {
                this._DCHDR_ID = value;
                _UpdateFieldName.Add("DCHDR_ID");
            }
        }
        public Int64 Fk_PIHDR_ID
        {
            get
            {
                return this._Fk_PIHDR_ID;
            }
            set
            {
                this._Fk_PIHDR_ID = value;
                _UpdateFieldName.Add("Fk_PIHDR_ID");
            }
        }
        public Int64 Fk_Company_ID
        {
            get
            {
                return this._Fk_Company_ID;
            }
            set
            {
                this._Fk_Company_ID = value;
                _UpdateFieldName.Add("Fk_Company_ID");
            }
        }
        public Int64 Fk_Branch_ID
        {
            get
            {
                return this._Fk_Branch_ID;
            }
            set
            {
                this._Fk_Branch_ID = value;
                _UpdateFieldName.Add("Fk_Branch_ID");
            }
        }
        public Int64 Fk_Year_ID
        {
            get
            {
                return this._Fk_Year_ID;
            }
            set
            {
                this._Fk_Year_ID = value;
                _UpdateFieldName.Add("Fk_Year_ID");
            }
        }
        public Int32 Fk_Currency_ID
        {
            get
            {
                return this._Fk_Currency_ID;
            }
            set
            {
                this._Fk_Currency_ID = value;
                _UpdateFieldName.Add("Fk_Currency_ID");
            }
        }
        public String Rec_Created_In
        {
            get
            {
                return this._Rec_Created_In;
            }
            set
            {
                this._Rec_Created_In = value;
                _UpdateFieldName.Add("Rec_Created_In");
            }
        }
        public Int64 Rec_CreatedBy_ID
        {
            get
            {
                return this._Rec_CreatedBy_ID;
            }
            set
            {
                this._Rec_CreatedBy_ID = value;
                _UpdateFieldName.Add("Rec_CreatedBy_ID");
            }
        }
        public Int64 Rec_CreatedFor_ID
        {
            get
            {
                return this._Rec_CreatedFor_ID;
            }
            set
            {
                this._Rec_CreatedFor_ID = value;
                _UpdateFieldName.Add("Rec_CreatedFor_ID");
            }
        }
        public String DC_CreationType
        {
            get
            {
                return this._DC_CreationType;
            }
            set
            {
                this._DC_CreationType = value;
                _UpdateFieldName.Add("DC_CreationType");
            }
        }
        public String DC_Type
        {
            get
            {
                return this._DC_Type;
            }
            set
            {
                this._DC_Type = value;
                _UpdateFieldName.Add("DC_Type");
            }
        }
        public String DC_Category
        {
            get
            {
                return this._DC_Category;
            }
            set
            {
                this._DC_Category = value;
                _UpdateFieldName.Add("DC_Category");
            }
        }
        public String DC_Taxtype
        {
            get
            {
                return this._DC_Taxtype;
            }
            set
            {
                this._DC_Taxtype = value;
                _UpdateFieldName.Add("DC_Taxtype");
            }
        }
        public String DC_No
        {
            get
            {
                return this._DC_No;
            }
            set
            {
                this._DC_No = value;
                _UpdateFieldName.Add("DC_No");
            }
        }
        public String DC_DT
        {
            get
            {
                return this._DC_DT;
            }
            set
            {
                this._DC_DT = value;
                _UpdateFieldName.Add("DC_DT");
            }
        }
        public Int64 Fk_CustomerID
        {
            get
            {
                return this._Fk_CustomerID;
            }
            set
            {
                this._Fk_CustomerID = value;
                _UpdateFieldName.Add("Fk_CustomerID");
            }
        }
        public Int64 DC_CreditDays
        {
            get
            {
                return this._DC_CreditDays;
            }
            set
            {
                this._DC_CreditDays = value;
                _UpdateFieldName.Add("DC_CreditDays");
            }
        }
        public String DC_DueDT
        {
            get
            {
                return this._DC_DueDT;
            }
            set
            {
                this._DC_DueDT = value;
                _UpdateFieldName.Add("DC_DueDT");
            }
        }
        public Int64 DC_State_ID
        {
            get
            {
                return this._DC_State_ID;
            }
            set
            {
                this._DC_State_ID = value;
                _UpdateFieldName.Add("DC_State_ID");
            }
        }
        public String DC_PONo
        {
            get
            {
                return this._DC_PONo;
            }
            set
            {
                this._DC_PONo = value;
                _UpdateFieldName.Add("DC_PONo");
            }
        }
        public String DC_PO_DT
        {
            get
            {
                return this._DC_PO_DT;
            }
            set
            {
                this._DC_PO_DT = value;
                _UpdateFieldName.Add("DC_PO_DT");
            }
        }
        public String DC_BillTo_CompanyName
        {
            get
            {
                return this._DC_BillTo_CompanyName;
            }
            set
            {
                this._DC_BillTo_CompanyName = value;
                _UpdateFieldName.Add("DC_BillTo_CompanyName");
            }
        }
        public String DC_BillTo_ContactPersone
        {
            get
            {
                return this._DC_BillTo_ContactPersone;
            }
            set
            {
                this._DC_BillTo_ContactPersone = value;
                _UpdateFieldName.Add("DC_BillTo_ContactPersone");
            }
        }
        public String DC_BillTo_CP_MobileNo
        {
            get
            {
                return this._DC_BillTo_CP_MobileNo;
            }
            set
            {
                this._DC_BillTo_CP_MobileNo = value;
                _UpdateFieldName.Add("DC_BillTo_CP_MobileNo");
            }
        }
        public String DC_BillTo_Add1
        {
            get
            {
                return this._DC_BillTo_Add1;
            }
            set
            {
                this._DC_BillTo_Add1 = value;
                _UpdateFieldName.Add("DC_BillTo_Add1");
            }
        }
        public String DC_BillTo_Add2
        {
            get
            {
                return this._DC_BillTo_Add2;
            }
            set
            {
                this._DC_BillTo_Add2 = value;
                _UpdateFieldName.Add("DC_BillTo_Add2");
            }
        }
        public String DC_BillTo_Add3
        {
            get
            {
                return this._DC_BillTo_Add3;
            }
            set
            {
                this._DC_BillTo_Add3 = value;
                _UpdateFieldName.Add("DC_BillTo_Add3");
            }
        }
        public String DC_BillTo_Pincode
        {
            get
            {
                return this._DC_BillTo_Pincode;
            }
            set
            {
                this._DC_BillTo_Pincode = value;
                _UpdateFieldName.Add("DC_BillTo_Pincode");
            }
        }
        public String DC_BillTo_Area
        {
            get
            {
                return this._DC_BillTo_Area;
            }
            set
            {
                this._DC_BillTo_Area = value;
                _UpdateFieldName.Add("DC_BillTo_Area");
            }
        }
        public String DC_BillTo_City
        {
            get
            {
                return this._DC_BillTo_City;
            }
            set
            {
                this._DC_BillTo_City = value;
                _UpdateFieldName.Add("DC_BillTo_City");
            }
        }
        public Int64 DC_BillTo_State_ID
        {
            get
            {
                return this._DC_BillTo_State_ID;
            }
            set
            {
                this._DC_BillTo_State_ID = value;
                _UpdateFieldName.Add("DC_BillTo_State_ID");
            }
        }
        public String DC_BillTo_Country
        {
            get
            {
                return this._DC_BillTo_Country;
            }
            set
            {
                this._DC_BillTo_Country = value;
                _UpdateFieldName.Add("DC_BillTo_Country");
            }
        }
        public String DC_BillTo_GSTNo
        {
            get
            {
                return this._DC_BillTo_GSTNo;
            }
            set
            {
                this._DC_BillTo_GSTNo = value;
                _UpdateFieldName.Add("DC_BillTo_GSTNo");
            }
        }
        public String DC_BillTo_PANNO
        {
            get
            {
                return this._DC_BillTo_PANNO;
            }
            set
            {
                this._DC_BillTo_PANNO = value;
                _UpdateFieldName.Add("DC_BillTo_PANNO");
            }
        }
        public String DC_ShippTo_CompanyName
        {
            get
            {
                return this._DC_ShippTo_CompanyName;
            }
            set
            {
                this._DC_ShippTo_CompanyName = value;
                _UpdateFieldName.Add("DC_ShippTo_CompanyName");
            }
        }
        public String DC_ShippTo_ContactPersone
        {
            get
            {
                return this._DC_ShippTo_ContactPersone;
            }
            set
            {
                this._DC_ShippTo_ContactPersone = value;
                _UpdateFieldName.Add("DC_ShippTo_ContactPersone");
            }
        }
        public String DC_ShippTo_CP_MobileNo
        {
            get
            {
                return this._DC_ShippTo_CP_MobileNo;
            }
            set
            {
                this._DC_ShippTo_CP_MobileNo = value;
                _UpdateFieldName.Add("DC_ShippTo_CP_MobileNo");
            }
        }
        public String DC_ShippTo_Add1
        {
            get
            {
                return this._DC_ShippTo_Add1;
            }
            set
            {
                this._DC_ShippTo_Add1 = value;
                _UpdateFieldName.Add("DC_ShippTo_Add1");
            }
        }
        public String DC_ShippTo_Add2
        {
            get
            {
                return this._DC_ShippTo_Add2;
            }
            set
            {
                this._DC_ShippTo_Add2 = value;
                _UpdateFieldName.Add("DC_ShippTo_Add2");
            }
        }
        public String DC_ShippTo_Add3
        {
            get
            {
                return this._DC_ShippTo_Add3;
            }
            set
            {
                this._DC_ShippTo_Add3 = value;
                _UpdateFieldName.Add("DC_ShippTo_Add3");
            }
        }
        public String DC_ShippTo_Pincode
        {
            get
            {
                return this._DC_ShippTo_Pincode;
            }
            set
            {
                this._DC_ShippTo_Pincode = value;
                _UpdateFieldName.Add("DC_ShippTo_Pincode");
            }
        }
        public String DC_ShippTo_Area
        {
            get
            {
                return this._DC_ShippTo_Area;
            }
            set
            {
                this._DC_ShippTo_Area = value;
                _UpdateFieldName.Add("DC_ShippTo_Area");
            }
        }
        public String DC_ShippTo_City
        {
            get
            {
                return this._DC_ShippTo_City;
            }
            set
            {
                this._DC_ShippTo_City = value;
                _UpdateFieldName.Add("DC_ShippTo_City");
            }
        }
        public Int64 DC_ShippTo_State_ID
        {
            get
            {
                return this._DC_ShippTo_State_ID;
            }
            set
            {
                this._DC_ShippTo_State_ID = value;
                _UpdateFieldName.Add("DC_ShippTo_State_ID");
            }
        }
        public String DC_ShippTo_Country
        {
            get
            {
                return this._DC_ShippTo_Country;
            }
            set
            {
                this._DC_ShippTo_Country = value;
                _UpdateFieldName.Add("DC_ShippTo_Country");
            }
        }
        public String DC_ShippTo_GSTNo
        {
            get
            {
                return this._DC_ShippTo_GSTNo;
            }
            set
            {
                this._DC_ShippTo_GSTNo = value;
                _UpdateFieldName.Add("DC_ShippTo_GSTNo");
            }
        }
        public String DC_ShippTo_PANNO
        {
            get
            {
                return this._DC_ShippTo_PANNO;
            }
            set
            {
                this._DC_ShippTo_PANNO = value;
                _UpdateFieldName.Add("DC_ShippTo_PANNO");
            }
        }
        public String DC_ShippedFrom_CompanyName
        {
            get
            {
                return this._DC_ShippedFrom_CompanyName;
            }
            set
            {
                this._DC_ShippedFrom_CompanyName = value;
                _UpdateFieldName.Add("DC_ShippedFrom_CompanyName");
            }
        }
        public String DC_ShippedFrom_ContactPersone
        {
            get
            {
                return this._DC_ShippedFrom_ContactPersone;
            }
            set
            {
                this._DC_ShippedFrom_ContactPersone = value;
                _UpdateFieldName.Add("DC_ShippedFrom_ContactPersone");
            }
        }
        public String DC_ShippedFrom_CP_MobileNo
        {
            get
            {
                return this._DC_ShippedFrom_CP_MobileNo;
            }
            set
            {
                this._DC_ShippedFrom_CP_MobileNo = value;
                _UpdateFieldName.Add("DC_ShippedFrom_CP_MobileNo");
            }
        }
        public String DC_ShippedFrom_Add1
        {
            get
            {
                return this._DC_ShippedFrom_Add1;
            }
            set
            {
                this._DC_ShippedFrom_Add1 = value;
                _UpdateFieldName.Add("DC_ShippedFrom_Add1");
            }
        }
        public String DC_ShippedFrom_Add2
        {
            get
            {
                return this._DC_ShippedFrom_Add2;
            }
            set
            {
                this._DC_ShippedFrom_Add2 = value;
                _UpdateFieldName.Add("DC_ShippedFrom_Add2");
            }
        }
        public String DC_ShippedFrom_Add3
        {
            get
            {
                return this._DC_ShippedFrom_Add3;
            }
            set
            {
                this._DC_ShippedFrom_Add3 = value;
                _UpdateFieldName.Add("DC_ShippedFrom_Add3");
            }
        }
        public String DC_ShippedFrom_Pincode
        {
            get
            {
                return this._DC_ShippedFrom_Pincode;
            }
            set
            {
                this._DC_ShippedFrom_Pincode = value;
                _UpdateFieldName.Add("DC_ShippedFrom_Pincode");
            }
        }
        public String DC_ShippedFrom_Area
        {
            get
            {
                return this._DC_ShippedFrom_Area;
            }
            set
            {
                this._DC_ShippedFrom_Area = value;
                _UpdateFieldName.Add("DC_ShippedFrom_Area");
            }
        }
        public String DC_ShippedFrom_City
        {
            get
            {
                return this._DC_ShippedFrom_City;
            }
            set
            {
                this._DC_ShippedFrom_City = value;
                _UpdateFieldName.Add("DC_ShippedFrom_City");
            }
        }
        public Int64 DC_ShippedFrom_State_ID
        {
            get
            {
                return this._DC_ShippedFrom_State_ID;
            }
            set
            {
                this._DC_ShippedFrom_State_ID = value;
                _UpdateFieldName.Add("DC_ShippedFrom_State_ID");
            }
        }
        public String DC_ShippedFrom_Country
        {
            get
            {
                return this._DC_ShippedFrom_Country;
            }
            set
            {
                this._DC_ShippedFrom_Country = value;
                _UpdateFieldName.Add("DC_ShippedFrom_Country");
            }
        }
        public String DC_ShippedFrom_GSTNo
        {
            get
            {
                return this._DC_ShippedFrom_GSTNo;
            }
            set
            {
                this._DC_ShippedFrom_GSTNo = value;
                _UpdateFieldName.Add("DC_ShippedFrom_GSTNo");
            }
        }
        public String DC_ShippedFrom_PANNO
        {
            get
            {
                return this._DC_ShippedFrom_PANNO;
            }
            set
            {
                this._DC_ShippedFrom_PANNO = value;
                _UpdateFieldName.Add("DC_ShippedFrom_PANNO");
            }
        }
        public String DC_PaymentTerms
        {
            get
            {
                return this._DC_PaymentTerms;
            }
            set
            {
                this._DC_PaymentTerms = value;
                _UpdateFieldName.Add("DC_PaymentTerms");
            }
        }
        public String DC_DelvieryPeriod
        {
            get
            {
                return this._DC_DelvieryPeriod;
            }
            set
            {
                this._DC_DelvieryPeriod = value;
                _UpdateFieldName.Add("DC_DelvieryPeriod");
            }
        }
        public String DC_DeliveryCharges
        {
            get
            {
                return this._DC_DeliveryCharges;
            }
            set
            {
                this._DC_DeliveryCharges = value;
                _UpdateFieldName.Add("DC_DeliveryCharges");
            }
        }
        public String DC_ExciseDuty
        {
            get
            {
                return this._DC_ExciseDuty;
            }
            set
            {
                this._DC_ExciseDuty = value;
                _UpdateFieldName.Add("DC_ExciseDuty");
            }
        }
        public String DC_CompletionPeriod
        {
            get
            {
                return this._DC_CompletionPeriod;
            }
            set
            {
                this._DC_CompletionPeriod = value;
                _UpdateFieldName.Add("DC_CompletionPeriod");
            }
        }
        public String DC_ModeOfDispatch
        {
            get
            {
                return this._DC_ModeOfDispatch;
            }
            set
            {
                this._DC_ModeOfDispatch = value;
                _UpdateFieldName.Add("DC_ModeOfDispatch");
            }
        }
        public String DC_TranspoterName
        {
            get
            {
                return this._DC_TranspoterName;
            }
            set
            {
                this._DC_TranspoterName = value;
                _UpdateFieldName.Add("DC_TranspoterName");
            }
        }
        public String DC_VehicleNumber
        {
            get
            {
                return this._DC_VehicleNumber;
            }
            set
            {
                this._DC_VehicleNumber = value;
                _UpdateFieldName.Add("DC_VehicleNumber");
            }
        }
        public String DC_PlaceOfDelivery
        {
            get
            {
                return this._DC_PlaceOfDelivery;
            }
            set
            {
                this._DC_PlaceOfDelivery = value;
                _UpdateFieldName.Add("DC_PlaceOfDelivery");
            }
        }
        public String DC_FreigthCharge_Txt
        {
            get
            {
                return this._DC_FreigthCharge_Txt;
            }
            set
            {
                this._DC_FreigthCharge_Txt = value;
                _UpdateFieldName.Add("DC_FreigthCharge_Txt");
            }
        }
        public String DC_Insurance_Txt
        {
            get
            {
                return this._DC_Insurance_Txt;
            }
            set
            {
                this._DC_Insurance_Txt = value;
                _UpdateFieldName.Add("DC_Insurance_Txt");
            }
        }
        public String DC_Remark
        {
            get
            {
                return this._DC_Remark;
            }
            set
            {
                this._DC_Remark = value;
                _UpdateFieldName.Add("DC_Remark");
            }
        }
        public Int16 DC_L1AuthorizeID
        {
            get
            {
                return this._DC_L1AuthorizeID;
            }
            set
            {
                this._DC_L1AuthorizeID = value;
                _UpdateFieldName.Add("DC_L1AuthorizeID");
            }
        }
        public String DC_L1AuthorizeBy
        {
            get
            {
                return this._DC_L1AuthorizeBy;
            }
            set
            {
                this._DC_L1AuthorizeBy = value;
                _UpdateFieldName.Add("DC_L1AuthorizeBy");
            }
        }
        public String DC_L1AuthorizeDT
        {
            get
            {
                return this._DC_L1AuthorizeDT;
            }
            set
            {
                this._DC_L1AuthorizeDT = value;
                _UpdateFieldName.Add("DC_L1AuthorizeDT");
            }
        }
        public Int16 DC_L2AuthorizeID
        {
            get
            {
                return this._DC_L2AuthorizeID;
            }
            set
            {
                this._DC_L2AuthorizeID = value;
                _UpdateFieldName.Add("DC_L2AuthorizeID");
            }
        }
        public String DC_L2AuthorizeBy
        {
            get
            {
                return this._DC_L2AuthorizeBy;
            }
            set
            {
                this._DC_L2AuthorizeBy = value;
                _UpdateFieldName.Add("DC_L2AuthorizeBy");
            }
        }
        public String DC_L2AuthorizeDT
        {
            get
            {
                return this._DC_L2AuthorizeDT;
            }
            set
            {
                this._DC_L2AuthorizeDT = value;
                _UpdateFieldName.Add("DC_L2AuthorizeDT");
            }
        }
        public String DC_AuthRemark
        {
            get
            {
                return this._DC_AuthRemark;
            }
            set
            {
                this._DC_AuthRemark = value;
                _UpdateFieldName.Add("DC_AuthRemark");
            }
        }
        public Int16 DC_DTL_CNT
        {
            get
            {
                return this._DC_DTL_CNT;
            }
            set
            {
                this._DC_DTL_CNT = value;
                _UpdateFieldName.Add("DC_DTL_CNT");
            }
        }
        public String MDBSC_RowStatus
        {
            get
            {
                return this._MDBSC_RowStatus;
            }
            set
            {
                this._MDBSC_RowStatus = value;
                _UpdateFieldName.Add("MDBSC_RowStatus");
            }
        }
        public Int16 MDBSC_RowCreatedByUser_ID
        {
            get
            {
                return this._MDBSC_RowCreatedByUser_ID;
            }
            set
            {
                this._MDBSC_RowCreatedByUser_ID = value;
                _UpdateFieldName.Add("MDBSC_RowCreatedByUser_ID");
            }
        }
        public String MDBSC_RowCreatedByUserName
        {
            get
            {
                return this._MDBSC_RowCreatedByUserName;
            }
            set
            {
                this._MDBSC_RowCreatedByUserName = value;
                _UpdateFieldName.Add("MDBSC_RowCreatedByUserName");
            }
        }
        public String MDBSC_RowCreatedOn_DT
        {
            get
            {
                return this._MDBSC_RowCreatedOn_DT;
            }
            set
            {
                this._MDBSC_RowCreatedOn_DT = value;
                _UpdateFieldName.Add("MDBSC_RowCreatedOn_DT");
            }
        }
        public Int16 MDBSC_RowLupdnByUser_ID
        {
            get
            {
                return this._MDBSC_RowLupdnByUser_ID;
            }
            set
            {
                this._MDBSC_RowLupdnByUser_ID = value;
                _UpdateFieldName.Add("MDBSC_RowLupdnByUser_ID");
            }
        }
        public String MDBSC_RowLupdnUserName
        {
            get
            {
                return this._MDBSC_RowLupdnUserName;
            }
            set
            {
                this._MDBSC_RowLupdnUserName = value;
                _UpdateFieldName.Add("MDBSC_RowLupdnUserName");
            }
        }
        public String MDBSC_RowLupdnOn_DT
        {
            get
            {
                return this._MDBSC_RowLupdnOn_DT;
            }
            set
            {
                this._MDBSC_RowLupdnOn_DT = value;
                _UpdateFieldName.Add("MDBSC_RowLupdnOn_DT");
            }
        }
        public Decimal DC_HDR_BasicAmt
        {
            get
            {
                return this._DC_HDR_BasicAmt;
            }
            set
            {
                this._DC_HDR_BasicAmt = value;
                _UpdateFieldName.Add("DC_HDR_BasicAmt");
            }
        }
        public Decimal DC_HDR_DiscountRate
        {
            get
            {
                return this._DC_HDR_DiscountRate;
            }
            set
            {
                this._DC_HDR_DiscountRate = value;
                _UpdateFieldName.Add("DC_HDR_DiscountRate");
            }
        }
        public Decimal DC_HDR_DiscountAmt
        {
            get
            {
                return this._DC_HDR_DiscountAmt;
            }
            set
            {
                this._DC_HDR_DiscountAmt = value;
                _UpdateFieldName.Add("DC_HDR_DiscountAmt");
            }
        }
        public Decimal DC_HDR_Net_Amt
        {
            get
            {
                return this._DC_HDR_Net_Amt;
            }
            set
            {
                this._DC_HDR_Net_Amt = value;
                _UpdateFieldName.Add("DC_HDR_Net_Amt");
            }
        }
        public Decimal DC_HDR_Freight_Charges
        {
            get
            {
                return this._DC_HDR_Freight_Charges;
            }
            set
            {
                this._DC_HDR_Freight_Charges = value;
                _UpdateFieldName.Add("DC_HDR_Freight_Charges");
            }
        }
        public Decimal DC_HDR_Loading_N_Packing_Charges
        {
            get
            {
                return this._DC_HDR_Loading_N_Packing_Charges;
            }
            set
            {
                this._DC_HDR_Loading_N_Packing_Charges = value;
                _UpdateFieldName.Add("DC_HDR_Loading_N_Packing_Charges");
            }
        }
        public Decimal DC_HDR_Insurance_Charges
        {
            get
            {
                return this._DC_HDR_Insurance_Charges;
            }
            set
            {
                this._DC_HDR_Insurance_Charges = value;
                _UpdateFieldName.Add("DC_HDR_Insurance_Charges");
            }
        }
        public String DC_HDR_Other_Charges_Txt
        {
            get
            {
                return this._DC_HDR_Other_Charges_Txt;
            }
            set
            {
                this._DC_HDR_Other_Charges_Txt = value;
                _UpdateFieldName.Add("DC_HDR_Other_Charges_Txt");
            }
        }
        public Decimal DC_HDR_Other_Charges_Amt
        {
            get
            {
                return this._DC_HDR_Other_Charges_Amt;
            }
            set
            {
                this._DC_HDR_Other_Charges_Amt = value;
                _UpdateFieldName.Add("DC_HDR_Other_Charges_Amt");
            }
        }
        public Decimal DC_HDR_Taxable_Amt
        {
            get
            {
                return this._DC_HDR_Taxable_Amt;
            }
            set
            {
                this._DC_HDR_Taxable_Amt = value;
                _UpdateFieldName.Add("DC_HDR_Taxable_Amt");
            }
        }
        public Decimal DC_HDR_CGST_Amt
        {
            get
            {
                return this._DC_HDR_CGST_Amt;
            }
            set
            {
                this._DC_HDR_CGST_Amt = value;
                _UpdateFieldName.Add("DC_HDR_CGST_Amt");
            }
        }
        public Decimal DC_HDR_CGST_Taxable_Amt
        {
            get
            {
                return this._DC_HDR_CGST_Taxable_Amt;
            }
            set
            {
                this._DC_HDR_CGST_Taxable_Amt = value;
                _UpdateFieldName.Add("DC_HDR_CGST_Taxable_Amt");
            }
        }
        public Decimal DC_HDR_SGST_Amt
        {
            get
            {
                return this._DC_HDR_SGST_Amt;
            }
            set
            {
                this._DC_HDR_SGST_Amt = value;
                _UpdateFieldName.Add("DC_HDR_SGST_Amt");
            }
        }
        public Decimal DC_HDR_SGST_Taxable_Amt
        {
            get
            {
                return this._DC_HDR_SGST_Taxable_Amt;
            }
            set
            {
                this._DC_HDR_SGST_Taxable_Amt = value;
                _UpdateFieldName.Add("DC_HDR_SGST_Taxable_Amt");
            }
        }
        public Decimal DC_HDR_IGST_Amt
        {
            get
            {
                return this._DC_HDR_IGST_Amt;
            }
            set
            {
                this._DC_HDR_IGST_Amt = value;
                _UpdateFieldName.Add("DC_HDR_IGST_Amt");
            }
        }
        public Decimal DC_HDR_IGST_Taxable_Amt
        {
            get
            {
                return this._DC_HDR_IGST_Taxable_Amt;
            }
            set
            {
                this._DC_HDR_IGST_Taxable_Amt = value;
                _UpdateFieldName.Add("DC_HDR_IGST_Taxable_Amt");
            }
        }
        public Decimal DC_HDR_CESS_Amt
        {
            get
            {
                return this._DC_HDR_CESS_Amt;
            }
            set
            {
                this._DC_HDR_CESS_Amt = value;
                _UpdateFieldName.Add("DC_HDR_CESS_Amt");
            }
        }
        public Decimal DC_HDR_CESS_Taxable_Amt
        {
            get
            {
                return this._DC_HDR_CESS_Taxable_Amt;
            }
            set
            {
                this._DC_HDR_CESS_Taxable_Amt = value;
                _UpdateFieldName.Add("DC_HDR_CESS_Taxable_Amt");
            }
        }
        public Int16 DC_HDR_OtherTax_ID
        {
            get
            {
                return this._DC_HDR_OtherTax_ID;
            }
            set
            {
                this._DC_HDR_OtherTax_ID = value;
                _UpdateFieldName.Add("DC_HDR_OtherTax_ID");
            }
        }
        public Decimal DC_HDR_OtherTax_Rate
        {
            get
            {
                return this._DC_HDR_OtherTax_Rate;
            }
            set
            {
                this._DC_HDR_OtherTax_Rate = value;
                _UpdateFieldName.Add("DC_HDR_OtherTax_Rate");
            }
        }
        public Decimal DC_HDR_OtherTax_Amt
        {
            get
            {
                return this._DC_HDR_OtherTax_Amt;
            }
            set
            {
                this._DC_HDR_OtherTax_Amt = value;
                _UpdateFieldName.Add("DC_HDR_OtherTax_Amt");
            }
        }
        public Decimal DC_HDR_Other_Taxable_Amt
        {
            get
            {
                return this._DC_HDR_Other_Taxable_Amt;
            }
            set
            {
                this._DC_HDR_Other_Taxable_Amt = value;
                _UpdateFieldName.Add("DC_HDR_Other_Taxable_Amt");
            }
        }
        public Decimal DC_HDR_Total_Tax_Amt
        {
            get
            {
                return this._DC_HDR_Total_Tax_Amt;
            }
            set
            {
                this._DC_HDR_Total_Tax_Amt = value;
                _UpdateFieldName.Add("DC_HDR_Total_Tax_Amt");
            }
        }
        public Decimal DC_HDR_ItemGross_Total_Amt
        {
            get
            {
                return this._DC_HDR_ItemGross_Total_Amt;
            }
            set
            {
                this._DC_HDR_ItemGross_Total_Amt = value;
                _UpdateFieldName.Add("DC_HDR_ItemGross_Total_Amt");
            }
        }
        public Decimal DC_HDR_Gross_Amt
        {
            get
            {
                return this._DC_HDR_Gross_Amt;
            }
            set
            {
                this._DC_HDR_Gross_Amt = value;
                _UpdateFieldName.Add("DC_HDR_Gross_Amt");
            }
        }
        public Decimal DC_HDR_Round_Off_Amt
        {
            get
            {
                return this._DC_HDR_Round_Off_Amt;
            }
            set
            {
                this._DC_HDR_Round_Off_Amt = value;
                _UpdateFieldName.Add("DC_HDR_Round_Off_Amt");
            }
        }
        public Decimal DC_HDR_Total_Gross_Amt
        {
            get
            {
                return this._DC_HDR_Total_Gross_Amt;
            }
            set
            {
                this._DC_HDR_Total_Gross_Amt = value;
                _UpdateFieldName.Add("DC_HDR_Total_Gross_Amt");
            }
        }
        public String DC_HDR_Gross_AmtInWords
        {
            get
            {
                return this._DC_HDR_Gross_AmtInWords;
            }
            set
            {
                this._DC_HDR_Gross_AmtInWords = value;
                _UpdateFieldName.Add("DC_HDR_Gross_AmtInWords");
            }
        }
        public Decimal DC_HDR_CreditNote_AsOn_Amt
        {
            get
            {
                return this._DC_HDR_CreditNote_AsOn_Amt;
            }
            set
            {
                this._DC_HDR_CreditNote_AsOn_Amt = value;
                _UpdateFieldName.Add("DC_HDR_CreditNote_AsOn_Amt");
            }
        }
        public Decimal DC_HDR_DebitNote_AsOn_Amt
        {
            get
            {
                return this._DC_HDR_DebitNote_AsOn_Amt;
            }
            set
            {
                this._DC_HDR_DebitNote_AsOn_Amt = value;
                _UpdateFieldName.Add("DC_HDR_DebitNote_AsOn_Amt");
            }
        }
        public Decimal DC_HDR_TDS_Rate
        {
            get
            {
                return this._DC_HDR_TDS_Rate;
            }
            set
            {
                this._DC_HDR_TDS_Rate = value;
                _UpdateFieldName.Add("DC_HDR_TDS_Rate");
            }
        }
        public Decimal DC_HDR_TDS_Amt
        {
            get
            {
                return this._DC_HDR_TDS_Amt;
            }
            set
            {
                this._DC_HDR_TDS_Amt = value;
                _UpdateFieldName.Add("DC_HDR_TDS_Amt");
            }
        }
        public Decimal DC_HDR_Paid_AsOn_Amt
        {
            get
            {
                return this._DC_HDR_Paid_AsOn_Amt;
            }
            set
            {
                this._DC_HDR_Paid_AsOn_Amt = value;
                _UpdateFieldName.Add("DC_HDR_Paid_AsOn_Amt");
            }
        }
        public Decimal DC_HDR_Outstanding_AsOn_Amt
        {
            get
            {
                return this._DC_HDR_Outstanding_AsOn_Amt;
            }
            set
            {
                this._DC_HDR_Outstanding_AsOn_Amt = value;
                _UpdateFieldName.Add("DC_HDR_Outstanding_AsOn_Amt");
            }
        }

        #endregion
        #region Genric Methods
        public string Insert_Update(M_AT_Sales_DC_AHDRBO sObject)
        {
            try
            {
                string strPkValue = "";
                strPkValue = ObjDataAcess.InsertUpdate(sObject);
                return ObjDataAcess.ReturnMessage + "|" + strPkValue;
            }
            catch
            {
                return "Failed To Save Data|0";
            }
        }


        #endregion
    }
}

// ObjAT_DCHDR.DCHDR_ID=ObjAT_DCHDR.DCHDR_ID;
// ObjAT_DCHDR.Fk_PIHDR_ID=ObjAT_DCHDR.Fk_PIHDR_ID;
// ObjAT_DCHDR.Fk_Company_ID=ObjAT_DCHDR.Fk_Company_ID;
// ObjAT_DCHDR.Fk_Branch_ID=ObjAT_DCHDR.Fk_Branch_ID;
// ObjAT_DCHDR.Fk_Year_ID=ObjAT_DCHDR.Fk_Year_ID;
// ObjAT_DCHDR.Fk_Currency_ID=ObjAT_DCHDR.Fk_Currency_ID;
// ObjAT_DCHDR.Rec_Created_In=ObjAT_DCHDR.Rec_Created_In;
// ObjAT_DCHDR.Rec_CreatedBy_ID=ObjAT_DCHDR.Rec_CreatedBy_ID;
// ObjAT_DCHDR.Rec_CreatedFor_ID=ObjAT_DCHDR.Rec_CreatedFor_ID;
// ObjAT_DCHDR.DC_CreationType=ObjAT_DCHDR.DC_CreationType;
// ObjAT_DCHDR.DC_Type=ObjAT_DCHDR.DC_Type;
// ObjAT_DCHDR.DC_Category=ObjAT_DCHDR.DC_Category;
// ObjAT_DCHDR.DC_Taxtype=ObjAT_DCHDR.DC_Taxtype;
// ObjAT_DCHDR.DC_No=ObjAT_DCHDR.DC_No;
// ObjAT_DCHDR.DC_DT=ObjAT_DCHDR.DC_DT;
// ObjAT_DCHDR.Fk_CustomerID=ObjAT_DCHDR.Fk_CustomerID;
// ObjAT_DCHDR.DC_CreditDays=ObjAT_DCHDR.DC_CreditDays;
// ObjAT_DCHDR.DC_DueDT=ObjAT_DCHDR.DC_DueDT;
// ObjAT_DCHDR.DC_State_ID=ObjAT_DCHDR.DC_State_ID;
// ObjAT_DCHDR.DC_PONo=ObjAT_DCHDR.DC_PONo;
// ObjAT_DCHDR.DC_PO_DT=ObjAT_DCHDR.DC_PO_DT;
// ObjAT_DCHDR.DC_BillTo_CompanyName=ObjAT_DCHDR.DC_BillTo_CompanyName;
// ObjAT_DCHDR.DC_BillTo_ContactPersone=ObjAT_DCHDR.DC_BillTo_ContactPersone;
// ObjAT_DCHDR.DC_BillTo_CP_MobileNo=ObjAT_DCHDR.DC_BillTo_CP_MobileNo;
// ObjAT_DCHDR.DC_BillTo_Add1=ObjAT_DCHDR.DC_BillTo_Add1;
// ObjAT_DCHDR.DC_BillTo_Add2=ObjAT_DCHDR.DC_BillTo_Add2;
// ObjAT_DCHDR.DC_BillTo_Add3=ObjAT_DCHDR.DC_BillTo_Add3;
// ObjAT_DCHDR.DC_BillTo_Pincode=ObjAT_DCHDR.DC_BillTo_Pincode;
// ObjAT_DCHDR.DC_BillTo_Area=ObjAT_DCHDR.DC_BillTo_Area;
// ObjAT_DCHDR.DC_BillTo_City=ObjAT_DCHDR.DC_BillTo_City;
// ObjAT_DCHDR.DC_BillTo_State_ID=ObjAT_DCHDR.DC_BillTo_State_ID;
// ObjAT_DCHDR.DC_BillTo_Country=ObjAT_DCHDR.DC_BillTo_Country;
// ObjAT_DCHDR.DC_BillTo_GSTNo=ObjAT_DCHDR.DC_BillTo_GSTNo;
// ObjAT_DCHDR.DC_BillTo_PANNO=ObjAT_DCHDR.DC_BillTo_PANNO;
// ObjAT_DCHDR.DC_ShippTo_CompanyName=ObjAT_DCHDR.DC_ShippTo_CompanyName;
// ObjAT_DCHDR.DC_ShippTo_ContactPersone=ObjAT_DCHDR.DC_ShippTo_ContactPersone;
// ObjAT_DCHDR.DC_ShippTo_CP_MobileNo=ObjAT_DCHDR.DC_ShippTo_CP_MobileNo;
// ObjAT_DCHDR.DC_ShippTo_Add1=ObjAT_DCHDR.DC_ShippTo_Add1;
// ObjAT_DCHDR.DC_ShippTo_Add2=ObjAT_DCHDR.DC_ShippTo_Add2;
// ObjAT_DCHDR.DC_ShippTo_Add3=ObjAT_DCHDR.DC_ShippTo_Add3;
// ObjAT_DCHDR.DC_ShippTo_Pincode=ObjAT_DCHDR.DC_ShippTo_Pincode;
// ObjAT_DCHDR.DC_ShippTo_Area=ObjAT_DCHDR.DC_ShippTo_Area;
// ObjAT_DCHDR.DC_ShippTo_City=ObjAT_DCHDR.DC_ShippTo_City;
// ObjAT_DCHDR.DC_ShippTo_State_ID=ObjAT_DCHDR.DC_ShippTo_State_ID;
// ObjAT_DCHDR.DC_ShippTo_Country=ObjAT_DCHDR.DC_ShippTo_Country;
// ObjAT_DCHDR.DC_ShippTo_GSTNo=ObjAT_DCHDR.DC_ShippTo_GSTNo;
// ObjAT_DCHDR.DC_ShippTo_PANNO=ObjAT_DCHDR.DC_ShippTo_PANNO;
// ObjAT_DCHDR.DC_ShippedFrom_CompanyName=ObjAT_DCHDR.DC_ShippedFrom_CompanyName;
// ObjAT_DCHDR.DC_ShippedFrom_ContactPersone=ObjAT_DCHDR.DC_ShippedFrom_ContactPersone;
// ObjAT_DCHDR.DC_ShippedFrom_CP_MobileNo=ObjAT_DCHDR.DC_ShippedFrom_CP_MobileNo;
// ObjAT_DCHDR.DC_ShippedFrom_Add1=ObjAT_DCHDR.DC_ShippedFrom_Add1;
// ObjAT_DCHDR.DC_ShippedFrom_Add2=ObjAT_DCHDR.DC_ShippedFrom_Add2;
// ObjAT_DCHDR.DC_ShippedFrom_Add3=ObjAT_DCHDR.DC_ShippedFrom_Add3;
// ObjAT_DCHDR.DC_ShippedFrom_Pincode=ObjAT_DCHDR.DC_ShippedFrom_Pincode;
// ObjAT_DCHDR.DC_ShippedFrom_Area=ObjAT_DCHDR.DC_ShippedFrom_Area;
// ObjAT_DCHDR.DC_ShippedFrom_City=ObjAT_DCHDR.DC_ShippedFrom_City;
// ObjAT_DCHDR.DC_ShippedFrom_State_ID=ObjAT_DCHDR.DC_ShippedFrom_State_ID;
// ObjAT_DCHDR.DC_ShippedFrom_Country=ObjAT_DCHDR.DC_ShippedFrom_Country;
// ObjAT_DCHDR.DC_ShippedFrom_GSTNo=ObjAT_DCHDR.DC_ShippedFrom_GSTNo;
// ObjAT_DCHDR.DC_ShippedFrom_PANNO=ObjAT_DCHDR.DC_ShippedFrom_PANNO;
// ObjAT_DCHDR.DC_PaymentTerms=ObjAT_DCHDR.DC_PaymentTerms;
// ObjAT_DCHDR.DC_DelvieryPeriod=ObjAT_DCHDR.DC_DelvieryPeriod;
// ObjAT_DCHDR.DC_DeliveryCharges=ObjAT_DCHDR.DC_DeliveryCharges;
// ObjAT_DCHDR.DC_ExciseDuty=ObjAT_DCHDR.DC_ExciseDuty;
// ObjAT_DCHDR.DC_CompletionPeriod=ObjAT_DCHDR.DC_CompletionPeriod;
// ObjAT_DCHDR.DC_ModeOfDispatch=ObjAT_DCHDR.DC_ModeOfDispatch;
// ObjAT_DCHDR.DC_TranspoterName=ObjAT_DCHDR.DC_TranspoterName;
// ObjAT_DCHDR.DC_VehicleNumber=ObjAT_DCHDR.DC_VehicleNumber;
// ObjAT_DCHDR.DC_PlaceOfDelivery=ObjAT_DCHDR.DC_PlaceOfDelivery;
// ObjAT_DCHDR.DC_FreigthCharge_Txt=ObjAT_DCHDR.DC_FreigthCharge_Txt;
// ObjAT_DCHDR.DC_Insurance_Txt=ObjAT_DCHDR.DC_Insurance_Txt;
// ObjAT_DCHDR.DC_Remark=ObjAT_DCHDR.DC_Remark;
// ObjAT_DCHDR.DC_L1AuthorizeID=ObjAT_DCHDR.DC_L1AuthorizeID;
// ObjAT_DCHDR.DC_L1AuthorizeBy=ObjAT_DCHDR.DC_L1AuthorizeBy;
// ObjAT_DCHDR.DC_L1AuthorizeDT=ObjAT_DCHDR.DC_L1AuthorizeDT;
// ObjAT_DCHDR.DC_L2AuthorizeID=ObjAT_DCHDR.DC_L2AuthorizeID;
// ObjAT_DCHDR.DC_L2AuthorizeBy=ObjAT_DCHDR.DC_L2AuthorizeBy;
// ObjAT_DCHDR.DC_L2AuthorizeDT=ObjAT_DCHDR.DC_L2AuthorizeDT;
// ObjAT_DCHDR.DC_AuthRemark=ObjAT_DCHDR.DC_AuthRemark;
// ObjAT_DCHDR.DC_DTL_CNT=ObjAT_DCHDR.DC_DTL_CNT;
// ObjAT_DCHDR.MDBSC_RowStatus=ObjAT_DCHDR.MDBSC_RowStatus;
// ObjAT_DCHDR.MDBSC_RowCreatedByUser_ID=ObjAT_DCHDR.MDBSC_RowCreatedByUser_ID;
// ObjAT_DCHDR.MDBSC_RowCreatedByUserName=ObjAT_DCHDR.MDBSC_RowCreatedByUserName;
// ObjAT_DCHDR.MDBSC_RowCreatedOn_DT=ObjAT_DCHDR.MDBSC_RowCreatedOn_DT;
// ObjAT_DCHDR.MDBSC_RowLupdnByUser_ID=ObjAT_DCHDR.MDBSC_RowLupdnByUser_ID;
// ObjAT_DCHDR.MDBSC_RowLupdnUserName=ObjAT_DCHDR.MDBSC_RowLupdnUserName;
// ObjAT_DCHDR.MDBSC_RowLupdnOn_DT=ObjAT_DCHDR.MDBSC_RowLupdnOn_DT;
// ObjAT_DCHDR.DC_HDR_BasicAmt=ObjAT_DCHDR.DC_HDR_BasicAmt;
// ObjAT_DCHDR.DC_HDR_DiscountRate=ObjAT_DCHDR.DC_HDR_DiscountRate;
// ObjAT_DCHDR.DC_HDR_DiscountAmt=ObjAT_DCHDR.DC_HDR_DiscountAmt;
// ObjAT_DCHDR.DC_HDR_Net_Amt=ObjAT_DCHDR.DC_HDR_Net_Amt;
// ObjAT_DCHDR.DC_HDR_Freight_Charges=ObjAT_DCHDR.DC_HDR_Freight_Charges;
// ObjAT_DCHDR.DC_HDR_Loading_N_Packing_Charges=ObjAT_DCHDR.DC_HDR_Loading_N_Packing_Charges;
// ObjAT_DCHDR.DC_HDR_Insurance_Charges=ObjAT_DCHDR.DC_HDR_Insurance_Charges;
// ObjAT_DCHDR.DC_HDR_Other_Charges_Txt=ObjAT_DCHDR.DC_HDR_Other_Charges_Txt;
// ObjAT_DCHDR.DC_HDR_Other_Charges_Amt=ObjAT_DCHDR.DC_HDR_Other_Charges_Amt;
// ObjAT_DCHDR.DC_HDR_Taxable_Amt=ObjAT_DCHDR.DC_HDR_Taxable_Amt;
// ObjAT_DCHDR.DC_HDR_CGST_Amt=ObjAT_DCHDR.DC_HDR_CGST_Amt;
// ObjAT_DCHDR.DC_HDR_CGST_Taxable_Amt=ObjAT_DCHDR.DC_HDR_CGST_Taxable_Amt;
// ObjAT_DCHDR.DC_HDR_SGST_Amt=ObjAT_DCHDR.DC_HDR_SGST_Amt;
// ObjAT_DCHDR.DC_HDR_SGST_Taxable_Amt=ObjAT_DCHDR.DC_HDR_SGST_Taxable_Amt;
// ObjAT_DCHDR.DC_HDR_IGST_Amt=ObjAT_DCHDR.DC_HDR_IGST_Amt;
// ObjAT_DCHDR.DC_HDR_IGST_Taxable_Amt=ObjAT_DCHDR.DC_HDR_IGST_Taxable_Amt;
// ObjAT_DCHDR.DC_HDR_CESS_Amt=ObjAT_DCHDR.DC_HDR_CESS_Amt;
// ObjAT_DCHDR.DC_HDR_CESS_Taxable_Amt=ObjAT_DCHDR.DC_HDR_CESS_Taxable_Amt;
// ObjAT_DCHDR.DC_HDR_OtherTax_ID=ObjAT_DCHDR.DC_HDR_OtherTax_ID;
// ObjAT_DCHDR.DC_HDR_OtherTax_Rate=ObjAT_DCHDR.DC_HDR_OtherTax_Rate;
// ObjAT_DCHDR.DC_HDR_OtherTax_Amt=ObjAT_DCHDR.DC_HDR_OtherTax_Amt;
// ObjAT_DCHDR.DC_HDR_Other_Taxable_Amt=ObjAT_DCHDR.DC_HDR_Other_Taxable_Amt;
// ObjAT_DCHDR.DC_HDR_Total_Tax_Amt=ObjAT_DCHDR.DC_HDR_Total_Tax_Amt;
// ObjAT_DCHDR.DC_HDR_ItemGross_Total_Amt=ObjAT_DCHDR.DC_HDR_ItemGross_Total_Amt;
// ObjAT_DCHDR.DC_HDR_Gross_Amt=ObjAT_DCHDR.DC_HDR_Gross_Amt;
// ObjAT_DCHDR.DC_HDR_Round_Off_Amt=ObjAT_DCHDR.DC_HDR_Round_Off_Amt;
// ObjAT_DCHDR.DC_HDR_Total_Gross_Amt=ObjAT_DCHDR.DC_HDR_Total_Gross_Amt;
// ObjAT_DCHDR.DC_HDR_Gross_AmtInWords=ObjAT_DCHDR.DC_HDR_Gross_AmtInWords;
// ObjAT_DCHDR.DC_HDR_CreditNote_AsOn_Amt=ObjAT_DCHDR.DC_HDR_CreditNote_AsOn_Amt;
// ObjAT_DCHDR.DC_HDR_DebitNote_AsOn_Amt=ObjAT_DCHDR.DC_HDR_DebitNote_AsOn_Amt;
// ObjAT_DCHDR.DC_HDR_TDS_Rate=ObjAT_DCHDR.DC_HDR_TDS_Rate;
// ObjAT_DCHDR.DC_HDR_TDS_Amt=ObjAT_DCHDR.DC_HDR_TDS_Amt;
// ObjAT_DCHDR.DC_HDR_Paid_AsOn_Amt=ObjAT_DCHDR.DC_HDR_Paid_AsOn_Amt;
// ObjAT_DCHDR.DC_HDR_Outstanding_AsOn_Amt=ObjAT_DCHDR.DC_HDR_Outstanding_AsOn_Amt;



// DCHDR_ID.Text = "";
// Fk_PIHDR_ID.Text = "";
// Fk_Company_ID.Text = "";
// Fk_Branch_ID.Text = "";
// Fk_Year_ID.Text = "";
// Fk_Currency_ID.Text = "";
// Rec_Created_In.Text = "";
// Rec_CreatedBy_ID.Text = "";
// Rec_CreatedFor_ID.Text = "";
// DC_CreationType.Text = "";
// DC_Type.Text = "";
// DC_Category.Text = "";
// DC_Taxtype.Text = "";
// DC_No.Text = "";
// DC_DT.Text = "";
// Fk_CustomerID.Text = "";
// DC_CreditDays.Text = "";
// DC_DueDT.Text = "";
// DC_State_ID.Text = "";
// DC_PONo.Text = "";
// DC_PO_DT.Text = "";
// DC_BillTo_CompanyName.Text = "";
// DC_BillTo_ContactPersone.Text = "";
// DC_BillTo_CP_MobileNo.Text = "";
// DC_BillTo_Add1.Text = "";
// DC_BillTo_Add2.Text = "";
// DC_BillTo_Add3.Text = "";
// DC_BillTo_Pincode.Text = "";
// DC_BillTo_Area.Text = "";
// DC_BillTo_City.Text = "";
// DC_BillTo_State_ID.Text = "";
// DC_BillTo_Country.Text = "";
// DC_BillTo_GSTNo.Text = "";
// DC_BillTo_PANNO.Text = "";
// DC_ShippTo_CompanyName.Text = "";
// DC_ShippTo_ContactPersone.Text = "";
// DC_ShippTo_CP_MobileNo.Text = "";
// DC_ShippTo_Add1.Text = "";
// DC_ShippTo_Add2.Text = "";
// DC_ShippTo_Add3.Text = "";
// DC_ShippTo_Pincode.Text = "";
// DC_ShippTo_Area.Text = "";
// DC_ShippTo_City.Text = "";
// DC_ShippTo_State_ID.Text = "";
// DC_ShippTo_Country.Text = "";
// DC_ShippTo_GSTNo.Text = "";
// DC_ShippTo_PANNO.Text = "";
// DC_ShippedFrom_CompanyName.Text = "";
// DC_ShippedFrom_ContactPersone.Text = "";
// DC_ShippedFrom_CP_MobileNo.Text = "";
// DC_ShippedFrom_Add1.Text = "";
// DC_ShippedFrom_Add2.Text = "";
// DC_ShippedFrom_Add3.Text = "";
// DC_ShippedFrom_Pincode.Text = "";
// DC_ShippedFrom_Area.Text = "";
// DC_ShippedFrom_City.Text = "";
// DC_ShippedFrom_State_ID.Text = "";
// DC_ShippedFrom_Country.Text = "";
// DC_ShippedFrom_GSTNo.Text = "";
// DC_ShippedFrom_PANNO.Text = "";
// DC_PaymentTerms.Text = "";
// DC_DelvieryPeriod.Text = "";
// DC_DeliveryCharges.Text = "";
// DC_ExciseDuty.Text = "";
// DC_CompletionPeriod.Text = "";
// DC_ModeOfDispatch.Text = "";
// DC_TranspoterName.Text = "";
// DC_VehicleNumber.Text = "";
// DC_PlaceOfDelivery.Text = "";
// DC_FreigthCharge_Txt.Text = "";
// DC_Insurance_Txt.Text = "";
// DC_Remark.Text = "";
// DC_L1AuthorizeID.Text = "";
// DC_L1AuthorizeBy.Text = "";
// DC_L1AuthorizeDT.Text = "";
// DC_L2AuthorizeID.Text = "";
// DC_L2AuthorizeBy.Text = "";
// DC_L2AuthorizeDT.Text = "";
// DC_AuthRemark.Text = "";
// DC_DTL_CNT.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";
// DC_HDR_BasicAmt.Text = "";
// DC_HDR_DiscountRate.Text = "";
// DC_HDR_DiscountAmt.Text = "";
// DC_HDR_Net_Amt.Text = "";
// DC_HDR_Freight_Charges.Text = "";
// DC_HDR_Loading_N_Packing_Charges.Text = "";
// DC_HDR_Insurance_Charges.Text = "";
// DC_HDR_Other_Charges_Txt.Text = "";
// DC_HDR_Other_Charges_Amt.Text = "";
// DC_HDR_Taxable_Amt.Text = "";
// DC_HDR_CGST_Amt.Text = "";
// DC_HDR_CGST_Taxable_Amt.Text = "";
// DC_HDR_SGST_Amt.Text = "";
// DC_HDR_SGST_Taxable_Amt.Text = "";
// DC_HDR_IGST_Amt.Text = "";
// DC_HDR_IGST_Taxable_Amt.Text = "";
// DC_HDR_CESS_Amt.Text = "";
// DC_HDR_CESS_Taxable_Amt.Text = "";
// DC_HDR_OtherTax_ID.Text = "";
// DC_HDR_OtherTax_Rate.Text = "";
// DC_HDR_OtherTax_Amt.Text = "";
// DC_HDR_Other_Taxable_Amt.Text = "";
// DC_HDR_Total_Tax_Amt.Text = "";
// DC_HDR_ItemGross_Total_Amt.Text = "";
// DC_HDR_Gross_Amt.Text = "";
// DC_HDR_Round_Off_Amt.Text = "";
// DC_HDR_Total_Gross_Amt.Text = "";
// DC_HDR_Gross_AmtInWords.Text = "";
// DC_HDR_CreditNote_AsOn_Amt.Text = "";
// DC_HDR_DebitNote_AsOn_Amt.Text = "";
// DC_HDR_TDS_Rate.Text = "";
// DC_HDR_TDS_Amt.Text = "";
// DC_HDR_Paid_AsOn_Amt.Text = "";
// DC_HDR_Outstanding_AsOn_Amt.Text = "";



// ObjAT_DCHDR.DCHDR_ID=DCHDR_ID.Text ;
// ObjAT_DCHDR.Fk_PIHDR_ID=Fk_PIHDR_ID.Text ;
// ObjAT_DCHDR.Fk_Company_ID=Fk_Company_ID.Text ;
// ObjAT_DCHDR.Fk_Branch_ID=Fk_Branch_ID.Text ;
// ObjAT_DCHDR.Fk_Year_ID=Fk_Year_ID.Text ;
// ObjAT_DCHDR.Fk_Currency_ID=Fk_Currency_ID.Text ;
// ObjAT_DCHDR.Rec_Created_In=Rec_Created_In.Text ;
// ObjAT_DCHDR.Rec_CreatedBy_ID=Rec_CreatedBy_ID.Text ;
// ObjAT_DCHDR.Rec_CreatedFor_ID=Rec_CreatedFor_ID.Text ;
// ObjAT_DCHDR.DC_CreationType=DC_CreationType.Text ;
// ObjAT_DCHDR.DC_Type=DC_Type.Text ;
// ObjAT_DCHDR.DC_Category=DC_Category.Text ;
// ObjAT_DCHDR.DC_Taxtype=DC_Taxtype.Text ;
// ObjAT_DCHDR.DC_No=DC_No.Text ;
// ObjAT_DCHDR.DC_DT=DC_DT.Text ;
// ObjAT_DCHDR.Fk_CustomerID=Fk_CustomerID.Text ;
// ObjAT_DCHDR.DC_CreditDays=DC_CreditDays.Text ;
// ObjAT_DCHDR.DC_DueDT=DC_DueDT.Text ;
// ObjAT_DCHDR.DC_State_ID=DC_State_ID.Text ;
// ObjAT_DCHDR.DC_PONo=DC_PONo.Text ;
// ObjAT_DCHDR.DC_PO_DT=DC_PO_DT.Text ;
// ObjAT_DCHDR.DC_BillTo_CompanyName=DC_BillTo_CompanyName.Text ;
// ObjAT_DCHDR.DC_BillTo_ContactPersone=DC_BillTo_ContactPersone.Text ;
// ObjAT_DCHDR.DC_BillTo_CP_MobileNo=DC_BillTo_CP_MobileNo.Text ;
// ObjAT_DCHDR.DC_BillTo_Add1=DC_BillTo_Add1.Text ;
// ObjAT_DCHDR.DC_BillTo_Add2=DC_BillTo_Add2.Text ;
// ObjAT_DCHDR.DC_BillTo_Add3=DC_BillTo_Add3.Text ;
// ObjAT_DCHDR.DC_BillTo_Pincode=DC_BillTo_Pincode.Text ;
// ObjAT_DCHDR.DC_BillTo_Area=DC_BillTo_Area.Text ;
// ObjAT_DCHDR.DC_BillTo_City=DC_BillTo_City.Text ;
// ObjAT_DCHDR.DC_BillTo_State_ID=DC_BillTo_State_ID.Text ;
// ObjAT_DCHDR.DC_BillTo_Country=DC_BillTo_Country.Text ;
// ObjAT_DCHDR.DC_BillTo_GSTNo=DC_BillTo_GSTNo.Text ;
// ObjAT_DCHDR.DC_BillTo_PANNO=DC_BillTo_PANNO.Text ;
// ObjAT_DCHDR.DC_ShippTo_CompanyName=DC_ShippTo_CompanyName.Text ;
// ObjAT_DCHDR.DC_ShippTo_ContactPersone=DC_ShippTo_ContactPersone.Text ;
// ObjAT_DCHDR.DC_ShippTo_CP_MobileNo=DC_ShippTo_CP_MobileNo.Text ;
// ObjAT_DCHDR.DC_ShippTo_Add1=DC_ShippTo_Add1.Text ;
// ObjAT_DCHDR.DC_ShippTo_Add2=DC_ShippTo_Add2.Text ;
// ObjAT_DCHDR.DC_ShippTo_Add3=DC_ShippTo_Add3.Text ;
// ObjAT_DCHDR.DC_ShippTo_Pincode=DC_ShippTo_Pincode.Text ;
// ObjAT_DCHDR.DC_ShippTo_Area=DC_ShippTo_Area.Text ;
// ObjAT_DCHDR.DC_ShippTo_City=DC_ShippTo_City.Text ;
// ObjAT_DCHDR.DC_ShippTo_State_ID=DC_ShippTo_State_ID.Text ;
// ObjAT_DCHDR.DC_ShippTo_Country=DC_ShippTo_Country.Text ;
// ObjAT_DCHDR.DC_ShippTo_GSTNo=DC_ShippTo_GSTNo.Text ;
// ObjAT_DCHDR.DC_ShippTo_PANNO=DC_ShippTo_PANNO.Text ;
// ObjAT_DCHDR.DC_ShippedFrom_CompanyName=DC_ShippedFrom_CompanyName.Text ;
// ObjAT_DCHDR.DC_ShippedFrom_ContactPersone=DC_ShippedFrom_ContactPersone.Text ;
// ObjAT_DCHDR.DC_ShippedFrom_CP_MobileNo=DC_ShippedFrom_CP_MobileNo.Text ;
// ObjAT_DCHDR.DC_ShippedFrom_Add1=DC_ShippedFrom_Add1.Text ;
// ObjAT_DCHDR.DC_ShippedFrom_Add2=DC_ShippedFrom_Add2.Text ;
// ObjAT_DCHDR.DC_ShippedFrom_Add3=DC_ShippedFrom_Add3.Text ;
// ObjAT_DCHDR.DC_ShippedFrom_Pincode=DC_ShippedFrom_Pincode.Text ;
// ObjAT_DCHDR.DC_ShippedFrom_Area=DC_ShippedFrom_Area.Text ;
// ObjAT_DCHDR.DC_ShippedFrom_City=DC_ShippedFrom_City.Text ;
// ObjAT_DCHDR.DC_ShippedFrom_State_ID=DC_ShippedFrom_State_ID.Text ;
// ObjAT_DCHDR.DC_ShippedFrom_Country=DC_ShippedFrom_Country.Text ;
// ObjAT_DCHDR.DC_ShippedFrom_GSTNo=DC_ShippedFrom_GSTNo.Text ;
// ObjAT_DCHDR.DC_ShippedFrom_PANNO=DC_ShippedFrom_PANNO.Text ;
// ObjAT_DCHDR.DC_PaymentTerms=DC_PaymentTerms.Text ;
// ObjAT_DCHDR.DC_DelvieryPeriod=DC_DelvieryPeriod.Text ;
// ObjAT_DCHDR.DC_DeliveryCharges=DC_DeliveryCharges.Text ;
// ObjAT_DCHDR.DC_ExciseDuty=DC_ExciseDuty.Text ;
// ObjAT_DCHDR.DC_CompletionPeriod=DC_CompletionPeriod.Text ;
// ObjAT_DCHDR.DC_ModeOfDispatch=DC_ModeOfDispatch.Text ;
// ObjAT_DCHDR.DC_TranspoterName=DC_TranspoterName.Text ;
// ObjAT_DCHDR.DC_VehicleNumber=DC_VehicleNumber.Text ;
// ObjAT_DCHDR.DC_PlaceOfDelivery=DC_PlaceOfDelivery.Text ;
// ObjAT_DCHDR.DC_FreigthCharge_Txt=DC_FreigthCharge_Txt.Text ;
// ObjAT_DCHDR.DC_Insurance_Txt=DC_Insurance_Txt.Text ;
// ObjAT_DCHDR.DC_Remark=DC_Remark.Text ;
// ObjAT_DCHDR.DC_L1AuthorizeID=DC_L1AuthorizeID.Text ;
// ObjAT_DCHDR.DC_L1AuthorizeBy=DC_L1AuthorizeBy.Text ;
// ObjAT_DCHDR.DC_L1AuthorizeDT=DC_L1AuthorizeDT.Text ;
// ObjAT_DCHDR.DC_L2AuthorizeID=DC_L2AuthorizeID.Text ;
// ObjAT_DCHDR.DC_L2AuthorizeBy=DC_L2AuthorizeBy.Text ;
// ObjAT_DCHDR.DC_L2AuthorizeDT=DC_L2AuthorizeDT.Text ;
// ObjAT_DCHDR.DC_AuthRemark=DC_AuthRemark.Text ;
// ObjAT_DCHDR.DC_DTL_CNT=DC_DTL_CNT.Text ;
// ObjAT_DCHDR.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_DCHDR.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_DCHDR.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_DCHDR.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_DCHDR.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_DCHDR.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_DCHDR.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;
// ObjAT_DCHDR.DC_HDR_BasicAmt=DC_HDR_BasicAmt.Text ;
// ObjAT_DCHDR.DC_HDR_DiscountRate=DC_HDR_DiscountRate.Text ;
// ObjAT_DCHDR.DC_HDR_DiscountAmt=DC_HDR_DiscountAmt.Text ;
// ObjAT_DCHDR.DC_HDR_Net_Amt=DC_HDR_Net_Amt.Text ;
// ObjAT_DCHDR.DC_HDR_Freight_Charges=DC_HDR_Freight_Charges.Text ;
// ObjAT_DCHDR.DC_HDR_Loading_N_Packing_Charges=DC_HDR_Loading_N_Packing_Charges.Text ;
// ObjAT_DCHDR.DC_HDR_Insurance_Charges=DC_HDR_Insurance_Charges.Text ;
// ObjAT_DCHDR.DC_HDR_Other_Charges_Txt=DC_HDR_Other_Charges_Txt.Text ;
// ObjAT_DCHDR.DC_HDR_Other_Charges_Amt=DC_HDR_Other_Charges_Amt.Text ;
// ObjAT_DCHDR.DC_HDR_Taxable_Amt=DC_HDR_Taxable_Amt.Text ;
// ObjAT_DCHDR.DC_HDR_CGST_Amt=DC_HDR_CGST_Amt.Text ;
// ObjAT_DCHDR.DC_HDR_CGST_Taxable_Amt=DC_HDR_CGST_Taxable_Amt.Text ;
// ObjAT_DCHDR.DC_HDR_SGST_Amt=DC_HDR_SGST_Amt.Text ;
// ObjAT_DCHDR.DC_HDR_SGST_Taxable_Amt=DC_HDR_SGST_Taxable_Amt.Text ;
// ObjAT_DCHDR.DC_HDR_IGST_Amt=DC_HDR_IGST_Amt.Text ;
// ObjAT_DCHDR.DC_HDR_IGST_Taxable_Amt=DC_HDR_IGST_Taxable_Amt.Text ;
// ObjAT_DCHDR.DC_HDR_CESS_Amt=DC_HDR_CESS_Amt.Text ;
// ObjAT_DCHDR.DC_HDR_CESS_Taxable_Amt=DC_HDR_CESS_Taxable_Amt.Text ;
// ObjAT_DCHDR.DC_HDR_OtherTax_ID=DC_HDR_OtherTax_ID.Text ;
// ObjAT_DCHDR.DC_HDR_OtherTax_Rate=DC_HDR_OtherTax_Rate.Text ;
// ObjAT_DCHDR.DC_HDR_OtherTax_Amt=DC_HDR_OtherTax_Amt.Text ;
// ObjAT_DCHDR.DC_HDR_Other_Taxable_Amt=DC_HDR_Other_Taxable_Amt.Text ;
// ObjAT_DCHDR.DC_HDR_Total_Tax_Amt=DC_HDR_Total_Tax_Amt.Text ;
// ObjAT_DCHDR.DC_HDR_ItemGross_Total_Amt=DC_HDR_ItemGross_Total_Amt.Text ;
// ObjAT_DCHDR.DC_HDR_Gross_Amt=DC_HDR_Gross_Amt.Text ;
// ObjAT_DCHDR.DC_HDR_Round_Off_Amt=DC_HDR_Round_Off_Amt.Text ;
// ObjAT_DCHDR.DC_HDR_Total_Gross_Amt=DC_HDR_Total_Gross_Amt.Text ;
// ObjAT_DCHDR.DC_HDR_Gross_AmtInWords=DC_HDR_Gross_AmtInWords.Text ;
// ObjAT_DCHDR.DC_HDR_CreditNote_AsOn_Amt=DC_HDR_CreditNote_AsOn_Amt.Text ;
// ObjAT_DCHDR.DC_HDR_DebitNote_AsOn_Amt=DC_HDR_DebitNote_AsOn_Amt.Text ;
// ObjAT_DCHDR.DC_HDR_TDS_Rate=DC_HDR_TDS_Rate.Text ;
// ObjAT_DCHDR.DC_HDR_TDS_Amt=DC_HDR_TDS_Amt.Text ;
// ObjAT_DCHDR.DC_HDR_Paid_AsOn_Amt=DC_HDR_Paid_AsOn_Amt.Text ;
// ObjAT_DCHDR.DC_HDR_Outstanding_AsOn_Amt=DC_HDR_Outstanding_AsOn_Amt.Text ;



// DCHDR_ID.Text =  dt.Rows[0]["DCHDR_ID"].ToString();
// Fk_PIHDR_ID.Text =  dt.Rows[0]["Fk_PIHDR_ID"].ToString();
// Fk_Company_ID.Text =  dt.Rows[0]["Fk_Company_ID"].ToString();
// Fk_Branch_ID.Text =  dt.Rows[0]["Fk_Branch_ID"].ToString();
// Fk_Year_ID.Text =  dt.Rows[0]["Fk_Year_ID"].ToString();
// Fk_Currency_ID.Text =  dt.Rows[0]["Fk_Currency_ID"].ToString();
// Rec_Created_In.Text =  dt.Rows[0]["Rec_Created_In"].ToString();
// Rec_CreatedBy_ID.Text =  dt.Rows[0]["Rec_CreatedBy_ID"].ToString();
// Rec_CreatedFor_ID.Text =  dt.Rows[0]["Rec_CreatedFor_ID"].ToString();
// DC_CreationType.Text =  dt.Rows[0]["DC_CreationType"].ToString();
// DC_Type.Text =  dt.Rows[0]["DC_Type"].ToString();
// DC_Category.Text =  dt.Rows[0]["DC_Category"].ToString();
// DC_Taxtype.Text =  dt.Rows[0]["DC_Taxtype"].ToString();
// DC_No.Text =  dt.Rows[0]["DC_No"].ToString();
// DC_DT.Text =  dt.Rows[0]["DC_DT"].ToString();
// Fk_CustomerID.Text =  dt.Rows[0]["Fk_CustomerID"].ToString();
// DC_CreditDays.Text =  dt.Rows[0]["DC_CreditDays"].ToString();
// DC_DueDT.Text =  dt.Rows[0]["DC_DueDT"].ToString();
// DC_State_ID.Text =  dt.Rows[0]["DC_State_ID"].ToString();
// DC_PONo.Text =  dt.Rows[0]["DC_PONo"].ToString();
// DC_PO_DT.Text =  dt.Rows[0]["DC_PO_DT"].ToString();
// DC_BillTo_CompanyName.Text =  dt.Rows[0]["DC_BillTo_CompanyName"].ToString();
// DC_BillTo_ContactPersone.Text =  dt.Rows[0]["DC_BillTo_ContactPersone"].ToString();
// DC_BillTo_CP_MobileNo.Text =  dt.Rows[0]["DC_BillTo_CP_MobileNo"].ToString();
// DC_BillTo_Add1.Text =  dt.Rows[0]["DC_BillTo_Add1"].ToString();
// DC_BillTo_Add2.Text =  dt.Rows[0]["DC_BillTo_Add2"].ToString();
// DC_BillTo_Add3.Text =  dt.Rows[0]["DC_BillTo_Add3"].ToString();
// DC_BillTo_Pincode.Text =  dt.Rows[0]["DC_BillTo_Pincode"].ToString();
// DC_BillTo_Area.Text =  dt.Rows[0]["DC_BillTo_Area"].ToString();
// DC_BillTo_City.Text =  dt.Rows[0]["DC_BillTo_City"].ToString();
// DC_BillTo_State_ID.Text =  dt.Rows[0]["DC_BillTo_State_ID"].ToString();
// DC_BillTo_Country.Text =  dt.Rows[0]["DC_BillTo_Country"].ToString();
// DC_BillTo_GSTNo.Text =  dt.Rows[0]["DC_BillTo_GSTNo"].ToString();
// DC_BillTo_PANNO.Text =  dt.Rows[0]["DC_BillTo_PANNO"].ToString();
// DC_ShippTo_CompanyName.Text =  dt.Rows[0]["DC_ShippTo_CompanyName"].ToString();
// DC_ShippTo_ContactPersone.Text =  dt.Rows[0]["DC_ShippTo_ContactPersone"].ToString();
// DC_ShippTo_CP_MobileNo.Text =  dt.Rows[0]["DC_ShippTo_CP_MobileNo"].ToString();
// DC_ShippTo_Add1.Text =  dt.Rows[0]["DC_ShippTo_Add1"].ToString();
// DC_ShippTo_Add2.Text =  dt.Rows[0]["DC_ShippTo_Add2"].ToString();
// DC_ShippTo_Add3.Text =  dt.Rows[0]["DC_ShippTo_Add3"].ToString();
// DC_ShippTo_Pincode.Text =  dt.Rows[0]["DC_ShippTo_Pincode"].ToString();
// DC_ShippTo_Area.Text =  dt.Rows[0]["DC_ShippTo_Area"].ToString();
// DC_ShippTo_City.Text =  dt.Rows[0]["DC_ShippTo_City"].ToString();
// DC_ShippTo_State_ID.Text =  dt.Rows[0]["DC_ShippTo_State_ID"].ToString();
// DC_ShippTo_Country.Text =  dt.Rows[0]["DC_ShippTo_Country"].ToString();
// DC_ShippTo_GSTNo.Text =  dt.Rows[0]["DC_ShippTo_GSTNo"].ToString();
// DC_ShippTo_PANNO.Text =  dt.Rows[0]["DC_ShippTo_PANNO"].ToString();
// DC_ShippedFrom_CompanyName.Text =  dt.Rows[0]["DC_ShippedFrom_CompanyName"].ToString();
// DC_ShippedFrom_ContactPersone.Text =  dt.Rows[0]["DC_ShippedFrom_ContactPersone"].ToString();
// DC_ShippedFrom_CP_MobileNo.Text =  dt.Rows[0]["DC_ShippedFrom_CP_MobileNo"].ToString();
// DC_ShippedFrom_Add1.Text =  dt.Rows[0]["DC_ShippedFrom_Add1"].ToString();
// DC_ShippedFrom_Add2.Text =  dt.Rows[0]["DC_ShippedFrom_Add2"].ToString();
// DC_ShippedFrom_Add3.Text =  dt.Rows[0]["DC_ShippedFrom_Add3"].ToString();
// DC_ShippedFrom_Pincode.Text =  dt.Rows[0]["DC_ShippedFrom_Pincode"].ToString();
// DC_ShippedFrom_Area.Text =  dt.Rows[0]["DC_ShippedFrom_Area"].ToString();
// DC_ShippedFrom_City.Text =  dt.Rows[0]["DC_ShippedFrom_City"].ToString();
// DC_ShippedFrom_State_ID.Text =  dt.Rows[0]["DC_ShippedFrom_State_ID"].ToString();
// DC_ShippedFrom_Country.Text =  dt.Rows[0]["DC_ShippedFrom_Country"].ToString();
// DC_ShippedFrom_GSTNo.Text =  dt.Rows[0]["DC_ShippedFrom_GSTNo"].ToString();
// DC_ShippedFrom_PANNO.Text =  dt.Rows[0]["DC_ShippedFrom_PANNO"].ToString();
// DC_PaymentTerms.Text =  dt.Rows[0]["DC_PaymentTerms"].ToString();
// DC_DelvieryPeriod.Text =  dt.Rows[0]["DC_DelvieryPeriod"].ToString();
// DC_DeliveryCharges.Text =  dt.Rows[0]["DC_DeliveryCharges"].ToString();
// DC_ExciseDuty.Text =  dt.Rows[0]["DC_ExciseDuty"].ToString();
// DC_CompletionPeriod.Text =  dt.Rows[0]["DC_CompletionPeriod"].ToString();
// DC_ModeOfDispatch.Text =  dt.Rows[0]["DC_ModeOfDispatch"].ToString();
// DC_TranspoterName.Text =  dt.Rows[0]["DC_TranspoterName"].ToString();
// DC_VehicleNumber.Text =  dt.Rows[0]["DC_VehicleNumber"].ToString();
// DC_PlaceOfDelivery.Text =  dt.Rows[0]["DC_PlaceOfDelivery"].ToString();
// DC_FreigthCharge_Txt.Text =  dt.Rows[0]["DC_FreigthCharge_Txt"].ToString();
// DC_Insurance_Txt.Text =  dt.Rows[0]["DC_Insurance_Txt"].ToString();
// DC_Remark.Text =  dt.Rows[0]["DC_Remark"].ToString();
// DC_L1AuthorizeID.Text =  dt.Rows[0]["DC_L1AuthorizeID"].ToString();
// DC_L1AuthorizeBy.Text =  dt.Rows[0]["DC_L1AuthorizeBy"].ToString();
// DC_L1AuthorizeDT.Text =  dt.Rows[0]["DC_L1AuthorizeDT"].ToString();
// DC_L2AuthorizeID.Text =  dt.Rows[0]["DC_L2AuthorizeID"].ToString();
// DC_L2AuthorizeBy.Text =  dt.Rows[0]["DC_L2AuthorizeBy"].ToString();
// DC_L2AuthorizeDT.Text =  dt.Rows[0]["DC_L2AuthorizeDT"].ToString();
// DC_AuthRemark.Text =  dt.Rows[0]["DC_AuthRemark"].ToString();
// DC_DTL_CNT.Text =  dt.Rows[0]["DC_DTL_CNT"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
// DC_HDR_BasicAmt.Text =  dt.Rows[0]["DC_HDR_BasicAmt"].ToString();
// DC_HDR_DiscountRate.Text =  dt.Rows[0]["DC_HDR_DiscountRate"].ToString();
// DC_HDR_DiscountAmt.Text =  dt.Rows[0]["DC_HDR_DiscountAmt"].ToString();
// DC_HDR_Net_Amt.Text =  dt.Rows[0]["DC_HDR_Net_Amt"].ToString();
// DC_HDR_Freight_Charges.Text =  dt.Rows[0]["DC_HDR_Freight_Charges"].ToString();
// DC_HDR_Loading_N_Packing_Charges.Text =  dt.Rows[0]["DC_HDR_Loading_N_Packing_Charges"].ToString();
// DC_HDR_Insurance_Charges.Text =  dt.Rows[0]["DC_HDR_Insurance_Charges"].ToString();
// DC_HDR_Other_Charges_Txt.Text =  dt.Rows[0]["DC_HDR_Other_Charges_Txt"].ToString();
// DC_HDR_Other_Charges_Amt.Text =  dt.Rows[0]["DC_HDR_Other_Charges_Amt"].ToString();
// DC_HDR_Taxable_Amt.Text =  dt.Rows[0]["DC_HDR_Taxable_Amt"].ToString();
// DC_HDR_CGST_Amt.Text =  dt.Rows[0]["DC_HDR_CGST_Amt"].ToString();
// DC_HDR_CGST_Taxable_Amt.Text =  dt.Rows[0]["DC_HDR_CGST_Taxable_Amt"].ToString();
// DC_HDR_SGST_Amt.Text =  dt.Rows[0]["DC_HDR_SGST_Amt"].ToString();
// DC_HDR_SGST_Taxable_Amt.Text =  dt.Rows[0]["DC_HDR_SGST_Taxable_Amt"].ToString();
// DC_HDR_IGST_Amt.Text =  dt.Rows[0]["DC_HDR_IGST_Amt"].ToString();
// DC_HDR_IGST_Taxable_Amt.Text =  dt.Rows[0]["DC_HDR_IGST_Taxable_Amt"].ToString();
// DC_HDR_CESS_Amt.Text =  dt.Rows[0]["DC_HDR_CESS_Amt"].ToString();
// DC_HDR_CESS_Taxable_Amt.Text =  dt.Rows[0]["DC_HDR_CESS_Taxable_Amt"].ToString();
// DC_HDR_OtherTax_ID.Text =  dt.Rows[0]["DC_HDR_OtherTax_ID"].ToString();
// DC_HDR_OtherTax_Rate.Text =  dt.Rows[0]["DC_HDR_OtherTax_Rate"].ToString();
// DC_HDR_OtherTax_Amt.Text =  dt.Rows[0]["DC_HDR_OtherTax_Amt"].ToString();
// DC_HDR_Other_Taxable_Amt.Text =  dt.Rows[0]["DC_HDR_Other_Taxable_Amt"].ToString();
// DC_HDR_Total_Tax_Amt.Text =  dt.Rows[0]["DC_HDR_Total_Tax_Amt"].ToString();
// DC_HDR_ItemGross_Total_Amt.Text =  dt.Rows[0]["DC_HDR_ItemGross_Total_Amt"].ToString();
// DC_HDR_Gross_Amt.Text =  dt.Rows[0]["DC_HDR_Gross_Amt"].ToString();
// DC_HDR_Round_Off_Amt.Text =  dt.Rows[0]["DC_HDR_Round_Off_Amt"].ToString();
// DC_HDR_Total_Gross_Amt.Text =  dt.Rows[0]["DC_HDR_Total_Gross_Amt"].ToString();
// DC_HDR_Gross_AmtInWords.Text =  dt.Rows[0]["DC_HDR_Gross_AmtInWords"].ToString();
// DC_HDR_CreditNote_AsOn_Amt.Text =  dt.Rows[0]["DC_HDR_CreditNote_AsOn_Amt"].ToString();
// DC_HDR_DebitNote_AsOn_Amt.Text =  dt.Rows[0]["DC_HDR_DebitNote_AsOn_Amt"].ToString();
// DC_HDR_TDS_Rate.Text =  dt.Rows[0]["DC_HDR_TDS_Rate"].ToString();
// DC_HDR_TDS_Amt.Text =  dt.Rows[0]["DC_HDR_TDS_Amt"].ToString();
// DC_HDR_Paid_AsOn_Amt.Text =  dt.Rows[0]["DC_HDR_Paid_AsOn_Amt"].ToString();
// DC_HDR_Outstanding_AsOn_Amt.Text =  dt.Rows[0]["DC_HDR_Outstanding_AsOn_Amt"].ToString();
