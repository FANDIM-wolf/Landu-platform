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
using System.Threading;

namespace landu_coin_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Thread th;
        public MainWindow()
        {
            InitializeComponent();
            SplashScreen splashScreen = new SplashScreen("Image1.png");
            splashScreen.Show(true);
        }

        private void opens(object obj)
        {
           //Application.Run(new (Window1));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == "elkin" || TextBox1.Text == "elkin") {

                Window1 taskWindow = new Window1();
                taskWindow.Show();

            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        { }
           
    }
}
