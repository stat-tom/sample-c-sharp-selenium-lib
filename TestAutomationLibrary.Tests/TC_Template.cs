using TestAutomationLibrary.Selenium.Browsers;

using NUnit.Framework;

namespace TestAutomationLibrary.Tests.FakeStore
{
    [TestFixture]
    public class TC_Template
    {
        //Arrange
        private IContext context;
        private Browser browser;

        [SetUp]
        public void Init()
        {
            context = new ChromeContext();
            browser = new Browser(context);
        }

        [TearDown]
        public void Cleanup()
        {
            browser = null;
            context.Quit();
        }

        [Test]
        public void Test_Template()
        {
            //Act


            //Assert


        }
    }
}

