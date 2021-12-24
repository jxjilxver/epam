using OpenQA.Selenium;
using NUnit.Framework;
using Forexclub.PageObjects;
using Forexclub.Model;
using NUnit.Framework.Interfaces;
using System.IO;
using System;
using Forexclub.Service;
using Forexclub.Util;

namespace Forexclub.Tests
{
    [SetUpFixture]
    public abstract class CommonConditions
    {
        protected IWebDriver _driver;
        internal LibertexMainPageObject mainPage;

        [SetUp]
        public void InitBrowserAndLogin()
        {
            _driver = DriverManager.GetWebDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(@"https://fxclub.by/");
            User testUser = UserCreator.WithCredentialsFromProperty();
            mainPage = new MainPageObject(_driver).ClickLoginButton().Login(testUser.Email, testUser.Password);
        }

        [TearDown]
        public void CloseBrowser()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                ScreenShot.MakeScreenShot();
            }
            DriverManager.CloseWebDriver();
        }
    }
}
