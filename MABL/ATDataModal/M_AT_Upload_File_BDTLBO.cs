using System;
using System.Collections;
using System.Data;
using   MaheshAF18.DataAccess;
namespace MABL.ATDataModal 
{
public class M_AT_Upload_File_BDTLBO
{
MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
#region Constructor 
public M_AT_Upload_File_BDTLBO() { }
#endregion 
#region Standard Property
private string _PrimaryKeyName = "FUDTL_ID";
private string _TableName = "M_AT_Upload_File_BDTL";
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

private Int64 _FUDTL_ID;
private Int64 _Fk_FU_ID;
private String _FU_UserColumn;
private String _FU_SystemColumn;

public Int64 FUDTL_ID
{
get
  {
   return this._FUDTL_ID;  }
set
   {
     this._FUDTL_ID = value;
     _UpdateFieldName.Add("FUDTL_ID");
     }
}
public Int64 Fk_FU_ID
{
get
  {
   return this._Fk_FU_ID;  }
set
   {
     this._Fk_FU_ID = value;
     _UpdateFieldName.Add("Fk_FU_ID");
     }
}
public String FU_UserColumn
{
get
  {
   return this._FU_UserColumn;  }
set
   {
     this._FU_UserColumn = value;
     _UpdateFieldName.Add("FU_UserColumn");
     }
}
public String FU_SystemColumn
{
get
  {
   return this._FU_SystemColumn;  }
set
   {
     this._FU_SystemColumn = value;
     _UpdateFieldName.Add("FU_SystemColumn");
     }
}

#endregion
#region Genric Methods
public string Insert_Update(M_AT_Upload_File_BDTLBO sObject)
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

// ObjAT_FUDTL.FUDTL_ID=ObjAT_FUDTL.FUDTL_ID;
// ObjAT_FUDTL.Fk_FU_ID=ObjAT_FUDTL.Fk_FU_ID;
// ObjAT_FUDTL.FU_UserColumn=ObjAT_FUDTL.FU_UserColumn;
// ObjAT_FUDTL.FU_SystemColumn=ObjAT_FUDTL.FU_SystemColumn;



// FUDTL_ID.Text = "";
// Fk_FU_ID.Text = "";
// FU_UserColumn.Text = "";
// FU_SystemColumn.Text = "";



// ObjAT_FUDTL.FUDTL_ID=FUDTL_ID.Text ;
// ObjAT_FUDTL.Fk_FU_ID=Fk_FU_ID.Text ;
// ObjAT_FUDTL.FU_UserColumn=FU_UserColumn.Text ;
// ObjAT_FUDTL.FU_SystemColumn=FU_SystemColumn.Text ;



// FUDTL_ID.Text =  dt.Rows[0]["FUDTL_ID"].ToString();
// Fk_FU_ID.Text =  dt.Rows[0]["Fk_FU_ID"].ToString();
// FU_UserColumn.Text =  dt.Rows[0]["FU_UserColumn"].ToString();
// FU_SystemColumn.Text =  dt.Rows[0]["FU_SystemColumn"].ToString();

