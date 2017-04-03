using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Podcaster.Common.Constants;

namespace Podcaster.Common.Validators
{
    public interface IEpisodeEntitiesValidator
    {
        void ValidateNotProvidedStringMember(params string[] members);
    }

    public class EpisodeEntitiesValidator : IEpisodeEntitiesValidator
    {
        public void ValidateNotProvidedStringMember(params string [] members)
        {
            var membersLength = members.Length;

            for (int i = 0; i < membersLength; i++)
            {
                var member = members[i];
                if (member == null)
                {
                    member = GlobalConstants.NotProvidedMessage;
                }
            }
        }
    }
}
