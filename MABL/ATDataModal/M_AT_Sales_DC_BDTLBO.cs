using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal
{
    public class M_AT_Sales_DC_BDTLBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public M_AT_Sales_DC_BDTLBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "DCDTL_ID";
        private string _TableName = "M_AT_Sales_DC_BDTL";
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

        private Int64 _DCDTL_ID;
        private Int64 _Fk_DCHDR_ID;
        private Int64 _Fk_MItem_ID;
        private String _DC_HSNCode;
        private Decimal _DC_QTY;
        private Decimal _DC_QTY_Tolerance_Rate;
        private Decimal _DC_QTY_Tolerance;
        private Decimal _DC_Final_Qty;
        private Decimal _DC_GRN_Qty;
        private Decimal _DC_GRN_Rejected_Qty;
        private Decimal _DC_Blance_Qty;
        private String _Qtn_Selected;
        private Decimal _DC_BasicRate;
        private Decimal _DC_NetRate;
        private Decimal _DC_BasicAmt;
        private Decimal _DC_DiscountRate;
        private Decimal _DC_DiscountAmt;
        private Decimal _DC_NetTaxableAmt;
        private Int16 _DC_GST_TaxRate_ID;
        private Decimal _DC_GST_TaxRate;
        private Int16 _DC_CGST_ID;
        private Decimal _DC_CGST_Rate;
        private Decimal _DC_CGST_Amt;
        private Decimal _DC_CGST_TaxableAmt;
        private Int16 _DC_SGST_ID;
        private Decimal _DC_SGST_Rate;
        private Decimal _DC_SGST_Amt;
        private Decimal _DC_SGST_TaxableAmt;
        private Int16 _DC_IGST_ID;
        private Decimal _DC_IGST_Rate;
        private Decimal _DC_IGST_Amt;
        private Decimal _DC_IGST_TaxableAmt;
        private Int16 _DC_CESS_ID;
        private Decimal _DC_CESS_Rate;
        private Decimal _DC_CESS_Amt;
        private Decimal _DC_CESS_TaxableAmt;
        private Int16 _DC_OtherTax_ID;
        private Decimal _DC_OtherTax_Rate;
        private Decimal _DC_OtherTax_Amt;
        private Decimal _DC_OtherTax_TaxableAmt;
        private Decimal _DC_TotalTax;
        private Decimal _DC_GrossRateWithTax;
        private String _MDBSC_RowStatus;
        private String _DC_ItemRemark_DTL;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;

        public Int64 DCDTL_ID
        {
            get
            {
                return this._DCDTL_ID;
            }
            set
            {
                this._DCDTL_ID = value;
                _UpdateFieldName.Add("DCDTL_ID");
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
        public String DC_HSNCode
        {
            get
            {
                return this._DC_HSNCode;
            }
            set
            {
                this._DC_HSNCode = value;
                _UpdateFieldName.Add("DC_HSNCode");
            }
        }
        public Decimal DC_QTY
        {
            get
            {
                return this._DC_QTY;
            }
            set
            {
                this._DC_QTY = value;
                _UpdateFieldName.Add("DC_QTY");
            }
        }
        public Decimal DC_QTY_Tolerance_Rate
        {
            get
            {
                return this._DC_QTY_Tolerance_Rate;
            }
            set
            {
                this._DC_QTY_Tolerance_Rate = value;
                _UpdateFieldName.Add("DC_QTY_Tolerance_Rate");
            }
        }
        public Decimal DC_QTY_Tolerance
        {
            get
            {
                return this._DC_QTY_Tolerance;
            }
            set
            {
                this._DC_QTY_Tolerance = value;
                _UpdateFieldName.Add("DC_QTY_Tolerance");
            }
        }
        public Decimal DC_Final_Qty
        {
            get
            {
                return this._DC_Final_Qty;
            }
            set
            {
                this._DC_Final_Qty = value;
                _UpdateFieldName.Add("DC_Final_Qty");
            }
        }
        public Decimal DC_GRN_Qty
        {
            get
            {
                return this._DC_GRN_Qty;
            }
            set
            {
                this._DC_GRN_Qty = value;
                _UpdateFieldName.Add("DC_GRN_Qty");
            }
        }
        public Decimal DC_GRN_Rejected_Qty
        {
            get
            {
                return this._DC_GRN_Rejected_Qty;
            }
            set
            {
                this._DC_GRN_Rejected_Qty = value;
                _UpdateFieldName.Add("DC_GRN_Rejected_Qty");
            }
        }
        public Decimal DC_Blance_Qty
        {
            get
            {
                return this._DC_Blance_Qty;
            }
            set
            {
                this._DC_Blance_Qty = value;
                _UpdateFieldName.Add("DC_Blance_Qty");
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
        public Decimal DC_BasicRate
        {
            get
            {
                return this._DC_BasicRate;
            }
            set
            {
                this._DC_BasicRate = value;
                _UpdateFieldName.Add("DC_BasicRate");
            }
        }
        public Decimal DC_NetRate
        {
            get
            {
                return this._DC_NetRate;
            }
            set
            {
                this._DC_NetRate = value;
                _UpdateFieldName.Add("DC_NetRate");
            }
        }
        public Decimal DC_BasicAmt
        {
            get
            {
                return this._DC_BasicAmt;
            }
            set
            {
                this._DC_BasicAmt = value;
                _UpdateFieldName.Add("DC_BasicAmt");
            }
        }
        public Decimal DC_DiscountRate
        {
            get
            {
                return this._DC_DiscountRate;
            }
            set
            {
                this._DC_DiscountRate = value;
                _UpdateFieldName.Add("DC_DiscountRate");
            }
        }
        public Decimal DC_DiscountAmt
        {
            get
            {
                return this._DC_DiscountAmt;
            }
            set
            {
                this._DC_DiscountAmt = value;
                _UpdateFieldName.Add("DC_DiscountAmt");
            }
        }
        public Decimal DC_NetTaxableAmt
        {
            get
            {
                return this._DC_NetTaxableAmt;
            }
            set
            {
                this._DC_NetTaxableAmt = value;
                _UpdateFieldName.Add("DC_NetTaxableAmt");
            }
        }
        public Int16 DC_GST_TaxRate_ID
        {
            get
            {
                return this._DC_GST_TaxRate_ID;
            }
            set
            {
                this._DC_GST_TaxRate_ID = value;
                _UpdateFieldName.Add("DC_GST_TaxRate_ID");
            }
        }
        public Decimal DC_GST_TaxRate
        {
            get
            {
                return this._DC_GST_TaxRate;
            }
            set
            {
                this._DC_GST_TaxRate = value;
                _UpdateFieldName.Add("DC_GST_TaxRate");
            }
        }
        public Int16 DC_CGST_ID
        {
            get
            {
                return this._DC_CGST_ID;
            }
            set
            {
                this._DC_CGST_ID = value;
                _UpdateFieldName.Add("DC_CGST_ID");
            }
        }
        public Decimal DC_CGST_Rate
        {
            get
            {
                return this._DC_CGST_Rate;
            }
            set
            {
                this._DC_CGST_Rate = value;
                _UpdateFieldName.Add("DC_CGST_Rate");
            }
        }
        public Decimal DC_CGST_Amt
        {
            get
            {
                return this._DC_CGST_Amt;
            }
            set
            {
                this._DC_CGST_Amt = value;
                _UpdateFieldName.Add("DC_CGST_Amt");
            }
        }
        public Decimal DC_CGST_TaxableAmt
        {
            get
            {
                return this._DC_CGST_TaxableAmt;
            }
            set
            {
                this._DC_CGST_TaxableAmt = value;
                _UpdateFieldName.Add("DC_CGST_TaxableAmt");
            }
        }
        public Int16 DC_SGST_ID
        {
            get
            {
                return this._DC_SGST_ID;
            }
            set
            {
                this._DC_SGST_ID = value;
                _UpdateFieldName.Add("DC_SGST_ID");
            }
        }
        public Decimal DC_SGST_Rate
        {
            get
            {
                return this._DC_SGST_Rate;
            }
            set
            {
                this._DC_SGST_Rate = value;
                _UpdateFieldName.Add("DC_SGST_Rate");
            }
        }
        public Decimal DC_SGST_Amt
        {
            get
            {
                return this._DC_SGST_Amt;
            }
            set
            {
                this._DC_SGST_Amt = value;
                _UpdateFieldName.Add("DC_SGST_Amt");
            }
        }
        public Decimal DC_SGST_TaxableAmt
        {
            get
            {
                return this._DC_SGST_TaxableAmt;
            }
            set
            {
                this._DC_SGST_TaxableAmt = value;
                _UpdateFieldName.Add("DC_SGST_TaxableAmt");
            }
        }
        public Int16 DC_IGST_ID
        {
            get
            {
                return this._DC_IGST_ID;
            }
            set
            {
                this._DC_IGST_ID = value;
                _UpdateFieldName.Add("DC_IGST_ID");
            }
        }
        public Decimal DC_IGST_Rate
        {
            get
            {
                return this._DC_IGST_Rate;
            }
            set
            {
                this._DC_IGST_Rate = value;
                _UpdateFieldName.Add("DC_IGST_Rate");
            }
        }
        public Decimal DC_IGST_Amt
        {
            get
            {
                return this._DC_IGST_Amt;
            }
            set
            {
                this._DC_IGST_Amt = value;
                _UpdateFieldName.Add("DC_IGST_Amt");
            }
        }
        public Decimal DC_IGST_TaxableAmt
        {
            get
            {
                return this._DC_IGST_TaxableAmt;
            }
            set
            {
                this._DC_IGST_TaxableAmt = value;
                _UpdateFieldName.Add("DC_IGST_TaxableAmt");
            }
        }
        public Int16 DC_CESS_ID
        {
            get
            {
                return this._DC_CESS_ID;
            }
            set
            {
                this._DC_CESS_ID = value;
                _UpdateFieldName.Add("DC_CESS_ID");
            }
        }
        public Decimal DC_CESS_Rate
        {
            get
            {
                return this._DC_CESS_Rate;
            }
            set
            {
                this._DC_CESS_Rate = value;
                _UpdateFieldName.Add("DC_CESS_Rate");
            }
        }
        public Decimal DC_CESS_Amt
        {
            get
            {
                return this._DC_CESS_Amt;
            }
            set
            {
                this._DC_CESS_Amt = value;
                _UpdateFieldName.Add("DC_CESS_Amt");
            }
        }
        public Decimal DC_CESS_TaxableAmt
        {
            get
            {
                return this._DC_CESS_TaxableAmt;
            }
            set
            {
                this._DC_CESS_TaxableAmt = value;
                _UpdateFieldName.Add("DC_CESS_TaxableAmt");
            }
        }
        public Int16 DC_OtherTax_ID
        {
            get
            {
                return this._DC_OtherTax_ID;
            }
            set
            {
                this._DC_OtherTax_ID = value;
                _UpdateFieldName.Add("DC_OtherTax_ID");
            }
        }
        public Decimal DC_OtherTax_Rate
        {
            get
            {
                return this._DC_OtherTax_Rate;
            }
            set
            {
                this._DC_OtherTax_Rate = value;
                _UpdateFieldName.Add("DC_OtherTax_Rate");
            }
        }
        public Decimal DC_OtherTax_Amt
        {
            get
            {
                return this._DC_OtherTax_Amt;
            }
            set
            {
                this._DC_OtherTax_Amt = value;
                _UpdateFieldName.Add("DC_OtherTax_Amt");
            }
        }
        public Decimal DC_OtherTax_TaxableAmt
        {
            get
            {
                return this._DC_OtherTax_TaxableAmt;
            }
            set
            {
                this._DC_OtherTax_TaxableAmt = value;
                _UpdateFieldName.Add("DC_OtherTax_TaxableAmt");
            }
        }
        public Decimal DC_TotalTax
        {
            get
            {
                return this._DC_TotalTax;
            }
            set
            {
                this._DC_TotalTax = value;
                _UpdateFieldName.Add("DC_TotalTax");
            }
        }
        public Decimal DC_GrossRateWithTax
        {
            get
            {
                return this._DC_GrossRateWithTax;
            }
            set
            {
                this._DC_GrossRateWithTax = value;
                _UpdateFieldName.Add("DC_GrossRateWithTax");
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
        public String DC_ItemRemark_DTL
        {
            get
            {
                return this._DC_ItemRemark_DTL;
            }
            set
            {
                this._DC_ItemRemark_DTL = value;
                _UpdateFieldName.Add("DC_ItemRemark_DTL");
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
        public string Insert_Update(M_AT_Sales_DC_BDTLBO sObject)
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

// ObjAT_DCDTL.DCDTL_ID=ObjAT_DCDTL.DCDTL_ID;
// ObjAT_DCDTL.Fk_DCHDR_ID=ObjAT_DCDTL.Fk_DCHDR_ID;
// ObjAT_DCDTL.Fk_MItem_ID=ObjAT_DCDTL.Fk_MItem_ID;
// ObjAT_DCDTL.DC_HSNCode=ObjAT_DCDTL.DC_HSNCode;
// ObjAT_DCDTL.DC_QTY=ObjAT_DCDTL.DC_QTY;
// ObjAT_DCDTL.DC_QTY_Tolerance_Rate=ObjAT_DCDTL.DC_QTY_Tolerance_Rate;
// ObjAT_DCDTL.DC_QTY_Tolerance=ObjAT_DCDTL.DC_QTY_Tolerance;
// ObjAT_DCDTL.DC_Final_Qty=ObjAT_DCDTL.DC_Final_Qty;
// ObjAT_DCDTL.DC_GRN_Qty=ObjAT_DCDTL.DC_GRN_Qty;
// ObjAT_DCDTL.DC_GRN_Rejected_Qty=ObjAT_DCDTL.DC_GRN_Rejected_Qty;
// ObjAT_DCDTL.DC_Blance_Qty=ObjAT_DCDTL.DC_Blance_Qty;
// ObjAT_DCDTL.Qtn_Selected=ObjAT_DCDTL.Qtn_Selected;
// ObjAT_DCDTL.DC_BasicRate=ObjAT_DCDTL.DC_BasicRate;
// ObjAT_DCDTL.DC_NetRate=ObjAT_DCDTL.DC_NetRate;
// ObjAT_DCDTL.DC_BasicAmt=ObjAT_DCDTL.DC_BasicAmt;
// ObjAT_DCDTL.DC_DiscountRate=ObjAT_DCDTL.DC_DiscountRate;
// ObjAT_DCDTL.DC_DiscountAmt=ObjAT_DCDTL.DC_DiscountAmt;
// ObjAT_DCDTL.DC_NetTaxableAmt=ObjAT_DCDTL.DC_NetTaxableAmt;
// ObjAT_DCDTL.DC_GST_TaxRate_ID=ObjAT_DCDTL.DC_GST_TaxRate_ID;
// ObjAT_DCDTL.DC_GST_TaxRate=ObjAT_DCDTL.DC_GST_TaxRate;
// ObjAT_DCDTL.DC_CGST_ID=ObjAT_DCDTL.DC_CGST_ID;
// ObjAT_DCDTL.DC_CGST_Rate=ObjAT_DCDTL.DC_CGST_Rate;
// ObjAT_DCDTL.DC_CGST_Amt=ObjAT_DCDTL.DC_CGST_Amt;
// ObjAT_DCDTL.DC_CGST_TaxableAmt=ObjAT_DCDTL.DC_CGST_TaxableAmt;
// ObjAT_DCDTL.DC_SGST_ID=ObjAT_DCDTL.DC_SGST_ID;
// ObjAT_DCDTL.DC_SGST_Rate=ObjAT_DCDTL.DC_SGST_Rate;
// ObjAT_DCDTL.DC_SGST_Amt=ObjAT_DCDTL.DC_SGST_Amt;
// ObjAT_DCDTL.DC_SGST_TaxableAmt=ObjAT_DCDTL.DC_SGST_TaxableAmt;
// ObjAT_DCDTL.DC_IGST_ID=ObjAT_DCDTL.DC_IGST_ID;
// ObjAT_DCDTL.DC_IGST_Rate=ObjAT_DCDTL.DC_IGST_Rate;
// ObjAT_DCDTL.DC_IGST_Amt=ObjAT_DCDTL.DC_IGST_Amt;
// ObjAT_DCDTL.DC_IGST_TaxableAmt=ObjAT_DCDTL.DC_IGST_TaxableAmt;
// ObjAT_DCDTL.DC_CESS_ID=ObjAT_DCDTL.DC_CESS_ID;
// ObjAT_DCDTL.DC_CESS_Rate=ObjAT_DCDTL.DC_CESS_Rate;
// ObjAT_DCDTL.DC_CESS_Amt=ObjAT_DCDTL.DC_CESS_Amt;
// ObjAT_DCDTL.DC_CESS_TaxableAmt=ObjAT_DCDTL.DC_CESS_TaxableAmt;
// ObjAT_DCDTL.DC_OtherTax_ID=ObjAT_DCDTL.DC_OtherTax_ID;
// ObjAT_DCDTL.DC_OtherTax_Rate=ObjAT_DCDTL.DC_OtherTax_Rate;
// ObjAT_DCDTL.DC_OtherTax_Amt=ObjAT_DCDTL.DC_OtherTax_Amt;
// ObjAT_DCDTL.DC_OtherTax_TaxableAmt=ObjAT_DCDTL.DC_OtherTax_TaxableAmt;
// ObjAT_DCDTL.DC_TotalTax=ObjAT_DCDTL.DC_TotalTax;
// ObjAT_DCDTL.DC_GrossRateWithTax=ObjAT_DCDTL.DC_GrossRateWithTax;
// ObjAT_DCDTL.MDBSC_RowStatus=ObjAT_DCDTL.MDBSC_RowStatus;
// ObjAT_DCDTL.DC_ItemRemark_DTL=ObjAT_DCDTL.DC_ItemRemark_DTL;
// ObjAT_DCDTL.MDBSC_RowCreatedByUser_ID=ObjAT_DCDTL.MDBSC_RowCreatedByUser_ID;
// ObjAT_DCDTL.MDBSC_RowCreatedByUserName=ObjAT_DCDTL.MDBSC_RowCreatedByUserName;
// ObjAT_DCDTL.MDBSC_RowCreatedOn_DT=ObjAT_DCDTL.MDBSC_RowCreatedOn_DT;
// ObjAT_DCDTL.MDBSC_RowLupdnByUser_ID=ObjAT_DCDTL.MDBSC_RowLupdnByUser_ID;
// ObjAT_DCDTL.MDBSC_RowLupdnUserName=ObjAT_DCDTL.MDBSC_RowLupdnUserName;
// ObjAT_DCDTL.MDBSC_RowLupdnOn_DT=ObjAT_DCDTL.MDBSC_RowLupdnOn_DT;



// DCDTL_ID.Text = "";
// Fk_DCHDR_ID.Text = "";
// Fk_MItem_ID.Text = "";
// DC_HSNCode.Text = "";
// DC_QTY.Text = "";
// DC_QTY_Tolerance_Rate.Text = "";
// DC_QTY_Tolerance.Text = "";
// DC_Final_Qty.Text = "";
// DC_GRN_Qty.Text = "";
// DC_GRN_Rejected_Qty.Text = "";
// DC_Blance_Qty.Text = "";
// Qtn_Selected.Text = "";
// DC_BasicRate.Text = "";
// DC_NetRate.Text = "";
// DC_BasicAmt.Text = "";
// DC_DiscountRate.Text = "";
// DC_DiscountAmt.Text = "";
// DC_NetTaxableAmt.Text = "";
// DC_GST_TaxRate_ID.Text = "";
// DC_GST_TaxRate.Text = "";
// DC_CGST_ID.Text = "";
// DC_CGST_Rate.Text = "";
// DC_CGST_Amt.Text = "";
// DC_CGST_TaxableAmt.Text = "";
// DC_SGST_ID.Text = "";
// DC_SGST_Rate.Text = "";
// DC_SGST_Amt.Text = "";
// DC_SGST_TaxableAmt.Text = "";
// DC_IGST_ID.Text = "";
// DC_IGST_Rate.Text = "";
// DC_IGST_Amt.Text = "";
// DC_IGST_TaxableAmt.Text = "";
// DC_CESS_ID.Text = "";
// DC_CESS_Rate.Text = "";
// DC_CESS_Amt.Text = "";
// DC_CESS_TaxableAmt.Text = "";
// DC_OtherTax_ID.Text = "";
// DC_OtherTax_Rate.Text = "";
// DC_OtherTax_Amt.Text = "";
// DC_OtherTax_TaxableAmt.Text = "";
// DC_TotalTax.Text = "";
// DC_GrossRateWithTax.Text = "";
// MDBSC_RowStatus.Text = "";
// DC_ItemRemark_DTL.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";



// ObjAT_DCDTL.DCDTL_ID=DCDTL_ID.Text ;
// ObjAT_DCDTL.Fk_DCHDR_ID=Fk_DCHDR_ID.Text ;
// ObjAT_DCDTL.Fk_MItem_ID=Fk_MItem_ID.Text ;
// ObjAT_DCDTL.DC_HSNCode=DC_HSNCode.Text ;
// ObjAT_DCDTL.DC_QTY=DC_QTY.Text ;
// ObjAT_DCDTL.DC_QTY_Tolerance_Rate=DC_QTY_Tolerance_Rate.Text ;
// ObjAT_DCDTL.DC_QTY_Tolerance=DC_QTY_Tolerance.Text ;
// ObjAT_DCDTL.DC_Final_Qty=DC_Final_Qty.Text ;
// ObjAT_DCDTL.DC_GRN_Qty=DC_GRN_Qty.Text ;
// ObjAT_DCDTL.DC_GRN_Rejected_Qty=DC_GRN_Rejected_Qty.Text ;
// ObjAT_DCDTL.DC_Blance_Qty=DC_Blance_Qty.Text ;
// ObjAT_DCDTL.Qtn_Selected=Qtn_Selected.Text ;
// ObjAT_DCDTL.DC_BasicRate=DC_BasicRate.Text ;
// ObjAT_DCDTL.DC_NetRate=DC_NetRate.Text ;
// ObjAT_DCDTL.DC_BasicAmt=DC_BasicAmt.Text ;
// ObjAT_DCDTL.DC_DiscountRate=DC_DiscountRate.Text ;
// ObjAT_DCDTL.DC_DiscountAmt=DC_DiscountAmt.Text ;
// ObjAT_DCDTL.DC_NetTaxableAmt=DC_NetTaxableAmt.Text ;
// ObjAT_DCDTL.DC_GST_TaxRate_ID=DC_GST_TaxRate_ID.Text ;
// ObjAT_DCDTL.DC_GST_TaxRate=DC_GST_TaxRate.Text ;
// ObjAT_DCDTL.DC_CGST_ID=DC_CGST_ID.Text ;
// ObjAT_DCDTL.DC_CGST_Rate=DC_CGST_Rate.Text ;
// ObjAT_DCDTL.DC_CGST_Amt=DC_CGST_Amt.Text ;
// ObjAT_DCDTL.DC_CGST_TaxableAmt=DC_CGST_TaxableAmt.Text ;
// ObjAT_DCDTL.DC_SGST_ID=DC_SGST_ID.Text ;
// ObjAT_DCDTL.DC_SGST_Rate=DC_SGST_Rate.Text ;
// ObjAT_DCDTL.DC_SGST_Amt=DC_SGST_Amt.Text ;
// ObjAT_DCDTL.DC_SGST_TaxableAmt=DC_SGST_TaxableAmt.Text ;
// ObjAT_DCDTL.DC_IGST_ID=DC_IGST_ID.Text ;
// ObjAT_DCDTL.DC_IGST_Rate=DC_IGST_Rate.Text ;
// ObjAT_DCDTL.DC_IGST_Amt=DC_IGST_Amt.Text ;
// ObjAT_DCDTL.DC_IGST_TaxableAmt=DC_IGST_TaxableAmt.Text ;
// ObjAT_DCDTL.DC_CESS_ID=DC_CESS_ID.Text ;
// ObjAT_DCDTL.DC_CESS_Rate=DC_CESS_Rate.Text ;
// ObjAT_DCDTL.DC_CESS_Amt=DC_CESS_Amt.Text ;
// ObjAT_DCDTL.DC_CESS_TaxableAmt=DC_CESS_TaxableAmt.Text ;
// ObjAT_DCDTL.DC_OtherTax_ID=DC_OtherTax_ID.Text ;
// ObjAT_DCDTL.DC_OtherTax_Rate=DC_OtherTax_Rate.Text ;
// ObjAT_DCDTL.DC_OtherTax_Amt=DC_OtherTax_Amt.Text ;
// ObjAT_DCDTL.DC_OtherTax_TaxableAmt=DC_OtherTax_TaxableAmt.Text ;
// ObjAT_DCDTL.DC_TotalTax=DC_TotalTax.Text ;
// ObjAT_DCDTL.DC_GrossRateWithTax=DC_GrossRateWithTax.Text ;
// ObjAT_DCDTL.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_DCDTL.DC_ItemRemark_DTL=DC_ItemRemark_DTL.Text ;
// ObjAT_DCDTL.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_DCDTL.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_DCDTL.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_DCDTL.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_DCDTL.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_DCDTL.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;



// DCDTL_ID.Text =  dt.Rows[0]["DCDTL_ID"].ToString();
// Fk_DCHDR_ID.Text =  dt.Rows[0]["Fk_DCHDR_ID"].ToString();
// Fk_MItem_ID.Text =  dt.Rows[0]["Fk_MItem_ID"].ToString();
// DC_HSNCode.Text =  dt.Rows[0]["DC_HSNCode"].ToString();
// DC_QTY.Text =  dt.Rows[0]["DC_QTY"].ToString();
// DC_QTY_Tolerance_Rate.Text =  dt.Rows[0]["DC_QTY_Tolerance_Rate"].ToString();
// DC_QTY_Tolerance.Text =  dt.Rows[0]["DC_QTY_Tolerance"].ToString();
// DC_Final_Qty.Text =  dt.Rows[0]["DC_Final_Qty"].ToString();
// DC_GRN_Qty.Text =  dt.Rows[0]["DC_GRN_Qty"].ToString();
// DC_GRN_Rejected_Qty.Text =  dt.Rows[0]["DC_GRN_Rejected_Qty"].ToString();
// DC_Blance_Qty.Text =  dt.Rows[0]["DC_Blance_Qty"].ToString();
// Qtn_Selected.Text =  dt.Rows[0]["Qtn_Selected"].ToString();
// DC_BasicRate.Text =  dt.Rows[0]["DC_BasicRate"].ToString();
// DC_NetRate.Text =  dt.Rows[0]["DC_NetRate"].ToString();
// DC_BasicAmt.Text =  dt.Rows[0]["DC_BasicAmt"].ToString();
// DC_DiscountRate.Text =  dt.Rows[0]["DC_DiscountRate"].ToString();
// DC_DiscountAmt.Text =  dt.Rows[0]["DC_DiscountAmt"].ToString();
// DC_NetTaxableAmt.Text =  dt.Rows[0]["DC_NetTaxableAmt"].ToString();
// DC_GST_TaxRate_ID.Text =  dt.Rows[0]["DC_GST_TaxRate_ID"].ToString();
// DC_GST_TaxRate.Text =  dt.Rows[0]["DC_GST_TaxRate"].ToString();
// DC_CGST_ID.Text =  dt.Rows[0]["DC_CGST_ID"].ToString();
// DC_CGST_Rate.Text =  dt.Rows[0]["DC_CGST_Rate"].ToString();
// DC_CGST_Amt.Text =  dt.Rows[0]["DC_CGST_Amt"].ToString();
// DC_CGST_TaxableAmt.Text =  dt.Rows[0]["DC_CGST_TaxableAmt"].ToString();
// DC_SGST_ID.Text =  dt.Rows[0]["DC_SGST_ID"].ToString();
// DC_SGST_Rate.Text =  dt.Rows[0]["DC_SGST_Rate"].ToString();
// DC_SGST_Amt.Text =  dt.Rows[0]["DC_SGST_Amt"].ToString();
// DC_SGST_TaxableAmt.Text =  dt.Rows[0]["DC_SGST_TaxableAmt"].ToString();
// DC_IGST_ID.Text =  dt.Rows[0]["DC_IGST_ID"].ToString();
// DC_IGST_Rate.Text =  dt.Rows[0]["DC_IGST_Rate"].ToString();
// DC_IGST_Amt.Text =  dt.Rows[0]["DC_IGST_Amt"].ToString();
// DC_IGST_TaxableAmt.Text =  dt.Rows[0]["DC_IGST_TaxableAmt"].ToString();
// DC_CESS_ID.Text =  dt.Rows[0]["DC_CESS_ID"].ToString();
// DC_CESS_Rate.Text =  dt.Rows[0]["DC_CESS_Rate"].ToString();
// DC_CESS_Amt.Text =  dt.Rows[0]["DC_CESS_Amt"].ToString();
// DC_CESS_TaxableAmt.Text =  dt.Rows[0]["DC_CESS_TaxableAmt"].ToString();
// DC_OtherTax_ID.Text =  dt.Rows[0]["DC_OtherTax_ID"].ToString();
// DC_OtherTax_Rate.Text =  dt.Rows[0]["DC_OtherTax_Rate"].ToString();
// DC_OtherTax_Amt.Text =  dt.Rows[0]["DC_OtherTax_Amt"].ToString();
// DC_OtherTax_TaxableAmt.Text =  dt.Rows[0]["DC_OtherTax_TaxableAmt"].ToString();
// DC_TotalTax.Text =  dt.Rows[0]["DC_TotalTax"].ToString();
// DC_GrossRateWithTax.Text =  dt.Rows[0]["DC_GrossRateWithTax"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// DC_ItemRemark_DTL.Text =  dt.Rows[0]["DC_ItemRemark_DTL"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
