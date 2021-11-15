using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;

namespace Forexclub
{
    public class Tests
    {
        private IWebDriver _driver;
        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl(@"https://fxclub.by/");
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.FindElement(By.CssSelector(".tm-icon-login")).Click();
            _driver.FindElement(By.XPath("//a[text()='войти в Личный Кабинет']")).Click();
            _driver.FindElement(By.Name("login")).SendKeys("jxjilxver@mail.ru");
            _driver.FindElement(By.Name("password")).SendKeys("7355608");
            _driver.FindElement(By.XPath("//input[@value='Войти']")).Click();
        }

        [Test]
        public void ChangeDemoAccountBalance()
        {
            string sourceBalanceOfDemoAccount = _driver.FindElement(By.CssSelector(".balance")).Text;
            Actions action = new Actions(_driver);
            action.MoveToElement(_driver.FindElement(By.CssSelector(".profile-nav"))).Perform();
            _driver.FindElement(By.XPath("//a[text()='Обновить баланс демо-аккаунта']")).Click();
            _driver.FindElement(By.XPath("//input[@name='amount']")).SendKeys("-10");
            _driver.FindElement(By.XPath("//input[@value='Обновить баланс']")).Click();
            _driver.FindElement(By.XPath("//span[text()='OK']")).Click();
            string currentBalanceOfDemoAccount = _driver.FindElement(By.CssSelector(".balance")).Text;
            Assert.AreNotEqual(sourceBalanceOfDemoAccount, currentBalanceOfDemoAccount);
        }
        [TearDown]
        public void TeadDown()
        {
            _driver.Quit();
        }
    }
}