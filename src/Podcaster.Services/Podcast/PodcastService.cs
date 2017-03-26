using System;

using Bytes2you.Validation;

using Podcaster.Data.DataEF.Contracts;
using Podcaster.Models;
using Podcaster.Models.Contracts;
using Podcaster.Services.Podcast.Contracts;

namespace Podcaster.Services.Podcast
{
    public class PodcastService : IPodcastService
    {
        private readonly IPodcasterDataEF data;

        public PodcastService(IPodcasterDataEF data)
        {
            Guard.WhenArgument(data, nameof(data)).IsNull().Throw();

            this.data = data;
        }

        public void Add(PodcastEntity podcast)
        {
            Guard.WhenArgument(podcast, nameof(podcast)).IsNull().Throw();

            this.data.Podcasts.Add(podcast);
        }

        public void Delete(PodcastEntity podcast)
        {
            Guard.WhenArgument(podcast, nameof(podcast)).IsNull().Throw();

            this.data.Podcasts.Add(podcast);
        }

        public PodcastEntity FindById(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException(nameof(id));
            }

            return this.data.Podcasts.GetById(id);
        }

        public PodcastEntity FindByTitle(string title)
        {
            Guard.WhenArgument(title, nameof(title)).IsNullOrEmpty().IsNullOrWhiteSpace().Throw();

            return this.data.Podcasts.GetByName(title);
        }

        public void Update(PodcastEntity podcast)
        {
            Guard.WhenArgument(podcast, nameof(podcast)).IsNull().Throw();

            this.data.Podcasts.Add(podcast);
        }
    }
}