using System;
using System.Collections.Generic;

using NUnit.Framework;

using Podcaster.Models;
using Podcaster.UnitTests.Mocks;

namespace Podcaster.UnitTests.Models.Podcast
{
    [TestFixture]
    public class ConstructorShould
    {
        [Test]
        public void Set_SubscribersProperty()
        {
            // Arrange
            var sut = new FakePodcastEntityFactory().GetPodcastEntity();

            // Act & Assert
            Assert.IsNotNull(sut.Subscribers);
        }
    }
}
