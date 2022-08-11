namespace FinistBackend.Models
{
    public class Favorite
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; } = null!;
        public int AccountId { get; set; }
        public BankAccount BankAccount { get; set; } = null!;
    }
}
