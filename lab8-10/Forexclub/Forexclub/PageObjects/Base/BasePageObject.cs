using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forexclub.PageObjects.Base
{
    class BasePageObject
    {
        protected IWebDriver _driver;

        public BasePageObject(IWebDriver driver)
        {
            this._driver = driver;
        }

        public IWebElement FindElement(By locator)
        {
            return _driver.FindElement(locator);
        }

        public IWebElement WaitElementToBeClickable(By locator, int seconds)
        {
            return new WebDriverWait(_driver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public IWebElement WaitElementIsVisible(By locator, int seconds)
        {
            return new WebDriverWait(_driver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementIsVisible(locator));
        }
    }
}
