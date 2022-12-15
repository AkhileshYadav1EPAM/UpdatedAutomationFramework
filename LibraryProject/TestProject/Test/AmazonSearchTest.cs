using AventStack.ExtentReports;
using CommonFramework.Report;
using LibraryProject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Test.BaseTestClass;
using CommonFramework.Screenshots;
using CommonFramework.Base;

namespace TestProject.Test
{
    public class AmazonSearchTest : BaseTest
    {
        [Test]
        public void TestAmazonSearch()
        {
            AmazonSearchPage amazonSearchPage = new AmazonSearchPage();
            ExtentReportBasePage extentReportBasePage = new ExtentReportBasePage();

            extentReportBasePage.ExtentReportInitialisation("Amazon Search Test In NUnit");

            NavigateToURL("https://www.amazon.in/");
            amazonSearchPage.EnterTextInSearchBar("C# book");
            amazonSearchPage.ClickOnSearchButton();
            var mediaEntity = ScreenShot.TakeScreenShot();

            extentReportBasePage.ExtentReportStop(mediaEntity);
        }
    }
}
