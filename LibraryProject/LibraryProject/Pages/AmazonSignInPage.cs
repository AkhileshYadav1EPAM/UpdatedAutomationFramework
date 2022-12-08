using OpenQA.Selenium;
using LibraryProject.ExtensionMethods;
using LibraryProject.Utilities.PageUtilityClass;
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
        By element;

        #region Locators
        By emailId => By.XPath("//*[@id=\"ap_email\"]");
        By continueButton => By.XPath("//*[@id=\"continue\"]");
        By passwordText => By.XPath("//*[@id=\"ap_password\"]");
        By signInButtonFinal => By.XPath("//*[@id=\"signInSubmit\"]");
        #endregion

        #region Actions
        public void TypeTheCredentials(string username, string password)
        {
            AmazonSearchPage searchPage = new AmazonSearchPage();
            ClickOnElement(searchPage.signInButton);
            SendKeysToField(emailId, username);
            ClickOnElement(continueButton);
           /* wait = wait.ShorterWait();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(passwordText));*/
            SendKeysToField(passwordText, password);
            ClickOnElement(signInButtonFinal);
        }
        #endregion
    }
}
