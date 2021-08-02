using TestAutomationLibrary.Controls;

using OpenQA.Selenium;
using System.Collections.Generic;

namespace TestAutomationLibrary.Selenium.Controls
{
    public class UnorderedList : IUnorderedList
    {
        private readonly IWebElement webElement;

        public UnorderedList(IWebElement webElement)
        {
            this.webElement = webElement;
            Items = new List<IListItem>();
        }

        public List<IListItem> Items { get; set; }

    }
}
