using TestAutomationLibrary.Controls;

namespace TestAutomationLibrary.ContextFeatures
{
    public interface IControlFinder
    {
        ITextField FindTextInput(string arg);

        IButton FindButton(string arg);

        IParagraph FindParagraph(string arg);

        ILink FindLink(string arg);

        IUnorderedList FindUnorderedList(string arg);
    }
}
