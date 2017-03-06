using System;

namespace Drummers.Models.Contracts
{
    public interface IIdentifiable
    {
        Guid Id { get; set; }
    }
}
