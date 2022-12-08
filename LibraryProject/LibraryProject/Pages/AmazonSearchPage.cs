using OpenQA.Selenium;
using LibraryProject.Utilities.PageUtilityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Pages
{
    public class AmazonSearchPage : PageUtility
    {
        By element;

        #region Locators
        private By searchBar => By.XPath("//*[@id=\"twotabsearchtextbox\"]");
        private By searchButton => By.XPath("//*[@id=\"nav-search-submit-button\"]");
        public By signInButton => By.XPath("//*[@id=\"nav-link-accountList\"]");
        #endregion

        #region Actions
        public void EnterTextInSearchBar(string searchText)
        {
            SendKeysToField(searchBar, searchText);
        }

        public void ClickOnSearchButton()
        {
            ClickOnElement(searchButton);
        }
        #endregion
    }
}
