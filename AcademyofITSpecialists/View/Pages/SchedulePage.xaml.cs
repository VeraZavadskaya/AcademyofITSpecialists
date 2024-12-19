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
using AcademyofITSpecialists.View.Windows;

namespace AcademyofITSpecialists.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для SchedulePage.xaml
    /// </summary>
    public partial class SchedulePage : Page
    {
        List<Schedule> schedules = App.context.Schedule.ToList();
        public SchedulePage()
        {
            InitializeComponent();

            if (App.currentUser.IdPost == 2)
            {
                AddScheduleBtn.IsEnabled = false;
                AddScheduleBtn.Visibility = Visibility.Collapsed;
            }

            ScheduleLv.ItemsSource = App.context.Schedule.ToList();
        }


        private void AddScheduleBtn_Click(object sender, RoutedEventArgs e)
        {
            AddGroupInSchedule addGroupInSchedule = new AddGroupInSchedule();
            addGroupInSchedule.ShowDialog();
            }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchTb.Text != string.Empty)
            {
                ScheduleLv.ItemsSource = App.context.Schedule.Where(g => g.Group.Name.ToLower().Contains(SearchTb.Text.ToLower())).ToList();
            }
            else
            {
                ScheduleLv.ItemsSource = App.context.Schedule.ToList();
            }
        }
    }
}