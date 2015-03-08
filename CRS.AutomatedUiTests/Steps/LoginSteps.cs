using CRS.AutomatedUiTests.PageObjects;
using CRS.AutomatedUiTests.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace CRS.AutomatedUiTests.Steps
{
    /// <summary>
    /// Contains the SpecFlow step methods that bind to the LogIn.feature file
    /// </summary>
    [Binding]
    public class LoginSteps
    {
        readonly LoginPage _loginPage = new LoginPage();

        [Given(@"I navigate to '(.*)'")]
        public void GivenINavigateTo(string url)
        {
            WebBrowser.Current.Navigate().GoToUrl(url);
        }

        [When(@"I login as an administrator")]
        public void WhenILoginAsAnAdministrator()
        {
            _loginPage.LoginAsAdministrator();
        }

        [When(@"I login as '(.*)' and '(.*)'")]
        public void WhenILoginAsAnd(string username, string password)
        {
            _loginPage.LoginAs(username, password);
        }

        [Then(@"I am logged into the CRS website")]
        public void ThenIAmLoggedIntoTheCrsWebsite()
        {
            Assert.IsTrue(!Utility.Utility.IsElementPresent(By.Id("dnn_ctr437_View_tbUsername")));
        }

        [Then(@"I am not logged into the CRS website")]
        public void ThenIAmNotLoggedIntoTheCrsWebsite()
        {
            Assert.IsTrue(Utility.Utility.IsElementPresent(By.Id("dnn_ctr437_View_tbUsername")));
        }
    }
}