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
    public partial class PedidosPage : ContentPage
    {
        public PedidosPage()
        {
            InitializeComponent();
            GetPedidos();
            btnvendidos.Clicked += Btnvendidos_Clicked;
            btncomprados.Clicked += Btncomprados_Clicked;
        }

        private void Btncomprados_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new CompradosPage());
        }

        private void Btnvendidos_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new MasvendidosPage());
        }

            private async void GetPedidos()
            {
                HttpClient client = new HttpClient();
                var response = await client.GetStringAsync("http://192.168.100.6:1000/pedidos/listar");
                var pedidos = JsonConvert.DeserializeObject<List<Pedidos>>(response);
                mostrar_pedidos.ItemsSource = pedidos;

            }

    }
}