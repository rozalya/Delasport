using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelasportAssignment.Pages.RegistrationPage.RegisterThirdStep
{
    public partial class RegisterThirdStep
    {
        private IWebElement SuccessfullyCreatedAccountMessage => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(text(),'You have successfully created your account! To unl')]")));

    }
}
