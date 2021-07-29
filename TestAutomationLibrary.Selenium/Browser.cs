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

        public void CloseNotice()
        {
            driver.FindElement(By.ClassName("woocommerce-store-notice__dismiss-link")).Click();
        }

        private IWebElement FindUsernameInputField => driver.FindElement(By.CssSelector("input#username"));

        private IWebElement FindPasswordInputField => driver.FindElement(By.CssSelector("input#password"));

        public void Login(string username, string password)
        {
            FindUsernameInputField.SendKeys(username);
            FindPasswordInputField.SendKeys(password);
            driver.FindElement(By.CssSelector("button[name='login']")).Click();
        }

        public static void Cleanup()
        {
            driver.Quit();
        }
    }
}
