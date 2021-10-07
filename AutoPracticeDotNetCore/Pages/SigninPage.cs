using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPracticeDotNetCore.Pages
{
    public class SigninPage : BasePage
    {
        
        public SigninPage(IWebDriver driver)
        {
            _driver = driver;
        }

        IWebElement  emailTxtBox => _driver.FindElement(By.Id("email"));

        IWebElement passwdTxtBox => _driver.FindElement(By.Id("passwd"));

        IWebElement errorAlert => _driver.FindElement(By.XPath("*//div[@class = 'alert alert-danger']/ol/li"));

        IWebElement submitBtn => _driver.FindElement(By.XPath("*//button[@name = 'SubmitLogin']"));

        public void EnterEmail (string email)
        {
            emailTxtBox.Clear();
            emailTxtBox.SendKeys(email);
        }

        public void EnterPassword (string password)
        {
            passwdTxtBox.Clear();
            passwdTxtBox.SendKeys(password);
        }

        public void ClickSigninBtn()
        {
            submitBtn.Submit();
        }

        public void DisplayErrorMsg(string error)
        {
            var errorMsg = errorAlert.Text;
            Assert.IsTrue(errorMsg.Contains(error));
        }
    }
}
