using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal 
{
public class M_AT_Sales_SEWB_AHDRBO
{
    MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
#region Constructor 
public M_AT_Sales_SEWB_AHDRBO() { }
#endregion 
#region Standard Property
private string _PrimaryKeyName = "SEWB_HDR_ID";
private string _TableName = "M_AT_Sales_SEWB_AHDR";
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

private Int64 _SEWB_HDR_ID;
private Int64 _Fk_SourceTable;
private Int64 _Fk_TrnHDR_ID;
private Int64 _Fk_TrnDTL_ID;
private String _SEWB_Trn_Type;
private String _SEWB_Trn_SubType;
private String _SEWB_Trn_SubDesc;
private String _SEWB_Trn_Doc_Type;
private String _SEWB_Trn_Doc_No;
private String _SEWB_Trn_Doc_Date;
private String _SEWB_Supplier_GSTIN;
private String _SEWB_Supplier_Name;
private String _SEWB_Supplier_Add1;
private String _SEWB_Supplier_Add2;
private String _SEWB_Supplier_Add3;
private String _SEWB_Supplier_Pincode;
private String _SEWB_Supplier_Place;
private String _SEWB_Supplier_State;
private String _SEWB_Supplier_POS;
private String _SEWB_Recipient_GSTIN;
private String _SEWB_Recipient_Name;
private String _SEWB_Recipient_Add1;
private String _SEWB_Recipient_Add2;
private String _SEWB_Recipient_Add3;
private String _SEWB_Recipient_Pincode;
private String _SEWB_Recipient_Place;
private String _SEWB_Recipient_State;
private String _SEWB_Recipient_POS;
private String _SEWB_Trans_Mode;
private String _SEWB_Distance;
private String _SEWB_TranspoterNo;
private String _SEWB_TranspoterName;
private String _SEWB_TranspoterDOC_No;
private String _SEWB_Transpoter_DOC_DT;
private Int64 _SEWB_Vechile_CNT;
private Int64 _SEWB_Item_CNT;
private Decimal _SEWB_HDR_Gross_Amt;
private Decimal _SEWB_HDR_Discount_Amt;
private Decimal _SEWB_HDR_Taxable_Amt;
private Decimal _SEWB_HDR_CGST_Amt;
private Decimal _SEWB_HDR_SGST_Amt;
private Decimal _SEWB_HDR_IGST_Amt;
private Decimal _SEWB_HDR_CESS_Amt;
private String _MDBSC_RowStatus;
private Int16 _MDBSC_RowCreatedByUser_ID;
private String _MDBSC_RowCreatedByUserName;
private String _MDBSC_RowCreatedOn_DT;
private Int16 _MDBSC_RowLupdnByUser_ID;
private String _MDBSC_RowLupdnUserName;
private String _MDBSC_RowLupdnOn_DT;
private string _SINV_No;

public Int64 SEWB_HDR_ID
{
get
  {
   return this._SEWB_HDR_ID;  }
set
   {
     this._SEWB_HDR_ID = value;
     _UpdateFieldName.Add("SEWB_HDR_ID");
     }
}
public Int64 Fk_SourceTable
{
get
  {
   return this._Fk_SourceTable;  }
set
   {
     this._Fk_SourceTable = value;
     _UpdateFieldName.Add("Fk_SourceTable");
     }
}
public Int64 Fk_TrnHDR_ID
{
get
  {
   return this._Fk_TrnHDR_ID;  }
set
   {
     this._Fk_TrnHDR_ID = value;
     _UpdateFieldName.Add("Fk_TrnHDR_ID");
     }
}
public Int64 Fk_TrnDTL_ID
{
get
  {
   return this._Fk_TrnDTL_ID;  }
set
   {
     this._Fk_TrnDTL_ID = value;
     _UpdateFieldName.Add("Fk_TrnDTL_ID");
     }
}
public String SEWB_Trn_Type
{
get
  {
   return this._SEWB_Trn_Type;  }
set
   {
     this._SEWB_Trn_Type = value;
     _UpdateFieldName.Add("SEWB_Trn_Type");
     }
}
public String SEWB_Trn_SubType
{
get
  {
   return this._SEWB_Trn_SubType;  }
set
   {
     this._SEWB_Trn_SubType = value;
     _UpdateFieldName.Add("SEWB_Trn_SubType");
     }
}
public String SEWB_Trn_SubDesc
{
get
  {
   return this._SEWB_Trn_SubDesc;  }
set
   {
     this._SEWB_Trn_SubDesc = value;
     _UpdateFieldName.Add("SEWB_Trn_SubDesc");
     }
}
public String SEWB_Trn_Doc_Type
{
get
  {
   return this._SEWB_Trn_Doc_Type;  }
set
   {
     this._SEWB_Trn_Doc_Type = value;
     _UpdateFieldName.Add("SEWB_Trn_Doc_Type");
     }
}
public String SEWB_Trn_Doc_No
{
get
  {
   return this._SEWB_Trn_Doc_No;  }
set
   {
     this._SEWB_Trn_Doc_No = value;
     _UpdateFieldName.Add("SEWB_Trn_Doc_No");
     }
}
public String SEWB_Trn_Doc_Date
{
get
  {
   return this._SEWB_Trn_Doc_Date;  }
set
   {
     this._SEWB_Trn_Doc_Date = value;
     _UpdateFieldName.Add("SEWB_Trn_Doc_Date");
     }
}
public String SEWB_Supplier_GSTIN
{
get
  {
   return this._SEWB_Supplier_GSTIN;  }
set
   {
     this._SEWB_Supplier_GSTIN = value;
     _UpdateFieldName.Add("SEWB_Supplier_GSTIN");
     }
}
public String SEWB_Supplier_Name
{
get
  {
   return this._SEWB_Supplier_Name;  }
set
   {
     this._SEWB_Supplier_Name = value;
     _UpdateFieldName.Add("SEWB_Supplier_Name");
     }
}
public String SEWB_Supplier_Add1
{
get
  {
   return this._SEWB_Supplier_Add1;  }
set
   {
     this._SEWB_Supplier_Add1 = value;
     _UpdateFieldName.Add("SEWB_Supplier_Add1");
     }
}
public String SEWB_Supplier_Add2
{
get
  {
   return this._SEWB_Supplier_Add2;  }
set
   {
     this._SEWB_Supplier_Add2 = value;
     _UpdateFieldName.Add("SEWB_Supplier_Add2");
     }
}
public String SEWB_Supplier_Add3
{
get
  {
   return this._SEWB_Supplier_Add3;  }
set
   {
     this._SEWB_Supplier_Add3 = value;
     _UpdateFieldName.Add("SEWB_Supplier_Add3");
     }
}
public String SEWB_Supplier_Pincode
{
get
  {
   return this._SEWB_Supplier_Pincode;  }
set
   {
     this._SEWB_Supplier_Pincode = value;
     _UpdateFieldName.Add("SEWB_Supplier_Pincode");
     }
}
public String SEWB_Supplier_Place
{
get
  {
   return this._SEWB_Supplier_Place;  }
set
   {
     this._SEWB_Supplier_Place = value;
     _UpdateFieldName.Add("SEWB_Supplier_Place");
     }
}
public String SEWB_Supplier_State
{
get
  {
   return this._SEWB_Supplier_State;  }
set
   {
     this._SEWB_Supplier_State = value;
     _UpdateFieldName.Add("SEWB_Supplier_State");
     }
}
public String SEWB_Supplier_POS
{
get
  {
   return this._SEWB_Supplier_POS;  }
set
   {
     this._SEWB_Supplier_POS = value;
     _UpdateFieldName.Add("SEWB_Supplier_POS");
     }
}
public String SEWB_Recipient_GSTIN
{
get
  {
   return this._SEWB_Recipient_GSTIN;  }
set
   {
     this._SEWB_Recipient_GSTIN = value;
     _UpdateFieldName.Add("SEWB_Recipient_GSTIN");
     }
}
public String SEWB_Recipient_Name
{
get
  {
   return this._SEWB_Recipient_Name;  }
set
   {
     this._SEWB_Recipient_Name = value;
     _UpdateFieldName.Add("SEWB_Recipient_Name");
     }
}
public String SEWB_Recipient_Add1
{
get
  {
   return this._SEWB_Recipient_Add1;  }
set
   {
     this._SEWB_Recipient_Add1 = value;
     _UpdateFieldName.Add("SEWB_Recipient_Add1");
     }
}
public String SEWB_Recipient_Add2
{
get
  {
   return this._SEWB_Recipient_Add2;  }
set
   {
     this._SEWB_Recipient_Add2 = value;
     _UpdateFieldName.Add("SEWB_Recipient_Add2");
     }
}
public String SEWB_Recipient_Add3
{
get
  {
   return this._SEWB_Recipient_Add3;  }
set
   {
     this._SEWB_Recipient_Add3 = value;
     _UpdateFieldName.Add("SEWB_Recipient_Add3");
     }
}
public String SEWB_Recipient_Pincode
{
get
  {
   return this._SEWB_Recipient_Pincode;  }
set
   {
     this._SEWB_Recipient_Pincode = value;
     _UpdateFieldName.Add("SEWB_Recipient_Pincode");
     }
}
public String SEWB_Recipient_Place
{
get
  {
   return this._SEWB_Recipient_Place;  }
set
   {
     this._SEWB_Recipient_Place = value;
     _UpdateFieldName.Add("SEWB_Recipient_Place");
     }
}
public String SEWB_Recipient_State
{
get
  {
   return this._SEWB_Recipient_State;  }
set
   {
     this._SEWB_Recipient_State = value;
     _UpdateFieldName.Add("SEWB_Recipient_State");
     }
}
public String SEWB_Recipient_POS
{
get
  {
   return this._SEWB_Recipient_POS;  }
set
   {
     this._SEWB_Recipient_POS = value;
     _UpdateFieldName.Add("SEWB_Recipient_POS");
     }
}
public String SEWB_Trans_Mode
{
get
  {
   return this._SEWB_Trans_Mode;  }
set
   {
     this._SEWB_Trans_Mode = value;
     _UpdateFieldName.Add("SEWB_Trans_Mode");
     }
}
public String SEWB_Distance
{
get
  {
   return this._SEWB_Distance;  }
set
   {
     this._SEWB_Distance = value;
     _UpdateFieldName.Add("SEWB_Distance");
     }
}
public String SEWB_TranspoterNo
{
get
  {
   return this._SEWB_TranspoterNo;  }
set
   {
     this._SEWB_TranspoterNo = value;
     _UpdateFieldName.Add("SEWB_TranspoterNo");
     }
}
public String SEWB_TranspoterName
{
get
  {
   return this._SEWB_TranspoterName;  }
set
   {
     this._SEWB_TranspoterName = value;
     _UpdateFieldName.Add("SEWB_TranspoterName");
     }
}
public String SEWB_TranspoterDOC_No
{
get
  {
   return this._SEWB_TranspoterDOC_No;  }
set
   {
     this._SEWB_TranspoterDOC_No = value;
     _UpdateFieldName.Add("SEWB_TranspoterDOC_No");
     }
}
public String SEWB_Transpoter_DOC_DT
{
get
  {
   return this._SEWB_Transpoter_DOC_DT;  }
set
   {
     this._SEWB_Transpoter_DOC_DT = value;
     _UpdateFieldName.Add("SEWB_Transpoter_DOC_DT");
     }
}
public Int64 SEWB_Vechile_CNT
{
get
  {
   return this._SEWB_Vechile_CNT;  }
set
   {
     this._SEWB_Vechile_CNT = value;
     _UpdateFieldName.Add("SEWB_Vechile_CNT");
     }
}
public Int64 SEWB_Item_CNT
{
get
  {
   return this._SEWB_Item_CNT;  }
set
   {
     this._SEWB_Item_CNT = value;
     _UpdateFieldName.Add("SEWB_Item_CNT");
     }
}
public Decimal SEWB_HDR_Gross_Amt
{
get
  {
   return this._SEWB_HDR_Gross_Amt;  }
set
   {
     this._SEWB_HDR_Gross_Amt = value;
     _UpdateFieldName.Add("SEWB_HDR_Gross_Amt");
     }
}
public Decimal SEWB_HDR_Discount_Amt
{
get
  {
   return this._SEWB_HDR_Discount_Amt;  }
set
   {
     this._SEWB_HDR_Discount_Amt = value;
     _UpdateFieldName.Add("SEWB_HDR_Discount_Amt");
     }
}
public Decimal SEWB_HDR_Taxable_Amt
{
get
  {
   return this._SEWB_HDR_Taxable_Amt;  }
set
   {
     this._SEWB_HDR_Taxable_Amt = value;
     _UpdateFieldName.Add("SEWB_HDR_Taxable_Amt");
     }
}
public Decimal SEWB_HDR_CGST_Amt
{
get
  {
   return this._SEWB_HDR_CGST_Amt;  }
set
   {
     this._SEWB_HDR_CGST_Amt = value;
     _UpdateFieldName.Add("SEWB_HDR_CGST_Amt");
     }
}
public Decimal SEWB_HDR_SGST_Amt
{
get
  {
   return this._SEWB_HDR_SGST_Amt;  }
set
   {
     this._SEWB_HDR_SGST_Amt = value;
     _UpdateFieldName.Add("SEWB_HDR_SGST_Amt");
     }
}
public Decimal SEWB_HDR_IGST_Amt
{
get
  {
   return this._SEWB_HDR_IGST_Amt;  }
set
   {
     this._SEWB_HDR_IGST_Amt = value;
     _UpdateFieldName.Add("SEWB_HDR_IGST_Amt");
     }
}
public Decimal SEWB_HDR_CESS_Amt
{
get
  {
   return this._SEWB_HDR_CESS_Amt;  }
set
   {
     this._SEWB_HDR_CESS_Amt = value;
     _UpdateFieldName.Add("SEWB_HDR_CESS_Amt");
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


public String SINV_No
{
get
  {
      return this._SINV_No;
  }
set
   {
       this._SINV_No = value;
       _UpdateFieldName.Add("SINV_No");
     }
}
#endregion
#region Genric Methods
public string Insert_Update(M_AT_Sales_SEWB_AHDRBO sObject)
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

// ObjAT_SEWHDR.SEWB_HDR_ID=ObjAT_SEWHDR.SEWB_HDR_ID;
// ObjAT_SEWHDR.Fk_SourceTable=ObjAT_SEWHDR.Fk_SourceTable;
// ObjAT_SEWHDR.Fk_TrnHDR_ID=ObjAT_SEWHDR.Fk_TrnHDR_ID;
// ObjAT_SEWHDR.Fk_TrnDTL_ID=ObjAT_SEWHDR.Fk_TrnDTL_ID;
// ObjAT_SEWHDR.SEWB_Trn_Type=ObjAT_SEWHDR.SEWB_Trn_Type;
// ObjAT_SEWHDR.SEWB_Trn_SubType=ObjAT_SEWHDR.SEWB_Trn_SubType;
// ObjAT_SEWHDR.SEWB_Trn_SubDesc=ObjAT_SEWHDR.SEWB_Trn_SubDesc;
// ObjAT_SEWHDR.SEWB_Trn_Doc_Type=ObjAT_SEWHDR.SEWB_Trn_Doc_Type;
// ObjAT_SEWHDR.SEWB_Trn_Doc_No=ObjAT_SEWHDR.SEWB_Trn_Doc_No;
// ObjAT_SEWHDR.SEWB_Trn_Doc_Date=ObjAT_SEWHDR.SEWB_Trn_Doc_Date;
// ObjAT_SEWHDR.SEWB_Supplier_GSTIN=ObjAT_SEWHDR.SEWB_Supplier_GSTIN;
// ObjAT_SEWHDR.SEWB_Supplier_Name=ObjAT_SEWHDR.SEWB_Supplier_Name;
// ObjAT_SEWHDR.SEWB_Supplier_Add1=ObjAT_SEWHDR.SEWB_Supplier_Add1;
// ObjAT_SEWHDR.SEWB_Supplier_Add2=ObjAT_SEWHDR.SEWB_Supplier_Add2;
// ObjAT_SEWHDR.SEWB_Supplier_Add3=ObjAT_SEWHDR.SEWB_Supplier_Add3;
// ObjAT_SEWHDR.SEWB_Supplier_Pincode=ObjAT_SEWHDR.SEWB_Supplier_Pincode;
// ObjAT_SEWHDR.SEWB_Supplier_Place=ObjAT_SEWHDR.SEWB_Supplier_Place;
// ObjAT_SEWHDR.SEWB_Supplier_State=ObjAT_SEWHDR.SEWB_Supplier_State;
// ObjAT_SEWHDR.SEWB_Supplier_POS=ObjAT_SEWHDR.SEWB_Supplier_POS;
// ObjAT_SEWHDR.SEWB_Recipient_GSTIN=ObjAT_SEWHDR.SEWB_Recipient_GSTIN;
// ObjAT_SEWHDR.SEWB_Recipient_Name=ObjAT_SEWHDR.SEWB_Recipient_Name;
// ObjAT_SEWHDR.SEWB_Recipient_Add1=ObjAT_SEWHDR.SEWB_Recipient_Add1;
// ObjAT_SEWHDR.SEWB_Recipient_Add2=ObjAT_SEWHDR.SEWB_Recipient_Add2;
// ObjAT_SEWHDR.SEWB_Recipient_Add3=ObjAT_SEWHDR.SEWB_Recipient_Add3;
// ObjAT_SEWHDR.SEWB_Recipient_Pincode=ObjAT_SEWHDR.SEWB_Recipient_Pincode;
// ObjAT_SEWHDR.SEWB_Recipient_Place=ObjAT_SEWHDR.SEWB_Recipient_Place;
// ObjAT_SEWHDR.SEWB_Recipient_State=ObjAT_SEWHDR.SEWB_Recipient_State;
// ObjAT_SEWHDR.SEWB_Recipient_POS=ObjAT_SEWHDR.SEWB_Recipient_POS;
// ObjAT_SEWHDR.SEWB_Trans_Mode=ObjAT_SEWHDR.SEWB_Trans_Mode;
// ObjAT_SEWHDR.SEWB_Distance=ObjAT_SEWHDR.SEWB_Distance;
// ObjAT_SEWHDR.SEWB_TranspoterNo=ObjAT_SEWHDR.SEWB_TranspoterNo;
// ObjAT_SEWHDR.SEWB_TranspoterName=ObjAT_SEWHDR.SEWB_TranspoterName;
// ObjAT_SEWHDR.SEWB_TranspoterDOC_No=ObjAT_SEWHDR.SEWB_TranspoterDOC_No;
// ObjAT_SEWHDR.SEWB_Transpoter_DOC_DT=ObjAT_SEWHDR.SEWB_Transpoter_DOC_DT;
// ObjAT_SEWHDR.SEWB_Vechile_CNT=ObjAT_SEWHDR.SEWB_Vechile_CNT;
// ObjAT_SEWHDR.SEWB_Item_CNT=ObjAT_SEWHDR.SEWB_Item_CNT;
// ObjAT_SEWHDR.SEWB_HDR_Gross_Amt=ObjAT_SEWHDR.SEWB_HDR_Gross_Amt;
// ObjAT_SEWHDR.SEWB_HDR_Discount_Amt=ObjAT_SEWHDR.SEWB_HDR_Discount_Amt;
// ObjAT_SEWHDR.SEWB_HDR_Taxable_Amt=ObjAT_SEWHDR.SEWB_HDR_Taxable_Amt;
// ObjAT_SEWHDR.SEWB_HDR_CGST_Amt=ObjAT_SEWHDR.SEWB_HDR_CGST_Amt;
// ObjAT_SEWHDR.SEWB_HDR_SGST_Amt=ObjAT_SEWHDR.SEWB_HDR_SGST_Amt;
// ObjAT_SEWHDR.SEWB_HDR_IGST_Amt=ObjAT_SEWHDR.SEWB_HDR_IGST_Amt;
// ObjAT_SEWHDR.SEWB_HDR_CESS_Amt=ObjAT_SEWHDR.SEWB_HDR_CESS_Amt;
// ObjAT_SEWHDR.MDBSC_RowStatus=ObjAT_SEWHDR.MDBSC_RowStatus;
// ObjAT_SEWHDR.MDBSC_RowCreatedByUser_ID=ObjAT_SEWHDR.MDBSC_RowCreatedByUser_ID;
// ObjAT_SEWHDR.MDBSC_RowCreatedByUserName=ObjAT_SEWHDR.MDBSC_RowCreatedByUserName;
// ObjAT_SEWHDR.MDBSC_RowCreatedOn_DT=ObjAT_SEWHDR.MDBSC_RowCreatedOn_DT;
// ObjAT_SEWHDR.MDBSC_RowLupdnByUser_ID=ObjAT_SEWHDR.MDBSC_RowLupdnByUser_ID;
// ObjAT_SEWHDR.MDBSC_RowLupdnUserName=ObjAT_SEWHDR.MDBSC_RowLupdnUserName;
// ObjAT_SEWHDR.MDBSC_RowLupdnOn_DT=ObjAT_SEWHDR.MDBSC_RowLupdnOn_DT;



// SEWB_HDR_ID.Text = "";
// Fk_SourceTable.Text = "";
// Fk_TrnHDR_ID.Text = "";
// Fk_TrnDTL_ID.Text = "";
// SEWB_Trn_Type.Text = "";
// SEWB_Trn_SubType.Text = "";
// SEWB_Trn_SubDesc.Text = "";
// SEWB_Trn_Doc_Type.Text = "";
// SEWB_Trn_Doc_No.Text = "";
// SEWB_Trn_Doc_Date.Text = "";
// SEWB_Supplier_GSTIN.Text = "";
// SEWB_Supplier_Name.Text = "";
// SEWB_Supplier_Add1.Text = "";
// SEWB_Supplier_Add2.Text = "";
// SEWB_Supplier_Add3.Text = "";
// SEWB_Supplier_Pincode.Text = "";
// SEWB_Supplier_Place.Text = "";
// SEWB_Supplier_State.Text = "";
// SEWB_Supplier_POS.Text = "";
// SEWB_Recipient_GSTIN.Text = "";
// SEWB_Recipient_Name.Text = "";
// SEWB_Recipient_Add1.Text = "";
// SEWB_Recipient_Add2.Text = "";
// SEWB_Recipient_Add3.Text = "";
// SEWB_Recipient_Pincode.Text = "";
// SEWB_Recipient_Place.Text = "";
// SEWB_Recipient_State.Text = "";
// SEWB_Recipient_POS.Text = "";
// SEWB_Trans_Mode.Text = "";
// SEWB_Distance.Text = "";
// SEWB_TranspoterNo.Text = "";
// SEWB_TranspoterName.Text = "";
// SEWB_TranspoterDOC_No.Text = "";
// SEWB_Transpoter_DOC_DT.Text = "";
// SEWB_Vechile_CNT.Text = "";
// SEWB_Item_CNT.Text = "";
// SEWB_HDR_Gross_Amt.Text = "";
// SEWB_HDR_Discount_Amt.Text = "";
// SEWB_HDR_Taxable_Amt.Text = "";
// SEWB_HDR_CGST_Amt.Text = "";
// SEWB_HDR_SGST_Amt.Text = "";
// SEWB_HDR_IGST_Amt.Text = "";
// SEWB_HDR_CESS_Amt.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";



// ObjAT_SEWHDR.SEWB_HDR_ID=SEWB_HDR_ID.Text ;
// ObjAT_SEWHDR.Fk_SourceTable=Fk_SourceTable.Text ;
// ObjAT_SEWHDR.Fk_TrnHDR_ID=Fk_TrnHDR_ID.Text ;
// ObjAT_SEWHDR.Fk_TrnDTL_ID=Fk_TrnDTL_ID.Text ;
// ObjAT_SEWHDR.SEWB_Trn_Type=SEWB_Trn_Type.Text ;
// ObjAT_SEWHDR.SEWB_Trn_SubType=SEWB_Trn_SubType.Text ;
// ObjAT_SEWHDR.SEWB_Trn_SubDesc=SEWB_Trn_SubDesc.Text ;
// ObjAT_SEWHDR.SEWB_Trn_Doc_Type=SEWB_Trn_Doc_Type.Text ;
// ObjAT_SEWHDR.SEWB_Trn_Doc_No=SEWB_Trn_Doc_No.Text ;
// ObjAT_SEWHDR.SEWB_Trn_Doc_Date=SEWB_Trn_Doc_Date.Text ;
// ObjAT_SEWHDR.SEWB_Supplier_GSTIN=SEWB_Supplier_GSTIN.Text ;
// ObjAT_SEWHDR.SEWB_Supplier_Name=SEWB_Supplier_Name.Text ;
// ObjAT_SEWHDR.SEWB_Supplier_Add1=SEWB_Supplier_Add1.Text ;
// ObjAT_SEWHDR.SEWB_Supplier_Add2=SEWB_Supplier_Add2.Text ;
// ObjAT_SEWHDR.SEWB_Supplier_Add3=SEWB_Supplier_Add3.Text ;
// ObjAT_SEWHDR.SEWB_Supplier_Pincode=SEWB_Supplier_Pincode.Text ;
// ObjAT_SEWHDR.SEWB_Supplier_Place=SEWB_Supplier_Place.Text ;
// ObjAT_SEWHDR.SEWB_Supplier_State=SEWB_Supplier_State.Text ;
// ObjAT_SEWHDR.SEWB_Supplier_POS=SEWB_Supplier_POS.Text ;
// ObjAT_SEWHDR.SEWB_Recipient_GSTIN=SEWB_Recipient_GSTIN.Text ;
// ObjAT_SEWHDR.SEWB_Recipient_Name=SEWB_Recipient_Name.Text ;
// ObjAT_SEWHDR.SEWB_Recipient_Add1=SEWB_Recipient_Add1.Text ;
// ObjAT_SEWHDR.SEWB_Recipient_Add2=SEWB_Recipient_Add2.Text ;
// ObjAT_SEWHDR.SEWB_Recipient_Add3=SEWB_Recipient_Add3.Text ;
// ObjAT_SEWHDR.SEWB_Recipient_Pincode=SEWB_Recipient_Pincode.Text ;
// ObjAT_SEWHDR.SEWB_Recipient_Place=SEWB_Recipient_Place.Text ;
// ObjAT_SEWHDR.SEWB_Recipient_State=SEWB_Recipient_State.Text ;
// ObjAT_SEWHDR.SEWB_Recipient_POS=SEWB_Recipient_POS.Text ;
// ObjAT_SEWHDR.SEWB_Trans_Mode=SEWB_Trans_Mode.Text ;
// ObjAT_SEWHDR.SEWB_Distance=SEWB_Distance.Text ;
// ObjAT_SEWHDR.SEWB_TranspoterNo=SEWB_TranspoterNo.Text ;
// ObjAT_SEWHDR.SEWB_TranspoterName=SEWB_TranspoterName.Text ;
// ObjAT_SEWHDR.SEWB_TranspoterDOC_No=SEWB_TranspoterDOC_No.Text ;
// ObjAT_SEWHDR.SEWB_Transpoter_DOC_DT=SEWB_Transpoter_DOC_DT.Text ;
// ObjAT_SEWHDR.SEWB_Vechile_CNT=SEWB_Vechile_CNT.Text ;
// ObjAT_SEWHDR.SEWB_Item_CNT=SEWB_Item_CNT.Text ;
// ObjAT_SEWHDR.SEWB_HDR_Gross_Amt=SEWB_HDR_Gross_Amt.Text ;
// ObjAT_SEWHDR.SEWB_HDR_Discount_Amt=SEWB_HDR_Discount_Amt.Text ;
// ObjAT_SEWHDR.SEWB_HDR_Taxable_Amt=SEWB_HDR_Taxable_Amt.Text ;
// ObjAT_SEWHDR.SEWB_HDR_CGST_Amt=SEWB_HDR_CGST_Amt.Text ;
// ObjAT_SEWHDR.SEWB_HDR_SGST_Amt=SEWB_HDR_SGST_Amt.Text ;
// ObjAT_SEWHDR.SEWB_HDR_IGST_Amt=SEWB_HDR_IGST_Amt.Text ;
// ObjAT_SEWHDR.SEWB_HDR_CESS_Amt=SEWB_HDR_CESS_Amt.Text ;
// ObjAT_SEWHDR.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_SEWHDR.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_SEWHDR.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_SEWHDR.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_SEWHDR.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_SEWHDR.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_SEWHDR.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;



// SEWB_HDR_ID.Text =  dt.Rows[0]["SEWB_HDR_ID"].ToString();
// Fk_SourceTable.Text =  dt.Rows[0]["Fk_SourceTable"].ToString();
// Fk_TrnHDR_ID.Text =  dt.Rows[0]["Fk_TrnHDR_ID"].ToString();
// Fk_TrnDTL_ID.Text =  dt.Rows[0]["Fk_TrnDTL_ID"].ToString();
// SEWB_Trn_Type.Text =  dt.Rows[0]["SEWB_Trn_Type"].ToString();
// SEWB_Trn_SubType.Text =  dt.Rows[0]["SEWB_Trn_SubType"].ToString();
// SEWB_Trn_SubDesc.Text =  dt.Rows[0]["SEWB_Trn_SubDesc"].ToString();
// SEWB_Trn_Doc_Type.Text =  dt.Rows[0]["SEWB_Trn_Doc_Type"].ToString();
// SEWB_Trn_Doc_No.Text =  dt.Rows[0]["SEWB_Trn_Doc_No"].ToString();
// SEWB_Trn_Doc_Date.Text =  dt.Rows[0]["SEWB_Trn_Doc_Date"].ToString();
// SEWB_Supplier_GSTIN.Text =  dt.Rows[0]["SEWB_Supplier_GSTIN"].ToString();
// SEWB_Supplier_Name.Text =  dt.Rows[0]["SEWB_Supplier_Name"].ToString();
// SEWB_Supplier_Add1.Text =  dt.Rows[0]["SEWB_Supplier_Add1"].ToString();
// SEWB_Supplier_Add2.Text =  dt.Rows[0]["SEWB_Supplier_Add2"].ToString();
// SEWB_Supplier_Add3.Text =  dt.Rows[0]["SEWB_Supplier_Add3"].ToString();
// SEWB_Supplier_Pincode.Text =  dt.Rows[0]["SEWB_Supplier_Pincode"].ToString();
// SEWB_Supplier_Place.Text =  dt.Rows[0]["SEWB_Supplier_Place"].ToString();
// SEWB_Supplier_State.Text =  dt.Rows[0]["SEWB_Supplier_State"].ToString();
// SEWB_Supplier_POS.Text =  dt.Rows[0]["SEWB_Supplier_POS"].ToString();
// SEWB_Recipient_GSTIN.Text =  dt.Rows[0]["SEWB_Recipient_GSTIN"].ToString();
// SEWB_Recipient_Name.Text =  dt.Rows[0]["SEWB_Recipient_Name"].ToString();
// SEWB_Recipient_Add1.Text =  dt.Rows[0]["SEWB_Recipient_Add1"].ToString();
// SEWB_Recipient_Add2.Text =  dt.Rows[0]["SEWB_Recipient_Add2"].ToString();
// SEWB_Recipient_Add3.Text =  dt.Rows[0]["SEWB_Recipient_Add3"].ToString();
// SEWB_Recipient_Pincode.Text =  dt.Rows[0]["SEWB_Recipient_Pincode"].ToString();
// SEWB_Recipient_Place.Text =  dt.Rows[0]["SEWB_Recipient_Place"].ToString();
// SEWB_Recipient_State.Text =  dt.Rows[0]["SEWB_Recipient_State"].ToString();
// SEWB_Recipient_POS.Text =  dt.Rows[0]["SEWB_Recipient_POS"].ToString();
// SEWB_Trans_Mode.Text =  dt.Rows[0]["SEWB_Trans_Mode"].ToString();
// SEWB_Distance.Text =  dt.Rows[0]["SEWB_Distance"].ToString();
// SEWB_TranspoterNo.Text =  dt.Rows[0]["SEWB_TranspoterNo"].ToString();
// SEWB_TranspoterName.Text =  dt.Rows[0]["SEWB_TranspoterName"].ToString();
// SEWB_TranspoterDOC_No.Text =  dt.Rows[0]["SEWB_TranspoterDOC_No"].ToString();
// SEWB_Transpoter_DOC_DT.Text =  dt.Rows[0]["SEWB_Transpoter_DOC_DT"].ToString();
// SEWB_Vechile_CNT.Text =  dt.Rows[0]["SEWB_Vechile_CNT"].ToString();
// SEWB_Item_CNT.Text =  dt.Rows[0]["SEWB_Item_CNT"].ToString();
// SEWB_HDR_Gross_Amt.Text =  dt.Rows[0]["SEWB_HDR_Gross_Amt"].ToString();
// SEWB_HDR_Discount_Amt.Text =  dt.Rows[0]["SEWB_HDR_Discount_Amt"].ToString();
// SEWB_HDR_Taxable_Amt.Text =  dt.Rows[0]["SEWB_HDR_Taxable_Amt"].ToString();
// SEWB_HDR_CGST_Amt.Text =  dt.Rows[0]["SEWB_HDR_CGST_Amt"].ToString();
// SEWB_HDR_SGST_Amt.Text =  dt.Rows[0]["SEWB_HDR_SGST_Amt"].ToString();
// SEWB_HDR_IGST_Amt.Text =  dt.Rows[0]["SEWB_HDR_IGST_Amt"].ToString();
// SEWB_HDR_CESS_Amt.Text =  dt.Rows[0]["SEWB_HDR_CESS_Amt"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
