using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelasportAssignment.Pages.RegisterField
{
    public partial class RegisterFirstStep : BasePage
    {
        public RegisterFirstStep(IWebDriver driver, IWebElement section) 
            : base(driver)
        {
        }
        public void ClickNextButton()
        {
            this.NextButton.Click();
        }
        public string EmailErrorMessageText()
        {
            return this.EmailErrorMessage.Text;
        }

        public string UsernameErrorMessageText()
        {
            return this.UsernameErrorMessage.Text;
        }

        public string PasswordErrorMessageText()
        {
            return this.PasswordErrorMessage.Text;
        }
        public void FillInDataFirstStep(string email, string username, string password)
        {
            this.Email = email;
            this.Username = username;
            this.Password = password;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public string RandomString(int length)
        {
            Random Random = new Random();
            const string chars =
                   "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                   "abcdefghijklmnopqrstuvwxyz" +
                   "0123456789";
            return new string(chars.Select(c => chars[Random.Next(chars.Length)]).Take(8).ToArray());
        }
    }
}
