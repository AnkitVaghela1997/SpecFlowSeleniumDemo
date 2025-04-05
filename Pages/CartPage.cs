using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace BDDTestFramework.Pages
{
    public class CartPage
    {
        private readonly IWebDriver _driver;

        public CartPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void AddProductToCart(string productName)
        {
            // Example: For "Sauce Labs Backpack"
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var addButton = wait.Until(driver =>
    driver.FindElement(By.XPath($"//div[@class='inventory_item' and .//div[@class='inventory_item_name' and text()='{productName}']]//button[text()='ADD TO CART']"))
);
addButton.Click();

        }

        public void OpenCart()
        {
            var cartIcon = _driver.FindElement(By.ClassName("svg-inline--fa fa-shopping-cart fa-w-18 fa-3x "));
            cartIcon.Click();
        }

        public bool IsProductInCart(string productName)
        {
            try
            {
                _driver.FindElement(By.LinkText(productName));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
