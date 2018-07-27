using System;
using System.Collections;
using System.Data;
using   MaheshAF18.DataAccess;
namespace MABL.ATDataModal 
{
public class M_AT_Purchase_Inv_BDTLBO
{
MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
#region Constructor 
public M_AT_Purchase_Inv_BDTLBO() { }
#endregion 
#region Standard Property
private string _PrimaryKeyName = "PINVDTL_ID";
private string _TableName = "M_AT_Purchase_Inv_BDTL";
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

private Int64 _PINVDTL_ID;
private Int64 _Fk_PINVHDR_ID;
private Int64 _Fk_PIHDR_ID;
private Int64 _Fk_PIDTL_ID;
private Int64 _Fk_MItem_ID;
private String _PINV_HSNCode;
private Decimal _PINV_QTY;
private Decimal _PINV_QTY_Tolerance_Rate;
private Decimal _PINV_QTY_Tolerance;
private Decimal _PINV_Final_Qty;
private Decimal _PINV_GRN_Qty;
private Decimal _PINV_GRN_Rejected_Qty;
private Decimal _PINV_Blance_Qty;
private String _Qtn_Selected;
private Decimal _PINV_BasicRate;
private Decimal _PINV_NetRate;
private Decimal _PINV_BasicAmt;
private Decimal _PINV_DiscountRate;
private Decimal _PINV_DiscountAmt;
private Decimal _PINV_NetTaxableAmt;
private Int16 _PINV_CGST_ID;
private Decimal _PINV_CGST_Rate;
private Decimal _PINV_CGST_Amt;
private Decimal _PINV_CGST_TaxableAmt;
private Int16 _PINV_SGST_ID;
private Decimal _PINV_SGST_Rate;
private Decimal _PINV_SGST_Amt;
private Decimal _PINV_SGST_TaxableAmt;
private Int16 _PINV_IGST_ID;
private Decimal _PINV_IGST_Rate;
private Decimal _PINV_IGST_Amt;
private Decimal _PINV_IGST_TaxableAmt;
private Int16 _PINV_CESS_ID;
private Decimal _PINV_CESS_Rate;
private Decimal _PINV_CESS_Amt;
private Decimal _PINV_CESS_TaxableAmt;
private Int16 _PINV_OtherTax_ID;
private Decimal _PINV_OtherTax_Rate;
private Decimal _PINV_OtherTax_Amt;
private Decimal _PINV_OtherTax_TaxableAmt;
private Decimal _PINV_TotalTax;
private Decimal _PINV_GrossRateWithTax;
private String _MDBSC_RowStatus;
private String _PINV_ItemRemark_DTL;
private Int16 _MDBSC_RowCreatedByUser_ID;
private String _MDBSC_RowCreatedByUserName;
private String _MDBSC_RowCreatedOn_DT;
private Int16 _MDBSC_RowLupdnByUser_ID;
private String _MDBSC_RowLupdnUserName;
private String _MDBSC_RowLupdnOn_DT;

public Int64 PINVDTL_ID
{
get
  {
   return this._PINVDTL_ID;  }
set
   {
     this._PINVDTL_ID = value;
     _UpdateFieldName.Add("PINVDTL_ID");
     }
}
public Int64 Fk_PINVHDR_ID
{
get
  {
   return this._Fk_PINVHDR_ID;  }
set
   {
     this._Fk_PINVHDR_ID = value;
     _UpdateFieldName.Add("Fk_PINVHDR_ID");
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
public Int64 Fk_PIDTL_ID
{
get
  {
   return this._Fk_PIDTL_ID;  }
set
   {
     this._Fk_PIDTL_ID = value;
     _UpdateFieldName.Add("Fk_PIDTL_ID");
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
public String PINV_HSNCode
{
get
  {
   return this._PINV_HSNCode;  }
set
   {
     this._PINV_HSNCode = value;
     _UpdateFieldName.Add("PINV_HSNCode");
     }
}
public Decimal PINV_QTY
{
get
  {
   return this._PINV_QTY;  }
set
   {
     this._PINV_QTY = value;
     _UpdateFieldName.Add("PINV_QTY");
     }
}
public Decimal PINV_QTY_Tolerance_Rate
{
get
  {
   return this._PINV_QTY_Tolerance_Rate;  }
set
   {
     this._PINV_QTY_Tolerance_Rate = value;
     _UpdateFieldName.Add("PINV_QTY_Tolerance_Rate");
     }
}
public Decimal PINV_QTY_Tolerance
{
get
  {
   return this._PINV_QTY_Tolerance;  }
set
   {
     this._PINV_QTY_Tolerance = value;
     _UpdateFieldName.Add("PINV_QTY_Tolerance");
     }
}
public Decimal PINV_Final_Qty
{
get
  {
   return this._PINV_Final_Qty;  }
set
   {
     this._PINV_Final_Qty = value;
     _UpdateFieldName.Add("PINV_Final_Qty");
     }
}
public Decimal PINV_GRN_Qty
{
get
  {
   return this._PINV_GRN_Qty;  }
set
   {
     this._PINV_GRN_Qty = value;
     _UpdateFieldName.Add("PINV_GRN_Qty");
     }
}
public Decimal PINV_GRN_Rejected_Qty
{
get
  {
   return this._PINV_GRN_Rejected_Qty;  }
set
   {
     this._PINV_GRN_Rejected_Qty = value;
     _UpdateFieldName.Add("PINV_GRN_Rejected_Qty");
     }
}
public Decimal PINV_Blance_Qty
{
get
  {
   return this._PINV_Blance_Qty;  }
set
   {
     this._PINV_Blance_Qty = value;
     _UpdateFieldName.Add("PINV_Blance_Qty");
     }
}
public String Qtn_Selected
{
get
  {
   return this._Qtn_Selected;  }
set
   {
     this._Qtn_Selected = value;
     _UpdateFieldName.Add("Qtn_Selected");
     }
}
public Decimal PINV_BasicRate
{
get
  {
   return this._PINV_BasicRate;  }
set
   {
     this._PINV_BasicRate = value;
     _UpdateFieldName.Add("PINV_BasicRate");
     }
}
public Decimal PINV_NetRate
{
get
  {
   return this._PINV_NetRate;  }
set
   {
     this._PINV_NetRate = value;
     _UpdateFieldName.Add("PINV_NetRate");
     }
}
public Decimal PINV_BasicAmt
{
get
  {
   return this._PINV_BasicAmt;  }
set
   {
     this._PINV_BasicAmt = value;
     _UpdateFieldName.Add("PINV_BasicAmt");
     }
}
public Decimal PINV_DiscountRate
{
get
  {
   return this._PINV_DiscountRate;  }
set
   {
     this._PINV_DiscountRate = value;
     _UpdateFieldName.Add("PINV_DiscountRate");
     }
}
public Decimal PINV_DiscountAmt
{
get
  {
   return this._PINV_DiscountAmt;  }
set
   {
     this._PINV_DiscountAmt = value;
     _UpdateFieldName.Add("PINV_DiscountAmt");
     }
}
public Decimal PINV_NetTaxableAmt
{
get
  {
   return this._PINV_NetTaxableAmt;  }
set
   {
     this._PINV_NetTaxableAmt = value;
     _UpdateFieldName.Add("PINV_NetTaxableAmt");
     }
}
public Int16 PINV_CGST_ID
{
get
  {
   return this._PINV_CGST_ID;  }
set
   {
     this._PINV_CGST_ID = value;
     _UpdateFieldName.Add("PINV_CGST_ID");
     }
}
public Decimal PINV_CGST_Rate
{
get
  {
   return this._PINV_CGST_Rate;  }
set
   {
     this._PINV_CGST_Rate = value;
     _UpdateFieldName.Add("PINV_CGST_Rate");
     }
}
public Decimal PINV_CGST_Amt
{
get
  {
   return this._PINV_CGST_Amt;  }
set
   {
     this._PINV_CGST_Amt = value;
     _UpdateFieldName.Add("PINV_CGST_Amt");
     }
}
public Decimal PINV_CGST_TaxableAmt
{
get
  {
   return this._PINV_CGST_TaxableAmt;  }
set
   {
     this._PINV_CGST_TaxableAmt = value;
     _UpdateFieldName.Add("PINV_CGST_TaxableAmt");
     }
}
public Int16 PINV_SGST_ID
{
get
  {
   return this._PINV_SGST_ID;  }
set
   {
     this._PINV_SGST_ID = value;
     _UpdateFieldName.Add("PINV_SGST_ID");
     }
}
public Decimal PINV_SGST_Rate
{
get
  {
   return this._PINV_SGST_Rate;  }
set
   {
     this._PINV_SGST_Rate = value;
     _UpdateFieldName.Add("PINV_SGST_Rate");
     }
}
public Decimal PINV_SGST_Amt
{
get
  {
   return this._PINV_SGST_Amt;  }
set
   {
     this._PINV_SGST_Amt = value;
     _UpdateFieldName.Add("PINV_SGST_Amt");
     }
}
public Decimal PINV_SGST_TaxableAmt
{
get
  {
   return this._PINV_SGST_TaxableAmt;  }
set
   {
     this._PINV_SGST_TaxableAmt = value;
     _UpdateFieldName.Add("PINV_SGST_TaxableAmt");
     }
}
public Int16 PINV_IGST_ID
{
get
  {
   return this._PINV_IGST_ID;  }
set
   {
     this._PINV_IGST_ID = value;
     _UpdateFieldName.Add("PINV_IGST_ID");
     }
}
public Decimal PINV_IGST_Rate
{
get
  {
   return this._PINV_IGST_Rate;  }
set
   {
     this._PINV_IGST_Rate = value;
     _UpdateFieldName.Add("PINV_IGST_Rate");
     }
}
public Decimal PINV_IGST_Amt
{
get
  {
   return this._PINV_IGST_Amt;  }
set
   {
     this._PINV_IGST_Amt = value;
     _UpdateFieldName.Add("PINV_IGST_Amt");
     }
}
public Decimal PINV_IGST_TaxableAmt
{
get
  {
   return this._PINV_IGST_TaxableAmt;  }
set
   {
     this._PINV_IGST_TaxableAmt = value;
     _UpdateFieldName.Add("PINV_IGST_TaxableAmt");
     }
}
public Int16 PINV_CESS_ID
{
get
  {
   return this._PINV_CESS_ID;  }
set
   {
     this._PINV_CESS_ID = value;
     _UpdateFieldName.Add("PINV_CESS_ID");
     }
}
public Decimal PINV_CESS_Rate
{
get
  {
   return this._PINV_CESS_Rate;  }
set
   {
     this._PINV_CESS_Rate = value;
     _UpdateFieldName.Add("PINV_CESS_Rate");
     }
}
public Decimal PINV_CESS_Amt
{
get
  {
   return this._PINV_CESS_Amt;  }
set
   {
     this._PINV_CESS_Amt = value;
     _UpdateFieldName.Add("PINV_CESS_Amt");
     }
}
public Decimal PINV_CESS_TaxableAmt
{
get
  {
   return this._PINV_CESS_TaxableAmt;  }
set
   {
     this._PINV_CESS_TaxableAmt = value;
     _UpdateFieldName.Add("PINV_CESS_TaxableAmt");
     }
}
public Int16 PINV_OtherTax_ID
{
get
  {
   return this._PINV_OtherTax_ID;  }
set
   {
     this._PINV_OtherTax_ID = value;
     _UpdateFieldName.Add("PINV_OtherTax_ID");
     }
}
public Decimal PINV_OtherTax_Rate
{
get
  {
   return this._PINV_OtherTax_Rate;  }
set
   {
     this._PINV_OtherTax_Rate = value;
     _UpdateFieldName.Add("PINV_OtherTax_Rate");
     }
}
public Decimal PINV_OtherTax_Amt
{
get
  {
   return this._PINV_OtherTax_Amt;  }
set
   {
     this._PINV_OtherTax_Amt = value;
     _UpdateFieldName.Add("PINV_OtherTax_Amt");
     }
}
public Decimal PINV_OtherTax_TaxableAmt
{
get
  {
   return this._PINV_OtherTax_TaxableAmt;  }
set
   {
     this._PINV_OtherTax_TaxableAmt = value;
     _UpdateFieldName.Add("PINV_OtherTax_TaxableAmt");
     }
}
public Decimal PINV_TotalTax
{
get
  {
   return this._PINV_TotalTax;  }
set
   {
     this._PINV_TotalTax = value;
     _UpdateFieldName.Add("PINV_TotalTax");
     }
}
public Decimal PINV_GrossRateWithTax
{
get
  {
   return this._PINV_GrossRateWithTax;  }
set
   {
     this._PINV_GrossRateWithTax = value;
     _UpdateFieldName.Add("PINV_GrossRateWithTax");
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
public String PINV_ItemRemark_DTL
{
get
  {
   return this._PINV_ItemRemark_DTL;  }
set
   {
     this._PINV_ItemRemark_DTL = value;
     _UpdateFieldName.Add("PINV_ItemRemark_DTL");
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
public string Insert_Update(M_AT_Purchase_Inv_BDTLBO sObject)
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

// ObjAT_PINVDTL.PINVDTL_ID=ObjAT_PINVDTL.PINVDTL_ID;
// ObjAT_PINVDTL.Fk_PINVHDR_ID=ObjAT_PINVDTL.Fk_PINVHDR_ID;
// ObjAT_PINVDTL.Fk_PIHDR_ID=ObjAT_PINVDTL.Fk_PIHDR_ID;
// ObjAT_PINVDTL.Fk_PIDTL_ID=ObjAT_PINVDTL.Fk_PIDTL_ID;
// ObjAT_PINVDTL.Fk_MItem_ID=ObjAT_PINVDTL.Fk_MItem_ID;
// ObjAT_PINVDTL.PINV_HSNCode=ObjAT_PINVDTL.PINV_HSNCode;
// ObjAT_PINVDTL.PINV_QTY=ObjAT_PINVDTL.PINV_QTY;
// ObjAT_PINVDTL.PINV_QTY_Tolerance_Rate=ObjAT_PINVDTL.PINV_QTY_Tolerance_Rate;
// ObjAT_PINVDTL.PINV_QTY_Tolerance=ObjAT_PINVDTL.PINV_QTY_Tolerance;
// ObjAT_PINVDTL.PINV_Final_Qty=ObjAT_PINVDTL.PINV_Final_Qty;
// ObjAT_PINVDTL.PINV_GRN_Qty=ObjAT_PINVDTL.PINV_GRN_Qty;
// ObjAT_PINVDTL.PINV_GRN_Rejected_Qty=ObjAT_PINVDTL.PINV_GRN_Rejected_Qty;
// ObjAT_PINVDTL.PINV_Blance_Qty=ObjAT_PINVDTL.PINV_Blance_Qty;
// ObjAT_PINVDTL.Qtn_Selected=ObjAT_PINVDTL.Qtn_Selected;
// ObjAT_PINVDTL.PINV_BasicRate=ObjAT_PINVDTL.PINV_BasicRate;
// ObjAT_PINVDTL.PINV_NetRate=ObjAT_PINVDTL.PINV_NetRate;
// ObjAT_PINVDTL.PINV_BasicAmt=ObjAT_PINVDTL.PINV_BasicAmt;
// ObjAT_PINVDTL.PINV_DiscountRate=ObjAT_PINVDTL.PINV_DiscountRate;
// ObjAT_PINVDTL.PINV_DiscountAmt=ObjAT_PINVDTL.PINV_DiscountAmt;
// ObjAT_PINVDTL.PINV_NetTaxableAmt=ObjAT_PINVDTL.PINV_NetTaxableAmt;
// ObjAT_PINVDTL.PINV_CGST_ID=ObjAT_PINVDTL.PINV_CGST_ID;
// ObjAT_PINVDTL.PINV_CGST_Rate=ObjAT_PINVDTL.PINV_CGST_Rate;
// ObjAT_PINVDTL.PINV_CGST_Amt=ObjAT_PINVDTL.PINV_CGST_Amt;
// ObjAT_PINVDTL.PINV_CGST_TaxableAmt=ObjAT_PINVDTL.PINV_CGST_TaxableAmt;
// ObjAT_PINVDTL.PINV_SGST_ID=ObjAT_PINVDTL.PINV_SGST_ID;
// ObjAT_PINVDTL.PINV_SGST_Rate=ObjAT_PINVDTL.PINV_SGST_Rate;
// ObjAT_PINVDTL.PINV_SGST_Amt=ObjAT_PINVDTL.PINV_SGST_Amt;
// ObjAT_PINVDTL.PINV_SGST_TaxableAmt=ObjAT_PINVDTL.PINV_SGST_TaxableAmt;
// ObjAT_PINVDTL.PINV_IGST_ID=ObjAT_PINVDTL.PINV_IGST_ID;
// ObjAT_PINVDTL.PINV_IGST_Rate=ObjAT_PINVDTL.PINV_IGST_Rate;
// ObjAT_PINVDTL.PINV_IGST_Amt=ObjAT_PINVDTL.PINV_IGST_Amt;
// ObjAT_PINVDTL.PINV_IGST_TaxableAmt=ObjAT_PINVDTL.PINV_IGST_TaxableAmt;
// ObjAT_PINVDTL.PINV_CESS_ID=ObjAT_PINVDTL.PINV_CESS_ID;
// ObjAT_PINVDTL.PINV_CESS_Rate=ObjAT_PINVDTL.PINV_CESS_Rate;
// ObjAT_PINVDTL.PINV_CESS_Amt=ObjAT_PINVDTL.PINV_CESS_Amt;
// ObjAT_PINVDTL.PINV_CESS_TaxableAmt=ObjAT_PINVDTL.PINV_CESS_TaxableAmt;
// ObjAT_PINVDTL.PINV_OtherTax_ID=ObjAT_PINVDTL.PINV_OtherTax_ID;
// ObjAT_PINVDTL.PINV_OtherTax_Rate=ObjAT_PINVDTL.PINV_OtherTax_Rate;
// ObjAT_PINVDTL.PINV_OtherTax_Amt=ObjAT_PINVDTL.PINV_OtherTax_Amt;
// ObjAT_PINVDTL.PINV_OtherTax_TaxableAmt=ObjAT_PINVDTL.PINV_OtherTax_TaxableAmt;
// ObjAT_PINVDTL.PINV_TotalTax=ObjAT_PINVDTL.PINV_TotalTax;
// ObjAT_PINVDTL.PINV_GrossRateWithTax=ObjAT_PINVDTL.PINV_GrossRateWithTax;
// ObjAT_PINVDTL.MDBSC_RowStatus=ObjAT_PINVDTL.MDBSC_RowStatus;
// ObjAT_PINVDTL.PINV_ItemRemark_DTL=ObjAT_PINVDTL.PINV_ItemRemark_DTL;
// ObjAT_PINVDTL.MDBSC_RowCreatedByUser_ID=ObjAT_PINVDTL.MDBSC_RowCreatedByUser_ID;
// ObjAT_PINVDTL.MDBSC_RowCreatedByUserName=ObjAT_PINVDTL.MDBSC_RowCreatedByUserName;
// ObjAT_PINVDTL.MDBSC_RowCreatedOn_DT=ObjAT_PINVDTL.MDBSC_RowCreatedOn_DT;
// ObjAT_PINVDTL.MDBSC_RowLupdnByUser_ID=ObjAT_PINVDTL.MDBSC_RowLupdnByUser_ID;
// ObjAT_PINVDTL.MDBSC_RowLupdnUserName=ObjAT_PINVDTL.MDBSC_RowLupdnUserName;
// ObjAT_PINVDTL.MDBSC_RowLupdnOn_DT=ObjAT_PINVDTL.MDBSC_RowLupdnOn_DT;



// PINVDTL_ID.Text = "";
// Fk_PINVHDR_ID.Text = "";
// Fk_PIHDR_ID.Text = "";
// Fk_PIDTL_ID.Text = "";
// Fk_MItem_ID.Text = "";
// PINV_HSNCode.Text = "";
// PINV_QTY.Text = "";
// PINV_QTY_Tolerance_Rate.Text = "";
// PINV_QTY_Tolerance.Text = "";
// PINV_Final_Qty.Text = "";
// PINV_GRN_Qty.Text = "";
// PINV_GRN_Rejected_Qty.Text = "";
// PINV_Blance_Qty.Text = "";
// Qtn_Selected.Text = "";
// PINV_BasicRate.Text = "";
// PINV_NetRate.Text = "";
// PINV_BasicAmt.Text = "";
// PINV_DiscountRate.Text = "";
// PINV_DiscountAmt.Text = "";
// PINV_NetTaxableAmt.Text = "";
// PINV_CGST_ID.Text = "";
// PINV_CGST_Rate.Text = "";
// PINV_CGST_Amt.Text = "";
// PINV_CGST_TaxableAmt.Text = "";
// PINV_SGST_ID.Text = "";
// PINV_SGST_Rate.Text = "";
// PINV_SGST_Amt.Text = "";
// PINV_SGST_TaxableAmt.Text = "";
// PINV_IGST_ID.Text = "";
// PINV_IGST_Rate.Text = "";
// PINV_IGST_Amt.Text = "";
// PINV_IGST_TaxableAmt.Text = "";
// PINV_CESS_ID.Text = "";
// PINV_CESS_Rate.Text = "";
// PINV_CESS_Amt.Text = "";
// PINV_CESS_TaxableAmt.Text = "";
// PINV_OtherTax_ID.Text = "";
// PINV_OtherTax_Rate.Text = "";
// PINV_OtherTax_Amt.Text = "";
// PINV_OtherTax_TaxableAmt.Text = "";
// PINV_TotalTax.Text = "";
// PINV_GrossRateWithTax.Text = "";
// MDBSC_RowStatus.Text = "";
// PINV_ItemRemark_DTL.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";



// ObjAT_PINVDTL.PINVDTL_ID=PINVDTL_ID.Text ;
// ObjAT_PINVDTL.Fk_PINVHDR_ID=Fk_PINVHDR_ID.Text ;
// ObjAT_PINVDTL.Fk_PIHDR_ID=Fk_PIHDR_ID.Text ;
// ObjAT_PINVDTL.Fk_PIDTL_ID=Fk_PIDTL_ID.Text ;
// ObjAT_PINVDTL.Fk_MItem_ID=Fk_MItem_ID.Text ;
// ObjAT_PINVDTL.PINV_HSNCode=PINV_HSNCode.Text ;
// ObjAT_PINVDTL.PINV_QTY=PINV_QTY.Text ;
// ObjAT_PINVDTL.PINV_QTY_Tolerance_Rate=PINV_QTY_Tolerance_Rate.Text ;
// ObjAT_PINVDTL.PINV_QTY_Tolerance=PINV_QTY_Tolerance.Text ;
// ObjAT_PINVDTL.PINV_Final_Qty=PINV_Final_Qty.Text ;
// ObjAT_PINVDTL.PINV_GRN_Qty=PINV_GRN_Qty.Text ;
// ObjAT_PINVDTL.PINV_GRN_Rejected_Qty=PINV_GRN_Rejected_Qty.Text ;
// ObjAT_PINVDTL.PINV_Blance_Qty=PINV_Blance_Qty.Text ;
// ObjAT_PINVDTL.Qtn_Selected=Qtn_Selected.Text ;
// ObjAT_PINVDTL.PINV_BasicRate=PINV_BasicRate.Text ;
// ObjAT_PINVDTL.PINV_NetRate=PINV_NetRate.Text ;
// ObjAT_PINVDTL.PINV_BasicAmt=PINV_BasicAmt.Text ;
// ObjAT_PINVDTL.PINV_DiscountRate=PINV_DiscountRate.Text ;
// ObjAT_PINVDTL.PINV_DiscountAmt=PINV_DiscountAmt.Text ;
// ObjAT_PINVDTL.PINV_NetTaxableAmt=PINV_NetTaxableAmt.Text ;
// ObjAT_PINVDTL.PINV_CGST_ID=PINV_CGST_ID.Text ;
// ObjAT_PINVDTL.PINV_CGST_Rate=PINV_CGST_Rate.Text ;
// ObjAT_PINVDTL.PINV_CGST_Amt=PINV_CGST_Amt.Text ;
// ObjAT_PINVDTL.PINV_CGST_TaxableAmt=PINV_CGST_TaxableAmt.Text ;
// ObjAT_PINVDTL.PINV_SGST_ID=PINV_SGST_ID.Text ;
// ObjAT_PINVDTL.PINV_SGST_Rate=PINV_SGST_Rate.Text ;
// ObjAT_PINVDTL.PINV_SGST_Amt=PINV_SGST_Amt.Text ;
// ObjAT_PINVDTL.PINV_SGST_TaxableAmt=PINV_SGST_TaxableAmt.Text ;
// ObjAT_PINVDTL.PINV_IGST_ID=PINV_IGST_ID.Text ;
// ObjAT_PINVDTL.PINV_IGST_Rate=PINV_IGST_Rate.Text ;
// ObjAT_PINVDTL.PINV_IGST_Amt=PINV_IGST_Amt.Text ;
// ObjAT_PINVDTL.PINV_IGST_TaxableAmt=PINV_IGST_TaxableAmt.Text ;
// ObjAT_PINVDTL.PINV_CESS_ID=PINV_CESS_ID.Text ;
// ObjAT_PINVDTL.PINV_CESS_Rate=PINV_CESS_Rate.Text ;
// ObjAT_PINVDTL.PINV_CESS_Amt=PINV_CESS_Amt.Text ;
// ObjAT_PINVDTL.PINV_CESS_TaxableAmt=PINV_CESS_TaxableAmt.Text ;
// ObjAT_PINVDTL.PINV_OtherTax_ID=PINV_OtherTax_ID.Text ;
// ObjAT_PINVDTL.PINV_OtherTax_Rate=PINV_OtherTax_Rate.Text ;
// ObjAT_PINVDTL.PINV_OtherTax_Amt=PINV_OtherTax_Amt.Text ;
// ObjAT_PINVDTL.PINV_OtherTax_TaxableAmt=PINV_OtherTax_TaxableAmt.Text ;
// ObjAT_PINVDTL.PINV_TotalTax=PINV_TotalTax.Text ;
// ObjAT_PINVDTL.PINV_GrossRateWithTax=PINV_GrossRateWithTax.Text ;
// ObjAT_PINVDTL.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_PINVDTL.PINV_ItemRemark_DTL=PINV_ItemRemark_DTL.Text ;
// ObjAT_PINVDTL.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_PINVDTL.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_PINVDTL.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_PINVDTL.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_PINVDTL.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_PINVDTL.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;



// PINVDTL_ID.Text =  dt.Rows[0]["PINVDTL_ID"].ToString();
// Fk_PINVHDR_ID.Text =  dt.Rows[0]["Fk_PINVHDR_ID"].ToString();
// Fk_PIHDR_ID.Text =  dt.Rows[0]["Fk_PIHDR_ID"].ToString();
// Fk_PIDTL_ID.Text =  dt.Rows[0]["Fk_PIDTL_ID"].ToString();
// Fk_MItem_ID.Text =  dt.Rows[0]["Fk_MItem_ID"].ToString();
// PINV_HSNCode.Text =  dt.Rows[0]["PINV_HSNCode"].ToString();
// PINV_QTY.Text =  dt.Rows[0]["PINV_QTY"].ToString();
// PINV_QTY_Tolerance_Rate.Text =  dt.Rows[0]["PINV_QTY_Tolerance_Rate"].ToString();
// PINV_QTY_Tolerance.Text =  dt.Rows[0]["PINV_QTY_Tolerance"].ToString();
// PINV_Final_Qty.Text =  dt.Rows[0]["PINV_Final_Qty"].ToString();
// PINV_GRN_Qty.Text =  dt.Rows[0]["PINV_GRN_Qty"].ToString();
// PINV_GRN_Rejected_Qty.Text =  dt.Rows[0]["PINV_GRN_Rejected_Qty"].ToString();
// PINV_Blance_Qty.Text =  dt.Rows[0]["PINV_Blance_Qty"].ToString();
// Qtn_Selected.Text =  dt.Rows[0]["Qtn_Selected"].ToString();
// PINV_BasicRate.Text =  dt.Rows[0]["PINV_BasicRate"].ToString();
// PINV_NetRate.Text =  dt.Rows[0]["PINV_NetRate"].ToString();
// PINV_BasicAmt.Text =  dt.Rows[0]["PINV_BasicAmt"].ToString();
// PINV_DiscountRate.Text =  dt.Rows[0]["PINV_DiscountRate"].ToString();
// PINV_DiscountAmt.Text =  dt.Rows[0]["PINV_DiscountAmt"].ToString();
// PINV_NetTaxableAmt.Text =  dt.Rows[0]["PINV_NetTaxableAmt"].ToString();
// PINV_CGST_ID.Text =  dt.Rows[0]["PINV_CGST_ID"].ToString();
// PINV_CGST_Rate.Text =  dt.Rows[0]["PINV_CGST_Rate"].ToString();
// PINV_CGST_Amt.Text =  dt.Rows[0]["PINV_CGST_Amt"].ToString();
// PINV_CGST_TaxableAmt.Text =  dt.Rows[0]["PINV_CGST_TaxableAmt"].ToString();
// PINV_SGST_ID.Text =  dt.Rows[0]["PINV_SGST_ID"].ToString();
// PINV_SGST_Rate.Text =  dt.Rows[0]["PINV_SGST_Rate"].ToString();
// PINV_SGST_Amt.Text =  dt.Rows[0]["PINV_SGST_Amt"].ToString();
// PINV_SGST_TaxableAmt.Text =  dt.Rows[0]["PINV_SGST_TaxableAmt"].ToString();
// PINV_IGST_ID.Text =  dt.Rows[0]["PINV_IGST_ID"].ToString();
// PINV_IGST_Rate.Text =  dt.Rows[0]["PINV_IGST_Rate"].ToString();
// PINV_IGST_Amt.Text =  dt.Rows[0]["PINV_IGST_Amt"].ToString();
// PINV_IGST_TaxableAmt.Text =  dt.Rows[0]["PINV_IGST_TaxableAmt"].ToString();
// PINV_CESS_ID.Text =  dt.Rows[0]["PINV_CESS_ID"].ToString();
// PINV_CESS_Rate.Text =  dt.Rows[0]["PINV_CESS_Rate"].ToString();
// PINV_CESS_Amt.Text =  dt.Rows[0]["PINV_CESS_Amt"].ToString();
// PINV_CESS_TaxableAmt.Text =  dt.Rows[0]["PINV_CESS_TaxableAmt"].ToString();
// PINV_OtherTax_ID.Text =  dt.Rows[0]["PINV_OtherTax_ID"].ToString();
// PINV_OtherTax_Rate.Text =  dt.Rows[0]["PINV_OtherTax_Rate"].ToString();
// PINV_OtherTax_Amt.Text =  dt.Rows[0]["PINV_OtherTax_Amt"].ToString();
// PINV_OtherTax_TaxableAmt.Text =  dt.Rows[0]["PINV_OtherTax_TaxableAmt"].ToString();
// PINV_TotalTax.Text =  dt.Rows[0]["PINV_TotalTax"].ToString();
// PINV_GrossRateWithTax.Text =  dt.Rows[0]["PINV_GrossRateWithTax"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// PINV_ItemRemark_DTL.Text =  dt.Rows[0]["PINV_ItemRemark_DTL"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
