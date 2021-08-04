using TestAutomationLibrary.ContextFeatures;

using OpenQA.Selenium;

namespace TestAutomationLibrary.Selenium.ContextFeatures
{
    public class UrlNavigator : IUrlNavigator
    {
        private readonly INavigation navigation;

        public UrlNavigator(IWebDriver webDriver)
        {
            this.navigation = webDriver.Navigate();
        }

        public void GoToUrl(string url)
        {
            navigation.GoToUrl(url);
        }

        public void GoForward()
        {
            navigation.Forward();
        }

        public void GoBack()
        {
            navigation.Back();
        }

        public void Refresh()
        {
            navigation.Refresh();
        }
    }
}
