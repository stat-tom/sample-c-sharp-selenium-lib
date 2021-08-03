using OpenQA.Selenium.Chrome;

namespace TestAutomationLibrary.Selenium.Browsers
{
    public class ChromeContext : Context
    {
        public ChromeContext() : base(new ChromeDriver())
        {
            
        }
    }
}
