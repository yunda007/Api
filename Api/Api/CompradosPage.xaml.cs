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
    public partial class CompradosPage : ContentPage
    {
        public CompradosPage()
        {
            InitializeComponent();
            GetComprados();
        }
        private async void GetComprados()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://192.168.100.6:1000/pedidos/comprados");
            var compradoss = JsonConvert.DeserializeObject<List<Comprados>>(response);
            comprados.ItemsSource = compradoss;

        }

    }
}