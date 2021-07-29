using NUnit.Framework;
using TestAutomationLibrary.Selenium;

namespace TestAutomationLibrary.Tests
{
    public class TC_Template
    {
        //Arrange

        [SetUp]
        public void Init()
        {
            Browser.Init();
        }
        

        [Test]
        public void TestTemplate()
        {
            //Act
            
            

            //Assert
            

        }

        [TearDown]
        public void Cleanup()
        {
            Browser.Cleanup();
        }
    }
}
