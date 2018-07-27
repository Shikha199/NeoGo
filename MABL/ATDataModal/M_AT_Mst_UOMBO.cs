using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal
{
    public class M_AT_Mst_UOMBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public M_AT_Mst_UOMBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "UOM_ID";
        private string _TableName = "M_AT_Mst_UOM";
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

        private Int64 _UOM_ID;
        private String _UOM;
        private String _UOM_Code;
        private String _UOM_Desc;
        private String _MDBSC_RowStatus;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;

        public Int64 UOM_ID
        {
            get
            {
                return this._UOM_ID;
            }
            set
            {
                this._UOM_ID = value;
                _UpdateFieldName.Add("UOM_ID");
            }
        }
        public String UOM
        {
            get
            {
                return this._UOM;
            }
            set
            {
                this._UOM = value;
                _UpdateFieldName.Add("UOM");
            }
        }
        public String UOM_Code
        {
            get
            {
                return this._UOM_Code;
            }
            set
            {
                this._UOM_Code = value;
                _UpdateFieldName.Add("UOM_Code");
            }
        }
        public String UOM_Desc
        {
            get
            {
                return this._UOM_Desc;
            }
            set
            {
                this._UOM_Desc = value;
                _UpdateFieldName.Add("UOM_Desc");
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
        public string Insert_Update(M_AT_Mst_UOMBO sObject)
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

// ObjAT_Item_UOM.UOM_ID=ObjAT_Item_UOM.UOM_ID;
// ObjAT_Item_UOM.UOM=ObjAT_Item_UOM.UOM;
// ObjAT_Item_UOM.UOM_Code=ObjAT_Item_UOM.UOM_Code;
// ObjAT_Item_UOM.UOM_Desc=ObjAT_Item_UOM.UOM_Desc;
// ObjAT_Item_UOM.MDBSC_RowStatus=ObjAT_Item_UOM.MDBSC_RowStatus;
// ObjAT_Item_UOM.MDBSC_RowCreatedByUser_ID=ObjAT_Item_UOM.MDBSC_RowCreatedByUser_ID;
// ObjAT_Item_UOM.MDBSC_RowCreatedByUserName=ObjAT_Item_UOM.MDBSC_RowCreatedByUserName;
// ObjAT_Item_UOM.MDBSC_RowCreatedOn_DT=ObjAT_Item_UOM.MDBSC_RowCreatedOn_DT;
// ObjAT_Item_UOM.MDBSC_RowLupdnByUser_ID=ObjAT_Item_UOM.MDBSC_RowLupdnByUser_ID;
// ObjAT_Item_UOM.MDBSC_RowLupdnUserName=ObjAT_Item_UOM.MDBSC_RowLupdnUserName;
// ObjAT_Item_UOM.MDBSC_RowLupdnOn_DT=ObjAT_Item_UOM.MDBSC_RowLupdnOn_DT;



// UOM_ID.Text = "";
// UOM.Text = "";
// UOM_Code.Text = "";
// UOM_Desc.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";



// ObjAT_Item_UOM.UOM_ID=UOM_ID.Text ;
// ObjAT_Item_UOM.UOM=UOM.Text ;
// ObjAT_Item_UOM.UOM_Code=UOM_Code.Text ;
// ObjAT_Item_UOM.UOM_Desc=UOM_Desc.Text ;
// ObjAT_Item_UOM.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_Item_UOM.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_Item_UOM.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_Item_UOM.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_Item_UOM.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_Item_UOM.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_Item_UOM.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;



// UOM_ID.Text =  dt.Rows[0]["UOM_ID"].ToString();
// UOM.Text =  dt.Rows[0]["UOM"].ToString();
// UOM_Code.Text =  dt.Rows[0]["UOM_Code"].ToString();
// UOM_Desc.Text =  dt.Rows[0]["UOM_Desc"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
