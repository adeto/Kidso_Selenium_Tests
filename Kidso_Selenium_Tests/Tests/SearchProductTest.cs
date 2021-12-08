using Kidso_Selenium_Tests.PageObjects;
using NUnit.Framework;

namespace Kidso_Selenium_Tests.Tests
{
    public class SearchProductTest : Hooks
    {
        [Test]
        public void SearchProductTest_KidsoWebApp()
        {
            var page = new SearchProductPage(driver);
            page.Open();

           page.SearchProduct();          
        }
    }
}