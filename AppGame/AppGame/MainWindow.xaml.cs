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

//https://github.com/TexAgg/MyMP3/blob/master/MyMP3/Form1.cs

namespace AppGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
            main_label.Content = "Yay";
        }
    }
}
