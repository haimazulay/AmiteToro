using eToroLandingPage.Infra.Web.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eToroLandingPage.Tests
{
    class TestNumber001 : AbstractTest
    {
        private static readonly string websiteUrl = "https://developers.google.com/speed/pagespeed/insights/";

        [Test]
        public void TestNumber001Mobile()
        {
            BrowseToUrl(websiteUrl);
            PageSpeedInsightsPage Insights = new PageSpeedInsightsPage(driver);
            Insights.EnterWebPageUrl();
            MobileTab mobileTab = Insights.ClickOnAnalyzeBtn();
            int result = mobileTab.GetScoreForMobile();
            Assert.GreaterOrEqual(result, 80, "Score should be >= 80");
        }

        [Test]
        public void TestNumber002Desktop()
        {
            BrowseToUrl(websiteUrl);
            PageSpeedInsightsPage Insights = new PageSpeedInsightsPage(driver);
            Insights.EnterWebPageUrl();
            MobileTab mobileTab = Insights.ClickOnAnalyzeBtn();
            DesktopTab desktopTab = mobileTab.ClickOnDesktopTab();
            int result = desktopTab.GetScoreForDesktop();
            Assert.GreaterOrEqual(result, 80, "Score should be >= 80");
        }
    }
}
