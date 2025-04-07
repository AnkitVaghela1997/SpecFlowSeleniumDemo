using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace BDDTestFramework.Utilities
{
    public class DriverFactory
    {
        public static IWebDriver CreateDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless");
            return new ChromeDriver(options);
        }
    }
}
