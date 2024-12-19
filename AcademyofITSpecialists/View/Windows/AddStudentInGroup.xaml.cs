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
    /// Логика взаимодействия для AddStudentInGroup.xaml
    /// </summary>
    public partial class AddStudentInGroup : Window
    {
        public AddStudentInGroup()
        {
            InitializeComponent();

            GroupCmb.SelectedValuePath = "Id";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.Group.ToList();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(LastNameTb.Text) || string.IsNullOrEmpty(FirstNameTb.Text) || string.IsNullOrEmpty(BirthDp.Text) || string.IsNullOrEmpty(GroupCmb.Text))
            {
                MessageBoxHelper.Warning("Заполните все поля!");
            }
            else
            {
                Student newStudent = new Student()
                {
                    LastName = LastNameTb.Text,
                    FirstName = FirstNameTb.Text,
                    MiddleName = MiddleNameTb.Text,
                    Birthday = Convert.ToDateTime(BirthDp.Text),
                    IdGroup = Convert.ToInt32(GroupCmb.SelectedValue)
                };
                 App.context.Student.Add(newStudent);
                App.context.SaveChanges();
                MessageBoxHelper.Information("Студент добавлен в группу");
            }

            LastNameTb.Text = "";
            FirstNameTb.Text = "";
            MiddleNameTb.Text = "";
            BirthDp.Text = "";
            GroupCmb.Text = "";
            

        }
    }
}
