/*
*┌────────────────────────────────────────────────┐
*│　描   述：角色表                                                    
*│　作   者：lc                                              
*│　版   本：1.0                                              
*│　创建时间：2019-12-06 12:02:58                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyBill.Entity
{
    /// <summary>
    /// 角色表
    /// </summary>
    public class Roles
    {
        public Roles()
        {
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
            IsEnable = 1;
        }

        /// <summary>
        /// 主键id
        /// </summary>
        [Key]
        public System.Int32 Id { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        public System.String Desc { get; set; }

        /// <summary>
        /// 模块
        /// </summary>
        public System.Int32 Module { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime CreateDate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime UpdateDate { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public System.Int32 IsEnable { get; set; }
    }
}
