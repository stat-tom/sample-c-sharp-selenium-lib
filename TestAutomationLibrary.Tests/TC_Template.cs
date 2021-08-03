using TestAutomationLibrary.Selenium;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestAutomationLibrary.Tests
{
    [TestFixture]
    public class TC_Template
    {
        private IWebDriver webDriver;
        private IBrowser browser;

        [SetUp]
        public void Init()
        {
            webDriver = new ChromeDriver();
            browser = new Browser(webDriver);
        }

        [TearDown]
        public void Cleanup()
        {
            browser = null;
            webDriver.Quit();
        }

        [Test]
        public void Template()
        {
            
        }

    }
}
