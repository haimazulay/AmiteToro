using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eToroLandingPage.Infra.Web.Pages
{
    public class DesktopTab : AbstractPage
    {
        private static readonly By score = By.XPath("//p[@class='result-group-title-card-score']");
        private static readonly By greatJobMessage = By.ClassName("result-group-title-message");
        public DesktopTab(IWebDriver driver) : base(driver, new By[] { score })
        { }

        public int GetScoreForDesktop()
        {
            bot.WaitUntilVisible(greatJobMessage);
            List<IWebElement> scoreElements = driver.FindElements(score).ToList();
            string strScore = scoreElements[1].Text;
            strScore = strScore.Split('/')[0];
            int intScore = Convert.ToInt32(strScore);
            return intScore;
        }

    }
}
