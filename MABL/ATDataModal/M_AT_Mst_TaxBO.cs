using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal
{
    public class M_AT_Mst_TaxBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public M_AT_Mst_TaxBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "Tax_ID";
        private string _TableName = "M_AT_Mst_Tax";
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

        private Int32 _Tax_ID;
        private String _Tax;
        private Decimal _Tax_Rate;
        private String _TaxFor;
        private String _Tax_DisplayName;
        private String _Tax_Category;
        
        private String _Tax_Desc;
        private String _MDBSC_RowStatus;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;

        public Int32 Tax_ID
        {
            get
            {
                return this._Tax_ID;
            }
            set
            {
                this._Tax_ID = value;
                _UpdateFieldName.Add("Tax_ID");
            }
        }


        public String Tax_Category
        {
            get
            {
                return this._Tax_Category;
            }
            set
            {
                this._Tax_Category = value;
                _UpdateFieldName.Add("Tax_Category");
            }
        }


        public String Tax_DisplayName
        {
            get
            {
                return this._Tax_DisplayName;
            }
            set
            {
                this._Tax_DisplayName = value;
                _UpdateFieldName.Add("Tax_DisplayName");
            }
        }


        public String Tax
        {
            get
            {
                return this._Tax;
            }
            set
            {
                this._Tax = value;
                _UpdateFieldName.Add("Tax");
            }
        }
        public decimal Tax_Rate
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
        public String TaxFor
        {
            get
            {
                return this._TaxFor;
            }
            set
            {
                this._TaxFor = value;
                _UpdateFieldName.Add("TaxFor");
            }
        }
        public String Tax_Desc
        {
            get
            {
                return this._Tax_Desc;
            }
            set
            {
                this._Tax_Desc = value;
                _UpdateFieldName.Add("Tax_Desc");
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
        public string Insert_Update(M_AT_Mst_TaxBO sObject)
        {
            try
            {
                string strPkValue = "";
                strPkValue = ObjDataAcess.InsertUpdate(sObject);
                return ObjDataAcess.ReturnMessage + "|" + strPkValue;
            }
            catch
            {
                return "Failed To Save Data" + "|0";
            }
        }


        public DataTable List(Int64 Tax_ID, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                if (Tax_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_M_AT_Mst_Tax" + strWhereClause;
                }
                else
                {
                    strSqlString = "SELECT * FROM v_M_AT_Mst_Tax  Where  Tax_ID=0" + Tax_ID;
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

// ObjBOAT_Tax.Tax_ID=ObjBOAT_Tax.Tax_ID;
// ObjBOAT_Tax.Tax=ObjBOAT_Tax.Tax;
// ObjBOAT_Tax.Tax_Rate=ObjBOAT_Tax.Tax_Rate;
// ObjBOAT_Tax.TaxFor=ObjBOAT_Tax.TaxFor;
// ObjBOAT_Tax.TAx_Desc=ObjBOAT_Tax.TAx_Desc;
// ObjBOAT_Tax.MDBSC_RowStatus=ObjBOAT_Tax.MDBSC_RowStatus;
// ObjBOAT_Tax.MDBSC_RowCreatedByUser_ID=ObjBOAT_Tax.MDBSC_RowCreatedByUser_ID;
// ObjBOAT_Tax.MDBSC_RowCreatedByUserName=ObjBOAT_Tax.MDBSC_RowCreatedByUserName;
// ObjBOAT_Tax.MDBSC_RowCreatedOn_DT=ObjBOAT_Tax.MDBSC_RowCreatedOn_DT;
// ObjBOAT_Tax.MDBSC_RowLupdnByUser_ID=ObjBOAT_Tax.MDBSC_RowLupdnByUser_ID;
// ObjBOAT_Tax.MDBSC_RowLupdnUserName=ObjBOAT_Tax.MDBSC_RowLupdnUserName;
// ObjBOAT_Tax.MDBSC_RowLupdnOn_DT=ObjBOAT_Tax.MDBSC_RowLupdnOn_DT;



// Tax_ID.Text = "";
// Tax.Text = "";
// Tax_Rate.Text = "";
// TaxFor.Text = "";
// TAx_Desc.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";



// ObjBOAT_Tax.Tax_ID=Tax_ID.Text ;
// ObjBOAT_Tax.Tax=Tax.Text ;
// ObjBOAT_Tax.Tax_Rate=Tax_Rate.Text ;
// ObjBOAT_Tax.TaxFor=TaxFor.Text ;
// ObjBOAT_Tax.TAx_Desc=TAx_Desc.Text ;
// ObjBOAT_Tax.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjBOAT_Tax.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjBOAT_Tax.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjBOAT_Tax.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjBOAT_Tax.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjBOAT_Tax.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjBOAT_Tax.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;



// Tax_ID.Text =  dt.Rows[0]["Tax_ID"].ToString();
// Tax.Text =  dt.Rows[0]["Tax"].ToString();
// Tax_Rate.Text =  dt.Rows[0]["Tax_Rate"].ToString();
// TaxFor.Text =  dt.Rows[0]["TaxFor"].ToString();
// TAx_Desc.Text =  dt.Rows[0]["TAx_Desc"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
