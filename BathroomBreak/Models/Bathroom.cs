using System;
using Xamarin.Essentials;
using Xamarin.Forms.Maps;

namespace BathroomBreak.Models
{
    public class Bathroom
    {
        public Position Position { get; set; }
        public string Address { get; set; }
        public string PlaceName { get; set; }
        public Location Location { get; set; }

        public Bathroom()
        {
        }
    }
}
