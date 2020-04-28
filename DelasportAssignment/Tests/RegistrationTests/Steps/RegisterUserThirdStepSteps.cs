using DelasportAssignment.Models;
using DelasportAssignment.Pages.HomePage;
using DelasportAssignment.Pages.RegistrationPage.RegisterThirdStep;
using System;
using TechTalk.SpecFlow;

namespace DelasportAssignment.Tests.Steps
{
    [Binding]
    public class RegisterUserThirdStepSteps
    {
        private readonly HomePage homePage;
        private readonly RegisterUser registerUser;

        public RegisterUserThirdStepSteps(HomePage homePage, RegisterUser registerUser)
        {
            this.homePage = homePage;
            this.registerUser = registerUser;
        }

        [Then(@"new account is created")]
        public void ThenNewAccountIsCreated()
        {
            RegisterThirdStepAsserter.AssertThirdStepHeaderIsOpened(this.homePage.registretionHeader.ThirdStep);
            RegisterThirdStepAsserter.AssertAccountIsCreated(this.homePage.registerThirdStep.IsCreatedAccount());
        }

    }
}
