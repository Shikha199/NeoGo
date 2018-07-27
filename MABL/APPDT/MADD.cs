using MaheshAF18.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MABL.APPDT
{
    public static class MADD
    {      
        public static DataTable DT_PaymentMode(string var_value, string var_Text, string var_SelectText)
        {

            try
            {
                DataTable Dt_DD = new DataTable();
                Dt_DD.Columns.Add("value", typeof(string));
                Dt_DD.Columns.Add("Text", typeof(string));

                Dt_DD.Rows.Add("", "Select " + var_SelectText);
                Dt_DD.Rows.Add("Cheque", "Cheque");
                Dt_DD.Rows.Add("Cash", "Cash");
                Dt_DD.Rows.Add("NEFT/RTGS", "NEFT/RTGS");
                Dt_DD.Rows.Add("Card Payment", "Card Payment");
                return Dt_DD;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable DT_Taxpayer_Type(string var_value, string var_Text, string var_SelectText)
        {

            try
            {
                DataTable Dt_DD = new DataTable();
                Dt_DD.Columns.Add("value", typeof(string));
                Dt_DD.Columns.Add("Text", typeof(string));

                Dt_DD.Rows.Add("", "Select " + var_SelectText);
                Dt_DD.Rows.Add("Registered Taxpayer", "Registered Taxpayer");
                Dt_DD.Rows.Add("Composite Taxpayer", "Composite Taxpayer");
                Dt_DD.Rows.Add("Unregistered", "Unregistered");
                
                
                return Dt_DD;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable DT_DCN_Reason(string var_value, string var_Text, string var_SelectText)
        {

            try
            {
                DataTable Dt_DD = new DataTable();
                Dt_DD.Columns.Add("value", typeof(string));
                Dt_DD.Columns.Add("Text", typeof(string));

                Dt_DD.Rows.Add("", "Select " + var_SelectText);
                Dt_DD.Rows.Add("01-Sales Return", "01-Sales Return");
                Dt_DD.Rows.Add("02-Post Sale Discount", "02-Post Sale Discount");
                Dt_DD.Rows.Add("03-Deficiency in services", "03-Deficiency in services");
                Dt_DD.Rows.Add("04-Correction in Invoice", "04-Correction in Invoice");
                Dt_DD.Rows.Add("05-Change in POS", "05-Change in POS");
                Dt_DD.Rows.Add("06-Finalization of Provisional assessment", "06-Finalization of Provisional assessment");
                Dt_DD.Rows.Add("07-Others", "07-Others");
                
                    
                        
                            

                return Dt_DD;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
    }
}
