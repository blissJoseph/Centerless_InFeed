using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Timers;
using System.ComponentModel;
using System.Windows.Threading;

namespace Centerless_InFeed
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer;
     
        public MainWindow()
        {
            InitializeComponent();

            //Initialize Timer
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1); // update every second
            _timer.Tick += Timer_Tick;
            _timer.Start();

            //Set initial time
            TimeTextBlock.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy hh:mm:ss tt");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //Update the time in the TextBlock
            TimeTextBlock.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy hh:mm:ss tt");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }
    }
}
