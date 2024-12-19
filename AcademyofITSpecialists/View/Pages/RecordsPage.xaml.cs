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
using AcademyofITSpecialists.View.Windows;

namespace AcademyofITSpecialists.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для RecordsPage.xaml
    /// </summary>
    public partial class RecordsPage : Page
    {
        public RecordsPage()
        {
            InitializeComponent();

            if (App.currentUser.IdPost == 2)
            {
                AddRecordsBtn.IsEnabled = false;
                AddRecordsBtn.Visibility = Visibility.Collapsed;
            }

            RecordsLb.ItemsSource = App.context.Records.ToList();
        }

        private void AddRecordsBtn_Click(object sender, RoutedEventArgs e)
        {
            AddRecordWindow addRecordWindow = new AddRecordWindow();
            addRecordWindow.ShowDialog();
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(SearchTb.Text != string.Empty)
            {
                RecordsLb.ItemsSource = App.context.Records.Where(r => r.Text.ToLower().Contains(SearchTb.Text.ToLower())).ToList();
            }
            else
            {
                RecordsLb.ItemsSource = App.context.Records.ToList();
            }
        }

        private void RecordsLb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
