using Microsoft.EntityFrameworkCore;
using FinistBackend.Models;

namespace FinistBackend.Context
{
    public class ApplicationContext: DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<BankAccount> BankAccounts { get; set; } = null!;
        public DbSet<Card> Cards { get; set; } = null!;
        public DbSet<Transaction> Transactions { get; set; } = null!;
        public DbSet<Favorite> Favorites { get; set; } = null!;

        private const string CONNECTION = "Server=(localdb)\\mssqllocaldb;Database=FinistDB;Trusted_Connection=True;";
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTION);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankAccount>().HasIndex(bk => bk.Number).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.Login).IsUnique();
            modelBuilder.Entity<Card>().HasIndex(c => c.Number).IsUnique();

            modelBuilder.Entity<User>().HasOne(u=> u.Account).WithOne();
            modelBuilder.Entity<BankAccount>().HasMany(bk => bk.Cards).WithOne(c => c.bankAccount).HasForeignKey(c => c.BankAccountId);
            modelBuilder.Entity<Card>().HasMany(c => c.Sends).WithOne(s => s.Sender).HasForeignKey(s => s.SenderId).OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Entity<Card>().HasMany(c => c.Gets).WithOne(g => g.Receiver).HasForeignKey(g => g.ReceiverId).OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Entity<Favorite>().HasOne(f => f.Transaction).WithMany(t => t.Favorites).HasForeignKey(f => f.TransactionId);
            modelBuilder.Entity<Favorite>().HasOne(f => f.BankAccount).WithMany(bk => bk.Favorites).HasForeignKey(f => f.AccountId);
        }
    }
}
