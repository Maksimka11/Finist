using FinistBackend.Context;
using FinistBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinistBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteController : ControllerBase
    {
        
        private readonly ApplicationContext db;

        public FavoriteController(ApplicationContext context)
        {
            db = context;
        }

        
        [HttpGet("{AccountId}")]
        public async Task<ActionResult> Get(int AccountId)
        {
            var view = from favorite in db.Favorites
                       where favorite.AccountId == AccountId
                       select new
                       {
                           Id = favorite.Id,
                           Name = favorite.Name,
                           Image = favorite.BankAccount.Image                           
                       };
            if (view == null)
                return NotFound();
            return Ok(await view.ToListAsync());
        }
        

    }
}
