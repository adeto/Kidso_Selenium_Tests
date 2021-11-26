using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Kidso_Selenium_Tests.PageObjects
{
    public class HooksPage : BasePage
    {
        IWebDriver driver;

        public HooksPage(IWebDriver driver) : base(driver)
        {
        }
        
        public override string PageUrl => "https://kidso.bg/?homepage=black-friday";

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [OneTimeTearDown]
        public void ShutDown()
        {
            driver.Quit();
        }
    }
}