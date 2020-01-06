/*
*┌────────────────────────────────────────────────┐
*│　描   述：SessionUser                                                    
*│　作   者：lc                                              
*│　版   本：1.0                                              
*│　创建时间：2020-01-06 14:23:27                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBill.Entity
{
    public class SessionUser : Result
    {
        public SessionUser()
        {
        }

        public SessionUser(bool success, string msg = "") : base(success, msg) { }
        public string Name { get; set; }

        public string Company { get; set; }

        public string Avatar { get; set; }

        public int Id { get; set; }

        public string Mobile { get; set; }

        public string Token { get; set; }

    }
}
