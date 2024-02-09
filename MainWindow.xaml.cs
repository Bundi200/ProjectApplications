using NoteApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
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

namespace Applications
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
        public MainWindow()
        {
            InitializeComponent();


            //DateTime currentDate = DateTime.Today;

            //Label label = new Label();
            
        }

        private void Note_Application_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new NoteApplication.MainWindow();
            newWindow.Show();
            this.Close();
        }

        private void Calculator_Application_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new Calculator();
            newWindow.Show();
            this.Close();
        }

        private void Random_Number_Generator_Application_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new RandomNumberGenerator();
            newWindow.Show();
            this.Close();
        }
        private void Employee_Promotion_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new EmployeePromotion();
            newWindow.Show();
            this.Close();
        }
        private void Drawing_Board_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new Drawing();
            newWindow.Show();
            this.Close();
        }
        
        private void lbl_Date(object sender, RoutedEventArgs e)
        {
            DateTime currentDate = DateTime.UtcNow;

            lbl_date.Content = currentDate;
        }
    }
}
