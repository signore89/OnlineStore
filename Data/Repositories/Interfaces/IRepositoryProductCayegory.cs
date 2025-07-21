using OnlineStoreDouble.Models;

namespace OnlineStoreDouble.Data.Repositories.Interfaces
{
    public interface IRepositoryProductCayegory
    {
        Task AddAsync(ProductCategory productCategory);

        Task RemoveAsync(int id);

        Task UpdateAsync(ProductCategory updatedProductCategory);

        Task<List<ProductCategory>> GetAll();
    }
}
