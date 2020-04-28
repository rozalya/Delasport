using Delasport.Pages.HomePage;
using Delasport.Pages.RegisterField;
using DelasportAssignment.Extentions;
using DelasportAssignment.Models;
using DelasportAssignment.Pages.HomePage;
using System;
using TechTalk.SpecFlow;

namespace DelasportAssignment.Tests.Steps
{
    [Binding]
    public class UserRegisterSteps
    {
        private readonly HomePage homePage;
        private readonly RegisterUser registerUser;
        private readonly DataContex dataContex;

        public UserRegisterSteps(HomePage homePage, RegisterUser registerUser, DataContex dataContex)
        {
            this.homePage = homePage;
            this.registerUser = registerUser;
            this.dataContex = dataContex;
        }
        [Given(@"Registeration screen is opend")]
        public void GivenRegisterationScreenIsOpend()
        {
            HomePageAsserter.AssertRegistrationButtonIsDisplayed(this.homePage.RegirstratonButton);
            this.homePage.RegirstratonButton.Click();
            HomePageAsserter.AssertRegisterScreenOpened(this.homePage.RegisterScreen);
        }

        [When(@"the data is filled in")]
        public void WhenTheDataIsFilledIn(Table table)
        {
            SpecflowExtensions.ChangeValues(table, this.dataContex);
            this.homePage.registerFirstStep.FillInDataFirstStep(this.dataContex.RegisterUser.Email, this.dataContex.RegisterUser.Username, this.dataContex.RegisterUser.Password);
            this.homePage.registerFirstStep.ClickNextButton();
        }

        [Then(@"Error message is displayed")]
        public void ThenErrorMessageIsDisplayed()
        {
            RegisterFirstStepAsserter.AssertInvalidEmailMessage(this.homePage.registerFirstStep.EmailErrorMessageText());
        }
        [Then(@"Error message for missing usernme is displayed")]
        public void ThenErrorMessageForMissingUsernmeIsDisplayed()
        {
            RegisterFirstStepAsserter.AssertMIssingUsernameMessage(this.homePage.registerFirstStep.UsernameErrorMessageText());
        }
        [Then(@"Error message for missing password is displayed")]
        public void ThenErrorMessageForMissingPasswordIsDisplayed()
        {
            RegisterFirstStepAsserter.AssertMissingPasswordMessage(this.homePage.registerFirstStep.PasswordErrorMessageText());
        }


    }
}
