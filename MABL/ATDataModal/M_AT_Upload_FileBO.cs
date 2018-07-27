using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal
{
    public class M_AT_Upload_FileBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public M_AT_Upload_FileBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "FU_ID";
        private string _TableName = "M_AT_Upload_File";
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

        private Int64 _FU_ID;
        private Int64 _PartyID;
        private String _UserFileName;
        private String _GSTIN;
        
        private String _FileExt;
        private String _FilePath;
        private String _MDBSC_RowStatus;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;

        public Int64 FU_ID
        {
            get
            {
                return this._FU_ID;
            }
            set
            {
                this._FU_ID = value;
                _UpdateFieldName.Add("FU_ID");
            }
        }
        public Int64 PartyID
        {
            get
            {
                return this._PartyID;
            }
            set
            {
                this._PartyID = value;
                _UpdateFieldName.Add("PartyID");
            }
        }



        public String FileExt
        {
            get
            {
                return this._FileExt;
            }
            set
            {
                this._FileExt = value;
                _UpdateFieldName.Add("FileExt ");
            }
        }

        public String UserFileName
        {
            get
            {
                return this._UserFileName;
            }
            set
            {
                this._UserFileName = value;
                _UpdateFieldName.Add("UserFileName");
            }
        }
        public String FilePath
        {
            get
            {
                return this._FilePath;
            }
            set
            {
                this._FilePath = value;
                _UpdateFieldName.Add("FilePath");
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


        public String GSTIN
        {
            get
            {
                return this._GSTIN;
            }
            set
            {
                this._GSTIN = value;
                _UpdateFieldName.Add("GSTIN");
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
        public string Insert_Update(M_AT_Upload_FileBO sObject)
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

// ObjAT_FU.FU_ID=ObjAT_FU.FU_ID;
// ObjAT_FU.PartyID=ObjAT_FU.PartyID;
// ObjAT_FU.UserFileName=ObjAT_FU.UserFileName;
// ObjAT_FU.FilePath=ObjAT_FU.FilePath;
// ObjAT_FU.MDBSC_RowStatus=ObjAT_FU.MDBSC_RowStatus;
// ObjAT_FU.MDBSC_RowCreatedByUser_ID=ObjAT_FU.MDBSC_RowCreatedByUser_ID;
// ObjAT_FU.MDBSC_RowCreatedByUserName=ObjAT_FU.MDBSC_RowCreatedByUserName;
// ObjAT_FU.MDBSC_RowCreatedOn_DT=ObjAT_FU.MDBSC_RowCreatedOn_DT;
// ObjAT_FU.MDBSC_RowLupdnByUser_ID=ObjAT_FU.MDBSC_RowLupdnByUser_ID;
// ObjAT_FU.MDBSC_RowLupdnUserName=ObjAT_FU.MDBSC_RowLupdnUserName;
// ObjAT_FU.MDBSC_RowLupdnOn_DT=ObjAT_FU.MDBSC_RowLupdnOn_DT;



// FU_ID.Text = "";
// PartyID.Text = "";
// UserFileName.Text = "";
// FilePath.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";



// ObjAT_FU.FU_ID=FU_ID.Text ;
// ObjAT_FU.PartyID=PartyID.Text ;
// ObjAT_FU.UserFileName=UserFileName.Text ;
// ObjAT_FU.FilePath=FilePath.Text ;
// ObjAT_FU.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_FU.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_FU.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_FU.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_FU.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_FU.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_FU.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;



// FU_ID.Text =  dt.Rows[0]["FU_ID"].ToString();
// PartyID.Text =  dt.Rows[0]["PartyID"].ToString();
// UserFileName.Text =  dt.Rows[0]["UserFileName"].ToString();
// FilePath.Text =  dt.Rows[0]["FilePath"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
