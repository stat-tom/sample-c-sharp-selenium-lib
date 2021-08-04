using TestAutomationLibrary.ContextFeatures;
using TestAutomationLibrary.Selenium.ContextFeatures;

using OpenQA.Selenium;

namespace TestAutomationLibrary.Selenium
{
    public abstract class Context : IContext
    {
        private readonly IControlFinder controlFinder;

        private readonly IUrlNavigator urlNavigator;

        private readonly IWaiting waiting;

        private readonly IWebDriver webDriver;

        public Context(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            controlFinder = new ControlFinder(webDriver);
            urlNavigator = new UrlNavigator(webDriver);
        }

        public IControlFinder ControlFinder => controlFinder;

        public IUrlNavigator UrlNavigator => urlNavigator;

        public IWaiting Waiting => waiting;

        public void Quit()
        {
            webDriver.Quit();
        }
    }
}
