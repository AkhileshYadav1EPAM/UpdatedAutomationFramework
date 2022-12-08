using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework.Interfaces;
using TestProject.Test.BaseTestClass;
using LibraryProject.Pages;

namespace AutomationFramework.Screenshots
{
    internal class ScreenShot:BasePage
    {
        public static void TakeScreenShot()
        {
                Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\Akhilesh_Yadav1\\Desktop\\C# Example Codes\\1 - Selenium projects\\AutomationFramework\\LibraryProject\\TestProject\\Screenshots\\screenshot.png", ScreenshotImageFormat.Png);
            
        }
    }
}
