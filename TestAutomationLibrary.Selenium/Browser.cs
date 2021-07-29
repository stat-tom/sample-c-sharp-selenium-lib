using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestAutomationLibrary.Selenium
{
    public class Browser
    {
        public Browser() { }

        public static IWebDriver driver;

        public static void Init()
        {
            driver = new ChromeDriver();
        }

        public static void Cleanup()
        {
            driver.Quit();
        }
    }
}
