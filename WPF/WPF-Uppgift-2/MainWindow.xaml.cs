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

namespace WPF_Uppgift_2
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
        private void add(Object sender, RoutedEventArgs e)
        {
            string siffra1=tal1.Text;
            string siffra2=tal2.Text;
            int ett=0;
            int två=0;
            if (!int.TryParse(siffra1,out ett ))
            {
                MessageBox.Show("Ange ett tal");
            }
            else if (!int.TryParse(siffra2,out två))
            {
                MessageBox.Show("Ange ett tal");
            }    
            else
            {
            int resultat= ett+två;
            svar.Text= siffra1+"+"+siffra2+"="+resultat;    
            }
        }
        private void minus(Object sender, RoutedEventArgs e)
        {
            string siffra1=tal1.Text;
            string siffra2=tal2.Text;
            int ett=0;
            int två=0;
            if (!int.TryParse(siffra1,out ett ))
            {
                MessageBox.Show("Ange ett tal");
            }
            else if (!int.TryParse(siffra2,out två))
            {
                MessageBox.Show("Ange ett tal");
            }    
            else
            {
            int resultat= ett-två;
            svar.Text= siffra1+"-"+siffra2+"="+resultat;   
        }
        }
        private void dela(Object sender, RoutedEventArgs e)
        {
            string siffra1=tal1.Text;
            string siffra2=tal2.Text;
            int ett=0;
            int två=0;
            if (!int.TryParse(siffra1,out ett ))
            {
                MessageBox.Show("Ange ett tal");
            }
            else if (!int.TryParse(siffra2,out två))
            {
                MessageBox.Show("Ange ett tal");
            }    
            else
            {
            int resultat= ett/två;
            svar.Text= siffra1+"/"+siffra2+"="+resultat;   
            
        }
        }
        private void gånger(Object sender, RoutedEventArgs e)
        {
          string siffra1=tal1.Text;
            string siffra2=tal2.Text;
            int ett=0;
            int två=0;
            if (!int.TryParse(siffra1,out ett ))
            {
                MessageBox.Show("Ange ett tal");
            }
            else if (!int.TryParse(siffra2,out två))
            {
                MessageBox.Show("Ange ett tal");
            }    
            else
            {
            int resultat= ett*två;
            svar.Text= siffra1+"*"+siffra2+"="+resultat;   
            }
        }
    }
}
