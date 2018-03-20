using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;
using Newtonsoft.Json.Linq;

namespace NewLocationApp
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Pin> _pinCollection = new ObservableCollection<Pin>();
        public ObservableCollection<Pin> PinCollection
        {
            get
            {
                return _pinCollection;
            }
            set
            {
                _pinCollection = value; OnPropertyChanged();
            }
        }

        private Position _myPosition;
        public Position MyPosition
        {
            get
            {
                return _myPosition;
            }
            set
            {
                _myPosition = value;
                OnPropertyChanged();
            }
        }

        public double Lat { get; set; }
        public double Long { get; set; }

        public string Location { get; set; }
        public string Temperature { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
        public string WindSpeed { get; set; }
        public string Humidity { get; set; }





        public MainViewModel(JObject json)
        {
            string latitude = (string)json["coord"]["lat"];
            string longitude = (string)json["coord"]["lon"];
            Location = (string)json["name"];
            Temperature= (string)json["main"]["temp"];
            Sunrise= (string)json["sys"]["sunrise"];
            Sunset= (string)json["sys"]["sunset"];
            WindSpeed = (string)json["wind"]["speed"];
            Humidity= (string)json["main"]["humidity"];

            MyPosition = new Position(double.Parse(latitude), double.Parse(longitude));
            PinCollection.Add(new Pin() { Position = MyPosition, Type = PinType.Generic, Label = "I'm a Pin" });

        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
