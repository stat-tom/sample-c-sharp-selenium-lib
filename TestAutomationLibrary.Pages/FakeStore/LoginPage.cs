using System.Linq;

namespace TestAutomationLibrary.Pages.FakeStore
{
    public class LoginPage : Page
    {
        public LoginPage(IContext context) : base (context) 
        {
        }

        public void Login(string username, string password)
        {
            var usernameTextbox = controlFinder.FindTextInput("username");
            usernameTextbox.InsertText(username);

            var passwordTextbox = controlFinder.FindTextInput("password");
            passwordTextbox.InsertText(password);

            var loginButton = controlFinder.FindButton("login");
            loginButton.Click();
        }

        public string GetUserInfo()
        {
            var userInfoParagraph = controlFinder.FindParagraph("div.woocommerce-MyAccount-content>p:first-of-type");
            return userInfoParagraph.Text;
        }

        public void DismissLink()
        {
            var dismissLink = controlFinder.FindLink("woocommerce-store-notice__dismiss-link");
            dismissLink.Click();
        }

        public string GetLoginErrorMessage()
        {
            var list = controlFinder.FindUnorderedList("ul.woocommerce-error");

            return list.Items.First().Text;
        }
    }
}
