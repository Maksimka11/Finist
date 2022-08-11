using FinistBackend.Context;
using FinistBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinistBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : ControllerBase
    {
        
        private readonly ApplicationContext db;
        public CardController(ApplicationContext context)
        {
            db = context;
        }


        [HttpGet("Debet/{Id}")]
        public async Task<ActionResult> GetDebetCards(int Id)
        {
            BankAccount? account = await db.BankAccounts.FirstOrDefaultAsync(bk => bk.Id == Id);
            if (account == null)
                return BadRequest();
            var view = from card in db.Cards
                       where card.CardType == "Дебетовая"
                       where card.BankAccountId == account.Id
                       select new
                       {
                           Balance = card.Balance,
                           CardPhoto = card.Image,
                           CardNumber = card.Number
                       };
            return Ok(view.ToList());
        }
        [HttpGet("Credit/{Id}")]
        public async Task<ActionResult> GetCreditCards(int Id)
        {
            BankAccount? account = await db.BankAccounts.FirstOrDefaultAsync(bk => bk.Id == Id);
            if (account == null)
                return BadRequest();
            var view = from card in db.Cards
                       where card.CardType == "Кредитная"
                       where card.BankAccountId == account.Id
                       select new
                       {
                           Balance = card.Balance,
                           CardPhoto = card.Image,
                           CardNumber = card.Number
                       };
            return Ok(view.ToList());
        }

    }
}
