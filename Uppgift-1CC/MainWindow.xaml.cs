using System;
using System.Windows;

namespace Uppgift_1
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
        private void ClickKör(Object sender, RoutedEventArgs e)
        {
            string text = Rutatext.Text;
            int nyckel = 0;
            string nyckelString = Rutanyckel.Text.ToUpper();
            if (!int.TryParse(nyckelString, out nyckel)|| nyckel<0 ||nyckel>9)
            {
                MessageBox.Show("Du måste mata in ett tal mellan (1-9)Försök igen");
            }
            else
            {
                string kryptadText = "";
                for (int i = 0; i < text.Length; i++)
                {
                    char bokstav = text[i];
                    Console.WriteLine($"Bokstaven på position {i} är {bokstav}");

                    int ascii = (int)bokstav;

                    int kryptadAscii = ascii + nyckel;

                    if (kryptadAscii >= 90)
                    {
                        kryptadAscii -= 26;
                    }

                    char kryptadBokstav = (char)(kryptadAscii);
                    Console.WriteLine($"{bokstav} blir {kryptadBokstav}");

                    kryptadText += kryptadBokstav.ToString();
                }

                Rutakrypterad.Text = ($"Den krypterade texten blir: {kryptadText}");
            }
        }
    }
}
