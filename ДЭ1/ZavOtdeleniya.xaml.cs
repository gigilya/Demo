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
    /// Логика взаимодействия для ZavOtdeleniya.xaml
    /// </summary>
    public partial class ZavOtdeleniya : Window
    {
        public ZavOtdeleniya()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Singleton.BD.Group.ToList();
            group_grid.ItemsSource = Singleton.BD.Group.Local;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Singleton.BD.SaveChanges();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            Hide();
            addStudent.ShowDialog();
            Show();
        }

    }
}
