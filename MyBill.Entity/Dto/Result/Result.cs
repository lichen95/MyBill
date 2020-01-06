/*
*┌────────────────────────────────────────────────┐
*│　描   述：Result                                                    
*│　作   者：lc                                              
*│　版   本：1.0                                              
*│　创建时间：2020-01-06 14:24:30                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBill.Entity
{
    public class Result : IResult
    {
        #region Implementation of ICustomResult
        public Result() { Success = true; Message = ""; }
        public Result(bool success, string msg = "")
        {
            Success = success;
            Message = msg;
        }

        public bool Success { get; set; }

        public string Message { get; set; }

        public void Succeed()
        {
            this.Success = true;
        }

        public void Fail()
        {
            this.Success = false;
        }

        public void Succeed(string message)
        {
            this.Success = true;
            this.Message = message;
        }

        public void Fail(string message)
        {
            this.Success = false;
            this.Message = message;
        }

        #endregion
    }

    public class Result<T> : Result, IResult<T>
    {
        #region Implementation of ICustomResult<T>

        public T Value { get; set; }

        #endregion
    }
}
