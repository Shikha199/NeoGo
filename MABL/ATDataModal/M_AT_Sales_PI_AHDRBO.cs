using System;
using System.Collections;
using System.Data;
using   MaheshAF18.DataAccess;
namespace MABL.ATDataModal 
{
public class M_AT_Sales_PI_AHDRBO
{
MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
#region Constructor 
public M_AT_Sales_PI_AHDRBO() { }
#endregion 
#region Standard Property
private string _PrimaryKeyName = "SPIHDR_ID";
private string _TableName = "M_AT_Sales_PI_AHDR";
private string _PrimaryKeyValue = "0"; 
private ArrayList _UpdateFieldName = new ArrayList();
public string TableName
{
get{return _TableName;}
set{this._TableName = value;}
}
public string PrimaryKeyName
{
get{return _PrimaryKeyName;}
set{this._PrimaryKeyName = value;}
}
public string PrimaryKeyValue
        {
get{return _PrimaryKeyValue;}
set{this._PrimaryKeyValue = value;}
}
public ArrayList UpdateFieldName
{
get{return _UpdateFieldName;}
set{this._UpdateFieldName = value;}
}
#endregion
#region Table Properties

private Int64 _SPIHDR_ID;
private Int64 _Fk_PIHDR_ID;
private Int64 _Fk_Company_ID;
private Int64 _Fk_Branch_ID;
private Int64 _Fk_Year_ID;
private Int32 _Fk_Currency_ID;
private String _Rec_Created_In;
private Int64 _Rec_CreatedBy_ID;
private Int64 _Rec_CreatedFor_ID;
private String _SPI_CreationType;
private String _SPI_Type;
private String _SPI_Category;
private String _SPI_Taxtype;
private String _SPI_No;
private String _SPI_DT;
private Int64 _Fk_CustomerID;
private Int64 _SPI_CreditDays;
private String _SPI_DueDT;
private Int64 _SPI_State_ID;
private String _SPI_PONo;
private String _SPI_PO_DT;
private String _SPI_BillTo_CompanyName;
private String _SPI_BillTo_ContactPersone;
private String _SPI_BillTo_CP_MobileNo;
private String _SPI_BillTo_Add1;
private String _SPI_BillTo_Add2;
private String _SPI_BillTo_Add3;
private String _SPI_BillTo_Pincode;
private String _SPI_BillTo_Area;
private String _SPI_BillTo_City;
private Int64 _SPI_BillTo_State_ID;
private String _SPI_BillTo_Country;
private String _SPI_BillTo_GSTNo;
private String _SPI_BillTo_PANNO;
private String _SPI_ShippTo_CompanyName;
private String _SPI_ShippTo_ContactPersone;
private String _SPI_ShippTo_CP_MobileNo;
private String _SPI_ShippTo_Add1;
private String _SPI_ShippTo_Add2;
private String _SPI_ShippTo_Add3;
private String _SPI_ShippTo_Pincode;
private String _SPI_ShippTo_Area;
private String _SPI_ShippTo_City;
private Int64 _SPI_ShippTo_State_ID;
private String _SPI_ShippTo_Country;
private String _SPI_ShippTo_GSTNo;
private String _SPI_ShippTo_PANNO;
private String _SPI_ShippedFrom_CompanyName;
private String _SPI_ShippedFrom_ContactPersone;
private String _SPI_ShippedFrom_CP_MobileNo;
private String _SPI_ShippedFrom_Add1;
private String _SPI_ShippedFrom_Add2;
private String _SPI_ShippedFrom_Add3;
private String _SPI_ShippedFrom_Pincode;
private String _SPI_ShippedFrom_Area;
private String _SPI_ShippedFrom_City;
private Int64 _SPI_ShippedFrom_State_ID;
private String _SPI_ShippedFrom_Country;
private String _SPI_ShippedFrom_GSTNo;
private String _SPI_ShippedFrom_PANNO;
private String _SPI_PaymentTerms;
private String _SPI_DelvieryPeriod;
private String _SPI_DeliveryCharges;
private String _SPI_ExciseDuty;
private String _SPI_CompletionPeriod;
private String _SPI_ModeOfDispatch;
private String _SPI_TranspoterName;
private String _SPI_VehicleNumber;
private String _SPI_PlaceOfDelivery;
private String _SPI_FreigthCharge_Txt;
private String _SPI_Insurance_Txt;
private String _SPI_Remark;
private Int16 _SPI_L1AuthorizeID;
private String _SPI_L1AuthorizeBy;
private String _SPI_L1AuthorizeDT;
private Int16 _SPI_L2AuthorizeID;
private String _SPI_L2AuthorizeBy;
private String _SPI_L2AuthorizeDT;
private String _SPI_AuthRemark;
private Int16 _SPI_DTL_CNT;
private String _MDBSC_RowStatus;
private Int16 _MDBSC_RowCreatedByUser_ID;
private String _MDBSC_RowCreatedByUserName;
private String _MDBSC_RowCreatedOn_DT;
private Int16 _MDBSC_RowLupdnByUser_ID;
private String _MDBSC_RowLupdnUserName;
private String _MDBSC_RowLupdnOn_DT;
private Decimal _SPI_HDR_BasicAmt;
private Decimal _SPI_HDR_DiscountRate;
private Decimal _SPI_HDR_DiscountAmt;
private Decimal _SPI_HDR_Net_Amt;
private Decimal _SPI_HDR_Freight_Charges;
private Decimal _SPI_HDR_Loading_N_Packing_Charges;
private Decimal _SPI_HDR_Insurance_Charges;
private String _SPI_HDR_Other_Charges_Txt;
private Decimal _SPI_HDR_Other_Charges_Amt;
private Decimal _SPI_HDR_Taxable_Amt;
private Decimal _SPI_HDR_CGST_Amt;
private Decimal _SPI_HDR_CGST_Taxable_Amt;
private Decimal _SPI_HDR_SGST_Amt;
private Decimal _SPI_HDR_SGST_Taxable_Amt;
private Decimal _SPI_HDR_IGST_Amt;
private Decimal _SPI_HDR_IGST_Taxable_Amt;
private Decimal _SPI_HDR_CESS_Amt;
private Decimal _SPI_HDR_CESS_Taxable_Amt;
private Int16 _SPI_HDR_OtherTax_ID;
private Decimal _SPI_HDR_OtherTax_Rate;
private Decimal _SPI_HDR_OtherTax_Amt;
private Decimal _SPI_HDR_Other_Taxable_Amt;
private Decimal _SPI_HDR_Total_Tax_Amt;
private Decimal _SPI_HDR_ItemGross_Total_Amt;
private Decimal _SPI_HDR_Gross_Amt;
private Decimal _SPI_HDR_Round_Off_Amt;
private Decimal _SPI_HDR_Total_Gross_Amt;
private String _SPI_HDR_Gross_AmtInWords;
private Decimal _SPI_HDR_CreditNote_AsOn_Amt;
private Decimal _SPI_HDR_DebitNote_AsOn_Amt;
private Decimal _SPI_HDR_TDS_Rate;
private Decimal _SPI_HDR_TDS_Amt;
private Decimal _SPI_HDR_Paid_AsOn_Amt;
private Decimal _SPI_HDR_Outstanding_AsOn_Amt;

public Int64 SPIHDR_ID
{
get
  {
   return this._SPIHDR_ID;  }
set
   {
     this._SPIHDR_ID = value;
     _UpdateFieldName.Add("SPIHDR_ID");
     }
}
public Int64 Fk_PIHDR_ID
{
get
  {
   return this._Fk_PIHDR_ID;  }
set
   {
     this._Fk_PIHDR_ID = value;
     _UpdateFieldName.Add("Fk_PIHDR_ID");
     }
}
public Int64 Fk_Company_ID
{
get
  {
   return this._Fk_Company_ID;  }
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
   return this._Fk_Branch_ID;  }
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
   return this._Fk_Year_ID;  }
set
   {
     this._Fk_Year_ID = value;
     _UpdateFieldName.Add("Fk_Year_ID");
     }
}
public Int32 Fk_Currency_ID
{
get
  {
   return this._Fk_Currency_ID;  }
set
   {
     this._Fk_Currency_ID = value;
     _UpdateFieldName.Add("Fk_Currency_ID");
     }
}
public String Rec_Created_In
{
get
  {
   return this._Rec_Created_In;  }
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
   return this._Rec_CreatedBy_ID;  }
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
   return this._Rec_CreatedFor_ID;  }
