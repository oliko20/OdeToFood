using OdeToFood.Core;
using System.Collections.Generic;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();

    }
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>
            {
                new Restaurant {Id = 1, Name = "Res1", Location = "Tbilisi", Cuisine = CuisineType.Georgian},
                new Restaurant {Id = 2, Name = "Res2", Location = "Borjomi", Cuisine = CuisineType.Italian}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants;
        }
    }
}
