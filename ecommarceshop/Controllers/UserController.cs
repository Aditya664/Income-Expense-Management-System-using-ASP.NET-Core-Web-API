using incomeexpense.DTO;
using incomeexpense.Interfaces;
using incomeexpense.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace incomeexpense.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        public UserController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var owners = _repository.User.FindAll();
            return StatusCode(500,owners);
        }

        [HttpGet("{Id}", Name = "GetUserById")] // Define route with id parameter
        public IActionResult GetById(Guid Id)
        {
            var user = _repository.User.FindByCondition(x => x.Id == Id).FirstOrDefault(); // Fetch user by ID from repository

            if (user == null)
            {
                return NotFound(); // Return 404 Not Found if user is not found
            }

            return Ok(user); // Return 200 OK with user data if found
        }

        [HttpDelete("{Id}")] // Define route with id parameter
        public IActionResult DeleteUserById(Guid Id)
        {
            var user = _repository.User.FindByCondition(x => x.Id == Id).FirstOrDefault(); // Fetch user by ID from repository

            if (user == null)
            {
                return NotFound(); // Return 404 Not Found if user is not found
            }

            _repository.User.Delete(user);
            _repository.Save();
            return Ok(user); // Return 200 OK with user data if found
        }


        [HttpPost]
        public IActionResult Create(RegisterRequestDto registerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Check if the email already exists
            var existingUser = _repository.User.FindByCondition(u => u.Email == registerDto.Email).FirstOrDefault();
            if (existingUser != null)
            {
                // Return a 409 Conflict response indicating that the email is already in use
                return Conflict($"Email '{registerDto.Email}' is already registered.");
            }

            // Map RegisterRequestDto to Register entity
            var user = new Register
            {
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                Email = registerDto.Email,
                MobileNo = registerDto.MobileNo,
                Password = registerDto.Password
            };

            try
            {
                // Add the user to the repository and save changes
                _repository.User.Create(user);
                _repository.Save();

                // Return 201 Created status code along with the created user
                return CreatedAtRoute("GetUserById", new { id = user.Id }, user);
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error: {ex}");

                // Return a more informative error message to the client
                return StatusCode(500, $"Failed to create user: {ex.Message}");
            }
        }


    }
}
