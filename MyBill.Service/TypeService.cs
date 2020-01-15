using System;
using MyBill.Entity;
using MyBill.IService;
using MyBill.Service.Dapper;

namespace MyBill.Service
{
    public class TypeService:ITypeService
    {
        public TypeService()
        {
        }

        public int Add(Types t)
        {
            var sql = string.Format("insert into types(Name,Desc,CreateDate,UpdateDate,IsEnable) value(@Name,@Desc,@CreateDate,@UpdateDate,@IsEnable)");
            return DbContext.Execute(sql, t);
        }

        public PageResult<Types> Query(SearchTypes model)
        {
            var sql = "select * from types";
            var types = DbContext.Query<Types>(sql);


            return new PageResult<Types>();

        }

        public Types QueryById(int Id)
        {
            var sql = string.Format("select * from types where id='{0}'",Id);
            return DbContext.QueryFirstOrDefault<Types>(sql);
        }

        public int Update(Types t)
        {
            throw new NotImplementedException();
        }
    }
}
