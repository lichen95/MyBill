using System;
using MyBill.Entity;
using MyBill.IService.IBase;

namespace MyBill.IService
{
    public interface ITypeService:IBaseService<Types>
    {
        PageResult<Types> Query(SearchTypes model);
    }
}
