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

        static List<UserControl1> control = new List<UserControl1>();
        public static List<list_structure> Errorlist_CAN= new List<list_structure>();
        public MainWindow()
        {
            InitializeComponent();
            initerror();
            foreach (UserControl1 temp in control)
            {
                testgrid.Children.Add(temp);
            }
            
        }
        public static void initerror()
        {
            string[] errorlist = File.ReadAllLines("test.txt");
            int byte_num = 0;
            int i = 0;
            int type = 1;
            Boolean next_can = true;
            Boolean next_byte = false;

            UserControl1 temp_Control = new UserControl1();
            list_structure temp_list_structure = new list_structure();
            while (errorlist[i] != "CONFIG")
            {
                i++;
                if (i - 1 > errorlist.Count())
                {
                    return;
                }
            }
            for (; i < errorlist.Count() - 1; i++)
            {
                try
                {
                    if (Convert.ToInt32(errorlist[i], 16) >= 0x743)
                    {
                        temp_list_structure = new list_structure();
                        temp_list_structure.ID = Convert.ToInt16(errorlist[i]);
                        i++;
                        temp_list_structure.type = Convert.ToInt16(errorlist[i]);
                        type= Convert.ToInt16(errorlist[i]);
                        i++;
                        byte_num = 0;
                        temp_Control = new UserControl1();
                        temp_Control.CAN.Content = errorlist[i];
                        Errorlist_CAN.Add(temp_list_structure);
                        next_can = false;
                        i++;
                    }
                }
                catch
                {
                }
                while (next_can == false)
                {
                    next_byte = false;
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
                    }
                    if (errorlist[i + 1] != "")
                    {
                        if (errorlist[i + 1].Substring(0, 1) == "*")
                        {
                            next_can = true;
                            next_byte = true;
                            control.Add(temp_Control);
                            break;
                        }
                    }
                    switch (byte_num)
                    {
                        case 0:
                            i++;
                            if (errorlist[i]!="")
                            {
                                temp_Control.CAN_byte1_title.Content= errorlist[i];
                                temp_Control.Add_byte(byte_num,type);
                            }
                            i++;
                            break;
                        case 1:
                            i++;
                            if (errorlist[i] != "")
                            {
                                temp_Control.CAN_byte2_title.Content = errorlist[i];
                                temp_Control.Add_byte(byte_num, type);
                            }
                            i++;
                            break;
                        case 2:
                            i++;
                            if (errorlist[i] != "")
                            {
                                temp_Control.CAN_byte3_title.Content = errorlist[i];
                                temp_Control.Add_byte(byte_num, type);
                            }
                            i++;
                            break;
                        case 3:
                            i++;
                            if (errorlist[i] != "")
                            {
                                temp_Control.CAN_byte4_title.Content = errorlist[i];
                                temp_Control.Add_byte(byte_num, type);
                            }
                            i++;
                            break;
                        case 4:
                            i++;
                            if (errorlist[i] != "")
                            {
                                temp_Control.CAN_byte5_title.Content = errorlist[i];
                                temp_Control.Add_byte(byte_num, type);
                            }
                            i++;
                            break;
                        case 5:
                            i++;
                            if (errorlist[i] != "")
                            {
                                temp_Control.CAN_byte6_title.Content = errorlist[i];
                                temp_Control.Add_byte(byte_num, type);
                            }
                            i++;
                            break;
                        case 6:
                            i++;
                            if (errorlist[i] != "")
                            {
                                temp_Control.CAN_byte7_title.Content = errorlist[i];
                                temp_Control.Add_byte(byte_num, type);
                            }
                            i++;
                            break;
                        case 7:
                            i++;
                            if (errorlist[i] != "")
                            {
                                temp_Control.CAN_byte8_title.Content = errorlist[i];
                                temp_Control.Add_byte(byte_num, type);
                            }
                            i++;
                            break;
                    }
                    while (next_byte == false)
                    {
                        switch (byte_num)
                        {
                            case 0:
                                temp_Control.CAN_byte1_title.Foreground = new SolidColorBrush(Colors.Black);
                                temp_Control.Add_new(errorlist[i], 0);
                                i++;
                                break;
                            case 1:
                                temp_Control.CAN_byte2_title.Foreground = new SolidColorBrush(Colors.Black);
                                temp_Control.Add_new(errorlist[i], 1);
                                i++;
                                break;
                            case 2:
                                temp_Control.CAN_byte3_title.Foreground = new SolidColorBrush(Colors.Black);
                                temp_Control.Add_new(errorlist[i], 2);
                                i++;
                                break;
                            case 3:
                                temp_Control.CAN_byte4_title.Foreground = new SolidColorBrush(Colors.Black);
                                temp_Control.Add_new(errorlist[i], 3);
                                i++;
                                break;
                            case 4:
                                temp_Control.CAN_byte5_title.Foreground = new SolidColorBrush(Colors.Black);
                                temp_Control.Add_new(errorlist[i], 4);
                                i++;
                                break;
                            case 5:
                                temp_Control.CAN_byte6_title.Foreground = new SolidColorBrush(Colors.Black);
                                temp_Control.Add_new(errorlist[i], 5);
                                i++;
                                break;
                            case 6:
                                temp_Control.CAN_byte7_title.Foreground = new SolidColorBrush(Colors.Black);
                                temp_Control.Add_new(errorlist[i], 6);
                                i++;
                                break;
                            case 7:
                                temp_Control.CAN_byte8_title.Foreground = new SolidColorBrush(Colors.Black);
                                temp_Control.Add_new(errorlist[i], 7);
                                i++;
                                break;
                        }
                        try
                        {
                            if (Convert.ToInt32(errorlist[i], 16) < 8 || errorlist[i+1].Substring(0, 1) == "*")
                            {
                                next_byte = true;
                                byte_num++;
                            }
                        }
                        catch
                        {
                        }
                    }
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Error1.Children[1].Status = new SolidColorBrush(Colors.Red);
            //Error2.Children[1].Status = new SolidColorBrush(Colors.Red);
        }


    }
    public struct list_structure
    {
        public Int16 ID;
        public Int16 type;
    }
}
