using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BathroomBreak.Models;
using Xamarin.Essentials;
using Newtonsoft.Json;

namespace BathroomBreak.Services
{
    public class RestService
    {
        HttpClient client;
        string PlacesApiBase = "https://maps.googleapis.com/maps/api/place";
        string ApiKey = "AIzaSyALxVcQZDG7p4qh_89RmPJ8pguo-mtYyRI";
        decimal Radius = 500;

        public RestService()
        {
            client = new HttpClient();
        }

        public async Task<List<Bathroom>> Search(Xamarin.Essentials.Location location, String name)
        {
            List<Bathroom> resultList = new List<Bathroom>();
            HttpResponseMessage response = null;
            var jsonResults = new StringBuilder();

            var url = $"{PlacesApiBase}/nearbysearch/json?key={ApiKey}&location={location.Latitude},{location.Longitude}&radius={Radius}&name={name}";

            response = (client.GetAsync(url)).Result;

            // Create a JSON object hierarchy from the results
            var result = await response.Content.ReadAsStringAsync();

            var json = JsonConvert.DeserializeObject<SearchResponse>(result);

            try
            {
                foreach (var place in json?.results)
                {
                    resultList.Add(new Bathroom()
                    {
                        Address = place.vicinity,
                        PlaceName = place.name,
                        Location = new Xamarin.Essentials.Location { Latitude = place.geometry.location.lat, Longitude = place.geometry.location.lng }
                    });
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return resultList;
        }
    }
}
