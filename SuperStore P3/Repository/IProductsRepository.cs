using Models;

namespace EcoPower_Logistics.Repository
{
    public interface IProductsRepository : IGenericRepository<Product>
    {
        Product GetMostRecentProduct();
        Product GetProductById(Guid? id);
        IEnumerable<Product> GetAllProducts();
        void AddProduct(Product entity);
        void RemoveProduct(Product entity);
        void UpdateProduct(Product entity);
    }
}
