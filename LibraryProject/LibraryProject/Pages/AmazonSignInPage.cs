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
            
           /* wait = wait.ShorterWait();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(passwordText));*/
        }

        public void EnterTheEmail(string email)
        {
            SendKeysToField(emailId, email);
            ClickOnElement(continueButton);
        }

        public void EnterThePassword(string password)
        {
            SendKeysToField(passwordText, password);
            ClickOnElement(signInButtonFinal);
        }


        #endregion
    }
}
