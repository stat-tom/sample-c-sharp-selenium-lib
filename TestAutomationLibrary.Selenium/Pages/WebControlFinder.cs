using System.Linq;

using TestAutomationLibrary.Pages;
using TestAutomationLibrary.Controls;
using TestAutomationLibrary.Selenium.Controls;

using OpenQA.Selenium;
using System.Collections.Generic;

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

        public IUnorderedList FindUnorderedList(string cssSelector)
        {
            var webElement = webDriver.FindElement(By.CssSelector(cssSelector));
            //to do check if it is text input; throw exception if null

            var items = webElement.FindElements(By.TagName("li"));
            var unorderedList = new UnorderedList(webElement);
            var listItems = items.Select(item => new ListItem(item)).ToList();
            foreach(var listItem in listItems)
            {
                unorderedList.Items.Add(listItem);
            }
            return unorderedList;
        }
    }
}
