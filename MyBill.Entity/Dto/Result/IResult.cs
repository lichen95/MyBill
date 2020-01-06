/*
*┌────────────────────────────────────────────────┐
*│　描   述：IResult                                                    
*│　作   者：lc                                              
*│　版   本：1.0                                              
*│　创建时间：2020-01-06 14:25:06                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBill.Entity
{
    public interface IResult
    {
        bool Success { get; set; }
        string Message { get; set; }
        void Succeed();
        void Fail();
        void Succeed(string message);
        void Fail(string message);
    }

    public interface IResult<T> : IResult
    {
        T Value { get; set; }
    }
}
