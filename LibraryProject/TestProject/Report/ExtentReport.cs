using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Report
{
    public class ExtentReport
    {
        public ExtentReports report = null;
        public ExtentTest test = null;
        [OneTimeSetUp]
        public void ExtentStart()
        {
            report = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter("C:\\Users\\Akhilesh_Yadav1\\Desktop\\C# Example Codes\\1 - Selenium projects\\AutomationFramework\\LibraryProject\\TestProject\\Report");
            report.AttachReporter(htmlReporter);
        }
        [OneTimeTearDown]
        public void ExtentClose()
        {
            report.Flush();
        }
    }
}
