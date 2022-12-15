using AventStack.ExtentReports;
using CommonFramework.Base;
using CommonFramework.Report;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFramework.Utilities.PageUtilityClass
{
    public class PageUtility
    {
        public static IWebDriver driver;

        public static void NavigateToURL(string url)
        {
            driver.Navigate().GoToUrl(url);
            //ExtentReportBasePage.extentReport.test.Log(Status.Info, "Amazon.com is launched");
        }

        public static void ClickOnElement(By element)
        {
            driver.FindElement(element).Click();
        }

        public static void SendKeysToField(By element, string text)
        {
            driver.FindElement(element).SendKeys(text);
        }

    }
}
