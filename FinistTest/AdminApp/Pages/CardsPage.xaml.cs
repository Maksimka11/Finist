using AdminApp.Windows;
using FinistBackend.Context;
using FinistBackend.Models;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AdminApp.Pages
{
    public partial class CardsPage : Page
    {
        private readonly ApplicationContext db;
        public CardsPage()
        {
            InitializeComponent();
            db = new();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            CardWindow window = new();
            if (window.ShowDialog() == true)
            {
                Refresh();
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (dgCards.SelectedItem == null)
                return;
            
            int accountId = (int)dgCards.SelectedValue;
            Card card = db.Cards.FirstOrDefault(bk => bk.Id == accountId)!;
            CardWindow window = new(card);
            if (window.ShowDialog() == true)
            {
                Refresh();
            }
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            if (dgCards.SelectedItem == null)
                return;
            try
            {
                int accountId = (int)dgCards.SelectedValue;
                Card card = db.Cards.FirstOrDefault(bk => bk.Id == accountId)!;
                db.Cards.Remove(card);
                db.SaveChanges();
                Refresh();
            }
            catch
            {
                MessageBox.Show("Есть связаные поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Refresh()
        {
            dgCards.ItemsSource = null;
            var view = from card in db.Cards
                       join account in db.BankAccounts on card.BankAccountId equals account.Id
                       select new
                       {
                           Id = card.Id,
                           Account = account.Number,
                           Number = card.Number,
                           CVV = card.CVV,
                           Balance = card.Balance,
                           CardType = card.CardType,
                           Image = card.Image
                       };
            dgCards.ItemsSource = view.ToList();
            
        }
    }
}
