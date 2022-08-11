using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinistBackend.Context;
using FinistBackend.Models;

namespace FinistBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
        
        private readonly ApplicationContext db;

        public TransactionController(ApplicationContext context)
        {
            db = context;
        }
        
        [HttpGet("{Accountid}")]
        public async Task<ActionResult> Get(int AccountId)
        {
            BankAccount? account = await db.BankAccounts.FirstOrDefaultAsync(bk => bk.Id == AccountId);
            var view = from transaction in db.Transactions
                       where transaction.Receiver.bankAccount == account || transaction.Sender.bankAccount == account
                       orderby transaction.TransferDateTime descending
                       select new
                       {
                           Time = transaction.TransferDateTime.ToString("HH:mm"),
                           Day = transaction.TransferDateTime.ToString("dd:MM:yy"),
                           AccountImage = transaction.Receiver.bankAccount.Image,
                           AccountName = transaction.Receiver.bankAccount.Name,
                           CardImage = transaction.Sender.Image,
                           CardNumber = "*** " + transaction.Sender.Number.Substring(transaction.Sender.Number.Length - 4),
                           Sum = transaction.Sum,
                           Specific = transaction.Receiver.bankAccount.Specific,
                           receiver = transaction.Receiver.BankAccountId
                       };
            return Ok(view.ToList());
        }
    }
}
