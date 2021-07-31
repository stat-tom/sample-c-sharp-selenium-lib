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

        public IButton FindButton(string name)
        {
            var webElement = webDriver.FindElement(By.Name(name));
            //to do check if it is text input; throw exception if null

            return new Button(webElement);
        }

        public ILink FindLink(string name)
        {
            var webElement = webDriver.FindElement(By.ClassName(name));
            //to do check if it is text input; throw exception if null

            return new Link(webElement);
        }

        public IListElement FindListElement(string cssSelector)
        {
            var webElement = webDriver.FindElement(By.CssSelector(cssSelector));
            //to do check if it is text input; throw exception if null

            return new ListElement(webElement);
        }

        public IParagraph FindParagraph(string cssSelector)
        {
            var webElement = webDriver.FindElement(By.CssSelector(cssSelector));
            //to do check if it is text input; throw exception if null

            return new Paragraph(webElement);
        }

        public ITextInput FindTextInput(string id)
        {
            var webElement = webDriver.FindElement(By.Id(id));
            //to do check if it is text input; throw exception if null

            return new TextInput(webElement);
        }
    }
}
