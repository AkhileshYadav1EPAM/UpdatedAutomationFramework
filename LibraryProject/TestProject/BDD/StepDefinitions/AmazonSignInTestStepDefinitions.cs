using CommonFramework.Base;
using LibraryProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace LoginSwagLabsSpecFlow.StepDefinitions
{
    [Binding]
    public sealed class AmazonSignInTestStepDefinitions : BasePage
    {
        BasePage basePage = new BasePage();
        AmazonSignInPage amazonSignInPage = new AmazonSignInPage();
        ExtentReportBasePage extentReportBasePage = new ExtentReportBasePage();
        AmazonSearchPage searchPage = new AmazonSearchPage();
        string targetURL = "https://www.amazon.in/";

        [Given(@"User is on the page https://www\.amazon\.in/")]
        public void GivenUserIsOnThePageHttpsWww_Amazon_In()
        {
            basePage.Start();
            extentReportBasePage.ExtentReportInitialisation("AmazonSignInTest");
            NavigateToURL(targetURL);
        }

        [When(@"User clicks on the signIn button")]
        public void WhenUserClicksOnTheSignInButton()
        {
            amazonSignInPage.ClickOnSignInButton();
        }

        [When(@"User enters the email/mobile number and clicks continue")]
        public void WhenUserEntersTheEmailMobileNumberAndClicksContinue()
        {
            amazonSignInPage.EnterTheEmail("ModiJi@gmail.com");
        }

        [When(@"User enters the password ans clicks signIn")]
        public void WhenUserEntersThePasswordAnsClicksSignIn()
        {
            amazonSignInPage.EnterThePassword("123456");
        }

        [Then(@"LogIn unsuccessful message is displayed")]
        public void ThenLogInUnsuccessfulMessageIsDisplayed()
        {
            extentReportBasePage.ExtentReportStop();
            driver.Close();
        }




    }
}