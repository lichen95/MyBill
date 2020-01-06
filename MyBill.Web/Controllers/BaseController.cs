using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBill.Entity;

namespace MyBill.Web.Controllers
{
    public class BaseController : Controller
    {
        public new SessionUser User
        {
            get
            {
                return Request.GetUser();
            }
        }
    }

    public static class ControllerExtensions
    {
        public static string Token(this HttpRequest request)
        {
            var token = "";
            request.Cookies.TryGetValue("token", out token);
            if (string.IsNullOrEmpty(token) || token.Length != 32)
                token = "";
            return token;
        }
        public static SessionUser GetUser(this ControllerBase controller)
        {
            return controller.HttpContext.Request.GetUser();
        }
        public static SessionUser GetUser(this HttpRequest request)
        {
            //var _service = request.HttpContext.RequestServices.GetService(typeof(UserService)) as UserService;
            var token = request.Token();
            if (string.IsNullOrEmpty(token))
            {
                return new SessionUser(false);
            }
            else
            {
                //return _service.GetAuth(token);
                return new SessionUser(false);
            }
        }
    }
}