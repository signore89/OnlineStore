using OnlineStoreDouble.Models;

namespace OnlineStoreDouble.Data.Repositories.Interfaces
{
    public interface IRepositoryProduct
    {
        Task AddAsync(Product product);

        Task RemoveAsync(int id);

        Task UpdateAsync(Product updatedProduct);

        Task<List<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
    }
}
