using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eToroLandingPage.Infra.Web.Pages
{
    public class MobileTab : AbstractPage
    {
        private static readonly By mobileScore = By.ClassName("result-group-title-card-score");
        private static readonly By desktopTab = By.XPath("//*[@id=':l']/div/div[2]");
        private static readonly By greatJobMessage = By.ClassName("result-group-title-message");


        public MobileTab(IWebDriver driver) : base(driver, new By[] { mobileScore, greatJobMessage })
        { }

        public DesktopTab ClickOnDesktopTab()
        {
            bot.Click(desktopTab);
            return new DesktopTab(driver);
        }

        public bool GetScore()
        {
            return bot.ExtractValueToString(mobileScore, greatJobMessage);
        }


    }
}
