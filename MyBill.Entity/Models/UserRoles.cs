/*
*┌────────────────────────────────────────────────┐
*│　描   述：用户角色关联表                                                    
*│　作   者：lc                                              
*│　版   本：1.0                                              
*│　创建时间：2019-12-06 12:03:30                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyBill.Entity
{
    /// <summary>
    /// 用户角色关联表
    /// </summary>
    public class UserRoles
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public System.Int32 Id { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        public System.Int32 UserId { get; set; }

        /// <summary>
        /// 角色Id
        /// </summary>
        public System.Int32 RoleId { get; set; }
    }
}
