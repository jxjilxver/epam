using Forexclub.PageObjects.Base;
using Forexclub.Util;
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
    class LibertexMainPageObject : BasePageObject
    {
        private readonly By _balance = By.CssSelector(".balance");
        private readonly By _profileNav = By.CssSelector(".profile-nav");
        private readonly By _updateBalanceButton = By.XPath("//a[text()='Обновить баланс демо-аккаунта']");
        private readonly By _newInvestGrowthButton = By.CssSelector(".growth");
        private readonly By _activeInvestment = By.XPath("//a[@class='nav-item investments-nav a-event']");

        public LibertexMainPageObject(IWebDriver driver):base(driver)
        {
        }

        public string GetAccountBalance()
        {
            WaitElementToBeClickable(_balance, 5);
            Log.Info("Account balance is " + FindElement(_balance).Text);
            return FindElement(_balance).Text;
        }

        public UpdateBalancePageObject GoToBalanceUpdating()
        {
            Actions action = new Actions(_driver);
            action.MoveToElement(FindElement(_profileNav)).Perform();
            FindElement(_updateBalanceButton).Click();

            return new UpdateBalancePageObject(_driver);
        }

        public BetPageObject OpenBetPage()
        {
            WaitElementIsVisible(_newInvestGrowthButton, 5);
            WaitElementToBeClickable(_newInvestGrowthButton, 5);
            FindElement(_newInvestGrowthButton).Click();

            return new BetPageObject(_driver);
        }
    }
}
