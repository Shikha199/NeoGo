using System;
using System.Collections;
using System.Data;
using  MaheshAF18.DataAccess;
namespace MABL.ATDataModal 
{
public class M_AT_Proc_JW_AHDRBO
{
MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
#region Constructor 
public M_AT_Proc_JW_AHDRBO() { }
#endregion 
#region Standard Property
private string _PrimaryKeyName = "JW_HDR_ID";
private string _TableName = "M_AT_Proc_JW_AHDR";
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

private Int64 _JW_HDR_ID;
private Int64 _Fk_Company_ID;
private Int64 _Fk_Branch_ID;
private Int64 _Fk_Year_ID;
private String _Rec_Created_In;
private Int64 _Rec_CreatedBy_ID;
private Int64 _Rec_CreatedFor_ID;
private String _JW_CreationType;
private String _JW_Category;
private String _JW_Type;
private String _JW_TrnType;
private String _JW_No;
private String _JW_DT;
private Int64 _Fk_VendorID;
private Int64 _JW_Days;
private String _JW_DueDT;
private Int64 _JW_State_ID;
private String _JW_ShippTo_CompanyName;
private String _JW_ShippTo_ContactPersone;
private String _JW_ShippTo_CP_MobileNo;
private String _JW_ShippTo_Add1;
private String _JW_ShippTo_Add2;
private String _JW_ShippTo_Add3;
private String _JW_ShippTo_Pincode;
private String _JW_ShippTo_Area;
private String _JW_ShippTo_City;
private Int64 _JW_ShippTo_State_ID;
private String _JW_ShippTo_Country;
private String _JW_ShippTo_GSTNo;
private String _JW_ShippTo_PANNO;
private String _JW_ShippedFrom_CompanyName;
private String _JW_ShippedFrom_ContactPersone;
private String _JW_ShippedFrom_CP_MobileNo;
private String _JW_ShippedFrom_Add1;
private String _JW_ShippedFrom_Add2;
private String _JW_ShippedFrom_Add3;
private String _JW_ShippedFrom_Pincode;
private String _JW_ShippedFrom_Area;
private String _JW_ShippedFrom_City;
private Int64 _JW_ShippedFrom_State_ID;
private String _JW_ShippedFrom_Country;
private String _JW_ShippedFrom_GSTNo;
private String _JW_ShippedFrom_PANNO;
private String _JW_PaymentTerms;
private String _JW_DelvieryPeriod;
private String _JW_DeliveryCharges;
private String _JW_CompletionPeriod;
private String _JW_ModeOfDispatch;
private String _JW_TranspoterName;
private String _JW_VehicleNumber;
private String _JW_PlaceOfDelivery;
private String _JW_FreigthCharge_Txt;
private String _JW_Insurance_Txt;
private String _JW_Remark;
private Int16 _JW_L1AuthorizeID;
private String _JW_L1AuthorizeBy;
private String _JW_L1AuthorizeDT;
private Int16 _JW_L2AuthorizeID;
private String _JW_L2AuthorizeBy;
private String _JW_L2AuthorizeDT;
private String _JW_AuthRemark;
private Int16 _JW_DTL_CNT;
private String _MDBSC_RowStatus;
private Int16 _MDBSC_RowCreatedByUser_ID;
private String _MDBSC_RowCreatedByUserName;
private String _MDBSC_RowCreatedOn_DT;
private Int16 _MDBSC_RowLupdnByUser_ID;
private String _MDBSC_RowLupdnUserName;
private String _MDBSC_RowLupdnOn_DT;
private Decimal _JW_HDR_BasicAmt;
private Decimal _JW_HDR_DiscountRate;
private Decimal _JW_HDR_DiscountAmt;
private Decimal _JW_HDR_Net_Amt;
private Decimal _JW_HDR_Freight_Charges;
private Decimal _JW_HDR_Loading_N_Packing_Charges;
private Decimal _JW_HDR_Insurance_Charges;
private String _JW_HDR_Other_Charges_Txt;
private Decimal _JW_HDR_Other_Charges_Amt;
private Decimal _JW_HDR_Taxable_Amt;
private Decimal _JW_HDR_CGST_Amt;
private Decimal _JW_HDR_CGST_Taxable_Amt;
private Decimal _JW_HDR_SGST_Amt;
private Decimal _JW_HDR_SGST_Taxable_Amt;
private Decimal _JW_HDR_IGST_Amt;
private Decimal _JW_HDR_IGST_Taxable_Amt;
private Decimal _JW_HDR_CESS_Amt;
private Decimal _JW_HDR_CESS_Taxable_Amt;
private Int16 _JW_HDR_OtherTax_ID;
private Decimal _JW_HDR_OtherTax_Rate;
private Decimal _JW_HDR_OtherTax_Amt;
private Decimal _JW_HDR_Other_Taxable_Amt;
private Decimal _JW_HDR_Total_Tax_Amt;
private Decimal _JW_HDR_ItemGross_Total_Amt;
private Decimal _JW_HDR_Gross_Amt;
private Decimal _JW_HDR_Round_Off_Amt;
private Decimal _JW_HDR_Total_Gross_Amt;
private String _JW_HDR_Gross_AmtInWords;
private Decimal _JW_HDR_CreditNote_AsOn_Amt;
private Decimal _JW_HDR_DebitNote_AsOn_Amt;
private Decimal _JW_HDR_TDS_Rate;
private Decimal _JW_HDR_TDS_Amt;
private Decimal _JW_HDR_Paid_AsOn_Amt;
private Decimal _JW_HDR_Outstanding_AsOn_Amt;

public Int64 JW_HDR_ID
{
get
  {
   return this._JW_HDR_ID;  }
set
   {
     this._JW_HDR_ID = value;
     _UpdateFieldName.Add("JW_HDR_ID");
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
public String JW_CreationType
{
get
  {
   return this._JW_CreationType;  }
set
   {
     this._JW_CreationType = value;
     _UpdateFieldName.Add("JW_CreationType");
     }
}
public String JW_Category
{
get
  {
   return this._JW_Category;  }
set
   {
     this._JW_Category = value;
     _UpdateFieldName.Add("JW_Category");
     }
}
public String JW_Type
{
get
  {
   return this._JW_Type;  }
set
   {
     this._JW_Type = value;
     _UpdateFieldName.Add("JW_Type");
     }
}
public String JW_TrnType
{
get
  {
   return this._JW_TrnType;  }
set
   {
     this._JW_TrnType = value;
     _UpdateFieldName.Add("JW_TrnType");
     }
}
public String JW_No
{
get
  {
   return this._JW_No;  }
set
   {
     this._JW_No = value;
     _UpdateFieldName.Add("JW_No");
     }
}
public String JW_DT
{
get
  {
   return this._JW_DT;  }
set
   {
     this._JW_DT = value;
     _UpdateFieldName.Add("JW_DT");
     }
}
public Int64 Fk_VendorID
{
get
  {
   return this._Fk_VendorID;  }
set
   {
     this._Fk_VendorID = value;
     _UpdateFieldName.Add("Fk_VendorID");
     }
}
public Int64 JW_Days
{
get
  {
   return this._JW_Days;  }
set
   {
     this._JW_Days = value;
     _UpdateFieldName.Add("JW_Days");
     }
}
public String JW_DueDT
{
get
  {
   return this._JW_DueDT;  }
set
   {
     this._JW_DueDT = value;
     _UpdateFieldName.Add("JW_DueDT");
     }
}
public Int64 JW_State_ID
{
get
  {
   return this._JW_State_ID;  }
set
   {
     this._JW_State_ID = value;
     _UpdateFieldName.Add("JW_State_ID");
     }
}
public String JW_ShippTo_CompanyName
{
get
  {
   return this._JW_ShippTo_CompanyName;  }
set
   {
     this._JW_ShippTo_CompanyName = value;
     _UpdateFieldName.Add("JW_ShippTo_CompanyName");
     }
}
public String JW_ShippTo_ContactPersone
{
get
  {
   return this._JW_ShippTo_ContactPersone;  }
set
   {
     this._JW_ShippTo_ContactPersone = value;
     _UpdateFieldName.Add("JW_ShippTo_ContactPersone");
     }
}
public String JW_ShippTo_CP_MobileNo
{
get
  {
   return this._JW_ShippTo_CP_MobileNo;  }
set
   {
     this._JW_ShippTo_CP_MobileNo = value;
     _UpdateFieldName.Add("JW_ShippTo_CP_MobileNo");
     }
}
public String JW_ShippTo_Add1
{
get
  {
   return this._JW_ShippTo_Add1;  }
set
   {
     this._JW_ShippTo_Add1 = value;
     _UpdateFieldName.Add("JW_ShippTo_Add1");
     }
}
public String JW_ShippTo_Add2
{
get
  {
   return this._JW_ShippTo_Add2;  }
set
   {
     this._JW_ShippTo_Add2 = value;
     _UpdateFieldName.Add("JW_ShippTo_Add2");
     }
}
public String JW_ShippTo_Add3
{
get
  {
   return this._JW_ShippTo_Add3;  }
set
   {
     this._JW_ShippTo_Add3 = value;
     _UpdateFieldName.Add("JW_ShippTo_Add3");
     }
}
public String JW_ShippTo_Pincode
{
get
  {
   return this._JW_ShippTo_Pincode;  }
set
   {
     this._JW_ShippTo_Pincode = value;
     _UpdateFieldName.Add("JW_ShippTo_Pincode");
     }
}
public String JW_ShippTo_Area
{
get
  {
   return this._JW_ShippTo_Area;  }
set
   {
     this._JW_ShippTo_Area = value;
     _UpdateFieldName.Add("JW_ShippTo_Area");
     }
}
public String JW_ShippTo_City
{
get
  {
   return this._JW_ShippTo_City;  }
set
   {
     this._JW_ShippTo_City = value;
     _UpdateFieldName.Add("JW_ShippTo_City");
     }
}
public Int64 JW_ShippTo_State_ID
{
get
  {
   return this._JW_ShippTo_State_ID;  }
set
   {
     this._JW_ShippTo_State_ID = value;
     _UpdateFieldName.Add("JW_ShippTo_State_ID");
     }
}
public String JW_ShippTo_Country
{
get
  {
   return this._JW_ShippTo_Country;  }
set
   {
     this._JW_ShippTo_Country = value;
     _UpdateFieldName.Add("JW_ShippTo_Country");
     }
}
public String JW_ShippTo_GSTNo
{
get
  {
   return this._JW_ShippTo_GSTNo;  }
set
   {
     this._JW_ShippTo_GSTNo = value;
     _UpdateFieldName.Add("JW_ShippTo_GSTNo");
     }
}
public String JW_ShippTo_PANNO
{
get
  {
   return this._JW_ShippTo_PANNO;  }
set
   {
     this._JW_ShippTo_PANNO = value;
     _UpdateFieldName.Add("JW_ShippTo_PANNO");
     }
}
public String JW_ShippedFrom_CompanyName
{
get
  {
   return this._JW_ShippedFrom_CompanyName;  }
set
   {
     this._JW_ShippedFrom_CompanyName = value;
     _UpdateFieldName.Add("JW_ShippedFrom_CompanyName");
     }
}
public String JW_ShippedFrom_ContactPersone
{
get
  {
   return this._JW_ShippedFrom_ContactPersone;  }
set
   {
     this._JW_ShippedFrom_ContactPersone = value;
     _UpdateFieldName.Add("JW_ShippedFrom_ContactPersone");
     }
}
public String JW_ShippedFrom_CP_MobileNo
{
get
  {
   return this._JW_ShippedFrom_CP_MobileNo;  }
set
   {
     this._JW_ShippedFrom_CP_MobileNo = value;
     _UpdateFieldName.Add("JW_ShippedFrom_CP_MobileNo");
     }
}
public String JW_ShippedFrom_Add1
{
get
  {
   return this._JW_ShippedFrom_Add1;  }
set
   {
     this._JW_ShippedFrom_Add1 = value;
     _UpdateFieldName.Add("JW_ShippedFrom_Add1");
     }
}
public String JW_ShippedFrom_Add2
{
get
  {
   return this._JW_ShippedFrom_Add2;  }
set
   {
     this._JW_ShippedFrom_Add2 = value;
     _UpdateFieldName.Add("JW_ShippedFrom_Add2");
     }
}
public String JW_ShippedFrom_Add3
{
get
  {
   return this._JW_ShippedFrom_Add3;  }
set
   {
     this._JW_ShippedFrom_Add3 = value;
     _UpdateFieldName.Add("JW_ShippedFrom_Add3");
     }
}
public String JW_ShippedFrom_Pincode
{
get
  {
   return this._JW_ShippedFrom_Pincode;  }
set
   {
     this._JW_ShippedFrom_Pincode = value;
     _UpdateFieldName.Add("JW_ShippedFrom_Pincode");
     }
}
public String JW_ShippedFrom_Area
{
get
  {
   return this._JW_ShippedFrom_Area;  }
set
   {
     this._JW_ShippedFrom_Area = value;
     _UpdateFieldName.Add("JW_ShippedFrom_Area");
     }
}
public String JW_ShippedFrom_City
{
get
  {
   return this._JW_ShippedFrom_City;  }
set
   {
     this._JW_ShippedFrom_City = value;
     _UpdateFieldName.Add("JW_ShippedFrom_City");
     }
}
public Int64 JW_ShippedFrom_State_ID
{
get
  {
   return this._JW_ShippedFrom_State_ID;  }
set
   {
     this._JW_ShippedFrom_State_ID = value;
     _UpdateFieldName.Add("JW_ShippedFrom_State_ID");
     }
}
public String JW_ShippedFrom_Country
{
get
  {
   return this._JW_ShippedFrom_Country;  }
set
   {
     this._JW_ShippedFrom_Country = value;
     _UpdateFieldName.Add("JW_ShippedFrom_Country");
     }
}
public String JW_ShippedFrom_GSTNo
{
get
  {
   return this._JW_ShippedFrom_GSTNo;  }
set
   {
     this._JW_ShippedFrom_GSTNo = value;
     _UpdateFieldName.Add("JW_ShippedFrom_GSTNo");
     }
}
public String JW_ShippedFrom_PANNO
{
get
  {
   return this._JW_ShippedFrom_PANNO;  }
set
   {
     this._JW_ShippedFrom_PANNO = value;
     _UpdateFieldName.Add("JW_ShippedFrom_PANNO");
     }
}
public String JW_PaymentTerms
{
get
  {
   return this._JW_PaymentTerms;  }
set
   {
     this._JW_PaymentTerms = value;
     _UpdateFieldName.Add("JW_PaymentTerms");
     }
}
public String JW_DelvieryPeriod
{
get
  {
   return this._JW_DelvieryPeriod;  }
set
   {
     this._JW_DelvieryPeriod = value;
     _UpdateFieldName.Add("JW_DelvieryPeriod");
     }
}
public String JW_DeliveryCharges
{
get
  {
   return this._JW_DeliveryCharges;  }
set
   {
     this._JW_DeliveryCharges = value;
     _UpdateFieldName.Add("JW_DeliveryCharges");
     }
}
public String JW_CompletionPeriod
{
get
  {
   return this._JW_CompletionPeriod;  }
set
   {
     this._JW_CompletionPeriod = value;
     _UpdateFieldName.Add("JW_CompletionPeriod");
     }
}
public String JW_ModeOfDispatch
{
get
  {
   return this._JW_ModeOfDispatch;  }
set
   {
     this._JW_ModeOfDispatch = value;
     _UpdateFieldName.Add("JW_ModeOfDispatch");
     }
}
public String JW_TranspoterName
{
get
  {
   return this._JW_TranspoterName;  }
set
   {
     this._JW_TranspoterName = value;
     _UpdateFieldName.Add("JW_TranspoterName");
     }
}
public String JW_VehicleNumber
{
get
  {
   return this._JW_VehicleNumber;  }
set
   {
     this._JW_VehicleNumber = value;
     _UpdateFieldName.Add("JW_VehicleNumber");
     }
}
public String JW_PlaceOfDelivery
{
get
  {
   return this._JW_PlaceOfDelivery;  }
set
   {
     this._JW_PlaceOfDelivery = value;
     _UpdateFieldName.Add("JW_PlaceOfDelivery");
     }
}
public String JW_FreigthCharge_Txt
{
get
  {
   return this._JW_FreigthCharge_Txt;  }
set
   {
     this._JW_FreigthCharge_Txt = value;
     _UpdateFieldName.Add("JW_FreigthCharge_Txt");
     }
}
public String JW_Insurance_Txt
{
get
  {
   return this._JW_Insurance_Txt;  }
set
   {
     this._JW_Insurance_Txt = value;
     _UpdateFieldName.Add("JW_Insurance_Txt");
     }
}
public String JW_Remark
{
get
  {
   return this._JW_Remark;  }
set
   {
     this._JW_Remark = value;
     _UpdateFieldName.Add("JW_Remark");
     }
}
public Int16 JW_L1AuthorizeID
{
get
  {
   return this._JW_L1AuthorizeID;  }
set
   {
     this._JW_L1AuthorizeID = value;
     _UpdateFieldName.Add("JW_L1AuthorizeID");
     }
}
public String JW_L1AuthorizeBy
{
get
  {
   return this._JW_L1AuthorizeBy;  }
set
   {
     this._JW_L1AuthorizeBy = value;
     _UpdateFieldName.Add("JW_L1AuthorizeBy");
     }
}
public String JW_L1AuthorizeDT
{
get
  {
   return this._JW_L1AuthorizeDT;  }
set
   {
     this._JW_L1AuthorizeDT = value;
     _UpdateFieldName.Add("JW_L1AuthorizeDT");
     }
}
public Int16 JW_L2AuthorizeID
{
get
  {
   return this._JW_L2AuthorizeID;  }
set
   {
     this._JW_L2AuthorizeID = value;
     _UpdateFieldName.Add("JW_L2AuthorizeID");
     }
}
public String JW_L2AuthorizeBy
{
get
  {
   return this._JW_L2AuthorizeBy;  }
set
   {
     this._JW_L2AuthorizeBy = value;
     _UpdateFieldName.Add("JW_L2AuthorizeBy");
     }
}
public String JW_L2AuthorizeDT
{
get
  {
   return this._JW_L2AuthorizeDT;  }
set
   {
     this._JW_L2AuthorizeDT = value;
     _UpdateFieldName.Add("JW_L2AuthorizeDT");
     }
}
public String JW_AuthRemark
{
get
  {
   return this._JW_AuthRemark;  }
set
   {
     this._JW_AuthRemark = value;
     _UpdateFieldName.Add("JW_AuthRemark");
     }
}
public Int16 JW_DTL_CNT
{
get
  {
   return this._JW_DTL_CNT;  }
set
   {
     this._JW_DTL_CNT = value;
     _UpdateFieldName.Add("JW_DTL_CNT");
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
public Decimal JW_HDR_BasicAmt
{
get
  {
   return this._JW_HDR_BasicAmt;  }
set
   {
     this._JW_HDR_BasicAmt = value;
     _UpdateFieldName.Add("JW_HDR_BasicAmt");
     }
}
public Decimal JW_HDR_DiscountRate
{
get
  {
   return this._JW_HDR_DiscountRate;  }
set
   {
     this._JW_HDR_DiscountRate = value;
     _UpdateFieldName.Add("JW_HDR_DiscountRate");
     }
}
public Decimal JW_HDR_DiscountAmt
{
get
  {
   return this._JW_HDR_DiscountAmt;  }
set
   {
     this._JW_HDR_DiscountAmt = value;
     _UpdateFieldName.Add("JW_HDR_DiscountAmt");
     }
}
public Decimal JW_HDR_Net_Amt
{
get
  {
   return this._JW_HDR_Net_Amt;  }
set
   {
     this._JW_HDR_Net_Amt = value;
     _UpdateFieldName.Add("JW_HDR_Net_Amt");
     }
}
public Decimal JW_HDR_Freight_Charges
{
get
  {
   return this._JW_HDR_Freight_Charges;  }
set
   {
     this._JW_HDR_Freight_Charges = value;
     _UpdateFieldName.Add("JW_HDR_Freight_Charges");
     }
}
public Decimal JW_HDR_Loading_N_Packing_Charges
{
get
  {
   return this._JW_HDR_Loading_N_Packing_Charges;  }
set
   {
     this._JW_HDR_Loading_N_Packing_Charges = value;
     _UpdateFieldName.Add("JW_HDR_Loading_N_Packing_Charges");
     }
}
public Decimal JW_HDR_Insurance_Charges
{
get
  {
   return this._JW_HDR_Insurance_Charges;  }
set
   {
     this._JW_HDR_Insurance_Charges = value;
     _UpdateFieldName.Add("JW_HDR_Insurance_Charges");
     }
}
public String JW_HDR_Other_Charges_Txt
{
get
  {
   return this._JW_HDR_Other_Charges_Txt;  }
set
   {
     this._JW_HDR_Other_Charges_Txt = value;
     _UpdateFieldName.Add("JW_HDR_Other_Charges_Txt");
     }
}
public Decimal JW_HDR_Other_Charges_Amt
{
get
  {
   return this._JW_HDR_Other_Charges_Amt;  }
set
   {
     this._JW_HDR_Other_Charges_Amt = value;
     _UpdateFieldName.Add("JW_HDR_Other_Charges_Amt");
     }
}
public Decimal JW_HDR_Taxable_Amt
{
get
  {
   return this._JW_HDR_Taxable_Amt;  }
set
   {
     this._JW_HDR_Taxable_Amt = value;
     _UpdateFieldName.Add("JW_HDR_Taxable_Amt");
     }
}
public Decimal JW_HDR_CGST_Amt
{
get
  {
   return this._JW_HDR_CGST_Amt;  }
set
   {
     this._JW_HDR_CGST_Amt = value;
     _UpdateFieldName.Add("JW_HDR_CGST_Amt");
     }
}
public Decimal JW_HDR_CGST_Taxable_Amt
{
get
  {
   return this._JW_HDR_CGST_Taxable_Amt;  }
set
   {
     this._JW_HDR_CGST_Taxable_Amt = value;
     _UpdateFieldName.Add("JW_HDR_CGST_Taxable_Amt");
     }
}
public Decimal JW_HDR_SGST_Amt
{
get
  {
   return this._JW_HDR_SGST_Amt;  }
set
   {
     this._JW_HDR_SGST_Amt = value;
     _UpdateFieldName.Add("JW_HDR_SGST_Amt");
     }
}
public Decimal JW_HDR_SGST_Taxable_Amt
{
get
  {
   return this._JW_HDR_SGST_Taxable_Amt;  }
set
   {
     this._JW_HDR_SGST_Taxable_Amt = value;
     _UpdateFieldName.Add("JW_HDR_SGST_Taxable_Amt");
     }
}
public Decimal JW_HDR_IGST_Amt
{
get
  {
   return this._JW_HDR_IGST_Amt;  }
set
   {
     this._JW_HDR_IGST_Amt = value;
     _UpdateFieldName.Add("JW_HDR_IGST_Amt");
     }
}
public Decimal JW_HDR_IGST_Taxable_Amt
{
get
  {
   return this._JW_HDR_IGST_Taxable_Amt;  }
set
   {
     this._JW_HDR_IGST_Taxable_Amt = value;
     _UpdateFieldName.Add("JW_HDR_IGST_Taxable_Amt");
     }
}
public Decimal JW_HDR_CESS_Amt
{
get
  {
   return this._JW_HDR_CESS_Amt;  }
set
   {
     this._JW_HDR_CESS_Amt = value;
     _UpdateFieldName.Add("JW_HDR_CESS_Amt");
     }
}
public Decimal JW_HDR_CESS_Taxable_Amt
{
get
  {
   return this._JW_HDR_CESS_Taxable_Amt;  }
set
   {
     this._JW_HDR_CESS_Taxable_Amt = value;
     _UpdateFieldName.Add("JW_HDR_CESS_Taxable_Amt");
     }
}
public Int16 JW_HDR_OtherTax_ID
{
get
  {
   return this._JW_HDR_OtherTax_ID;  }
set
   {
     this._JW_HDR_OtherTax_ID = value;
     _UpdateFieldName.Add("JW_HDR_OtherTax_ID");
     }
}
public Decimal JW_HDR_OtherTax_Rate
{
get
  {
   return this._JW_HDR_OtherTax_Rate;  }
set
   {
     this._JW_HDR_OtherTax_Rate = value;
     _UpdateFieldName.Add("JW_HDR_OtherTax_Rate");
     }
}
public Decimal JW_HDR_OtherTax_Amt
{
get
  {
   return this._JW_HDR_OtherTax_Amt;  }
set
   {
     this._JW_HDR_OtherTax_Amt = value;
     _UpdateFieldName.Add("JW_HDR_OtherTax_Amt");
     }
}
public Decimal JW_HDR_Other_Taxable_Amt
{
get
  {
   return this._JW_HDR_Other_Taxable_Amt;  }
set
   {
     this._JW_HDR_Other_Taxable_Amt = value;
     _UpdateFieldName.Add("JW_HDR_Other_Taxable_Amt");
     }
}
public Decimal JW_HDR_Total_Tax_Amt
{
get
  {
   return this._JW_HDR_Total_Tax_Amt;  }
set
   {
     this._JW_HDR_Total_Tax_Amt = value;
     _UpdateFieldName.Add("JW_HDR_Total_Tax_Amt");
     }
}
public Decimal JW_HDR_ItemGross_Total_Amt
{
get
  {
   return this._JW_HDR_ItemGross_Total_Amt;  }
set
   {
     this._JW_HDR_ItemGross_Total_Amt = value;
     _UpdateFieldName.Add("JW_HDR_ItemGross_Total_Amt");
     }
}
public Decimal JW_HDR_Gross_Amt
{
get
  {
   return this._JW_HDR_Gross_Amt;  }
set
   {
     this._JW_HDR_Gross_Amt = value;
     _UpdateFieldName.Add("JW_HDR_Gross_Amt");
     }
}
public Decimal JW_HDR_Round_Off_Amt
{
get
  {
   return this._JW_HDR_Round_Off_Amt;  }
set
   {
     this._JW_HDR_Round_Off_Amt = value;
     _UpdateFieldName.Add("JW_HDR_Round_Off_Amt");
     }
}
public Decimal JW_HDR_Total_Gross_Amt
{
get
  {
   return this._JW_HDR_Total_Gross_Amt;  }
set
   {
     this._JW_HDR_Total_Gross_Amt = value;
     _UpdateFieldName.Add("JW_HDR_Total_Gross_Amt");
     }
}
public String JW_HDR_Gross_AmtInWords
{
get
  {
   return this._JW_HDR_Gross_AmtInWords;  }
set
   {
     this._JW_HDR_Gross_AmtInWords = value;
     _UpdateFieldName.Add("JW_HDR_Gross_AmtInWords");
     }
}
public Decimal JW_HDR_CreditNote_AsOn_Amt
{
get
  {
   return this._JW_HDR_CreditNote_AsOn_Amt;  }
set
   {
     this._JW_HDR_CreditNote_AsOn_Amt = value;
     _UpdateFieldName.Add("JW_HDR_CreditNote_AsOn_Amt");
     }
}
public Decimal JW_HDR_DebitNote_AsOn_Amt
{
get
  {
   return this._JW_HDR_DebitNote_AsOn_Amt;  }
set
   {
     this._JW_HDR_DebitNote_AsOn_Amt = value;
     _UpdateFieldName.Add("JW_HDR_DebitNote_AsOn_Amt");
     }
}
public Decimal JW_HDR_TDS_Rate
{
get
  {
   return this._JW_HDR_TDS_Rate;  }
set
   {
     this._JW_HDR_TDS_Rate = value;
     _UpdateFieldName.Add("JW_HDR_TDS_Rate");
     }
}
public Decimal JW_HDR_TDS_Amt
{
get
  {
   return this._JW_HDR_TDS_Amt;  }
set
   {
     this._JW_HDR_TDS_Amt = value;
     _UpdateFieldName.Add("JW_HDR_TDS_Amt");
     }
}
public Decimal JW_HDR_Paid_AsOn_Amt
{
get
  {
   return this._JW_HDR_Paid_AsOn_Amt;  }
set
   {
     this._JW_HDR_Paid_AsOn_Amt = value;
     _UpdateFieldName.Add("JW_HDR_Paid_AsOn_Amt");
     }
}
public Decimal JW_HDR_Outstanding_AsOn_Amt
{
get
  {
   return this._JW_HDR_Outstanding_AsOn_Amt;  }
set
   {
     this._JW_HDR_Outstanding_AsOn_Amt = value;
     _UpdateFieldName.Add("JW_HDR_Outstanding_AsOn_Amt");
     }
}

#endregion
#region Genric Methods
public string Insert_Update(M_AT_Proc_JW_AHDRBO sObject)
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

// ObjAT_JWHDR.JW_HDR_ID=ObjAT_JWHDR.JW_HDR_ID;
// ObjAT_JWHDR.Fk_Company_ID=ObjAT_JWHDR.Fk_Company_ID;
// ObjAT_JWHDR.Fk_Branch_ID=ObjAT_JWHDR.Fk_Branch_ID;
// ObjAT_JWHDR.Fk_Year_ID=ObjAT_JWHDR.Fk_Year_ID;
// ObjAT_JWHDR.Rec_Created_In=ObjAT_JWHDR.Rec_Created_In;
// ObjAT_JWHDR.Rec_CreatedBy_ID=ObjAT_JWHDR.Rec_CreatedBy_ID;
// ObjAT_JWHDR.Rec_CreatedFor_ID=ObjAT_JWHDR.Rec_CreatedFor_ID;
// ObjAT_JWHDR.JW_CreationType=ObjAT_JWHDR.JW_CreationType;
// ObjAT_JWHDR.JW_Category=ObjAT_JWHDR.JW_Category;
// ObjAT_JWHDR.JW_Type=ObjAT_JWHDR.JW_Type;
// ObjAT_JWHDR.JW_TrnType=ObjAT_JWHDR.JW_TrnType;
// ObjAT_JWHDR.JW_No=ObjAT_JWHDR.JW_No;
// ObjAT_JWHDR.JW_DT=ObjAT_JWHDR.JW_DT;
// ObjAT_JWHDR.Fk_VendorID=ObjAT_JWHDR.Fk_VendorID;
// ObjAT_JWHDR.JW_Days=ObjAT_JWHDR.JW_Days;
// ObjAT_JWHDR.JW_DueDT=ObjAT_JWHDR.JW_DueDT;
// ObjAT_JWHDR.JW_State_ID=ObjAT_JWHDR.JW_State_ID;
// ObjAT_JWHDR.JW_ShippTo_CompanyName=ObjAT_JWHDR.JW_ShippTo_CompanyName;
// ObjAT_JWHDR.JW_ShippTo_ContactPersone=ObjAT_JWHDR.JW_ShippTo_ContactPersone;
// ObjAT_JWHDR.JW_ShippTo_CP_MobileNo=ObjAT_JWHDR.JW_ShippTo_CP_MobileNo;
// ObjAT_JWHDR.JW_ShippTo_Add1=ObjAT_JWHDR.JW_ShippTo_Add1;
// ObjAT_JWHDR.JW_ShippTo_Add2=ObjAT_JWHDR.JW_ShippTo_Add2;
// ObjAT_JWHDR.JW_ShippTo_Add3=ObjAT_JWHDR.JW_ShippTo_Add3;
// ObjAT_JWHDR.JW_ShippTo_Pincode=ObjAT_JWHDR.JW_ShippTo_Pincode;
// ObjAT_JWHDR.JW_ShippTo_Area=ObjAT_JWHDR.JW_ShippTo_Area;
// ObjAT_JWHDR.JW_ShippTo_City=ObjAT_JWHDR.JW_ShippTo_City;
// ObjAT_JWHDR.JW_ShippTo_State_ID=ObjAT_JWHDR.JW_ShippTo_State_ID;
// ObjAT_JWHDR.JW_ShippTo_Country=ObjAT_JWHDR.JW_ShippTo_Country;
// ObjAT_JWHDR.JW_ShippTo_GSTNo=ObjAT_JWHDR.JW_ShippTo_GSTNo;
// ObjAT_JWHDR.JW_ShippTo_PANNO=ObjAT_JWHDR.JW_ShippTo_PANNO;
// ObjAT_JWHDR.JW_ShippedFrom_CompanyName=ObjAT_JWHDR.JW_ShippedFrom_CompanyName;
// ObjAT_JWHDR.JW_ShippedFrom_ContactPersone=ObjAT_JWHDR.JW_ShippedFrom_ContactPersone;
// ObjAT_JWHDR.JW_ShippedFrom_CP_MobileNo=ObjAT_JWHDR.JW_ShippedFrom_CP_MobileNo;
// ObjAT_JWHDR.JW_ShippedFrom_Add1=ObjAT_JWHDR.JW_ShippedFrom_Add1;
// ObjAT_JWHDR.JW_ShippedFrom_Add2=ObjAT_JWHDR.JW_ShippedFrom_Add2;
// ObjAT_JWHDR.JW_ShippedFrom_Add3=ObjAT_JWHDR.JW_ShippedFrom_Add3;
// ObjAT_JWHDR.JW_ShippedFrom_Pincode=ObjAT_JWHDR.JW_ShippedFrom_Pincode;
// ObjAT_JWHDR.JW_ShippedFrom_Area=ObjAT_JWHDR.JW_ShippedFrom_Area;
// ObjAT_JWHDR.JW_ShippedFrom_City=ObjAT_JWHDR.JW_ShippedFrom_City;
// ObjAT_JWHDR.JW_ShippedFrom_State_ID=ObjAT_JWHDR.JW_ShippedFrom_State_ID;
// ObjAT_JWHDR.JW_ShippedFrom_Country=ObjAT_JWHDR.JW_ShippedFrom_Country;
// ObjAT_JWHDR.JW_ShippedFrom_GSTNo=ObjAT_JWHDR.JW_ShippedFrom_GSTNo;
// ObjAT_JWHDR.JW_ShippedFrom_PANNO=ObjAT_JWHDR.JW_ShippedFrom_PANNO;
// ObjAT_JWHDR.JW_PaymentTerms=ObjAT_JWHDR.JW_PaymentTerms;
// ObjAT_JWHDR.JW_DelvieryPeriod=ObjAT_JWHDR.JW_DelvieryPeriod;
// ObjAT_JWHDR.JW_DeliveryCharges=ObjAT_JWHDR.JW_DeliveryCharges;
// ObjAT_JWHDR.JW_CompletionPeriod=ObjAT_JWHDR.JW_CompletionPeriod;
// ObjAT_JWHDR.JW_ModeOfDispatch=ObjAT_JWHDR.JW_ModeOfDispatch;
// ObjAT_JWHDR.JW_TranspoterName=ObjAT_JWHDR.JW_TranspoterName;
// ObjAT_JWHDR.JW_VehicleNumber=ObjAT_JWHDR.JW_VehicleNumber;
// ObjAT_JWHDR.JW_PlaceOfDelivery=ObjAT_JWHDR.JW_PlaceOfDelivery;
// ObjAT_JWHDR.JW_FreigthCharge_Txt=ObjAT_JWHDR.JW_FreigthCharge_Txt;
// ObjAT_JWHDR.JW_Insurance_Txt=ObjAT_JWHDR.JW_Insurance_Txt;
// ObjAT_JWHDR.JW_Remark=ObjAT_JWHDR.JW_Remark;
// ObjAT_JWHDR.JW_L1AuthorizeID=ObjAT_JWHDR.JW_L1AuthorizeID;
// ObjAT_JWHDR.JW_L1AuthorizeBy=ObjAT_JWHDR.JW_L1AuthorizeBy;
// ObjAT_JWHDR.JW_L1AuthorizeDT=ObjAT_JWHDR.JW_L1AuthorizeDT;
// ObjAT_JWHDR.JW_L2AuthorizeID=ObjAT_JWHDR.JW_L2AuthorizeID;
// ObjAT_JWHDR.JW_L2AuthorizeBy=ObjAT_JWHDR.JW_L2AuthorizeBy;
// ObjAT_JWHDR.JW_L2AuthorizeDT=ObjAT_JWHDR.JW_L2AuthorizeDT;
// ObjAT_JWHDR.JW_AuthRemark=ObjAT_JWHDR.JW_AuthRemark;
// ObjAT_JWHDR.JW_DTL_CNT=ObjAT_JWHDR.JW_DTL_CNT;
// ObjAT_JWHDR.MDBSC_RowStatus=ObjAT_JWHDR.MDBSC_RowStatus;
// ObjAT_JWHDR.MDBSC_RowCreatedByUser_ID=ObjAT_JWHDR.MDBSC_RowCreatedByUser_ID;
// ObjAT_JWHDR.MDBSC_RowCreatedByUserName=ObjAT_JWHDR.MDBSC_RowCreatedByUserName;
// ObjAT_JWHDR.MDBSC_RowCreatedOn_DT=ObjAT_JWHDR.MDBSC_RowCreatedOn_DT;
// ObjAT_JWHDR.MDBSC_RowLupdnByUser_ID=ObjAT_JWHDR.MDBSC_RowLupdnByUser_ID;
// ObjAT_JWHDR.MDBSC_RowLupdnUserName=ObjAT_JWHDR.MDBSC_RowLupdnUserName;
// ObjAT_JWHDR.MDBSC_RowLupdnOn_DT=ObjAT_JWHDR.MDBSC_RowLupdnOn_DT;
// ObjAT_JWHDR.JW_HDR_BasicAmt=ObjAT_JWHDR.JW_HDR_BasicAmt;
// ObjAT_JWHDR.JW_HDR_DiscountRate=ObjAT_JWHDR.JW_HDR_DiscountRate;
// ObjAT_JWHDR.JW_HDR_DiscountAmt=ObjAT_JWHDR.JW_HDR_DiscountAmt;
// ObjAT_JWHDR.JW_HDR_Net_Amt=ObjAT_JWHDR.JW_HDR_Net_Amt;
// ObjAT_JWHDR.JW_HDR_Freight_Charges=ObjAT_JWHDR.JW_HDR_Freight_Charges;
// ObjAT_JWHDR.JW_HDR_Loading_N_Packing_Charges=ObjAT_JWHDR.JW_HDR_Loading_N_Packing_Charges;
// ObjAT_JWHDR.JW_HDR_Insurance_Charges=ObjAT_JWHDR.JW_HDR_Insurance_Charges;
// ObjAT_JWHDR.JW_HDR_Other_Charges_Txt=ObjAT_JWHDR.JW_HDR_Other_Charges_Txt;
// ObjAT_JWHDR.JW_HDR_Other_Charges_Amt=ObjAT_JWHDR.JW_HDR_Other_Charges_Amt;
// ObjAT_JWHDR.JW_HDR_Taxable_Amt=ObjAT_JWHDR.JW_HDR_Taxable_Amt;
// ObjAT_JWHDR.JW_HDR_CGST_Amt=ObjAT_JWHDR.JW_HDR_CGST_Amt;
// ObjAT_JWHDR.JW_HDR_CGST_Taxable_Amt=ObjAT_JWHDR.JW_HDR_CGST_Taxable_Amt;
// ObjAT_JWHDR.JW_HDR_SGST_Amt=ObjAT_JWHDR.JW_HDR_SGST_Amt;
// ObjAT_JWHDR.JW_HDR_SGST_Taxable_Amt=ObjAT_JWHDR.JW_HDR_SGST_Taxable_Amt;
// ObjAT_JWHDR.JW_HDR_IGST_Amt=ObjAT_JWHDR.JW_HDR_IGST_Amt;
// ObjAT_JWHDR.JW_HDR_IGST_Taxable_Amt=ObjAT_JWHDR.JW_HDR_IGST_Taxable_Amt;
// ObjAT_JWHDR.JW_HDR_CESS_Amt=ObjAT_JWHDR.JW_HDR_CESS_Amt;
// ObjAT_JWHDR.JW_HDR_CESS_Taxable_Amt=ObjAT_JWHDR.JW_HDR_CESS_Taxable_Amt;
// ObjAT_JWHDR.JW_HDR_OtherTax_ID=ObjAT_JWHDR.JW_HDR_OtherTax_ID;
// ObjAT_JWHDR.JW_HDR_OtherTax_Rate=ObjAT_JWHDR.JW_HDR_OtherTax_Rate;
// ObjAT_JWHDR.JW_HDR_OtherTax_Amt=ObjAT_JWHDR.JW_HDR_OtherTax_Amt;
// ObjAT_JWHDR.JW_HDR_Other_Taxable_Amt=ObjAT_JWHDR.JW_HDR_Other_Taxable_Amt;
// ObjAT_JWHDR.JW_HDR_Total_Tax_Amt=ObjAT_JWHDR.JW_HDR_Total_Tax_Amt;
// ObjAT_JWHDR.JW_HDR_ItemGross_Total_Amt=ObjAT_JWHDR.JW_HDR_ItemGross_Total_Amt;
// ObjAT_JWHDR.JW_HDR_Gross_Amt=ObjAT_JWHDR.JW_HDR_Gross_Amt;
// ObjAT_JWHDR.JW_HDR_Round_Off_Amt=ObjAT_JWHDR.JW_HDR_Round_Off_Amt;
// ObjAT_JWHDR.JW_HDR_Total_Gross_Amt=ObjAT_JWHDR.JW_HDR_Total_Gross_Amt;
// ObjAT_JWHDR.JW_HDR_Gross_AmtInWords=ObjAT_JWHDR.JW_HDR_Gross_AmtInWords;
// ObjAT_JWHDR.JW_HDR_CreditNote_AsOn_Amt=ObjAT_JWHDR.JW_HDR_CreditNote_AsOn_Amt;
// ObjAT_JWHDR.JW_HDR_DebitNote_AsOn_Amt=ObjAT_JWHDR.JW_HDR_DebitNote_AsOn_Amt;
// ObjAT_JWHDR.JW_HDR_TDS_Rate=ObjAT_JWHDR.JW_HDR_TDS_Rate;
// ObjAT_JWHDR.JW_HDR_TDS_Amt=ObjAT_JWHDR.JW_HDR_TDS_Amt;
// ObjAT_JWHDR.JW_HDR_Paid_AsOn_Amt=ObjAT_JWHDR.JW_HDR_Paid_AsOn_Amt;
// ObjAT_JWHDR.JW_HDR_Outstanding_AsOn_Amt=ObjAT_JWHDR.JW_HDR_Outstanding_AsOn_Amt;



// JW_HDR_ID.Text = "";
// Fk_Company_ID.Text = "";
// Fk_Branch_ID.Text = "";
// Fk_Year_ID.Text = "";
// Rec_Created_In.Text = "";
// Rec_CreatedBy_ID.Text = "";
// Rec_CreatedFor_ID.Text = "";
// JW_CreationType.Text = "";
// JW_Category.Text = "";
// JW_Type.Text = "";
// JW_TrnType.Text = "";
// JW_No.Text = "";
// JW_DT.Text = "";
// Fk_VendorID.Text = "";
// JW_Days.Text = "";
// JW_DueDT.Text = "";
// JW_State_ID.Text = "";
// JW_ShippTo_CompanyName.Text = "";
// JW_ShippTo_ContactPersone.Text = "";
// JW_ShippTo_CP_MobileNo.Text = "";
// JW_ShippTo_Add1.Text = "";
// JW_ShippTo_Add2.Text = "";
// JW_ShippTo_Add3.Text = "";
// JW_ShippTo_Pincode.Text = "";
// JW_ShippTo_Area.Text = "";
// JW_ShippTo_City.Text = "";
// JW_ShippTo_State_ID.Text = "";
// JW_ShippTo_Country.Text = "";
// JW_ShippTo_GSTNo.Text = "";
// JW_ShippTo_PANNO.Text = "";
// JW_ShippedFrom_CompanyName.Text = "";
// JW_ShippedFrom_ContactPersone.Text = "";
// JW_ShippedFrom_CP_MobileNo.Text = "";
// JW_ShippedFrom_Add1.Text = "";
// JW_ShippedFrom_Add2.Text = "";
// JW_ShippedFrom_Add3.Text = "";
// JW_ShippedFrom_Pincode.Text = "";
// JW_ShippedFrom_Area.Text = "";
// JW_ShippedFrom_City.Text = "";
// JW_ShippedFrom_State_ID.Text = "";
// JW_ShippedFrom_Country.Text = "";
// JW_ShippedFrom_GSTNo.Text = "";
// JW_ShippedFrom_PANNO.Text = "";
// JW_PaymentTerms.Text = "";
// JW_DelvieryPeriod.Text = "";
// JW_DeliveryCharges.Text = "";
// JW_CompletionPeriod.Text = "";
// JW_ModeOfDispatch.Text = "";
// JW_TranspoterName.Text = "";
// JW_VehicleNumber.Text = "";
// JW_PlaceOfDelivery.Text = "";
// JW_FreigthCharge_Txt.Text = "";
// JW_Insurance_Txt.Text = "";
// JW_Remark.Text = "";
// JW_L1AuthorizeID.Text = "";
// JW_L1AuthorizeBy.Text = "";
// JW_L1AuthorizeDT.Text = "";
// JW_L2AuthorizeID.Text = "";
// JW_L2AuthorizeBy.Text = "";
// JW_L2AuthorizeDT.Text = "";
// JW_AuthRemark.Text = "";
// JW_DTL_CNT.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";
// JW_HDR_BasicAmt.Text = "";
// JW_HDR_DiscountRate.Text = "";
// JW_HDR_DiscountAmt.Text = "";
// JW_HDR_Net_Amt.Text = "";
// JW_HDR_Freight_Charges.Text = "";
// JW_HDR_Loading_N_Packing_Charges.Text = "";
// JW_HDR_Insurance_Charges.Text = "";
// JW_HDR_Other_Charges_Txt.Text = "";
// JW_HDR_Other_Charges_Amt.Text = "";
// JW_HDR_Taxable_Amt.Text = "";
// JW_HDR_CGST_Amt.Text = "";
// JW_HDR_CGST_Taxable_Amt.Text = "";
// JW_HDR_SGST_Amt.Text = "";
// JW_HDR_SGST_Taxable_Amt.Text = "";
// JW_HDR_IGST_Amt.Text = "";
// JW_HDR_IGST_Taxable_Amt.Text = "";
// JW_HDR_CESS_Amt.Text = "";
// JW_HDR_CESS_Taxable_Amt.Text = "";
// JW_HDR_OtherTax_ID.Text = "";
// JW_HDR_OtherTax_Rate.Text = "";
// JW_HDR_OtherTax_Amt.Text = "";
// JW_HDR_Other_Taxable_Amt.Text = "";
// JW_HDR_Total_Tax_Amt.Text = "";
// JW_HDR_ItemGross_Total_Amt.Text = "";
// JW_HDR_Gross_Amt.Text = "";
// JW_HDR_Round_Off_Amt.Text = "";
// JW_HDR_Total_Gross_Amt.Text = "";
// JW_HDR_Gross_AmtInWords.Text = "";
// JW_HDR_CreditNote_AsOn_Amt.Text = "";
// JW_HDR_DebitNote_AsOn_Amt.Text = "";
// JW_HDR_TDS_Rate.Text = "";
// JW_HDR_TDS_Amt.Text = "";
// JW_HDR_Paid_AsOn_Amt.Text = "";
// JW_HDR_Outstanding_AsOn_Amt.Text = "";



// ObjAT_JWHDR.JW_HDR_ID=JW_HDR_ID.Text ;
// ObjAT_JWHDR.Fk_Company_ID=Fk_Company_ID.Text ;
// ObjAT_JWHDR.Fk_Branch_ID=Fk_Branch_ID.Text ;
// ObjAT_JWHDR.Fk_Year_ID=Fk_Year_ID.Text ;
// ObjAT_JWHDR.Rec_Created_In=Rec_Created_In.Text ;
// ObjAT_JWHDR.Rec_CreatedBy_ID=Rec_CreatedBy_ID.Text ;
// ObjAT_JWHDR.Rec_CreatedFor_ID=Rec_CreatedFor_ID.Text ;
// ObjAT_JWHDR.JW_CreationType=JW_CreationType.Text ;
// ObjAT_JWHDR.JW_Category=JW_Category.Text ;
// ObjAT_JWHDR.JW_Type=JW_Type.Text ;
// ObjAT_JWHDR.JW_TrnType=JW_TrnType.Text ;
// ObjAT_JWHDR.JW_No=JW_No.Text ;
// ObjAT_JWHDR.JW_DT=JW_DT.Text ;
// ObjAT_JWHDR.Fk_VendorID=Fk_VendorID.Text ;
// ObjAT_JWHDR.JW_Days=JW_Days.Text ;
// ObjAT_JWHDR.JW_DueDT=JW_DueDT.Text ;
// ObjAT_JWHDR.JW_State_ID=JW_State_ID.Text ;
// ObjAT_JWHDR.JW_ShippTo_CompanyName=JW_ShippTo_CompanyName.Text ;
// ObjAT_JWHDR.JW_ShippTo_ContactPersone=JW_ShippTo_ContactPersone.Text ;
// ObjAT_JWHDR.JW_ShippTo_CP_MobileNo=JW_ShippTo_CP_MobileNo.Text ;
// ObjAT_JWHDR.JW_ShippTo_Add1=JW_ShippTo_Add1.Text ;
// ObjAT_JWHDR.JW_ShippTo_Add2=JW_ShippTo_Add2.Text ;
// ObjAT_JWHDR.JW_ShippTo_Add3=JW_ShippTo_Add3.Text ;
// ObjAT_JWHDR.JW_ShippTo_Pincode=JW_ShippTo_Pincode.Text ;
// ObjAT_JWHDR.JW_ShippTo_Area=JW_ShippTo_Area.Text ;
// ObjAT_JWHDR.JW_ShippTo_City=JW_ShippTo_City.Text ;
// ObjAT_JWHDR.JW_ShippTo_State_ID=JW_ShippTo_State_ID.Text ;
// ObjAT_JWHDR.JW_ShippTo_Country=JW_ShippTo_Country.Text ;
// ObjAT_JWHDR.JW_ShippTo_GSTNo=JW_ShippTo_GSTNo.Text ;
// ObjAT_JWHDR.JW_ShippTo_PANNO=JW_ShippTo_PANNO.Text ;
// ObjAT_JWHDR.JW_ShippedFrom_CompanyName=JW_ShippedFrom_CompanyName.Text ;
// ObjAT_JWHDR.JW_ShippedFrom_ContactPersone=JW_ShippedFrom_ContactPersone.Text ;
// ObjAT_JWHDR.JW_ShippedFrom_CP_MobileNo=JW_ShippedFrom_CP_MobileNo.Text ;
// ObjAT_JWHDR.JW_ShippedFrom_Add1=JW_ShippedFrom_Add1.Text ;
// ObjAT_JWHDR.JW_ShippedFrom_Add2=JW_ShippedFrom_Add2.Text ;
// ObjAT_JWHDR.JW_ShippedFrom_Add3=JW_ShippedFrom_Add3.Text ;
// ObjAT_JWHDR.JW_ShippedFrom_Pincode=JW_ShippedFrom_Pincode.Text ;
// ObjAT_JWHDR.JW_ShippedFrom_Area=JW_ShippedFrom_Area.Text ;
// ObjAT_JWHDR.JW_ShippedFrom_City=JW_ShippedFrom_City.Text ;
// ObjAT_JWHDR.JW_ShippedFrom_State_ID=JW_ShippedFrom_State_ID.Text ;
// ObjAT_JWHDR.JW_ShippedFrom_Country=JW_ShippedFrom_Country.Text ;
// ObjAT_JWHDR.JW_ShippedFrom_GSTNo=JW_ShippedFrom_GSTNo.Text ;
// ObjAT_JWHDR.JW_ShippedFrom_PANNO=JW_ShippedFrom_PANNO.Text ;
// ObjAT_JWHDR.JW_PaymentTerms=JW_PaymentTerms.Text ;
// ObjAT_JWHDR.JW_DelvieryPeriod=JW_DelvieryPeriod.Text ;
// ObjAT_JWHDR.JW_DeliveryCharges=JW_DeliveryCharges.Text ;
// ObjAT_JWHDR.JW_CompletionPeriod=JW_CompletionPeriod.Text ;
// ObjAT_JWHDR.JW_ModeOfDispatch=JW_ModeOfDispatch.Text ;
// ObjAT_JWHDR.JW_TranspoterName=JW_TranspoterName.Text ;
// ObjAT_JWHDR.JW_VehicleNumber=JW_VehicleNumber.Text ;
// ObjAT_JWHDR.JW_PlaceOfDelivery=JW_PlaceOfDelivery.Text ;
// ObjAT_JWHDR.JW_FreigthCharge_Txt=JW_FreigthCharge_Txt.Text ;
// ObjAT_JWHDR.JW_Insurance_Txt=JW_Insurance_Txt.Text ;
// ObjAT_JWHDR.JW_Remark=JW_Remark.Text ;
// ObjAT_JWHDR.JW_L1AuthorizeID=JW_L1AuthorizeID.Text ;
// ObjAT_JWHDR.JW_L1AuthorizeBy=JW_L1AuthorizeBy.Text ;
// ObjAT_JWHDR.JW_L1AuthorizeDT=JW_L1AuthorizeDT.Text ;
// ObjAT_JWHDR.JW_L2AuthorizeID=JW_L2AuthorizeID.Text ;
// ObjAT_JWHDR.JW_L2AuthorizeBy=JW_L2AuthorizeBy.Text ;
// ObjAT_JWHDR.JW_L2AuthorizeDT=JW_L2AuthorizeDT.Text ;
// ObjAT_JWHDR.JW_AuthRemark=JW_AuthRemark.Text ;
// ObjAT_JWHDR.JW_DTL_CNT=JW_DTL_CNT.Text ;
// ObjAT_JWHDR.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_JWHDR.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_JWHDR.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_JWHDR.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_JWHDR.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_JWHDR.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_JWHDR.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;
// ObjAT_JWHDR.JW_HDR_BasicAmt=JW_HDR_BasicAmt.Text ;
// ObjAT_JWHDR.JW_HDR_DiscountRate=JW_HDR_DiscountRate.Text ;
// ObjAT_JWHDR.JW_HDR_DiscountAmt=JW_HDR_DiscountAmt.Text ;
// ObjAT_JWHDR.JW_HDR_Net_Amt=JW_HDR_Net_Amt.Text ;
// ObjAT_JWHDR.JW_HDR_Freight_Charges=JW_HDR_Freight_Charges.Text ;
// ObjAT_JWHDR.JW_HDR_Loading_N_Packing_Charges=JW_HDR_Loading_N_Packing_Charges.Text ;
// ObjAT_JWHDR.JW_HDR_Insurance_Charges=JW_HDR_Insurance_Charges.Text ;
// ObjAT_JWHDR.JW_HDR_Other_Charges_Txt=JW_HDR_Other_Charges_Txt.Text ;
// ObjAT_JWHDR.JW_HDR_Other_Charges_Amt=JW_HDR_Other_Charges_Amt.Text ;
// ObjAT_JWHDR.JW_HDR_Taxable_Amt=JW_HDR_Taxable_Amt.Text ;
// ObjAT_JWHDR.JW_HDR_CGST_Amt=JW_HDR_CGST_Amt.Text ;
// ObjAT_JWHDR.JW_HDR_CGST_Taxable_Amt=JW_HDR_CGST_Taxable_Amt.Text ;
// ObjAT_JWHDR.JW_HDR_SGST_Amt=JW_HDR_SGST_Amt.Text ;
// ObjAT_JWHDR.JW_HDR_SGST_Taxable_Amt=JW_HDR_SGST_Taxable_Amt.Text ;
// ObjAT_JWHDR.JW_HDR_IGST_Amt=JW_HDR_IGST_Amt.Text ;
// ObjAT_JWHDR.JW_HDR_IGST_Taxable_Amt=JW_HDR_IGST_Taxable_Amt.Text ;
// ObjAT_JWHDR.JW_HDR_CESS_Amt=JW_HDR_CESS_Amt.Text ;
// ObjAT_JWHDR.JW_HDR_CESS_Taxable_Amt=JW_HDR_CESS_Taxable_Amt.Text ;
// ObjAT_JWHDR.JW_HDR_OtherTax_ID=JW_HDR_OtherTax_ID.Text ;
// ObjAT_JWHDR.JW_HDR_OtherTax_Rate=JW_HDR_OtherTax_Rate.Text ;
// ObjAT_JWHDR.JW_HDR_OtherTax_Amt=JW_HDR_OtherTax_Amt.Text ;
// ObjAT_JWHDR.JW_HDR_Other_Taxable_Amt=JW_HDR_Other_Taxable_Amt.Text ;
// ObjAT_JWHDR.JW_HDR_Total_Tax_Amt=JW_HDR_Total_Tax_Amt.Text ;
// ObjAT_JWHDR.JW_HDR_ItemGross_Total_Amt=JW_HDR_ItemGross_Total_Amt.Text ;
// ObjAT_JWHDR.JW_HDR_Gross_Amt=JW_HDR_Gross_Amt.Text ;
// ObjAT_JWHDR.JW_HDR_Round_Off_Amt=JW_HDR_Round_Off_Amt.Text ;
// ObjAT_JWHDR.JW_HDR_Total_Gross_Amt=JW_HDR_Total_Gross_Amt.Text ;
// ObjAT_JWHDR.JW_HDR_Gross_AmtInWords=JW_HDR_Gross_AmtInWords.Text ;
// ObjAT_JWHDR.JW_HDR_CreditNote_AsOn_Amt=JW_HDR_CreditNote_AsOn_Amt.Text ;
// ObjAT_JWHDR.JW_HDR_DebitNote_AsOn_Amt=JW_HDR_DebitNote_AsOn_Amt.Text ;
// ObjAT_JWHDR.JW_HDR_TDS_Rate=JW_HDR_TDS_Rate.Text ;
// ObjAT_JWHDR.JW_HDR_TDS_Amt=JW_HDR_TDS_Amt.Text ;
// ObjAT_JWHDR.JW_HDR_Paid_AsOn_Amt=JW_HDR_Paid_AsOn_Amt.Text ;
// ObjAT_JWHDR.JW_HDR_Outstanding_AsOn_Amt=JW_HDR_Outstanding_AsOn_Amt.Text ;



// JW_HDR_ID.Text =  dt.Rows[0]["JW_HDR_ID"].ToString();
// Fk_Company_ID.Text =  dt.Rows[0]["Fk_Company_ID"].ToString();
// Fk_Branch_ID.Text =  dt.Rows[0]["Fk_Branch_ID"].ToString();
// Fk_Year_ID.Text =  dt.Rows[0]["Fk_Year_ID"].ToString();
// Rec_Created_In.Text =  dt.Rows[0]["Rec_Created_In"].ToString();
// Rec_CreatedBy_ID.Text =  dt.Rows[0]["Rec_CreatedBy_ID"].ToString();
// Rec_CreatedFor_ID.Text =  dt.Rows[0]["Rec_CreatedFor_ID"].ToString();
// JW_CreationType.Text =  dt.Rows[0]["JW_CreationType"].ToString();
// JW_Category.Text =  dt.Rows[0]["JW_Category"].ToString();
// JW_Type.Text =  dt.Rows[0]["JW_Type"].ToString();
// JW_TrnType.Text =  dt.Rows[0]["JW_TrnType"].ToString();
// JW_No.Text =  dt.Rows[0]["JW_No"].ToString();
// JW_DT.Text =  dt.Rows[0]["JW_DT"].ToString();
// Fk_VendorID.Text =  dt.Rows[0]["Fk_VendorID"].ToString();
// JW_Days.Text =  dt.Rows[0]["JW_Days"].ToString();
// JW_DueDT.Text =  dt.Rows[0]["JW_DueDT"].ToString();
// JW_State_ID.Text =  dt.Rows[0]["JW_State_ID"].ToString();
// JW_ShippTo_CompanyName.Text =  dt.Rows[0]["JW_ShippTo_CompanyName"].ToString();
// JW_ShippTo_ContactPersone.Text =  dt.Rows[0]["JW_ShippTo_ContactPersone"].ToString();
// JW_ShippTo_CP_MobileNo.Text =  dt.Rows[0]["JW_ShippTo_CP_MobileNo"].ToString();
// JW_ShippTo_Add1.Text =  dt.Rows[0]["JW_ShippTo_Add1"].ToString();
// JW_ShippTo_Add2.Text =  dt.Rows[0]["JW_ShippTo_Add2"].ToString();
// JW_ShippTo_Add3.Text =  dt.Rows[0]["JW_ShippTo_Add3"].ToString();
// JW_ShippTo_Pincode.Text =  dt.Rows[0]["JW_ShippTo_Pincode"].ToString();
// JW_ShippTo_Area.Text =  dt.Rows[0]["JW_ShippTo_Area"].ToString();
// JW_ShippTo_City.Text =  dt.Rows[0]["JW_ShippTo_City"].ToString();
// JW_ShippTo_State_ID.Text =  dt.Rows[0]["JW_ShippTo_State_ID"].ToString();
// JW_ShippTo_Country.Text =  dt.Rows[0]["JW_ShippTo_Country"].ToString();
// JW_ShippTo_GSTNo.Text =  dt.Rows[0]["JW_ShippTo_GSTNo"].ToString();
// JW_ShippTo_PANNO.Text =  dt.Rows[0]["JW_ShippTo_PANNO"].ToString();
// JW_ShippedFrom_CompanyName.Text =  dt.Rows[0]["JW_ShippedFrom_CompanyName"].ToString();
// JW_ShippedFrom_ContactPersone.Text =  dt.Rows[0]["JW_ShippedFrom_ContactPersone"].ToString();
// JW_ShippedFrom_CP_MobileNo.Text =  dt.Rows[0]["JW_ShippedFrom_CP_MobileNo"].ToString();
// JW_ShippedFrom_Add1.Text =  dt.Rows[0]["JW_ShippedFrom_Add1"].ToString();
// JW_ShippedFrom_Add2.Text =  dt.Rows[0]["JW_ShippedFrom_Add2"].ToString();
// JW_ShippedFrom_Add3.Text =  dt.Rows[0]["JW_ShippedFrom_Add3"].ToString();
// JW_ShippedFrom_Pincode.Text =  dt.Rows[0]["JW_ShippedFrom_Pincode"].ToString();
// JW_ShippedFrom_Area.Text =  dt.Rows[0]["JW_ShippedFrom_Area"].ToString();
// JW_ShippedFrom_City.Text =  dt.Rows[0]["JW_ShippedFrom_City"].ToString();
// JW_ShippedFrom_State_ID.Text =  dt.Rows[0]["JW_ShippedFrom_State_ID"].ToString();
// JW_ShippedFrom_Country.Text =  dt.Rows[0]["JW_ShippedFrom_Country"].ToString();
// JW_ShippedFrom_GSTNo.Text =  dt.Rows[0]["JW_ShippedFrom_GSTNo"].ToString();
// JW_ShippedFrom_PANNO.Text =  dt.Rows[0]["JW_ShippedFrom_PANNO"].ToString();
// JW_PaymentTerms.Text =  dt.Rows[0]["JW_PaymentTerms"].ToString();
// JW_DelvieryPeriod.Text =  dt.Rows[0]["JW_DelvieryPeriod"].ToString();
// JW_DeliveryCharges.Text =  dt.Rows[0]["JW_DeliveryCharges"].ToString();
// JW_CompletionPeriod.Text =  dt.Rows[0]["JW_CompletionPeriod"].ToString();
// JW_ModeOfDispatch.Text =  dt.Rows[0]["JW_ModeOfDispatch"].ToString();
// JW_TranspoterName.Text =  dt.Rows[0]["JW_TranspoterName"].ToString();
// JW_VehicleNumber.Text =  dt.Rows[0]["JW_VehicleNumber"].ToString();
// JW_PlaceOfDelivery.Text =  dt.Rows[0]["JW_PlaceOfDelivery"].ToString();
// JW_FreigthCharge_Txt.Text =  dt.Rows[0]["JW_FreigthCharge_Txt"].ToString();
// JW_Insurance_Txt.Text =  dt.Rows[0]["JW_Insurance_Txt"].ToString();
// JW_Remark.Text =  dt.Rows[0]["JW_Remark"].ToString();
// JW_L1AuthorizeID.Text =  dt.Rows[0]["JW_L1AuthorizeID"].ToString();
// JW_L1AuthorizeBy.Text =  dt.Rows[0]["JW_L1AuthorizeBy"].ToString();
// JW_L1AuthorizeDT.Text =  dt.Rows[0]["JW_L1AuthorizeDT"].ToString();
// JW_L2AuthorizeID.Text =  dt.Rows[0]["JW_L2AuthorizeID"].ToString();
// JW_L2AuthorizeBy.Text =  dt.Rows[0]["JW_L2AuthorizeBy"].ToString();
// JW_L2AuthorizeDT.Text =  dt.Rows[0]["JW_L2AuthorizeDT"].ToString();
// JW_AuthRemark.Text =  dt.Rows[0]["JW_AuthRemark"].ToString();
// JW_DTL_CNT.Text =  dt.Rows[0]["JW_DTL_CNT"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
// JW_HDR_BasicAmt.Text =  dt.Rows[0]["JW_HDR_BasicAmt"].ToString();
// JW_HDR_DiscountRate.Text =  dt.Rows[0]["JW_HDR_DiscountRate"].ToString();
// JW_HDR_DiscountAmt.Text =  dt.Rows[0]["JW_HDR_DiscountAmt"].ToString();
// JW_HDR_Net_Amt.Text =  dt.Rows[0]["JW_HDR_Net_Amt"].ToString();
// JW_HDR_Freight_Charges.Text =  dt.Rows[0]["JW_HDR_Freight_Charges"].ToString();
// JW_HDR_Loading_N_Packing_Charges.Text =  dt.Rows[0]["JW_HDR_Loading_N_Packing_Charges"].ToString();
// JW_HDR_Insurance_Charges.Text =  dt.Rows[0]["JW_HDR_Insurance_Charges"].ToString();
// JW_HDR_Other_Charges_Txt.Text =  dt.Rows[0]["JW_HDR_Other_Charges_Txt"].ToString();
// JW_HDR_Other_Charges_Amt.Text =  dt.Rows[0]["JW_HDR_Other_Charges_Amt"].ToString();
// JW_HDR_Taxable_Amt.Text =  dt.Rows[0]["JW_HDR_Taxable_Amt"].ToString();
// JW_HDR_CGST_Amt.Text =  dt.Rows[0]["JW_HDR_CGST_Amt"].ToString();
// JW_HDR_CGST_Taxable_Amt.Text =  dt.Rows[0]["JW_HDR_CGST_Taxable_Amt"].ToString();
// JW_HDR_SGST_Amt.Text =  dt.Rows[0]["JW_HDR_SGST_Amt"].ToString();
// JW_HDR_SGST_Taxable_Amt.Text =  dt.Rows[0]["JW_HDR_SGST_Taxable_Amt"].ToString();
// JW_HDR_IGST_Amt.Text =  dt.Rows[0]["JW_HDR_IGST_Amt"].ToString();
// JW_HDR_IGST_Taxable_Amt.Text =  dt.Rows[0]["JW_HDR_IGST_Taxable_Amt"].ToString();
// JW_HDR_CESS_Amt.Text =  dt.Rows[0]["JW_HDR_CESS_Amt"].ToString();
// JW_HDR_CESS_Taxable_Amt.Text =  dt.Rows[0]["JW_HDR_CESS_Taxable_Amt"].ToString();
// JW_HDR_OtherTax_ID.Text =  dt.Rows[0]["JW_HDR_OtherTax_ID"].ToString();
// JW_HDR_OtherTax_Rate.Text =  dt.Rows[0]["JW_HDR_OtherTax_Rate"].ToString();
// JW_HDR_OtherTax_Amt.Text =  dt.Rows[0]["JW_HDR_OtherTax_Amt"].ToString();
// JW_HDR_Other_Taxable_Amt.Text =  dt.Rows[0]["JW_HDR_Other_Taxable_Amt"].ToString();
// JW_HDR_Total_Tax_Amt.Text =  dt.Rows[0]["JW_HDR_Total_Tax_Amt"].ToString();
// JW_HDR_ItemGross_Total_Amt.Text =  dt.Rows[0]["JW_HDR_ItemGross_Total_Amt"].ToString();
// JW_HDR_Gross_Amt.Text =  dt.Rows[0]["JW_HDR_Gross_Amt"].ToString();
// JW_HDR_Round_Off_Amt.Text =  dt.Rows[0]["JW_HDR_Round_Off_Amt"].ToString();
// JW_HDR_Total_Gross_Amt.Text =  dt.Rows[0]["JW_HDR_Total_Gross_Amt"].ToString();
// JW_HDR_Gross_AmtInWords.Text =  dt.Rows[0]["JW_HDR_Gross_AmtInWords"].ToString();
// JW_HDR_CreditNote_AsOn_Amt.Text =  dt.Rows[0]["JW_HDR_CreditNote_AsOn_Amt"].ToString();
// JW_HDR_DebitNote_AsOn_Amt.Text =  dt.Rows[0]["JW_HDR_DebitNote_AsOn_Amt"].ToString();
// JW_HDR_TDS_Rate.Text =  dt.Rows[0]["JW_HDR_TDS_Rate"].ToString();
// JW_HDR_TDS_Amt.Text =  dt.Rows[0]["JW_HDR_TDS_Amt"].ToString();
// JW_HDR_Paid_AsOn_Amt.Text =  dt.Rows[0]["JW_HDR_Paid_AsOn_Amt"].ToString();
// JW_HDR_Outstanding_AsOn_Amt.Text =  dt.Rows[0]["JW_HDR_Outstanding_AsOn_Amt"].ToString();