set
   {
     this._Rec_CreatedFor_ID = value;
     _UpdateFieldName.Add("Rec_CreatedFor_ID");
     }
}
public String SPI_CreationType
{
get
  {
   return this._SPI_CreationType;  }
set
   {
     this._SPI_CreationType = value;
     _UpdateFieldName.Add("SPI_CreationType");
     }
}
public String SPI_Type
{
get
  {
   return this._SPI_Type;  }
set
   {
     this._SPI_Type = value;
     _UpdateFieldName.Add("SPI_Type");
     }
}
public String SPI_Category
{
get
  {
   return this._SPI_Category;  }
set
   {
     this._SPI_Category = value;
     _UpdateFieldName.Add("SPI_Category");
     }
}
public String SPI_Taxtype
{
get
  {
   return this._SPI_Taxtype;  }
set
   {
     this._SPI_Taxtype = value;
     _UpdateFieldName.Add("SPI_Taxtype");
     }
}
public String SPI_No
{
get
  {
   return this._SPI_No;  }
set
   {
     this._SPI_No = value;
     _UpdateFieldName.Add("SPI_No");
     }
}
public String SPI_DT
{
get
  {
   return this._SPI_DT;  }
set
   {
     this._SPI_DT = value;
     _UpdateFieldName.Add("SPI_DT");
     }
}
public Int64 Fk_CustomerID
{
get
  {
   return this._Fk_CustomerID;  }
set
   {
     this._Fk_CustomerID = value;
     _UpdateFieldName.Add("Fk_CustomerID");
     }
}
public Int64 SPI_CreditDays
{
get
  {
   return this._SPI_CreditDays;  }
set
   {
     this._SPI_CreditDays = value;
     _UpdateFieldName.Add("SPI_CreditDays");
     }
}
public String SPI_DueDT
{
get
  {
   return this._SPI_DueDT;  }
set
   {
     this._SPI_DueDT = value;
     _UpdateFieldName.Add("SPI_DueDT");
     }
}
public Int64 SPI_State_ID
{
get
  {
   return this._SPI_State_ID;  }
set
   {
     this._SPI_State_ID = value;
     _UpdateFieldName.Add("SPI_State_ID");
     }
}
public String SPI_PONo
{
get
  {
   return this._SPI_PONo;  }
set
   {
     this._SPI_PONo = value;
     _UpdateFieldName.Add("SPI_PONo");
     }
}
public String SPI_PO_DT
{
get
  {
   return this._SPI_PO_DT;  }
set
   {
     this._SPI_PO_DT = value;
     _UpdateFieldName.Add("SPI_PO_DT");
     }
}
public String SPI_BillTo_CompanyName
{
get
  {
   return this._SPI_BillTo_CompanyName;  }
set
   {
     this._SPI_BillTo_CompanyName = value;
     _UpdateFieldName.Add("SPI_BillTo_CompanyName");
     }
}
public String SPI_BillTo_ContactPersone
{
get
  {
   return this._SPI_BillTo_ContactPersone;  }
set
   {
     this._SPI_BillTo_ContactPersone = value;
     _UpdateFieldName.Add("SPI_BillTo_ContactPersone");
     }
}
public String SPI_BillTo_CP_MobileNo
{
get
  {
   return this._SPI_BillTo_CP_MobileNo;  }
set
   {
     this._SPI_BillTo_CP_MobileNo = value;
     _UpdateFieldName.Add("SPI_BillTo_CP_MobileNo");
     }
}
public String SPI_BillTo_Add1
{
get
  {
   return this._SPI_BillTo_Add1;  }
set
   {
     this._SPI_BillTo_Add1 = value;
     _UpdateFieldName.Add("SPI_BillTo_Add1");
     }
}
public String SPI_BillTo_Add2
{
get
  {
   return this._SPI_BillTo_Add2;  }
set
   {
     this._SPI_BillTo_Add2 = value;
     _UpdateFieldName.Add("SPI_BillTo_Add2");
     }
}
public String SPI_BillTo_Add3
{
get
  {
   return this._SPI_BillTo_Add3;  }
set
   {
     this._SPI_BillTo_Add3 = value;
     _UpdateFieldName.Add("SPI_BillTo_Add3");
     }
}
public String SPI_BillTo_Pincode
{
get
  {
   return this._SPI_BillTo_Pincode;  }
set
   {
     this._SPI_BillTo_Pincode = value;
     _UpdateFieldName.Add("SPI_BillTo_Pincode");
     }
}
public String SPI_BillTo_Area
{
get
  {
   return this._SPI_BillTo_Area;  }
set
   {
     this._SPI_BillTo_Area = value;
     _UpdateFieldName.Add("SPI_BillTo_Area");
     }
}
public String SPI_BillTo_City
{
get
  {
   return this._SPI_BillTo_City;  }
set
   {
     this._SPI_BillTo_City = value;
     _UpdateFieldName.Add("SPI_BillTo_City");
     }
}
public Int64 SPI_BillTo_State_ID
{
get
  {
   return this._SPI_BillTo_State_ID;  }
set
   {
     this._SPI_BillTo_State_ID = value;
     _UpdateFieldName.Add("SPI_BillTo_State_ID");
     }
}
public String SPI_BillTo_Country
{
get
  {
   return this._SPI_BillTo_Country;  }
set
   {
     this._SPI_BillTo_Country = value;
     _UpdateFieldName.Add("SPI_BillTo_Country");
     }
}
public String SPI_BillTo_GSTNo
{
get
  {
   return this._SPI_BillTo_GSTNo;  }
set
   {
     this._SPI_BillTo_GSTNo = value;
     _UpdateFieldName.Add("SPI_BillTo_GSTNo");
     }
}
public String SPI_BillTo_PANNO
{
get
  {
   return this._SPI_BillTo_PANNO;  }
set
   {
     this._SPI_BillTo_PANNO = value;
     _UpdateFieldName.Add("SPI_BillTo_PANNO");
     }
}
public String SPI_ShippTo_CompanyName
{
get
  {
   return this._SPI_ShippTo_CompanyName;  }
set
   {
     this._SPI_ShippTo_CompanyName = value;
     _UpdateFieldName.Add("SPI_ShippTo_CompanyName");
     }
}
public String SPI_ShippTo_ContactPersone
{
get
  {
   return this._SPI_ShippTo_ContactPersone;  }
set
   {
     this._SPI_ShippTo_ContactPersone = value;
     _UpdateFieldName.Add("SPI_ShippTo_ContactPersone");
     }
}
public String SPI_ShippTo_CP_MobileNo
{
get
  {
   return this._SPI_ShippTo_CP_MobileNo;  }
set
   {
     this._SPI_ShippTo_CP_MobileNo = value;
     _UpdateFieldName.Add("SPI_ShippTo_CP_MobileNo");
     }
}
public String SPI_ShippTo_Add1
{
get
  {
   return this._SPI_ShippTo_Add1;  }
set
   {
     this._SPI_ShippTo_Add1 = value;
     _UpdateFieldName.Add("SPI_ShippTo_Add1");
     }
}
public String SPI_ShippTo_Add2
{
get
  {
   return this._SPI_ShippTo_Add2;  }
set
   {
     this._SPI_ShippTo_Add2 = value;
     _UpdateFieldName.Add("SPI_ShippTo_Add2");
     }
}
public String SPI_ShippTo_Add3
{
get
  {
   return this._SPI_ShippTo_Add3;  }
set
   {
     this._SPI_ShippTo_Add3 = value;
     _UpdateFieldName.Add("SPI_ShippTo_Add3");
     }
}
public String SPI_ShippTo_Pincode
{
get
  {
   return this._SPI_ShippTo_Pincode;  }
set
   {
     this._SPI_ShippTo_Pincode = value;
     _UpdateFieldName.Add("SPI_ShippTo_Pincode");
     }
}
public String SPI_ShippTo_Area
{
get
  {
   return this._SPI_ShippTo_Area;  }
set
   {
     this._SPI_ShippTo_Area = value;
     _UpdateFieldName.Add("SPI_ShippTo_Area");
     }
}
public String SPI_ShippTo_City
{
get
  {
   return this._SPI_ShippTo_City;  }
set
   {
     this._SPI_ShippTo_City = value;
     _UpdateFieldName.Add("SPI_ShippTo_City");
     }
}
public Int64 SPI_ShippTo_State_ID
{
get
  {
   return this._SPI_ShippTo_State_ID;  }
set
   {
     this._SPI_ShippTo_State_ID = value;
     _UpdateFieldName.Add("SPI_ShippTo_State_ID");
     }
}
public String SPI_ShippTo_Country
{
get
  {
   return this._SPI_ShippTo_Country;  }
set
   {
     this._SPI_ShippTo_Country = value;
     _UpdateFieldName.Add("SPI_ShippTo_Country");
     }
}
public String SPI_ShippTo_GSTNo
{
get
  {
   return this._SPI_ShippTo_GSTNo;  }
set
   {
     this._SPI_ShippTo_GSTNo = value;
     _UpdateFieldName.Add("SPI_ShippTo_GSTNo");
     }
}
public String SPI_ShippTo_PANNO
{
get
  {
   return this._SPI_ShippTo_PANNO;  }
set
   {
     this._SPI_ShippTo_PANNO = value;
     _UpdateFieldName.Add("SPI_ShippTo_PANNO");
     }
}
public String SPI_ShippedFrom_CompanyName
{
get
  {
   return this._SPI_ShippedFrom_CompanyName;  }
set
   {
     this._SPI_ShippedFrom_CompanyName = value;
     _UpdateFieldName.Add("SPI_ShippedFrom_CompanyName");
     }
}
public String SPI_ShippedFrom_ContactPersone
{
get
  {
   return this._SPI_ShippedFrom_ContactPersone;  }
set
   {
     this._SPI_ShippedFrom_ContactPersone = value;
     _UpdateFieldName.Add("SPI_ShippedFrom_ContactPersone");
     }
}
public String SPI_ShippedFrom_CP_MobileNo
{
get
  {
   return this._SPI_ShippedFrom_CP_MobileNo;  }
set
   {
     this._SPI_ShippedFrom_CP_MobileNo = value;
     _UpdateFieldName.Add("SPI_ShippedFrom_CP_MobileNo");
     }
}
public String SPI_ShippedFrom_Add1
{
get
  {
   return this._SPI_ShippedFrom_Add1;  }
set
   {
     this._SPI_ShippedFrom_Add1 = value;
     _UpdateFieldName.Add("SPI_ShippedFrom_Add1");
     }
}
public String SPI_ShippedFrom_Add2
{
get
  {
   return this._SPI_ShippedFrom_Add2;  }
set
   {
     this._SPI_ShippedFrom_Add2 = value;
     _UpdateFieldName.Add("SPI_ShippedFrom_Add2");
     }
}
public String SPI_ShippedFrom_Add3
{
get
  {
   return this._SPI_ShippedFrom_Add3;  }
set
   {
     this._SPI_ShippedFrom_Add3 = value;
     _UpdateFieldName.Add("SPI_ShippedFrom_Add3");
     }
}
public String SPI_ShippedFrom_Pincode
{
get
  {
   return this._SPI_ShippedFrom_Pincode;  }
set
   {
     this._SPI_ShippedFrom_Pincode = value;
     _UpdateFieldName.Add("SPI_ShippedFrom_Pincode");
     }
}
public String SPI_ShippedFrom_Area
{
get
  {
   return this._SPI_ShippedFrom_Area;  }
set
   {
     this._SPI_ShippedFrom_Area = value;
     _UpdateFieldName.Add("SPI_ShippedFrom_Area");
     }
}
public String SPI_ShippedFrom_City
{
get
  {
   return this._SPI_ShippedFrom_City;  }
set
   {
     this._SPI_ShippedFrom_City = value;
     _UpdateFieldName.Add("SPI_ShippedFrom_City");
     }
}
public Int64 SPI_ShippedFrom_State_ID
{
get
  {
   return this._SPI_ShippedFrom_State_ID;  }
set
   {
     this._SPI_ShippedFrom_State_ID = value;
     _UpdateFieldName.Add("SPI_ShippedFrom_State_ID");
     }
}
public String SPI_ShippedFrom_Country
{
get
  {
   return this._SPI_ShippedFrom_Country;  }
set
   {
     this._SPI_ShippedFrom_Country = value;
     _UpdateFieldName.Add("SPI_ShippedFrom_Country");
     }
}
public String SPI_ShippedFrom_GSTNo
{
get
  {
   return this._SPI_ShippedFrom_GSTNo;  }
set
   {
     this._SPI_ShippedFrom_GSTNo = value;
     _UpdateFieldName.Add("SPI_ShippedFrom_GSTNo");
     }
}
public String SPI_ShippedFrom_PANNO
{
get
  {
   return this._SPI_ShippedFrom_PANNO;  }
set
   {
     this._SPI_ShippedFrom_PANNO = value;
     _UpdateFieldName.Add("SPI_ShippedFrom_PANNO");
     }
}
public String SPI_PaymentTerms
{
get
  {
   return this._SPI_PaymentTerms;  }
set
   {
     this._SPI_PaymentTerms = value;
     _UpdateFieldName.Add("SPI_PaymentTerms");
     }
}
public String SPI_DelvieryPeriod
{
get
  {
   return this._SPI_DelvieryPeriod;  }
set
   {
     this._SPI_DelvieryPeriod = value;
     _UpdateFieldName.Add("SPI_DelvieryPeriod");
     }
}
public String SPI_DeliveryCharges
{
get
  {
   return this._SPI_DeliveryCharges;  }
set
   {
     this._SPI_DeliveryCharges = value;
     _UpdateFieldName.Add("SPI_DeliveryCharges");
     }
}
public String SPI_ExciseDuty
{
get
  {
   return this._SPI_ExciseDuty;  }
set
   {
     this._SPI_ExciseDuty = value;
     _UpdateFieldName.Add("SPI_ExciseDuty");
     }
}
public String SPI_CompletionPeriod
{
get
  {
   return this._SPI_CompletionPeriod;  }
set
   {
     this._SPI_CompletionPeriod = value;
     _UpdateFieldName.Add("SPI_CompletionPeriod");
     }
}
public String SPI_ModeOfDispatch
{
get
  {
   return this._SPI_ModeOfDispatch;  }
set
   {
     this._SPI_ModeOfDispatch = value;
     _UpdateFieldName.Add("SPI_ModeOfDispatch");
     }
}
public String SPI_TranspoterName
{
get
  {
   return this._SPI_TranspoterName;  }
set
   {
     this._SPI_TranspoterName = value;
     _UpdateFieldName.Add("SPI_TranspoterName");
     }
}
public String SPI_VehicleNumber
{
get
  {
   return this._SPI_VehicleNumber;  }
set
   {
     this._SPI_VehicleNumber = value;
     _UpdateFieldName.Add("SPI_VehicleNumber");
     }
}
public String SPI_PlaceOfDelivery
{
get
  {
   return this._SPI_PlaceOfDelivery;  }
set
   {
     this._SPI_PlaceOfDelivery = value;
     _UpdateFieldName.Add("SPI_PlaceOfDelivery");
     }
}
public String SPI_FreigthCharge_Txt
{
get
  {
   return this._SPI_FreigthCharge_Txt;  }
set
   {
     this._SPI_FreigthCharge_Txt = value;
     _UpdateFieldName.Add("SPI_FreigthCharge_Txt");
     }
}
public String SPI_Insurance_Txt
{
get
  {
   return this._SPI_Insurance_Txt;  }
set
   {
     this._SPI_Insurance_Txt = value;
     _UpdateFieldName.Add("SPI_Insurance_Txt");
     }
}
public String SPI_Remark
{
get
  {
   return this._SPI_Remark;  }
set
   {
     this._SPI_Remark = value;
     _UpdateFieldName.Add("SPI_Remark");
     }
}
public Int16 SPI_L1AuthorizeID
{
get
  {
   return this._SPI_L1AuthorizeID;  }
set
   {
     this._SPI_L1AuthorizeID = value;
     _UpdateFieldName.Add("SPI_L1AuthorizeID");
     }
}
public String SPI_L1AuthorizeBy
{
get
  {
   return this._SPI_L1AuthorizeBy;  }
set
   {
     this._SPI_L1AuthorizeBy = value;
     _UpdateFieldName.Add("SPI_L1AuthorizeBy");
     }
}
public String SPI_L1AuthorizeDT
{
get
  {
   return this._SPI_L1AuthorizeDT;  }
set
   {
     this._SPI_L1AuthorizeDT = value;
     _UpdateFieldName.Add("SPI_L1AuthorizeDT");
     }
}
public Int16 SPI_L2AuthorizeID
{
get
  {
   return this._SPI_L2AuthorizeID;  }
set
   {
     this._SPI_L2AuthorizeID = value;
     _UpdateFieldName.Add("SPI_L2AuthorizeID");
     }
}
public String SPI_L2AuthorizeBy
{
get
  {
   return this._SPI_L2AuthorizeBy;  }
set
   {
     this._SPI_L2AuthorizeBy = value;
     _UpdateFieldName.Add("SPI_L2AuthorizeBy");
     }
}
public String SPI_L2AuthorizeDT
{
get
  {
   return this._SPI_L2AuthorizeDT;  }
set
   {
     this._SPI_L2AuthorizeDT = value;
     _UpdateFieldName.Add("SPI_L2AuthorizeDT");
     }
}
public String SPI_AuthRemark
{
get
  {
   return this._SPI_AuthRemark;  }
set
   {
     this._SPI_AuthRemark = value;
     _UpdateFieldName.Add("SPI_AuthRemark");
     }
}
public Int16 SPI_DTL_CNT
{
get
  {
   return this._SPI_DTL_CNT;  }
set
   {
     this._SPI_DTL_CNT = value;
     _UpdateFieldName.Add("SPI_DTL_CNT");
     }
}
public String MDBSC_RowStatus
{
get
  {
   return this._MDBSC_RowStatus;  }
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
   return this._MDBSC_RowCreatedByUser_ID;  }
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
   return this._MDBSC_RowCreatedByUserName;  }
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
   return this._MDBSC_RowCreatedOn_DT;  }
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
   return this._MDBSC_RowLupdnByUser_ID;  }
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
   return this._MDBSC_RowLupdnUserName;  }
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
   return this._MDBSC_RowLupdnOn_DT;  }
