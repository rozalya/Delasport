using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delasport.Pages.RegisterField
{
    public static class RegisterFirstStepAsserter
    {
        public static void AssertInvalidEmailMessage(string message)
        {
            Assert.AreEqual("Please enter valid Email", message, "Registration error message for invalid email is not dispalyed!");
        }

        public static void AssertMIssingUsernameMessage(string message)
        {
            Assert.AreEqual("Please enter Username", message, "Registration error message for missing username is not dispalyed!");
        }
        public static void AssertMissingPasswordMessage(string message)
        {
            Assert.AreEqual("Your password should contain at least 3 characters.", message, "Registration error message for missing password is not dispalyed!");
        }
    }
}
