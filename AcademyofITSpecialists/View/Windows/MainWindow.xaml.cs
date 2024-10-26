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
using System.Windows.Shapes;
using AcademyofITSpecialists.View.Pages;

namespace AcademyofITSpecialists.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainFrame.Navigate(new MainPage());
        }

        private void MainBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainPage());
        }

        private void GroupBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new GroupPage());
        }

        private void RecordingsBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new RecordsPage());
        }

        private void ScheduleBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SchedulePage());
        }

        private void ExitHL_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            this.Close();
        }

        private void ProfileImageBtn_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProfilePage());
        }
    }
}
