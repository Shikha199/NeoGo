using System;
using System.Collections;
using System.Data;
using   MaheshAF18.DataAccess;
namespace MABL.ATDataModal 
{
public class M_AT_Purchase_Inv_AHDRBO
{
MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
#region Constructor 
public M_AT_Purchase_Inv_AHDRBO() { }
#endregion 
#region Standard Property
private string _PrimaryKeyName = "PINVHDR_ID";
private string _TableName = "M_AT_Purchase_Inv_AHDR";
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

private Int64 _PINVHDR_ID;
private Int64 _Fk_PIHDR_ID;
private Int64 _Fk_Company_ID;
private Int64 _Fk_Branch_ID;
private Int64 _Fk_Year_ID;
private Int32 _Fk_Currency_ID;
private String _Rec_Created_In;
private Int64 _Rec_CreatedBy_ID;
private Int64 _Rec_CreatedFor_ID;
private String _PINV_CreationType;
private String _PINV_Type;
private String _PINV_Category;
private String _PINV_Taxtype;
private String _PINV_No;
private String _PINV_DT;
private Int64 _Fk_VendorID;
private Int64 _PINV_CreditDays;
private String _PINV_DueDT;
private Int64 _PINV_State_ID;
private Int64 _PINV_HDR_Job_Work_ID;
private String _PINV_PONo;
private String _PINV_PO_DT;
private String _PINV_BillTo_CompanyName;
private String _PINV_BillTo_ContactPersone;
private String _PINV_BillTo_CP_MobileNo;
private String _PINV_BillTo_Add1;
private String _PINV_BillTo_Add2;
private String _PINV_BillTo_Add3;
private String _PINV_BillTo_Pincode;
private String _PINV_BillTo_Area;
private String _PINV_BillTo_City;
private Int64 _PINV_BillTo_State_ID;
private String _PINV_BillTo_Country;
private String _PINV_BillTo_GSTNo;
private String _PINV_BillTo_PANNO;
private String _PINV_ShippTo_CompanyName;
private String _PINV_ShippTo_ContactPersone;
private String _PINV_ShippTo_CP_MobileNo;
private String _PINV_ShippTo_Add1;
private String _PINV_ShippTo_Add2;
private String _PINV_ShippTo_Add3;
private String _PINV_ShippTo_Pincode;
private String _PINV_ShippTo_Area;
private String _PINV_ShippTo_City;
private Int64 _PINV_ShippTo_State_ID;
private String _PINV_ShippTo_Country;
private String _PINV_ShippTo_GSTNo;
private String _PINV_ShippTo_PANNO;
private String _PINV_ShippedFrom_CompanyName;
private String _PINV_ShippedFrom_ContactPersone;
private String _PINV_ShippedFrom_CP_MobileNo;
private String _PINV_ShippedFrom_Add1;
private String _PINV_ShippedFrom_Add2;
private String _PINV_ShippedFrom_Add3;
private String _PINV_ShippedFrom_Pincode;
private String _PINV_ShippedFrom_Area;
private String _PINV_ShippedFrom_City;
private Int64 _PINV_ShippedFrom_State_ID;
private String _PINV_ShippedFrom_Country;
private String _PINV_ShippedFrom_GSTNo;
private String _PINV_ShippedFrom_PANNO;
private String _PINV_PaymentTerms;
private String _PINV_DelvieryPeriod;
private String _PINV_DeliveryCharges;
private String _PINV_ExciseDuty;
private String _PINV_CompletionPeriod;
private String _PINV_ModeOfDispatch;
private String _PINV_TranspoterName;
private String _PINV_VehicleNumber;
private String _PINV_PlaceOfDelivery;
private String _PINV_FreigthCharge_Txt;
private String _PINV_Insurance_Txt;
private String _PINV_Remark;
private Int16 _PINV_L1AuthorizeID;
private String _PINV_L1AuthorizeBy;
private String _PINV_L1AuthorizeDT;
private Int16 _PINV_L2AuthorizeID;
private String _PINV_L2AuthorizeBy;
private String _PINV_L2AuthorizeDT;
private String _PINV_AuthRemark;
private Int16 _PINV_DTL_CNT;
private String _MDBSC_RowStatus;
private Int16 _MDBSC_RowCreatedByUser_ID;
private String _MDBSC_RowCreatedByUserName;
private String _MDBSC_RowCreatedOn_DT;
private Int16 _MDBSC_RowLupdnByUser_ID;
private String _MDBSC_RowLupdnUserName;
private String _MDBSC_RowLupdnOn_DT;
private Decimal _PINV_HDR_BasicAmt;
private Decimal _PINV_HDR_DiscountRate;
private Decimal _PINV_HDR_DiscountAmt;
private Decimal _PINV_HDR_Net_Amt;
private Decimal _PINV_HDR_Freight_Charges;
private Decimal _PINV_HDR_Loading_N_Packing_Charges;
private Decimal _PINV_HDR_Insurance_Charges;
private String _PINV_HDR_Other_Charges_Txt;
private Decimal _PINV_HDR_Other_Charges_Amt;
private Decimal _PINV_HDR_Taxable_Amt;
private Decimal _PINV_HDR_CGST_Amt;
private Decimal _PINV_HDR_CGST_Taxable_Amt;
private Decimal _PINV_HDR_SGST_Amt;
private Decimal _PINV_HDR_SGST_Taxable_Amt;
private Decimal _PINV_HDR_IGST_Amt;
private Decimal _PINV_HDR_IGST_Taxable_Amt;
private Decimal _PINV_HDR_CESS_Amt;
private Decimal _PINV_HDR_CESS_Taxable_Amt;
private Int16 _PINV_HDR_OtherTax_ID;
private Decimal _PINV_HDR_OtherTax_Rate;
private Decimal _PINV_HDR_OtherTax_Amt;
private Decimal _PINV_HDR_Other_Taxable_Amt;
private Decimal _PINV_HDR_Total_Tax_Amt;
private Decimal _PINV_HDR_ItemGross_Total_Amt;
private Decimal _PINV_HDR_Gross_Amt;
private Decimal _PINV_HDR_Round_Off_Amt;
private Decimal _PINV_HDR_Total_Gross_Amt;
private String _PINV_HDR_Gross_AmtInWords;
private Decimal _PINV_HDR_CreditNote_AsOn_Amt;
private Decimal _PINV_HDR_DebitNote_AsOn_Amt;
private Decimal _PINV_HDR_TDS_Rate;
private Decimal _PINV_HDR_TDS_Amt;
private Decimal _PINV_HDR_Paid_AsOn_Amt;
private Decimal _PINV_HDR_Outstanding_AsOn_Amt;

public Int64 PINVHDR_ID
{
get
  {
   return this._PINVHDR_ID;  }
set
   {
     this._PINVHDR_ID = value;
     _UpdateFieldName.Add("PINVHDR_ID");
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
public String PINV_CreationType
{
get
  {
   return this._PINV_CreationType;  }
set
   {
     this._PINV_CreationType = value;
     _UpdateFieldName.Add("PINV_CreationType");
     }
}
public String PINV_Type
{
get
  {
   return this._PINV_Type;  }
set
   {
     this._PINV_Type = value;
     _UpdateFieldName.Add("PINV_Type");
     }
}
public String PINV_Category
{
get
  {
   return this._PINV_Category;  }
set
   {
     this._PINV_Category = value;
     _UpdateFieldName.Add("PINV_Category");
     }
}
public String PINV_Taxtype
{
get
  {
   return this._PINV_Taxtype;  }
set
   {
     this._PINV_Taxtype = value;
     _UpdateFieldName.Add("PINV_Taxtype");
     }
}
public String PINV_No
{
get
  {
   return this._PINV_No;  }
set
   {
     this._PINV_No = value;
     _UpdateFieldName.Add("PINV_No");
     }
}
public String PINV_DT
{
get
  {
   return this._PINV_DT;  }
set
   {
     this._PINV_DT = value;
     _UpdateFieldName.Add("PINV_DT");
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
public Int64 PINV_CreditDays
{
get
  {
   return this._PINV_CreditDays;  }
set
   {
     this._PINV_CreditDays = value;
     _UpdateFieldName.Add("PINV_CreditDays");
     }
}
public String PINV_DueDT
{
get
  {
   return this._PINV_DueDT;  }
set
   {
     this._PINV_DueDT = value;
     _UpdateFieldName.Add("PINV_DueDT");
     }
}
public Int64 PINV_State_ID
{
get
  {
   return this._PINV_State_ID;  }
set
   {
     this._PINV_State_ID = value;
     _UpdateFieldName.Add("PINV_State_ID");
     }
}

public Int64 PINV_HDR_Job_Work_ID
{
    get
    {
        return this._PINV_HDR_Job_Work_ID;
    }
    set
    {
        this._PINV_HDR_Job_Work_ID = value;
        _UpdateFieldName.Add("PINV_HDR_Job_Work_ID");
    }
}
public String PINV_PONo
{
get
  {
   return this._PINV_PONo;  }
set
   {
     this._PINV_PONo = value;
     _UpdateFieldName.Add("PINV_PONo");
     }
}
public String PINV_PO_DT
{
get
  {
   return this._PINV_PO_DT;  }
set
   {
     this._PINV_PO_DT = value;
     _UpdateFieldName.Add("PINV_PO_DT");
     }
}
public String PINV_BillTo_CompanyName
{
get
  {
   return this._PINV_BillTo_CompanyName;  }
set
   {
     this._PINV_BillTo_CompanyName = value;
     _UpdateFieldName.Add("PINV_BillTo_CompanyName");
     }
}
public String PINV_BillTo_ContactPersone
{
get
  {
   return this._PINV_BillTo_ContactPersone;  }
set
   {
     this._PINV_BillTo_ContactPersone = value;
     _UpdateFieldName.Add("PINV_BillTo_ContactPersone");
     }
}
public String PINV_BillTo_CP_MobileNo
{
get
  {
   return this._PINV_BillTo_CP_MobileNo;  }
set
   {
     this._PINV_BillTo_CP_MobileNo = value;
     _UpdateFieldName.Add("PINV_BillTo_CP_MobileNo");
     }
}
public String PINV_BillTo_Add1
{
get
  {
   return this._PINV_BillTo_Add1;  }
set
   {
     this._PINV_BillTo_Add1 = value;
     _UpdateFieldName.Add("PINV_BillTo_Add1");
     }
}
public String PINV_BillTo_Add2
{
get
  {
   return this._PINV_BillTo_Add2;  }
set
   {
     this._PINV_BillTo_Add2 = value;
     _UpdateFieldName.Add("PINV_BillTo_Add2");
     }
}
public String PINV_BillTo_Add3
{
get
  {
   return this._PINV_BillTo_Add3;  }
set
   {
     this._PINV_BillTo_Add3 = value;
     _UpdateFieldName.Add("PINV_BillTo_Add3");
     }
}
public String PINV_BillTo_Pincode
{
get
  {
   return this._PINV_BillTo_Pincode;  }
set
   {
     this._PINV_BillTo_Pincode = value;
     _UpdateFieldName.Add("PINV_BillTo_Pincode");
     }
}
public String PINV_BillTo_Area
{
get
  {
   return this._PINV_BillTo_Area;  }
set
   {
     this._PINV_BillTo_Area = value;
     _UpdateFieldName.Add("PINV_BillTo_Area");
     }
}
public String PINV_BillTo_City
{
get
  {
   return this._PINV_BillTo_City;  }
set
   {
     this._PINV_BillTo_City = value;
     _UpdateFieldName.Add("PINV_BillTo_City");
     }
}
public Int64 PINV_BillTo_State_ID
{
get
  {
   return this._PINV_BillTo_State_ID;  }
set
   {
     this._PINV_BillTo_State_ID = value;
     _UpdateFieldName.Add("PINV_BillTo_State_ID");
     }
}
public String PINV_BillTo_Country
{
get
  {
   return this._PINV_BillTo_Country;  }
set
   {
     this._PINV_BillTo_Country = value;
     _UpdateFieldName.Add("PINV_BillTo_Country");
     }
}
public String PINV_BillTo_GSTNo
{
get
  {
   return this._PINV_BillTo_GSTNo;  }
set
   {
     this._PINV_BillTo_GSTNo = value;
     _UpdateFieldName.Add("PINV_BillTo_GSTNo");
     }
}
public String PINV_BillTo_PANNO
{
get
  {
   return this._PINV_BillTo_PANNO;  }
set
   {
     this._PINV_BillTo_PANNO = value;
     _UpdateFieldName.Add("PINV_BillTo_PANNO");
     }
}
public String PINV_ShippTo_CompanyName
{
get
  {
   return this._PINV_ShippTo_CompanyName;  }
set
   {
     this._PINV_ShippTo_CompanyName = value;
     _UpdateFieldName.Add("PINV_ShippTo_CompanyName");
     }
}
public String PINV_ShippTo_ContactPersone
{
get
  {
   return this._PINV_ShippTo_ContactPersone;  }
set
   {
     this._PINV_ShippTo_ContactPersone = value;
     _UpdateFieldName.Add("PINV_ShippTo_ContactPersone");
     }
}
public String PINV_ShippTo_CP_MobileNo
{
get
  {
   return this._PINV_ShippTo_CP_MobileNo;  }
set
   {
     this._PINV_ShippTo_CP_MobileNo = value;
     _UpdateFieldName.Add("PINV_ShippTo_CP_MobileNo");
     }
}
public String PINV_ShippTo_Add1
{
get
  {
   return this._PINV_ShippTo_Add1;  }
set
   {
     this._PINV_ShippTo_Add1 = value;
     _UpdateFieldName.Add("PINV_ShippTo_Add1");
     }
}
public String PINV_ShippTo_Add2
{
get
  {
   return this._PINV_ShippTo_Add2;  }
set
   {
     this._PINV_ShippTo_Add2 = value;
     _UpdateFieldName.Add("PINV_ShippTo_Add2");
     }
}
public String PINV_ShippTo_Add3
{
get
  {
   return this._PINV_ShippTo_Add3;  }
set
   {
     this._PINV_ShippTo_Add3 = value;
     _UpdateFieldName.Add("PINV_ShippTo_Add3");
     }
}
public String PINV_ShippTo_Pincode
{
get
  {
   return this._PINV_ShippTo_Pincode;  }
set
   {
     this._PINV_ShippTo_Pincode = value;
     _UpdateFieldName.Add("PINV_ShippTo_Pincode");
     }
}
public String PINV_ShippTo_Area
{
get
  {
   return this._PINV_ShippTo_Area;  }
set
   {
     this._PINV_ShippTo_Area = value;
     _UpdateFieldName.Add("PINV_ShippTo_Area");
     }
}
public String PINV_ShippTo_City
{
get
  {
   return this._PINV_ShippTo_City;  }
set
   {
     this._PINV_ShippTo_City = value;
     _UpdateFieldName.Add("PINV_ShippTo_City");
     }
}
public Int64 PINV_ShippTo_State_ID
{
get
  {
   return this._PINV_ShippTo_State_ID;  }
set
   {
     this._PINV_ShippTo_State_ID = value;
     _UpdateFieldName.Add("PINV_ShippTo_State_ID");
     }
}
public String PINV_ShippTo_Country
{
get
  {
   return this._PINV_ShippTo_Country;  }
set
   {
     this._PINV_ShippTo_Country = value;
     _UpdateFieldName.Add("PINV_ShippTo_Country");
     }
}
public String PINV_ShippTo_GSTNo
{
get
  {
   return this._PINV_ShippTo_GSTNo;  }
set
   {
     this._PINV_ShippTo_GSTNo = value;
     _UpdateFieldName.Add("PINV_ShippTo_GSTNo");
     }
}
public String PINV_ShippTo_PANNO
{
get
  {
   return this._PINV_ShippTo_PANNO;  }
set
   {
     this._PINV_ShippTo_PANNO = value;
     _UpdateFieldName.Add("PINV_ShippTo_PANNO");
     }
}
public String PINV_ShippedFrom_CompanyName
{
get
  {
   return this._PINV_ShippedFrom_CompanyName;  }
set
   {
     this._PINV_ShippedFrom_CompanyName = value;
     _UpdateFieldName.Add("PINV_ShippedFrom_CompanyName");
     }
}
public String PINV_ShippedFrom_ContactPersone
{
get
  {
   return this._PINV_ShippedFrom_ContactPersone;  }
set
   {
     this._PINV_ShippedFrom_ContactPersone = value;
     _UpdateFieldName.Add("PINV_ShippedFrom_ContactPersone");
     }
}
public String PINV_ShippedFrom_CP_MobileNo
{
get
  {
   return this._PINV_ShippedFrom_CP_MobileNo;  }
set
   {
     this._PINV_ShippedFrom_CP_MobileNo = value;
     _UpdateFieldName.Add("PINV_ShippedFrom_CP_MobileNo");
     }
}
public String PINV_ShippedFrom_Add1
{
get
  {
   return this._PINV_ShippedFrom_Add1;  }
set
   {
     this._PINV_ShippedFrom_Add1 = value;
     _UpdateFieldName.Add("PINV_ShippedFrom_Add1");
     }
}
public String PINV_ShippedFrom_Add2
{
get
  {
   return this._PINV_ShippedFrom_Add2;  }
set
   {
     this._PINV_ShippedFrom_Add2 = value;
     _UpdateFieldName.Add("PINV_ShippedFrom_Add2");
     }
}
public String PINV_ShippedFrom_Add3
{
get
  {
   return this._PINV_ShippedFrom_Add3;  }
set
   {
     this._PINV_ShippedFrom_Add3 = value;
     _UpdateFieldName.Add("PINV_ShippedFrom_Add3");
     }
}
public String PINV_ShippedFrom_Pincode
{
get
  {
   return this._PINV_ShippedFrom_Pincode;  }
set
   {
     this._PINV_ShippedFrom_Pincode = value;
     _UpdateFieldName.Add("PINV_ShippedFrom_Pincode");
     }
}
public String PINV_ShippedFrom_Area
{
get
  {
   return this._PINV_ShippedFrom_Area;  }
set
   {
     this._PINV_ShippedFrom_Area = value;
     _UpdateFieldName.Add("PINV_ShippedFrom_Area");
     }
}
public String PINV_ShippedFrom_City
{
get
  {
   return this._PINV_ShippedFrom_City;  }
set
   {
     this._PINV_ShippedFrom_City = value;
     _UpdateFieldName.Add("PINV_ShippedFrom_City");
     }
}
public Int64 PINV_ShippedFrom_State_ID
{
get
  {
   return this._PINV_ShippedFrom_State_ID;  }
set
   {
     this._PINV_ShippedFrom_State_ID = value;
     _UpdateFieldName.Add("PINV_ShippedFrom_State_ID");
     }
}
public String PINV_ShippedFrom_Country
{
get
  {
   return this._PINV_ShippedFrom_Country;  }
set
   {
     this._PINV_ShippedFrom_Country = value;
     _UpdateFieldName.Add("PINV_ShippedFrom_Country");
     }
}
public String PINV_ShippedFrom_GSTNo
{
get
  {
   return this._PINV_ShippedFrom_GSTNo;  }
set
   {
     this._PINV_ShippedFrom_GSTNo = value;
     _UpdateFieldName.Add("PINV_ShippedFrom_GSTNo");
     }
}
public String PINV_ShippedFrom_PANNO
{
get
  {
   return this._PINV_ShippedFrom_PANNO;  }
set
   {
     this._PINV_ShippedFrom_PANNO = value;
     _UpdateFieldName.Add("PINV_ShippedFrom_PANNO");
     }
}
public String PINV_PaymentTerms
{
get
  {
   return this._PINV_PaymentTerms;  }
set
   {
     this._PINV_PaymentTerms = value;
     _UpdateFieldName.Add("PINV_PaymentTerms");
     }
}
public String PINV_DelvieryPeriod
{
get
  {
   return this._PINV_DelvieryPeriod;  }
set
   {
     this._PINV_DelvieryPeriod = value;
     _UpdateFieldName.Add("PINV_DelvieryPeriod");
     }
}
public String PINV_DeliveryCharges
{
get
  {
   return this._PINV_DeliveryCharges;  }
set
   {
     this._PINV_DeliveryCharges = value;
     _UpdateFieldName.Add("PINV_DeliveryCharges");
     }
}
public String PINV_ExciseDuty
{
get
  {
   return this._PINV_ExciseDuty;  }
set
   {
     this._PINV_ExciseDuty = value;
     _UpdateFieldName.Add("PINV_ExciseDuty");
     }
}
public String PINV_CompletionPeriod
{
get
  {
   return this._PINV_CompletionPeriod;  }
set
   {
     this._PINV_CompletionPeriod = value;
     _UpdateFieldName.Add("PINV_CompletionPeriod");
     }
}
public String PINV_ModeOfDispatch
{
get
  {
   return this._PINV_ModeOfDispatch;  }
set
   {
     this._PINV_ModeOfDispatch = value;
     _UpdateFieldName.Add("PINV_ModeOfDispatch");
     }
}
public String PINV_TranspoterName
{
get
  {
   return this._PINV_TranspoterName;  }
set
   {
     this._PINV_TranspoterName = value;
     _UpdateFieldName.Add("PINV_TranspoterName");
     }
}
public String PINV_VehicleNumber
{
get
  {
   return this._PINV_VehicleNumber;  }
set
   {
     this._PINV_VehicleNumber = value;
     _UpdateFieldName.Add("PINV_VehicleNumber");
     }
}
public String PINV_PlaceOfDelivery
{
get
  {
   return this._PINV_PlaceOfDelivery;  }
set
   {
     this._PINV_PlaceOfDelivery = value;
     _UpdateFieldName.Add("PINV_PlaceOfDelivery");
     }
}
public String PINV_FreigthCharge_Txt
{
get
  {
   return this._PINV_FreigthCharge_Txt;  }
set
   {
     this._PINV_FreigthCharge_Txt = value;
     _UpdateFieldName.Add("PINV_FreigthCharge_Txt");
     }
}
public String PINV_Insurance_Txt
{
get
  {
   return this._PINV_Insurance_Txt;  }
set
   {
     this._PINV_Insurance_Txt = value;
     _UpdateFieldName.Add("PINV_Insurance_Txt");
     }
}
public String PINV_Remark
{
get
  {
   return this._PINV_Remark;  }
set
   {
     this._PINV_Remark = value;
     _UpdateFieldName.Add("PINV_Remark");
     }
}
public Int16 PINV_L1AuthorizeID
{
get
  {
   return this._PINV_L1AuthorizeID;  }
set
   {
     this._PINV_L1AuthorizeID = value;
     _UpdateFieldName.Add("PINV_L1AuthorizeID");
     }
}
public String PINV_L1AuthorizeBy
{
get
  {
   return this._PINV_L1AuthorizeBy;  }
set
   {
     this._PINV_L1AuthorizeBy = value;
     _UpdateFieldName.Add("PINV_L1AuthorizeBy");
     }
}
public String PINV_L1AuthorizeDT
{
get
  {
   return this._PINV_L1AuthorizeDT;  }
set
   {
     this._PINV_L1AuthorizeDT = value;
     _UpdateFieldName.Add("PINV_L1AuthorizeDT");
     }
}
public Int16 PINV_L2AuthorizeID
{
get
  {
   return this._PINV_L2AuthorizeID;  }
set
   {
     this._PINV_L2AuthorizeID = value;
     _UpdateFieldName.Add("PINV_L2AuthorizeID");
     }
}
public String PINV_L2AuthorizeBy
{
get
  {
   return this._PINV_L2AuthorizeBy;  }
set
   {
     this._PINV_L2AuthorizeBy = value;
     _UpdateFieldName.Add("PINV_L2AuthorizeBy");
     }
}
public String PINV_L2AuthorizeDT
{
get
  {
   return this._PINV_L2AuthorizeDT;  }
set
   {
     this._PINV_L2AuthorizeDT = value;
     _UpdateFieldName.Add("PINV_L2AuthorizeDT");
     }
}
public String PINV_AuthRemark
{
get
  {
   return this._PINV_AuthRemark;  }
set
   {
     this._PINV_AuthRemark = value;
     _UpdateFieldName.Add("PINV_AuthRemark");
     }
}
public Int16 PINV_DTL_CNT
{
get
  {
   return this._PINV_DTL_CNT;  }
set
   {
     this._PINV_DTL_CNT = value;
     _UpdateFieldName.Add("PINV_DTL_CNT");
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
public Decimal PINV_HDR_BasicAmt
{
get
  {
   return this._PINV_HDR_BasicAmt;  }
set
   {
     this._PINV_HDR_BasicAmt = value;
     _UpdateFieldName.Add("PINV_HDR_BasicAmt");
     }
}
public Decimal PINV_HDR_DiscountRate
{
get
  {
   return this._PINV_HDR_DiscountRate;  }
set
   {
     this._PINV_HDR_DiscountRate = value;
     _UpdateFieldName.Add("PINV_HDR_DiscountRate");
     }
}
public Decimal PINV_HDR_DiscountAmt
{
get
  {
   return this._PINV_HDR_DiscountAmt;  }
set
   {
     this._PINV_HDR_DiscountAmt = value;
     _UpdateFieldName.Add("PINV_HDR_DiscountAmt");
     }
}
public Decimal PINV_HDR_Net_Amt
{
get
  {
   return this._PINV_HDR_Net_Amt;  }
set
   {
     this._PINV_HDR_Net_Amt = value;
     _UpdateFieldName.Add("PINV_HDR_Net_Amt");
     }
}
public Decimal PINV_HDR_Freight_Charges
{
get
  {
   return this._PINV_HDR_Freight_Charges;  }
set
   {
     this._PINV_HDR_Freight_Charges = value;
     _UpdateFieldName.Add("PINV_HDR_Freight_Charges");
     }
}
public Decimal PINV_HDR_Loading_N_Packing_Charges
{
get
  {
   return this._PINV_HDR_Loading_N_Packing_Charges;  }
set
   {
     this._PINV_HDR_Loading_N_Packing_Charges = value;
     _UpdateFieldName.Add("PINV_HDR_Loading_N_Packing_Charges");
     }
}
public Decimal PINV_HDR_Insurance_Charges
{
get
  {
   return this._PINV_HDR_Insurance_Charges;  }
set
   {
     this._PINV_HDR_Insurance_Charges = value;
     _UpdateFieldName.Add("PINV_HDR_Insurance_Charges");
     }
}
public String PINV_HDR_Other_Charges_Txt
{
get
  {
   return this._PINV_HDR_Other_Charges_Txt;  }
set
   {
     this._PINV_HDR_Other_Charges_Txt = value;
     _UpdateFieldName.Add("PINV_HDR_Other_Charges_Txt");
     }
}
public Decimal PINV_HDR_Other_Charges_Amt
{
get
  {
   return this._PINV_HDR_Other_Charges_Amt;  }
set
   {
     this._PINV_HDR_Other_Charges_Amt = value;
     _UpdateFieldName.Add("PINV_HDR_Other_Charges_Amt");
     }
}
public Decimal PINV_HDR_Taxable_Amt
{
get
  {
   return this._PINV_HDR_Taxable_Amt;  }
set
   {
     this._PINV_HDR_Taxable_Amt = value;
     _UpdateFieldName.Add("PINV_HDR_Taxable_Amt");
     }
}
public Decimal PINV_HDR_CGST_Amt
{
get
  {
   return this._PINV_HDR_CGST_Amt;  }
set
   {
     this._PINV_HDR_CGST_Amt = value;
     _UpdateFieldName.Add("PINV_HDR_CGST_Amt");
     }
}
public Decimal PINV_HDR_CGST_Taxable_Amt
{
get
  {
   return this._PINV_HDR_CGST_Taxable_Amt;  }
set
   {
     this._PINV_HDR_CGST_Taxable_Amt = value;
     _UpdateFieldName.Add("PINV_HDR_CGST_Taxable_Amt");
     }
}
public Decimal PINV_HDR_SGST_Amt
{
get
  {
   return this._PINV_HDR_SGST_Amt;  }
set
   {
     this._PINV_HDR_SGST_Amt = value;
     _UpdateFieldName.Add("PINV_HDR_SGST_Amt");
     }
}
public Decimal PINV_HDR_SGST_Taxable_Amt
{
get
  {
   return this._PINV_HDR_SGST_Taxable_Amt;  }
set
   {
     this._PINV_HDR_SGST_Taxable_Amt = value;
     _UpdateFieldName.Add("PINV_HDR_SGST_Taxable_Amt");
     }
}
public Decimal PINV_HDR_IGST_Amt
{
get
  {
   return this._PINV_HDR_IGST_Amt;  }
set
   {
     this._PINV_HDR_IGST_Amt = value;
     _UpdateFieldName.Add("PINV_HDR_IGST_Amt");
     }
}
public Decimal PINV_HDR_IGST_Taxable_Amt
{
get
  {
   return this._PINV_HDR_IGST_Taxable_Amt;  }
set
   {
     this._PINV_HDR_IGST_Taxable_Amt = value;
     _UpdateFieldName.Add("PINV_HDR_IGST_Taxable_Amt");
     }
}
public Decimal PINV_HDR_CESS_Amt
{
get
  {
   return this._PINV_HDR_CESS_Amt;  }
set
   {
     this._PINV_HDR_CESS_Amt = value;
     _UpdateFieldName.Add("PINV_HDR_CESS_Amt");
     }
}
public Decimal PINV_HDR_CESS_Taxable_Amt
{
get
  {
   return this._PINV_HDR_CESS_Taxable_Amt;  }
set
   {
     this._PINV_HDR_CESS_Taxable_Amt = value;
     _UpdateFieldName.Add("PINV_HDR_CESS_Taxable_Amt");
     }
}
public Int16 PINV_HDR_OtherTax_ID
{
get
  {
   return this._PINV_HDR_OtherTax_ID;  }
set
   {
     this._PINV_HDR_OtherTax_ID = value;
     _UpdateFieldName.Add("PINV_HDR_OtherTax_ID");
     }
}
public Decimal PINV_HDR_OtherTax_Rate
{
get
  {
   return this._PINV_HDR_OtherTax_Rate;  }
set
   {
     this._PINV_HDR_OtherTax_Rate = value;
     _UpdateFieldName.Add("PINV_HDR_OtherTax_Rate");
     }
}
public Decimal PINV_HDR_OtherTax_Amt
{
get
  {
   return this._PINV_HDR_OtherTax_Amt;  }
set
   {
     this._PINV_HDR_OtherTax_Amt = value;
     _UpdateFieldName.Add("PINV_HDR_OtherTax_Amt");
     }
}
public Decimal PINV_HDR_Other_Taxable_Amt
{
get
  {
   return this._PINV_HDR_Other_Taxable_Amt;  }
set
   {
     this._PINV_HDR_Other_Taxable_Amt = value;
     _UpdateFieldName.Add("PINV_HDR_Other_Taxable_Amt");
     }
}
public Decimal PINV_HDR_Total_Tax_Amt
{
get
  {
   return this._PINV_HDR_Total_Tax_Amt;  }
set
   {
     this._PINV_HDR_Total_Tax_Amt = value;
     _UpdateFieldName.Add("PINV_HDR_Total_Tax_Amt");
     }
}
public Decimal PINV_HDR_ItemGross_Total_Amt
{
get
  {
   return this._PINV_HDR_ItemGross_Total_Amt;  }
set
   {
     this._PINV_HDR_ItemGross_Total_Amt = value;
     _UpdateFieldName.Add("PINV_HDR_ItemGross_Total_Amt");
     }
}
public Decimal PINV_HDR_Gross_Amt
{
get
  {
   return this._PINV_HDR_Gross_Amt;  }
set
   {
     this._PINV_HDR_Gross_Amt = value;
     _UpdateFieldName.Add("PINV_HDR_Gross_Amt");
     }
}
public Decimal PINV_HDR_Round_Off_Amt
{
get
  {
   return this._PINV_HDR_Round_Off_Amt;  }
set
   {
     this._PINV_HDR_Round_Off_Amt = value;
     _UpdateFieldName.Add("PINV_HDR_Round_Off_Amt");
     }
}
public Decimal PINV_HDR_Total_Gross_Amt
{
get
  {
   return this._PINV_HDR_Total_Gross_Amt;  }
set
   {
     this._PINV_HDR_Total_Gross_Amt = value;
     _UpdateFieldName.Add("PINV_HDR_Total_Gross_Amt");
     }
}
public String PINV_HDR_Gross_AmtInWords
{
get
  {
   return this._PINV_HDR_Gross_AmtInWords;  }
set
   {
     this._PINV_HDR_Gross_AmtInWords = value;
     _UpdateFieldName.Add("PINV_HDR_Gross_AmtInWords");
     }
}
public Decimal PINV_HDR_CreditNote_AsOn_Amt
{
get
  {
   return this._PINV_HDR_CreditNote_AsOn_Amt;  }
set
   {
     this._PINV_HDR_CreditNote_AsOn_Amt = value;
     _UpdateFieldName.Add("PINV_HDR_CreditNote_AsOn_Amt");
     }
}
public Decimal PINV_HDR_DebitNote_AsOn_Amt
{
get
  {
   return this._PINV_HDR_DebitNote_AsOn_Amt;  }
set
   {
     this._PINV_HDR_DebitNote_AsOn_Amt = value;
     _UpdateFieldName.Add("PINV_HDR_DebitNote_AsOn_Amt");
     }
}
public Decimal PINV_HDR_TDS_Rate
{
get
  {
   return this._PINV_HDR_TDS_Rate;  }
set
   {
     this._PINV_HDR_TDS_Rate = value;
     _UpdateFieldName.Add("PINV_HDR_TDS_Rate");
     }
}
public Decimal PINV_HDR_TDS_Amt
{
get
  {
   return this._PINV_HDR_TDS_Amt;  }
set
   {
     this._PINV_HDR_TDS_Amt = value;
     _UpdateFieldName.Add("PINV_HDR_TDS_Amt");
     }
}
public Decimal PINV_HDR_Paid_AsOn_Amt
{
get
  {
   return this._PINV_HDR_Paid_AsOn_Amt;  }
set
   {
     this._PINV_HDR_Paid_AsOn_Amt = value;
     _UpdateFieldName.Add("PINV_HDR_Paid_AsOn_Amt");
     }
}
public Decimal PINV_HDR_Outstanding_AsOn_Amt
{
get
  {
   return this._PINV_HDR_Outstanding_AsOn_Amt;  }
set
   {
     this._PINV_HDR_Outstanding_AsOn_Amt = value;
     _UpdateFieldName.Add("PINV_HDR_Outstanding_AsOn_Amt");
     }
}

#endregion
#region Genric Methods
public string Insert_Update(M_AT_Purchase_Inv_AHDRBO sObject)
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

// ObjAT_PINVHDR.PINVHDR_ID=ObjAT_PINVHDR.PINVHDR_ID;
// ObjAT_PINVHDR.Fk_PIHDR_ID=ObjAT_PINVHDR.Fk_PIHDR_ID;
// ObjAT_PINVHDR.Fk_Company_ID=ObjAT_PINVHDR.Fk_Company_ID;
// ObjAT_PINVHDR.Fk_Branch_ID=ObjAT_PINVHDR.Fk_Branch_ID;
// ObjAT_PINVHDR.Fk_Year_ID=ObjAT_PINVHDR.Fk_Year_ID;
// ObjAT_PINVHDR.Fk_Currency_ID=ObjAT_PINVHDR.Fk_Currency_ID;
// ObjAT_PINVHDR.Rec_Created_In=ObjAT_PINVHDR.Rec_Created_In;
// ObjAT_PINVHDR.Rec_CreatedBy_ID=ObjAT_PINVHDR.Rec_CreatedBy_ID;
// ObjAT_PINVHDR.Rec_CreatedFor_ID=ObjAT_PINVHDR.Rec_CreatedFor_ID;
// ObjAT_PINVHDR.PINV_CreationType=ObjAT_PINVHDR.PINV_CreationType;
// ObjAT_PINVHDR.PINV_Type=ObjAT_PINVHDR.PINV_Type;
// ObjAT_PINVHDR.PINV_Category=ObjAT_PINVHDR.PINV_Category;
// ObjAT_PINVHDR.PINV_Taxtype=ObjAT_PINVHDR.PINV_Taxtype;
// ObjAT_PINVHDR.PINV_No=ObjAT_PINVHDR.PINV_No;
// ObjAT_PINVHDR.PINV_DT=ObjAT_PINVHDR.PINV_DT;
// ObjAT_PINVHDR.Fk_VendorID=ObjAT_PINVHDR.Fk_VendorID;
// ObjAT_PINVHDR.PINV_CreditDays=ObjAT_PINVHDR.PINV_CreditDays;
// ObjAT_PINVHDR.PINV_DueDT=ObjAT_PINVHDR.PINV_DueDT;
// ObjAT_PINVHDR.PINV_State_ID=ObjAT_PINVHDR.PINV_State_ID;
// ObjAT_PINVHDR.PINV_PONo=ObjAT_PINVHDR.PINV_PONo;
// ObjAT_PINVHDR.PINV_PO_DT=ObjAT_PINVHDR.PINV_PO_DT;
// ObjAT_PINVHDR.PINV_BillTo_CompanyName=ObjAT_PINVHDR.PINV_BillTo_CompanyName;
// ObjAT_PINVHDR.PINV_BillTo_ContactPersone=ObjAT_PINVHDR.PINV_BillTo_ContactPersone;
// ObjAT_PINVHDR.PINV_BillTo_CP_MobileNo=ObjAT_PINVHDR.PINV_BillTo_CP_MobileNo;
// ObjAT_PINVHDR.PINV_BillTo_Add1=ObjAT_PINVHDR.PINV_BillTo_Add1;
// ObjAT_PINVHDR.PINV_BillTo_Add2=ObjAT_PINVHDR.PINV_BillTo_Add2;
// ObjAT_PINVHDR.PINV_BillTo_Add3=ObjAT_PINVHDR.PINV_BillTo_Add3;
// ObjAT_PINVHDR.PINV_BillTo_Pincode=ObjAT_PINVHDR.PINV_BillTo_Pincode;
// ObjAT_PINVHDR.PINV_BillTo_Area=ObjAT_PINVHDR.PINV_BillTo_Area;
// ObjAT_PINVHDR.PINV_BillTo_City=ObjAT_PINVHDR.PINV_BillTo_City;
// ObjAT_PINVHDR.PINV_BillTo_State_ID=ObjAT_PINVHDR.PINV_BillTo_State_ID;
// ObjAT_PINVHDR.PINV_BillTo_Country=ObjAT_PINVHDR.PINV_BillTo_Country;
// ObjAT_PINVHDR.PINV_BillTo_GSTNo=ObjAT_PINVHDR.PINV_BillTo_GSTNo;
// ObjAT_PINVHDR.PINV_BillTo_PANNO=ObjAT_PINVHDR.PINV_BillTo_PANNO;
// ObjAT_PINVHDR.PINV_ShippTo_CompanyName=ObjAT_PINVHDR.PINV_ShippTo_CompanyName;
// ObjAT_PINVHDR.PINV_ShippTo_ContactPersone=ObjAT_PINVHDR.PINV_ShippTo_ContactPersone;
// ObjAT_PINVHDR.PINV_ShippTo_CP_MobileNo=ObjAT_PINVHDR.PINV_ShippTo_CP_MobileNo;
// ObjAT_PINVHDR.PINV_ShippTo_Add1=ObjAT_PINVHDR.PINV_ShippTo_Add1;
// ObjAT_PINVHDR.PINV_ShippTo_Add2=ObjAT_PINVHDR.PINV_ShippTo_Add2;
// ObjAT_PINVHDR.PINV_ShippTo_Add3=ObjAT_PINVHDR.PINV_ShippTo_Add3;
// ObjAT_PINVHDR.PINV_ShippTo_Pincode=ObjAT_PINVHDR.PINV_ShippTo_Pincode;
// ObjAT_PINVHDR.PINV_ShippTo_Area=ObjAT_PINVHDR.PINV_ShippTo_Area;
// ObjAT_PINVHDR.PINV_ShippTo_City=ObjAT_PINVHDR.PINV_ShippTo_City;
// ObjAT_PINVHDR.PINV_ShippTo_State_ID=ObjAT_PINVHDR.PINV_ShippTo_State_ID;
// ObjAT_PINVHDR.PINV_ShippTo_Country=ObjAT_PINVHDR.PINV_ShippTo_Country;
// ObjAT_PINVHDR.PINV_ShippTo_GSTNo=ObjAT_PINVHDR.PINV_ShippTo_GSTNo;
// ObjAT_PINVHDR.PINV_ShippTo_PANNO=ObjAT_PINVHDR.PINV_ShippTo_PANNO;
// ObjAT_PINVHDR.PINV_ShippedFrom_CompanyName=ObjAT_PINVHDR.PINV_ShippedFrom_CompanyName;
// ObjAT_PINVHDR.PINV_ShippedFrom_ContactPersone=ObjAT_PINVHDR.PINV_ShippedFrom_ContactPersone;
// ObjAT_PINVHDR.PINV_ShippedFrom_CP_MobileNo=ObjAT_PINVHDR.PINV_ShippedFrom_CP_MobileNo;
// ObjAT_PINVHDR.PINV_ShippedFrom_Add1=ObjAT_PINVHDR.PINV_ShippedFrom_Add1;
// ObjAT_PINVHDR.PINV_ShippedFrom_Add2=ObjAT_PINVHDR.PINV_ShippedFrom_Add2;
// ObjAT_PINVHDR.PINV_ShippedFrom_Add3=ObjAT_PINVHDR.PINV_ShippedFrom_Add3;
// ObjAT_PINVHDR.PINV_ShippedFrom_Pincode=ObjAT_PINVHDR.PINV_ShippedFrom_Pincode;
// ObjAT_PINVHDR.PINV_ShippedFrom_Area=ObjAT_PINVHDR.PINV_ShippedFrom_Area;
// ObjAT_PINVHDR.PINV_ShippedFrom_City=ObjAT_PINVHDR.PINV_ShippedFrom_City;
// ObjAT_PINVHDR.PINV_ShippedFrom_State_ID=ObjAT_PINVHDR.PINV_ShippedFrom_State_ID;
// ObjAT_PINVHDR.PINV_ShippedFrom_Country=ObjAT_PINVHDR.PINV_ShippedFrom_Country;
// ObjAT_PINVHDR.PINV_ShippedFrom_GSTNo=ObjAT_PINVHDR.PINV_ShippedFrom_GSTNo;
// ObjAT_PINVHDR.PINV_ShippedFrom_PANNO=ObjAT_PINVHDR.PINV_ShippedFrom_PANNO;
// ObjAT_PINVHDR.PINV_PaymentTerms=ObjAT_PINVHDR.PINV_PaymentTerms;
// ObjAT_PINVHDR.PINV_DelvieryPeriod=ObjAT_PINVHDR.PINV_DelvieryPeriod;
// ObjAT_PINVHDR.PINV_DeliveryCharges=ObjAT_PINVHDR.PINV_DeliveryCharges;
// ObjAT_PINVHDR.PINV_ExciseDuty=ObjAT_PINVHDR.PINV_ExciseDuty;
// ObjAT_PINVHDR.PINV_CompletionPeriod=ObjAT_PINVHDR.PINV_CompletionPeriod;
// ObjAT_PINVHDR.PINV_ModeOfDispatch=ObjAT_PINVHDR.PINV_ModeOfDispatch;
// ObjAT_PINVHDR.PINV_TranspoterName=ObjAT_PINVHDR.PINV_TranspoterName;
// ObjAT_PINVHDR.PINV_VehicleNumber=ObjAT_PINVHDR.PINV_VehicleNumber;
// ObjAT_PINVHDR.PINV_PlaceOfDelivery=ObjAT_PINVHDR.PINV_PlaceOfDelivery;
// ObjAT_PINVHDR.PINV_FreigthCharge_Txt=ObjAT_PINVHDR.PINV_FreigthCharge_Txt;
// ObjAT_PINVHDR.PINV_Insurance_Txt=ObjAT_PINVHDR.PINV_Insurance_Txt;
// ObjAT_PINVHDR.PINV_Remark=ObjAT_PINVHDR.PINV_Remark;
// ObjAT_PINVHDR.PINV_L1AuthorizeID=ObjAT_PINVHDR.PINV_L1AuthorizeID;
// ObjAT_PINVHDR.PINV_L1AuthorizeBy=ObjAT_PINVHDR.PINV_L1AuthorizeBy;
// ObjAT_PINVHDR.PINV_L1AuthorizeDT=ObjAT_PINVHDR.PINV_L1AuthorizeDT;
// ObjAT_PINVHDR.PINV_L2AuthorizeID=ObjAT_PINVHDR.PINV_L2AuthorizeID;
// ObjAT_PINVHDR.PINV_L2AuthorizeBy=ObjAT_PINVHDR.PINV_L2AuthorizeBy;
// ObjAT_PINVHDR.PINV_L2AuthorizeDT=ObjAT_PINVHDR.PINV_L2AuthorizeDT;
// ObjAT_PINVHDR.PINV_AuthRemark=ObjAT_PINVHDR.PINV_AuthRemark;
// ObjAT_PINVHDR.PINV_DTL_CNT=ObjAT_PINVHDR.PINV_DTL_CNT;
// ObjAT_PINVHDR.MDBSC_RowStatus=ObjAT_PINVHDR.MDBSC_RowStatus;
// ObjAT_PINVHDR.MDBSC_RowCreatedByUser_ID=ObjAT_PINVHDR.MDBSC_RowCreatedByUser_ID;
// ObjAT_PINVHDR.MDBSC_RowCreatedByUserName=ObjAT_PINVHDR.MDBSC_RowCreatedByUserName;
// ObjAT_PINVHDR.MDBSC_RowCreatedOn_DT=ObjAT_PINVHDR.MDBSC_RowCreatedOn_DT;
// ObjAT_PINVHDR.MDBSC_RowLupdnByUser_ID=ObjAT_PINVHDR.MDBSC_RowLupdnByUser_ID;
// ObjAT_PINVHDR.MDBSC_RowLupdnUserName=ObjAT_PINVHDR.MDBSC_RowLupdnUserName;
// ObjAT_PINVHDR.MDBSC_RowLupdnOn_DT=ObjAT_PINVHDR.MDBSC_RowLupdnOn_DT;
// ObjAT_PINVHDR.PINV_HDR_BasicAmt=ObjAT_PINVHDR.PINV_HDR_BasicAmt;
// ObjAT_PINVHDR.PINV_HDR_DiscountRate=ObjAT_PINVHDR.PINV_HDR_DiscountRate;
// ObjAT_PINVHDR.PINV_HDR_DiscountAmt=ObjAT_PINVHDR.PINV_HDR_DiscountAmt;
// ObjAT_PINVHDR.PINV_HDR_Net_Amt=ObjAT_PINVHDR.PINV_HDR_Net_Amt;
// ObjAT_PINVHDR.PINV_HDR_Freight_Charges=ObjAT_PINVHDR.PINV_HDR_Freight_Charges;
// ObjAT_PINVHDR.PINV_HDR_Loading_N_Packing_Charges=ObjAT_PINVHDR.PINV_HDR_Loading_N_Packing_Charges;
// ObjAT_PINVHDR.PINV_HDR_Insurance_Charges=ObjAT_PINVHDR.PINV_HDR_Insurance_Charges;
// ObjAT_PINVHDR.PINV_HDR_Other_Charges_Txt=ObjAT_PINVHDR.PINV_HDR_Other_Charges_Txt;
// ObjAT_PINVHDR.PINV_HDR_Other_Charges_Amt=ObjAT_PINVHDR.PINV_HDR_Other_Charges_Amt;
// ObjAT_PINVHDR.PINV_HDR_Taxable_Amt=ObjAT_PINVHDR.PINV_HDR_Taxable_Amt;
// ObjAT_PINVHDR.PINV_HDR_CGST_Amt=ObjAT_PINVHDR.PINV_HDR_CGST_Amt;
// ObjAT_PINVHDR.PINV_HDR_CGST_Taxable_Amt=ObjAT_PINVHDR.PINV_HDR_CGST_Taxable_Amt;
// ObjAT_PINVHDR.PINV_HDR_SGST_Amt=ObjAT_PINVHDR.PINV_HDR_SGST_Amt;
// ObjAT_PINVHDR.PINV_HDR_SGST_Taxable_Amt=ObjAT_PINVHDR.PINV_HDR_SGST_Taxable_Amt;
// ObjAT_PINVHDR.PINV_HDR_IGST_Amt=ObjAT_PINVHDR.PINV_HDR_IGST_Amt;
// ObjAT_PINVHDR.PINV_HDR_IGST_Taxable_Amt=ObjAT_PINVHDR.PINV_HDR_IGST_Taxable_Amt;
// ObjAT_PINVHDR.PINV_HDR_CESS_Amt=ObjAT_PINVHDR.PINV_HDR_CESS_Amt;
// ObjAT_PINVHDR.PINV_HDR_CESS_Taxable_Amt=ObjAT_PINVHDR.PINV_HDR_CESS_Taxable_Amt;
// ObjAT_PINVHDR.PINV_HDR_OtherTax_ID=ObjAT_PINVHDR.PINV_HDR_OtherTax_ID;
// ObjAT_PINVHDR.PINV_HDR_OtherTax_Rate=ObjAT_PINVHDR.PINV_HDR_OtherTax_Rate;
// ObjAT_PINVHDR.PINV_HDR_OtherTax_Amt=ObjAT_PINVHDR.PINV_HDR_OtherTax_Amt;
// ObjAT_PINVHDR.PINV_HDR_Other_Taxable_Amt=ObjAT_PINVHDR.PINV_HDR_Other_Taxable_Amt;
// ObjAT_PINVHDR.PINV_HDR_Total_Tax_Amt=ObjAT_PINVHDR.PINV_HDR_Total_Tax_Amt;
// ObjAT_PINVHDR.PINV_HDR_ItemGross_Total_Amt=ObjAT_PINVHDR.PINV_HDR_ItemGross_Total_Amt;
// ObjAT_PINVHDR.PINV_HDR_Gross_Amt=ObjAT_PINVHDR.PINV_HDR_Gross_Amt;
// ObjAT_PINVHDR.PINV_HDR_Round_Off_Amt=ObjAT_PINVHDR.PINV_HDR_Round_Off_Amt;
// ObjAT_PINVHDR.PINV_HDR_Total_Gross_Amt=ObjAT_PINVHDR.PINV_HDR_Total_Gross_Amt;
// ObjAT_PINVHDR.PINV_HDR_Gross_AmtInWords=ObjAT_PINVHDR.PINV_HDR_Gross_AmtInWords;
// ObjAT_PINVHDR.PINV_HDR_CreditNote_AsOn_Amt=ObjAT_PINVHDR.PINV_HDR_CreditNote_AsOn_Amt;
// ObjAT_PINVHDR.PINV_HDR_DebitNote_AsOn_Amt=ObjAT_PINVHDR.PINV_HDR_DebitNote_AsOn_Amt;
// ObjAT_PINVHDR.PINV_HDR_TDS_Rate=ObjAT_PINVHDR.PINV_HDR_TDS_Rate;
// ObjAT_PINVHDR.PINV_HDR_TDS_Amt=ObjAT_PINVHDR.PINV_HDR_TDS_Amt;
// ObjAT_PINVHDR.PINV_HDR_Paid_AsOn_Amt=ObjAT_PINVHDR.PINV_HDR_Paid_AsOn_Amt;
// ObjAT_PINVHDR.PINV_HDR_Outstanding_AsOn_Amt=ObjAT_PINVHDR.PINV_HDR_Outstanding_AsOn_Amt;



// PINVHDR_ID.Text = "";
// Fk_PIHDR_ID.Text = "";
// Fk_Company_ID.Text = "";
// Fk_Branch_ID.Text = "";
// Fk_Year_ID.Text = "";
// Fk_Currency_ID.Text = "";
// Rec_Created_In.Text = "";
// Rec_CreatedBy_ID.Text = "";
// Rec_CreatedFor_ID.Text = "";
// PINV_CreationType.Text = "";
// PINV_Type.Text = "";
// PINV_Category.Text = "";
// PINV_Taxtype.Text = "";
// PINV_No.Text = "";
// PINV_DT.Text = "";
// Fk_VendorID.Text = "";
// PINV_CreditDays.Text = "";
// PINV_DueDT.Text = "";
// PINV_State_ID.Text = "";
// PINV_PONo.Text = "";
// PINV_PO_DT.Text = "";
// PINV_BillTo_CompanyName.Text = "";
// PINV_BillTo_ContactPersone.Text = "";
// PINV_BillTo_CP_MobileNo.Text = "";
// PINV_BillTo_Add1.Text = "";
// PINV_BillTo_Add2.Text = "";
// PINV_BillTo_Add3.Text = "";
// PINV_BillTo_Pincode.Text = "";
// PINV_BillTo_Area.Text = "";
// PINV_BillTo_City.Text = "";
// PINV_BillTo_State_ID.Text = "";
// PINV_BillTo_Country.Text = "";
// PINV_BillTo_GSTNo.Text = "";
// PINV_BillTo_PANNO.Text = "";
// PINV_ShippTo_CompanyName.Text = "";
// PINV_ShippTo_ContactPersone.Text = "";
// PINV_ShippTo_CP_MobileNo.Text = "";
// PINV_ShippTo_Add1.Text = "";
// PINV_ShippTo_Add2.Text = "";
// PINV_ShippTo_Add3.Text = "";
// PINV_ShippTo_Pincode.Text = "";
// PINV_ShippTo_Area.Text = "";
// PINV_ShippTo_City.Text = "";
// PINV_ShippTo_State_ID.Text = "";
// PINV_ShippTo_Country.Text = "";
// PINV_ShippTo_GSTNo.Text = "";
// PINV_ShippTo_PANNO.Text = "";
// PINV_ShippedFrom_CompanyName.Text = "";
// PINV_ShippedFrom_ContactPersone.Text = "";
// PINV_ShippedFrom_CP_MobileNo.Text = "";
// PINV_ShippedFrom_Add1.Text = "";
// PINV_ShippedFrom_Add2.Text = "";
// PINV_ShippedFrom_Add3.Text = "";
// PINV_ShippedFrom_Pincode.Text = "";
// PINV_ShippedFrom_Area.Text = "";
// PINV_ShippedFrom_City.Text = "";
// PINV_ShippedFrom_State_ID.Text = "";
// PINV_ShippedFrom_Country.Text = "";
// PINV_ShippedFrom_GSTNo.Text = "";
// PINV_ShippedFrom_PANNO.Text = "";
// PINV_PaymentTerms.Text = "";
// PINV_DelvieryPeriod.Text = "";
// PINV_DeliveryCharges.Text = "";
// PINV_ExciseDuty.Text = "";
// PINV_CompletionPeriod.Text = "";
// PINV_ModeOfDispatch.Text = "";
// PINV_TranspoterName.Text = "";
// PINV_VehicleNumber.Text = "";
// PINV_PlaceOfDelivery.Text = "";
// PINV_FreigthCharge_Txt.Text = "";
// PINV_Insurance_Txt.Text = "";
// PINV_Remark.Text = "";
// PINV_L1AuthorizeID.Text = "";
// PINV_L1AuthorizeBy.Text = "";
// PINV_L1AuthorizeDT.Text = "";
// PINV_L2AuthorizeID.Text = "";
// PINV_L2AuthorizeBy.Text = "";
// PINV_L2AuthorizeDT.Text = "";
// PINV_AuthRemark.Text = "";
// PINV_DTL_CNT.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";
// PINV_HDR_BasicAmt.Text = "";
// PINV_HDR_DiscountRate.Text = "";
// PINV_HDR_DiscountAmt.Text = "";
// PINV_HDR_Net_Amt.Text = "";
// PINV_HDR_Freight_Charges.Text = "";
// PINV_HDR_Loading_N_Packing_Charges.Text = "";
// PINV_HDR_Insurance_Charges.Text = "";
// PINV_HDR_Other_Charges_Txt.Text = "";
// PINV_HDR_Other_Charges_Amt.Text = "";
// PINV_HDR_Taxable_Amt.Text = "";
// PINV_HDR_CGST_Amt.Text = "";
// PINV_HDR_CGST_Taxable_Amt.Text = "";
// PINV_HDR_SGST_Amt.Text = "";
// PINV_HDR_SGST_Taxable_Amt.Text = "";
// PINV_HDR_IGST_Amt.Text = "";
// PINV_HDR_IGST_Taxable_Amt.Text = "";
// PINV_HDR_CESS_Amt.Text = "";
// PINV_HDR_CESS_Taxable_Amt.Text = "";
// PINV_HDR_OtherTax_ID.Text = "";
// PINV_HDR_OtherTax_Rate.Text = "";
// PINV_HDR_OtherTax_Amt.Text = "";
// PINV_HDR_Other_Taxable_Amt.Text = "";
// PINV_HDR_Total_Tax_Amt.Text = "";
// PINV_HDR_ItemGross_Total_Amt.Text = "";
// PINV_HDR_Gross_Amt.Text = "";
// PINV_HDR_Round_Off_Amt.Text = "";
// PINV_HDR_Total_Gross_Amt.Text = "";
// PINV_HDR_Gross_AmtInWords.Text = "";
// PINV_HDR_CreditNote_AsOn_Amt.Text = "";
// PINV_HDR_DebitNote_AsOn_Amt.Text = "";
// PINV_HDR_TDS_Rate.Text = "";
// PINV_HDR_TDS_Amt.Text = "";
// PINV_HDR_Paid_AsOn_Amt.Text = "";
// PINV_HDR_Outstanding_AsOn_Amt.Text = "";



// ObjAT_PINVHDR.PINVHDR_ID=PINVHDR_ID.Text ;
// ObjAT_PINVHDR.Fk_PIHDR_ID=Fk_PIHDR_ID.Text ;
// ObjAT_PINVHDR.Fk_Company_ID=Fk_Company_ID.Text ;
// ObjAT_PINVHDR.Fk_Branch_ID=Fk_Branch_ID.Text ;
// ObjAT_PINVHDR.Fk_Year_ID=Fk_Year_ID.Text ;
// ObjAT_PINVHDR.Fk_Currency_ID=Fk_Currency_ID.Text ;
// ObjAT_PINVHDR.Rec_Created_In=Rec_Created_In.Text ;
// ObjAT_PINVHDR.Rec_CreatedBy_ID=Rec_CreatedBy_ID.Text ;
// ObjAT_PINVHDR.Rec_CreatedFor_ID=Rec_CreatedFor_ID.Text ;
// ObjAT_PINVHDR.PINV_CreationType=PINV_CreationType.Text ;
// ObjAT_PINVHDR.PINV_Type=PINV_Type.Text ;
// ObjAT_PINVHDR.PINV_Category=PINV_Category.Text ;
// ObjAT_PINVHDR.PINV_Taxtype=PINV_Taxtype.Text ;
// ObjAT_PINVHDR.PINV_No=PINV_No.Text ;
// ObjAT_PINVHDR.PINV_DT=PINV_DT.Text ;
// ObjAT_PINVHDR.Fk_VendorID=Fk_VendorID.Text ;
// ObjAT_PINVHDR.PINV_CreditDays=PINV_CreditDays.Text ;
// ObjAT_PINVHDR.PINV_DueDT=PINV_DueDT.Text ;
// ObjAT_PINVHDR.PINV_State_ID=PINV_State_ID.Text ;
// ObjAT_PINVHDR.PINV_PONo=PINV_PONo.Text ;
// ObjAT_PINVHDR.PINV_PO_DT=PINV_PO_DT.Text ;
// ObjAT_PINVHDR.PINV_BillTo_CompanyName=PINV_BillTo_CompanyName.Text ;
// ObjAT_PINVHDR.PINV_BillTo_ContactPersone=PINV_BillTo_ContactPersone.Text ;
// ObjAT_PINVHDR.PINV_BillTo_CP_MobileNo=PINV_BillTo_CP_MobileNo.Text ;
// ObjAT_PINVHDR.PINV_BillTo_Add1=PINV_BillTo_Add1.Text ;
// ObjAT_PINVHDR.PINV_BillTo_Add2=PINV_BillTo_Add2.Text ;
// ObjAT_PINVHDR.PINV_BillTo_Add3=PINV_BillTo_Add3.Text ;
// ObjAT_PINVHDR.PINV_BillTo_Pincode=PINV_BillTo_Pincode.Text ;
// ObjAT_PINVHDR.PINV_BillTo_Area=PINV_BillTo_Area.Text ;
// ObjAT_PINVHDR.PINV_BillTo_City=PINV_BillTo_City.Text ;
// ObjAT_PINVHDR.PINV_BillTo_State_ID=PINV_BillTo_State_ID.Text ;
// ObjAT_PINVHDR.PINV_BillTo_Country=PINV_BillTo_Country.Text ;
// ObjAT_PINVHDR.PINV_BillTo_GSTNo=PINV_BillTo_GSTNo.Text ;
// ObjAT_PINVHDR.PINV_BillTo_PANNO=PINV_BillTo_PANNO.Text ;
// ObjAT_PINVHDR.PINV_ShippTo_CompanyName=PINV_ShippTo_CompanyName.Text ;
// ObjAT_PINVHDR.PINV_ShippTo_ContactPersone=PINV_ShippTo_ContactPersone.Text ;
// ObjAT_PINVHDR.PINV_ShippTo_CP_MobileNo=PINV_ShippTo_CP_MobileNo.Text ;
// ObjAT_PINVHDR.PINV_ShippTo_Add1=PINV_ShippTo_Add1.Text ;
// ObjAT_PINVHDR.PINV_ShippTo_Add2=PINV_ShippTo_Add2.Text ;
// ObjAT_PINVHDR.PINV_ShippTo_Add3=PINV_ShippTo_Add3.Text ;
// ObjAT_PINVHDR.PINV_ShippTo_Pincode=PINV_ShippTo_Pincode.Text ;
// ObjAT_PINVHDR.PINV_ShippTo_Area=PINV_ShippTo_Area.Text ;
// ObjAT_PINVHDR.PINV_ShippTo_City=PINV_ShippTo_City.Text ;
// ObjAT_PINVHDR.PINV_ShippTo_State_ID=PINV_ShippTo_State_ID.Text ;
// ObjAT_PINVHDR.PINV_ShippTo_Country=PINV_ShippTo_Country.Text ;
// ObjAT_PINVHDR.PINV_ShippTo_GSTNo=PINV_ShippTo_GSTNo.Text ;
// ObjAT_PINVHDR.PINV_ShippTo_PANNO=PINV_ShippTo_PANNO.Text ;
// ObjAT_PINVHDR.PINV_ShippedFrom_CompanyName=PINV_ShippedFrom_CompanyName.Text ;
// ObjAT_PINVHDR.PINV_ShippedFrom_ContactPersone=PINV_ShippedFrom_ContactPersone.Text ;
// ObjAT_PINVHDR.PINV_ShippedFrom_CP_MobileNo=PINV_ShippedFrom_CP_MobileNo.Text ;
// ObjAT_PINVHDR.PINV_ShippedFrom_Add1=PINV_ShippedFrom_Add1.Text ;
// ObjAT_PINVHDR.PINV_ShippedFrom_Add2=PINV_ShippedFrom_Add2.Text ;
// ObjAT_PINVHDR.PINV_ShippedFrom_Add3=PINV_ShippedFrom_Add3.Text ;
// ObjAT_PINVHDR.PINV_ShippedFrom_Pincode=PINV_ShippedFrom_Pincode.Text ;
// ObjAT_PINVHDR.PINV_ShippedFrom_Area=PINV_ShippedFrom_Area.Text ;
// ObjAT_PINVHDR.PINV_ShippedFrom_City=PINV_ShippedFrom_City.Text ;
// ObjAT_PINVHDR.PINV_ShippedFrom_State_ID=PINV_ShippedFrom_State_ID.Text ;
// ObjAT_PINVHDR.PINV_ShippedFrom_Country=PINV_ShippedFrom_Country.Text ;
// ObjAT_PINVHDR.PINV_ShippedFrom_GSTNo=PINV_ShippedFrom_GSTNo.Text ;
// ObjAT_PINVHDR.PINV_ShippedFrom_PANNO=PINV_ShippedFrom_PANNO.Text ;
// ObjAT_PINVHDR.PINV_PaymentTerms=PINV_PaymentTerms.Text ;
// ObjAT_PINVHDR.PINV_DelvieryPeriod=PINV_DelvieryPeriod.Text ;
// ObjAT_PINVHDR.PINV_DeliveryCharges=PINV_DeliveryCharges.Text ;
// ObjAT_PINVHDR.PINV_ExciseDuty=PINV_ExciseDuty.Text ;
// ObjAT_PINVHDR.PINV_CompletionPeriod=PINV_CompletionPeriod.Text ;
// ObjAT_PINVHDR.PINV_ModeOfDispatch=PINV_ModeOfDispatch.Text ;
// ObjAT_PINVHDR.PINV_TranspoterName=PINV_TranspoterName.Text ;
// ObjAT_PINVHDR.PINV_VehicleNumber=PINV_VehicleNumber.Text ;
// ObjAT_PINVHDR.PINV_PlaceOfDelivery=PINV_PlaceOfDelivery.Text ;
// ObjAT_PINVHDR.PINV_FreigthCharge_Txt=PINV_FreigthCharge_Txt.Text ;
// ObjAT_PINVHDR.PINV_Insurance_Txt=PINV_Insurance_Txt.Text ;
// ObjAT_PINVHDR.PINV_Remark=PINV_Remark.Text ;
// ObjAT_PINVHDR.PINV_L1AuthorizeID=PINV_L1AuthorizeID.Text ;
// ObjAT_PINVHDR.PINV_L1AuthorizeBy=PINV_L1AuthorizeBy.Text ;
// ObjAT_PINVHDR.PINV_L1AuthorizeDT=PINV_L1AuthorizeDT.Text ;
// ObjAT_PINVHDR.PINV_L2AuthorizeID=PINV_L2AuthorizeID.Text ;
// ObjAT_PINVHDR.PINV_L2AuthorizeBy=PINV_L2AuthorizeBy.Text ;
// ObjAT_PINVHDR.PINV_L2AuthorizeDT=PINV_L2AuthorizeDT.Text ;
// ObjAT_PINVHDR.PINV_AuthRemark=PINV_AuthRemark.Text ;
// ObjAT_PINVHDR.PINV_DTL_CNT=PINV_DTL_CNT.Text ;
// ObjAT_PINVHDR.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_PINVHDR.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_PINVHDR.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_PINVHDR.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_PINVHDR.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_PINVHDR.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_PINVHDR.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;
// ObjAT_PINVHDR.PINV_HDR_BasicAmt=PINV_HDR_BasicAmt.Text ;
// ObjAT_PINVHDR.PINV_HDR_DiscountRate=PINV_HDR_DiscountRate.Text ;
// ObjAT_PINVHDR.PINV_HDR_DiscountAmt=PINV_HDR_DiscountAmt.Text ;
// ObjAT_PINVHDR.PINV_HDR_Net_Amt=PINV_HDR_Net_Amt.Text ;
// ObjAT_PINVHDR.PINV_HDR_Freight_Charges=PINV_HDR_Freight_Charges.Text ;
// ObjAT_PINVHDR.PINV_HDR_Loading_N_Packing_Charges=PINV_HDR_Loading_N_Packing_Charges.Text ;
// ObjAT_PINVHDR.PINV_HDR_Insurance_Charges=PINV_HDR_Insurance_Charges.Text ;
// ObjAT_PINVHDR.PINV_HDR_Other_Charges_Txt=PINV_HDR_Other_Charges_Txt.Text ;
// ObjAT_PINVHDR.PINV_HDR_Other_Charges_Amt=PINV_HDR_Other_Charges_Amt.Text ;
// ObjAT_PINVHDR.PINV_HDR_Taxable_Amt=PINV_HDR_Taxable_Amt.Text ;
// ObjAT_PINVHDR.PINV_HDR_CGST_Amt=PINV_HDR_CGST_Amt.Text ;
// ObjAT_PINVHDR.PINV_HDR_CGST_Taxable_Amt=PINV_HDR_CGST_Taxable_Amt.Text ;
// ObjAT_PINVHDR.PINV_HDR_SGST_Amt=PINV_HDR_SGST_Amt.Text ;
// ObjAT_PINVHDR.PINV_HDR_SGST_Taxable_Amt=PINV_HDR_SGST_Taxable_Amt.Text ;
// ObjAT_PINVHDR.PINV_HDR_IGST_Amt=PINV_HDR_IGST_Amt.Text ;
// ObjAT_PINVHDR.PINV_HDR_IGST_Taxable_Amt=PINV_HDR_IGST_Taxable_Amt.Text ;
// ObjAT_PINVHDR.PINV_HDR_CESS_Amt=PINV_HDR_CESS_Amt.Text ;
// ObjAT_PINVHDR.PINV_HDR_CESS_Taxable_Amt=PINV_HDR_CESS_Taxable_Amt.Text ;
// ObjAT_PINVHDR.PINV_HDR_OtherTax_ID=PINV_HDR_OtherTax_ID.Text ;
// ObjAT_PINVHDR.PINV_HDR_OtherTax_Rate=PINV_HDR_OtherTax_Rate.Text ;
// ObjAT_PINVHDR.PINV_HDR_OtherTax_Amt=PINV_HDR_OtherTax_Amt.Text ;
// ObjAT_PINVHDR.PINV_HDR_Other_Taxable_Amt=PINV_HDR_Other_Taxable_Amt.Text ;
// ObjAT_PINVHDR.PINV_HDR_Total_Tax_Amt=PINV_HDR_Total_Tax_Amt.Text ;
// ObjAT_PINVHDR.PINV_HDR_ItemGross_Total_Amt=PINV_HDR_ItemGross_Total_Amt.Text ;
// ObjAT_PINVHDR.PINV_HDR_Gross_Amt=PINV_HDR_Gross_Amt.Text ;
// ObjAT_PINVHDR.PINV_HDR_Round_Off_Amt=PINV_HDR_Round_Off_Amt.Text ;
// ObjAT_PINVHDR.PINV_HDR_Total_Gross_Amt=PINV_HDR_Total_Gross_Amt.Text ;
// ObjAT_PINVHDR.PINV_HDR_Gross_AmtInWords=PINV_HDR_Gross_AmtInWords.Text ;
// ObjAT_PINVHDR.PINV_HDR_CreditNote_AsOn_Amt=PINV_HDR_CreditNote_AsOn_Amt.Text ;
// ObjAT_PINVHDR.PINV_HDR_DebitNote_AsOn_Amt=PINV_HDR_DebitNote_AsOn_Amt.Text ;
// ObjAT_PINVHDR.PINV_HDR_TDS_Rate=PINV_HDR_TDS_Rate.Text ;
// ObjAT_PINVHDR.PINV_HDR_TDS_Amt=PINV_HDR_TDS_Amt.Text ;
// ObjAT_PINVHDR.PINV_HDR_Paid_AsOn_Amt=PINV_HDR_Paid_AsOn_Amt.Text ;
// ObjAT_PINVHDR.PINV_HDR_Outstanding_AsOn_Amt=PINV_HDR_Outstanding_AsOn_Amt.Text ;



// PINVHDR_ID.Text =  dt.Rows[0]["PINVHDR_ID"].ToString();
// Fk_PIHDR_ID.Text =  dt.Rows[0]["Fk_PIHDR_ID"].ToString();
// Fk_Company_ID.Text =  dt.Rows[0]["Fk_Company_ID"].ToString();
// Fk_Branch_ID.Text =  dt.Rows[0]["Fk_Branch_ID"].ToString();
// Fk_Year_ID.Text =  dt.Rows[0]["Fk_Year_ID"].ToString();
// Fk_Currency_ID.Text =  dt.Rows[0]["Fk_Currency_ID"].ToString();
// Rec_Created_In.Text =  dt.Rows[0]["Rec_Created_In"].ToString();
// Rec_CreatedBy_ID.Text =  dt.Rows[0]["Rec_CreatedBy_ID"].ToString();
// Rec_CreatedFor_ID.Text =  dt.Rows[0]["Rec_CreatedFor_ID"].ToString();
// PINV_CreationType.Text =  dt.Rows[0]["PINV_CreationType"].ToString();
// PINV_Type.Text =  dt.Rows[0]["PINV_Type"].ToString();
// PINV_Category.Text =  dt.Rows[0]["PINV_Category"].ToString();
// PINV_Taxtype.Text =  dt.Rows[0]["PINV_Taxtype"].ToString();
// PINV_No.Text =  dt.Rows[0]["PINV_No"].ToString();
// PINV_DT.Text =  dt.Rows[0]["PINV_DT"].ToString();
// Fk_VendorID.Text =  dt.Rows[0]["Fk_VendorID"].ToString();
// PINV_CreditDays.Text =  dt.Rows[0]["PINV_CreditDays"].ToString();
// PINV_DueDT.Text =  dt.Rows[0]["PINV_DueDT"].ToString();
// PINV_State_ID.Text =  dt.Rows[0]["PINV_State_ID"].ToString();
// PINV_PONo.Text =  dt.Rows[0]["PINV_PONo"].ToString();
// PINV_PO_DT.Text =  dt.Rows[0]["PINV_PO_DT"].ToString();
// PINV_BillTo_CompanyName.Text =  dt.Rows[0]["PINV_BillTo_CompanyName"].ToString();
// PINV_BillTo_ContactPersone.Text =  dt.Rows[0]["PINV_BillTo_ContactPersone"].ToString();
// PINV_BillTo_CP_MobileNo.Text =  dt.Rows[0]["PINV_BillTo_CP_MobileNo"].ToString();
// PINV_BillTo_Add1.Text =  dt.Rows[0]["PINV_BillTo_Add1"].ToString();
// PINV_BillTo_Add2.Text =  dt.Rows[0]["PINV_BillTo_Add2"].ToString();
// PINV_BillTo_Add3.Text =  dt.Rows[0]["PINV_BillTo_Add3"].ToString();
// PINV_BillTo_Pincode.Text =  dt.Rows[0]["PINV_BillTo_Pincode"].ToString();
// PINV_BillTo_Area.Text =  dt.Rows[0]["PINV_BillTo_Area"].ToString();
// PINV_BillTo_City.Text =  dt.Rows[0]["PINV_BillTo_City"].ToString();
// PINV_BillTo_State_ID.Text =  dt.Rows[0]["PINV_BillTo_State_ID"].ToString();
// PINV_BillTo_Country.Text =  dt.Rows[0]["PINV_BillTo_Country"].ToString();
// PINV_BillTo_GSTNo.Text =  dt.Rows[0]["PINV_BillTo_GSTNo"].ToString();
// PINV_BillTo_PANNO.Text =  dt.Rows[0]["PINV_BillTo_PANNO"].ToString();
// PINV_ShippTo_CompanyName.Text =  dt.Rows[0]["PINV_ShippTo_CompanyName"].ToString();
// PINV_ShippTo_ContactPersone.Text =  dt.Rows[0]["PINV_ShippTo_ContactPersone"].ToString();
// PINV_ShippTo_CP_MobileNo.Text =  dt.Rows[0]["PINV_ShippTo_CP_MobileNo"].ToString();
// PINV_ShippTo_Add1.Text =  dt.Rows[0]["PINV_ShippTo_Add1"].ToString();
// PINV_ShippTo_Add2.Text =  dt.Rows[0]["PINV_ShippTo_Add2"].ToString();
// PINV_ShippTo_Add3.Text =  dt.Rows[0]["PINV_ShippTo_Add3"].ToString();
// PINV_ShippTo_Pincode.Text =  dt.Rows[0]["PINV_ShippTo_Pincode"].ToString();
// PINV_ShippTo_Area.Text =  dt.Rows[0]["PINV_ShippTo_Area"].ToString();
// PINV_ShippTo_City.Text =  dt.Rows[0]["PINV_ShippTo_City"].ToString();
// PINV_ShippTo_State_ID.Text =  dt.Rows[0]["PINV_ShippTo_State_ID"].ToString();
// PINV_ShippTo_Country.Text =  dt.Rows[0]["PINV_ShippTo_Country"].ToString();
// PINV_ShippTo_GSTNo.Text =  dt.Rows[0]["PINV_ShippTo_GSTNo"].ToString();
// PINV_ShippTo_PANNO.Text =  dt.Rows[0]["PINV_ShippTo_PANNO"].ToString();
// PINV_ShippedFrom_CompanyName.Text =  dt.Rows[0]["PINV_ShippedFrom_CompanyName"].ToString();
// PINV_ShippedFrom_ContactPersone.Text =  dt.Rows[0]["PINV_ShippedFrom_ContactPersone"].ToString();
// PINV_ShippedFrom_CP_MobileNo.Text =  dt.Rows[0]["PINV_ShippedFrom_CP_MobileNo"].ToString();
// PINV_ShippedFrom_Add1.Text =  dt.Rows[0]["PINV_ShippedFrom_Add1"].ToString();
// PINV_ShippedFrom_Add2.Text =  dt.Rows[0]["PINV_ShippedFrom_Add2"].ToString();
// PINV_ShippedFrom_Add3.Text =  dt.Rows[0]["PINV_ShippedFrom_Add3"].ToString();
// PINV_ShippedFrom_Pincode.Text =  dt.Rows[0]["PINV_ShippedFrom_Pincode"].ToString();
// PINV_ShippedFrom_Area.Text =  dt.Rows[0]["PINV_ShippedFrom_Area"].ToString();
// PINV_ShippedFrom_City.Text =  dt.Rows[0]["PINV_ShippedFrom_City"].ToString();
// PINV_ShippedFrom_State_ID.Text =  dt.Rows[0]["PINV_ShippedFrom_State_ID"].ToString();
// PINV_ShippedFrom_Country.Text =  dt.Rows[0]["PINV_ShippedFrom_Country"].ToString();
// PINV_ShippedFrom_GSTNo.Text =  dt.Rows[0]["PINV_ShippedFrom_GSTNo"].ToString();
// PINV_ShippedFrom_PANNO.Text =  dt.Rows[0]["PINV_ShippedFrom_PANNO"].ToString();
// PINV_PaymentTerms.Text =  dt.Rows[0]["PINV_PaymentTerms"].ToString();
// PINV_DelvieryPeriod.Text =  dt.Rows[0]["PINV_DelvieryPeriod"].ToString();
// PINV_DeliveryCharges.Text =  dt.Rows[0]["PINV_DeliveryCharges"].ToString();
// PINV_ExciseDuty.Text =  dt.Rows[0]["PINV_ExciseDuty"].ToString();
// PINV_CompletionPeriod.Text =  dt.Rows[0]["PINV_CompletionPeriod"].ToString();
// PINV_ModeOfDispatch.Text =  dt.Rows[0]["PINV_ModeOfDispatch"].ToString();
// PINV_TranspoterName.Text =  dt.Rows[0]["PINV_TranspoterName"].ToString();
// PINV_VehicleNumber.Text =  dt.Rows[0]["PINV_VehicleNumber"].ToString();
// PINV_PlaceOfDelivery.Text =  dt.Rows[0]["PINV_PlaceOfDelivery"].ToString();
// PINV_FreigthCharge_Txt.Text =  dt.Rows[0]["PINV_FreigthCharge_Txt"].ToString();
// PINV_Insurance_Txt.Text =  dt.Rows[0]["PINV_Insurance_Txt"].ToString();
// PINV_Remark.Text =  dt.Rows[0]["PINV_Remark"].ToString();
// PINV_L1AuthorizeID.Text =  dt.Rows[0]["PINV_L1AuthorizeID"].ToString();
// PINV_L1AuthorizeBy.Text =  dt.Rows[0]["PINV_L1AuthorizeBy"].ToString();
// PINV_L1AuthorizeDT.Text =  dt.Rows[0]["PINV_L1AuthorizeDT"].ToString();
// PINV_L2AuthorizeID.Text =  dt.Rows[0]["PINV_L2AuthorizeID"].ToString();
// PINV_L2AuthorizeBy.Text =  dt.Rows[0]["PINV_L2AuthorizeBy"].ToString();
// PINV_L2AuthorizeDT.Text =  dt.Rows[0]["PINV_L2AuthorizeDT"].ToString();
// PINV_AuthRemark.Text =  dt.Rows[0]["PINV_AuthRemark"].ToString();
// PINV_DTL_CNT.Text =  dt.Rows[0]["PINV_DTL_CNT"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
// PINV_HDR_BasicAmt.Text =  dt.Rows[0]["PINV_HDR_BasicAmt"].ToString();
// PINV_HDR_DiscountRate.Text =  dt.Rows[0]["PINV_HDR_DiscountRate"].ToString();
// PINV_HDR_DiscountAmt.Text =  dt.Rows[0]["PINV_HDR_DiscountAmt"].ToString();
// PINV_HDR_Net_Amt.Text =  dt.Rows[0]["PINV_HDR_Net_Amt"].ToString();
// PINV_HDR_Freight_Charges.Text =  dt.Rows[0]["PINV_HDR_Freight_Charges"].ToString();
// PINV_HDR_Loading_N_Packing_Charges.Text =  dt.Rows[0]["PINV_HDR_Loading_N_Packing_Charges"].ToString();
// PINV_HDR_Insurance_Charges.Text =  dt.Rows[0]["PINV_HDR_Insurance_Charges"].ToString();
// PINV_HDR_Other_Charges_Txt.Text =  dt.Rows[0]["PINV_HDR_Other_Charges_Txt"].ToString();
// PINV_HDR_Other_Charges_Amt.Text =  dt.Rows[0]["PINV_HDR_Other_Charges_Amt"].ToString();
// PINV_HDR_Taxable_Amt.Text =  dt.Rows[0]["PINV_HDR_Taxable_Amt"].ToString();
// PINV_HDR_CGST_Amt.Text =  dt.Rows[0]["PINV_HDR_CGST_Amt"].ToString();
// PINV_HDR_CGST_Taxable_Amt.Text =  dt.Rows[0]["PINV_HDR_CGST_Taxable_Amt"].ToString();
// PINV_HDR_SGST_Amt.Text =  dt.Rows[0]["PINV_HDR_SGST_Amt"].ToString();
// PINV_HDR_SGST_Taxable_Amt.Text =  dt.Rows[0]["PINV_HDR_SGST_Taxable_Amt"].ToString();
// PINV_HDR_IGST_Amt.Text =  dt.Rows[0]["PINV_HDR_IGST_Amt"].ToString();
// PINV_HDR_IGST_Taxable_Amt.Text =  dt.Rows[0]["PINV_HDR_IGST_Taxable_Amt"].ToString();
// PINV_HDR_CESS_Amt.Text =  dt.Rows[0]["PINV_HDR_CESS_Amt"].ToString();
// PINV_HDR_CESS_Taxable_Amt.Text =  dt.Rows[0]["PINV_HDR_CESS_Taxable_Amt"].ToString();
// PINV_HDR_OtherTax_ID.Text =  dt.Rows[0]["PINV_HDR_OtherTax_ID"].ToString();
// PINV_HDR_OtherTax_Rate.Text =  dt.Rows[0]["PINV_HDR_OtherTax_Rate"].ToString();
// PINV_HDR_OtherTax_Amt.Text =  dt.Rows[0]["PINV_HDR_OtherTax_Amt"].ToString();
// PINV_HDR_Other_Taxable_Amt.Text =  dt.Rows[0]["PINV_HDR_Other_Taxable_Amt"].ToString();
// PINV_HDR_Total_Tax_Amt.Text =  dt.Rows[0]["PINV_HDR_Total_Tax_Amt"].ToString();
// PINV_HDR_ItemGross_Total_Amt.Text =  dt.Rows[0]["PINV_HDR_ItemGross_Total_Amt"].ToString();
// PINV_HDR_Gross_Amt.Text =  dt.Rows[0]["PINV_HDR_Gross_Amt"].ToString();
// PINV_HDR_Round_Off_Amt.Text =  dt.Rows[0]["PINV_HDR_Round_Off_Amt"].ToString();
// PINV_HDR_Total_Gross_Amt.Text =  dt.Rows[0]["PINV_HDR_Total_Gross_Amt"].ToString();
// PINV_HDR_Gross_AmtInWords.Text =  dt.Rows[0]["PINV_HDR_Gross_AmtInWords"].ToString();
// PINV_HDR_CreditNote_AsOn_Amt.Text =  dt.Rows[0]["PINV_HDR_CreditNote_AsOn_Amt"].ToString();
// PINV_HDR_DebitNote_AsOn_Amt.Text =  dt.Rows[0]["PINV_HDR_DebitNote_AsOn_Amt"].ToString();
// PINV_HDR_TDS_Rate.Text =  dt.Rows[0]["PINV_HDR_TDS_Rate"].ToString();
// PINV_HDR_TDS_Amt.Text =  dt.Rows[0]["PINV_HDR_TDS_Amt"].ToString();
// PINV_HDR_Paid_AsOn_Amt.Text =  dt.Rows[0]["PINV_HDR_Paid_AsOn_Amt"].ToString();
// PINV_HDR_Outstanding_AsOn_Amt.Text =  dt.Rows[0]["PINV_HDR_Outstanding_AsOn_Amt"].ToString();
