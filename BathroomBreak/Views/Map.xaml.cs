using System;
using System.Collections.Generic;
using System.Linq;
using BathroomBreak.ViewModels;
using Xamarin.Forms;

namespace BathroomBreak.Views
{
    public partial class Map : ContentPage
    {
        public MapViewModel MapViewModel { get; set; }

        public Map()
        {
            InitializeComponent();

            MapViewModel = new MapViewModel()
            {
                Bathrooms = new List<Models.Bathroom>()
                {
                    new Models.Bathroom()
                    {
                        PlaceName = "Home",
                        Address = "8737 Fletcher Pkwy #578, La Mesa, CA 91942",
                        Position = new Xamarin.Forms.Maps.Position(32.783510, -117.009890)
                    }
                }
            };

            BindingContext = MapViewModel.Bathrooms.FirstOrDefault();
        }
    }
}
