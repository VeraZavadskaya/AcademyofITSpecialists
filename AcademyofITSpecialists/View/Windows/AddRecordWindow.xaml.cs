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
    /// Логика взаимодействия для AddRecordWindow.xaml
    /// </summary>
    public partial class AddRecordWindow : Window
    {
        public AddRecordWindow()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TextTb.Text))
            {
                MessageBoxHelper.Warning("Заполните текстовое поле!");
            }
            else
            {
                Records records = new Records()
                {
                    Heading = HeadingTb.Text,
                    Text = TextTb.Text
                };

                App.context.Records.Add(records);
                App.context.SaveChanges();
                MessageBoxHelper.Information("Запись успешно добавлена!");
            }
            
            HeadingTb.Text = "";
            TextTb.Text = "";
            Close();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
