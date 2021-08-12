using TestAutomationLibrary.Pages.FakeStore;
using TestAutomationLibrary.Selenium.Browsers;

using NUnit.Framework;

namespace TestAutomationLibrary.Tests.FakeStore
{
    [TestFixture]
    public class TC_Cart
    {
        private IContext context;
        private Browser browser;
        private LoginPage loginPage;
        private ProductPage productPage;
        private CartPage cartPage;

        [SetUp]
        public void Init()
        {
            context = new ChromeContext();
            browser = new Browser(context);
            loginPage = new LoginPage(context);
            productPage = new ProductPage(context);
            cartPage = new CartPage(context);
        }

        [TearDown]
        public void Cleanup()
        {
            cartPage = null;
            productPage = null;
            loginPage = null;
            browser = null;
            context.Quit();
        }

        [Test]
        public void IncreaseProductQuantityInCart()
        {
            browser.GoToUrl("https://fakestore.testelka.pl/product/kurs-zeglarski-na-mazurach/");
            loginPage.DismissLink();
        }

    }
}
