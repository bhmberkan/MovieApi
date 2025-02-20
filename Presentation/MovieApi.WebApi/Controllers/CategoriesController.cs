using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using MovieApi.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly GetCategoryQueryHandler _getCategoryQueryHandler;
        private readonly GetCategoryByIdQueryHandler _getCategoryByIdQueryHandler;
        private readonly CreateCategoryCommandHandler _createCategoryCommandHandler;
        private readonly UpdateCategoryCommandHandler _updateCategoryCommandHandler;
        private readonly RemoveCategoryCommandHandler _removeCategoryCommandHandler;

        // mediator kullanmadık. Daha sonra kullanacağız.
        public CategoriesController(GetCategoryQueryHandler getCategoryQueryHandler, 
            GetCategoryByIdQueryHandler getCategoryByIdQueryHandler, 
            CreateCategoryCommandHandler createCategoryCommandHandler, 
            UpdateCategoryCommandHandler updateCategoryCommandHandler, 
            RemoveCategoryCommandHandler removeCategoryCommandHandler)
        {
            _getCategoryQueryHandler = getCategoryQueryHandler;
            _getCategoryByIdQueryHandler = getCategoryByIdQueryHandler;
            _createCategoryCommandHandler = createCategoryCommandHandler;
            _updateCategoryCommandHandler = updateCategoryCommandHandler;
            _removeCategoryCommandHandler = removeCategoryCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var value =await _getCategoryQueryHandler.Handle();
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommand command)
        {
           await _createCategoryCommandHandler.Handler(command);
            return Ok("Kategory ekleme işlemi başarılı");
        }
    }
}
