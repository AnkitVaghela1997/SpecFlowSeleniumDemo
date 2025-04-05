using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit.Framework;
using BDDTestFramework.Utilities;
using System.Threading;


namespace BDDTestFramework.StepDefinitions
{
    [Binding]
    public class GoogleSearchSteps
    {
        private readonly IWebDriver _driver;

        public GoogleSearchSteps()
        {
            _driver = DriverFactory.Driver;
        }

        [Given(@"I have opened the browser")]
        public void GivenIHaveOpenedTheBrowser()
        {
             Thread.Sleep(2000); // wait for results to load
            _driver.Navigate().GoToUrl("https://www.google.com");
        }

        [When(@"I navigate to Google and search for ""(.*)""")]
        public void WhenINavigateToGoogleAndSearchFor(string searchTerm)
        {
            Thread.Sleep(2000); // wait for results to load
            var searchBox = _driver.FindElement(By.Name("q"));
            searchBox.SendKeys(searchTerm);
            searchBox.SendKeys(Keys.Enter);
        }

        [Then(@"the search results should include ""(.*)""")]
        public void ThenTheSearchResultsShouldInclude(string expectedText)
        {
            Thread.Sleep(2000); // wait for results to load
            Assert.IsTrue(_driver.PageSource.Contains(expectedText), $"Expected to find '{expectedText}' in the search results.");
        }
    }
}
