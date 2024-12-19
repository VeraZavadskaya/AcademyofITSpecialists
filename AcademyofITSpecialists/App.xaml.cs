using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows;
using AcademyofITSpecialists.Model;

namespace AcademyofITSpecialists
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        // Подключение к БД.
        public static AcademyofITSpecialistsEntities context = new AcademyofITSpecialistsEntities();

        //Вошедший пользователь.
        public static User currentUser;
    }
}
