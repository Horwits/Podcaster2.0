using Ploeh.AutoFixture;

namespace Podcaster.UnitTests.Abstractions
{
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