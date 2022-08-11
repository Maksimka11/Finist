using System.Windows;
using System.Windows.Controls;
namespace AdminApp.Pages
{
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UsersPage());
        }

        private void btnBankAccount_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BankAccountsPage());
        }

        private void btnCard_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CardsPage());
        }

        private void btnTransactions_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TransactionsPage());
        }

        private void btnFavorites_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FavoritesPage());
        }
    }
}
