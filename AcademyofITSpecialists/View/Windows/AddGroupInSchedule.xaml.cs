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
using AcademyofITSpecialists.AppData;
using AcademyofITSpecialists.Model;

namespace AcademyofITSpecialists.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddGroupInSchedule.xaml
    /// </summary>
    public partial class AddGroupInSchedule : Window
    {
        public AddGroupInSchedule()
        {
            InitializeComponent();

            DayOfWeekCmb.DisplayMemberPath = "Name";
            DayOfWeekCmb.SelectedValuePath = "Id";
            DayOfWeekCmb.ItemsSource = App.context.DayOfTheWeek.ToList();

            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.SelectedValuePath = "Id";
            GroupCmb.ItemsSource  = App.context.Group.ToList();

            SubjectCmb.DisplayMemberPath = "Name";
            SubjectCmb.SelectedValuePath = "Id";
            SubjectCmb.ItemsSource = App.context.Subject.ToList();

            UserCmb.DisplayMemberPath = "LastName";
            UserCmb.SelectedValuePath = "Id";
            UserCmb.ItemsSource = App.context.User.ToList();

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(DayOfWeekCmb.Text) || string.IsNullOrEmpty(HourTb.Text)|| string.IsNullOrEmpty(MinuteTb.Text) || string.IsNullOrEmpty(GroupCmb.Text) || string.IsNullOrEmpty(SubjectCmb.Text) || string.IsNullOrEmpty(UserCmb.Text))
            {
                MessageBoxHelper.Information("Заполните все поля!");
            }
            else
            {
                Schedule newSchedule = new Schedule()
                {
                    DayOfTheWeek = DayOfWeekCmb.SelectedItem as DayOfTheWeek,

                    Group = GroupCmb.SelectedItem as Group,
                    Subject = SubjectCmb.SelectedItem as Subject,
                    User = UserCmb.SelectedItem as User
                };

                App.context.Schedule.Add(newSchedule);
                App.context.SaveChanges();
                MessageBoxHelper.Information("Расписание добавлено!");


            }
        }
    }
}