set
   {
     this._MDBSC_RowLupdnOn_DT = value;
     _UpdateFieldName.Add("MDBSC_RowLupdnOn_DT");
     }
}
public Decimal SPI_HDR_BasicAmt
{
get
  {
   return this._SPI_HDR_BasicAmt;  }
set
   {
     this._SPI_HDR_BasicAmt = value;
     _UpdateFieldName.Add("SPI_HDR_BasicAmt");
     }
}
public Decimal SPI_HDR_DiscountRate
{
get
  {
   return this._SPI_HDR_DiscountRate;  }
set
   {
     this._SPI_HDR_DiscountRate = value;
     _UpdateFieldName.Add("SPI_HDR_DiscountRate");
     }
}
public Decimal SPI_HDR_DiscountAmt
{
get
  {
   return this._SPI_HDR_DiscountAmt;  }
set
   {
     this._SPI_HDR_DiscountAmt = value;
     _UpdateFieldName.Add("SPI_HDR_DiscountAmt");
     }
}
public Decimal SPI_HDR_Net_Amt
{
get
  {
   return this._SPI_HDR_Net_Amt;  }
set
   {
     this._SPI_HDR_Net_Amt = value;
     _UpdateFieldName.Add("SPI_HDR_Net_Amt");
     }
}
public Decimal SPI_HDR_Freight_Charges
{
get
  {
   return this._SPI_HDR_Freight_Charges;  }
set
   {
     this._SPI_HDR_Freight_Charges = value;
     _UpdateFieldName.Add("SPI_HDR_Freight_Charges");
     }
}
public Decimal SPI_HDR_Loading_N_Packing_Charges
{
get
  {
   return this._SPI_HDR_Loading_N_Packing_Charges;  }
set
   {
     this._SPI_HDR_Loading_N_Packing_Charges = value;
     _UpdateFieldName.Add("SPI_HDR_Loading_N_Packing_Charges");
     }
}
public Decimal SPI_HDR_Insurance_Charges
{
get
  {
   return this._SPI_HDR_Insurance_Charges;  }
set
   {
     this._SPI_HDR_Insurance_Charges = value;
     _UpdateFieldName.Add("SPI_HDR_Insurance_Charges");
     }
}
public String SPI_HDR_Other_Charges_Txt
{
get
  {
   return this._SPI_HDR_Other_Charges_Txt;  }
set
   {
     this._SPI_HDR_Other_Charges_Txt = value;
     _UpdateFieldName.Add("SPI_HDR_Other_Charges_Txt");
     }
}
public Decimal SPI_HDR_Other_Charges_Amt
{
get
  {
   return this._SPI_HDR_Other_Charges_Amt;  }
set
   {
     this._SPI_HDR_Other_Charges_Amt = value;
     _UpdateFieldName.Add("SPI_HDR_Other_Charges_Amt");
     }
}
public Decimal SPI_HDR_Taxable_Amt
{
get
  {
   return this._SPI_HDR_Taxable_Amt;  }
set
   {
     this._SPI_HDR_Taxable_Amt = value;
     _UpdateFieldName.Add("SPI_HDR_Taxable_Amt");
     }
}
public Decimal SPI_HDR_CGST_Amt
{
get
  {
   return this._SPI_HDR_CGST_Amt;  }
set
   {
     this._SPI_HDR_CGST_Amt = value;
     _UpdateFieldName.Add("SPI_HDR_CGST_Amt");
     }
}
public Decimal SPI_HDR_CGST_Taxable_Amt
{
get
  {
   return this._SPI_HDR_CGST_Taxable_Amt;  }
set
   {
     this._SPI_HDR_CGST_Taxable_Amt = value;
     _UpdateFieldName.Add("SPI_HDR_CGST_Taxable_Amt");
     }
}
public Decimal SPI_HDR_SGST_Amt
{
get
  {
   return this._SPI_HDR_SGST_Amt;  }
set
   {
     this._SPI_HDR_SGST_Amt = value;
     _UpdateFieldName.Add("SPI_HDR_SGST_Amt");
     }
}
public Decimal SPI_HDR_SGST_Taxable_Amt
{
get
  {
   return this._SPI_HDR_SGST_Taxable_Amt;  }
set
   {
     this._SPI_HDR_SGST_Taxable_Amt = value;
     _UpdateFieldName.Add("SPI_HDR_SGST_Taxable_Amt");
     }
}
public Decimal SPI_HDR_IGST_Amt
{
get
  {
   return this._SPI_HDR_IGST_Amt;  }
set
   {
     this._SPI_HDR_IGST_Amt = value;
     _UpdateFieldName.Add("SPI_HDR_IGST_Amt");
     }
}
public Decimal SPI_HDR_IGST_Taxable_Amt
{
get
  {
   return this._SPI_HDR_IGST_Taxable_Amt;  }
set
   {
     this._SPI_HDR_IGST_Taxable_Amt = value;
     _UpdateFieldName.Add("SPI_HDR_IGST_Taxable_Amt");
     }
}
public Decimal SPI_HDR_CESS_Amt
{
get
  {
   return this._SPI_HDR_CESS_Amt;  }
set
   {
     this._SPI_HDR_CESS_Amt = value;
     _UpdateFieldName.Add("SPI_HDR_CESS_Amt");
     }
}
public Decimal SPI_HDR_CESS_Taxable_Amt
{
get
  {
   return this._SPI_HDR_CESS_Taxable_Amt;  }
set
   {
     this._SPI_HDR_CESS_Taxable_Amt = value;
     _UpdateFieldName.Add("SPI_HDR_CESS_Taxable_Amt");
     }
}
public Int16 SPI_HDR_OtherTax_ID
{
get
  {
   return this._SPI_HDR_OtherTax_ID;  }
set
   {
     this._SPI_HDR_OtherTax_ID = value;
     _UpdateFieldName.Add("SPI_HDR_OtherTax_ID");
     }
}
public Decimal SPI_HDR_OtherTax_Rate
{
get
  {
   return this._SPI_HDR_OtherTax_Rate;  }
set
   {
     this._SPI_HDR_OtherTax_Rate = value;
     _UpdateFieldName.Add("SPI_HDR_OtherTax_Rate");
     }
}
public Decimal SPI_HDR_OtherTax_Amt
{
get
  {
   return this._SPI_HDR_OtherTax_Amt;  }
set
   {
     this._SPI_HDR_OtherTax_Amt = value;
     _UpdateFieldName.Add("SPI_HDR_OtherTax_Amt");
     }
}
public Decimal SPI_HDR_Other_Taxable_Amt
{
get
  {
   return this._SPI_HDR_Other_Taxable_Amt;  }
set
   {
     this._SPI_HDR_Other_Taxable_Amt = value;
     _UpdateFieldName.Add("SPI_HDR_Other_Taxable_Amt");
     }
}
public Decimal SPI_HDR_Total_Tax_Amt
{
get
  {
   return this._SPI_HDR_Total_Tax_Amt;  }
set
   {
     this._SPI_HDR_Total_Tax_Amt = value;
     _UpdateFieldName.Add("SPI_HDR_Total_Tax_Amt");
     }
}
public Decimal SPI_HDR_ItemGross_Total_Amt
{
get
  {
   return this._SPI_HDR_ItemGross_Total_Amt;  }
set
   {
     this._SPI_HDR_ItemGross_Total_Amt = value;
     _UpdateFieldName.Add("SPI_HDR_ItemGross_Total_Amt");
     }
}
public Decimal SPI_HDR_Gross_Amt
{
get
  {
   return this._SPI_HDR_Gross_Amt;  }
set
   {
     this._SPI_HDR_Gross_Amt = value;
     _UpdateFieldName.Add("SPI_HDR_Gross_Amt");
     }
}
public Decimal SPI_HDR_Round_Off_Amt
{
get
  {
   return this._SPI_HDR_Round_Off_Amt;  }
set
   {
     this._SPI_HDR_Round_Off_Amt = value;
     _UpdateFieldName.Add("SPI_HDR_Round_Off_Amt");
     }
}
public Decimal SPI_HDR_Total_Gross_Amt
{
get
  {
   return this._SPI_HDR_Total_Gross_Amt;  }
set
   {
     this._SPI_HDR_Total_Gross_Amt = value;
     _UpdateFieldName.Add("SPI_HDR_Total_Gross_Amt");
     }
}
public String SPI_HDR_Gross_AmtInWords
{
get
  {
   return this._SPI_HDR_Gross_AmtInWords;  }
set
   {
     this._SPI_HDR_Gross_AmtInWords = value;
     _UpdateFieldName.Add("SPI_HDR_Gross_AmtInWords");
     }
}
public Decimal SPI_HDR_CreditNote_AsOn_Amt
{
get
  {
   return this._SPI_HDR_CreditNote_AsOn_Amt;  }
set
   {
     this._SPI_HDR_CreditNote_AsOn_Amt = value;
     _UpdateFieldName.Add("SPI_HDR_CreditNote_AsOn_Amt");
     }
}
public Decimal SPI_HDR_DebitNote_AsOn_Amt
{
get
  {
   return this._SPI_HDR_DebitNote_AsOn_Amt;  }
set
   {
     this._SPI_HDR_DebitNote_AsOn_Amt = value;
     _UpdateFieldName.Add("SPI_HDR_DebitNote_AsOn_Amt");
     }
}
public Decimal SPI_HDR_TDS_Rate
{
get
  {
   return this._SPI_HDR_TDS_Rate;  }
set
   {
     this._SPI_HDR_TDS_Rate = value;
     _UpdateFieldName.Add("SPI_HDR_TDS_Rate");
     }
}
public Decimal SPI_HDR_TDS_Amt
{
get
  {
   return this._SPI_HDR_TDS_Amt;  }
set
   {
     this._SPI_HDR_TDS_Amt = value;
     _UpdateFieldName.Add("SPI_HDR_TDS_Amt");
     }
}
public Decimal SPI_HDR_Paid_AsOn_Amt
{
get
  {
   return this._SPI_HDR_Paid_AsOn_Amt;  }
set
   {
     this._SPI_HDR_Paid_AsOn_Amt = value;
     _UpdateFieldName.Add("SPI_HDR_Paid_AsOn_Amt");
     }
}
public Decimal SPI_HDR_Outstanding_AsOn_Amt
{
get
  {
   return this._SPI_HDR_Outstanding_AsOn_Amt;  }
set
   {
     this._SPI_HDR_Outstanding_AsOn_Amt = value;
     _UpdateFieldName.Add("SPI_HDR_Outstanding_AsOn_Amt");
     }
}

