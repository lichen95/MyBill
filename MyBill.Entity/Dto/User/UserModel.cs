/*
*┌────────────────────────────────────────────────┐
*│　描   述：UserModel                                                    
*│　作   者：lc                                              
*│　版   本：1.0                                              
*│　创建时间：2020-01-06 15:35:35                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBill.Entity
{
    public class UserModel
    {
        public UserModel()
        {
            Permissions = new List<Permissions>();
        }
        /// <summary>
        /// 用户编号
        /// </summary>
        public int Id { get; set; }

        public string UserName { get; set; }
        /// <summary>
        /// 用户账号
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string Nickname { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string Avatar { get; set; }

        public string OpenId { get; set; }

        /// <summary>
        /// 授权码
        /// </summary>
        public string Token { get; set; }

        public string Company { get; set; }

        public string ComPhone { get; set; }

        public string ComEmail { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public DateTime CreateTime { get; set; }

        public bool IsAuth { get; set; }

        public int ClientId { get; set; }

        public bool IsManager { get; set; }

        public List<Permissions> Permissions { get; set; }
        public List<Permissions> AllPermissions { get; set; }
        public List<Roles> Roles { get; set; }
    }
}
