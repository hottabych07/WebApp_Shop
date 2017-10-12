
using System.Linq;
using WebApp_Shop.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApp_Shop.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        IProductRepository repository;
        public NavigationMenuViewComponent(IProductRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Products.Select(x => x.Category).Distinct().OrderBy(x => x));
        }
        
    }
}
