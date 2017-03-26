using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Podcaster.Web.Attributes
{
    [ExcludeFromCodeCoverage]
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            var roles = this.Roles.Split(',');
            var isAuthenticated = filterContext.HttpContext.Request.IsAuthenticated;
            var isInRole = roles.Any(filterContext.HttpContext.User.IsInRole);

            if (isAuthenticated && !isInRole)
            {
                filterContext.Result = new ViewResult() { ViewName = "~/Views/Shared/_NotAuthorized.cshtml" };
            }
            else
            {
                base.HandleUnauthorizedRequest(filterContext);
    }
}
    }
}