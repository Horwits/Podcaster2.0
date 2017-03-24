namespace Podcaster.Models.Contracts
{
    public interface IPodcastEntity
    {
        string Author { get; set; }

        string Description { get; set; }

        string ImageUrl { get; set; }

        decimal Price { get; set; }

        string Rights { get; set; }

        string Title { get; set; }
    }
}