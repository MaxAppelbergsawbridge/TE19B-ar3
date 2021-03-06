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
            VisaRuta.Focus();
            string jsonText = JsonConvert.SerializeObject(ListaObjekt, Formatting.Indented);
            File.WriteAllText("Objekt.json", jsonText);
            foreach (var item in ListaObjekt)
            {
                VisaRuta.Items.Add(jsonText);
            }
        }
        private void KnappSparaClick(object sender, RoutedEventArgs e)
        {
            Genre genre = new Genre(NamnRuta.Text, MängdRuta.Text, DatumRuta.Text, NyCategori.Text, InfoRuta.Text);
            ListaObjekt.Add(genre);
            string jsonText = JsonConvert.SerializeObject(ListaObjekt, Formatting.Indented);
            File.WriteAllText("Objekt.json", jsonText);
            VisaRuta.Items.Add(jsonText);
        }
        private void KnappRaderaClick(object sender, RoutedEventArgs e)
        {
            VisaRuta.Items.Clear();
        }
        private void NyCategoriClick(object sender, RoutedEventArgs e)
        {
            List<string> _ListAvEgenskaper = new List<string>();
            string categori = NyCategori.Text;
            Genre genre = new Genre(NamnRuta.Text, MängdRuta.Text, categori, InfoRuta.Text, DatumRuta.Text);
            _ListAvEgenskaper.Add(categori);
            foreach (var item in _ListAvEgenskaper)
            {
                TextBox nycategori = new TextBox();
                nycategori.Text = item;
            }
        }
    }
}
