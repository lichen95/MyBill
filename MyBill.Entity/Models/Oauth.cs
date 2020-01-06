/*
*┌────────────────────────────────────────────────┐
*│　描   述：保存用户令牌/授权码                                                    
*│　作   者：lc                                              
*│　版   本：1.0                                              
*│　创建时间：2020-01-06 16:05:27                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyBill.Entity
{
    /// <summary>
    /// 授权信息表
    /// </summary>
    public class Oauth
    {
        public Oauth()
        {
            Expires = DateTime.Now.AddMinutes(2);
            UpdateDate = DateTime.Now;
            CreateDate = DateTime.Now;
        }

        /// <summary>
        /// 主键id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 令牌
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 授权码
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        public DateTime Expires { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate { get; set; }

    }
}
