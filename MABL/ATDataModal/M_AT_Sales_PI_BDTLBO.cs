using System;
using System.Collections;
using System.Data;
using   MaheshAF18.DataAccess;
namespace MABL.ATDataModal 
{
public class M_AT_Sales_PI_BDTLBO
{
MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
#region Constructor 
public M_AT_Sales_PI_BDTLBO() { }
#endregion 
#region Standard Property
private string _PrimaryKeyName = "SPIDTL_ID";
private string _TableName = "M_AT_Sales_PI_BDTL";
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

private Int64 _SPIDTL_ID;
private Int64 _Fk_SPIHDR_ID;
private Int64 _Fk_DCHDR_ID;
private Int64 _Fk_DCDTL_ID;
private Int64 _Fk_MItem_ID;
private String _SPI_HSNCode;
private Decimal _SPI_QTY;
private Decimal _SPI_QTY_Tolerance_Rate;
private Decimal _SPI_QTY_Tolerance;
private Decimal _SPI_Final_Qty;
private Decimal _SPI_GRN_Qty;
private Decimal _SPI_GRN_Rejected_Qty;
private Decimal _SPI_Blance_Qty;
private String _Qtn_Selected;
private Decimal _SPI_BasicRate;
private Decimal _SPI_NetRate;
private Decimal _SPI_BasicAmt;
private Decimal _SPI_DiscountRate;
private Decimal _SPI_DiscountAmt;
private Decimal _SPI_NetTaxableAmt;
private Int16 _SPI_GST_TaxRate_ID;
private Decimal _SPI_GST_TaxRate;
private Int16 _SPI_CGST_ID;
private Decimal _SPI_CGST_Rate;
private Decimal _SPI_CGST_Amt;
private Decimal _SPI_CGST_TaxableAmt;
private Int16 _SPI_SGST_ID;
private Decimal _SPI_SGST_Rate;
private Decimal _SPI_SGST_Amt;
private Decimal _SPI_SGST_TaxableAmt;
private Int16 _SPI_IGST_ID;
private Decimal _SPI_IGST_Rate;
private Decimal _SPI_IGST_Amt;
private Decimal _SPI_IGST_TaxableAmt;
private Int16 _SPI_CESS_ID;
private Decimal _SPI_CESS_Rate;
private Decimal _SPI_CESS_Amt;
private Decimal _SPI_CESS_TaxableAmt;
private Int16 _SPI_OtherTax_ID;
private Decimal _SPI_OtherTax_Rate;
private Decimal _SPI_OtherTax_Amt;
private Decimal _SPI_OtherTax_TaxableAmt;
private Decimal _SPI_TotalTax;
private Decimal _SPI_GrossRateWithTax;
private String _MDBSC_RowStatus;
private String _SPI_ItemRemark_DTL;
private Int16 _MDBSC_RowCreatedByUser_ID;
private String _MDBSC_RowCreatedByUserName;
private String _MDBSC_RowCreatedOn_DT;
private Int16 _MDBSC_RowLupdnByUser_ID;
private String _MDBSC_RowLupdnUserName;
private String _MDBSC_RowLupdnOn_DT;

public Int64 SPIDTL_ID
{
get
  {
   return this._SPIDTL_ID;  }
set
   {
     this._SPIDTL_ID = value;
     _UpdateFieldName.Add("SPIDTL_ID");
     }
}
public Int64 Fk_SPIHDR_ID
{
get
  {
   return this._Fk_SPIHDR_ID;  }
set
   {
     this._Fk_SPIHDR_ID = value;
     _UpdateFieldName.Add("Fk_SPIHDR_ID");
     }
}
public Int64 Fk_DCHDR_ID
{
get
  {
   return this._Fk_DCHDR_ID;  }
set
   {
     this._Fk_DCHDR_ID = value;
     _UpdateFieldName.Add("Fk_DCHDR_ID");
     }
}
public Int64 Fk_DCDTL_ID
{
get
  {
   return this._Fk_DCDTL_ID;  }
set
   {
     this._Fk_DCDTL_ID = value;
     _UpdateFieldName.Add("Fk_DCDTL_ID");
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
public String SPI_HSNCode
{
get
  {
   return this._SPI_HSNCode;  }
set
   {
     this._SPI_HSNCode = value;
     _UpdateFieldName.Add("SPI_HSNCode");
     }
}
public Decimal SPI_QTY
{
get
  {
   return this._SPI_QTY;  }
set
   {
     this._SPI_QTY = value;
     _UpdateFieldName.Add("SPI_QTY");
     }
}
public Decimal SPI_QTY_Tolerance_Rate
{
get
  {
   return this._SPI_QTY_Tolerance_Rate;  }
set
   {
     this._SPI_QTY_Tolerance_Rate = value;
     _UpdateFieldName.Add("SPI_QTY_Tolerance_Rate");
     }
}
public Decimal SPI_QTY_Tolerance
{
get
  {
   return this._SPI_QTY_Tolerance;  }
set
   {
     this._SPI_QTY_Tolerance = value;
     _UpdateFieldName.Add("SPI_QTY_Tolerance");
     }
}
public Decimal SPI_Final_Qty
{
get
  {
   return this._SPI_Final_Qty;  }
set
   {
     this._SPI_Final_Qty = value;
     _UpdateFieldName.Add("SPI_Final_Qty");
     }
}
public Decimal SPI_GRN_Qty
{
get
  {
   return this._SPI_GRN_Qty;  }
set
   {
     this._SPI_GRN_Qty = value;
     _UpdateFieldName.Add("SPI_GRN_Qty");
     }
}
public Decimal SPI_GRN_Rejected_Qty
{
get
  {
   return this._SPI_GRN_Rejected_Qty;  }
set
   {
     this._SPI_GRN_Rejected_Qty = value;
     _UpdateFieldName.Add("SPI_GRN_Rejected_Qty");
     }
}
public Decimal SPI_Blance_Qty
{
get
  {
   return this._SPI_Blance_Qty;  }
set
   {
     this._SPI_Blance_Qty = value;
     _UpdateFieldName.Add("SPI_Blance_Qty");
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
public Decimal SPI_BasicRate
{
get
  {
   return this._SPI_BasicRate;  }
set
   {
     this._SPI_BasicRate = value;
     _UpdateFieldName.Add("SPI_BasicRate");
     }
}
public Decimal SPI_NetRate
{
get
  {
   return this._SPI_NetRate;  }
set
   {
     this._SPI_NetRate = value;
     _UpdateFieldName.Add("SPI_NetRate");
     }
}
public Decimal SPI_BasicAmt
{
get
  {
   return this._SPI_BasicAmt;  }
set
   {
     this._SPI_BasicAmt = value;
     _UpdateFieldName.Add("SPI_BasicAmt");
     }
}
public Decimal SPI_DiscountRate
{
get
  {
   return this._SPI_DiscountRate;  }
set
   {
     this._SPI_DiscountRate = value;
     _UpdateFieldName.Add("SPI_DiscountRate");
     }
}
public Decimal SPI_DiscountAmt
{
get
  {
   return this._SPI_DiscountAmt;  }
set
   {
     this._SPI_DiscountAmt = value;
     _UpdateFieldName.Add("SPI_DiscountAmt");
     }
}
public Decimal SPI_NetTaxableAmt
{
get
  {
   return this._SPI_NetTaxableAmt;  }
set
   {
     this._SPI_NetTaxableAmt = value;
     _UpdateFieldName.Add("SPI_NetTaxableAmt");
     }
}
public Int16 SPI_GST_TaxRate_ID
{
get
  {
   return this._SPI_GST_TaxRate_ID;  }
set
   {
     this._SPI_GST_TaxRate_ID = value;
     _UpdateFieldName.Add("SPI_GST_TaxRate_ID");
     }
}
public Decimal SPI_GST_TaxRate
{
get
  {
   return this._SPI_GST_TaxRate;  }
set
   {
     this._SPI_GST_TaxRate = value;
     _UpdateFieldName.Add("SPI_GST_TaxRate");
     }
}
public Int16 SPI_CGST_ID
{
get
  {
   return this._SPI_CGST_ID;  }
set
   {
     this._SPI_CGST_ID = value;
     _UpdateFieldName.Add("SPI_CGST_ID");
     }
}
public Decimal SPI_CGST_Rate
{
get
  {
   return this._SPI_CGST_Rate;  }
set
   {
     this._SPI_CGST_Rate = value;
     _UpdateFieldName.Add("SPI_CGST_Rate");
     }
}
public Decimal SPI_CGST_Amt
{
get
  {
   return this._SPI_CGST_Amt;  }
set
   {
     this._SPI_CGST_Amt = value;
     _UpdateFieldName.Add("SPI_CGST_Amt");
     }
}
public Decimal SPI_CGST_TaxableAmt
{
get
  {
   return this._SPI_CGST_TaxableAmt;  }
set
   {
     this._SPI_CGST_TaxableAmt = value;
     _UpdateFieldName.Add("SPI_CGST_TaxableAmt");
     }
}
public Int16 SPI_SGST_ID
{
get
  {
   return this._SPI_SGST_ID;  }
set
   {
     this._SPI_SGST_ID = value;
     _UpdateFieldName.Add("SPI_SGST_ID");
     }
}
public Decimal SPI_SGST_Rate
{
get
  {
   return this._SPI_SGST_Rate;  }
set
   {
     this._SPI_SGST_Rate = value;
     _UpdateFieldName.Add("SPI_SGST_Rate");
     }
}
public Decimal SPI_SGST_Amt
{
get
  {
   return this._SPI_SGST_Amt;  }
set
   {
     this._SPI_SGST_Amt = value;
     _UpdateFieldName.Add("SPI_SGST_Amt");
     }
}
public Decimal SPI_SGST_TaxableAmt
{
get
  {
   return this._SPI_SGST_TaxableAmt;  }
set
   {
     this._SPI_SGST_TaxableAmt = value;
     _UpdateFieldName.Add("SPI_SGST_TaxableAmt");
     }
}
public Int16 SPI_IGST_ID
{
get
  {
   return this._SPI_IGST_ID;  }
set
   {
     this._SPI_IGST_ID = value;
     _UpdateFieldName.Add("SPI_IGST_ID");
     }
}
public Decimal SPI_IGST_Rate
{
get
  {
   return this._SPI_IGST_Rate;  }
set
   {
     this._SPI_IGST_Rate = value;
     _UpdateFieldName.Add("SPI_IGST_Rate");
     }
}
public Decimal SPI_IGST_Amt
{
get
  {
   return this._SPI_IGST_Amt;  }
set
   {
     this._SPI_IGST_Amt = value;
     _UpdateFieldName.Add("SPI_IGST_Amt");
     }
}
public Decimal SPI_IGST_TaxableAmt
{
get
  {
   return this._SPI_IGST_TaxableAmt;  }
set
   {
     this._SPI_IGST_TaxableAmt = value;
     _UpdateFieldName.Add("SPI_IGST_TaxableAmt");
     }
}
public Int16 SPI_CESS_ID
{
get
  {
   return this._SPI_CESS_ID;  }
set
   {
     this._SPI_CESS_ID = value;
     _UpdateFieldName.Add("SPI_CESS_ID");
     }
}
public Decimal SPI_CESS_Rate
{
get
  {
   return this._SPI_CESS_Rate;  }
set
   {
     this._SPI_CESS_Rate = value;
     _UpdateFieldName.Add("SPI_CESS_Rate");
     }
}
public Decimal SPI_CESS_Amt
{
get
  {
   return this._SPI_CESS_Amt;  }
set
   {
     this._SPI_CESS_Amt = value;
     _UpdateFieldName.Add("SPI_CESS_Amt");
     }
}
public Decimal SPI_CESS_TaxableAmt
{
get
  {
   return this._SPI_CESS_TaxableAmt;  }
set
   {
     this._SPI_CESS_TaxableAmt = value;
     _UpdateFieldName.Add("SPI_CESS_TaxableAmt");
     }
}
public Int16 SPI_OtherTax_ID
{
get
  {
   return this._SPI_OtherTax_ID;  }
set
   {
     this._SPI_OtherTax_ID = value;
     _UpdateFieldName.Add("SPI_OtherTax_ID");
     }
}
public Decimal SPI_OtherTax_Rate
{
get
  {
   return this._SPI_OtherTax_Rate;  }
set
   {
     this._SPI_OtherTax_Rate = value;
     _UpdateFieldName.Add("SPI_OtherTax_Rate");
     }
}
public Decimal SPI_OtherTax_Amt
{
get
  {
   return this._SPI_OtherTax_Amt;  }
set
   {
     this._SPI_OtherTax_Amt = value;
     _UpdateFieldName.Add("SPI_OtherTax_Amt");
     }
}
public Decimal SPI_OtherTax_TaxableAmt
{
get
  {
   return this._SPI_OtherTax_TaxableAmt;  }
set
   {
     this._SPI_OtherTax_TaxableAmt = value;
     _UpdateFieldName.Add("SPI_OtherTax_TaxableAmt");
     }
}
public Decimal SPI_TotalTax
{
get
  {
   return this._SPI_TotalTax;  }
set
   {
     this._SPI_TotalTax = value;
     _UpdateFieldName.Add("SPI_TotalTax");
     }
}
public Decimal SPI_GrossRateWithTax
{
get
  {
   return this._SPI_GrossRateWithTax;  }
set
   {
     this._SPI_GrossRateWithTax = value;
     _UpdateFieldName.Add("SPI_GrossRateWithTax");
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
public String SPI_ItemRemark_DTL
{
get
  {
   return this._SPI_ItemRemark_DTL;  }
set
   {
     this._SPI_ItemRemark_DTL = value;
     _UpdateFieldName.Add("SPI_ItemRemark_DTL");
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
public string Insert_Update(M_AT_Sales_PI_BDTLBO sObject)
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

// ObjAT_SPIDTL.SPIDTL_ID=ObjAT_SPIDTL.SPIDTL_ID;
// ObjAT_SPIDTL.Fk_SPIHDR_ID=ObjAT_SPIDTL.Fk_SPIHDR_ID;
// ObjAT_SPIDTL.Fk_DCHDR_ID=ObjAT_SPIDTL.Fk_DCHDR_ID;
// ObjAT_SPIDTL.Fk_DCDTL_ID=ObjAT_SPIDTL.Fk_DCDTL_ID;
// ObjAT_SPIDTL.Fk_MItem_ID=ObjAT_SPIDTL.Fk_MItem_ID;
// ObjAT_SPIDTL.SPI_HSNCode=ObjAT_SPIDTL.SPI_HSNCode;
// ObjAT_SPIDTL.SPI_QTY=ObjAT_SPIDTL.SPI_QTY;
// ObjAT_SPIDTL.SPI_QTY_Tolerance_Rate=ObjAT_SPIDTL.SPI_QTY_Tolerance_Rate;
// ObjAT_SPIDTL.SPI_QTY_Tolerance=ObjAT_SPIDTL.SPI_QTY_Tolerance;
// ObjAT_SPIDTL.SPI_Final_Qty=ObjAT_SPIDTL.SPI_Final_Qty;
// ObjAT_SPIDTL.SPI_GRN_Qty=ObjAT_SPIDTL.SPI_GRN_Qty;
// ObjAT_SPIDTL.SPI_GRN_Rejected_Qty=ObjAT_SPIDTL.SPI_GRN_Rejected_Qty;
// ObjAT_SPIDTL.SPI_Blance_Qty=ObjAT_SPIDTL.SPI_Blance_Qty;
// ObjAT_SPIDTL.Qtn_Selected=ObjAT_SPIDTL.Qtn_Selected;
// ObjAT_SPIDTL.SPI_BasicRate=ObjAT_SPIDTL.SPI_BasicRate;
// ObjAT_SPIDTL.SPI_NetRate=ObjAT_SPIDTL.SPI_NetRate;
// ObjAT_SPIDTL.SPI_BasicAmt=ObjAT_SPIDTL.SPI_BasicAmt;
// ObjAT_SPIDTL.SPI_DiscountRate=ObjAT_SPIDTL.SPI_DiscountRate;
// ObjAT_SPIDTL.SPI_DiscountAmt=ObjAT_SPIDTL.SPI_DiscountAmt;
// ObjAT_SPIDTL.SPI_NetTaxableAmt=ObjAT_SPIDTL.SPI_NetTaxableAmt;
// ObjAT_SPIDTL.SPI_GST_TaxRate_ID=ObjAT_SPIDTL.SPI_GST_TaxRate_ID;
// ObjAT_SPIDTL.SPI_GST_TaxRate=ObjAT_SPIDTL.SPI_GST_TaxRate;
// ObjAT_SPIDTL.SPI_CGST_ID=ObjAT_SPIDTL.SPI_CGST_ID;
// ObjAT_SPIDTL.SPI_CGST_Rate=ObjAT_SPIDTL.SPI_CGST_Rate;
// ObjAT_SPIDTL.SPI_CGST_Amt=ObjAT_SPIDTL.SPI_CGST_Amt;
// ObjAT_SPIDTL.SPI_CGST_TaxableAmt=ObjAT_SPIDTL.SPI_CGST_TaxableAmt;
// ObjAT_SPIDTL.SPI_SGST_ID=ObjAT_SPIDTL.SPI_SGST_ID;
// ObjAT_SPIDTL.SPI_SGST_Rate=ObjAT_SPIDTL.SPI_SGST_Rate;
// ObjAT_SPIDTL.SPI_SGST_Amt=ObjAT_SPIDTL.SPI_SGST_Amt;
// ObjAT_SPIDTL.SPI_SGST_TaxableAmt=ObjAT_SPIDTL.SPI_SGST_TaxableAmt;
// ObjAT_SPIDTL.SPI_IGST_ID=ObjAT_SPIDTL.SPI_IGST_ID;
// ObjAT_SPIDTL.SPI_IGST_Rate=ObjAT_SPIDTL.SPI_IGST_Rate;
// ObjAT_SPIDTL.SPI_IGST_Amt=ObjAT_SPIDTL.SPI_IGST_Amt;
// ObjAT_SPIDTL.SPI_IGST_TaxableAmt=ObjAT_SPIDTL.SPI_IGST_TaxableAmt;
// ObjAT_SPIDTL.SPI_CESS_ID=ObjAT_SPIDTL.SPI_CESS_ID;
// ObjAT_SPIDTL.SPI_CESS_Rate=ObjAT_SPIDTL.SPI_CESS_Rate;
// ObjAT_SPIDTL.SPI_CESS_Amt=ObjAT_SPIDTL.SPI_CESS_Amt;
// ObjAT_SPIDTL.SPI_CESS_TaxableAmt=ObjAT_SPIDTL.SPI_CESS_TaxableAmt;
// ObjAT_SPIDTL.SPI_OtherTax_ID=ObjAT_SPIDTL.SPI_OtherTax_ID;
// ObjAT_SPIDTL.SPI_OtherTax_Rate=ObjAT_SPIDTL.SPI_OtherTax_Rate;
// ObjAT_SPIDTL.SPI_OtherTax_Amt=ObjAT_SPIDTL.SPI_OtherTax_Amt;
// ObjAT_SPIDTL.SPI_OtherTax_TaxableAmt=ObjAT_SPIDTL.SPI_OtherTax_TaxableAmt;
// ObjAT_SPIDTL.SPI_TotalTax=ObjAT_SPIDTL.SPI_TotalTax;
// ObjAT_SPIDTL.SPI_GrossRateWithTax=ObjAT_SPIDTL.SPI_GrossRateWithTax;
// ObjAT_SPIDTL.MDBSC_RowStatus=ObjAT_SPIDTL.MDBSC_RowStatus;
// ObjAT_SPIDTL.SPI_ItemRemark_DTL=ObjAT_SPIDTL.SPI_ItemRemark_DTL;
// ObjAT_SPIDTL.MDBSC_RowCreatedByUser_ID=ObjAT_SPIDTL.MDBSC_RowCreatedByUser_ID;
// ObjAT_SPIDTL.MDBSC_RowCreatedByUserName=ObjAT_SPIDTL.MDBSC_RowCreatedByUserName;
// ObjAT_SPIDTL.MDBSC_RowCreatedOn_DT=ObjAT_SPIDTL.MDBSC_RowCreatedOn_DT;
// ObjAT_SPIDTL.MDBSC_RowLupdnByUser_ID=ObjAT_SPIDTL.MDBSC_RowLupdnByUser_ID;
// ObjAT_SPIDTL.MDBSC_RowLupdnUserName=ObjAT_SPIDTL.MDBSC_RowLupdnUserName;
// ObjAT_SPIDTL.MDBSC_RowLupdnOn_DT=ObjAT_SPIDTL.MDBSC_RowLupdnOn_DT;



// SPIDTL_ID.Text = "";
// Fk_SPIHDR_ID.Text = "";
// Fk_DCHDR_ID.Text = "";
// Fk_DCDTL_ID.Text = "";
// Fk_MItem_ID.Text = "";
// SPI_HSNCode.Text = "";
// SPI_QTY.Text = "";
// SPI_QTY_Tolerance_Rate.Text = "";
// SPI_QTY_Tolerance.Text = "";
// SPI_Final_Qty.Text = "";
// SPI_GRN_Qty.Text = "";
// SPI_GRN_Rejected_Qty.Text = "";
// SPI_Blance_Qty.Text = "";
// Qtn_Selected.Text = "";
// SPI_BasicRate.Text = "";
// SPI_NetRate.Text = "";
// SPI_BasicAmt.Text = "";
// SPI_DiscountRate.Text = "";
// SPI_DiscountAmt.Text = "";
// SPI_NetTaxableAmt.Text = "";
// SPI_GST_TaxRate_ID.Text = "";
// SPI_GST_TaxRate.Text = "";
// SPI_CGST_ID.Text = "";
// SPI_CGST_Rate.Text = "";
// SPI_CGST_Amt.Text = "";
// SPI_CGST_TaxableAmt.Text = "";
// SPI_SGST_ID.Text = "";
// SPI_SGST_Rate.Text = "";
// SPI_SGST_Amt.Text = "";
// SPI_SGST_TaxableAmt.Text = "";
// SPI_IGST_ID.Text = "";
// SPI_IGST_Rate.Text = "";
// SPI_IGST_Amt.Text = "";
// SPI_IGST_TaxableAmt.Text = "";
// SPI_CESS_ID.Text = "";
// SPI_CESS_Rate.Text = "";
// SPI_CESS_Amt.Text = "";
// SPI_CESS_TaxableAmt.Text = "";
// SPI_OtherTax_ID.Text = "";
// SPI_OtherTax_Rate.Text = "";
// SPI_OtherTax_Amt.Text = "";
// SPI_OtherTax_TaxableAmt.Text = "";
// SPI_TotalTax.Text = "";
// SPI_GrossRateWithTax.Text = "";
// MDBSC_RowStatus.Text = "";
// SPI_ItemRemark_DTL.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";



// ObjAT_SPIDTL.SPIDTL_ID=SPIDTL_ID.Text ;
// ObjAT_SPIDTL.Fk_SPIHDR_ID=Fk_SPIHDR_ID.Text ;
// ObjAT_SPIDTL.Fk_DCHDR_ID=Fk_DCHDR_ID.Text ;
// ObjAT_SPIDTL.Fk_DCDTL_ID=Fk_DCDTL_ID.Text ;
// ObjAT_SPIDTL.Fk_MItem_ID=Fk_MItem_ID.Text ;
// ObjAT_SPIDTL.SPI_HSNCode=SPI_HSNCode.Text ;
// ObjAT_SPIDTL.SPI_QTY=SPI_QTY.Text ;
// ObjAT_SPIDTL.SPI_QTY_Tolerance_Rate=SPI_QTY_Tolerance_Rate.Text ;
// ObjAT_SPIDTL.SPI_QTY_Tolerance=SPI_QTY_Tolerance.Text ;
// ObjAT_SPIDTL.SPI_Final_Qty=SPI_Final_Qty.Text ;
// ObjAT_SPIDTL.SPI_GRN_Qty=SPI_GRN_Qty.Text ;
// ObjAT_SPIDTL.SPI_GRN_Rejected_Qty=SPI_GRN_Rejected_Qty.Text ;
// ObjAT_SPIDTL.SPI_Blance_Qty=SPI_Blance_Qty.Text ;
// ObjAT_SPIDTL.Qtn_Selected=Qtn_Selected.Text ;
// ObjAT_SPIDTL.SPI_BasicRate=SPI_BasicRate.Text ;
// ObjAT_SPIDTL.SPI_NetRate=SPI_NetRate.Text ;
// ObjAT_SPIDTL.SPI_BasicAmt=SPI_BasicAmt.Text ;
// ObjAT_SPIDTL.SPI_DiscountRate=SPI_DiscountRate.Text ;
// ObjAT_SPIDTL.SPI_DiscountAmt=SPI_DiscountAmt.Text ;
// ObjAT_SPIDTL.SPI_NetTaxableAmt=SPI_NetTaxableAmt.Text ;
// ObjAT_SPIDTL.SPI_GST_TaxRate_ID=SPI_GST_TaxRate_ID.Text ;
// ObjAT_SPIDTL.SPI_GST_TaxRate=SPI_GST_TaxRate.Text ;
// ObjAT_SPIDTL.SPI_CGST_ID=SPI_CGST_ID.Text ;
// ObjAT_SPIDTL.SPI_CGST_Rate=SPI_CGST_Rate.Text ;
// ObjAT_SPIDTL.SPI_CGST_Amt=SPI_CGST_Amt.Text ;
// ObjAT_SPIDTL.SPI_CGST_TaxableAmt=SPI_CGST_TaxableAmt.Text ;
// ObjAT_SPIDTL.SPI_SGST_ID=SPI_SGST_ID.Text ;
// ObjAT_SPIDTL.SPI_SGST_Rate=SPI_SGST_Rate.Text ;
// ObjAT_SPIDTL.SPI_SGST_Amt=SPI_SGST_Amt.Text ;
// ObjAT_SPIDTL.SPI_SGST_TaxableAmt=SPI_SGST_TaxableAmt.Text ;
// ObjAT_SPIDTL.SPI_IGST_ID=SPI_IGST_ID.Text ;
// ObjAT_SPIDTL.SPI_IGST_Rate=SPI_IGST_Rate.Text ;
// ObjAT_SPIDTL.SPI_IGST_Amt=SPI_IGST_Amt.Text ;
// ObjAT_SPIDTL.SPI_IGST_TaxableAmt=SPI_IGST_TaxableAmt.Text ;
// ObjAT_SPIDTL.SPI_CESS_ID=SPI_CESS_ID.Text ;
// ObjAT_SPIDTL.SPI_CESS_Rate=SPI_CESS_Rate.Text ;
// ObjAT_SPIDTL.SPI_CESS_Amt=SPI_CESS_Amt.Text ;
// ObjAT_SPIDTL.SPI_CESS_TaxableAmt=SPI_CESS_TaxableAmt.Text ;
// ObjAT_SPIDTL.SPI_OtherTax_ID=SPI_OtherTax_ID.Text ;
// ObjAT_SPIDTL.SPI_OtherTax_Rate=SPI_OtherTax_Rate.Text ;
// ObjAT_SPIDTL.SPI_OtherTax_Amt=SPI_OtherTax_Amt.Text ;
// ObjAT_SPIDTL.SPI_OtherTax_TaxableAmt=SPI_OtherTax_TaxableAmt.Text ;
// ObjAT_SPIDTL.SPI_TotalTax=SPI_TotalTax.Text ;
// ObjAT_SPIDTL.SPI_GrossRateWithTax=SPI_GrossRateWithTax.Text ;
// ObjAT_SPIDTL.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_SPIDTL.SPI_ItemRemark_DTL=SPI_ItemRemark_DTL.Text ;
// ObjAT_SPIDTL.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_SPIDTL.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_SPIDTL.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_SPIDTL.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_SPIDTL.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_SPIDTL.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;



// SPIDTL_ID.Text =  dt.Rows[0]["SPIDTL_ID"].ToString();
// Fk_SPIHDR_ID.Text =  dt.Rows[0]["Fk_SPIHDR_ID"].ToString();
// Fk_DCHDR_ID.Text =  dt.Rows[0]["Fk_DCHDR_ID"].ToString();
// Fk_DCDTL_ID.Text =  dt.Rows[0]["Fk_DCDTL_ID"].ToString();
// Fk_MItem_ID.Text =  dt.Rows[0]["Fk_MItem_ID"].ToString();
// SPI_HSNCode.Text =  dt.Rows[0]["SPI_HSNCode"].ToString();
// SPI_QTY.Text =  dt.Rows[0]["SPI_QTY"].ToString();
// SPI_QTY_Tolerance_Rate.Text =  dt.Rows[0]["SPI_QTY_Tolerance_Rate"].ToString();
// SPI_QTY_Tolerance.Text =  dt.Rows[0]["SPI_QTY_Tolerance"].ToString();
// SPI_Final_Qty.Text =  dt.Rows[0]["SPI_Final_Qty"].ToString();
// SPI_GRN_Qty.Text =  dt.Rows[0]["SPI_GRN_Qty"].ToString();
// SPI_GRN_Rejected_Qty.Text =  dt.Rows[0]["SPI_GRN_Rejected_Qty"].ToString();
// SPI_Blance_Qty.Text =  dt.Rows[0]["SPI_Blance_Qty"].ToString();
// Qtn_Selected.Text =  dt.Rows[0]["Qtn_Selected"].ToString();
// SPI_BasicRate.Text =  dt.Rows[0]["SPI_BasicRate"].ToString();
// SPI_NetRate.Text =  dt.Rows[0]["SPI_NetRate"].ToString();
// SPI_BasicAmt.Text =  dt.Rows[0]["SPI_BasicAmt"].ToString();
// SPI_DiscountRate.Text =  dt.Rows[0]["SPI_DiscountRate"].ToString();
// SPI_DiscountAmt.Text =  dt.Rows[0]["SPI_DiscountAmt"].ToString();
// SPI_NetTaxableAmt.Text =  dt.Rows[0]["SPI_NetTaxableAmt"].ToString();
// SPI_GST_TaxRate_ID.Text =  dt.Rows[0]["SPI_GST_TaxRate_ID"].ToString();
// SPI_GST_TaxRate.Text =  dt.Rows[0]["SPI_GST_TaxRate"].ToString();
// SPI_CGST_ID.Text =  dt.Rows[0]["SPI_CGST_ID"].ToString();
// SPI_CGST_Rate.Text =  dt.Rows[0]["SPI_CGST_Rate"].ToString();
// SPI_CGST_Amt.Text =  dt.Rows[0]["SPI_CGST_Amt"].ToString();
// SPI_CGST_TaxableAmt.Text =  dt.Rows[0]["SPI_CGST_TaxableAmt"].ToString();
// SPI_SGST_ID.Text =  dt.Rows[0]["SPI_SGST_ID"].ToString();
// SPI_SGST_Rate.Text =  dt.Rows[0]["SPI_SGST_Rate"].ToString();
// SPI_SGST_Amt.Text =  dt.Rows[0]["SPI_SGST_Amt"].ToString();
// SPI_SGST_TaxableAmt.Text =  dt.Rows[0]["SPI_SGST_TaxableAmt"].ToString();
// SPI_IGST_ID.Text =  dt.Rows[0]["SPI_IGST_ID"].ToString();
// SPI_IGST_Rate.Text =  dt.Rows[0]["SPI_IGST_Rate"].ToString();
// SPI_IGST_Amt.Text =  dt.Rows[0]["SPI_IGST_Amt"].ToString();
// SPI_IGST_TaxableAmt.Text =  dt.Rows[0]["SPI_IGST_TaxableAmt"].ToString();
// SPI_CESS_ID.Text =  dt.Rows[0]["SPI_CESS_ID"].ToString();
// SPI_CESS_Rate.Text =  dt.Rows[0]["SPI_CESS_Rate"].ToString();
// SPI_CESS_Amt.Text =  dt.Rows[0]["SPI_CESS_Amt"].ToString();
// SPI_CESS_TaxableAmt.Text =  dt.Rows[0]["SPI_CESS_TaxableAmt"].ToString();
// SPI_OtherTax_ID.Text =  dt.Rows[0]["SPI_OtherTax_ID"].ToString();
// SPI_OtherTax_Rate.Text =  dt.Rows[0]["SPI_OtherTax_Rate"].ToString();
// SPI_OtherTax_Amt.Text =  dt.Rows[0]["SPI_OtherTax_Amt"].ToString();
// SPI_OtherTax_TaxableAmt.Text =  dt.Rows[0]["SPI_OtherTax_TaxableAmt"].ToString();
// SPI_TotalTax.Text =  dt.Rows[0]["SPI_TotalTax"].ToString();
// SPI_GrossRateWithTax.Text =  dt.Rows[0]["SPI_GrossRateWithTax"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// SPI_ItemRemark_DTL.Text =  dt.Rows[0]["SPI_ItemRemark_DTL"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
 