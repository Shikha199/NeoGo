using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace JEMEAWAPI.APIAL
{
    public   class MPAL
    {
        public static void ParseObject(Object obj)
        {
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                if (property.PropertyType == typeof(string) && property.GetValue(obj, null) == null)
                {

                    string pname = property.Name;
                    property.SetValue(obj, "", null);

                }

                //MessageBox.Show("Name: " + property.Name + ", Value: " + property.GetValue(obj, null));
            }
        } 
    }
}