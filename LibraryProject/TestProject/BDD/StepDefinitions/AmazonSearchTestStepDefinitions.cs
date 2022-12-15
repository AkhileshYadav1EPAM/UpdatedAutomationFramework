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
    public sealed class AmazonSearchTestStepDefinitions : BasePage
    {
        BasePage basePage = new BasePage();
        AmazonSearchPage amazonSearchPage = new AmazonSearchPage();
        ExtentReportBasePage extentReportBasePage = new ExtentReportBasePage();
        string targetURL = "https://www.amazon.in/";

        [Given(@"User is on the home page")]
        public void GivenUserIsOnTheHomePage()
        {
            basePage.Start();
            extentReportBasePage.ExtentReportInitialisation("AmazonSearchTest");
            NavigateToURL(targetURL);
        }

        [When(@"User enters the item to search on the amazon search bar")]
        public void WhenUserEntersTheItemToSearchOnTheAmazonSearchBar()
        {
            amazonSearchPage.EnterTextInSearchBar("C# book");
        }

        [When(@"User clicks on the search button")]
        public void WhenUserClicksOnTheSearchButton()
        {
            amazonSearchPage.ClickOnSearchButton();
        }


        [Then(@"Searched item get populated")]
        public void ThenSearchedItemGetPopulated()
        {
            extentReportBasePage.ExtentReportStop();
            driver.Close();
        }

    }
}