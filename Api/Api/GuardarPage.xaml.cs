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
    public partial class GuardarPage : ContentPage
    {
        public GuardarPage()
        {
            InitializeComponent();
            btnSaves.Clicked += BtnSaves_Clicked;
        }

        private async void BtnSaves_Clicked(object sender, EventArgs e)
        {
            Mensajes mensaje = new Mensajes()
            {
                contacto = Entcontacto.Text,
                mensajes = Entcontacto.Text,

            };

            var json = JsonConvert.SerializeObject(mensaje);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();

            var result = await client.PostAsync("http://192.168.100.6:1000/usuarios/mensaje", content);

            if (result.StatusCode == HttpStatusCode.Created)
            {
                await DisplayAlert("Hey", "Your record has been added", "Alright");
            }
        }
    }
}