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
            var usernameTextbox = controlFinder.FindTextFieldWithWait(By.Id("username"));
            usernameTextbox.InsertText(username);

            var passwordTextbox = controlFinder.FindTextFieldWithWait(By.Id("password"));
            passwordTextbox.InsertText(password);

            var loginButton = controlFinder.FindButton(By.Name("login"));
            loginButton.Click();
        }

        public string GetUserInfo()
        {
            var userInfoParagraph = controlFinder.FindParagraph(By.CssSelector("div.woocommerce-MyAccount-content>p:first-of-type"));
            return userInfoParagraph.Text;
        }

        public void DismissLink()
        {
            var dismissLink = controlFinder.FindLink(By.ClassName("woocommerce-store-notice__dismiss-link"));
            dismissLink.Click();
        }

        public string GetLoginErrorMessage()
        {
            var list = controlFinder.FindUnorderedList(By.CssSelector("ul.woocommerce-error"));

            return list.Items.First().Text;
        }
    }
}
