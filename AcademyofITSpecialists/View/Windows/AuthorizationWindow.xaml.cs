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
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();

            LoadUserData();
        }

        private void RegistrationHl_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            this.Hide();
        }

        /// <summary>
        ///  Функция производит запись данных пользователя в память приложения при нажатии на галочку "Запомнить меня".
        /// </summary>
        private void RememberMeCb_Click(object sender, RoutedEventArgs e)
        {
            
            if (RememberMeCb.IsChecked == true)
            {
                Properties.Settings.Default.LoginValue = LoginTb.Text;
                Properties.Settings.Default.PasswordValue = PasswordPb.Password;
            }
            else
            {
                Properties.Settings.Default.LoginValue = string.Empty;
                Properties.Settings.Default.PasswordValue = string.Empty;
            }

            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Функция производит загрузку данных пользователя из памяти приложения в поля для ввода.
        /// </summary>
        private void LoadUserData()
        {
            if (Properties.Settings.Default.LoginValue != string.Empty)
            {
                LoginTb.Text = Properties.Settings.Default.LoginValue;
                PasswordPb.Password = Properties.Settings.Default.PasswordValue;
            }
        }

        private void EntranceBtn_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(LoginTb.Text) && string.IsNullOrEmpty(PasswordPb.Password))
            {
                MessageBoxHelper.Error("Введите логин и пароль!");
            }
            if(string.IsNullOrEmpty(LoginTb.Text) || string.IsNullOrEmpty(PasswordPb.Password))
            {
                MessageBoxHelper.Error("Введите логин или пароль!");
            }
            User newUser = App.context.User.FirstOrDefault(user => user.Login == LoginTb.Text && user.Password == PasswordPb.Password);

            if(newUser != null)
            {
                App.currentUser = newUser;
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBoxHelper.Warning("Пользователь не найден!");
            }
            
        }
    }
}
