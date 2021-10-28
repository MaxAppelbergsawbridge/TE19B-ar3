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
using System.IO;
using System.Text.RegularExpressions;
namespace new_json
{
    class Kontakt
    {
        public string Namn;
        public string Mobil;
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Gästboksfilen
        string filen = "./kontakter.tsv";

        // Kontaktlistan
        List<string> kontaktLista = new List<string>();

        public MainWindow()
        {
            InitializeComponent();

            // Lägg fokus i första inmatningsrutan
            rutaNamn.Focus();

            // Läs in Kontaktlistan
            if (File.Exists(filen))
            {
                kontaktLista = File.ReadAllLines(filen).ToList();
            }
            else
            {
                rutaStatus.Text = "Filen finns inte";
            }

            // fyll på textrutan för alla kontakter
            foreach (var kontakten in kontaktLista)
            {
                rutaAllaKontakter.Text += kontakten + "\n";
            }
        }

        private void ClickSpara(object sender, RoutedEventArgs e)
        {
            // Hämta namn & mobil
            string namn = rutaNamn.Text;
            string mobil = rutaMobil.Text;

            // KOlla att mobilnr är ok
            Regex regex = new Regex(@"^\(?([0-9]{3})\)?[-]([0-9]{7})$");
            if (regex.IsMatch(mobil))
            {
                // Fyll i rutaAllaKontakter
                rutaAllaKontakter.Text += $"{namn}\t{mobil}\n";

                // Fyll på namnet i listan
                kontaktLista.Add($"{namn}\t{mobil}");

                // Spara ned!
                File.WriteAllLines(filen, kontaktLista);
                Kontakt objekt = new Kontakt();
                objekt.Namn = namn;
                objekt.Mobil = mobil;
                /*{
                    Namn = namn,
                    Mobil = mobil
                };*/
            }
            else
            {
                rutaStatus.Text = "String does NOT contain numbers!";
            }
        }
    }
}
