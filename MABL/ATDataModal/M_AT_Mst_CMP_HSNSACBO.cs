using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal 
{
public class M_AT_Mst_CMP_HSNSACBO
{
    MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
#region Constructor 
public M_AT_Mst_CMP_HSNSACBO() { }
#endregion 
#region Standard Property
private string _PrimaryKeyName = "CHID_ID";
private string _TableName = "M_AT_Mst_CMP_HSNSAC";
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

private Int64 _CHID_ID;
private Int64 _Fk_Company_ID;
private Int64 _Fk_Branch_ID;
private String _HSNCode;
private String _HSN_Desc;
private String _MDBSC_RowStatus;
private Int64 _MDBSC_RowCreatedByUser_ID;
private String _MDBSC_RowCreatedByUserName;
private String _MDBSC_RowCreatedOn_DT;
private Int64 _MDBSC_RowLupdnByUser_ID;
private String _MDBSC_RowLupdnUserName;
private String _MDBSC_RowLupdnOn_DT;

public Int64 CHID_ID
{
get
  {
   return this._CHID_ID;  }
set
   {
     this._CHID_ID = value;
     _UpdateFieldName.Add("CHID_ID");
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
public String HSNCode
{
get
  {
   return this._HSNCode;  }
set
   {
     this._HSNCode = value;
     _UpdateFieldName.Add("HSNCode");
     }
}
public String HSN_Desc
{
get
  {
   return this._HSN_Desc;  }
set
   {
     this._HSN_Desc = value;
     _UpdateFieldName.Add("HSN_Desc");
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
public Int64 MDBSC_RowCreatedByUser_ID
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
public Int64 MDBSC_RowLupdnByUser_ID
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
public string Insert_Update(M_AT_Mst_CMP_HSNSACBO sObject)
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

// ObjAT_CH.CHID_ID=ObjAT_CH.CHID_ID;
// ObjAT_CH.Fk_Company_ID=ObjAT_CH.Fk_Company_ID;
// ObjAT_CH.Fk_Branch_ID=ObjAT_CH.Fk_Branch_ID;
// ObjAT_CH.HSNCode=ObjAT_CH.HSNCode;
// ObjAT_CH.HSN_Desc=ObjAT_CH.HSN_Desc;
// ObjAT_CH.MDBSC_RowStatus=ObjAT_CH.MDBSC_RowStatus;
// ObjAT_CH.MDBSC_RowCreatedByUser_ID=ObjAT_CH.MDBSC_RowCreatedByUser_ID;
// ObjAT_CH.MDBSC_RowCreatedByUserName=ObjAT_CH.MDBSC_RowCreatedByUserName;
// ObjAT_CH.MDBSC_RowCreatedOn_DT=ObjAT_CH.MDBSC_RowCreatedOn_DT;
// ObjAT_CH.MDBSC_RowLupdnByUser_ID=ObjAT_CH.MDBSC_RowLupdnByUser_ID;
// ObjAT_CH.MDBSC_RowLupdnUserName=ObjAT_CH.MDBSC_RowLupdnUserName;
// ObjAT_CH.MDBSC_RowLupdnOn_DT=ObjAT_CH.MDBSC_RowLupdnOn_DT;



// CHID_ID.Text = "";
// Fk_Company_ID.Text = "";
// Fk_Branch_ID.Text = "";
// HSNCode.Text = "";
// HSN_Desc.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";



// ObjAT_CH.CHID_ID=CHID_ID.Text ;
// ObjAT_CH.Fk_Company_ID=Fk_Company_ID.Text ;
// ObjAT_CH.Fk_Branch_ID=Fk_Branch_ID.Text ;
// ObjAT_CH.HSNCode=HSNCode.Text ;
// ObjAT_CH.HSN_Desc=HSN_Desc.Text ;
// ObjAT_CH.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_CH.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_CH.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_CH.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_CH.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_CH.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_CH.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;



// CHID_ID.Text =  dt.Rows[0]["CHID_ID"].ToString();
// Fk_Company_ID.Text =  dt.Rows[0]["Fk_Company_ID"].ToString();
// Fk_Branch_ID.Text =  dt.Rows[0]["Fk_Branch_ID"].ToString();
// HSNCode.Text =  dt.Rows[0]["HSNCode"].ToString();
// HSN_Desc.Text =  dt.Rows[0]["HSN_Desc"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();

