using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelasportAssignment.Pages.RegistrationPage
{
    public class RegistretionHeader : BasePage
    {
        public RegistretionHeader(IWebDriver driver, IWebElement section) 
            : base(driver)
        {
        }

        public IWebElement FisrtStep => Driver.FindElement(By.XPath("//div[contains(text(),'Account Details')]"));
        public IWebElement SecondStep => Driver.FindElement(By.XPath("//div[contains(text(),'Contact Details')]"));
        public IWebElement ThirdStep => Driver.FindElement(By.XPath("//div[contains(text(),'Account Created')]"));
    }
}
