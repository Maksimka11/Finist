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
    public partial class CardWindow : Window
    {
        readonly Card card = new();
        readonly ApplicationContext db = new();
        public CardWindow()
        {
            InitializeComponent();
        }
        public CardWindow(Card card)
        {
            InitializeComponent();
            this.card = card;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbAccount.ItemsSource = db.BankAccounts.ToList();

            tbBalance.Text = card.Balance.ToString();
            tbImage.Text = card.Image;
            tbNumber.Text = card.Number;
            tbCVV.Text = card.CVV;
            cbAccount.SelectedValue = card.BankAccountId;
            cbCardType.Text = card.CardType;
            
        }
        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateData())
                return;
            FillData();
            db.Cards.Update(card);
            db.SaveChanges();
            DialogResult = true;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void Digital_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new("[^0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void FillData()
        {
            card.Number = tbNumber.Text;
            card.CVV = tbCVV.Text;
            card.Balance = Convert.ToDecimal(tbBalance.Text);
            card.CardType = cbCardType.Text;
            card.BankAccountId = (int)cbAccount.SelectedValue;
            card.Image = tbImage.Text;
        }

        private bool ValidateData()
        {
            StringBuilder errorMessage = new();
            if (tbNumber.Text.Length == 0)
                errorMessage.AppendLine("Введите номер карты");
            if (tbCVV.Text.Length == 0)
                errorMessage.AppendLine("Введите CVV");
            if (cbAccount.SelectedIndex == -1)
                errorMessage.AppendLine("Выберите счет");
            if (tbImage.Text.Length == 0)
                errorMessage.AppendLine("Введите название фото");
            if (cbCardType.SelectedIndex == -1)
                errorMessage.AppendLine("Выберите тип карты");

            if (errorMessage.Length != 0)
            {
                MessageBox.Show(errorMessage.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            else
                return true;

        }

        private void TbBalance_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new("[^0-9-,]");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
