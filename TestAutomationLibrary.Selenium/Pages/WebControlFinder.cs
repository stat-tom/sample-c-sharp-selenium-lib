using TestAutomationLibrary.Pages;
using TestAutomationLibrary.Controls;
using TestAutomationLibrary.Selenium.Controls;

using OpenQA.Selenium;

namespace TestAutomationLibrary.Selenium.Pages
{
    public class WebControlFinder : IWebControlFinder
    {
        private readonly IWebDriver webDriver;

        public WebControlFinder(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public ITextInput FindTextInput(string id)
        {
            var webElement = webDriver.FindElement(By.Id(id));
            //to do check if it is text input; throw exception if null

            return new TextInput(webElement);
        }
    }
}
