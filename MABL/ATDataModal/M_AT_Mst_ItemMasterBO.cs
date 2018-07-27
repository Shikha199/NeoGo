using System;
using System.Collections;
using System.Data;
using MaheshAF18.DataAccess;
namespace MABL.ATDataModal
{
    public class M_AT_Mst_ItemMasterBO
    {
        MaheshAF18.DataAccess.IUD ObjDataAcess = new MaheshAF18.DataAccess.IUD();
        #region Constructor
        public M_AT_Mst_ItemMasterBO() { }
        #endregion
        #region Standard Property
        private string _PrimaryKeyName = "MItem_ID";
        private string _TableName = "M_AT_Mst_ItemMaster";
        private string _PrimaryKeyValue = "0";
        private ArrayList _UpdateFieldName = new ArrayList();
        public string TableName
        {
            get { return _TableName; }
            set { this._TableName = value; }
        }
        public string PrimaryKeyName
        {
            get { return _PrimaryKeyName; }
            set { this._PrimaryKeyName = value; }
        }
        public string PrimaryKeyValue
        {
            get { return _PrimaryKeyValue; }
            set { this._PrimaryKeyValue = value; }
        }
        public ArrayList UpdateFieldName
        {
            get { return _UpdateFieldName; }
            set { this._UpdateFieldName = value; }
        }
        #endregion
        #region Table Properties

        private Int64 _MItem_ID;
        private Int64 _Fk_Company_ID;
        private Int64 _Fk_Branch_ID;
        private Int64 _Fk_Year_ID;
        private Int64 _Fk_MIC_ID;
        private Int64 _Fk_IG_ID;
        private Int64 _Fk_ISG_ID;
        private Int64 _Fk_UOM_ID;
        private Int64 _Item_SRNO;
        private String _Item_Code;
        private String _HSNCode;
        private Int64 _Fk_HSN_ID;
        private String _HSN_Desc;
        private String _I_UserCode;

        private String _Item_Inv_Desc;
        private String _Item_Name;
        private String _Item_Type;
        private Decimal _Item_Selling_Rate;
        private Decimal _Item_Purchase_Rate;
        private Int64 _Item_Tax_GST_ID;
        private String _Item_Tax_GST_Effective_From;
        private Decimal _Item_CGST_Rate;
        private Decimal _Item_SGST_Rate;
        private Decimal _Item_IGST_Rate;
        private Int64 _Item_Tax_CESS_ID;
        private String _Item_Tax_CESS_Effective_From;
        private Decimal _Item_CESS_Rate;
        private Decimal _Item_CESS_Amt_Per_X_Product;
        private String _Is_Item_StockCodeSingle;
        private String _Is_Allow_Item_RateEdit;
        private String _I_PartNo;
        private String _I_Asset_Code;
        private String _I_Machinery_Name;
        private String _I_Make;
        private String _I_Model;
        private String _I_Engine_Number;
        private String _I_Chassis_Number;
        private String _I_Machinery_Type;
        private Int16 _I_ManufacturingYear;
        private Decimal _I_Total_Machinery_Cost;
        private String _I_Machinery_RTO_Reg_No;
        private String _Item_Desc;
        private String _MDBSC_RowStatus;
        private Int16 _MDBSC_RowCreatedByUser_ID;
        private String _MDBSC_RowCreatedByUserName;
        private String _MDBSC_RowCreatedOn_DT;
        private Int16 _MDBSC_RowLupdnByUser_ID;
        private String _MDBSC_RowLupdnUserName;
        private String _MDBSC_RowLupdnOn_DT;

