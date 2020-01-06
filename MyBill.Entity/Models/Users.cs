/*
*┌────────────────────────────────────────────────┐
*│　描   述：用户表                                                    
*│　作   者：lc                                              
*│　版   本：1.0                                              
*│　创建时间：2019-12-06 11:55:12                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyBill.Entity
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class Users
    {
        public Users()
        {
            Gender = 1;
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
            LastLoginDate = DateTime.Now;
            IsEnable = 1;
        }

        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public System.Int32 Id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public System.String UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public System.String Password { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public System.String NickName { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public System.String Mobile { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public System.Int32 Gender { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public System.DateTime CreateDate { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public System.DateTime UpdateDate { get; set; }

        /// <summary>
        /// 最后登录时间
        /// </summary>
        public System.DateTime LastLoginDate { get; set; }

        /// <summary>
        /// 是否启用 
        /// </summary>
        public System.Int32 IsEnable { get; set; }
    }
}
