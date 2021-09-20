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

namespace _3försöket3uppgiftet
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

        private void knappPlusClick(Object sender, RoutedEventArgs e)
        {
            bool ärKorrektInmattat = true;
            resultatRuta.Text = "";
            float tal1;
            if (!float.TryParse(tal1Ruta.Text, out tal1))
            {
                MessageBox.Show("Tal1 fel inmatning.\n formatet tex 2,5");
                ärKorrektInmattat = false;
            }
            float tal2;
            if (!float.TryParse(tal2Ruta.Text, out tal2))
            {
                MessageBox.Show("Tal1 fel inmatning.\n formatet tex 2,5");
                ärKorrektInmattat = false;
            }
            if (ärKorrektInmattat)
            {
                resultatRuta.Text = $"{tal1} + {tal2} = {tal1 + tal2}";
            }

        }

        private void knappMinusClick(Object sender, RoutedEventArgs e)
        {
            bool ärKorrektInmattat = true;
            resultatRuta.Text = "";
            float tal1;
            if (!float.TryParse(tal1Ruta.Text, out tal1))
            {
                MessageBox.Show("Tal1 fel inmatning.\n formatet tex 2,5");
                ärKorrektInmattat = false;
            }
            float tal2;
            if (!float.TryParse(tal2Ruta.Text, out tal2))
            {
                MessageBox.Show("Tal2 fel inmatning.\n formatet tex 2,5");
                ärKorrektInmattat = false;
            }
            if (ärKorrektInmattat)
            {
                resultatRuta.Text = $"{tal1} - {tal2} = {tal1 - tal2}";
            }

        }

        private void knappGångerClick(Object sender, RoutedEventArgs e)
        {
            bool ärKorrektInmattat = true;
            resultatRuta.Text = "";
            float tal1;
            if (!float.TryParse(tal1Ruta.Text, out tal1))
            {
                MessageBox.Show("Tal1 fel inmatning.\n formatet tex 2,5");
                ärKorrektInmattat = false;
            }
            float tal2;
            if (!float.TryParse(tal2Ruta.Text, out tal2))
            {
                MessageBox.Show("Tal2 fel inmatning.\n formatet tex 2,5");
                ärKorrektInmattat = false;
            }
            if (ärKorrektInmattat)
            {
                resultatRuta.Text = $"{tal1} * {tal2} = {tal1 * tal2}";
            }

        }

        private void knappDivideraClick(Object sender, RoutedEventArgs e)
        {
            bool ärKorrektInmattat = true;
            resultatRuta.Text = "";
            float tal1;
            if (!float.TryParse(tal1Ruta.Text, out tal1))
            {
                MessageBox.Show("Tal1 fel inmatning.\n formatet tex 2,5");
                ärKorrektInmattat = false;
            }
            float tal2;
            if (!float.TryParse(tal2Ruta.Text, out tal2))
            {
                MessageBox.Show("Tal2 fel inmatning.\n formatet tex 2,5");
                ärKorrektInmattat = false;
            }
            if (ärKorrektInmattat)
            {
                resultatRuta.Text = $"{tal1} / {tal2} = {tal1 / tal2}";
            }

        }
    }
}
