using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;

namespace Api
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CanceladosPage : ContentPage
    {
        public CanceladosPage()
        {
            InitializeComponent();
            GetCancelados();
        }
        private async void GetCancelados()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://192.168.100.6:1000/pedidos/cancelado");
            var cancelados = JsonConvert.DeserializeObject<List<Cancelados>>(response);
            cancelado.ItemsSource = cancelados;

        }
    }
}