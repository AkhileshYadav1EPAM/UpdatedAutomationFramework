using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFramework.Report
{
    public class ExtentReport
    {
        public ExtentReports report = new ExtentReports();
        public ExtentTest test = null;
        const string reportPath = @"C:\Users\Akhilesh_Yadav1\Desktop\C# Example Codes\1 - Selenium projects\AutomationFramework\LibraryProject\CommonFramework\Report\";
        
        public void ExtentStart()
        {
            var htmlReporter = new ExtentHtmlReporter(reportPath);
            report.AttachReporter(htmlReporter);
        }
        public void ExtentClose()
        {
            report.Flush();
        }
    }
}
