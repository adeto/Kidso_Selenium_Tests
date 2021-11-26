using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;

namespace Kidso_Selenium_Tests.PageObjects
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        public override string PageUrl => "https://kidso.bg/vhod?back=my-account";

        public IWebElement TextBoxUsername => 
            driver.FindElement(By.Name("email"));
        public IWebElement TextBoxPassword =>  
            driver.FindElement(By.Name("password"));
        public IWebElement LoginButton =>  
            driver.FindElement(By.CssSelector("#submit-login"));
        public IWebElement MyProfile =>
            driver.FindElement(By.XPath("//span[contains(text(),'test testov')]"));
        public IWebElement LinkLoginPage =>
            driver.FindElement(By.XPath("//span[contains(.,'¬ход')]"));

        public void enterUsernameAndPassword(string username, string password)
        {
            this.TextBoxUsername.SendKeys(username);
            this.TextBoxPassword.SendKeys(password);
            this.LoginButton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

    }
}