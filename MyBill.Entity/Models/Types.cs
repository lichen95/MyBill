/*
*┌────────────────────────────────────────────────┐
*│　描   述：类型表                                                    
*│　作   者：lc                                              
*│　版   本：1.0                                              
*│　创建时间：2019-12-06 12:03:20                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyBill.Entity
{
    /// <summary>
    /// 类型表
    /// </summary>
    public class Types
    { 
        public Types()
        {
            IsEnable = 1;
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
        }

        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public System.Int32 Id { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        public System.String Desc { get; set; }

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
