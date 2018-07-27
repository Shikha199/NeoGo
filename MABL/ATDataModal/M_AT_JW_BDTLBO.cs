using System;
using System.Collections;
using System.Data;
using System.Web;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal
{
    public class M_AT_JW_BDTLBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public M_AT_JW_BDTLBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "JWDTL_ID";
        private string _TableName = "M_AT_JW_BDTL";
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

        private Int64 _JWDTL_ID;
        private Int64 _Fk_JWHDR_ID;
        private Int64 _Fk_JW_Item_ID;
        private String _JW_Item_HSNCode;
        private Decimal _JW_Item_QTY;
        private Decimal _JW_Item_BasicRate;
        private Decimal _JW_NetRate;
        private Decimal _JW_Item_BasicAmt;
        private Decimal _JW_DiscountRate;
        private Decimal _JW_DiscountAmt;
        private Decimal _JW_NetTaxableAmt;
        private Int16 _JW_GST_TaxRate_ID;
        private Decimal _JW_GST_TaxRate;
        private Int16 _JW_CGST_ID;
        private Decimal _JW_CGST_Rate;
        private Decimal _JW_CGST_Amt;
        private Decimal _JW_CGST_TaxableAmt;
        private Int16 _JW_SGST_ID;
        private Decimal _JW_SGST_Rate;
        private Decimal _JW_SGST_Amt;
        private Decimal _JW_SGST_TaxableAmt;
        private Int16 _JW_IGST_ID;
        private Decimal _JW_IGST_Rate;
        private Decimal _JW_IGST_Amt;
        private Decimal _JW_IGST_TaxableAmt;
        private Int16 _JW_CESS_ID;
        private Decimal _JW_CESS_Rate;
        private Decimal _JW_CESS_Amt;
        private Decimal _JW_CESS_TaxableAmt;
        private Int16 _JW_OtherTax_ID;
        private Decimal _JW_OtherTax_Rate;
        private Decimal _JW_OtherTax_Amt;
        private Decimal _JW_OtherTax_TaxableAmt;
        private Decimal _JW_TotalTax;
        private Decimal _JW_GrossRateWithTax;
        private String _MDBSC_RowStatus;
        private String _JW_ItemRemark_DTL;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;

        public Int64 JWDTL_ID
        {
            get
            {
                return this._JWDTL_ID;
            }
            set
            {
                this._JWDTL_ID = value;
                _UpdateFieldName.Add("JWDTL_ID");
            }
        }
        public Int64 Fk_JWHDR_ID
        {
            get
            {
                return this._Fk_JWHDR_ID;
            }
            set
            {
                this._Fk_JWHDR_ID = value;
                _UpdateFieldName.Add("Fk_JWHDR_ID");
            }
        }
        public Int64 Fk_JW_Item_ID
        {
            get
            {
                return this._Fk_JW_Item_ID;
            }
            set
            {
                this._Fk_JW_Item_ID = value;
                _UpdateFieldName.Add("Fk_JW_Item_ID");
            }
        }
        public String JW_Item_HSNCode
        {
            get
            {
                return this._JW_Item_HSNCode;
            }
            set
            {
                this._JW_Item_HSNCode = value;
                _UpdateFieldName.Add("JW_Item_HSNCode");
            }
        }
        public Decimal JW_Item_QTY
        {
            get
            {
                return this._JW_Item_QTY;
            }
            set
            {
                this._JW_Item_QTY = value;
                _UpdateFieldName.Add("JW_Item_QTY");
            }
        }
        public Decimal JW_Item_BasicRate
        {
            get
            {
                return this._JW_Item_BasicRate;
            }
            set
            {
                this._JW_Item_BasicRate = value;
                _UpdateFieldName.Add("JW_Item_BasicRate");
            }
        }
        public Decimal JW_NetRate
        {
            get
            {
                return this._JW_NetRate;
            }
            set
            {
                this._JW_NetRate = value;
                _UpdateFieldName.Add("JW_NetRate");
            }
        }
        public Decimal JW_Item_BasicAmt
        {
            get
            {
                return this._JW_Item_BasicAmt;
            }
            set
            {
                this._JW_Item_BasicAmt = value;
                _UpdateFieldName.Add("JW_Item_BasicAmt");
            }
        }
        public Decimal JW_DiscountRate
        {
            get
            {
                return this._JW_DiscountRate;
            }
            set
            {
                this._JW_DiscountRate = value;
                _UpdateFieldName.Add("JW_DiscountRate");
            }
        }
        public Decimal JW_DiscountAmt
        {
            get
            {
                return this._JW_DiscountAmt;
            }
            set
            {
                this._JW_DiscountAmt = value;
                _UpdateFieldName.Add("JW_DiscountAmt");
            }
        }
        public Decimal JW_NetTaxableAmt
        {
            get
            {
                return this._JW_NetTaxableAmt;
            }
            set
            {
                this._JW_NetTaxableAmt = value;
                _UpdateFieldName.Add("JW_NetTaxableAmt");
            }
        }
        public Int16 JW_GST_TaxRate_ID
        {
            get
            {
                return this._JW_GST_TaxRate_ID;
            }
            set
            {
                this._JW_GST_TaxRate_ID = value;
                _UpdateFieldName.Add("JW_GST_TaxRate_ID");
            }
        }
        public Decimal JW_GST_TaxRate
        {
            get
            {
                return this._JW_GST_TaxRate;
            }
            set
            {
                this._JW_GST_TaxRate = value;
                _UpdateFieldName.Add("JW_GST_TaxRate");
            }
        }
        public Int16 JW_CGST_ID
        {
            get
            {
                return this._JW_CGST_ID;
            }
            set
            {
                this._JW_CGST_ID = value;
                _UpdateFieldName.Add("JW_CGST_ID");
            }
        }
        public Decimal JW_CGST_Rate
        {
            get
            {
                return this._JW_CGST_Rate;
            }
            set
            {
                this._JW_CGST_Rate = value;
                _UpdateFieldName.Add("JW_CGST_Rate");
            }
        }
        public Decimal JW_CGST_Amt
        {
            get
            {
                return this._JW_CGST_Amt;
            }
            set
            {
                this._JW_CGST_Amt = value;
                _UpdateFieldName.Add("JW_CGST_Amt");
            }
        }
        public Decimal JW_CGST_TaxableAmt
        {
            get
            {
                return this._JW_CGST_TaxableAmt;
            }
            set
            {
                this._JW_CGST_TaxableAmt = value;
                _UpdateFieldName.Add("JW_CGST_TaxableAmt");
            }
        }
        public Int16 JW_SGST_ID
        {
            get
            {
                return this._JW_SGST_ID;
            }
            set
            {
                this._JW_SGST_ID = value;
                _UpdateFieldName.Add("JW_SGST_ID");
            }
        }
        public Decimal JW_SGST_Rate
        {
            get
            {
                return this._JW_SGST_Rate;
            }
            set
            {
                this._JW_SGST_Rate = value;
                _UpdateFieldName.Add("JW_SGST_Rate");
            }
        }
        public Decimal JW_SGST_Amt
        {
            get
            {
                return this._JW_SGST_Amt;
            }
            set
            {
                this._JW_SGST_Amt = value;
                _UpdateFieldName.Add("JW_SGST_Amt");
            }
        }
        public Decimal JW_SGST_TaxableAmt
        {
            get
            {
                return this._JW_SGST_TaxableAmt;
            }
            set
            {
                this._JW_SGST_TaxableAmt = value;
                _UpdateFieldName.Add("JW_SGST_TaxableAmt");
            }
        }
        public Int16 JW_IGST_ID
        {
            get
            {
                return this._JW_IGST_ID;
            }
            set
            {
                this._JW_IGST_ID = value;
                _UpdateFieldName.Add("JW_IGST_ID");
            }
        }
        public Decimal JW_IGST_Rate
        {
            get
            {
                return this._JW_IGST_Rate;
            }
            set
            {
                this._JW_IGST_Rate = value;
                _UpdateFieldName.Add("JW_IGST_Rate");
            }
        }
        public Decimal JW_IGST_Amt
        {
            get
            {
                return this._JW_IGST_Amt;
            }
            set
            {
                this._JW_IGST_Amt = value;
                _UpdateFieldName.Add("JW_IGST_Amt");
            }
        }
        public Decimal JW_IGST_TaxableAmt
        {
            get
            {
                return this._JW_IGST_TaxableAmt;
            }
            set
            {
                this._JW_IGST_TaxableAmt = value;
                _UpdateFieldName.Add("JW_IGST_TaxableAmt");
            }
        }
        public Int16 JW_CESS_ID
        {
            get
            {
                return this._JW_CESS_ID;
            }
            set
            {
                this._JW_CESS_ID = value;
                _UpdateFieldName.Add("JW_CESS_ID");
            }
        }
        public Decimal JW_CESS_Rate
        {
            get
            {
                return this._JW_CESS_Rate;
            }
            set
            {
                this._JW_CESS_Rate = value;
                _UpdateFieldName.Add("JW_CESS_Rate");
            }
        }
        public Decimal JW_CESS_Amt
        {
            get
            {
                return this._JW_CESS_Amt;
            }
            set
            {
                this._JW_CESS_Amt = value;
                _UpdateFieldName.Add("JW_CESS_Amt");
            }
        }
        public Decimal JW_CESS_TaxableAmt
        {
            get
            {
                return this._JW_CESS_TaxableAmt;
            }
            set
            {
                this._JW_CESS_TaxableAmt = value;
                _UpdateFieldName.Add("JW_CESS_TaxableAmt");
            }
        }
        public Int16 JW_OtherTax_ID
        {
            get
            {
                return this._JW_OtherTax_ID;
            }
            set
            {
                this._JW_OtherTax_ID = value;
                _UpdateFieldName.Add("JW_OtherTax_ID");
            }
        }
        public Decimal JW_OtherTax_Rate
        {
            get
            {
                return this._JW_OtherTax_Rate;
            }
            set
            {
                this._JW_OtherTax_Rate = value;
                _UpdateFieldName.Add("JW_OtherTax_Rate");
            }
        }
        public Decimal JW_OtherTax_Amt
        {
            get
            {
                return this._JW_OtherTax_Amt;
            }
            set
            {
                this._JW_OtherTax_Amt = value;
                _UpdateFieldName.Add("JW_OtherTax_Amt");
            }
        }
        public Decimal JW_OtherTax_TaxableAmt
        {
            get
            {
                return this._JW_OtherTax_TaxableAmt;
            }
            set
            {
                this._JW_OtherTax_TaxableAmt = value;
                _UpdateFieldName.Add("JW_OtherTax_TaxableAmt");
            }
        }
        public Decimal JW_TotalTax
        {
            get
            {
                return this._JW_TotalTax;
            }
            set
            {
                this._JW_TotalTax = value;
                _UpdateFieldName.Add("JW_TotalTax");
            }
        }
        public Decimal JW_GrossRateWithTax
        {
            get
            {
                return this._JW_GrossRateWithTax;
            }
            set
            {
                this._JW_GrossRateWithTax = value;
                _UpdateFieldName.Add("JW_GrossRateWithTax");
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
        public String JW_ItemRemark_DTL
        {
            get
            {
                return this._JW_ItemRemark_DTL;
            }
            set
            {
                this._JW_ItemRemark_DTL = value;
                _UpdateFieldName.Add("JW_ItemRemark_DTL");
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
        public string Insert_Update(M_AT_JW_BDTLBO sObject)
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

// ObjAT_JWDTL.JWDTL_ID=ObjAT_JWDTL.JWDTL_ID;
// ObjAT_JWDTL.Fk_JWHDR_ID=ObjAT_JWDTL.Fk_JWHDR_ID;
// ObjAT_JWDTL.Fk_JW_Item_ID=ObjAT_JWDTL.Fk_JW_Item_ID;
// ObjAT_JWDTL.JW_Item_HSNCode=ObjAT_JWDTL.JW_Item_HSNCode;
// ObjAT_JWDTL.JW_Item_QTY=ObjAT_JWDTL.JW_Item_QTY;
// ObjAT_JWDTL.JW_Item_BasicRate=ObjAT_JWDTL.JW_Item_BasicRate;
// ObjAT_JWDTL.JW_NetRate=ObjAT_JWDTL.JW_NetRate;
// ObjAT_JWDTL.JW_Item_BasicAmt=ObjAT_JWDTL.JW_Item_BasicAmt;
// ObjAT_JWDTL.JW_DiscountRate=ObjAT_JWDTL.JW_DiscountRate;
// ObjAT_JWDTL.JW_DiscountAmt=ObjAT_JWDTL.JW_DiscountAmt;
// ObjAT_JWDTL.JW_NetTaxableAmt=ObjAT_JWDTL.JW_NetTaxableAmt;
// ObjAT_JWDTL.JW_GST_TaxRate_ID=ObjAT_JWDTL.JW_GST_TaxRate_ID;
// ObjAT_JWDTL.JW_GST_TaxRate=ObjAT_JWDTL.JW_GST_TaxRate;
// ObjAT_JWDTL.JW_CGST_ID=ObjAT_JWDTL.JW_CGST_ID;
// ObjAT_JWDTL.JW_CGST_Rate=ObjAT_JWDTL.JW_CGST_Rate;
// ObjAT_JWDTL.JW_CGST_Amt=ObjAT_JWDTL.JW_CGST_Amt;
// ObjAT_JWDTL.JW_CGST_TaxableAmt=ObjAT_JWDTL.JW_CGST_TaxableAmt;
// ObjAT_JWDTL.JW_SGST_ID=ObjAT_JWDTL.JW_SGST_ID;
// ObjAT_JWDTL.JW_SGST_Rate=ObjAT_JWDTL.JW_SGST_Rate;
// ObjAT_JWDTL.JW_SGST_Amt=ObjAT_JWDTL.JW_SGST_Amt;
// ObjAT_JWDTL.JW_SGST_TaxableAmt=ObjAT_JWDTL.JW_SGST_TaxableAmt;
// ObjAT_JWDTL.JW_IGST_ID=ObjAT_JWDTL.JW_IGST_ID;
// ObjAT_JWDTL.JW_IGST_Rate=ObjAT_JWDTL.JW_IGST_Rate;
// ObjAT_JWDTL.JW_IGST_Amt=ObjAT_JWDTL.JW_IGST_Amt;
// ObjAT_JWDTL.JW_IGST_TaxableAmt=ObjAT_JWDTL.JW_IGST_TaxableAmt;
// ObjAT_JWDTL.JW_CESS_ID=ObjAT_JWDTL.JW_CESS_ID;
// ObjAT_JWDTL.JW_CESS_Rate=ObjAT_JWDTL.JW_CESS_Rate;
// ObjAT_JWDTL.JW_CESS_Amt=ObjAT_JWDTL.JW_CESS_Amt;
// ObjAT_JWDTL.JW_CESS_TaxableAmt=ObjAT_JWDTL.JW_CESS_TaxableAmt;
// ObjAT_JWDTL.JW_OtherTax_ID=ObjAT_JWDTL.JW_OtherTax_ID;
// ObjAT_JWDTL.JW_OtherTax_Rate=ObjAT_JWDTL.JW_OtherTax_Rate;
// ObjAT_JWDTL.JW_OtherTax_Amt=ObjAT_JWDTL.JW_OtherTax_Amt;
// ObjAT_JWDTL.JW_OtherTax_TaxableAmt=ObjAT_JWDTL.JW_OtherTax_TaxableAmt;
// ObjAT_JWDTL.JW_TotalTax=ObjAT_JWDTL.JW_TotalTax;
// ObjAT_JWDTL.JW_GrossRateWithTax=ObjAT_JWDTL.JW_GrossRateWithTax;
// ObjAT_JWDTL.MDBSC_RowStatus=ObjAT_JWDTL.MDBSC_RowStatus;
// ObjAT_JWDTL.JW_ItemRemark_DTL=ObjAT_JWDTL.JW_ItemRemark_DTL;
// ObjAT_JWDTL.MDBSC_RowCreatedByUser_ID=ObjAT_JWDTL.MDBSC_RowCreatedByUser_ID;
// ObjAT_JWDTL.MDBSC_RowCreatedByUserName=ObjAT_JWDTL.MDBSC_RowCreatedByUserName;
// ObjAT_JWDTL.MDBSC_RowCreatedOn_DT=ObjAT_JWDTL.MDBSC_RowCreatedOn_DT;
// ObjAT_JWDTL.MDBSC_RowLupdnByUser_ID=ObjAT_JWDTL.MDBSC_RowLupdnByUser_ID;
// ObjAT_JWDTL.MDBSC_RowLupdnUserName=ObjAT_JWDTL.MDBSC_RowLupdnUserName;
// ObjAT_JWDTL.MDBSC_RowLupdnOn_DT=ObjAT_JWDTL.MDBSC_RowLupdnOn_DT;



// JWDTL_ID.Text = "";
// Fk_JWHDR_ID.Text = "";
// Fk_JW_Item_ID.Text = "";
// JW_Item_HSNCode.Text = "";
// JW_Item_QTY.Text = "";
// JW_Item_BasicRate.Text = "";
// JW_NetRate.Text = "";
// JW_Item_BasicAmt.Text = "";
// JW_DiscountRate.Text = "";
// JW_DiscountAmt.Text = "";
// JW_NetTaxableAmt.Text = "";
// JW_GST_TaxRate_ID.Text = "";
// JW_GST_TaxRate.Text = "";
// JW_CGST_ID.Text = "";
// JW_CGST_Rate.Text = "";
// JW_CGST_Amt.Text = "";
// JW_CGST_TaxableAmt.Text = "";
// JW_SGST_ID.Text = "";
// JW_SGST_Rate.Text = "";
// JW_SGST_Amt.Text = "";
// JW_SGST_TaxableAmt.Text = "";
// JW_IGST_ID.Text = "";
// JW_IGST_Rate.Text = "";
// JW_IGST_Amt.Text = "";
// JW_IGST_TaxableAmt.Text = "";
// JW_CESS_ID.Text = "";
// JW_CESS_Rate.Text = "";
// JW_CESS_Amt.Text = "";
// JW_CESS_TaxableAmt.Text = "";
// JW_OtherTax_ID.Text = "";
// JW_OtherTax_Rate.Text = "";
// JW_OtherTax_Amt.Text = "";
// JW_OtherTax_TaxableAmt.Text = "";
// JW_TotalTax.Text = "";
// JW_GrossRateWithTax.Text = "";
// MDBSC_RowStatus.Text = "";
// JW_ItemRemark_DTL.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";



// ObjAT_JWDTL.JWDTL_ID=JWDTL_ID.Text ;
// ObjAT_JWDTL.Fk_JWHDR_ID=Fk_JWHDR_ID.Text ;
// ObjAT_JWDTL.Fk_JW_Item_ID=Fk_JW_Item_ID.Text ;
// ObjAT_JWDTL.JW_Item_HSNCode=JW_Item_HSNCode.Text ;
// ObjAT_JWDTL.JW_Item_QTY=JW_Item_QTY.Text ;
// ObjAT_JWDTL.JW_Item_BasicRate=JW_Item_BasicRate.Text ;
// ObjAT_JWDTL.JW_NetRate=JW_NetRate.Text ;
// ObjAT_JWDTL.JW_Item_BasicAmt=JW_Item_BasicAmt.Text ;
// ObjAT_JWDTL.JW_DiscountRate=JW_DiscountRate.Text ;
// ObjAT_JWDTL.JW_DiscountAmt=JW_DiscountAmt.Text ;
// ObjAT_JWDTL.JW_NetTaxableAmt=JW_NetTaxableAmt.Text ;
// ObjAT_JWDTL.JW_GST_TaxRate_ID=JW_GST_TaxRate_ID.Text ;
// ObjAT_JWDTL.JW_GST_TaxRate=JW_GST_TaxRate.Text ;
// ObjAT_JWDTL.JW_CGST_ID=JW_CGST_ID.Text ;
// ObjAT_JWDTL.JW_CGST_Rate=JW_CGST_Rate.Text ;
// ObjAT_JWDTL.JW_CGST_Amt=JW_CGST_Amt.Text ;
// ObjAT_JWDTL.JW_CGST_TaxableAmt=JW_CGST_TaxableAmt.Text ;
// ObjAT_JWDTL.JW_SGST_ID=JW_SGST_ID.Text ;
// ObjAT_JWDTL.JW_SGST_Rate=JW_SGST_Rate.Text ;
// ObjAT_JWDTL.JW_SGST_Amt=JW_SGST_Amt.Text ;
// ObjAT_JWDTL.JW_SGST_TaxableAmt=JW_SGST_TaxableAmt.Text ;
// ObjAT_JWDTL.JW_IGST_ID=JW_IGST_ID.Text ;
// ObjAT_JWDTL.JW_IGST_Rate=JW_IGST_Rate.Text ;
// ObjAT_JWDTL.JW_IGST_Amt=JW_IGST_Amt.Text ;
// ObjAT_JWDTL.JW_IGST_TaxableAmt=JW_IGST_TaxableAmt.Text ;
// ObjAT_JWDTL.JW_CESS_ID=JW_CESS_ID.Text ;
// ObjAT_JWDTL.JW_CESS_Rate=JW_CESS_Rate.Text ;
// ObjAT_JWDTL.JW_CESS_Amt=JW_CESS_Amt.Text ;
// ObjAT_JWDTL.JW_CESS_TaxableAmt=JW_CESS_TaxableAmt.Text ;
// ObjAT_JWDTL.JW_OtherTax_ID=JW_OtherTax_ID.Text ;
// ObjAT_JWDTL.JW_OtherTax_Rate=JW_OtherTax_Rate.Text ;
// ObjAT_JWDTL.JW_OtherTax_Amt=JW_OtherTax_Amt.Text ;
// ObjAT_JWDTL.JW_OtherTax_TaxableAmt=JW_OtherTax_TaxableAmt.Text ;
// ObjAT_JWDTL.JW_TotalTax=JW_TotalTax.Text ;
// ObjAT_JWDTL.JW_GrossRateWithTax=JW_GrossRateWithTax.Text ;
// ObjAT_JWDTL.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_JWDTL.JW_ItemRemark_DTL=JW_ItemRemark_DTL.Text ;
// ObjAT_JWDTL.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_JWDTL.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_JWDTL.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_JWDTL.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_JWDTL.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_JWDTL.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;



// JWDTL_ID.Text =  dt.Rows[0]["JWDTL_ID"].ToString();
// Fk_JWHDR_ID.Text =  dt.Rows[0]["Fk_JWHDR_ID"].ToString();
// Fk_JW_Item_ID.Text =  dt.Rows[0]["Fk_JW_Item_ID"].ToString();
// JW_Item_HSNCode.Text =  dt.Rows[0]["JW_Item_HSNCode"].ToString();
// JW_Item_QTY.Text =  dt.Rows[0]["JW_Item_QTY"].ToString();
// JW_Item_BasicRate.Text =  dt.Rows[0]["JW_Item_BasicRate"].ToString();
// JW_NetRate.Text =  dt.Rows[0]["JW_NetRate"].ToString();
// JW_Item_BasicAmt.Text =  dt.Rows[0]["JW_Item_BasicAmt"].ToString();
// JW_DiscountRate.Text =  dt.Rows[0]["JW_DiscountRate"].ToString();
// JW_DiscountAmt.Text =  dt.Rows[0]["JW_DiscountAmt"].ToString();
// JW_NetTaxableAmt.Text =  dt.Rows[0]["JW_NetTaxableAmt"].ToString();
// JW_GST_TaxRate_ID.Text =  dt.Rows[0]["JW_GST_TaxRate_ID"].ToString();
// JW_GST_TaxRate.Text =  dt.Rows[0]["JW_GST_TaxRate"].ToString();
// JW_CGST_ID.Text =  dt.Rows[0]["JW_CGST_ID"].ToString();
// JW_CGST_Rate.Text =  dt.Rows[0]["JW_CGST_Rate"].ToString();
// JW_CGST_Amt.Text =  dt.Rows[0]["JW_CGST_Amt"].ToString();
// JW_CGST_TaxableAmt.Text =  dt.Rows[0]["JW_CGST_TaxableAmt"].ToString();
// JW_SGST_ID.Text =  dt.Rows[0]["JW_SGST_ID"].ToString();
// JW_SGST_Rate.Text =  dt.Rows[0]["JW_SGST_Rate"].ToString();
// JW_SGST_Amt.Text =  dt.Rows[0]["JW_SGST_Amt"].ToString();
// JW_SGST_TaxableAmt.Text =  dt.Rows[0]["JW_SGST_TaxableAmt"].ToString();
// JW_IGST_ID.Text =  dt.Rows[0]["JW_IGST_ID"].ToString();
// JW_IGST_Rate.Text =  dt.Rows[0]["JW_IGST_Rate"].ToString();
// JW_IGST_Amt.Text =  dt.Rows[0]["JW_IGST_Amt"].ToString();
// JW_IGST_TaxableAmt.Text =  dt.Rows[0]["JW_IGST_TaxableAmt"].ToString();
// JW_CESS_ID.Text =  dt.Rows[0]["JW_CESS_ID"].ToString();
// JW_CESS_Rate.Text =  dt.Rows[0]["JW_CESS_Rate"].ToString();
// JW_CESS_Amt.Text =  dt.Rows[0]["JW_CESS_Amt"].ToString();
// JW_CESS_TaxableAmt.Text =  dt.Rows[0]["JW_CESS_TaxableAmt"].ToString();
// JW_OtherTax_ID.Text =  dt.Rows[0]["JW_OtherTax_ID"].ToString();
// JW_OtherTax_Rate.Text =  dt.Rows[0]["JW_OtherTax_Rate"].ToString();
// JW_OtherTax_Amt.Text =  dt.Rows[0]["JW_OtherTax_Amt"].ToString();
// JW_OtherTax_TaxableAmt.Text =  dt.Rows[0]["JW_OtherTax_TaxableAmt"].ToString();
// JW_TotalTax.Text =  dt.Rows[0]["JW_TotalTax"].ToString();
// JW_GrossRateWithTax.Text =  dt.Rows[0]["JW_GrossRateWithTax"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// JW_ItemRemark_DTL.Text =  dt.Rows[0]["JW_ItemRemark_DTL"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
