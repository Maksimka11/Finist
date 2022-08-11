using AdminApp.Windows;
using FinistBackend.Context;
using FinistBackend.Models;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AdminApp.Pages
{
    public partial class TransactionsPage : Page
    {
        private readonly ApplicationContext db;
        public TransactionsPage()
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
            TransactionWindow window = new();
            if (window.ShowDialog() == true)
            {
                Refresh();
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (dgTransactions.SelectedItem == null)
                return;
            int accountId = (int)dgTransactions.SelectedValue;
            Transaction transaction = db.Transactions.FirstOrDefault(t => t.Id == accountId)!;
            TransactionWindow window = new(transaction);
            if (window.ShowDialog() == true)
            {
                Refresh();
            }
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            if (dgTransactions.SelectedItem == null)
                return;

            try
            {
                int transactionId = (int)dgTransactions.SelectedValue;
                Transaction transaction = db.Transactions.FirstOrDefault(t => t.Id == transactionId)!;
                db.Transactions.Remove(transaction);
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
            dgTransactions.ItemsSource = null;
            var view = from transaction in db.Transactions
                       join sender in db.Cards on transaction.SenderId equals sender.Id
                       join receiver in db.Cards on transaction.ReceiverId equals receiver.Id
                       select new
                       {
                           Id = transaction.Id,
                           Sender = sender.Number,
                           Receiver = receiver.Number,
                           Sum = transaction.Sum,
                           TransferDateTime = transaction.TransferDateTime,
                       };
            dgTransactions.ItemsSource = view.ToList();

        }
    }
}
