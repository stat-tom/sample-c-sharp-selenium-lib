using TestAutomationLibrary.Controls;

using OpenQA.Selenium;

namespace TestAutomationLibrary.Selenium.Controls
{
    public class ListItem : IListItem
    {
        private readonly IWebElement webElement;

        public ListItem(IWebElement webElement)
        {
            this.webElement = webElement;
        }

        public string Text => webElement.Text;
    }
}
