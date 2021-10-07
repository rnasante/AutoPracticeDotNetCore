using AutoPracticeDotNetCore.Pages;
using System;
using TechTalk.SpecFlow;

namespace AutoPracticeDotNetCore.Steps
{
    [Binding]
    public class SigninPageAssertionsSteps : BasePage 
    {
        HomePage homePage = new HomePage(_driver);
        SigninPage signinPage = new SigninPage(_driver);

        [Given(@"I navigate to Automation Practice Homepage")]
        public void GivenINavigateToAutomationPracticeHomepage()
        {
            LaunchSite(); 
        }
        
        [Given(@"I click on Sign in link")]
        public void GivenIClickOnSignInLink()
        {
            homePage.ClickSigninLink();
        }
        
        [When(@"I enter ""(.*)"" at email address textbox")]
        public void WhenIEnterAtEmailAddressTextbox(string email)
        {
            signinPage.EnterEmail(email);
        }
        
        [When(@"I enter ""(.*)"" at password")]
        public void WhenIEnterAtPassword(string password)
        {
            signinPage.EnterPassword(password);
        }
        
        [When(@"I click on Sign in button")]
        public void WhenIClickOnSignInButton()
        {
            signinPage.ClickSigninBtn();
        }
        
        [Then(@"the error message reads ""(.*)""")]
        public void ThenTheErrorMessageReads(string error)
        {
            signinPage.DisplayErrorMsg(error);
        }
    }
}
