using System.Windows;
using System.Windows.Input;
using FinistBackend.Models;
using FinistBackend.Context;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System;

namespace AdminApp.Windows
{
    public partial class FavoriteWindow : Window
    {
        readonly Favorite favorite = new();
        readonly ApplicationContext db = new();
        public FavoriteWindow()
        {
            InitializeComponent();
        }

        public FavoriteWindow(Favorite favorite)
        {
            InitializeComponent();
            this.favorite = favorite;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbTransaction.ItemsSource = db.Transactions.ToList();
            cbAccount.ItemsSource = db.BankAccounts.ToList();
            tbName.Text = favorite.Name;
            cbTransaction.SelectedValue = favorite.TransactionId;
            cbAccount.SelectedValue = favorite.AccountId;
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateData())
                return;
            FillData();
            db.Favorites.Update(favorite);
            db.SaveChanges();
            DialogResult = true;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void FillData()
        {
            favorite.Name = tbName.Text;
            favorite.AccountId = (int)cbAccount.SelectedValue;
            favorite.TransactionId = (int)cbTransaction.SelectedValue;
        }

        private bool ValidateData()
        {
            StringBuilder errorMessage = new();
            if (tbName.Text.Length == 0)
                errorMessage.AppendLine("Введите название");
            if (cbAccount.SelectedIndex == -1)
                errorMessage.AppendLine("Выберите счет");
            if (cbTransaction.Text.Length == -1)
                errorMessage.AppendLine("Выберите транзакцию");
            if (errorMessage.Length != 0)
            {
                MessageBox.Show(errorMessage.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            else
                return true;

        }
    }
}
