using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;

namespace Podcaster.Web.Controllers
{
    [ExcludeFromCodeCoverage]
    public class HomeController : Controller
    {
        /*[OutputCache(Duration = 43200)]*/
        public ActionResult About()
        {
            return this.View();
        }

        /*[OutputCache(Duration = 43200)]*/
        public ActionResult Contact()
        {
            return this.View();
        }

        /*[OutputCache(Duration = 60 * 60)]*/
        public ActionResult Index()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.RedirectToAction("Index", "Search");
            }

            return this.View();
        }
    }
}