using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal
{
    public class M_AT_Mst_CustomerBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public M_AT_Mst_CustomerBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "M_Cust_ID";
        private string _TableName = "M_AT_Mst_Customer";
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

        private Int64 _M_Cust_ID;
        private Int64 _Fk_Company_ID;
        private Int64 _Fk_Branch_ID;
        private Int64 _Fk_Year_ID;
        private String _MCust_Code;
        private String _MCust_Name;
        private String _MCust_DisplayName;
        private String _MCust_TradeName;
        private String _MCust_Reg_Add1;
        private String _MCust_Reg_Add2;
        private String _MCust_Reg_Add3;
        private String _MCust_Reg_Pincode;
        private Int32 _MCust_CreditDays;
        private String _MCust_Reg_Area;
        private String _MCust_Reg_City;
        private Int64 _MCust_Reg_State_ID;
        private String _MCust_Reg_Country;
        private String _MCust_ShippTo_CompanyName;
        private String _MCust_ShippTo_ContactPerson;
        private String _MCust_ShippTo_CP_MobileNo;
        private String _MCust_ShippTo_Add1;
        private String _MCust_ShippTo_Add2;
        private String _MCust_ShippTo_Add3;
        private String _MCust_ShippTo_Pincode;
        private String _MCust_ShippTo_Area;
        private String _MCust_ShippTo_City;
        private Int64 _MCust_ShippTo_State_ID;
        private String _MCust_ShippTo_Country;
        private String _MCust_ShippTo_PANNO;
        private String _MCust_ShippTo_GSTNO;
        private String _MCust_ShippTo_ARNO;
        private String _MCust_BankName;
        private String _MCust_AccountHolderName;
        private String _MCust_IFSCNo;
        private String _MCust_AccountNo;
        private String _MCust_BankBranch;
        private String _MDBSC_RowStatus;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;
        private String _MCust_RegType;
        private String _MCust_NatureOfBusiness;
        private String _MCust_Primary_Contact_Designation;
        private String _MCust_Primary_Contact_Person;
        private String _MCust_Primary_CP_PhoneNo;
        private String _MCust_Primary_CP_MobileNo;
        private String _MCust_Primary_CP_MobileNo_Alt;
        private String _MCust_Primary_CP_EmailID;
        private String _MCust_Primary_CP_EmailID_Alt;
        private String _MCust_Contact_OfficeNo1;
        private String _MCust_Contact_OfficeNo2;
        private String _MCust_Contact_OfficeNo_Alt;
        private String _MCust_Contact_FaxNo;
        private String _MCust_Contact_Email_Admin;
        private String _MCust_Contact_Email_Info;
        private String _MCust_Contact_Email_Sales;
        private String _MCust_Contact_Email_Tech;
        private String _MCust_Contact_Website;
        private String _MCust_BL_VATNO;
        private String _MCust_BL_CSTNO;
        private String _MCust_BL_TINNO;
        private String _MCust_BL_ServiceTaxNo;
        private String _MCust_BL_ExciseRegNo;
        private String _MCust_BL_PANNO;
        private String _MCust_BL_GSTNO;
        private String _MCust_BL_ARNO;

        public Int64 M_Cust_ID
        {
            get
            {
                return this._M_Cust_ID;
            }
            set
            {
                this._M_Cust_ID = value;
                _UpdateFieldName.Add("M_Cust_ID");
            }
        }
        public Int64 Fk_Company_ID
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
        public Int64 Fk_Branch_ID
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
        public Int64 Fk_Year_ID
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
        public String MCust_Code
        {
            get
            {
                return this._MCust_Code;
            }
            set
            {
                this._MCust_Code = value;
                _UpdateFieldName.Add("MCust_Code");
            }
        }
        public String MCust_Name
        {
            get
            {
                return this._MCust_Name;
            }
            set
            {
                this._MCust_Name = value;
                _UpdateFieldName.Add("MCust_Name");
            }
        }
        public String MCust_DisplayName
        {
            get
            {
                return this._MCust_DisplayName;
            }
            set
            {
                this._MCust_DisplayName = value;
                _UpdateFieldName.Add("MCust_DisplayName");
            }
        }
        public String MCust_TradeName
        {
            get
            {
                return this._MCust_TradeName;
            }
            set
            {
                this._MCust_TradeName = value;
                _UpdateFieldName.Add("MCust_TradeName");
            }
        }
        public String MCust_Reg_Add1
        {
            get
            {
                return this._MCust_Reg_Add1;
            }
            set
            {
                this._MCust_Reg_Add1 = value;
                _UpdateFieldName.Add("MCust_Reg_Add1");
            }
        }
        public String MCust_Reg_Add2
        {
            get
            {
                return this._MCust_Reg_Add2;
            }
            set
            {
                this._MCust_Reg_Add2 = value;
                _UpdateFieldName.Add("MCust_Reg_Add2");
            }
        }
        public String MCust_Reg_Add3
        {
            get
            {
                return this._MCust_Reg_Add3;
            }
            set
            {
                this._MCust_Reg_Add3 = value;
                _UpdateFieldName.Add("MCust_Reg_Add3");
            }
        }
        public String MCust_Reg_Pincode
        {
            get
            {
                return this._MCust_Reg_Pincode;
            }
            set
            {
                this._MCust_Reg_Pincode = value;
                _UpdateFieldName.Add("MCust_Reg_Pincode");
            }
        }
        public String MCust_Reg_Area
        {
            get
            {
                return this._MCust_Reg_Area;
            }
            set
            {
                this._MCust_Reg_Area = value;
                _UpdateFieldName.Add("MCust_Reg_Area");
            }
        }
        public String MCust_Reg_City
        {
            get
            {
                return this._MCust_Reg_City;
            }
            set
            {
                this._MCust_Reg_City = value;
                _UpdateFieldName.Add("MCust_Reg_City");
            }
        }
        public Int64 MCust_Reg_State_ID
        {
            get
            {
                return this._MCust_Reg_State_ID;
            }
            set
            {
                this._MCust_Reg_State_ID = value;
                _UpdateFieldName.Add("MCust_Reg_State_ID");
            }
        }
        public String MCust_Reg_Country
        {
            get
            {
                return this._MCust_Reg_Country;
            }
            set
            {
                this._MCust_Reg_Country = value;
                _UpdateFieldName.Add("MCust_Reg_Country");
            }
        }
        public String MCust_ShippTo_CompanyName
        {
            get
            {
                return this._MCust_ShippTo_CompanyName;
            }
            set
            {
                this._MCust_ShippTo_CompanyName = value;
                _UpdateFieldName.Add("MCust_ShippTo_CompanyName");
            }
        }
        public String MCust_ShippTo_ContactPerson
        {
            get
            {
                return this._MCust_ShippTo_ContactPerson;
            }
            set
            {
                this._MCust_ShippTo_ContactPerson = value;
                _UpdateFieldName.Add("MCust_ShippTo_ContactPerson");
            }
        }
        public String MCust_ShippTo_CP_MobileNo
        {
            get
            {
                return this._MCust_ShippTo_CP_MobileNo;
            }
            set
            {
                this._MCust_ShippTo_CP_MobileNo = value;
                _UpdateFieldName.Add("MCust_ShippTo_CP_MobileNo");
            }
        }
        public String MCust_ShippTo_Add1
        {
            get
            {
                return this._MCust_ShippTo_Add1;
            }
            set
            {
                this._MCust_ShippTo_Add1 = value;
                _UpdateFieldName.Add("MCust_ShippTo_Add1");
            }
        }
        public String MCust_ShippTo_Add2
        {
            get
            {
                return this._MCust_ShippTo_Add2;
            }
            set
            {
                this._MCust_ShippTo_Add2 = value;
                _UpdateFieldName.Add("MCust_ShippTo_Add2");
            }
        }
        public String MCust_ShippTo_Add3
        {
            get
            {
                return this._MCust_ShippTo_Add3;
            }
            set
            {
                this._MCust_ShippTo_Add3 = value;
                _UpdateFieldName.Add("MCust_ShippTo_Add3");
            }
        }
        public String MCust_ShippTo_Pincode
        {
            get
            {
                return this._MCust_ShippTo_Pincode;
            }
            set
            {
                this._MCust_ShippTo_Pincode = value;
                _UpdateFieldName.Add("MCust_ShippTo_Pincode");
            }
        }
        public String MCust_ShippTo_Area
        {
            get
            {
                return this._MCust_ShippTo_Area;
            }
            set
            {
                this._MCust_ShippTo_Area = value;
                _UpdateFieldName.Add("MCust_ShippTo_Area");
            }
        }
        public String MCust_ShippTo_City
        {
            get
            {
                return this._MCust_ShippTo_City;
            }
            set
            {
                this._MCust_ShippTo_City = value;
                _UpdateFieldName.Add("MCust_ShippTo_City");
            }
        }
        public Int64 MCust_ShippTo_State_ID
        {
            get
            {
                return this._MCust_ShippTo_State_ID;
            }
            set
            {
                this._MCust_ShippTo_State_ID = value;
                _UpdateFieldName.Add("MCust_ShippTo_State_ID");
            }
        }
        public String MCust_ShippTo_Country
        {
            get
            {
                return this._MCust_ShippTo_Country;
            }
            set
            {
                this._MCust_ShippTo_Country = value;
                _UpdateFieldName.Add("MCust_ShippTo_Country");
            }
        }
        public String MCust_ShippTo_PANNO
        {
            get
            {
                return this._MCust_ShippTo_PANNO;
            }
            set
            {
                this._MCust_ShippTo_PANNO = value;
                _UpdateFieldName.Add("MCust_ShippTo_PANNO");
            }
        }
        public String MCust_ShippTo_GSTNO
        {
            get
            {
                return this._MCust_ShippTo_GSTNO;
            }
            set
            {
                this._MCust_ShippTo_GSTNO = value;
                _UpdateFieldName.Add("MCust_ShippTo_GSTNO");
            }
        }
        public String MCust_ShippTo_ARNO
        {
            get
            {
                return this._MCust_ShippTo_ARNO;
            }
            set
            {
                this._MCust_ShippTo_ARNO = value;
                _UpdateFieldName.Add("MCust_ShippTo_ARNO");
            }
        }
        public String MCust_BankName
        {
            get
            {
                return this._MCust_BankName;
            }
            set
            {
                this._MCust_BankName = value;
                _UpdateFieldName.Add("MCust_BankName");
            }
        }
        public String MCust_AccountHolderName
        {
            get
            {
                return this._MCust_AccountHolderName;
            }
            set
            {
                this._MCust_AccountHolderName = value;
                _UpdateFieldName.Add("MCust_AccountHolderName");
            }
        }
        public String MCust_IFSCNo
        {
            get
            {
                return this._MCust_IFSCNo;
            }
            set
            {
                this._MCust_IFSCNo = value;
                _UpdateFieldName.Add("MCust_IFSCNo");
            }
        }
        public String MCust_AccountNo
        {
            get
            {
                return this._MCust_AccountNo;
            }
            set
            {
                this._MCust_AccountNo = value;
                _UpdateFieldName.Add("MCust_AccountNo");
            }
        }
        public String MCust_BankBranch
        {
            get
            {
                return this._MCust_BankBranch;
            }
            set
            {
                this._MCust_BankBranch = value;
                _UpdateFieldName.Add("MCust_BankBranch");
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

        public Int32 MCust_CreditDays
        {
            get
            {
                return this._MCust_CreditDays;
            }
            set
            {
                this._MCust_CreditDays = value;
                _UpdateFieldName.Add("MCust_CreditDays");
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
        public String MCust_RegType
        {
            get
            {
                return this._MCust_RegType;
            }
            set
            {
                this._MCust_RegType = value;
                _UpdateFieldName.Add("MCust_RegType");
            }
        }
        public String MCust_NatureOfBusiness
        {
            get
            {
                return this._MCust_NatureOfBusiness;
            }
            set
            {
                this._MCust_NatureOfBusiness = value;
                _UpdateFieldName.Add("MCust_NatureOfBusiness");
            }
        }
        public String MCust_Primary_Contact_Designation
        {
            get
            {
                return this._MCust_Primary_Contact_Designation;
            }
            set
            {
                this._MCust_Primary_Contact_Designation = value;
                _UpdateFieldName.Add("MCust_Primary_Contact_Designation");
            }
        }
        public String MCust_Primary_Contact_Person
        {
            get
            {
                return this._MCust_Primary_Contact_Person;
            }
            set
            {
                this._MCust_Primary_Contact_Person = value;
                _UpdateFieldName.Add("MCust_Primary_Contact_Person");
            }
        }
        public String MCust_Primary_CP_PhoneNo
        {
            get
            {
                return this._MCust_Primary_CP_PhoneNo;
            }
            set
            {
                this._MCust_Primary_CP_PhoneNo = value;
                _UpdateFieldName.Add("MCust_Primary_CP_PhoneNo");
            }
        }
        public String MCust_Primary_CP_MobileNo
        {
            get
            {
                return this._MCust_Primary_CP_MobileNo;
            }
            set
            {
                this._MCust_Primary_CP_MobileNo = value;
                _UpdateFieldName.Add("MCust_Primary_CP_MobileNo");
            }
        }
        public String MCust_Primary_CP_MobileNo_Alt
        {
            get
            {
                return this._MCust_Primary_CP_MobileNo_Alt;
            }
            set
            {
                this._MCust_Primary_CP_MobileNo_Alt = value;
                _UpdateFieldName.Add("MCust_Primary_CP_MobileNo_Alt");
            }
        }
        public String MCust_Primary_CP_EmailID
        {
            get
            {
                return this._MCust_Primary_CP_EmailID;
            }
            set
            {
                this._MCust_Primary_CP_EmailID = value;
                _UpdateFieldName.Add("MCust_Primary_CP_EmailID");
            }
        }
        public String MCust_Primary_CP_EmailID_Alt
        {
            get
            {
                return this._MCust_Primary_CP_EmailID_Alt;
            }
            set
            {
                this._MCust_Primary_CP_EmailID_Alt = value;
                _UpdateFieldName.Add("MCust_Primary_CP_EmailID_Alt");
            }
        }
        public String MCust_Contact_OfficeNo1
        {
            get
            {
                return this._MCust_Contact_OfficeNo1;
            }
            set
            {
                this._MCust_Contact_OfficeNo1 = value;
                _UpdateFieldName.Add("MCust_Contact_OfficeNo1");
            }
        }
        public String MCust_Contact_OfficeNo2
        {
            get
            {
                return this._MCust_Contact_OfficeNo2;
            }
            set
            {
                this._MCust_Contact_OfficeNo2 = value;
                _UpdateFieldName.Add("MCust_Contact_OfficeNo2");
            }
        }
        public String MCust_Contact_OfficeNo_Alt
        {
            get
            {
                return this._MCust_Contact_OfficeNo_Alt;
            }
            set
            {
                this._MCust_Contact_OfficeNo_Alt = value;
                _UpdateFieldName.Add("MCust_Contact_OfficeNo_Alt");
            }
        }
        public String MCust_Contact_FaxNo
        {
            get
            {
                return this._MCust_Contact_FaxNo;
            }
            set
            {
                this._MCust_Contact_FaxNo = value;
                _UpdateFieldName.Add("MCust_Contact_FaxNo");
            }
        }
        public String MCust_Contact_Email_Admin
        {
            get
            {
                return this._MCust_Contact_Email_Admin;
            }
            set
            {
                this._MCust_Contact_Email_Admin = value;
                _UpdateFieldName.Add("MCust_Contact_Email_Admin");
            }
        }
        public String MCust_Contact_Email_Info
        {
            get
            {
                return this._MCust_Contact_Email_Info;
            }
            set
            {
                this._MCust_Contact_Email_Info = value;
                _UpdateFieldName.Add("MCust_Contact_Email_Info");
            }
        }
        public String MCust_Contact_Email_Sales
        {
            get
            {
                return this._MCust_Contact_Email_Sales;
            }
            set
            {
                this._MCust_Contact_Email_Sales = value;
                _UpdateFieldName.Add("MCust_Contact_Email_Sales");
            }
        }
        public String MCust_Contact_Email_Tech
        {
            get
            {
                return this._MCust_Contact_Email_Tech;
            }
            set
            {
                this._MCust_Contact_Email_Tech = value;
                _UpdateFieldName.Add("MCust_Contact_Email_Tech");
            }
        }
        public String MCust_Contact_Website
        {
            get
            {
                return this._MCust_Contact_Website;
            }
            set
            {
                this._MCust_Contact_Website = value;
                _UpdateFieldName.Add("MCust_Contact_Website");
            }
        }
        public String MCust_BL_VATNO
        {
            get
            {
                return this._MCust_BL_VATNO;
            }
            set
            {
                this._MCust_BL_VATNO = value;
                _UpdateFieldName.Add("MCust_BL_VATNO");
            }
        }
        public String MCust_BL_CSTNO
        {
            get
            {
                return this._MCust_BL_CSTNO;
            }
            set
            {
                this._MCust_BL_CSTNO = value;
                _UpdateFieldName.Add("MCust_BL_CSTNO");
            }
        }
        public String MCust_BL_TINNO
        {
            get
            {
                return this._MCust_BL_TINNO;
            }
            set
            {
                this._MCust_BL_TINNO = value;
                _UpdateFieldName.Add("MCust_BL_TINNO");
            }
        }
        public String MCust_BL_ServiceTaxNo
        {
            get
            {
                return this._MCust_BL_ServiceTaxNo;
            }
            set
            {
                this._MCust_BL_ServiceTaxNo = value;
                _UpdateFieldName.Add("MCust_BL_ServiceTaxNo");
            }
        }
        public String MCust_BL_ExciseRegNo
        {
            get
            {
                return this._MCust_BL_ExciseRegNo;
            }
            set
            {
                this._MCust_BL_ExciseRegNo = value;
                _UpdateFieldName.Add("MCust_BL_ExciseRegNo");
            }
        }
        public String MCust_BL_PANNO
        {
            get
            {
                return this._MCust_BL_PANNO;
            }
            set
            {
                this._MCust_BL_PANNO = value;
                _UpdateFieldName.Add("MCust_BL_PANNO");
            }
        }
        public String MCust_BL_GSTNO
        {
            get
            {
                return this._MCust_BL_GSTNO;
            }
            set
            {
                this._MCust_BL_GSTNO = value;
                _UpdateFieldName.Add("MCust_BL_GSTNO");
            }
        }
        public String MCust_BL_ARNO
        {
            get
            {
                return this._MCust_BL_ARNO;
            }
            set
            {
                this._MCust_BL_ARNO = value;
                _UpdateFieldName.Add("MCust_BL_ARNO");
            }
        }

        #endregion
        #region Genric Methods
        public string Insert_Update(M_AT_Mst_CustomerBO sObject)
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


// ObjAT_Cust.M_Cust_ID=ObjAT_Cust.M_Cust_ID;
// ObjAT_Cust.Fk_Company_ID=ObjAT_Cust.Fk_Company_ID;
// ObjAT_Cust.Fk_Branch_ID=ObjAT_Cust.Fk_Branch_ID;
// ObjAT_Cust.Fk_Year_ID=ObjAT_Cust.Fk_Year_ID;
// ObjAT_Cust.MCust_Code=ObjAT_Cust.MCust_Code;
// ObjAT_Cust.MCust_Name=ObjAT_Cust.MCust_Name;
// ObjAT_Cust.MCust_DisplayName=ObjAT_Cust.MCust_DisplayName;
// ObjAT_Cust.MCust_TradeName=ObjAT_Cust.MCust_TradeName;
// ObjAT_Cust.MCust_Reg_Add1=ObjAT_Cust.MCust_Reg_Add1;
// ObjAT_Cust.MCust_Reg_Add2=ObjAT_Cust.MCust_Reg_Add2;
// ObjAT_Cust.MCust_Reg_Add3=ObjAT_Cust.MCust_Reg_Add3;
// ObjAT_Cust.MCust_Reg_Pincode=ObjAT_Cust.MCust_Reg_Pincode;
// ObjAT_Cust.MCust_Reg_Area=ObjAT_Cust.MCust_Reg_Area;
// ObjAT_Cust.MCust_Reg_City=ObjAT_Cust.MCust_Reg_City;
// ObjAT_Cust.MCust_Reg_State_ID=ObjAT_Cust.MCust_Reg_State_ID;
// ObjAT_Cust.MCust_Reg_Country=ObjAT_Cust.MCust_Reg_Country;
// ObjAT_Cust.MCust_ShippTo_CompanyName=ObjAT_Cust.MCust_ShippTo_CompanyName;
// ObjAT_Cust.MCust_ShippTo_ContactPerson=ObjAT_Cust.MCust_ShippTo_ContactPerson;
// ObjAT_Cust.MCust_ShippTo_CP_MobileNo=ObjAT_Cust.MCust_ShippTo_CP_MobileNo;
// ObjAT_Cust.MCust_ShippTo_Add1=ObjAT_Cust.MCust_ShippTo_Add1;
// ObjAT_Cust.MCust_ShippTo_Add2=ObjAT_Cust.MCust_ShippTo_Add2;
// ObjAT_Cust.MCust_ShippTo_Add3=ObjAT_Cust.MCust_ShippTo_Add3;
// ObjAT_Cust.MCust_ShippTo_Pincode=ObjAT_Cust.MCust_ShippTo_Pincode;
// ObjAT_Cust.MCust_ShippTo_Area=ObjAT_Cust.MCust_ShippTo_Area;
// ObjAT_Cust.MCust_ShippTo_City=ObjAT_Cust.MCust_ShippTo_City;
// ObjAT_Cust.MCust_ShippTo_State_ID=ObjAT_Cust.MCust_ShippTo_State_ID;
// ObjAT_Cust.MCust_ShippTo_Country=ObjAT_Cust.MCust_ShippTo_Country;
// ObjAT_Cust.MCust_ShippTo_PANNO=ObjAT_Cust.MCust_ShippTo_PANNO;
// ObjAT_Cust.MCust_ShippTo_GSTNO=ObjAT_Cust.MCust_ShippTo_GSTNO;
// ObjAT_Cust.MCust_ShippTo_ARNO=ObjAT_Cust.MCust_ShippTo_ARNO;
// ObjAT_Cust.MCust_BankName=ObjAT_Cust.MCust_BankName;
// ObjAT_Cust.MCust_AccountHolderName=ObjAT_Cust.MCust_AccountHolderName;
// ObjAT_Cust.MCust_IFSCNo=ObjAT_Cust.MCust_IFSCNo;
// ObjAT_Cust.MCust_AccountNo=ObjAT_Cust.MCust_AccountNo;
// ObjAT_Cust.MCust_BankBranch=ObjAT_Cust.MCust_BankBranch;
// ObjAT_Cust.MDBSC_RowStatus=ObjAT_Cust.MDBSC_RowStatus;
// ObjAT_Cust.MDBSC_RowCreatedByUser_ID=ObjAT_Cust.MDBSC_RowCreatedByUser_ID;
// ObjAT_Cust.MDBSC_RowCreatedByUserName=ObjAT_Cust.MDBSC_RowCreatedByUserName;
// ObjAT_Cust.MDBSC_RowCreatedOn_DT=ObjAT_Cust.MDBSC_RowCreatedOn_DT;
// ObjAT_Cust.MDBSC_RowLupdnByUser_ID=ObjAT_Cust.MDBSC_RowLupdnByUser_ID;
// ObjAT_Cust.MDBSC_RowLupdnUserName=ObjAT_Cust.MDBSC_RowLupdnUserName;
// ObjAT_Cust.MDBSC_RowLupdnOn_DT=ObjAT_Cust.MDBSC_RowLupdnOn_DT;
// ObjAT_Cust.MCust_RegType=ObjAT_Cust.MCust_RegType;
// ObjAT_Cust.MCust_NatureOfBusiness=ObjAT_Cust.MCust_NatureOfBusiness;
// ObjAT_Cust.MCust_Primary_Contact_Designation=ObjAT_Cust.MCust_Primary_Contact_Designation;
// ObjAT_Cust.MCust_Primary_Contact_Person=ObjAT_Cust.MCust_Primary_Contact_Person;
// ObjAT_Cust.MCust_Primary_CP_PhoneNo=ObjAT_Cust.MCust_Primary_CP_PhoneNo;
// ObjAT_Cust.MCust_Primary_CP_MobileNo=ObjAT_Cust.MCust_Primary_CP_MobileNo;
// ObjAT_Cust.MCust_Primary_CP_MobileNo_Alt=ObjAT_Cust.MCust_Primary_CP_MobileNo_Alt;
// ObjAT_Cust.MCust_Primary_CP_EmailID=ObjAT_Cust.MCust_Primary_CP_EmailID;
// ObjAT_Cust.MCust_Primary_CP_EmailID_Alt=ObjAT_Cust.MCust_Primary_CP_EmailID_Alt;
// ObjAT_Cust.MCust_Contact_OfficeNo1=ObjAT_Cust.MCust_Contact_OfficeNo1;
// ObjAT_Cust.MCust_Contact_OfficeNo2=ObjAT_Cust.MCust_Contact_OfficeNo2;
// ObjAT_Cust.MCust_Contact_OfficeNo_Alt=ObjAT_Cust.MCust_Contact_OfficeNo_Alt;
// ObjAT_Cust.MCust_Contact_FaxNo=ObjAT_Cust.MCust_Contact_FaxNo;
// ObjAT_Cust.MCust_Contact_Email_Admin=ObjAT_Cust.MCust_Contact_Email_Admin;
// ObjAT_Cust.MCust_Contact_Email_Info=ObjAT_Cust.MCust_Contact_Email_Info;
// ObjAT_Cust.MCust_Contact_Email_Sales=ObjAT_Cust.MCust_Contact_Email_Sales;
// ObjAT_Cust.MCust_Contact_Email_Tech=ObjAT_Cust.MCust_Contact_Email_Tech;
// ObjAT_Cust.MCust_Contact_Website=ObjAT_Cust.MCust_Contact_Website;
// ObjAT_Cust.MCust_BL_VATNO=ObjAT_Cust.MCust_BL_VATNO;
// ObjAT_Cust.MCust_BL_CSTNO=ObjAT_Cust.MCust_BL_CSTNO;
// ObjAT_Cust.MCust_BL_TINNO=ObjAT_Cust.MCust_BL_TINNO;
// ObjAT_Cust.MCust_BL_ServiceTaxNo=ObjAT_Cust.MCust_BL_ServiceTaxNo;
// ObjAT_Cust.MCust_BL_ExciseRegNo=ObjAT_Cust.MCust_BL_ExciseRegNo;
// ObjAT_Cust.MCust_BL_PANNO=ObjAT_Cust.MCust_BL_PANNO;
// ObjAT_Cust.MCust_BL_GSTNO=ObjAT_Cust.MCust_BL_GSTNO;
// ObjAT_Cust.MCust_BL_ARNO=ObjAT_Cust.MCust_BL_ARNO;



// M_Cust_ID.Text = "";
// Fk_Company_ID.Text = "";
// Fk_Branch_ID.Text = "";
// Fk_Year_ID.Text = "";
// MCust_Code.Text = "";
// MCust_Name.Text = "";
// MCust_DisplayName.Text = "";
// MCust_TradeName.Text = "";
// MCust_Reg_Add1.Text = "";
// MCust_Reg_Add2.Text = "";
// MCust_Reg_Add3.Text = "";
// MCust_Reg_Pincode.Text = "";
// MCust_Reg_Area.Text = "";
// MCust_Reg_City.Text = "";
// MCust_Reg_State_ID.Text = "";
// MCust_Reg_Country.Text = "";
// MCust_ShippTo_CompanyName.Text = "";
// MCust_ShippTo_ContactPerson.Text = "";
// MCust_ShippTo_CP_MobileNo.Text = "";
// MCust_ShippTo_Add1.Text = "";
// MCust_ShippTo_Add2.Text = "";
// MCust_ShippTo_Add3.Text = "";
// MCust_ShippTo_Pincode.Text = "";
// MCust_ShippTo_Area.Text = "";
// MCust_ShippTo_City.Text = "";
// MCust_ShippTo_State_ID.Text = "";
// MCust_ShippTo_Country.Text = "";
// MCust_ShippTo_PANNO.Text = "";
// MCust_ShippTo_GSTNO.Text = "";
// MCust_ShippTo_ARNO.Text = "";
// MCust_BankName.Text = "";
// MCust_AccountHolderName.Text = "";
// MCust_IFSCNo.Text = "";
// MCust_AccountNo.Text = "";
// MCust_BankBranch.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";
// MCust_RegType.Text = "";
// MCust_NatureOfBusiness.Text = "";
// MCust_Primary_Contact_Designation.Text = "";
// MCust_Primary_Contact_Person.Text = "";
// MCust_Primary_CP_PhoneNo.Text = "";
// MCust_Primary_CP_MobileNo.Text = "";
// MCust_Primary_CP_MobileNo_Alt.Text = "";
// MCust_Primary_CP_EmailID.Text = "";
// MCust_Primary_CP_EmailID_Alt.Text = "";
// MCust_Contact_OfficeNo1.Text = "";
// MCust_Contact_OfficeNo2.Text = "";
// MCust_Contact_OfficeNo_Alt.Text = "";
// MCust_Contact_FaxNo.Text = "";
// MCust_Contact_Email_Admin.Text = "";
// MCust_Contact_Email_Info.Text = "";
// MCust_Contact_Email_Sales.Text = "";
// MCust_Contact_Email_Tech.Text = "";
// MCust_Contact_Website.Text = "";
// MCust_BL_VATNO.Text = "";
// MCust_BL_CSTNO.Text = "";
// MCust_BL_TINNO.Text = "";
// MCust_BL_ServiceTaxNo.Text = "";
// MCust_BL_ExciseRegNo.Text = "";
// MCust_BL_PANNO.Text = "";
// MCust_BL_GSTNO.Text = "";
// MCust_BL_ARNO.Text = "";



// ObjAT_Cust.M_Cust_ID=M_Cust_ID.Text ;
// ObjAT_Cust.Fk_Company_ID=Fk_Company_ID.Text ;
// ObjAT_Cust.Fk_Branch_ID=Fk_Branch_ID.Text ;
// ObjAT_Cust.Fk_Year_ID=Fk_Year_ID.Text ;
// ObjAT_Cust.MCust_Code=MCust_Code.Text ;
// ObjAT_Cust.MCust_Name=MCust_Name.Text ;
// ObjAT_Cust.MCust_DisplayName=MCust_DisplayName.Text ;
// ObjAT_Cust.MCust_TradeName=MCust_TradeName.Text ;
// ObjAT_Cust.MCust_Reg_Add1=MCust_Reg_Add1.Text ;
// ObjAT_Cust.MCust_Reg_Add2=MCust_Reg_Add2.Text ;
// ObjAT_Cust.MCust_Reg_Add3=MCust_Reg_Add3.Text ;
// ObjAT_Cust.MCust_Reg_Pincode=MCust_Reg_Pincode.Text ;
// ObjAT_Cust.MCust_Reg_Area=MCust_Reg_Area.Text ;
// ObjAT_Cust.MCust_Reg_City=MCust_Reg_City.Text ;
// ObjAT_Cust.MCust_Reg_State_ID=MCust_Reg_State_ID.Text ;
// ObjAT_Cust.MCust_Reg_Country=MCust_Reg_Country.Text ;
// ObjAT_Cust.MCust_ShippTo_CompanyName=MCust_ShippTo_CompanyName.Text ;
// ObjAT_Cust.MCust_ShippTo_ContactPerson=MCust_ShippTo_ContactPerson.Text ;
// ObjAT_Cust.MCust_ShippTo_CP_MobileNo=MCust_ShippTo_CP_MobileNo.Text ;
// ObjAT_Cust.MCust_ShippTo_Add1=MCust_ShippTo_Add1.Text ;
// ObjAT_Cust.MCust_ShippTo_Add2=MCust_ShippTo_Add2.Text ;
// ObjAT_Cust.MCust_ShippTo_Add3=MCust_ShippTo_Add3.Text ;
// ObjAT_Cust.MCust_ShippTo_Pincode=MCust_ShippTo_Pincode.Text ;
// ObjAT_Cust.MCust_ShippTo_Area=MCust_ShippTo_Area.Text ;
// ObjAT_Cust.MCust_ShippTo_City=MCust_ShippTo_City.Text ;
// ObjAT_Cust.MCust_ShippTo_State_ID=MCust_ShippTo_State_ID.Text ;
// ObjAT_Cust.MCust_ShippTo_Country=MCust_ShippTo_Country.Text ;
// ObjAT_Cust.MCust_ShippTo_PANNO=MCust_ShippTo_PANNO.Text ;
// ObjAT_Cust.MCust_ShippTo_GSTNO=MCust_ShippTo_GSTNO.Text ;
// ObjAT_Cust.MCust_ShippTo_ARNO=MCust_ShippTo_ARNO.Text ;
// ObjAT_Cust.MCust_BankName=MCust_BankName.Text ;
// ObjAT_Cust.MCust_AccountHolderName=MCust_AccountHolderName.Text ;
// ObjAT_Cust.MCust_IFSCNo=MCust_IFSCNo.Text ;
// ObjAT_Cust.MCust_AccountNo=MCust_AccountNo.Text ;
// ObjAT_Cust.MCust_BankBranch=MCust_BankBranch.Text ;
// ObjAT_Cust.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_Cust.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_Cust.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_Cust.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_Cust.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_Cust.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_Cust.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;
// ObjAT_Cust.MCust_RegType=MCust_RegType.Text ;
// ObjAT_Cust.MCust_NatureOfBusiness=MCust_NatureOfBusiness.Text ;
// ObjAT_Cust.MCust_Primary_Contact_Designation=MCust_Primary_Contact_Designation.Text ;
// ObjAT_Cust.MCust_Primary_Contact_Person=MCust_Primary_Contact_Person.Text ;
// ObjAT_Cust.MCust_Primary_CP_PhoneNo=MCust_Primary_CP_PhoneNo.Text ;
// ObjAT_Cust.MCust_Primary_CP_MobileNo=MCust_Primary_CP_MobileNo.Text ;
// ObjAT_Cust.MCust_Primary_CP_MobileNo_Alt=MCust_Primary_CP_MobileNo_Alt.Text ;
// ObjAT_Cust.MCust_Primary_CP_EmailID=MCust_Primary_CP_EmailID.Text ;
// ObjAT_Cust.MCust_Primary_CP_EmailID_Alt=MCust_Primary_CP_EmailID_Alt.Text ;
// ObjAT_Cust.MCust_Contact_OfficeNo1=MCust_Contact_OfficeNo1.Text ;
// ObjAT_Cust.MCust_Contact_OfficeNo2=MCust_Contact_OfficeNo2.Text ;
// ObjAT_Cust.MCust_Contact_OfficeNo_Alt=MCust_Contact_OfficeNo_Alt.Text ;
// ObjAT_Cust.MCust_Contact_FaxNo=MCust_Contact_FaxNo.Text ;
// ObjAT_Cust.MCust_Contact_Email_Admin=MCust_Contact_Email_Admin.Text ;
// ObjAT_Cust.MCust_Contact_Email_Info=MCust_Contact_Email_Info.Text ;
// ObjAT_Cust.MCust_Contact_Email_Sales=MCust_Contact_Email_Sales.Text ;
// ObjAT_Cust.MCust_Contact_Email_Tech=MCust_Contact_Email_Tech.Text ;
// ObjAT_Cust.MCust_Contact_Website=MCust_Contact_Website.Text ;
// ObjAT_Cust.MCust_BL_VATNO=MCust_BL_VATNO.Text ;
// ObjAT_Cust.MCust_BL_CSTNO=MCust_BL_CSTNO.Text ;
// ObjAT_Cust.MCust_BL_TINNO=MCust_BL_TINNO.Text ;
// ObjAT_Cust.MCust_BL_ServiceTaxNo=MCust_BL_ServiceTaxNo.Text ;
// ObjAT_Cust.MCust_BL_ExciseRegNo=MCust_BL_ExciseRegNo.Text ;
// ObjAT_Cust.MCust_BL_PANNO=MCust_BL_PANNO.Text ;
// ObjAT_Cust.MCust_BL_GSTNO=MCust_BL_GSTNO.Text ;
// ObjAT_Cust.MCust_BL_ARNO=MCust_BL_ARNO.Text ;



// M_Cust_ID.Text =  dt.Rows[0]["M_Cust_ID"].ToString();
// Fk_Company_ID.Text =  dt.Rows[0]["Fk_Company_ID"].ToString();
// Fk_Branch_ID.Text =  dt.Rows[0]["Fk_Branch_ID"].ToString();
// Fk_Year_ID.Text =  dt.Rows[0]["Fk_Year_ID"].ToString();
// MCust_Code.Text =  dt.Rows[0]["MCust_Code"].ToString();
// MCust_Name.Text =  dt.Rows[0]["MCust_Name"].ToString();
// MCust_DisplayName.Text =  dt.Rows[0]["MCust_DisplayName"].ToString();
// MCust_TradeName.Text =  dt.Rows[0]["MCust_TradeName"].ToString();
// MCust_Reg_Add1.Text =  dt.Rows[0]["MCust_Reg_Add1"].ToString();
// MCust_Reg_Add2.Text =  dt.Rows[0]["MCust_Reg_Add2"].ToString();
// MCust_Reg_Add3.Text =  dt.Rows[0]["MCust_Reg_Add3"].ToString();
// MCust_Reg_Pincode.Text =  dt.Rows[0]["MCust_Reg_Pincode"].ToString();
// MCust_Reg_Area.Text =  dt.Rows[0]["MCust_Reg_Area"].ToString();
// MCust_Reg_City.Text =  dt.Rows[0]["MCust_Reg_City"].ToString();
// MCust_Reg_State_ID.Text =  dt.Rows[0]["MCust_Reg_State_ID"].ToString();
// MCust_Reg_Country.Text =  dt.Rows[0]["MCust_Reg_Country"].ToString();
// MCust_ShippTo_CompanyName.Text =  dt.Rows[0]["MCust_ShippTo_CompanyName"].ToString();
// MCust_ShippTo_ContactPerson.Text =  dt.Rows[0]["MCust_ShippTo_ContactPerson"].ToString();
// MCust_ShippTo_CP_MobileNo.Text =  dt.Rows[0]["MCust_ShippTo_CP_MobileNo"].ToString();
// MCust_ShippTo_Add1.Text =  dt.Rows[0]["MCust_ShippTo_Add1"].ToString();
// MCust_ShippTo_Add2.Text =  dt.Rows[0]["MCust_ShippTo_Add2"].ToString();
// MCust_ShippTo_Add3.Text =  dt.Rows[0]["MCust_ShippTo_Add3"].ToString();
// MCust_ShippTo_Pincode.Text =  dt.Rows[0]["MCust_ShippTo_Pincode"].ToString();
// MCust_ShippTo_Area.Text =  dt.Rows[0]["MCust_ShippTo_Area"].ToString();
// MCust_ShippTo_City.Text =  dt.Rows[0]["MCust_ShippTo_City"].ToString();
// MCust_ShippTo_State_ID.Text =  dt.Rows[0]["MCust_ShippTo_State_ID"].ToString();
// MCust_ShippTo_Country.Text =  dt.Rows[0]["MCust_ShippTo_Country"].ToString();
// MCust_ShippTo_PANNO.Text =  dt.Rows[0]["MCust_ShippTo_PANNO"].ToString();
// MCust_ShippTo_GSTNO.Text =  dt.Rows[0]["MCust_ShippTo_GSTNO"].ToString();
// MCust_ShippTo_ARNO.Text =  dt.Rows[0]["MCust_ShippTo_ARNO"].ToString();
// MCust_BankName.Text =  dt.Rows[0]["MCust_BankName"].ToString();
// MCust_AccountHolderName.Text =  dt.Rows[0]["MCust_AccountHolderName"].ToString();
// MCust_IFSCNo.Text =  dt.Rows[0]["MCust_IFSCNo"].ToString();
// MCust_AccountNo.Text =  dt.Rows[0]["MCust_AccountNo"].ToString();
// MCust_BankBranch.Text =  dt.Rows[0]["MCust_BankBranch"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
// MCust_RegType.Text =  dt.Rows[0]["MCust_RegType"].ToString();
// MCust_NatureOfBusiness.Text =  dt.Rows[0]["MCust_NatureOfBusiness"].ToString();
// MCust_Primary_Contact_Designation.Text =  dt.Rows[0]["MCust_Primary_Contact_Designation"].ToString();
// MCust_Primary_Contact_Person.Text =  dt.Rows[0]["MCust_Primary_Contact_Person"].ToString();
// MCust_Primary_CP_PhoneNo.Text =  dt.Rows[0]["MCust_Primary_CP_PhoneNo"].ToString();
// MCust_Primary_CP_MobileNo.Text =  dt.Rows[0]["MCust_Primary_CP_MobileNo"].ToString();
// MCust_Primary_CP_MobileNo_Alt.Text =  dt.Rows[0]["MCust_Primary_CP_MobileNo_Alt"].ToString();
// MCust_Primary_CP_EmailID.Text =  dt.Rows[0]["MCust_Primary_CP_EmailID"].ToString();
// MCust_Primary_CP_EmailID_Alt.Text =  dt.Rows[0]["MCust_Primary_CP_EmailID_Alt"].ToString();
// MCust_Contact_OfficeNo1.Text =  dt.Rows[0]["MCust_Contact_OfficeNo1"].ToString();
// MCust_Contact_OfficeNo2.Text =  dt.Rows[0]["MCust_Contact_OfficeNo2"].ToString();
// MCust_Contact_OfficeNo_Alt.Text =  dt.Rows[0]["MCust_Contact_OfficeNo_Alt"].ToString();
// MCust_Contact_FaxNo.Text =  dt.Rows[0]["MCust_Contact_FaxNo"].ToString();
// MCust_Contact_Email_Admin.Text =  dt.Rows[0]["MCust_Contact_Email_Admin"].ToString();
// MCust_Contact_Email_Info.Text =  dt.Rows[0]["MCust_Contact_Email_Info"].ToString();
// MCust_Contact_Email_Sales.Text =  dt.Rows[0]["MCust_Contact_Email_Sales"].ToString();
// MCust_Contact_Email_Tech.Text =  dt.Rows[0]["MCust_Contact_Email_Tech"].ToString();
// MCust_Contact_Website.Text =  dt.Rows[0]["MCust_Contact_Website"].ToString();
// MCust_BL_VATNO.Text =  dt.Rows[0]["MCust_BL_VATNO"].ToString();
// MCust_BL_CSTNO.Text =  dt.Rows[0]["MCust_BL_CSTNO"].ToString();
// MCust_BL_TINNO.Text =  dt.Rows[0]["MCust_BL_TINNO"].ToString();
// MCust_BL_ServiceTaxNo.Text =  dt.Rows[0]["MCust_BL_ServiceTaxNo"].ToString();
// MCust_BL_ExciseRegNo.Text =  dt.Rows[0]["MCust_BL_ExciseRegNo"].ToString();
// MCust_BL_PANNO.Text =  dt.Rows[0]["MCust_BL_PANNO"].ToString();
// MCust_BL_GSTNO.Text =  dt.Rows[0]["MCust_BL_GSTNO"].ToString();
// MCust_BL_ARNO.Text =  dt.Rows[0]["MCust_BL_ARNO"].ToString();
