using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace web_app.Filters
{
    public class UsuarioLogado : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Session.Get("login") == null)
                context.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "login" }, { "action", "login" } });

            base.OnActionExecuting(context);
        }
    }
}
