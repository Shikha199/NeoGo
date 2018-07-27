using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal
{
    public class M_AT_Mst_VendorBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public M_AT_Mst_VendorBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "M_Ven_ID";
        private string _TableName = "M_AT_Mst_Vendor";
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

        private Int64 _M_Ven_ID;
        private Int64 _Fk_Company_ID;
        private Int64 _Fk_Branch_ID;
        private Int64 _Fk_Year_ID;
        private String _MVen_Code;
        private String _MVen_Name;
        private String _MVen_DisplayName;
        private String _MVen_TradeName;
        private String _MVen_Reg_Add1;
        private String _MVen_Reg_Add2;
        private String _MVen_Reg_Add3;
        private String _MVen_Reg_Pincode;
        private String _MVen_Reg_Area;
        private String _MVen_Reg_City;
        private Int64 _MVen_Reg_State_ID;
        private Int32 _MVen_CreditDays;
        
        private String _MVen_Reg_Country;
        private String _MVen_DispatchFrom_CompanyName;
        private String _MVen_DispatchFrom_ContactPerson;
        private String _MVen_DispatchFrom_CP_MobileNo;
        private String _MVen_DispatchFrom_Add1;
        private String _MVen_DispatchFrom_Add2;
        private String _MVen_DispatchFrom_Add3;
        private String _MVen_DispatchFrom_Pincode;
        private String _MVen_DispatchFrom_Area;
        private String _MVen_DispatchFrom_City;
        private Int64 _MVen_DispatchFrom_State_ID;
        private String _MVen_DispatchFrom_Country;
        private String _MVen_DispatchFrom_PANNO;
        private String _MVen_DispatchFrom_GSTNO;
        private String _MVen_DispatchFrom_ARNO;
        private String _MVen_BankName;
        private String _MVen_AccountHolderName;
        private String _MVen_IFSCNo;
        private String _MVen_AccountNo;
        private String _MVen_BankBranch;
        private String _MDBSC_RowStatus;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;
        private String _MVen_RegType;
        private String _MVen_NatureOfBusiness;
        private String _MVen_Primary_Contact_Designation;
        private String _MVen_Primary_Contact_Person;
        private String _MVen_Primary_CP_PhoneNo;
        private String _MVen_Primary_CP_MobileNo;
        private String _MVen_Primary_CP_MobileNo_Alt;
        private String _MVen_Primary_CP_EmailID;
        private String _MVen_Primary_CP_EmailID_Alt;
        private String _MVen_Contact_OfficeNo1;
        private String _MVen_Contact_OfficeNo2;
        private String _MVen_Contact_OfficeNo_Alt;
        private String _MVen_Contact_FaxNo;
        private String _MVen_Contact_Email_Admin;
        private String _MVen_Contact_Email_Info;
        private String _MVen_Contact_Email_Sales;
        private String _MVen_Contact_Email_Tech;
        private String _MVen_Contact_Website;
        private String _MVen_BL_VATNO;
        private String _MVen_BL_CSTNO;
        private String _MVen_BL_TINNO;
        private String _MVen_BL_ServiceTaxNo;
        private String _MVen_BL_ExciseRegNo;
        private String _MVen_BL_PANNO;
        private String _MVen_BL_GSTNO;
        private String _MVen_BL_ARNO;

        public Int64 M_Ven_ID
        {
            get
            {
                return this._M_Ven_ID;
            }
            set
            {
                this._M_Ven_ID = value;
                _UpdateFieldName.Add("M_Ven_ID");
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
        public String MVen_Code
        {
            get
            {
                return this._MVen_Code;
            }
            set
            {
                this._MVen_Code = value;
                _UpdateFieldName.Add("MVen_Code");
            }
        }
        public String MVen_Name
        {
            get
            {
                return this._MVen_Name;
            }
            set
            {
                this._MVen_Name = value;
                _UpdateFieldName.Add("MVen_Name");
            }
        }
        public String MVen_DisplayName
        {
            get
            {
                return this._MVen_DisplayName;
            }
            set
            {
                this._MVen_DisplayName = value;
                _UpdateFieldName.Add("MVen_DisplayName");
            }
        }
        public String MVen_TradeName
        {
            get
            {
                return this._MVen_TradeName;
            }
            set
            {
                this._MVen_TradeName = value;
                _UpdateFieldName.Add("MVen_TradeName");
            }
        }
        public String MVen_Reg_Add1
        {
            get
            {
                return this._MVen_Reg_Add1;
            }
            set
            {
                this._MVen_Reg_Add1 = value;
                _UpdateFieldName.Add("MVen_Reg_Add1");
            }
        }
        public String MVen_Reg_Add2
        {
            get
            {
                return this._MVen_Reg_Add2;
            }
            set
            {
                this._MVen_Reg_Add2 = value;
                _UpdateFieldName.Add("MVen_Reg_Add2");
            }
        }
        public String MVen_Reg_Add3
        {
            get
            {
                return this._MVen_Reg_Add3;
            }
            set
            {
                this._MVen_Reg_Add3 = value;
                _UpdateFieldName.Add("MVen_Reg_Add3");
            }
        }
        public String MVen_Reg_Pincode
        {
            get
            {
                return this._MVen_Reg_Pincode;
            }
            set
            {
                this._MVen_Reg_Pincode = value;
                _UpdateFieldName.Add("MVen_Reg_Pincode");
            }
        }
        public String MVen_Reg_Area
        {
            get
            {
                return this._MVen_Reg_Area;
            }
            set
            {
                this._MVen_Reg_Area = value;
                _UpdateFieldName.Add("MVen_Reg_Area");
            }
        }
        public String MVen_Reg_City
        {
            get
            {
                return this._MVen_Reg_City;
            }
            set
            {
                this._MVen_Reg_City = value;
                _UpdateFieldName.Add("MVen_Reg_City");
            }
        }
        public Int64 MVen_Reg_State_ID
        {
            get
            {
                return this._MVen_Reg_State_ID;
            }
            set
            {
                this._MVen_Reg_State_ID = value;
                _UpdateFieldName.Add("MVen_Reg_State_ID");
            }
        }
        public String MVen_Reg_Country
        {
            get
            {
                return this._MVen_Reg_Country;
            }
            set
            {
                this._MVen_Reg_Country = value;
                _UpdateFieldName.Add("MVen_Reg_Country");
            }
        }
        public String MVen_DispatchFrom_CompanyName
        {
            get
            {
                return this._MVen_DispatchFrom_CompanyName;
            }
            set
            {
                this._MVen_DispatchFrom_CompanyName = value;
                _UpdateFieldName.Add("MVen_DispatchFrom_CompanyName");
            }
        }
        public String MVen_DispatchFrom_ContactPerson
        {
            get
            {
                return this._MVen_DispatchFrom_ContactPerson;
            }
            set
            {
                this._MVen_DispatchFrom_ContactPerson = value;
                _UpdateFieldName.Add("MVen_DispatchFrom_ContactPerson");
            }
        }
        public String MVen_DispatchFrom_CP_MobileNo
        {
            get
            {
                return this._MVen_DispatchFrom_CP_MobileNo;
            }
            set
            {
                this._MVen_DispatchFrom_CP_MobileNo = value;
                _UpdateFieldName.Add("MVen_DispatchFrom_CP_MobileNo");
            }
        }
        public String MVen_DispatchFrom_Add1
        {
            get
            {
                return this._MVen_DispatchFrom_Add1;
            }
            set
            {
                this._MVen_DispatchFrom_Add1 = value;
                _UpdateFieldName.Add("MVen_DispatchFrom_Add1");
            }
        }
        public String MVen_DispatchFrom_Add2
        {
            get
            {
                return this._MVen_DispatchFrom_Add2;
            }
            set
            {
                this._MVen_DispatchFrom_Add2 = value;
                _UpdateFieldName.Add("MVen_DispatchFrom_Add2");
            }
        }
        public String MVen_DispatchFrom_Add3
        {
            get
            {
                return this._MVen_DispatchFrom_Add3;
            }
            set
            {
                this._MVen_DispatchFrom_Add3 = value;
                _UpdateFieldName.Add("MVen_DispatchFrom_Add3");
            }
        }
        public String MVen_DispatchFrom_Pincode
        {
            get
            {
                return this._MVen_DispatchFrom_Pincode;
            }
            set
            {
                this._MVen_DispatchFrom_Pincode = value;
                _UpdateFieldName.Add("MVen_DispatchFrom_Pincode");
            }
        }
        public String MVen_DispatchFrom_Area
        {
            get
            {
                return this._MVen_DispatchFrom_Area;
            }
            set
            {
                this._MVen_DispatchFrom_Area = value;
                _UpdateFieldName.Add("MVen_DispatchFrom_Area");
            }
        }
        public String MVen_DispatchFrom_City
        {
            get
            {
                return this._MVen_DispatchFrom_City;
            }
            set
            {
                this._MVen_DispatchFrom_City = value;
                _UpdateFieldName.Add("MVen_DispatchFrom_City");
            }
        }
        public Int64 MVen_DispatchFrom_State_ID
        {
            get
            {
                return this._MVen_DispatchFrom_State_ID;
            }
            set
            {
                this._MVen_DispatchFrom_State_ID = value;
                _UpdateFieldName.Add("MVen_DispatchFrom_State_ID");
            }
        }
        public String MVen_DispatchFrom_Country
        {
            get
            {
                return this._MVen_DispatchFrom_Country;
            }
            set
            {
                this._MVen_DispatchFrom_Country = value;
                _UpdateFieldName.Add("MVen_DispatchFrom_Country");
            }
        }
        public String MVen_DispatchFrom_PANNO
        {
            get
            {
                return this._MVen_DispatchFrom_PANNO;
            }
            set
            {
                this._MVen_DispatchFrom_PANNO = value;
                _UpdateFieldName.Add("MVen_DispatchFrom_PANNO");
            }
        }
        public String MVen_DispatchFrom_GSTNO
        {
            get
            {
                return this._MVen_DispatchFrom_GSTNO;
            }
            set
            {
                this._MVen_DispatchFrom_GSTNO = value;
                _UpdateFieldName.Add("MVen_DispatchFrom_GSTNO");
            }
        }
        public String MVen_DispatchFrom_ARNO
        {
            get
            {
                return this._MVen_DispatchFrom_ARNO;
            }
            set
            {
                this._MVen_DispatchFrom_ARNO = value;
                _UpdateFieldName.Add("MVen_DispatchFrom_ARNO");
            }
        }
        public String MVen_BankName
        {
            get
            {
                return this._MVen_BankName;
            }
            set
            {
                this._MVen_BankName = value;
                _UpdateFieldName.Add("MVen_BankName");
            }
        }
        public String MVen_AccountHolderName
        {
            get
            {
                return this._MVen_AccountHolderName;
            }
            set
            {
                this._MVen_AccountHolderName = value;
                _UpdateFieldName.Add("MVen_AccountHolderName");
            }
        }
        public String MVen_IFSCNo
        {
            get
            {
                return this._MVen_IFSCNo;
            }
            set
            {
                this._MVen_IFSCNo = value;
                _UpdateFieldName.Add("MVen_IFSCNo");
            }
        }
        public String MVen_AccountNo
        {
            get
            {
                return this._MVen_AccountNo;
            }
            set
            {
                this._MVen_AccountNo = value;
                _UpdateFieldName.Add("MVen_AccountNo");
            }
        }

        public Int32 MVen_CreditDays
        {
            get
            {
                return this._MVen_CreditDays;
            }
            set
            {
                this._MVen_CreditDays = value;
                _UpdateFieldName.Add("MVen_CreditDays");
            }
        }

        public String MVen_BankBranch
        {
            get
            {
                return this._MVen_BankBranch;
            }
            set
            {
                this._MVen_BankBranch = value;
                _UpdateFieldName.Add("MVen_BankBranch");
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
        public String MVen_RegType
        {
            get
            {
                return this._MVen_RegType;
            }
            set
            {
                this._MVen_RegType = value;
                _UpdateFieldName.Add("MVen_RegType");
            }
        }
        public String MVen_NatureOfBusiness
        {
            get
            {
                return this._MVen_NatureOfBusiness;
            }
            set
            {
                this._MVen_NatureOfBusiness = value;
                _UpdateFieldName.Add("MVen_NatureOfBusiness");
            }
        }
        public String MVen_Primary_Contact_Designation
        {
            get
            {
                return this._MVen_Primary_Contact_Designation;
            }
            set
            {
                this._MVen_Primary_Contact_Designation = value;
                _UpdateFieldName.Add("MVen_Primary_Contact_Designation");
            }
        }
        public String MVen_Primary_Contact_Person
        {
            get
            {
                return this._MVen_Primary_Contact_Person;
            }
            set
            {
                this._MVen_Primary_Contact_Person = value;
                _UpdateFieldName.Add("MVen_Primary_Contact_Person");
            }
        }
        public String MVen_Primary_CP_PhoneNo
        {
            get
            {
                return this._MVen_Primary_CP_PhoneNo;
            }
            set
            {
                this._MVen_Primary_CP_PhoneNo = value;
                _UpdateFieldName.Add("MVen_Primary_CP_PhoneNo");
            }
        }
        public String MVen_Primary_CP_MobileNo
        {
            get
            {
                return this._MVen_Primary_CP_MobileNo;
            }
            set
            {
                this._MVen_Primary_CP_MobileNo = value;
                _UpdateFieldName.Add("MVen_Primary_CP_MobileNo");
            }
        }
        public String MVen_Primary_CP_MobileNo_Alt
        {
            get
            {
                return this._MVen_Primary_CP_MobileNo_Alt;
            }
            set
            {
                this._MVen_Primary_CP_MobileNo_Alt = value;
                _UpdateFieldName.Add("MVen_Primary_CP_MobileNo_Alt");
            }
        }
        public String MVen_Primary_CP_EmailID
        {
            get
            {
                return this._MVen_Primary_CP_EmailID;
            }
            set
            {
                this._MVen_Primary_CP_EmailID = value;
                _UpdateFieldName.Add("MVen_Primary_CP_EmailID");
            }
        }
        public String MVen_Primary_CP_EmailID_Alt
        {
            get
            {
                return this._MVen_Primary_CP_EmailID_Alt;
            }
            set
            {
                this._MVen_Primary_CP_EmailID_Alt = value;
                _UpdateFieldName.Add("MVen_Primary_CP_EmailID_Alt");
            }
        }
        public String MVen_Contact_OfficeNo1
        {
            get
            {
                return this._MVen_Contact_OfficeNo1;
            }
            set
            {
                this._MVen_Contact_OfficeNo1 = value;
                _UpdateFieldName.Add("MVen_Contact_OfficeNo1");
            }
        }
        public String MVen_Contact_OfficeNo2
        {
            get
            {
                return this._MVen_Contact_OfficeNo2;
            }
            set
            {
                this._MVen_Contact_OfficeNo2 = value;
                _UpdateFieldName.Add("MVen_Contact_OfficeNo2");
            }
        }
        public String MVen_Contact_OfficeNo_Alt
        {
            get
            {
                return this._MVen_Contact_OfficeNo_Alt;
            }
            set
            {
                this._MVen_Contact_OfficeNo_Alt = value;
                _UpdateFieldName.Add("MVen_Contact_OfficeNo_Alt");
            }
        }
        public String MVen_Contact_FaxNo
        {
            get
            {
                return this._MVen_Contact_FaxNo;
            }
            set
            {
                this._MVen_Contact_FaxNo = value;
                _UpdateFieldName.Add("MVen_Contact_FaxNo");
            }
        }
        public String MVen_Contact_Email_Admin
        {
            get
            {
                return this._MVen_Contact_Email_Admin;
            }
            set
            {
                this._MVen_Contact_Email_Admin = value;
                _UpdateFieldName.Add("MVen_Contact_Email_Admin");
            }
        }
        public String MVen_Contact_Email_Info
        {
            get
            {
                return this._MVen_Contact_Email_Info;
            }
            set
            {
                this._MVen_Contact_Email_Info = value;
                _UpdateFieldName.Add("MVen_Contact_Email_Info");
            }
        }
        public String MVen_Contact_Email_Sales
        {
            get
            {
                return this._MVen_Contact_Email_Sales;
            }
            set
            {
                this._MVen_Contact_Email_Sales = value;
                _UpdateFieldName.Add("MVen_Contact_Email_Sales");
            }
        }
        public String MVen_Contact_Email_Tech
        {
            get
            {
                return this._MVen_Contact_Email_Tech;
            }
            set
            {
                this._MVen_Contact_Email_Tech = value;
                _UpdateFieldName.Add("MVen_Contact_Email_Tech");
            }
        }
        public String MVen_Contact_Website
        {
            get
            {
                return this._MVen_Contact_Website;
            }
            set
            {
                this._MVen_Contact_Website = value;
                _UpdateFieldName.Add("MVen_Contact_Website");
            }
        }
        public String MVen_BL_VATNO
        {
            get
            {
                return this._MVen_BL_VATNO;
            }
            set
            {
                this._MVen_BL_VATNO = value;
                _UpdateFieldName.Add("MVen_BL_VATNO");
            }
        }
        public String MVen_BL_CSTNO
        {
            get
            {
                return this._MVen_BL_CSTNO;
            }
            set
            {
                this._MVen_BL_CSTNO = value;
                _UpdateFieldName.Add("MVen_BL_CSTNO");
            }
        }
        public String MVen_BL_TINNO
        {
            get
            {
                return this._MVen_BL_TINNO;
            }
            set
            {
                this._MVen_BL_TINNO = value;
                _UpdateFieldName.Add("MVen_BL_TINNO");
            }
        }
        public String MVen_BL_ServiceTaxNo
        {
            get
            {
                return this._MVen_BL_ServiceTaxNo;
            }
            set
            {
                this._MVen_BL_ServiceTaxNo = value;
                _UpdateFieldName.Add("MVen_BL_ServiceTaxNo");
            }
        }
        public String MVen_BL_ExciseRegNo
        {
            get
            {
                return this._MVen_BL_ExciseRegNo;
            }
            set
            {
                this._MVen_BL_ExciseRegNo = value;
                _UpdateFieldName.Add("MVen_BL_ExciseRegNo");
            }
        }
        public String MVen_BL_PANNO
        {
            get
            {
                return this._MVen_BL_PANNO;
            }
            set
            {
                this._MVen_BL_PANNO = value;
                _UpdateFieldName.Add("MVen_BL_PANNO");
            }
        }
        public String MVen_BL_GSTNO
        {
            get
            {
                return this._MVen_BL_GSTNO;
            }
            set
            {
                this._MVen_BL_GSTNO = value;
                _UpdateFieldName.Add("MVen_BL_GSTNO");
            }
        }
        public String MVen_BL_ARNO
        {
            get
            {
                return this._MVen_BL_ARNO;
            }
            set
            {
                this._MVen_BL_ARNO = value;
                _UpdateFieldName.Add("MVen_BL_ARNO");
            }
        }

        #endregion
        #region Genric Methods
        public string Insert_Update(M_AT_Mst_VendorBO sObject)
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


// ObjAT_Cust.M_Ven_ID=ObjAT_Cust.M_Ven_ID;
// ObjAT_Cust.Fk_Company_ID=ObjAT_Cust.Fk_Company_ID;
// ObjAT_Cust.Fk_Branch_ID=ObjAT_Cust.Fk_Branch_ID;
// ObjAT_Cust.Fk_Year_ID=ObjAT_Cust.Fk_Year_ID;
// ObjAT_Cust.MVen_Code=ObjAT_Cust.MVen_Code;
// ObjAT_Cust.MVen_Name=ObjAT_Cust.MVen_Name;
// ObjAT_Cust.MVen_DisplayName=ObjAT_Cust.MVen_DisplayName;
// ObjAT_Cust.MVen_TradeName=ObjAT_Cust.MVen_TradeName;
// ObjAT_Cust.MVen_Reg_Add1=ObjAT_Cust.MVen_Reg_Add1;
// ObjAT_Cust.MVen_Reg_Add2=ObjAT_Cust.MVen_Reg_Add2;
// ObjAT_Cust.MVen_Reg_Add3=ObjAT_Cust.MVen_Reg_Add3;
// ObjAT_Cust.MVen_Reg_Pincode=ObjAT_Cust.MVen_Reg_Pincode;
// ObjAT_Cust.MVen_Reg_Area=ObjAT_Cust.MVen_Reg_Area;
// ObjAT_Cust.MVen_Reg_City=ObjAT_Cust.MVen_Reg_City;
// ObjAT_Cust.MVen_Reg_State_ID=ObjAT_Cust.MVen_Reg_State_ID;
// ObjAT_Cust.MVen_Reg_Country=ObjAT_Cust.MVen_Reg_Country;
// ObjAT_Cust.MVen_DispatchFrom_CompanyName=ObjAT_Cust.MVen_DispatchFrom_CompanyName;
// ObjAT_Cust.MVen_DispatchFrom_ContactPerson=ObjAT_Cust.MVen_DispatchFrom_ContactPerson;
// ObjAT_Cust.MVen_DispatchFrom_CP_MobileNo=ObjAT_Cust.MVen_DispatchFrom_CP_MobileNo;
// ObjAT_Cust.MVen_DispatchFrom_Add1=ObjAT_Cust.MVen_DispatchFrom_Add1;
// ObjAT_Cust.MVen_DispatchFrom_Add2=ObjAT_Cust.MVen_DispatchFrom_Add2;
// ObjAT_Cust.MVen_DispatchFrom_Add3=ObjAT_Cust.MVen_DispatchFrom_Add3;
// ObjAT_Cust.MVen_DispatchFrom_Pincode=ObjAT_Cust.MVen_DispatchFrom_Pincode;
// ObjAT_Cust.MVen_DispatchFrom_Area=ObjAT_Cust.MVen_DispatchFrom_Area;
// ObjAT_Cust.MVen_DispatchFrom_City=ObjAT_Cust.MVen_DispatchFrom_City;
// ObjAT_Cust.MVen_DispatchFrom_State_ID=ObjAT_Cust.MVen_DispatchFrom_State_ID;
// ObjAT_Cust.MVen_DispatchFrom_Country=ObjAT_Cust.MVen_DispatchFrom_Country;
// ObjAT_Cust.MVen_DispatchFrom_PANNO=ObjAT_Cust.MVen_DispatchFrom_PANNO;
// ObjAT_Cust.MVen_DispatchFrom_GSTNO=ObjAT_Cust.MVen_DispatchFrom_GSTNO;
// ObjAT_Cust.MVen_DispatchFrom_ARNO=ObjAT_Cust.MVen_DispatchFrom_ARNO;
// ObjAT_Cust.MVen_BankName=ObjAT_Cust.MVen_BankName;
// ObjAT_Cust.MVen_AccountHolderName=ObjAT_Cust.MVen_AccountHolderName;
// ObjAT_Cust.MVen_IFSCNo=ObjAT_Cust.MVen_IFSCNo;
// ObjAT_Cust.MVen_AccountNo=ObjAT_Cust.MVen_AccountNo;
// ObjAT_Cust.MVen_BankBranch=ObjAT_Cust.MVen_BankBranch;
// ObjAT_Cust.MDBSC_RowStatus=ObjAT_Cust.MDBSC_RowStatus;
// ObjAT_Cust.MDBSC_RowCreatedByUser_ID=ObjAT_Cust.MDBSC_RowCreatedByUser_ID;
// ObjAT_Cust.MDBSC_RowCreatedByUserName=ObjAT_Cust.MDBSC_RowCreatedByUserName;
// ObjAT_Cust.MDBSC_RowCreatedOn_DT=ObjAT_Cust.MDBSC_RowCreatedOn_DT;
// ObjAT_Cust.MDBSC_RowLupdnByUser_ID=ObjAT_Cust.MDBSC_RowLupdnByUser_ID;
// ObjAT_Cust.MDBSC_RowLupdnUserName=ObjAT_Cust.MDBSC_RowLupdnUserName;
// ObjAT_Cust.MDBSC_RowLupdnOn_DT=ObjAT_Cust.MDBSC_RowLupdnOn_DT;
// ObjAT_Cust.MVen_RegType=ObjAT_Cust.MVen_RegType;
// ObjAT_Cust.MVen_NatureOfBusiness=ObjAT_Cust.MVen_NatureOfBusiness;
// ObjAT_Cust.MVen_Primary_Contact_Designation=ObjAT_Cust.MVen_Primary_Contact_Designation;
// ObjAT_Cust.MVen_Primary_Contact_Person=ObjAT_Cust.MVen_Primary_Contact_Person;
// ObjAT_Cust.MVen_Primary_CP_PhoneNo=ObjAT_Cust.MVen_Primary_CP_PhoneNo;
// ObjAT_Cust.MVen_Primary_CP_MobileNo=ObjAT_Cust.MVen_Primary_CP_MobileNo;
// ObjAT_Cust.MVen_Primary_CP_MobileNo_Alt=ObjAT_Cust.MVen_Primary_CP_MobileNo_Alt;
// ObjAT_Cust.MVen_Primary_CP_EmailID=ObjAT_Cust.MVen_Primary_CP_EmailID;
// ObjAT_Cust.MVen_Primary_CP_EmailID_Alt=ObjAT_Cust.MVen_Primary_CP_EmailID_Alt;
// ObjAT_Cust.MVen_Contact_OfficeNo1=ObjAT_Cust.MVen_Contact_OfficeNo1;
// ObjAT_Cust.MVen_Contact_OfficeNo2=ObjAT_Cust.MVen_Contact_OfficeNo2;
// ObjAT_Cust.MVen_Contact_OfficeNo_Alt=ObjAT_Cust.MVen_Contact_OfficeNo_Alt;
// ObjAT_Cust.MVen_Contact_FaxNo=ObjAT_Cust.MVen_Contact_FaxNo;
// ObjAT_Cust.MVen_Contact_Email_Admin=ObjAT_Cust.MVen_Contact_Email_Admin;
// ObjAT_Cust.MVen_Contact_Email_Info=ObjAT_Cust.MVen_Contact_Email_Info;
// ObjAT_Cust.MVen_Contact_Email_Sales=ObjAT_Cust.MVen_Contact_Email_Sales;
// ObjAT_Cust.MVen_Contact_Email_Tech=ObjAT_Cust.MVen_Contact_Email_Tech;
// ObjAT_Cust.MVen_Contact_Website=ObjAT_Cust.MVen_Contact_Website;
// ObjAT_Cust.MVen_BL_VATNO=ObjAT_Cust.MVen_BL_VATNO;
// ObjAT_Cust.MVen_BL_CSTNO=ObjAT_Cust.MVen_BL_CSTNO;
// ObjAT_Cust.MVen_BL_TINNO=ObjAT_Cust.MVen_BL_TINNO;
// ObjAT_Cust.MVen_BL_ServiceTaxNo=ObjAT_Cust.MVen_BL_ServiceTaxNo;
// ObjAT_Cust.MVen_BL_ExciseRegNo=ObjAT_Cust.MVen_BL_ExciseRegNo;
// ObjAT_Cust.MVen_BL_PANNO=ObjAT_Cust.MVen_BL_PANNO;
// ObjAT_Cust.MVen_BL_GSTNO=ObjAT_Cust.MVen_BL_GSTNO;
// ObjAT_Cust.MVen_BL_ARNO=ObjAT_Cust.MVen_BL_ARNO;



// M_Ven_ID.Text = "";
// Fk_Company_ID.Text = "";
// Fk_Branch_ID.Text = "";
// Fk_Year_ID.Text = "";
// MVen_Code.Text = "";
// MVen_Name.Text = "";
// MVen_DisplayName.Text = "";
// MVen_TradeName.Text = "";
// MVen_Reg_Add1.Text = "";
// MVen_Reg_Add2.Text = "";
// MVen_Reg_Add3.Text = "";
// MVen_Reg_Pincode.Text = "";
// MVen_Reg_Area.Text = "";
// MVen_Reg_City.Text = "";
// MVen_Reg_State_ID.Text = "";
// MVen_Reg_Country.Text = "";
// MVen_DispatchFrom_CompanyName.Text = "";
// MVen_DispatchFrom_ContactPerson.Text = "";
// MVen_DispatchFrom_CP_MobileNo.Text = "";
// MVen_DispatchFrom_Add1.Text = "";
// MVen_DispatchFrom_Add2.Text = "";
// MVen_DispatchFrom_Add3.Text = "";
// MVen_DispatchFrom_Pincode.Text = "";
// MVen_DispatchFrom_Area.Text = "";
// MVen_DispatchFrom_City.Text = "";
// MVen_DispatchFrom_State_ID.Text = "";
// MVen_DispatchFrom_Country.Text = "";
// MVen_DispatchFrom_PANNO.Text = "";
// MVen_DispatchFrom_GSTNO.Text = "";
// MVen_DispatchFrom_ARNO.Text = "";
// MVen_BankName.Text = "";
// MVen_AccountHolderName.Text = "";
// MVen_IFSCNo.Text = "";
// MVen_AccountNo.Text = "";
// MVen_BankBranch.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";
// MVen_RegType.Text = "";
// MVen_NatureOfBusiness.Text = "";
// MVen_Primary_Contact_Designation.Text = "";
// MVen_Primary_Contact_Person.Text = "";
// MVen_Primary_CP_PhoneNo.Text = "";
// MVen_Primary_CP_MobileNo.Text = "";
// MVen_Primary_CP_MobileNo_Alt.Text = "";
// MVen_Primary_CP_EmailID.Text = "";
// MVen_Primary_CP_EmailID_Alt.Text = "";
// MVen_Contact_OfficeNo1.Text = "";
// MVen_Contact_OfficeNo2.Text = "";
// MVen_Contact_OfficeNo_Alt.Text = "";
// MVen_Contact_FaxNo.Text = "";
// MVen_Contact_Email_Admin.Text = "";
// MVen_Contact_Email_Info.Text = "";
// MVen_Contact_Email_Sales.Text = "";
// MVen_Contact_Email_Tech.Text = "";
// MVen_Contact_Website.Text = "";
// MVen_BL_VATNO.Text = "";
// MVen_BL_CSTNO.Text = "";
// MVen_BL_TINNO.Text = "";
// MVen_BL_ServiceTaxNo.Text = "";
// MVen_BL_ExciseRegNo.Text = "";
// MVen_BL_PANNO.Text = "";
// MVen_BL_GSTNO.Text = "";
// MVen_BL_ARNO.Text = "";



// ObjAT_Cust.M_Ven_ID=M_Ven_ID.Text ;
// ObjAT_Cust.Fk_Company_ID=Fk_Company_ID.Text ;
// ObjAT_Cust.Fk_Branch_ID=Fk_Branch_ID.Text ;
// ObjAT_Cust.Fk_Year_ID=Fk_Year_ID.Text ;
// ObjAT_Cust.MVen_Code=MVen_Code.Text ;
// ObjAT_Cust.MVen_Name=MVen_Name.Text ;
// ObjAT_Cust.MVen_DisplayName=MVen_DisplayName.Text ;
// ObjAT_Cust.MVen_TradeName=MVen_TradeName.Text ;
// ObjAT_Cust.MVen_Reg_Add1=MVen_Reg_Add1.Text ;
// ObjAT_Cust.MVen_Reg_Add2=MVen_Reg_Add2.Text ;
// ObjAT_Cust.MVen_Reg_Add3=MVen_Reg_Add3.Text ;
// ObjAT_Cust.MVen_Reg_Pincode=MVen_Reg_Pincode.Text ;
// ObjAT_Cust.MVen_Reg_Area=MVen_Reg_Area.Text ;
// ObjAT_Cust.MVen_Reg_City=MVen_Reg_City.Text ;
// ObjAT_Cust.MVen_Reg_State_ID=MVen_Reg_State_ID.Text ;
// ObjAT_Cust.MVen_Reg_Country=MVen_Reg_Country.Text ;
// ObjAT_Cust.MVen_DispatchFrom_CompanyName=MVen_DispatchFrom_CompanyName.Text ;
// ObjAT_Cust.MVen_DispatchFrom_ContactPerson=MVen_DispatchFrom_ContactPerson.Text ;
// ObjAT_Cust.MVen_DispatchFrom_CP_MobileNo=MVen_DispatchFrom_CP_MobileNo.Text ;
// ObjAT_Cust.MVen_DispatchFrom_Add1=MVen_DispatchFrom_Add1.Text ;
// ObjAT_Cust.MVen_DispatchFrom_Add2=MVen_DispatchFrom_Add2.Text ;
// ObjAT_Cust.MVen_DispatchFrom_Add3=MVen_DispatchFrom_Add3.Text ;
// ObjAT_Cust.MVen_DispatchFrom_Pincode=MVen_DispatchFrom_Pincode.Text ;
// ObjAT_Cust.MVen_DispatchFrom_Area=MVen_DispatchFrom_Area.Text ;
// ObjAT_Cust.MVen_DispatchFrom_City=MVen_DispatchFrom_City.Text ;
// ObjAT_Cust.MVen_DispatchFrom_State_ID=MVen_DispatchFrom_State_ID.Text ;
// ObjAT_Cust.MVen_DispatchFrom_Country=MVen_DispatchFrom_Country.Text ;
// ObjAT_Cust.MVen_DispatchFrom_PANNO=MVen_DispatchFrom_PANNO.Text ;
// ObjAT_Cust.MVen_DispatchFrom_GSTNO=MVen_DispatchFrom_GSTNO.Text ;
// ObjAT_Cust.MVen_DispatchFrom_ARNO=MVen_DispatchFrom_ARNO.Text ;
// ObjAT_Cust.MVen_BankName=MVen_BankName.Text ;
// ObjAT_Cust.MVen_AccountHolderName=MVen_AccountHolderName.Text ;
// ObjAT_Cust.MVen_IFSCNo=MVen_IFSCNo.Text ;
// ObjAT_Cust.MVen_AccountNo=MVen_AccountNo.Text ;
// ObjAT_Cust.MVen_BankBranch=MVen_BankBranch.Text ;
// ObjAT_Cust.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_Cust.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_Cust.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_Cust.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_Cust.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_Cust.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_Cust.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;
// ObjAT_Cust.MVen_RegType=MVen_RegType.Text ;
// ObjAT_Cust.MVen_NatureOfBusiness=MVen_NatureOfBusiness.Text ;
// ObjAT_Cust.MVen_Primary_Contact_Designation=MVen_Primary_Contact_Designation.Text ;
// ObjAT_Cust.MVen_Primary_Contact_Person=MVen_Primary_Contact_Person.Text ;
// ObjAT_Cust.MVen_Primary_CP_PhoneNo=MVen_Primary_CP_PhoneNo.Text ;
// ObjAT_Cust.MVen_Primary_CP_MobileNo=MVen_Primary_CP_MobileNo.Text ;
// ObjAT_Cust.MVen_Primary_CP_MobileNo_Alt=MVen_Primary_CP_MobileNo_Alt.Text ;
// ObjAT_Cust.MVen_Primary_CP_EmailID=MVen_Primary_CP_EmailID.Text ;
// ObjAT_Cust.MVen_Primary_CP_EmailID_Alt=MVen_Primary_CP_EmailID_Alt.Text ;
// ObjAT_Cust.MVen_Contact_OfficeNo1=MVen_Contact_OfficeNo1.Text ;
// ObjAT_Cust.MVen_Contact_OfficeNo2=MVen_Contact_OfficeNo2.Text ;
// ObjAT_Cust.MVen_Contact_OfficeNo_Alt=MVen_Contact_OfficeNo_Alt.Text ;
// ObjAT_Cust.MVen_Contact_FaxNo=MVen_Contact_FaxNo.Text ;
// ObjAT_Cust.MVen_Contact_Email_Admin=MVen_Contact_Email_Admin.Text ;
// ObjAT_Cust.MVen_Contact_Email_Info=MVen_Contact_Email_Info.Text ;
// ObjAT_Cust.MVen_Contact_Email_Sales=MVen_Contact_Email_Sales.Text ;
// ObjAT_Cust.MVen_Contact_Email_Tech=MVen_Contact_Email_Tech.Text ;
// ObjAT_Cust.MVen_Contact_Website=MVen_Contact_Website.Text ;
// ObjAT_Cust.MVen_BL_VATNO=MVen_BL_VATNO.Text ;
// ObjAT_Cust.MVen_BL_CSTNO=MVen_BL_CSTNO.Text ;
// ObjAT_Cust.MVen_BL_TINNO=MVen_BL_TINNO.Text ;
// ObjAT_Cust.MVen_BL_ServiceTaxNo=MVen_BL_ServiceTaxNo.Text ;
// ObjAT_Cust.MVen_BL_ExciseRegNo=MVen_BL_ExciseRegNo.Text ;
// ObjAT_Cust.MVen_BL_PANNO=MVen_BL_PANNO.Text ;
// ObjAT_Cust.MVen_BL_GSTNO=MVen_BL_GSTNO.Text ;
// ObjAT_Cust.MVen_BL_ARNO=MVen_BL_ARNO.Text ;



// M_Ven_ID.Text =  dt.Rows[0]["M_Ven_ID"].ToString();
// Fk_Company_ID.Text =  dt.Rows[0]["Fk_Company_ID"].ToString();
// Fk_Branch_ID.Text =  dt.Rows[0]["Fk_Branch_ID"].ToString();
// Fk_Year_ID.Text =  dt.Rows[0]["Fk_Year_ID"].ToString();
// MVen_Code.Text =  dt.Rows[0]["MVen_Code"].ToString();
// MVen_Name.Text =  dt.Rows[0]["MVen_Name"].ToString();
// MVen_DisplayName.Text =  dt.Rows[0]["MVen_DisplayName"].ToString();
// MVen_TradeName.Text =  dt.Rows[0]["MVen_TradeName"].ToString();
// MVen_Reg_Add1.Text =  dt.Rows[0]["MVen_Reg_Add1"].ToString();
// MVen_Reg_Add2.Text =  dt.Rows[0]["MVen_Reg_Add2"].ToString();
// MVen_Reg_Add3.Text =  dt.Rows[0]["MVen_Reg_Add3"].ToString();
// MVen_Reg_Pincode.Text =  dt.Rows[0]["MVen_Reg_Pincode"].ToString();
// MVen_Reg_Area.Text =  dt.Rows[0]["MVen_Reg_Area"].ToString();
// MVen_Reg_City.Text =  dt.Rows[0]["MVen_Reg_City"].ToString();
// MVen_Reg_State_ID.Text =  dt.Rows[0]["MVen_Reg_State_ID"].ToString();
// MVen_Reg_Country.Text =  dt.Rows[0]["MVen_Reg_Country"].ToString();
// MVen_DispatchFrom_CompanyName.Text =  dt.Rows[0]["MVen_DispatchFrom_CompanyName"].ToString();
// MVen_DispatchFrom_ContactPerson.Text =  dt.Rows[0]["MVen_DispatchFrom_ContactPerson"].ToString();
// MVen_DispatchFrom_CP_MobileNo.Text =  dt.Rows[0]["MVen_DispatchFrom_CP_MobileNo"].ToString();
// MVen_DispatchFrom_Add1.Text =  dt.Rows[0]["MVen_DispatchFrom_Add1"].ToString();
// MVen_DispatchFrom_Add2.Text =  dt.Rows[0]["MVen_DispatchFrom_Add2"].ToString();
// MVen_DispatchFrom_Add3.Text =  dt.Rows[0]["MVen_DispatchFrom_Add3"].ToString();
// MVen_DispatchFrom_Pincode.Text =  dt.Rows[0]["MVen_DispatchFrom_Pincode"].ToString();
// MVen_DispatchFrom_Area.Text =  dt.Rows[0]["MVen_DispatchFrom_Area"].ToString();
// MVen_DispatchFrom_City.Text =  dt.Rows[0]["MVen_DispatchFrom_City"].ToString();
// MVen_DispatchFrom_State_ID.Text =  dt.Rows[0]["MVen_DispatchFrom_State_ID"].ToString();
// MVen_DispatchFrom_Country.Text =  dt.Rows[0]["MVen_DispatchFrom_Country"].ToString();
// MVen_DispatchFrom_PANNO.Text =  dt.Rows[0]["MVen_DispatchFrom_PANNO"].ToString();
// MVen_DispatchFrom_GSTNO.Text =  dt.Rows[0]["MVen_DispatchFrom_GSTNO"].ToString();
// MVen_DispatchFrom_ARNO.Text =  dt.Rows[0]["MVen_DispatchFrom_ARNO"].ToString();
// MVen_BankName.Text =  dt.Rows[0]["MVen_BankName"].ToString();
// MVen_AccountHolderName.Text =  dt.Rows[0]["MVen_AccountHolderName"].ToString();
// MVen_IFSCNo.Text =  dt.Rows[0]["MVen_IFSCNo"].ToString();
// MVen_AccountNo.Text =  dt.Rows[0]["MVen_AccountNo"].ToString();
// MVen_BankBranch.Text =  dt.Rows[0]["MVen_BankBranch"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
// MVen_RegType.Text =  dt.Rows[0]["MVen_RegType"].ToString();
// MVen_NatureOfBusiness.Text =  dt.Rows[0]["MVen_NatureOfBusiness"].ToString();
// MVen_Primary_Contact_Designation.Text =  dt.Rows[0]["MVen_Primary_Contact_Designation"].ToString();
// MVen_Primary_Contact_Person.Text =  dt.Rows[0]["MVen_Primary_Contact_Person"].ToString();
// MVen_Primary_CP_PhoneNo.Text =  dt.Rows[0]["MVen_Primary_CP_PhoneNo"].ToString();
// MVen_Primary_CP_MobileNo.Text =  dt.Rows[0]["MVen_Primary_CP_MobileNo"].ToString();
// MVen_Primary_CP_MobileNo_Alt.Text =  dt.Rows[0]["MVen_Primary_CP_MobileNo_Alt"].ToString();
// MVen_Primary_CP_EmailID.Text =  dt.Rows[0]["MVen_Primary_CP_EmailID"].ToString();
// MVen_Primary_CP_EmailID_Alt.Text =  dt.Rows[0]["MVen_Primary_CP_EmailID_Alt"].ToString();
// MVen_Contact_OfficeNo1.Text =  dt.Rows[0]["MVen_Contact_OfficeNo1"].ToString();
// MVen_Contact_OfficeNo2.Text =  dt.Rows[0]["MVen_Contact_OfficeNo2"].ToString();
// MVen_Contact_OfficeNo_Alt.Text =  dt.Rows[0]["MVen_Contact_OfficeNo_Alt"].ToString();
// MVen_Contact_FaxNo.Text =  dt.Rows[0]["MVen_Contact_FaxNo"].ToString();
// MVen_Contact_Email_Admin.Text =  dt.Rows[0]["MVen_Contact_Email_Admin"].ToString();
// MVen_Contact_Email_Info.Text =  dt.Rows[0]["MVen_Contact_Email_Info"].ToString();
// MVen_Contact_Email_Sales.Text =  dt.Rows[0]["MVen_Contact_Email_Sales"].ToString();
// MVen_Contact_Email_Tech.Text =  dt.Rows[0]["MVen_Contact_Email_Tech"].ToString();
// MVen_Contact_Website.Text =  dt.Rows[0]["MVen_Contact_Website"].ToString();
// MVen_BL_VATNO.Text =  dt.Rows[0]["MVen_BL_VATNO"].ToString();
// MVen_BL_CSTNO.Text =  dt.Rows[0]["MVen_BL_CSTNO"].ToString();
// MVen_BL_TINNO.Text =  dt.Rows[0]["MVen_BL_TINNO"].ToString();
// MVen_BL_ServiceTaxNo.Text =  dt.Rows[0]["MVen_BL_ServiceTaxNo"].ToString();
// MVen_BL_ExciseRegNo.Text =  dt.Rows[0]["MVen_BL_ExciseRegNo"].ToString();
// MVen_BL_PANNO.Text =  dt.Rows[0]["MVen_BL_PANNO"].ToString();
// MVen_BL_GSTNO.Text =  dt.Rows[0]["MVen_BL_GSTNO"].ToString();
// MVen_BL_ARNO.Text =  dt.Rows[0]["MVen_BL_ARNO"].ToString();
