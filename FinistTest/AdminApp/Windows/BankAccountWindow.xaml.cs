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
    public partial class BankAccountWindow : Window
    {
        readonly BankAccount bankAccount = new();
        public BankAccountWindow()
        {
            InitializeComponent();
        }
        public BankAccountWindow(BankAccount account)
        {
            InitializeComponent();
            bankAccount = account;
        }
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new())
            {
                cbUser.ItemsSource = db.Users.Where(u => u.Account == null).ToList();
            }
            if (bankAccount != null)
            {
                tbName.Text = bankAccount.Name;
                tbImage.Text = bankAccount.Image;
                tbNumber.Text = bankAccount!.Number;
                dpOpeningDate.SelectedDate = bankAccount.OpeningDate;
                tbSpecific.Text = bankAccount.Specific;
                cbUser.SelectedValue = bankAccount.UserId;
            }
        }
        
        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateData())
                return;
            FillData();
            using (ApplicationContext db = new()) 
            {
                db.BankAccounts.Update(bankAccount);
                db.SaveChanges();
            }            
            DialogResult = true;
        }
        private void Number_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new("[^0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void FillData()
        {
            bankAccount.Name = tbName.Text;
            bankAccount.Number = tbNumber.Text;
            bankAccount.Image = tbImage.Text;
            bankAccount.OpeningDate = (DateTime)dpOpeningDate.SelectedDate!;
            bankAccount.Specific = tbSpecific.Text;
            bankAccount.UserId = (int)cbUser.SelectedValue;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private bool ValidateData()
        {
            StringBuilder errorMessage = new();
            if (tbSpecific.Text.Length == 0)
                errorMessage.AppendLine("Введите спецификацию счета");
            if (tbImage.Text.Length == 0)
                errorMessage.AppendLine("Введите название фотографии");
            if (tbNumber.Text.Length == 0)
                errorMessage.AppendLine("Введите номер счета");
            if (tbName.Text.Length == 0)
                errorMessage.AppendLine("Введите название счета");
            if (cbUser.SelectedIndex == -1)
                errorMessage.AppendLine("Выберите пользователя");
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
