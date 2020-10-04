﻿using OdeToFood.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public List<Restaurant> Restaurants { get; }

        public InMemoryRestaurantData()
        {
            Restaurants = new List<Restaurant>
            {
                new Restaurant{Id=1,Name="Pizza",Cuisine=CuisineType.Italian },
                new Restaurant{Id=2,Name="Sushi",Cuisine=CuisineType.Georgian }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return Restaurants.OrderBy(n => n.Name);
        }

        public Restaurant Get(int id)
        {
            return Restaurants.FirstOrDefault(s => s.Id == id);
        }

        public void Add(Restaurant restaurant)
        {
            Restaurants.Add(restaurant);
        }
        public void Update(Restaurant restaurant)
        {
            var existing = Get(restaurant.Id);
            if (existing != null)
            {
                existing.Name = restaurant.Name;
                existing.Id = restaurant.Id;
            }
        }

        public void Delete(int id)
        {
            var restaurant = Get(id);
            if (restaurant != null)
            {
                Restaurants.Remove(restaurant);
            }
        }
    }
}
