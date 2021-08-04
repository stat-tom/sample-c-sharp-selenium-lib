namespace TestAutomationLibrary.ContextFeatures
{
    public interface IWaiting
    {
        void WaitForPageLoad(int seconds);

        void ImplicitWait(int seconds);
    }
}
