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
        private void Knapp (Object sender,RoutedEventArgs e)
        {
            string text= inputtext.Text;
            int nyckel=0;
            string nyckelString=inputtext.Text;
           /* while (!int.TryParse(nyckelString,out nyckel))
            {
                ouputtext.Text="Du måste mata in ett tal mellan (1-9)Försök igen";
            }*/
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

            outputkrypterad.Text=($"Den krypterade texten blir: {kryptadText}");
        }
    }
}
