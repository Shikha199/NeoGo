using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.MCore.STDataModal
{
    public class AAA_M_RT_CMP_BranchBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public AAA_M_RT_CMP_BranchBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "M_RT_CMP_BR_ID";
        private string _TableName = "AAA_M_RT_CMP_Branch";
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

        private byte _M_RT_CMP_BR_ID;
        private byte _FK_M_RT_CMP_ID;
        private byte _MDBSC_BR_Start_Year_ID;
        private byte _MDBSC_BR_Previous_Year_ID;
        private byte _MDBSC_BR_Current_Year_ID;
        private String _MDBSC_BR_Name;
        private String _MDBSC_BR_Type;
        private String _MDBSC_BR_RSN;
        private String _MDBSC_BR_Perfix;
        private String _MDBSC_BR_Print_HeaderTxt;
        private String _MDBSC_BR_Print_Rpt_Default_Declaration;        
        private String _MDBSC_BR_Print_FooterTxt;
        private String _MDBSC_RowStatus;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;
        private String _BR_RegType;
        private String _BR_Reg_Add1;
        private String _BR_Reg_Add2;
        private String _BR_Reg_Add3;
        private String _BR_Reg_Add4;
        private String _BR_Buyer_Contact_Designation;
        private String _BR_Buyer_Contact_Person;
        private String _BR_Buyer_CP_PhoneNo;
        private String _BR_Buyer_CP_MobileNo;
        private String _BR_Buyer_CP_MobileNo_Alt;
        private String _BR_Buyer_CP_EmailID;
        private String _BR_Buyer_CP_EmailID_Alt;
        private String _BR_Consignee_Contact_Designation;
        private String _BR_Consignee_Contact_Person;
        private String _BR_Consignee_CP_PhoneNo;
        private String _BR_Consignee_CP_MobileNo;
        private String _BR_Consignee_CP_MobileNo_Alt;
        private String _BR_Consignee_CP_EmailID;
        private String _BR_Consignee_CP_EmailID_Alt;
        private String _BR_Buyer_CompanyName;
        private String _BR_Consignee_CompanyName;
        private String _BR_Consignee_Add1;
        private String _BR_Consignee_Add2;
        private String _BR_Consignee_Add3;
        private String _BR_Consignee_Add4;
        private String _BR_Consignee_PhoneNo1;
        private String _BR_Consignee_PhoneNo2;
        private String _BR_Consignee_FaxNo;
        private String _BR_Consignee_EmailID;
        private String _BR_Consignee_Country;
        private Int16 _BR_Consignee_State_ID;
        private String _BR_Consignee_City;
        private String _BR_Consignee_Area;
        private String _BR_Consignee_Pincode;
        private String _BR_Consignee_GSTNO;
        private String _BR_Consignee_ARNNO;
        private String _BR_Consignee_PANNO;
        private String _BR_NatureOfBusiness;
        private String _BR_Primary_Contact_Designation;
        private String _BR_Primary_Contact_Person;
        private String _BR_Primary_CP_PhoneNo;
        private String _BR_Primary_CP_MobileNo;
        private String _BR_Primary_CP_MobileNo_Alt;
        private String _BR_Primary_CP_EmailID;
        private String _BR_Primary_CP_EmailID_Alt;
        private String _BR_Contact_OfficeNo1;
        private String _BR_Contact_OfficeNo2;
        private String _BR_Contact_OfficeNo_Alt;
        private String _BR_Contact_FaxNo;
        private String _BR_Contact_Email_Admin;
        private String _BR_Contact_Email_Info;
        private String _BR_Contact_Email_Sales;
        private String _BR_BankName;
        private String _BR_AccountHolderName;
        private String _BR_IFSCNo;
        private String _BR_AccountNo;
        private String _BR_BankBranch;
        
        private String _BR_Contact_Email_Tech;
        private String _BR_Contact_Website;
        private String _BR_Reg_Country;
        private Int16 _BR_Reg_State_ID;
        private String _BR_Reg_City;
        private String _BR_Reg_Area;
        private String _BR_Reg_Pincode;
        private String _BL_VATNO;
        private String _BL_CSTNO;
        private String _BL_PANNO;
        private String _BL_TINNO;
        private String _BL_MST;
        private String _BL_ServiceTaxNo;
        private String _BL_TANNO;
        private String _BL_ESINO;
        private String _BL_ProfessionalTaxNo;
        private String _BL_ExciseRegNo;
        private String _BL_GSTNO;
        private String _BL_GST_DT;
        private String _BL_ARNNO;

        public byte M_RT_CMP_BR_ID
        {
            get
            {
                return this._M_RT_CMP_BR_ID;
            }
            set
            {
                this._M_RT_CMP_BR_ID = value;
                _UpdateFieldName.Add("M_RT_CMP_BR_ID");
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
        public byte MDBSC_BR_Start_Year_ID
        {
            get
            {
                return this._MDBSC_BR_Start_Year_ID;
            }
            set
            {
                this._MDBSC_BR_Start_Year_ID = value;
                _UpdateFieldName.Add("MDBSC_BR_Start_Year_ID");
            }
        }
        public byte MDBSC_BR_Previous_Year_ID
        {
            get
            {
                return this._MDBSC_BR_Previous_Year_ID;
            }
            set
            {
                this._MDBSC_BR_Previous_Year_ID = value;
                _UpdateFieldName.Add("MDBSC_BR_Previous_Year_ID");
            }
        }
        public byte MDBSC_BR_Current_Year_ID
        {
            get
            {
                return this._MDBSC_BR_Current_Year_ID;
            }
            set
            {
                this._MDBSC_BR_Current_Year_ID = value;
                _UpdateFieldName.Add("MDBSC_BR_Current_Year_ID");
            }
        }
        public String MDBSC_BR_Name
        {
            get
            {
                return this._MDBSC_BR_Name;
            }
            set
            {
                this._MDBSC_BR_Name = value;
                _UpdateFieldName.Add("MDBSC_BR_Name");
            }
        }
        public String MDBSC_BR_Type
        {
            get
            {
                return this._MDBSC_BR_Type;
            }
            set
            {
                this._MDBSC_BR_Type = value;
                _UpdateFieldName.Add("MDBSC_BR_Type");
            }
        }

        public String BR_BankName
        {
            get
            {
                return this._BR_BankName;
            }
            set
            {
                this._BR_BankName = value;
                _UpdateFieldName.Add("BR_BankName");
            }
        }
        public String BR_AccountHolderName
        {
            get
            {
                return this._BR_AccountHolderName;
            }
            set
            {
                this._BR_AccountHolderName = value;
                _UpdateFieldName.Add("BR_AccountHolderName");
            }
        }
        public String BR_IFSCNo
        {
            get
            {
                return this._BR_IFSCNo;
            }
            set
            {
                this._BR_IFSCNo = value;
                _UpdateFieldName.Add("BR_IFSCNo");
            }
        }
        public String BR_AccountNo
        {
            get
            {
                return this._BR_AccountNo;
            }
            set
            {
                this._BR_AccountNo = value;
                _UpdateFieldName.Add("BR_AccountNo");
            }
        }
        public String BR_BankBranch
        {
            get
            {
                return this._BR_BankBranch;
            }
            set
            {
                this._BR_BankBranch = value;
                _UpdateFieldName.Add("BR_BankBranch");
            }
        }
       

        public String MDBSC_BR_RSN
        {
            get
            {
                return this._MDBSC_BR_RSN;
            }
            set
            {
                this._MDBSC_BR_RSN = value;
                _UpdateFieldName.Add("MDBSC_BR_RSN");
            }
        }
        public String MDBSC_BR_Perfix
        {
            get
            {
                return this._MDBSC_BR_Perfix;
            }
            set
            {
                this._MDBSC_BR_Perfix = value;
                _UpdateFieldName.Add("MDBSC_BR_Perfix");
            }
        }
        public String MDBSC_BR_Print_HeaderTxt
        {
            get
            {
                return this._MDBSC_BR_Print_HeaderTxt;
            }
            set
            {
                this._MDBSC_BR_Print_HeaderTxt = value;
                _UpdateFieldName.Add("MDBSC_BR_Print_HeaderTxt");
            }
        }
        public String MDBSC_BR_Print_Rpt_Default_Declaration
        {
            get
            {
                return this._MDBSC_BR_Print_Rpt_Default_Declaration;
            }
            set
            {
                this._MDBSC_BR_Print_Rpt_Default_Declaration = value;
                _UpdateFieldName.Add("MDBSC_BR_Print_Rpt_Default_Declaration");
            }
        }
        public String MDBSC_BR_Print_FooterTxt
        {
            get
            {
                return this._MDBSC_BR_Print_FooterTxt;
            }
            set
            {
                this._MDBSC_BR_Print_FooterTxt = value;
                _UpdateFieldName.Add("MDBSC_BR_Print_FooterTxt");
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
        public String BR_RegType
        {
            get
            {
                return this._BR_RegType;
            }
            set
            {
                this._BR_RegType = value;
                _UpdateFieldName.Add("BR_RegType");
            }
        }
        public String BR_Reg_Add1
        {
            get
            {
                return this._BR_Reg_Add1;
            }
            set
            {
                this._BR_Reg_Add1 = value;
                _UpdateFieldName.Add("BR_Reg_Add1");
            }
        }
        public String BR_Reg_Add2
        {
            get
            {
                return this._BR_Reg_Add2;
            }
            set
            {
                this._BR_Reg_Add2 = value;
                _UpdateFieldName.Add("BR_Reg_Add2");
            }
        }
        public String BR_Reg_Add3
        {
            get
            {
                return this._BR_Reg_Add3;
            }
            set
            {
                this._BR_Reg_Add3 = value;
                _UpdateFieldName.Add("BR_Reg_Add3");
            }
        }
        public String BR_Reg_Add4
        {
            get
            {
                return this._BR_Reg_Add4;
            }
            set
            {
                this._BR_Reg_Add4 = value;
                _UpdateFieldName.Add("BR_Reg_Add4");
            }
        }
        public String BR_Buyer_Contact_Designation
        {
            get
            {
                return this._BR_Buyer_Contact_Designation;
            }
            set
            {
                this._BR_Buyer_Contact_Designation = value;
                _UpdateFieldName.Add("BR_Buyer_Contact_Designation");
            }
        }
        public String BR_Buyer_Contact_Person
        {
            get
            {
                return this._BR_Buyer_Contact_Person;
            }
            set
            {
                this._BR_Buyer_Contact_Person = value;
                _UpdateFieldName.Add("BR_Buyer_Contact_Person");
            }
        }
        public String BR_Buyer_CP_PhoneNo
        {
            get
            {
                return this._BR_Buyer_CP_PhoneNo;
            }
            set
            {
                this._BR_Buyer_CP_PhoneNo = value;
                _UpdateFieldName.Add("BR_Buyer_CP_PhoneNo");
            }
        }
        public String BR_Buyer_CP_MobileNo
        {
            get
            {
                return this._BR_Buyer_CP_MobileNo;
            }
            set
            {
                this._BR_Buyer_CP_MobileNo = value;
                _UpdateFieldName.Add("BR_Buyer_CP_MobileNo");
            }
        }
        public String BR_Buyer_CP_MobileNo_Alt
        {
            get
            {
                return this._BR_Buyer_CP_MobileNo_Alt;
            }
            set
            {
                this._BR_Buyer_CP_MobileNo_Alt = value;
                _UpdateFieldName.Add("BR_Buyer_CP_MobileNo_Alt");
            }
        }
        public String BR_Buyer_CP_EmailID
        {
            get
            {
                return this._BR_Buyer_CP_EmailID;
            }
            set
            {
                this._BR_Buyer_CP_EmailID = value;
                _UpdateFieldName.Add("BR_Buyer_CP_EmailID");
            }
        }
        public String BR_Buyer_CP_EmailID_Alt
        {
            get
            {
                return this._BR_Buyer_CP_EmailID_Alt;
            }
            set
            {
                this._BR_Buyer_CP_EmailID_Alt = value;
                _UpdateFieldName.Add("BR_Buyer_CP_EmailID_Alt");
            }
        }
        public String BR_Consignee_Contact_Designation
        {
            get
            {
                return this._BR_Consignee_Contact_Designation;
            }
            set
            {
                this._BR_Consignee_Contact_Designation = value;
                _UpdateFieldName.Add("BR_Consignee_Contact_Designation");
            }
        }
        public String BR_Consignee_Contact_Person
        {
            get
            {
                return this._BR_Consignee_Contact_Person;
            }
            set
            {
                this._BR_Consignee_Contact_Person = value;
                _UpdateFieldName.Add("BR_Consignee_Contact_Person");
            }
        }
        public String BR_Consignee_CP_PhoneNo
        {
            get
            {
                return this._BR_Consignee_CP_PhoneNo;
            }
            set
            {
                this._BR_Consignee_CP_PhoneNo = value;
                _UpdateFieldName.Add("BR_Consignee_CP_PhoneNo");
            }
        }
        public String BR_Consignee_CP_MobileNo
        {
            get
            {
                return this._BR_Consignee_CP_MobileNo;
            }
            set
            {
                this._BR_Consignee_CP_MobileNo = value;
                _UpdateFieldName.Add("BR_Consignee_CP_MobileNo");
            }
        }
        public String BR_Consignee_CP_MobileNo_Alt
        {
            get
            {
                return this._BR_Consignee_CP_MobileNo_Alt;
            }
            set
            {
                this._BR_Consignee_CP_MobileNo_Alt = value;
                _UpdateFieldName.Add("BR_Consignee_CP_MobileNo_Alt");
            }
        }
        public String BR_Consignee_CP_EmailID
        {
            get
            {
                return this._BR_Consignee_CP_EmailID;
            }
            set
            {
                this._BR_Consignee_CP_EmailID = value;
                _UpdateFieldName.Add("BR_Consignee_CP_EmailID");
            }
        }
        public String BR_Consignee_CP_EmailID_Alt
        {
            get
            {
                return this._BR_Consignee_CP_EmailID_Alt;
            }
            set
            {
                this._BR_Consignee_CP_EmailID_Alt = value;
                _UpdateFieldName.Add("BR_Consignee_CP_EmailID_Alt");
            }
        }
        public String BR_Buyer_CompanyName
        {
            get
            {
                return this._BR_Buyer_CompanyName;
            }
            set
            {
                this._BR_Buyer_CompanyName = value;
                _UpdateFieldName.Add("BR_Buyer_CompanyName");
            }
        }
        public String BR_Consignee_CompanyName
        {
            get
            {
                return this._BR_Consignee_CompanyName;
            }
            set
            {
                this._BR_Consignee_CompanyName = value;
                _UpdateFieldName.Add("BR_Consignee_CompanyName");
            }
        }
        public String BR_Consignee_Add1
        {
            get
            {
                return this._BR_Consignee_Add1;
            }
            set
            {
                this._BR_Consignee_Add1 = value;
                _UpdateFieldName.Add("BR_Consignee_Add1");
            }
        }
        public String BR_Consignee_Add2
        {
            get
            {
                return this._BR_Consignee_Add2;
            }
            set
            {
                this._BR_Consignee_Add2 = value;
                _UpdateFieldName.Add("BR_Consignee_Add2");
            }
        }
        public String BR_Consignee_Add3
        {
            get
            {
                return this._BR_Consignee_Add3;
            }
            set
            {
                this._BR_Consignee_Add3 = value;
                _UpdateFieldName.Add("BR_Consignee_Add3");
            }
        }
        public String BR_Consignee_Add4
        {
            get
            {
                return this._BR_Consignee_Add4;
            }
            set
            {
                this._BR_Consignee_Add4 = value;
                _UpdateFieldName.Add("BR_Consignee_Add4");
            }
        }
        public String BR_Consignee_PhoneNo1
        {
            get
            {
                return this._BR_Consignee_PhoneNo1;
            }
            set
            {
                this._BR_Consignee_PhoneNo1 = value;
                _UpdateFieldName.Add("BR_Consignee_PhoneNo1");
            }
        }
        public String BR_Consignee_PhoneNo2
        {
            get
            {
                return this._BR_Consignee_PhoneNo2;
            }
            set
            {
                this._BR_Consignee_PhoneNo2 = value;
                _UpdateFieldName.Add("BR_Consignee_PhoneNo2");
            }
        }
        public String BR_Consignee_FaxNo
        {
            get
            {
                return this._BR_Consignee_FaxNo;
            }
            set
            {
                this._BR_Consignee_FaxNo = value;
                _UpdateFieldName.Add("BR_Consignee_FaxNo");
            }
        }
        public String BR_Consignee_EmailID
        {
            get
            {
                return this._BR_Consignee_EmailID;
            }
            set
            {
                this._BR_Consignee_EmailID = value;
                _UpdateFieldName.Add("BR_Consignee_EmailID");
            }
        }
        public String BR_Consignee_Country
        {
            get
            {
                return this._BR_Consignee_Country;
            }
            set
            {
                this._BR_Consignee_Country = value;
                _UpdateFieldName.Add("BR_Consignee_Country");
            }
        }
        public Int16 BR_Consignee_State_ID
        {
            get
            {
                return this._BR_Consignee_State_ID;
            }
            set
            {
                this._BR_Consignee_State_ID = value;
                _UpdateFieldName.Add("BR_Consignee_State_ID");
            }
        }
        public String BR_Consignee_City
        {
            get
            {
                return this._BR_Consignee_City;
            }
            set
            {
                this._BR_Consignee_City = value;
                _UpdateFieldName.Add("BR_Consignee_City");
            }
        }
        public String BR_Consignee_Area
        {
            get
            {
                return this._BR_Consignee_Area;
            }
            set
            {
                this._BR_Consignee_Area = value;
                _UpdateFieldName.Add("BR_Consignee_Area");
            }
        }
        public String BR_Consignee_Pincode
        {
            get
            {
                return this._BR_Consignee_Pincode;
            }
            set
            {
                this._BR_Consignee_Pincode = value;
                _UpdateFieldName.Add("BR_Consignee_Pincode");
            }
        }
        public String BR_Consignee_GSTNO
        {
            get
            {
                return this._BR_Consignee_GSTNO;
            }
            set
            {
                this._BR_Consignee_GSTNO = value;
                _UpdateFieldName.Add("BR_Consignee_GSTNO");
            }
        }
        public String BR_Consignee_ARNNO
        {
            get
            {
                return this._BR_Consignee_ARNNO;
            }
            set
            {
                this._BR_Consignee_ARNNO = value;
                _UpdateFieldName.Add("BR_Consignee_ARNNO");
            }
        }
        public String BR_Consignee_PANNO
        {
            get
            {
                return this._BR_Consignee_PANNO;
            }
            set
            {
                this._BR_Consignee_PANNO = value;
                _UpdateFieldName.Add("BR_Consignee_PANNO");
            }
        }
        public String BR_NatureOfBusiness
        {
            get
            {
                return this._BR_NatureOfBusiness;
            }
            set
            {
                this._BR_NatureOfBusiness = value;
                _UpdateFieldName.Add("BR_NatureOfBusiness");
            }
        }
        public String BR_Primary_Contact_Designation
        {
            get
            {
                return this._BR_Primary_Contact_Designation;
            }
            set
            {
                this._BR_Primary_Contact_Designation = value;
                _UpdateFieldName.Add("BR_Primary_Contact_Designation");
            }
        }
        public String BR_Primary_Contact_Person
        {
            get
            {
                return this._BR_Primary_Contact_Person;
            }
            set
            {
                this._BR_Primary_Contact_Person = value;
                _UpdateFieldName.Add("BR_Primary_Contact_Person");
            }
        }
        public String BR_Primary_CP_PhoneNo
        {
            get
            {
                return this._BR_Primary_CP_PhoneNo;
            }
            set
            {
                this._BR_Primary_CP_PhoneNo = value;
                _UpdateFieldName.Add("BR_Primary_CP_PhoneNo");
            }
        }
        public String BR_Primary_CP_MobileNo
        {
            get
            {
                return this._BR_Primary_CP_MobileNo;
            }
            set
            {
                this._BR_Primary_CP_MobileNo = value;
                _UpdateFieldName.Add("BR_Primary_CP_MobileNo");
            }
        }
        public String BR_Primary_CP_MobileNo_Alt
        {
            get
            {
                return this._BR_Primary_CP_MobileNo_Alt;
            }
            set
            {
                this._BR_Primary_CP_MobileNo_Alt = value;
                _UpdateFieldName.Add("BR_Primary_CP_MobileNo_Alt");
            }
        }
        public String BR_Primary_CP_EmailID
        {
            get
            {
                return this._BR_Primary_CP_EmailID;
            }
            set
            {
                this._BR_Primary_CP_EmailID = value;
                _UpdateFieldName.Add("BR_Primary_CP_EmailID");
            }
        }
        public String BR_Primary_CP_EmailID_Alt
        {
            get
            {
                return this._BR_Primary_CP_EmailID_Alt;
            }
            set
            {
                this._BR_Primary_CP_EmailID_Alt = value;
                _UpdateFieldName.Add("BR_Primary_CP_EmailID_Alt");
            }
        }
        public String BR_Contact_OfficeNo1
        {
            get
            {
                return this._BR_Contact_OfficeNo1;
            }
            set
            {
                this._BR_Contact_OfficeNo1 = value;
                _UpdateFieldName.Add("BR_Contact_OfficeNo1");
            }
        }
        public String BR_Contact_OfficeNo2
        {
            get
            {
                return this._BR_Contact_OfficeNo2;
            }
            set
            {
                this._BR_Contact_OfficeNo2 = value;
                _UpdateFieldName.Add("BR_Contact_OfficeNo2");
            }
        }
        public String BR_Contact_OfficeNo_Alt
        {
            get
            {
                return this._BR_Contact_OfficeNo_Alt;
            }
            set
            {
                this._BR_Contact_OfficeNo_Alt = value;
                _UpdateFieldName.Add("BR_Contact_OfficeNo_Alt");
            }
        }
        public String BR_Contact_FaxNo
        {
            get
            {
                return this._BR_Contact_FaxNo;
            }
            set
            {
                this._BR_Contact_FaxNo = value;
                _UpdateFieldName.Add("BR_Contact_FaxNo");
            }
        }
        public String BR_Contact_Email_Admin
        {
            get
            {
                return this._BR_Contact_Email_Admin;
            }
            set
            {
                this._BR_Contact_Email_Admin = value;
                _UpdateFieldName.Add("BR_Contact_Email_Admin");
            }
        }
        public String BR_Contact_Email_Info
        {
            get
            {
                return this._BR_Contact_Email_Info;
            }
            set
            {
                this._BR_Contact_Email_Info = value;
                _UpdateFieldName.Add("BR_Contact_Email_Info");
            }
        }
        public String BR_Contact_Email_Sales
        {
            get
            {
                return this._BR_Contact_Email_Sales;
            }
            set
            {
                this._BR_Contact_Email_Sales = value;
                _UpdateFieldName.Add("BR_Contact_Email_Sales");
            }
        }
        public String BR_Contact_Email_Tech
        {
            get
            {
                return this._BR_Contact_Email_Tech;
            }
            set
            {
                this._BR_Contact_Email_Tech = value;
                _UpdateFieldName.Add("BR_Contact_Email_Tech");
            }
        }
        public String BR_Contact_Website
        {
            get
            {
                return this._BR_Contact_Website;
            }
            set
            {
                this._BR_Contact_Website = value;
                _UpdateFieldName.Add("BR_Contact_Website");
            }
        }
        public String BR_Reg_Country
        {
            get
            {
                return this._BR_Reg_Country;
            }
            set
            {
                this._BR_Reg_Country = value;
                _UpdateFieldName.Add("BR_Reg_Country");
            }
        }
        public Int16 BR_Reg_State_ID
        {
            get
            {
                return this._BR_Reg_State_ID;
            }
            set
            {
                this._BR_Reg_State_ID = value;
                _UpdateFieldName.Add("BR_Reg_State_ID");
            }
        }
        public String BR_Reg_City
        {
            get
            {
                return this._BR_Reg_City;
            }
            set
            {
                this._BR_Reg_City = value;
                _UpdateFieldName.Add("BR_Reg_City");
            }
        }
        public String BR_Reg_Area
        {
            get
            {
                return this._BR_Reg_Area;
            }
            set
            {
                this._BR_Reg_Area = value;
                _UpdateFieldName.Add("BR_Reg_Area");
            }
        }
        public String BR_Reg_Pincode
        {
            get
            {
                return this._BR_Reg_Pincode;
            }
            set
            {
                this._BR_Reg_Pincode = value;
                _UpdateFieldName.Add("BR_Reg_Pincode");
            }
        }
        public String BL_VATNO
        {
            get
            {
                return this._BL_VATNO;
            }
            set
            {
                this._BL_VATNO = value;
                _UpdateFieldName.Add("BL_VATNO");
            }
        }
        public String BL_CSTNO
        {
            get
            {
                return this._BL_CSTNO;
            }
            set
            {
                this._BL_CSTNO = value;
                _UpdateFieldName.Add("BL_CSTNO");
            }
        }
        public String BL_PANNO
        {
            get
            {
                return this._BL_PANNO;
            }
            set
            {
                this._BL_PANNO = value;
                _UpdateFieldName.Add("BL_PANNO");
            }
        }
        public String BL_TINNO
        {
            get
            {
                return this._BL_TINNO;
            }
            set
            {
                this._BL_TINNO = value;
                _UpdateFieldName.Add("BL_TINNO");
            }
        }
        public String BL_MST
        {
            get
            {
                return this._BL_MST;
            }
            set
            {
                this._BL_MST = value;
                _UpdateFieldName.Add("BL_MST");
            }
        }
        public String BL_ServiceTaxNo
        {
            get
            {
                return this._BL_ServiceTaxNo;
            }
            set
            {
                this._BL_ServiceTaxNo = value;
                _UpdateFieldName.Add("BL_ServiceTaxNo");
            }
        }
        public String BL_TANNO
        {
            get
            {
                return this._BL_TANNO;
            }
            set
            {
                this._BL_TANNO = value;
                _UpdateFieldName.Add("BL_TANNO");
            }
        }
        public String BL_ESINO
        {
            get
            {
                return this._BL_ESINO;
            }
            set
            {
                this._BL_ESINO = value;
                _UpdateFieldName.Add("BL_ESINO");
            }
        }
        public String BL_ProfessionalTaxNo
        {
            get
            {
                return this._BL_ProfessionalTaxNo;
            }
            set
            {
                this._BL_ProfessionalTaxNo = value;
                _UpdateFieldName.Add("BL_ProfessionalTaxNo");
            }
        }
        public String BL_ExciseRegNo
        {
            get
            {
                return this._BL_ExciseRegNo;
            }
            set
            {
                this._BL_ExciseRegNo = value;
                _UpdateFieldName.Add("BL_ExciseRegNo");
            }
        }
        public String BL_GSTNO
        {
            get
            {
                return this._BL_GSTNO;
            }
            set
            {
                this._BL_GSTNO = value;
                _UpdateFieldName.Add("BL_GSTNO");
            }
        }
        public String BL_GST_DT
        {
            get
            {
                return this._BL_GST_DT;
            }
            set
            {
                this._BL_GST_DT = value;
                _UpdateFieldName.Add("BL_GST_DT");
            }
        }
        public String BL_ARNNO
        {
            get
            {
                return this._BL_ARNNO;
            }
            set
            {
                this._BL_ARNNO = value;
                _UpdateFieldName.Add("BL_ARNNO");
            }
        }

        #endregion
        #region Genric Methods
        public string Insert_Update(AAA_M_RT_CMP_BranchBO sObject)
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

// Obj_RT_Branch.M_RT_CMP_BR_ID=Obj_RT_Branch.M_RT_CMP_BR_ID;
// Obj_RT_Branch.FK_M_RT_CMP_ID=Obj_RT_Branch.FK_M_RT_CMP_ID;
// Obj_RT_Branch.MDBSC_BR_Start_Year_ID=Obj_RT_Branch.MDBSC_BR_Start_Year_ID;
// Obj_RT_Branch.MDBSC_BR_Previous_Year_ID=Obj_RT_Branch.MDBSC_BR_Previous_Year_ID;
// Obj_RT_Branch.MDBSC_BR_Current_Year_ID=Obj_RT_Branch.MDBSC_BR_Current_Year_ID;
// Obj_RT_Branch.MDBSC_BR_Name=Obj_RT_Branch.MDBSC_BR_Name;
// Obj_RT_Branch.MDBSC_BR_Type=Obj_RT_Branch.MDBSC_BR_Type;
// Obj_RT_Branch.MDBSC_BR_RSN=Obj_RT_Branch.MDBSC_BR_RSN;
// Obj_RT_Branch.MDBSC_BR_Perfix=Obj_RT_Branch.MDBSC_BR_Perfix;
// Obj_RT_Branch.MDBSC_BR_Print_HeaderTxt=Obj_RT_Branch.MDBSC_BR_Print_HeaderTxt;
// Obj_RT_Branch.MDBSC_BR_Print_FooterTxt=Obj_RT_Branch.MDBSC_BR_Print_FooterTxt;
// Obj_RT_Branch.MDBSC_RowStatus=Obj_RT_Branch.MDBSC_RowStatus;
// Obj_RT_Branch.MDBSC_RowCreatedByUser_ID=Obj_RT_Branch.MDBSC_RowCreatedByUser_ID;
// Obj_RT_Branch.MDBSC_RowCreatedByUserName=Obj_RT_Branch.MDBSC_RowCreatedByUserName;
// Obj_RT_Branch.MDBSC_RowCreatedOn_DT=Obj_RT_Branch.MDBSC_RowCreatedOn_DT;
// Obj_RT_Branch.MDBSC_RowLupdnByUser_ID=Obj_RT_Branch.MDBSC_RowLupdnByUser_ID;
// Obj_RT_Branch.MDBSC_RowLupdnUserName=Obj_RT_Branch.MDBSC_RowLupdnUserName;
// Obj_RT_Branch.MDBSC_RowLupdnOn_DT=Obj_RT_Branch.MDBSC_RowLupdnOn_DT;
// Obj_RT_Branch.BR_RegType=Obj_RT_Branch.BR_RegType;
// Obj_RT_Branch.BR_Reg_Add1=Obj_RT_Branch.BR_Reg_Add1;
// Obj_RT_Branch.BR_Reg_Add2=Obj_RT_Branch.BR_Reg_Add2;
// Obj_RT_Branch.BR_Reg_Add3=Obj_RT_Branch.BR_Reg_Add3;
// Obj_RT_Branch.BR_Reg_Add4=Obj_RT_Branch.BR_Reg_Add4;
// Obj_RT_Branch.BR_Buyer_Contact_Designation=Obj_RT_Branch.BR_Buyer_Contact_Designation;
// Obj_RT_Branch.BR_Buyer_Contact_Person=Obj_RT_Branch.BR_Buyer_Contact_Person;
// Obj_RT_Branch.BR_Buyer_CP_PhoneNo=Obj_RT_Branch.BR_Buyer_CP_PhoneNo;
// Obj_RT_Branch.BR_Buyer_CP_MobileNo=Obj_RT_Branch.BR_Buyer_CP_MobileNo;
// Obj_RT_Branch.BR_Buyer_CP_MobileNo_Alt=Obj_RT_Branch.BR_Buyer_CP_MobileNo_Alt;
// Obj_RT_Branch.BR_Buyer_CP_EmailID=Obj_RT_Branch.BR_Buyer_CP_EmailID;
// Obj_RT_Branch.BR_Buyer_CP_EmailID_Alt=Obj_RT_Branch.BR_Buyer_CP_EmailID_Alt;
// Obj_RT_Branch.BR_Consignee_Contact_Designation=Obj_RT_Branch.BR_Consignee_Contact_Designation;
// Obj_RT_Branch.BR_Consignee_Contact_Person=Obj_RT_Branch.BR_Consignee_Contact_Person;
// Obj_RT_Branch.BR_Consignee_CP_PhoneNo=Obj_RT_Branch.BR_Consignee_CP_PhoneNo;
// Obj_RT_Branch.BR_Consignee_CP_MobileNo=Obj_RT_Branch.BR_Consignee_CP_MobileNo;
// Obj_RT_Branch.BR_Consignee_CP_MobileNo_Alt=Obj_RT_Branch.BR_Consignee_CP_MobileNo_Alt;
// Obj_RT_Branch.BR_Consignee_CP_EmailID=Obj_RT_Branch.BR_Consignee_CP_EmailID;
// Obj_RT_Branch.BR_Consignee_CP_EmailID_Alt=Obj_RT_Branch.BR_Consignee_CP_EmailID_Alt;
// Obj_RT_Branch.BR_Buyer_CompanyName=Obj_RT_Branch.BR_Buyer_CompanyName;
// Obj_RT_Branch.BR_Consignee_CompanyName=Obj_RT_Branch.BR_Consignee_CompanyName;
// Obj_RT_Branch.BR_Consignee_Add1=Obj_RT_Branch.BR_Consignee_Add1;
// Obj_RT_Branch.BR_Consignee_Add2=Obj_RT_Branch.BR_Consignee_Add2;
// Obj_RT_Branch.BR_Consignee_Add3=Obj_RT_Branch.BR_Consignee_Add3;
// Obj_RT_Branch.BR_Consignee_Add4=Obj_RT_Branch.BR_Consignee_Add4;
// Obj_RT_Branch.BR_Consignee_PhoneNo1=Obj_RT_Branch.BR_Consignee_PhoneNo1;
// Obj_RT_Branch.BR_Consignee_PhoneNo2=Obj_RT_Branch.BR_Consignee_PhoneNo2;
// Obj_RT_Branch.BR_Consignee_FaxNo=Obj_RT_Branch.BR_Consignee_FaxNo;
// Obj_RT_Branch.BR_Consignee_EmailID=Obj_RT_Branch.BR_Consignee_EmailID;
// Obj_RT_Branch.BR_Consignee_Country=Obj_RT_Branch.BR_Consignee_Country;
// Obj_RT_Branch.BR_Consignee_State_ID=Obj_RT_Branch.BR_Consignee_State_ID;
// Obj_RT_Branch.BR_Consignee_City=Obj_RT_Branch.BR_Consignee_City;
// Obj_RT_Branch.BR_Consignee_Area=Obj_RT_Branch.BR_Consignee_Area;
// Obj_RT_Branch.BR_Consignee_Pincode=Obj_RT_Branch.BR_Consignee_Pincode;
// Obj_RT_Branch.BR_Consignee_GSTNO=Obj_RT_Branch.BR_Consignee_GSTNO;
// Obj_RT_Branch.BR_Consignee_ARNNO=Obj_RT_Branch.BR_Consignee_ARNNO;
// Obj_RT_Branch.BR_Consignee_PANNO=Obj_RT_Branch.BR_Consignee_PANNO;
// Obj_RT_Branch.BR_NatureOfBusiness=Obj_RT_Branch.BR_NatureOfBusiness;
// Obj_RT_Branch.BR_Primary_Contact_Designation=Obj_RT_Branch.BR_Primary_Contact_Designation;
// Obj_RT_Branch.BR_Primary_Contact_Person=Obj_RT_Branch.BR_Primary_Contact_Person;
// Obj_RT_Branch.BR_Primary_CP_PhoneNo=Obj_RT_Branch.BR_Primary_CP_PhoneNo;
// Obj_RT_Branch.BR_Primary_CP_MobileNo=Obj_RT_Branch.BR_Primary_CP_MobileNo;
// Obj_RT_Branch.BR_Primary_CP_MobileNo_Alt=Obj_RT_Branch.BR_Primary_CP_MobileNo_Alt;
// Obj_RT_Branch.BR_Primary_CP_EmailID=Obj_RT_Branch.BR_Primary_CP_EmailID;
// Obj_RT_Branch.BR_Primary_CP_EmailID_Alt=Obj_RT_Branch.BR_Primary_CP_EmailID_Alt;
// Obj_RT_Branch.BR_Contact_OfficeNo1=Obj_RT_Branch.BR_Contact_OfficeNo1;
// Obj_RT_Branch.BR_Contact_OfficeNo2=Obj_RT_Branch.BR_Contact_OfficeNo2;
// Obj_RT_Branch.BR_Contact_OfficeNo_Alt=Obj_RT_Branch.BR_Contact_OfficeNo_Alt;
// Obj_RT_Branch.BR_Contact_FaxNo=Obj_RT_Branch.BR_Contact_FaxNo;
// Obj_RT_Branch.BR_Contact_Email_Admin=Obj_RT_Branch.BR_Contact_Email_Admin;
// Obj_RT_Branch.BR_Contact_Email_Info=Obj_RT_Branch.BR_Contact_Email_Info;
// Obj_RT_Branch.BR_Contact_Email_Sales=Obj_RT_Branch.BR_Contact_Email_Sales;
// Obj_RT_Branch.BR_Contact_Email_Tech=Obj_RT_Branch.BR_Contact_Email_Tech;
// Obj_RT_Branch.BR_Contact_Website=Obj_RT_Branch.BR_Contact_Website;
// Obj_RT_Branch.BR_Reg_Country=Obj_RT_Branch.BR_Reg_Country;
// Obj_RT_Branch.BR_Reg_State_ID=Obj_RT_Branch.BR_Reg_State_ID;
// Obj_RT_Branch.BR_Reg_City=Obj_RT_Branch.BR_Reg_City;
// Obj_RT_Branch.BR_Reg_Area=Obj_RT_Branch.BR_Reg_Area;
// Obj_RT_Branch.BR_Reg_Pincode=Obj_RT_Branch.BR_Reg_Pincode;
// Obj_RT_Branch.BL_VATNO=Obj_RT_Branch.BL_VATNO;
// Obj_RT_Branch.BL_CSTNO=Obj_RT_Branch.BL_CSTNO;
// Obj_RT_Branch.BL_PANNO=Obj_RT_Branch.BL_PANNO;
// Obj_RT_Branch.BL_TINNO=Obj_RT_Branch.BL_TINNO;
// Obj_RT_Branch.BL_MST=Obj_RT_Branch.BL_MST;
// Obj_RT_Branch.BL_ServiceTaxNo=Obj_RT_Branch.BL_ServiceTaxNo;
// Obj_RT_Branch.BL_TANNO=Obj_RT_Branch.BL_TANNO;
// Obj_RT_Branch.BL_ESINO=Obj_RT_Branch.BL_ESINO;
// Obj_RT_Branch.BL_ProfessionalTaxNo=Obj_RT_Branch.BL_ProfessionalTaxNo;
// Obj_RT_Branch.BL_ExciseRegNo=Obj_RT_Branch.BL_ExciseRegNo;
// Obj_RT_Branch.BL_GSTNO=Obj_RT_Branch.BL_GSTNO;
// Obj_RT_Branch.BL_GST_DT=Obj_RT_Branch.BL_GST_DT;
// Obj_RT_Branch.BL_ARNNO=Obj_RT_Branch.BL_ARNNO;



// M_RT_CMP_BR_ID.Text = "";
// FK_M_RT_CMP_ID.Text = "";
// MDBSC_BR_Start_Year_ID.Text = "";
// MDBSC_BR_Previous_Year_ID.Text = "";
// MDBSC_BR_Current_Year_ID.Text = "";
// MDBSC_BR_Name.Text = "";
// MDBSC_BR_Type.Text = "";
// MDBSC_BR_RSN.Text = "";
// MDBSC_BR_Perfix.Text = "";
// MDBSC_BR_Print_HeaderTxt.Text = "";
// MDBSC_BR_Print_FooterTxt.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";
// BR_RegType.Text = "";
// BR_Reg_Add1.Text = "";
// BR_Reg_Add2.Text = "";
// BR_Reg_Add3.Text = "";
// BR_Reg_Add4.Text = "";
// BR_Buyer_Contact_Designation.Text = "";
// BR_Buyer_Contact_Person.Text = "";
// BR_Buyer_CP_PhoneNo.Text = "";
// BR_Buyer_CP_MobileNo.Text = "";
// BR_Buyer_CP_MobileNo_Alt.Text = "";
// BR_Buyer_CP_EmailID.Text = "";
// BR_Buyer_CP_EmailID_Alt.Text = "";
// BR_Consignee_Contact_Designation.Text = "";
// BR_Consignee_Contact_Person.Text = "";
// BR_Consignee_CP_PhoneNo.Text = "";
// BR_Consignee_CP_MobileNo.Text = "";
// BR_Consignee_CP_MobileNo_Alt.Text = "";
// BR_Consignee_CP_EmailID.Text = "";
// BR_Consignee_CP_EmailID_Alt.Text = "";
// BR_Buyer_CompanyName.Text = "";
// BR_Consignee_CompanyName.Text = "";
// BR_Consignee_Add1.Text = "";
// BR_Consignee_Add2.Text = "";
// BR_Consignee_Add3.Text = "";
// BR_Consignee_Add4.Text = "";
// BR_Consignee_PhoneNo1.Text = "";
// BR_Consignee_PhoneNo2.Text = "";
// BR_Consignee_FaxNo.Text = "";
// BR_Consignee_EmailID.Text = "";
// BR_Consignee_Country.Text = "";
// BR_Consignee_State_ID.Text = "";
// BR_Consignee_City.Text = "";
// BR_Consignee_Area.Text = "";
// BR_Consignee_Pincode.Text = "";
// BR_Consignee_GSTNO.Text = "";
// BR_Consignee_ARNNO.Text = "";
// BR_Consignee_PANNO.Text = "";
// BR_NatureOfBusiness.Text = "";
// BR_Primary_Contact_Designation.Text = "";
// BR_Primary_Contact_Person.Text = "";
// BR_Primary_CP_PhoneNo.Text = "";
// BR_Primary_CP_MobileNo.Text = "";
// BR_Primary_CP_MobileNo_Alt.Text = "";
// BR_Primary_CP_EmailID.Text = "";
// BR_Primary_CP_EmailID_Alt.Text = "";
// BR_Contact_OfficeNo1.Text = "";
// BR_Contact_OfficeNo2.Text = "";
// BR_Contact_OfficeNo_Alt.Text = "";
// BR_Contact_FaxNo.Text = "";
// BR_Contact_Email_Admin.Text = "";
// BR_Contact_Email_Info.Text = "";
// BR_Contact_Email_Sales.Text = "";
// BR_Contact_Email_Tech.Text = "";
// BR_Contact_Website.Text = "";
// BR_Reg_Country.Text = "";
// BR_Reg_State_ID.Text = "";
// BR_Reg_City.Text = "";
// BR_Reg_Area.Text = "";
// BR_Reg_Pincode.Text = "";
// BL_VATNO.Text = "";
// BL_CSTNO.Text = "";
// BL_PANNO.Text = "";
// BL_TINNO.Text = "";
// BL_MST.Text = "";
// BL_ServiceTaxNo.Text = "";
// BL_TANNO.Text = "";
// BL_ESINO.Text = "";
// BL_ProfessionalTaxNo.Text = "";
// BL_ExciseRegNo.Text = "";
// BL_GSTNO.Text = "";
// BL_GST_DT.Text = "";
// BL_ARNNO.Text = "";



// Obj_RT_Branch.M_RT_CMP_BR_ID=M_RT_CMP_BR_ID.Text ;
// Obj_RT_Branch.FK_M_RT_CMP_ID=FK_M_RT_CMP_ID.Text ;
// Obj_RT_Branch.MDBSC_BR_Start_Year_ID=MDBSC_BR_Start_Year_ID.Text ;
// Obj_RT_Branch.MDBSC_BR_Previous_Year_ID=MDBSC_BR_Previous_Year_ID.Text ;
// Obj_RT_Branch.MDBSC_BR_Current_Year_ID=MDBSC_BR_Current_Year_ID.Text ;
// Obj_RT_Branch.MDBSC_BR_Name=MDBSC_BR_Name.Text ;
// Obj_RT_Branch.MDBSC_BR_Type=MDBSC_BR_Type.Text ;
// Obj_RT_Branch.MDBSC_BR_RSN=MDBSC_BR_RSN.Text ;
// Obj_RT_Branch.MDBSC_BR_Perfix=MDBSC_BR_Perfix.Text ;
// Obj_RT_Branch.MDBSC_BR_Print_HeaderTxt=MDBSC_BR_Print_HeaderTxt.Text ;
// Obj_RT_Branch.MDBSC_BR_Print_FooterTxt=MDBSC_BR_Print_FooterTxt.Text ;
// Obj_RT_Branch.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// Obj_RT_Branch.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// Obj_RT_Branch.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// Obj_RT_Branch.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// Obj_RT_Branch.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// Obj_RT_Branch.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// Obj_RT_Branch.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;
// Obj_RT_Branch.BR_RegType=BR_RegType.Text ;
// Obj_RT_Branch.BR_Reg_Add1=BR_Reg_Add1.Text ;
// Obj_RT_Branch.BR_Reg_Add2=BR_Reg_Add2.Text ;
// Obj_RT_Branch.BR_Reg_Add3=BR_Reg_Add3.Text ;
// Obj_RT_Branch.BR_Reg_Add4=BR_Reg_Add4.Text ;
// Obj_RT_Branch.BR_Buyer_Contact_Designation=BR_Buyer_Contact_Designation.Text ;
// Obj_RT_Branch.BR_Buyer_Contact_Person=BR_Buyer_Contact_Person.Text ;
// Obj_RT_Branch.BR_Buyer_CP_PhoneNo=BR_Buyer_CP_PhoneNo.Text ;
// Obj_RT_Branch.BR_Buyer_CP_MobileNo=BR_Buyer_CP_MobileNo.Text ;
// Obj_RT_Branch.BR_Buyer_CP_MobileNo_Alt=BR_Buyer_CP_MobileNo_Alt.Text ;
// Obj_RT_Branch.BR_Buyer_CP_EmailID=BR_Buyer_CP_EmailID.Text ;
// Obj_RT_Branch.BR_Buyer_CP_EmailID_Alt=BR_Buyer_CP_EmailID_Alt.Text ;
// Obj_RT_Branch.BR_Consignee_Contact_Designation=BR_Consignee_Contact_Designation.Text ;
// Obj_RT_Branch.BR_Consignee_Contact_Person=BR_Consignee_Contact_Person.Text ;
// Obj_RT_Branch.BR_Consignee_CP_PhoneNo=BR_Consignee_CP_PhoneNo.Text ;
// Obj_RT_Branch.BR_Consignee_CP_MobileNo=BR_Consignee_CP_MobileNo.Text ;
// Obj_RT_Branch.BR_Consignee_CP_MobileNo_Alt=BR_Consignee_CP_MobileNo_Alt.Text ;
// Obj_RT_Branch.BR_Consignee_CP_EmailID=BR_Consignee_CP_EmailID.Text ;
// Obj_RT_Branch.BR_Consignee_CP_EmailID_Alt=BR_Consignee_CP_EmailID_Alt.Text ;
// Obj_RT_Branch.BR_Buyer_CompanyName=BR_Buyer_CompanyName.Text ;
// Obj_RT_Branch.BR_Consignee_CompanyName=BR_Consignee_CompanyName.Text ;
// Obj_RT_Branch.BR_Consignee_Add1=BR_Consignee_Add1.Text ;
// Obj_RT_Branch.BR_Consignee_Add2=BR_Consignee_Add2.Text ;
// Obj_RT_Branch.BR_Consignee_Add3=BR_Consignee_Add3.Text ;
// Obj_RT_Branch.BR_Consignee_Add4=BR_Consignee_Add4.Text ;
// Obj_RT_Branch.BR_Consignee_PhoneNo1=BR_Consignee_PhoneNo1.Text ;
// Obj_RT_Branch.BR_Consignee_PhoneNo2=BR_Consignee_PhoneNo2.Text ;
// Obj_RT_Branch.BR_Consignee_FaxNo=BR_Consignee_FaxNo.Text ;
// Obj_RT_Branch.BR_Consignee_EmailID=BR_Consignee_EmailID.Text ;
// Obj_RT_Branch.BR_Consignee_Country=BR_Consignee_Country.Text ;
// Obj_RT_Branch.BR_Consignee_State_ID=BR_Consignee_State_ID.Text ;
// Obj_RT_Branch.BR_Consignee_City=BR_Consignee_City.Text ;
// Obj_RT_Branch.BR_Consignee_Area=BR_Consignee_Area.Text ;
// Obj_RT_Branch.BR_Consignee_Pincode=BR_Consignee_Pincode.Text ;
// Obj_RT_Branch.BR_Consignee_GSTNO=BR_Consignee_GSTNO.Text ;
// Obj_RT_Branch.BR_Consignee_ARNNO=BR_Consignee_ARNNO.Text ;
// Obj_RT_Branch.BR_Consignee_PANNO=BR_Consignee_PANNO.Text ;
// Obj_RT_Branch.BR_NatureOfBusiness=BR_NatureOfBusiness.Text ;
// Obj_RT_Branch.BR_Primary_Contact_Designation=BR_Primary_Contact_Designation.Text ;
// Obj_RT_Branch.BR_Primary_Contact_Person=BR_Primary_Contact_Person.Text ;
// Obj_RT_Branch.BR_Primary_CP_PhoneNo=BR_Primary_CP_PhoneNo.Text ;
// Obj_RT_Branch.BR_Primary_CP_MobileNo=BR_Primary_CP_MobileNo.Text ;
// Obj_RT_Branch.BR_Primary_CP_MobileNo_Alt=BR_Primary_CP_MobileNo_Alt.Text ;
// Obj_RT_Branch.BR_Primary_CP_EmailID=BR_Primary_CP_EmailID.Text ;
// Obj_RT_Branch.BR_Primary_CP_EmailID_Alt=BR_Primary_CP_EmailID_Alt.Text ;
// Obj_RT_Branch.BR_Contact_OfficeNo1=BR_Contact_OfficeNo1.Text ;
// Obj_RT_Branch.BR_Contact_OfficeNo2=BR_Contact_OfficeNo2.Text ;
// Obj_RT_Branch.BR_Contact_OfficeNo_Alt=BR_Contact_OfficeNo_Alt.Text ;
// Obj_RT_Branch.BR_Contact_FaxNo=BR_Contact_FaxNo.Text ;
// Obj_RT_Branch.BR_Contact_Email_Admin=BR_Contact_Email_Admin.Text ;
// Obj_RT_Branch.BR_Contact_Email_Info=BR_Contact_Email_Info.Text ;
// Obj_RT_Branch.BR_Contact_Email_Sales=BR_Contact_Email_Sales.Text ;
// Obj_RT_Branch.BR_Contact_Email_Tech=BR_Contact_Email_Tech.Text ;
// Obj_RT_Branch.BR_Contact_Website=BR_Contact_Website.Text ;
// Obj_RT_Branch.BR_Reg_Country=BR_Reg_Country.Text ;
// Obj_RT_Branch.BR_Reg_State_ID=BR_Reg_State_ID.Text ;
// Obj_RT_Branch.BR_Reg_City=BR_Reg_City.Text ;
// Obj_RT_Branch.BR_Reg_Area=BR_Reg_Area.Text ;
// Obj_RT_Branch.BR_Reg_Pincode=BR_Reg_Pincode.Text ;
// Obj_RT_Branch.BL_VATNO=BL_VATNO.Text ;
// Obj_RT_Branch.BL_CSTNO=BL_CSTNO.Text ;
// Obj_RT_Branch.BL_PANNO=BL_PANNO.Text ;
// Obj_RT_Branch.BL_TINNO=BL_TINNO.Text ;
// Obj_RT_Branch.BL_MST=BL_MST.Text ;
// Obj_RT_Branch.BL_ServiceTaxNo=BL_ServiceTaxNo.Text ;
// Obj_RT_Branch.BL_TANNO=BL_TANNO.Text ;
// Obj_RT_Branch.BL_ESINO=BL_ESINO.Text ;
// Obj_RT_Branch.BL_ProfessionalTaxNo=BL_ProfessionalTaxNo.Text ;
// Obj_RT_Branch.BL_ExciseRegNo=BL_ExciseRegNo.Text ;
// Obj_RT_Branch.BL_GSTNO=BL_GSTNO.Text ;
// Obj_RT_Branch.BL_GST_DT=BL_GST_DT.Text ;
// Obj_RT_Branch.BL_ARNNO=BL_ARNNO.Text ;



// M_RT_CMP_BR_ID.Text =  dt.Rows[0]["M_RT_CMP_BR_ID"].ToString();
// FK_M_RT_CMP_ID.Text =  dt.Rows[0]["FK_M_RT_CMP_ID"].ToString();
// MDBSC_BR_Start_Year_ID.Text =  dt.Rows[0]["MDBSC_BR_Start_Year_ID"].ToString();
// MDBSC_BR_Previous_Year_ID.Text =  dt.Rows[0]["MDBSC_BR_Previous_Year_ID"].ToString();
// MDBSC_BR_Current_Year_ID.Text =  dt.Rows[0]["MDBSC_BR_Current_Year_ID"].ToString();
// MDBSC_BR_Name.Text =  dt.Rows[0]["MDBSC_BR_Name"].ToString();
// MDBSC_BR_Type.Text =  dt.Rows[0]["MDBSC_BR_Type"].ToString();
// MDBSC_BR_RSN.Text =  dt.Rows[0]["MDBSC_BR_RSN"].ToString();
// MDBSC_BR_Perfix.Text =  dt.Rows[0]["MDBSC_BR_Perfix"].ToString();
// MDBSC_BR_Print_HeaderTxt.Text =  dt.Rows[0]["MDBSC_BR_Print_HeaderTxt"].ToString();
// MDBSC_BR_Print_FooterTxt.Text =  dt.Rows[0]["MDBSC_BR_Print_FooterTxt"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
// BR_RegType.Text =  dt.Rows[0]["BR_RegType"].ToString();
// BR_Reg_Add1.Text =  dt.Rows[0]["BR_Reg_Add1"].ToString();
// BR_Reg_Add2.Text =  dt.Rows[0]["BR_Reg_Add2"].ToString();
// BR_Reg_Add3.Text =  dt.Rows[0]["BR_Reg_Add3"].ToString();
// BR_Reg_Add4.Text =  dt.Rows[0]["BR_Reg_Add4"].ToString();
// BR_Buyer_Contact_Designation.Text =  dt.Rows[0]["BR_Buyer_Contact_Designation"].ToString();
// BR_Buyer_Contact_Person.Text =  dt.Rows[0]["BR_Buyer_Contact_Person"].ToString();
// BR_Buyer_CP_PhoneNo.Text =  dt.Rows[0]["BR_Buyer_CP_PhoneNo"].ToString();
// BR_Buyer_CP_MobileNo.Text =  dt.Rows[0]["BR_Buyer_CP_MobileNo"].ToString();
// BR_Buyer_CP_MobileNo_Alt.Text =  dt.Rows[0]["BR_Buyer_CP_MobileNo_Alt"].ToString();
// BR_Buyer_CP_EmailID.Text =  dt.Rows[0]["BR_Buyer_CP_EmailID"].ToString();
// BR_Buyer_CP_EmailID_Alt.Text =  dt.Rows[0]["BR_Buyer_CP_EmailID_Alt"].ToString();
// BR_Consignee_Contact_Designation.Text =  dt.Rows[0]["BR_Consignee_Contact_Designation"].ToString();
// BR_Consignee_Contact_Person.Text =  dt.Rows[0]["BR_Consignee_Contact_Person"].ToString();
// BR_Consignee_CP_PhoneNo.Text =  dt.Rows[0]["BR_Consignee_CP_PhoneNo"].ToString();
// BR_Consignee_CP_MobileNo.Text =  dt.Rows[0]["BR_Consignee_CP_MobileNo"].ToString();
// BR_Consignee_CP_MobileNo_Alt.Text =  dt.Rows[0]["BR_Consignee_CP_MobileNo_Alt"].ToString();
// BR_Consignee_CP_EmailID.Text =  dt.Rows[0]["BR_Consignee_CP_EmailID"].ToString();
// BR_Consignee_CP_EmailID_Alt.Text =  dt.Rows[0]["BR_Consignee_CP_EmailID_Alt"].ToString();
// BR_Buyer_CompanyName.Text =  dt.Rows[0]["BR_Buyer_CompanyName"].ToString();
// BR_Consignee_CompanyName.Text =  dt.Rows[0]["BR_Consignee_CompanyName"].ToString();
// BR_Consignee_Add1.Text =  dt.Rows[0]["BR_Consignee_Add1"].ToString();
// BR_Consignee_Add2.Text =  dt.Rows[0]["BR_Consignee_Add2"].ToString();
// BR_Consignee_Add3.Text =  dt.Rows[0]["BR_Consignee_Add3"].ToString();
// BR_Consignee_Add4.Text =  dt.Rows[0]["BR_Consignee_Add4"].ToString();
// BR_Consignee_PhoneNo1.Text =  dt.Rows[0]["BR_Consignee_PhoneNo1"].ToString();
// BR_Consignee_PhoneNo2.Text =  dt.Rows[0]["BR_Consignee_PhoneNo2"].ToString();
// BR_Consignee_FaxNo.Text =  dt.Rows[0]["BR_Consignee_FaxNo"].ToString();
// BR_Consignee_EmailID.Text =  dt.Rows[0]["BR_Consignee_EmailID"].ToString();
// BR_Consignee_Country.Text =  dt.Rows[0]["BR_Consignee_Country"].ToString();
// BR_Consignee_State_ID.Text =  dt.Rows[0]["BR_Consignee_State_ID"].ToString();
// BR_Consignee_City.Text =  dt.Rows[0]["BR_Consignee_City"].ToString();
// BR_Consignee_Area.Text =  dt.Rows[0]["BR_Consignee_Area"].ToString();
// BR_Consignee_Pincode.Text =  dt.Rows[0]["BR_Consignee_Pincode"].ToString();
// BR_Consignee_GSTNO.Text =  dt.Rows[0]["BR_Consignee_GSTNO"].ToString();
// BR_Consignee_ARNNO.Text =  dt.Rows[0]["BR_Consignee_ARNNO"].ToString();
// BR_Consignee_PANNO.Text =  dt.Rows[0]["BR_Consignee_PANNO"].ToString();
// BR_NatureOfBusiness.Text =  dt.Rows[0]["BR_NatureOfBusiness"].ToString();
// BR_Primary_Contact_Designation.Text =  dt.Rows[0]["BR_Primary_Contact_Designation"].ToString();
// BR_Primary_Contact_Person.Text =  dt.Rows[0]["BR_Primary_Contact_Person"].ToString();
// BR_Primary_CP_PhoneNo.Text =  dt.Rows[0]["BR_Primary_CP_PhoneNo"].ToString();
// BR_Primary_CP_MobileNo.Text =  dt.Rows[0]["BR_Primary_CP_MobileNo"].ToString();
// BR_Primary_CP_MobileNo_Alt.Text =  dt.Rows[0]["BR_Primary_CP_MobileNo_Alt"].ToString();
// BR_Primary_CP_EmailID.Text =  dt.Rows[0]["BR_Primary_CP_EmailID"].ToString();
// BR_Primary_CP_EmailID_Alt.Text =  dt.Rows[0]["BR_Primary_CP_EmailID_Alt"].ToString();
// BR_Contact_OfficeNo1.Text =  dt.Rows[0]["BR_Contact_OfficeNo1"].ToString();
// BR_Contact_OfficeNo2.Text =  dt.Rows[0]["BR_Contact_OfficeNo2"].ToString();
// BR_Contact_OfficeNo_Alt.Text =  dt.Rows[0]["BR_Contact_OfficeNo_Alt"].ToString();
// BR_Contact_FaxNo.Text =  dt.Rows[0]["BR_Contact_FaxNo"].ToString();
// BR_Contact_Email_Admin.Text =  dt.Rows[0]["BR_Contact_Email_Admin"].ToString();
// BR_Contact_Email_Info.Text =  dt.Rows[0]["BR_Contact_Email_Info"].ToString();
// BR_Contact_Email_Sales.Text =  dt.Rows[0]["BR_Contact_Email_Sales"].ToString();
// BR_Contact_Email_Tech.Text =  dt.Rows[0]["BR_Contact_Email_Tech"].ToString();
// BR_Contact_Website.Text =  dt.Rows[0]["BR_Contact_Website"].ToString();
// BR_Reg_Country.Text =  dt.Rows[0]["BR_Reg_Country"].ToString();
// BR_Reg_State_ID.Text =  dt.Rows[0]["BR_Reg_State_ID"].ToString();
// BR_Reg_City.Text =  dt.Rows[0]["BR_Reg_City"].ToString();
// BR_Reg_Area.Text =  dt.Rows[0]["BR_Reg_Area"].ToString();
// BR_Reg_Pincode.Text =  dt.Rows[0]["BR_Reg_Pincode"].ToString();
// BL_VATNO.Text =  dt.Rows[0]["BL_VATNO"].ToString();
// BL_CSTNO.Text =  dt.Rows[0]["BL_CSTNO"].ToString();
// BL_PANNO.Text =  dt.Rows[0]["BL_PANNO"].ToString();
// BL_TINNO.Text =  dt.Rows[0]["BL_TINNO"].ToString();
// BL_MST.Text =  dt.Rows[0]["BL_MST"].ToString();
// BL_ServiceTaxNo.Text =  dt.Rows[0]["BL_ServiceTaxNo"].ToString();
// BL_TANNO.Text =  dt.Rows[0]["BL_TANNO"].ToString();
// BL_ESINO.Text =  dt.Rows[0]["BL_ESINO"].ToString();
// BL_ProfessionalTaxNo.Text =  dt.Rows[0]["BL_ProfessionalTaxNo"].ToString();
// BL_ExciseRegNo.Text =  dt.Rows[0]["BL_ExciseRegNo"].ToString();
// BL_GSTNO.Text =  dt.Rows[0]["BL_GSTNO"].ToString();
// BL_GST_DT.Text =  dt.Rows[0]["BL_GST_DT"].ToString();
// BL_ARNNO.Text =  dt.Rows[0]["BL_ARNNO"].ToString();

