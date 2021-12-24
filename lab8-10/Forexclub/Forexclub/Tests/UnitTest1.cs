using Forexclub.PageObjects;
using Forexclub.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace Forexclub
{
    [TestFixture]
    public class LibertexMainPageTests : CommonConditions
    {
        [Test]
        public void ChangeDemoAccountBalance()
        {
            string sourceBalanceOfDemoAccount = mainPage.GetAccountBalance();
            string currentBalanceOfDemoAccount = mainPage.GoToBalanceUpdating().UpdateAccountBalance().GetAccountBalance();
            Assert.AreNotEqual(sourceBalanceOfDemoAccount, currentBalanceOfDemoAccount);//comparison of the balance before its change and after
        }

        [Test]
        public void BetAmmountMoreThanActualBalance()
        {
            mainPage.OpenBetPage().PlaceBet("60000");//the maximum possible balance of the demo account is $50,000, so we specify $60,000
            Assert.IsTrue(new BetPageObject(_driver).IsErrorVisible);//checking for an error notification
        }

        [TearDown]
        public void TeadDown()
        {
            _driver.Quit();
        }
    }
}