using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web.Hosting;
using System.Web.Mvc;

using Podcaster.Web.Models;
using Podcaster.Web.Models.Podcast;

namespace Podcaster.Web.Controllers
{
    [ExcludeFromCodeCoverage]
    public class HomeController : Controller
    {
        /*[OutputCache(Duration = 43200)]*/
        public ActionResult About()
        {
            this.ViewBag.Message = "Your application description page.";

            return this.View();
        }

        /*[OutputCache(Duration = 43200)]*/
        public ActionResult Contact()
        {
            this.ViewBag.Message = "Your contact page.";

            return this.View();
        }

        /*[OutputCache(Duration = 60 * 60)]*/
        public ActionResult Index()
        {
            return this.View();
        }
    }
}