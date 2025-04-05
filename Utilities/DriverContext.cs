using OpenQA.Selenium;

namespace BDDTestFramework.Utilities
{
    public class DriverContext
    {
        public IWebDriver Driver { get; set; }
    }
}
// This class is used to manage the WebDriver instance across the test framework.   