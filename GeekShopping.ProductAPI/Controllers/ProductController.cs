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
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult> FindById(long id)
        {
            var product = await _productRepository.FindById(id);
            if (product == null) return NotFound();

            return Ok(product);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductVO>>> FindAll()
        {
            var products = await _productRepository.FindAll();

            return Ok(products);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<ProductVO>> Create([FromBody] ProductVO productVO)
        {
            if (productVO == null) return BadRequest();
            
            var products = await _productRepository.Create(productVO);
            return Ok(products);
        }

        [HttpPut]
        [Authorize]
        public async Task<ActionResult<ProductVO>> Update([FromBody] ProductVO productVO)
        {
            if (productVO == null) return BadRequest();

            var products = await _productRepository.Update(productVO);
            return Ok(products);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = Role.Admin)]
        public async Task<ActionResult<ProductVO>> Delete(long id)
        {
            var status = await _productRepository.Delete(id);

            if (!status) return NotFound();

            return Ok(status);
        }
    }
}
