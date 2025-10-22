using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticalWork12.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        public AutorizationPage()
        {
            InitializeComponent();
        }

        private void ButtonAuth_Click(object sender, RoutedEventArgs e)
        {
            var client = Helpers.Helpers.DB.Users.FirstOrDefault(u => u.Login == TextBoxLogin.Text);

            if (client == null)
            {
                MessageBox.Show("Пользователь не найден");
                return;
            }
            if (TextBoxLogin.Text != client.Password.Replace(" ", ""))
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }

            MessageBox.Show("Успешный вход");
            Helpers.Helpers.label.Content = "Основная страница";
            Helpers.Helpers.CurrentUser = client;
            Helpers.Helpers.frame.Navigate(new MainPage());
        }

        private void ButtonReg_Click(object sender, RoutedEventArgs e)
        {
            Helpers.Helpers.label.Content = "Регистрация";
            Helpers.Helpers.frame.Navigate(new RegistrationPage());
        }
    }
}