#endregion
#region Genric Methods
public string Insert_Update(M_AT_Sales_PI_AHDRBO sObject)
{
   try
    {
         string strPkValue="";
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

// ObjAT_SPIHDR.SPIHDR_ID=ObjAT_SPIHDR.SPIHDR_ID;
// ObjAT_SPIHDR.Fk_PIHDR_ID=ObjAT_SPIHDR.Fk_PIHDR_ID;
// ObjAT_SPIHDR.Fk_Company_ID=ObjAT_SPIHDR.Fk_Company_ID;
// ObjAT_SPIHDR.Fk_Branch_ID=ObjAT_SPIHDR.Fk_Branch_ID;
// ObjAT_SPIHDR.Fk_Year_ID=ObjAT_SPIHDR.Fk_Year_ID;
// ObjAT_SPIHDR.Fk_Currency_ID=ObjAT_SPIHDR.Fk_Currency_ID;
// ObjAT_SPIHDR.Rec_Created_In=ObjAT_SPIHDR.Rec_Created_In;
// ObjAT_SPIHDR.Rec_CreatedBy_ID=ObjAT_SPIHDR.Rec_CreatedBy_ID;
// ObjAT_SPIHDR.Rec_CreatedFor_ID=ObjAT_SPIHDR.Rec_CreatedFor_ID;
// ObjAT_SPIHDR.SPI_CreationType=ObjAT_SPIHDR.SPI_CreationType;
// ObjAT_SPIHDR.SPI_Type=ObjAT_SPIHDR.SPI_Type;
// ObjAT_SPIHDR.SPI_Category=ObjAT_SPIHDR.SPI_Category;
// ObjAT_SPIHDR.SPI_Taxtype=ObjAT_SPIHDR.SPI_Taxtype;
// ObjAT_SPIHDR.SPI_No=ObjAT_SPIHDR.SPI_No;
// ObjAT_SPIHDR.SPI_DT=ObjAT_SPIHDR.SPI_DT;
// ObjAT_SPIHDR.Fk_CustomerID=ObjAT_SPIHDR.Fk_CustomerID;
// ObjAT_SPIHDR.SPI_CreditDays=ObjAT_SPIHDR.SPI_CreditDays;
// ObjAT_SPIHDR.SPI_DueDT=ObjAT_SPIHDR.SPI_DueDT;
// ObjAT_SPIHDR.SPI_State_ID=ObjAT_SPIHDR.SPI_State_ID;
// ObjAT_SPIHDR.SPI_PONo=ObjAT_SPIHDR.SPI_PONo;
// ObjAT_SPIHDR.SPI_PO_DT=ObjAT_SPIHDR.SPI_PO_DT;
// ObjAT_SPIHDR.SPI_BillTo_CompanyName=ObjAT_SPIHDR.SPI_BillTo_CompanyName;
// ObjAT_SPIHDR.SPI_BillTo_ContactPersone=ObjAT_SPIHDR.SPI_BillTo_ContactPersone;
// ObjAT_SPIHDR.SPI_BillTo_CP_MobileNo=ObjAT_SPIHDR.SPI_BillTo_CP_MobileNo;
// ObjAT_SPIHDR.SPI_BillTo_Add1=ObjAT_SPIHDR.SPI_BillTo_Add1;
// ObjAT_SPIHDR.SPI_BillTo_Add2=ObjAT_SPIHDR.SPI_BillTo_Add2;
// ObjAT_SPIHDR.SPI_BillTo_Add3=ObjAT_SPIHDR.SPI_BillTo_Add3;
// ObjAT_SPIHDR.SPI_BillTo_Pincode=ObjAT_SPIHDR.SPI_BillTo_Pincode;
// ObjAT_SPIHDR.SPI_BillTo_Area=ObjAT_SPIHDR.SPI_BillTo_Area;
// ObjAT_SPIHDR.SPI_BillTo_City=ObjAT_SPIHDR.SPI_BillTo_City;
// ObjAT_SPIHDR.SPI_BillTo_State_ID=ObjAT_SPIHDR.SPI_BillTo_State_ID;
// ObjAT_SPIHDR.SPI_BillTo_Country=ObjAT_SPIHDR.SPI_BillTo_Country;
// ObjAT_SPIHDR.SPI_BillTo_GSTNo=ObjAT_SPIHDR.SPI_BillTo_GSTNo;
// ObjAT_SPIHDR.SPI_BillTo_PANNO=ObjAT_SPIHDR.SPI_BillTo_PANNO;
// ObjAT_SPIHDR.SPI_ShippTo_CompanyName=ObjAT_SPIHDR.SPI_ShippTo_CompanyName;
// ObjAT_SPIHDR.SPI_ShippTo_ContactPersone=ObjAT_SPIHDR.SPI_ShippTo_ContactPersone;
// ObjAT_SPIHDR.SPI_ShippTo_CP_MobileNo=ObjAT_SPIHDR.SPI_ShippTo_CP_MobileNo;
// ObjAT_SPIHDR.SPI_ShippTo_Add1=ObjAT_SPIHDR.SPI_ShippTo_Add1;
// ObjAT_SPIHDR.SPI_ShippTo_Add2=ObjAT_SPIHDR.SPI_ShippTo_Add2;
// ObjAT_SPIHDR.SPI_ShippTo_Add3=ObjAT_SPIHDR.SPI_ShippTo_Add3;
// ObjAT_SPIHDR.SPI_ShippTo_Pincode=ObjAT_SPIHDR.SPI_ShippTo_Pincode;
// ObjAT_SPIHDR.SPI_ShippTo_Area=ObjAT_SPIHDR.SPI_ShippTo_Area;
// ObjAT_SPIHDR.SPI_ShippTo_City=ObjAT_SPIHDR.SPI_ShippTo_City;
// ObjAT_SPIHDR.SPI_ShippTo_State_ID=ObjAT_SPIHDR.SPI_ShippTo_State_ID;
// ObjAT_SPIHDR.SPI_ShippTo_Country=ObjAT_SPIHDR.SPI_ShippTo_Country;
// ObjAT_SPIHDR.SPI_ShippTo_GSTNo=ObjAT_SPIHDR.SPI_ShippTo_GSTNo;
// ObjAT_SPIHDR.SPI_ShippTo_PANNO=ObjAT_SPIHDR.SPI_ShippTo_PANNO;
// ObjAT_SPIHDR.SPI_ShippedFrom_CompanyName=ObjAT_SPIHDR.SPI_ShippedFrom_CompanyName;
// ObjAT_SPIHDR.SPI_ShippedFrom_ContactPersone=ObjAT_SPIHDR.SPI_ShippedFrom_ContactPersone;
// ObjAT_SPIHDR.SPI_ShippedFrom_CP_MobileNo=ObjAT_SPIHDR.SPI_ShippedFrom_CP_MobileNo;
// ObjAT_SPIHDR.SPI_ShippedFrom_Add1=ObjAT_SPIHDR.SPI_ShippedFrom_Add1;
// ObjAT_SPIHDR.SPI_ShippedFrom_Add2=ObjAT_SPIHDR.SPI_ShippedFrom_Add2;
// ObjAT_SPIHDR.SPI_ShippedFrom_Add3=ObjAT_SPIHDR.SPI_ShippedFrom_Add3;
// ObjAT_SPIHDR.SPI_ShippedFrom_Pincode=ObjAT_SPIHDR.SPI_ShippedFrom_Pincode;
// ObjAT_SPIHDR.SPI_ShippedFrom_Area=ObjAT_SPIHDR.SPI_ShippedFrom_Area;
// ObjAT_SPIHDR.SPI_ShippedFrom_City=ObjAT_SPIHDR.SPI_ShippedFrom_City;
// ObjAT_SPIHDR.SPI_ShippedFrom_State_ID=ObjAT_SPIHDR.SPI_ShippedFrom_State_ID;
// ObjAT_SPIHDR.SPI_ShippedFrom_Country=ObjAT_SPIHDR.SPI_ShippedFrom_Country;
// ObjAT_SPIHDR.SPI_ShippedFrom_GSTNo=ObjAT_SPIHDR.SPI_ShippedFrom_GSTNo;
// ObjAT_SPIHDR.SPI_ShippedFrom_PANNO=ObjAT_SPIHDR.SPI_ShippedFrom_PANNO;
// ObjAT_SPIHDR.SPI_PaymentTerms=ObjAT_SPIHDR.SPI_PaymentTerms;
// ObjAT_SPIHDR.SPI_DelvieryPeriod=ObjAT_SPIHDR.SPI_DelvieryPeriod;
// ObjAT_SPIHDR.SPI_DeliveryCharges=ObjAT_SPIHDR.SPI_DeliveryCharges;
// ObjAT_SPIHDR.SPI_ExciseDuty=ObjAT_SPIHDR.SPI_ExciseDuty;
// ObjAT_SPIHDR.SPI_CompletionPeriod=ObjAT_SPIHDR.SPI_CompletionPeriod;
// ObjAT_SPIHDR.SPI_ModeOfDispatch=ObjAT_SPIHDR.SPI_ModeOfDispatch;
// ObjAT_SPIHDR.SPI_TranspoterName=ObjAT_SPIHDR.SPI_TranspoterName;
// ObjAT_SPIHDR.SPI_VehicleNumber=ObjAT_SPIHDR.SPI_VehicleNumber;
// ObjAT_SPIHDR.SPI_PlaceOfDelivery=ObjAT_SPIHDR.SPI_PlaceOfDelivery;
// ObjAT_SPIHDR.SPI_FreigthCharge_Txt=ObjAT_SPIHDR.SPI_FreigthCharge_Txt;
// ObjAT_SPIHDR.SPI_Insurance_Txt=ObjAT_SPIHDR.SPI_Insurance_Txt;
// ObjAT_SPIHDR.SPI_Remark=ObjAT_SPIHDR.SPI_Remark;
// ObjAT_SPIHDR.SPI_L1AuthorizeID=ObjAT_SPIHDR.SPI_L1AuthorizeID;
// ObjAT_SPIHDR.SPI_L1AuthorizeBy=ObjAT_SPIHDR.SPI_L1AuthorizeBy;
// ObjAT_SPIHDR.SPI_L1AuthorizeDT=ObjAT_SPIHDR.SPI_L1AuthorizeDT;
// ObjAT_SPIHDR.SPI_L2AuthorizeID=ObjAT_SPIHDR.SPI_L2AuthorizeID;
// ObjAT_SPIHDR.SPI_L2AuthorizeBy=ObjAT_SPIHDR.SPI_L2AuthorizeBy;
// ObjAT_SPIHDR.SPI_L2AuthorizeDT=ObjAT_SPIHDR.SPI_L2AuthorizeDT;
// ObjAT_SPIHDR.SPI_AuthRemark=ObjAT_SPIHDR.SPI_AuthRemark;
// ObjAT_SPIHDR.SPI_DTL_CNT=ObjAT_SPIHDR.SPI_DTL_CNT;
// ObjAT_SPIHDR.MDBSC_RowStatus=ObjAT_SPIHDR.MDBSC_RowStatus;
// ObjAT_SPIHDR.MDBSC_RowCreatedByUser_ID=ObjAT_SPIHDR.MDBSC_RowCreatedByUser_ID;
// ObjAT_SPIHDR.MDBSC_RowCreatedByUserName=ObjAT_SPIHDR.MDBSC_RowCreatedByUserName;
// ObjAT_SPIHDR.MDBSC_RowCreatedOn_DT=ObjAT_SPIHDR.MDBSC_RowCreatedOn_DT;
// ObjAT_SPIHDR.MDBSC_RowLupdnByUser_ID=ObjAT_SPIHDR.MDBSC_RowLupdnByUser_ID;
// ObjAT_SPIHDR.MDBSC_RowLupdnUserName=ObjAT_SPIHDR.MDBSC_RowLupdnUserName;
// ObjAT_SPIHDR.MDBSC_RowLupdnOn_DT=ObjAT_SPIHDR.MDBSC_RowLupdnOn_DT;
// ObjAT_SPIHDR.SPI_HDR_BasicAmt=ObjAT_SPIHDR.SPI_HDR_BasicAmt;
// ObjAT_SPIHDR.SPI_HDR_DiscountRate=ObjAT_SPIHDR.SPI_HDR_DiscountRate;
// ObjAT_SPIHDR.SPI_HDR_DiscountAmt=ObjAT_SPIHDR.SPI_HDR_DiscountAmt;
// ObjAT_SPIHDR.SPI_HDR_Net_Amt=ObjAT_SPIHDR.SPI_HDR_Net_Amt;
// ObjAT_SPIHDR.SPI_HDR_Freight_Charges=ObjAT_SPIHDR.SPI_HDR_Freight_Charges;
// ObjAT_SPIHDR.SPI_HDR_Loading_N_Packing_Charges=ObjAT_SPIHDR.SPI_HDR_Loading_N_Packing_Charges;
// ObjAT_SPIHDR.SPI_HDR_Insurance_Charges=ObjAT_SPIHDR.SPI_HDR_Insurance_Charges;
// ObjAT_SPIHDR.SPI_HDR_Other_Charges_Txt=ObjAT_SPIHDR.SPI_HDR_Other_Charges_Txt;
// ObjAT_SPIHDR.SPI_HDR_Other_Charges_Amt=ObjAT_SPIHDR.SPI_HDR_Other_Charges_Amt;
// ObjAT_SPIHDR.SPI_HDR_Taxable_Amt=ObjAT_SPIHDR.SPI_HDR_Taxable_Amt;
// ObjAT_SPIHDR.SPI_HDR_CGST_Amt=ObjAT_SPIHDR.SPI_HDR_CGST_Amt;
// ObjAT_SPIHDR.SPI_HDR_CGST_Taxable_Amt=ObjAT_SPIHDR.SPI_HDR_CGST_Taxable_Amt;
// ObjAT_SPIHDR.SPI_HDR_SGST_Amt=ObjAT_SPIHDR.SPI_HDR_SGST_Amt;
// ObjAT_SPIHDR.SPI_HDR_SGST_Taxable_Amt=ObjAT_SPIHDR.SPI_HDR_SGST_Taxable_Amt;
// ObjAT_SPIHDR.SPI_HDR_IGST_Amt=ObjAT_SPIHDR.SPI_HDR_IGST_Amt;
// ObjAT_SPIHDR.SPI_HDR_IGST_Taxable_Amt=ObjAT_SPIHDR.SPI_HDR_IGST_Taxable_Amt;
// ObjAT_SPIHDR.SPI_HDR_CESS_Amt=ObjAT_SPIHDR.SPI_HDR_CESS_Amt;
// ObjAT_SPIHDR.SPI_HDR_CESS_Taxable_Amt=ObjAT_SPIHDR.SPI_HDR_CESS_Taxable_Amt;
// ObjAT_SPIHDR.SPI_HDR_OtherTax_ID=ObjAT_SPIHDR.SPI_HDR_OtherTax_ID;
// ObjAT_SPIHDR.SPI_HDR_OtherTax_Rate=ObjAT_SPIHDR.SPI_HDR_OtherTax_Rate;
// ObjAT_SPIHDR.SPI_HDR_OtherTax_Amt=ObjAT_SPIHDR.SPI_HDR_OtherTax_Amt;
// ObjAT_SPIHDR.SPI_HDR_Other_Taxable_Amt=ObjAT_SPIHDR.SPI_HDR_Other_Taxable_Amt;
// ObjAT_SPIHDR.SPI_HDR_Total_Tax_Amt=ObjAT_SPIHDR.SPI_HDR_Total_Tax_Amt;
// ObjAT_SPIHDR.SPI_HDR_ItemGross_Total_Amt=ObjAT_SPIHDR.SPI_HDR_ItemGross_Total_Amt;
// ObjAT_SPIHDR.SPI_HDR_Gross_Amt=ObjAT_SPIHDR.SPI_HDR_Gross_Amt;
// ObjAT_SPIHDR.SPI_HDR_Round_Off_Amt=ObjAT_SPIHDR.SPI_HDR_Round_Off_Amt;
// ObjAT_SPIHDR.SPI_HDR_Total_Gross_Amt=ObjAT_SPIHDR.SPI_HDR_Total_Gross_Amt;
// ObjAT_SPIHDR.SPI_HDR_Gross_AmtInWords=ObjAT_SPIHDR.SPI_HDR_Gross_AmtInWords;
// ObjAT_SPIHDR.SPI_HDR_CreditNote_AsOn_Amt=ObjAT_SPIHDR.SPI_HDR_CreditNote_AsOn_Amt;
// ObjAT_SPIHDR.SPI_HDR_DebitNote_AsOn_Amt=ObjAT_SPIHDR.SPI_HDR_DebitNote_AsOn_Amt;
// ObjAT_SPIHDR.SPI_HDR_TDS_Rate=ObjAT_SPIHDR.SPI_HDR_TDS_Rate;
// ObjAT_SPIHDR.SPI_HDR_TDS_Amt=ObjAT_SPIHDR.SPI_HDR_TDS_Amt;
// ObjAT_SPIHDR.SPI_HDR_Paid_AsOn_Amt=ObjAT_SPIHDR.SPI_HDR_Paid_AsOn_Amt;
// ObjAT_SPIHDR.SPI_HDR_Outstanding_AsOn_Amt=ObjAT_SPIHDR.SPI_HDR_Outstanding_AsOn_Amt;



// SPIHDR_ID.Text = "";
// Fk_PIHDR_ID.Text = "";
// Fk_Company_ID.Text = "";
// Fk_Branch_ID.Text = "";
// Fk_Year_ID.Text = "";
// Fk_Currency_ID.Text = "";
// Rec_Created_In.Text = "";
// Rec_CreatedBy_ID.Text = "";
// Rec_CreatedFor_ID.Text = "";
// SPI_CreationType.Text = "";
// SPI_Type.Text = "";
// SPI_Category.Text = "";
// SPI_Taxtype.Text = "";
// SPI_No.Text = "";
// SPI_DT.Text = "";
// Fk_CustomerID.Text = "";
// SPI_CreditDays.Text = "";
// SPI_DueDT.Text = "";
// SPI_State_ID.Text = "";
// SPI_PONo.Text = "";
// SPI_PO_DT.Text = "";
// SPI_BillTo_CompanyName.Text = "";
// SPI_BillTo_ContactPersone.Text = "";
// SPI_BillTo_CP_MobileNo.Text = "";
// SPI_BillTo_Add1.Text = "";
// SPI_BillTo_Add2.Text = "";
// SPI_BillTo_Add3.Text = "";
// SPI_BillTo_Pincode.Text = "";
// SPI_BillTo_Area.Text = "";
// SPI_BillTo_City.Text = "";
// SPI_BillTo_State_ID.Text = "";
// SPI_BillTo_Country.Text = "";
// SPI_BillTo_GSTNo.Text = "";
// SPI_BillTo_PANNO.Text = "";
// SPI_ShippTo_CompanyName.Text = "";
// SPI_ShippTo_ContactPersone.Text = "";
// SPI_ShippTo_CP_MobileNo.Text = "";
// SPI_ShippTo_Add1.Text = "";
// SPI_ShippTo_Add2.Text = "";
// SPI_ShippTo_Add3.Text = "";
// SPI_ShippTo_Pincode.Text = "";
// SPI_ShippTo_Area.Text = "";
// SPI_ShippTo_City.Text = "";
// SPI_ShippTo_State_ID.Text = "";
// SPI_ShippTo_Country.Text = "";
// SPI_ShippTo_GSTNo.Text = "";
// SPI_ShippTo_PANNO.Text = "";
// SPI_ShippedFrom_CompanyName.Text = "";
// SPI_ShippedFrom_ContactPersone.Text = "";
// SPI_ShippedFrom_CP_MobileNo.Text = "";
// SPI_ShippedFrom_Add1.Text = "";
// SPI_ShippedFrom_Add2.Text = "";
// SPI_ShippedFrom_Add3.Text = "";
// SPI_ShippedFrom_Pincode.Text = "";
// SPI_ShippedFrom_Area.Text = "";
// SPI_ShippedFrom_City.Text = "";
// SPI_ShippedFrom_State_ID.Text = "";
// SPI_ShippedFrom_Country.Text = "";
// SPI_ShippedFrom_GSTNo.Text = "";
// SPI_ShippedFrom_PANNO.Text = "";
// SPI_PaymentTerms.Text = "";
// SPI_DelvieryPeriod.Text = "";
// SPI_DeliveryCharges.Text = "";
// SPI_ExciseDuty.Text = "";
// SPI_CompletionPeriod.Text = "";
// SPI_ModeOfDispatch.Text = "";
// SPI_TranspoterName.Text = "";
// SPI_VehicleNumber.Text = "";
// SPI_PlaceOfDelivery.Text = "";
// SPI_FreigthCharge_Txt.Text = "";
// SPI_Insurance_Txt.Text = "";
// SPI_Remark.Text = "";
// SPI_L1AuthorizeID.Text = "";
// SPI_L1AuthorizeBy.Text = "";
// SPI_L1AuthorizeDT.Text = "";
// SPI_L2AuthorizeID.Text = "";
// SPI_L2AuthorizeBy.Text = "";
// SPI_L2AuthorizeDT.Text = "";
// SPI_AuthRemark.Text = "";
// SPI_DTL_CNT.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";
// SPI_HDR_BasicAmt.Text = "";
// SPI_HDR_DiscountRate.Text = "";
// SPI_HDR_DiscountAmt.Text = "";
// SPI_HDR_Net_Amt.Text = "";
// SPI_HDR_Freight_Charges.Text = "";
// SPI_HDR_Loading_N_Packing_Charges.Text = "";
// SPI_HDR_Insurance_Charges.Text = "";
// SPI_HDR_Other_Charges_Txt.Text = "";
// SPI_HDR_Other_Charges_Amt.Text = "";
// SPI_HDR_Taxable_Amt.Text = "";
// SPI_HDR_CGST_Amt.Text = "";
// SPI_HDR_CGST_Taxable_Amt.Text = "";
// SPI_HDR_SGST_Amt.Text = "";
// SPI_HDR_SGST_Taxable_Amt.Text = "";
// SPI_HDR_IGST_Amt.Text = "";
// SPI_HDR_IGST_Taxable_Amt.Text = "";
// SPI_HDR_CESS_Amt.Text = "";
// SPI_HDR_CESS_Taxable_Amt.Text = "";
// SPI_HDR_OtherTax_ID.Text = "";
// SPI_HDR_OtherTax_Rate.Text = "";
// SPI_HDR_OtherTax_Amt.Text = "";
// SPI_HDR_Other_Taxable_Amt.Text = "";
// SPI_HDR_Total_Tax_Amt.Text = "";
// SPI_HDR_ItemGross_Total_Amt.Text = "";
// SPI_HDR_Gross_Amt.Text = "";
// SPI_HDR_Round_Off_Amt.Text = "";
// SPI_HDR_Total_Gross_Amt.Text = "";
// SPI_HDR_Gross_AmtInWords.Text = "";
// SPI_HDR_CreditNote_AsOn_Amt.Text = "";
// SPI_HDR_DebitNote_AsOn_Amt.Text = "";
// SPI_HDR_TDS_Rate.Text = "";
// SPI_HDR_TDS_Amt.Text = "";
// SPI_HDR_Paid_AsOn_Amt.Text = "";
// SPI_HDR_Outstanding_AsOn_Amt.Text = "";



// ObjAT_SPIHDR.SPIHDR_ID=SPIHDR_ID.Text ;
// ObjAT_SPIHDR.Fk_PIHDR_ID=Fk_PIHDR_ID.Text ;
// ObjAT_SPIHDR.Fk_Company_ID=Fk_Company_ID.Text ;
// ObjAT_SPIHDR.Fk_Branch_ID=Fk_Branch_ID.Text ;
// ObjAT_SPIHDR.Fk_Year_ID=Fk_Year_ID.Text ;
// ObjAT_SPIHDR.Fk_Currency_ID=Fk_Currency_ID.Text ;
// ObjAT_SPIHDR.Rec_Created_In=Rec_Created_In.Text ;
// ObjAT_SPIHDR.Rec_CreatedBy_ID=Rec_CreatedBy_ID.Text ;
// ObjAT_SPIHDR.Rec_CreatedFor_ID=Rec_CreatedFor_ID.Text ;
// ObjAT_SPIHDR.SPI_CreationType=SPI_CreationType.Text ;
// ObjAT_SPIHDR.SPI_Type=SPI_Type.Text ;
// ObjAT_SPIHDR.SPI_Category=SPI_Category.Text ;
// ObjAT_SPIHDR.SPI_Taxtype=SPI_Taxtype.Text ;
// ObjAT_SPIHDR.SPI_No=SPI_No.Text ;
// ObjAT_SPIHDR.SPI_DT=SPI_DT.Text ;
// ObjAT_SPIHDR.Fk_CustomerID=Fk_CustomerID.Text ;
// ObjAT_SPIHDR.SPI_CreditDays=SPI_CreditDays.Text ;
// ObjAT_SPIHDR.SPI_DueDT=SPI_DueDT.Text ;
// ObjAT_SPIHDR.SPI_State_ID=SPI_State_ID.Text ;
// ObjAT_SPIHDR.SPI_PONo=SPI_PONo.Text ;
// ObjAT_SPIHDR.SPI_PO_DT=SPI_PO_DT.Text ;
// ObjAT_SPIHDR.SPI_BillTo_CompanyName=SPI_BillTo_CompanyName.Text ;
// ObjAT_SPIHDR.SPI_BillTo_ContactPersone=SPI_BillTo_ContactPersone.Text ;
// ObjAT_SPIHDR.SPI_BillTo_CP_MobileNo=SPI_BillTo_CP_MobileNo.Text ;
// ObjAT_SPIHDR.SPI_BillTo_Add1=SPI_BillTo_Add1.Text ;
// ObjAT_SPIHDR.SPI_BillTo_Add2=SPI_BillTo_Add2.Text ;
// ObjAT_SPIHDR.SPI_BillTo_Add3=SPI_BillTo_Add3.Text ;
// ObjAT_SPIHDR.SPI_BillTo_Pincode=SPI_BillTo_Pincode.Text ;
// ObjAT_SPIHDR.SPI_BillTo_Area=SPI_BillTo_Area.Text ;
// ObjAT_SPIHDR.SPI_BillTo_City=SPI_BillTo_City.Text ;
// ObjAT_SPIHDR.SPI_BillTo_State_ID=SPI_BillTo_State_ID.Text ;
// ObjAT_SPIHDR.SPI_BillTo_Country=SPI_BillTo_Country.Text ;
// ObjAT_SPIHDR.SPI_BillTo_GSTNo=SPI_BillTo_GSTNo.Text ;
// ObjAT_SPIHDR.SPI_BillTo_PANNO=SPI_BillTo_PANNO.Text ;
// ObjAT_SPIHDR.SPI_ShippTo_CompanyName=SPI_ShippTo_CompanyName.Text ;
// ObjAT_SPIHDR.SPI_ShippTo_ContactPersone=SPI_ShippTo_ContactPersone.Text ;
// ObjAT_SPIHDR.SPI_ShippTo_CP_MobileNo=SPI_ShippTo_CP_MobileNo.Text ;
// ObjAT_SPIHDR.SPI_ShippTo_Add1=SPI_ShippTo_Add1.Text ;
// ObjAT_SPIHDR.SPI_ShippTo_Add2=SPI_ShippTo_Add2.Text ;
// ObjAT_SPIHDR.SPI_ShippTo_Add3=SPI_ShippTo_Add3.Text ;
// ObjAT_SPIHDR.SPI_ShippTo_Pincode=SPI_ShippTo_Pincode.Text ;
// ObjAT_SPIHDR.SPI_ShippTo_Area=SPI_ShippTo_Area.Text ;
// ObjAT_SPIHDR.SPI_ShippTo_City=SPI_ShippTo_City.Text ;
// ObjAT_SPIHDR.SPI_ShippTo_State_ID=SPI_ShippTo_State_ID.Text ;
// ObjAT_SPIHDR.SPI_ShippTo_Country=SPI_ShippTo_Country.Text ;
// ObjAT_SPIHDR.SPI_ShippTo_GSTNo=SPI_ShippTo_GSTNo.Text ;
// ObjAT_SPIHDR.SPI_ShippTo_PANNO=SPI_ShippTo_PANNO.Text ;
// ObjAT_SPIHDR.SPI_ShippedFrom_CompanyName=SPI_ShippedFrom_CompanyName.Text ;
// ObjAT_SPIHDR.SPI_ShippedFrom_ContactPersone=SPI_ShippedFrom_ContactPersone.Text ;
// ObjAT_SPIHDR.SPI_ShippedFrom_CP_MobileNo=SPI_ShippedFrom_CP_MobileNo.Text ;
// ObjAT_SPIHDR.SPI_ShippedFrom_Add1=SPI_ShippedFrom_Add1.Text ;
// ObjAT_SPIHDR.SPI_ShippedFrom_Add2=SPI_ShippedFrom_Add2.Text ;
// ObjAT_SPIHDR.SPI_ShippedFrom_Add3=SPI_ShippedFrom_Add3.Text ;
// ObjAT_SPIHDR.SPI_ShippedFrom_Pincode=SPI_ShippedFrom_Pincode.Text ;
// ObjAT_SPIHDR.SPI_ShippedFrom_Area=SPI_ShippedFrom_Area.Text ;
// ObjAT_SPIHDR.SPI_ShippedFrom_City=SPI_ShippedFrom_City.Text ;
// ObjAT_SPIHDR.SPI_ShippedFrom_State_ID=SPI_ShippedFrom_State_ID.Text ;
// ObjAT_SPIHDR.SPI_ShippedFrom_Country=SPI_ShippedFrom_Country.Text ;
// ObjAT_SPIHDR.SPI_ShippedFrom_GSTNo=SPI_ShippedFrom_GSTNo.Text ;
// ObjAT_SPIHDR.SPI_ShippedFrom_PANNO=SPI_ShippedFrom_PANNO.Text ;
// ObjAT_SPIHDR.SPI_PaymentTerms=SPI_PaymentTerms.Text ;
// ObjAT_SPIHDR.SPI_DelvieryPeriod=SPI_DelvieryPeriod.Text ;
// ObjAT_SPIHDR.SPI_DeliveryCharges=SPI_DeliveryCharges.Text ;
// ObjAT_SPIHDR.SPI_ExciseDuty=SPI_ExciseDuty.Text ;
// ObjAT_SPIHDR.SPI_CompletionPeriod=SPI_CompletionPeriod.Text ;
// ObjAT_SPIHDR.SPI_ModeOfDispatch=SPI_ModeOfDispatch.Text ;
// ObjAT_SPIHDR.SPI_TranspoterName=SPI_TranspoterName.Text ;
// ObjAT_SPIHDR.SPI_VehicleNumber=SPI_VehicleNumber.Text ;
// ObjAT_SPIHDR.SPI_PlaceOfDelivery=SPI_PlaceOfDelivery.Text ;
// ObjAT_SPIHDR.SPI_FreigthCharge_Txt=SPI_FreigthCharge_Txt.Text ;
// ObjAT_SPIHDR.SPI_Insurance_Txt=SPI_Insurance_Txt.Text ;
// ObjAT_SPIHDR.SPI_Remark=SPI_Remark.Text ;
// ObjAT_SPIHDR.SPI_L1AuthorizeID=SPI_L1AuthorizeID.Text ;
// ObjAT_SPIHDR.SPI_L1AuthorizeBy=SPI_L1AuthorizeBy.Text ;
// ObjAT_SPIHDR.SPI_L1AuthorizeDT=SPI_L1AuthorizeDT.Text ;
// ObjAT_SPIHDR.SPI_L2AuthorizeID=SPI_L2AuthorizeID.Text ;
// ObjAT_SPIHDR.SPI_L2AuthorizeBy=SPI_L2AuthorizeBy.Text ;
// ObjAT_SPIHDR.SPI_L2AuthorizeDT=SPI_L2AuthorizeDT.Text ;
// ObjAT_SPIHDR.SPI_AuthRemark=SPI_AuthRemark.Text ;
// ObjAT_SPIHDR.SPI_DTL_CNT=SPI_DTL_CNT.Text ;
// ObjAT_SPIHDR.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_SPIHDR.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_SPIHDR.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_SPIHDR.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_SPIHDR.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_SPIHDR.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_SPIHDR.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;
// ObjAT_SPIHDR.SPI_HDR_BasicAmt=SPI_HDR_BasicAmt.Text ;
// ObjAT_SPIHDR.SPI_HDR_DiscountRate=SPI_HDR_DiscountRate.Text ;
// ObjAT_SPIHDR.SPI_HDR_DiscountAmt=SPI_HDR_DiscountAmt.Text ;
// ObjAT_SPIHDR.SPI_HDR_Net_Amt=SPI_HDR_Net_Amt.Text ;
// ObjAT_SPIHDR.SPI_HDR_Freight_Charges=SPI_HDR_Freight_Charges.Text ;
// ObjAT_SPIHDR.SPI_HDR_Loading_N_Packing_Charges=SPI_HDR_Loading_N_Packing_Charges.Text ;
// ObjAT_SPIHDR.SPI_HDR_Insurance_Charges=SPI_HDR_Insurance_Charges.Text ;
// ObjAT_SPIHDR.SPI_HDR_Other_Charges_Txt=SPI_HDR_Other_Charges_Txt.Text ;
// ObjAT_SPIHDR.SPI_HDR_Other_Charges_Amt=SPI_HDR_Other_Charges_Amt.Text ;
// ObjAT_SPIHDR.SPI_HDR_Taxable_Amt=SPI_HDR_Taxable_Amt.Text ;
// ObjAT_SPIHDR.SPI_HDR_CGST_Amt=SPI_HDR_CGST_Amt.Text ;
// ObjAT_SPIHDR.SPI_HDR_CGST_Taxable_Amt=SPI_HDR_CGST_Taxable_Amt.Text ;
// ObjAT_SPIHDR.SPI_HDR_SGST_Amt=SPI_HDR_SGST_Amt.Text ;
// ObjAT_SPIHDR.SPI_HDR_SGST_Taxable_Amt=SPI_HDR_SGST_Taxable_Amt.Text ;
// ObjAT_SPIHDR.SPI_HDR_IGST_Amt=SPI_HDR_IGST_Amt.Text ;
// ObjAT_SPIHDR.SPI_HDR_IGST_Taxable_Amt=SPI_HDR_IGST_Taxable_Amt.Text ;
// ObjAT_SPIHDR.SPI_HDR_CESS_Amt=SPI_HDR_CESS_Amt.Text ;
// ObjAT_SPIHDR.SPI_HDR_CESS_Taxable_Amt=SPI_HDR_CESS_Taxable_Amt.Text ;
// ObjAT_SPIHDR.SPI_HDR_OtherTax_ID=SPI_HDR_OtherTax_ID.Text ;
// ObjAT_SPIHDR.SPI_HDR_OtherTax_Rate=SPI_HDR_OtherTax_Rate.Text ;
// ObjAT_SPIHDR.SPI_HDR_OtherTax_Amt=SPI_HDR_OtherTax_Amt.Text ;
// ObjAT_SPIHDR.SPI_HDR_Other_Taxable_Amt=SPI_HDR_Other_Taxable_Amt.Text ;
// ObjAT_SPIHDR.SPI_HDR_Total_Tax_Amt=SPI_HDR_Total_Tax_Amt.Text ;
// ObjAT_SPIHDR.SPI_HDR_ItemGross_Total_Amt=SPI_HDR_ItemGross_Total_Amt.Text ;
// ObjAT_SPIHDR.SPI_HDR_Gross_Amt=SPI_HDR_Gross_Amt.Text ;
// ObjAT_SPIHDR.SPI_HDR_Round_Off_Amt=SPI_HDR_Round_Off_Amt.Text ;
// ObjAT_SPIHDR.SPI_HDR_Total_Gross_Amt=SPI_HDR_Total_Gross_Amt.Text ;
// ObjAT_SPIHDR.SPI_HDR_Gross_AmtInWords=SPI_HDR_Gross_AmtInWords.Text ;
// ObjAT_SPIHDR.SPI_HDR_CreditNote_AsOn_Amt=SPI_HDR_CreditNote_AsOn_Amt.Text ;
// ObjAT_SPIHDR.SPI_HDR_DebitNote_AsOn_Amt=SPI_HDR_DebitNote_AsOn_Amt.Text ;
// ObjAT_SPIHDR.SPI_HDR_TDS_Rate=SPI_HDR_TDS_Rate.Text ;
// ObjAT_SPIHDR.SPI_HDR_TDS_Amt=SPI_HDR_TDS_Amt.Text ;
// ObjAT_SPIHDR.SPI_HDR_Paid_AsOn_Amt=SPI_HDR_Paid_AsOn_Amt.Text ;
// ObjAT_SPIHDR.SPI_HDR_Outstanding_AsOn_Amt=SPI_HDR_Outstanding_AsOn_Amt.Text ;



// SPIHDR_ID.Text =  dt.Rows[0]["SPIHDR_ID"].ToString();
// Fk_PIHDR_ID.Text =  dt.Rows[0]["Fk_PIHDR_ID"].ToString();
// Fk_Company_ID.Text =  dt.Rows[0]["Fk_Company_ID"].ToString();
// Fk_Branch_ID.Text =  dt.Rows[0]["Fk_Branch_ID"].ToString();
// Fk_Year_ID.Text =  dt.Rows[0]["Fk_Year_ID"].ToString();
// Fk_Currency_ID.Text =  dt.Rows[0]["Fk_Currency_ID"].ToString();
// Rec_Created_In.Text =  dt.Rows[0]["Rec_Created_In"].ToString();
// Rec_CreatedBy_ID.Text =  dt.Rows[0]["Rec_CreatedBy_ID"].ToString();
// Rec_CreatedFor_ID.Text =  dt.Rows[0]["Rec_CreatedFor_ID"].ToString();
// SPI_CreationType.Text =  dt.Rows[0]["SPI_CreationType"].ToString();
// SPI_Type.Text =  dt.Rows[0]["SPI_Type"].ToString();
// SPI_Category.Text =  dt.Rows[0]["SPI_Category"].ToString();
// SPI_Taxtype.Text =  dt.Rows[0]["SPI_Taxtype"].ToString();
// SPI_No.Text =  dt.Rows[0]["SPI_No"].ToString();
// SPI_DT.Text =  dt.Rows[0]["SPI_DT"].ToString();
// Fk_CustomerID.Text =  dt.Rows[0]["Fk_CustomerID"].ToString();
// SPI_CreditDays.Text =  dt.Rows[0]["SPI_CreditDays"].ToString();
// SPI_DueDT.Text =  dt.Rows[0]["SPI_DueDT"].ToString();
// SPI_State_ID.Text =  dt.Rows[0]["SPI_State_ID"].ToString();
// SPI_PONo.Text =  dt.Rows[0]["SPI_PONo"].ToString();
// SPI_PO_DT.Text =  dt.Rows[0]["SPI_PO_DT"].ToString();
// SPI_BillTo_CompanyName.Text =  dt.Rows[0]["SPI_BillTo_CompanyName"].ToString();
// SPI_BillTo_ContactPersone.Text =  dt.Rows[0]["SPI_BillTo_ContactPersone"].ToString();
// SPI_BillTo_CP_MobileNo.Text =  dt.Rows[0]["SPI_BillTo_CP_MobileNo"].ToString();
// SPI_BillTo_Add1.Text =  dt.Rows[0]["SPI_BillTo_Add1"].ToString();
// SPI_BillTo_Add2.Text =  dt.Rows[0]["SPI_BillTo_Add2"].ToString();
// SPI_BillTo_Add3.Text =  dt.Rows[0]["SPI_BillTo_Add3"].ToString();
// SPI_BillTo_Pincode.Text =  dt.Rows[0]["SPI_BillTo_Pincode"].ToString();
// SPI_BillTo_Area.Text =  dt.Rows[0]["SPI_BillTo_Area"].ToString();
// SPI_BillTo_City.Text =  dt.Rows[0]["SPI_BillTo_City"].ToString();
// SPI_BillTo_State_ID.Text =  dt.Rows[0]["SPI_BillTo_State_ID"].ToString();
// SPI_BillTo_Country.Text =  dt.Rows[0]["SPI_BillTo_Country"].ToString();
// SPI_BillTo_GSTNo.Text =  dt.Rows[0]["SPI_BillTo_GSTNo"].ToString();
// SPI_BillTo_PANNO.Text =  dt.Rows[0]["SPI_BillTo_PANNO"].ToString();
// SPI_ShippTo_CompanyName.Text =  dt.Rows[0]["SPI_ShippTo_CompanyName"].ToString();
// SPI_ShippTo_ContactPersone.Text =  dt.Rows[0]["SPI_ShippTo_ContactPersone"].ToString();
// SPI_ShippTo_CP_MobileNo.Text =  dt.Rows[0]["SPI_ShippTo_CP_MobileNo"].ToString();
// SPI_ShippTo_Add1.Text =  dt.Rows[0]["SPI_ShippTo_Add1"].ToString();
// SPI_ShippTo_Add2.Text =  dt.Rows[0]["SPI_ShippTo_Add2"].ToString();
// SPI_ShippTo_Add3.Text =  dt.Rows[0]["SPI_ShippTo_Add3"].ToString();
// SPI_ShippTo_Pincode.Text =  dt.Rows[0]["SPI_ShippTo_Pincode"].ToString();
// SPI_ShippTo_Area.Text =  dt.Rows[0]["SPI_ShippTo_Area"].ToString();
// SPI_ShippTo_City.Text =  dt.Rows[0]["SPI_ShippTo_City"].ToString();
// SPI_ShippTo_State_ID.Text =  dt.Rows[0]["SPI_ShippTo_State_ID"].ToString();
// SPI_ShippTo_Country.Text =  dt.Rows[0]["SPI_ShippTo_Country"].ToString();
// SPI_ShippTo_GSTNo.Text =  dt.Rows[0]["SPI_ShippTo_GSTNo"].ToString();
// SPI_ShippTo_PANNO.Text =  dt.Rows[0]["SPI_ShippTo_PANNO"].ToString();
// SPI_ShippedFrom_CompanyName.Text =  dt.Rows[0]["SPI_ShippedFrom_CompanyName"].ToString();
// SPI_ShippedFrom_ContactPersone.Text =  dt.Rows[0]["SPI_ShippedFrom_ContactPersone"].ToString();
// SPI_ShippedFrom_CP_MobileNo.Text =  dt.Rows[0]["SPI_ShippedFrom_CP_MobileNo"].ToString();
// SPI_ShippedFrom_Add1.Text =  dt.Rows[0]["SPI_ShippedFrom_Add1"].ToString();
// SPI_ShippedFrom_Add2.Text =  dt.Rows[0]["SPI_ShippedFrom_Add2"].ToString();
// SPI_ShippedFrom_Add3.Text =  dt.Rows[0]["SPI_ShippedFrom_Add3"].ToString();
// SPI_ShippedFrom_Pincode.Text =  dt.Rows[0]["SPI_ShippedFrom_Pincode"].ToString();
// SPI_ShippedFrom_Area.Text =  dt.Rows[0]["SPI_ShippedFrom_Area"].ToString();
// SPI_ShippedFrom_City.Text =  dt.Rows[0]["SPI_ShippedFrom_City"].ToString();
// SPI_ShippedFrom_State_ID.Text =  dt.Rows[0]["SPI_ShippedFrom_State_ID"].ToString();
// SPI_ShippedFrom_Country.Text =  dt.Rows[0]["SPI_ShippedFrom_Country"].ToString();
// SPI_ShippedFrom_GSTNo.Text =  dt.Rows[0]["SPI_ShippedFrom_GSTNo"].ToString();
// SPI_ShippedFrom_PANNO.Text =  dt.Rows[0]["SPI_ShippedFrom_PANNO"].ToString();
// SPI_PaymentTerms.Text =  dt.Rows[0]["SPI_PaymentTerms"].ToString();
// SPI_DelvieryPeriod.Text =  dt.Rows[0]["SPI_DelvieryPeriod"].ToString();
// SPI_DeliveryCharges.Text =  dt.Rows[0]["SPI_DeliveryCharges"].ToString();
// SPI_ExciseDuty.Text =  dt.Rows[0]["SPI_ExciseDuty"].ToString();
// SPI_CompletionPeriod.Text =  dt.Rows[0]["SPI_CompletionPeriod"].ToString();
// SPI_ModeOfDispatch.Text =  dt.Rows[0]["SPI_ModeOfDispatch"].ToString();
// SPI_TranspoterName.Text =  dt.Rows[0]["SPI_TranspoterName"].ToString();
// SPI_VehicleNumber.Text =  dt.Rows[0]["SPI_VehicleNumber"].ToString();
// SPI_PlaceOfDelivery.Text =  dt.Rows[0]["SPI_PlaceOfDelivery"].ToString();
// SPI_FreigthCharge_Txt.Text =  dt.Rows[0]["SPI_FreigthCharge_Txt"].ToString();
// SPI_Insurance_Txt.Text =  dt.Rows[0]["SPI_Insurance_Txt"].ToString();
// SPI_Remark.Text =  dt.Rows[0]["SPI_Remark"].ToString();
// SPI_L1AuthorizeID.Text =  dt.Rows[0]["SPI_L1AuthorizeID"].ToString();
// SPI_L1AuthorizeBy.Text =  dt.Rows[0]["SPI_L1AuthorizeBy"].ToString();
// SPI_L1AuthorizeDT.Text =  dt.Rows[0]["SPI_L1AuthorizeDT"].ToString();
// SPI_L2AuthorizeID.Text =  dt.Rows[0]["SPI_L2AuthorizeID"].ToString();
// SPI_L2AuthorizeBy.Text =  dt.Rows[0]["SPI_L2AuthorizeBy"].ToString();
// SPI_L2AuthorizeDT.Text =  dt.Rows[0]["SPI_L2AuthorizeDT"].ToString();
// SPI_AuthRemark.Text =  dt.Rows[0]["SPI_AuthRemark"].ToString();
// SPI_DTL_CNT.Text =  dt.Rows[0]["SPI_DTL_CNT"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
// SPI_HDR_BasicAmt.Text =  dt.Rows[0]["SPI_HDR_BasicAmt"].ToString();
// SPI_HDR_DiscountRate.Text =  dt.Rows[0]["SPI_HDR_DiscountRate"].ToString();
// SPI_HDR_DiscountAmt.Text =  dt.Rows[0]["SPI_HDR_DiscountAmt"].ToString();
// SPI_HDR_Net_Amt.Text =  dt.Rows[0]["SPI_HDR_Net_Amt"].ToString();
// SPI_HDR_Freight_Charges.Text =  dt.Rows[0]["SPI_HDR_Freight_Charges"].ToString();
// SPI_HDR_Loading_N_Packing_Charges.Text =  dt.Rows[0]["SPI_HDR_Loading_N_Packing_Charges"].ToString();
// SPI_HDR_Insurance_Charges.Text =  dt.Rows[0]["SPI_HDR_Insurance_Charges"].ToString();
// SPI_HDR_Other_Charges_Txt.Text =  dt.Rows[0]["SPI_HDR_Other_Charges_Txt"].ToString();
// SPI_HDR_Other_Charges_Amt.Text =  dt.Rows[0]["SPI_HDR_Other_Charges_Amt"].ToString();
// SPI_HDR_Taxable_Amt.Text =  dt.Rows[0]["SPI_HDR_Taxable_Amt"].ToString();
// SPI_HDR_CGST_Amt.Text =  dt.Rows[0]["SPI_HDR_CGST_Amt"].ToString();
// SPI_HDR_CGST_Taxable_Amt.Text =  dt.Rows[0]["SPI_HDR_CGST_Taxable_Amt"].ToString();
// SPI_HDR_SGST_Amt.Text =  dt.Rows[0]["SPI_HDR_SGST_Amt"].ToString();
// SPI_HDR_SGST_Taxable_Amt.Text =  dt.Rows[0]["SPI_HDR_SGST_Taxable_Amt"].ToString();
// SPI_HDR_IGST_Amt.Text =  dt.Rows[0]["SPI_HDR_IGST_Amt"].ToString();
// SPI_HDR_IGST_Taxable_Amt.Text =  dt.Rows[0]["SPI_HDR_IGST_Taxable_Amt"].ToString();
// SPI_HDR_CESS_Amt.Text =  dt.Rows[0]["SPI_HDR_CESS_Amt"].ToString();
// SPI_HDR_CESS_Taxable_Amt.Text =  dt.Rows[0]["SPI_HDR_CESS_Taxable_Amt"].ToString();
// SPI_HDR_OtherTax_ID.Text =  dt.Rows[0]["SPI_HDR_OtherTax_ID"].ToString();
// SPI_HDR_OtherTax_Rate.Text =  dt.Rows[0]["SPI_HDR_OtherTax_Rate"].ToString();
// SPI_HDR_OtherTax_Amt.Text =  dt.Rows[0]["SPI_HDR_OtherTax_Amt"].ToString();
// SPI_HDR_Other_Taxable_Amt.Text =  dt.Rows[0]["SPI_HDR_Other_Taxable_Amt"].ToString();
// SPI_HDR_Total_Tax_Amt.Text =  dt.Rows[0]["SPI_HDR_Total_Tax_Amt"].ToString();
// SPI_HDR_ItemGross_Total_Amt.Text =  dt.Rows[0]["SPI_HDR_ItemGross_Total_Amt"].ToString();
// SPI_HDR_Gross_Amt.Text =  dt.Rows[0]["SPI_HDR_Gross_Amt"].ToString();
// SPI_HDR_Round_Off_Amt.Text =  dt.Rows[0]["SPI_HDR_Round_Off_Amt"].ToString();
// SPI_HDR_Total_Gross_Amt.Text =  dt.Rows[0]["SPI_HDR_Total_Gross_Amt"].ToString();
// SPI_HDR_Gross_AmtInWords.Text =  dt.Rows[0]["SPI_HDR_Gross_AmtInWords"].ToString();
// SPI_HDR_CreditNote_AsOn_Amt.Text =  dt.Rows[0]["SPI_HDR_CreditNote_AsOn_Amt"].ToString();
// SPI_HDR_DebitNote_AsOn_Amt.Text =  dt.Rows[0]["SPI_HDR_DebitNote_AsOn_Amt"].ToString();
// SPI_HDR_TDS_Rate.Text =  dt.Rows[0]["SPI_HDR_TDS_Rate"].ToString();
// SPI_HDR_TDS_Amt.Text =  dt.Rows[0]["SPI_HDR_TDS_Amt"].ToString();
// SPI_HDR_Paid_AsOn_Amt.Text =  dt.Rows[0]["SPI_HDR_Paid_AsOn_Amt"].ToString();
// SPI_HDR_Outstanding_AsOn_Amt.Text =  dt.Rows[0]["SPI_HDR_Outstanding_AsOn_Amt"].ToString();
 