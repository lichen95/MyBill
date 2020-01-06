/*
*┌────────────────────────────────────────────────┐
*│　描   述：UserService                                                    
*│　作   者：lc                                              
*│　版   本：1.0                                              
*│　创建时间：2019-12-06 13:35:40                        
*└────────────────────────────────────────────────┘
*/
using MyBill.Common;
using MyBill.Entity;
using MyBill.IService;
using MyBill.Service.Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBill.Service
{
    public class UserService : IUserService
    {
        public PageResult<Users> Query(SearchUsers model)
        {

        }

        public int Add(Users t)
        {
            var sql =string.Format("insert into Users(UserName,Password,NickName,Mobile,Gender,CreateDate,UpdateDate,LastLoginDate,IsEnable) value(@UserName,@Password,@NickName,@Mobile,@Gender,@CreateDate,@UpdateDate,@LastLoginDate,@IsEnable)");
            return DbContext.Execute(sql,t);
        }

        public UserModel GetUser(string token)
        {
            var sql = string.Format("select * from oauth where token='{0}'", token);
            var oauth= DbContext.QueryFirstOrDefault<Oauth>(sql);
            var user = QueryById(oauth.UserId);
            UserModel result = new UserModel()
            {
                Id=user.Id,
                UserName=user.UserName,
                Nickname =user.NickName,

            };
            return result;
        }

        public Oauth Login(string name, string pwd)
        {
            var sql = string.Format("select * from users where username='{0}' and password='{1}'",name,pwd);
            var user= DbContext.QueryFirstOrDefault<Users>(sql);
            if (user != null)
            {
                var oauth = DbContext.QueryFirstOrDefault<Oauth>(string.Format("select * from oauth where userid='{0}'",user.Id));
                if (oauth != null)
                {
                    oauth.Code = AuthHelper.GetToken();
                    oauth.Token = AuthHelper.GetToken();
                    oauth.Expires = DateTime.Now.AddMinutes(2);
                    oauth.UpdateDate = DateTime.Now;
                    var updOauth = string.Format("update oauth set code=@code,token=@token,expires=@expires,updatedate=@updatedate where id=@id");
                    var i= DbContext.Execute(updOauth, oauth);
                }
                else
                {
                    Oauth oa = new Oauth()
                    {
                        Code= AuthHelper.GetToken(),
                        Token= AuthHelper.GetToken(),
                        UserId=user.Id
                    };
                    var insOauth = string.Format("insert into oauth(code,token,userid,expires,updatedate,createdate) value(@code,@token,@userid,@expires,@updatedate,@createdate)");
                    var i = DbContext.Execute(insOauth, oa);
                    oauth = oa;
                }
                return oauth;
            }
            else
            {
                return new Oauth();
            }


        }

        public Users QueryById(int Id)
        {
            var sql = string.Format("select * from users where id='{0}'",Id);
            return DbContext.QueryFirstOrDefault<Users>(sql);
        }

        public int Update(Users t)
        {
            var sql = string.Format("update Users set UserName=@UserName,Password=@Password,NickName=@NickName,Mobile=@Mobile,Gender=@Gender,CreateDate=@CreateDate,UpdateDate=@UpdateDate,LastLoginDate=@LastLoginDate,IsEnable=@IsEnable where id=@id");
            return DbContext.Execute(sql, t);
        }
    }
}
