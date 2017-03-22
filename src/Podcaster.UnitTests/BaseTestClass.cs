using Ploeh.AutoFixture;

namespace Podcaster.UnitTests
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