using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eToroLandingPage.Infra.Web.Pages
{
    public abstract class AbstractPage
    {
        protected IWebDriver driver;
        protected ActionBot bot;
        protected By[] pageUniqueElementsBy;
        private string pageName;

        public AbstractPage(IWebDriver driver, By[] pageUniqueElementsBy)
        {
            this.driver = driver;
            bot = new ActionBot(driver);

            this.pageUniqueElementsBy = pageUniqueElementsBy;
            pageName = this.GetType().Name;

            if (pageUniqueElementsBy != null && pageUniqueElementsBy.Length > 0)
            {
                VerifyOnPage();
            }
        }



        private void VerifyOnPage()
        {

            foreach (By by in pageUniqueElementsBy)
            {
                bot.WaitUntilVisible(by);
            }
        }




    }
}
