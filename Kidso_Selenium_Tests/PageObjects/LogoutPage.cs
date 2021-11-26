using Kidso_Selenium_Tests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Kidso_Selenium_Tests.PageObjects

{
    public class LogoutPage : BasePage
    {
        public LogoutPage(IWebDriver driver) : base(driver)
        {
        }
        public override string PageUrl => "https://kidso.bg/vhod?back=my-account";

        public IWebElement textBoxUsername =>
            driver.FindElement(By.Name("email"));
        public IWebElement textBoxPassword =>
            driver.FindElement(By.Name("password"));
        public IWebElement loginButton =>
            driver.FindElement(By.CssSelector("#submit-login"));
        public IWebElement userInfo =>
            driver.FindElement(By.Id("#_desktop_user_info"));
        public IWebElement logoutInfo => 
            driver.FindElement(By.CssSelector("a > span"));
        public IWebElement logoutButton => 
            driver.FindElement(By.LinkText("Изход"));

        public void enterUsernameAndPassword(string username, string password)
        {
            this.textBoxUsername.SendKeys(username);
            this.textBoxPassword.SendKeys(password);
            this.loginButton.Click();
        }
    }
}