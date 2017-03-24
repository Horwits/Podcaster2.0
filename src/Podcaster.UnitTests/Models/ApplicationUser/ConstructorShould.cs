using NUnit.Framework;

namespace Podcaster.UnitTests.Models.ApplicationUser
{
    [TestFixture]
    public class ConstructorShould
    {
        // TODO: Possible check -> it is email
        [TestCase("def", "def@abv.bg")]
        [TestCase("dedsadaf", "ddsadaef@abv.bg")]
        [TestCase("ddsaaef", "defdsada@abv.bg")]
        public void Set_NeededProperties_WhenValid(string name, string email)
        {
            // Arrange
            var appUser = new Podcaster.Models.ApplicationUser(name, email);

            // Act & Assert
            Assert.AreEqual(name, appUser.UserName);
            Assert.AreEqual(email, appUser.Email);
        }
    }
}