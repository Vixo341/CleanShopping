using Catalog.Core.Entities;

namespace Catalog.Core.Repositories;

public interface IProductRepository
{
    Task<Product> CreateProduct(Product product);
    Task<bool> UpdateProduct(Product product);
    Task<bool> DeleteProduct(string id);


    Task<Product> GetProduct(string id);

    Task<IEnumerable<Product>> GetProducts();
    Task<IEnumerable<Product>> GetProductByName(string name);
    Task<IEnumerable<Product>> GetProductByBrand(string brand);


}
