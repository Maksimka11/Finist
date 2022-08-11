using System.ComponentModel.DataAnnotations;

namespace FinistBackend.Models
{
    public class Card
    {
        public int Id { get; set; }
        [MaxLength(16)]
        public string Number { get; set; } = null!;
        [MaxLength(3)]
        public string CVV { get; set; } = null!;
        [MaxLength(20)]
        public string CardType { get; set; } = null!;
        [MaxLength(100)]
        public string Image { get; set; } = null!;
        public decimal Balance { get; set; }
        public int BankAccountId { get; set; }
        public BankAccount bankAccount { get; set; } = null!;
        public List<Transaction>? Sends { get; set; } = new();
        public List<Transaction>? Gets { get; set; } = new();

    }
}
