using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace JEMEAWAPI.RetWebObj
{
      
    public class JsonRetMessage
    {
       // Variable Declaration
        private bool _ErrorState;
        private bool _RetStatus;
        private string _RetMsg;
        private object _RetData;
        //Properties
        public bool ErrorState
        {
            get
            {
                return _ErrorState;
            }

        }
        public bool RetStatus
        {
            get
            {
                return _RetStatus;
            }

        }
        public string RetMsg
        {
            get
            {
                return _RetMsg;
            }
        }
        public object RetData
        {
            get
            {
                return _RetData;
            }
        }

        //Constructor
        public JsonRetMessage(bool mvErrorState, bool mvRetStatus, string mvRetMsg)
        {
            _ErrorState = mvErrorState;
            _RetStatus = mvRetStatus;
            _RetMsg = mvRetMsg; 
        }

        public JsonRetMessage(bool mvErrorState, bool mvRetStatus, string mvRetMsg, object mvObjData)
        {
            _ErrorState = mvErrorState;
            _RetStatus = mvRetStatus;
            _RetMsg = mvRetMsg;
            _RetData = mvObjData;
            
        }
    }
}