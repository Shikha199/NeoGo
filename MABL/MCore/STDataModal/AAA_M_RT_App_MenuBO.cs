using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.MCore.STDataModal
{
    public class AAA_M_RT_App_MenuBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public AAA_M_RT_App_MenuBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "M_RT_AppMenu_ID";
        private string _TableName = "AAA_M_RT_App_Menu";
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

        private Int64 _M_RT_AppMenu_ID;
        private String _MDBSC_Menu_For;
        private byte _FK_MDBSC_Menu_ModuleID;
        private String _MDBSC_Menu_Menu;
        private String _MDBSC_Menu_Level;
        private byte _MDBSC_Menu_ParentID;
        private String _MDBSC_Menu_Url;
        private String _MDBSC_Menu_Caption;
        private Int64 _MDBSC_Menu_SerialNo;
        private String _MDBSC_Menu_IsShow;
        private String _MDBSC_RowStatus;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;

        public Int64 M_RT_AppMenu_ID
        {
            get
            {
                return this._M_RT_AppMenu_ID;
            }
            set
            {
                this._M_RT_AppMenu_ID = value;
                _UpdateFieldName.Add("M_RT_AppMenu_ID");
            }
        }
        public String MDBSC_Menu_For
        {
            get
            {
                return this._MDBSC_Menu_For;
            }
            set
            {
                this._MDBSC_Menu_For = value;
                _UpdateFieldName.Add("MDBSC_Menu_For");
            }
        }
        public byte FK_MDBSC_Menu_ModuleID
        {
            get
            {
                return this._FK_MDBSC_Menu_ModuleID;
            }
            set
            {
                this._FK_MDBSC_Menu_ModuleID = value;
                _UpdateFieldName.Add("FK_MDBSC_Menu_ModuleID");
            }
        }
        public String MDBSC_Menu_Menu
        {
            get
            {
                return this._MDBSC_Menu_Menu;
            }
            set
            {
                this._MDBSC_Menu_Menu = value;
                _UpdateFieldName.Add("MDBSC_Menu_Menu");
            }
        }
        public String MDBSC_Menu_Level
        {
            get
            {
                return this._MDBSC_Menu_Level;
            }
            set
            {
                this._MDBSC_Menu_Level = value;
                _UpdateFieldName.Add("MDBSC_Menu_Level");
            }
        }
        public byte MDBSC_Menu_ParentID
        {
            get
            {
                return this._MDBSC_Menu_ParentID;
            }
            set
            {
                this._MDBSC_Menu_ParentID = value;
                _UpdateFieldName.Add("MDBSC_Menu_ParentID");
            }
        }
        public String MDBSC_Menu_Url
        {
            get
            {
                return this._MDBSC_Menu_Url;
            }
            set
            {
                this._MDBSC_Menu_Url = value;
                _UpdateFieldName.Add("MDBSC_Menu_Url");
            }
        }
        public String MDBSC_Menu_Caption
        {
            get
            {
                return this._MDBSC_Menu_Caption;
            }
            set
            {
                this._MDBSC_Menu_Caption = value;
                _UpdateFieldName.Add("MDBSC_Menu_Caption");
            }
        }
        public Int64 MDBSC_Menu_SerialNo
        {
            get
            {
                return this._MDBSC_Menu_SerialNo;
            }
            set
            {
                this._MDBSC_Menu_SerialNo = value;
                _UpdateFieldName.Add("MDBSC_Menu_SerialNo");
            }
        }
        public String MDBSC_Menu_IsShow
        {
            get
            {
                return this._MDBSC_Menu_IsShow;
            }
            set
            {
                this._MDBSC_Menu_IsShow = value;
                _UpdateFieldName.Add("MDBSC_Menu_IsShow");
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
        public string Insert_Update(AAA_M_RT_App_MenuBO sObject)
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


        public DataTable List(Int64 M_RT_AppMenu_ID, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                if (M_RT_AppMenu_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_AAA_M_RT_App_Menu" + strWhereClause;
                }
                else
                {
                    strSqlString = "SELECT * FROM v_AAA_M_RT_App_Menu  Where  M_RT_AppMenu_ID=0" + M_RT_AppMenu_ID;
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

// Obj_RT_Menu.M_RT_AppMenu_ID=Obj_RT_Menu.M_RT_AppMenu_ID;
// Obj_RT_Menu.MDBSC_Menu_For=Obj_RT_Menu.MDBSC_Menu_For;
// Obj_RT_Menu.FK_MDBSC_Menu_ModuleID=Obj_RT_Menu.FK_MDBSC_Menu_ModuleID;
// Obj_RT_Menu.MDBSC_Menu_Menu=Obj_RT_Menu.MDBSC_Menu_Menu;
// Obj_RT_Menu.MDBSC_Menu_Level=Obj_RT_Menu.MDBSC_Menu_Level;
// Obj_RT_Menu.MDBSC_Menu_ParentID=Obj_RT_Menu.MDBSC_Menu_ParentID;
// Obj_RT_Menu.MDBSC_Menu_Url=Obj_RT_Menu.MDBSC_Menu_Url;
// Obj_RT_Menu.MDBSC_Menu_Caption=Obj_RT_Menu.MDBSC_Menu_Caption;
// Obj_RT_Menu.MDBSC_Menu_SerialNo=Obj_RT_Menu.MDBSC_Menu_SerialNo;
// Obj_RT_Menu.MDBSC_Menu_IsShow=Obj_RT_Menu.MDBSC_Menu_IsShow;
// Obj_RT_Menu.MDBSC_RowStatus=Obj_RT_Menu.MDBSC_RowStatus;
// Obj_RT_Menu.MDBSC_RowCreatedByUser_ID=Obj_RT_Menu.MDBSC_RowCreatedByUser_ID;
// Obj_RT_Menu.MDBSC_RowCreatedByUserName=Obj_RT_Menu.MDBSC_RowCreatedByUserName;
// Obj_RT_Menu.MDBSC_RowCreatedOn_DT=Obj_RT_Menu.MDBSC_RowCreatedOn_DT;
// Obj_RT_Menu.MDBSC_RowLupdnByUser_ID=Obj_RT_Menu.MDBSC_RowLupdnByUser_ID;
// Obj_RT_Menu.MDBSC_RowLupdnUserName=Obj_RT_Menu.MDBSC_RowLupdnUserName;
// Obj_RT_Menu.MDBSC_RowLupdnOn_DT=Obj_RT_Menu.MDBSC_RowLupdnOn_DT;



// M_RT_AppMenu_ID.Text = "";
// MDBSC_Menu_For.Text = "";
// FK_MDBSC_Menu_ModuleID.Text = "";
// MDBSC_Menu_Menu.Text = "";
// MDBSC_Menu_Level.Text = "";
// MDBSC_Menu_ParentID.Text = "";
// MDBSC_Menu_Url.Text = "";
// MDBSC_Menu_Caption.Text = "";
// MDBSC_Menu_SerialNo.Text = "";
// MDBSC_Menu_IsShow.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";



// Obj_RT_Menu.M_RT_AppMenu_ID=M_RT_AppMenu_ID.Text ;
// Obj_RT_Menu.MDBSC_Menu_For=MDBSC_Menu_For.Text ;
// Obj_RT_Menu.FK_MDBSC_Menu_ModuleID=FK_MDBSC_Menu_ModuleID.Text ;
// Obj_RT_Menu.MDBSC_Menu_Menu=MDBSC_Menu_Menu.Text ;
// Obj_RT_Menu.MDBSC_Menu_Level=MDBSC_Menu_Level.Text ;
// Obj_RT_Menu.MDBSC_Menu_ParentID=MDBSC_Menu_ParentID.Text ;
// Obj_RT_Menu.MDBSC_Menu_Url=MDBSC_Menu_Url.Text ;
// Obj_RT_Menu.MDBSC_Menu_Caption=MDBSC_Menu_Caption.Text ;
// Obj_RT_Menu.MDBSC_Menu_SerialNo=MDBSC_Menu_SerialNo.Text ;
// Obj_RT_Menu.MDBSC_Menu_IsShow=MDBSC_Menu_IsShow.Text ;
// Obj_RT_Menu.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// Obj_RT_Menu.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// Obj_RT_Menu.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// Obj_RT_Menu.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// Obj_RT_Menu.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// Obj_RT_Menu.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// Obj_RT_Menu.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;



// M_RT_AppMenu_ID.Text =  dt.Rows[0]["M_RT_AppMenu_ID"].ToString();
// MDBSC_Menu_For.Text =  dt.Rows[0]["MDBSC_Menu_For"].ToString();
// FK_MDBSC_Menu_ModuleID.Text =  dt.Rows[0]["FK_MDBSC_Menu_ModuleID"].ToString();
// MDBSC_Menu_Menu.Text =  dt.Rows[0]["MDBSC_Menu_Menu"].ToString();
// MDBSC_Menu_Level.Text =  dt.Rows[0]["MDBSC_Menu_Level"].ToString();
// MDBSC_Menu_ParentID.Text =  dt.Rows[0]["MDBSC_Menu_ParentID"].ToString();
// MDBSC_Menu_Url.Text =  dt.Rows[0]["MDBSC_Menu_Url"].ToString();
// MDBSC_Menu_Caption.Text =  dt.Rows[0]["MDBSC_Menu_Caption"].ToString();
// MDBSC_Menu_SerialNo.Text =  dt.Rows[0]["MDBSC_Menu_SerialNo"].ToString();
// MDBSC_Menu_IsShow.Text =  dt.Rows[0]["MDBSC_Menu_IsShow"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
