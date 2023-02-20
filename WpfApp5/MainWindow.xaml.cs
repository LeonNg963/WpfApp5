using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography;
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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Errorlist Error1 = new Errorlist(null, false);
        private Errorlist Error2 = new Errorlist(null, false);
        UserControl1 control1 = new UserControl1();
        UserControl1 control2 = new UserControl1();

        public MainWindow()
        {
            InitializeComponent();
            Error1.Children.Add(new Errorlist() { Status = new SolidColorBrush(Colors.Green), ERROR = "Err1" });
            Error1.Children.Add(new Errorlist() { Status = new SolidColorBrush(Colors.Green), ERROR = "Err1" });
            Error1.Children.Add(new Errorlist() { Status = new SolidColorBrush(Colors.Green), ERROR = "Err1" });
            Error1.Children.Add(new Errorlist() { Status = new SolidColorBrush(Colors.Green), ERROR = "Err1" });
            control1.Error1.ItemsSource = Error1.Children;
            Error2.Children.Add(new Errorlist() { Status = new SolidColorBrush(Colors.Green), ERROR = "Err1" });
            Error2.Children.Add(new Errorlist() { Status = new SolidColorBrush(Colors.Green), ERROR = "Err1" });
            Error2.Children.Add(new Errorlist() { Status = new SolidColorBrush(Colors.Green), ERROR = "Err1" });
            Error2.Children.Add(new Errorlist() { Status = new SolidColorBrush(Colors.Green), ERROR = "Err1" });
            control2.Error1.ItemsSource = Error2.Children;
            testgrid.Children.Add(control1);
            testgrid.Children.Add(control2);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Error1.Children[1].Status = new SolidColorBrush(Colors.Red);
            Error2.Children[1].Status = new SolidColorBrush(Colors.Red);
        }

    }
}
