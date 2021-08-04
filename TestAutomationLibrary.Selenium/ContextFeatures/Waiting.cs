using System;

using TestAutomationLibrary.ContextFeatures;

using OpenQA.Selenium;

namespace TestAutomationLibrary.Selenium.ContextFeatures
{
    public class Waiting : IWaiting
    {
        private readonly IWebDriver webDriver;

        public Waiting(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public void WaitForPageLoad(int seconds)
        {
            webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(seconds);
        }
    }
}