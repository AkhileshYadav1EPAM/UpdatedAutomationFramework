using AventStack.ExtentReports;
using CommonFramework.Report;
using LibraryProject.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Test.BaseTestClass;
using CommonFramework.Utilities.PageUtilityClass;
using CommonFramework.Screenshots;
using CommonFramework.Base;

namespace TestProject.Test
{
    public class AmazonSignInTest : BaseTest
    {
        [Test]
        public void InvalidSignInTest()
        {
            AmazonSignInPage amazonSignInPage = new AmazonSignInPage();
            ExtentReportBasePage extentReportBasePage = new ExtentReportBasePage();

            extentReportBasePage.ExtentReportInitialisation("AmazonSignInTest");

            NavigateToURL("https://www.amazon.in/");
            amazonSignInPage.ClickOnSignInButton();
            amazonSignInPage.EnterTheEmail("ModiJi@gmail.com");
            amazonSignInPage.EnterThePassword("123456");
            ScreenShot.TakeScreenShot();

            extentReportBasePage.ExtentReportStop();
        }
    }
}
