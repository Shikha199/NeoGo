using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal
{
    public class M_AT_Purchase_Inv_TaxDTLBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public M_AT_Purchase_Inv_TaxDTLBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "PINVTDTL_ID";
        private string _TableName = "M_AT_Purchase_Inv_TaxDTL";
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

        private Int64 _PINVTDTL_ID;
        private Int64 _Fk_PINVHDR_ID;
        private Int64 _TaxID;
        private Decimal _Tax_Rate;
        private Decimal _Eligible_Amt;
        private Decimal _TotalTaxAmt;

        public Int64 PINVTDTL_ID
        {
            get
            {
                return this._PINVTDTL_ID;
            }
            set
            {
                this._PINVTDTL_ID = value;
                _UpdateFieldName.Add("PINVTDTL_ID");
            }
        }
        public Int64 Fk_PINVHDR_ID
        {
            get
            {
                return this._Fk_PINVHDR_ID;
            }
            set
            {
                this._Fk_PINVHDR_ID = value;
                _UpdateFieldName.Add("Fk_PINVHDR_ID");
            }
        }
        public Int64 TaxID
        {
            get
            {
                return this._TaxID;
            }
            set
            {
                this._TaxID = value;
                _UpdateFieldName.Add("TaxID");
            }
        }
        public Decimal Tax_Rate
        {
            get
            {
                return this._Tax_Rate;
            }
            set
            {
                this._Tax_Rate = value;
                _UpdateFieldName.Add("Tax_Rate");
            }
        }
        public Decimal Eligible_Amt
        {
            get
            {
                return this._Eligible_Amt;
            }
            set
            {
                this._Eligible_Amt = value;
                _UpdateFieldName.Add("Eligible_Amt");
            }
        }
        public Decimal TotalTaxAmt
        {
            get
            {
                return this._TotalTaxAmt;
            }
            set
            {
                this._TotalTaxAmt = value;
                _UpdateFieldName.Add("TotalTaxAmt");
            }
        }

        #endregion
        #region Genric Methods
        public string Insert_Update(M_AT_Purchase_Inv_TaxDTLBO sObject)
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

// ObjAT_PINV_TDTL.PINVTDTL_ID=ObjAT_PINV_TDTL.PINVTDTL_ID;
// ObjAT_PINV_TDTL.Fk_PINVHDR_ID=ObjAT_PINV_TDTL.Fk_PINVHDR_ID;
// ObjAT_PINV_TDTL.TaxID=ObjAT_PINV_TDTL.TaxID;
// ObjAT_PINV_TDTL.Tax_Rate=ObjAT_PINV_TDTL.Tax_Rate;
// ObjAT_PINV_TDTL.Eligible_Amt=ObjAT_PINV_TDTL.Eligible_Amt;
// ObjAT_PINV_TDTL.TotalTaxAmt=ObjAT_PINV_TDTL.TotalTaxAmt;



// PINVTDTL_ID.Text = "";
// Fk_PINVHDR_ID.Text = "";
// TaxID.Text = "";
// Tax_Rate.Text = "";
// Eligible_Amt.Text = "";
// TotalTaxAmt.Text = "";



// ObjAT_PINV_TDTL.PINVTDTL_ID=PINVTDTL_ID.Text ;
// ObjAT_PINV_TDTL.Fk_PINVHDR_ID=Fk_PINVHDR_ID.Text ;
// ObjAT_PINV_TDTL.TaxID=TaxID.Text ;
// ObjAT_PINV_TDTL.Tax_Rate=Tax_Rate.Text ;
// ObjAT_PINV_TDTL.Eligible_Amt=Eligible_Amt.Text ;
// ObjAT_PINV_TDTL.TotalTaxAmt=TotalTaxAmt.Text ;



// PINVTDTL_ID.Text =  dt.Rows[0]["PINVTDTL_ID"].ToString();
// Fk_PINVHDR_ID.Text =  dt.Rows[0]["Fk_PINVHDR_ID"].ToString();
// TaxID.Text =  dt.Rows[0]["TaxID"].ToString();
// Tax_Rate.Text =  dt.Rows[0]["Tax_Rate"].ToString();
// Eligible_Amt.Text =  dt.Rows[0]["Eligible_Amt"].ToString();
// TotalTaxAmt.Text =  dt.Rows[0]["TotalTaxAmt"].ToString();

