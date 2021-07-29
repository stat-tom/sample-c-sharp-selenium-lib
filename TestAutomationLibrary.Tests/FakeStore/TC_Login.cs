using NUnit.Framework;
using OpenQA.Selenium;
using TestAutomationLibrary.Selenium;

namespace TestAutomationLibrary.Tests.FakeStore
{
    [TestFixture]
    public class TC_Login
    {
        [SetUp]
        public void Init()
        {
            Browser.Init();
        }

        Browser browser = new Browser();
        string correctUsername = "siwec27155";
        string incorrectUsername = "siwec271555555";
        string correctPassword = "Abcde1234!@#$";

        [Test]
        public void SuccessfulLogin()
        {
            //1. open webpage
            Browser.driver.Navigate().GoToUrl("https://fakestore.testelka.pl/moje-konto/");
            Browser.driver.Manage().Timeouts().PageLoad = System.TimeSpan.FromSeconds(10);
            browser.CloseNotice();
            //2. insert user and password and click login button
            browser.Login(correctUsername, correctPassword);
            //3. check username after login
            Browser.driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
            IWebElement element = Browser.driver.FindElement(By.CssSelector("div.woocommerce-MyAccount-content>p:first-of-type"));

            string myAccountContent = element.Text;
            string expectedContent = "Witaj siwec27155 (nie jesteś siwec27155? Wyloguj się)";

            Assert.IsTrue(myAccountContent.Contains(expectedContent), "My Account page does not contain correct name. Expected name: " + expectedContent + " was not found in a string: " + myAccountContent);
        }

        [Test]
        public void FailedLoginIncorrectUsername()
        {
            //1. open webpage
            Browser.driver.Navigate().GoToUrl("https://fakestore.testelka.pl/moje-konto/");
            Browser.driver.Manage().Timeouts().PageLoad = System.TimeSpan.FromSeconds(10);
            browser.CloseNotice();
            //2. insert wrong user and password and click login button
            browser.Login(incorrectUsername, correctPassword);
            //3. check error message
            Browser.driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
            IWebElement element = Browser.driver.FindElement(By.CssSelector("ul.woocommerce-error"));

            string errorMessage = element.Text;
            string expectedErrorMsg = "Nieznany użytkownik. Proszę spróbować ponownie lub użyć swojego adresu e-mail.";

            Assert.AreEqual(expectedErrorMsg, errorMessage, "Error message is not correct.");
        }

        [TearDown]
        public void Cleanup()
        {
            Browser.Cleanup();
        }
    }
}
