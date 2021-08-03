using TestAutomationLibrary.ContextFeatures;

namespace TestAutomationLibrary
{
    public class Browser
    {
        private readonly IUrlNavigator urlNavigator;

        public Browser(IContext context)
        {
            this.urlNavigator = context.UrlNavigator;
        }

        public void GoToUrl(string url)
        {
            this.urlNavigator.GoToUrl(url);
        }
    }
}
