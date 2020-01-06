/*
*┌────────────────────────────────────────────────┐
*│　描   述：ReturnResult                                                    
*│　作   者：lc                                              
*│　版   本：1.0                                              
*│　创建时间：2019-12-06 13:30:20                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBill.Entity.Dto
{
    public class ReturnResult
    {
        public ReturnResult(int code=0,string msg="",Object obj=null)
        {
            Code = code;
            Msg = msg;
            Obj = obj;
        }
        public int Code { get; set; }

        public string Msg { get; set; }

        public Object Obj { get; set; }
    }

    public class ReturnResult<T> where T:class,new()
    {
        public int Code { get; set; }

        public string Msg { get; set; }

        public T Obj { get; set; }
    }
}
