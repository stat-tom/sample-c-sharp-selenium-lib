namespace TestAutomationLibrary.ContextFeatures
{
    public interface IUrlNavigator
    {
        void GoToUrl(string url);

        void GoForward();

        void GoBack();

        void Refresh();
    }
}
