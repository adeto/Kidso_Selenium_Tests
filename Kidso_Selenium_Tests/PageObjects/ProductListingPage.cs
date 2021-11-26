using Kidso_Selenium_Tests.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Kidso_Selenium_Tests
{
    public class ProductListingPage : BasePage
    {
        public ProductListingPage(IWebDriver driver) : base(driver)
        {
        }
        public override string PageUrl => "https://kidso.bg/momcheta/";

        public IWebElement ListItemsProducts =>
           driver.FindElement(By.CssSelector(".products > article:nth-child(3)"));
        public IWebElement Pages =>
            driver.FindElement(By.CssSelector("#js-product-list > nav > div.col-md-12.pr-0.pagination_holder > ul"));

        public int GetProductsCount()
        {
            string productCountsText = this.ListItemsProducts.Text;
            if (productCountsText != "")
                return 1;

            return 0;
        }

        public int GetPagesCount()
        {
            string pageCountText = this.Pages.Text;
            List<string> listPages = pageCountText.Split("\r\n").ToList();

            return listPages.Count;
        }
    }
}