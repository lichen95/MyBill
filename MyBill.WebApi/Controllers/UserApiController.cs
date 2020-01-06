using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBill.Entity.Dto;
using MyBill.Entity;
using MyBill.IService;

namespace MyBill.WebApi.Controllers
{
    [EnableCors("AllowSameDomain")]
    [Route("api/[controller]/[action]")]
    [Oauth]
    [ApiController]
    public class UserApiController : ControllerBase
    {
        private readonly IUserService _service;
        public UserApiController(IUserService service)
        {
            _service = service;
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="users">用户信息</param>
        /// <returns></returns>
        [HttpPost]
        [AllowAll]
        public ReturnResult AddUser(Users users)
        {
            var result = _service.Add(users);
            if (result > 0)
            {
                return new ReturnResult();
            }
            else
            {
                return new ReturnResult(1,"添加失败");
            }
        }

        [HttpPost]
        [AllowAll]
        public ReturnResult Login(Users users)
        {
            var result = _service.Login(users.UserName,users.Password);
            if (result!=null)
            {
                return new ReturnResult(0,"登录成功");
            }
            else
            {
                return new ReturnResult(1, "用户名或密码错误");
            }
        }
    }
}