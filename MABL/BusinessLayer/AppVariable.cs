using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MABL.BL
{
    public static class AppVariable
    {
        public static string Project_Constant(string ConstantType)
        {
            string StrRetCnstType = "";
            try
            {
                if (ConstantType == "RptBrowse")
                {
                    StrRetCnstType = "";
                    StrRetCnstType = "/tgim";
                }
                if (ConstantType == "UploadDIR")
                {
                    StrRetCnstType = "";
                    StrRetCnstType = "~/AppUpload";
                }
                 
                return StrRetCnstType;
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public static string Customer_Document_Location(string FolderPath)
        {
            string StrRetCnstType = "";
            string var_RootFoldare = "~/AppUpload/CustomerData";
            try
            {
                if (FolderPath == "SETUP")
                {
                    StrRetCnstType = "";
                    StrRetCnstType = var_RootFoldare + "/Setup/Logo";
                }
                if (FolderPath == "UExcel")
                {
                    StrRetCnstType = "";
                    StrRetCnstType = var_RootFoldare + "/GST/UExcel";
                }
                   

                return StrRetCnstType;
            }
            catch (Exception ex)
            {
                return "";
            }
        }

    }
}
