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
        private Cards cc;
        public MainWindow()
        {
            InitializeComponent();
            cc = new Cards();
            DataContext = cc;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cc.Update(0, "1");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            cc.Update(1, "1");
        }
    }
}
