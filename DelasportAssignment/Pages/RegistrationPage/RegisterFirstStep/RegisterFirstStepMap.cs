using DelasportAssignment.Extentions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace DelasportAssignment.Pages.RegisterField
{
    public partial class RegisterFirstStep
    {
        //private readonly IWebDriver driver;
        //private readonly WebDriverWait wait;

        //public RegisterFirstStep(IWebElement section, IWebDriver driver)
        //{
        //    PageFactory.InitElements(section, this);
        //    this.driver = driver;
        //    this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
        //    driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
        //}

        private IWebElement EmailField => Driver.FindElement(By.CssSelector("input[id$='reg_form_email']"));
        private IWebElement UsernameField => Driver.FindElement(By.CssSelector("input[id$='reg_form_username']"));
        private IWebElement PasswordField => Driver.FindElement(By.CssSelector("input[id$='reg_form_password']"));
        //private IWebElement NextButton => this.driver.FindElement(By.Id("next-registration-step"));
        private IWebElement NextButton => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("next-registration-step")));
        private IWebElement EmailErrorMessage => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='reg_form_email']/following::div[1]")));
        private IWebElement UsernameErrorMessage => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='reg_form_username']/following::div[1]")));
        private IWebElement PasswordErrorMessage => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='reg_form_password']/following::div[1]")));



        public string Email
        {
            get => this.EmailField.GetAttribute("value");
            set => this.EmailField.SendKeys(value);
        }

        public string Username
        {
            get => this.UsernameField.GetAttribute("value");
            set => this.UsernameField.SendKeys(value);
        }

        public string Password
        {
            get => this.PasswordField.GetAttribute("value");
            set => this.PasswordField.SendKeys(value);
        }
       


    }
}
