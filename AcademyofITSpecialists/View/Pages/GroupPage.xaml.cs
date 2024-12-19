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
    /// Логика взаимодействия для GroupPage.xaml
    /// </summary>
    public partial class GroupPage : Page
    {
        List<Group> groups = App.context.Group.ToList();
        public GroupPage()
        {
            InitializeComponent();

            if(App.currentUser.IdPost == 2)
            {
                AddStudentInGroupBtn.IsEnabled = false;
                AddStudentInGroupBtn.Visibility = Visibility.Collapsed;
            }

            InformationOfStudentsLV.ItemsSource = App.context.Student.ToList();

            GroupCmb.SelectedValuePath = "Id";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.Group.ToList();
        }

        private void GroupCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Group group = GroupCmb.SelectedItem as Group;
            if(GroupCmb.SelectedIndex == 0)
            {
                InformationOfStudentsLV.ItemsSource = App.context.Student.ToList();
            }
            else
            {
                InformationOfStudentsLV.ItemsSource = App.context.Student.Where(s => s.IdGroup == group.Id).ToList();
            }
        }

        private void AddStudentInGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            AddStudentInGroup addStudentInGroup = new AddStudentInGroup();
            addStudentInGroup.ShowDialog();
        }
    }
}
