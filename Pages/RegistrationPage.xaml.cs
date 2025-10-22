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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
            RegisterComboBox.ItemsSource = Helpers.Helpers.DB.Class.ToList();
        }

        private void CreateAccount_Click(object sender, RoutedEventArgs e)
        {
            if (Helpers.Helpers.DB.Users.FirstOrDefault(u => u.Login == RegisterLoginTextBox.Text) != null)
            {
                MessageBox.Show("Пользователь с таким логином уже существует");
                return;
            }
            if (RegisterComboBox != null && RegisterComboBox.SelectedItem == null)
            {
                MessageBox.Show("Вы не выбрали свой класс");
                return;
            }

            string login = RegisterLoginTextBox.Text;
            string nickname = RegisterNickNameTextBox.Text;
            string password = RegisterPasswordBox.Password;

            int ClassId = (int)RegisterComboBox.SelectedValue;
            int maxId;

            if (Helpers.Helpers.DB.Users.Count() == 0)
            {
                maxId = 1;
            }
            else
            {
                maxId = Helpers.Helpers.DB.Users.Max(b => b.ID) + 1;
            }

            var user = new Users()
            {
                ID = maxId,
                Login = login,
                Nickname = nickname,
                Password = password,
                ClassID = ClassId,
            };

            Helpers.Helpers.DB.Users.Add(user);
            Helpers.Helpers.DB.SaveChanges();

            MessageBox.Show("Вы успешно зарегистрировались");

            Helpers.Helpers.CurrentUser = user;
            Helpers.Helpers.label.Content = "Основная страница";
            Helpers.Helpers.frame.Navigate(new MainPage());
        }

        private void ButtonLog_Click(object sender, RoutedEventArgs e)
        {
            Helpers.Helpers.label.Content = "Авторизация";
            Helpers.Helpers.frame.Navigate(new AutorizationPage());
        }
    }
}
