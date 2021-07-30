using OpenQA.Selenium;
using TestAutomationLibrary.Controls;
using TestAutomationLibrary.Pages;
using TestAutomationLibrary.Selenium.Pages;

namespace TestAutomationLibrary.Pages.FakeStore
{
    public class LoginPage
    {
        private readonly IWebControlFinder webControlFinder;

        public LoginPage(IWebDriver webDriver) 
        {
            this.webControlFinder = new WebControlFinder(webDriver);
        }

        public void Login(string username, string password)
        {
            var usernameTextbox = webControlFinder.FindTextInput("username");
            usernameTextbox.InsertText(username);

            var passwordTextbox = webControlFinder.FindTextInput("password");
            passwordTextbox.InsertText(password);

            var loginButton = webControlFinder.FindButton("login");
            loginButton.Click();
        }

        public string GetUserInfo()
        {
            var userInfoParagraph = webControlFinder.FindParagraph("div.woocommerce-MyAccount-content>p:first-of-type");
            return userInfoParagraph.Text;
        }
    }
}
