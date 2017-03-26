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
        public ActionResult About()
        {
            this.ViewBag.Message = "Your application description page.";

            return this.View();

        }

        public ActionResult Contact()
        {
            this.ViewBag.Message = "Your contact page.";

            return this.View();
        }

        public ActionResult Index()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                var model = new TopTenPodcastsViewModel();

                return this.View("_TopTen", model);
            }
            else
            {
                return this.View();
            }
        }

        public ActionResult Details(PodcastDetailsViewModel model)
        {
            this.ViewBag.Details = "Your contact page.";

            var modelBase = new TopTenPodcastsViewModel();
            model = modelBase.TopTen.First();

            return this.View("Details", model);
        }
    }
}