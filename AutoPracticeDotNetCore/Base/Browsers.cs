using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace AutoPracticeDotNetCore.Base
{
    public class Browsers : Driver
    {
        
        private IWebDriver InitFirefox()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            return new FirefoxDriver();
        }

        private IWebDriver InitChrome()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            return new ChromeDriver();
            
        }
        private IWebDriver InitHeadless()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            FirefoxOptions options = new FirefoxOptions();
            options.AddArguments("--disable-gpu", "--headless");
            return new FirefoxDriver(options);

        }

        public void LaunchBrowser(string browser)
        {
            _driver = browser switch
            {
                "Firefox" => InitFirefox(),
                "Chrome" => InitChrome(),
                "Headless" => InitHeadless(),
                _ => InitFirefox()
            };

            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            //DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(_driver);
            //fluentWait.Timeout = TimeSpan.FromSeconds(5);
            //fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            //fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            //WebDriverWait wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 30));
            //wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.LinkText("Sign in")));


        }


        public void CloseBrowser()
        {
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Close();
        }

       

    }     
    
}
