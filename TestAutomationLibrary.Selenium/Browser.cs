using OpenQA.Selenium;

namespace TestAutomationLibrary.Selenium
{
    public class Browser : IBrowser
    {
        private readonly IWebDriver webDriver;

        public Browser(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public void GoToUrl(string url)
        {
            webDriver.Navigate().GoToUrl(url);
        }
    }
}
