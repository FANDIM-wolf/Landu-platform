using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Threading;
using System.Diagnostics;

namespace landu_coin_wpf
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //создаем новый процесс
            //Process proc = new Process();
            //Запускаем Блокнто
            //proc.StartInfo.FileName = @"Notepad.exe";
            //proc.StartInfo.Arguments = "";
            //proc.Start();

            ProcessStartInfo stInfo =
            new ProcessStartInfo(@"C:\Users\USER\source\repos\LanduS\Debug\LanduS.exe");

            stInfo.UseShellExecute = false;
            stInfo.CreateNoWindow = true;

            //создаем новый процесс
            Process proc = new Process();
            proc.StartInfo = stInfo;
            //Запускаем процесс
            proc.Start();

            //Ждем, пока блокнот запущен
            proc.WaitForExit();

           
        }
    }
}
