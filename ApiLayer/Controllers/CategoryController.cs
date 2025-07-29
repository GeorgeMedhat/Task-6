using BusinessLogic.Models;
using BusinessLogicLayer.Models;
using DataAccessLayer.Interfaces;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace ApiLayer.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("all")]
        [ResponseCache(CacheProfileName = "profile-50")]
        public async Task<IActionResult> GetAllCategories()
        {
            var products = await _unitOfWork.Categories.GetAllAsync();
            return Ok(products);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategoriesWithPagination([FromQuery] PaginationParams paginationParams)
        {
            var products = await _unitOfWork.Categories.GetAllAsyncWithPagination(paginationParams);
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _unitOfWork.Categories.GetByIdAsync(id);
            if (category == null)
                return NotFound();

            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] Category category)
        {
            await _unitOfWork.Categories.AddAsync(category);
            await _unitOfWork.CompleteAsync();
            return CreatedAtAction(nameof(GetById), new { id = category.id }, category);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id , [FromBody] Category category)
        {
            if (id != category.id)//do i need this ???
                return BadRequest("ID mismatch");

            var result = await _unitOfWork.Categories.UpdateAsync(category);

            if (!result)
                return NotFound();

            await _unitOfWork.CompleteAsync();
            return Ok();

        }


        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchCategory(int id, [FromBody] JsonPatchDocument<Category> patchDoc)
        {
            if (patchDoc == null)
                return BadRequest();

            var category = await _unitOfWork.Categories.GetByIdAsync(id);
            if (category == null)
                return NotFound();

            patchDoc.ApplyTo(category, ModelState);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _unitOfWork.CompleteAsync();
            return Ok(category);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult>DeleteCategory(int id)
        {
            var category = await _unitOfWork.Categories.GetByIdAsync(id);

            if (category==null)
                return NotFound();

            _unitOfWork.Categories.Delete(category);
            await _unitOfWork.CompleteAsync();
            return Ok();
        }

    }
}
