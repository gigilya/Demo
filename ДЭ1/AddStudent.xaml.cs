using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Window
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AddGroupStudent.ItemsSource = Singleton.BD.Group.Local.ToList();

            AddNameStudent.ItemsSource = Singleton.BD.Applicant.ToList();
        }            //AddNameStudent.ItemsSource = Singleton.BD.Applicant.Local.ToList();

        private void Cancel_click(object sender, RoutedEventArgs e) => Close();
 

        private void Add_click(object sender, RoutedEventArgs e) => Singleton.BD.SaveChanges();

    }
}
