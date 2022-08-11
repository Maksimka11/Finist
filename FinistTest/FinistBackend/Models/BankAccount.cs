using System.ComponentModel.DataAnnotations;

namespace FinistBackend.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; } = null!;
        [MaxLength(20)]
        public string Number { get; set; } = null!;
        [MaxLength(100)]
        public string Image { get; set; } = null!;
        public DateTime OpeningDate { get; set; } = DateTime.UtcNow;
        public List<Card>? Cards { get; set; } = new();
        [MaxLength(30)]
        public string Specific { get; set; } = null!;
        public int UserId { get; set; }
        public List<Favorite>? Favorites { get; set; } = new();
    }
}   