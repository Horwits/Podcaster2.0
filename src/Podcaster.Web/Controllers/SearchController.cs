using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;

using Podcaster.Services.Podcast.Contracts;
using Podcaster.Web.Models.Search;

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
            var model = new SearchViewModel();
            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(SearchViewModel model)
        {
            if (model.SearchTitle == null)
            {
                return this.View(model);
            }

            if (this.ModelState.IsValid)
            {
                var podcastEntity = this.service.FindByTitle(model.SearchTitle);

                model.Podcast = podcastEntity;
            }

            return this.View(model);
        }
    }
}