/*
*┌────────────────────────────────────────────────┐
*│　描   述：JsonHelper                                                    
*│　作   者：lc                                              
*│　版   本：1.0                                              
*│　创建时间：2020-01-06 15:38:24                        
*└────────────────────────────────────────────────┘
*/
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBill.Common
{
    public static class JsonHelper
    {
        public static string ToJson(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T ToObject<T>(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch
            {
                return default(T);
            }
        }
    }
}
