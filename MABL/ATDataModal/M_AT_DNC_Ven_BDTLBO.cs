using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal
{
    public class M_AT_DNC_Ven_BDTLBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public M_AT_DNC_Ven_BDTLBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "DCNVDTL_ID";
        private string _TableName = "M_AT_DNC_Ven_BDTL";
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

        private Int64 _DCNVDTL_ID;
        private Int64 _Fk_DCNVHDR_ID;
        private Int64 _Fk_MItem_ID;
        private String _DCNV_HSNCode;
        private Decimal _DCNV_QTY;
        private Decimal _DCNV_BasicRate;
        private Decimal _DCNV_NetRate;
        private Decimal _DCNV_BasicAmt;
        private Decimal _DCNV_DiscountRate;
        private Decimal _DCNV_DiscountAmt;
        private Decimal _DCNV_NetTaxableAmt;
        private Int16 _DCNV_CGST_ID;
        private Decimal _DCNV_CGST_Rate;
        private Decimal _DCNV_CGST_Amt;
        private Decimal _DCNV_CGST_TaxableAmt;
        private Int16 _DCNV_SGST_ID;
        private Decimal _DCNV_SGST_Rate;
        private Decimal _DCNV_SGST_Amt;
        private Decimal _DCNV_SGST_TaxableAmt;
        private Int16 _DCNV_IGST_ID;
        private Decimal _DCNV_IGST_Rate;
        private Decimal _DCNV_IGST_Amt;
        private Decimal _DCNV_IGST_TaxableAmt;
        private Int16 _DCNV_CESS_ID;
        private Decimal _DCNV_CESS_Rate;
        private Decimal _DCNV_CESS_Amt;
        private Decimal _DCNV_CESS_TaxableAmt;
        private Int16 _DCNV_OtherTax_ID;
        private Decimal _DCNV_OtherTax_Rate;
        private Decimal _DCNV_OtherTax_Amt;
        private Decimal _DCNV_OtherTax_TaxableAmt;
        private Decimal _DCNV_TotalTax;
        private Decimal _DCNV_GrossRateWithTax;
        private String _MDBSC_RowStatus;
        private String _DCNV_ItemRemark_DTL;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;

        public Int64 DCNVDTL_ID
        {
            get
            {
                return this._DCNVDTL_ID;
            }
            set
            {
                this._DCNVDTL_ID = value;
                _UpdateFieldName.Add("DCNVDTL_ID");
            }
        }
        public Int64 Fk_DCNVHDR_ID
        {
            get
            {
                return this._Fk_DCNVHDR_ID;
            }
            set
            {
                this._Fk_DCNVHDR_ID = value;
                _UpdateFieldName.Add("Fk_DCNVHDR_ID");
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
        public String DCNV_HSNCode
        {
            get
            {
                return this._DCNV_HSNCode;
            }
            set
            {
                this._DCNV_HSNCode = value;
                _UpdateFieldName.Add("DCNV_HSNCode");
            }
        }
        public Decimal DCNV_QTY
        {
            get
            {
                return this._DCNV_QTY;
            }
            set
            {
                this._DCNV_QTY = value;
                _UpdateFieldName.Add("DCNV_QTY");
            }
        }
        public Decimal DCNV_BasicRate
        {
            get
            {
                return this._DCNV_BasicRate;
            }
            set
            {
                this._DCNV_BasicRate = value;
                _UpdateFieldName.Add("DCNV_BasicRate");
            }
        }
        public Decimal DCNV_NetRate
        {
            get
            {
                return this._DCNV_NetRate;
            }
            set
            {
                this._DCNV_NetRate = value;
                _UpdateFieldName.Add("DCNV_NetRate");
            }
        }
        public Decimal DCNV_BasicAmt
        {
            get
            {
                return this._DCNV_BasicAmt;
            }
            set
            {
                this._DCNV_BasicAmt = value;
                _UpdateFieldName.Add("DCNV_BasicAmt");
            }
        }
        public Decimal DCNV_DiscountRate
        {
            get
            {
                return this._DCNV_DiscountRate;
            }
            set
            {
                this._DCNV_DiscountRate = value;
                _UpdateFieldName.Add("DCNV_DiscountRate");
            }
        }
        public Decimal DCNV_DiscountAmt
        {
            get
            {
                return this._DCNV_DiscountAmt;
            }
            set
            {
                this._DCNV_DiscountAmt = value;
                _UpdateFieldName.Add("DCNV_DiscountAmt");
            }
        }
        public Decimal DCNV_NetTaxableAmt
        {
            get
            {
                return this._DCNV_NetTaxableAmt;
            }
            set
            {
                this._DCNV_NetTaxableAmt = value;
                _UpdateFieldName.Add("DCNV_NetTaxableAmt");
            }
        }
        public Int16 DCNV_CGST_ID
        {
            get
            {
                return this._DCNV_CGST_ID;
            }
            set
            {
                this._DCNV_CGST_ID = value;
                _UpdateFieldName.Add("DCNV_CGST_ID");
            }
        }
        public Decimal DCNV_CGST_Rate
        {
            get
            {
                return this._DCNV_CGST_Rate;
            }
            set
            {
                this._DCNV_CGST_Rate = value;
                _UpdateFieldName.Add("DCNV_CGST_Rate");
            }
        }
        public Decimal DCNV_CGST_Amt
        {
            get
            {
                return this._DCNV_CGST_Amt;
            }
            set
            {
                this._DCNV_CGST_Amt = value;
                _UpdateFieldName.Add("DCNV_CGST_Amt");
            }
        }
        public Decimal DCNV_CGST_TaxableAmt
        {
            get
            {
                return this._DCNV_CGST_TaxableAmt;
            }
            set
            {
                this._DCNV_CGST_TaxableAmt = value;
                _UpdateFieldName.Add("DCNV_CGST_TaxableAmt");
            }
        }
        public Int16 DCNV_SGST_ID
        {
            get
            {
                return this._DCNV_SGST_ID;
            }
            set
            {
                this._DCNV_SGST_ID = value;
                _UpdateFieldName.Add("DCNV_SGST_ID");
            }
        }
        public Decimal DCNV_SGST_Rate
        {
            get
            {
                return this._DCNV_SGST_Rate;
            }
            set
            {
                this._DCNV_SGST_Rate = value;
                _UpdateFieldName.Add("DCNV_SGST_Rate");
            }
        }
        public Decimal DCNV_SGST_Amt
        {
            get
            {
                return this._DCNV_SGST_Amt;
            }
            set
            {
                this._DCNV_SGST_Amt = value;
                _UpdateFieldName.Add("DCNV_SGST_Amt");
            }
        }
        public Decimal DCNV_SGST_TaxableAmt
        {
            get
            {
                return this._DCNV_SGST_TaxableAmt;
            }
            set
            {
                this._DCNV_SGST_TaxableAmt = value;
                _UpdateFieldName.Add("DCNV_SGST_TaxableAmt");
            }
        }
        public Int16 DCNV_IGST_ID
        {
            get
            {
                return this._DCNV_IGST_ID;
            }
            set
            {
                this._DCNV_IGST_ID = value;
                _UpdateFieldName.Add("DCNV_IGST_ID");
            }
        }
        public Decimal DCNV_IGST_Rate
        {
            get
            {
                return this._DCNV_IGST_Rate;
            }
            set
            {
                this._DCNV_IGST_Rate = value;
                _UpdateFieldName.Add("DCNV_IGST_Rate");
            }
        }
        public Decimal DCNV_IGST_Amt
        {
            get
            {
                return this._DCNV_IGST_Amt;
            }
            set
            {
                this._DCNV_IGST_Amt = value;
                _UpdateFieldName.Add("DCNV_IGST_Amt");
            }
        }
        public Decimal DCNV_IGST_TaxableAmt
        {
            get
            {
                return this._DCNV_IGST_TaxableAmt;
            }
            set
            {
                this._DCNV_IGST_TaxableAmt = value;
                _UpdateFieldName.Add("DCNV_IGST_TaxableAmt");
            }
        }
        public Int16 DCNV_CESS_ID
        {
            get
            {
                return this._DCNV_CESS_ID;
            }
            set
            {
                this._DCNV_CESS_ID = value;
                _UpdateFieldName.Add("DCNV_CESS_ID");
            }
        }
        public Decimal DCNV_CESS_Rate
        {
            get
            {
                return this._DCNV_CESS_Rate;
            }
            set
            {
                this._DCNV_CESS_Rate = value;
                _UpdateFieldName.Add("DCNV_CESS_Rate");
            }
        }
        public Decimal DCNV_CESS_Amt
        {
            get
            {
                return this._DCNV_CESS_Amt;
            }
            set
            {
                this._DCNV_CESS_Amt = value;
                _UpdateFieldName.Add("DCNV_CESS_Amt");
            }
        }
        public Decimal DCNV_CESS_TaxableAmt
        {
            get
            {
                return this._DCNV_CESS_TaxableAmt;
            }
            set
            {
                this._DCNV_CESS_TaxableAmt = value;
                _UpdateFieldName.Add("DCNV_CESS_TaxableAmt");
            }
        }
        public Int16 DCNV_OtherTax_ID
        {
            get
            {
                return this._DCNV_OtherTax_ID;
            }
            set
            {
                this._DCNV_OtherTax_ID = value;
                _UpdateFieldName.Add("DCNV_OtherTax_ID");
            }
        }
        public Decimal DCNV_OtherTax_Rate
        {
            get
            {
                return this._DCNV_OtherTax_Rate;
            }
            set
            {
                this._DCNV_OtherTax_Rate = value;
                _UpdateFieldName.Add("DCNV_OtherTax_Rate");
            }
        }
        public Decimal DCNV_OtherTax_Amt
        {
            get
            {
                return this._DCNV_OtherTax_Amt;
            }
            set
            {
                this._DCNV_OtherTax_Amt = value;
                _UpdateFieldName.Add("DCNV_OtherTax_Amt");
            }
        }
        public Decimal DCNV_OtherTax_TaxableAmt
        {
            get
            {
                return this._DCNV_OtherTax_TaxableAmt;
            }
            set
            {
                this._DCNV_OtherTax_TaxableAmt = value;
                _UpdateFieldName.Add("DCNV_OtherTax_TaxableAmt");
            }
        }
        public Decimal DCNV_TotalTax
        {
            get
            {
                return this._DCNV_TotalTax;
            }
            set
            {
                this._DCNV_TotalTax = value;
                _UpdateFieldName.Add("DCNV_TotalTax");
            }
        }
        public Decimal DCNV_GrossRateWithTax
        {
            get
            {
                return this._DCNV_GrossRateWithTax;
            }
            set
            {
                this._DCNV_GrossRateWithTax = value;
                _UpdateFieldName.Add("DCNV_GrossRateWithTax");
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
        public String DCNV_ItemRemark_DTL
        {
            get
            {
                return this._DCNV_ItemRemark_DTL;
            }
            set
            {
                this._DCNV_ItemRemark_DTL = value;
                _UpdateFieldName.Add("DCNV_ItemRemark_DTL");
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
        public string Insert_Update(M_AT_DNC_Ven_BDTLBO sObject)
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

// ObjAT_DCNVDTL.DCNVDTL_ID=ObjAT_DCNVDTL.DCNVDTL_ID;
// ObjAT_DCNVDTL.Fk_DCNVHDR_ID=ObjAT_DCNVDTL.Fk_DCNVHDR_ID;
// ObjAT_DCNVDTL.Fk_MItem_ID=ObjAT_DCNVDTL.Fk_MItem_ID;
// ObjAT_DCNVDTL.DCNV_HSNCode=ObjAT_DCNVDTL.DCNV_HSNCode;
// ObjAT_DCNVDTL.DCNV_QTY=ObjAT_DCNVDTL.DCNV_QTY;
// ObjAT_DCNVDTL.DCNV_BasicRate=ObjAT_DCNVDTL.DCNV_BasicRate;
// ObjAT_DCNVDTL.DCNV_NetRate=ObjAT_DCNVDTL.DCNV_NetRate;
// ObjAT_DCNVDTL.DCNV_BasicAmt=ObjAT_DCNVDTL.DCNV_BasicAmt;
// ObjAT_DCNVDTL.DCNV_DiscountRate=ObjAT_DCNVDTL.DCNV_DiscountRate;
// ObjAT_DCNVDTL.DCNV_DiscountAmt=ObjAT_DCNVDTL.DCNV_DiscountAmt;
// ObjAT_DCNVDTL.DCNV_NetTaxableAmt=ObjAT_DCNVDTL.DCNV_NetTaxableAmt;
// ObjAT_DCNVDTL.DCNV_CGST_ID=ObjAT_DCNVDTL.DCNV_CGST_ID;
// ObjAT_DCNVDTL.DCNV_CGST_Rate=ObjAT_DCNVDTL.DCNV_CGST_Rate;
// ObjAT_DCNVDTL.DCNV_CGST_Amt=ObjAT_DCNVDTL.DCNV_CGST_Amt;
// ObjAT_DCNVDTL.DCNV_CGST_TaxableAmt=ObjAT_DCNVDTL.DCNV_CGST_TaxableAmt;
// ObjAT_DCNVDTL.DCNV_SGST_ID=ObjAT_DCNVDTL.DCNV_SGST_ID;
// ObjAT_DCNVDTL.DCNV_SGST_Rate=ObjAT_DCNVDTL.DCNV_SGST_Rate;
// ObjAT_DCNVDTL.DCNV_SGST_Amt=ObjAT_DCNVDTL.DCNV_SGST_Amt;
// ObjAT_DCNVDTL.DCNV_SGST_TaxableAmt=ObjAT_DCNVDTL.DCNV_SGST_TaxableAmt;
// ObjAT_DCNVDTL.DCNV_IGST_ID=ObjAT_DCNVDTL.DCNV_IGST_ID;
// ObjAT_DCNVDTL.DCNV_IGST_Rate=ObjAT_DCNVDTL.DCNV_IGST_Rate;
// ObjAT_DCNVDTL.DCNV_IGST_Amt=ObjAT_DCNVDTL.DCNV_IGST_Amt;
// ObjAT_DCNVDTL.DCNV_IGST_TaxableAmt=ObjAT_DCNVDTL.DCNV_IGST_TaxableAmt;
// ObjAT_DCNVDTL.DCNV_CESS_ID=ObjAT_DCNVDTL.DCNV_CESS_ID;
// ObjAT_DCNVDTL.DCNV_CESS_Rate=ObjAT_DCNVDTL.DCNV_CESS_Rate;
// ObjAT_DCNVDTL.DCNV_CESS_Amt=ObjAT_DCNVDTL.DCNV_CESS_Amt;
// ObjAT_DCNVDTL.DCNV_CESS_TaxableAmt=ObjAT_DCNVDTL.DCNV_CESS_TaxableAmt;
// ObjAT_DCNVDTL.DCNV_OtherTax_ID=ObjAT_DCNVDTL.DCNV_OtherTax_ID;
// ObjAT_DCNVDTL.DCNV_OtherTax_Rate=ObjAT_DCNVDTL.DCNV_OtherTax_Rate;
// ObjAT_DCNVDTL.DCNV_OtherTax_Amt=ObjAT_DCNVDTL.DCNV_OtherTax_Amt;
// ObjAT_DCNVDTL.DCNV_OtherTax_TaxableAmt=ObjAT_DCNVDTL.DCNV_OtherTax_TaxableAmt;
// ObjAT_DCNVDTL.DCNV_TotalTax=ObjAT_DCNVDTL.DCNV_TotalTax;
// ObjAT_DCNVDTL.DCNV_GrossRateWithTax=ObjAT_DCNVDTL.DCNV_GrossRateWithTax;
// ObjAT_DCNVDTL.MDBSC_RowStatus=ObjAT_DCNVDTL.MDBSC_RowStatus;
// ObjAT_DCNVDTL.DCNV_ItemRemark_DTL=ObjAT_DCNVDTL.DCNV_ItemRemark_DTL;
// ObjAT_DCNVDTL.MDBSC_RowCreatedByUser_ID=ObjAT_DCNVDTL.MDBSC_RowCreatedByUser_ID;
// ObjAT_DCNVDTL.MDBSC_RowCreatedByUserName=ObjAT_DCNVDTL.MDBSC_RowCreatedByUserName;
// ObjAT_DCNVDTL.MDBSC_RowCreatedOn_DT=ObjAT_DCNVDTL.MDBSC_RowCreatedOn_DT;
// ObjAT_DCNVDTL.MDBSC_RowLupdnByUser_ID=ObjAT_DCNVDTL.MDBSC_RowLupdnByUser_ID;
// ObjAT_DCNVDTL.MDBSC_RowLupdnUserName=ObjAT_DCNVDTL.MDBSC_RowLupdnUserName;
// ObjAT_DCNVDTL.MDBSC_RowLupdnOn_DT=ObjAT_DCNVDTL.MDBSC_RowLupdnOn_DT;



// DCNVDTL_ID.Text = "";
// Fk_DCNVHDR_ID.Text = "";
// Fk_MItem_ID.Text = "";
// DCNV_HSNCode.Text = "";
// DCNV_QTY.Text = "";
// DCNV_BasicRate.Text = "";
// DCNV_NetRate.Text = "";
// DCNV_BasicAmt.Text = "";
// DCNV_DiscountRate.Text = "";
// DCNV_DiscountAmt.Text = "";
// DCNV_NetTaxableAmt.Text = "";
// DCNV_CGST_ID.Text = "";
// DCNV_CGST_Rate.Text = "";
// DCNV_CGST_Amt.Text = "";
// DCNV_CGST_TaxableAmt.Text = "";
// DCNV_SGST_ID.Text = "";
// DCNV_SGST_Rate.Text = "";
// DCNV_SGST_Amt.Text = "";
// DCNV_SGST_TaxableAmt.Text = "";
// DCNV_IGST_ID.Text = "";
// DCNV_IGST_Rate.Text = "";
// DCNV_IGST_Amt.Text = "";
// DCNV_IGST_TaxableAmt.Text = "";
// DCNV_CESS_ID.Text = "";
// DCNV_CESS_Rate.Text = "";
// DCNV_CESS_Amt.Text = "";
// DCNV_CESS_TaxableAmt.Text = "";
// DCNV_OtherTax_ID.Text = "";
// DCNV_OtherTax_Rate.Text = "";
// DCNV_OtherTax_Amt.Text = "";
// DCNV_OtherTax_TaxableAmt.Text = "";
// DCNV_TotalTax.Text = "";
// DCNV_GrossRateWithTax.Text = "";
// MDBSC_RowStatus.Text = "";
// DCNV_ItemRemark_DTL.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";



// ObjAT_DCNVDTL.DCNVDTL_ID=DCNVDTL_ID.Text ;
// ObjAT_DCNVDTL.Fk_DCNVHDR_ID=Fk_DCNVHDR_ID.Text ;
// ObjAT_DCNVDTL.Fk_MItem_ID=Fk_MItem_ID.Text ;
// ObjAT_DCNVDTL.DCNV_HSNCode=DCNV_HSNCode.Text ;
// ObjAT_DCNVDTL.DCNV_QTY=DCNV_QTY.Text ;
// ObjAT_DCNVDTL.DCNV_BasicRate=DCNV_BasicRate.Text ;
// ObjAT_DCNVDTL.DCNV_NetRate=DCNV_NetRate.Text ;
// ObjAT_DCNVDTL.DCNV_BasicAmt=DCNV_BasicAmt.Text ;
// ObjAT_DCNVDTL.DCNV_DiscountRate=DCNV_DiscountRate.Text ;
// ObjAT_DCNVDTL.DCNV_DiscountAmt=DCNV_DiscountAmt.Text ;
// ObjAT_DCNVDTL.DCNV_NetTaxableAmt=DCNV_NetTaxableAmt.Text ;
// ObjAT_DCNVDTL.DCNV_CGST_ID=DCNV_CGST_ID.Text ;
// ObjAT_DCNVDTL.DCNV_CGST_Rate=DCNV_CGST_Rate.Text ;
// ObjAT_DCNVDTL.DCNV_CGST_Amt=DCNV_CGST_Amt.Text ;
// ObjAT_DCNVDTL.DCNV_CGST_TaxableAmt=DCNV_CGST_TaxableAmt.Text ;
// ObjAT_DCNVDTL.DCNV_SGST_ID=DCNV_SGST_ID.Text ;
// ObjAT_DCNVDTL.DCNV_SGST_Rate=DCNV_SGST_Rate.Text ;
// ObjAT_DCNVDTL.DCNV_SGST_Amt=DCNV_SGST_Amt.Text ;
// ObjAT_DCNVDTL.DCNV_SGST_TaxableAmt=DCNV_SGST_TaxableAmt.Text ;
// ObjAT_DCNVDTL.DCNV_IGST_ID=DCNV_IGST_ID.Text ;
// ObjAT_DCNVDTL.DCNV_IGST_Rate=DCNV_IGST_Rate.Text ;
// ObjAT_DCNVDTL.DCNV_IGST_Amt=DCNV_IGST_Amt.Text ;
// ObjAT_DCNVDTL.DCNV_IGST_TaxableAmt=DCNV_IGST_TaxableAmt.Text ;
// ObjAT_DCNVDTL.DCNV_CESS_ID=DCNV_CESS_ID.Text ;
// ObjAT_DCNVDTL.DCNV_CESS_Rate=DCNV_CESS_Rate.Text ;
// ObjAT_DCNVDTL.DCNV_CESS_Amt=DCNV_CESS_Amt.Text ;
// ObjAT_DCNVDTL.DCNV_CESS_TaxableAmt=DCNV_CESS_TaxableAmt.Text ;
// ObjAT_DCNVDTL.DCNV_OtherTax_ID=DCNV_OtherTax_ID.Text ;
// ObjAT_DCNVDTL.DCNV_OtherTax_Rate=DCNV_OtherTax_Rate.Text ;
// ObjAT_DCNVDTL.DCNV_OtherTax_Amt=DCNV_OtherTax_Amt.Text ;
// ObjAT_DCNVDTL.DCNV_OtherTax_TaxableAmt=DCNV_OtherTax_TaxableAmt.Text ;
// ObjAT_DCNVDTL.DCNV_TotalTax=DCNV_TotalTax.Text ;
// ObjAT_DCNVDTL.DCNV_GrossRateWithTax=DCNV_GrossRateWithTax.Text ;
// ObjAT_DCNVDTL.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_DCNVDTL.DCNV_ItemRemark_DTL=DCNV_ItemRemark_DTL.Text ;
// ObjAT_DCNVDTL.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_DCNVDTL.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_DCNVDTL.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_DCNVDTL.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_DCNVDTL.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_DCNVDTL.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;



// DCNVDTL_ID.Text =  dt.Rows[0]["DCNVDTL_ID"].ToString();
// Fk_DCNVHDR_ID.Text =  dt.Rows[0]["Fk_DCNVHDR_ID"].ToString();
// Fk_MItem_ID.Text =  dt.Rows[0]["Fk_MItem_ID"].ToString();
// DCNV_HSNCode.Text =  dt.Rows[0]["DCNV_HSNCode"].ToString();
// DCNV_QTY.Text =  dt.Rows[0]["DCNV_QTY"].ToString();
// DCNV_BasicRate.Text =  dt.Rows[0]["DCNV_BasicRate"].ToString();
// DCNV_NetRate.Text =  dt.Rows[0]["DCNV_NetRate"].ToString();
// DCNV_BasicAmt.Text =  dt.Rows[0]["DCNV_BasicAmt"].ToString();
// DCNV_DiscountRate.Text =  dt.Rows[0]["DCNV_DiscountRate"].ToString();
// DCNV_DiscountAmt.Text =  dt.Rows[0]["DCNV_DiscountAmt"].ToString();
// DCNV_NetTaxableAmt.Text =  dt.Rows[0]["DCNV_NetTaxableAmt"].ToString();
// DCNV_CGST_ID.Text =  dt.Rows[0]["DCNV_CGST_ID"].ToString();
// DCNV_CGST_Rate.Text =  dt.Rows[0]["DCNV_CGST_Rate"].ToString();
// DCNV_CGST_Amt.Text =  dt.Rows[0]["DCNV_CGST_Amt"].ToString();
// DCNV_CGST_TaxableAmt.Text =  dt.Rows[0]["DCNV_CGST_TaxableAmt"].ToString();
// DCNV_SGST_ID.Text =  dt.Rows[0]["DCNV_SGST_ID"].ToString();
// DCNV_SGST_Rate.Text =  dt.Rows[0]["DCNV_SGST_Rate"].ToString();
// DCNV_SGST_Amt.Text =  dt.Rows[0]["DCNV_SGST_Amt"].ToString();
// DCNV_SGST_TaxableAmt.Text =  dt.Rows[0]["DCNV_SGST_TaxableAmt"].ToString();
// DCNV_IGST_ID.Text =  dt.Rows[0]["DCNV_IGST_ID"].ToString();
// DCNV_IGST_Rate.Text =  dt.Rows[0]["DCNV_IGST_Rate"].ToString();
// DCNV_IGST_Amt.Text =  dt.Rows[0]["DCNV_IGST_Amt"].ToString();
// DCNV_IGST_TaxableAmt.Text =  dt.Rows[0]["DCNV_IGST_TaxableAmt"].ToString();
// DCNV_CESS_ID.Text =  dt.Rows[0]["DCNV_CESS_ID"].ToString();
// DCNV_CESS_Rate.Text =  dt.Rows[0]["DCNV_CESS_Rate"].ToString();
// DCNV_CESS_Amt.Text =  dt.Rows[0]["DCNV_CESS_Amt"].ToString();
// DCNV_CESS_TaxableAmt.Text =  dt.Rows[0]["DCNV_CESS_TaxableAmt"].ToString();
// DCNV_OtherTax_ID.Text =  dt.Rows[0]["DCNV_OtherTax_ID"].ToString();
// DCNV_OtherTax_Rate.Text =  dt.Rows[0]["DCNV_OtherTax_Rate"].ToString();
// DCNV_OtherTax_Amt.Text =  dt.Rows[0]["DCNV_OtherTax_Amt"].ToString();
// DCNV_OtherTax_TaxableAmt.Text =  dt.Rows[0]["DCNV_OtherTax_TaxableAmt"].ToString();
// DCNV_TotalTax.Text =  dt.Rows[0]["DCNV_TotalTax"].ToString();
// DCNV_GrossRateWithTax.Text =  dt.Rows[0]["DCNV_GrossRateWithTax"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// DCNV_ItemRemark_DTL.Text =  dt.Rows[0]["DCNV_ItemRemark_DTL"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();

