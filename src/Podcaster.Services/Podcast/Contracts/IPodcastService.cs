using System;

using Podcaster.Models;

namespace Podcaster.Services.Podcast.Contracts
{
    public interface IPodcastService
    {
        void Add(PodcastEntity podcast);

        void Delete(PodcastEntity podcast);

        PodcastEntity FindById(Guid id);

        PodcastEntity FindByTitle(string title);

        void Update(PodcastEntity podcast);
    }
}