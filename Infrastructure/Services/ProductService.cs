using Infrastructure.Models;

namespace WebAppMVC.Services;
public class ProductService
{
    private List<Product> _products = new List<Product>
    {
        new Product { Id = 1, Name = "Product 1" },
        new Product { Id = 2, Name = "Product 2" },
        new Product { Id = 3, Name = "Product 3" },
        new Product { Id = 4, Name = "Product 4" },
        new Product { Id = 5, Name = "Product 5" }
    };
    public List<Product> GetProducts()
    {
        return _products;
    }
}
