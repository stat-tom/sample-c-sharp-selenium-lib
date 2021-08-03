using TestAutomationLibrary.Controls;

namespace TestAutomationLibrary.ContextFeatures
{
    public interface IControlFinder
    {
        ITextField FindTextInput(string id);

        IButton FindButton(string name);

        IParagraph FindParagraph(string cssSelector);

        ILink FindLink(string className);

        IUnorderedList FindUnorderedList(string cssSelector);
    }
}
