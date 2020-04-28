using DelasportAssignment.Pages.HomePage;
using System;
using TechTalk.SpecFlow;

namespace DelasportAssignment.Tests.LanguageChangeTests.Steps
{
    [Binding]
    public class LanguageChangeSteps
    {
        private readonly HomePage homePage;

        public LanguageChangeSteps(HomePage homePage)
        {
            this.homePage = homePage;
        }

        [Given(@"the (.*) language is choosen")]
        public void GivenTheLanguageIsChoosen(string language)
        {
            this.homePage.LanguageButton.Click();
            this.homePage.LanguageChangeList("language");
        }

        [When(@"the site (.*) is changed")]
        public void WhenTheSiteIsChanged(string language)
        {
            this.homePage.Driver.PageSource.Contains($"lang={language}");
        }


    }
}
