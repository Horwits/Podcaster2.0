using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;

using Podcaster.Common.Constants;
using Podcaster.Models;
using Podcaster.Services.Podcast.Contracts;
using Podcaster.Web.Models.Podcast;

namespace Podcaster.Web.Areas.Administrator.Controllers
{
    [ExcludeFromCodeCoverage]
    [Authorize(Roles = GlobalConstants.AdminRole)]
    public class ManagePodcastController : Controller
    {
        private readonly IPodcastService service;

        public ManagePodcastController(IPodcastService service)
        {
            this.service = service;
        }

        public ActionResult Delete()
        {
            return this.View();
        }

        public ActionResult New()
        {
            var viewModel = new PodcastViewModel() { Podcast = new PodcastEntity() };
            return this.View("PodcastForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(PodcastEntity podcast)
        {
            if (!this.ModelState.IsValid)
            {
                var viewModel = new PodcastViewModel { Podcast = podcast, };

                return this.View("PodcastForm", viewModel);
            }

            if (podcast.Id == Guid.Empty)
            {
                podcast.Id = new Guid();
                this.service.Add(podcast);
            }
            else
            {
                var podcastInDb = this.service.FindById(podcast.Id);
                podcastInDb.FeedUrl = podcast.FeedUrl;
                podcastInDb.ImageUrl = podcast.ImageUrl;
                podcastInDb.Title = podcast.Title;
                podcastInDb.AuthorName = podcast.AuthorName;
                podcastInDb.Pricing = podcast.Pricing;
                podcastInDb.Description = podcast.Description;
                podcastInDb.IsExplicit = podcast.IsExplicit;
            }

            this.service.Add(podcast);
            return this.RedirectToAction("Index", "AdminPanel");
        }

        public ActionResult Update(Guid id)
        {
            var podcast = this.service.FindById(id);

            if (podcast == null)
            {
                return this.HttpNotFound();
            }

            var viewModel = new PodcastViewModel() { Podcast = podcast };
            return this.View("PodcastForm", viewModel);
        }
    }
}