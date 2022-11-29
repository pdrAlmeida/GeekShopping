using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Repository;
using GeekShopping.ProductAPI.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductVO>> FindById(Guid id) 
        {
            var product = await _productRepository.FindByIdAsync(id);
            return product != null ? Ok(product) : NotFound();
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductVO>>> FindAll()
        {
            var product = await _productRepository.FindAllAsync();
            return Ok(product);
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<ProductVO>> Create(ProductVO vo)
        {
            if (vo == null) return BadRequest();
            var product = _productRepository.Create(vo);
            return Ok(product);
        }

        [Authorize]
        [HttpPut]
        public async Task<ActionResult<ProductVO>> Update(ProductVO vo)
        {
            if (vo == null) return BadRequest();
            var product = _productRepository.Update(vo);
            return Ok(product);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = Role.Admin)]
        public async Task<ActionResult<ProductVO>> Delete(Guid id)
        {
            var status = await _productRepository.Delete(id);
            if (!status) return BadRequest();
            return Ok(true);
        }
    }
}
