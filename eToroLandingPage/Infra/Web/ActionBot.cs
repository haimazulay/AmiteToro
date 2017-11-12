using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using static System.Threading.Thread;

namespace eToroLandingPage.Infra.Web
{
    public class ActionBot
    {

        private IWebDriver driver;
        private WebDriverWait webDriverWait; // explicit wait
        private double timeOut;

        public ActionBot(IWebDriver driver)
        {
            this.driver = driver;
            webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void Click(By by)
        {
            IWebElement element = driver.FindElement(by);
            element.Click();
        }

        public void SendKeys(By by, string text)
        {
            IWebElement element = driver.FindElement(by);
            element.SendKeys(text);
        }

        public void WaitUntilVisible(By by)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));

        }


    }
}
