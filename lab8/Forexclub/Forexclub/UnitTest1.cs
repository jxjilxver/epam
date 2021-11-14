using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;

namespace Forexclub
{
    public class Tests
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(@"https://fxclub.by/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.CssSelector(".tm-icon-login")).Click();
            driver.FindElement(By.XPath("//a[text()='войти в Личный Кабинет']")).Click();
            driver.FindElement(By.Name("login")).SendKeys("jxjilxver@mail.ru");
            driver.FindElement(By.Name("password")).SendKeys("7355608");
            driver.FindElement(By.XPath("//input[@value='Войти']")).Click();
        }

        [Test]
        public void Test1()
        {
            Actions action = new Actions(driver);
            string sourceBalance = driver.FindElement(By.CssSelector(".balance")).Text;
            action.MoveToElement(driver.FindElement(By.CssSelector(".profile-nav"))).Perform();
            driver.FindElement(By.XPath("//a[text()='Обновить баланс демо-аккаунта']")).Click();
            driver.FindElement(By.XPath("//input[@name='amount']")).SendKeys("-10");
            driver.FindElement(By.XPath("//input[@value='Обновить баланс']")).Click();
            driver.FindElement(By.XPath("//span[text()='OK']")).Click();
            string currentBalance = driver.FindElement(By.CssSelector(".balance")).Text;
            Assert.AreNotEqual(sourceBalance, currentBalance);
        }
        [TearDown]
        public void TeadDown()
        {
            driver.Quit();
        }
    }
}