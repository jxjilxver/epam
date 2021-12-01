using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forexclub.PageObjects
{
    class MainPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _loginPageButton = By.CssSelector(".tm-icon-login");
        
        public MainPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public LoginPageObject ClickLoginButton()
        {
            _webDriver.FindElement(_loginPageButton).Click();

            return new LoginPageObject(_webDriver);
        }
    }
}
