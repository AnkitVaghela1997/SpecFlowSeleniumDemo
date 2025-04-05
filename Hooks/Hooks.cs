using TechTalk.SpecFlow;
using BDDTestFramework.Utilities;

namespace BDDTestFramework.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            // You can initialize logging or report setups here
            var driver = DriverFactory.Driver;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            DriverFactory.QuitDriver();
        }
    }
}
