using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.MCore.STDataModal
{
    public class AAA_M_RT_App_UserBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public AAA_M_RT_App_UserBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "M_RT_User_ID";
        private string _TableName = "AAA_M_RT_App_User";
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

        private Int32 _M_RT_User_ID;
        private Int32 _FK_M_RT_CMP_ID;
        private Int32 _FK_M_RT_CMP_BR_ID;
        private Int32 _FK_M_RT_UserType_ID;
        private Int32 _FK_M_RT_UserRole_ID;
        private String _MDBSC_App_User_LoginID;
        private String _MDBSC_App_User_FName;
        private String _MDBSC_App_User_MName;
        private String _MDBSC_App_User_LName;
        private String _MDBSC_App_User_Password;
        private String _MDBSC_App_User_RegEmailID;
        private String _MDBSC_App_User_RegMobileNo;
        private String _MDBSC_App_User_Status;
        private String _MDBSC_App_User_ProfileImgPath;
        private String _MDBSC_RowStatus;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;

        public Int32 M_RT_User_ID
        {
            get
            {
                return this._M_RT_User_ID;
            }
            set
            {
                this._M_RT_User_ID = value;
                _UpdateFieldName.Add("M_RT_User_ID");
            }
        }
        public Int32 FK_M_RT_CMP_ID
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
        public Int32 FK_M_RT_CMP_BR_ID
        {
            get
            {
                return this._FK_M_RT_CMP_BR_ID;
            }
            set
            {
                this._FK_M_RT_CMP_BR_ID = value;
                _UpdateFieldName.Add("FK_M_RT_CMP_BR_ID");
            }
        }
        public Int32 FK_M_RT_UserType_ID
        {
            get
            {
                return this._FK_M_RT_UserType_ID;
            }
            set
            {
                this._FK_M_RT_UserType_ID = value;
                _UpdateFieldName.Add("FK_M_RT_UserType_ID");
            }
        }
        public Int32 FK_M_RT_UserRole_ID
        {
            get
            {
                return this._FK_M_RT_UserRole_ID;
            }
            set
            {
                this._FK_M_RT_UserRole_ID = value;
                _UpdateFieldName.Add("FK_M_RT_UserRole_ID");
            }
        }
        public String MDBSC_App_User_LoginID
        {
            get
            {
                return this._MDBSC_App_User_LoginID;
            }
            set
            {
                this._MDBSC_App_User_LoginID = value;
                _UpdateFieldName.Add("MDBSC_App_User_LoginID");
            }
        }
        public String MDBSC_App_User_FName
        {
            get
            {
                return this._MDBSC_App_User_FName;
            }
            set
            {
                this._MDBSC_App_User_FName = value;
                _UpdateFieldName.Add("MDBSC_App_User_FName");
            }
        }
        public String MDBSC_App_User_MName
        {
            get
            {
                return this._MDBSC_App_User_MName;
            }
            set
            {
                this._MDBSC_App_User_MName = value;
                _UpdateFieldName.Add("MDBSC_App_User_MName");
            }
        }
        public String MDBSC_App_User_LName
        {
            get
            {
                return this._MDBSC_App_User_LName;
            }
            set
            {
                this._MDBSC_App_User_LName = value;
                _UpdateFieldName.Add("MDBSC_App_User_LName");
            }
        }
        public String MDBSC_App_User_Password
        {
            get
            {
                return this._MDBSC_App_User_Password;
            }
            set
            {
                this._MDBSC_App_User_Password = value;
                _UpdateFieldName.Add("MDBSC_App_User_Password");
            }
        }
        public String MDBSC_App_User_RegEmailID
        {
            get
            {
                return this._MDBSC_App_User_RegEmailID;
            }
            set
            {
                this._MDBSC_App_User_RegEmailID = value;
                _UpdateFieldName.Add("MDBSC_App_User_RegEmailID");
            }
        }
        public String MDBSC_App_User_RegMobileNo
        {
            get
            {
                return this._MDBSC_App_User_RegMobileNo;
            }
            set
            {
                this._MDBSC_App_User_RegMobileNo = value;
                _UpdateFieldName.Add("MDBSC_App_User_RegMobileNo");
            }
        }
        public String MDBSC_App_User_Status
        {
            get
            {
                return this._MDBSC_App_User_Status;
            }
            set
            {
                this._MDBSC_App_User_Status = value;
                _UpdateFieldName.Add("MDBSC_App_User_Status");
            }
        }
        public String MDBSC_App_User_ProfileImgPath
        {
            get
            {
                return this._MDBSC_App_User_ProfileImgPath;
            }
            set
            {
                this._MDBSC_App_User_ProfileImgPath = value;
                _UpdateFieldName.Add("MDBSC_App_User_ProfileImgPath");
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
        public string Insert_Update(AAA_M_RT_App_UserBO sObject)
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


        public DataTable List(Int64 M_RT_User_ID, string SearchCriteria)
        {
            string strWhereClause = "";
            string strSqlString = "";
            try
            {
                strWhereClause = MaheshAF18.Application.MEF.GetSearchWhereClause(SearchCriteria);
                if (M_RT_User_ID == 0)
                {
                    strSqlString = "SELECT  Top 1 * FROM v_AAA_M_RT_App_User" + strWhereClause;
                }
                else
                {
                    strSqlString = "SELECT Top 1 * FROM v_AAA_M_RT_App_User  Where  M_RT_User_ID=0" + M_RT_User_ID;
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

// Obj_RT_AppUser.M_RT_User_ID=Obj_RT_AppUser.M_RT_User_ID;
// Obj_RT_AppUser.FK_M_RT_CMP_ID=Obj_RT_AppUser.FK_M_RT_CMP_ID;
// Obj_RT_AppUser.FK_M_RT_CMP_BR_ID=Obj_RT_AppUser.FK_M_RT_CMP_BR_ID;
// Obj_RT_AppUser.FK_M_RT_UserType_ID=Obj_RT_AppUser.FK_M_RT_UserType_ID;
// Obj_RT_AppUser.FK_M_RT_UserRole_ID=Obj_RT_AppUser.FK_M_RT_UserRole_ID;
// Obj_RT_AppUser.MDBSC_App_User_LoginID=Obj_RT_AppUser.MDBSC_App_User_LoginID;
// Obj_RT_AppUser.MDBSC_App_User_FName=Obj_RT_AppUser.MDBSC_App_User_FName;
// Obj_RT_AppUser.MDBSC_App_User_MName=Obj_RT_AppUser.MDBSC_App_User_MName;
// Obj_RT_AppUser.MDBSC_App_User_LName=Obj_RT_AppUser.MDBSC_App_User_LName;
// Obj_RT_AppUser.MDBSC_App_User_Password=Obj_RT_AppUser.MDBSC_App_User_Password;
// Obj_RT_AppUser.MDBSC_App_User_RegEmailID=Obj_RT_AppUser.MDBSC_App_User_RegEmailID;
// Obj_RT_AppUser.MDBSC_App_User_RegMobileNo=Obj_RT_AppUser.MDBSC_App_User_RegMobileNo;
// Obj_RT_AppUser.MDBSC_App_User_Status=Obj_RT_AppUser.MDBSC_App_User_Status;
// Obj_RT_AppUser.MDBSC_App_User_ProfileImgPath=Obj_RT_AppUser.MDBSC_App_User_ProfileImgPath;
// Obj_RT_AppUser.MDBSC_RowStatus=Obj_RT_AppUser.MDBSC_RowStatus;
// Obj_RT_AppUser.MDBSC_RowCreatedByUser_ID=Obj_RT_AppUser.MDBSC_RowCreatedByUser_ID;
// Obj_RT_AppUser.MDBSC_RowCreatedByUserName=Obj_RT_AppUser.MDBSC_RowCreatedByUserName;
// Obj_RT_AppUser.MDBSC_RowCreatedOn_DT=Obj_RT_AppUser.MDBSC_RowCreatedOn_DT;
// Obj_RT_AppUser.MDBSC_RowLupdnByUser_ID=Obj_RT_AppUser.MDBSC_RowLupdnByUser_ID;
// Obj_RT_AppUser.MDBSC_RowLupdnUserName=Obj_RT_AppUser.MDBSC_RowLupdnUserName;
// Obj_RT_AppUser.MDBSC_RowLupdnOn_DT=Obj_RT_AppUser.MDBSC_RowLupdnOn_DT;



// M_RT_User_ID.Text = "";
// FK_M_RT_CMP_ID.Text = "";
// FK_M_RT_CMP_BR_ID.Text = "";
// FK_M_RT_UserType_ID.Text = "";
// FK_M_RT_UserRole_ID.Text = "";
// MDBSC_App_User_LoginID.Text = "";
// MDBSC_App_User_FName.Text = "";
// MDBSC_App_User_MName.Text = "";
// MDBSC_App_User_LName.Text = "";
// MDBSC_App_User_Password.Text = "";
// MDBSC_App_User_RegEmailID.Text = "";
// MDBSC_App_User_RegMobileNo.Text = "";
// MDBSC_App_User_Status.Text = "";
// MDBSC_App_User_ProfileImgPath.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";



// Obj_RT_AppUser.M_RT_User_ID=M_RT_User_ID.Text ;
// Obj_RT_AppUser.FK_M_RT_CMP_ID=FK_M_RT_CMP_ID.Text ;
// Obj_RT_AppUser.FK_M_RT_CMP_BR_ID=FK_M_RT_CMP_BR_ID.Text ;
// Obj_RT_AppUser.FK_M_RT_UserType_ID=FK_M_RT_UserType_ID.Text ;
// Obj_RT_AppUser.FK_M_RT_UserRole_ID=FK_M_RT_UserRole_ID.Text ;
// Obj_RT_AppUser.MDBSC_App_User_LoginID=MDBSC_App_User_LoginID.Text ;
// Obj_RT_AppUser.MDBSC_App_User_FName=MDBSC_App_User_FName.Text ;
// Obj_RT_AppUser.MDBSC_App_User_MName=MDBSC_App_User_MName.Text ;
// Obj_RT_AppUser.MDBSC_App_User_LName=MDBSC_App_User_LName.Text ;
// Obj_RT_AppUser.MDBSC_App_User_Password=MDBSC_App_User_Password.Text ;
// Obj_RT_AppUser.MDBSC_App_User_RegEmailID=MDBSC_App_User_RegEmailID.Text ;
// Obj_RT_AppUser.MDBSC_App_User_RegMobileNo=MDBSC_App_User_RegMobileNo.Text ;
// Obj_RT_AppUser.MDBSC_App_User_Status=MDBSC_App_User_Status.Text ;
// Obj_RT_AppUser.MDBSC_App_User_ProfileImgPath=MDBSC_App_User_ProfileImgPath.Text ;
// Obj_RT_AppUser.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// Obj_RT_AppUser.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// Obj_RT_AppUser.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// Obj_RT_AppUser.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// Obj_RT_AppUser.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// Obj_RT_AppUser.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// Obj_RT_AppUser.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;



// M_RT_User_ID.Text =  dt.Rows[0]["M_RT_User_ID"].ToString();
// FK_M_RT_CMP_ID.Text =  dt.Rows[0]["FK_M_RT_CMP_ID"].ToString();
// FK_M_RT_CMP_BR_ID.Text =  dt.Rows[0]["FK_M_RT_CMP_BR_ID"].ToString();
// FK_M_RT_UserType_ID.Text =  dt.Rows[0]["FK_M_RT_UserType_ID"].ToString();
// FK_M_RT_UserRole_ID.Text =  dt.Rows[0]["FK_M_RT_UserRole_ID"].ToString();
// MDBSC_App_User_LoginID.Text =  dt.Rows[0]["MDBSC_App_User_LoginID"].ToString();
// MDBSC_App_User_FName.Text =  dt.Rows[0]["MDBSC_App_User_FName"].ToString();
// MDBSC_App_User_MName.Text =  dt.Rows[0]["MDBSC_App_User_MName"].ToString();
// MDBSC_App_User_LName.Text =  dt.Rows[0]["MDBSC_App_User_LName"].ToString();
// MDBSC_App_User_Password.Text =  dt.Rows[0]["MDBSC_App_User_Password"].ToString();
// MDBSC_App_User_RegEmailID.Text =  dt.Rows[0]["MDBSC_App_User_RegEmailID"].ToString();
// MDBSC_App_User_RegMobileNo.Text =  dt.Rows[0]["MDBSC_App_User_RegMobileNo"].ToString();
// MDBSC_App_User_Status.Text =  dt.Rows[0]["MDBSC_App_User_Status"].ToString();
// MDBSC_App_User_ProfileImgPath.Text =  dt.Rows[0]["MDBSC_App_User_ProfileImgPath"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
