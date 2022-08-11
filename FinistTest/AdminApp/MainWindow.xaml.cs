using System.Windows;
using AdminApp.Pages;
using FinistBackend.Models;
using FinistBackend.Context;
using System.Collections.Generic;
using System.Linq;
using System;

namespace AdminApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly ApplicationContext db = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            frameMain.NavigationService.Navigate(new MenuPage());
        }

        private void BtnLoadData_Click(object sender, RoutedEventArgs e)
        {                      
            try {
                LoadUsers();
                LoadBankAccounts();
                LoadCards();
                LoadTransactions();
                LoadFavorites();
                MessageBox.Show("Данные загружены", "Инфо", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Стартовые значения уже были загружены", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void LoadUsers()
        {
            for (int i = 0; i < 5; i++)
            {
                User user = new()
                {
                    Login = "user" + i,
                    Password = "password" + i,
                    Email = "user" + i + "@mail.ru"
                };
                db.Users.Add(user);
            }
            db.SaveChanges();            
        }

        private void LoadBankAccounts()
        {

            List<User> users = db.Users.ToList();
            int number = 0;
            foreach (User user in users)
            {
                BankAccount bankAccount = new()
                {
                    Number = "0000000000000000000" + number,
                    UserId = user.Id,
                    Name = "Name"+ number,
                    Specific = "Транспорт",
                    Image = "finist.jpg"
                };
                user.Account = bankAccount;
                number++;                    
            }
            db.SaveChanges();            
        }

        private void LoadCards()
        {
            Random rand = new();
            List<BankAccount> accounts = db.BankAccounts.ToList();
            int id = 0;
            foreach (BankAccount account in accounts)
            {
                Card card = new();
                card = new Card()
                {
                    Number = "00000000000000" + id,
                    CVV = "333",
                    BankAccountId = account.Id,
                    CardType = "Кредитная",
                    Image = "creditCard.png",
                    Balance = rand.Next(-5000, 5000)
                };
                id++;
                account.Cards!.Add(card);
                card = new Card()
                {
                    Number = "00000000000000" + id,
                    CVV = "333",
                    BankAccountId = account.Id,
                    CardType = "Дебетовая",
                    Image = "debetCard.png",
                    Balance = rand.Next(0, 5000)
                };
                id++;
                account.Cards!.Add(card);
            }
            db.SaveChanges();            
        }

        
        private void LoadTransactions()
        {
            Random rand = new();
            List<Card> cards = db.Cards.ToList();
            foreach(Card card in cards)
            {
                Transaction transaction = new()
                {
                    ReceiverId = card.Id + 1,
                    SenderId = card.Id,
                    Sum = rand.Next(0, 500),
                    TransferDateTime = DateTime.Now.AddDays(rand.Next(0, 10)),
                };
                Card receiver = db.Cards.FirstOrDefault(c => c.Id == transaction.ReceiverId)!;
                if (receiver != null)
                {
                    card.Sends!.Add(transaction);
                    receiver = db.Cards.FirstOrDefault(c => c.Id == transaction.ReceiverId)!;
                    if (receiver != null)
                        receiver.Gets!.Add(transaction);
                    db.Transactions.Add(transaction);
                }
            }
            db.SaveChanges();            
        }
        
        private void LoadFavorites()
        {
            List<BankAccount> accounts = db.BankAccounts.ToList();
            int id = 0;
            foreach(BankAccount account in accounts)
            {
                List<Transaction> transactions = db.Transactions.Where(t => t.SenderId == account.Id).ToList();
                foreach (Transaction transaction in transactions)
                {
                    Favorite favorite = new()
                    {
                        Name = "FavorName" + id,
                        Transaction = transaction,
                        BankAccount = account
                    };
                    transaction.Favorites!.Add(favorite);
                    account.Favorites!.Add(favorite);
                    db.Favorites.Add(favorite);
                }                    
            }
            db.SaveChanges();            
        }
        
    }
}
