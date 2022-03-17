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

namespace labb_19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Media> Medier = new List<Media>();
        public MainWindow()
        {
            InitializeComponent();

        }
        public class Media
        {
            public string Titel { get; set; }
            public virtual string TillText()
            {
                return $"{Titel}";
            }
        }
        public class Film : Media
        {
            public string Regissör { get; set; }
            public int Längd { get; set; }
            public Film(string titel, string regissör, string längd)
            {
                Titel = titel;
                Regissör = regissör;
                Längd = int.Parse(längd);
            }
            public override string TillText()
            {
                return $"{Titel}({Regissör} {Längd})";
            }
        }
        public class Bok : Media
        {
            public string Författare { get; set; }
            public int Antalsidor { get; set; }
            public Bok(string titel, string författare, string antalSidor)
            {
                Titel = titel;
                Författare = författare;
                Antalsidor = int.Parse(antalSidor);
            }
            public override string TillText()
            {
                return $"{Titel}({Författare}{Antalsidor})";
            }
        }
        public void KlickSparaFilm(object sender, RoutedEventArgs e)
        {
            Film film = new Film(rutaFilmtitel.Text, rutaRegissör.Text, rutaLängdFilm.Text);
            Medier.Add(film);
            //string json = JsonConvert.SerializeObject(Medier, Formatting.Indented);
            rutaResultat.Items.Add(film.TillText());
        }
        public void KlickSparaBok(object sender, RoutedEventArgs e)
        {
            Bok bok = new Bok(rutaBoktitel.Text, rutaFörfattare.Text, rutaLängdBok.Text);
            rutaResultat.Items.Add(bok.TillText());
            Medier.Add(bok);
        }
        public void CheckaRadio(object sender, RoutedEventArgs e)
        {
            rutaResultat.Items.Clear();
            string svar = ((RadioButton)sender).Name;
            foreach (var item in Medier)
            {
                switch (svar)
                {
                    case "böcker":
                        if (item is Bok)
                        {
                            rutaResultat.Items.Add(item.TillText());
                        }
                        break;
                    case "filmer":
                        if (item is Film)
                        {
                            rutaResultat.Items.Add(item.TillText());
                        }
                        break;
                    default:
                        rutaResultat.Items.Add(item.TillText());
                        break;
                }
            }
        }
    }
}
