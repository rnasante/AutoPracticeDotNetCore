using AutoPracticeDotNetCore.Base;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace AutoPracticeDotNetCore.Hooks
{
    [Binding]
    public sealed class MainHook : Browsers
    {
        [BeforeScenario]
        public void BeforeScenario() => LaunchBrowser("Firefox");

       
        [AfterScenario]
        public void AfterScenario() => CloseBrowser();
    }
}
