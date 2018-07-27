using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal
{
    public class M_AT_Acc_Payment_Customer_AHDRBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public M_AT_Acc_Payment_Customer_AHDRBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "ACPHDR_ID";
        private string _TableName = "M_AT_Acc_Payment_Customer_AHDR";
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

        private Int64 _ACPHDR_ID;
        private Int32 _Fk_Company_ID;
        private Int32 _Fk_Branch_ID;
        private Int32 _Fk_Year_ID;
        private String _Rec_Created_In;
        private Int64 _Rec_CreatedBy_ID;
        private Int64 _Rec_CreatedFor_ID;
        private String _CP_CreationType;
        private String _PC_Type;
        private String _CP_No;
        private String _CP_DT;
        private Int64 _Fk_CustomerID;
        private Decimal _CP_Received_Amt;
        private Decimal _CP_Adjusted_Amt;
        private Decimal _CP_OnAccount_Amt;
        private String _CP_Payment_Mode;
        private String _CP_Ref_No;
        private String _CP_Ref_DT;
        private String _CP_Narration;
        private Int16 _CP_L1AuthorizeID;
        private String _CP_L1AuthorizeBy;
        private String _CP_L1AuthorizeDT;
        private Int16 _CP_L2AuthorizeID;
        private String _CP_L2AuthorizeBy;
        private String _CP_L2AuthorizeDT;
        private String _CP_AuthRemark;
        private Int16 _CP_DTL_CNT;
        private String _MDBSC_RowStatus;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;

        public Int64 ACPHDR_ID
        {
            get
            {
                return this._ACPHDR_ID;
            }
            set
            {
                this._ACPHDR_ID = value;
                _UpdateFieldName.Add("ACPHDR_ID");
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
        public String CP_CreationType
        {
            get
            {
                return this._CP_CreationType;
            }
            set
            {
                this._CP_CreationType = value;
                _UpdateFieldName.Add("CP_CreationType");
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
        public String CP_No
        {
            get
            {
                return this._CP_No;
            }
            set
            {
                this._CP_No = value;
                _UpdateFieldName.Add("CP_No");
            }
        }
        public String CP_DT
        {
            get
            {
                return this._CP_DT;
            }
            set
            {
                this._CP_DT = value;
                _UpdateFieldName.Add("CP_DT");
            }
        }
        public Int64 Fk_CustomerID
        {
            get
            {
                return this._Fk_CustomerID;
            }
            set
            {
                this._Fk_CustomerID = value;
                _UpdateFieldName.Add("Fk_CustomerID");
            }
        }
        public Decimal CP_Received_Amt
        {
            get
            {
                return this._CP_Received_Amt;
            }
            set
            {
                this._CP_Received_Amt = value;
                _UpdateFieldName.Add("CP_Received_Amt");
            }
        }
        public Decimal CP_Adjusted_Amt
        {
            get
            {
                return this._CP_Adjusted_Amt;
            }
            set
            {
                this._CP_Adjusted_Amt = value;
                _UpdateFieldName.Add("CP_Adjusted_Amt");
            }
        }
        public Decimal CP_OnAccount_Amt
        {
            get
            {
                return this._CP_OnAccount_Amt;
            }
            set
            {
                this._CP_OnAccount_Amt = value;
                _UpdateFieldName.Add("CP_OnAccount_Amt");
            }
        }
        public String CP_Payment_Mode
        {
            get
            {
                return this._CP_Payment_Mode;
            }
            set
            {
                this._CP_Payment_Mode = value;
                _UpdateFieldName.Add("CP_Payment_Mode");
            }
        }
        public String CP_Ref_No
        {
            get
            {
                return this._CP_Ref_No;
            }
            set
            {
                this._CP_Ref_No = value;
                _UpdateFieldName.Add("CP_Ref_No");
            }
        }
        public String CP_Ref_DT
        {
            get
            {
                return this._CP_Ref_DT;
            }
            set
            {
                this._CP_Ref_DT = value;
                _UpdateFieldName.Add("CP_Ref_DT");
            }
        }
        public String CP_Narration
        {
            get
            {
                return this._CP_Narration;
            }
            set
            {
                this._CP_Narration = value;
                _UpdateFieldName.Add("CP_Narration");
            }
        }
        public Int16 CP_L1AuthorizeID
        {
            get
            {
                return this._CP_L1AuthorizeID;
            }
            set
            {
                this._CP_L1AuthorizeID = value;
                _UpdateFieldName.Add("CP_L1AuthorizeID");
            }
        }
        public String CP_L1AuthorizeBy
        {
            get
            {
                return this._CP_L1AuthorizeBy;
            }
            set
            {
                this._CP_L1AuthorizeBy = value;
                _UpdateFieldName.Add("CP_L1AuthorizeBy");
            }
        }
        public String CP_L1AuthorizeDT
        {
            get
            {
                return this._CP_L1AuthorizeDT;
            }
            set
            {
                this._CP_L1AuthorizeDT = value;
                _UpdateFieldName.Add("CP_L1AuthorizeDT");
            }
        }
        public Int16 CP_L2AuthorizeID
        {
            get
            {
                return this._CP_L2AuthorizeID;
            }
            set
            {
                this._CP_L2AuthorizeID = value;
                _UpdateFieldName.Add("CP_L2AuthorizeID");
            }
        }
        public String CP_L2AuthorizeBy
        {
            get
            {
                return this._CP_L2AuthorizeBy;
            }
            set
            {
                this._CP_L2AuthorizeBy = value;
                _UpdateFieldName.Add("CP_L2AuthorizeBy");
            }
        }
        public String CP_L2AuthorizeDT
        {
            get
            {
                return this._CP_L2AuthorizeDT;
            }
            set
            {
                this._CP_L2AuthorizeDT = value;
                _UpdateFieldName.Add("CP_L2AuthorizeDT");
            }
        }
        public String CP_AuthRemark
        {
            get
            {
                return this._CP_AuthRemark;
            }
            set
            {
                this._CP_AuthRemark = value;
                _UpdateFieldName.Add("CP_AuthRemark");
            }
        }
        public Int16 CP_DTL_CNT
        {
            get
            {
                return this._CP_DTL_CNT;
            }
            set
            {
                this._CP_DTL_CNT = value;
                _UpdateFieldName.Add("CP_DTL_CNT");
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
        public string Insert_Update(M_AT_Acc_Payment_Customer_AHDRBO sObject)
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

// ObjAT_CPHDR.ACPHDR_ID=ObjAT_CPHDR.ACPHDR_ID;
// ObjAT_CPHDR.Fk_Company_ID=ObjAT_CPHDR.Fk_Company_ID;
// ObjAT_CPHDR.Fk_Branch_ID=ObjAT_CPHDR.Fk_Branch_ID;
// ObjAT_CPHDR.Fk_Year_ID=ObjAT_CPHDR.Fk_Year_ID;
// ObjAT_CPHDR.Rec_Created_In=ObjAT_CPHDR.Rec_Created_In;
// ObjAT_CPHDR.Rec_CreatedBy_ID=ObjAT_CPHDR.Rec_CreatedBy_ID;
// ObjAT_CPHDR.Rec_CreatedFor_ID=ObjAT_CPHDR.Rec_CreatedFor_ID;
// ObjAT_CPHDR.CP_CreationType=ObjAT_CPHDR.CP_CreationType;
// ObjAT_CPHDR.PC_Type=ObjAT_CPHDR.PC_Type;
// ObjAT_CPHDR.CP_No=ObjAT_CPHDR.CP_No;
// ObjAT_CPHDR.CP_DT=ObjAT_CPHDR.CP_DT;
// ObjAT_CPHDR.Fk_CustomerID=ObjAT_CPHDR.Fk_CustomerID;
// ObjAT_CPHDR.CP_Received_Amt=ObjAT_CPHDR.CP_Received_Amt;
// ObjAT_CPHDR.CP_Adjusted_Amt=ObjAT_CPHDR.CP_Adjusted_Amt;
// ObjAT_CPHDR.CP_OnAccount_Amt=ObjAT_CPHDR.CP_OnAccount_Amt;
// ObjAT_CPHDR.CP_Payment_Mode=ObjAT_CPHDR.CP_Payment_Mode;
// ObjAT_CPHDR.CP_Ref_No=ObjAT_CPHDR.CP_Ref_No;
// ObjAT_CPHDR.CP_Ref_DT=ObjAT_CPHDR.CP_Ref_DT;
// ObjAT_CPHDR.CP_Narration=ObjAT_CPHDR.CP_Narration;
// ObjAT_CPHDR.CP_L1AuthorizeID=ObjAT_CPHDR.CP_L1AuthorizeID;
// ObjAT_CPHDR.CP_L1AuthorizeBy=ObjAT_CPHDR.CP_L1AuthorizeBy;
// ObjAT_CPHDR.CP_L1AuthorizeDT=ObjAT_CPHDR.CP_L1AuthorizeDT;
// ObjAT_CPHDR.CP_L2AuthorizeID=ObjAT_CPHDR.CP_L2AuthorizeID;
// ObjAT_CPHDR.CP_L2AuthorizeBy=ObjAT_CPHDR.CP_L2AuthorizeBy;
// ObjAT_CPHDR.CP_L2AuthorizeDT=ObjAT_CPHDR.CP_L2AuthorizeDT;
// ObjAT_CPHDR.CP_AuthRemark=ObjAT_CPHDR.CP_AuthRemark;
// ObjAT_CPHDR.CP_DTL_CNT=ObjAT_CPHDR.CP_DTL_CNT;
// ObjAT_CPHDR.MDBSC_RowStatus=ObjAT_CPHDR.MDBSC_RowStatus;
// ObjAT_CPHDR.MDBSC_RowCreatedByUser_ID=ObjAT_CPHDR.MDBSC_RowCreatedByUser_ID;
// ObjAT_CPHDR.MDBSC_RowCreatedByUserName=ObjAT_CPHDR.MDBSC_RowCreatedByUserName;
// ObjAT_CPHDR.MDBSC_RowCreatedOn_DT=ObjAT_CPHDR.MDBSC_RowCreatedOn_DT;
// ObjAT_CPHDR.MDBSC_RowLupdnByUser_ID=ObjAT_CPHDR.MDBSC_RowLupdnByUser_ID;
// ObjAT_CPHDR.MDBSC_RowLupdnUserName=ObjAT_CPHDR.MDBSC_RowLupdnUserName;
// ObjAT_CPHDR.MDBSC_RowLupdnOn_DT=ObjAT_CPHDR.MDBSC_RowLupdnOn_DT;



// ACPHDR_ID.Text = "";
// Fk_Company_ID.Text = "";
// Fk_Branch_ID.Text = "";
// Fk_Year_ID.Text = "";
// Rec_Created_In.Text = "";
// Rec_CreatedBy_ID.Text = "";
// Rec_CreatedFor_ID.Text = "";
// CP_CreationType.Text = "";
// PC_Type.Text = "";
// CP_No.Text = "";
// CP_DT.Text = "";
// Fk_CustomerID.Text = "";
// CP_Received_Amt.Text = "";
// CP_Adjusted_Amt.Text = "";
// CP_OnAccount_Amt.Text = "";
// CP_Payment_Mode.Text = "";
// CP_Ref_No.Text = "";
// CP_Ref_DT.Text = "";
// CP_Narration.Text = "";
// CP_L1AuthorizeID.Text = "";
// CP_L1AuthorizeBy.Text = "";
// CP_L1AuthorizeDT.Text = "";
// CP_L2AuthorizeID.Text = "";
// CP_L2AuthorizeBy.Text = "";
// CP_L2AuthorizeDT.Text = "";
// CP_AuthRemark.Text = "";
// CP_DTL_CNT.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";



// ObjAT_CPHDR.ACPHDR_ID=ACPHDR_ID.Text ;
// ObjAT_CPHDR.Fk_Company_ID=Fk_Company_ID.Text ;
// ObjAT_CPHDR.Fk_Branch_ID=Fk_Branch_ID.Text ;
// ObjAT_CPHDR.Fk_Year_ID=Fk_Year_ID.Text ;
// ObjAT_CPHDR.Rec_Created_In=Rec_Created_In.Text ;
// ObjAT_CPHDR.Rec_CreatedBy_ID=Rec_CreatedBy_ID.Text ;
// ObjAT_CPHDR.Rec_CreatedFor_ID=Rec_CreatedFor_ID.Text ;
// ObjAT_CPHDR.CP_CreationType=CP_CreationType.Text ;
// ObjAT_CPHDR.PC_Type=PC_Type.Text ;
// ObjAT_CPHDR.CP_No=CP_No.Text ;
// ObjAT_CPHDR.CP_DT=CP_DT.Text ;
// ObjAT_CPHDR.Fk_CustomerID=Fk_CustomerID.Text ;
// ObjAT_CPHDR.CP_Received_Amt=CP_Received_Amt.Text ;
// ObjAT_CPHDR.CP_Adjusted_Amt=CP_Adjusted_Amt.Text ;
// ObjAT_CPHDR.CP_OnAccount_Amt=CP_OnAccount_Amt.Text ;
// ObjAT_CPHDR.CP_Payment_Mode=CP_Payment_Mode.Text ;
// ObjAT_CPHDR.CP_Ref_No=CP_Ref_No.Text ;
// ObjAT_CPHDR.CP_Ref_DT=CP_Ref_DT.Text ;
// ObjAT_CPHDR.CP_Narration=CP_Narration.Text ;
// ObjAT_CPHDR.CP_L1AuthorizeID=CP_L1AuthorizeID.Text ;
// ObjAT_CPHDR.CP_L1AuthorizeBy=CP_L1AuthorizeBy.Text ;
// ObjAT_CPHDR.CP_L1AuthorizeDT=CP_L1AuthorizeDT.Text ;
// ObjAT_CPHDR.CP_L2AuthorizeID=CP_L2AuthorizeID.Text ;
// ObjAT_CPHDR.CP_L2AuthorizeBy=CP_L2AuthorizeBy.Text ;
// ObjAT_CPHDR.CP_L2AuthorizeDT=CP_L2AuthorizeDT.Text ;
// ObjAT_CPHDR.CP_AuthRemark=CP_AuthRemark.Text ;
// ObjAT_CPHDR.CP_DTL_CNT=CP_DTL_CNT.Text ;
// ObjAT_CPHDR.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_CPHDR.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_CPHDR.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_CPHDR.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_CPHDR.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_CPHDR.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_CPHDR.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;



// ACPHDR_ID.Text =  dt.Rows[0]["ACPHDR_ID"].ToString();
// Fk_Company_ID.Text =  dt.Rows[0]["Fk_Company_ID"].ToString();
// Fk_Branch_ID.Text =  dt.Rows[0]["Fk_Branch_ID"].ToString();
// Fk_Year_ID.Text =  dt.Rows[0]["Fk_Year_ID"].ToString();
// Rec_Created_In.Text =  dt.Rows[0]["Rec_Created_In"].ToString();
// Rec_CreatedBy_ID.Text =  dt.Rows[0]["Rec_CreatedBy_ID"].ToString();
// Rec_CreatedFor_ID.Text =  dt.Rows[0]["Rec_CreatedFor_ID"].ToString();
// CP_CreationType.Text =  dt.Rows[0]["CP_CreationType"].ToString();
// PC_Type.Text =  dt.Rows[0]["PC_Type"].ToString();
// CP_No.Text =  dt.Rows[0]["CP_No"].ToString();
// CP_DT.Text =  dt.Rows[0]["CP_DT"].ToString();
// Fk_CustomerID.Text =  dt.Rows[0]["Fk_CustomerID"].ToString();
// CP_Received_Amt.Text =  dt.Rows[0]["CP_Received_Amt"].ToString();
// CP_Adjusted_Amt.Text =  dt.Rows[0]["CP_Adjusted_Amt"].ToString();
// CP_OnAccount_Amt.Text =  dt.Rows[0]["CP_OnAccount_Amt"].ToString();
// CP_Payment_Mode.Text =  dt.Rows[0]["CP_Payment_Mode"].ToString();
// CP_Ref_No.Text =  dt.Rows[0]["CP_Ref_No"].ToString();
// CP_Ref_DT.Text =  dt.Rows[0]["CP_Ref_DT"].ToString();
// CP_Narration.Text =  dt.Rows[0]["CP_Narration"].ToString();
// CP_L1AuthorizeID.Text =  dt.Rows[0]["CP_L1AuthorizeID"].ToString();
// CP_L1AuthorizeBy.Text =  dt.Rows[0]["CP_L1AuthorizeBy"].ToString();
// CP_L1AuthorizeDT.Text =  dt.Rows[0]["CP_L1AuthorizeDT"].ToString();
// CP_L2AuthorizeID.Text =  dt.Rows[0]["CP_L2AuthorizeID"].ToString();
// CP_L2AuthorizeBy.Text =  dt.Rows[0]["CP_L2AuthorizeBy"].ToString();
// CP_L2AuthorizeDT.Text =  dt.Rows[0]["CP_L2AuthorizeDT"].ToString();
// CP_AuthRemark.Text =  dt.Rows[0]["CP_AuthRemark"].ToString();
// CP_DTL_CNT.Text =  dt.Rows[0]["CP_DTL_CNT"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
