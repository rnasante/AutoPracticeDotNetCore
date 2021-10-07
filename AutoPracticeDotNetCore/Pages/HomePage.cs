using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPracticeDotNetCore.Pages
{
    public class HomePage : BasePage
    {
        public HomePage (IWebDriver driver)
        {
            _driver = driver;

            //_driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(25);
            //WebDriverWait wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 1000));
            //wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("login")));

        }

        IWebElement SigninLnk => _driver.FindElement(By.LinkText("Sign in"));
        
        public SigninPage ClickSigninLink ()
        {
            SigninLnk.Click();
            return new SigninPage(_driver);
        }

        
        
    }
}
