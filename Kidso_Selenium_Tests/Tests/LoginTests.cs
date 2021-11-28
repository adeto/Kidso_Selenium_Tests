using Kidso_Selenium_Tests.Constants;
using Kidso_Selenium_Tests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Kidso_Selenium_Tests.Tests
{
    public class LoginTest : BaseTest
    {
        [Test, Order(1)]
        public void Test_ViewLoginPage_Link()
        {
            var viewLoginPage = new LoginPage(driver);

            viewLoginPage.Open();
            viewLoginPage.LinkLoginPage.Click();

            Assert.IsTrue(new LoginPage(driver).IsOpen());

            
        }
        [Test]
        public void Test_Login_With_ValidUser()
        {
            var page = new LoginPage(driver);
            page.Open();

            string username = GlobalTestConstants.Username;
            string password = GlobalTestConstants.Password;

            page.enterUsernameAndPassword(username, password);

            Assert.AreEqual(page.MyProfile.Text, "Test Testov");
          
        }

    [Test]
    public void Test_Login_With_EmptyUsername()
    {
        var page = new LoginPage(driver);
        page.Open();

        string username = GlobalTestConstants.BlankUsername;
        string password = GlobalTestConstants.Password;

        page.enterUsernameAndPassword(username, password);


    }
    [Test]
    public void Test_Login_With_EmptyPassword()
    {
            var page = new LoginPage(driver);
            page.Open();

            string username = GlobalTestConstants.Username;
            string password = GlobalTestConstants.BlankPassword;

            page.enterUsernameAndPassword(username, password);


        }
    [Test]
    public void Test_Login_With_EmptyCredentials()
    {
        var page = new LoginPage(driver);
        page.Open();
        page.LoginButton.Click();



        }
    [Test]
    public void Test_Login_With_InvalidUsername()
    {
        var page = new LoginPage(driver);
        page.Open();

        string username = GlobalTestConstants.InvalidEmail;
        string password = GlobalTestConstants.Password;

        page.enterUsernameAndPassword(username, password);


    }
    [Test]
    public void Test_Login_With_InvalidEmailValidation()
    {
        var page = new LoginPage(driver);
        page.Open();

        string username = GlobalTestConstants.InvalidEmail;
        string password = GlobalTestConstants.Password;

        page.enterUsernameAndPassword(username, password);


    }
        [Test]
        public void Test_Login_With_InvalidPasswordButValidUsername()
        {
            var page = new LoginPage(driver);
            page.Open();

            string username = GlobalTestConstants.Username;
            string password = GlobalTestConstants.InvalidPassword;

            page.enterUsernameAndPassword(username, password);
        }

    }
}
