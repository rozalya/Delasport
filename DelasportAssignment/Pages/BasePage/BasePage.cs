using BoDi;
using NLog.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using System.Linq;

namespace DelasportAssignment.Pages
{
    public class BasePage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
   
        

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(30));
        }

        public IWebDriver Driver
        {
            get
            {
                return this.driver;
            }
        }

        public WebDriverWait Wait
        {
            get
            {
                return this.wait;
            }
        }
        //public void StartBrowser()
        //{
        //    this.driver = new ChromeDriver();
        //    container.RegisterInstanceAs<IWebDriver>(driver);
 
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        //}
        //public void StopBrowser()
        //{
        //    var driver = container.Resolve<IWebDriver>();

        //    driver.Quit();
        //    driver.Dispose();
        //}
    }
}
