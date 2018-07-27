using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.MCore.STDataModal
{
    public class AAA_M_RT_App_Menu_UserPermissionBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public AAA_M_RT_App_Menu_UserPermissionBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "M_RT_UP_ID";
        private string _TableName = "AAA_M_RT_App_Menu_UserPermission";
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

        private Int64 _M_RT_UP_ID;
        private Int64 _FK_M_RT_User_ID;
        private Int64 _FK_M_RT_AppMenu_ID;
        private String _MDBSC_App_UserRolePermissionVal;

        public Int64 M_RT_UP_ID
        {
            get
            {
                return this._M_RT_UP_ID;
            }
            set
            {
                this._M_RT_UP_ID = value;
                _UpdateFieldName.Add("M_RT_UP_ID");
            }
        }
        public Int64 FK_M_RT_User_ID
        {
            get
            {
                return this._FK_M_RT_User_ID;
            }
            set
            {
                this._FK_M_RT_User_ID = value;
                _UpdateFieldName.Add("FK_M_RT_User_ID");
            }
        }
        public Int64 FK_M_RT_AppMenu_ID
        {
            get
            {
                return this._FK_M_RT_AppMenu_ID;
            }
            set
            {
                this._FK_M_RT_AppMenu_ID = value;
                _UpdateFieldName.Add("FK_M_RT_AppMenu_ID");
            }
        }
        public String MDBSC_App_UserRolePermissionVal
        {
            get
            {
                return this._MDBSC_App_UserRolePermissionVal;
            }
            set
            {
                this._MDBSC_App_UserRolePermissionVal = value;
                _UpdateFieldName.Add("MDBSC_App_UserRolePermissionVal");
            }
        }

        #endregion
        #region Genric Methods
        public string Insert_Update(AAA_M_RT_App_Menu_UserPermissionBO sObject)
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


        public DataTable List(Int64 M_RT_UP_ID, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                if (M_RT_UP_ID == 0)
                {
                    strSqlString = "SELECT * FROM v_AAA_M_RT_App_Menu_UserPermission" + strWhereClause;
                }
                else
                {
                    strSqlString = "SELECT * FROM v_AAA_M_RT_App_Menu_UserPermission  Where  M_RT_UP_ID=0" + M_RT_UP_ID;
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

// Obj_RT_UserPermission.M_RT_UP_ID=Obj_RT_UserPermission.M_RT_UP_ID;
// Obj_RT_UserPermission.FK_M_RT_User_ID=Obj_RT_UserPermission.FK_M_RT_User_ID;
// Obj_RT_UserPermission.FK_M_RT_AppMenu_ID=Obj_RT_UserPermission.FK_M_RT_AppMenu_ID;
// Obj_RT_UserPermission.MDBSC_App_UserRolePermissionVal=Obj_RT_UserPermission.MDBSC_App_UserRolePermissionVal;



// M_RT_UP_ID.Text = "";
// FK_M_RT_User_ID.Text = "";
// FK_M_RT_AppMenu_ID.Text = "";
// MDBSC_App_UserRolePermissionVal.Text = "";



// Obj_RT_UserPermission.M_RT_UP_ID=M_RT_UP_ID.Text ;
// Obj_RT_UserPermission.FK_M_RT_User_ID=FK_M_RT_User_ID.Text ;
// Obj_RT_UserPermission.FK_M_RT_AppMenu_ID=FK_M_RT_AppMenu_ID.Text ;
// Obj_RT_UserPermission.MDBSC_App_UserRolePermissionVal=MDBSC_App_UserRolePermissionVal.Text ;



// M_RT_UP_ID.Text =  dt.Rows[0]["M_RT_UP_ID"].ToString();
// FK_M_RT_User_ID.Text =  dt.Rows[0]["FK_M_RT_User_ID"].ToString();
// FK_M_RT_AppMenu_ID.Text =  dt.Rows[0]["FK_M_RT_AppMenu_ID"].ToString();
// MDBSC_App_UserRolePermissionVal.Text =  dt.Rows[0]["MDBSC_App_UserRolePermissionVal"].ToString();
