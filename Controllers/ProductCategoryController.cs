using Microsoft.AspNetCore.Mvc;
using OnlineStoreDouble.Data.Repositories.Interfaces;
using OnlineStoreDouble.Exeption;
using OnlineStoreDouble.Models;

namespace OnlineStoreDouble.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController(IRepositoryProductCayegory repositoryProductCayegory) : Controller
    {
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
           var productCategoryes =  await repositoryProductCayegory.GetAllAsync();
            return Ok(productCategoryes);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetByIdAsync(int id)
        {
            var productCategory = await repositoryProductCayegory.GetByIdAsync(id);
            return Ok(productCategory);
        }
        [HttpPost]
        public async Task<ActionResult> AddAsync(ProductCategory productCategory)
        {
            await repositoryProductCayegory.AddAsync(productCategory);
            return Created();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            try
            {
                await repositoryProductCayegory.RemoveAsync(id);
            }
            catch (NotFoundException )
            {
                throw;
            }
            return NoContent();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync(ProductCategory productCategory)
        {
            try
            {
                await repositoryProductCayegory.UpdateAsync(productCategory);
            }
            catch (NotFoundException )
            {
                throw;
            }
            return NoContent();
        }
    }
}
