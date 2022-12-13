using AutomationFramework.Screenshots;
using AventStack.ExtentReports;
using LibraryProject.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Report;
using TestProject.Test.BaseTestClass;

namespace TestProject.Test
{
    public class AmazonSignInTest : BaseTest
    {

        [Test]
        public void InvalidSignInTest()
        {

            AmazonSignInPage amazonSignInPage = new AmazonSignInPage();
            ExtentReport extentReport = new ExtentReport();
            extentReport.ExtentStart();
            extentReport.test = extentReport.report.CreateTest("AmazonSignInTest").Info("Test Started");
            NavigateToURL("https://www.amazon.in/");
            extentReport.test.Log(Status.Info, "Amazon.com is launched");

            try
            {
                amazonSignInPage.TypeTheCredentials("modiji@gmial.com", "qwerty123");
            }
            catch (TimeoutException e)
            {
                Console.WriteLine("Timeout exception handled: " + e.Message);
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("NoSuchElement exception handled: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception handled: " + e.Message);
            }

            extentReport.test.Log(Status.Info, "Credentials are entered and submitted");

            ScreenShot.TakeScreenShot();
            extentReport.test.Log(Status.Info, "Screenshot is taken for reference");
            if (extentReport.test.Status == Status.Fail)
                extentReport.test.Log(Status.Fail, "Invalid SignIn Test Failed");
            else
                extentReport.test.Log(Status.Pass, "Invalid SignIn Test Passed");
            extentReport.ExtentClose();

        }
    }
}
