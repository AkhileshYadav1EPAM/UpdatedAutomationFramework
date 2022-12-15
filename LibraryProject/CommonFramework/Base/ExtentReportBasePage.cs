using AventStack.ExtentReports;
using CommonFramework.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFramework.Base
{
    public class ExtentReportBasePage
    {
        public static ExtentReport extentReport = new ExtentReport();
        public void ExtentReportInitialisation(string testName)
        {
            extentReport.ExtentStart();

            extentReport.test = extentReport.report.CreateTest(testName).Info("Test Started");
        }

        public void ExtentReportStop()
        {
            if (extentReport.test.Status == Status.Pass)
                extentReport.test.Log(Status.Pass, "SearchTest Passed");
            else
                extentReport.test.Log(Status.Fail, "SearchTest Fails");

            extentReport.ExtentClose();
        }
    }
}
