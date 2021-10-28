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

namespace WPF_uppgift_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public float addition;
        public int antalClick = 1;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void knappAdderaClick(object sender, RoutedEventArgs e)
        {
            string summa = talRuta.Text;
            if (!float.TryParse(summa, out float tal))
            {
                MessageBox.Show("Ange en tal");
            }
            else
            {
                float resultat = addition + tal;
                summaRuta.Text = +addition + "+" + tal + "=" + resultat;
                addition = addition + tal;
                medelRuta.Text = $"{addition} / {antalClick}={addition / antalClick}";
                antalClick++;
                talRuta.Text = "";
            }
        }
    }
}
