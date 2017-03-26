using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;

namespace Podcaster.Web.Areas.Error
{
    [ExcludeFromCodeCoverage]
    public class ErrorAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Error";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Error_default",
                "Error/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional });
        }
    }
}