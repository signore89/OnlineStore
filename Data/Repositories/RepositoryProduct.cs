using Microsoft.EntityFrameworkCore;
using OnlineStoreDouble.Data.Repositories.Interfaces;
using OnlineStoreDouble.Models;

namespace OnlineStoreDouble.Data.Repositories
{
    public class RepositoryProduct(OnlineStoreDBContext onlineStoreDBContext) : IRepositoryProduct
    {
        public async Task AddAsync(Product product)
        {
            await onlineStoreDBContext.AddAsync(product);
            await onlineStoreDBContext.SaveChangesAsync();
        }

        public async Task RemoveAsync(int id)
        {
            var product = await onlineStoreDBContext.Products.FirstOrDefaultAsync(product => product.Id == id);
            onlineStoreDBContext.Products.Remove(product);
            await onlineStoreDBContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Product updatedProduct)
        {
            var product = await onlineStoreDBContext.Products.FirstOrDefaultAsync(product => product.Id == updatedProduct.Id);
            product.Name = updatedProduct.Name;
            product.Description = updatedProduct.Description;
            product.Price = updatedProduct.Price;
            product.ProductCategoryId = updatedProduct.ProductCategoryId;
            await onlineStoreDBContext.SaveChangesAsync();
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await onlineStoreDBContext.Products.AsNoTracking().ToListAsync();
        }
        public async Task<Product> GetByIdAsync(int id)
        {
            return await onlineStoreDBContext.Products
                .FirstAsync(p => p.Id == id);
        }
    }
}
