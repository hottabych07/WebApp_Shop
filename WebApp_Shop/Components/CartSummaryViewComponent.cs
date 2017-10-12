using Microsoft.AspNetCore.Mvc;
using WebApp_Shop.Models;

namespace WebApp_Shop.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;
        public CartSummaryViewComponent(Cart cartServices)
        {
            cart = cartServices;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
