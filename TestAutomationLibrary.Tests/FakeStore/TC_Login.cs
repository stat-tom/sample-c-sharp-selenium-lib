using NUnit.Framework;
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

        [Test]
        public void SuccessfulLogin()
        {
            //1. open webpage
            Browser.driver.Navigate().GoToUrl("https://fakestore.testelka.pl/moje-konto/");
            //2. insert user and password and click login button

            //3. check username after login

            Assert.Pass();
        }

        [Test]
        public void FailedLogin()
        {
            //1. open webpage
            Browser.driver.Navigate().GoToUrl("https://fakestore.testelka.pl/moje-konto/");
            //2. insert wrong user and password and click login button

            //3. check error message

            Assert.Pass();
        }

        [TearDown]
        public void Cleanup()
        {
            Browser.Cleanup();
        }
    }
}
