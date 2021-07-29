using TestAutomationLibrary;
using TestAutomationLibrary.Selenium;
using TestAutomationLibrary.Pages.FakeStore;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestAutomationLibrary.Tests.FakeStore
{
    [TestFixture]
    public class TC_Login
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
        public void SuccessfulLogin()
        {
            browser.GoToUrl("https://fakestore.testelka.pl/moje-konto/");

            LoginPage loginPage = new LoginPage();
            loginPage.Login("siwec27155", "Abcde1234!@#$");
            
        }

        
    }
}
