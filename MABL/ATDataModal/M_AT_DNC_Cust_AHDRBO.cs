using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal
{
    public class M_AT_DNC_Cust_AHDRBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public M_AT_DNC_Cust_AHDRBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "DCNCHDR_ID";
        private string _TableName = "M_AT_DNC_Cust_AHDR";
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

        private Int64 _DCNCHDR_ID;
        private Int64 _Fk_Company_ID;
        private Int64 _Fk_Branch_ID;
        private Int64 _Fk_Year_ID;
        
        private Int64 _Fk_INVHDR_ID;
        private String _Rec_Created_In;
        private String _DCNC_TrnType;
        private String _DCNC_Reason;
        private Int64 _DCNC_ShippTo_State_ID;
        private String _DCNC_Category;
        
        private Int64 _Rec_CreatedBy_ID;
        private Int64 _Rec_CreatedFor_ID;
        private String _DCNC_CreationType;
        private String _DCNC_Type;
        private String _DCNC_Taxtype;
        private String _DCNC_No;
        private String _DCNC_DT;
        private String _DCNC_Remark;
        private Int16 _DCNC_L1AuthorizeID;
        private String _DCNC_L1AuthorizeBy;
        private String _DCNC_L1AuthorizeDT;
        private Int16 _DCNC_L2AuthorizeID;
        private String _DCNC_L2AuthorizeBy;
        private String _DCNC_L2AuthorizeDT;
        private String _DCNC_AuthRemark;
        private Int16 _DCNC_DTL_CNT;
        private String _MDBSC_RowStatus;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;
        private Decimal _DCNC_HDR_BasicAmt;
        private Decimal _DCNC_HDR_DiscountRate;
        private Decimal _DCNC_HDR_DiscountAmt;
        private Decimal _DCNC_HDR_Net_Amt;
        private Decimal _DCNC_HDR_Freight_Charges;
        private Decimal _DCNC_HDR_Loading_N_Packing_Charges;
        private Decimal _DCNC_HDR_Insurance_Charges;
        private String _DCNC_HDR_Other_Charges_Txt;
        private Decimal _DCNC_HDR_Other_Charges_Amt;
        private Decimal _DCNC_HDR_Taxable_Amt;
        private Decimal _DCNC_HDR_CGST_Amt;
        private Decimal _DCNC_HDR_CGST_Taxable_Amt;
        private Decimal _DCNC_HDR_SGST_Amt;
        private Decimal _DCNC_HDR_SGST_Taxable_Amt;
        private Decimal _DCNC_HDR_IGST_Amt;
        private Decimal _DCNC_HDR_IGST_Taxable_Amt;
        private Decimal _DCNC_HDR_CESS_Amt;
        private Decimal _DCNC_HDR_CESS_Taxable_Amt;
        private Int16 _DCNC_HDR_OtherTax_ID;
        private Decimal _DCNC_HDR_OtherTax_Rate;
        private Decimal _DCNC_HDR_OtherTax_Amt;
        private Decimal _DCNC_HDR_Other_Taxable_Amt;
        private Decimal _DCNC_HDR_Total_Tax_Amt;
        private Decimal _DCNC_HDR_ItemGross_Total_Amt;
        private Decimal _DCNC_HDR_Gross_Amt;
        private Decimal _DCNC_HDR_Round_Off_Amt;
        private Decimal _DCNC_HDR_Total_Gross_Amt;
        private String _DCNC_HDR_Gross_AmtInWords;

        public Int64 DCNCHDR_ID
        {
            get
            {
                return this._DCNCHDR_ID;
            }
            set
            {
                this._DCNCHDR_ID = value;
                _UpdateFieldName.Add("DCNCHDR_ID");
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
        public Int64 Fk_INVHDR_ID
        {
            get
            {
                return this._Fk_INVHDR_ID;
            }
            set
            {
                this._Fk_INVHDR_ID = value;
                _UpdateFieldName.Add("Fk_INVHDR_ID");
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


        public Int64 DCNC_ShippTo_State_ID
        {
            get
            {
                return this._DCNC_ShippTo_State_ID;
            }
            set
            {
                this._DCNC_ShippTo_State_ID = value;
                _UpdateFieldName.Add("DCNC_ShippTo_State_ID");
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

        public String DCNC_TrnType
        {
            get
            {
                return this._DCNC_TrnType;
            }
            set
            {
                this._DCNC_TrnType = value;
                _UpdateFieldName.Add("DCNC_TrnType");
            }
        }
        public String DCNC_Category
        {
            get
            {
                return this._DCNC_Category;
            }
            set
            {
                this._DCNC_Category = value;
                _UpdateFieldName.Add("DCNC_Category");
            }
        }
        public String DCNC_CreationType
        {
            get
            {
                return this._DCNC_CreationType;
            }
            set
            {
                this._DCNC_CreationType = value;
                _UpdateFieldName.Add("DCNC_CreationType");
            }
        }
        public String DCNC_Type
        {
            get
            {
                return this._DCNC_Type;
            }
            set
            {
                this._DCNC_Type = value;
                _UpdateFieldName.Add("DCNC_Type");
            }
        }
        public String DCNC_Taxtype
        {
            get
            {
                return this._DCNC_Taxtype;
            }
            set
            {
                this._DCNC_Taxtype = value;
                _UpdateFieldName.Add("DCNC_Taxtype");
            }
        }
        public String DCNC_No
        {
            get
            {
                return this._DCNC_No;
            }
            set
            {
                this._DCNC_No = value;
                _UpdateFieldName.Add("DCNC_No");
            }
        }

        public String DCNC_Reason
        {
            get
            {
                return this._DCNC_Reason;
            }
            set
            {
                this._DCNC_Reason = value;
                _UpdateFieldName.Add("DCNC_Reason");
            }
        }
        public String DCNC_DT
        {
            get
            {
                return this._DCNC_DT;
            }
            set
            {
                this._DCNC_DT = value;
                _UpdateFieldName.Add("DCNC_DT");
            }
        }
        public String DCNC_Remark
        {
            get
            {
                return this._DCNC_Remark;
            }
            set
            {
                this._DCNC_Remark = value;
                _UpdateFieldName.Add("DCNC_Remark");
            }
        }
        public Int16 DCNC_L1AuthorizeID
        {
            get
            {
                return this._DCNC_L1AuthorizeID;
            }
            set
            {
                this._DCNC_L1AuthorizeID = value;
                _UpdateFieldName.Add("DCNC_L1AuthorizeID");
            }
        }
        public String DCNC_L1AuthorizeBy
        {
            get
            {
                return this._DCNC_L1AuthorizeBy;
            }
            set
            {
                this._DCNC_L1AuthorizeBy = value;
                _UpdateFieldName.Add("DCNC_L1AuthorizeBy");
            }
        }
        public String DCNC_L1AuthorizeDT
        {
            get
            {
                return this._DCNC_L1AuthorizeDT;
            }
            set
            {
                this._DCNC_L1AuthorizeDT = value;
                _UpdateFieldName.Add("DCNC_L1AuthorizeDT");
            }
        }
        public Int16 DCNC_L2AuthorizeID
        {
            get
            {
                return this._DCNC_L2AuthorizeID;
            }
            set
            {
                this._DCNC_L2AuthorizeID = value;
                _UpdateFieldName.Add("DCNC_L2AuthorizeID");
            }
        }
        public String DCNC_L2AuthorizeBy
        {
            get
            {
                return this._DCNC_L2AuthorizeBy;
            }
            set
            {
                this._DCNC_L2AuthorizeBy = value;
                _UpdateFieldName.Add("DCNC_L2AuthorizeBy");
            }
        }
        public String DCNC_L2AuthorizeDT
        {
            get
            {
                return this._DCNC_L2AuthorizeDT;
            }
            set
            {
                this._DCNC_L2AuthorizeDT = value;
                _UpdateFieldName.Add("DCNC_L2AuthorizeDT");
            }
        }
        public String DCNC_AuthRemark
        {
            get
            {
                return this._DCNC_AuthRemark;
            }
            set
            {
                this._DCNC_AuthRemark = value;
                _UpdateFieldName.Add("DCNC_AuthRemark");
            }
        }
        public Int16 DCNC_DTL_CNT
        {
            get
            {
                return this._DCNC_DTL_CNT;
            }
            set
            {
                this._DCNC_DTL_CNT = value;
                _UpdateFieldName.Add("DCNC_DTL_CNT");
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
        public Decimal DCNC_HDR_BasicAmt
        {
            get
            {
                return this._DCNC_HDR_BasicAmt;
            }
            set
            {
                this._DCNC_HDR_BasicAmt = value;
                _UpdateFieldName.Add("DCNC_HDR_BasicAmt");
            }
        }
        public Decimal DCNC_HDR_DiscountRate
        {
            get
            {
                return this._DCNC_HDR_DiscountRate;
            }
            set
            {
                this._DCNC_HDR_DiscountRate = value;
                _UpdateFieldName.Add("DCNC_HDR_DiscountRate");
            }
        }
        public Decimal DCNC_HDR_DiscountAmt
        {
            get
            {
                return this._DCNC_HDR_DiscountAmt;
            }
            set
            {
                this._DCNC_HDR_DiscountAmt = value;
                _UpdateFieldName.Add("DCNC_HDR_DiscountAmt");
            }
        }
        public Decimal DCNC_HDR_Net_Amt
        {
            get
            {
                return this._DCNC_HDR_Net_Amt;
            }
            set
            {
                this._DCNC_HDR_Net_Amt = value;
                _UpdateFieldName.Add("DCNC_HDR_Net_Amt");
            }
        }
        public Decimal DCNC_HDR_Freight_Charges
        {
            get
            {
                return this._DCNC_HDR_Freight_Charges;
            }
            set
            {
                this._DCNC_HDR_Freight_Charges = value;
                _UpdateFieldName.Add("DCNC_HDR_Freight_Charges");
            }
        }
        public Decimal DCNC_HDR_Loading_N_Packing_Charges
        {
            get
            {
                return this._DCNC_HDR_Loading_N_Packing_Charges;
            }
            set
            {
                this._DCNC_HDR_Loading_N_Packing_Charges = value;
                _UpdateFieldName.Add("DCNC_HDR_Loading_N_Packing_Charges");
            }
        }
        public Decimal DCNC_HDR_Insurance_Charges
        {
            get
            {
                return this._DCNC_HDR_Insurance_Charges;
            }
            set
            {
                this._DCNC_HDR_Insurance_Charges = value;
                _UpdateFieldName.Add("DCNC_HDR_Insurance_Charges");
            }
        }
        public String DCNC_HDR_Other_Charges_Txt
        {
            get
            {
                return this._DCNC_HDR_Other_Charges_Txt;
            }
            set
            {
                this._DCNC_HDR_Other_Charges_Txt = value;
                _UpdateFieldName.Add("DCNC_HDR_Other_Charges_Txt");
            }
        }
        public Decimal DCNC_HDR_Other_Charges_Amt
        {
            get
            {
                return this._DCNC_HDR_Other_Charges_Amt;
            }
            set
            {
                this._DCNC_HDR_Other_Charges_Amt = value;
                _UpdateFieldName.Add("DCNC_HDR_Other_Charges_Amt");
            }
        }
        public Decimal DCNC_HDR_Taxable_Amt
        {
            get
            {
                return this._DCNC_HDR_Taxable_Amt;
            }
            set
            {
                this._DCNC_HDR_Taxable_Amt = value;
                _UpdateFieldName.Add("DCNC_HDR_Taxable_Amt");
            }
        }
        public Decimal DCNC_HDR_CGST_Amt
        {
            get
            {
                return this._DCNC_HDR_CGST_Amt;
            }
            set
            {
                this._DCNC_HDR_CGST_Amt = value;
                _UpdateFieldName.Add("DCNC_HDR_CGST_Amt");
            }
        }
        public Decimal DCNC_HDR_CGST_Taxable_Amt
        {
            get
            {
                return this._DCNC_HDR_CGST_Taxable_Amt;
            }
            set
            {
                this._DCNC_HDR_CGST_Taxable_Amt = value;
                _UpdateFieldName.Add("DCNC_HDR_CGST_Taxable_Amt");
            }
        }
        public Decimal DCNC_HDR_SGST_Amt
        {
            get
            {
                return this._DCNC_HDR_SGST_Amt;
            }
            set
            {
                this._DCNC_HDR_SGST_Amt = value;
                _UpdateFieldName.Add("DCNC_HDR_SGST_Amt");
            }
        }
        public Decimal DCNC_HDR_SGST_Taxable_Amt
        {
            get
            {
                return this._DCNC_HDR_SGST_Taxable_Amt;
            }
            set
            {
                this._DCNC_HDR_SGST_Taxable_Amt = value;
                _UpdateFieldName.Add("DCNC_HDR_SGST_Taxable_Amt");
            }
        }
        public Decimal DCNC_HDR_IGST_Amt
        {
            get
            {
                return this._DCNC_HDR_IGST_Amt;
            }
            set
            {
                this._DCNC_HDR_IGST_Amt = value;
                _UpdateFieldName.Add("DCNC_HDR_IGST_Amt");
            }
        }
        public Decimal DCNC_HDR_IGST_Taxable_Amt
        {
            get
            {
                return this._DCNC_HDR_IGST_Taxable_Amt;
            }
            set
            {
                this._DCNC_HDR_IGST_Taxable_Amt = value;
                _UpdateFieldName.Add("DCNC_HDR_IGST_Taxable_Amt");
            }
        }
        public Decimal DCNC_HDR_CESS_Amt
        {
            get
            {
                return this._DCNC_HDR_CESS_Amt;
            }
            set
            {
                this._DCNC_HDR_CESS_Amt = value;
                _UpdateFieldName.Add("DCNC_HDR_CESS_Amt");
            }
        }
        public Decimal DCNC_HDR_CESS_Taxable_Amt
        {
            get
            {
                return this._DCNC_HDR_CESS_Taxable_Amt;
            }
            set
            {
                this._DCNC_HDR_CESS_Taxable_Amt = value;
                _UpdateFieldName.Add("DCNC_HDR_CESS_Taxable_Amt");
            }
        }
        public Int16 DCNC_HDR_OtherTax_ID
        {
            get
            {
                return this._DCNC_HDR_OtherTax_ID;
            }
            set
            {
                this._DCNC_HDR_OtherTax_ID = value;
                _UpdateFieldName.Add("DCNC_HDR_OtherTax_ID");
            }
        }
        public Decimal DCNC_HDR_OtherTax_Rate
        {
            get
            {
                return this._DCNC_HDR_OtherTax_Rate;
            }
            set
            {
                this._DCNC_HDR_OtherTax_Rate = value;
                _UpdateFieldName.Add("DCNC_HDR_OtherTax_Rate");
            }
        }
        public Decimal DCNC_HDR_OtherTax_Amt
        {
            get
            {
                return this._DCNC_HDR_OtherTax_Amt;
            }
            set
            {
                this._DCNC_HDR_OtherTax_Amt = value;
                _UpdateFieldName.Add("DCNC_HDR_OtherTax_Amt");
            }
        }
        public Decimal DCNC_HDR_Other_Taxable_Amt
        {
            get
            {
                return this._DCNC_HDR_Other_Taxable_Amt;
            }
            set
            {
                this._DCNC_HDR_Other_Taxable_Amt = value;
                _UpdateFieldName.Add("DCNC_HDR_Other_Taxable_Amt");
            }
        }
        public Decimal DCNC_HDR_Total_Tax_Amt
        {
            get
            {
                return this._DCNC_HDR_Total_Tax_Amt;
            }
            set
            {
                this._DCNC_HDR_Total_Tax_Amt = value;
                _UpdateFieldName.Add("DCNC_HDR_Total_Tax_Amt");
            }
        }
        public Decimal DCNC_HDR_ItemGross_Total_Amt
        {
            get
            {
                return this._DCNC_HDR_ItemGross_Total_Amt;
            }
            set
            {
                this._DCNC_HDR_ItemGross_Total_Amt = value;
                _UpdateFieldName.Add("DCNC_HDR_ItemGross_Total_Amt");
            }
        }
        public Decimal DCNC_HDR_Gross_Amt
        {
            get
            {
                return this._DCNC_HDR_Gross_Amt;
            }
            set
            {
                this._DCNC_HDR_Gross_Amt = value;
                _UpdateFieldName.Add("DCNC_HDR_Gross_Amt");
            }
        }
        public Decimal DCNC_HDR_Round_Off_Amt
        {
            get
            {
                return this._DCNC_HDR_Round_Off_Amt;
            }
            set
            {
                this._DCNC_HDR_Round_Off_Amt = value;
                _UpdateFieldName.Add("DCNC_HDR_Round_Off_Amt");
            }
        }
        public Decimal DCNC_HDR_Total_Gross_Amt
        {
            get
            {
                return this._DCNC_HDR_Total_Gross_Amt;
            }
            set
            {
                this._DCNC_HDR_Total_Gross_Amt = value;
                _UpdateFieldName.Add("DCNC_HDR_Total_Gross_Amt");
            }
        }
        public String DCNC_HDR_Gross_AmtInWords
        {
            get
            {
                return this._DCNC_HDR_Gross_AmtInWords;
            }
            set
            {
                this._DCNC_HDR_Gross_AmtInWords = value;
                _UpdateFieldName.Add("DCNC_HDR_Gross_AmtInWords");
            }
        }

        #endregion
        #region Genric Methods
        public string Insert_Update(M_AT_DNC_Cust_AHDRBO sObject)
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

// ObjAT_DCNCHDR.DCNCHDR_ID=ObjAT_DCNCHDR.DCNCHDR_ID;
// ObjAT_DCNCHDR.Fk_Company_ID=ObjAT_DCNCHDR.Fk_Company_ID;
// ObjAT_DCNCHDR.Fk_Branch_ID=ObjAT_DCNCHDR.Fk_Branch_ID;
// ObjAT_DCNCHDR.Fk_Year_ID=ObjAT_DCNCHDR.Fk_Year_ID;
// ObjAT_DCNCHDR.Fk_INVHDR_ID=ObjAT_DCNCHDR.Fk_INVHDR_ID;
// ObjAT_DCNCHDR.Rec_Created_In=ObjAT_DCNCHDR.Rec_Created_In;
// ObjAT_DCNCHDR.Rec_CreatedBy_ID=ObjAT_DCNCHDR.Rec_CreatedBy_ID;
// ObjAT_DCNCHDR.Rec_CreatedFor_ID=ObjAT_DCNCHDR.Rec_CreatedFor_ID;
// ObjAT_DCNCHDR.DCNC_CreationType=ObjAT_DCNCHDR.DCNC_CreationType;
// ObjAT_DCNCHDR.DC_Type=ObjAT_DCNCHDR.DC_Type;
// ObjAT_DCNCHDR.DCNC_Taxtype=ObjAT_DCNCHDR.DCNC_Taxtype;
// ObjAT_DCNCHDR.DCNC_No=ObjAT_DCNCHDR.DCNC_No;
// ObjAT_DCNCHDR.DCNC_DT=ObjAT_DCNCHDR.DCNC_DT;
// ObjAT_DCNCHDR.DCNC_Remark=ObjAT_DCNCHDR.DCNC_Remark;
// ObjAT_DCNCHDR.DCNC_L1AuthorizeID=ObjAT_DCNCHDR.DCNC_L1AuthorizeID;
// ObjAT_DCNCHDR.DCNC_L1AuthorizeBy=ObjAT_DCNCHDR.DCNC_L1AuthorizeBy;
// ObjAT_DCNCHDR.DCNC_L1AuthorizeDT=ObjAT_DCNCHDR.DCNC_L1AuthorizeDT;
// ObjAT_DCNCHDR.DCNC_L2AuthorizeID=ObjAT_DCNCHDR.DCNC_L2AuthorizeID;
// ObjAT_DCNCHDR.DCNC_L2AuthorizeBy=ObjAT_DCNCHDR.DCNC_L2AuthorizeBy;
// ObjAT_DCNCHDR.DCNC_L2AuthorizeDT=ObjAT_DCNCHDR.DCNC_L2AuthorizeDT;
// ObjAT_DCNCHDR.DCNC_AuthRemark=ObjAT_DCNCHDR.DCNC_AuthRemark;
// ObjAT_DCNCHDR.DCNC_DTL_CNT=ObjAT_DCNCHDR.DCNC_DTL_CNT;
// ObjAT_DCNCHDR.MDBSC_RowStatus=ObjAT_DCNCHDR.MDBSC_RowStatus;
// ObjAT_DCNCHDR.MDBSC_RowCreatedByUser_ID=ObjAT_DCNCHDR.MDBSC_RowCreatedByUser_ID;
// ObjAT_DCNCHDR.MDBSC_RowCreatedByUserName=ObjAT_DCNCHDR.MDBSC_RowCreatedByUserName;
// ObjAT_DCNCHDR.MDBSC_RowCreatedOn_DT=ObjAT_DCNCHDR.MDBSC_RowCreatedOn_DT;
// ObjAT_DCNCHDR.MDBSC_RowLupdnByUser_ID=ObjAT_DCNCHDR.MDBSC_RowLupdnByUser_ID;
// ObjAT_DCNCHDR.MDBSC_RowLupdnUserName=ObjAT_DCNCHDR.MDBSC_RowLupdnUserName;
// ObjAT_DCNCHDR.MDBSC_RowLupdnOn_DT=ObjAT_DCNCHDR.MDBSC_RowLupdnOn_DT;
// ObjAT_DCNCHDR.DCNC_HDR_BasicAmt=ObjAT_DCNCHDR.DCNC_HDR_BasicAmt;
// ObjAT_DCNCHDR.DCNC_HDR_DiscountRate=ObjAT_DCNCHDR.DCNC_HDR_DiscountRate;
// ObjAT_DCNCHDR.DCNC_HDR_DiscountAmt=ObjAT_DCNCHDR.DCNC_HDR_DiscountAmt;
// ObjAT_DCNCHDR.DCNC_HDR_Net_Amt=ObjAT_DCNCHDR.DCNC_HDR_Net_Amt;
// ObjAT_DCNCHDR.DCNC_HDR_Freight_Charges=ObjAT_DCNCHDR.DCNC_HDR_Freight_Charges;
// ObjAT_DCNCHDR.DCNC_HDR_Loading_N_Packing_Charges=ObjAT_DCNCHDR.DCNC_HDR_Loading_N_Packing_Charges;
// ObjAT_DCNCHDR.DCNC_HDR_Insurance_Charges=ObjAT_DCNCHDR.DCNC_HDR_Insurance_Charges;
// ObjAT_DCNCHDR.DCNC_HDR_Other_Charges_Txt=ObjAT_DCNCHDR.DCNC_HDR_Other_Charges_Txt;
// ObjAT_DCNCHDR.DCNC_HDR_Other_Charges_Amt=ObjAT_DCNCHDR.DCNC_HDR_Other_Charges_Amt;
// ObjAT_DCNCHDR.DCNC_HDR_Taxable_Amt=ObjAT_DCNCHDR.DCNC_HDR_Taxable_Amt;
// ObjAT_DCNCHDR.DCNC_HDR_CGST_Amt=ObjAT_DCNCHDR.DCNC_HDR_CGST_Amt;
// ObjAT_DCNCHDR.DCNC_HDR_CGST_Taxable_Amt=ObjAT_DCNCHDR.DCNC_HDR_CGST_Taxable_Amt;
// ObjAT_DCNCHDR.DCNC_HDR_SGST_Amt=ObjAT_DCNCHDR.DCNC_HDR_SGST_Amt;
// ObjAT_DCNCHDR.DCNC_HDR_SGST_Taxable_Amt=ObjAT_DCNCHDR.DCNC_HDR_SGST_Taxable_Amt;
// ObjAT_DCNCHDR.DCNC_HDR_IGST_Amt=ObjAT_DCNCHDR.DCNC_HDR_IGST_Amt;
// ObjAT_DCNCHDR.DCNC_HDR_IGST_Taxable_Amt=ObjAT_DCNCHDR.DCNC_HDR_IGST_Taxable_Amt;
// ObjAT_DCNCHDR.DCNC_HDR_CESS_Amt=ObjAT_DCNCHDR.DCNC_HDR_CESS_Amt;
// ObjAT_DCNCHDR.DCNC_HDR_CESS_Taxable_Amt=ObjAT_DCNCHDR.DCNC_HDR_CESS_Taxable_Amt;
// ObjAT_DCNCHDR.DCNC_HDR_OtherTax_ID=ObjAT_DCNCHDR.DCNC_HDR_OtherTax_ID;
// ObjAT_DCNCHDR.DCNC_HDR_OtherTax_Rate=ObjAT_DCNCHDR.DCNC_HDR_OtherTax_Rate;
// ObjAT_DCNCHDR.DCNC_HDR_OtherTax_Amt=ObjAT_DCNCHDR.DCNC_HDR_OtherTax_Amt;
// ObjAT_DCNCHDR.DCNC_HDR_Other_Taxable_Amt=ObjAT_DCNCHDR.DCNC_HDR_Other_Taxable_Amt;
// ObjAT_DCNCHDR.DCNC_HDR_Total_Tax_Amt=ObjAT_DCNCHDR.DCNC_HDR_Total_Tax_Amt;
// ObjAT_DCNCHDR.DCNC_HDR_ItemGross_Total_Amt=ObjAT_DCNCHDR.DCNC_HDR_ItemGross_Total_Amt;
// ObjAT_DCNCHDR.DCNC_HDR_Gross_Amt=ObjAT_DCNCHDR.DCNC_HDR_Gross_Amt;
// ObjAT_DCNCHDR.DCNC_HDR_Round_Off_Amt=ObjAT_DCNCHDR.DCNC_HDR_Round_Off_Amt;
// ObjAT_DCNCHDR.DCNC_HDR_Total_Gross_Amt=ObjAT_DCNCHDR.DCNC_HDR_Total_Gross_Amt;
// ObjAT_DCNCHDR.DCNC_HDR_Gross_AmtInWords=ObjAT_DCNCHDR.DCNC_HDR_Gross_AmtInWords;



// DCNCHDR_ID.Text = "";
// Fk_Company_ID.Text = "";
// Fk_Branch_ID.Text = "";
// Fk_Year_ID.Text = "";
// Fk_INVHDR_ID.Text = "";
// Rec_Created_In.Text = "";
// Rec_CreatedBy_ID.Text = "";
// Rec_CreatedFor_ID.Text = "";
// DCNC_CreationType.Text = "";
// DC_Type.Text = "";
// DCNC_Taxtype.Text = "";
// DCNC_No.Text = "";
// DCNC_DT.Text = "";
// DCNC_Remark.Text = "";
// DCNC_L1AuthorizeID.Text = "";
// DCNC_L1AuthorizeBy.Text = "";
// DCNC_L1AuthorizeDT.Text = "";
// DCNC_L2AuthorizeID.Text = "";
// DCNC_L2AuthorizeBy.Text = "";
// DCNC_L2AuthorizeDT.Text = "";
// DCNC_AuthRemark.Text = "";
// DCNC_DTL_CNT.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";
// DCNC_HDR_BasicAmt.Text = "";
// DCNC_HDR_DiscountRate.Text = "";
// DCNC_HDR_DiscountAmt.Text = "";
// DCNC_HDR_Net_Amt.Text = "";
// DCNC_HDR_Freight_Charges.Text = "";
// DCNC_HDR_Loading_N_Packing_Charges.Text = "";
// DCNC_HDR_Insurance_Charges.Text = "";
// DCNC_HDR_Other_Charges_Txt.Text = "";
// DCNC_HDR_Other_Charges_Amt.Text = "";
// DCNC_HDR_Taxable_Amt.Text = "";
// DCNC_HDR_CGST_Amt.Text = "";
// DCNC_HDR_CGST_Taxable_Amt.Text = "";
// DCNC_HDR_SGST_Amt.Text = "";
// DCNC_HDR_SGST_Taxable_Amt.Text = "";
// DCNC_HDR_IGST_Amt.Text = "";
// DCNC_HDR_IGST_Taxable_Amt.Text = "";
// DCNC_HDR_CESS_Amt.Text = "";
// DCNC_HDR_CESS_Taxable_Amt.Text = "";
// DCNC_HDR_OtherTax_ID.Text = "";
// DCNC_HDR_OtherTax_Rate.Text = "";
// DCNC_HDR_OtherTax_Amt.Text = "";
// DCNC_HDR_Other_Taxable_Amt.Text = "";
// DCNC_HDR_Total_Tax_Amt.Text = "";
// DCNC_HDR_ItemGross_Total_Amt.Text = "";
// DCNC_HDR_Gross_Amt.Text = "";
// DCNC_HDR_Round_Off_Amt.Text = "";
// DCNC_HDR_Total_Gross_Amt.Text = "";
// DCNC_HDR_Gross_AmtInWords.Text = "";



// ObjAT_DCNCHDR.DCNCHDR_ID=DCNCHDR_ID.Text ;
// ObjAT_DCNCHDR.Fk_Company_ID=Fk_Company_ID.Text ;
// ObjAT_DCNCHDR.Fk_Branch_ID=Fk_Branch_ID.Text ;
// ObjAT_DCNCHDR.Fk_Year_ID=Fk_Year_ID.Text ;
// ObjAT_DCNCHDR.Fk_INVHDR_ID=Fk_INVHDR_ID.Text ;
// ObjAT_DCNCHDR.Rec_Created_In=Rec_Created_In.Text ;
// ObjAT_DCNCHDR.Rec_CreatedBy_ID=Rec_CreatedBy_ID.Text ;
// ObjAT_DCNCHDR.Rec_CreatedFor_ID=Rec_CreatedFor_ID.Text ;
// ObjAT_DCNCHDR.DCNC_CreationType=DCNC_CreationType.Text ;
// ObjAT_DCNCHDR.DC_Type=DC_Type.Text ;
// ObjAT_DCNCHDR.DCNC_Taxtype=DCNC_Taxtype.Text ;
// ObjAT_DCNCHDR.DCNC_No=DCNC_No.Text ;
// ObjAT_DCNCHDR.DCNC_DT=DCNC_DT.Text ;
// ObjAT_DCNCHDR.DCNC_Remark=DCNC_Remark.Text ;
// ObjAT_DCNCHDR.DCNC_L1AuthorizeID=DCNC_L1AuthorizeID.Text ;
// ObjAT_DCNCHDR.DCNC_L1AuthorizeBy=DCNC_L1AuthorizeBy.Text ;
// ObjAT_DCNCHDR.DCNC_L1AuthorizeDT=DCNC_L1AuthorizeDT.Text ;
// ObjAT_DCNCHDR.DCNC_L2AuthorizeID=DCNC_L2AuthorizeID.Text ;
// ObjAT_DCNCHDR.DCNC_L2AuthorizeBy=DCNC_L2AuthorizeBy.Text ;
// ObjAT_DCNCHDR.DCNC_L2AuthorizeDT=DCNC_L2AuthorizeDT.Text ;
// ObjAT_DCNCHDR.DCNC_AuthRemark=DCNC_AuthRemark.Text ;
// ObjAT_DCNCHDR.DCNC_DTL_CNT=DCNC_DTL_CNT.Text ;
// ObjAT_DCNCHDR.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_DCNCHDR.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_DCNCHDR.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_DCNCHDR.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_DCNCHDR.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_DCNCHDR.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_DCNCHDR.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_BasicAmt=DCNC_HDR_BasicAmt.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_DiscountRate=DCNC_HDR_DiscountRate.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_DiscountAmt=DCNC_HDR_DiscountAmt.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_Net_Amt=DCNC_HDR_Net_Amt.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_Freight_Charges=DCNC_HDR_Freight_Charges.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_Loading_N_Packing_Charges=DCNC_HDR_Loading_N_Packing_Charges.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_Insurance_Charges=DCNC_HDR_Insurance_Charges.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_Other_Charges_Txt=DCNC_HDR_Other_Charges_Txt.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_Other_Charges_Amt=DCNC_HDR_Other_Charges_Amt.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_Taxable_Amt=DCNC_HDR_Taxable_Amt.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_CGST_Amt=DCNC_HDR_CGST_Amt.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_CGST_Taxable_Amt=DCNC_HDR_CGST_Taxable_Amt.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_SGST_Amt=DCNC_HDR_SGST_Amt.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_SGST_Taxable_Amt=DCNC_HDR_SGST_Taxable_Amt.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_IGST_Amt=DCNC_HDR_IGST_Amt.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_IGST_Taxable_Amt=DCNC_HDR_IGST_Taxable_Amt.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_CESS_Amt=DCNC_HDR_CESS_Amt.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_CESS_Taxable_Amt=DCNC_HDR_CESS_Taxable_Amt.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_OtherTax_ID=DCNC_HDR_OtherTax_ID.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_OtherTax_Rate=DCNC_HDR_OtherTax_Rate.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_OtherTax_Amt=DCNC_HDR_OtherTax_Amt.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_Other_Taxable_Amt=DCNC_HDR_Other_Taxable_Amt.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_Total_Tax_Amt=DCNC_HDR_Total_Tax_Amt.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_ItemGross_Total_Amt=DCNC_HDR_ItemGross_Total_Amt.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_Gross_Amt=DCNC_HDR_Gross_Amt.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_Round_Off_Amt=DCNC_HDR_Round_Off_Amt.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_Total_Gross_Amt=DCNC_HDR_Total_Gross_Amt.Text ;
// ObjAT_DCNCHDR.DCNC_HDR_Gross_AmtInWords=DCNC_HDR_Gross_AmtInWords.Text ;



// DCNCHDR_ID.Text =  dt.Rows[0]["DCNCHDR_ID"].ToString();
// Fk_Company_ID.Text =  dt.Rows[0]["Fk_Company_ID"].ToString();
// Fk_Branch_ID.Text =  dt.Rows[0]["Fk_Branch_ID"].ToString();
// Fk_Year_ID.Text =  dt.Rows[0]["Fk_Year_ID"].ToString();
// Fk_INVHDR_ID.Text =  dt.Rows[0]["Fk_INVHDR_ID"].ToString();
// Rec_Created_In.Text =  dt.Rows[0]["Rec_Created_In"].ToString();
// Rec_CreatedBy_ID.Text =  dt.Rows[0]["Rec_CreatedBy_ID"].ToString();
// Rec_CreatedFor_ID.Text =  dt.Rows[0]["Rec_CreatedFor_ID"].ToString();
// DCNC_CreationType.Text =  dt.Rows[0]["DCNC_CreationType"].ToString();
// DC_Type.Text =  dt.Rows[0]["DC_Type"].ToString();
// DCNC_Taxtype.Text =  dt.Rows[0]["DCNC_Taxtype"].ToString();
// DCNC_No.Text =  dt.Rows[0]["DCNC_No"].ToString();
// DCNC_DT.Text =  dt.Rows[0]["DCNC_DT"].ToString();
// DCNC_Remark.Text =  dt.Rows[0]["DCNC_Remark"].ToString();
// DCNC_L1AuthorizeID.Text =  dt.Rows[0]["DCNC_L1AuthorizeID"].ToString();
// DCNC_L1AuthorizeBy.Text =  dt.Rows[0]["DCNC_L1AuthorizeBy"].ToString();
// DCNC_L1AuthorizeDT.Text =  dt.Rows[0]["DCNC_L1AuthorizeDT"].ToString();
// DCNC_L2AuthorizeID.Text =  dt.Rows[0]["DCNC_L2AuthorizeID"].ToString();
// DCNC_L2AuthorizeBy.Text =  dt.Rows[0]["DCNC_L2AuthorizeBy"].ToString();
// DCNC_L2AuthorizeDT.Text =  dt.Rows[0]["DCNC_L2AuthorizeDT"].ToString();
// DCNC_AuthRemark.Text =  dt.Rows[0]["DCNC_AuthRemark"].ToString();
// DCNC_DTL_CNT.Text =  dt.Rows[0]["DCNC_DTL_CNT"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
// DCNC_HDR_BasicAmt.Text =  dt.Rows[0]["DCNC_HDR_BasicAmt"].ToString();
// DCNC_HDR_DiscountRate.Text =  dt.Rows[0]["DCNC_HDR_DiscountRate"].ToString();
// DCNC_HDR_DiscountAmt.Text =  dt.Rows[0]["DCNC_HDR_DiscountAmt"].ToString();
// DCNC_HDR_Net_Amt.Text =  dt.Rows[0]["DCNC_HDR_Net_Amt"].ToString();
// DCNC_HDR_Freight_Charges.Text =  dt.Rows[0]["DCNC_HDR_Freight_Charges"].ToString();
// DCNC_HDR_Loading_N_Packing_Charges.Text =  dt.Rows[0]["DCNC_HDR_Loading_N_Packing_Charges"].ToString();
// DCNC_HDR_Insurance_Charges.Text =  dt.Rows[0]["DCNC_HDR_Insurance_Charges"].ToString();
// DCNC_HDR_Other_Charges_Txt.Text =  dt.Rows[0]["DCNC_HDR_Other_Charges_Txt"].ToString();
// DCNC_HDR_Other_Charges_Amt.Text =  dt.Rows[0]["DCNC_HDR_Other_Charges_Amt"].ToString();
// DCNC_HDR_Taxable_Amt.Text =  dt.Rows[0]["DCNC_HDR_Taxable_Amt"].ToString();
// DCNC_HDR_CGST_Amt.Text =  dt.Rows[0]["DCNC_HDR_CGST_Amt"].ToString();
// DCNC_HDR_CGST_Taxable_Amt.Text =  dt.Rows[0]["DCNC_HDR_CGST_Taxable_Amt"].ToString();
// DCNC_HDR_SGST_Amt.Text =  dt.Rows[0]["DCNC_HDR_SGST_Amt"].ToString();
// DCNC_HDR_SGST_Taxable_Amt.Text =  dt.Rows[0]["DCNC_HDR_SGST_Taxable_Amt"].ToString();
// DCNC_HDR_IGST_Amt.Text =  dt.Rows[0]["DCNC_HDR_IGST_Amt"].ToString();
// DCNC_HDR_IGST_Taxable_Amt.Text =  dt.Rows[0]["DCNC_HDR_IGST_Taxable_Amt"].ToString();
// DCNC_HDR_CESS_Amt.Text =  dt.Rows[0]["DCNC_HDR_CESS_Amt"].ToString();
// DCNC_HDR_CESS_Taxable_Amt.Text =  dt.Rows[0]["DCNC_HDR_CESS_Taxable_Amt"].ToString();
// DCNC_HDR_OtherTax_ID.Text =  dt.Rows[0]["DCNC_HDR_OtherTax_ID"].ToString();
// DCNC_HDR_OtherTax_Rate.Text =  dt.Rows[0]["DCNC_HDR_OtherTax_Rate"].ToString();
// DCNC_HDR_OtherTax_Amt.Text =  dt.Rows[0]["DCNC_HDR_OtherTax_Amt"].ToString();
// DCNC_HDR_Other_Taxable_Amt.Text =  dt.Rows[0]["DCNC_HDR_Other_Taxable_Amt"].ToString();
// DCNC_HDR_Total_Tax_Amt.Text =  dt.Rows[0]["DCNC_HDR_Total_Tax_Amt"].ToString();
// DCNC_HDR_ItemGross_Total_Amt.Text =  dt.Rows[0]["DCNC_HDR_ItemGross_Total_Amt"].ToString();
// DCNC_HDR_Gross_Amt.Text =  dt.Rows[0]["DCNC_HDR_Gross_Amt"].ToString();
// DCNC_HDR_Round_Off_Amt.Text =  dt.Rows[0]["DCNC_HDR_Round_Off_Amt"].ToString();
// DCNC_HDR_Total_Gross_Amt.Text =  dt.Rows[0]["DCNC_HDR_Total_Gross_Amt"].ToString();
// DCNC_HDR_Gross_AmtInWords.Text =  dt.Rows[0]["DCNC_HDR_Gross_AmtInWords"].ToString();

