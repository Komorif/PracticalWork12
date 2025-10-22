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
    /// Логика взаимодействия для TeamsPage.xaml
    /// </summary>
    public partial class TeamsPage : Page
    {
        public TeamsPage()
        {
            InitializeComponent();
            ListViewTeams.ItemsSource = Helpers.Helpers.DB.Command.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Helpers.Helpers.label.Content = "Основная страница";
            Helpers.Helpers.frame.Navigate(new MainPage());
        }

    }
}
