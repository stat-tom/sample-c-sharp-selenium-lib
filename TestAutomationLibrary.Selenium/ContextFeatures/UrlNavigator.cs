using TestAutomationLibrary.ContextFeatures;

using OpenQA.Selenium;

namespace TestAutomationLibrary.Selenium.ContextFeatures
{
    public class UrlNavigator : IUrlNavigator
    {
        private readonly IWebDriver webDriver;

        public UrlNavigator(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public void GoToUrl(string url)
        {
            webDriver.Navigate().GoToUrl(url);
        }
    }
}
