using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelasportAssignment.Pages.RegistrationPage.RegisterThirdStep
{
    public static class RegisterThirdStepAsserter
    {
        public static void AssertAccountIsCreated(bool isCreated)
        {
            Assert.IsTrue(isCreated, "The confirmation message for created account is not dispalyed!");
        }
        public static void AssertThirdStepHeaderIsOpened(IWebElement webElement)
        {
            Assert.AreEqual("#ffe615", webElement.GetCssValue("color"), "The second step of registartion is not marked as ready!");
        }
    }
}
