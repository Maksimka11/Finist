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
    public partial class TransactionWindow : Window
    {
        private readonly Transaction transaction = new();
        private readonly ApplicationContext db = new();
        public TransactionWindow()
        {
            InitializeComponent();
        }

        public TransactionWindow(Transaction transaction)
        {
            InitializeComponent();
            this.transaction = transaction;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbSender.ItemsSource = db.Cards.ToList();
            cbReceiver.ItemsSource = db.Cards.ToList();

            tbSum.Text = transaction.Sum.ToString();
            dpTransferDateTime.SelectedDate = transaction.TransferDateTime;
            cbSender.SelectedValue = transaction.SenderId;
            cbReceiver.SelectedValue = transaction.ReceiverId;
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateData())
                return;
            FillData();
            db.Transactions.Update(transaction);
            db.SaveChanges();
            DialogResult = true;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void Sum_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new("[^0-9,]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void FillData()
        {
            transaction.SenderId = (int)cbSender.SelectedValue;
            transaction.ReceiverId = (int)cbReceiver.SelectedValue;
            transaction.Sum = Convert.ToDecimal(tbSum.Text);
            transaction.TransferDateTime = (DateTime)dpTransferDateTime.SelectedDate!;
        }

        private bool ValidateData()
        {
            StringBuilder errorMessage = new();
            if (cbSender.SelectedIndex == -1)
                errorMessage.AppendLine("Выберите отправителя");
            if (cbReceiver.SelectedIndex == -1)
                errorMessage.AppendLine("Выберите получателя");
            if (tbSum.Text.Length == 0)
                errorMessage.AppendLine("Введите сумму перевода");
            if (cbSender.SelectedIndex == cbReceiver.SelectedIndex)
                errorMessage.AppendLine("Отправитель и получаетель не могут иметь одинаковый счет");
            
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
