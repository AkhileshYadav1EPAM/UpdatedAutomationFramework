using AventStack.ExtentReports;
using CommonFramework.Base;
using CommonFramework.Utilities.PageUtilityClass;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Pages
{
    public class AmazonSignInPage : PageUtility
    {
        //By element;

        #region Locators
        By emailId => By.XPath("//*[@id=\"ap_email\"]");
        By continueButton => By.XPath("//*[@id=\"continue\"]");
        By passwordText => By.XPath("//*[@id=\"ap_password\"]");
        By signInButtonFinal => By.XPath("//*[@id=\"signInSubmit\"]");
        #endregion

        #region Actions
        public void ClickOnSignInButton()
        {
            AmazonSearchPage searchPage = new AmazonSearchPage();
            ClickOnElement(searchPage.signInButton);
            ExtentReportBasePage.extentReport.test.Log(Status.Info, "SignIn button is clicked");
        }

        public void EnterTheEmail(string email)
        {
            SendKeysToField(emailId, email);
            ClickOnElement(continueButton);
            ExtentReportBasePage.extentReport.test.Log(Status.Info, "Email has been entered");
        }

        public void EnterThePassword(string password)
        {
            SendKeysToField(passwordText, password);
            ClickOnElement(signInButtonFinal);
            ExtentReportBasePage.extentReport.test.Log(Status.Info, "Password has been entered");
        }


        #endregion
    }
}
