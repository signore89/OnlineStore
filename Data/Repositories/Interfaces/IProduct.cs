using OnlineStoreDouble.Models;

namespace OnlineStoreDouble.Data.Repositories.Interfaces
{
    public interface IProduct
    {
        Task AddAsync(Product product);

        Task RemoveAsync(int id);

        Task UpdateAsync(Product updatedProduct);

        Task<List<Product>> GetAll();
    }
}
