using AutomationFramework.Screenshots;
using AventStack.ExtentReports;
using LibraryProject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Report;
using TestProject.Test.BaseTestClass;

namespace TestProject.Test
{
    public  class AmazonSearchTest : BaseTest
    {
        [Test]
        public void TestAmazonSearch()
        {
            AmazonSearchPage amazonSearchPage = new AmazonSearchPage();
            ExtentReport extentReport = new ExtentReport();

            extentReport.ExtentStart();
            extentReport.test = extentReport.report.CreateTest("AmazonSearchTest").Info("Test Started");
            NavigateToURL("https://www.amazon.in/");
            extentReport.test.Log(Status.Info, "Amazon.com is launched");

            amazonSearchPage.EnterTextInSearchBar("C# book");
            extentReport.test.Log(Status.Info, "Text is entered into search bar");

            amazonSearchPage.ClickOnSearchButton();
            extentReport.test.Log(Status.Info, "Search button is clicked to display results");

            ScreenShot.TakeScreenShot();
            extentReport.test.Log(Status.Info, "Screenshot is taken for reference");

            if (extentReport.test.Status == Status.Pass)
                extentReport.test.Log(Status.Pass, "SearchTest Passed");
            else
                extentReport.test.Log(Status.Fail, "SearchTest Fails");

            extentReport.ExtentClose();
        }
    }
}
