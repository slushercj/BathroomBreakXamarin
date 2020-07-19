using System;
using System.Collections.Generic;
using System.Linq;
using BathroomBreak.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Essentials;
using System.Threading.Tasks;
using BathroomBreak.Models;
using System.Text;
using BathroomBreak.Services;

namespace BathroomBreak.Views
{
    public partial class Map : ContentPage
    {
        public MapViewModel MapViewModel { get; set; }

        public Map()
        {
            InitializeComponent();

            var location = GetLocation().Result;
            var service = new RestService();
            var result = service.Search(location, String.Join("|", "mcdonalds", "starbucks", "cvs", "walgreens", "ampm")).Result;
            var position = new Position(location.Latitude, location.Longitude);

            MapViewModel = new MapViewModel()
            {
                Bathrooms = new List<Models.Bathroom>()
                {
                    new Models.Bathroom()
                    {
                        PlaceName = "Home",
                        Address = "8737 Fletcher Pkwy #578, La Mesa, CA 91942",
                        Position = position
                    }
                }
            };

            var currentLocation = MapViewModel.Bathrooms.FirstOrDefault();

            BindingContext = currentLocation;

            MainMap.Pins.Add(new Pin
            {
                Label = "Current Location",
                Type = PinType.Generic,
                Position = position
            });

            foreach(var br in result)
            {
                MainMap.Pins.Add(new Pin
                {
                    Label = br.PlaceName,
                    Type = PinType.Place,
                    Address = br.Address,
                    Position = new Position(br.Location.Latitude, br.Location.Longitude)
                });
            }

            MainMap.MoveToRegion(MapSpan.FromCenterAndRadius(currentLocation.Position, new Distance(500)));
        }

        public async Task<Xamarin.Essentials.Location> GetLocation()
        {
            var location = await Geolocation.GetLastKnownLocationAsync();

            return location;
        }

    }
}
