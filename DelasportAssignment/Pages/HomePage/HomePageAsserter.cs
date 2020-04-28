using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delasport.Pages.HomePage
{
    public static class HomePageAsserter
    {
        public static void AssertRegistrationButtonIsDisplayed(IWebElement registartionButton)
        {
            Assert.IsTrue(registartionButton.Displayed, "Registration button is not dispalyed!");
        }

        public static void AssertRegisterScreenOpened(IWebElement registerScreen)
        {
            Assert.IsTrue(registerScreen.Displayed, "Registration button is not dispalyed!");
        }
      
    }
}
