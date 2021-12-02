using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forexclub.PageObjects
{
    class LibertexMainPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _balance = By.CssSelector(".balance");
        private readonly By _profileNav = By.CssSelector(".profile-nav");
        private readonly By _updateBalanceButton = By.XPath("//a[text()='Обновить баланс демо-аккаунта']");
        private readonly By _newInvestGrowthButton = By.CssSelector(".growth");

        public LibertexMainPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public string GetAccountBalance()
        {
            new WebDriverWait(_webDriver, TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementIsVisible(_balance));
            return _webDriver.FindElement(_balance).Text;
        }

        public UpdateBalancePageObject GoToBalanceUpdating()
        {
            Actions action = new Actions(_webDriver);
            action.MoveToElement(_webDriver.FindElement(_profileNav)).Perform();
            _webDriver.FindElement(_updateBalanceButton).Click();

            return new UpdateBalancePageObject(_webDriver);
        }

        public BetPageObject OpenBetPage()
        {
            new WebDriverWait(_webDriver, TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementIsVisible(_newInvestGrowthButton));
            new WebDriverWait(_webDriver, TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementToBeClickable(_newInvestGrowthButton));
            _webDriver.FindElement(_newInvestGrowthButton).Click();

            return new BetPageObject(_webDriver);
        }
    }
}
