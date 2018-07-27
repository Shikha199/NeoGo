using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal
{
    public class M_AT_DNC_Cust_BDTLBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public M_AT_DNC_Cust_BDTLBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "DCNCDTL_ID";
        private string _TableName = "M_AT_DNC_Cust_BDTL";
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

        private Int64 _DCNCDTL_ID;
        private Int64 _Fk_DCNCHDR_ID;
        private Int64 _Fk_MItem_ID;
        private String _DCNC_HSNCode;
        private Decimal _DCNC_QTY;
        private Decimal _DCNC_BasicRate;
        private Decimal _DCNC_NetRate;
        private Decimal _DCNC_BasicAmt;
        private Decimal _DCNC_DiscountRate;
        private Decimal _DCNC_DiscountAmt;
        private Decimal _DCNC_NetTaxableAmt;
        private Int16 _DCNC_CGST_ID;
        private Decimal _DCNC_CGST_Rate;
        private Decimal _DCNC_CGST_Amt;
        private Decimal _DCNC_CGST_TaxableAmt;
        private Int16 _DCNC_SGST_ID;
        private Decimal _DCNC_SGST_Rate;
        private Decimal _DCNC_SGST_Amt;
        private Decimal _DCNC_SGST_TaxableAmt;
        private Int16 _DCNC_IGST_ID;
        private Decimal _DCNC_IGST_Rate;
        private Decimal _DCNC_IGST_Amt;
        private Decimal _DCNC_IGST_TaxableAmt;
        private Int16 _DCNC_CESS_ID;
        private Decimal _DCNC_CESS_Rate;
        private Decimal _DCNC_CESS_Amt;
        private Decimal _DCNC_CESS_TaxableAmt;
        private Int16 _DCNC_OtherTax_ID;
        private Decimal _DCNC_OtherTax_Rate;
        private Decimal _DCNC_OtherTax_Amt;
        private Decimal _DCNC_OtherTax_TaxableAmt;
        private Decimal _DCNC_TotalTax;
        private Decimal _DCNC_GrossRateWithTax;
        private String _MDBSC_RowStatus;
        private String _DCNC_ItemRemark_DTL;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;

        public Int64 DCNCDTL_ID
        {
            get
            {
                return this._DCNCDTL_ID;
            }
            set
            {
                this._DCNCDTL_ID = value;
                _UpdateFieldName.Add("DCNCDTL_ID");
            }
        }
        public Int64 Fk_DCNCHDR_ID
        {
            get
            {
                return this._Fk_DCNCHDR_ID;
            }
            set
            {
                this._Fk_DCNCHDR_ID = value;
                _UpdateFieldName.Add("Fk_DCNCHDR_ID");
            }
        }
        public Int64 Fk_MItem_ID
        {
            get
            {
                return this._Fk_MItem_ID;
            }
            set
            {
                this._Fk_MItem_ID = value;
                _UpdateFieldName.Add("Fk_MItem_ID");
            }
        }
        public String DCNC_HSNCode
        {
            get
            {
                return this._DCNC_HSNCode;
            }
            set
            {
                this._DCNC_HSNCode = value;
                _UpdateFieldName.Add("DCNC_HSNCode");
            }
        }
        public Decimal DCNC_QTY
        {
            get
            {
                return this._DCNC_QTY;
            }
            set
            {
                this._DCNC_QTY = value;
                _UpdateFieldName.Add("DCNC_QTY");
            }
        }
        public Decimal DCNC_BasicRate
        {
            get
            {
                return this._DCNC_BasicRate;
            }
            set
            {
                this._DCNC_BasicRate = value;
                _UpdateFieldName.Add("DCNC_BasicRate");
            }
        }
        public Decimal DCNC_NetRate
        {
            get
            {
                return this._DCNC_NetRate;
            }
            set
            {
                this._DCNC_NetRate = value;
                _UpdateFieldName.Add("DCNC_NetRate");
            }
        }
        public Decimal DCNC_BasicAmt
        {
            get
            {
                return this._DCNC_BasicAmt;
            }
            set
            {
                this._DCNC_BasicAmt = value;
                _UpdateFieldName.Add("DCNC_BasicAmt");
            }
        }
        public Decimal DCNC_DiscountRate
        {
            get
            {
                return this._DCNC_DiscountRate;
            }
            set
            {
                this._DCNC_DiscountRate = value;
                _UpdateFieldName.Add("DCNC_DiscountRate");
            }
        }
        public Decimal DCNC_DiscountAmt
        {
            get
            {
                return this._DCNC_DiscountAmt;
            }
            set
            {
                this._DCNC_DiscountAmt = value;
                _UpdateFieldName.Add("DCNC_DiscountAmt");
            }
        }
        public Decimal DCNC_NetTaxableAmt
        {
            get
            {
                return this._DCNC_NetTaxableAmt;
            }
            set
            {
                this._DCNC_NetTaxableAmt = value;
                _UpdateFieldName.Add("DCNC_NetTaxableAmt");
            }
        }
        public Int16 DCNC_CGST_ID
        {
            get
            {
                return this._DCNC_CGST_ID;
            }
            set
            {
                this._DCNC_CGST_ID = value;
                _UpdateFieldName.Add("DCNC_CGST_ID");
            }
        }
        public Decimal DCNC_CGST_Rate
        {
            get
            {
                return this._DCNC_CGST_Rate;
            }
            set
            {
                this._DCNC_CGST_Rate = value;
                _UpdateFieldName.Add("DCNC_CGST_Rate");
            }
        }
        public Decimal DCNC_CGST_Amt
        {
            get
            {
                return this._DCNC_CGST_Amt;
            }
            set
            {
                this._DCNC_CGST_Amt = value;
                _UpdateFieldName.Add("DCNC_CGST_Amt");
            }
        }
        public Decimal DCNC_CGST_TaxableAmt
        {
            get
            {
                return this._DCNC_CGST_TaxableAmt;
            }
            set
            {
                this._DCNC_CGST_TaxableAmt = value;
                _UpdateFieldName.Add("DCNC_CGST_TaxableAmt");
            }
        }
        public Int16 DCNC_SGST_ID
        {
            get
            {
                return this._DCNC_SGST_ID;
            }
            set
            {
                this._DCNC_SGST_ID = value;
                _UpdateFieldName.Add("DCNC_SGST_ID");
            }
        }
        public Decimal DCNC_SGST_Rate
        {
            get
            {
                return this._DCNC_SGST_Rate;
            }
            set
            {
                this._DCNC_SGST_Rate = value;
                _UpdateFieldName.Add("DCNC_SGST_Rate");
            }
        }
        public Decimal DCNC_SGST_Amt
        {
            get
            {
                return this._DCNC_SGST_Amt;
            }
            set
            {
                this._DCNC_SGST_Amt = value;
                _UpdateFieldName.Add("DCNC_SGST_Amt");
            }
        }
        public Decimal DCNC_SGST_TaxableAmt
        {
            get
            {
                return this._DCNC_SGST_TaxableAmt;
            }
            set
            {
                this._DCNC_SGST_TaxableAmt = value;
                _UpdateFieldName.Add("DCNC_SGST_TaxableAmt");
            }
        }
        public Int16 DCNC_IGST_ID
        {
            get
            {
                return this._DCNC_IGST_ID;
            }
            set
            {
                this._DCNC_IGST_ID = value;
                _UpdateFieldName.Add("DCNC_IGST_ID");
            }
        }
        public Decimal DCNC_IGST_Rate
        {
            get
            {
                return this._DCNC_IGST_Rate;
            }
            set
            {
                this._DCNC_IGST_Rate = value;
                _UpdateFieldName.Add("DCNC_IGST_Rate");
            }
        }
        public Decimal DCNC_IGST_Amt
        {
            get
            {
                return this._DCNC_IGST_Amt;
            }
            set
            {
                this._DCNC_IGST_Amt = value;
                _UpdateFieldName.Add("DCNC_IGST_Amt");
            }
        }
        public Decimal DCNC_IGST_TaxableAmt
        {
            get
            {
                return this._DCNC_IGST_TaxableAmt;
            }
            set
            {
                this._DCNC_IGST_TaxableAmt = value;
                _UpdateFieldName.Add("DCNC_IGST_TaxableAmt");
            }
        }
        public Int16 DCNC_CESS_ID
        {
            get
            {
                return this._DCNC_CESS_ID;
            }
            set
            {
                this._DCNC_CESS_ID = value;
                _UpdateFieldName.Add("DCNC_CESS_ID");
            }
        }
        public Decimal DCNC_CESS_Rate
        {
            get
            {
                return this._DCNC_CESS_Rate;
            }
            set
            {
                this._DCNC_CESS_Rate = value;
                _UpdateFieldName.Add("DCNC_CESS_Rate");
            }
        }
        public Decimal DCNC_CESS_Amt
        {
            get
            {
                return this._DCNC_CESS_Amt;
            }
            set
            {
                this._DCNC_CESS_Amt = value;
                _UpdateFieldName.Add("DCNC_CESS_Amt");
            }
        }
        public Decimal DCNC_CESS_TaxableAmt
        {
            get
            {
                return this._DCNC_CESS_TaxableAmt;
            }
            set
            {
                this._DCNC_CESS_TaxableAmt = value;
                _UpdateFieldName.Add("DCNC_CESS_TaxableAmt");
            }
        }
        public Int16 DCNC_OtherTax_ID
        {
            get
            {
                return this._DCNC_OtherTax_ID;
            }
            set
            {
                this._DCNC_OtherTax_ID = value;
                _UpdateFieldName.Add("DCNC_OtherTax_ID");
            }
        }
        public Decimal DCNC_OtherTax_Rate
        {
            get
            {
                return this._DCNC_OtherTax_Rate;
            }
            set
            {
                this._DCNC_OtherTax_Rate = value;
                _UpdateFieldName.Add("DCNC_OtherTax_Rate");
            }
        }
        public Decimal DCNC_OtherTax_Amt
        {
            get
            {
                return this._DCNC_OtherTax_Amt;
            }
            set
            {
                this._DCNC_OtherTax_Amt = value;
                _UpdateFieldName.Add("DCNC_OtherTax_Amt");
            }
        }
        public Decimal DCNC_OtherTax_TaxableAmt
        {
            get
            {
                return this._DCNC_OtherTax_TaxableAmt;
            }
            set
            {
                this._DCNC_OtherTax_TaxableAmt = value;
                _UpdateFieldName.Add("DCNC_OtherTax_TaxableAmt");
            }
        }
        public Decimal DCNC_TotalTax
        {
            get
            {
                return this._DCNC_TotalTax;
            }
            set
            {
                this._DCNC_TotalTax = value;
                _UpdateFieldName.Add("DCNC_TotalTax");
            }
        }
        public Decimal DCNC_GrossRateWithTax
        {
            get
            {
                return this._DCNC_GrossRateWithTax;
            }
            set
            {
                this._DCNC_GrossRateWithTax = value;
                _UpdateFieldName.Add("DCNC_GrossRateWithTax");
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
        public String DCNC_ItemRemark_DTL
        {
            get
            {
                return this._DCNC_ItemRemark_DTL;
            }
            set
            {
                this._DCNC_ItemRemark_DTL = value;
                _UpdateFieldName.Add("DCNC_ItemRemark_DTL");
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

        #endregion
        #region Genric Methods
        public string Insert_Update(M_AT_DNC_Cust_BDTLBO sObject)
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

// ObjAT_DCNCDTL.DCNCDTL_ID=ObjAT_DCNCDTL.DCNCDTL_ID;
// ObjAT_DCNCDTL.Fk_DCNCHDR_ID=ObjAT_DCNCDTL.Fk_DCNCHDR_ID;
// ObjAT_DCNCDTL.Fk_MItem_ID=ObjAT_DCNCDTL.Fk_MItem_ID;
// ObjAT_DCNCDTL.DCNC_HSNCode=ObjAT_DCNCDTL.DCNC_HSNCode;
// ObjAT_DCNCDTL.DCNC_QTY=ObjAT_DCNCDTL.DCNC_QTY;
// ObjAT_DCNCDTL.DCNC_BasicRate=ObjAT_DCNCDTL.DCNC_BasicRate;
// ObjAT_DCNCDTL.DCNC_NetRate=ObjAT_DCNCDTL.DCNC_NetRate;
// ObjAT_DCNCDTL.DCNC_BasicAmt=ObjAT_DCNCDTL.DCNC_BasicAmt;
// ObjAT_DCNCDTL.DCNC_DiscountRate=ObjAT_DCNCDTL.DCNC_DiscountRate;
// ObjAT_DCNCDTL.DCNC_DiscountAmt=ObjAT_DCNCDTL.DCNC_DiscountAmt;
// ObjAT_DCNCDTL.DCNC_NetTaxableAmt=ObjAT_DCNCDTL.DCNC_NetTaxableAmt;
// ObjAT_DCNCDTL.DCNC_CGST_ID=ObjAT_DCNCDTL.DCNC_CGST_ID;
// ObjAT_DCNCDTL.DCNC_CGST_Rate=ObjAT_DCNCDTL.DCNC_CGST_Rate;
// ObjAT_DCNCDTL.DCNC_CGST_Amt=ObjAT_DCNCDTL.DCNC_CGST_Amt;
// ObjAT_DCNCDTL.DCNC_CGST_TaxableAmt=ObjAT_DCNCDTL.DCNC_CGST_TaxableAmt;
// ObjAT_DCNCDTL.DCNC_SGST_ID=ObjAT_DCNCDTL.DCNC_SGST_ID;
// ObjAT_DCNCDTL.DCNC_SGST_Rate=ObjAT_DCNCDTL.DCNC_SGST_Rate;
// ObjAT_DCNCDTL.DCNC_SGST_Amt=ObjAT_DCNCDTL.DCNC_SGST_Amt;
// ObjAT_DCNCDTL.DCNC_SGST_TaxableAmt=ObjAT_DCNCDTL.DCNC_SGST_TaxableAmt;
// ObjAT_DCNCDTL.DCNC_IGST_ID=ObjAT_DCNCDTL.DCNC_IGST_ID;
// ObjAT_DCNCDTL.DCNC_IGST_Rate=ObjAT_DCNCDTL.DCNC_IGST_Rate;
// ObjAT_DCNCDTL.DCNC_IGST_Amt=ObjAT_DCNCDTL.DCNC_IGST_Amt;
// ObjAT_DCNCDTL.DCNC_IGST_TaxableAmt=ObjAT_DCNCDTL.DCNC_IGST_TaxableAmt;
// ObjAT_DCNCDTL.DCNC_CESS_ID=ObjAT_DCNCDTL.DCNC_CESS_ID;
// ObjAT_DCNCDTL.DCNC_CESS_Rate=ObjAT_DCNCDTL.DCNC_CESS_Rate;
// ObjAT_DCNCDTL.DCNC_CESS_Amt=ObjAT_DCNCDTL.DCNC_CESS_Amt;
// ObjAT_DCNCDTL.DCNC_CESS_TaxableAmt=ObjAT_DCNCDTL.DCNC_CESS_TaxableAmt;
// ObjAT_DCNCDTL.DCNC_OtherTax_ID=ObjAT_DCNCDTL.DCNC_OtherTax_ID;
// ObjAT_DCNCDTL.DCNC_OtherTax_Rate=ObjAT_DCNCDTL.DCNC_OtherTax_Rate;
// ObjAT_DCNCDTL.DCNC_OtherTax_Amt=ObjAT_DCNCDTL.DCNC_OtherTax_Amt;
// ObjAT_DCNCDTL.DCNC_OtherTax_TaxableAmt=ObjAT_DCNCDTL.DCNC_OtherTax_TaxableAmt;
// ObjAT_DCNCDTL.DCNC_TotalTax=ObjAT_DCNCDTL.DCNC_TotalTax;
// ObjAT_DCNCDTL.DCNC_GrossRateWithTax=ObjAT_DCNCDTL.DCNC_GrossRateWithTax;
// ObjAT_DCNCDTL.MDBSC_RowStatus=ObjAT_DCNCDTL.MDBSC_RowStatus;
// ObjAT_DCNCDTL.DCNC_ItemRemark_DTL=ObjAT_DCNCDTL.DCNC_ItemRemark_DTL;
// ObjAT_DCNCDTL.MDBSC_RowCreatedByUser_ID=ObjAT_DCNCDTL.MDBSC_RowCreatedByUser_ID;
// ObjAT_DCNCDTL.MDBSC_RowCreatedByUserName=ObjAT_DCNCDTL.MDBSC_RowCreatedByUserName;
// ObjAT_DCNCDTL.MDBSC_RowCreatedOn_DT=ObjAT_DCNCDTL.MDBSC_RowCreatedOn_DT;
// ObjAT_DCNCDTL.MDBSC_RowLupdnByUser_ID=ObjAT_DCNCDTL.MDBSC_RowLupdnByUser_ID;
// ObjAT_DCNCDTL.MDBSC_RowLupdnUserName=ObjAT_DCNCDTL.MDBSC_RowLupdnUserName;
// ObjAT_DCNCDTL.MDBSC_RowLupdnOn_DT=ObjAT_DCNCDTL.MDBSC_RowLupdnOn_DT;



// DCNCDTL_ID.Text = "";
// Fk_DCNCHDR_ID.Text = "";
// Fk_MItem_ID.Text = "";
// DCNC_HSNCode.Text = "";
// DCNC_QTY.Text = "";
// DCNC_BasicRate.Text = "";
// DCNC_NetRate.Text = "";
// DCNC_BasicAmt.Text = "";
// DCNC_DiscountRate.Text = "";
// DCNC_DiscountAmt.Text = "";
// DCNC_NetTaxableAmt.Text = "";
// DCNC_CGST_ID.Text = "";
// DCNC_CGST_Rate.Text = "";
// DCNC_CGST_Amt.Text = "";
// DCNC_CGST_TaxableAmt.Text = "";
// DCNC_SGST_ID.Text = "";
// DCNC_SGST_Rate.Text = "";
// DCNC_SGST_Amt.Text = "";
// DCNC_SGST_TaxableAmt.Text = "";
// DCNC_IGST_ID.Text = "";
// DCNC_IGST_Rate.Text = "";
// DCNC_IGST_Amt.Text = "";
// DCNC_IGST_TaxableAmt.Text = "";
// DCNC_CESS_ID.Text = "";
// DCNC_CESS_Rate.Text = "";
// DCNC_CESS_Amt.Text = "";
// DCNC_CESS_TaxableAmt.Text = "";
// DCNC_OtherTax_ID.Text = "";
// DCNC_OtherTax_Rate.Text = "";
// DCNC_OtherTax_Amt.Text = "";
// DCNC_OtherTax_TaxableAmt.Text = "";
// DCNC_TotalTax.Text = "";
// DCNC_GrossRateWithTax.Text = "";
// MDBSC_RowStatus.Text = "";
// DCNC_ItemRemark_DTL.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";



// ObjAT_DCNCDTL.DCNCDTL_ID=DCNCDTL_ID.Text ;
// ObjAT_DCNCDTL.Fk_DCNCHDR_ID=Fk_DCNCHDR_ID.Text ;
// ObjAT_DCNCDTL.Fk_MItem_ID=Fk_MItem_ID.Text ;
// ObjAT_DCNCDTL.DCNC_HSNCode=DCNC_HSNCode.Text ;
// ObjAT_DCNCDTL.DCNC_QTY=DCNC_QTY.Text ;
// ObjAT_DCNCDTL.DCNC_BasicRate=DCNC_BasicRate.Text ;
// ObjAT_DCNCDTL.DCNC_NetRate=DCNC_NetRate.Text ;
// ObjAT_DCNCDTL.DCNC_BasicAmt=DCNC_BasicAmt.Text ;
// ObjAT_DCNCDTL.DCNC_DiscountRate=DCNC_DiscountRate.Text ;
// ObjAT_DCNCDTL.DCNC_DiscountAmt=DCNC_DiscountAmt.Text ;
// ObjAT_DCNCDTL.DCNC_NetTaxableAmt=DCNC_NetTaxableAmt.Text ;
// ObjAT_DCNCDTL.DCNC_CGST_ID=DCNC_CGST_ID.Text ;
// ObjAT_DCNCDTL.DCNC_CGST_Rate=DCNC_CGST_Rate.Text ;
// ObjAT_DCNCDTL.DCNC_CGST_Amt=DCNC_CGST_Amt.Text ;
// ObjAT_DCNCDTL.DCNC_CGST_TaxableAmt=DCNC_CGST_TaxableAmt.Text ;
// ObjAT_DCNCDTL.DCNC_SGST_ID=DCNC_SGST_ID.Text ;
// ObjAT_DCNCDTL.DCNC_SGST_Rate=DCNC_SGST_Rate.Text ;
// ObjAT_DCNCDTL.DCNC_SGST_Amt=DCNC_SGST_Amt.Text ;
// ObjAT_DCNCDTL.DCNC_SGST_TaxableAmt=DCNC_SGST_TaxableAmt.Text ;
// ObjAT_DCNCDTL.DCNC_IGST_ID=DCNC_IGST_ID.Text ;
// ObjAT_DCNCDTL.DCNC_IGST_Rate=DCNC_IGST_Rate.Text ;
// ObjAT_DCNCDTL.DCNC_IGST_Amt=DCNC_IGST_Amt.Text ;
// ObjAT_DCNCDTL.DCNC_IGST_TaxableAmt=DCNC_IGST_TaxableAmt.Text ;
// ObjAT_DCNCDTL.DCNC_CESS_ID=DCNC_CESS_ID.Text ;
// ObjAT_DCNCDTL.DCNC_CESS_Rate=DCNC_CESS_Rate.Text ;
// ObjAT_DCNCDTL.DCNC_CESS_Amt=DCNC_CESS_Amt.Text ;
// ObjAT_DCNCDTL.DCNC_CESS_TaxableAmt=DCNC_CESS_TaxableAmt.Text ;
// ObjAT_DCNCDTL.DCNC_OtherTax_ID=DCNC_OtherTax_ID.Text ;
// ObjAT_DCNCDTL.DCNC_OtherTax_Rate=DCNC_OtherTax_Rate.Text ;
// ObjAT_DCNCDTL.DCNC_OtherTax_Amt=DCNC_OtherTax_Amt.Text ;
// ObjAT_DCNCDTL.DCNC_OtherTax_TaxableAmt=DCNC_OtherTax_TaxableAmt.Text ;
// ObjAT_DCNCDTL.DCNC_TotalTax=DCNC_TotalTax.Text ;
// ObjAT_DCNCDTL.DCNC_GrossRateWithTax=DCNC_GrossRateWithTax.Text ;
// ObjAT_DCNCDTL.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_DCNCDTL.DCNC_ItemRemark_DTL=DCNC_ItemRemark_DTL.Text ;
// ObjAT_DCNCDTL.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_DCNCDTL.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_DCNCDTL.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_DCNCDTL.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_DCNCDTL.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_DCNCDTL.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;



// DCNCDTL_ID.Text =  dt.Rows[0]["DCNCDTL_ID"].ToString();
// Fk_DCNCHDR_ID.Text =  dt.Rows[0]["Fk_DCNCHDR_ID"].ToString();
// Fk_MItem_ID.Text =  dt.Rows[0]["Fk_MItem_ID"].ToString();
// DCNC_HSNCode.Text =  dt.Rows[0]["DCNC_HSNCode"].ToString();
// DCNC_QTY.Text =  dt.Rows[0]["DCNC_QTY"].ToString();
// DCNC_BasicRate.Text =  dt.Rows[0]["DCNC_BasicRate"].ToString();
// DCNC_NetRate.Text =  dt.Rows[0]["DCNC_NetRate"].ToString();
// DCNC_BasicAmt.Text =  dt.Rows[0]["DCNC_BasicAmt"].ToString();
// DCNC_DiscountRate.Text =  dt.Rows[0]["DCNC_DiscountRate"].ToString();
// DCNC_DiscountAmt.Text =  dt.Rows[0]["DCNC_DiscountAmt"].ToString();
// DCNC_NetTaxableAmt.Text =  dt.Rows[0]["DCNC_NetTaxableAmt"].ToString();
// DCNC_CGST_ID.Text =  dt.Rows[0]["DCNC_CGST_ID"].ToString();
// DCNC_CGST_Rate.Text =  dt.Rows[0]["DCNC_CGST_Rate"].ToString();
// DCNC_CGST_Amt.Text =  dt.Rows[0]["DCNC_CGST_Amt"].ToString();
// DCNC_CGST_TaxableAmt.Text =  dt.Rows[0]["DCNC_CGST_TaxableAmt"].ToString();
// DCNC_SGST_ID.Text =  dt.Rows[0]["DCNC_SGST_ID"].ToString();
// DCNC_SGST_Rate.Text =  dt.Rows[0]["DCNC_SGST_Rate"].ToString();
// DCNC_SGST_Amt.Text =  dt.Rows[0]["DCNC_SGST_Amt"].ToString();
// DCNC_SGST_TaxableAmt.Text =  dt.Rows[0]["DCNC_SGST_TaxableAmt"].ToString();
// DCNC_IGST_ID.Text =  dt.Rows[0]["DCNC_IGST_ID"].ToString();
// DCNC_IGST_Rate.Text =  dt.Rows[0]["DCNC_IGST_Rate"].ToString();
// DCNC_IGST_Amt.Text =  dt.Rows[0]["DCNC_IGST_Amt"].ToString();
// DCNC_IGST_TaxableAmt.Text =  dt.Rows[0]["DCNC_IGST_TaxableAmt"].ToString();
// DCNC_CESS_ID.Text =  dt.Rows[0]["DCNC_CESS_ID"].ToString();
// DCNC_CESS_Rate.Text =  dt.Rows[0]["DCNC_CESS_Rate"].ToString();
// DCNC_CESS_Amt.Text =  dt.Rows[0]["DCNC_CESS_Amt"].ToString();
// DCNC_CESS_TaxableAmt.Text =  dt.Rows[0]["DCNC_CESS_TaxableAmt"].ToString();
// DCNC_OtherTax_ID.Text =  dt.Rows[0]["DCNC_OtherTax_ID"].ToString();
// DCNC_OtherTax_Rate.Text =  dt.Rows[0]["DCNC_OtherTax_Rate"].ToString();
// DCNC_OtherTax_Amt.Text =  dt.Rows[0]["DCNC_OtherTax_Amt"].ToString();
// DCNC_OtherTax_TaxableAmt.Text =  dt.Rows[0]["DCNC_OtherTax_TaxableAmt"].ToString();
// DCNC_TotalTax.Text =  dt.Rows[0]["DCNC_TotalTax"].ToString();
// DCNC_GrossRateWithTax.Text =  dt.Rows[0]["DCNC_GrossRateWithTax"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// DCNC_ItemRemark_DTL.Text =  dt.Rows[0]["DCNC_ItemRemark_DTL"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
