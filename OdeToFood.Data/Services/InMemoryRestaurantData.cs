using OdeToFood.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>
            {
                new Restaurant{Id=1,Name="Pizza",Cuisine=CuisineType.Italian },
                new Restaurant{Id=2,Name="Sushi",Cuisine=CuisineType.Georgian }
            };
        }

        public List<Restaurant> Restaurants => restaurants;

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(n => n.Name);
        }
    }
}
