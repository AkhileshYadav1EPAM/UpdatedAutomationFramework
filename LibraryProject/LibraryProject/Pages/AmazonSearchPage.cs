using AventStack.ExtentReports;
using CommonFramework.Report;
using CommonFramework.Utilities.PageUtilityClass;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonFramework.Base;

namespace LibraryProject.Pages
{
    public class AmazonSearchPage : PageUtility
    {
        //By element;
        //ExtentReport extentReport = new ExtentReport();

        #region Locators
        private By searchBar => By.XPath("//*[@id=\"twotabsearchtextbox\"]");
        private By searchButton => By.XPath("//*[@id=\"nav-search-submit-button\"]");
        public By signInButton => By.XPath("//*[@id=\"nav-link-accountList\"]");
        #endregion

        #region Actions
        public void EnterTextInSearchBar(string searchText)
        {
            SendKeysToField(searchBar, searchText);
            ExtentReportBasePage.extentReport.test.Log(Status.Info, "Text is entered into search bar");
        }

        public void ClickOnSearchButton()
        {
            ClickOnElement(searchButton);
            ExtentReportBasePage.extentReport.test.Log(Status.Info, "Search button is clicked to display results");
        }
        #endregion
    }
}
