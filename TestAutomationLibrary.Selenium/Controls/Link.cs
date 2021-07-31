using TestAutomationLibrary.Controls;

using OpenQA.Selenium;

namespace TestAutomationLibrary.Selenium.Controls
{
    public class Link : ILink
    {
        private readonly IWebElement webElement;

        public Link(IWebElement webElement)
        {
            this.webElement = webElement;
        }

        public void Click()
        {
            webElement.Click();
        }
    }
}
