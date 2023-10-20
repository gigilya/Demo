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

namespace ДЭ1
{
    /// <summary>
    /// Логика взаимодействия для UserRole.xaml
    /// </summary>
    public partial class UserRole : Window
    {
        public UserRole()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BoxUser.ItemsSource = Singleton.BD.User.ToList();

            User_Role.ItemsSource = Singleton.BD.Role.ToList();

        }

        private void Save_click(object sender, RoutedEventArgs e)
        {
            User user = BoxUser.SelectedItem as User;
            Role role = User_Role.SelectedItem as Role;

            if (user == null)
                return;

            user.Role.Clear();

            if (role != null)
                user.Role.Add(role);

            Singleton.BD.SaveChanges();  
        }

        private void Cancel_click(object sender, RoutedEventArgs e) => Close();
        private void Clear_click(object sender, RoutedEventArgs e)
        {
            User_Role.SelectedItem = null;
        }

        private void BoxUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User user = BoxUser.SelectedItem as User;

            if (user == null)
                return;

            User_Role.SelectedItem = user.Role.FirstOrDefault();
        }
    }
}
