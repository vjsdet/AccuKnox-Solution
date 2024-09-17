using NUnit.Framework;
using Test_Project.Pages;

namespace Test_Project.TestFile
{
    [TestFixture]
    [Property("Priority", 0)]
    public class HomePageTest : BaseTest
    {
        [Test, Order(0)]
        public void ValidateBackendTest()
        {
            var page = new HomePage();
            Assert.IsTrue(page.ValidateBackendText(), "Backend Text Displayed");


        }
    }
}
