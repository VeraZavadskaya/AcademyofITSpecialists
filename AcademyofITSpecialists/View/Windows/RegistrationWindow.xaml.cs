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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();

            GenderCb.ItemsSource = App.context.Gender.ToList();
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(LastNameTb.Text) || string.IsNullOrEmpty(FirstNameTb.Text) || string.IsNullOrEmpty(MiddleNameTb.Text) || BirthdayDp.SelectedDate.Value == null || GenderCb.SelectedValue == null || string.IsNullOrEmpty(EmailTb.Text) || string.IsNullOrEmpty(PhoneTb.Text) || string.IsNullOrEmpty(PasswordPb.Password))
            {
                MessageBoxHelper.Warning("Заполните  все поля!");
            }
            else
            {
                try
                {
                    User newUser = new User()
                    {
                        LastName = LastNameTb.Text,
                        FistName = FirstNameTb.Text,
                        MiddleName = MiddleNameTb.Text,
                        Birthday = BirthdayDp.SelectedDate.Value,
                        IdGender = Convert.ToInt32(GenderCb.SelectedValue),
                        Email = EmailTb.Text,
                        NumberPhone = PhoneTb.Text,
                        Password = PasswordPb.Password
                    };
                    App.context.User.Add(newUser);
                    App.context.SaveChanges();

                    MessageBoxHelper.Information("Пользователь успешно добавлен!");
                }
                catch
                {
                    MessageBoxHelper.Error("Данные заполнены некорректно!");
                }
            }
        }

        private void AutorizationHl_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            this.Close();
        }
    }
}
