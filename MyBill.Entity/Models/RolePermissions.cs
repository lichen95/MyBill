/*
*┌────────────────────────────────────────────────┐
*│　描   述：角色权限关联表                                                    
*│　作   者：lc                                              
*│　版   本：1.0                                              
*│　创建时间：2019-12-06 12:03:45                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyBill.Entity
{
    /// <summary>
    /// 角色权限关联表
    /// </summary>
    public class RolePermissions
    {
        public RolePermissions()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public System.Int32 Id { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        public System.Int32 RoleId { get; set; }

        /// <summary>
        /// 权限id
        /// </summary>
        public System.Int32 PermissionId { get; set; }
    }
}
