using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelasportAssignment.Pages.RegistrationPage.RegisterSecondStep
{
    public partial class RegisterSecondStep : BasePage
    {
        public RegisterSecondStep(IWebDriver driver, IWebElement section) 
            : base(driver)
        {
        }

        public void CountryList(string name) => this.Country.SelectByText(name);
        public void CurrencyList(string name) => this.Currency.SelectByText(name);
        public void PrfixList(string name) => this.Prfix.SelectByText(name);
        public void DayOfBirthList(string name) => this.DayOfBirth.SelectByText(name);
        public void MonthOfBirthList(string name) => this.MonthOfBirth.SelectByText(name);
        public void YearOfBirthList(string name) => this.YearOfBirth.SelectByText(name);

        public void FillInDataSecondStep(
            string firstName, 
            string lastName,
            string country, 
            string currency, 
            string prefix,  
            string cellPhone,
            string dayOfBirth,
            string monthOfBirth,
            string yearOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CellPhone = cellPhone;
            this.CountryList(country);
            this.CurrencyList(currency);
            this.PrfixList(prefix);
            this.DayOfBirthList(dayOfBirth);
            this.MonthOfBirthList(monthOfBirth);
            this.YearOfBirthList(yearOfBirth);
        }
        public void ChooseGender(string gender)
        {
           if(gender == "male")
            {
                this.MaleField.Click();
            }
            else if (gender == "female")
            {
                this.FemaleField.Click();
            }               
        }

        public void TermsAndNewsLetter(bool tearms, bool newsLetter)
        {
            if (tearms && !this.TermsAndConditionsField.Selected)
            {
                this.TermsAndConditionsField.Click();
            }
            else if (newsLetter && !this.NewsLetterField.Selected)
            {
                this.NewsLetterField.Click();
            }
            else if(!tearms && this.TermsAndConditionsField.Selected)
            {
                this.TermsAndConditionsField.Click();
            }
            else if (!newsLetter && this.NewsLetterField.Selected)
            {
                this.NewsLetterField.Click();
            }
        }

        public void ClickCreateNewAccountButton()
        {
            this.CreateNewAccountButton.Click();
        }
        public string FirstnameErrorMessageText()
        {
            return this.FirstNameErrorMessage.Text;
        }

        public string LastnameErrorMessageText()
        {
            return this.LastNameErrorMessage.Text;
        }

        public string CellPhoneErrorMessageText()
        {
            return this.CellPhoneErrorMessage.Text;
        }

        public string TermsAndConditionsErrorMessageText()
        {
            return this.TermsAndConditionsMessage.Text;
        }
    }
}
