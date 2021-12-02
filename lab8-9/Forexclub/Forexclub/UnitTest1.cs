using Forexclub.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace Forexclub
{
    public class Tests
    {
        private IWebDriver _driver;
        private LibertexMainPageObject libertexPage;
        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl(@"https://fxclub.by/");
            _driver.Manage().Window.Maximize();
            var mainPage = new MainPageObject(_driver);
            libertexPage = mainPage.ClickLoginButton().Login("jxjilxver@mail.ru", "7355608");
        }

        [Test]
        public void ChangeDemoAccountBalance()
        {
            string sourceBalanceOfDemoAccount = libertexPage.GetAccountBalance();
            string currentBalanceOfDemoAccount = libertexPage.GoToBalanceUpdating().UpdateAccountBalance().GetAccountBalance();
            Assert.AreNotEqual(sourceBalanceOfDemoAccount, currentBalanceOfDemoAccount);//comparison of the balance before its change and after
        }

        [Test]
        public void BetAmmountMoreThanActualBalance()
        {
            libertexPage.OpenBetPage().PlaceBet("60000");//the maximum possible balance of the demo account is $50,000, so we specify $60,000
            Assert.IsTrue(new BetPageObject(_driver).IsErrorVisible);//checking for an error notification
        }

        [TearDown]
        public void TeadDown()
        {
            _driver.Quit();
        }
    }
}