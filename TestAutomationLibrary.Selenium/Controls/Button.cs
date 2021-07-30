using TestAutomationLibrary.Controls;

using OpenQA.Selenium;

namespace TestAutomationLibrary.Selenium.Controls
{
    public class Button : IButton
    {
        private readonly IWebElement webElement;

        public Button(IWebElement webElement)
        {
            this.webElement = webElement;
        }

        public void Click()
        {
            webElement.Click();
        }
    }
}