        public Int64 MItem_ID
        {
            get
            {
                return this._MItem_ID;
            }
            set
            {
                this._MItem_ID = value;
                _UpdateFieldName.Add("MItem_ID");
            }
        }
        public Int64 Fk_Company_ID
        {
            get
            {
                return this._Fk_Company_ID;
            }
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
                return this._Fk_Branch_ID;
            }
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
                return this._Fk_Year_ID;
            }
            set
            {
                this._Fk_Year_ID = value;
                _UpdateFieldName.Add("Fk_Year_ID");
            }
        }
        public Int64 Fk_MIC_ID
        {
            get
            {
                return this._Fk_MIC_ID;
            }
            set
            {
                this._Fk_MIC_ID = value;
                _UpdateFieldName.Add("Fk_MIC_ID");
            }
        }
        public Int64 Fk_IG_ID
        {
            get
            {
                return this._Fk_IG_ID;
            }
            set
            {
                this._Fk_IG_ID = value;
                _UpdateFieldName.Add("Fk_IG_ID");
            }
        }
        public Int64 Fk_ISG_ID
        {
            get
            {
                return this._Fk_ISG_ID;
            }
            set
            {
                this._Fk_ISG_ID = value;
                _UpdateFieldName.Add("Fk_ISG_ID");
            }
        }
        public Int64 Fk_UOM_ID
        {
            get
            {
                return this._Fk_UOM_ID;
            }
            set
            {
                this._Fk_UOM_ID = value;
                _UpdateFieldName.Add("Fk_UOM_ID");
            }
        }
        public Int64 Item_SRNO
        {
            get
            {
                return this._Item_SRNO;
            }
            set
            {
                this._Item_SRNO = value;
                _UpdateFieldName.Add("Item_SRNO");
            }
        }
        public String Item_Code
        {
            get
            {
                return this._Item_Code;
            }
            set
            {
                this._Item_Code = value;
                _UpdateFieldName.Add("Item_Code");
            }
        }
        public Int64 Fk_HSN_ID
        {
            get
            {
                return this._Fk_HSN_ID;
            }
            set
            {
                this._Fk_HSN_ID = value;
                _UpdateFieldName.Add("Fk_HSN_ID");
            }
        }
        public String HSN_Desc
        {
            get
            {
                return this._HSN_Desc;
            }
            set
            {
                this._HSN_Desc = value;
                _UpdateFieldName.Add("HSN_Desc");
            }
        }
        public String HSNCode
        {
            get
            {
                return this._HSNCode;
            }
            set
            {
                this._HSNCode = value;
                _UpdateFieldName.Add("HSNCode");
            }
        }


        public String Item_Inv_Desc
        {
            get
            {
                return this._Item_Inv_Desc;
            }
            set
            {
                this._Item_Inv_Desc = value;
                _UpdateFieldName.Add("Item_Inv_Desc");
            }
        }

        public String Item_Name
        {
            get
            {
                return this._Item_Name;
            }
            set
            {
                this._Item_Name = value;
                _UpdateFieldName.Add("Item_Name");
            }
        }
        public String Item_Type
        {
            get
            {
                return this._Item_Type;
            }
            set
            {
                this._Item_Type = value;
                _UpdateFieldName.Add("Item_Type");
            }
        }
        public Decimal Item_Selling_Rate
        {
            get
            {
                return this._Item_Selling_Rate;
            }
            set
            {
                this._Item_Selling_Rate = value;
                _UpdateFieldName.Add("Item_Selling_Rate");
            }
        }
        public Decimal Item_Purchase_Rate
        {
            get
            {
                return this._Item_Purchase_Rate;
            }
            set
            {
                this._Item_Purchase_Rate = value;
                _UpdateFieldName.Add("Item_Purchase_Rate");
            }
        }
        public Int64 Item_Tax_GST_ID
        {
            get
            {
                return this._Item_Tax_GST_ID;
            }
            set
            {
                this._Item_Tax_GST_ID = value;
                _UpdateFieldName.Add("Item_Tax_GST_ID");
            }
        }
        public String Item_Tax_GST_Effective_From
        {
            get
            {
                return this._Item_Tax_GST_Effective_From;
            }
            set
            {
                this._Item_Tax_GST_Effective_From = value;
                _UpdateFieldName.Add("Item_Tax_GST_Effective_From");
            }
        }
        public Decimal Item_CGST_Rate
        {
            get
            {
                return this._Item_CGST_Rate;
            }
            set
            {
                this._Item_CGST_Rate = value;
                _UpdateFieldName.Add("Item_CGST_Rate");
            }
        }
        public Decimal Item_SGST_Rate
        {
            get
            {
                return this._Item_SGST_Rate;
            }
            set
            {
                this._Item_SGST_Rate = value;
                _UpdateFieldName.Add("Item_SGST_Rate");
            }
        }
        public Decimal Item_IGST_Rate
        {
            get
            {
                return this._Item_IGST_Rate;
            }
            set
            {
                this._Item_IGST_Rate = value;
                _UpdateFieldName.Add("Item_IGST_Rate");
            }
        }
        public Int64 Item_Tax_CESS_ID
        {
            get
            {
                return this._Item_Tax_CESS_ID;
            }
            set
            {
                this._Item_Tax_CESS_ID = value;
                _UpdateFieldName.Add("Item_Tax_CESS_ID");
            }
        }


        public String I_UserCode
        {
            get
            {
                return this._I_UserCode;
            }
            set
            {
                this._I_UserCode = value;
                _UpdateFieldName.Add("I_UserCode");
            }
        }

        public String Item_Tax_CESS_Effective_From
        {
            get
            {
                return this._Item_Tax_CESS_Effective_From;
            }
            set
            {
                this._Item_Tax_CESS_Effective_From = value;
                _UpdateFieldName.Add("Item_Tax_CESS_Effective_From");
            }
        }
        public Decimal Item_CESS_Rate
        {
            get
            {
                return this._Item_CESS_Rate;
            }
            set
            {
                this._Item_CESS_Rate = value;
                _UpdateFieldName.Add("Item_CESS_Rate");
            }
        }
        public Decimal Item_CESS_Amt_Per_X_Product
        {
            get
            {
                return this._Item_CESS_Amt_Per_X_Product;
            }
            set
            {
                this._Item_CESS_Amt_Per_X_Product = value;
                _UpdateFieldName.Add("Item_CESS_Amt_Per_X_Product");
            }
        }
        public String Is_Item_StockCodeSingle
        {
            get
            {
                return this._Is_Item_StockCodeSingle;
            }
            set
            {
                this._Is_Item_StockCodeSingle = value;
                _UpdateFieldName.Add("Is_Item_StockCodeSingle");
            }
        }
        public String Is_Allow_Item_RateEdit
        {
            get
            {
                return this._Is_Allow_Item_RateEdit;
            }
            set
            {
                this._Is_Allow_Item_RateEdit = value;
                _UpdateFieldName.Add("Is_Allow_Item_RateEdit");
            }
        }
        public String I_PartNo
        {
            get
            {
                return this._I_PartNo;
            }
            set
            {
                this._I_PartNo = value;
                _UpdateFieldName.Add("I_PartNo");
            }
        }
        public String I_Asset_Code
        {
            get
            {
                return this._I_Asset_Code;
            }
            set
            {
                this._I_Asset_Code = value;
                _UpdateFieldName.Add("I_Asset_Code");
            }
        }
        public String I_Machinery_Name
        {
            get
            {
                return this._I_Machinery_Name;
            }
            set
            {
                this._I_Machinery_Name = value;
                _UpdateFieldName.Add("I_Machinery_Name");
            }
        }
        public String I_Make
        {
            get
            {
                return this._I_Make;
            }
            set
            {
                this._I_Make = value;
                _UpdateFieldName.Add("I_Make");
            }
        }
        public String I_Model
        {
            get
            {
                return this._I_Model;
            }
            set
            {
                this._I_Model = value;
                _UpdateFieldName.Add("I_Model");
            }
        }
        public String I_Engine_Number
        {
            get
            {
                return this._I_Engine_Number;
            }
            set
            {
                this._I_Engine_Number = value;
                _UpdateFieldName.Add("I_Engine_Number");
            }
        }
        public String I_Chassis_Number
        {
            get
            {
                return this._I_Chassis_Number;
            }
            set
            {
                this._I_Chassis_Number = value;
                _UpdateFieldName.Add("I_Chassis_Number");
            }
        }
        public String I_Machinery_Type
        {
            get
            {
                return this._I_Machinery_Type;
            }
            set
            {
                this._I_Machinery_Type = value;
                _UpdateFieldName.Add("I_Machinery_Type");
            }
        }
        public Int16 I_ManufacturingYear
        {
            get
            {
                return this._I_ManufacturingYear;
            }
            set
            {
                this._I_ManufacturingYear = value;
                _UpdateFieldName.Add("I_ManufacturingYear");
            }
        }
        public Decimal I_Total_Machinery_Cost
        {
            get
            {
                return this._I_Total_Machinery_Cost;
            }
            set
            {
                this._I_Total_Machinery_Cost = value;
                _UpdateFieldName.Add("I_Total_Machinery_Cost");
            }
        }
        public String I_Machinery_RTO_Reg_No
        {
            get
            {
                return this._I_Machinery_RTO_Reg_No;
            }
            set
            {
                this._I_Machinery_RTO_Reg_No = value;
                _UpdateFieldName.Add("I_Machinery_RTO_Reg_No");
            }
        }
        public String Item_Desc
        {
            get
            {
                return this._Item_Desc;
            }
            set
            {
                this._Item_Desc = value;
                _UpdateFieldName.Add("Item_Desc");
            }
        }
        public String MDBSC_RowStatus
        {
            get
            {
                return this._MDBSC_RowStatus;
            }
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
                return this._MDBSC_RowCreatedByUser_ID;
            }
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
                return this._MDBSC_RowCreatedByUserName;
            }
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
                return this._MDBSC_RowCreatedOn_DT;
            }
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
                return this._MDBSC_RowLupdnByUser_ID;
            }
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
                return this._MDBSC_RowLupdnUserName;
            }
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
                return this._MDBSC_RowLupdnOn_DT;
            }
            set
            {
                this._MDBSC_RowLupdnOn_DT = value;
                _UpdateFieldName.Add("MDBSC_RowLupdnOn_DT");
            }
        }

        #endregion
        #region Genric Methods
        public string Insert_Update(M_AT_Mst_ItemMasterBO sObject)
        {
            try
            {
                string strPkValue = "";
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

// ObjAT_Item.MItem_ID=ObjAT_Item.MItem_ID;
// ObjAT_Item.Fk_Company_ID=ObjAT_Item.Fk_Company_ID;
// ObjAT_Item.Fk_Branch_ID=ObjAT_Item.Fk_Branch_ID;
// ObjAT_Item.Fk_Year_ID=ObjAT_Item.Fk_Year_ID;
// ObjAT_Item.Fk_MIC_ID=ObjAT_Item.Fk_MIC_ID;
// ObjAT_Item.Fk_IG_ID=ObjAT_Item.Fk_IG_ID;
// ObjAT_Item.Fk_ISG_ID=ObjAT_Item.Fk_ISG_ID;
// ObjAT_Item.Fk_UOM_ID=ObjAT_Item.Fk_UOM_ID;
// ObjAT_Item.Item_SRNO=ObjAT_Item.Item_SRNO;
// ObjAT_Item.Item_Code=ObjAT_Item.Item_Code;
// ObjAT_Item.HSNCode=ObjAT_Item.HSNCode;
// ObjAT_Item.Item_Name=ObjAT_Item.Item_Name;
// ObjAT_Item.Item_Type=ObjAT_Item.Item_Type;
// ObjAT_Item.Item_Selling_Rate=ObjAT_Item.Item_Selling_Rate;
// ObjAT_Item.Item_Purchase_Rate=ObjAT_Item.Item_Purchase_Rate;
// ObjAT_Item.Item_Tax_GST_ID=ObjAT_Item.Item_Tax_GST_ID;
// ObjAT_Item.Item_Tax_GST_Effective_From=ObjAT_Item.Item_Tax_GST_Effective_From;
// ObjAT_Item.Item_CGST_Rate=ObjAT_Item.Item_CGST_Rate;
// ObjAT_Item.Item_SGST_Rate=ObjAT_Item.Item_SGST_Rate;
// ObjAT_Item.Item_IGST_Rate=ObjAT_Item.Item_IGST_Rate;
// ObjAT_Item.Item_Tax_CESS_ID=ObjAT_Item.Item_Tax_CESS_ID;
// ObjAT_Item.Item_Tax_CESS_Effective_From=ObjAT_Item.Item_Tax_CESS_Effective_From;
// ObjAT_Item.Item_CESS_Rate=ObjAT_Item.Item_CESS_Rate;
// ObjAT_Item.Item_CESS_Amt_Per_X_Product=ObjAT_Item.Item_CESS_Amt_Per_X_Product;
// ObjAT_Item.Is_Item_StockCodeSingle=ObjAT_Item.Is_Item_StockCodeSingle;
// ObjAT_Item.Is_Allow_Item_RateEdit=ObjAT_Item.Is_Allow_Item_RateEdit;
// ObjAT_Item.I_PartNo=ObjAT_Item.I_PartNo;
// ObjAT_Item.I_Asset_Code=ObjAT_Item.I_Asset_Code;
// ObjAT_Item.I_Machinery_Name=ObjAT_Item.I_Machinery_Name;
// ObjAT_Item.I_Make=ObjAT_Item.I_Make;
// ObjAT_Item.I_Model=ObjAT_Item.I_Model;
// ObjAT_Item.I_Engine_Number=ObjAT_Item.I_Engine_Number;
// ObjAT_Item.I_Chassis_Number=ObjAT_Item.I_Chassis_Number;
// ObjAT_Item.I_Machinery_Type=ObjAT_Item.I_Machinery_Type;
// ObjAT_Item.I_ManufacturingYear=ObjAT_Item.I_ManufacturingYear;
// ObjAT_Item.I_Total_Machinery_Cost=ObjAT_Item.I_Total_Machinery_Cost;
// ObjAT_Item.I_Machinery_RTO_Reg_No=ObjAT_Item.I_Machinery_RTO_Reg_No;
// ObjAT_Item.Item_Desc=ObjAT_Item.Item_Desc;
// ObjAT_Item.MDBSC_RowStatus=ObjAT_Item.MDBSC_RowStatus;
// ObjAT_Item.MDBSC_RowCreatedByUser_ID=ObjAT_Item.MDBSC_RowCreatedByUser_ID;
// ObjAT_Item.MDBSC_RowCreatedByUserName=ObjAT_Item.MDBSC_RowCreatedByUserName;
// ObjAT_Item.MDBSC_RowCreatedOn_DT=ObjAT_Item.MDBSC_RowCreatedOn_DT;
// ObjAT_Item.MDBSC_RowLupdnByUser_ID=ObjAT_Item.MDBSC_RowLupdnByUser_ID;
// ObjAT_Item.MDBSC_RowLupdnUserName=ObjAT_Item.MDBSC_RowLupdnUserName;
// ObjAT_Item.MDBSC_RowLupdnOn_DT=ObjAT_Item.MDBSC_RowLupdnOn_DT;



// MItem_ID.Text = "";
// Fk_Company_ID.Text = "";
// Fk_Branch_ID.Text = "";
// Fk_Year_ID.Text = "";
// Fk_MIC_ID.Text = "";
// Fk_IG_ID.Text = "";
// Fk_ISG_ID.Text = "";
// Fk_UOM_ID.Text = "";
// Item_SRNO.Text = "";
// Item_Code.Text = "";
// HSNCode.Text = "";
// Item_Name.Text = "";
// Item_Type.Text = "";
// Item_Selling_Rate.Text = "";
// Item_Purchase_Rate.Text = "";
// Item_Tax_GST_ID.Text = "";
// Item_Tax_GST_Effective_From.Text = "";
// Item_CGST_Rate.Text = "";
// Item_SGST_Rate.Text = "";
// Item_IGST_Rate.Text = "";
// Item_Tax_CESS_ID.Text = "";
// Item_Tax_CESS_Effective_From.Text = "";
// Item_CESS_Rate.Text = "";
// Item_CESS_Amt_Per_X_Product.Text = "";
// Is_Item_StockCodeSingle.Text = "";
// Is_Allow_Item_RateEdit.Text = "";
// I_PartNo.Text = "";
// I_Asset_Code.Text = "";
// I_Machinery_Name.Text = "";
// I_Make.Text = "";
// I_Model.Text = "";
// I_Engine_Number.Text = "";
// I_Chassis_Number.Text = "";
// I_Machinery_Type.Text = "";
// I_ManufacturingYear.Text = "";
// I_Total_Machinery_Cost.Text = "";
// I_Machinery_RTO_Reg_No.Text = "";
// Item_Desc.Text = "";
// MDBSC_RowStatus.Text = "";
// MDBSC_RowCreatedByUser_ID.Text = "";
// MDBSC_RowCreatedByUserName.Text = "";
// MDBSC_RowCreatedOn_DT.Text = "";
// MDBSC_RowLupdnByUser_ID.Text = "";
// MDBSC_RowLupdnUserName.Text = "";
// MDBSC_RowLupdnOn_DT.Text = "";



// ObjAT_Item.MItem_ID=MItem_ID.Text ;
// ObjAT_Item.Fk_Company_ID=Fk_Company_ID.Text ;
// ObjAT_Item.Fk_Branch_ID=Fk_Branch_ID.Text ;
// ObjAT_Item.Fk_Year_ID=Fk_Year_ID.Text ;
// ObjAT_Item.Fk_MIC_ID=Fk_MIC_ID.Text ;
// ObjAT_Item.Fk_IG_ID=Fk_IG_ID.Text ;
// ObjAT_Item.Fk_ISG_ID=Fk_ISG_ID.Text ;
// ObjAT_Item.Fk_UOM_ID=Fk_UOM_ID.Text ;
// ObjAT_Item.Item_SRNO=Item_SRNO.Text ;
// ObjAT_Item.Item_Code=Item_Code.Text ;
// ObjAT_Item.HSNCode=HSNCode.Text ;
// ObjAT_Item.Item_Name=Item_Name.Text ;
// ObjAT_Item.Item_Type=Item_Type.Text ;
// ObjAT_Item.Item_Selling_Rate=Item_Selling_Rate.Text ;
// ObjAT_Item.Item_Purchase_Rate=Item_Purchase_Rate.Text ;
// ObjAT_Item.Item_Tax_GST_ID=Item_Tax_GST_ID.Text ;
// ObjAT_Item.Item_Tax_GST_Effective_From=Item_Tax_GST_Effective_From.Text ;
// ObjAT_Item.Item_CGST_Rate=Item_CGST_Rate.Text ;
// ObjAT_Item.Item_SGST_Rate=Item_SGST_Rate.Text ;
// ObjAT_Item.Item_IGST_Rate=Item_IGST_Rate.Text ;
// ObjAT_Item.Item_Tax_CESS_ID=Item_Tax_CESS_ID.Text ;
// ObjAT_Item.Item_Tax_CESS_Effective_From=Item_Tax_CESS_Effective_From.Text ;
// ObjAT_Item.Item_CESS_Rate=Item_CESS_Rate.Text ;
// ObjAT_Item.Item_CESS_Amt_Per_X_Product=Item_CESS_Amt_Per_X_Product.Text ;
// ObjAT_Item.Is_Item_StockCodeSingle=Is_Item_StockCodeSingle.Text ;
// ObjAT_Item.Is_Allow_Item_RateEdit=Is_Allow_Item_RateEdit.Text ;
// ObjAT_Item.I_PartNo=I_PartNo.Text ;
// ObjAT_Item.I_Asset_Code=I_Asset_Code.Text ;
// ObjAT_Item.I_Machinery_Name=I_Machinery_Name.Text ;
// ObjAT_Item.I_Make=I_Make.Text ;
// ObjAT_Item.I_Model=I_Model.Text ;
// ObjAT_Item.I_Engine_Number=I_Engine_Number.Text ;
// ObjAT_Item.I_Chassis_Number=I_Chassis_Number.Text ;
// ObjAT_Item.I_Machinery_Type=I_Machinery_Type.Text ;
// ObjAT_Item.I_ManufacturingYear=I_ManufacturingYear.Text ;
// ObjAT_Item.I_Total_Machinery_Cost=I_Total_Machinery_Cost.Text ;
// ObjAT_Item.I_Machinery_RTO_Reg_No=I_Machinery_RTO_Reg_No.Text ;
// ObjAT_Item.Item_Desc=Item_Desc.Text ;
// ObjAT_Item.MDBSC_RowStatus=MDBSC_RowStatus.Text ;
// ObjAT_Item.MDBSC_RowCreatedByUser_ID=MDBSC_RowCreatedByUser_ID.Text ;
// ObjAT_Item.MDBSC_RowCreatedByUserName=MDBSC_RowCreatedByUserName.Text ;
// ObjAT_Item.MDBSC_RowCreatedOn_DT=MDBSC_RowCreatedOn_DT.Text ;
// ObjAT_Item.MDBSC_RowLupdnByUser_ID=MDBSC_RowLupdnByUser_ID.Text ;
// ObjAT_Item.MDBSC_RowLupdnUserName=MDBSC_RowLupdnUserName.Text ;
// ObjAT_Item.MDBSC_RowLupdnOn_DT=MDBSC_RowLupdnOn_DT.Text ;



// MItem_ID.Text =  dt.Rows[0]["MItem_ID"].ToString();
// Fk_Company_ID.Text =  dt.Rows[0]["Fk_Company_ID"].ToString();
// Fk_Branch_ID.Text =  dt.Rows[0]["Fk_Branch_ID"].ToString();
// Fk_Year_ID.Text =  dt.Rows[0]["Fk_Year_ID"].ToString();
// Fk_MIC_ID.Text =  dt.Rows[0]["Fk_MIC_ID"].ToString();
// Fk_IG_ID.Text =  dt.Rows[0]["Fk_IG_ID"].ToString();
// Fk_ISG_ID.Text =  dt.Rows[0]["Fk_ISG_ID"].ToString();
// Fk_UOM_ID.Text =  dt.Rows[0]["Fk_UOM_ID"].ToString();
// Item_SRNO.Text =  dt.Rows[0]["Item_SRNO"].ToString();
// Item_Code.Text =  dt.Rows[0]["Item_Code"].ToString();
// HSNCode.Text =  dt.Rows[0]["HSNCode"].ToString();
// Item_Name.Text =  dt.Rows[0]["Item_Name"].ToString();
// Item_Type.Text =  dt.Rows[0]["Item_Type"].ToString();
// Item_Selling_Rate.Text =  dt.Rows[0]["Item_Selling_Rate"].ToString();
// Item_Purchase_Rate.Text =  dt.Rows[0]["Item_Purchase_Rate"].ToString();
// Item_Tax_GST_ID.Text =  dt.Rows[0]["Item_Tax_GST_ID"].ToString();
// Item_Tax_GST_Effective_From.Text =  dt.Rows[0]["Item_Tax_GST_Effective_From"].ToString();
// Item_CGST_Rate.Text =  dt.Rows[0]["Item_CGST_Rate"].ToString();
// Item_SGST_Rate.Text =  dt.Rows[0]["Item_SGST_Rate"].ToString();
// Item_IGST_Rate.Text =  dt.Rows[0]["Item_IGST_Rate"].ToString();
// Item_Tax_CESS_ID.Text =  dt.Rows[0]["Item_Tax_CESS_ID"].ToString();
// Item_Tax_CESS_Effective_From.Text =  dt.Rows[0]["Item_Tax_CESS_Effective_From"].ToString();
// Item_CESS_Rate.Text =  dt.Rows[0]["Item_CESS_Rate"].ToString();
// Item_CESS_Amt_Per_X_Product.Text =  dt.Rows[0]["Item_CESS_Amt_Per_X_Product"].ToString();
// Is_Item_StockCodeSingle.Text =  dt.Rows[0]["Is_Item_StockCodeSingle"].ToString();
// Is_Allow_Item_RateEdit.Text =  dt.Rows[0]["Is_Allow_Item_RateEdit"].ToString();
// I_PartNo.Text =  dt.Rows[0]["I_PartNo"].ToString();
// I_Asset_Code.Text =  dt.Rows[0]["I_Asset_Code"].ToString();
// I_Machinery_Name.Text =  dt.Rows[0]["I_Machinery_Name"].ToString();
// I_Make.Text =  dt.Rows[0]["I_Make"].ToString();
// I_Model.Text =  dt.Rows[0]["I_Model"].ToString();
// I_Engine_Number.Text =  dt.Rows[0]["I_Engine_Number"].ToString();
// I_Chassis_Number.Text =  dt.Rows[0]["I_Chassis_Number"].ToString();
// I_Machinery_Type.Text =  dt.Rows[0]["I_Machinery_Type"].ToString();
// I_ManufacturingYear.Text =  dt.Rows[0]["I_ManufacturingYear"].ToString();
// I_Total_Machinery_Cost.Text =  dt.Rows[0]["I_Total_Machinery_Cost"].ToString();
// I_Machinery_RTO_Reg_No.Text =  dt.Rows[0]["I_Machinery_RTO_Reg_No"].ToString();
// Item_Desc.Text =  dt.Rows[0]["Item_Desc"].ToString();
// MDBSC_RowStatus.Text =  dt.Rows[0]["MDBSC_RowStatus"].ToString();
// MDBSC_RowCreatedByUser_ID.Text =  dt.Rows[0]["MDBSC_RowCreatedByUser_ID"].ToString();
// MDBSC_RowCreatedByUserName.Text =  dt.Rows[0]["MDBSC_RowCreatedByUserName"].ToString();
// MDBSC_RowCreatedOn_DT.Text =  dt.Rows[0]["MDBSC_RowCreatedOn_DT"].ToString();
// MDBSC_RowLupdnByUser_ID.Text =  dt.Rows[0]["MDBSC_RowLupdnByUser_ID"].ToString();
// MDBSC_RowLupdnUserName.Text =  dt.Rows[0]["MDBSC_RowLupdnUserName"].ToString();
// MDBSC_RowLupdnOn_DT.Text =  dt.Rows[0]["MDBSC_RowLupdnOn_DT"].ToString();
