namespace FinistBackend.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int SenderId{ get; set; }
        public Card Sender { get; set; } = null!;
        public int ReceiverId { get; set; }
        public Card Receiver { get; set; } = null!;
        public decimal Sum { get; set; }
        public DateTime TransferDateTime { get; set; } = DateTime.UtcNow;
        public List<Favorite>? Favorites { get; set; } = new();
    }
}
