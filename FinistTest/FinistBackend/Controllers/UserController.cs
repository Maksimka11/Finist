using FinistBackend.Context;
using FinistBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinistBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController: ControllerBase
    {
        private readonly ApplicationContext db;
        public UserController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet("validate/{login}/{password}")]
        public async Task<ActionResult<IEnumerable<User>>> ValidateLogin(string login, string password)
        {
            User? user = await db.Users.FirstOrDefaultAsync(u => u.Login == login);
            if (user == null)
                return NotFound();
            if (user.Password != password)
                return BadRequest();
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult> Post(User user)
        {
            if (user == null)
                return BadRequest();
            db.Users.Add(user);
            await db.SaveChangesAsync();
            return Ok();
        }
    }
}
