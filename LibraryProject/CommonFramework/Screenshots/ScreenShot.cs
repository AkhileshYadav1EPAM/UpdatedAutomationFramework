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
        public static MediaEntityModelProvider TakeScreenShot()
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;

            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, "Test Screenshot").Build();
        }
    }
}
