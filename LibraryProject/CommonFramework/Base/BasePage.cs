using AventStack.ExtentReports.Configuration;
using CommonFramework.Utilities.PageUtilityClass;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using System.Configuration;

namespace CommonFramework.Base
{
    public class BasePage : PageUtility
    {
        public string browserName;
        public void Start()
        {
            browserName = System.Configuration.ConfigurationManager.AppSettings["browser"];
            InitialBrowser(browserName);
        }

        public void InitialBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;

                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;

                case "Edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    break;
            }
        }

        public void End()
        {
            driver.Quit();
        }
    }
}
