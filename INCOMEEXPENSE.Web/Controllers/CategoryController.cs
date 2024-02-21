using INCOMEEXPENSE.Web.DTO;
using INCOMEEXPENSE.Web.Interfaces;
using INCOMEEXPENSE.Web.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace INCOMEEXPENSE.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IRepositoryWrapper _repository;

        public CategoryController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }
        [HttpGet("GetAllCategory/{userId}")]
        public IActionResult Get(Guid userId)
        {
            var categories = _repository.Category.FindByCondition(categories => categories.CreatedBy == userId).ToList();
            var categoryList = categories.Select(c => new CategoryResponseDto
            {
                Id = c.Id, Name = c.Name,Type = c.Type
            });
            return StatusCode(500, categories);
        }

        [HttpGet("GetExpenseCategory/expense/{userId}")]
        public IActionResult GetExpenseCategories(Guid userId)
        {
            var categories = _repository.Category.FindByCondition(c => c.Type == "expense" && c.CreatedBy == userId).ToList();

            var categoryList = categories.Select(c => new CategoryResponseDto
            {
                Id = c.Id,
                Name = c.Name,
                Type = c.Type
            }).ToList();

            return Ok(categoryList);
        }

        [HttpGet("GetIncomeCategory/income/{userId}")]
        public IActionResult GetIncomeCategories(Guid userId)
        {
            var categories = _repository.Category.FindByCondition(c => c.Type == "income" && c.CreatedBy == userId).ToList();

            var categoryList = categories.Select(c => new CategoryResponseDto
            {
                Id = c.Id,
                Name = c.Name,
                Type = c.Type
            }).ToList();

            return Ok(categoryList);
        }


        [HttpPost("CreateNewCategory/{userId}")]
        public IActionResult PostCategory(Guid userId, [FromBody] CategoryRequestDto category)
        {
            var isExistingCategory = _repository.Category.FindByCondition(x => x.Name == category.Name && x.CreatedBy == userId && x.Type == category.Type).FirstOrDefault();
            if (isExistingCategory != null)
            {
                return Conflict($"Category '{category.Name}' already exists.");
            }

            var newCategory = new Category
            {
                Name = category.Name,
                CreatedBy = userId,
                Type = category.Type
            };

            _repository.Category.Create(newCategory);
            _repository.Save();

            return CreatedAtAction("GetCategory", new { userId = userId, id = newCategory.Id }, category);
        }

        [HttpGet("DeleteCategory/{userId}/{id}")]
        public IActionResult DeleteCategoryById(Guid userId, Guid id)
        {
            var category = _repository.Category.FindByCondition(x => x.Id == id && x.CreatedBy == userId).FirstOrDefault(); // Fetch user by ID from repository

            if (category == null)
            {
                return NotFound(); // Return 404 Not Found if user is not found
            }

            _repository.Category.Delete(category);
            _repository.Save();
            return Ok(category); // Return 200 OK with user data if found
        }

        [HttpGet("GetCategory/{userId}/{id}")]
        public IActionResult GetCategory(Guid userId, Guid id)
        {
            var category = _repository.Category.FindByCondition(c => c.Id == id && c.CreatedBy == userId).FirstOrDefault();

            if (category == null)
            {
                return NotFound();
            }

            var categoryResponse = new CategoryResponseDto
            {
                Name = category.Name,
                Type = category.Type,
                Id = category.Id
            };
            return Ok(categoryResponse);
        }
    }
}
