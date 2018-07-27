using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal
{
    public class M_AT_Acc_Payment_Customer_BDTLBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public M_AT_Acc_Payment_Customer_BDTLBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "ACPDTL_ID";
        private string _TableName = "M_AT_Acc_Payment_Customer_BDTL";
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

        private Int64 _ACPDTL_ID;
        private Int64 _Fk_ACPHDRID;
        private Int64 _Fk_InvoiceID;
        private Decimal _Inv_Adjusted_Amt;

        public Int64 ACPDTL_ID
        {
            get
            {
                return this._ACPDTL_ID;
            }
            set
            {
                this._ACPDTL_ID = value;
                _UpdateFieldName.Add("ACPDTL_ID");
            }
        }
        public Int64 Fk_ACPHDRID
        {
            get
            {
                return this._Fk_ACPHDRID;
            }
            set
            {
                this._Fk_ACPHDRID = value;
                _UpdateFieldName.Add("Fk_ACPHDRID");
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
        public string Insert_Update(M_AT_Acc_Payment_Customer_BDTLBO sObject)
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

// ObjAT_CPDTL.ACPDTL_ID=ObjAT_CPDTL.ACPDTL_ID;
// ObjAT_CPDTL.Fk_ACPHDRID=ObjAT_CPDTL.Fk_ACPHDRID;
// ObjAT_CPDTL.Fk_InvoiceID=ObjAT_CPDTL.Fk_InvoiceID;
// ObjAT_CPDTL.Inv_Adjusted_Amt=ObjAT_CPDTL.Inv_Adjusted_Amt;



// ACPDTL_ID.Text = "";
// Fk_ACPHDRID.Text = "";
// Fk_InvoiceID.Text = "";
// Inv_Adjusted_Amt.Text = "";



// ObjAT_CPDTL.ACPDTL_ID=ACPDTL_ID.Text ;
// ObjAT_CPDTL.Fk_ACPHDRID=Fk_ACPHDRID.Text ;
// ObjAT_CPDTL.Fk_InvoiceID=Fk_InvoiceID.Text ;
// ObjAT_CPDTL.Inv_Adjusted_Amt=Inv_Adjusted_Amt.Text ;



// ACPDTL_ID.Text =  dt.Rows[0]["ACPDTL_ID"].ToString();
// Fk_ACPHDRID.Text =  dt.Rows[0]["Fk_ACPHDRID"].ToString();
// Fk_InvoiceID.Text =  dt.Rows[0]["Fk_InvoiceID"].ToString();
// Inv_Adjusted_Amt.Text =  dt.Rows[0]["Inv_Adjusted_Amt"].ToString();
