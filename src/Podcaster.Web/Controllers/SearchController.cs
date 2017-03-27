using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;

using Podcaster.Services.Podcast.Contracts;

namespace Podcaster.Web.Controllers
{
    [ExcludeFromCodeCoverage]
    [Authorize]
    public class SearchController : Controller
    {
        private readonly IPodcastService service;

        public SearchController(IPodcastService service)
        {
            this.service = service;
        }

        // GET: Search
        public ViewResult Index()
        {
            return this.View();
        }

        /*// TODO: AUTH
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string title)
        {
            if (title == null)
            {
                return this.View();
            }

            if (this.ModelState.IsValid)
            {
                var podcastEntity = this.service.FindByTitle(title);

                return this.PartialView("_PodcastDetailsPartial", podcastEntity);
            }

            return this.View();
        }*/
    }
}