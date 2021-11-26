using Kidso_Selenium_Tests.PageObjects;
using NUnit.Framework;

namespace Kidso_Selenium_Tests.Tests
{
    public class LogoutTests : BaseTest
    {
        [Test]
        public void Test_Login_And_Logout()
        {
            var page = new LogoutPage(driver);
            page.Open();

            string username = "test01@abv.bg";
            string password = "Password1";

            page.enterUsernameAndPassword(username, password);
            page.logoutInfo.Click();
            page.logoutButton.Click();

            Assert.Pass();
            Assert.IsTrue(new HooksPage(driver).IsOpen());

        }
    }
}