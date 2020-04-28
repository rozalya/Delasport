using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelasportAssignment.Pages.RegistrationPage.RegisterSecondStep
{
    public static class RegisterSecondStepAsserter
    {
        public static void AssertFirstStepHeaderPositive(IWebElement webElement)
        {
            Assert.AreEqual("#0daa8d", webElement.GetCssValue("color"), "The first step of registartion is not marked as complete!");
        }

        public static void AssertSecondStepHeaderIsOpened(IWebElement webElement)
        {
            Assert.AreEqual("#ffe615", webElement.GetCssValue("color"), "The second step of registartion is not marked as ready!");
        }
        public static void AssertMissingErrorMessage(string expectedMessage, string actualMessage)
        {
            Assert.AreEqual(expectedMessage, actualMessage, $"The error message: {expectedMessage} is not displayed!");
        }
    }
}
