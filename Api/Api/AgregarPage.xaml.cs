using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Api
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgregarPage : ContentPage
    {
        public AgregarPage()
        {
            InitializeComponent();
            btnSave.Clicked += BtnSave_Clicked;
        }

        private async void BtnSave_Clicked(object sender, EventArgs e)
        {
            Productos productos = new Productos()
            {
                Nombre = EntNombre.Text,
                Valor = Convert.ToInt32(EntValor.Text),
                Codigo = EntCodigo.Text,
                Imagen = EntImagen.Text
            };

            var json = JsonConvert.SerializeObject(productos);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();

            var result = await client.PostAsync("http://192.168.100.6:1000/productos/insertar", content);

            if (result.StatusCode == HttpStatusCode.Created)
            {
                await DisplayAlert("Hey", "Your record has been added", "Alright");
            }
        }

  
    }
}