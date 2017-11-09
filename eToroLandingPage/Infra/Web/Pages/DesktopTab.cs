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
        private static readonly By desktopScore = By.ClassName("result-group-title-card-score");
        private static readonly By greatJobMessage = By.ClassName("result-group-title-message");
        public DesktopTab(IWebDriver driver) : base(driver, new By[] { desktopScore })
        { }

        public  bool GetScore()
        {
            return bot.ExtractValueToString(desktopScore, greatJobMessage);
        }

    }
}
