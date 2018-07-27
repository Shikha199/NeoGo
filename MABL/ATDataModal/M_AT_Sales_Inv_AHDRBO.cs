using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal
{
    public class M_AT_Sales_Inv_AHDRBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public M_AT_Sales_Inv_AHDRBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "SINVHDR_ID";
        private string _TableName = "M_AT_Sales_Inv_AHDR";
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

        private Int64 _SINVHDR_ID;
        private Int64 _Fk_PIHDR_ID;
        private Int64 _Fk_Company_ID;
        private Int64 _Fk_Branch_ID;
        private Int64 _Fk_Year_ID;
        private Int32 _Fk_Currency_ID;
        private String _Rec_Created_In;
        private Int64 _Rec_CreatedBy_ID;
        private Int64 _Rec_CreatedFor_ID;
        private String _SINV_CreationType;
        private String _SINV_Type;
        private String _SINV_Category;
        private String _SINV_Taxtype;
        private String _SINV_No;
        private String _SINV_DT;
        private Int64 _Fk_CustomerID;
        private Int64 _SINV_CreditDays;
        private String _SINV_DueDT;
        private Int64 _SINV_State_ID;
        private String _SINV_PONo;
        private String _SINV_PO_DT;
        private String _SINV_BillTo_CompanyName;
        private String _SINV_BillTo_ContactPersone;
        private String _SINV_BillTo_CP_MobileNo;
        private String _SINV_BillTo_Add1;
        private String _SINV_BillTo_Add2;
        private String _SINV_BillTo_Add3;
        private String _SINV_BillTo_Pincode;
        private String _SINV_BillTo_Area;
        private String _SINV_BillTo_City;
        private Int64 _SINV_BillTo_State_ID;
        private String _SINV_BillTo_Country;
        private String _SINV_BillTo_GSTNo;
        private String _SINV_BillTo_PANNO;
        private String _SINV_ShippTo_CompanyName;
        private String _SINV_ShippTo_ContactPersone;
        private String _SINV_ShippTo_CP_MobileNo;
        private String _SINV_ShippTo_Add1;
        private String _SINV_ShippTo_Add2;
        private String _SINV_ShippTo_Add3;
        private String _SINV_ShippTo_Pincode;
        private String _SINV_ShippTo_Area;
        private String _SINV_ShippTo_City;
        private Int64 _SINV_ShippTo_State_ID;
        private String _SINV_ShippTo_Country;
        private String _SINV_ShippTo_GSTNo;
        private String _SINV_ShippTo_PANNO;
        private String _SINV_ShippedFrom_CompanyName;
        private String _SINV_ShippedFrom_ContactPersone;
        private String _SINV_ShippedFrom_CP_MobileNo;
        private String _SINV_ShippedFrom_Add1;
        private String _SINV_ShippedFrom_Add2;
        private String _SINV_ShippedFrom_Add3;
        private String _SINV_ShippedFrom_Pincode;
        private String _SINV_ShippedFrom_Area;
        private String _SINV_ShippedFrom_City;
        private Int64 _SINV_ShippedFrom_State_ID;
        private String _SINV_ShippedFrom_Country;
        private String _SINV_ShippedFrom_GSTNo;
        private String _SINV_ShippedFrom_PANNO;
        private String _SINV_PaymentTerms;
        private String _SINV_DelvieryPeriod;
        private String _SINV_DeliveryCharges;
        private String _SINV_ExciseDuty;
        private String _SINV_CompletionPeriod;
        private String _SINV_ModeOfDispatch;
        private String _SINV_TranspoterName;
        private String _SINV_LRNumber;
         
        private String _SINV_VehicleNumber;
        private String _SINV_PlaceOfDelivery;
        private String _SINV_FreigthCharge_Txt;
        private String _SINV_Insurance_Txt;
        private String _SINV_Remark;
        private Int16 _SINV_L1AuthorizeID;
        private String _SINV_L1AuthorizeBy;
        private String _SINV_L1AuthorizeDT;
        private Int16 _SINV_L2AuthorizeID;
        private String _SINV_L2AuthorizeBy;
        private String _SINV_L2AuthorizeDT;
        private String _SINV_AuthRemark;
        private Int16 _SINV_DTL_CNT;
        private String _MDBSC_RowStatus;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;
        private Decimal _SINV_HDR_BasicAmt;
        private Decimal _SINV_HDR_DiscountRate;
        private Decimal _SINV_HDR_DiscountAmt;
        private Decimal _SINV_HDR_Net_Amt;
        private Decimal _SINV_HDR_Freight_Charges;
        private Decimal _SINV_HDR_Loading_N_Packing_Charges;
        private Decimal _SINV_HDR_Insurance_Charges;
        private String _SINV_HDR_Other_Charges_Txt;
        private Decimal _SINV_HDR_Other_Charges_Amt;
        private Decimal _SINV_HDR_Taxable_Amt;
        private Decimal _SINV_HDR_CGST_Amt;
        private Decimal _SINV_HDR_CGST_Taxable_Amt;
        private Decimal _SINV_HDR_SGST_Amt;
        private Decimal _SINV_HDR_SGST_Taxable_Amt;
        private Decimal _SINV_HDR_IGST_Amt;
        private Decimal _SINV_HDR_IGST_Taxable_Amt;
        private Decimal _SINV_HDR_CESS_Amt;
        private Decimal _SINV_HDR_CESS_Taxable_Amt;
        private Int16 _SINV_HDR_OtherTax_ID;
        private Decimal _SINV_HDR_OtherTax_Rate;
        private Decimal _SINV_HDR_OtherTax_Amt;
        private Decimal _SINV_HDR_Other_Taxable_Amt;
        private Decimal _SINV_HDR_Total_Tax_Amt;
        private Decimal _SINV_HDR_ItemGross_Total_Amt;
        private Decimal _SINV_HDR_Gross_Amt;
        private Decimal _SINV_HDR_Round_Off_Amt;
        private Decimal _SINV_HDR_Total_Gross_Amt;
        private String _SINV_HDR_Gross_AmtInWords;
        private Decimal _SINV_HDR_CreditNote_AsOn_Amt;
        private Decimal _SINV_HDR_DebitNote_AsOn_Amt;
        private Decimal _SINV_HDR_TDS_Rate;
        private Decimal _SINV_HDR_TDS_Amt;
        private Decimal _SINV_HDR_Paid_AsOn_Amt;
        private Decimal _SINV_HDR_Outstanding_AsOn_Amt;

        private String _SINV_ewb_EwayBillNo;
        private Int64 _SINV_ewb_TransDocNo;
        private String _SINV_ewb_TransDocDate;
        private Int64 _SINV_ewb_Distance;
        private Int64 _SINV_ewb_TransporterId;
        //private String _SINV_ewb_TransporterName;
        private String _SINV_ewb_TransactionType;
        private String _SINV_ewb_TransactionSubType;
        private String _SINV_ewb_VehicleType;
        private Decimal _SINV_ewb_Amount;


        public String SINV_ewb_EwayBillNo
        {
            get
            {
                return this._SINV_ewb_EwayBillNo;
            }
            set
            {
                this._SINV_ewb_EwayBillNo = value;
                _UpdateFieldName.Add("SINV_ewb_EwayBillNo");
            }
        }
        public String SINV_ewb_TransDocDate
        {
            get
            {
                return this._SINV_ewb_TransDocDate;
            }
            set
            {
                this._SINV_ewb_TransDocDate = value;
                _UpdateFieldName.Add("SINV_ewb_TransDocDate");
            }
        }
        
        public String SINV_ewb_TransactionType
        {
            get
            {
                return this._SINV_ewb_TransactionType;
            }
            set
            {
                this._SINV_ewb_TransactionType = value;
                _UpdateFieldName.Add("SINV_ewb_TransactionType");
            }
        }
        public String SINV_ewb_TransactionSubType
        {
            get
            {
                return this._SINV_ewb_TransactionSubType;
            }
            set
            {
                this._SINV_ewb_TransactionSubType = value;
                _UpdateFieldName.Add("SINV_ewb_TransactionSubType");
            }
        }
        public String SINV_ewb_VehicleType
        {
            get
            {
                return this._SINV_ewb_VehicleType;
            }
            set
            {
                this._SINV_ewb_VehicleType = value;
                _UpdateFieldName.Add("SINV_ewb_VehicleType");
            }
        }

        public Int64 SINV_ewb_TransDocNo
        {
            get
            {
                return this._SINV_ewb_TransDocNo;
            }
            set
            {
                this._SINV_ewb_TransDocNo = value;
                _UpdateFieldName.Add("SINV_ewb_TransDocNo");
            }
        }
        public Int64 SINV_ewb_Distance
        {
            get
            {
                return this._SINV_ewb_Distance;
            }
            set
            {
                this._SINV_ewb_Distance = value;
                _UpdateFieldName.Add("SINV_ewb_Distance");
            }
        }
        public Int64 SINV_ewb_TransporterId
        {
            get
            {
                return this._SINV_ewb_TransporterId;
            }
            set
            {
                this._SINVHDR_ID = value;
                _UpdateFieldName.Add("SINV_ewb_TransporterId");
            }
        }

        public Decimal SINV_ewb_Amount
        {
            get
            {
                return this._SINV_ewb_Amount;
            }
            set
            {
                this._SINV_ewb_Amount = value;
                _UpdateFieldName.Add("SINV_ewb_Amount");
            }
        }
        public Int64 SINVHDR_ID
        {
            get
            {
                return this._SINVHDR_ID;
            }
            set
            {
                this._SINVHDR_ID = value;
                _UpdateFieldName.Add("SINVHDR_ID");
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

        public String SINV_LRNumber
        {
            get
            {
                return this._SINV_LRNumber;
            }
            set
            {
                this._SINV_LRNumber = value;
                _UpdateFieldName.Add("SINV_LRNumber");
            }
        }
        public String SINV_CreationType
        {
            get
            {
                return this._SINV_CreationType;
            }
            set
            {
                this._SINV_CreationType = value;
                _UpdateFieldName.Add("SINV_CreationType");
            }
        }
        public String SINV_Type
        {
            get
            {
                return this._SINV_Type;
            }
            set
            {
                this._SINV_Type = value;
                _UpdateFieldName.Add("SINV_Type");
            }
        }
        public String SINV_Category
        {
            get
            {
                return this._SINV_Category;
            }
            set
            {
                this._SINV_Category = value;
                _UpdateFieldName.Add("SINV_Category");
            }
        }
        public String SINV_Taxtype
        {
            get
            {
                return this._SINV_Taxtype;
            }
            set
            {
                this._SINV_Taxtype = value;
                _UpdateFieldName.Add("SINV_Taxtype");
            }
        }
        public String SINV_No
        {
            get
            {
                return this._SINV_No;
            }
            set
            {
                this._SINV_No = value;
                _UpdateFieldName.Add("SINV_No");
            }
        }
        public String SINV_DT
        {
            get
            {
                return this._SINV_DT;
            }
            set
            {
                this._SINV_DT = value;
                _UpdateFieldName.Add("SINV_DT");
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
        public Int64 SINV_CreditDays
        {
            get
            {
                return this._SINV_CreditDays;
            }
            set
            {
                this._SINV_CreditDays = value;
                _UpdateFieldName.Add("SINV_CreditDays");
            }
        }
        public String SINV_DueDT
        {
            get
            {
                return this._SINV_DueDT;
            }
            set
            {
                this._SINV_DueDT = value;
                _UpdateFieldName.Add("SINV_DueDT");
            }
        }
        public Int64 SINV_State_ID
        {
            get
            {
                return this._SINV_State_ID;
            }
            set
            {
                this._SINV_State_ID = value;
                _UpdateFieldName.Add("SINV_State_ID");
            }
        }
        public String SINV_PONo
        {
            get
            {
                return this._SINV_PONo;
            }
            set
            {
                this._SINV_PONo = value;
                _UpdateFieldName.Add("SINV_PONo");
            }
        }
        public String SINV_PO_DT
        {
            get
            {
                return this._SINV_PO_DT;
            }
            set
            {
                this._SINV_PO_DT = value;
                _UpdateFieldName.Add("SINV_PO_DT");
            }
        }
        public String SINV_BillTo_CompanyName
        {
            get
            {
                return this._SINV_BillTo_CompanyName;
            }
            set
            {
                this._SINV_BillTo_CompanyName = value;
                _UpdateFieldName.Add("SINV_BillTo_CompanyName");
            }
        }
        public String SINV_BillTo_ContactPersone
        {
            get
            {
                return this._SINV_BillTo_ContactPersone;
            }
            set
            {
                this._SINV_BillTo_ContactPersone = value;
                _UpdateFieldName.Add("SINV_BillTo_ContactPersone");
            }
        }
        public String SINV_BillTo_CP_MobileNo
        {
            get
            {
                return this._SINV_BillTo_CP_MobileNo;
            }
            set
            {
                this._SINV_BillTo_CP_MobileNo = value;
                _UpdateFieldName.Add("SINV_BillTo_CP_MobileNo");
            }
        }
        public String SINV_BillTo_Add1
        {
            get
            {
                return this._SINV_BillTo_Add1;
            }
            set
            {
                this._SINV_BillTo_Add1 = value;
                _UpdateFieldName.Add("SINV_BillTo_Add1");
            }
        }
        public String SINV_BillTo_Add2
        {
            get
            {
                return this._SINV_BillTo_Add2;
            }
            set
            {
                this._SINV_BillTo_Add2 = value;
                _UpdateFieldName.Add("SINV_BillTo_Add2");
            }
        }
        public String SINV_BillTo_Add3
        {
            get
            {
                return this._SINV_BillTo_Add3;
            }
            set
            {
                this._SINV_BillTo_Add3 = value;
                _UpdateFieldName.Add("SINV_BillTo_Add3");
            }
        }
        public String SINV_BillTo_Pincode
        {
            get
            {
                return this._SINV_BillTo_Pincode;
            }
            set
            {
                this._SINV_BillTo_Pincode = value;
                _UpdateFieldName.Add("SINV_BillTo_Pincode");
            }
        }
        public String SINV_BillTo_Area
        {
            get
            {
                return this._SINV_BillTo_Area;
            }
            set
            {
                this._SINV_BillTo_Area = value;
                _UpdateFieldName.Add("SINV_BillTo_Area");
            }
        }
        public String SINV_BillTo_City
        {
            get
            {
                return this._SINV_BillTo_City;
            }
            set
            {
                this._SINV_BillTo_City = value;
                _UpdateFieldName.Add("SINV_BillTo_City");
            }
        }
        public Int64 SINV_BillTo_State_ID
        {
            get
            {
                return this._SINV_BillTo_State_ID;
            }
            set
            {
                this._SINV_BillTo_State_ID = value;
                _UpdateFieldName.Add("SINV_BillTo_State_ID");
            }
        }
        public String SINV_BillTo_Country
        {
            get
            {
                return this._SINV_BillTo_Country;
            }
            set
            {
                this._SINV_BillTo_Country = value;
                _UpdateFieldName.Add("SINV_BillTo_Country");
            }
        }
        public String SINV_BillTo_GSTNo
        {
            get
            {
                return this._SINV_BillTo_GSTNo;
            }
            set
            {
                this._SINV_BillTo_GSTNo = value;
                _UpdateFieldName.Add("SINV_BillTo_GSTNo");
            }
        }
        public String SINV_BillTo_PANNO
        {
            get
            {
                return this._SINV_BillTo_PANNO;
            }
            set
            {
                this._SINV_BillTo_PANNO = value;
                _UpdateFieldName.Add("SINV_BillTo_PANNO");
            }
        }
        public String SINV_ShippTo_CompanyName
        {
            get
            {
                return this._SINV_ShippTo_CompanyName;
            }
            set
            {
                this._SINV_ShippTo_CompanyName = value;
                _UpdateFieldName.Add("SINV_ShippTo_CompanyName");
            }
        }
        public String SINV_ShippTo_ContactPersone
        {
            get
            {
                return this._SINV_ShippTo_ContactPersone;
            }
            set
            {
                this._SINV_ShippTo_ContactPersone = value;
                _UpdateFieldName.Add("SINV_ShippTo_ContactPersone");
            }
        }
        public String SINV_ShippTo_CP_MobileNo
        {
            get
            {
                return this._SINV_ShippTo_CP_MobileNo;
            }
            set
            {
                this._SINV_ShippTo_CP_MobileNo = value;
                _UpdateFieldName.Add("SINV_ShippTo_CP_MobileNo");
            }
        }
        public String SINV_ShippTo_Add1
        {
            get
            {
                return this._SINV_ShippTo_Add1;
            }
            set
            {
                this._SINV_ShippTo_Add1 = value;
                _UpdateFieldName.Add("SINV_ShippTo_Add1");
            }
        }
        public String SINV_ShippTo_Add2
        {
            get
            {
                return this._SINV_ShippTo_Add2;
            }
            set
            {
                this._SINV_ShippTo_Add2 = value;
                _UpdateFieldName.Add("SINV_ShippTo_Add2");
            }
        }
        public String SINV_ShippTo_Add3
        {
            get
            {
                return this._SINV_ShippTo_Add3;
            }
            set
            {
                this._SINV_ShippTo_Add3 = value;
                _UpdateFieldName.Add("SINV_ShippTo_Add3");
            }
        }
        public String SINV_ShippTo_Pincode
        {
            get
            {
                return this._SINV_ShippTo_Pincode;
            }
            set
            {
                this._SINV_ShippTo_Pincode = value;
                _UpdateFieldName.Add("SINV_ShippTo_Pincode");
            }
        }
        public String SINV_ShippTo_Area
        {
            get
            {
                return this._SINV_ShippTo_Area;
            }
            set
            {
                this._SINV_ShippTo_Area = value;
                _UpdateFieldName.Add("SINV_ShippTo_Area");
            }
        }
        public String SINV_ShippTo_City
        {
            get
            {
                return this._SINV_ShippTo_City;
            }
            set
            {
                this._SINV_ShippTo_City = value;
                _UpdateFieldName.Add("SINV_ShippTo_City");
            }
        }
        public Int64 SINV_ShippTo_State_ID
        {
            get
            {
                return this._SINV_ShippTo_State_ID;
            }
            set
            {
                this._SINV_ShippTo_State_ID = value;
                _UpdateFieldName.Add("SINV_ShippTo_State_ID");
            }
        }
        public String SINV_ShippTo_Country
        {
            get
            {
                return this._SINV_ShippTo_Country;
            }
            set
            {
                this._SINV_ShippTo_Country = value;
                _UpdateFieldName.Add("SINV_ShippTo_Country");
            }
        }
        public String SINV_ShippTo_GSTNo
        {
            get
            {
                return this._SINV_ShippTo_GSTNo;
            }
            set
            {
                this._SINV_ShippTo_GSTNo = value;
                _UpdateFieldName.Add("SINV_ShippTo_GSTNo");
            }
        }
        public String SINV_ShippTo_PANNO
        {
            get
            {
                return this._SINV_ShippTo_PANNO;
            }
            set
            {
                this._SINV_ShippTo_PANNO = value;
                _UpdateFieldName.Add("SINV_ShippTo_PANNO");
            }
        }
        public String SINV_ShippedFrom_CompanyName
        {
            get
            {
                return this._SINV_ShippedFrom_CompanyName;
            }
            set
            {
                this._SINV_ShippedFrom_CompanyName = value;
                _UpdateFieldName.Add("SINV_ShippedFrom_CompanyName");
            }
        }
        public String SINV_ShippedFrom_ContactPersone
        {
            get
            {
                return this._SINV_ShippedFrom_ContactPersone;
            }
            set
            {
                this._SINV_ShippedFrom_ContactPersone = value;
                _UpdateFieldName.Add("SINV_ShippedFrom_ContactPersone");
            }
        }
        public String SINV_ShippedFrom_CP_MobileNo
        {
            get
            {
                return this._SINV_ShippedFrom_CP_MobileNo;
            }
            set
            {
                this._SINV_ShippedFrom_CP_MobileNo = value;
                _UpdateFieldName.Add("SINV_ShippedFrom_CP_MobileNo");
            }
        }
        public String SINV_ShippedFrom_Add1
        {
            get
            {
                return this._SINV_ShippedFrom_Add1;
            }
            set
            {
                this._SINV_ShippedFrom_Add1 = value;
                _UpdateFieldName.Add("SINV_ShippedFrom_Add1");
            }
        }
        public String SINV_ShippedFrom_Add2
        {
            get
            {
                return this._SINV_ShippedFrom_Add2;
            }
            set
            {
                this._SINV_ShippedFrom_Add2 = value;
                _UpdateFieldName.Add("SINV_ShippedFrom_Add2");
            }
        }
        public String SINV_ShippedFrom_Add3
        {
            get
            {
                return this._SINV_ShippedFrom_Add3;
            }
            set
            {
                this._SINV_ShippedFrom_Add3 = value;
                _UpdateFieldName.Add("SINV_ShippedFrom_Add3");
            }
        }
        public String SINV_ShippedFrom_Pincode
        {
            get
            {
                return this._SINV_ShippedFrom_Pincode;
            }
            set
            {
                this._SINV_ShippedFrom_Pincode = value;
                _UpdateFieldName.Add("SINV_ShippedFrom_Pincode");
            }
        }
        public String SINV_ShippedFrom_Area
        {
            get
            {
                return this._SINV_ShippedFrom_Area;
            }
            set
            {
                this._SINV_ShippedFrom_Area = value;
                _UpdateFieldName.Add("SINV_ShippedFrom_Area");
            }
        }
        public String SINV_ShippedFrom_City
        {
            get
            {
                return this._SINV_ShippedFrom_City;
            }
            set
            {
                this._SINV_ShippedFrom_City = value;
                _UpdateFieldName.Add("SINV_ShippedFrom_City");
            }
        }
        public Int64 SINV_ShippedFrom_State_ID
        {
            get
            {
                return this._SINV_ShippedFrom_State_ID;
            }
            set
            {
                this._SINV_ShippedFrom_State_ID = value;
                _UpdateFieldName.Add("SINV_ShippedFrom_State_ID");
            }
        }
        public String SINV_ShippedFrom_Country
        {
            get
            {
                return this._SINV_ShippedFrom_Country;
            }
            set
            {
                this._SINV_ShippedFrom_Country = value;
                _UpdateFieldName.Add("SINV_ShippedFrom_Country");
            }
        }
        public String SINV_ShippedFrom_GSTNo
        {
            get
            {
                return this._SINV_ShippedFrom_GSTNo;
            }
            set
            {
                this._SINV_ShippedFrom_GSTNo = value;
                _UpdateFieldName.Add("SINV_ShippedFrom_GSTNo");
            }
        }
        public String SINV_ShippedFrom_PANNO
        {
            get
            {
                return this._SINV_ShippedFrom_PANNO;
            }
            set
            {
                this._SINV_ShippedFrom_PANNO = value;
                _UpdateFieldName.Add("SINV_ShippedFrom_PANNO");
            }
        }
        public String SINV_PaymentTerms
        {
            get
            {
                return this._SINV_PaymentTerms;
            }
            set
            {
                this._SINV_PaymentTerms = value;
                _UpdateFieldName.Add("SINV_PaymentTerms");
            }
        }
        public String SINV_DelvieryPeriod
        {
            get
            {
                return this._SINV_DelvieryPeriod;
            }
            set
            {
                this._SINV_DelvieryPeriod = value;
                _UpdateFieldName.Add("SINV_DelvieryPeriod");
            }
        }
        public String SINV_DeliveryCharges
        {
            get
            {
                return this._SINV_DeliveryCharges;
            }
            set
            {
                this._SINV_DeliveryCharges = value;
                _UpdateFieldName.Add("SINV_DeliveryCharges");
            }
        }
        public String SINV_ExciseDuty
        {
            get
            {
                return this._SINV_ExciseDuty;
            }
            set
            {
                this._SINV_ExciseDuty = value;
                _UpdateFieldName.Add("SINV_ExciseDuty");
            }
        }
        public String SINV_CompletionPeriod
        {
            get
            {
                return this._SINV_CompletionPeriod;
            }
            set
            {
                this._SINV_CompletionPeriod = value;
                _UpdateFieldName.Add("SINV_CompletionPeriod");
            }
        }
        public String SINV_ModeOfDispatch
        {
            get
            {
                return this._SINV_ModeOfDispatch;
            }
            set
            {
                this._SINV_ModeOfDispatch = value;
                _UpdateFieldName.Add("SINV_ModeOfDispatch");
            }
        }
        public String SINV_TranspoterName
        {
            get
            {
                return this._SINV_TranspoterName;
            }
            set
            {
                this._SINV_TranspoterName = value;
                _UpdateFieldName.Add("SINV_TranspoterName");
            }
        }
        public String SINV_VehicleNumber
        {
            get
            {
                return this._SINV_VehicleNumber;
            }
            set
            {
                this._SINV_VehicleNumber = value;
                _UpdateFieldName.Add("SINV_VehicleNumber");
            }
        }
        public String SINV_PlaceOfDelivery
        {
            get
            {
                return this._SINV_PlaceOfDelivery;
            }
            set
            {
                this._SINV_PlaceOfDelivery = value;
                _UpdateFieldName.Add("SINV_PlaceOfDelivery");
            }
        }
        public String SINV_FreigthCharge_Txt
        {
            get
            {
                return this._SINV_FreigthCharge_Txt;
            }
            set
            {
                this._SINV_FreigthCharge_Txt = value;
                _UpdateFieldName.Add("SINV_FreigthCharge_Txt");
            }
        }
        public String SINV_Insurance_Txt
        {
            get
            {
                return this._SINV_Insurance_Txt;
            }
            set
            {
                this._SINV_Insurance_Txt = value;
                _UpdateFieldName.Add("SINV_Insurance_Txt");
            }
        }
        public String SINV_Remark
        {
            get
            {
                return this._SINV_Remark;
            }
            set
            {
                this._SINV_Remark = value;
                _UpdateFieldName.Add("SINV_Remark");
            }
        }
        public Int16 SINV_L1AuthorizeID
        {
            get
            {
                return this._SINV_L1AuthorizeID;
            }
            set
            {
                this._SINV_L1AuthorizeID = value;
                _UpdateFieldName.Add("SINV_L1AuthorizeID");
            }
        }
        public String SINV_L1AuthorizeBy
        {
            get
            {
                return this._SINV_L1AuthorizeBy;
            }
            set
            {
                this._SINV_L1AuthorizeBy = value;
                _UpdateFieldName.Add("SINV_L1AuthorizeBy");
            }
        }
        public String SINV_L1AuthorizeDT
        {
            get
            {
                return this._SINV_L1AuthorizeDT;
            }
            set
            {
                this._SINV_L1AuthorizeDT = value;
                _UpdateFieldName.Add("SINV_L1AuthorizeDT");
            }
        }
        public Int16 SINV_L2AuthorizeID
        {
            get
            {
                return this._SINV_L2AuthorizeID;
            }
            set
            {
                this._SINV_L2AuthorizeID = value;
                _UpdateFieldName.Add("SINV_L2AuthorizeID");
            }
        }
        public String SINV_L2AuthorizeBy
        {
            get
            {
                return this._SINV_L2AuthorizeBy;
            }
            set
            {
                this._SINV_L2AuthorizeBy = value;
                _UpdateFieldName.Add("SINV_L2AuthorizeBy");
            }
        }
        public String SINV_L2AuthorizeDT
        {
            get
            {
                return this._SINV_L2AuthorizeDT;
            }
            set
            {
                this._SINV_L2AuthorizeDT = value;
                _UpdateFieldName.Add("SINV_L2AuthorizeDT");
            }
        }
        public String SINV_AuthRemark
        {
            get
            {
                return this._SINV_AuthRemark;
            }
            set
            {
                this._SINV_AuthRemark = value;
                _UpdateFieldName.Add("SINV_AuthRemark");
            }
        }
        public Int16 SINV_DTL_CNT
        {
            get
            {
                return this._SINV_DTL_CNT;
            }
            set
            {
                this._SINV_DTL_CNT = value;
                _UpdateFieldName.Add("SINV_DTL_CNT");
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
        public Decimal SINV_HDR_BasicAmt
        {
            get
            {
                return this._SINV_HDR_BasicAmt;
            }
            set
            {
                this._SINV_HDR_BasicAmt = value;
                _UpdateFieldName.Add("SINV_HDR_BasicAmt");
            }
        }
        public Decimal SINV_HDR_DiscountRate
        {
            get
            {
                return this._SINV_HDR_DiscountRate;
            }
            set
            {
                this._SINV_HDR_DiscountRate = value;
                _UpdateFieldName.Add("SINV_HDR_DiscountRate");
            }
        }
        public Decimal SINV_HDR_DiscountAmt
        {
            get
            {
                return this._SINV_HDR_DiscountAmt;
            }
            set
            {
                this._SINV_HDR_DiscountAmt = value;
                _UpdateFieldName.Add("SINV_HDR_DiscountAmt");
            }
        }
        public Decimal SINV_HDR_Net_Amt
        {
            get
            {
                return this._SINV_HDR_Net_Amt;
            }
            set
            {
                this._SINV_HDR_Net_Amt = value;
                _UpdateFieldName.Add("SINV_HDR_Net_Amt");
            }
        }
        public Decimal SINV_HDR_Freight_Charges
        {
            get
            {
                return this._SINV_HDR_Freight_Charges;
            }
            set
            {
                this._SINV_HDR_Freight_Charges = value;
                _UpdateFieldName.Add("SINV_HDR_Freight_Charges");
            }
        }
        public Decimal SINV_HDR_Loading_N_Packing_Charges
        {
            get
            {
                return this._SINV_HDR_Loading_N_Packing_Charges;
            }
            set
            {
                this._SINV_HDR_Loading_N_Packing_Charges = value;
                _UpdateFieldName.Add("SINV_HDR_Loading_N_Packing_Charges");
            }
        }
        public Decimal SINV_HDR_Insurance_Charges
        {
            get
            {
                return this._SINV_HDR_Insurance_Charges;
            }
            set
            {
                this._SINV_HDR_Insurance_Charges = value;
                _UpdateFieldName.Add("SINV_HDR_Insurance_Charges");
            }
        }
        public String SINV_HDR_Other_Charges_Txt
        {
            get
            {
                return this._SINV_HDR_Other_Charges_Txt;
            }
            set
            {
                this._SINV_HDR_Other_Charges_Txt = value;
                _UpdateFieldName.Add("SINV_HDR_Other_Charges_Txt");
            }
        }
        public Decimal SINV_HDR_Other_Charges_Amt
        {
            get
            {
                return this._SINV_HDR_Other_Charges_Amt;
            }
            set
            {
                this._SINV_HDR_Other_Charges_Amt = value;
                _UpdateFieldName.Add("SINV_HDR_Other_Charges_Amt");
            }
        }
        public Decimal SINV_HDR_Taxable_Amt
        {
            get
            {
                return this._SINV_HDR_Taxable_Amt;
            }
            set
            {
                this._SINV_HDR_Taxable_Amt = value;
                _UpdateFieldName.Add("SINV_HDR_Taxable_Amt");
            }
        }
        public Decimal SINV_HDR_CGST_Amt
        {
            get
            {
                return this._SINV_HDR_CGST_Amt;
            }
            set
            {
                this._SINV_HDR_CGST_Amt = value;
                _UpdateFieldName.Add("SINV_HDR_CGST_Amt");
            }
        }
        public Decimal SINV_HDR_CGST_Taxable_Amt
        {
            get
            {
                return this._SINV_HDR_CGST_Taxable_Amt;
            }
            set
            {
                this._SINV_HDR_CGST_Taxable_Amt = value;
                _UpdateFieldName.Add("SINV_HDR_CGST_Taxable_Amt");
            }
        }
        public Decimal SINV_HDR_SGST_Amt
        {
            get
            {
                return this._SINV_HDR_SGST_Amt;
            }
            set
            {
                this._SINV_HDR_SGST_Amt = value;
                _UpdateFieldName.Add("SINV_HDR_SGST_Amt");
            }
        }
        public Decimal SINV_HDR_SGST_Taxable_Amt
        {
            get
            {
                return this._SINV_HDR_SGST_Taxable_Amt;
            }
            set
            {
                this._SINV_HDR_SGST_Taxable_Amt = value;
                _UpdateFieldName.Add("SINV_HDR_SGST_Taxable_Amt");
            }
        }
        public Decimal SINV_HDR_IGST_Amt
        {
            get
            {
                return this._SINV_HDR_IGST_Amt;
            }
            set
            {
                this._SINV_HDR_IGST_Amt = value;
                _UpdateFieldName.Add("SINV_HDR_IGST_Amt");
            }
        }
        public Decimal SINV_HDR_IGST_Taxable_Amt
        {
            get
            {
                return this._SINV_HDR_IGST_Taxable_Amt;
            }
            set
            {
                this._SINV_HDR_IGST_Taxable_Amt = value;
                _UpdateFieldName.Add("SINV_HDR_IGST_Taxable_Amt");
            }
        }
        public Decimal SINV_HDR_CESS_Amt
        {
            get
            {
                return this._SINV_HDR_CESS_Amt;
            }
            set
            {
                this._SINV_HDR_CESS_Amt = value;
                _UpdateFieldName.Add("SINV_HDR_CESS_Amt");
            }
        }
        public Decimal SINV_HDR_CESS_Taxable_Amt
        {
            get
            {
                return this._SINV_HDR_CESS_Taxable_Amt;
            }
            set
            {
                this._SINV_HDR_CESS_Taxable_Amt = value;
                _UpdateFieldName.Add("SINV_HDR_CESS_Taxable_Amt");
            }
        }
        public Int16 SINV_HDR_OtherTax_ID
        {
            get
            {
                return this._SINV_HDR_OtherTax_ID;
            }
            set
            {
                this._SINV_HDR_OtherTax_ID = value;
                _UpdateFieldName.Add("SINV_HDR_OtherTax_ID");
            }
        }
        public Decimal SINV_HDR_OtherTax_Rate
        {
            get
            {
                return this._SINV_HDR_OtherTax_Rate;
            }
            set
            {
                this._SINV_HDR_OtherTax_Rate = value;
                _UpdateFieldName.Add("SINV_HDR_OtherTax_Rate");
            }
        }
        public Decimal SINV_HDR_OtherTax_Amt
        {
            get
            {
                return this._SINV_HDR_OtherTax_Amt;
            }
            set
            {
                this._SINV_HDR_OtherTax_Amt = value;
                _UpdateFieldName.Add("SINV_HDR_OtherTax_Amt");
            }
        }
        public Decimal SINV_HDR_Other_Taxable_Amt
        {
            get
            {
                return this._SINV_HDR_Other_Taxable_Amt;
            }
            set
            {
                this._SINV_HDR_Other_Taxable_Amt = value;
                _UpdateFieldName.Add("SINV_HDR_Other_Taxable_Amt");
            }
        }
        public Decimal SINV_HDR_Total_Tax_Amt
        {
            get
            {
                return this._SINV_HDR_Total_Tax_Amt;
            }
            set
            {
                this._SINV_HDR_Total_Tax_Amt = value;
                _UpdateFieldName.Add("SINV_HDR_Total_Tax_Amt");
            }
        }
        public Decimal SINV_HDR_ItemGross_Total_Amt
        {
            get
            {
                return this._SINV_HDR_ItemGross_Total_Amt;
            }
            set
            {
                this._SINV_HDR_ItemGross_Total_Amt = value;
                _UpdateFieldName.Add("SINV_HDR_ItemGross_Total_Amt");
            }
        }
        public Decimal SINV_HDR_Gross_Amt
        {
            get
            {
                return this._SINV_HDR_Gross_Amt;
            }
            set
            {
                this._SINV_HDR_Gross_Amt = value;
                _UpdateFieldName.Add("SINV_HDR_Gross_Amt");
            }
        }
        public Decimal SINV_HDR_Round_Off_Amt
        {
            get
            {
                return this._SINV_HDR_Round_Off_Amt;
            }
            set
            {
                this._SINV_HDR_Round_Off_Amt = value;
                _UpdateFieldName.Add("SINV_HDR_Round_Off_Amt");
            }
        }
        public Decimal SINV_HDR_Total_Gross_Amt
        {
            get
            {
                return this._SINV_HDR_Total_Gross_Amt;
            }
            set
            {
                this._SINV_HDR_Total_Gross_Amt = value;
                _UpdateFieldName.Add("SINV_HDR_Total_Gross_Amt");
            }
        }
        public String SINV_HDR_Gross_AmtInWords
        {
            get
            {
                return this._SINV_HDR_Gross_AmtInWords;
            }
            set
            {
                this._SINV_HDR_Gross_AmtInWords = value;
                _UpdateFieldName.Add("SINV_HDR_Gross_AmtInWords");
            }
        }
        public Decimal SINV_HDR_CreditNote_AsOn_Amt
        {
            get
            {
                return this._SINV_HDR_CreditNote_AsOn_Amt;
            }
            set
            {
                this._SINV_HDR_CreditNote_AsOn_Amt = value;
                _UpdateFieldName.Add("SINV_HDR_CreditNote_AsOn_Amt");
            }
        }
        public Decimal SINV_HDR_DebitNote_AsOn_Amt
        {
            get
            {
                return this._SINV_HDR_DebitNote_AsOn_Amt;
            }
            set
            {
                this._SINV_HDR_DebitNote_AsOn_Amt = value;
                _UpdateFieldName.Add("SINV_HDR_DebitNote_AsOn_Amt");
            }
        }
        public Decimal SINV_HDR_TDS_Rate
        {
            get
            {
                return this._SINV_HDR_TDS_Rate;
            }
            set
            {
                this._SINV_HDR_TDS_Rate = value;
                _UpdateFieldName.Add("SINV_HDR_TDS_Rate");
            }
        }
        public Decimal SINV_HDR_TDS_Amt
        {
            get
            {
                return this._SINV_HDR_TDS_Amt;
            }
            set
            {
                this._SINV_HDR_TDS_Amt = value;
                _UpdateFieldName.Add("SINV_HDR_TDS_Amt");
            }
        }
        public Decimal SINV_HDR_Paid_AsOn_Amt
        {
            get
            {
                return this._SINV_HDR_Paid_AsOn_Amt;
            }
            set
            {
                this._SINV_HDR_Paid_AsOn_Amt = value;
                _UpdateFieldName.Add("SINV_HDR_Paid_AsOn_Amt");
            }
        }
        public Decimal SINV_HDR_Outstanding_AsOn_Amt
        {
            get
            {
                return this._SINV_HDR_Outstanding_AsOn_Amt;
            }
            set
            {
                this._SINV_HDR_Outstanding_AsOn_Amt = value;
                _UpdateFieldName.Add("SINV_HDR_Outstanding_AsOn_Amt");
            }
        }

        #endregion
        #region Genric Methods
        public string Insert_Update(M_AT_Sales_Inv_AHDRBO sObject)
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

// ObjAT_SINVHDR.SINVHDR_ID=ObjAT_SINVHDR.SINVHDR_ID;
// ObjAT_SINVHDR.Fk_PIHDR_ID=ObjAT_SINVHDR.Fk_PIHDR_ID;
// ObjAT_SINVHDR.Fk_Company_ID=ObjAT_SINVHDR.Fk_Company_ID;
// ObjAT_SINVHDR.Fk_Branch_ID=ObjAT_SINVHDR.Fk_Branch_ID;
// ObjAT_SINVHDR.Fk_Year_ID=ObjAT_SINVHDR.Fk_Year_ID;
// ObjAT_SINVHDR.Fk_Currency_ID=ObjAT_SINVHDR.Fk_Currency_ID;
// ObjAT_SINVHDR.Rec_Created_In=ObjAT_SINVHDR.Rec_Created_In;
// ObjAT_SINVHDR.Rec_CreatedBy_ID=ObjAT_SINVHDR.Rec_CreatedBy_ID;
// ObjAT_SINVHDR.Rec_CreatedFor_ID=ObjAT_SINVHDR.Rec_CreatedFor_ID;
// ObjAT_SINVHDR.SINV_CreationType=ObjAT_SINVHDR.SINV_CreationType;
// ObjAT_SINVHDR.SINV_Type=ObjAT_SINVHDR.SINV_Type;
// ObjAT_SINVHDR.SINV_Category=ObjAT_SINVHDR.SINV_Category;
// ObjAT_SINVHDR.SINV_Taxtype=ObjAT_SINVHDR.SINV_Taxtype;
// ObjAT_SINVHDR.SINV_No=ObjAT_SINVHDR.SINV_No;
// ObjAT_SINVHDR.SINV_DT=ObjAT_SINVHDR.SINV_DT;
// ObjAT_SINVHDR.Fk_CustomerID=ObjAT_SINVHDR.Fk_CustomerID;
// ObjAT_SINVHDR.SINV_CreditDays=ObjAT_SINVHDR.SINV_CreditDays;
// ObjAT_SINVHDR.SINV_DueDT=ObjAT_SINVHDR.SINV_DueDT;
// ObjAT_SINVHDR.SINV_State_ID=ObjAT_SINVHDR.SINV_State_ID;
// ObjAT_SINVHDR.SINV_PONo=ObjAT_SINVHDR.SINV_PONo;
// ObjAT_SINVHDR.SINV_PO_DT=ObjAT_SINVHDR.SINV_PO_DT;
// ObjAT_SINVHDR.SINV_BillTo_CompanyName=ObjAT_SINVHDR.SINV_BillTo_CompanyName;
// ObjAT_SINVHDR.SINV_BillTo_ContactPersone=ObjAT_SINVHDR.SINV_BillTo_ContactPersone;
// ObjAT_SINVHDR.SINV_BillTo_CP_MobileNo=ObjAT_SINVHDR.SINV_BillTo_CP_MobileNo;
// ObjAT_SINVHDR.SINV_BillTo_Add1=ObjAT_SINVHDR.SINV_BillTo_Add1;
// ObjAT_SINVHDR.SINV_BillTo_Add2=ObjAT_SINVHDR.SINV_BillTo_Add2;
// ObjAT_SINVHDR.SINV_BillTo_Add3=ObjAT_SINVHDR.SINV_BillTo_Add3;
// ObjAT_SINVHDR.SINV_BillTo_Pincode=ObjAT_SINVHDR.SINV_BillTo_Pincode;
// ObjAT_SINVHDR.SINV_BillTo_Area=ObjAT_SINVHDR.SINV_BillTo_Area;
// ObjAT_SINVHDR.SINV_BillTo_City=ObjAT_SINVHDR.SINV_BillTo_City;
// ObjAT_SINVHDR.SINV_BillTo_State_ID=ObjAT_SINVHDR.SINV_BillTo_State_ID;
// ObjAT_SINVHDR.SINV_BillTo_Country=ObjAT_SINVHDR.SINV_BillTo_Country;
// ObjAT_SINVHDR.SINV_BillTo_GSTNo=ObjAT_SINVHDR.SINV_BillTo_GSTNo;
// ObjAT_SINVHDR.SINV_BillTo_PANNO=ObjAT_SINVHDR.SINV_BillTo_PANNO;
// ObjAT_SINVHDR.SINV_ShippTo_CompanyName=ObjAT_SINVHDR.SINV_ShippTo_CompanyName;
// ObjAT_SINVHDR.SINV_ShippTo_ContactPersone=ObjAT_SINVHDR.SINV_ShippTo_ContactPersone;
// ObjAT_SINVHDR.SINV_ShippTo_CP_MobileNo=ObjAT_SINVHDR.SINV_ShippTo_CP_MobileNo;
// ObjAT_SINVHDR.SINV_ShippTo_Add1=ObjAT_SINVHDR.SINV_ShippTo_Add1;
// ObjAT_SINVHDR.SINV_ShippTo_Add2=ObjAT_SINVHDR.SINV_ShippTo_Add2;
// ObjAT_SINVHDR.SINV_ShippTo_Add3=ObjAT_SINVHDR.SINV_ShippTo_Add3;
// ObjAT_SINVHDR.SINV_ShippTo_Pincode=ObjAT_SINVHDR.SINV_ShippTo_Pincode;
// ObjAT_SINVHDR.SINV_ShippTo_Area=ObjAT_SINVHDR.SINV_ShippTo_Area;
// ObjAT_SINVHDR.SINV_ShippTo_City=ObjAT_SINVHDR.SINV_ShippTo_City;
// ObjAT_SINVHDR.SINV_ShippTo_State_ID=ObjAT_SINVHDR.SINV_ShippTo_State_ID;
// ObjAT_SINVHDR.SINV_ShippTo_Country=ObjAT_SINVHDR.SINV_ShippTo_Country;
// ObjAT_SINVHDR.SINV_ShippTo_GSTNo=ObjAT_SINVHDR.SINV_ShippTo_GSTNo;
// ObjAT_SINVHDR.SINV_ShippTo_PANNO=ObjAT_SINVHDR.SINV_ShippTo_PANNO;
// ObjAT_SINVHDR.SINV_ShippedFrom_CompanyName=ObjAT_SINVHDR.SINV_ShippedFrom_CompanyName;
// ObjAT_SINVHDR.SINV_ShippedFrom_ContactPersone=ObjAT_SINVHDR.SINV_ShippedFrom_ContactPersone;
// ObjAT_SINVHDR.SINV_ShippedFrom_CP_MobileNo=ObjAT_SINVHDR.SINV_ShippedFrom_CP_MobileNo;
// ObjAT_SINVHDR.SINV_ShippedFrom_Add1=ObjAT_SINVHDR.SINV_ShippedFrom_Add1;
// ObjAT_SINVHDR.SINV_ShippedFrom_Add2=ObjAT_SINVHDR.SINV_ShippedFrom_Add2;
// ObjAT_SINVHDR.SINV_ShippedFrom_Add3=ObjAT_SINVHDR.SINV_ShippedFrom_Add3;
// ObjAT_SINVHDR.SINV_ShippedFrom_Pincode=ObjAT_SINVHDR.SINV_ShippedFrom_Pincode;
// ObjAT_SINVHDR.SINV_ShippedFrom_Area=ObjAT_SINVHDR.SINV_ShippedFrom_Area;
// ObjAT_SINVHDR.SINV_ShippedFrom_City=ObjAT_SINVHDR.SINV_ShippedFrom_City;
// ObjAT_SINVHDR.SINV_ShippedFrom_State_ID=ObjAT_SINVHDR.SINV_ShippedFrom_State_ID;
// ObjAT_SINVHDR.SINV_ShippedFrom_Country=ObjAT_SINVHDR.SINV_ShippedFrom_Country;
// ObjAT_SINVHDR.SINV_ShippedFrom_GSTNo=ObjAT_SINVHDR.SINV_ShippedFrom_GSTNo;
// ObjAT_SINVHDR.SINV_ShippedFrom_PANNO=ObjAT_SINVHDR.SINV_ShippedFrom_PANNO;
// ObjAT_SINVHDR.SINV_PaymentTerms=ObjAT_SINVHDR.SINV_PaymentTerms;
// ObjAT_SINVHDR.SINV_DelvieryPeriod=ObjAT_SINVHDR.SINV_DelvieryPeriod;
// ObjAT_SINVHDR.SINV_DeliveryCharges=ObjAT_SINVHDR.SINV_DeliveryCharges;
// ObjAT_SINVHDR.SINV_ExciseDuty=ObjAT_SINVHDR.SINV_ExciseDuty;
// ObjAT_SINVHDR.SINV_CompletionPeriod=ObjAT_SINVHDR.SINV_CompletionPeriod;
// ObjAT_SINVHDR.SINV_ModeOfDispatch=ObjAT_SINVHDR.SINV_ModeOfDispatch;
// ObjAT_SINVHDR.SINV_TranspoterName=ObjAT_SINVHDR.SINV_TranspoterName;
// ObjAT_SINVHDR.SINV_VehicleNumber=ObjAT_SINVHDR.SINV_VehicleNumber;
// ObjAT_SINVHDR.SINV_PlaceOfDelivery=ObjAT_SINVHDR.SINV_PlaceOfDelivery;
// ObjAT_SINVHDR.SINV_FreigthCharge_Txt=ObjAT_SINVHDR.SINV_FreigthCharge_Txt;
// ObjAT_SINVHDR.SINV_Insurance_Txt=ObjAT_SINVHDR.SINV_Insurance_Txt;
// ObjAT_SINVHDR.SINV_Remark=ObjAT_SINVHDR.SINV_Remark;
// ObjAT_SINVHDR.SINV_L1AuthorizeID=ObjAT_SINVHDR.SINV_L1AuthorizeID;
// ObjAT_SINVHDR.SINV_L1AuthorizeBy=ObjAT_SINVHDR.SINV_L1AuthorizeBy;
// ObjAT_SINVHDR.SINV_L1AuthorizeDT=ObjAT_SINVHDR.SINV_L1AuthorizeDT;
// ObjAT_SINVHDR.SINV_L2AuthorizeID=ObjAT_SINVHDR.SINV_L2AuthorizeID;
// ObjAT_SINVHDR.SINV_L2AuthorizeBy=ObjAT_SINVHDR.SINV_L2AuthorizeBy;
// ObjAT_SINVHDR.SINV_L2AuthorizeDT=ObjAT_SINVHDR.SINV_L2AuthorizeDT;
// ObjAT_SINVHDR.SINV_AuthRemark=ObjAT_SINVHDR.SINV_AuthRemark;
// ObjAT_SINVHDR.SINV_DTL_CNT=ObjAT_SINVHDR.SINV_DTL_CNT;
// ObjAT_SINVHDR.MDBSC_RowStatus=ObjAT_SINVHDR.MDBSC_RowStatus;
// ObjAT_SINVHDR.MDBSC_RowCreatedByUser_ID=ObjAT_SINVHDR.MDBSC_RowCreatedByUser_ID;
// ObjAT_SINVHDR.MDBSC_RowCreatedByUserName=ObjAT_SINVHDR.MDBSC_RowCreatedByUserName;
// ObjAT_SINVHDR.MDBSC_RowCreatedOn_DT=ObjAT_SINVHDR.MDBSC_RowCreatedOn_DT;
// ObjAT_SINVHDR.MDBSC_RowLupdnByUser_ID=ObjAT_SINVHDR.MDBSC_RowLupdnByUser_ID;
// ObjAT_SINVHDR.MDBSC_RowLupdnUserName=ObjAT_SINVHDR.MDBSC_RowLupdnUserName;
// ObjAT_SINVHDR.MDBSC_RowLupdnOn_DT=ObjAT_SINVHDR.MDBSC_RowLupdnOn_DT;
// ObjAT_SINVHDR.SINV_HDR_BasicAmt=ObjAT_SINVHDR.SINV_HDR_BasicAmt;
// ObjAT_SINVHDR.SINV_HDR_DiscountRate=ObjAT_SINVHDR.SINV_HDR_DiscountRate;
// ObjAT_SINVHDR.SINV_HDR_DiscountAmt=ObjAT_SINVHDR.SINV_HDR_DiscountAmt;
// ObjAT_SINVHDR.SINV_HDR_Net_Amt=ObjAT_SINVHDR.SINV_HDR_Net_Amt;
// ObjAT_SINVHDR.SINV_HDR_Freight_Charges=ObjAT_SINVHDR.SINV_HDR_Freight_Charges;
// ObjAT_SINVHDR.SINV_HDR_Loading_N_Packing_Charges=ObjAT_SINVHDR.SINV_HDR_Loading_N_Packing_Charges;
// ObjAT_SINVHDR.SINV_HDR_Insurance_Charges=ObjAT_SINVHDR.SINV_HDR_Insurance_Charges;
// ObjAT_SINVHDR.SINV_HDR_Other_Charges_Txt=ObjAT_SINVHDR.SINV_HDR_Other_Charges_Txt;
// ObjAT_SINVHDR.SINV_HDR_Other_Charges_Amt=ObjAT_SINVHDR.SINV_HDR_Other_Charges_Amt;
// ObjAT_SINVHDR.SINV_HDR_Taxable_Amt=ObjAT_SINVHDR.SINV_HDR_Taxable_Amt;
// ObjAT_SINVHDR.SINV_HDR_CGST_Amt=ObjAT_SINVHDR.SINV_HDR_CGST_Amt;
// ObjAT_SINVHDR.SINV_HDR_CGST_Taxable_Amt=ObjAT_SINVHDR.SINV_HDR_CGST_Taxable_Amt;
// ObjAT_SINVHDR.SINV_HDR_SGST_Amt=ObjAT_SINVHDR.SINV_HDR_SGST_Amt;
// ObjAT_SINVHDR.SINV_HDR_SGST_Taxable_Amt=ObjAT_SINVHDR.SINV_HDR_SGST_Taxable_Amt;
// ObjAT_SINVHDR.SINV_HDR_IGST_Amt=ObjAT_SINVHDR.SINV_HDR_IGST_Amt;
// ObjAT_SINVHDR.SINV_HDR_IGST_Taxable_Amt=ObjAT_SINVHDR.SINV_HDR_IGST_Taxable_Amt;
// ObjAT_SINVHDR.SINV_HDR_CESS_Amt=ObjAT_SINVHDR.SINV_HDR_CESS_Amt;
// ObjAT_SINVHDR.SINV_HDR_CESS_Taxable_Amt=ObjAT_SINVHDR.SINV_HDR_CESS_Taxable_Amt;
// ObjAT_SINVHDR.SINV_HDR_OtherTax_ID=ObjAT_SINVHDR.SINV_HDR_OtherTax_ID;
// ObjAT_SINVHDR.SINV_HDR_OtherTax_Rate=ObjAT_SINVHDR.SINV_HDR_OtherTax_Rate;
// ObjAT_SINVHDR.SINV_HDR_OtherTax_Amt=ObjAT_SINVHDR.SINV_HDR_OtherTax_Amt;
// ObjAT_SINVHDR.SINV_HDR_Other_Taxable_Amt=ObjAT_SINVHDR.SINV_HDR_Other_Taxable_Amt;
// ObjAT_SINVHDR.SINV_HDR_Total_Tax_Amt=ObjAT_SINVHDR.SINV_HDR_Total_Tax_Amt;
// ObjAT_SINVHDR.SINV_HDR_ItemGross_Total_Amt=ObjAT_SINVHDR.SINV_HDR_ItemGross_Total_Amt;
// ObjAT_SINVHDR.SINV_HDR_Gross_Amt=ObjAT_SINVHDR.SINV_HDR_Gross_Amt;
// ObjAT_SINVHDR.SINV_HDR_Round_Off_Amt=ObjAT_SINVHDR.SINV_HDR_Round_Off_Amt;
// ObjAT_SINVHDR.SINV_HDR_Total_Gross_Amt=ObjAT_SINVHDR.SINV_HDR_Total_Gross_Amt;
// ObjAT_SINVHDR.SINV_HDR_Gross_AmtInWords=ObjAT_SINVHDR.SINV_HDR_Gross_AmtInWords;
// ObjAT_SINVHDR.SINV_HDR_CreditNote_AsOn_Amt=ObjAT_SINVHDR.SINV_HDR_CreditNote_AsOn_Amt;
// ObjAT_SINVHDR.SINV_HDR_DebitNote_AsOn_Amt=ObjAT_SINVHDR.SINV_HDR_DebitNote_AsOn_Amt;
// ObjAT_SINVHDR.SINV_HDR_TDS_Rate=ObjAT_SINVHDR.SINV_HDR_TDS_Rate;
// ObjAT_SINVHDR.SINV_HDR_TDS_Amt=ObjAT_SINVHDR.SINV_HDR_TDS_Amt;
// ObjAT_SINVHDR.SINV_HDR_Paid_AsOn_Amt=ObjAT_SINVHDR.SINV_HDR_Paid_AsOn_Amt;
// ObjAT_SINVHDR.SINV_HDR_Outstanding_AsOn_Amt=ObjAT_SINVHDR.SINV_HDR_Outstanding_AsOn_Amt;



// SINVHDR_ID.Text = "";
// Fk_PIHDR_ID.Text = "";
// Fk_Company_ID.Text = "";
// Fk_Branch_ID.Text = "";
// Fk_Year_ID.Text = "";
// Fk_Currency_ID.Text = "";
// Rec_Created_In.Text = "";
// Rec_CreatedBy_ID.Text = "";
// Rec_CreatedFor_ID.Text = "";
// SINV_CreationType.Text = "";
// SINV_Type.Text = "";
// SINV_Category.Text = "";
// SINV_Taxtype.Text = "";
// SINV_No.Text = "";
// SINV_DT.Text = "";
// Fk_CustomerID.Text = "";
// SINV_CreditDays.Text = "";
// SINV_DueDT.Text = "";
// SINV_State_ID.Text = "";
// SINV_PONo.Text = "";
// SINV_PO_DT.Text = "";
// SINV_BillTo_CompanyName.Text = "";
// SINV_BillTo_ContactPersone.Text = "";
// SINV_BillTo_CP_MobileNo.Text = "";
// SINV_BillTo_Add1.Text = "";
// SINV_BillTo_Add2.Text = "";
// SINV_BillTo_Add3.Text = "";
// SINV_BillTo_Pincode.Text = "";
// SINV_BillTo_Area.Text = "";
// SINV_BillTo_City.Text = "";
// SINV_BillTo_State_ID.Text = "";
// SINV_BillTo_Country.Text = "";
// SINV_BillTo_GSTNo.Text = "";
// SINV_BillTo_PANNO.Text = "";
// SINV_ShippTo_CompanyName.Text = "";
// SINV_ShippTo_ContactPersone.Text = "";
// SINV_ShippTo_CP_MobileNo.Text = "";
// SINV_ShippTo_Add1.Text = "";
// SINV_ShippTo_Add2.Text = "";
// SINV_ShippTo_Add3.Text = "";
// SINV_ShippTo_Pincode.Text = "";
// SINV_ShippTo_Area.Text = "";
// SINV_ShippTo_City.Text = "";
// SINV_ShippTo_State_ID.Text = "";
// SINV_ShippTo_Country.Text = "";
// SINV_ShippTo_GSTNo.Text = "";
// SINV_ShippTo_PANNO.Text = "";
// SINV_ShippedFrom_CompanyName.Text = "";
// SINV_ShippedFrom_ContactPersone.Text = "";
// SINV_ShippedFrom_CP_MobileNo.Text = "";
// SINV_ShippedFrom_Add1.Text = "";
// SINV_ShippedFrom_Add2.Text = "";
// SINV_ShippedFrom_Add3.Text = "";
// SINV_ShippedFrom_Pincode.Text = "";
// SINV_ShippedFrom_Area.Text = "";
// SINV_ShippedFrom_City.Text = "";
// SINV_ShippedFrom_State_ID.Text = "";
// SINV_ShippedFrom_Country.Text = "";
// SINV_ShippedFrom_GSTNo.Text = "";
// SINV_ShippedFrom_PANNO.Text = "";
// SINV_PaymentTerms.Text = "";
// SINV_DelvieryPeriod.Text = "";
// SINV_DeliveryCharges.Text = "";
// SINV_ExciseDuty.Text = "";
// SINV_CompletionPeriod.Text = "";
// SINV_ModeOfDispatch.Text = "";
// SINV_TranspoterName.Text = "";
// SINV_VehicleNumber.Text = "";
// SINV_PlaceOfDelivery.Text = "";
// SINV_FreigthCharge_Txt.Text = "";
// SINV_Insurance_Txt.Text = "";
// SINV_Remark.Text = "";
// SINV_L1AuthorizeID.Text = "";
// SINV_L1AuthorizeBy.Text = "";
// SINV_L1AuthorizeDT.Text = "";
// SINV_L2AuthorizeID.Text = "";
// SINV_L2AuthorizeBy.Text = "";
// SINV_L2AuthorizeDT.Text = "";
// SINV_AuthRemark.Text = "";
// SINV_DTL_CNT.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";
// SINV_HDR_BasicAmt.Text = "";
// SINV_HDR_DiscountRate.Text = "";
// SINV_HDR_DiscountAmt.Text = "";
// SINV_HDR_Net_Amt.Text = "";
// SINV_HDR_Freight_Charges.Text = "";
// SINV_HDR_Loading_N_Packing_Charges.Text = "";
// SINV_HDR_Insurance_Charges.Text = "";
// SINV_HDR_Other_Charges_Txt.Text = "";
// SINV_HDR_Other_Charges_Amt.Text = "";
// SINV_HDR_Taxable_Amt.Text = "";
// SINV_HDR_CGST_Amt.Text = "";
// SINV_HDR_CGST_Taxable_Amt.Text = "";
// SINV_HDR_SGST_Amt.Text = "";
// SINV_HDR_SGST_Taxable_Amt.Text = "";
// SINV_HDR_IGST_Amt.Text = "";
// SINV_HDR_IGST_Taxable_Amt.Text = "";
// SINV_HDR_CESS_Amt.Text = "";
// SINV_HDR_CESS_Taxable_Amt.Text = "";
// SINV_HDR_OtherTax_ID.Text = "";
// SINV_HDR_OtherTax_Rate.Text = "";
// SINV_HDR_OtherTax_Amt.Text = "";
// SINV_HDR_Other_Taxable_Amt.Text = "";
// SINV_HDR_Total_Tax_Amt.Text = "";
// SINV_HDR_ItemGross_Total_Amt.Text = "";
// SINV_HDR_Gross_Amt.Text = "";
// SINV_HDR_Round_Off_Amt.Text = "";
// SINV_HDR_Total_Gross_Amt.Text = "";
// SINV_HDR_Gross_AmtInWords.Text = "";
// SINV_HDR_CreditNote_AsOn_Amt.Text = "";
// SINV_HDR_DebitNote_AsOn_Amt.Text = "";
// SINV_HDR_TDS_Rate.Text = "";
// SINV_HDR_TDS_Amt.Text = "";
// SINV_HDR_Paid_AsOn_Amt.Text = "";
// SINV_HDR_Outstanding_AsOn_Amt.Text = "";



// ObjAT_SINVHDR.SINVHDR_ID=SINVHDR_ID.Text ;
// ObjAT_SINVHDR.Fk_PIHDR_ID=Fk_PIHDR_ID.Text ;
// ObjAT_SINVHDR.Fk_Company_ID=Fk_Company_ID.Text ;
// ObjAT_SINVHDR.Fk_Branch_ID=Fk_Branch_ID.Text ;
// ObjAT_SINVHDR.Fk_Year_ID=Fk_Year_ID.Text ;
// ObjAT_SINVHDR.Fk_Currency_ID=Fk_Currency_ID.Text ;
// ObjAT_SINVHDR.Rec_Created_In=Rec_Created_In.Text ;
// ObjAT_SINVHDR.Rec_CreatedBy_ID=Rec_CreatedBy_ID.Text ;
// ObjAT_SINVHDR.Rec_CreatedFor_ID=Rec_CreatedFor_ID.Text ;
// ObjAT_SINVHDR.SINV_CreationType=SINV_CreationType.Text ;
// ObjAT_SINVHDR.SINV_Type=SINV_Type.Text ;
// ObjAT_SINVHDR.SINV_Category=SINV_Category.Text ;
// ObjAT_SINVHDR.SINV_Taxtype=SINV_Taxtype.Text ;
// ObjAT_SINVHDR.SINV_No=SINV_No.Text ;
// ObjAT_SINVHDR.SINV_DT=SINV_DT.Text ;
// ObjAT_SINVHDR.Fk_CustomerID=Fk_CustomerID.Text ;
// ObjAT_SINVHDR.SINV_CreditDays=SINV_CreditDays.Text ;
// ObjAT_SINVHDR.SINV_DueDT=SINV_DueDT.Text ;
// ObjAT_SINVHDR.SINV_State_ID=SINV_State_ID.Text ;
// ObjAT_SINVHDR.SINV_PONo=SINV_PONo.Text ;
// ObjAT_SINVHDR.SINV_PO_DT=SINV_PO_DT.Text ;
// ObjAT_SINVHDR.SINV_BillTo_CompanyName=SINV_BillTo_CompanyName.Text ;
// ObjAT_SINVHDR.SINV_BillTo_ContactPersone=SINV_BillTo_ContactPersone.Text ;
// ObjAT_SINVHDR.SINV_BillTo_CP_MobileNo=SINV_BillTo_CP_MobileNo.Text ;
// ObjAT_SINVHDR.SINV_BillTo_Add1=SINV_BillTo_Add1.Text ;
// ObjAT_SINVHDR.SINV_BillTo_Add2=SINV_BillTo_Add2.Text ;
// ObjAT_SINVHDR.SINV_BillTo_Add3=SINV_BillTo_Add3.Text ;
// ObjAT_SINVHDR.SINV_BillTo_Pincode=SINV_BillTo_Pincode.Text ;
// ObjAT_SINVHDR.SINV_BillTo_Area=SINV_BillTo_Area.Text ;
// ObjAT_SINVHDR.SINV_BillTo_City=SINV_BillTo_City.Text ;
// ObjAT_SINVHDR.SINV_BillTo_State_ID=SINV_BillTo_State_ID.Text ;
// ObjAT_SINVHDR.SINV_BillTo_Country=SINV_BillTo_Country.Text ;
// ObjAT_SINVHDR.SINV_BillTo_GSTNo=SINV_BillTo_GSTNo.Text ;
// ObjAT_SINVHDR.SINV_BillTo_PANNO=SINV_BillTo_PANNO.Text ;
// ObjAT_SINVHDR.SINV_ShippTo_CompanyName=SINV_ShippTo_CompanyName.Text ;
// ObjAT_SINVHDR.SINV_ShippTo_ContactPersone=SINV_ShippTo_ContactPersone.Text ;
// ObjAT_SINVHDR.SINV_ShippTo_CP_MobileNo=SINV_ShippTo_CP_MobileNo.Text ;
// ObjAT_SINVHDR.SINV_ShippTo_Add1=SINV_ShippTo_Add1.Text ;
// ObjAT_SINVHDR.SINV_ShippTo_Add2=SINV_ShippTo_Add2.Text ;
// ObjAT_SINVHDR.SINV_ShippTo_Add3=SINV_ShippTo_Add3.Text ;
// ObjAT_SINVHDR.SINV_ShippTo_Pincode=SINV_ShippTo_Pincode.Text ;
// ObjAT_SINVHDR.SINV_ShippTo_Area=SINV_ShippTo_Area.Text ;
// ObjAT_SINVHDR.SINV_ShippTo_City=SINV_ShippTo_City.Text ;
// ObjAT_SINVHDR.SINV_ShippTo_State_ID=SINV_ShippTo_State_ID.Text ;
// ObjAT_SINVHDR.SINV_ShippTo_Country=SINV_ShippTo_Country.Text ;
// ObjAT_SINVHDR.SINV_ShippTo_GSTNo=SINV_ShippTo_GSTNo.Text ;
// ObjAT_SINVHDR.SINV_ShippTo_PANNO=SINV_ShippTo_PANNO.Text ;
// ObjAT_SINVHDR.SINV_ShippedFrom_CompanyName=SINV_ShippedFrom_CompanyName.Text ;
// ObjAT_SINVHDR.SINV_ShippedFrom_ContactPersone=SINV_ShippedFrom_ContactPersone.Text ;
// ObjAT_SINVHDR.SINV_ShippedFrom_CP_MobileNo=SINV_ShippedFrom_CP_MobileNo.Text ;
// ObjAT_SINVHDR.SINV_ShippedFrom_Add1=SINV_ShippedFrom_Add1.Text ;
// ObjAT_SINVHDR.SINV_ShippedFrom_Add2=SINV_ShippedFrom_Add2.Text ;
// ObjAT_SINVHDR.SINV_ShippedFrom_Add3=SINV_ShippedFrom_Add3.Text ;
// ObjAT_SINVHDR.SINV_ShippedFrom_Pincode=SINV_ShippedFrom_Pincode.Text ;
// ObjAT_SINVHDR.SINV_ShippedFrom_Area=SINV_ShippedFrom_Area.Text ;
// ObjAT_SINVHDR.SINV_ShippedFrom_City=SINV_ShippedFrom_City.Text ;
// ObjAT_SINVHDR.SINV_ShippedFrom_State_ID=SINV_ShippedFrom_State_ID.Text ;
// ObjAT_SINVHDR.SINV_ShippedFrom_Country=SINV_ShippedFrom_Country.Text ;
// ObjAT_SINVHDR.SINV_ShippedFrom_GSTNo=SINV_ShippedFrom_GSTNo.Text ;
// ObjAT_SINVHDR.SINV_ShippedFrom_PANNO=SINV_ShippedFrom_PANNO.Text ;
// ObjAT_SINVHDR.SINV_PaymentTerms=SINV_PaymentTerms.Text ;
// ObjAT_SINVHDR.SINV_DelvieryPeriod=SINV_DelvieryPeriod.Text ;
// ObjAT_SINVHDR.SINV_DeliveryCharges=SINV_DeliveryCharges.Text ;
// ObjAT_SINVHDR.SINV_ExciseDuty=SINV_ExciseDuty.Text ;
// ObjAT_SINVHDR.SINV_CompletionPeriod=SINV_CompletionPeriod.Text ;
// ObjAT_SINVHDR.SINV_ModeOfDispatch=SINV_ModeOfDispatch.Text ;
// ObjAT_SINVHDR.SINV_TranspoterName=SINV_TranspoterName.Text ;
// ObjAT_SINVHDR.SINV_VehicleNumber=SINV_VehicleNumber.Text ;
// ObjAT_SINVHDR.SINV_PlaceOfDelivery=SINV_PlaceOfDelivery.Text ;
// ObjAT_SINVHDR.SINV_FreigthCharge_Txt=SINV_FreigthCharge_Txt.Text ;
// ObjAT_SINVHDR.SINV_Insurance_Txt=SINV_Insurance_Txt.Text ;
// ObjAT_SINVHDR.SINV_Remark=SINV_Remark.Text ;
// ObjAT_SINVHDR.SINV_L1AuthorizeID=SINV_L1AuthorizeID.Text ;
// ObjAT_SINVHDR.SINV_L1AuthorizeBy=SINV_L1AuthorizeBy.Text ;
// ObjAT_SINVHDR.SINV_L1AuthorizeDT=SINV_L1AuthorizeDT.Text ;
// ObjAT_SINVHDR.SINV_L2AuthorizeID=SINV_L2AuthorizeID.Text ;
// ObjAT_SINVHDR.SINV_L2AuthorizeBy=SINV_L2AuthorizeBy.Text ;
// ObjAT_SINVHDR.SINV_L2AuthorizeDT=SINV_L2AuthorizeDT.Text ;
// ObjAT_SINVHDR.SINV_AuthRemark=SINV_AuthRemark.Text ;
// ObjAT_SINVHDR.SINV_DTL_CNT=SINV_DTL_CNT.Text ;
// ObjAT_SINVHDR.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_SINVHDR.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_SINVHDR.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_SINVHDR.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_SINVHDR.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_SINVHDR.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_SINVHDR.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;
// ObjAT_SINVHDR.SINV_HDR_BasicAmt=SINV_HDR_BasicAmt.Text ;
// ObjAT_SINVHDR.SINV_HDR_DiscountRate=SINV_HDR_DiscountRate.Text ;
// ObjAT_SINVHDR.SINV_HDR_DiscountAmt=SINV_HDR_DiscountAmt.Text ;
// ObjAT_SINVHDR.SINV_HDR_Net_Amt=SINV_HDR_Net_Amt.Text ;
// ObjAT_SINVHDR.SINV_HDR_Freight_Charges=SINV_HDR_Freight_Charges.Text ;
// ObjAT_SINVHDR.SINV_HDR_Loading_N_Packing_Charges=SINV_HDR_Loading_N_Packing_Charges.Text ;
// ObjAT_SINVHDR.SINV_HDR_Insurance_Charges=SINV_HDR_Insurance_Charges.Text ;
// ObjAT_SINVHDR.SINV_HDR_Other_Charges_Txt=SINV_HDR_Other_Charges_Txt.Text ;
// ObjAT_SINVHDR.SINV_HDR_Other_Charges_Amt=SINV_HDR_Other_Charges_Amt.Text ;
// ObjAT_SINVHDR.SINV_HDR_Taxable_Amt=SINV_HDR_Taxable_Amt.Text ;
// ObjAT_SINVHDR.SINV_HDR_CGST_Amt=SINV_HDR_CGST_Amt.Text ;
// ObjAT_SINVHDR.SINV_HDR_CGST_Taxable_Amt=SINV_HDR_CGST_Taxable_Amt.Text ;
// ObjAT_SINVHDR.SINV_HDR_SGST_Amt=SINV_HDR_SGST_Amt.Text ;
// ObjAT_SINVHDR.SINV_HDR_SGST_Taxable_Amt=SINV_HDR_SGST_Taxable_Amt.Text ;
// ObjAT_SINVHDR.SINV_HDR_IGST_Amt=SINV_HDR_IGST_Amt.Text ;
// ObjAT_SINVHDR.SINV_HDR_IGST_Taxable_Amt=SINV_HDR_IGST_Taxable_Amt.Text ;
// ObjAT_SINVHDR.SINV_HDR_CESS_Amt=SINV_HDR_CESS_Amt.Text ;
// ObjAT_SINVHDR.SINV_HDR_CESS_Taxable_Amt=SINV_HDR_CESS_Taxable_Amt.Text ;
// ObjAT_SINVHDR.SINV_HDR_OtherTax_ID=SINV_HDR_OtherTax_ID.Text ;
// ObjAT_SINVHDR.SINV_HDR_OtherTax_Rate=SINV_HDR_OtherTax_Rate.Text ;
// ObjAT_SINVHDR.SINV_HDR_OtherTax_Amt=SINV_HDR_OtherTax_Amt.Text ;
// ObjAT_SINVHDR.SINV_HDR_Other_Taxable_Amt=SINV_HDR_Other_Taxable_Amt.Text ;
// ObjAT_SINVHDR.SINV_HDR_Total_Tax_Amt=SINV_HDR_Total_Tax_Amt.Text ;
// ObjAT_SINVHDR.SINV_HDR_ItemGross_Total_Amt=SINV_HDR_ItemGross_Total_Amt.Text ;
// ObjAT_SINVHDR.SINV_HDR_Gross_Amt=SINV_HDR_Gross_Amt.Text ;
// ObjAT_SINVHDR.SINV_HDR_Round_Off_Amt=SINV_HDR_Round_Off_Amt.Text ;
// ObjAT_SINVHDR.SINV_HDR_Total_Gross_Amt=SINV_HDR_Total_Gross_Amt.Text ;
// ObjAT_SINVHDR.SINV_HDR_Gross_AmtInWords=SINV_HDR_Gross_AmtInWords.Text ;
// ObjAT_SINVHDR.SINV_HDR_CreditNote_AsOn_Amt=SINV_HDR_CreditNote_AsOn_Amt.Text ;
// ObjAT_SINVHDR.SINV_HDR_DebitNote_AsOn_Amt=SINV_HDR_DebitNote_AsOn_Amt.Text ;
// ObjAT_SINVHDR.SINV_HDR_TDS_Rate=SINV_HDR_TDS_Rate.Text ;
// ObjAT_SINVHDR.SINV_HDR_TDS_Amt=SINV_HDR_TDS_Amt.Text ;
// ObjAT_SINVHDR.SINV_HDR_Paid_AsOn_Amt=SINV_HDR_Paid_AsOn_Amt.Text ;
// ObjAT_SINVHDR.SINV_HDR_Outstanding_AsOn_Amt=SINV_HDR_Outstanding_AsOn_Amt.Text ;



// SINVHDR_ID.Text =  dt.Rows[0]["SINVHDR_ID"].ToString();
// Fk_PIHDR_ID.Text =  dt.Rows[0]["Fk_PIHDR_ID"].ToString();
// Fk_Company_ID.Text =  dt.Rows[0]["Fk_Company_ID"].ToString();
// Fk_Branch_ID.Text =  dt.Rows[0]["Fk_Branch_ID"].ToString();
// Fk_Year_ID.Text =  dt.Rows[0]["Fk_Year_ID"].ToString();
// Fk_Currency_ID.Text =  dt.Rows[0]["Fk_Currency_ID"].ToString();
// Rec_Created_In.Text =  dt.Rows[0]["Rec_Created_In"].ToString();
// Rec_CreatedBy_ID.Text =  dt.Rows[0]["Rec_CreatedBy_ID"].ToString();
// Rec_CreatedFor_ID.Text =  dt.Rows[0]["Rec_CreatedFor_ID"].ToString();
// SINV_CreationType.Text =  dt.Rows[0]["SINV_CreationType"].ToString();
// SINV_Type.Text =  dt.Rows[0]["SINV_Type"].ToString();
// SINV_Category.Text =  dt.Rows[0]["SINV_Category"].ToString();
// SINV_Taxtype.Text =  dt.Rows[0]["SINV_Taxtype"].ToString();
// SINV_No.Text =  dt.Rows[0]["SINV_No"].ToString();
// SINV_DT.Text =  dt.Rows[0]["SINV_DT"].ToString();
// Fk_CustomerID.Text =  dt.Rows[0]["Fk_CustomerID"].ToString();
// SINV_CreditDays.Text =  dt.Rows[0]["SINV_CreditDays"].ToString();
// SINV_DueDT.Text =  dt.Rows[0]["SINV_DueDT"].ToString();
// SINV_State_ID.Text =  dt.Rows[0]["SINV_State_ID"].ToString();
// SINV_PONo.Text =  dt.Rows[0]["SINV_PONo"].ToString();
// SINV_PO_DT.Text =  dt.Rows[0]["SINV_PO_DT"].ToString();
// SINV_BillTo_CompanyName.Text =  dt.Rows[0]["SINV_BillTo_CompanyName"].ToString();
// SINV_BillTo_ContactPersone.Text =  dt.Rows[0]["SINV_BillTo_ContactPersone"].ToString();
// SINV_BillTo_CP_MobileNo.Text =  dt.Rows[0]["SINV_BillTo_CP_MobileNo"].ToString();
// SINV_BillTo_Add1.Text =  dt.Rows[0]["SINV_BillTo_Add1"].ToString();
// SINV_BillTo_Add2.Text =  dt.Rows[0]["SINV_BillTo_Add2"].ToString();
// SINV_BillTo_Add3.Text =  dt.Rows[0]["SINV_BillTo_Add3"].ToString();
// SINV_BillTo_Pincode.Text =  dt.Rows[0]["SINV_BillTo_Pincode"].ToString();
// SINV_BillTo_Area.Text =  dt.Rows[0]["SINV_BillTo_Area"].ToString();
// SINV_BillTo_City.Text =  dt.Rows[0]["SINV_BillTo_City"].ToString();
// SINV_BillTo_State_ID.Text =  dt.Rows[0]["SINV_BillTo_State_ID"].ToString();
// SINV_BillTo_Country.Text =  dt.Rows[0]["SINV_BillTo_Country"].ToString();
// SINV_BillTo_GSTNo.Text =  dt.Rows[0]["SINV_BillTo_GSTNo"].ToString();
// SINV_BillTo_PANNO.Text =  dt.Rows[0]["SINV_BillTo_PANNO"].ToString();
// SINV_ShippTo_CompanyName.Text =  dt.Rows[0]["SINV_ShippTo_CompanyName"].ToString();
// SINV_ShippTo_ContactPersone.Text =  dt.Rows[0]["SINV_ShippTo_ContactPersone"].ToString();
// SINV_ShippTo_CP_MobileNo.Text =  dt.Rows[0]["SINV_ShippTo_CP_MobileNo"].ToString();
// SINV_ShippTo_Add1.Text =  dt.Rows[0]["SINV_ShippTo_Add1"].ToString();
// SINV_ShippTo_Add2.Text =  dt.Rows[0]["SINV_ShippTo_Add2"].ToString();
// SINV_ShippTo_Add3.Text =  dt.Rows[0]["SINV_ShippTo_Add3"].ToString();
// SINV_ShippTo_Pincode.Text =  dt.Rows[0]["SINV_ShippTo_Pincode"].ToString();
// SINV_ShippTo_Area.Text =  dt.Rows[0]["SINV_ShippTo_Area"].ToString();
// SINV_ShippTo_City.Text =  dt.Rows[0]["SINV_ShippTo_City"].ToString();
// SINV_ShippTo_State_ID.Text =  dt.Rows[0]["SINV_ShippTo_State_ID"].ToString();
// SINV_ShippTo_Country.Text =  dt.Rows[0]["SINV_ShippTo_Country"].ToString();
// SINV_ShippTo_GSTNo.Text =  dt.Rows[0]["SINV_ShippTo_GSTNo"].ToString();
// SINV_ShippTo_PANNO.Text =  dt.Rows[0]["SINV_ShippTo_PANNO"].ToString();
// SINV_ShippedFrom_CompanyName.Text =  dt.Rows[0]["SINV_ShippedFrom_CompanyName"].ToString();
// SINV_ShippedFrom_ContactPersone.Text =  dt.Rows[0]["SINV_ShippedFrom_ContactPersone"].ToString();
// SINV_ShippedFrom_CP_MobileNo.Text =  dt.Rows[0]["SINV_ShippedFrom_CP_MobileNo"].ToString();
// SINV_ShippedFrom_Add1.Text =  dt.Rows[0]["SINV_ShippedFrom_Add1"].ToString();
// SINV_ShippedFrom_Add2.Text =  dt.Rows[0]["SINV_ShippedFrom_Add2"].ToString();
// SINV_ShippedFrom_Add3.Text =  dt.Rows[0]["SINV_ShippedFrom_Add3"].ToString();
// SINV_ShippedFrom_Pincode.Text =  dt.Rows[0]["SINV_ShippedFrom_Pincode"].ToString();
// SINV_ShippedFrom_Area.Text =  dt.Rows[0]["SINV_ShippedFrom_Area"].ToString();
// SINV_ShippedFrom_City.Text =  dt.Rows[0]["SINV_ShippedFrom_City"].ToString();
// SINV_ShippedFrom_State_ID.Text =  dt.Rows[0]["SINV_ShippedFrom_State_ID"].ToString();
// SINV_ShippedFrom_Country.Text =  dt.Rows[0]["SINV_ShippedFrom_Country"].ToString();
// SINV_ShippedFrom_GSTNo.Text =  dt.Rows[0]["SINV_ShippedFrom_GSTNo"].ToString();
// SINV_ShippedFrom_PANNO.Text =  dt.Rows[0]["SINV_ShippedFrom_PANNO"].ToString();
// SINV_PaymentTerms.Text =  dt.Rows[0]["SINV_PaymentTerms"].ToString();
// SINV_DelvieryPeriod.Text =  dt.Rows[0]["SINV_DelvieryPeriod"].ToString();
// SINV_DeliveryCharges.Text =  dt.Rows[0]["SINV_DeliveryCharges"].ToString();
// SINV_ExciseDuty.Text =  dt.Rows[0]["SINV_ExciseDuty"].ToString();
// SINV_CompletionPeriod.Text =  dt.Rows[0]["SINV_CompletionPeriod"].ToString();
// SINV_ModeOfDispatch.Text =  dt.Rows[0]["SINV_ModeOfDispatch"].ToString();
// SINV_TranspoterName.Text =  dt.Rows[0]["SINV_TranspoterName"].ToString();
// SINV_VehicleNumber.Text =  dt.Rows[0]["SINV_VehicleNumber"].ToString();
// SINV_PlaceOfDelivery.Text =  dt.Rows[0]["SINV_PlaceOfDelivery"].ToString();
// SINV_FreigthCharge_Txt.Text =  dt.Rows[0]["SINV_FreigthCharge_Txt"].ToString();
// SINV_Insurance_Txt.Text =  dt.Rows[0]["SINV_Insurance_Txt"].ToString();
// SINV_Remark.Text =  dt.Rows[0]["SINV_Remark"].ToString();
// SINV_L1AuthorizeID.Text =  dt.Rows[0]["SINV_L1AuthorizeID"].ToString();
// SINV_L1AuthorizeBy.Text =  dt.Rows[0]["SINV_L1AuthorizeBy"].ToString();
// SINV_L1AuthorizeDT.Text =  dt.Rows[0]["SINV_L1AuthorizeDT"].ToString();
// SINV_L2AuthorizeID.Text =  dt.Rows[0]["SINV_L2AuthorizeID"].ToString();
// SINV_L2AuthorizeBy.Text =  dt.Rows[0]["SINV_L2AuthorizeBy"].ToString();
// SINV_L2AuthorizeDT.Text =  dt.Rows[0]["SINV_L2AuthorizeDT"].ToString();
// SINV_AuthRemark.Text =  dt.Rows[0]["SINV_AuthRemark"].ToString();
// SINV_DTL_CNT.Text =  dt.Rows[0]["SINV_DTL_CNT"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
// SINV_HDR_BasicAmt.Text =  dt.Rows[0]["SINV_HDR_BasicAmt"].ToString();
// SINV_HDR_DiscountRate.Text =  dt.Rows[0]["SINV_HDR_DiscountRate"].ToString();
// SINV_HDR_DiscountAmt.Text =  dt.Rows[0]["SINV_HDR_DiscountAmt"].ToString();
// SINV_HDR_Net_Amt.Text =  dt.Rows[0]["SINV_HDR_Net_Amt"].ToString();
// SINV_HDR_Freight_Charges.Text =  dt.Rows[0]["SINV_HDR_Freight_Charges"].ToString();
// SINV_HDR_Loading_N_Packing_Charges.Text =  dt.Rows[0]["SINV_HDR_Loading_N_Packing_Charges"].ToString();
// SINV_HDR_Insurance_Charges.Text =  dt.Rows[0]["SINV_HDR_Insurance_Charges"].ToString();
// SINV_HDR_Other_Charges_Txt.Text =  dt.Rows[0]["SINV_HDR_Other_Charges_Txt"].ToString();
// SINV_HDR_Other_Charges_Amt.Text =  dt.Rows[0]["SINV_HDR_Other_Charges_Amt"].ToString();
// SINV_HDR_Taxable_Amt.Text =  dt.Rows[0]["SINV_HDR_Taxable_Amt"].ToString();
// SINV_HDR_CGST_Amt.Text =  dt.Rows[0]["SINV_HDR_CGST_Amt"].ToString();
// SINV_HDR_CGST_Taxable_Amt.Text =  dt.Rows[0]["SINV_HDR_CGST_Taxable_Amt"].ToString();
// SINV_HDR_SGST_Amt.Text =  dt.Rows[0]["SINV_HDR_SGST_Amt"].ToString();
// SINV_HDR_SGST_Taxable_Amt.Text =  dt.Rows[0]["SINV_HDR_SGST_Taxable_Amt"].ToString();
// SINV_HDR_IGST_Amt.Text =  dt.Rows[0]["SINV_HDR_IGST_Amt"].ToString();
// SINV_HDR_IGST_Taxable_Amt.Text =  dt.Rows[0]["SINV_HDR_IGST_Taxable_Amt"].ToString();
// SINV_HDR_CESS_Amt.Text =  dt.Rows[0]["SINV_HDR_CESS_Amt"].ToString();
// SINV_HDR_CESS_Taxable_Amt.Text =  dt.Rows[0]["SINV_HDR_CESS_Taxable_Amt"].ToString();
// SINV_HDR_OtherTax_ID.Text =  dt.Rows[0]["SINV_HDR_OtherTax_ID"].ToString();
// SINV_HDR_OtherTax_Rate.Text =  dt.Rows[0]["SINV_HDR_OtherTax_Rate"].ToString();
// SINV_HDR_OtherTax_Amt.Text =  dt.Rows[0]["SINV_HDR_OtherTax_Amt"].ToString();
// SINV_HDR_Other_Taxable_Amt.Text =  dt.Rows[0]["SINV_HDR_Other_Taxable_Amt"].ToString();
// SINV_HDR_Total_Tax_Amt.Text =  dt.Rows[0]["SINV_HDR_Total_Tax_Amt"].ToString();
// SINV_HDR_ItemGross_Total_Amt.Text =  dt.Rows[0]["SINV_HDR_ItemGross_Total_Amt"].ToString();
// SINV_HDR_Gross_Amt.Text =  dt.Rows[0]["SINV_HDR_Gross_Amt"].ToString();
// SINV_HDR_Round_Off_Amt.Text =  dt.Rows[0]["SINV_HDR_Round_Off_Amt"].ToString();
// SINV_HDR_Total_Gross_Amt.Text =  dt.Rows[0]["SINV_HDR_Total_Gross_Amt"].ToString();
// SINV_HDR_Gross_AmtInWords.Text =  dt.Rows[0]["SINV_HDR_Gross_AmtInWords"].ToString();
// SINV_HDR_CreditNote_AsOn_Amt.Text =  dt.Rows[0]["SINV_HDR_CreditNote_AsOn_Amt"].ToString();
// SINV_HDR_DebitNote_AsOn_Amt.Text =  dt.Rows[0]["SINV_HDR_DebitNote_AsOn_Amt"].ToString();
// SINV_HDR_TDS_Rate.Text =  dt.Rows[0]["SINV_HDR_TDS_Rate"].ToString();
// SINV_HDR_TDS_Amt.Text =  dt.Rows[0]["SINV_HDR_TDS_Amt"].ToString();
// SINV_HDR_Paid_AsOn_Amt.Text =  dt.Rows[0]["SINV_HDR_Paid_AsOn_Amt"].ToString();
// SINV_HDR_Outstanding_AsOn_Amt.Text =  dt.Rows[0]["SINV_HDR_Outstanding_AsOn_Amt"].ToString();
