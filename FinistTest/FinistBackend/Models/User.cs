using System.ComponentModel.DataAnnotations;

namespace FinistBackend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string Login { get; set; } = null!;
        [MaxLength(20)]
        public string Password { get; set; } = null!;
        [MaxLength(30)]
        public string Email { get; set; } = null!;        
        public BankAccount? Account { get; set; }
    }
}
