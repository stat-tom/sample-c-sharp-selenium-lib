using TestAutomationLibrary.Controls;

namespace TestAutomationLibrary.ContextFeatures
{
    public interface IControlFinder
    {
        ITextField FindTextField(By by);
        ITextField FindTextFieldWithWait(By by);

        IButton FindButton(By by);
        IButton FindButtonWithWait(By by);

        IParagraph FindParagraph(string arg);

        ILink FindLink(string arg);

        IUnorderedList FindUnorderedList(string arg);
    }
}
