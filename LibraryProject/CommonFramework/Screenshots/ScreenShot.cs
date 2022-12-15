using AventStack.ExtentReports;
using CommonFramework.Base;
using CommonFramework.Report;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFramework.Screenshots
{
    public class ScreenShot : BasePage
    {
        public static void TakeScreenShot()
        {
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string screenshotPath = projectDirectory + "//screenshot.png";
            screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);

            ExtentReportBasePage.extentReport.test.Log(Status.Info, "Screenshot is taken for reference");
        }
    }
}
