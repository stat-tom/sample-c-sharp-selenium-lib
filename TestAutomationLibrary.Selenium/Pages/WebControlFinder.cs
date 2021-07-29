using TestAutomationLibrary.Pages;
using TestAutomationLibrary.Controls;

using OpenQA.Selenium;

namespace TestAutomationLibrary.Selenium.Pages
{
    public class WebControlFinder : IWebControlFinder
    {
        private readonly IWebDriver webDriver;

        public ITextInput FindTextInput(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
