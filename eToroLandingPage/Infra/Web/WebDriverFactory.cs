using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eToroLandingPage.Infra.Web
{
    public class WebDriverFactory
    {

        public static IWebDriver GetDriver(BrowserType browserType)
        {
            IWebDriver driver = null;

            switch (browserType)
            {
                case BrowserType.CHROME:
                    driver = new ChromeDriver();
                    break;
                case BrowserType.FIREFOX:
                    driver = new FirefoxDriver();
                    break;
                case BrowserType.INTERNET_EXPLORER:
                    driver = new InternetExplorerDriver();
                    break;
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();

            return driver;
        }
    }
}
