/*
*┌────────────────────────────────────────────────┐
*│　描   述：权限表                                                    
*│　作   者：lc                                              
*│　版   本：1.0                                              
*│　创建时间：2019-12-06 12:02:50                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyBill.Entity
{
    /// <summary>
    /// 权限表
    /// </summary>
    public class Permissions
    {
        public Permissions()
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
        /// 权限名称
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        public System.String Desc { get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        public System.String Area { get; set; }

        /// <summary>
        /// 控制器
        /// </summary>
        public System.String Controller { get; set; }

        /// <summary>
        /// 方法
        /// </summary>
        public System.String Action { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public System.Int32 IsEnable { get; set; }

        /// <summary>
        /// 分组
        /// </summary>
        public System.String Group { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime CreateDate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime UpdateDate { get; set; }
    }
}
