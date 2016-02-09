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
using System.Windows.Navigation;
using System.Windows.Shapes;
//using System.Drawing;

//https://github.com/TexAgg/MyMP3/blob/master/MyMP3/Form1.cs

namespace AppGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool main_button_pressed = false;
        private int count = 0;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        /*
        private void main_button_Click(object sender, EventArgs e)
        {
            main_label.Content = "Yay";
        }
         */

        private void main_button_click(object sender, RoutedEventArgs e)
        {
            count++;
            main_button_pressed = !main_button_pressed;
            main_label.Content = labeler();
            strobe();
            display_count.Text = count.ToString();
        }

        private string labeler()
        {
            if (main_button_pressed)
                return "yay!";
            else
                return "Press me!";
        }

        private void strobe()
        {
            if (main_button_pressed)
                background.Background = new SolidColorBrush(Color.FromRgb(255, 204, 0));
            else
                background.Background = new SolidColorBrush(Color.FromRgb(128,128,128));
        }
    }
}
