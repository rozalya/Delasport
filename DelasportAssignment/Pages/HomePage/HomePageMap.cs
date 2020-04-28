using Delasport.Pages.RegisterField;
using DelasportAssignment.Pages.RegisterField;
using DelasportAssignment.Pages.RegistrationPage;
using DelasportAssignment.Pages.RegistrationPage.RegisterSecondStep;
using DelasportAssignment.Pages.RegistrationPage.RegisterThirdStep;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelasportAssignment.Pages.HomePage
{
    public partial class HomePage
    {
    
        public RegistretionHeader registretionHeader => new RegistretionHeader(Driver, this.RegisterScreen);
        public RegisterFirstStep registerFirstStep => new RegisterFirstStep(Driver, this.RegisterScreen);
        public RegisterSecondStep registerSecondStep => new RegisterSecondStep(Driver, this.RegisterScreen);
        public RegisterThirdStep registerThirdStep => new RegisterThirdStep(Driver, this.RegisterScreen);
        public IWebElement RegirstratonButton => Driver.FindElement(By.XPath("//button[@class='btn btn-sm header-register-button header-menu-button']"));
        public IWebElement LanguageScreen => Driver.FindElement(By.CssSelector("#serviceBarPrimaryRight .language-select-service-item .dropdown-menu"));
        public IWebElement LanguageButton => Driver.FindElement(By.CssSelector("div[class$='language-select-service-item'] .dropdown-toggle"));
        public IWebElement RegisterScreen => Driver.FindElement(By.CssSelector("div[id$='register-user-modal']"));
     
    }
}
