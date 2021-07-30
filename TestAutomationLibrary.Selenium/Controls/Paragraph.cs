using TestAutomationLibrary.Controls;

using OpenQA.Selenium;

namespace TestAutomationLibrary.Selenium.Controls
{
    public class Paragraph : IParagraph
    {
        private readonly IWebElement webElement;

        public Paragraph(IWebElement webElement)
        {
            this.webElement = webElement;
        }

        public string Text => webElement.Text;

    }
}
