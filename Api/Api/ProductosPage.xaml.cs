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
    public partial class ProductosPage : ContentPage
    {
        public ProductosPage()
        {
            InitializeComponent();
            GetProductos();
            btnagregar.Clicked += Btnagregar_Clicked;
        }

        private void Btnagregar_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new AgregarPage());
        }

        private async void GetProductos()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://192.168.100.6:1000/productos/listar");
            var productos = JsonConvert.DeserializeObject<List<Productos>>(response);
            mostrar_producto.ItemsSource = productos;

        }
    }
}