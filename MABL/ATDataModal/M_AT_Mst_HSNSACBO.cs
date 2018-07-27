using System;
using System.Collections;
using System.Data;
using   MaheshAF18.DataAccess;
namespace MABL.ATDataModal 
{
public class M_AT_Mst_HSNSACBO
{
MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
#region Constructor 
public M_AT_Mst_HSNSACBO() { }
#endregion 
#region Standard Property
private string _PrimaryKeyName = "HS_ID";
private string _TableName = "M_AT_Mst_HSNSAC";
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

private Int64 _HS_ID;
private String _HS_Type;
private String _HS_CODE;
private String _HS_ChapterName;
private String _HS_ChapterCode;
private String _HS_GroupName;
private String _HS_GroupCode;
private String _HS_SectionName;
private String _HS_SectionCode;
private String _HS_IsITCAllowed;
private String _HS_EffectiveFrom_DT;
private String _HS_EffectiveTo_DT;
private Decimal _HS_TaxRate;
private Decimal _HS_CESSRate;
private Decimal _HS_CESSAmt;
private Decimal _HS_CESSAmtPerNos;
private Int64 _HS_UOMID;
private String _HS_UOMDesc;
private String _HSN_Description;
private String _HS_IsSystem;
private String _MDBSC_RowStatus;
private Int16 _MDBSC_RowCreatedByUser_ID;
private String _MDBSC_RowCreatedByUserName;
private String _MDBSC_RowCreatedOn_DT;
private Int16 _MDBSC_RowLupdnByUser_ID;
private String _MDBSC_RowLupdnUserName;
private String _MDBSC_RowLupdnOn_DT;

public Int64 HS_ID
{
get
  {
   return this._HS_ID;  }
set
   {
     this._HS_ID = value;
     _UpdateFieldName.Add("HS_ID");
     }
}
public String HS_Type
{
get
  {
   return this._HS_Type;  }
set
   {
     this._HS_Type = value;
     _UpdateFieldName.Add("HS_Type");
     }
}
public String HS_CODE
{
get
  {
   return this._HS_CODE;  }
set
   {
     this._HS_CODE = value;
     _UpdateFieldName.Add("HS_CODE");
     }
}
public String HS_ChapterName
{
get
  {
   return this._HS_ChapterName;  }
set
   {
     this._HS_ChapterName = value;
     _UpdateFieldName.Add("HS_ChapterName");
     }
}
public String HS_ChapterCode
{
get
  {
   return this._HS_ChapterCode;  }
set
   {
     this._HS_ChapterCode = value;
     _UpdateFieldName.Add("HS_ChapterCode");
     }
}
public String HS_GroupName
{
get
  {
   return this._HS_GroupName;  }
set
   {
     this._HS_GroupName = value;
     _UpdateFieldName.Add("HS_GroupName");
     }
}
public String HS_GroupCode
{
get
  {
   return this._HS_GroupCode;  }
set
   {
     this._HS_GroupCode = value;
     _UpdateFieldName.Add("HS_GroupCode");
     }
}
public String HS_SectionName
{
get
  {
   return this._HS_SectionName;  }
set
   {
     this._HS_SectionName = value;
     _UpdateFieldName.Add("HS_SectionName");
     }
}
public String HS_SectionCode
{
get
  {
   return this._HS_SectionCode;  }
set
   {
     this._HS_SectionCode = value;
     _UpdateFieldName.Add("HS_SectionCode");
     }
}
public String HS_IsITCAllowed
{
get
  {
   return this._HS_IsITCAllowed;  }
set
   {
     this._HS_IsITCAllowed = value;
     _UpdateFieldName.Add("HS_IsITCAllowed");
     }
}
public String HS_EffectiveFrom_DT
{
get
  {
   return this._HS_EffectiveFrom_DT;  }
set
   {
     this._HS_EffectiveFrom_DT = value;
     _UpdateFieldName.Add("HS_EffectiveFrom_DT");
     }
}
public String HS_EffectiveTo_DT
{
get
  {
   return this._HS_EffectiveTo_DT;  }
set
   {
     this._HS_EffectiveTo_DT = value;
     _UpdateFieldName.Add("HS_EffectiveTo_DT");
     }
}
public Decimal HS_TaxRate
{
get
  {
   return this._HS_TaxRate;  }
set
   {
     this._HS_TaxRate = value;
     _UpdateFieldName.Add("HS_TaxRate");
     }
}
public Decimal HS_CESSRate
{
get
  {
   return this._HS_CESSRate;  }
set
   {
     this._HS_CESSRate = value;
     _UpdateFieldName.Add("HS_CESSRate");
     }
}
public Decimal HS_CESSAmt
{
get
  {
   return this._HS_CESSAmt;  }
set
   {
     this._HS_CESSAmt = value;
     _UpdateFieldName.Add("HS_CESSAmt");
     }
}
public Decimal HS_CESSAmtPerNos
{
get
  {
   return this._HS_CESSAmtPerNos;  }
set
   {
     this._HS_CESSAmtPerNos = value;
     _UpdateFieldName.Add("HS_CESSAmtPerNos");
     }
}
public Int64 HS_UOMID
{
get
  {
   return this._HS_UOMID;  }
set
   {
     this._HS_UOMID = value;
     _UpdateFieldName.Add("HS_UOMID");
     }
}
public String HS_UOMDesc
{
get
  {
   return this._HS_UOMDesc;  }
set
   {
     this._HS_UOMDesc = value;
     _UpdateFieldName.Add("HS_UOMDesc");
     }
}
public String HSN_Description
{
get
  {
   return this._HSN_Description;  }
set
   {
     this._HSN_Description = value;
     _UpdateFieldName.Add("HSN_Description");
     }
}
public String HS_IsSystem
{
get
  {
   return this._HS_IsSystem;  }
set
   {
     this._HS_IsSystem = value;
     _UpdateFieldName.Add("HS_IsSystem");
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

#endregion
#region Genric Methods
public string Insert_Update(M_AT_Mst_HSNSACBO sObject)
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

// ObjAT_HS.HS_ID=ObjAT_HS.HS_ID;
// ObjAT_HS.HS_Type=ObjAT_HS.HS_Type;
// ObjAT_HS.HS_CODE=ObjAT_HS.HS_CODE;
// ObjAT_HS.HS_ChapterName=ObjAT_HS.HS_ChapterName;
// ObjAT_HS.HS_ChapterCode=ObjAT_HS.HS_ChapterCode;
// ObjAT_HS.HS_GroupName=ObjAT_HS.HS_GroupName;
// ObjAT_HS.HS_GroupCode=ObjAT_HS.HS_GroupCode;
// ObjAT_HS.HS_SectionName=ObjAT_HS.HS_SectionName;
// ObjAT_HS.HS_SectionCode=ObjAT_HS.HS_SectionCode;
// ObjAT_HS.HS_IsITCAllowed=ObjAT_HS.HS_IsITCAllowed;
// ObjAT_HS.HS_EffectiveFrom_DT=ObjAT_HS.HS_EffectiveFrom_DT;
// ObjAT_HS.HS_EffectiveTo_DT=ObjAT_HS.HS_EffectiveTo_DT;
// ObjAT_HS.HS_TaxRate=ObjAT_HS.HS_TaxRate;
// ObjAT_HS.HS_CESSRate=ObjAT_HS.HS_CESSRate;
// ObjAT_HS.HS_CESSAmt=ObjAT_HS.HS_CESSAmt;
// ObjAT_HS.HS_CESSAmtPerNos=ObjAT_HS.HS_CESSAmtPerNos;
// ObjAT_HS.HS_UOMID=ObjAT_HS.HS_UOMID;
// ObjAT_HS.HS_UOMDesc=ObjAT_HS.HS_UOMDesc;
// ObjAT_HS.HSN_Description=ObjAT_HS.HSN_Description;
// ObjAT_HS.HS_IsSystem=ObjAT_HS.HS_IsSystem;
// ObjAT_HS.MDBSC_RowStatus=ObjAT_HS.MDBSC_RowStatus;
// ObjAT_HS.MDBSC_RowCreatedByUser_ID=ObjAT_HS.MDBSC_RowCreatedByUser_ID;
// ObjAT_HS.MDBSC_RowCreatedByUserName=ObjAT_HS.MDBSC_RowCreatedByUserName;
// ObjAT_HS.MDBSC_RowCreatedOn_DT=ObjAT_HS.MDBSC_RowCreatedOn_DT;
// ObjAT_HS.MDBSC_RowLupdnByUser_ID=ObjAT_HS.MDBSC_RowLupdnByUser_ID;
// ObjAT_HS.MDBSC_RowLupdnUserName=ObjAT_HS.MDBSC_RowLupdnUserName;
// ObjAT_HS.MDBSC_RowLupdnOn_DT=ObjAT_HS.MDBSC_RowLupdnOn_DT;



// HS_ID.Text = "";
// HS_Type.Text = "";
// HS_CODE.Text = "";
// HS_ChapterName.Text = "";
// HS_ChapterCode.Text = "";
// HS_GroupName.Text = "";
// HS_GroupCode.Text = "";
// HS_SectionName.Text = "";
// HS_SectionCode.Text = "";
// HS_IsITCAllowed.Text = "";
// HS_EffectiveFrom_DT.Text = "";
// HS_EffectiveTo_DT.Text = "";
// HS_TaxRate.Text = "";
// HS_CESSRate.Text = "";
// HS_CESSAmt.Text = "";
// HS_CESSAmtPerNos.Text = "";
// HS_UOMID.Text = "";
// HS_UOMDesc.Text = "";
// HSN_Description.Text = "";
// HS_IsSystem.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";



// ObjAT_HS.HS_ID=HS_ID.Text ;
// ObjAT_HS.HS_Type=HS_Type.Text ;
// ObjAT_HS.HS_CODE=HS_CODE.Text ;
// ObjAT_HS.HS_ChapterName=HS_ChapterName.Text ;
// ObjAT_HS.HS_ChapterCode=HS_ChapterCode.Text ;
// ObjAT_HS.HS_GroupName=HS_GroupName.Text ;
// ObjAT_HS.HS_GroupCode=HS_GroupCode.Text ;
// ObjAT_HS.HS_SectionName=HS_SectionName.Text ;
// ObjAT_HS.HS_SectionCode=HS_SectionCode.Text ;
// ObjAT_HS.HS_IsITCAllowed=HS_IsITCAllowed.Text ;
// ObjAT_HS.HS_EffectiveFrom_DT=HS_EffectiveFrom_DT.Text ;
// ObjAT_HS.HS_EffectiveTo_DT=HS_EffectiveTo_DT.Text ;
// ObjAT_HS.HS_TaxRate=HS_TaxRate.Text ;
// ObjAT_HS.HS_CESSRate=HS_CESSRate.Text ;
// ObjAT_HS.HS_CESSAmt=HS_CESSAmt.Text ;
// ObjAT_HS.HS_CESSAmtPerNos=HS_CESSAmtPerNos.Text ;
// ObjAT_HS.HS_UOMID=HS_UOMID.Text ;
// ObjAT_HS.HS_UOMDesc=HS_UOMDesc.Text ;
// ObjAT_HS.HSN_Description=HSN_Description.Text ;
// ObjAT_HS.HS_IsSystem=HS_IsSystem.Text ;
// ObjAT_HS.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_HS.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_HS.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_HS.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_HS.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_HS.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_HS.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;



// HS_ID.Text =  dt.Rows[0]["HS_ID"].ToString();
// HS_Type.Text =  dt.Rows[0]["HS_Type"].ToString();
// HS_CODE.Text =  dt.Rows[0]["HS_CODE"].ToString();
// HS_ChapterName.Text =  dt.Rows[0]["HS_ChapterName"].ToString();
// HS_ChapterCode.Text =  dt.Rows[0]["HS_ChapterCode"].ToString();
// HS_GroupName.Text =  dt.Rows[0]["HS_GroupName"].ToString();
// HS_GroupCode.Text =  dt.Rows[0]["HS_GroupCode"].ToString();
// HS_SectionName.Text =  dt.Rows[0]["HS_SectionName"].ToString();
// HS_SectionCode.Text =  dt.Rows[0]["HS_SectionCode"].ToString();
// HS_IsITCAllowed.Text =  dt.Rows[0]["HS_IsITCAllowed"].ToString();
// HS_EffectiveFrom_DT.Text =  dt.Rows[0]["HS_EffectiveFrom_DT"].ToString();
// HS_EffectiveTo_DT.Text =  dt.Rows[0]["HS_EffectiveTo_DT"].ToString();
// HS_TaxRate.Text =  dt.Rows[0]["HS_TaxRate"].ToString();
// HS_CESSRate.Text =  dt.Rows[0]["HS_CESSRate"].ToString();
// HS_CESSAmt.Text =  dt.Rows[0]["HS_CESSAmt"].ToString();
// HS_CESSAmtPerNos.Text =  dt.Rows[0]["HS_CESSAmtPerNos"].ToString();
// HS_UOMID.Text =  dt.Rows[0]["HS_UOMID"].ToString();
// HS_UOMDesc.Text =  dt.Rows[0]["HS_UOMDesc"].ToString();
// HSN_Description.Text =  dt.Rows[0]["HSN_Description"].ToString();
// HS_IsSystem.Text =  dt.Rows[0]["HS_IsSystem"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
