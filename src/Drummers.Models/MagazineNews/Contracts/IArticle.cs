using System;

namespace Drummers.Models.Contracts
{
    public interface IArticle
    {
        Guid Id { get; set; }

        string Provider { get; set; }

        string Url { get; set; }

        string Title { get; set; }

        string Description { get; set; }
    }
}
