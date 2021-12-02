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
    class BetPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _investmentAmountInput = By.Id("sumInv");
        private readonly By _buyButton = By.CssSelector(".a-submit");
        private readonly By _errorMsg = By.CssSelector(".msg-error");

        public bool IsErrorVisible => _webDriver.FindElement(_errorMsg).Displayed;

        public BetPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public LibertexMainPageObject PlaceBet(string amount)
        {
            new WebDriverWait(_webDriver, TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementIsVisible(_investmentAmountInput));
            _webDriver.FindElement(_investmentAmountInput).Clear();
            _webDriver.FindElement(_investmentAmountInput).SendKeys(amount);
            _webDriver.FindElement(_buyButton).Click();

            return new LibertexMainPageObject(_webDriver);
        }

    }
}