using Delasport.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelasportAssignment.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver)
            : base(driver)
        {
        }

        public void LanguageChangeList(string name) => this.LanguageScreen.FindElement(By.XPath($"//span[@class='language-option-label'][contains(text(),'{name}')]")).Click();
    }
}
