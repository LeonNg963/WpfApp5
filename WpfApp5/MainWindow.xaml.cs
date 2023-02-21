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
using WpfApp5.ViewModel;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static List<UserControl1> control1 = new List<UserControl1>();

        public MainWindow()
        {
            InitializeComponent();
            initerror();
            foreach (UserControl1 temp in control1)
            {
                testgrid.Children.Add(temp);
            }
            
        }
        public static void initerror()
        {
            string[] errorlist = File.ReadAllLines("test.txt");
            int CAN_num = 0;
            int byte_num = 0;
            List<string> title = new List<string>();
            List<string> test = new List<string>();
            List<string> test1 = new List<string>();
            UserControl1 temp = new UserControl1();
            for (int i = 0; i < errorlist.Count() - 1; i++)
            {
                try
                {
                    if (Convert.ToInt32(errorlist[i], 16) >= 0x743)
                    {
                        CAN_num++;
                        i++;
                        title.Add(errorlist[i]);
                        i++;
                        byte_num = 0;
                        temp = new UserControl1();
                    }
                    else
                    {
                        byte_num++;
                    }
                }
                catch
                {
                }
                try
                {
                    while (Convert.ToInt32(errorlist[i + 1], 16) < 8)
                    {
                        byte_num++;
                        i++;
                    }
                }
                catch
                {
                    if (errorlist[i] != "")
                    {
                        if (errorlist[i].Substring(0, 1) == "*")
                        {
                            continue;
                        }
                    }
                }
                switch (CAN_num)
                {
                    case 1:
                        switch (byte_num)
                        {
                            case 0:

                                break;
                            case 1:

                                break;
                            case 2:

                                break;
                            case 3:

                                break;
                            case 4:

                                break;
                            case 5:

                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                        }
                        break;
                    case 2:
                        switch (byte_num)
                        {
                            case 0:
                                test.Add(errorlist[i]);
                                break;
                            case 1:
                                test1.Add(errorlist[i]);
                                break;
                            case 2:
                                test1.Add(errorlist[i]);
                                break;
                            case 3:
                                test1.Add(errorlist[i]);
                                break;
                            case 4:
                                test1.Add(errorlist[i]);
                                break;
                            case 5:
                                test1.Add(errorlist[i]);
                                break;
                            case 6:
                                test1.Add(errorlist[i]);
                                break;
                            case 7:
                                test1.Add(errorlist[i]);
                                break;
                        }
                        break;
                    case 3:
                        switch (byte_num)
                        {
                            case 0:

                                break;
                            case 1:

                                break;
                            case 2:

                                break;
                            case 3:

                                break;
                            case 4:

                                break;
                            case 5:

                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                        }
                        break;
                    case 4:
                        switch (byte_num)
                        {
                            case 0:

                                break;
                            case 1:

                                break;
                            case 2:

                                break;
                            case 3:

                                break;
                            case 4:

                                break;
                            case 5:

                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                        }
                        break;
                    case 5:
                        switch (byte_num)
                        {
                            case 0:

                                break;
                            case 1:

                                break;
                            case 2:

                                break;
                            case 3:

                                break;
                            case 4:

                                break;
                            case 5:

                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                        }
                        break;
                    case 6:
                        switch (byte_num)
                        {
                            case 0:

                                break;
                            case 1:

                                break;
                            case 2:

                                break;
                            case 3:

                                break;
                            case 4:

                                break;
                            case 5:

                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                        }
                        break;
                    case 7:
                        switch (byte_num)
                        {
                            case 0:

                                break;
                            case 1:

                                break;
                            case 2:

                                break;
                            case 3:

                                break;
                            case 4:

                                break;
                            case 5:

                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                        }
                        break;
                    case 8:
                        switch (byte_num)
                        {
                            case 0:

                                break;
                            case 1:

                                break;
                            case 2:

                                break;
                            case 3:

                                break;
                            case 4:

                                break;
                            case 5:

                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                        }
                        break;
                    case 9:
                        switch (byte_num)
                        {
                            case 0:

                                break;
                            case 1:

                                break;
                            case 2:

                                break;
                            case 3:

                                break;
                            case 4:

                                break;
                            case 5:

                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                        }
                        break;
                    case 10:
                        switch (byte_num)
                        {
                            case 0:

                                break;
                            case 1:

                                break;
                            case 2:

                                break;
                            case 3:

                                break;
                            case 4:

                                break;
                            case 5:

                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                        }
                        break;
                    case 11:
                        switch (byte_num)
                        {
                            case 0:

                                break;
                            case 1:

                                break;
                            case 2:

                                break;
                            case 3:

                                break;
                            case 4:

                                break;
                            case 5:

                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                        }
                        break;
                    case 12:
                        switch (byte_num)
                        {
                            case 0:

                                break;
                            case 1:

                                break;
                            case 2:

                                break;
                            case 3:

                                break;
                            case 4:

                                break;
                            case 5:

                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                        }
                        break;
                    case 13:
                        switch (byte_num)
                        {
                            case 0:

                                break;
                            case 1:

                                break;
                            case 2:

                                break;
                            case 3:

                                break;
                            case 4:

                                break;
                            case 5:

                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                        }
                        break;
                    case 14:
                        switch (byte_num)
                        {
                            case 0:

                                break;
                            case 1:

                                break;
                            case 2:

                                break;
                            case 3:

                                break;
                            case 4:

                                break;
                            case 5:

                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                        }
                        break;
                    case 15:
                        switch (byte_num)
                        {
                            case 0:

                                break;
                            case 1:

                                break;
                            case 2:

                                break;
                            case 3:

                                break;
                            case 4:

                                break;
                            case 5:

                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                        }
                        break;
                    case 16:
                        switch (byte_num)
                        {
                            case 0:

                                break;
                            case 1:

                                break;
                            case 2:

                                break;
                            case 3:

                                break;
                            case 4:

                                break;
                            case 5:

                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                        }
                        break;
                    case 17:
                        switch (byte_num)
                        {
                            case 0:

                                break;
                            case 1:

                                break;
                            case 2:

                                break;
                            case 3:

                                break;
                            case 4:

                                break;
                            case 5:

                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                        }
                        break;
                    case 18:
                        switch (byte_num)
                        {
                            case 0:

                                break;
                            case 1:

                                break;
                            case 2:

                                break;
                            case 3:

                                break;
                            case 4:

                                break;
                            case 5:

                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                        }
                        break;
                    case 19:
                        switch (byte_num)
                        {
                            case 0:

                                break;
                            case 1:

                                break;
                            case 2:

                                break;
                            case 3:

                                break;
                            case 4:

                                break;
                            case 5:

                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                        }
                        break;
                    case 20:
                        switch (byte_num)
                        {
                            case 0:

                                break;
                            case 1:

                                break;
                            case 2:

                                break;
                            case 3:

                                break;
                            case 4:

                                break;
                            case 5:

                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                        }
                        break;
                }
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Error1.Children[1].Status = new SolidColorBrush(Colors.Red);
            Error2.Children[1].Status = new SolidColorBrush(Colors.Red);
        }

    }
}
