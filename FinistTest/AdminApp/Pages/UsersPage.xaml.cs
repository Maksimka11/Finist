using AdminApp.Windows;
using FinistBackend.Context;
using FinistBackend.Models;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace AdminApp.Pages
{
    public partial class UsersPage : Page
    {
        private readonly ApplicationContext db;

        public UsersPage()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dgUsers.ItemsSource = db.Users.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            UsersWindow window = new();
            if (window.ShowDialog() == true)
            {
                Refresh();
            }
        }
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (dgUsers.SelectedItem == null)
                return;
                      
            UsersWindow window = new((User)dgUsers.SelectedItem!);
            if (window.ShowDialog() == true)
            {
                Refresh();
            }
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            if (dgUsers.SelectedItem == null)
                return;
            try
            {
                db.Users.Remove((User)dgUsers.SelectedItem!);
                db.SaveChanges();
                Refresh();
            }
            catch
            {
                MessageBox.Show("Есть связаные поля","Ошибка",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Refresh()
        {
            dgUsers.ItemsSource = null;
            dgUsers.ItemsSource = db.Users.ToList();
        }
    }
}
