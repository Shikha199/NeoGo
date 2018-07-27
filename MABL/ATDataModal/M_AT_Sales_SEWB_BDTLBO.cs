using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal 
{
public class M_AT_Sales_SEWB_BDTLBO
{
    MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
#region Constructor 
public M_AT_Sales_SEWB_BDTLBO() { }
#endregion 
#region Standard Property
private string _PrimaryKeyName = "SEWB_DTL_ID";
private string _TableName = "M_AT_Sales_SEWB_BDTL";
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

private Int64 _SEWB_DTL_ID;
private Int64 _Fk_SEWB_HDR_ID;
private Int64 _Fk_MItem_ID;
private String _SEWB_HSNCode;
private Decimal _SEWB_QTY;
private Decimal _SEWB_BasicRate;
private Decimal _SEWB_NetRate;
private Decimal _SEWB_BasicAmt;
private Decimal _SEWB_DiscountRate;
private Decimal _SEWB_DiscountAmt;
private Decimal _SEWB_NetTaxableAmt;
private Int16 _SEWB_GST_TaxRate_ID;
private Decimal _SEWB_GST_TaxRate;
private Int16 _SEWB_CGST_ID;
private Decimal _SEWB_CGST_Rate;
private Decimal _SEWB_CGST_Amt;
private Decimal _SEWB_CGST_TaxableAmt;
private Int16 _SEWB_SGST_ID;
private Decimal _SEWB_SGST_Rate;
private Decimal _SEWB_SGST_Amt;
private Decimal _SEWB_SGST_TaxableAmt;
private Int16 _SEWB_IGST_ID;
private Decimal _SEWB_IGST_Rate;
private Decimal _SEWB_IGST_Amt;
private Decimal _SEWB_IGST_TaxableAmt;
private Int16 _SEWB_CESS_ID;
private Decimal _SEWB_CESS_Rate;
private Decimal _SEWB_CESS_Amt;
private Decimal _SEWB_CESS_TaxableAmt;
private Int16 _SEWB_OtherTax_ID;
private Decimal _SEWB_OtherTax_Rate;
private Decimal _SEWB_OtherTax_Amt;
private Decimal _SEWB_OtherTax_TaxableAmt;
private Decimal _SEWB_TotalTax;
private Decimal _SEWB_GrossRateWithTax;
private String _MDBSC_RowStatus;
private String _SEWB_ItemRemark_DTL;
private Int16 _MDBSC_RowCreatedByUser_ID;
private String _MDBSC_RowCreatedByUserName;
private String _MDBSC_RowCreatedOn_DT;
private Int16 _MDBSC_RowLupdnByUser_ID;
private String _MDBSC_RowLupdnUserName;
private String _MDBSC_RowLupdnOn_DT;

public Int64 SEWB_DTL_ID
{
get
  {
   return this._SEWB_DTL_ID;  }
set
   {
     this._SEWB_DTL_ID = value;
     _UpdateFieldName.Add("SEWB_DTL_ID");
     }
}
public Int64 Fk_SEWB_HDR_ID
{
get
  {
   return this._Fk_SEWB_HDR_ID;  }
set
   {
     this._Fk_SEWB_HDR_ID = value;
     _UpdateFieldName.Add("Fk_SEWB_HDR_ID");
     }
}
public Int64 Fk_MItem_ID
{
get
  {
   return this._Fk_MItem_ID;  }
set
   {
     this._Fk_MItem_ID = value;
     _UpdateFieldName.Add("Fk_MItem_ID");
     }
}
public String SEWB_HSNCode
{
get
  {
   return this._SEWB_HSNCode;  }
set
   {
     this._SEWB_HSNCode = value;
     _UpdateFieldName.Add("SEWB_HSNCode");
     }
}
public Decimal SEWB_QTY
{
get
  {
   return this._SEWB_QTY;  }
set
   {
     this._SEWB_QTY = value;
     _UpdateFieldName.Add("SEWB_QTY");
     }
}
public Decimal SEWB_BasicRate
{
get
  {
   return this._SEWB_BasicRate;  }
set
   {
     this._SEWB_BasicRate = value;
     _UpdateFieldName.Add("SEWB_BasicRate");
     }
}
public Decimal SEWB_NetRate
{
get
  {
   return this._SEWB_NetRate;  }
set
   {
     this._SEWB_NetRate = value;
     _UpdateFieldName.Add("SEWB_NetRate");
     }
}
public Decimal SEWB_BasicAmt
{
get
  {
   return this._SEWB_BasicAmt;  }
set
   {
     this._SEWB_BasicAmt = value;
     _UpdateFieldName.Add("SEWB_BasicAmt");
     }
}
public Decimal SEWB_DiscountRate
{
get
  {
   return this._SEWB_DiscountRate;  }
set
   {
     this._SEWB_DiscountRate = value;
     _UpdateFieldName.Add("SEWB_DiscountRate");
     }
}
public Decimal SEWB_DiscountAmt
{
get
  {
   return this._SEWB_DiscountAmt;  }
set
   {
     this._SEWB_DiscountAmt = value;
     _UpdateFieldName.Add("SEWB_DiscountAmt");
     }
}
public Decimal SEWB_NetTaxableAmt
{
get
  {
   return this._SEWB_NetTaxableAmt;  }
set
   {
     this._SEWB_NetTaxableAmt = value;
     _UpdateFieldName.Add("SEWB_NetTaxableAmt");
     }
}
public Int16 SEWB_GST_TaxRate_ID
{
get
  {
   return this._SEWB_GST_TaxRate_ID;  }
set
   {
     this._SEWB_GST_TaxRate_ID = value;
     _UpdateFieldName.Add("SEWB_GST_TaxRate_ID");
     }
}
public Decimal SEWB_GST_TaxRate
{
get
  {
   return this._SEWB_GST_TaxRate;  }
set
   {
     this._SEWB_GST_TaxRate = value;
     _UpdateFieldName.Add("SEWB_GST_TaxRate");
     }
}
public Int16 SEWB_CGST_ID
{
get
  {
   return this._SEWB_CGST_ID;  }
set
   {
     this._SEWB_CGST_ID = value;
     _UpdateFieldName.Add("SEWB_CGST_ID");
     }
}
public Decimal SEWB_CGST_Rate
{
get
  {
   return this._SEWB_CGST_Rate;  }
set
   {
     this._SEWB_CGST_Rate = value;
     _UpdateFieldName.Add("SEWB_CGST_Rate");
     }
}
public Decimal SEWB_CGST_Amt
{
get
  {
   return this._SEWB_CGST_Amt;  }
set
   {
     this._SEWB_CGST_Amt = value;
     _UpdateFieldName.Add("SEWB_CGST_Amt");
     }
}
public Decimal SEWB_CGST_TaxableAmt
{
get
  {
   return this._SEWB_CGST_TaxableAmt;  }
set
   {
     this._SEWB_CGST_TaxableAmt = value;
     _UpdateFieldName.Add("SEWB_CGST_TaxableAmt");
     }
}
public Int16 SEWB_SGST_ID
{
get
  {
   return this._SEWB_SGST_ID;  }
set
   {
     this._SEWB_SGST_ID = value;
     _UpdateFieldName.Add("SEWB_SGST_ID");
     }
}
public Decimal SEWB_SGST_Rate
{
get
  {
   return this._SEWB_SGST_Rate;  }
set
   {
     this._SEWB_SGST_Rate = value;
     _UpdateFieldName.Add("SEWB_SGST_Rate");
     }
}
public Decimal SEWB_SGST_Amt
{
get
  {
   return this._SEWB_SGST_Amt;  }
set
   {
     this._SEWB_SGST_Amt = value;
     _UpdateFieldName.Add("SEWB_SGST_Amt");
     }
}
public Decimal SEWB_SGST_TaxableAmt
{
get
  {
   return this._SEWB_SGST_TaxableAmt;  }
set
   {
     this._SEWB_SGST_TaxableAmt = value;
     _UpdateFieldName.Add("SEWB_SGST_TaxableAmt");
     }
}
public Int16 SEWB_IGST_ID
{
get
  {
   return this._SEWB_IGST_ID;  }
set
   {
     this._SEWB_IGST_ID = value;
     _UpdateFieldName.Add("SEWB_IGST_ID");
     }
}
public Decimal SEWB_IGST_Rate
{
get
  {
   return this._SEWB_IGST_Rate;  }
set
   {
     this._SEWB_IGST_Rate = value;
     _UpdateFieldName.Add("SEWB_IGST_Rate");
     }
}
public Decimal SEWB_IGST_Amt
{
get
  {
   return this._SEWB_IGST_Amt;  }
set
   {
     this._SEWB_IGST_Amt = value;
     _UpdateFieldName.Add("SEWB_IGST_Amt");
     }
}
public Decimal SEWB_IGST_TaxableAmt
{
get
  {
   return this._SEWB_IGST_TaxableAmt;  }
set
   {
     this._SEWB_IGST_TaxableAmt = value;
     _UpdateFieldName.Add("SEWB_IGST_TaxableAmt");
     }
}
public Int16 SEWB_CESS_ID
{
get
  {
   return this._SEWB_CESS_ID;  }
set
   {
     this._SEWB_CESS_ID = value;
     _UpdateFieldName.Add("SEWB_CESS_ID");
     }
}
public Decimal SEWB_CESS_Rate
{
get
  {
   return this._SEWB_CESS_Rate;  }
set
   {
     this._SEWB_CESS_Rate = value;
     _UpdateFieldName.Add("SEWB_CESS_Rate");
     }
}
public Decimal SEWB_CESS_Amt
{
get
  {
   return this._SEWB_CESS_Amt;  }
set
   {
     this._SEWB_CESS_Amt = value;
     _UpdateFieldName.Add("SEWB_CESS_Amt");
     }
}
public Decimal SEWB_CESS_TaxableAmt
{
get
  {
   return this._SEWB_CESS_TaxableAmt;  }
set
   {
     this._SEWB_CESS_TaxableAmt = value;
     _UpdateFieldName.Add("SEWB_CESS_TaxableAmt");
     }
}
public Int16 SEWB_OtherTax_ID
{
get
  {
   return this._SEWB_OtherTax_ID;  }
set
   {
     this._SEWB_OtherTax_ID = value;
     _UpdateFieldName.Add("SEWB_OtherTax_ID");
     }
}
public Decimal SEWB_OtherTax_Rate
{
get
  {
   return this._SEWB_OtherTax_Rate;  }
set
   {
     this._SEWB_OtherTax_Rate = value;
     _UpdateFieldName.Add("SEWB_OtherTax_Rate");
     }
}
public Decimal SEWB_OtherTax_Amt
{
get
  {
   return this._SEWB_OtherTax_Amt;  }
set
   {
     this._SEWB_OtherTax_Amt = value;
     _UpdateFieldName.Add("SEWB_OtherTax_Amt");
     }
}
public Decimal SEWB_OtherTax_TaxableAmt
{
get
  {
   return this._SEWB_OtherTax_TaxableAmt;  }
set
   {
     this._SEWB_OtherTax_TaxableAmt = value;
     _UpdateFieldName.Add("SEWB_OtherTax_TaxableAmt");
     }
}
public Decimal SEWB_TotalTax
{
get
  {
   return this._SEWB_TotalTax;  }
set
   {
     this._SEWB_TotalTax = value;
     _UpdateFieldName.Add("SEWB_TotalTax");
     }
}
public Decimal SEWB_GrossRateWithTax
{
get
  {
   return this._SEWB_GrossRateWithTax;  }
set
   {
     this._SEWB_GrossRateWithTax = value;
     _UpdateFieldName.Add("SEWB_GrossRateWithTax");
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
public String SEWB_ItemRemark_DTL
{
get
  {
   return this._SEWB_ItemRemark_DTL;  }
set
   {
     this._SEWB_ItemRemark_DTL = value;
     _UpdateFieldName.Add("SEWB_ItemRemark_DTL");
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

#endregion
#region Genric Methods
public string Insert_Update(M_AT_Sales_SEWB_BDTLBO sObject)
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

// ObjAT_SEWBDTL.SEWB_DTL_ID=ObjAT_SEWBDTL.SEWB_DTL_ID;
// ObjAT_SEWBDTL.Fk_SEWB_HDR_ID=ObjAT_SEWBDTL.Fk_SEWB_HDR_ID;
// ObjAT_SEWBDTL.Fk_MItem_ID=ObjAT_SEWBDTL.Fk_MItem_ID;
// ObjAT_SEWBDTL.SEWB_HSNCode=ObjAT_SEWBDTL.SEWB_HSNCode;
// ObjAT_SEWBDTL.SEWB_QTY=ObjAT_SEWBDTL.SEWB_QTY;
// ObjAT_SEWBDTL.SEWB_BasicRate=ObjAT_SEWBDTL.SEWB_BasicRate;
// ObjAT_SEWBDTL.SEWB_NetRate=ObjAT_SEWBDTL.SEWB_NetRate;
// ObjAT_SEWBDTL.SEWB_BasicAmt=ObjAT_SEWBDTL.SEWB_BasicAmt;
// ObjAT_SEWBDTL.SEWB_DiscountRate=ObjAT_SEWBDTL.SEWB_DiscountRate;
// ObjAT_SEWBDTL.SEWB_DiscountAmt=ObjAT_SEWBDTL.SEWB_DiscountAmt;
// ObjAT_SEWBDTL.SEWB_NetTaxableAmt=ObjAT_SEWBDTL.SEWB_NetTaxableAmt;
// ObjAT_SEWBDTL.SEWB_GST_TaxRate_ID=ObjAT_SEWBDTL.SEWB_GST_TaxRate_ID;
// ObjAT_SEWBDTL.SEWB_GST_TaxRate=ObjAT_SEWBDTL.SEWB_GST_TaxRate;
// ObjAT_SEWBDTL.SEWB_CGST_ID=ObjAT_SEWBDTL.SEWB_CGST_ID;
// ObjAT_SEWBDTL.SEWB_CGST_Rate=ObjAT_SEWBDTL.SEWB_CGST_Rate;
// ObjAT_SEWBDTL.SEWB_CGST_Amt=ObjAT_SEWBDTL.SEWB_CGST_Amt;
// ObjAT_SEWBDTL.SEWB_CGST_TaxableAmt=ObjAT_SEWBDTL.SEWB_CGST_TaxableAmt;
// ObjAT_SEWBDTL.SEWB_SGST_ID=ObjAT_SEWBDTL.SEWB_SGST_ID;
// ObjAT_SEWBDTL.SEWB_SGST_Rate=ObjAT_SEWBDTL.SEWB_SGST_Rate;
// ObjAT_SEWBDTL.SEWB_SGST_Amt=ObjAT_SEWBDTL.SEWB_SGST_Amt;
// ObjAT_SEWBDTL.SEWB_SGST_TaxableAmt=ObjAT_SEWBDTL.SEWB_SGST_TaxableAmt;
// ObjAT_SEWBDTL.SEWB_IGST_ID=ObjAT_SEWBDTL.SEWB_IGST_ID;
// ObjAT_SEWBDTL.SEWB_IGST_Rate=ObjAT_SEWBDTL.SEWB_IGST_Rate;
// ObjAT_SEWBDTL.SEWB_IGST_Amt=ObjAT_SEWBDTL.SEWB_IGST_Amt;
// ObjAT_SEWBDTL.SEWB_IGST_TaxableAmt=ObjAT_SEWBDTL.SEWB_IGST_TaxableAmt;
// ObjAT_SEWBDTL.SEWB_CESS_ID=ObjAT_SEWBDTL.SEWB_CESS_ID;
// ObjAT_SEWBDTL.SEWB_CESS_Rate=ObjAT_SEWBDTL.SEWB_CESS_Rate;
// ObjAT_SEWBDTL.SEWB_CESS_Amt=ObjAT_SEWBDTL.SEWB_CESS_Amt;
// ObjAT_SEWBDTL.SEWB_CESS_TaxableAmt=ObjAT_SEWBDTL.SEWB_CESS_TaxableAmt;
// ObjAT_SEWBDTL.SEWB_OtherTax_ID=ObjAT_SEWBDTL.SEWB_OtherTax_ID;
// ObjAT_SEWBDTL.SEWB_OtherTax_Rate=ObjAT_SEWBDTL.SEWB_OtherTax_Rate;
// ObjAT_SEWBDTL.SEWB_OtherTax_Amt=ObjAT_SEWBDTL.SEWB_OtherTax_Amt;
// ObjAT_SEWBDTL.SEWB_OtherTax_TaxableAmt=ObjAT_SEWBDTL.SEWB_OtherTax_TaxableAmt;
// ObjAT_SEWBDTL.SEWB_TotalTax=ObjAT_SEWBDTL.SEWB_TotalTax;
// ObjAT_SEWBDTL.SEWB_GrossRateWithTax=ObjAT_SEWBDTL.SEWB_GrossRateWithTax;
// ObjAT_SEWBDTL.MDBSC_RowStatus=ObjAT_SEWBDTL.MDBSC_RowStatus;
// ObjAT_SEWBDTL.SEWB_ItemRemark_DTL=ObjAT_SEWBDTL.SEWB_ItemRemark_DTL;
// ObjAT_SEWBDTL.MDBSC_RowCreatedByUser_ID=ObjAT_SEWBDTL.MDBSC_RowCreatedByUser_ID;
// ObjAT_SEWBDTL.MDBSC_RowCreatedByUserName=ObjAT_SEWBDTL.MDBSC_RowCreatedByUserName;
// ObjAT_SEWBDTL.MDBSC_RowCreatedOn_DT=ObjAT_SEWBDTL.MDBSC_RowCreatedOn_DT;
// ObjAT_SEWBDTL.MDBSC_RowLupdnByUser_ID=ObjAT_SEWBDTL.MDBSC_RowLupdnByUser_ID;
// ObjAT_SEWBDTL.MDBSC_RowLupdnUserName=ObjAT_SEWBDTL.MDBSC_RowLupdnUserName;
// ObjAT_SEWBDTL.MDBSC_RowLupdnOn_DT=ObjAT_SEWBDTL.MDBSC_RowLupdnOn_DT;



// SEWB_DTL_ID.Text = "";
// Fk_SEWB_HDR_ID.Text = "";
// Fk_MItem_ID.Text = "";
// SEWB_HSNCode.Text = "";
// SEWB_QTY.Text = "";
// SEWB_BasicRate.Text = "";
// SEWB_NetRate.Text = "";
// SEWB_BasicAmt.Text = "";
// SEWB_DiscountRate.Text = "";
// SEWB_DiscountAmt.Text = "";
// SEWB_NetTaxableAmt.Text = "";
// SEWB_GST_TaxRate_ID.Text = "";
// SEWB_GST_TaxRate.Text = "";
// SEWB_CGST_ID.Text = "";
// SEWB_CGST_Rate.Text = "";
// SEWB_CGST_Amt.Text = "";
// SEWB_CGST_TaxableAmt.Text = "";
// SEWB_SGST_ID.Text = "";
// SEWB_SGST_Rate.Text = "";
// SEWB_SGST_Amt.Text = "";
// SEWB_SGST_TaxableAmt.Text = "";
// SEWB_IGST_ID.Text = "";
// SEWB_IGST_Rate.Text = "";
// SEWB_IGST_Amt.Text = "";
// SEWB_IGST_TaxableAmt.Text = "";
// SEWB_CESS_ID.Text = "";
// SEWB_CESS_Rate.Text = "";
// SEWB_CESS_Amt.Text = "";
// SEWB_CESS_TaxableAmt.Text = "";
// SEWB_OtherTax_ID.Text = "";
// SEWB_OtherTax_Rate.Text = "";
// SEWB_OtherTax_Amt.Text = "";
// SEWB_OtherTax_TaxableAmt.Text = "";
// SEWB_TotalTax.Text = "";
// SEWB_GrossRateWithTax.Text = "";
// MDBSC_RowStatus.Text = "";
// SEWB_ItemRemark_DTL.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";



// ObjAT_SEWBDTL.SEWB_DTL_ID=SEWB_DTL_ID.Text ;
// ObjAT_SEWBDTL.Fk_SEWB_HDR_ID=Fk_SEWB_HDR_ID.Text ;
// ObjAT_SEWBDTL.Fk_MItem_ID=Fk_MItem_ID.Text ;
// ObjAT_SEWBDTL.SEWB_HSNCode=SEWB_HSNCode.Text ;
// ObjAT_SEWBDTL.SEWB_QTY=SEWB_QTY.Text ;
// ObjAT_SEWBDTL.SEWB_BasicRate=SEWB_BasicRate.Text ;
// ObjAT_SEWBDTL.SEWB_NetRate=SEWB_NetRate.Text ;
// ObjAT_SEWBDTL.SEWB_BasicAmt=SEWB_BasicAmt.Text ;
// ObjAT_SEWBDTL.SEWB_DiscountRate=SEWB_DiscountRate.Text ;
// ObjAT_SEWBDTL.SEWB_DiscountAmt=SEWB_DiscountAmt.Text ;
// ObjAT_SEWBDTL.SEWB_NetTaxableAmt=SEWB_NetTaxableAmt.Text ;
// ObjAT_SEWBDTL.SEWB_GST_TaxRate_ID=SEWB_GST_TaxRate_ID.Text ;
// ObjAT_SEWBDTL.SEWB_GST_TaxRate=SEWB_GST_TaxRate.Text ;
// ObjAT_SEWBDTL.SEWB_CGST_ID=SEWB_CGST_ID.Text ;
// ObjAT_SEWBDTL.SEWB_CGST_Rate=SEWB_CGST_Rate.Text ;
// ObjAT_SEWBDTL.SEWB_CGST_Amt=SEWB_CGST_Amt.Text ;
// ObjAT_SEWBDTL.SEWB_CGST_TaxableAmt=SEWB_CGST_TaxableAmt.Text ;
// ObjAT_SEWBDTL.SEWB_SGST_ID=SEWB_SGST_ID.Text ;
// ObjAT_SEWBDTL.SEWB_SGST_Rate=SEWB_SGST_Rate.Text ;
// ObjAT_SEWBDTL.SEWB_SGST_Amt=SEWB_SGST_Amt.Text ;
// ObjAT_SEWBDTL.SEWB_SGST_TaxableAmt=SEWB_SGST_TaxableAmt.Text ;
// ObjAT_SEWBDTL.SEWB_IGST_ID=SEWB_IGST_ID.Text ;
// ObjAT_SEWBDTL.SEWB_IGST_Rate=SEWB_IGST_Rate.Text ;
// ObjAT_SEWBDTL.SEWB_IGST_Amt=SEWB_IGST_Amt.Text ;
// ObjAT_SEWBDTL.SEWB_IGST_TaxableAmt=SEWB_IGST_TaxableAmt.Text ;
// ObjAT_SEWBDTL.SEWB_CESS_ID=SEWB_CESS_ID.Text ;
// ObjAT_SEWBDTL.SEWB_CESS_Rate=SEWB_CESS_Rate.Text ;
// ObjAT_SEWBDTL.SEWB_CESS_Amt=SEWB_CESS_Amt.Text ;
// ObjAT_SEWBDTL.SEWB_CESS_TaxableAmt=SEWB_CESS_TaxableAmt.Text ;
// ObjAT_SEWBDTL.SEWB_OtherTax_ID=SEWB_OtherTax_ID.Text ;
// ObjAT_SEWBDTL.SEWB_OtherTax_Rate=SEWB_OtherTax_Rate.Text ;
// ObjAT_SEWBDTL.SEWB_OtherTax_Amt=SEWB_OtherTax_Amt.Text ;
// ObjAT_SEWBDTL.SEWB_OtherTax_TaxableAmt=SEWB_OtherTax_TaxableAmt.Text ;
// ObjAT_SEWBDTL.SEWB_TotalTax=SEWB_TotalTax.Text ;
// ObjAT_SEWBDTL.SEWB_GrossRateWithTax=SEWB_GrossRateWithTax.Text ;
// ObjAT_SEWBDTL.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_SEWBDTL.SEWB_ItemRemark_DTL=SEWB_ItemRemark_DTL.Text ;
// ObjAT_SEWBDTL.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_SEWBDTL.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_SEWBDTL.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_SEWBDTL.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_SEWBDTL.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_SEWBDTL.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;



// SEWB_DTL_ID.Text =  dt.Rows[0]["SEWB_DTL_ID"].ToString();
// Fk_SEWB_HDR_ID.Text =  dt.Rows[0]["Fk_SEWB_HDR_ID"].ToString();
// Fk_MItem_ID.Text =  dt.Rows[0]["Fk_MItem_ID"].ToString();
// SEWB_HSNCode.Text =  dt.Rows[0]["SEWB_HSNCode"].ToString();
// SEWB_QTY.Text =  dt.Rows[0]["SEWB_QTY"].ToString();
// SEWB_BasicRate.Text =  dt.Rows[0]["SEWB_BasicRate"].ToString();
// SEWB_NetRate.Text =  dt.Rows[0]["SEWB_NetRate"].ToString();
// SEWB_BasicAmt.Text =  dt.Rows[0]["SEWB_BasicAmt"].ToString();
// SEWB_DiscountRate.Text =  dt.Rows[0]["SEWB_DiscountRate"].ToString();
// SEWB_DiscountAmt.Text =  dt.Rows[0]["SEWB_DiscountAmt"].ToString();
// SEWB_NetTaxableAmt.Text =  dt.Rows[0]["SEWB_NetTaxableAmt"].ToString();
// SEWB_GST_TaxRate_ID.Text =  dt.Rows[0]["SEWB_GST_TaxRate_ID"].ToString();
// SEWB_GST_TaxRate.Text =  dt.Rows[0]["SEWB_GST_TaxRate"].ToString();
// SEWB_CGST_ID.Text =  dt.Rows[0]["SEWB_CGST_ID"].ToString();
// SEWB_CGST_Rate.Text =  dt.Rows[0]["SEWB_CGST_Rate"].ToString();
// SEWB_CGST_Amt.Text =  dt.Rows[0]["SEWB_CGST_Amt"].ToString();
// SEWB_CGST_TaxableAmt.Text =  dt.Rows[0]["SEWB_CGST_TaxableAmt"].ToString();
// SEWB_SGST_ID.Text =  dt.Rows[0]["SEWB_SGST_ID"].ToString();
// SEWB_SGST_Rate.Text =  dt.Rows[0]["SEWB_SGST_Rate"].ToString();
// SEWB_SGST_Amt.Text =  dt.Rows[0]["SEWB_SGST_Amt"].ToString();
// SEWB_SGST_TaxableAmt.Text =  dt.Rows[0]["SEWB_SGST_TaxableAmt"].ToString();
// SEWB_IGST_ID.Text =  dt.Rows[0]["SEWB_IGST_ID"].ToString();
// SEWB_IGST_Rate.Text =  dt.Rows[0]["SEWB_IGST_Rate"].ToString();
// SEWB_IGST_Amt.Text =  dt.Rows[0]["SEWB_IGST_Amt"].ToString();
// SEWB_IGST_TaxableAmt.Text =  dt.Rows[0]["SEWB_IGST_TaxableAmt"].ToString();
// SEWB_CESS_ID.Text =  dt.Rows[0]["SEWB_CESS_ID"].ToString();
// SEWB_CESS_Rate.Text =  dt.Rows[0]["SEWB_CESS_Rate"].ToString();
// SEWB_CESS_Amt.Text =  dt.Rows[0]["SEWB_CESS_Amt"].ToString();
// SEWB_CESS_TaxableAmt.Text =  dt.Rows[0]["SEWB_CESS_TaxableAmt"].ToString();
// SEWB_OtherTax_ID.Text =  dt.Rows[0]["SEWB_OtherTax_ID"].ToString();
// SEWB_OtherTax_Rate.Text =  dt.Rows[0]["SEWB_OtherTax_Rate"].ToString();
// SEWB_OtherTax_Amt.Text =  dt.Rows[0]["SEWB_OtherTax_Amt"].ToString();
// SEWB_OtherTax_TaxableAmt.Text =  dt.Rows[0]["SEWB_OtherTax_TaxableAmt"].ToString();
// SEWB_TotalTax.Text =  dt.Rows[0]["SEWB_TotalTax"].ToString();
// SEWB_GrossRateWithTax.Text =  dt.Rows[0]["SEWB_GrossRateWithTax"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// SEWB_ItemRemark_DTL.Text =  dt.Rows[0]["SEWB_ItemRemark_DTL"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
