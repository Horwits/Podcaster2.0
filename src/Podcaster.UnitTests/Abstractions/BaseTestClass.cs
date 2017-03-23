using System.Diagnostics.CodeAnalysis;

using Ploeh.AutoFixture;

namespace Podcaster.UnitTests.Abstractions
{
    [ExcludeFromCodeCoverage]
    public abstract class BaseTestClass
    {
        public Fixture Fixture
        {
            get
            {
                return new Fixture();
            }
        }
    }
}