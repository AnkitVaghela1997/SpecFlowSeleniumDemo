using TechTalk.SpecFlow;
using BDDTestFramework.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BDDTestFramework.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly DriverContext _driverContext;

        public Hooks(DriverContext driverContext)
        {
            _driverContext = driverContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driverContext.Driver = new ChromeDriver();
            _driverContext.Driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverContext.Driver.Quit();
        }
    }
}
