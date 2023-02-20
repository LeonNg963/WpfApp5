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

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public int type;
        public UserControl1()
        {
            InitializeComponent();
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
    }
}
