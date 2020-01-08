/*
*┌────────────────────────────────────────────────┐
*│　描   述：PageResult                                                    
*│　作   者：lc                                              
*│　版   本：1.0                                              
*│　创建时间：2019-12-06 13:30:04                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBill.Entity
{
    /// <summary>
    /// 分页返回结果
    /// </summary>
    public class PageResult
    {
        /// <summary>
        /// 状态码
        /// 0：成功，1：失败，其他自定义
        /// </summary>
        public int Code { get; set; }
        public int Index { get; set; }
        /// <summary>
        /// 总页数
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// 总记录数
        /// </summary>
        public int RCount { get; set; }
        public object Data { get; set; }
        public string Msg { get; set; }
    }

    public class PageResult<T>
    {
        public PageResult()
        { }
        public PageResult(int page, int size)
        {
            Page = page;
            Size = size;
        }
        /// <summary>
        /// 状态码
        /// 0：成功，1：失败，其他自定义
        /// </summary>
        public int Code { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }

        private int pages;
        /// <summary>
        /// 总页数
        /// </summary>
        public int Pages
        {
            set { pages = value; }

            get
            {
                if (RCount > 0 && Size > 0)
                {
                    return (int)Math.Ceiling((double)RCount / (double)Size);
                }
                else if (pages > 0)
                {
                    return pages;
                }
                else
                    return 0;
            }
        }
        /// <summary>
        /// 总记录数
        /// </summary>
        public int RCount { get; set; }
        public List<T> Data { get; set; }
        public string Msg { get; set; }
    }


}
