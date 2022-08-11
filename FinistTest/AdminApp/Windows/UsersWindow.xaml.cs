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
    public partial class UsersWindow : Window
    {
        readonly User user;
        readonly ApplicationContext db = new();
        public UsersWindow()
        {
            InitializeComponent();
            user = new();
        }        
        public UsersWindow(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (user != null)
            {
                TbLogin.Text = user!.Login;
                TbPassword.Text = user.Password;
                TbEmail.Text = user.Email;
            }
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateData())
                return;

            FillData();
            db.Users.Update(user);
            db.SaveChanges();
            DialogResult = true;
        }

        private void FillData()
        {
            user.Login = TbLogin.Text;
            user.Password = TbPassword.Text;
            user.Email = TbEmail.Text;
        }
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
        private bool ValidateData()
        {
            StringBuilder errorMessage = new();
            if (TbLogin.Text.Length == 0)
                errorMessage.AppendLine("Введите логин");
            if (TbPassword.Text.Length == 0)
                errorMessage.AppendLine("Введите пароль");
            if (TbEmail.Text.Length == 0)
                errorMessage.AppendLine("Введите почту");

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
