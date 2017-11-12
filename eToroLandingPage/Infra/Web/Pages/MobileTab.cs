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
        private static readonly By score = By.XPath("//p[@class='result-group-title-card-score']");
        private static readonly By desktopTab = By.XPath("//*[@id=':l']/div/div[2]");
        private static readonly By greatJobMessage = By.ClassName("result-group-title-message");


        public MobileTab(IWebDriver driver) : base(driver, new By[] { score, greatJobMessage })
        { }

        public DesktopTab ClickOnDesktopTab()
        {
            bot.Click(desktopTab);
            return new DesktopTab(driver);
        }

        public int GetScoreForMobile()
        {
            bot.WaitUntilVisible(greatJobMessage);
            List<IWebElement> scoreElements = driver.FindElements(score).ToList();
            string strScore = scoreElements[0].Text;
            strScore = strScore.Split('/')[0];
            int intScore = Convert.ToInt32(strScore);
            return intScore;
        }
    }
}
