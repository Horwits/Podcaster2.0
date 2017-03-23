using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Podcaster.Models.Contracts;

namespace Podcaster.Data.Repositories.Contracts
{
    public interface IUserClaimsRepository
    {
        void Add(IUserClaim userClaim);

        Task<IEnumerable<IUserClaim>> GetByUserId(Guid userId);

        Task<IList<IUserClaim>> Remove(Func<IUserClaim, bool> func);
    }
}