using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelasportAssignment.Pages.RegistrationPage.RegisterSecondStep
{
    public partial class RegisterSecondStep
    {
        private IWebElement MaleField => Driver.FindElement(By.CssSelector("input[id$='reg_form_gender_male']"));
        private IWebElement FemaleField => Driver.FindElement(By.CssSelector("input[id$='reg_form_gender_female']"));
        private IWebElement FirstNameField => Driver.FindElement(By.CssSelector("input[id$='reg_form_fname']"));
        private IWebElement LastNameField => Driver.FindElement(By.CssSelector("input[id$='reg_form_lname']"));
        private IWebElement CountryField => Driver.FindElement(By.CssSelector("select[id$='reg_form_country_id']"));
        private IWebElement CurrencyField => Driver.FindElement(By.CssSelector("select[id$='reg_form_currency_id']"));
        private IWebElement PrfixField => Driver.FindElement(By.CssSelector("select[id$='reg_form_phone_prefix']"));
        private IWebElement DayOfBirthField => Driver.FindElement(By.CssSelector("select[id$='reg_form_birthday_day']"));
        private IWebElement MonthOfBirthField => Driver.FindElement(By.CssSelector("select[id$='reg_form_birthday_month']"));
        private IWebElement YearOfBirthField => Driver.FindElement(By.CssSelector("select[id$='reg_form_birthday_year']"));
        private IWebElement CellPhoneField => Driver.FindElement(By.CssSelector("input[id$='reg_form_cell_phone']"));
        private IWebElement TermsAndConditionsField => Driver.FindElement(By.CssSelector("input[id$='reg_form_terms_accepted']"));
        private IWebElement NewsLetterField => Driver.FindElement(By.CssSelector("input[id$='reg_form_newsletter']"));
        private IWebElement CreateNewAccountButton => Driver.FindElement(By.Id("submit-reg-form"));

        private IWebElement FirstNameErrorMessage => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='reg_form_fname']/following::div[1]")));
        private IWebElement LastNameErrorMessage => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='reg_form_lname']/following::div[1]")));
        private IWebElement CellPhoneErrorMessage => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='reg_form_cell_phone']/following::div[1]")));
        private IWebElement TermsAndConditionsMessage => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='reg_form_terms_accepted']/following::div[1]")));
        public string FirstName
        {
            get => this.FirstNameField.GetAttribute("value");
            set => this.FirstNameField.SendKeys(value);
        }

        public string LastName
        {
            get => this.LastNameField.GetAttribute("value");
            set => this.LastNameField.SendKeys(value);
        }

        public string CellPhone
        {
            get => this.CellPhoneField.GetAttribute("value");
            set => this.CellPhoneField.SendKeys(value);
        }

        public SelectElement Country => new SelectElement(this.CountryField);     
        public SelectElement Currency => new SelectElement(this.CurrencyField);
        public SelectElement Prfix => new SelectElement(this.PrfixField);    
        public SelectElement DayOfBirth => new SelectElement(this.DayOfBirthField);   
        public SelectElement MonthOfBirth => new SelectElement(this.MonthOfBirthField);    
        public SelectElement YearOfBirth => new SelectElement(this.YearOfBirthField);
     

       
    }
}
