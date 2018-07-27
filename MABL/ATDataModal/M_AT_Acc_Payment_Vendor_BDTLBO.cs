using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal
{
    public class M_AT_Acc_Payment_Vendor_BDTLBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public M_AT_Acc_Payment_Vendor_BDTLBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "AVPDTL_ID";
        private string _TableName = "M_AT_Acc_Payment_Vendor_BDTL";
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

        private Int64 _AVPDTL_ID;
        private Int64 _Fk_AVPHDRID;
        private Int64 _Fk_InvoiceID;
        private Decimal _Inv_Adjusted_Amt;

        public Int64 AVPDTL_ID
        {
            get
            {
                return this._AVPDTL_ID;
            }
            set
            {
                this._AVPDTL_ID = value;
                _UpdateFieldName.Add("AVPDTL_ID");
            }
        }
        public Int64 Fk_AVPHDRID
        {
            get
            {
                return this._Fk_AVPHDRID;
            }
            set
            {
                this._Fk_AVPHDRID = value;
                _UpdateFieldName.Add("Fk_AVPHDRID");
            }
        }
        public Int64 Fk_InvoiceID
        {
            get
            {
                return this._Fk_InvoiceID;
            }
            set
            {
                this._Fk_InvoiceID = value;
                _UpdateFieldName.Add("Fk_InvoiceID");
            }
        }
        public Decimal Inv_Adjusted_Amt
        {
            get
            {
                return this._Inv_Adjusted_Amt;
            }
            set
            {
                this._Inv_Adjusted_Amt = value;
                _UpdateFieldName.Add("Inv_Adjusted_Amt");
            }
        }

        #endregion
        #region Genric Methods
        public string Insert_Update(M_AT_Acc_Payment_Vendor_BDTLBO sObject)
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

// ObjAT_VPDTL.AVPDTL_ID=ObjAT_VPDTL.AVPDTL_ID;
// ObjAT_VPDTL.Fk_AVPHDRID=ObjAT_VPDTL.Fk_AVPHDRID;
// ObjAT_VPDTL.Fk_InvoiceID=ObjAT_VPDTL.Fk_InvoiceID;
// ObjAT_VPDTL.Inv_Adjusted_Amt=ObjAT_VPDTL.Inv_Adjusted_Amt;



// AVPDTL_ID.Text = "";
// Fk_AVPHDRID.Text = "";
// Fk_InvoiceID.Text = "";
// Inv_Adjusted_Amt.Text = "";



// ObjAT_VPDTL.AVPDTL_ID=AVPDTL_ID.Text ;
// ObjAT_VPDTL.Fk_AVPHDRID=Fk_AVPHDRID.Text ;
// ObjAT_VPDTL.Fk_InvoiceID=Fk_InvoiceID.Text ;
// ObjAT_VPDTL.Inv_Adjusted_Amt=Inv_Adjusted_Amt.Text ;



// AVPDTL_ID.Text =  dt.Rows[0]["AVPDTL_ID"].ToString();
// Fk_AVPHDRID.Text =  dt.Rows[0]["Fk_AVPHDRID"].ToString();
// Fk_InvoiceID.Text =  dt.Rows[0]["Fk_InvoiceID"].ToString();
// Inv_Adjusted_Amt.Text =  dt.Rows[0]["Inv_Adjusted_Amt"].ToString();
