using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.MCore.STDataModal
{
    public class AAA_M_RT_App_ModuleBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public AAA_M_RT_App_ModuleBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "M_RT_AM_ID";
        private string _TableName = "AAA_M_RT_App_Module";
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

        private byte _M_RT_AM_ID;
        private String _MDBSC_App_Module_For;
        private String _MDBSC_App_ModuleName;
        private String _MDBSC_App_IsSystem;
        private String _MDBSC_App_ModuleDesc;
        private String _MDBSC_App_IconUrl;
        private String _MDBSC_App_ModuleDashboardUrl;
        private String _MDBSC_RowStatus;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;

        public byte M_RT_AM_ID
        {
            get
            {
                return this._M_RT_AM_ID;
            }
            set
            {
                this._M_RT_AM_ID = value;
                _UpdateFieldName.Add("M_RT_AM_ID");
            }
        }
        public String MDBSC_App_Module_For
        {
            get
            {
                return this._MDBSC_App_Module_For;
            }
            set
            {
                this._MDBSC_App_Module_For = value;
                _UpdateFieldName.Add("MDBSC_App_Module_For");
            }
        }
        public String MDBSC_App_ModuleName
        {
            get
            {
                return this._MDBSC_App_ModuleName;
            }
            set
            {
                this._MDBSC_App_ModuleName = value;
                _UpdateFieldName.Add("MDBSC_App_ModuleName");
            }
        }
        public String MDBSC_App_IsSystem
        {
            get
            {
                return this._MDBSC_App_IsSystem;
            }
            set
            {
                this._MDBSC_App_IsSystem = value;
                _UpdateFieldName.Add("MDBSC_App_IsSystem");
            }
        }
        public String MDBSC_App_ModuleDesc
        {
            get
            {
                return this._MDBSC_App_ModuleDesc;
            }
            set
            {
                this._MDBSC_App_ModuleDesc = value;
                _UpdateFieldName.Add("MDBSC_App_ModuleDesc");
            }
        }
        public String MDBSC_App_IconUrl
        {
            get
            {
                return this._MDBSC_App_IconUrl;
            }
            set
            {
                this._MDBSC_App_IconUrl = value;
                _UpdateFieldName.Add("MDBSC_App_IconUrl");
            }
        }
        public String MDBSC_App_ModuleDashboardUrl
        {
            get
            {
                return this._MDBSC_App_ModuleDashboardUrl;
            }
            set
            {
                this._MDBSC_App_ModuleDashboardUrl = value;
                _UpdateFieldName.Add("MDBSC_App_ModuleDashboardUrl");
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
        public string Insert_Update(AAA_M_RT_App_ModuleBO sObject)
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


        public DataTable List(Int64 M_RT_AM_ID, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                if (M_RT_AM_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_AAA_M_RT_App_Module" + strWhereClause;
                }
                else
                {
                    strSqlString = "SELECT * FROM v_AAA_M_RT_App_Module  Where  M_RT_AM_ID=0" + M_RT_AM_ID;
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

// Obj_RT_AppModule.M_RT_AM_ID=Obj_RT_AppModule.M_RT_AM_ID;
// Obj_RT_AppModule.MDBSC_App_Module_For=Obj_RT_AppModule.MDBSC_App_Module_For;
// Obj_RT_AppModule.MDBSC_App_ModuleName=Obj_RT_AppModule.MDBSC_App_ModuleName;
// Obj_RT_AppModule.MDBSC_App_IsSystem=Obj_RT_AppModule.MDBSC_App_IsSystem;
// Obj_RT_AppModule.MDBSC_App_ModuleDesc=Obj_RT_AppModule.MDBSC_App_ModuleDesc;
// Obj_RT_AppModule.MDBSC_App_IconUrl=Obj_RT_AppModule.MDBSC_App_IconUrl;
// Obj_RT_AppModule.MDBSC_App_ModuleDashboardUrl=Obj_RT_AppModule.MDBSC_App_ModuleDashboardUrl;
// Obj_RT_AppModule.MDBSC_RowStatus=Obj_RT_AppModule.MDBSC_RowStatus;
// Obj_RT_AppModule.MDBSC_RowCreatedByUser_ID=Obj_RT_AppModule.MDBSC_RowCreatedByUser_ID;
// Obj_RT_AppModule.MDBSC_RowCreatedByUserName=Obj_RT_AppModule.MDBSC_RowCreatedByUserName;
// Obj_RT_AppModule.MDBSC_RowCreatedOn_DT=Obj_RT_AppModule.MDBSC_RowCreatedOn_DT;
// Obj_RT_AppModule.MDBSC_RowLupdnByUser_ID=Obj_RT_AppModule.MDBSC_RowLupdnByUser_ID;
// Obj_RT_AppModule.MDBSC_RowLupdnUserName=Obj_RT_AppModule.MDBSC_RowLupdnUserName;
// Obj_RT_AppModule.MDBSC_RowLupdnOn_DT=Obj_RT_AppModule.MDBSC_RowLupdnOn_DT;



// M_RT_AM_ID.Text = "";
// MDBSC_App_Module_For.Text = "";
// MDBSC_App_ModuleName.Text = "";
// MDBSC_App_IsSystem.Text = "";
// MDBSC_App_ModuleDesc.Text = "";
// MDBSC_App_IconUrl.Text = "";
// MDBSC_App_ModuleDashboardUrl.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";



// Obj_RT_AppModule.M_RT_AM_ID=M_RT_AM_ID.Text ;
// Obj_RT_AppModule.MDBSC_App_Module_For=MDBSC_App_Module_For.Text ;
// Obj_RT_AppModule.MDBSC_App_ModuleName=MDBSC_App_ModuleName.Text ;
// Obj_RT_AppModule.MDBSC_App_IsSystem=MDBSC_App_IsSystem.Text ;
// Obj_RT_AppModule.MDBSC_App_ModuleDesc=MDBSC_App_ModuleDesc.Text ;
// Obj_RT_AppModule.MDBSC_App_IconUrl=MDBSC_App_IconUrl.Text ;
// Obj_RT_AppModule.MDBSC_App_ModuleDashboardUrl=MDBSC_App_ModuleDashboardUrl.Text ;
// Obj_RT_AppModule.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// Obj_RT_AppModule.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// Obj_RT_AppModule.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// Obj_RT_AppModule.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// Obj_RT_AppModule.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// Obj_RT_AppModule.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// Obj_RT_AppModule.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;



// M_RT_AM_ID.Text =  dt.Rows[0]["M_RT_AM_ID"].ToString();
// MDBSC_App_Module_For.Text =  dt.Rows[0]["MDBSC_App_Module_For"].ToString();
// MDBSC_App_ModuleName.Text =  dt.Rows[0]["MDBSC_App_ModuleName"].ToString();
// MDBSC_App_IsSystem.Text =  dt.Rows[0]["MDBSC_App_IsSystem"].ToString();
// MDBSC_App_ModuleDesc.Text =  dt.Rows[0]["MDBSC_App_ModuleDesc"].ToString();
// MDBSC_App_IconUrl.Text =  dt.Rows[0]["MDBSC_App_IconUrl"].ToString();
// MDBSC_App_ModuleDashboardUrl.Text =  dt.Rows[0]["MDBSC_App_ModuleDashboardUrl"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
