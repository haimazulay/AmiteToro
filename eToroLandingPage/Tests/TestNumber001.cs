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
            bool result = mobileTab.GetScore();
                Assert.IsTrue(result);
        }


        [Test]
        public void TestNumber002Desktop()
        {
            BrowseToUrl(websiteUrl);
            PageSpeedInsightsPage Insights = new PageSpeedInsightsPage(driver);
            Insights.EnterWebPageUrl();
            MobileTab mobileTab = Insights.ClickOnAnalyzeBtn();

            DesktopTab desktopTab = mobileTab.ClickOnDesktopTab();
            bool result = mobileTab.GetScore();
            Assert.IsTrue(result);
        }




    }
}
