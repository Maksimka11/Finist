using AdminApp.Windows;
using FinistBackend.Context;
using FinistBackend.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AdminApp.Pages
{
    public partial class BankAccountsPage : Page
    {
        ApplicationContext db = new();
        public BankAccountsPage()
        {
            InitializeComponent();
        }
        
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            BankAccountWindow window = new();
            if (window.ShowDialog() == true)
            {
                Refresh();
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (dgAccounts.SelectedItem == null)
                return;
            int accountId = (int)dgAccounts.SelectedValue;
            BankAccount account = db.BankAccounts.FirstOrDefault(bk => bk.Id == accountId)!;
            BankAccountWindow window = new(account);

            if (window.ShowDialog() == true)
            {
                Refresh();
            }            
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            if (dgAccounts.SelectedItem == null)
                return;
            try
            {

                int accountId = (int)dgAccounts.SelectedValue;
                BankAccount account = db.BankAccounts.FirstOrDefault(bk => bk.Id == accountId)!;
                db.BankAccounts.Remove(account);
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
            dgAccounts.ItemsSource = null;
            var view = from account in db.BankAccounts
                        join user in db.Users on account.UserId equals user.Id
                        select new
                        {
                            Id = account.Id,
                            Name = account.Name,
                            Number = account.Number,
                            Image = account.Image,
                            OpeningDate = account.OpeningDate,
                            User = user.Login,
                            Specific = account.Specific
                        };
            dgAccounts.ItemsSource = view.ToList();
            
        }
    }
}
