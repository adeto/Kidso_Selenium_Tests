using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Kidso_Selenium_Tests.PageObjects
{
    public class BasePage
    {
        protected readonly IWebDriver driver;
        public virtual string PageUrl { get; }

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Manage().Window.Maximize();
        }

        public void Open()
        {
            driver.Navigate().GoToUrl(this.PageUrl);
        }

        public bool IsOpen()
        {
            return this.driver.Url == this.PageUrl;
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }

        protected void ClosePopWindow()
        {
            Thread.Sleep(12000);
            var popWindow = driver.FindElement(By.CssSelector(".close"));
            if (popWindow != null)
                popWindow.Click();
        }
    }
}