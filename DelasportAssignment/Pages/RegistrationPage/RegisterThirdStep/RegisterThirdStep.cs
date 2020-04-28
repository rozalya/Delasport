using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelasportAssignment.Pages.RegistrationPage.RegisterThirdStep
{
    public partial class RegisterThirdStep : BasePage
    {
        public RegisterThirdStep(IWebDriver driver, IWebElement section) 
            : base(driver)
        {
        }

       public bool IsCreatedAccount()
        {
           return this.SuccessfullyCreatedAccountMessage.Displayed;
        }
    }
}
