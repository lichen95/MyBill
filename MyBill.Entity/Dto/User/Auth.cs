/*
*┌────────────────────────────────────────────────┐
*│　描   述：Auth                                                    
*│　作   者：lc                                              
*│　版   本：1.0                                              
*│　创建时间：2020-01-06 16:53:07                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBill.Entity.Dto.User
{
    public class Auth : ReturnResult
    {
        public Auth()
        {
            Code = 0;
            Msg = "";
            Nickname = "";
            Avatar = "";
            UserId = 0;
            Token = "";
            Expires = DateTime.Now;
            VIP = 0;
            JoinId = 0;
            Obj = "";
            IsAuth = false;
            Points = 0;
            IsPurchaseGrouper = false;
        }

        public Auth(int code, string msg)
        {
            Code = code;
            Msg = msg;
            Nickname = "";
            Avatar = "";
            UserId = 0;
            Token = "";
            IsAuth = false;
            Expires = DateTime.Now;
            JoinId = 0;
        }

        public string Nickname { get; set; }

        public string Company { get; set; }

        public string Avatar { get; set; }

        public int UserId { get; set; }

        public string Mobile { get; set; }

        public string Token { get; set; }

        public DateTime? Expires { get; set; }

        public double VIP { get; set; }

        public bool IsAuth { get; set; }

        public bool IsCommonUser { get; set; }

        public int JoinId { get; set; }
        public DateTime JoinTime { get; set; }

        public bool IsBoss { get; set; }
        public bool IsManager { get; set; }

        public int Points { get; set; }
        public bool IsPurchaseGrouper { get; set; }
    }
}
