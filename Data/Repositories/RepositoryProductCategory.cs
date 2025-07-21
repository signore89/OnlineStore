using Microsoft.EntityFrameworkCore;
using OnlineStoreDouble.Data.Repositories.Interfaces;
using OnlineStoreDouble.Models;

namespace OnlineStoreDouble.Data.Repositories
{
    public class RepositoryProductCategory(OnlineStoreDBContext onlineStoreDBContext) : IRepositoryProductCayegory
    {
        public async Task AddAsync(ProductCategory productCategory)
        {
            await onlineStoreDBContext.AddAsync(productCategory);
            await onlineStoreDBContext.SaveChangesAsync();
        }

        public async Task RemoveAsync(int id)
        {
            var productCategory = await onlineStoreDBContext.ProductCategories.FirstOrDefaultAsync(productCategory => productCategory.Id == id);
            onlineStoreDBContext.ProductCategories.Remove(productCategory);
            await onlineStoreDBContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(ProductCategory updatedProductCategory)
        {
            var productCategory = await onlineStoreDBContext.ProductCategories.FirstOrDefaultAsync(productCategory => productCategory.Id == updatedProductCategory.Id);
            productCategory.Name = updatedProductCategory.Name;
            productCategory.Description = updatedProductCategory.Description;
            await onlineStoreDBContext.SaveChangesAsync();
        }

        public async Task<List<ProductCategory>> GetAll()
        {
            return await onlineStoreDBContext.ProductCategories.AsNoTracking().ToListAsync();
        }
    }
}
