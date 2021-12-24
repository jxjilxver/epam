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
    class UpdateBalancePageObject
    {
        private IWebDriver _webDriver;

        private readonly By _amountInput = By.XPath("//input[@name='amount']");
        private readonly By _UpdateBalanceButton = By.XPath("//input[@value='Обновить баланс']");
        private readonly By _okButton = By.XPath("//span[text()='OK']");

        public UpdateBalancePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public LibertexMainPageObject UpdateAccountBalance()
        {
            new WebDriverWait(_webDriver, TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementIsVisible(_amountInput));
            _webDriver.FindElement(_amountInput).SendKeys("-10");
            _webDriver.FindElement(_UpdateBalanceButton).Click();
            new WebDriverWait(_webDriver, TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementIsVisible(_okButton));
            new WebDriverWait(_webDriver, TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementToBeClickable(_okButton));
            _webDriver.FindElement(_okButton).Click();

            return new LibertexMainPageObject(_webDriver);
        }
    }
}
