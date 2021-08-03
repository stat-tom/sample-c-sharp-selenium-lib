using TestAutomationLibrary.Pages.FakeStore;
using TestAutomationLibrary.Selenium.Browsers;

using NUnit.Framework;

namespace TestAutomationLibrary.Tests.FakeStore
{
    [TestFixture]
    public class TC_Login
    {
        private IContext context;
        private Browser browser;
        private LoginPage loginPage;

        [SetUp]
        public void Init()
        {
            context = new ChromeContext();
            browser = new Browser(context);
            loginPage = new LoginPage(context);
        }

        [TearDown]
        public void Cleanup()
        {
            loginPage = null;
            browser = null;
            context.Quit();
        }

        [Test]
        public void SuccessfulLogin()
        {
            browser.GoToUrl("https://fakestore.testelka.pl/moje-konto/");
            loginPage.DismissLink();
            loginPage.Login("siwec27155", "Abcde1234!@#$");
            
            var userInfo = loginPage.GetUserInfo();
            string expectedUserInfo = "Witaj siwec27155 (nie jesteś siwec27155? Wyloguj się)";

            Assert.AreEqual(expectedUserInfo, userInfo, "User info is not correct.");
        }

        [Test]
        public void FailedLoginNoUsername()
        {
            browser.GoToUrl("https://fakestore.testelka.pl/moje-konto/");
            loginPage.DismissLink();
            loginPage.Login("", "Abcde1234!@#$");

            var loginErrorMessage = loginPage.GetLoginErrorMessage();
            string expectedLoginErrorMessage = "Błąd: Nazwa użytkownika jest wymagana.";

            Assert.AreEqual(expectedLoginErrorMessage, loginErrorMessage, "Error message is not correct.");
        }

        [Test]
        public void FailedLoginNoPassword()
        {
            browser.GoToUrl("https://fakestore.testelka.pl/moje-konto/");
            loginPage.DismissLink();

            loginPage.Login("siwec27155", "");

            var loginErrorMessage = loginPage.GetLoginErrorMessage();
            string expectedLoginErrorMessage = "Błąd: Hasło jest puste.";

            Assert.AreEqual(expectedLoginErrorMessage, loginErrorMessage, "Error message is not correct.");
        }

        [Test]
        public void FailedLoginNoUsernameAndPassword()
        {
            browser.GoToUrl("https://fakestore.testelka.pl/moje-konto/");
            loginPage.DismissLink();

            loginPage.Login("", "");
            
            var loginErrorMessage = loginPage.GetLoginErrorMessage();
            string expectedLoginErrorMessage = "Błąd: Nazwa użytkownika jest wymagana.";

            Assert.AreEqual(expectedLoginErrorMessage, loginErrorMessage, "Error message is not correct.");
        }
    }
}
