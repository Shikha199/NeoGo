using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal
{
    public class M_AT_Mst_CurrencyBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public M_AT_Mst_CurrencyBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "Currency_ID";
        private string _TableName = "M_AT_Mst_Currency";
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

        private byte _Currency_ID;
        private String _Currency;
        private String _Curr_FractionName;
        private String _Curr_Name;

        private String _Currency_Desc;
        private String _MDBSC_RowStatus;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;

        public byte Currency_ID
        {
            get
            {
                return this._Currency_ID;
            }
            set
            {
                this._Currency_ID = value;
                _UpdateFieldName.Add("Currency_ID");
            }
        }

        public String Curr_FractionName
        {
            get
            {
                return this._Curr_FractionName;
            }
            set
            {
                this._Curr_FractionName = value;
                _UpdateFieldName.Add("Curr_FractionName");
            }
        }



        public String Curr_Name
        {
            get
            {
                return this._Curr_Name;
            }
            set
            {
                this._Curr_Name = value;
                _UpdateFieldName.Add("Curr_Name");
            }
        }







        public String Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                this._Currency = value;
                _UpdateFieldName.Add("Currency");
            }
        }
        public String Currency_Desc
        {
            get
            {
                return this._Currency_Desc;
            }
            set
            {
                this._Currency_Desc = value;
                _UpdateFieldName.Add("Currency_Desc");
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

        #endregion
        #region Genric Methods
        public string Insert_Update(M_AT_Mst_CurrencyBO sObject)
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
        public DataTable List(Int64 Currency_ID, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                if (Currency_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Mst_Currency" + strWhereClause;
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Mst_Currency  Where  Currency_ID=0" + Currency_ID;
                }
                return MaheshAF18.Application.MEF.DA_GetDataTable(strSqlString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        #endregion
    }
}

// ObjAT_Cur.Currency_ID=ObjAT_Cur.Currency_ID;
// ObjAT_Cur.Currency=ObjAT_Cur.Currency;
// ObjAT_Cur.Currency_Desc=ObjAT_Cur.Currency_Desc;
// ObjAT_Cur.MDBSC_RowStatus=ObjAT_Cur.MDBSC_RowStatus;
// ObjAT_Cur.MDBSC_RowCreatedByUser_ID=ObjAT_Cur.MDBSC_RowCreatedByUser_ID;
// ObjAT_Cur.MDBSC_RowCreatedByUserName=ObjAT_Cur.MDBSC_RowCreatedByUserName;
// ObjAT_Cur.MDBSC_RowCreatedOn_DT=ObjAT_Cur.MDBSC_RowCreatedOn_DT;
// ObjAT_Cur.MDBSC_RowLupdnByUser_ID=ObjAT_Cur.MDBSC_RowLupdnByUser_ID;
// ObjAT_Cur.MDBSC_RowLupdnUserName=ObjAT_Cur.MDBSC_RowLupdnUserName;
// ObjAT_Cur.MDBSC_RowLupdnOn_DT=ObjAT_Cur.MDBSC_RowLupdnOn_DT;



// Currency_ID.Text = "";
// Currency.Text = "";
// Currency_Desc.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";



// ObjAT_Cur.Currency_ID=Currency_ID.Text ;
// ObjAT_Cur.Currency=Currency.Text ;
// ObjAT_Cur.Currency_Desc=Currency_Desc.Text ;
// ObjAT_Cur.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_Cur.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_Cur.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_Cur.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_Cur.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_Cur.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_Cur.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;



// Currency_ID.Text =  dt.Rows[0]["Currency_ID"].ToString();
// Currency.Text =  dt.Rows[0]["Currency"].ToString();
// Currency_Desc.Text =  dt.Rows[0]["Currency_Desc"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();

