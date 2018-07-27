using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal
{
    public class M_AT_Acc_Payment_Vendor_AHDRBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public M_AT_Acc_Payment_Vendor_AHDRBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "AVPHDR_ID";
        private string _TableName = "M_AT_Acc_Payment_Vendor_AHDR";
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

        private Int64 _AVPHDR_ID;
        private Int32 _Fk_Company_ID;
        private Int32 _Fk_Branch_ID;
        private Int32 _Fk_Year_ID;
        private String _Rec_Created_In;
        private Int64 _Rec_CreatedBy_ID;
        private Int64 _Rec_CreatedFor_ID;
        private String _VP_CreationType;
        private String _PC_Type;
        private String _VP_No;
        private String _VP_DT;
        private Int64 _Fk_VendorID;
        private Decimal _VP_Received_Amt;
        private Decimal _VP_Adjusted_Amt;
        private Decimal _VP_OnAccount_Amt;
        private String _VP_Payment_Mode;
        private String _VP_Ref_No;
        private String _VP_Ref_DT;
        private String _VP_Narration;
        private Int16 _VP_L1AuthorizeID;
        private String _VP_L1AuthorizeBy;
        private String _VP_L1AuthorizeDT;
        private Int16 _VP_L2AuthorizeID;
        private String _VP_L2AuthorizeBy;
        private String _VP_L2AuthorizeDT;
        private String _VP_AuthRemark;
        private Int16 _VP_DTL_CNT;
        private String _MDBSC_RowStatus;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;

        public Int64 AVPHDR_ID
        {
            get
            {
                return this._AVPHDR_ID;
            }
            set
            {
                this._AVPHDR_ID = value;
                _UpdateFieldName.Add("AVPHDR_ID");
            }
        }
        public Int32 Fk_Company_ID
        {
            get
            {
                return this._Fk_Company_ID;
            }
            set
            {
                this._Fk_Company_ID = value;
                _UpdateFieldName.Add("Fk_Company_ID");
            }
        }
        public Int32 Fk_Branch_ID
        {
            get
            {
                return this._Fk_Branch_ID;
            }
            set
            {
                this._Fk_Branch_ID = value;
                _UpdateFieldName.Add("Fk_Branch_ID");
            }
        }
        public Int32 Fk_Year_ID
        {
            get
            {
                return this._Fk_Year_ID;
            }
            set
            {
                this._Fk_Year_ID = value;
                _UpdateFieldName.Add("Fk_Year_ID");
            }
        }
        public String Rec_Created_In
        {
            get
            {
                return this._Rec_Created_In;
            }
            set
            {
                this._Rec_Created_In = value;
                _UpdateFieldName.Add("Rec_Created_In");
            }
        }
        public Int64 Rec_CreatedBy_ID
        {
            get
            {
                return this._Rec_CreatedBy_ID;
            }
            set
            {
                this._Rec_CreatedBy_ID = value;
                _UpdateFieldName.Add("Rec_CreatedBy_ID");
            }
        }
        public Int64 Rec_CreatedFor_ID
        {
            get
            {
                return this._Rec_CreatedFor_ID;
            }
            set
            {
                this._Rec_CreatedFor_ID = value;
                _UpdateFieldName.Add("Rec_CreatedFor_ID");
            }
        }
        public String VP_CreationType
        {
            get
            {
                return this._VP_CreationType;
            }
            set
            {
                this._VP_CreationType = value;
                _UpdateFieldName.Add("VP_CreationType");
            }
        }
        public String PC_Type
        {
            get
            {
                return this._PC_Type;
            }
            set
            {
                this._PC_Type = value;
                _UpdateFieldName.Add("PC_Type");
            }
        }
        public String VP_No
        {
            get
            {
                return this._VP_No;
            }
            set
            {
                this._VP_No = value;
                _UpdateFieldName.Add("VP_No");
            }
        }
        public String VP_DT
        {
            get
            {
                return this._VP_DT;
            }
            set
            {
                this._VP_DT = value;
                _UpdateFieldName.Add("VP_DT");
            }
        }
        public Int64 Fk_VendorID
        {
            get
            {
                return this._Fk_VendorID;
            }
            set
            {
                this._Fk_VendorID = value;
                _UpdateFieldName.Add("Fk_VendorID");
            }
        }
        public Decimal VP_Received_Amt
        {
            get
            {
                return this._VP_Received_Amt;
            }
            set
            {
                this._VP_Received_Amt = value;
                _UpdateFieldName.Add("VP_Received_Amt");
            }
        }
        public Decimal VP_Adjusted_Amt
        {
            get
            {
                return this._VP_Adjusted_Amt;
            }
            set
            {
                this._VP_Adjusted_Amt = value;
                _UpdateFieldName.Add("VP_Adjusted_Amt");
            }
        }
        public Decimal VP_OnAccount_Amt
        {
            get
            {
                return this._VP_OnAccount_Amt;
            }
            set
            {
                this._VP_OnAccount_Amt = value;
                _UpdateFieldName.Add("VP_OnAccount_Amt");
            }
        }
        public String VP_Payment_Mode
        {
            get
            {
                return this._VP_Payment_Mode;
            }
            set
            {
                this._VP_Payment_Mode = value;
                _UpdateFieldName.Add("VP_Payment_Mode");
            }
        }
        public String VP_Ref_No
        {
            get
            {
                return this._VP_Ref_No;
            }
            set
            {
                this._VP_Ref_No = value;
                _UpdateFieldName.Add("VP_Ref_No");
            }
        }
        public String VP_Ref_DT
        {
            get
            {
                return this._VP_Ref_DT;
            }
            set
            {
                this._VP_Ref_DT = value;
                _UpdateFieldName.Add("VP_Ref_DT");
            }
        }
        public String VP_Narration
        {
            get
            {
                return this._VP_Narration;
            }
            set
            {
                this._VP_Narration = value;
                _UpdateFieldName.Add("VP_Narration");
            }
        }
        public Int16 VP_L1AuthorizeID
        {
            get
            {
                return this._VP_L1AuthorizeID;
            }
            set
            {
                this._VP_L1AuthorizeID = value;
                _UpdateFieldName.Add("VP_L1AuthorizeID");
            }
        }
        public String VP_L1AuthorizeBy
        {
            get
            {
                return this._VP_L1AuthorizeBy;
            }
            set
            {
                this._VP_L1AuthorizeBy = value;
                _UpdateFieldName.Add("VP_L1AuthorizeBy");
            }
        }
        public String VP_L1AuthorizeDT
        {
            get
            {
                return this._VP_L1AuthorizeDT;
            }
            set
            {
                this._VP_L1AuthorizeDT = value;
                _UpdateFieldName.Add("VP_L1AuthorizeDT");
            }
        }
        public Int16 VP_L2AuthorizeID
        {
            get
            {
                return this._VP_L2AuthorizeID;
            }
            set
            {
                this._VP_L2AuthorizeID = value;
                _UpdateFieldName.Add("VP_L2AuthorizeID");
            }
        }
        public String VP_L2AuthorizeBy
        {
            get
            {
                return this._VP_L2AuthorizeBy;
            }
            set
            {
                this._VP_L2AuthorizeBy = value;
                _UpdateFieldName.Add("VP_L2AuthorizeBy");
            }
        }
        public String VP_L2AuthorizeDT
        {
            get
            {
                return this._VP_L2AuthorizeDT;
            }
            set
            {
                this._VP_L2AuthorizeDT = value;
                _UpdateFieldName.Add("VP_L2AuthorizeDT");
            }
        }
        public String VP_AuthRemark
        {
            get
            {
                return this._VP_AuthRemark;
            }
            set
            {
                this._VP_AuthRemark = value;
                _UpdateFieldName.Add("VP_AuthRemark");
            }
        }
        public Int16 VP_DTL_CNT
        {
            get
            {
                return this._VP_DTL_CNT;
            }
            set
            {
                this._VP_DTL_CNT = value;
                _UpdateFieldName.Add("VP_DTL_CNT");
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
        public string Insert_Update(M_AT_Acc_Payment_Vendor_AHDRBO sObject)
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

// ObjAT_VPHDR.AVPHDR_ID=ObjAT_VPHDR.AVPHDR_ID;
// ObjAT_VPHDR.Fk_Company_ID=ObjAT_VPHDR.Fk_Company_ID;
// ObjAT_VPHDR.Fk_Branch_ID=ObjAT_VPHDR.Fk_Branch_ID;
// ObjAT_VPHDR.Fk_Year_ID=ObjAT_VPHDR.Fk_Year_ID;
// ObjAT_VPHDR.Rec_Created_In=ObjAT_VPHDR.Rec_Created_In;
// ObjAT_VPHDR.Rec_CreatedBy_ID=ObjAT_VPHDR.Rec_CreatedBy_ID;
// ObjAT_VPHDR.Rec_CreatedFor_ID=ObjAT_VPHDR.Rec_CreatedFor_ID;
// ObjAT_VPHDR.VP_CreationType=ObjAT_VPHDR.VP_CreationType;
// ObjAT_VPHDR.PC_Type=ObjAT_VPHDR.PC_Type;
// ObjAT_VPHDR.VP_No=ObjAT_VPHDR.VP_No;
// ObjAT_VPHDR.VP_DT=ObjAT_VPHDR.VP_DT;
// ObjAT_VPHDR.Fk_VendorID=ObjAT_VPHDR.Fk_VendorID;
// ObjAT_VPHDR.VP_Received_Amt=ObjAT_VPHDR.VP_Received_Amt;
// ObjAT_VPHDR.VP_Adjusted_Amt=ObjAT_VPHDR.VP_Adjusted_Amt;
// ObjAT_VPHDR.VP_OnAccount_Amt=ObjAT_VPHDR.VP_OnAccount_Amt;
// ObjAT_VPHDR.VP_Payment_Mode=ObjAT_VPHDR.VP_Payment_Mode;
// ObjAT_VPHDR.VP_Ref_No=ObjAT_VPHDR.VP_Ref_No;
// ObjAT_VPHDR.VP_Ref_DT=ObjAT_VPHDR.VP_Ref_DT;
// ObjAT_VPHDR.VP_Narration=ObjAT_VPHDR.VP_Narration;
// ObjAT_VPHDR.VP_L1AuthorizeID=ObjAT_VPHDR.VP_L1AuthorizeID;
// ObjAT_VPHDR.VP_L1AuthorizeBy=ObjAT_VPHDR.VP_L1AuthorizeBy;
// ObjAT_VPHDR.VP_L1AuthorizeDT=ObjAT_VPHDR.VP_L1AuthorizeDT;
// ObjAT_VPHDR.VP_L2AuthorizeID=ObjAT_VPHDR.VP_L2AuthorizeID;
// ObjAT_VPHDR.VP_L2AuthorizeBy=ObjAT_VPHDR.VP_L2AuthorizeBy;
// ObjAT_VPHDR.VP_L2AuthorizeDT=ObjAT_VPHDR.VP_L2AuthorizeDT;
// ObjAT_VPHDR.VP_AuthRemark=ObjAT_VPHDR.VP_AuthRemark;
// ObjAT_VPHDR.VP_DTL_CNT=ObjAT_VPHDR.VP_DTL_CNT;
// ObjAT_VPHDR.MDBSC_RowStatus=ObjAT_VPHDR.MDBSC_RowStatus;
// ObjAT_VPHDR.MDBSC_RowCreatedByUser_ID=ObjAT_VPHDR.MDBSC_RowCreatedByUser_ID;
// ObjAT_VPHDR.MDBSC_RowCreatedByUserName=ObjAT_VPHDR.MDBSC_RowCreatedByUserName;
// ObjAT_VPHDR.MDBSC_RowCreatedOn_DT=ObjAT_VPHDR.MDBSC_RowCreatedOn_DT;
// ObjAT_VPHDR.MDBSC_RowLupdnByUser_ID=ObjAT_VPHDR.MDBSC_RowLupdnByUser_ID;
// ObjAT_VPHDR.MDBSC_RowLupdnUserName=ObjAT_VPHDR.MDBSC_RowLupdnUserName;
// ObjAT_VPHDR.MDBSC_RowLupdnOn_DT=ObjAT_VPHDR.MDBSC_RowLupdnOn_DT;



// AVPHDR_ID.Text = "";
// Fk_Company_ID.Text = "";
// Fk_Branch_ID.Text = "";
// Fk_Year_ID.Text = "";
// Rec_Created_In.Text = "";
// Rec_CreatedBy_ID.Text = "";
// Rec_CreatedFor_ID.Text = "";
// VP_CreationType.Text = "";
// PC_Type.Text = "";
// VP_No.Text = "";
// VP_DT.Text = "";
// Fk_VendorID.Text = "";
// VP_Received_Amt.Text = "";
// VP_Adjusted_Amt.Text = "";
// VP_OnAccount_Amt.Text = "";
// VP_Payment_Mode.Text = "";
// VP_Ref_No.Text = "";
// VP_Ref_DT.Text = "";
// VP_Narration.Text = "";
// VP_L1AuthorizeID.Text = "";
// VP_L1AuthorizeBy.Text = "";
// VP_L1AuthorizeDT.Text = "";
// VP_L2AuthorizeID.Text = "";
// VP_L2AuthorizeBy.Text = "";
// VP_L2AuthorizeDT.Text = "";
// VP_AuthRemark.Text = "";
// VP_DTL_CNT.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";



// ObjAT_VPHDR.AVPHDR_ID=AVPHDR_ID.Text ;
// ObjAT_VPHDR.Fk_Company_ID=Fk_Company_ID.Text ;
// ObjAT_VPHDR.Fk_Branch_ID=Fk_Branch_ID.Text ;
// ObjAT_VPHDR.Fk_Year_ID=Fk_Year_ID.Text ;
// ObjAT_VPHDR.Rec_Created_In=Rec_Created_In.Text ;
// ObjAT_VPHDR.Rec_CreatedBy_ID=Rec_CreatedBy_ID.Text ;
// ObjAT_VPHDR.Rec_CreatedFor_ID=Rec_CreatedFor_ID.Text ;
// ObjAT_VPHDR.VP_CreationType=VP_CreationType.Text ;
// ObjAT_VPHDR.PC_Type=PC_Type.Text ;
// ObjAT_VPHDR.VP_No=VP_No.Text ;
// ObjAT_VPHDR.VP_DT=VP_DT.Text ;
// ObjAT_VPHDR.Fk_VendorID=Fk_VendorID.Text ;
// ObjAT_VPHDR.VP_Received_Amt=VP_Received_Amt.Text ;
// ObjAT_VPHDR.VP_Adjusted_Amt=VP_Adjusted_Amt.Text ;
// ObjAT_VPHDR.VP_OnAccount_Amt=VP_OnAccount_Amt.Text ;
// ObjAT_VPHDR.VP_Payment_Mode=VP_Payment_Mode.Text ;
// ObjAT_VPHDR.VP_Ref_No=VP_Ref_No.Text ;
// ObjAT_VPHDR.VP_Ref_DT=VP_Ref_DT.Text ;
// ObjAT_VPHDR.VP_Narration=VP_Narration.Text ;
// ObjAT_VPHDR.VP_L1AuthorizeID=VP_L1AuthorizeID.Text ;
// ObjAT_VPHDR.VP_L1AuthorizeBy=VP_L1AuthorizeBy.Text ;
// ObjAT_VPHDR.VP_L1AuthorizeDT=VP_L1AuthorizeDT.Text ;
// ObjAT_VPHDR.VP_L2AuthorizeID=VP_L2AuthorizeID.Text ;
// ObjAT_VPHDR.VP_L2AuthorizeBy=VP_L2AuthorizeBy.Text ;
// ObjAT_VPHDR.VP_L2AuthorizeDT=VP_L2AuthorizeDT.Text ;
// ObjAT_VPHDR.VP_AuthRemark=VP_AuthRemark.Text ;
// ObjAT_VPHDR.VP_DTL_CNT=VP_DTL_CNT.Text ;
// ObjAT_VPHDR.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_VPHDR.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_VPHDR.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_VPHDR.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_VPHDR.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_VPHDR.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_VPHDR.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;



// AVPHDR_ID.Text =  dt.Rows[0]["AVPHDR_ID"].ToString();
// Fk_Company_ID.Text =  dt.Rows[0]["Fk_Company_ID"].ToString();
// Fk_Branch_ID.Text =  dt.Rows[0]["Fk_Branch_ID"].ToString();
// Fk_Year_ID.Text =  dt.Rows[0]["Fk_Year_ID"].ToString();
// Rec_Created_In.Text =  dt.Rows[0]["Rec_Created_In"].ToString();
// Rec_CreatedBy_ID.Text =  dt.Rows[0]["Rec_CreatedBy_ID"].ToString();
// Rec_CreatedFor_ID.Text =  dt.Rows[0]["Rec_CreatedFor_ID"].ToString();
// VP_CreationType.Text =  dt.Rows[0]["VP_CreationType"].ToString();
// PC_Type.Text =  dt.Rows[0]["PC_Type"].ToString();
// VP_No.Text =  dt.Rows[0]["VP_No"].ToString();
// VP_DT.Text =  dt.Rows[0]["VP_DT"].ToString();
// Fk_VendorID.Text =  dt.Rows[0]["Fk_VendorID"].ToString();
// VP_Received_Amt.Text =  dt.Rows[0]["VP_Received_Amt"].ToString();
// VP_Adjusted_Amt.Text =  dt.Rows[0]["VP_Adjusted_Amt"].ToString();
// VP_OnAccount_Amt.Text =  dt.Rows[0]["VP_OnAccount_Amt"].ToString();
// VP_Payment_Mode.Text =  dt.Rows[0]["VP_Payment_Mode"].ToString();
// VP_Ref_No.Text =  dt.Rows[0]["VP_Ref_No"].ToString();
// VP_Ref_DT.Text =  dt.Rows[0]["VP_Ref_DT"].ToString();
// VP_Narration.Text =  dt.Rows[0]["VP_Narration"].ToString();
// VP_L1AuthorizeID.Text =  dt.Rows[0]["VP_L1AuthorizeID"].ToString();
// VP_L1AuthorizeBy.Text =  dt.Rows[0]["VP_L1AuthorizeBy"].ToString();
// VP_L1AuthorizeDT.Text =  dt.Rows[0]["VP_L1AuthorizeDT"].ToString();
// VP_L2AuthorizeID.Text =  dt.Rows[0]["VP_L2AuthorizeID"].ToString();
// VP_L2AuthorizeBy.Text =  dt.Rows[0]["VP_L2AuthorizeBy"].ToString();
// VP_L2AuthorizeDT.Text =  dt.Rows[0]["VP_L2AuthorizeDT"].ToString();
// VP_AuthRemark.Text =  dt.Rows[0]["VP_AuthRemark"].ToString();
// VP_DTL_CNT.Text =  dt.Rows[0]["VP_DTL_CNT"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
