﻿using TestAutomationLibrary;
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
