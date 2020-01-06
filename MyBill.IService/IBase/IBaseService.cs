/*
*┌────────────────────────────────────────────────┐
*│　描   述：IBaseService                                                    
*│　作   者：lc                                              
*│　版   本：1.0                                              
*│　创建时间：2019-12-06 13:25:29                        
*└────────────────────────────────────────────────┘
*/
using MyBill.Entity.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBill.IService.IBase
{
    public interface IBaseService<T> where T: class,new()
    {
        int Add(T t);
        int Update(T t);
        T QueryById(int Id);
    }
}
