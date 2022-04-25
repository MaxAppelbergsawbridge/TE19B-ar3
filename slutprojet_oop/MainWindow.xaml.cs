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

namespace slutprojet_oop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //projekt: databas för samlare
            InitializeComponent();
        }
        private void KnappSparaClick(object sender, RoutedEventArgs e)
        {
            string svar = SvarRuta.Text;
            VisaRuta.Text += svar;
        }
        private void KnappRaderaClick(object sender, RoutedEventArgs e)
        {
            VisaRuta.Text = string.Empty;
        }
    }
}
