using DelasportAssignment.Extentions;
using DelasportAssignment.Models;
using DelasportAssignment.Pages.HomePage;
using DelasportAssignment.Pages.RegistrationPage;
using DelasportAssignment.Pages.RegistrationPage.RegisterSecondStep;
using System;
using TechTalk.SpecFlow;

namespace DelasportAssignment
{
    [Binding]
    public class RegisterUserSecondStepSteps
    {
        private readonly HomePage homePage;
        private readonly RegisterUser registerUser;
        private readonly DataContex dataContex;

        public RegisterUserSecondStepSteps(HomePage homePage, RegisterUser registerUser, DataContex dataContex)
        {
            this.homePage = homePage;
            this.registerUser = registerUser;
            this.dataContex = dataContex;
        }

        [Given(@"The first step of registartion is compleated")]
        public void GivenTheFirstStepOfRegistartionIsCompleated()
        {
            this.dataContex.RegisterUser.CellPhone = "4747474";
            var currentEmail = this.homePage.registerFirstStep.RandomString(5) + "@abv.bg";
            var currentUsername = this.homePage.registerFirstStep.RandomString(5);
            var currentPassword = this.homePage.registerFirstStep.RandomString(5);
            this.homePage.registerFirstStep.FillInDataFirstStep(currentEmail, currentUsername, currentPassword);
            this.homePage.registerFirstStep.ClickNextButton();
        }
        [Given(@"the second screen is opened")]
        public void GivenTheSecondScreenIsOpened()
        {
            RegisterSecondStepAsserter.AssertFirstStepHeaderPositive(this.homePage.registretionHeader.FisrtStep);
            RegisterSecondStepAsserter.AssertSecondStepHeaderIsOpened(this.homePage.registretionHeader.SecondStep);
        }
        [When(@"the person data is filled in")]
        public void WhenThePersonDataIsFilledIn(Table table)
        {
            SpecflowExtensions.ChangeValues(table, this.dataContex);
            this.homePage.registerSecondStep.ChooseGender(this.registerUser.Gender);
            this.homePage.registerSecondStep.FillInDataSecondStep(
                this.dataContex.RegisterUser.FirstName,
                this.dataContex.RegisterUser.LastName,
                this.dataContex.RegisterUser.Country,
                this.dataContex.RegisterUser.Currency,
                this.dataContex.RegisterUser.Prefix,
                this.dataContex.RegisterUser.CellPhone,
                this.dataContex.RegisterUser.DayOfBirth,
                this.dataContex.RegisterUser.MonthOfBirth,
                this.dataContex.RegisterUser.YearOfBirth);

            this.homePage.registerSecondStep.TermsAndNewsLetter(true, true);
            this.homePage.registerSecondStep.ClickCreateNewAccountButton();
        }
        [Then(@"Error message for missing first name is displayed")]
        public void ThenErrorMessageForMissingFirstNameIsDisplayed()
        {
            RegisterSecondStepAsserter.AssertMissingErrorMessage("Please enter First Name", this.homePage.registerSecondStep.FirstnameErrorMessageText());
        }

        [Then(@"Error message for missing last name is displayed")]
        public void ThenErrorMessageForMissingLastNameIsDisplayed()
        {
            RegisterSecondStepAsserter.AssertMissingErrorMessage("Please enter Last Name", this.homePage.registerSecondStep.LastnameErrorMessageText());
        }

        [Then(@"Error message for missing cell phone is displayed")]
        public void ThenErrorMessageForMissingCellPhoneIsDisplayed()
        {
            RegisterSecondStepAsserter.AssertMissingErrorMessage("Please enter Cell Phone", this.homePage.registerSecondStep.CellPhoneErrorMessageText());
        }

        [Then(@"Error message for not accept the terms and conditions")]
        public void ThenErrorMessageForNotAcceptTheTermsAndConditions()
        {
            RegisterSecondStepAsserter.AssertMissingErrorMessage("Please accept the terms and conditions", this.homePage.registerSecondStep.TermsAndConditionsErrorMessageText());
        }


    }
}
