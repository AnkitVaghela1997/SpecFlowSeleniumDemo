using TechTalk.SpecFlow;
using BDDTestFramework.Utilities;

namespace BDDTestFramework.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly DriverContext _context;

        public Hooks(DriverContext context)
        {
            _context = context;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _context.Driver = DriverFactory.CreateDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _context.Driver.Quit();
        }
    }
}
