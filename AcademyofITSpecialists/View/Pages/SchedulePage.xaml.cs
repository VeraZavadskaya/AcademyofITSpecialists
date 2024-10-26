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
    /// Логика взаимодействия для SchedulePage.xaml
    /// </summary>
    public partial class SchedulePage : Page
    {
        public SchedulePage()
        {
            InitializeComponent();

            ScheduleLv.ItemsSource = App.context.Schedule.ToList();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddScheduleBtn_Click(object sender, RoutedEventArgs e)
        {
            AddGroupInSchedule addGroupInSchedule = new AddGroupInSchedule();
            addGroupInSchedule.Show();
        }
    }
}
