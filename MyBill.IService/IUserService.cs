/*
*┌────────────────────────────────────────────────┐
*│　描   述：IUserService                                                    
*│　作   者：lc                                              
*│　版   本：1.0                                              
*│　创建时间：2019-12-06 13:34:22                        
*└────────────────────────────────────────────────┘
*/
using MyBill.Entity;
using MyBill.IService.IBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBill.IService
{
    public interface IUserService:IBaseService<Users>
    {
        Oauth Login(string name,string pwd);

        UserModel GetUser(string token);
    }
}
