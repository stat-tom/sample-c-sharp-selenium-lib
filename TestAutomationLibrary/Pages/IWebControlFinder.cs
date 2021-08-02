using TestAutomationLibrary.Controls;

namespace TestAutomationLibrary.Pages
{
    public interface IWebControlFinder
    {
        ITextInput FindTextInput(string id);

        IButton FindButton(string name);

        IParagraph FindParagraph(string cssSelector);

        ILink FindLink(string className);

        IUnorderedList FindUnorderedList(string cssSelector);
    }
}
