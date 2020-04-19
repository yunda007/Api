using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;

namespace Api
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasvendidosPage : ContentPage
    {

        public MasvendidosPage()
        {   
            InitializeComponent();
            GetMasvendidos();   
        }
        private async void GetMasvendidos()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://192.168.100.6:1000/pedidos/masVendidos");
            var Masvendido = JsonConvert.DeserializeObject<List<Masvendidos>>(response);
            masvendidos.ItemsSource = Masvendido;

        }

    }
}