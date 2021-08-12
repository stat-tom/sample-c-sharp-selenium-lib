using TestAutomationLibrary.Controls;

namespace TestAutomationLibrary.ContextFeatures
{
    public interface IControlFinder
    {
        ITextField FindTextField(By by);
        ITextField FindTextFieldWithWait(By by);

        IButton FindButton(By by);
        IButton FindButtonWithWait(By by);

        IParagraph FindParagraph(By by);

        ILink FindLink(By by);

        IUnorderedList FindUnorderedList(By by);
    }
}
