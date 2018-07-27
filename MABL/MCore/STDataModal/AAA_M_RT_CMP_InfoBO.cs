using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.MCore.STDataModal
{
    public class AAA_M_RT_CMP_InfoBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public AAA_M_RT_CMP_InfoBO() { }
        #endregion

        #region Standard Property
        private string _PrimaryKeyName = "M_RT_CMP_ID";
        private string _TableName = "AAA_M_RT_CMP_Info";
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

        private byte _M_RT_CMP_ID;
        private byte _FK_M_RT_CG_ID;
        private byte _MDBSC_CMP_Start_Year_ID;
        private byte _MDBSC_CMP_Previous_Year_ID;
        private byte _MDBSC_CMP_Current_Year_ID;
        private String _MDBSC_CMP_Name;
        private Int16 _MDBSC_CMP_HOBranch_ID;
        private Int16 _MDBSC_Sys_CMP_Branch_ID;
        private Int16 _MDBSC_CMP_Active_Branch_ID;
        private String _MDBSC_CMP_RSN;
        private String _MDBSC_CMP_Perfix;
        private String _MDBSC_CMP_TradingName;
        private String _MDBSC_CMP_PrintSubStr;
        private String _MDBSC_CMP_Print_HeaderTxt;
        private String _MDBSC_CMP_Print_FooterTxt;
        private String _MDBSC_CMP_Logo_Url;
        private String _MDBSC_RowStatus;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;
        private String _MDBSC_CMP_Director1;
        private String _MDBSC_CMP_Director2;
        private String _MDBSC_CMP_Director3;
        private String _MDBSC_CMP_Director4;
        private String _MDBSC_CMP_Director5;
        private String _MDBSC_CMP_Director6;
        private String _MDBSC_CMP_RegType;
        private String _MDBSC_CMP_NatureOfBusiness;
        private String _MDBSC_CMP_Reg_Add1;
        private String _MDBSC_CMP_Reg_Add2;
        private String _MDBSC_CMP_Reg_Add3;
        private String _MDBSC_CMP_Reg_Add4;
        private String _MDBSC_CMP_Shipping_Add1;
        private String _MDBSC_CMP_Shipping_Add2;
        private String _MDBSC_CMP_Shipping_Add3;
        private String _MDBSC_CMP_Shipping_Add4;
        private String _MDBSC_CMP_Primary_Contact_Person;
        private String _MDBSC_CMP_Primary_Contact_Designation;
        private String _MDBSC_CMP_Primary_CP_PhoneNo;
        private String _MDBSC_CMP_Primary_CP_MobileNo;
        private String _MDBSC_CMP_Primary_CP_MobileNo_Alt;
        private String _MDBSC_CMP_Primary_CP_EmailID;
        private String _MDBSC_CMP_Primary_CP_EmailID_Alt;
        private String _MDBSC_CMP_Contact_PhoneNo;
        private String _MDBSC_CMP_Contact_OfficeNo;
        private String _MDBSC_CMP_Contact_FaxNo;
        private String _MDBSC_CMP_Contact_OfficeNo_Alt;
        private String _MDBSC_CMP_Contact_Email_Admin;
        private String _MDBSC_CMP_Contact_Email_Info;
        private String _MDBSC_CMP_Contact_Email_Sales;
        private String _MDBSC_CMP_Contact_Email_Tech;
        private String _MDBSC_CMP_Contact_Website;
        private String _MDBSC_CMP_Reg_Country;
        private String _MDBSC_CMP_Reg_State;
        private String _MDBSC_CMP_Reg_City;
        private String _MDBSC_CMP_Reg_Area;
        private String _MDBSC_CMP_Reg_Pincode;
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

        public byte M_RT_CMP_ID
        {
            get
            {
                return this._M_RT_CMP_ID;
            }
            set
            {
                this._M_RT_CMP_ID = value;
                _UpdateFieldName.Add("M_RT_CMP_ID");
            }
        }
        public byte FK_M_RT_CG_ID
        {
            get
            {
                return this._FK_M_RT_CG_ID;
            }
            set
            {
                this._FK_M_RT_CG_ID = value;
                _UpdateFieldName.Add("FK_M_RT_CG_ID");
            }
        }
        public byte MDBSC_CMP_Start_Year_ID
        {
            get
            {
                return this._MDBSC_CMP_Start_Year_ID;
            }
            set
            {
                this._MDBSC_CMP_Start_Year_ID = value;
                _UpdateFieldName.Add("MDBSC_CMP_Start_Year_ID");
            }
        }
        public byte MDBSC_CMP_Previous_Year_ID
        {
            get
            {
                return this._MDBSC_CMP_Previous_Year_ID;
            }
            set
            {
                this._MDBSC_CMP_Previous_Year_ID = value;
                _UpdateFieldName.Add("MDBSC_CMP_Previous_Year_ID");
            }
        }
        public byte MDBSC_CMP_Current_Year_ID
        {
            get
            {
                return this._MDBSC_CMP_Current_Year_ID;
            }
            set
            {
                this._MDBSC_CMP_Current_Year_ID = value;
                _UpdateFieldName.Add("MDBSC_CMP_Current_Year_ID");
            }
        }
        public String MDBSC_CMP_Name
        {
            get
            {
                return this._MDBSC_CMP_Name;
            }
            set
            {
                this._MDBSC_CMP_Name = value;
                _UpdateFieldName.Add("MDBSC_CMP_Name");
            }
        }
        public Int16 MDBSC_CMP_HOBranch_ID
        {
            get
            {
                return this._MDBSC_CMP_HOBranch_ID;
            }
            set
            {
                this._MDBSC_CMP_HOBranch_ID = value;
                _UpdateFieldName.Add("MDBSC_CMP_HOBranch_ID");
            }
        }
        public Int16 MDBSC_Sys_CMP_Branch_ID
        {
            get
            {
                return this._MDBSC_Sys_CMP_Branch_ID;
            }
            set
            {
                this._MDBSC_Sys_CMP_Branch_ID = value;
                _UpdateFieldName.Add("MDBSC_Sys_CMP_Branch_ID");
            }
        }
        public Int16 MDBSC_CMP_Active_Branch_ID
        {
            get
            {
                return this._MDBSC_CMP_Active_Branch_ID;
            }
            set
            {
                this._MDBSC_CMP_Active_Branch_ID = value;
                _UpdateFieldName.Add("MDBSC_CMP_Active_Branch_ID");
            }
        }
        public String MDBSC_CMP_RSN
        {
            get
            {
                return this._MDBSC_CMP_RSN;
            }
            set
            {
                this._MDBSC_CMP_RSN = value;
                _UpdateFieldName.Add("MDBSC_CMP_RSN");
            }
        }
        public String MDBSC_CMP_Perfix
        {
            get
            {
                return this._MDBSC_CMP_Perfix;
            }
            set
            {
                this._MDBSC_CMP_Perfix = value;
                _UpdateFieldName.Add("MDBSC_CMP_Perfix");
            }
        }
        public String MDBSC_CMP_TradingName
        {
            get
            {
                return this._MDBSC_CMP_TradingName;
            }
            set
            {
                this._MDBSC_CMP_TradingName = value;
                _UpdateFieldName.Add("MDBSC_CMP_TradingName");
            }
        }
        public String MDBSC_CMP_PrintSubStr
        {
            get
            {
                return this._MDBSC_CMP_PrintSubStr;
            }
            set
            {
                this._MDBSC_CMP_PrintSubStr = value;
                _UpdateFieldName.Add("MDBSC_CMP_PrintSubStr");
            }
        }
        public String MDBSC_CMP_Print_HeaderTxt
        {
            get
            {
                return this._MDBSC_CMP_Print_HeaderTxt;
            }
            set
            {
                this._MDBSC_CMP_Print_HeaderTxt = value;
                _UpdateFieldName.Add("MDBSC_CMP_Print_HeaderTxt");
            }
        }
        public String MDBSC_CMP_Print_FooterTxt
        {
            get
            {
                return this._MDBSC_CMP_Print_FooterTxt;
            }
            set
            {
                this._MDBSC_CMP_Print_FooterTxt = value;
                _UpdateFieldName.Add("MDBSC_CMP_Print_FooterTxt");
            }
        }
        public String MDBSC_CMP_Logo_Url
        {
            get
            {
                return this._MDBSC_CMP_Logo_Url;
            }
            set
            {
                this._MDBSC_CMP_Logo_Url = value;
                _UpdateFieldName.Add("MDBSC_CMP_Logo_Url");
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
        public String MDBSC_CMP_Director1
        {
            get
            {
                return this._MDBSC_CMP_Director1;
            }
            set
            {
                this._MDBSC_CMP_Director1 = value;
                _UpdateFieldName.Add("MDBSC_CMP_Director1");
            }
        }
        public String MDBSC_CMP_Director2
        {
            get
            {
                return this._MDBSC_CMP_Director2;
            }
            set
            {
                this._MDBSC_CMP_Director2 = value;
                _UpdateFieldName.Add("MDBSC_CMP_Director2");
            }
        }
        public String MDBSC_CMP_Director3
        {
            get
            {
                return this._MDBSC_CMP_Director3;
            }
            set
            {
                this._MDBSC_CMP_Director3 = value;
                _UpdateFieldName.Add("MDBSC_CMP_Director3");
            }
        }
        public String MDBSC_CMP_Director4
        {
            get
            {
                return this._MDBSC_CMP_Director4;
            }
            set
            {
                this._MDBSC_CMP_Director4 = value;
                _UpdateFieldName.Add("MDBSC_CMP_Director4");
            }
        }
        public String MDBSC_CMP_Director5
        {
            get
            {
                return this._MDBSC_CMP_Director5;
            }
            set
            {
                this._MDBSC_CMP_Director5 = value;
                _UpdateFieldName.Add("MDBSC_CMP_Director5");
            }
        }
        public String MDBSC_CMP_Director6
        {
            get
            {
                return this._MDBSC_CMP_Director6;
            }
            set
            {
                this._MDBSC_CMP_Director6 = value;
                _UpdateFieldName.Add("MDBSC_CMP_Director6");
            }
        }
        public String MDBSC_CMP_RegType
        {
            get
            {
                return this._MDBSC_CMP_RegType;
            }
            set
            {
                this._MDBSC_CMP_RegType = value;
                _UpdateFieldName.Add("MDBSC_CMP_RegType");
            }
        }
        public String MDBSC_CMP_NatureOfBusiness
        {
            get
            {
                return this._MDBSC_CMP_NatureOfBusiness;
            }
            set
            {
                this._MDBSC_CMP_NatureOfBusiness = value;
                _UpdateFieldName.Add("MDBSC_CMP_NatureOfBusiness");
            }
        }
        public String MDBSC_CMP_Reg_Add1
        {
            get
            {
                return this._MDBSC_CMP_Reg_Add1;
            }
            set
            {
                this._MDBSC_CMP_Reg_Add1 = value;
                _UpdateFieldName.Add("MDBSC_CMP_Reg_Add1");
            }
        }
        public String MDBSC_CMP_Reg_Add2
        {
            get
            {
                return this._MDBSC_CMP_Reg_Add2;
            }
            set
            {
                this._MDBSC_CMP_Reg_Add2 = value;
                _UpdateFieldName.Add("MDBSC_CMP_Reg_Add2");
            }
        }
        public String MDBSC_CMP_Reg_Add3
        {
            get
            {
                return this._MDBSC_CMP_Reg_Add3;
            }
            set
            {
                this._MDBSC_CMP_Reg_Add3 = value;
                _UpdateFieldName.Add("MDBSC_CMP_Reg_Add3");
            }
        }
        public String MDBSC_CMP_Reg_Add4
        {
            get
            {
                return this._MDBSC_CMP_Reg_Add4;
            }
            set
            {
                this._MDBSC_CMP_Reg_Add4 = value;
                _UpdateFieldName.Add("MDBSC_CMP_Reg_Add4");
            }
        }
        public String MDBSC_CMP_Shipping_Add1
        {
            get
            {
                return this._MDBSC_CMP_Shipping_Add1;
            }
            set
            {
                this._MDBSC_CMP_Shipping_Add1 = value;
                _UpdateFieldName.Add("MDBSC_CMP_Shipping_Add1");
            }
        }
        public String MDBSC_CMP_Shipping_Add2
        {
            get
            {
                return this._MDBSC_CMP_Shipping_Add2;
            }
            set
            {
                this._MDBSC_CMP_Shipping_Add2 = value;
                _UpdateFieldName.Add("MDBSC_CMP_Shipping_Add2");
            }
        }
        public String MDBSC_CMP_Shipping_Add3
        {
            get
            {
                return this._MDBSC_CMP_Shipping_Add3;
            }
            set
            {
                this._MDBSC_CMP_Shipping_Add3 = value;
                _UpdateFieldName.Add("MDBSC_CMP_Shipping_Add3");
            }
        }
        public String MDBSC_CMP_Shipping_Add4
        {
            get
            {
                return this._MDBSC_CMP_Shipping_Add4;
            }
            set
            {
                this._MDBSC_CMP_Shipping_Add4 = value;
                _UpdateFieldName.Add("MDBSC_CMP_Shipping_Add4");
            }
        }
        public String MDBSC_CMP_Primary_Contact_Person
        {
            get
            {
                return this._MDBSC_CMP_Primary_Contact_Person;
            }
            set
            {
                this._MDBSC_CMP_Primary_Contact_Person = value;
                _UpdateFieldName.Add("MDBSC_CMP_Primary_Contact_Person");
            }
        }
        public String MDBSC_CMP_Primary_Contact_Designation
        {
            get
            {
                return this._MDBSC_CMP_Primary_Contact_Designation;
            }
            set
            {
                this._MDBSC_CMP_Primary_Contact_Designation = value;
                _UpdateFieldName.Add("MDBSC_CMP_Primary_Contact_Designation");
            }
        }
        public String MDBSC_CMP_Primary_CP_PhoneNo
        {
            get
            {
                return this._MDBSC_CMP_Primary_CP_PhoneNo;
            }
            set
            {
                this._MDBSC_CMP_Primary_CP_PhoneNo = value;
                _UpdateFieldName.Add("MDBSC_CMP_Primary_CP_PhoneNo");
            }
        }
        public String MDBSC_CMP_Primary_CP_MobileNo
        {
            get
            {
                return this._MDBSC_CMP_Primary_CP_MobileNo;
            }
            set
            {
                this._MDBSC_CMP_Primary_CP_MobileNo = value;
                _UpdateFieldName.Add("MDBSC_CMP_Primary_CP_MobileNo");
            }
        }
        public String MDBSC_CMP_Primary_CP_MobileNo_Alt
        {
            get
            {
                return this._MDBSC_CMP_Primary_CP_MobileNo_Alt;
            }
            set
            {
                this._MDBSC_CMP_Primary_CP_MobileNo_Alt = value;
                _UpdateFieldName.Add("MDBSC_CMP_Primary_CP_MobileNo_Alt");
            }
        }
        public String MDBSC_CMP_Primary_CP_EmailID
        {
            get
            {
                return this._MDBSC_CMP_Primary_CP_EmailID;
            }
            set
            {
                this._MDBSC_CMP_Primary_CP_EmailID = value;
                _UpdateFieldName.Add("MDBSC_CMP_Primary_CP_EmailID");
            }
        }
        public String MDBSC_CMP_Primary_CP_EmailID_Alt
        {
            get
            {
                return this._MDBSC_CMP_Primary_CP_EmailID_Alt;
            }
            set
            {
                this._MDBSC_CMP_Primary_CP_EmailID_Alt = value;
                _UpdateFieldName.Add("MDBSC_CMP_Primary_CP_EmailID_Alt");
            }
        }
        public String MDBSC_CMP_Contact_PhoneNo
        {
            get
            {
                return this._MDBSC_CMP_Contact_PhoneNo;
            }
            set
            {
                this._MDBSC_CMP_Contact_PhoneNo = value;
                _UpdateFieldName.Add("MDBSC_CMP_Contact_PhoneNo");
            }
        }
        public String MDBSC_CMP_Contact_OfficeNo
        {
            get
            {
                return this._MDBSC_CMP_Contact_OfficeNo;
            }
            set
            {
                this._MDBSC_CMP_Contact_OfficeNo = value;
                _UpdateFieldName.Add("MDBSC_CMP_Contact_OfficeNo");
            }
        }
        public String MDBSC_CMP_Contact_FaxNo
        {
            get
            {
                return this._MDBSC_CMP_Contact_FaxNo;
            }
            set
            {
                this._MDBSC_CMP_Contact_FaxNo = value;
                _UpdateFieldName.Add("MDBSC_CMP_Contact_FaxNo");
            }
        }
        public String MDBSC_CMP_Contact_OfficeNo_Alt
        {
            get
            {
                return this._MDBSC_CMP_Contact_OfficeNo_Alt;
            }
            set
            {
                this._MDBSC_CMP_Contact_OfficeNo_Alt = value;
                _UpdateFieldName.Add("MDBSC_CMP_Contact_OfficeNo_Alt");
            }
        }
        public String MDBSC_CMP_Contact_Email_Admin
        {
            get
            {
                return this._MDBSC_CMP_Contact_Email_Admin;
            }
            set
            {
                this._MDBSC_CMP_Contact_Email_Admin = value;
                _UpdateFieldName.Add("MDBSC_CMP_Contact_Email_Admin");
            }
        }
        public String MDBSC_CMP_Contact_Email_Info
        {
            get
            {
                return this._MDBSC_CMP_Contact_Email_Info;
            }
            set
            {
                this._MDBSC_CMP_Contact_Email_Info = value;
                _UpdateFieldName.Add("MDBSC_CMP_Contact_Email_Info");
            }
        }
        public String MDBSC_CMP_Contact_Email_Sales
        {
            get
            {
                return this._MDBSC_CMP_Contact_Email_Sales;
            }
            set
            {
                this._MDBSC_CMP_Contact_Email_Sales = value;
                _UpdateFieldName.Add("MDBSC_CMP_Contact_Email_Sales");
            }
        }
        public String MDBSC_CMP_Contact_Email_Tech
        {
            get
            {
                return this._MDBSC_CMP_Contact_Email_Tech;
            }
            set
            {
                this._MDBSC_CMP_Contact_Email_Tech = value;
                _UpdateFieldName.Add("MDBSC_CMP_Contact_Email_Tech");
            }
        }
        public String MDBSC_CMP_Contact_Website
        {
            get
            {
                return this._MDBSC_CMP_Contact_Website;
            }
            set
            {
                this._MDBSC_CMP_Contact_Website = value;
                _UpdateFieldName.Add("MDBSC_CMP_Contact_Website");
            }
        }
        public String MDBSC_CMP_Reg_Country
        {
            get
            {
                return this._MDBSC_CMP_Reg_Country;
            }
            set
            {
                this._MDBSC_CMP_Reg_Country = value;
                _UpdateFieldName.Add("MDBSC_CMP_Reg_Country");
            }
        }
        public String MDBSC_CMP_Reg_State
        {
            get
            {
                return this._MDBSC_CMP_Reg_State;
            }
            set
            {
                this._MDBSC_CMP_Reg_State = value;
                _UpdateFieldName.Add("MDBSC_CMP_Reg_State");
            }
        }
        public String MDBSC_CMP_Reg_City
        {
            get
            {
                return this._MDBSC_CMP_Reg_City;
            }
            set
            {
                this._MDBSC_CMP_Reg_City = value;
                _UpdateFieldName.Add("MDBSC_CMP_Reg_City");
            }
        }
        public String MDBSC_CMP_Reg_Area
        {
            get
            {
                return this._MDBSC_CMP_Reg_Area;
            }
            set
            {
                this._MDBSC_CMP_Reg_Area = value;
                _UpdateFieldName.Add("MDBSC_CMP_Reg_Area");
            }
        }
        public String MDBSC_CMP_Reg_Pincode
        {
            get
            {
                return this._MDBSC_CMP_Reg_Pincode;
            }
            set
            {
                this._MDBSC_CMP_Reg_Pincode = value;
                _UpdateFieldName.Add("MDBSC_CMP_Reg_Pincode");
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

        #endregion
        #region Genric Methods
        public string Insert_Update(AAA_M_RT_CMP_InfoBO sObject)
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


        public DataTable List(Int64 M_RT_CMP_ID, string SearchCriteria)
        {
             
            string strSqlString = "";
            try
            {
                 
                MaheshAF18.WebSession.SessionPageLocal ObjSessionData = new MaheshAF18.WebSession.SessionPageLocal();
                strSqlString = "SELECT * FROM v_AAA_M_RT_CMP_Info  Where  M_RT_CMP_ID=0" + ObjSessionData.Company.CompanyID;
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


// ObjBOAT_CMP.M_RT_CMP_ID=ObjBOAT_CMP.M_RT_CMP_ID;
// ObjBOAT_CMP.FK_M_RT_CG_ID=ObjBOAT_CMP.FK_M_RT_CG_ID;
// ObjBOAT_CMP.MDBSC_CMP_Start_Year_ID=ObjBOAT_CMP.MDBSC_CMP_Start_Year_ID;
// ObjBOAT_CMP.MDBSC_CMP_Previous_Year_ID=ObjBOAT_CMP.MDBSC_CMP_Previous_Year_ID;
// ObjBOAT_CMP.MDBSC_CMP_Current_Year_ID=ObjBOAT_CMP.MDBSC_CMP_Current_Year_ID;
// ObjBOAT_CMP.MDBSC_CMP_Name=ObjBOAT_CMP.MDBSC_CMP_Name;
// ObjBOAT_CMP.MDBSC_CMP_HOBranch_ID=ObjBOAT_CMP.MDBSC_CMP_HOBranch_ID;
// ObjBOAT_CMP.MDBSC_Sys_CMP_Branch_ID=ObjBOAT_CMP.MDBSC_Sys_CMP_Branch_ID;
// ObjBOAT_CMP.MDBSC_CMP_Active_Branch_ID=ObjBOAT_CMP.MDBSC_CMP_Active_Branch_ID;
// ObjBOAT_CMP.MDBSC_CMP_RSN=ObjBOAT_CMP.MDBSC_CMP_RSN;
// ObjBOAT_CMP.MDBSC_CMP_Perfix=ObjBOAT_CMP.MDBSC_CMP_Perfix;
// ObjBOAT_CMP.MDBSC_CMP_TradingName=ObjBOAT_CMP.MDBSC_CMP_TradingName;
// ObjBOAT_CMP.MDBSC_CMP_PrintSubStr=ObjBOAT_CMP.MDBSC_CMP_PrintSubStr;
// ObjBOAT_CMP.MDBSC_CMP_Print_HeaderTxt=ObjBOAT_CMP.MDBSC_CMP_Print_HeaderTxt;
// ObjBOAT_CMP.MDBSC_CMP_Print_FooterTxt=ObjBOAT_CMP.MDBSC_CMP_Print_FooterTxt;
// ObjBOAT_CMP.MDBSC_CMP_Logo_Url=ObjBOAT_CMP.MDBSC_CMP_Logo_Url;
// ObjBOAT_CMP.MDBSC_RowStatus=ObjBOAT_CMP.MDBSC_RowStatus;
// ObjBOAT_CMP.MDBSC_RowCreatedByUser_ID=ObjBOAT_CMP.MDBSC_RowCreatedByUser_ID;
// ObjBOAT_CMP.MDBSC_RowCreatedByUserName=ObjBOAT_CMP.MDBSC_RowCreatedByUserName;
// ObjBOAT_CMP.MDBSC_RowCreatedOn_DT=ObjBOAT_CMP.MDBSC_RowCreatedOn_DT;
// ObjBOAT_CMP.MDBSC_RowLupdnByUser_ID=ObjBOAT_CMP.MDBSC_RowLupdnByUser_ID;
// ObjBOAT_CMP.MDBSC_RowLupdnUserName=ObjBOAT_CMP.MDBSC_RowLupdnUserName;
// ObjBOAT_CMP.MDBSC_RowLupdnOn_DT=ObjBOAT_CMP.MDBSC_RowLupdnOn_DT;
// ObjBOAT_CMP.MDBSC_CMP_Director1=ObjBOAT_CMP.MDBSC_CMP_Director1;
// ObjBOAT_CMP.MDBSC_CMP_Director2=ObjBOAT_CMP.MDBSC_CMP_Director2;
// ObjBOAT_CMP.MDBSC_CMP_Director3=ObjBOAT_CMP.MDBSC_CMP_Director3;
// ObjBOAT_CMP.MDBSC_CMP_Director4=ObjBOAT_CMP.MDBSC_CMP_Director4;
// ObjBOAT_CMP.MDBSC_CMP_Director5=ObjBOAT_CMP.MDBSC_CMP_Director5;
// ObjBOAT_CMP.MDBSC_CMP_Director6=ObjBOAT_CMP.MDBSC_CMP_Director6;
// ObjBOAT_CMP.MDBSC_CMP_RegType=ObjBOAT_CMP.MDBSC_CMP_RegType;
// ObjBOAT_CMP.MDBSC_CMP_NatureOfBusiness=ObjBOAT_CMP.MDBSC_CMP_NatureOfBusiness;
// ObjBOAT_CMP.MDBSC_CMP_Reg_Add1=ObjBOAT_CMP.MDBSC_CMP_Reg_Add1;
// ObjBOAT_CMP.MDBSC_CMP_Reg_Add2=ObjBOAT_CMP.MDBSC_CMP_Reg_Add2;
// ObjBOAT_CMP.MDBSC_CMP_Reg_Add3=ObjBOAT_CMP.MDBSC_CMP_Reg_Add3;
// ObjBOAT_CMP.MDBSC_CMP_Reg_Add4=ObjBOAT_CMP.MDBSC_CMP_Reg_Add4;
// ObjBOAT_CMP.MDBSC_CMP_Shipping_Add1=ObjBOAT_CMP.MDBSC_CMP_Shipping_Add1;
// ObjBOAT_CMP.MDBSC_CMP_Shipping_Add2=ObjBOAT_CMP.MDBSC_CMP_Shipping_Add2;
// ObjBOAT_CMP.MDBSC_CMP_Shipping_Add3=ObjBOAT_CMP.MDBSC_CMP_Shipping_Add3;
// ObjBOAT_CMP.MDBSC_CMP_Shipping_Add4=ObjBOAT_CMP.MDBSC_CMP_Shipping_Add4;
// ObjBOAT_CMP.MDBSC_CMP_Primary_Contact_Person=ObjBOAT_CMP.MDBSC_CMP_Primary_Contact_Person;
// ObjBOAT_CMP.MDBSC_CMP_Primary_Contact_Designation=ObjBOAT_CMP.MDBSC_CMP_Primary_Contact_Designation;
// ObjBOAT_CMP.MDBSC_CMP_Primary_CP_PhoneNo=ObjBOAT_CMP.MDBSC_CMP_Primary_CP_PhoneNo;
// ObjBOAT_CMP.MDBSC_CMP_Primary_CP_MobileNo=ObjBOAT_CMP.MDBSC_CMP_Primary_CP_MobileNo;
// ObjBOAT_CMP.MDBSC_CMP_Primary_CP_MobileNo_Alt=ObjBOAT_CMP.MDBSC_CMP_Primary_CP_MobileNo_Alt;
// ObjBOAT_CMP.MDBSC_CMP_Primary_CP_EmailID=ObjBOAT_CMP.MDBSC_CMP_Primary_CP_EmailID;
// ObjBOAT_CMP.MDBSC_CMP_Primary_CP_EmailID_Alt=ObjBOAT_CMP.MDBSC_CMP_Primary_CP_EmailID_Alt;
// ObjBOAT_CMP.MDBSC_CMP_Contact_PhoneNo=ObjBOAT_CMP.MDBSC_CMP_Contact_PhoneNo;
// ObjBOAT_CMP.MDBSC_CMP_Contact_OfficeNo=ObjBOAT_CMP.MDBSC_CMP_Contact_OfficeNo;
// ObjBOAT_CMP.MDBSC_CMP_Contact_FaxNo=ObjBOAT_CMP.MDBSC_CMP_Contact_FaxNo;
// ObjBOAT_CMP.MDBSC_CMP_Contact_OfficeNo_Alt=ObjBOAT_CMP.MDBSC_CMP_Contact_OfficeNo_Alt;
// ObjBOAT_CMP.MDBSC_CMP_Contact_Email_Admin=ObjBOAT_CMP.MDBSC_CMP_Contact_Email_Admin;
// ObjBOAT_CMP.MDBSC_CMP_Contact_Email_Info=ObjBOAT_CMP.MDBSC_CMP_Contact_Email_Info;
// ObjBOAT_CMP.MDBSC_CMP_Contact_Email_Sales=ObjBOAT_CMP.MDBSC_CMP_Contact_Email_Sales;
// ObjBOAT_CMP.MDBSC_CMP_Contact_Email_Tech=ObjBOAT_CMP.MDBSC_CMP_Contact_Email_Tech;
// ObjBOAT_CMP.MDBSC_CMP_Contact_Website=ObjBOAT_CMP.MDBSC_CMP_Contact_Website;
// ObjBOAT_CMP.MDBSC_CMP_Reg_Country=ObjBOAT_CMP.MDBSC_CMP_Reg_Country;
// ObjBOAT_CMP.MDBSC_CMP_Reg_State=ObjBOAT_CMP.MDBSC_CMP_Reg_State;
// ObjBOAT_CMP.MDBSC_CMP_Reg_City=ObjBOAT_CMP.MDBSC_CMP_Reg_City;
// ObjBOAT_CMP.MDBSC_CMP_Reg_Area=ObjBOAT_CMP.MDBSC_CMP_Reg_Area;
// ObjBOAT_CMP.MDBSC_CMP_Reg_Pincode=ObjBOAT_CMP.MDBSC_CMP_Reg_Pincode;
// ObjBOAT_CMP.BL_VATNO=ObjBOAT_CMP.BL_VATNO;
// ObjBOAT_CMP.BL_CSTNO=ObjBOAT_CMP.BL_CSTNO;
// ObjBOAT_CMP.BL_PANNO=ObjBOAT_CMP.BL_PANNO;
// ObjBOAT_CMP.BL_TINNO=ObjBOAT_CMP.BL_TINNO;
// ObjBOAT_CMP.BL_MST=ObjBOAT_CMP.BL_MST;
// ObjBOAT_CMP.BL_ServiceTaxNo=ObjBOAT_CMP.BL_ServiceTaxNo;
// ObjBOAT_CMP.BL_TANNO=ObjBOAT_CMP.BL_TANNO;
// ObjBOAT_CMP.BL_ESINO=ObjBOAT_CMP.BL_ESINO;
// ObjBOAT_CMP.BL_ProfessionalTaxNo=ObjBOAT_CMP.BL_ProfessionalTaxNo;
// ObjBOAT_CMP.BL_ExciseRegNo=ObjBOAT_CMP.BL_ExciseRegNo;
// ObjBOAT_CMP.BL_GSTNO=ObjBOAT_CMP.BL_GSTNO;
// ObjBOAT_CMP.BL_GST_DT=ObjBOAT_CMP.BL_GST_DT;



// M_RT_CMP_ID.Text = "";
// FK_M_RT_CG_ID.Text = "";
// MDBSC_CMP_Start_Year_ID.Text = "";
// MDBSC_CMP_Previous_Year_ID.Text = "";
// MDBSC_CMP_Current_Year_ID.Text = "";
// MDBSC_CMP_Name.Text = "";
// MDBSC_CMP_HOBranch_ID.Text = "";
// MDBSC_Sys_CMP_Branch_ID.Text = "";
// MDBSC_CMP_Active_Branch_ID.Text = "";
// MDBSC_CMP_RSN.Text = "";
// MDBSC_CMP_Perfix.Text = "";
// MDBSC_CMP_TradingName.Text = "";
// MDBSC_CMP_PrintSubStr.Text = "";
// MDBSC_CMP_Print_HeaderTxt.Text = "";
// MDBSC_CMP_Print_FooterTxt.Text = "";
// MDBSC_CMP_Logo_Url.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";
// MDBSC_CMP_Director1.Text = "";
// MDBSC_CMP_Director2.Text = "";
// MDBSC_CMP_Director3.Text = "";
// MDBSC_CMP_Director4.Text = "";
// MDBSC_CMP_Director5.Text = "";
// MDBSC_CMP_Director6.Text = "";
// MDBSC_CMP_RegType.Text = "";
// MDBSC_CMP_NatureOfBusiness.Text = "";
// MDBSC_CMP_Reg_Add1.Text = "";
// MDBSC_CMP_Reg_Add2.Text = "";
// MDBSC_CMP_Reg_Add3.Text = "";
// MDBSC_CMP_Reg_Add4.Text = "";
// MDBSC_CMP_Shipping_Add1.Text = "";
// MDBSC_CMP_Shipping_Add2.Text = "";
// MDBSC_CMP_Shipping_Add3.Text = "";
// MDBSC_CMP_Shipping_Add4.Text = "";
// MDBSC_CMP_Primary_Contact_Person.Text = "";
// MDBSC_CMP_Primary_Contact_Designation.Text = "";
// MDBSC_CMP_Primary_CP_PhoneNo.Text = "";
// MDBSC_CMP_Primary_CP_MobileNo.Text = "";
// MDBSC_CMP_Primary_CP_MobileNo_Alt.Text = "";
// MDBSC_CMP_Primary_CP_EmailID.Text = "";
// MDBSC_CMP_Primary_CP_EmailID_Alt.Text = "";
// MDBSC_CMP_Contact_PhoneNo.Text = "";
// MDBSC_CMP_Contact_OfficeNo.Text = "";
// MDBSC_CMP_Contact_FaxNo.Text = "";
// MDBSC_CMP_Contact_OfficeNo_Alt.Text = "";
// MDBSC_CMP_Contact_Email_Admin.Text = "";
// MDBSC_CMP_Contact_Email_Info.Text = "";
// MDBSC_CMP_Contact_Email_Sales.Text = "";
// MDBSC_CMP_Contact_Email_Tech.Text = "";
// MDBSC_CMP_Contact_Website.Text = "";
// MDBSC_CMP_Reg_Country.Text = "";
// MDBSC_CMP_Reg_State.Text = "";
// MDBSC_CMP_Reg_City.Text = "";
// MDBSC_CMP_Reg_Area.Text = "";
// MDBSC_CMP_Reg_Pincode.Text = "";
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



// ObjBOAT_CMP.M_RT_CMP_ID=M_RT_CMP_ID.Text ;
// ObjBOAT_CMP.FK_M_RT_CG_ID=FK_M_RT_CG_ID.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Start_Year_ID=MDBSC_CMP_Start_Year_ID.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Previous_Year_ID=MDBSC_CMP_Previous_Year_ID.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Current_Year_ID=MDBSC_CMP_Current_Year_ID.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Name=MDBSC_CMP_Name.Text ;
// ObjBOAT_CMP.MDBSC_CMP_HOBranch_ID=MDBSC_CMP_HOBranch_ID.Text ;
// ObjBOAT_CMP.MDBSC_Sys_CMP_Branch_ID=MDBSC_Sys_CMP_Branch_ID.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Active_Branch_ID=MDBSC_CMP_Active_Branch_ID.Text ;
// ObjBOAT_CMP.MDBSC_CMP_RSN=MDBSC_CMP_RSN.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Perfix=MDBSC_CMP_Perfix.Text ;
// ObjBOAT_CMP.MDBSC_CMP_TradingName=MDBSC_CMP_TradingName.Text ;
// ObjBOAT_CMP.MDBSC_CMP_PrintSubStr=MDBSC_CMP_PrintSubStr.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Print_HeaderTxt=MDBSC_CMP_Print_HeaderTxt.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Print_FooterTxt=MDBSC_CMP_Print_FooterTxt.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Logo_Url=MDBSC_CMP_Logo_Url.Text ;
// ObjBOAT_CMP.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjBOAT_CMP.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjBOAT_CMP.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjBOAT_CMP.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjBOAT_CMP.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjBOAT_CMP.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjBOAT_CMP.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Director1=MDBSC_CMP_Director1.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Director2=MDBSC_CMP_Director2.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Director3=MDBSC_CMP_Director3.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Director4=MDBSC_CMP_Director4.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Director5=MDBSC_CMP_Director5.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Director6=MDBSC_CMP_Director6.Text ;
// ObjBOAT_CMP.MDBSC_CMP_RegType=MDBSC_CMP_RegType.Text ;
// ObjBOAT_CMP.MDBSC_CMP_NatureOfBusiness=MDBSC_CMP_NatureOfBusiness.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Reg_Add1=MDBSC_CMP_Reg_Add1.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Reg_Add2=MDBSC_CMP_Reg_Add2.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Reg_Add3=MDBSC_CMP_Reg_Add3.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Reg_Add4=MDBSC_CMP_Reg_Add4.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Shipping_Add1=MDBSC_CMP_Shipping_Add1.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Shipping_Add2=MDBSC_CMP_Shipping_Add2.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Shipping_Add3=MDBSC_CMP_Shipping_Add3.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Shipping_Add4=MDBSC_CMP_Shipping_Add4.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Primary_Contact_Person=MDBSC_CMP_Primary_Contact_Person.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Primary_Contact_Designation=MDBSC_CMP_Primary_Contact_Designation.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Primary_CP_PhoneNo=MDBSC_CMP_Primary_CP_PhoneNo.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Primary_CP_MobileNo=MDBSC_CMP_Primary_CP_MobileNo.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Primary_CP_MobileNo_Alt=MDBSC_CMP_Primary_CP_MobileNo_Alt.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Primary_CP_EmailID=MDBSC_CMP_Primary_CP_EmailID.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Primary_CP_EmailID_Alt=MDBSC_CMP_Primary_CP_EmailID_Alt.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Contact_PhoneNo=MDBSC_CMP_Contact_PhoneNo.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Contact_OfficeNo=MDBSC_CMP_Contact_OfficeNo.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Contact_FaxNo=MDBSC_CMP_Contact_FaxNo.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Contact_OfficeNo_Alt=MDBSC_CMP_Contact_OfficeNo_Alt.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Contact_Email_Admin=MDBSC_CMP_Contact_Email_Admin.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Contact_Email_Info=MDBSC_CMP_Contact_Email_Info.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Contact_Email_Sales=MDBSC_CMP_Contact_Email_Sales.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Contact_Email_Tech=MDBSC_CMP_Contact_Email_Tech.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Contact_Website=MDBSC_CMP_Contact_Website.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Reg_Country=MDBSC_CMP_Reg_Country.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Reg_State=MDBSC_CMP_Reg_State.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Reg_City=MDBSC_CMP_Reg_City.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Reg_Area=MDBSC_CMP_Reg_Area.Text ;
// ObjBOAT_CMP.MDBSC_CMP_Reg_Pincode=MDBSC_CMP_Reg_Pincode.Text ;
// ObjBOAT_CMP.BL_VATNO=BL_VATNO.Text ;
// ObjBOAT_CMP.BL_CSTNO=BL_CSTNO.Text ;
// ObjBOAT_CMP.BL_PANNO=BL_PANNO.Text ;
// ObjBOAT_CMP.BL_TINNO=BL_TINNO.Text ;
// ObjBOAT_CMP.BL_MST=BL_MST.Text ;
// ObjBOAT_CMP.BL_ServiceTaxNo=BL_ServiceTaxNo.Text ;
// ObjBOAT_CMP.BL_TANNO=BL_TANNO.Text ;
// ObjBOAT_CMP.BL_ESINO=BL_ESINO.Text ;
// ObjBOAT_CMP.BL_ProfessionalTaxNo=BL_ProfessionalTaxNo.Text ;
// ObjBOAT_CMP.BL_ExciseRegNo=BL_ExciseRegNo.Text ;
// ObjBOAT_CMP.BL_GSTNO=BL_GSTNO.Text ;
// ObjBOAT_CMP.BL_GST_DT=BL_GST_DT.Text ;



// M_RT_CMP_ID.Text =  dt.Rows[0]["M_RT_CMP_ID"].ToString();
// FK_M_RT_CG_ID.Text =  dt.Rows[0]["FK_M_RT_CG_ID"].ToString();
// MDBSC_CMP_Start_Year_ID.Text =  dt.Rows[0]["MDBSC_CMP_Start_Year_ID"].ToString();
// MDBSC_CMP_Previous_Year_ID.Text =  dt.Rows[0]["MDBSC_CMP_Previous_Year_ID"].ToString();
// MDBSC_CMP_Current_Year_ID.Text =  dt.Rows[0]["MDBSC_CMP_Current_Year_ID"].ToString();
// MDBSC_CMP_Name.Text =  dt.Rows[0]["MDBSC_CMP_Name"].ToString();
// MDBSC_CMP_HOBranch_ID.Text =  dt.Rows[0]["MDBSC_CMP_HOBranch_ID"].ToString();
// MDBSC_Sys_CMP_Branch_ID.Text =  dt.Rows[0]["MDBSC_Sys_CMP_Branch_ID"].ToString();
// MDBSC_CMP_Active_Branch_ID.Text =  dt.Rows[0]["MDBSC_CMP_Active_Branch_ID"].ToString();
// MDBSC_CMP_RSN.Text =  dt.Rows[0]["MDBSC_CMP_RSN"].ToString();
// MDBSC_CMP_Perfix.Text =  dt.Rows[0]["MDBSC_CMP_Perfix"].ToString();
// MDBSC_CMP_TradingName.Text =  dt.Rows[0]["MDBSC_CMP_TradingName"].ToString();
// MDBSC_CMP_PrintSubStr.Text =  dt.Rows[0]["MDBSC_CMP_PrintSubStr"].ToString();
// MDBSC_CMP_Print_HeaderTxt.Text =  dt.Rows[0]["MDBSC_CMP_Print_HeaderTxt"].ToString();
// MDBSC_CMP_Print_FooterTxt.Text =  dt.Rows[0]["MDBSC_CMP_Print_FooterTxt"].ToString();
// MDBSC_CMP_Logo_Url.Text =  dt.Rows[0]["MDBSC_CMP_Logo_Url"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
// MDBSC_CMP_Director1.Text =  dt.Rows[0]["MDBSC_CMP_Director1"].ToString();
// MDBSC_CMP_Director2.Text =  dt.Rows[0]["MDBSC_CMP_Director2"].ToString();
// MDBSC_CMP_Director3.Text =  dt.Rows[0]["MDBSC_CMP_Director3"].ToString();
// MDBSC_CMP_Director4.Text =  dt.Rows[0]["MDBSC_CMP_Director4"].ToString();
// MDBSC_CMP_Director5.Text =  dt.Rows[0]["MDBSC_CMP_Director5"].ToString();
// MDBSC_CMP_Director6.Text =  dt.Rows[0]["MDBSC_CMP_Director6"].ToString();
// MDBSC_CMP_RegType.Text =  dt.Rows[0]["MDBSC_CMP_RegType"].ToString();
// MDBSC_CMP_NatureOfBusiness.Text =  dt.Rows[0]["MDBSC_CMP_NatureOfBusiness"].ToString();
// MDBSC_CMP_Reg_Add1.Text =  dt.Rows[0]["MDBSC_CMP_Reg_Add1"].ToString();
// MDBSC_CMP_Reg_Add2.Text =  dt.Rows[0]["MDBSC_CMP_Reg_Add2"].ToString();
// MDBSC_CMP_Reg_Add3.Text =  dt.Rows[0]["MDBSC_CMP_Reg_Add3"].ToString();
// MDBSC_CMP_Reg_Add4.Text =  dt.Rows[0]["MDBSC_CMP_Reg_Add4"].ToString();
// MDBSC_CMP_Shipping_Add1.Text =  dt.Rows[0]["MDBSC_CMP_Shipping_Add1"].ToString();
// MDBSC_CMP_Shipping_Add2.Text =  dt.Rows[0]["MDBSC_CMP_Shipping_Add2"].ToString();
// MDBSC_CMP_Shipping_Add3.Text =  dt.Rows[0]["MDBSC_CMP_Shipping_Add3"].ToString();
// MDBSC_CMP_Shipping_Add4.Text =  dt.Rows[0]["MDBSC_CMP_Shipping_Add4"].ToString();
// MDBSC_CMP_Primary_Contact_Person.Text =  dt.Rows[0]["MDBSC_CMP_Primary_Contact_Person"].ToString();
// MDBSC_CMP_Primary_Contact_Designation.Text =  dt.Rows[0]["MDBSC_CMP_Primary_Contact_Designation"].ToString();
// MDBSC_CMP_Primary_CP_PhoneNo.Text =  dt.Rows[0]["MDBSC_CMP_Primary_CP_PhoneNo"].ToString();
// MDBSC_CMP_Primary_CP_MobileNo.Text =  dt.Rows[0]["MDBSC_CMP_Primary_CP_MobileNo"].ToString();
// MDBSC_CMP_Primary_CP_MobileNo_Alt.Text =  dt.Rows[0]["MDBSC_CMP_Primary_CP_MobileNo_Alt"].ToString();
// MDBSC_CMP_Primary_CP_EmailID.Text =  dt.Rows[0]["MDBSC_CMP_Primary_CP_EmailID"].ToString();
// MDBSC_CMP_Primary_CP_EmailID_Alt.Text =  dt.Rows[0]["MDBSC_CMP_Primary_CP_EmailID_Alt"].ToString();
// MDBSC_CMP_Contact_PhoneNo.Text =  dt.Rows[0]["MDBSC_CMP_Contact_PhoneNo"].ToString();
// MDBSC_CMP_Contact_OfficeNo.Text =  dt.Rows[0]["MDBSC_CMP_Contact_OfficeNo"].ToString();
// MDBSC_CMP_Contact_FaxNo.Text =  dt.Rows[0]["MDBSC_CMP_Contact_FaxNo"].ToString();
// MDBSC_CMP_Contact_OfficeNo_Alt.Text =  dt.Rows[0]["MDBSC_CMP_Contact_OfficeNo_Alt"].ToString();
// MDBSC_CMP_Contact_Email_Admin.Text =  dt.Rows[0]["MDBSC_CMP_Contact_Email_Admin"].ToString();
// MDBSC_CMP_Contact_Email_Info.Text =  dt.Rows[0]["MDBSC_CMP_Contact_Email_Info"].ToString();
// MDBSC_CMP_Contact_Email_Sales.Text =  dt.Rows[0]["MDBSC_CMP_Contact_Email_Sales"].ToString();
// MDBSC_CMP_Contact_Email_Tech.Text =  dt.Rows[0]["MDBSC_CMP_Contact_Email_Tech"].ToString();
// MDBSC_CMP_Contact_Website.Text =  dt.Rows[0]["MDBSC_CMP_Contact_Website"].ToString();
// MDBSC_CMP_Reg_Country.Text =  dt.Rows[0]["MDBSC_CMP_Reg_Country"].ToString();
// MDBSC_CMP_Reg_State.Text =  dt.Rows[0]["MDBSC_CMP_Reg_State"].ToString();
// MDBSC_CMP_Reg_City.Text =  dt.Rows[0]["MDBSC_CMP_Reg_City"].ToString();
// MDBSC_CMP_Reg_Area.Text =  dt.Rows[0]["MDBSC_CMP_Reg_Area"].ToString();
// MDBSC_CMP_Reg_Pincode.Text =  dt.Rows[0]["MDBSC_CMP_Reg_Pincode"].ToString();
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

