using ClassLibTeam05.Business;
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

namespace WpfTeam05
{
    /// <summary>
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
            foreach (var item in Students.List())
            {
                ListStudents.Items.Add(item);
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            SqlWindow window = new SqlWindow();
            window.ShowDialog();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            StudentWindow window = new StudentWindow();
            window.Show();
        }
    }
}
