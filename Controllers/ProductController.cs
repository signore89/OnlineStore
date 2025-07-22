using Microsoft.AspNetCore.Mvc;
using OnlineStoreDouble.Data.Repositories;
using OnlineStoreDouble.Data.Repositories.Interfaces;
using OnlineStoreDouble.Exeption;
using OnlineStoreDouble.Models;

namespace OnlineStoreDouble.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IRepositoryProduct repository) : Controller
    {
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var products = await repository.GetAllAsync();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetByIdAsync(int id)
        {
            var product = await repository.GetByIdAsync(id);
            return Ok(product);
        }
        [HttpPost]
        public async Task<ActionResult> AddAsync(Product product)
        {
            await repository.AddAsync(product);
            return Created();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            try
            {
                await repository.RemoveAsync(id);
            }
            catch (NotFoundException)
            {
                throw;
            }
            return NoContent();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync(Product product)
        {
            try
            {
                await repository.UpdateAsync(product);
            }
            catch (NotFoundException)
            {
                throw;
            }
            return NoContent();
        }
    }
}
