using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forexclub.PageObjects
{
    class LoginPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _loginPersonalAccount = By.XPath("//a[text()='войти в Личный Кабинет']");
        private readonly By _loginInput = By.Name("login");
        private readonly By _passwordInput = By.Name("password");
        private readonly By _loginButton = By.XPath("//input[@value='Войти']");

        public LoginPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public LibertexMainPageObject Login(string login, string password)
        {
            new WebDriverWait(_webDriver, TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementIsVisible(_loginPersonalAccount));
            new WebDriverWait(_webDriver, TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementToBeClickable(_loginPersonalAccount));
            _webDriver.FindElement(_loginPersonalAccount).Click();
            _webDriver.FindElement(_loginInput).SendKeys(login);
            _webDriver.FindElement(_passwordInput).SendKeys(password);
            _webDriver.FindElement(_loginButton).Click();

            return new LibertexMainPageObject(_webDriver);
        }
    }
}
