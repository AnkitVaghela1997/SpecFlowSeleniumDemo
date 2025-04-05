using BDDTestFramework.Pages;
using BDDTestFramework.Utilities;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace BDDTestFramework.StepDefinitions
{
    [Binding]
    public class CartSteps
    {
        private readonly IWebDriver _driver;
        private readonly CartPage _cartPage;

        public CartSteps(DriverContext context)
        {
            _driver = context.Driver;
            _cartPage = new CartPage(_driver);
        }

        [When(@"I add the product ""(.*)"" to the cart")]
        public void WhenIAddTheProductToTheCart(string productName)
        {
            _cartPage.AddProductToCart(productName);
        }

        [Then(@"the product ""(.*)"" should be visible in the cart")]
        public void ThenTheProductShouldBeVisibleInTheCart(string productName)
        {
            _cartPage.OpenCart();
            Assert.IsTrue(_cartPage.IsProductInCart(productName), $"Product '{productName}' is not found in the cart.");
        }
    }
}
