using Microsoft.AspNetCore.Mvc;

namespace ApI_routing.Controllers
{
    public class UserController : Controller
    {

        // Dummy data for demonstration
        private static readonly List<User> Users = new List<User>
        {
            new User { Id = 1, Name = "John Doe", Email = "john.doe@example.com" },
            new User { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com" }
        };

        // GET: /user/{id}
        [HttpGet("/user/{id}")]
        public IActionResult GetUserById(int id)
        {
            // Find user by ID
            var user = Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound($"User with ID {id} not found.");
            }
            return Ok(user);
        }

        // User class to represent data
        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
