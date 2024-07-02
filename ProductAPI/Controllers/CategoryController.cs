using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.ApplicationCore.Interfaces.Service;
using ProductAPI.ApplicationCore.Model.Request;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryServiceAsync categoryServiceAsync;

        public CategoryController(ICategoryServiceAsync categoryServiceAsync)
        {
            this.categoryServiceAsync = categoryServiceAsync;
        }
        [HttpPost]
        public async Task<IActionResult> Post(CategoryRequestModel categoryRequestModel)
        {
            try
            {
                var result = await categoryServiceAsync.InsertCategory(categoryRequestModel);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await categoryServiceAsync.GetAllCategories());
        }
    }
}
