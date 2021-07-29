using TestAutomationLibrary.Controls;

using OpenQA.Selenium;

namespace TestAutomationLibrary.Selenium.Controls
{
    public class TextInput : ITextInput
    {
        private readonly IWebElement webElement;

        public TextInput(IWebElement webElement)
        {
            this.webElement = webElement;
        }

        public void InsertText(string text)
        {
            webElement.SendKeys(text);
        }
    }
}
