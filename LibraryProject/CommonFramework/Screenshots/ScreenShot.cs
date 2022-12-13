using CommonFramework.Base;
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
            screenshot.SaveAsFile("C:\\Users\\Akhilesh_Yadav1\\Desktop\\C# Example Codes\\1 - Selenium projects\\AutomationFramework\\LibraryProject\\CommonFramework\\Screenshots\\screenshot.png", ScreenshotImageFormat.Png);

        }
    }
}
