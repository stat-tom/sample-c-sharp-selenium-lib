using TestAutomationLibrary.Controls;

namespace TestAutomationLibrary.Pages
{
    public interface IWebControlFinder
    {
        ITextInput FindTextInput(string id);
    }
}
