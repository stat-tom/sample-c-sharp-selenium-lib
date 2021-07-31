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
        private LoginPage loginPage;

        [SetUp]
        public void Init()
        {
            webDriver = new ChromeDriver();
            browser = new Browser(webDriver);
            loginPage = new LoginPage(webDriver);
        }

        [TearDown]
        public void Cleanup()
        {
            loginPage = null;
            browser = null;
            webDriver.Quit();
        }

        [Test]
        public void SuccessfulLogin()
        {
            browser.GoToUrl("https://fakestore.testelka.pl/moje-konto/");

            loginPage.Login("siwec27155", "Abcde1234!@#$");
            loginPage.DismissLink();

            var userInfo = loginPage.GetUserInfo();
            string expectedUserInfo = "Witaj siwec27155 (nie jesteś siwec27155? Wyloguj się)";

            Assert.AreEqual(expectedUserInfo, userInfo, "User info is not correct.");
        }

        [Test]
        public void FailedLoginNoUsername()
        {
            browser.GoToUrl("https://fakestore.testelka.pl/moje-konto/");

            loginPage.Login("", "Abcde1234!@#$");
            loginPage.DismissLink();

            var loginErrorMessage = loginPage.GetLoginErrorMessage();
            string expectedLoginErrorMessage = "Błąd: Nazwa użytkownika jest wymagana.";

            Assert.AreEqual(expectedLoginErrorMessage, loginErrorMessage, "Error message is not correct.");
        }
    }
}
