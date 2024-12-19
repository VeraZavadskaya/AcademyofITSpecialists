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
using AcademyofITSpecialists.AppData;
using Microsoft.Win32;

namespace AcademyofITSpecialists.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        OpenFileDialog openFileDialog = new OpenFileDialog()
        {
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        };
        public ProfilePage()
        {
            InitializeComponent();

            DataContext = App.currentUser;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if(openFileDialog.FileName != string.Empty)
            {
                App.currentUser.Photo = openFileDialog.FileName;
            }
            App.context.SaveChanges();

            MessageBoxHelper.Information("Изменения сохранены!");

            NavigationService.Navigate(new ProfilePage());
        }
    }
}
