
using System.Collections.Generic;


namespace WebApp_Shop.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
