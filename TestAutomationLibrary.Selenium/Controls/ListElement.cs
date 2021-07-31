using TestAutomationLibrary.Controls;

using OpenQA.Selenium;

namespace TestAutomationLibrary.Selenium.Controls
{
    public class ListElement : IListElement
    {
        private readonly IWebElement webElement;

        public ListElement(IWebElement webElement)
        {
            this.webElement = webElement;
        }

        public string Text => webElement.Text;

    }
}
