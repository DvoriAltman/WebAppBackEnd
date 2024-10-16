using DAL.Entities;

namespace DAL
{
    public interface IProductsDAL
    {
        Task<List<Product>> GetAllProducts();
    }
}