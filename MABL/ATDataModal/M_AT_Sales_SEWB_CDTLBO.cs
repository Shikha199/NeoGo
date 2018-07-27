using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal 
{
public class M_AT_Sales_SEWB_CDTLBO
{
    MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
#region Constructor 
public M_AT_Sales_SEWB_CDTLBO() { }
#endregion 
#region Standard Property
private string _PrimaryKeyName = "SEWB_CTL_ID";
private string _TableName = "M_AT_Sales_SEWB_CDTL";
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

private Int64 _SEWB_CTL_ID;
private Int64 _Fk_SEWB_HDR_ID;
private String _SEWB_Trans_Mode;
private String _SEWB_Trans_Doc_No;
private String _SEWB_Trans_Doc_Date;
private String _SEWB_Suppier_Place;
private String _SEWB_Supplier_State;
private String _SEWB_Vehicle_No;
private String _SEWB_Vehicle_Type;
private String _SEWB_Reason;
private String _SEWB_Remark;
private String _MDBSC_RowStatus;
private String _SEWB_ItemRemark_DTL;
private Int16 _MDBSC_RowCreatedByUser_ID;
private String _MDBSC_RowCreatedByUserName;
private String _MDBSC_RowCreatedOn_DT;
private Int16 _MDBSC_RowLupdnByUser_ID;
private String _MDBSC_RowLupdnUserName;
private String _MDBSC_RowLupdnOn_DT;

public Int64 SEWB_CTL_ID
{
get
  {
   return this._SEWB_CTL_ID;  }
set
   {
     this._SEWB_CTL_ID = value;
     _UpdateFieldName.Add("SEWB_CTL_ID");
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
public String SEWB_Trans_Doc_No
{
get
  {
   return this._SEWB_Trans_Doc_No;  }
set
   {
     this._SEWB_Trans_Doc_No = value;
     _UpdateFieldName.Add("SEWB_Trans_Doc_No");
     }
}
public String SEWB_Trans_Doc_Date
{
get
  {
   return this._SEWB_Trans_Doc_Date;  }
set
   {
     this._SEWB_Trans_Doc_Date = value;
     _UpdateFieldName.Add("SEWB_Trans_Doc_Date");
     }
}
public String SEWB_Suppier_Place
{
get
  {
   return this._SEWB_Suppier_Place;  }
set
   {
     this._SEWB_Suppier_Place = value;
     _UpdateFieldName.Add("SEWB_Suppier_Place");
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
public String SEWB_Vehicle_No
{
get
  {
   return this._SEWB_Vehicle_No;  }
set
   {
     this._SEWB_Vehicle_No = value;
     _UpdateFieldName.Add("SEWB_Vehicle_No");
     }
}
public String SEWB_Vehicle_Type
{
get
  {
   return this._SEWB_Vehicle_Type;  }
set
   {
     this._SEWB_Vehicle_Type = value;
     _UpdateFieldName.Add("SEWB_Vehicle_Type");
     }
}
public String SEWB_Reason
{
get
  {
   return this._SEWB_Reason;  }
set
   {
     this._SEWB_Reason = value;
     _UpdateFieldName.Add("SEWB_Reason");
     }
}
public String SEWB_Remark
{
get
  {
   return this._SEWB_Remark;  }
set
   {
     this._SEWB_Remark = value;
     _UpdateFieldName.Add("SEWB_Remark");
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
public string Insert_Update(M_AT_Sales_SEWB_CDTLBO sObject)
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

// ObjAT_SEWCDTL.SEWB_CTL_ID=ObjAT_SEWCDTL.SEWB_CTL_ID;
// ObjAT_SEWCDTL.Fk_SEWB_HDR_ID=ObjAT_SEWCDTL.Fk_SEWB_HDR_ID;
// ObjAT_SEWCDTL.SEWB_Trans_Mode=ObjAT_SEWCDTL.SEWB_Trans_Mode;
// ObjAT_SEWCDTL.SEWB_Trans_Doc_No=ObjAT_SEWCDTL.SEWB_Trans_Doc_No;
// ObjAT_SEWCDTL.SEWB_Trans_Doc_Date=ObjAT_SEWCDTL.SEWB_Trans_Doc_Date;
// ObjAT_SEWCDTL.SEWB_Suppier_Place=ObjAT_SEWCDTL.SEWB_Suppier_Place;
// ObjAT_SEWCDTL.SEWB_Supplier_State=ObjAT_SEWCDTL.SEWB_Supplier_State;
// ObjAT_SEWCDTL.SEWB_Vehicle_No=ObjAT_SEWCDTL.SEWB_Vehicle_No;
// ObjAT_SEWCDTL.SEWB_Vehicle_Type=ObjAT_SEWCDTL.SEWB_Vehicle_Type;
// ObjAT_SEWCDTL.SEWB_Reason=ObjAT_SEWCDTL.SEWB_Reason;
// ObjAT_SEWCDTL.SEWB_Remark=ObjAT_SEWCDTL.SEWB_Remark;
// ObjAT_SEWCDTL.MDBSC_RowStatus=ObjAT_SEWCDTL.MDBSC_RowStatus;
// ObjAT_SEWCDTL.SEWB_ItemRemark_DTL=ObjAT_SEWCDTL.SEWB_ItemRemark_DTL;
// ObjAT_SEWCDTL.MDBSC_RowCreatedByUser_ID=ObjAT_SEWCDTL.MDBSC_RowCreatedByUser_ID;
// ObjAT_SEWCDTL.MDBSC_RowCreatedByUserName=ObjAT_SEWCDTL.MDBSC_RowCreatedByUserName;
// ObjAT_SEWCDTL.MDBSC_RowCreatedOn_DT=ObjAT_SEWCDTL.MDBSC_RowCreatedOn_DT;
// ObjAT_SEWCDTL.MDBSC_RowLupdnByUser_ID=ObjAT_SEWCDTL.MDBSC_RowLupdnByUser_ID;
// ObjAT_SEWCDTL.MDBSC_RowLupdnUserName=ObjAT_SEWCDTL.MDBSC_RowLupdnUserName;
// ObjAT_SEWCDTL.MDBSC_RowLupdnOn_DT=ObjAT_SEWCDTL.MDBSC_RowLupdnOn_DT;



// SEWB_CTL_ID.Text = "";
// Fk_SEWB_HDR_ID.Text = "";
// SEWB_Trans_Mode.Text = "";
// SEWB_Trans_Doc_No.Text = "";
// SEWB_Trans_Doc_Date.Text = "";
// SEWB_Suppier_Place.Text = "";
// SEWB_Supplier_State.Text = "";
// SEWB_Vehicle_No.Text = "";
// SEWB_Vehicle_Type.Text = "";
// SEWB_Reason.Text = "";
// SEWB_Remark.Text = "";
// MDBSC_RowStatus.Text = "";
// SEWB_ItemRemark_DTL.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";



// ObjAT_SEWCDTL.SEWB_CTL_ID=SEWB_CTL_ID.Text ;
// ObjAT_SEWCDTL.Fk_SEWB_HDR_ID=Fk_SEWB_HDR_ID.Text ;
// ObjAT_SEWCDTL.SEWB_Trans_Mode=SEWB_Trans_Mode.Text ;
// ObjAT_SEWCDTL.SEWB_Trans_Doc_No=SEWB_Trans_Doc_No.Text ;
// ObjAT_SEWCDTL.SEWB_Trans_Doc_Date=SEWB_Trans_Doc_Date.Text ;
// ObjAT_SEWCDTL.SEWB_Suppier_Place=SEWB_Suppier_Place.Text ;
// ObjAT_SEWCDTL.SEWB_Supplier_State=SEWB_Supplier_State.Text ;
// ObjAT_SEWCDTL.SEWB_Vehicle_No=SEWB_Vehicle_No.Text ;
// ObjAT_SEWCDTL.SEWB_Vehicle_Type=SEWB_Vehicle_Type.Text ;
// ObjAT_SEWCDTL.SEWB_Reason=SEWB_Reason.Text ;
// ObjAT_SEWCDTL.SEWB_Remark=SEWB_Remark.Text ;
// ObjAT_SEWCDTL.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_SEWCDTL.SEWB_ItemRemark_DTL=SEWB_ItemRemark_DTL.Text ;
// ObjAT_SEWCDTL.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_SEWCDTL.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_SEWCDTL.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_SEWCDTL.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_SEWCDTL.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_SEWCDTL.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;



// SEWB_CTL_ID.Text =  dt.Rows[0]["SEWB_CTL_ID"].ToString();
// Fk_SEWB_HDR_ID.Text =  dt.Rows[0]["Fk_SEWB_HDR_ID"].ToString();
// SEWB_Trans_Mode.Text =  dt.Rows[0]["SEWB_Trans_Mode"].ToString();
// SEWB_Trans_Doc_No.Text =  dt.Rows[0]["SEWB_Trans_Doc_No"].ToString();
// SEWB_Trans_Doc_Date.Text =  dt.Rows[0]["SEWB_Trans_Doc_Date"].ToString();
// SEWB_Suppier_Place.Text =  dt.Rows[0]["SEWB_Suppier_Place"].ToString();
// SEWB_Supplier_State.Text =  dt.Rows[0]["SEWB_Supplier_State"].ToString();
// SEWB_Vehicle_No.Text =  dt.Rows[0]["SEWB_Vehicle_No"].ToString();
// SEWB_Vehicle_Type.Text =  dt.Rows[0]["SEWB_Vehicle_Type"].ToString();
// SEWB_Reason.Text =  dt.Rows[0]["SEWB_Reason"].ToString();
// SEWB_Remark.Text =  dt.Rows[0]["SEWB_Remark"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// SEWB_ItemRemark_DTL.Text =  dt.Rows[0]["SEWB_ItemRemark_DTL"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
