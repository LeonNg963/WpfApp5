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
using WpfApp5.ViewModel;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        private Errorlist CAN_B1 = new Errorlist(null, false);
        private Errorlist CAN_B2 = new Errorlist(null, false);
        private Errorlist CAN_B3 = new Errorlist(null, false);
        private Errorlist CAN_B4 = new Errorlist(null, false);
        private Errorlist CAN_B5 = new Errorlist(null, false);
        private Errorlist CAN_B6 = new Errorlist(null, false);
        private Errorlist CAN_B7 = new Errorlist(null, false);
        private Errorlist CAN_B8 = new Errorlist(null, false);
        private int type;
        public UserControl1(int type)
        {
            InitializeComponent();
            this.type = type;
            if (type == 1)
            {
                CAN_byte1.ItemsSource = CAN_B1.Children;
                CAN_byte2.ItemsSource = CAN_B2.Children;
                CAN_byte3.ItemsSource = CAN_B3.Children;
                CAN_byte4.ItemsSource = CAN_B4.Children;
                CAN_byte5.ItemsSource = CAN_B5.Children;
                CAN_byte6.ItemsSource = CAN_B6.Children;
                CAN_byte7.ItemsSource = CAN_B7.Children;
                CAN_byte8.ItemsSource = CAN_B8.Children;

            }
            else
            {
                CAN_byte2_v.ItemsSource = CAN_B2.Children;
                CAN_byte3_v.ItemsSource = CAN_B3.Children;
                CAN_byte4_v.ItemsSource = CAN_B4.Children;
                CAN_byte5_v.ItemsSource = CAN_B5.Children;
                CAN_byte6_v.ItemsSource = CAN_B6.Children;
                CAN_byte7_v.ItemsSource = CAN_B7.Children;
                CAN_byte8_v.ItemsSource = CAN_B8.Children;
                CAN_byte1_v.ItemsSource = CAN_B1.Children;
            }
        }

        private void Button_CanPanel(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null && clickedButton.Tag is string PanelName)
            {
                StackPanel Panel = FindName(PanelName) as StackPanel;
                if (Panel != null)
                {

                    if (Panel.Visibility == Visibility.Collapsed)
                    {
                        Panel.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        Panel.Visibility = Visibility.Collapsed;
                    }
                }
            }
        }
        private void Button_CANbyte(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null && clickedButton.Tag is string ListViewName)
            {
                ListView List = FindName(ListViewName) as ListView;
                if (List != null)
                {
                    if (List.Visibility == Visibility.Collapsed)
                    {
                        List.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        List.Visibility = Visibility.Collapsed;
                    }
                }
            }
        }
        
        public void Add_new(string str, int byte_num)
        {
            switch (byte_num)
            {
                case 0:
                    if (type == 1)
                    {
                        CAN_byte1_title.Visibility = Visibility.Visible;
                        CAN_byte1_title.Foreground = new SolidColorBrush(Colors.Black);
                    }
                    else
                    {
                        CAN_byte1_title_v.Visibility = Visibility.Visible;
                        CAN_byte1_title_v.Foreground = new SolidColorBrush(Colors.Black);
                    }
                    CAN_B1.Children.Add(new Errorlist() { Status = new SolidColorBrush(Colors.Green), ERROR = str });
                    break;
                case 1:
                    if (type == 1)
                    {
                        CAN_byte2_title.Visibility = Visibility.Visible;
                        CAN_byte2_title.Foreground = new SolidColorBrush(Colors.Black);
                    }
                    else
                    {
                        CAN_byte2_title_v.Visibility = Visibility.Visible;
                        CAN_byte2_title_v.Foreground = new SolidColorBrush(Colors.Black);
                    }
                    CAN_B2.Children.Add(new Errorlist() { Status = new SolidColorBrush(Colors.Green), ERROR = str });
                    break;
                case 2:
                    if (type == 1)
                    {
                        CAN_byte3_title.Visibility = Visibility.Visible;
                        CAN_byte3_title.Foreground = new SolidColorBrush(Colors.Black);
                    }
                    else
                    {
                        CAN_byte3_title_v.Visibility = Visibility.Visible;
                        CAN_byte3_title_v.Foreground = new SolidColorBrush(Colors.Black);
                    }
                    CAN_B3.Children.Add(new Errorlist() { Status = new SolidColorBrush(Colors.Green), ERROR = str });
                    break;
                case 3:
                    if (type == 1)
                    {
                        CAN_byte4_title.Visibility = Visibility.Visible;
                        CAN_byte4_title.Foreground = new SolidColorBrush(Colors.Black);
                    }
                    else
                    {
                        CAN_byte4_title_v.Visibility = Visibility.Visible;
                        CAN_byte4_title_v.Foreground = new SolidColorBrush(Colors.Black);
                    }
                    CAN_B4.Children.Add(new Errorlist() { Status = new SolidColorBrush(Colors.Green), ERROR = str });
                    break;
                case 4:
                    if (type == 1)
                    {
                        CAN_byte5_title.Visibility = Visibility.Visible;
                        CAN_byte5_title.Foreground = new SolidColorBrush(Colors.Black);
                    }
                    else
                    {
                        CAN_byte5_title_v.Visibility = Visibility.Visible;
                        CAN_byte5_title_v.Foreground = new SolidColorBrush(Colors.Black);
                    }
                    CAN_B5.Children.Add(new Errorlist() { Status = new SolidColorBrush(Colors.Green), ERROR = str });
                    break;
                case 5:
                    if (type == 1)
                    {
                        CAN_byte6_title.Visibility = Visibility.Visible;
                        CAN_byte6_title.Foreground = new SolidColorBrush(Colors.Black);
                    }
                    else
                    {
                        CAN_byte6_title_v.Visibility = Visibility.Visible;
                        CAN_byte6_title_v.Foreground = new SolidColorBrush(Colors.Black);
                    }
                    CAN_B6.Children.Add(new Errorlist() { Status = new SolidColorBrush(Colors.Green), ERROR = str });
                    break;
                case 6:
                    if (type == 1)
                    {
                        CAN_byte7_title.Visibility = Visibility.Visible;
                        CAN_byte7_title.Foreground = new SolidColorBrush(Colors.Black);
                    }
                    else
                    {
                        CAN_byte7_title_v.Visibility = Visibility.Visible;
                        CAN_byte7_title_v.Foreground = new SolidColorBrush(Colors.Black);
                    }
                    CAN_B7.Children.Add(new Errorlist() { Status = new SolidColorBrush(Colors.Green), ERROR = str });
                    break;
                case 7:
                    if (type == 1)
                    {
                        CAN_byte8_title.Visibility = Visibility.Visible;
                        CAN_byte8_title.Foreground = new SolidColorBrush(Colors.Black);
                    }
                    else
                    {
                        CAN_byte8_title_v.Visibility = Visibility.Visible;
                        CAN_byte8_title_v.Foreground = new SolidColorBrush(Colors.Black);
                    }
                    CAN_B8.Children.Add(new Errorlist() { Status = new SolidColorBrush(Colors.Green), ERROR = str });
                    break;
            }
        }
        public void Add_byte(int byte_num, int type)
        {
            switch (byte_num)
            {
                case 0:
                    
                    if (type == 1)
                    {
                        CAN_byte1_title.Visibility = Visibility.Visible;
                        CAN_byte1.ItemsSource = CAN_B1.Children;
                    }
                    else
                    {
                        CAN_byte1_title_v.Visibility = Visibility.Visible;
                        CAN_byte1_v.ItemsSource = CAN_B1.Children;
                    }
                    break;
                case 1:
                    if (type == 1)
                    {
                        CAN_byte2_title.Tag = "CAN_byte2";
                        CAN_byte2.ItemsSource = CAN_B2.Children;
                    }
                    else
                    {
                        CAN_byte2_title_v.Visibility = Visibility.Visible;
                        CAN_byte2_v.ItemsSource = CAN_B2.Children;
                    }
                    break;
                case 2:
                    if (type == 1)
                    {
                        CAN_byte3_title.Visibility = Visibility.Visible;
                        CAN_byte3.ItemsSource = CAN_B3.Children;
                    }
                    else
                    {
                        CAN_byte3_title_v.Visibility = Visibility.Visible;
                        CAN_byte3_v.ItemsSource = CAN_B3.Children;
                    }
                    break;
                case 3:
                    if (type == 1)
                    {
                        CAN_byte4_title.Visibility = Visibility.Visible;
                        CAN_byte4.ItemsSource = CAN_B4.Children;
                    }
                    else
                    {
                        CAN_byte4_title_v.Visibility = Visibility.Visible;
                        CAN_byte4_v.ItemsSource = CAN_B4.Children;
                    }
                    break;
                case 4:
                    if (type == 1)
                    {
                        CAN_byte5_title.Visibility = Visibility.Visible;
                        CAN_byte5.ItemsSource = CAN_B5.Children;
                    }
                    else
                    {
                        CAN_byte5_title_v.Visibility = Visibility.Visible;
                        CAN_byte5_v.ItemsSource = CAN_B5.Children;
                    }
                    break;
                case 5:
    
                    if (type == 1)
                    {
                        CAN_byte6_title.Visibility = Visibility.Visible;
                        CAN_byte6.ItemsSource = CAN_B6.Children;
                    }
                    else
                    {
                        CAN_byte6_title_v.Visibility = Visibility.Visible;
                        CAN_byte6_v.ItemsSource = CAN_B6.Children;
                    }
                    break;
                case 6:
                    if (type == 1)
                    {
                        CAN_byte7_title.Visibility = Visibility.Visible;
                        CAN_byte7.ItemsSource = CAN_B7.Children;
                    }
                    else
                    {
                        CAN_byte7_title_v.Visibility = Visibility.Visible;
                        CAN_byte7_v.ItemsSource = CAN_B7.Children;
                    }
                    break;
                case 7:
                    if (type == 1)
                    {
                        CAN_byte8_title.Visibility = Visibility.Visible;
                        CAN_byte8.ItemsSource = CAN_B8.Children;
                    }
                    else
                    {
                        CAN_byte8_title_v.Visibility = Visibility.Visible;
                        CAN_byte8_v.ItemsSource = CAN_B8.Children;
                    }
                    break;
            }
        }
    }
}
