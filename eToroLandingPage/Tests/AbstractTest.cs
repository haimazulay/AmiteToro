using eToroLandingPage.Infra.Web;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eToroLandingPage.Tests
{
    public abstract class AbstractTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void BeforeTest()
        {

            BrowserType browserType = BrowserType.CHROME;

            if (driver == null)
            {
                driver = WebDriverFactory.GetDriver(browserType);
            }
        }

        [TearDown]
        public void AfterTest()
        {
            driver.Close();
        }

        protected void BrowseToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }


    }
}
