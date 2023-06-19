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

namespace WpfApp3
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
        private void OnChecked(object sender, RoutedEventArgs e)
        {
            
            button.Visibility = Visibility.Visible;
            comboBox.Visibility = Visibility.Visible;
            textBox.Visibility = Visibility.Visible;
            label1.Visibility = Visibility.Visible;
            label2.Visibility = Visibility.Visible;
            PID.Visibility = Visibility.Visible;
            PID2.Visibility = Visibility.Visible;

            this.Height += 40;
        }

        private void OnUnchecked(object sender, RoutedEventArgs e)
        {
            
            button.Visibility = Visibility.Collapsed;
            comboBox.Visibility = Visibility.Collapsed;
            textBox.Visibility = Visibility.Collapsed;
            label1.Visibility = Visibility.Collapsed;
            label2.Visibility = Visibility.Collapsed;
            PID.Visibility = Visibility.Collapsed;
            PID2.Visibility = Visibility.Collapsed;
            this.Height -= 40;
        }
    }
}
