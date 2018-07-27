using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal
{
    public class AAA_M_RT_AppFeedbackBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public AAA_M_RT_AppFeedbackBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "MAF_ID";
        private string _TableName = "AAA_M_RT_AppFeedback";
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

        private Int64 _MAF_ID;
        private Int64 _UserID;
        private String _Q_Date;
        private String _Q_Module;
        private Int64 _Q_BranchID;
        private String _Q_Title;
        private String _Q_Description;
        private String _Q_URL;
        private String _IsLock;
        private String _Q_Priority;

        private String _MDBSC_RowStatus;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;

        public Int64 MAF_ID
        {
            get
            {
                return this._MAF_ID;
            }
            set
            {
                this._MAF_ID = value;
                _UpdateFieldName.Add("MAF_ID");
            }
        }
        public Int64 UserID
        {
            get
            {
                return this._UserID;
            }
            set
            {
                this._UserID = value;
                _UpdateFieldName.Add("UserID");
            }
        }
        public String Q_Date
        {
            get
            {
                return this._Q_Date;
            }
            set
            {
                this._Q_Date = value;
                _UpdateFieldName.Add("Q_Date");
            }
        }
        public String Q_Module
        {
            get
            {
                return this._Q_Module;
            }
            set
            {
                this._Q_Module = value;
                _UpdateFieldName.Add("Q_Module");
            }
        }
        public Int64 Q_BranchID
        {
            get
            {
                return this._Q_BranchID;
            }
            set
            {
                this._Q_BranchID = value;
                _UpdateFieldName.Add("Q_BranchID");
            }
        }
        public String Q_Title
        {
            get
            {
                return this._Q_Title;
            }
            set
            {
                this._Q_Title = value;
                _UpdateFieldName.Add("Q_Title");
            }
        }
        public String Q_Description
        {
            get
            {
                return this._Q_Description;
            }
            set
            {
                this._Q_Description = value;
                _UpdateFieldName.Add("Q_Description");
            }
        }


        public String Q_Priority
        {
            get
            {
                return this._Q_Priority;
            }
            set
            {
                this._Q_Priority = value;
                _UpdateFieldName.Add("Q_Priority");
            }
        }



        public String Q_URL
        {
            get
            {
                return this._Q_URL;
            }
            set
            {
                this._Q_URL = value;
                _UpdateFieldName.Add("Q_URL");
            }
        }
        public String IsLock
        {
            get
            {
                return this._IsLock;
            }
            set
            {
                this._IsLock = value;
                _UpdateFieldName.Add("IsLock");
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
        public string Insert_Update(AAA_M_RT_AppFeedbackBO sObject)
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

// ObjAT_MAF.MAF_ID=ObjAT_MAF.MAF_ID;
// ObjAT_MAF.UserID=ObjAT_MAF.UserID;
// ObjAT_MAF.Q_Date=ObjAT_MAF.Q_Date;
// ObjAT_MAF.Q_Module=ObjAT_MAF.Q_Module;
// ObjAT_MAF.Q_BranchID=ObjAT_MAF.Q_BranchID;
// ObjAT_MAF.Q_Title=ObjAT_MAF.Q_Title;
// ObjAT_MAF.Q_Description=ObjAT_MAF.Q_Description;
// ObjAT_MAF.Q_URL=ObjAT_MAF.Q_URL;
// ObjAT_MAF.IsLock=ObjAT_MAF.IsLock;
// ObjAT_MAF.MDBSC_RowStatus=ObjAT_MAF.MDBSC_RowStatus;
// ObjAT_MAF.MDBSC_RowCreatedByUser_ID=ObjAT_MAF.MDBSC_RowCreatedByUser_ID;
// ObjAT_MAF.MDBSC_RowCreatedByUserName=ObjAT_MAF.MDBSC_RowCreatedByUserName;
// ObjAT_MAF.MDBSC_RowCreatedOn_DT=ObjAT_MAF.MDBSC_RowCreatedOn_DT;
// ObjAT_MAF.MDBSC_RowLupdnByUser_ID=ObjAT_MAF.MDBSC_RowLupdnByUser_ID;
// ObjAT_MAF.MDBSC_RowLupdnUserName=ObjAT_MAF.MDBSC_RowLupdnUserName;
// ObjAT_MAF.MDBSC_RowLupdnOn_DT=ObjAT_MAF.MDBSC_RowLupdnOn_DT;



// MAF_ID.Text = "";
// UserID.Text = "";
// Q_Date.Text = "";
// Q_Module.Text = "";
// Q_BranchID.Text = "";
// Q_Title.Text = "";
// Q_Description.Text = "";
// Q_URL.Text = "";
// IsLock.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";



// ObjAT_MAF.MAF_ID=MAF_ID.Text ;
// ObjAT_MAF.UserID=UserID.Text ;
// ObjAT_MAF.Q_Date=Q_Date.Text ;
// ObjAT_MAF.Q_Module=Q_Module.Text ;
// ObjAT_MAF.Q_BranchID=Q_BranchID.Text ;
// ObjAT_MAF.Q_Title=Q_Title.Text ;
// ObjAT_MAF.Q_Description=Q_Description.Text ;
// ObjAT_MAF.Q_URL=Q_URL.Text ;
// ObjAT_MAF.IsLock=IsLock.Text ;
// ObjAT_MAF.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_MAF.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_MAF.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_MAF.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_MAF.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_MAF.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_MAF.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;



// MAF_ID.Text =  dt.Rows[0]["MAF_ID"].ToString();
// UserID.Text =  dt.Rows[0]["UserID"].ToString();
// Q_Date.Text =  dt.Rows[0]["Q_Date"].ToString();
// Q_Module.Text =  dt.Rows[0]["Q_Module"].ToString();
// Q_BranchID.Text =  dt.Rows[0]["Q_BranchID"].ToString();
// Q_Title.Text =  dt.Rows[0]["Q_Title"].ToString();
// Q_Description.Text =  dt.Rows[0]["Q_Description"].ToString();
// Q_URL.Text =  dt.Rows[0]["Q_URL"].ToString();
// IsLock.Text =  dt.Rows[0]["IsLock"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();

