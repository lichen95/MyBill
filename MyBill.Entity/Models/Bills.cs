/*
*┌────────────────────────────────────────────────┐
*│　描   述：账单表,记录收入与支出                                                   
*│　作   者：lc                                              
*│　版   本：1.0                                              
*│　创建时间：2019-12-06 12:03:09                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyBill.Entity
{
    /// <summary>
    /// 账单表
    /// </summary>
    class Bills
    {
        public Bills()
        {
            CreateDate = DateTime.Now;
        }

        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public System.Int32 Id { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public System.Int32 UserId { get; set; }

        /// <summary>
        /// 类型id
        /// </summary>
        public System.Int32 TypeId { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public System.Decimal Price { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime CreateDate { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        public System.String Desc { get; set; }
    }
}
