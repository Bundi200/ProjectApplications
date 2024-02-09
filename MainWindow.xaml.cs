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
using System.Windows.Threading;
using Microsoft.VisualBasic;
using System.ComponentModel;


namespace Applications
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public DateTime CurrentDateAndTime { get; set; }
        public event PropertyChangedEventHandler? PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += new EventHandler(lbl_time);
            timer.Start();
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
        
        public void lbl_time(object sender, EventArgs e)
        {
            CurrentDateAndTime = DateTime.Now;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName: "CurrentDateAndTime"));

        }
        
    }
}
