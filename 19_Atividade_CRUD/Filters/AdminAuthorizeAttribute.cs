using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Http;

namespace _19_Atividade_CRUD.Filters
{
    public class AdminAuthorizeAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!IsUserAuthorized(context.HttpContext))
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary
{
{ "controller", "Login" },
{ "action", "Index" },
{ "area", "" },
});
            }
        }
        private bool IsUserAuthorized(HttpContext httpContext)
        {
            return httpContext.Session.GetInt32("UsuarioId") == null ? false : true;
        }
    }
}