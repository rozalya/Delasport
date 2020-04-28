using BoDi;
using Bogus;
using DelasportAssignment.Models;
using Microsoft.Win32;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace DelasportAssignment.Pages
{
    [Binding]
    public  class Hooks
    {
        public IWebDriver driver;
        protected string url = ConfigurationManager.AppSettings["URL"];
        private IObjectContainer container;
        private readonly DataContex dataContex;
        public static string ExecutionBrowser = Environment.GetEnvironmentVariable("Browser");

        public Hooks(IObjectContainer container, DataContex dataContex)
        {
            this.container = container;
            this.dataContex = dataContex;

        }

        [BeforeScenario]
        public void CreateWebDriver()
        {
            if (ExecutionBrowser.Contains("Firefox"))
            {
                this.driver = new FirefoxDriver();
                this.driver.Manage().Window.Maximize();
                container.RegisterInstanceAs<IWebDriver>(driver);
                driver.Url = url;
            }
            else
            {
                this.driver = new ChromeDriver();
                this.driver.Manage().Window.Maximize();
                container.RegisterInstanceAs<IWebDriver>(driver);
                driver.Url = url;
            }
          
        }

       



        [AfterScenario]
        public void DestroyWebDriver()
        {
            driver.Quit();
            driver.Dispose();
        }


    }
}

