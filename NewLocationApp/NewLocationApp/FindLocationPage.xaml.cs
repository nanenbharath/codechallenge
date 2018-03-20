using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewLocationApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FindLocationPage : ContentPage
	{
        private const string Url = "http://api.openweathermap.org/data/2.5/weather?zip=";
        private readonly HttpClient _client = new HttpClient();
		public FindLocationPage ()
		{
			InitializeComponent ();
		}

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            string formatedUrl = Url + ZipCodeEntry.Text + "," + CountryEntry.Text + "&appid=9b563e2b99b44751f6efa27a5aa3c70f";
            string content = await _client.GetStringAsync(formatedUrl);
            JObject json = JObject.Parse(content);
            await Navigation.PushAsync(new MainPage(json));
        }
    }
}