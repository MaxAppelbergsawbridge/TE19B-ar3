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
using Newtonsoft.Json;
using System.IO;

namespace slutprojet_oop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Objekt> ListaObjekt = new List<Objekt>();
        public MainWindow()
        {
            //projekt: databas för samlare
            InitializeComponent();
        }
        private void KnappSparaClick(object sender, RoutedEventArgs e)
        {
            Objekt objekt = new Objekt(NamnRuta.Text, MängdRuta.Text, DatumRuta.Text, InfoRuta.Text);
            ListaObjekt.Add(objekt);
            string jsonText = JsonConvert.SerializeObject(ListaObjekt, Formatting.Indented);
            File.WriteAllText("Objekt.json", jsonText);
            VisaRuta.Text += jsonText;
        }
        private void KnappRaderaClick(object sender, RoutedEventArgs e)
        {
            VisaRuta.Text = string.Empty;
        }
    }
}
