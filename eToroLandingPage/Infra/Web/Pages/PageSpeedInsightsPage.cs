using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eToroLandingPage.Infra.Web.Pages
{
    public class PageSpeedInsightsPage : AbstractPage
    {
        private static readonly By webPageUrlEditBox = By.CssSelector("div.url-and-analyze > input");
        private static readonly By analyzeBtn = By.ClassName("button-red");


        private static readonly string eToroLandingPageUrl = "https://content.etoro.com/lp/bitcoin/";

        public PageSpeedInsightsPage(IWebDriver driver) : base(driver, new By[] { webPageUrlEditBox, analyzeBtn })
        {}

        public PageSpeedInsightsPage EnterWebPageUrl()
        {
            bot.SendKeys(webPageUrlEditBox, eToroLandingPageUrl);
            return this;
        }
        public MobileTab ClickOnAnalyzeBtn()
        {
            bot.Click(analyzeBtn);
            return new MobileTab(driver);
        }






    }
}
