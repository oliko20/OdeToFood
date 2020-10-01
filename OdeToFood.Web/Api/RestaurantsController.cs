using OdeToFood.Data.Models;
using OdeToFood.Data.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace OdeToFood.Web.Api
{
    public class RestaurantsController : ApiController
    {
        public IRestaurantData RestaurantsData { get; }

        public RestaurantsController(IRestaurantData restaurantsData)
        {
            RestaurantsData = restaurantsData;
        }
        public IEnumerable<Restaurant> Get()
        { var model = RestaurantsData.GetAll();
            return model;
        }
    }
}
