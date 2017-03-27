using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;

namespace Podcaster.Web.Areas.Administrator
{
    [ExcludeFromCodeCoverage]
    public class AdministratorAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Administrator";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Administrator_Default",
                "Administrator/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional });
        }
    }
}