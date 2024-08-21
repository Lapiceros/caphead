using CapHead.Models;

namespace CapHead.Repositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllProducts();
    Task<Product> AddNewProduct(Product newProduct);
    Task<Product> UpdateProduct(Product updatedProduct);
    Task DeleteProduct(int id);
}