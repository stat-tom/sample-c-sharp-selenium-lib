using System.Linq;

using TestAutomationLibrary.Controls;
using TestAutomationLibrary.ContextFeatures;
using TestAutomationLibrary.Selenium.Controls;

using OpenQA.Selenium;

namespace TestAutomationLibrary.Selenium.ContextFeatures
{
    public class ControlFinder : IControlFinder
    {
        private readonly IWebDriver webDriver;

        public ControlFinder(IWebDriver webDriver)
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

        public IParagraph FindParagraph(string cssSelector)
        {
            var webElement = webDriver.FindElement(By.CssSelector(cssSelector));
            //to do check if it is text input; throw exception if null

            return new Paragraph(webElement);
        }

        public ITextField FindTextInput(string id)
        {
            var webElement = webDriver.FindElement(By.Id(id));
            //to do check if it is text input; throw exception if null

            return new TextField(webElement);
        }

        public IUnorderedList FindUnorderedList(string cssSelector)
        {
            var webElement = webDriver.FindElement(By.CssSelector(cssSelector));
            //to do check if it is text input; throw exception if null

            var items = webElement.FindElements(By.TagName("li"));
            var unorderedList = new UnorderedList(webElement);
            var listItems = items.Select(item => new ListItem(item)).ToList();
            foreach (var listItem in listItems)
            {
                unorderedList.Items.Add(listItem);
            }
            return unorderedList;
        }
    }
}
