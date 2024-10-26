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
using AcademyofITSpecialists.Model;

namespace AcademyofITSpecialists.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для GroupPage.xaml
    /// </summary>
    public partial class GroupPage : Page
    {
        public GroupPage()
        {
            InitializeComponent();

            InformationOfStudentsLV.ItemsSource = App.context.Student.ToList();
        }

        private void P10Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void P11Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void P12Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void R09Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void R10Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void R11Btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
