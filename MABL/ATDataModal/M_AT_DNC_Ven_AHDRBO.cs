using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal
{
    public class M_AT_DNC_Ven_AHDRBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public M_AT_DNC_Ven_AHDRBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "DCNVHDR_ID";
        private string _TableName = "M_AT_DNC_Ven_AHDR";
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

        private Int64 _DCNVHDR_ID;
        private Int64 _Fk_Company_ID;
        private Int64 _Fk_Branch_ID;
        private Int64 _Fk_Year_ID;
        private Int64 _Fk_INVHDR_ID;
        private String _Rec_Created_In;
        private String _DCNV_Category;
        private String _DCNV_Reason;
        private String _DCNV_TrnType;

        private Int64 _DCNV_ShippTo_State_ID;
         
        private Int64 _Rec_CreatedBy_ID;
        private Int64 _Rec_CreatedFor_ID;
        private String _DCNV_CreationType;
        private String _DCNV_Type;
        private String _DCNV_Taxtype;
        private String _DCNV_No;
        private String _DCNV_DT;
        private String _DCNV_Remark;
        private Int16 _DCNV_L1AuthorizeID;
        private String _DCNV_L1AuthorizeBy;
        private String _DCNV_L1AuthorizeDT;
        private Int16 _DCNV_L2AuthorizeID;
        private String _DCNV_L2AuthorizeBy;
        private String _DCNV_L2AuthorizeDT;
        private String _DCNV_AuthRemark;
        private Int16 _DCNV_DTL_CNT;
        private String _MDBSC_RowStatus;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;
        private Decimal _DCNV_HDR_BasicAmt;
        private Decimal _DCNV_HDR_DiscountRate;
        private Decimal _DCNV_HDR_DiscountAmt;
        private Decimal _DCNV_HDR_Net_Amt;
        private Decimal _DCNV_HDR_Freight_Charges;
        private Decimal _DCNV_HDR_Loading_N_Packing_Charges;
        private Decimal _DCNV_HDR_Insurance_Charges;
        private String _DCNV_HDR_Other_Charges_Txt;
        private Decimal _DCNV_HDR_Other_Charges_Amt;
        private Decimal _DCNV_HDR_Taxable_Amt;
        private Decimal _DCNV_HDR_CGST_Amt;
        private Decimal _DCNV_HDR_CGST_Taxable_Amt;
        private Decimal _DCNV_HDR_SGST_Amt;
        private Decimal _DCNV_HDR_SGST_Taxable_Amt;
        private Decimal _DCNV_HDR_IGST_Amt;
        private Decimal _DCNV_HDR_IGST_Taxable_Amt;
        private Decimal _DCNV_HDR_CESS_Amt;
        private Decimal _DCNV_HDR_CESS_Taxable_Amt;
        private Int16 _DCNV_HDR_OtherTax_ID;
        private Decimal _DCNV_HDR_OtherTax_Rate;
        private Decimal _DCNV_HDR_OtherTax_Amt;
        private Decimal _DCNV_HDR_Other_Taxable_Amt;
        private Decimal _DCNV_HDR_Total_Tax_Amt;
        private Decimal _DCNV_HDR_ItemGross_Total_Amt;
        private Decimal _DCNV_HDR_Gross_Amt;
        private Decimal _DCNV_HDR_Round_Off_Amt;
        private Decimal _DCNV_HDR_Total_Gross_Amt;
        private String _DCNV_HDR_Gross_AmtInWords;

        public Int64 DCNVHDR_ID
        {
            get
            {
                return this._DCNVHDR_ID;
            }
            set
            {
                this._DCNVHDR_ID = value;
                _UpdateFieldName.Add("DCNVHDR_ID");
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



        public Int64 DCNV_ShippTo_State_ID
        {
            get
            {
                return this._DCNV_ShippTo_State_ID;
            }
            set
            {
                this._DCNV_ShippTo_State_ID = value;
                _UpdateFieldName.Add("DCNV_ShippTo_State_ID");
            }
        }

        
        public String DCNV_TrnType
        {
            get
            {
                return this._DCNV_TrnType;
            }
            set
            {
                this._DCNV_TrnType = value;
                _UpdateFieldName.Add("DCNV_TrnType");
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
        public String DCNV_CreationType
        {
            get
            {
                return this._DCNV_CreationType;
            }
            set
            {
                this._DCNV_CreationType = value;
                _UpdateFieldName.Add("DCNV_CreationType");
            }
        }




        public String DCNV_Category
        {
            get
            {
                return this._DCNV_Category;
            }
            set
            {
                this._DCNV_Category = value;
                _UpdateFieldName.Add("DCNV_Category");
            }
        }


        public String DCNV_Type
        {
            get
            {
                return this._DCNV_Type;
            }
            set
            {
                this._DCNV_Type = value;
                _UpdateFieldName.Add("DCNV_Type");
            }
        }
        public String DCNV_Taxtype
        {
            get
            {
                return this._DCNV_Taxtype;
            }
            set
            {
                this._DCNV_Taxtype = value;
                _UpdateFieldName.Add("DCNV_Taxtype");
            }
        }
        public String DCNV_No
        {
            get
            {
                return this._DCNV_No;
            }
            set
            {
                this._DCNV_No = value;
                _UpdateFieldName.Add("DCNV_No");
            }
        }

        public String DCNV_Reason
        {
            get
            {
                return this._DCNV_Reason;
            }
            set
            {
                this._DCNV_Reason = value;
                _UpdateFieldName.Add("DCNV_Reason");
            }
        }
        public String DCNV_DT
        {
            get
            {
                return this._DCNV_DT;
            }
            set
            {
                this._DCNV_DT = value;
                _UpdateFieldName.Add("DCNV_DT");
            }
        }
        public String DCNV_Remark
        {
            get
            {
                return this._DCNV_Remark;
            }
            set
            {
                this._DCNV_Remark = value;
                _UpdateFieldName.Add("DCNV_Remark");
            }
        }

        
        public Int16 DCNV_L1AuthorizeID
        {
            get
            {
                return this._DCNV_L1AuthorizeID;
            }
            set
            {
                this._DCNV_L1AuthorizeID = value;
                _UpdateFieldName.Add("DCNV_L1AuthorizeID");
            }
        }
        public String DCNV_L1AuthorizeBy
        {
            get
            {
                return this._DCNV_L1AuthorizeBy;
            }
            set
            {
                this._DCNV_L1AuthorizeBy = value;
                _UpdateFieldName.Add("DCNV_L1AuthorizeBy");
            }
        }
        public String DCNV_L1AuthorizeDT
        {
            get
            {
                return this._DCNV_L1AuthorizeDT;
            }
            set
            {
                this._DCNV_L1AuthorizeDT = value;
                _UpdateFieldName.Add("DCNV_L1AuthorizeDT");
            }
        }
        public Int16 DCNV_L2AuthorizeID
        {
            get
            {
                return this._DCNV_L2AuthorizeID;
            }
            set
            {
                this._DCNV_L2AuthorizeID = value;
                _UpdateFieldName.Add("DCNV_L2AuthorizeID");
            }
        }
        public String DCNV_L2AuthorizeBy
        {
            get
            {
                return this._DCNV_L2AuthorizeBy;
            }
            set
            {
                this._DCNV_L2AuthorizeBy = value;
                _UpdateFieldName.Add("DCNV_L2AuthorizeBy");
            }
        }
        public String DCNV_L2AuthorizeDT
        {
            get
            {
                return this._DCNV_L2AuthorizeDT;
            }
            set
            {
                this._DCNV_L2AuthorizeDT = value;
                _UpdateFieldName.Add("DCNV_L2AuthorizeDT");
            }
        }
        public String DCNV_AuthRemark
        {
            get
            {
                return this._DCNV_AuthRemark;
            }
            set
            {
                this._DCNV_AuthRemark = value;
                _UpdateFieldName.Add("DCNV_AuthRemark");
            }
        }
        public Int16 DCNV_DTL_CNT
        {
            get
            {
                return this._DCNV_DTL_CNT;
            }
            set
            {
                this._DCNV_DTL_CNT = value;
                _UpdateFieldName.Add("DCNV_DTL_CNT");
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
        public Decimal DCNV_HDR_BasicAmt
        {
            get
            {
                return this._DCNV_HDR_BasicAmt;
            }
            set
            {
                this._DCNV_HDR_BasicAmt = value;
                _UpdateFieldName.Add("DCNV_HDR_BasicAmt");
            }
        }
        public Decimal DCNV_HDR_DiscountRate
        {
            get
            {
                return this._DCNV_HDR_DiscountRate;
            }
            set
            {
                this._DCNV_HDR_DiscountRate = value;
                _UpdateFieldName.Add("DCNV_HDR_DiscountRate");
            }
        }
        public Decimal DCNV_HDR_DiscountAmt
        {
            get
            {
                return this._DCNV_HDR_DiscountAmt;
            }
            set
            {
                this._DCNV_HDR_DiscountAmt = value;
                _UpdateFieldName.Add("DCNV_HDR_DiscountAmt");
            }
        }
        public Decimal DCNV_HDR_Net_Amt
        {
            get
            {
                return this._DCNV_HDR_Net_Amt;
            }
            set
            {
                this._DCNV_HDR_Net_Amt = value;
                _UpdateFieldName.Add("DCNV_HDR_Net_Amt");
            }
        }
        public Decimal DCNV_HDR_Freight_Charges
        {
            get
            {
                return this._DCNV_HDR_Freight_Charges;
            }
            set
            {
                this._DCNV_HDR_Freight_Charges = value;
                _UpdateFieldName.Add("DCNV_HDR_Freight_Charges");
            }
        }
        public Decimal DCNV_HDR_Loading_N_Packing_Charges
        {
            get
            {
                return this._DCNV_HDR_Loading_N_Packing_Charges;
            }
            set
            {
                this._DCNV_HDR_Loading_N_Packing_Charges = value;
                _UpdateFieldName.Add("DCNV_HDR_Loading_N_Packing_Charges");
            }
        }
        public Decimal DCNV_HDR_Insurance_Charges
        {
            get
            {
                return this._DCNV_HDR_Insurance_Charges;
            }
            set
            {
                this._DCNV_HDR_Insurance_Charges = value;
                _UpdateFieldName.Add("DCNV_HDR_Insurance_Charges");
            }
        }
        public String DCNV_HDR_Other_Charges_Txt
        {
            get
            {
                return this._DCNV_HDR_Other_Charges_Txt;
            }
            set
            {
                this._DCNV_HDR_Other_Charges_Txt = value;
                _UpdateFieldName.Add("DCNV_HDR_Other_Charges_Txt");
            }
        }
        public Decimal DCNV_HDR_Other_Charges_Amt
        {
            get
            {
                return this._DCNV_HDR_Other_Charges_Amt;
            }
            set
            {
                this._DCNV_HDR_Other_Charges_Amt = value;
                _UpdateFieldName.Add("DCNV_HDR_Other_Charges_Amt");
            }
        }
        public Decimal DCNV_HDR_Taxable_Amt
        {
            get
            {
                return this._DCNV_HDR_Taxable_Amt;
            }
            set
            {
                this._DCNV_HDR_Taxable_Amt = value;
                _UpdateFieldName.Add("DCNV_HDR_Taxable_Amt");
            }
        }
        public Decimal DCNV_HDR_CGST_Amt
        {
            get
            {
                return this._DCNV_HDR_CGST_Amt;
            }
            set
            {
                this._DCNV_HDR_CGST_Amt = value;
                _UpdateFieldName.Add("DCNV_HDR_CGST_Amt");
            }
        }
        public Decimal DCNV_HDR_CGST_Taxable_Amt
        {
            get
            {
                return this._DCNV_HDR_CGST_Taxable_Amt;
            }
            set
            {
                this._DCNV_HDR_CGST_Taxable_Amt = value;
                _UpdateFieldName.Add("DCNV_HDR_CGST_Taxable_Amt");
            }
        }
        public Decimal DCNV_HDR_SGST_Amt
        {
            get
            {
                return this._DCNV_HDR_SGST_Amt;
            }
            set
            {
                this._DCNV_HDR_SGST_Amt = value;
                _UpdateFieldName.Add("DCNV_HDR_SGST_Amt");
            }
        }
        public Decimal DCNV_HDR_SGST_Taxable_Amt
        {
            get
            {
                return this._DCNV_HDR_SGST_Taxable_Amt;
            }
            set
            {
                this._DCNV_HDR_SGST_Taxable_Amt = value;
                _UpdateFieldName.Add("DCNV_HDR_SGST_Taxable_Amt");
            }
        }
        public Decimal DCNV_HDR_IGST_Amt
        {
            get
            {
                return this._DCNV_HDR_IGST_Amt;
            }
            set
            {
                this._DCNV_HDR_IGST_Amt = value;
                _UpdateFieldName.Add("DCNV_HDR_IGST_Amt");
            }
        }
        public Decimal DCNV_HDR_IGST_Taxable_Amt
        {
            get
            {
                return this._DCNV_HDR_IGST_Taxable_Amt;
            }
            set
            {
                this._DCNV_HDR_IGST_Taxable_Amt = value;
                _UpdateFieldName.Add("DCNV_HDR_IGST_Taxable_Amt");
            }
        }
        public Decimal DCNV_HDR_CESS_Amt
        {
            get
            {
                return this._DCNV_HDR_CESS_Amt;
            }
            set
            {
                this._DCNV_HDR_CESS_Amt = value;
                _UpdateFieldName.Add("DCNV_HDR_CESS_Amt");
            }
        }
        public Decimal DCNV_HDR_CESS_Taxable_Amt
        {
            get
            {
                return this._DCNV_HDR_CESS_Taxable_Amt;
            }
            set
            {
                this._DCNV_HDR_CESS_Taxable_Amt = value;
                _UpdateFieldName.Add("DCNV_HDR_CESS_Taxable_Amt");
            }
        }
        public Int16 DCNV_HDR_OtherTax_ID
        {
            get
            {
                return this._DCNV_HDR_OtherTax_ID;
            }
            set
            {
                this._DCNV_HDR_OtherTax_ID = value;
                _UpdateFieldName.Add("DCNV_HDR_OtherTax_ID");
            }
        }
        public Decimal DCNV_HDR_OtherTax_Rate
        {
            get
            {
                return this._DCNV_HDR_OtherTax_Rate;
            }
            set
            {
                this._DCNV_HDR_OtherTax_Rate = value;
                _UpdateFieldName.Add("DCNV_HDR_OtherTax_Rate");
            }
        }
        public Decimal DCNV_HDR_OtherTax_Amt
        {
            get
            {
                return this._DCNV_HDR_OtherTax_Amt;
            }
            set
            {
                this._DCNV_HDR_OtherTax_Amt = value;
                _UpdateFieldName.Add("DCNV_HDR_OtherTax_Amt");
            }
        }
        public Decimal DCNV_HDR_Other_Taxable_Amt
        {
            get
            {
                return this._DCNV_HDR_Other_Taxable_Amt;
            }
            set
            {
                this._DCNV_HDR_Other_Taxable_Amt = value;
                _UpdateFieldName.Add("DCNV_HDR_Other_Taxable_Amt");
            }
        }
        public Decimal DCNV_HDR_Total_Tax_Amt
        {
            get
            {
                return this._DCNV_HDR_Total_Tax_Amt;
            }
            set
            {
                this._DCNV_HDR_Total_Tax_Amt = value;
                _UpdateFieldName.Add("DCNV_HDR_Total_Tax_Amt");
            }
        }
        public Decimal DCNV_HDR_ItemGross_Total_Amt
        {
            get
            {
                return this._DCNV_HDR_ItemGross_Total_Amt;
            }
            set
            {
                this._DCNV_HDR_ItemGross_Total_Amt = value;
                _UpdateFieldName.Add("DCNV_HDR_ItemGross_Total_Amt");
            }
        }
        public Decimal DCNV_HDR_Gross_Amt
        {
            get
            {
                return this._DCNV_HDR_Gross_Amt;
            }
            set
            {
                this._DCNV_HDR_Gross_Amt = value;
                _UpdateFieldName.Add("DCNV_HDR_Gross_Amt");
            }
        }
        public Decimal DCNV_HDR_Round_Off_Amt
        {
            get
            {
                return this._DCNV_HDR_Round_Off_Amt;
            }
            set
            {
                this._DCNV_HDR_Round_Off_Amt = value;
                _UpdateFieldName.Add("DCNV_HDR_Round_Off_Amt");
            }
        }
        public Decimal DCNV_HDR_Total_Gross_Amt
        {
            get
            {
                return this._DCNV_HDR_Total_Gross_Amt;
            }
            set
            {
                this._DCNV_HDR_Total_Gross_Amt = value;
                _UpdateFieldName.Add("DCNV_HDR_Total_Gross_Amt");
            }
        }
        public String DCNV_HDR_Gross_AmtInWords
        {
            get
            {
                return this._DCNV_HDR_Gross_AmtInWords;
            }
            set
            {
                this._DCNV_HDR_Gross_AmtInWords = value;
                _UpdateFieldName.Add("DCNV_HDR_Gross_AmtInWords");
            }
        }

        #endregion
        #region Genric Methods
        public string Insert_Update(M_AT_DNC_Ven_AHDRBO sObject)
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

// ObjAT_DCNVHDR.DCNVHDR_ID=ObjAT_DCNVHDR.DCNVHDR_ID;
// ObjAT_DCNVHDR.Fk_Company_ID=ObjAT_DCNVHDR.Fk_Company_ID;
// ObjAT_DCNVHDR.Fk_Branch_ID=ObjAT_DCNVHDR.Fk_Branch_ID;
// ObjAT_DCNVHDR.Fk_Year_ID=ObjAT_DCNVHDR.Fk_Year_ID;
// ObjAT_DCNVHDR.Fk_INVHDR_ID=ObjAT_DCNVHDR.Fk_INVHDR_ID;
// ObjAT_DCNVHDR.Rec_Created_In=ObjAT_DCNVHDR.Rec_Created_In;
// ObjAT_DCNVHDR.Rec_CreatedBy_ID=ObjAT_DCNVHDR.Rec_CreatedBy_ID;
// ObjAT_DCNVHDR.Rec_CreatedFor_ID=ObjAT_DCNVHDR.Rec_CreatedFor_ID;
// ObjAT_DCNVHDR.DCNV_CreationType=ObjAT_DCNVHDR.DCNV_CreationType;
// ObjAT_DCNVHDR.DCNV_Type=ObjAT_DCNVHDR.DCNV_Type;
// ObjAT_DCNVHDR.DCNV_Taxtype=ObjAT_DCNVHDR.DCNV_Taxtype;
// ObjAT_DCNVHDR.DCNV_No=ObjAT_DCNVHDR.DCNV_No;
// ObjAT_DCNVHDR.DCNV_DT=ObjAT_DCNVHDR.DCNV_DT;
// ObjAT_DCNVHDR.DCNV_Remark=ObjAT_DCNVHDR.DCNV_Remark;
// ObjAT_DCNVHDR.DCNV_L1AuthorizeID=ObjAT_DCNVHDR.DCNV_L1AuthorizeID;
// ObjAT_DCNVHDR.DCNV_L1AuthorizeBy=ObjAT_DCNVHDR.DCNV_L1AuthorizeBy;
// ObjAT_DCNVHDR.DCNV_L1AuthorizeDT=ObjAT_DCNVHDR.DCNV_L1AuthorizeDT;
// ObjAT_DCNVHDR.DCNV_L2AuthorizeID=ObjAT_DCNVHDR.DCNV_L2AuthorizeID;
// ObjAT_DCNVHDR.DCNV_L2AuthorizeBy=ObjAT_DCNVHDR.DCNV_L2AuthorizeBy;
// ObjAT_DCNVHDR.DCNV_L2AuthorizeDT=ObjAT_DCNVHDR.DCNV_L2AuthorizeDT;
// ObjAT_DCNVHDR.DCNV_AuthRemark=ObjAT_DCNVHDR.DCNV_AuthRemark;
// ObjAT_DCNVHDR.DCNV_DTL_CNT=ObjAT_DCNVHDR.DCNV_DTL_CNT;
// ObjAT_DCNVHDR.MDBSC_RowStatus=ObjAT_DCNVHDR.MDBSC_RowStatus;
// ObjAT_DCNVHDR.MDBSC_RowCreatedByUser_ID=ObjAT_DCNVHDR.MDBSC_RowCreatedByUser_ID;
// ObjAT_DCNVHDR.MDBSC_RowCreatedByUserName=ObjAT_DCNVHDR.MDBSC_RowCreatedByUserName;
// ObjAT_DCNVHDR.MDBSC_RowCreatedOn_DT=ObjAT_DCNVHDR.MDBSC_RowCreatedOn_DT;
// ObjAT_DCNVHDR.MDBSC_RowLupdnByUser_ID=ObjAT_DCNVHDR.MDBSC_RowLupdnByUser_ID;
// ObjAT_DCNVHDR.MDBSC_RowLupdnUserName=ObjAT_DCNVHDR.MDBSC_RowLupdnUserName;
// ObjAT_DCNVHDR.MDBSC_RowLupdnOn_DT=ObjAT_DCNVHDR.MDBSC_RowLupdnOn_DT;
// ObjAT_DCNVHDR.DCNV_HDR_BasicAmt=ObjAT_DCNVHDR.DCNV_HDR_BasicAmt;
// ObjAT_DCNVHDR.DCNV_HDR_DiscountRate=ObjAT_DCNVHDR.DCNV_HDR_DiscountRate;
// ObjAT_DCNVHDR.DCNV_HDR_DiscountAmt=ObjAT_DCNVHDR.DCNV_HDR_DiscountAmt;
// ObjAT_DCNVHDR.DCNV_HDR_Net_Amt=ObjAT_DCNVHDR.DCNV_HDR_Net_Amt;
// ObjAT_DCNVHDR.DCNV_HDR_Freight_Charges=ObjAT_DCNVHDR.DCNV_HDR_Freight_Charges;
// ObjAT_DCNVHDR.DCNV_HDR_Loading_N_Packing_Charges=ObjAT_DCNVHDR.DCNV_HDR_Loading_N_Packing_Charges;
// ObjAT_DCNVHDR.DCNV_HDR_Insurance_Charges=ObjAT_DCNVHDR.DCNV_HDR_Insurance_Charges;
// ObjAT_DCNVHDR.DCNV_HDR_Other_Charges_Txt=ObjAT_DCNVHDR.DCNV_HDR_Other_Charges_Txt;
// ObjAT_DCNVHDR.DCNV_HDR_Other_Charges_Amt=ObjAT_DCNVHDR.DCNV_HDR_Other_Charges_Amt;
// ObjAT_DCNVHDR.DCNV_HDR_Taxable_Amt=ObjAT_DCNVHDR.DCNV_HDR_Taxable_Amt;
// ObjAT_DCNVHDR.DCNV_HDR_CGST_Amt=ObjAT_DCNVHDR.DCNV_HDR_CGST_Amt;
// ObjAT_DCNVHDR.DCNV_HDR_CGST_Taxable_Amt=ObjAT_DCNVHDR.DCNV_HDR_CGST_Taxable_Amt;
// ObjAT_DCNVHDR.DCNV_HDR_SGST_Amt=ObjAT_DCNVHDR.DCNV_HDR_SGST_Amt;
// ObjAT_DCNVHDR.DCNV_HDR_SGST_Taxable_Amt=ObjAT_DCNVHDR.DCNV_HDR_SGST_Taxable_Amt;
// ObjAT_DCNVHDR.DCNV_HDR_IGST_Amt=ObjAT_DCNVHDR.DCNV_HDR_IGST_Amt;
// ObjAT_DCNVHDR.DCNV_HDR_IGST_Taxable_Amt=ObjAT_DCNVHDR.DCNV_HDR_IGST_Taxable_Amt;
// ObjAT_DCNVHDR.DCNV_HDR_CESS_Amt=ObjAT_DCNVHDR.DCNV_HDR_CESS_Amt;
// ObjAT_DCNVHDR.DCNV_HDR_CESS_Taxable_Amt=ObjAT_DCNVHDR.DCNV_HDR_CESS_Taxable_Amt;
// ObjAT_DCNVHDR.DCNV_HDR_OtherTax_ID=ObjAT_DCNVHDR.DCNV_HDR_OtherTax_ID;
// ObjAT_DCNVHDR.DCNV_HDR_OtherTax_Rate=ObjAT_DCNVHDR.DCNV_HDR_OtherTax_Rate;
// ObjAT_DCNVHDR.DCNV_HDR_OtherTax_Amt=ObjAT_DCNVHDR.DCNV_HDR_OtherTax_Amt;
// ObjAT_DCNVHDR.DCNV_HDR_Other_Taxable_Amt=ObjAT_DCNVHDR.DCNV_HDR_Other_Taxable_Amt;
// ObjAT_DCNVHDR.DCNV_HDR_Total_Tax_Amt=ObjAT_DCNVHDR.DCNV_HDR_Total_Tax_Amt;
// ObjAT_DCNVHDR.DCNV_HDR_ItemGross_Total_Amt=ObjAT_DCNVHDR.DCNV_HDR_ItemGross_Total_Amt;
// ObjAT_DCNVHDR.DCNV_HDR_Gross_Amt=ObjAT_DCNVHDR.DCNV_HDR_Gross_Amt;
// ObjAT_DCNVHDR.DCNV_HDR_Round_Off_Amt=ObjAT_DCNVHDR.DCNV_HDR_Round_Off_Amt;
// ObjAT_DCNVHDR.DCNV_HDR_Total_Gross_Amt=ObjAT_DCNVHDR.DCNV_HDR_Total_Gross_Amt;
// ObjAT_DCNVHDR.DCNV_HDR_Gross_AmtInWords=ObjAT_DCNVHDR.DCNV_HDR_Gross_AmtInWords;



// DCNVHDR_ID.Text = "";
// Fk_Company_ID.Text = "";
// Fk_Branch_ID.Text = "";
// Fk_Year_ID.Text = "";
// Fk_INVHDR_ID.Text = "";
// Rec_Created_In.Text = "";
// Rec_CreatedBy_ID.Text = "";
// Rec_CreatedFor_ID.Text = "";
// DCNV_CreationType.Text = "";
// DCNV_Type.Text = "";
// DCNV_Taxtype.Text = "";
// DCNV_No.Text = "";
// DCNV_DT.Text = "";
// DCNV_Remark.Text = "";
// DCNV_L1AuthorizeID.Text = "";
// DCNV_L1AuthorizeBy.Text = "";
// DCNV_L1AuthorizeDT.Text = "";
// DCNV_L2AuthorizeID.Text = "";
// DCNV_L2AuthorizeBy.Text = "";
// DCNV_L2AuthorizeDT.Text = "";
// DCNV_AuthRemark.Text = "";
// DCNV_DTL_CNT.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";
// DCNV_HDR_BasicAmt.Text = "";
// DCNV_HDR_DiscountRate.Text = "";
// DCNV_HDR_DiscountAmt.Text = "";
// DCNV_HDR_Net_Amt.Text = "";
// DCNV_HDR_Freight_Charges.Text = "";
// DCNV_HDR_Loading_N_Packing_Charges.Text = "";
// DCNV_HDR_Insurance_Charges.Text = "";
// DCNV_HDR_Other_Charges_Txt.Text = "";
// DCNV_HDR_Other_Charges_Amt.Text = "";
// DCNV_HDR_Taxable_Amt.Text = "";
// DCNV_HDR_CGST_Amt.Text = "";
// DCNV_HDR_CGST_Taxable_Amt.Text = "";
// DCNV_HDR_SGST_Amt.Text = "";
// DCNV_HDR_SGST_Taxable_Amt.Text = "";
// DCNV_HDR_IGST_Amt.Text = "";
// DCNV_HDR_IGST_Taxable_Amt.Text = "";
// DCNV_HDR_CESS_Amt.Text = "";
// DCNV_HDR_CESS_Taxable_Amt.Text = "";
// DCNV_HDR_OtherTax_ID.Text = "";
// DCNV_HDR_OtherTax_Rate.Text = "";
// DCNV_HDR_OtherTax_Amt.Text = "";
// DCNV_HDR_Other_Taxable_Amt.Text = "";
// DCNV_HDR_Total_Tax_Amt.Text = "";
// DCNV_HDR_ItemGross_Total_Amt.Text = "";
// DCNV_HDR_Gross_Amt.Text = "";
// DCNV_HDR_Round_Off_Amt.Text = "";
// DCNV_HDR_Total_Gross_Amt.Text = "";
// DCNV_HDR_Gross_AmtInWords.Text = "";



// ObjAT_DCNVHDR.DCNVHDR_ID=DCNVHDR_ID.Text ;
// ObjAT_DCNVHDR.Fk_Company_ID=Fk_Company_ID.Text ;
// ObjAT_DCNVHDR.Fk_Branch_ID=Fk_Branch_ID.Text ;
// ObjAT_DCNVHDR.Fk_Year_ID=Fk_Year_ID.Text ;
// ObjAT_DCNVHDR.Fk_INVHDR_ID=Fk_INVHDR_ID.Text ;
// ObjAT_DCNVHDR.Rec_Created_In=Rec_Created_In.Text ;
// ObjAT_DCNVHDR.Rec_CreatedBy_ID=Rec_CreatedBy_ID.Text ;
// ObjAT_DCNVHDR.Rec_CreatedFor_ID=Rec_CreatedFor_ID.Text ;
// ObjAT_DCNVHDR.DCNV_CreationType=DCNV_CreationType.Text ;
// ObjAT_DCNVHDR.DCNV_Type=DCNV_Type.Text ;
// ObjAT_DCNVHDR.DCNV_Taxtype=DCNV_Taxtype.Text ;
// ObjAT_DCNVHDR.DCNV_No=DCNV_No.Text ;
// ObjAT_DCNVHDR.DCNV_DT=DCNV_DT.Text ;
// ObjAT_DCNVHDR.DCNV_Remark=DCNV_Remark.Text ;
// ObjAT_DCNVHDR.DCNV_L1AuthorizeID=DCNV_L1AuthorizeID.Text ;
// ObjAT_DCNVHDR.DCNV_L1AuthorizeBy=DCNV_L1AuthorizeBy.Text ;
// ObjAT_DCNVHDR.DCNV_L1AuthorizeDT=DCNV_L1AuthorizeDT.Text ;
// ObjAT_DCNVHDR.DCNV_L2AuthorizeID=DCNV_L2AuthorizeID.Text ;
// ObjAT_DCNVHDR.DCNV_L2AuthorizeBy=DCNV_L2AuthorizeBy.Text ;
// ObjAT_DCNVHDR.DCNV_L2AuthorizeDT=DCNV_L2AuthorizeDT.Text ;
// ObjAT_DCNVHDR.DCNV_AuthRemark=DCNV_AuthRemark.Text ;
// ObjAT_DCNVHDR.DCNV_DTL_CNT=DCNV_DTL_CNT.Text ;
// ObjAT_DCNVHDR.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_DCNVHDR.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_DCNVHDR.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_DCNVHDR.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_DCNVHDR.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_DCNVHDR.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_DCNVHDR.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_BasicAmt=DCNV_HDR_BasicAmt.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_DiscountRate=DCNV_HDR_DiscountRate.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_DiscountAmt=DCNV_HDR_DiscountAmt.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_Net_Amt=DCNV_HDR_Net_Amt.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_Freight_Charges=DCNV_HDR_Freight_Charges.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_Loading_N_Packing_Charges=DCNV_HDR_Loading_N_Packing_Charges.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_Insurance_Charges=DCNV_HDR_Insurance_Charges.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_Other_Charges_Txt=DCNV_HDR_Other_Charges_Txt.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_Other_Charges_Amt=DCNV_HDR_Other_Charges_Amt.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_Taxable_Amt=DCNV_HDR_Taxable_Amt.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_CGST_Amt=DCNV_HDR_CGST_Amt.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_CGST_Taxable_Amt=DCNV_HDR_CGST_Taxable_Amt.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_SGST_Amt=DCNV_HDR_SGST_Amt.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_SGST_Taxable_Amt=DCNV_HDR_SGST_Taxable_Amt.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_IGST_Amt=DCNV_HDR_IGST_Amt.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_IGST_Taxable_Amt=DCNV_HDR_IGST_Taxable_Amt.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_CESS_Amt=DCNV_HDR_CESS_Amt.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_CESS_Taxable_Amt=DCNV_HDR_CESS_Taxable_Amt.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_OtherTax_ID=DCNV_HDR_OtherTax_ID.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_OtherTax_Rate=DCNV_HDR_OtherTax_Rate.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_OtherTax_Amt=DCNV_HDR_OtherTax_Amt.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_Other_Taxable_Amt=DCNV_HDR_Other_Taxable_Amt.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_Total_Tax_Amt=DCNV_HDR_Total_Tax_Amt.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_ItemGross_Total_Amt=DCNV_HDR_ItemGross_Total_Amt.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_Gross_Amt=DCNV_HDR_Gross_Amt.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_Round_Off_Amt=DCNV_HDR_Round_Off_Amt.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_Total_Gross_Amt=DCNV_HDR_Total_Gross_Amt.Text ;
// ObjAT_DCNVHDR.DCNV_HDR_Gross_AmtInWords=DCNV_HDR_Gross_AmtInWords.Text ;



// DCNVHDR_ID.Text =  dt.Rows[0]["DCNVHDR_ID"].ToString();
// Fk_Company_ID.Text =  dt.Rows[0]["Fk_Company_ID"].ToString();
// Fk_Branch_ID.Text =  dt.Rows[0]["Fk_Branch_ID"].ToString();
// Fk_Year_ID.Text =  dt.Rows[0]["Fk_Year_ID"].ToString();
// Fk_INVHDR_ID.Text =  dt.Rows[0]["Fk_INVHDR_ID"].ToString();
// Rec_Created_In.Text =  dt.Rows[0]["Rec_Created_In"].ToString();
// Rec_CreatedBy_ID.Text =  dt.Rows[0]["Rec_CreatedBy_ID"].ToString();
// Rec_CreatedFor_ID.Text =  dt.Rows[0]["Rec_CreatedFor_ID"].ToString();
// DCNV_CreationType.Text =  dt.Rows[0]["DCNV_CreationType"].ToString();
// DCNV_Type.Text =  dt.Rows[0]["DCNV_Type"].ToString();
// DCNV_Taxtype.Text =  dt.Rows[0]["DCNV_Taxtype"].ToString();
// DCNV_No.Text =  dt.Rows[0]["DCNV_No"].ToString();
// DCNV_DT.Text =  dt.Rows[0]["DCNV_DT"].ToString();
// DCNV_Remark.Text =  dt.Rows[0]["DCNV_Remark"].ToString();
// DCNV_L1AuthorizeID.Text =  dt.Rows[0]["DCNV_L1AuthorizeID"].ToString();
// DCNV_L1AuthorizeBy.Text =  dt.Rows[0]["DCNV_L1AuthorizeBy"].ToString();
// DCNV_L1AuthorizeDT.Text =  dt.Rows[0]["DCNV_L1AuthorizeDT"].ToString();
// DCNV_L2AuthorizeID.Text =  dt.Rows[0]["DCNV_L2AuthorizeID"].ToString();
// DCNV_L2AuthorizeBy.Text =  dt.Rows[0]["DCNV_L2AuthorizeBy"].ToString();
// DCNV_L2AuthorizeDT.Text =  dt.Rows[0]["DCNV_L2AuthorizeDT"].ToString();
// DCNV_AuthRemark.Text =  dt.Rows[0]["DCNV_AuthRemark"].ToString();
// DCNV_DTL_CNT.Text =  dt.Rows[0]["DCNV_DTL_CNT"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
// DCNV_HDR_BasicAmt.Text =  dt.Rows[0]["DCNV_HDR_BasicAmt"].ToString();
// DCNV_HDR_DiscountRate.Text =  dt.Rows[0]["DCNV_HDR_DiscountRate"].ToString();
// DCNV_HDR_DiscountAmt.Text =  dt.Rows[0]["DCNV_HDR_DiscountAmt"].ToString();
// DCNV_HDR_Net_Amt.Text =  dt.Rows[0]["DCNV_HDR_Net_Amt"].ToString();
// DCNV_HDR_Freight_Charges.Text =  dt.Rows[0]["DCNV_HDR_Freight_Charges"].ToString();
// DCNV_HDR_Loading_N_Packing_Charges.Text =  dt.Rows[0]["DCNV_HDR_Loading_N_Packing_Charges"].ToString();
// DCNV_HDR_Insurance_Charges.Text =  dt.Rows[0]["DCNV_HDR_Insurance_Charges"].ToString();
// DCNV_HDR_Other_Charges_Txt.Text =  dt.Rows[0]["DCNV_HDR_Other_Charges_Txt"].ToString();
// DCNV_HDR_Other_Charges_Amt.Text =  dt.Rows[0]["DCNV_HDR_Other_Charges_Amt"].ToString();
// DCNV_HDR_Taxable_Amt.Text =  dt.Rows[0]["DCNV_HDR_Taxable_Amt"].ToString();
// DCNV_HDR_CGST_Amt.Text =  dt.Rows[0]["DCNV_HDR_CGST_Amt"].ToString();
// DCNV_HDR_CGST_Taxable_Amt.Text =  dt.Rows[0]["DCNV_HDR_CGST_Taxable_Amt"].ToString();
// DCNV_HDR_SGST_Amt.Text =  dt.Rows[0]["DCNV_HDR_SGST_Amt"].ToString();
// DCNV_HDR_SGST_Taxable_Amt.Text =  dt.Rows[0]["DCNV_HDR_SGST_Taxable_Amt"].ToString();
// DCNV_HDR_IGST_Amt.Text =  dt.Rows[0]["DCNV_HDR_IGST_Amt"].ToString();
// DCNV_HDR_IGST_Taxable_Amt.Text =  dt.Rows[0]["DCNV_HDR_IGST_Taxable_Amt"].ToString();
// DCNV_HDR_CESS_Amt.Text =  dt.Rows[0]["DCNV_HDR_CESS_Amt"].ToString();
// DCNV_HDR_CESS_Taxable_Amt.Text =  dt.Rows[0]["DCNV_HDR_CESS_Taxable_Amt"].ToString();
// DCNV_HDR_OtherTax_ID.Text =  dt.Rows[0]["DCNV_HDR_OtherTax_ID"].ToString();
// DCNV_HDR_OtherTax_Rate.Text =  dt.Rows[0]["DCNV_HDR_OtherTax_Rate"].ToString();
// DCNV_HDR_OtherTax_Amt.Text =  dt.Rows[0]["DCNV_HDR_OtherTax_Amt"].ToString();
// DCNV_HDR_Other_Taxable_Amt.Text =  dt.Rows[0]["DCNV_HDR_Other_Taxable_Amt"].ToString();
// DCNV_HDR_Total_Tax_Amt.Text =  dt.Rows[0]["DCNV_HDR_Total_Tax_Amt"].ToString();
// DCNV_HDR_ItemGross_Total_Amt.Text =  dt.Rows[0]["DCNV_HDR_ItemGross_Total_Amt"].ToString();
// DCNV_HDR_Gross_Amt.Text =  dt.Rows[0]["DCNV_HDR_Gross_Amt"].ToString();
// DCNV_HDR_Round_Off_Amt.Text =  dt.Rows[0]["DCNV_HDR_Round_Off_Amt"].ToString();
// DCNV_HDR_Total_Gross_Amt.Text =  dt.Rows[0]["DCNV_HDR_Total_Gross_Amt"].ToString();
// DCNV_HDR_Gross_AmtInWords.Text =  dt.Rows[0]["DCNV_HDR_Gross_AmtInWords"].ToString();
