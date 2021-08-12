using System.Linq;

namespace TestAutomationLibrary.Pages.FakeStore
{
    public class ProductPage : Page
    {
        public ProductPage(IContext context) : base(context)
        {
        }

        //public void AddToCart()
        //{
        //    var addToCartButton = controlFinder.FindButton("[name='add-to-cart']");
        //    addToCartButton.Click();
        //}

        //public void GoToCart()
        //{
        //    var goToCartButton = controlFinder.FindButton(".woocommerce-message .wc-forward");
        //    goToCartButton.Click();
        //}
    }
}
