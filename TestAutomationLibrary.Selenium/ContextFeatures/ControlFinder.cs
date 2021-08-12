﻿using System;
using System.Linq;

using TestAutomationLibrary.Controls;
using TestAutomationLibrary.ContextFeatures;
using TestAutomationLibrary.Selenium.Controls;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestAutomationLibrary.Selenium.ContextFeatures
{
    public class ControlFinder : IControlFinder
    {
        private readonly IWebDriver webDriver;
        private readonly WebDriverWait wait;
        private readonly ByFactory byFactory;

        public ControlFinder(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            this.wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            this.byFactory = new ByFactory();
        }

        private IWebElement InternalFindControl(Func<OpenQA.Selenium.By, IWebElement> func, OpenQA.Selenium.By by)
        {
            return func(by);
        }

        private IWebElement FindControl(By by)
        {
            var byS = byFactory.Create(by);
            Func<OpenQA.Selenium.By, IWebElement> funcFindControl = byS => webDriver.FindElement(byS);
            var control = InternalFindControl(funcFindControl, byS);
            if(control == null)
            {
                throw new Exception("Web element not found.");
            }
            return control;
        }

        private IWebElement FindControlWithWait(By by)
        {
            var byS = byFactory.Create(by);
            Func<OpenQA.Selenium.By, IWebElement> funcFindControlWithWait = byS => wait.Until(driver => webDriver.FindElement(byS));
            return InternalFindControl(funcFindControlWithWait, byS);
        }

        public IButton FindButton(By by)
        {
            var webElement = FindControl(by);
            //check if button has html
            return new Button(webElement);
        }

        public IButton FindButtonWithWait(By by)
        {
            var webElement = FindControlWithWait(by);
            return new Button(webElement);
        }

        public ITextField FindTextField(By by)
        {
            var webElement = FindControl(by);
            return new TextField(webElement);
        }

        public ITextField FindTextFieldWithWait(By by)
        {
            var webElement = FindControlWithWait(by);
            return new TextField(webElement);
        }

        public ILink FindLink(string name)
        {
            var webElement = wait.Until(driver => webDriver.FindElement(OpenQA.Selenium.By.ClassName(name)));
            //to do check if it is text input; throw exception if null

            return new Link(webElement);
        }

        public IParagraph FindParagraph(string cssSelector)
        {
            var webElement = wait.Until(driver => webDriver.FindElement(OpenQA.Selenium.By.CssSelector(cssSelector)));
            //to do check if it is text input; throw exception if null

            return new Paragraph(webElement);
        }

        public IUnorderedList FindUnorderedList(string cssSelector)
        {
            var webElement = wait.Until(driver => webDriver.FindElement(OpenQA.Selenium.By.CssSelector(cssSelector)));
            //to do check if it is text input; throw exception if null

            var items = webElement.FindElements(OpenQA.Selenium.By.TagName("li"));
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