using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.ApplicationCore.Interfaces.Service;
using ProductAPI.ApplicationCore.Model.Request;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductRepositoryAsync : ControllerBase
    {
        private readonly IProductServiceAsync productServiceAsync;

        public ProductRepositoryAsync(IProductServiceAsync productServiceAsync)
        {
            this.productServiceAsync = productServiceAsync;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        { 
        return Ok(productServiceAsync.GetAllProducts());
        }
        [HttpPost]
        public async Task<IActionResult> Post(ProductRequestModel model)
        {
            return Ok(productServiceAsync.InsertProduct(model));
        }
    }
}
