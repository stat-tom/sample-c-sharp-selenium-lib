using TestAutomationLibrary.ContextFeatures;

namespace TestAutomationLibrary
{
    public interface IContext
    {
        IControlFinder ControlFinder { get; }
        IUrlNavigator UrlNavigator { get; }
        IWaiting Waiting { get; }

        void Quit();
    }
}
