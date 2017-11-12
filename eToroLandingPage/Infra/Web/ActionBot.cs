using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool ExtractValueToString(By by, By greatMessage)
        {
            IsVisuble(greatMessage);
            IWebElement element = driver.FindElement(by);
            string result = element.Text;
            result = result.Remove(2);
            int a = Convert.ToInt32(result);
            return (a >= 80 ? true : false);
        }




        public void IsVisuble(By by)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut)).Until(ExpectedConditions.ElementExists((by)));
        }

        public void WaitForElementVisibility(By by)
        {
            webDriverWait.Until(ExpectedConditions.ElementIsVisible(by));
        }

    }
}
