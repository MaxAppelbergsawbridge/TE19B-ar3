using System.Net.Mime;
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
using RestSharp;
using System.Text.Json;
namespace labb_11._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        class NASA
        {
            public string url { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();
        }
        private void knapp(object sender, RoutedEventArgs e)
        {
            string url = "https://api.nasa.gov/planetary";
            var client = new RestClient(url);
            var request = new RestRequest("apod?api_key=3BnO79NdS2UdwKGLDXDC1QtyGsRm8eqGaNcdJyND"
            , RestSharp.DataFormat.Json);
            var response = client.Get(request);

            NASA Results = new NASA();
            Results = JsonSerializer.Deserialize<NASA>(response.Content);
            image1.Source = new BitmapImage(new Uri(Results.url));
            System.Console.WriteLine();
        }
    }
}
