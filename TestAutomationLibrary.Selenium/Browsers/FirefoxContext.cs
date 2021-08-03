using OpenQA.Selenium.Firefox;

namespace TestAutomationLibrary.Selenium.Browsers
{
    public class FirefoxContext : Context
    {
        public FirefoxContext() : base(new FirefoxDriver())
        {
            
        }
    }
}
