using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BDDTestFramework.Utilities
{
    public static class DriverFactory
    {
        private static IWebDriver _driver;

        public static IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                {
                    _driver = new ChromeDriver();
                    _driver.Manage().Window.Maximize();
                }
                return _driver;
            }
        }

        public static void QuitDriver()
        {
            _driver?.Quit();
            _driver = null;
        }
    }
}
