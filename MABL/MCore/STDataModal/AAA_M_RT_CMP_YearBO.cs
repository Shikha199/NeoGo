using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.MCore.STDataModal
{
    public class AAA_M_RT_CMP_YearBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public AAA_M_RT_CMP_YearBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "M_RT_CMP_Year_ID";
        private string _TableName = "AAA_M_RT_CMP_Year";
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

        private byte _M_RT_CMP_Year_ID;
        private byte _FK_M_RT_CMP_ID;
        private byte _MDBSC_PreviousYear_ID;
        private byte _MDBSC_NextYear_ID;
        private String _MDBSC_Start_DT;
        private String _MDBSC_End_DT;
        private String _MDBSC_Year_Desc;
        private String _MDBSC_RowStatus;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;

        public byte M_RT_CMP_Year_ID
        {
            get
            {
                return this._M_RT_CMP_Year_ID;
            }
            set
            {
                this._M_RT_CMP_Year_ID = value;
                _UpdateFieldName.Add("M_RT_CMP_Year_ID");
            }
        }
        public byte FK_M_RT_CMP_ID
        {
            get
            {
                return this._FK_M_RT_CMP_ID;
            }
            set
            {
                this._FK_M_RT_CMP_ID = value;
                _UpdateFieldName.Add("FK_M_RT_CMP_ID");
            }
        }
        public byte MDBSC_PreviousYear_ID
        {
            get
            {
                return this._MDBSC_PreviousYear_ID;
            }
            set
            {
                this._MDBSC_PreviousYear_ID = value;
                _UpdateFieldName.Add("MDBSC_PreviousYear_ID");
            }
        }
        public byte MDBSC_NextYear_ID
        {
            get
            {
                return this._MDBSC_NextYear_ID;
            }
            set
            {
                this._MDBSC_NextYear_ID = value;
                _UpdateFieldName.Add("MDBSC_NextYear_ID");
            }
        }
        public String MDBSC_Start_DT
        {
            get
            {
                return this._MDBSC_Start_DT;
            }
            set
            {
                this._MDBSC_Start_DT = value;
                _UpdateFieldName.Add("MDBSC_Start_DT");
            }
        }
        public String MDBSC_End_DT
        {
            get
            {
                return this._MDBSC_End_DT;
            }
            set
            {
                this._MDBSC_End_DT = value;
                _UpdateFieldName.Add("MDBSC_End_DT");
            }
        }
        public String MDBSC_Year_Desc
        {
            get
            {
                return this._MDBSC_Year_Desc;
            }
            set
            {
                this._MDBSC_Year_Desc = value;
                _UpdateFieldName.Add("MDBSC_Year_Desc");
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
        public string Insert_Update(AAA_M_RT_CMP_YearBO sObject)
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


        public DataTable List(Int64 M_RT_CMP_Year_ID, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                if (M_RT_CMP_Year_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_AAA_M_RT_CMP_Year" + strWhereClause;
                }
                else
                {
                    strSqlString = "SELECT * FROM v_AAA_M_RT_CMP_Year  Where  M_RT_CMP_Year_ID=0" + M_RT_CMP_Year_ID;
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

// Obj_RT_Year.M_RT_CMP_Year_ID=Obj_RT_Year.M_RT_CMP_Year_ID;
// Obj_RT_Year.FK_M_RT_CMP_ID=Obj_RT_Year.FK_M_RT_CMP_ID;
// Obj_RT_Year.MDBSC_PreviousYear_ID=Obj_RT_Year.MDBSC_PreviousYear_ID;
// Obj_RT_Year.MDBSC_NextYear_ID=Obj_RT_Year.MDBSC_NextYear_ID;
// Obj_RT_Year.MDBSC_Start_DT=Obj_RT_Year.MDBSC_Start_DT;
// Obj_RT_Year.MDBSC_End_DT=Obj_RT_Year.MDBSC_End_DT;
// Obj_RT_Year.MDBSC_Year_Desc=Obj_RT_Year.MDBSC_Year_Desc;
// Obj_RT_Year.MDBSC_RowStatus=Obj_RT_Year.MDBSC_RowStatus;
// Obj_RT_Year.MDBSC_RowCreatedByUser_ID=Obj_RT_Year.MDBSC_RowCreatedByUser_ID;
// Obj_RT_Year.MDBSC_RowCreatedByUserName=Obj_RT_Year.MDBSC_RowCreatedByUserName;
// Obj_RT_Year.MDBSC_RowCreatedOn_DT=Obj_RT_Year.MDBSC_RowCreatedOn_DT;
// Obj_RT_Year.MDBSC_RowLupdnByUser_ID=Obj_RT_Year.MDBSC_RowLupdnByUser_ID;
// Obj_RT_Year.MDBSC_RowLupdnUserName=Obj_RT_Year.MDBSC_RowLupdnUserName;
// Obj_RT_Year.MDBSC_RowLupdnOn_DT=Obj_RT_Year.MDBSC_RowLupdnOn_DT;



// M_RT_CMP_Year_ID.Text = "";
// FK_M_RT_CMP_ID.Text = "";
// MDBSC_PreviousYear_ID.Text = "";
// MDBSC_NextYear_ID.Text = "";
// MDBSC_Start_DT.Text = "";
// MDBSC_End_DT.Text = "";
// MDBSC_Year_Desc.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";



// Obj_RT_Year.M_RT_CMP_Year_ID=M_RT_CMP_Year_ID.Text ;
// Obj_RT_Year.FK_M_RT_CMP_ID=FK_M_RT_CMP_ID.Text ;
// Obj_RT_Year.MDBSC_PreviousYear_ID=MDBSC_PreviousYear_ID.Text ;
// Obj_RT_Year.MDBSC_NextYear_ID=MDBSC_NextYear_ID.Text ;
// Obj_RT_Year.MDBSC_Start_DT=MDBSC_Start_DT.Text ;
// Obj_RT_Year.MDBSC_End_DT=MDBSC_End_DT.Text ;
// Obj_RT_Year.MDBSC_Year_Desc=MDBSC_Year_Desc.Text ;
// Obj_RT_Year.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// Obj_RT_Year.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// Obj_RT_Year.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// Obj_RT_Year.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// Obj_RT_Year.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// Obj_RT_Year.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// Obj_RT_Year.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;



// M_RT_CMP_Year_ID.Text =  dt.Rows[0]["M_RT_CMP_Year_ID"].ToString();
// FK_M_RT_CMP_ID.Text =  dt.Rows[0]["FK_M_RT_CMP_ID"].ToString();
// MDBSC_PreviousYear_ID.Text =  dt.Rows[0]["MDBSC_PreviousYear_ID"].ToString();
// MDBSC_NextYear_ID.Text =  dt.Rows[0]["MDBSC_NextYear_ID"].ToString();
// MDBSC_Start_DT.Text =  dt.Rows[0]["MDBSC_Start_DT"].ToString();
// MDBSC_End_DT.Text =  dt.Rows[0]["MDBSC_End_DT"].ToString();
// MDBSC_Year_Desc.Text =  dt.Rows[0]["MDBSC_Year_Desc"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
