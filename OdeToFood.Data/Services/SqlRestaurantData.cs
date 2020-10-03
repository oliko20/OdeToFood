using OdeToFood.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        public OdeToFoodDbContext OdeToFoodDbContext { get; }

        public SqlRestaurantData(OdeToFoodDbContext db)
        {
            OdeToFoodDbContext = db;
        }

        public void Add(Restaurant restaurant)
        {
            OdeToFoodDbContext.Add(restaurant);
            OdeToFoodDbContext.SaveChanges();
        }

        public Restaurant Get(int id)
        {
            return OdeToFoodDbContext.Restaurants.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return OdeToFoodDbContext.Restaurants.Select(s => s);
        }

        public void Update(Restaurant restaurant)
        {
            var r = Get(restaurant.Id);
            r.Name = restaurant.Name;
            OdeToFoodDbContext.SaveChanges();
        }
    }
}
