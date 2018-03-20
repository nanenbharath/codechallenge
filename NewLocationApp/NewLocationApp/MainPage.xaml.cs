using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json.Linq;

namespace NewLocationApp
{
	public partial class MainPage : ContentPage
	{
        MainViewModel mainViewModel;
		public MainPage(JObject json)
		{
            
            InitializeComponent();
            mainViewModel = new MainViewModel(json);
            BindingContext = mainViewModel;
        }

        public void adddata(object s, EventArgs args)
        {

           Favorite favorite = new Favorite();
           FavouriteDB _favoritedb = new FavouriteDB();
            favorite.Location = mainViewModel.Location;
            favorite.Sunrise = mainViewModel.Sunrise;
            favorite.Sunset = mainViewModel.Sunset;
            favorite.Temperature = mainViewModel.Temperature;
            favorite.WindSpeed = mainViewModel.WindSpeed;
            _favoritedb.AddStusent(favorite);
            DisplayAlert("Notification", "Saved Successfully", "Yes");
        }
    }
}
