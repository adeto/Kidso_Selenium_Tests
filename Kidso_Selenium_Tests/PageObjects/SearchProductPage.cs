using OpenQA.Selenium;

namespace Kidso_Selenium_Tests.PageObjects
{
    public class SearchProductPage : BasePage
    {
        public SearchProductPage(IWebDriver driver) : base(driver)
        {
        }
        public override string PageUrl => "https://kidso.bg/?homepage=colorful-christmas";

        public IWebElement textBoxSearch =>
            driver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div[1]/div[3]/div[2]/form/input[4]"));


        public void SearchProduct()
        {
            textBoxSearch.SendKeys("kola");
            textBoxSearch.SendKeys(Keys.Enter);
        }
    }
}