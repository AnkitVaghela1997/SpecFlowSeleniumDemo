using BDDTestFramework.Pages;
using BDDTestFramework.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace BDDTestFramework.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage _loginPage;

        public LoginSteps(DriverContext context)
        {
            _driver = context.Driver;
            _loginPage = new LoginPage(_driver);
        }

        [Given(@"I navigate to the login page")]
        public void GivenINavigateToTheLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/index.html");
            _driver.Manage().Window.Maximize();
        }

        [When(@"I login with username ""(.*)"" and password ""(.*)""")]
        public void WhenILoginWithUsernameAndPassword(string username, string password)
        {
            _loginPage.EnterUsername(username);
            _loginPage.EnterPassword(password);
            _loginPage.ClickLogin();
        }

        [Then(@"I should be redirected to the inventory page")]
        public void ThenIShouldBeRedirectedToTheInventoryPage()
        {
            Assert.IsTrue(_driver.Url.Contains("inventory"), "User is not redirected to the inventory page.");
        }
    }
}
