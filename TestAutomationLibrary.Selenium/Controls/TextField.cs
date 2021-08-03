using TestAutomationLibrary.Controls;

using OpenQA.Selenium;

namespace TestAutomationLibrary.Selenium.Controls
{
    public class TextField : ITextField
    {
        private readonly IWebElement webElement;

        public TextField(IWebElement webElement)
        {
            this.webElement = webElement;
        }

        public void InsertText(string text)
        {
            webElement.SendKeys(text);
        }
    }
}
