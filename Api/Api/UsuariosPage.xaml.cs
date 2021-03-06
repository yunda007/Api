﻿using System;
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
    public partial class UsuariosPage : ContentPage
    {
        public UsuariosPage()
        {
            InitializeComponent();
            GetUsuarios();
            btnmensajes.Clicked += Btnmensajes_Clicked;
            btnchat.Clicked += Btnchat_Clicked;
        }

        private void Btnchat_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ChatPage());
        }

        private void Btnmensajes_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new MensajesPage());
        }

        private async void GetUsuarios()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://192.168.100.6:1000/usuarios/listar");
            var usuarios = JsonConvert.DeserializeObject<List<Usuarios>>(response);
            mostrar_usuario.ItemsSource = usuarios;

        }
    }
}