using OpenQA.Selenium;

namespace BDDTestFramework.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement UsernameInput => _driver.FindElement(By.Id("user-name"));
        private IWebElement PasswordInput => _driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => _driver.FindElement(By.Id("login-button"));

        public void EnterUsername(string username) => UsernameInput.SendKeys(username);
        public void EnterPassword(string password) => PasswordInput.SendKeys(password);
        public void ClickLogin() => LoginButton.Click();
    }
}
