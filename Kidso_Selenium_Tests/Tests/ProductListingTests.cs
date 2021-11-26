using NUnit.Framework;

namespace Kidso_Selenium_Tests.Tests
{
    public class ProductListingTests : BaseTest
    {
        [Test]
        public void Test_Get_Products()
        {
            var page = new ProductListingPage(driver);
            page.Open();

            var productCounter = page.GetProductsCount();

            Assert.IsTrue(productCounter > 0);
               
        }

        [Test]
        public void Test_Get_Pages()
        {
            var page = new ProductListingPage(driver);
            page.Open();

            var pageCounter = page.GetPagesCount();

            Assert.IsTrue(pageCounter > 0);
        }
    }
}