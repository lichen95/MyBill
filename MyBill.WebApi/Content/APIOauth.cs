using MyBill.Common;
using MyBill.Entity;
using MyBill.Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace MyBill.WebApi
{
    /// <summary>
    /// 需要验证token
    /// </summary>
    public class Oauth : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            IEnumerable<KeyValuePair<string, string>> data = actionContext.Request.GetQueryNameValuePairs();
            var allanyone = actionContext.ActionDescriptor.GetCustomAttributes<AllowAll>();
            if (allanyone.Count == 0)
            {
                var token = data.FirstOrDefault(k => k.Key.ToLower() == "token");
                var client = data.FirstOrDefault(k => k.Key.ToLower() == "clientid");
                int clientId = 1;
                if (client.Key != null && !string.IsNullOrEmpty(client.ToString()))
                {
                    int.TryParse(client.Value, out clientId);
                }
                if (token.Key != null && !string.IsNullOrEmpty(token.Value) && token.Value != "token")
                {
                    var currentUser =new MyBill.Service.UserService().GetUser(token.Value) ?? new UserModel();
                    currentUser.ClientId = clientId;

                    if (actionContext.ActionArguments.ContainsKey("user"))
                        actionContext.ActionArguments["user"] = currentUser;
                    else
                        actionContext.ActionArguments.Add("user", currentUser);


                }
                else
                {
                    ReturnResult rr = new ReturnResult() { Code = 1, Msg = "无权限_[Token Error]" };
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, JsonHelper.ToJson(rr));
                }
            }
            base.OnActionExecuting(actionContext);
        }
    }

    /// <summary>
    /// 允许所有请求
    /// </summary>
    public class AllowAll : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            IEnumerable<KeyValuePair<string, string>> data = actionContext.Request.GetQueryNameValuePairs();
            var client = data.FirstOrDefault(k => k.Key.ToLower() == "clientid");
            int clientId = 1;
            if (client.Key != null && !string.IsNullOrEmpty(client.ToString()))
            {
                int.TryParse(client.Value, out clientId);
            }
            var token = data.FirstOrDefault(k => k.Key.ToLower() == "token");
            if (token.Key != null && !string.IsNullOrEmpty(token.Value) && token.Value != "token")
            {
                var currentUser = new MyBill.Service.UserService().GetUser(token.Value) ?? new UserModel();
                currentUser.ClientId = clientId;
                actionContext.ActionArguments.Add("user", currentUser);

                base.OnActionExecuting(actionContext);
            }
        }
    }

    public static class ControllerExtension
    {
        public static UserModel GetUser(this ApiController controller)
        {
            if (controller.ActionContext.ActionArguments.ContainsKey("user"))
                return controller.ActionContext.ActionArguments["user"] as UserModel;
            else
                return null;
        }
    }
}
