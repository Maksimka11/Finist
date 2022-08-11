using AdminApp.Windows;
using FinistBackend.Context;
using FinistBackend.Models;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AdminApp.Pages
{
    public partial class FavoritesPage : Page
    {
        private readonly ApplicationContext db;

        public FavoritesPage()
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
            FavoriteWindow window = new();
            if (window.ShowDialog() == true)
            {
                Refresh();
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (dgFavorites.SelectedItem == null)
                return;
            int favoriteId = (int)dgFavorites.SelectedValue;
            Favorite favorite = db.Favorites.FirstOrDefault(bk => bk.Id == favoriteId)!;
            FavoriteWindow window = new(favorite);            
            if (window.ShowDialog() == true)
            {
                Refresh();
            }
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            if (dgFavorites.SelectedItem == null)
                return;

            int favoriteId = (int)dgFavorites.SelectedValue;
            Favorite favorite = db.Favorites.FirstOrDefault(bk => bk.Id == favoriteId)!;
            db.Favorites.Remove(favorite);
            db.SaveChanges();
            Refresh();
        }

        private void Refresh()
        {
            
            dgFavorites.ItemsSource = null;
            var view = from favorite in db.Favorites
                       join account in db.BankAccounts on favorite.AccountId equals account.Id
                       join transaction in db.Transactions on favorite.TransactionId equals transaction.Id
                       select new
                       {
                           Id = favorite.Id,
                           Name = favorite.Name,
                           Account = account.Name,
                           Transaction = transaction.Id
                       };
            dgFavorites.ItemsSource = view.ToList();
            
        }
    }
}
