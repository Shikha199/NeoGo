using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace JEMEAWAPI.Models
{
    
    public class AppUserModel
    { 
        public  Int64 UserID { get; set; }
        public string LoginID { get; set; }
        public string UserName { get; set; }
        public Int64 CompanyID { get; set; }
        public Int64 BranchID { get; set; }
        public Int64 HOBranchID { get; set; }
        public Int64 ActiveBranchID { get; set; }

        public Int64 RoleID { get; set; }
        public Int64 TypeID { get; set; }

        
        public string Password { get; set; }
        public string RoleDesc { get; set; }
        public string TypeDesc { get; set; } 

        public string UserStatus { get; set; }
         

        public string CompanyName { get; set; }
        public string BranchName { get; set; } 
    }

    public class AppInfoModel
    {
        public Int64 APIUserID { get; set; }
        public string APIKey { get; set; }
        public string APISecret { get; set; }        
        public string TokenID { get; set; }
        public string SessionID { get; set; }
      
    }




}
