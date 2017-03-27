using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Podcaster.Services.Podcast.Contracts;
using Podcaster.Web.Models.Podcast;

namespace Podcaster.Web.Controllers
{
    [ExcludeFromCodeCoverage]
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


        // TODO: AUTH
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string title)
        {

            if (ValidateRequest)
            {
                var podcastEntity = this.service.FindByTitle(title);
                var podcastViewModel = new PodcastDetailsViewModel
                {
                    Author = podcastEntity.AuthorName,
                    FeedUrl = podcastEntity.FeedUrl,
                    Pricing = podcastEntity.Pricing,
                    Id = podcastEntity.Id,
                    ImageUrl = podcastEntity.ImageUrl,
                    IsExplicit = podcastEntity.IsExplicit,
                    Description = podcastEntity.Description
                };

                return this.PartialView("_PodcastDetailsPartial", podcastViewModel);
            }

            return this.View();
        }
    }
}
