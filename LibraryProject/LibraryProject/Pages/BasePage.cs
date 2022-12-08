using LibraryProject.Utilities.PageUtilityClass;
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

namespace LibraryProject.Pages
{
    public class BasePage : PageUtility
    {
        public void Start()
        {
            driver = new ChromeDriver();
        }

        public void End()
        {
            driver.Close();
        }


        /*public string browserName;
        public void Start()
        {
            browserName = ConfigurationManager.AppSettings["browser"];
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
        }*/
    }
}
