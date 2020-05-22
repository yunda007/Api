using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Api
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatPage : ContentPage
    {
        public ChatPage()
        {
            InitializeComponent();
            btnenviar.Clicked += Btnenviar_Clicked;
            GetChat();

        }

        private void Btnenviar_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new GuardarPage());
        }

        private async void GetChat()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://192.168.100.6:1000/usuarios/chat");
            var usuarios = JsonConvert.DeserializeObject<List<Mensajes>>(response);
            mostrar_chat.ItemsSource = usuarios;

        }
    }
}