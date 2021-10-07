using AutoPracticeDotNetCore.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPracticeDotNetCore.Pages
{
    public class BasePage : Driver
    {
        public string siteUrl = "http://automationpractice.com/";


        public void LaunchSite() => _driver.Navigate().GoToUrl(siteUrl);


    }

    
}
