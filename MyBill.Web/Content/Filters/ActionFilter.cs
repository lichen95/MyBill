using Microsoft.AspNetCore.Mvc.Filters;
using MyBill.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBill.Web.Content.Filters
{
    public class Logged : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var token = context.HttpContext.Request.Token();
            if (string.IsNullOrEmpty(token))
            {
                context.HttpContext.Response.Redirect("/home/login?return=" + context.HttpContext.Request.Path);
            }
            else
            {
                base.OnActionExecuting(context);
            }
        }
    }
}
