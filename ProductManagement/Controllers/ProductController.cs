using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;
using ProductManagement.Authorization;
using ProductManagement.Entity;
using ProductManagement.Interfaces;
using ProductManagement.Model;

namespace ProductManagement.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("Paginate")]
        [Authorize]
        [HasPermission("ProductScene.Paging.Permission")]
        public async Task<IActionResult> Paginate([FromQuery] PagingParameter pagingParameter)
        {
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(' ').Last();
            var result = await _productService.Paginate(pagingParameter, token);
            return new OkObjectResult(result);
        }

        [HttpGet("All")]
        [Authorize]

        public async Task<IActionResult> GetAll()
        {
            var result = await _productService.GetProducts();
            return new OkObjectResult(result);
        }

        [HttpPost("Save")]
        [Authorize]
        [HasPermission("ProductScene.Save.Permission")]

        public async Task<IActionResult> Save([FromBody] Product product)
        {
            var result = await _productService.Save(product);
            return new OkObjectResult(result);
        }

        [HttpPost("Update")]
        [Authorize]
        [HasPermission("ProductScene.Edit.Permission")]

        public async Task<IActionResult> Update([FromBody] Product product)
        {
            var result = await _productService.Update(product);
            return new OkObjectResult(result);
        }

        [HttpDelete("Delete/{id}")]
        [Authorize]
        [HasPermission("ProductScene.Delete.Permission")]

        public async Task<IActionResult> Delete(long id)
        {
            var result = await _productService.Delete(id);
            return new OkObjectResult(result);
        }

        [HttpGet("{id}")]
        [Authorize]

        public async Task<IActionResult> GetById(long id)
        {
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(' ').Last();

            var result = await _productService.GetById(id, token);
            return new OkObjectResult(result);
        }
    }
}
