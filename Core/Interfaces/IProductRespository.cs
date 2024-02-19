using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRespository
    {
        Task<Product> GetProductByIdAsync(int id);

        Task<IReadOnlyList<Product>> GetProductsAsync();
    }
}