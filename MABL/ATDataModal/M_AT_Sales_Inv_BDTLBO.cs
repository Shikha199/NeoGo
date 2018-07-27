using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal
{
    public class M_AT_Sales_Inv_BDTLBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public M_AT_Sales_Inv_BDTLBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "SINVDTL_ID";
        private string _TableName = "M_AT_Sales_Inv_BDTL";
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

        private Int64 _SINVDTL_ID;
        private Int64 _Fk_SINVHDR_ID;
        private Int64 _Fk_DCHDR_ID;
        private Int64 _Fk_DCDTL_ID;
        private Int64 _Fk_MItem_ID;
        private String _SINV_HSNCode;
        private Decimal _SINV_QTY;
        private Decimal _SINV_QTY_Tolerance_Rate;
        private Decimal _SINV_QTY_Tolerance;
        private Decimal _SINV_Final_Qty;
        private Decimal _SINV_GRN_Qty;
        private Decimal _SINV_GRN_Rejected_Qty;
        private Decimal _SINV_Blance_Qty;
        private String _Qtn_Selected;
        private Decimal _SINV_BasicRate;
        private Decimal _SINV_NetRate;
        private Decimal _SINV_BasicAmt;
        private Decimal _SINV_DiscountRate;
        private Decimal _SINV_DiscountAmt;
        private Decimal _SINV_NetTaxableAmt;
        private Int16 _SINV_GST_TaxRate_ID;
        private Decimal _SINV_GST_TaxRate;
        private Int16 _SINV_CGST_ID;
        private Decimal _SINV_CGST_Rate;
        private Decimal _SINV_CGST_Amt;
        private Decimal _SINV_CGST_TaxableAmt;
        private Int16 _SINV_SGST_ID;
        private Decimal _SINV_SGST_Rate;
        private Decimal _SINV_SGST_Amt;
        private Decimal _SINV_SGST_TaxableAmt;
        private Int16 _SINV_IGST_ID;
        private Decimal _SINV_IGST_Rate;
        private Decimal _SINV_IGST_Amt;
        private Decimal _SINV_IGST_TaxableAmt;
        private Int16 _SINV_CESS_ID;
        private Decimal _SINV_CESS_Rate;
        private Decimal _SINV_CESS_Amt;
        private Decimal _SINV_CESS_TaxableAmt;
        private Int16 _SINV_OtherTax_ID;
        private Decimal _SINV_OtherTax_Rate;
        private Decimal _SINV_OtherTax_Amt;
        private Decimal _SINV_OtherTax_TaxableAmt;
        private Decimal _SINV_TotalTax;
        private Decimal _SINV_GrossRateWithTax;
        private String _MDBSC_RowStatus;
        private String _SINV_ItemRemark_DTL;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;

        public Int64 SINVDTL_ID
        {
            get
            {
                return this._SINVDTL_ID;
            }
            set
            {
                this._SINVDTL_ID = value;
                _UpdateFieldName.Add("SINVDTL_ID");
            }
        }
        public Int64 Fk_SINVHDR_ID
        {
            get
            {
                return this._Fk_SINVHDR_ID;
            }
            set
            {
                this._Fk_SINVHDR_ID = value;
                _UpdateFieldName.Add("Fk_SINVHDR_ID");
            }
        }
        public Int64 Fk_DCHDR_ID
        {
            get
            {
                return this._Fk_DCHDR_ID;
            }
            set
            {
                this._Fk_DCHDR_ID = value;
                _UpdateFieldName.Add("Fk_DCHDR_ID");
            }
        }
        public Int64 Fk_DCDTL_ID
        {
            get
            {
                return this._Fk_DCDTL_ID;
            }
            set
            {
                this._Fk_DCDTL_ID = value;
                _UpdateFieldName.Add("Fk_DCDTL_ID");
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
        public String SINV_HSNCode
        {
            get
            {
                return this._SINV_HSNCode;
            }
            set
            {
                this._SINV_HSNCode = value;
                _UpdateFieldName.Add("SINV_HSNCode");
            }
        }
        public Decimal SINV_QTY
        {
            get
            {
                return this._SINV_QTY;
            }
            set
            {
                this._SINV_QTY = value;
                _UpdateFieldName.Add("SINV_QTY");
            }
        }
        public Decimal SINV_QTY_Tolerance_Rate
        {
            get
            {
                return this._SINV_QTY_Tolerance_Rate;
            }
            set
            {
                this._SINV_QTY_Tolerance_Rate = value;
                _UpdateFieldName.Add("SINV_QTY_Tolerance_Rate");
            }
        }
        public Decimal SINV_QTY_Tolerance
        {
            get
            {
                return this._SINV_QTY_Tolerance;
            }
            set
            {
                this._SINV_QTY_Tolerance = value;
                _UpdateFieldName.Add("SINV_QTY_Tolerance");
            }
        }
        public Decimal SINV_Final_Qty
        {
            get
            {
                return this._SINV_Final_Qty;
            }
            set
            {
                this._SINV_Final_Qty = value;
                _UpdateFieldName.Add("SINV_Final_Qty");
            }
        }
        public Decimal SINV_GRN_Qty
        {
            get
            {
                return this._SINV_GRN_Qty;
            }
            set
            {
                this._SINV_GRN_Qty = value;
                _UpdateFieldName.Add("SINV_GRN_Qty");
            }
        }
        public Decimal SINV_GRN_Rejected_Qty
        {
            get
            {
                return this._SINV_GRN_Rejected_Qty;
            }
            set
            {
                this._SINV_GRN_Rejected_Qty = value;
                _UpdateFieldName.Add("SINV_GRN_Rejected_Qty");
            }
        }
        public Decimal SINV_Blance_Qty
        {
            get
            {
                return this._SINV_Blance_Qty;
            }
            set
            {
                this._SINV_Blance_Qty = value;
                _UpdateFieldName.Add("SINV_Blance_Qty");
            }
        }
        public String Qtn_Selected
        {
            get
            {
                return this._Qtn_Selected;
            }
            set
            {
                this._Qtn_Selected = value;
                _UpdateFieldName.Add("Qtn_Selected");
            }
        }
        public Decimal SINV_BasicRate
        {
            get
            {
                return this._SINV_BasicRate;
            }
            set
            {
                this._SINV_BasicRate = value;
                _UpdateFieldName.Add("SINV_BasicRate");
            }
        }
        public Decimal SINV_NetRate
        {
            get
            {
                return this._SINV_NetRate;
            }
            set
            {
                this._SINV_NetRate = value;
                _UpdateFieldName.Add("SINV_NetRate");
            }
        }
        public Decimal SINV_BasicAmt
        {
            get
            {
                return this._SINV_BasicAmt;
            }
            set
            {
                this._SINV_BasicAmt = value;
                _UpdateFieldName.Add("SINV_BasicAmt");
            }
        }
        public Decimal SINV_DiscountRate
        {
            get
            {
                return this._SINV_DiscountRate;
            }
            set
            {
                this._SINV_DiscountRate = value;
                _UpdateFieldName.Add("SINV_DiscountRate");
            }
        }
        public Decimal SINV_DiscountAmt
        {
            get
            {
                return this._SINV_DiscountAmt;
            }
            set
            {
                this._SINV_DiscountAmt = value;
                _UpdateFieldName.Add("SINV_DiscountAmt");
            }
        }
        public Decimal SINV_NetTaxableAmt
        {
            get
            {
                return this._SINV_NetTaxableAmt;
            }
            set
            {
                this._SINV_NetTaxableAmt = value;
                _UpdateFieldName.Add("SINV_NetTaxableAmt");
            }
        }
        public Int16 SINV_GST_TaxRate_ID
        {
            get
            {
                return this._SINV_GST_TaxRate_ID;
            }
            set
            {
                this._SINV_GST_TaxRate_ID = value;
                _UpdateFieldName.Add("SINV_GST_TaxRate_ID");
            }
        }
        public Decimal SINV_GST_TaxRate
        {
            get
            {
                return this._SINV_GST_TaxRate;
            }
            set
            {
                this._SINV_GST_TaxRate = value;
                _UpdateFieldName.Add("SINV_GST_TaxRate");
            }
        }
        public Int16 SINV_CGST_ID
        {
            get
            {
                return this._SINV_CGST_ID;
            }
            set
            {
                this._SINV_CGST_ID = value;
                _UpdateFieldName.Add("SINV_CGST_ID");
            }
        }
        public Decimal SINV_CGST_Rate
        {
            get
            {
                return this._SINV_CGST_Rate;
            }
            set
            {
                this._SINV_CGST_Rate = value;
                _UpdateFieldName.Add("SINV_CGST_Rate");
            }
        }
        public Decimal SINV_CGST_Amt
        {
            get
            {
                return this._SINV_CGST_Amt;
            }
            set
            {
                this._SINV_CGST_Amt = value;
                _UpdateFieldName.Add("SINV_CGST_Amt");
            }
        }
        public Decimal SINV_CGST_TaxableAmt
        {
            get
            {
                return this._SINV_CGST_TaxableAmt;
            }
            set
            {
                this._SINV_CGST_TaxableAmt = value;
                _UpdateFieldName.Add("SINV_CGST_TaxableAmt");
            }
        }
        public Int16 SINV_SGST_ID
        {
            get
            {
                return this._SINV_SGST_ID;
            }
            set
            {
                this._SINV_SGST_ID = value;
                _UpdateFieldName.Add("SINV_SGST_ID");
            }
        }
        public Decimal SINV_SGST_Rate
        {
            get
            {
                return this._SINV_SGST_Rate;
            }
            set
            {
                this._SINV_SGST_Rate = value;
                _UpdateFieldName.Add("SINV_SGST_Rate");
            }
        }
        public Decimal SINV_SGST_Amt
        {
            get
            {
                return this._SINV_SGST_Amt;
            }
            set
            {
                this._SINV_SGST_Amt = value;
                _UpdateFieldName.Add("SINV_SGST_Amt");
            }
        }
        public Decimal SINV_SGST_TaxableAmt
        {
            get
            {
                return this._SINV_SGST_TaxableAmt;
            }
            set
            {
                this._SINV_SGST_TaxableAmt = value;
                _UpdateFieldName.Add("SINV_SGST_TaxableAmt");
            }
        }
        public Int16 SINV_IGST_ID
        {
            get
            {
                return this._SINV_IGST_ID;
            }
            set
            {
                this._SINV_IGST_ID = value;
                _UpdateFieldName.Add("SINV_IGST_ID");
            }
        }
        public Decimal SINV_IGST_Rate
        {
            get
            {
                return this._SINV_IGST_Rate;
            }
            set
            {
                this._SINV_IGST_Rate = value;
                _UpdateFieldName.Add("SINV_IGST_Rate");
            }
        }
        public Decimal SINV_IGST_Amt
        {
            get
            {
                return this._SINV_IGST_Amt;
            }
            set
            {
                this._SINV_IGST_Amt = value;
                _UpdateFieldName.Add("SINV_IGST_Amt");
            }
        }
        public Decimal SINV_IGST_TaxableAmt
        {
            get
            {
                return this._SINV_IGST_TaxableAmt;
            }
            set
            {
                this._SINV_IGST_TaxableAmt = value;
                _UpdateFieldName.Add("SINV_IGST_TaxableAmt");
            }
        }
        public Int16 SINV_CESS_ID
        {
            get
            {
                return this._SINV_CESS_ID;
            }
            set
            {
                this._SINV_CESS_ID = value;
                _UpdateFieldName.Add("SINV_CESS_ID");
            }
        }
        public Decimal SINV_CESS_Rate
        {
            get
            {
                return this._SINV_CESS_Rate;
            }
            set
            {
                this._SINV_CESS_Rate = value;
                _UpdateFieldName.Add("SINV_CESS_Rate");
            }
        }
        public Decimal SINV_CESS_Amt
        {
            get
            {
                return this._SINV_CESS_Amt;
            }
            set
            {
                this._SINV_CESS_Amt = value;
                _UpdateFieldName.Add("SINV_CESS_Amt");
            }
        }
        public Decimal SINV_CESS_TaxableAmt
        {
            get
            {
                return this._SINV_CESS_TaxableAmt;
            }
            set
            {
                this._SINV_CESS_TaxableAmt = value;
                _UpdateFieldName.Add("SINV_CESS_TaxableAmt");
            }
        }
        public Int16 SINV_OtherTax_ID
        {
            get
            {
                return this._SINV_OtherTax_ID;
            }
            set
            {
                this._SINV_OtherTax_ID = value;
                _UpdateFieldName.Add("SINV_OtherTax_ID");
            }
        }
        public Decimal SINV_OtherTax_Rate
        {
            get
            {
                return this._SINV_OtherTax_Rate;
            }
            set
            {
                this._SINV_OtherTax_Rate = value;
                _UpdateFieldName.Add("SINV_OtherTax_Rate");
            }
        }
        public Decimal SINV_OtherTax_Amt
        {
            get
            {
                return this._SINV_OtherTax_Amt;
            }
            set
            {
                this._SINV_OtherTax_Amt = value;
                _UpdateFieldName.Add("SINV_OtherTax_Amt");
            }
        }
        public Decimal SINV_OtherTax_TaxableAmt
        {
            get
            {
                return this._SINV_OtherTax_TaxableAmt;
            }
            set
            {
                this._SINV_OtherTax_TaxableAmt = value;
                _UpdateFieldName.Add("SINV_OtherTax_TaxableAmt");
            }
        }
        public Decimal SINV_TotalTax
        {
            get
            {
                return this._SINV_TotalTax;
            }
            set
            {
                this._SINV_TotalTax = value;
                _UpdateFieldName.Add("SINV_TotalTax");
            }
        }
        public Decimal SINV_GrossRateWithTax
        {
            get
            {
                return this._SINV_GrossRateWithTax;
            }
            set
            {
                this._SINV_GrossRateWithTax = value;
                _UpdateFieldName.Add("SINV_GrossRateWithTax");
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
        public String SINV_ItemRemark_DTL
        {
            get
            {
                return this._SINV_ItemRemark_DTL;
            }
            set
            {
                this._SINV_ItemRemark_DTL = value;
                _UpdateFieldName.Add("SINV_ItemRemark_DTL");
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
        public string Insert_Update(M_AT_Sales_Inv_BDTLBO sObject)
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

// ObjAT_SINVDTL.SINVDTL_ID=ObjAT_SINVDTL.SINVDTL_ID;
// ObjAT_SINVDTL.Fk_SINVHDR_ID=ObjAT_SINVDTL.Fk_SINVHDR_ID;
// ObjAT_SINVDTL.Fk_DCHDR_ID=ObjAT_SINVDTL.Fk_DCHDR_ID;
// ObjAT_SINVDTL.Fk_DCDTL_ID=ObjAT_SINVDTL.Fk_DCDTL_ID;
// ObjAT_SINVDTL.Fk_MItem_ID=ObjAT_SINVDTL.Fk_MItem_ID;
// ObjAT_SINVDTL.SINV_HSNCode=ObjAT_SINVDTL.SINV_HSNCode;
// ObjAT_SINVDTL.SINV_QTY=ObjAT_SINVDTL.SINV_QTY;
// ObjAT_SINVDTL.SINV_QTY_Tolerance_Rate=ObjAT_SINVDTL.SINV_QTY_Tolerance_Rate;
// ObjAT_SINVDTL.SINV_QTY_Tolerance=ObjAT_SINVDTL.SINV_QTY_Tolerance;
// ObjAT_SINVDTL.SINV_Final_Qty=ObjAT_SINVDTL.SINV_Final_Qty;
// ObjAT_SINVDTL.SINV_GRN_Qty=ObjAT_SINVDTL.SINV_GRN_Qty;
// ObjAT_SINVDTL.SINV_GRN_Rejected_Qty=ObjAT_SINVDTL.SINV_GRN_Rejected_Qty;
// ObjAT_SINVDTL.SINV_Blance_Qty=ObjAT_SINVDTL.SINV_Blance_Qty;
// ObjAT_SINVDTL.Qtn_Selected=ObjAT_SINVDTL.Qtn_Selected;
// ObjAT_SINVDTL.SINV_BasicRate=ObjAT_SINVDTL.SINV_BasicRate;
// ObjAT_SINVDTL.SINV_NetRate=ObjAT_SINVDTL.SINV_NetRate;
// ObjAT_SINVDTL.SINV_BasicAmt=ObjAT_SINVDTL.SINV_BasicAmt;
// ObjAT_SINVDTL.SINV_DiscountRate=ObjAT_SINVDTL.SINV_DiscountRate;
// ObjAT_SINVDTL.SINV_DiscountAmt=ObjAT_SINVDTL.SINV_DiscountAmt;
// ObjAT_SINVDTL.SINV_NetTaxableAmt=ObjAT_SINVDTL.SINV_NetTaxableAmt;
// ObjAT_SINVDTL.SINV_GST_TaxRate_ID=ObjAT_SINVDTL.SINV_GST_TaxRate_ID;
// ObjAT_SINVDTL.SINV_GST_TaxRate=ObjAT_SINVDTL.SINV_GST_TaxRate;
// ObjAT_SINVDTL.SINV_CGST_ID=ObjAT_SINVDTL.SINV_CGST_ID;
// ObjAT_SINVDTL.SINV_CGST_Rate=ObjAT_SINVDTL.SINV_CGST_Rate;
// ObjAT_SINVDTL.SINV_CGST_Amt=ObjAT_SINVDTL.SINV_CGST_Amt;
// ObjAT_SINVDTL.SINV_CGST_TaxableAmt=ObjAT_SINVDTL.SINV_CGST_TaxableAmt;
// ObjAT_SINVDTL.SINV_SGST_ID=ObjAT_SINVDTL.SINV_SGST_ID;
// ObjAT_SINVDTL.SINV_SGST_Rate=ObjAT_SINVDTL.SINV_SGST_Rate;
// ObjAT_SINVDTL.SINV_SGST_Amt=ObjAT_SINVDTL.SINV_SGST_Amt;
// ObjAT_SINVDTL.SINV_SGST_TaxableAmt=ObjAT_SINVDTL.SINV_SGST_TaxableAmt;
// ObjAT_SINVDTL.SINV_IGST_ID=ObjAT_SINVDTL.SINV_IGST_ID;
// ObjAT_SINVDTL.SINV_IGST_Rate=ObjAT_SINVDTL.SINV_IGST_Rate;
// ObjAT_SINVDTL.SINV_IGST_Amt=ObjAT_SINVDTL.SINV_IGST_Amt;
// ObjAT_SINVDTL.SINV_IGST_TaxableAmt=ObjAT_SINVDTL.SINV_IGST_TaxableAmt;
// ObjAT_SINVDTL.SINV_CESS_ID=ObjAT_SINVDTL.SINV_CESS_ID;
// ObjAT_SINVDTL.SINV_CESS_Rate=ObjAT_SINVDTL.SINV_CESS_Rate;
// ObjAT_SINVDTL.SINV_CESS_Amt=ObjAT_SINVDTL.SINV_CESS_Amt;
// ObjAT_SINVDTL.SINV_CESS_TaxableAmt=ObjAT_SINVDTL.SINV_CESS_TaxableAmt;
// ObjAT_SINVDTL.SINV_OtherTax_ID=ObjAT_SINVDTL.SINV_OtherTax_ID;
// ObjAT_SINVDTL.SINV_OtherTax_Rate=ObjAT_SINVDTL.SINV_OtherTax_Rate;
// ObjAT_SINVDTL.SINV_OtherTax_Amt=ObjAT_SINVDTL.SINV_OtherTax_Amt;
// ObjAT_SINVDTL.SINV_OtherTax_TaxableAmt=ObjAT_SINVDTL.SINV_OtherTax_TaxableAmt;
// ObjAT_SINVDTL.SINV_TotalTax=ObjAT_SINVDTL.SINV_TotalTax;
// ObjAT_SINVDTL.SINV_GrossRateWithTax=ObjAT_SINVDTL.SINV_GrossRateWithTax;
// ObjAT_SINVDTL.MDBSC_RowStatus=ObjAT_SINVDTL.MDBSC_RowStatus;
// ObjAT_SINVDTL.SINV_ItemRemark_DTL=ObjAT_SINVDTL.SINV_ItemRemark_DTL;
// ObjAT_SINVDTL.MDBSC_RowCreatedByUser_ID=ObjAT_SINVDTL.MDBSC_RowCreatedByUser_ID;
// ObjAT_SINVDTL.MDBSC_RowCreatedByUserName=ObjAT_SINVDTL.MDBSC_RowCreatedByUserName;
// ObjAT_SINVDTL.MDBSC_RowCreatedOn_DT=ObjAT_SINVDTL.MDBSC_RowCreatedOn_DT;
// ObjAT_SINVDTL.MDBSC_RowLupdnByUser_ID=ObjAT_SINVDTL.MDBSC_RowLupdnByUser_ID;
// ObjAT_SINVDTL.MDBSC_RowLupdnUserName=ObjAT_SINVDTL.MDBSC_RowLupdnUserName;
// ObjAT_SINVDTL.MDBSC_RowLupdnOn_DT=ObjAT_SINVDTL.MDBSC_RowLupdnOn_DT;



// SINVDTL_ID.Text = "";
// Fk_SINVHDR_ID.Text = "";
// Fk_DCHDR_ID.Text = "";
// Fk_DCDTL_ID.Text = "";
// Fk_MItem_ID.Text = "";
// SINV_HSNCode.Text = "";
// SINV_QTY.Text = "";
// SINV_QTY_Tolerance_Rate.Text = "";
// SINV_QTY_Tolerance.Text = "";
// SINV_Final_Qty.Text = "";
// SINV_GRN_Qty.Text = "";
// SINV_GRN_Rejected_Qty.Text = "";
// SINV_Blance_Qty.Text = "";
// Qtn_Selected.Text = "";
// SINV_BasicRate.Text = "";
// SINV_NetRate.Text = "";
// SINV_BasicAmt.Text = "";
// SINV_DiscountRate.Text = "";
// SINV_DiscountAmt.Text = "";
// SINV_NetTaxableAmt.Text = "";
// SINV_GST_TaxRate_ID.Text = "";
// SINV_GST_TaxRate.Text = "";
// SINV_CGST_ID.Text = "";
// SINV_CGST_Rate.Text = "";
// SINV_CGST_Amt.Text = "";
// SINV_CGST_TaxableAmt.Text = "";
// SINV_SGST_ID.Text = "";
// SINV_SGST_Rate.Text = "";
// SINV_SGST_Amt.Text = "";
// SINV_SGST_TaxableAmt.Text = "";
// SINV_IGST_ID.Text = "";
// SINV_IGST_Rate.Text = "";
// SINV_IGST_Amt.Text = "";
// SINV_IGST_TaxableAmt.Text = "";
// SINV_CESS_ID.Text = "";
// SINV_CESS_Rate.Text = "";
// SINV_CESS_Amt.Text = "";
// SINV_CESS_TaxableAmt.Text = "";
// SINV_OtherTax_ID.Text = "";
// SINV_OtherTax_Rate.Text = "";
// SINV_OtherTax_Amt.Text = "";
// SINV_OtherTax_TaxableAmt.Text = "";
// SINV_TotalTax.Text = "";
// SINV_GrossRateWithTax.Text = "";
// MDBSC_RowStatus.Text = "";
// SINV_ItemRemark_DTL.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";



// ObjAT_SINVDTL.SINVDTL_ID=SINVDTL_ID.Text ;
// ObjAT_SINVDTL.Fk_SINVHDR_ID=Fk_SINVHDR_ID.Text ;
// ObjAT_SINVDTL.Fk_DCHDR_ID=Fk_DCHDR_ID.Text ;
// ObjAT_SINVDTL.Fk_DCDTL_ID=Fk_DCDTL_ID.Text ;
// ObjAT_SINVDTL.Fk_MItem_ID=Fk_MItem_ID.Text ;
// ObjAT_SINVDTL.SINV_HSNCode=SINV_HSNCode.Text ;
// ObjAT_SINVDTL.SINV_QTY=SINV_QTY.Text ;
// ObjAT_SINVDTL.SINV_QTY_Tolerance_Rate=SINV_QTY_Tolerance_Rate.Text ;
// ObjAT_SINVDTL.SINV_QTY_Tolerance=SINV_QTY_Tolerance.Text ;
// ObjAT_SINVDTL.SINV_Final_Qty=SINV_Final_Qty.Text ;
// ObjAT_SINVDTL.SINV_GRN_Qty=SINV_GRN_Qty.Text ;
// ObjAT_SINVDTL.SINV_GRN_Rejected_Qty=SINV_GRN_Rejected_Qty.Text ;
// ObjAT_SINVDTL.SINV_Blance_Qty=SINV_Blance_Qty.Text ;
// ObjAT_SINVDTL.Qtn_Selected=Qtn_Selected.Text ;
// ObjAT_SINVDTL.SINV_BasicRate=SINV_BasicRate.Text ;
// ObjAT_SINVDTL.SINV_NetRate=SINV_NetRate.Text ;
// ObjAT_SINVDTL.SINV_BasicAmt=SINV_BasicAmt.Text ;
// ObjAT_SINVDTL.SINV_DiscountRate=SINV_DiscountRate.Text ;
// ObjAT_SINVDTL.SINV_DiscountAmt=SINV_DiscountAmt.Text ;
// ObjAT_SINVDTL.SINV_NetTaxableAmt=SINV_NetTaxableAmt.Text ;
// ObjAT_SINVDTL.SINV_GST_TaxRate_ID=SINV_GST_TaxRate_ID.Text ;
// ObjAT_SINVDTL.SINV_GST_TaxRate=SINV_GST_TaxRate.Text ;
// ObjAT_SINVDTL.SINV_CGST_ID=SINV_CGST_ID.Text ;
// ObjAT_SINVDTL.SINV_CGST_Rate=SINV_CGST_Rate.Text ;
// ObjAT_SINVDTL.SINV_CGST_Amt=SINV_CGST_Amt.Text ;
// ObjAT_SINVDTL.SINV_CGST_TaxableAmt=SINV_CGST_TaxableAmt.Text ;
// ObjAT_SINVDTL.SINV_SGST_ID=SINV_SGST_ID.Text ;
// ObjAT_SINVDTL.SINV_SGST_Rate=SINV_SGST_Rate.Text ;
// ObjAT_SINVDTL.SINV_SGST_Amt=SINV_SGST_Amt.Text ;
// ObjAT_SINVDTL.SINV_SGST_TaxableAmt=SINV_SGST_TaxableAmt.Text ;
// ObjAT_SINVDTL.SINV_IGST_ID=SINV_IGST_ID.Text ;
// ObjAT_SINVDTL.SINV_IGST_Rate=SINV_IGST_Rate.Text ;
// ObjAT_SINVDTL.SINV_IGST_Amt=SINV_IGST_Amt.Text ;
// ObjAT_SINVDTL.SINV_IGST_TaxableAmt=SINV_IGST_TaxableAmt.Text ;
// ObjAT_SINVDTL.SINV_CESS_ID=SINV_CESS_ID.Text ;
// ObjAT_SINVDTL.SINV_CESS_Rate=SINV_CESS_Rate.Text ;
// ObjAT_SINVDTL.SINV_CESS_Amt=SINV_CESS_Amt.Text ;
// ObjAT_SINVDTL.SINV_CESS_TaxableAmt=SINV_CESS_TaxableAmt.Text ;
// ObjAT_SINVDTL.SINV_OtherTax_ID=SINV_OtherTax_ID.Text ;
// ObjAT_SINVDTL.SINV_OtherTax_Rate=SINV_OtherTax_Rate.Text ;
// ObjAT_SINVDTL.SINV_OtherTax_Amt=SINV_OtherTax_Amt.Text ;
// ObjAT_SINVDTL.SINV_OtherTax_TaxableAmt=SINV_OtherTax_TaxableAmt.Text ;
// ObjAT_SINVDTL.SINV_TotalTax=SINV_TotalTax.Text ;
// ObjAT_SINVDTL.SINV_GrossRateWithTax=SINV_GrossRateWithTax.Text ;
// ObjAT_SINVDTL.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_SINVDTL.SINV_ItemRemark_DTL=SINV_ItemRemark_DTL.Text ;
// ObjAT_SINVDTL.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_SINVDTL.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_SINVDTL.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_SINVDTL.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_SINVDTL.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_SINVDTL.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;



// SINVDTL_ID.Text =  dt.Rows[0]["SINVDTL_ID"].ToString();
// Fk_SINVHDR_ID.Text =  dt.Rows[0]["Fk_SINVHDR_ID"].ToString();
// Fk_DCHDR_ID.Text =  dt.Rows[0]["Fk_DCHDR_ID"].ToString();
// Fk_DCDTL_ID.Text =  dt.Rows[0]["Fk_DCDTL_ID"].ToString();
// Fk_MItem_ID.Text =  dt.Rows[0]["Fk_MItem_ID"].ToString();
// SINV_HSNCode.Text =  dt.Rows[0]["SINV_HSNCode"].ToString();
// SINV_QTY.Text =  dt.Rows[0]["SINV_QTY"].ToString();
// SINV_QTY_Tolerance_Rate.Text =  dt.Rows[0]["SINV_QTY_Tolerance_Rate"].ToString();
// SINV_QTY_Tolerance.Text =  dt.Rows[0]["SINV_QTY_Tolerance"].ToString();
// SINV_Final_Qty.Text =  dt.Rows[0]["SINV_Final_Qty"].ToString();
// SINV_GRN_Qty.Text =  dt.Rows[0]["SINV_GRN_Qty"].ToString();
// SINV_GRN_Rejected_Qty.Text =  dt.Rows[0]["SINV_GRN_Rejected_Qty"].ToString();
// SINV_Blance_Qty.Text =  dt.Rows[0]["SINV_Blance_Qty"].ToString();
// Qtn_Selected.Text =  dt.Rows[0]["Qtn_Selected"].ToString();
// SINV_BasicRate.Text =  dt.Rows[0]["SINV_BasicRate"].ToString();
// SINV_NetRate.Text =  dt.Rows[0]["SINV_NetRate"].ToString();
// SINV_BasicAmt.Text =  dt.Rows[0]["SINV_BasicAmt"].ToString();
// SINV_DiscountRate.Text =  dt.Rows[0]["SINV_DiscountRate"].ToString();
// SINV_DiscountAmt.Text =  dt.Rows[0]["SINV_DiscountAmt"].ToString();
// SINV_NetTaxableAmt.Text =  dt.Rows[0]["SINV_NetTaxableAmt"].ToString();
// SINV_GST_TaxRate_ID.Text =  dt.Rows[0]["SINV_GST_TaxRate_ID"].ToString();
// SINV_GST_TaxRate.Text =  dt.Rows[0]["SINV_GST_TaxRate"].ToString();
// SINV_CGST_ID.Text =  dt.Rows[0]["SINV_CGST_ID"].ToString();
// SINV_CGST_Rate.Text =  dt.Rows[0]["SINV_CGST_Rate"].ToString();
// SINV_CGST_Amt.Text =  dt.Rows[0]["SINV_CGST_Amt"].ToString();
// SINV_CGST_TaxableAmt.Text =  dt.Rows[0]["SINV_CGST_TaxableAmt"].ToString();
// SINV_SGST_ID.Text =  dt.Rows[0]["SINV_SGST_ID"].ToString();
// SINV_SGST_Rate.Text =  dt.Rows[0]["SINV_SGST_Rate"].ToString();
// SINV_SGST_Amt.Text =  dt.Rows[0]["SINV_SGST_Amt"].ToString();
// SINV_SGST_TaxableAmt.Text =  dt.Rows[0]["SINV_SGST_TaxableAmt"].ToString();
// SINV_IGST_ID.Text =  dt.Rows[0]["SINV_IGST_ID"].ToString();
// SINV_IGST_Rate.Text =  dt.Rows[0]["SINV_IGST_Rate"].ToString();
// SINV_IGST_Amt.Text =  dt.Rows[0]["SINV_IGST_Amt"].ToString();
// SINV_IGST_TaxableAmt.Text =  dt.Rows[0]["SINV_IGST_TaxableAmt"].ToString();
// SINV_CESS_ID.Text =  dt.Rows[0]["SINV_CESS_ID"].ToString();
// SINV_CESS_Rate.Text =  dt.Rows[0]["SINV_CESS_Rate"].ToString();
// SINV_CESS_Amt.Text =  dt.Rows[0]["SINV_CESS_Amt"].ToString();
// SINV_CESS_TaxableAmt.Text =  dt.Rows[0]["SINV_CESS_TaxableAmt"].ToString();
// SINV_OtherTax_ID.Text =  dt.Rows[0]["SINV_OtherTax_ID"].ToString();
// SINV_OtherTax_Rate.Text =  dt.Rows[0]["SINV_OtherTax_Rate"].ToString();
// SINV_OtherTax_Amt.Text =  dt.Rows[0]["SINV_OtherTax_Amt"].ToString();
// SINV_OtherTax_TaxableAmt.Text =  dt.Rows[0]["SINV_OtherTax_TaxableAmt"].ToString();
// SINV_TotalTax.Text =  dt.Rows[0]["SINV_TotalTax"].ToString();
// SINV_GrossRateWithTax.Text =  dt.Rows[0]["SINV_GrossRateWithTax"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// SINV_ItemRemark_DTL.Text =  dt.Rows[0]["SINV_ItemRemark_DTL"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
