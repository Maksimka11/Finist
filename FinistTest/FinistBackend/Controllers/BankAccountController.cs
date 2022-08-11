using FinistBackend.Context;
using FinistBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinistBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankAccountController : ControllerBase
    {
        private readonly ApplicationContext db;
        public BankAccountController(ApplicationContext context)
        {
            db = context;
        }
        
        [HttpGet("{UserId}")]
        public async Task<ActionResult<BankAccount>> Get(int UserId)
        {
            BankAccount? account = await db.BankAccounts.FirstOrDefaultAsync(bk => bk.UserId == UserId);
            if (account == null)
                return NotFound();
            return Ok(account);
        }
        
    }
}