﻿using Microsoft.EntityFrameworkCore;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public class OdeToFoodDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public OdeToFoodDbContext(DbContextOptions<OdeToFoodDbContext> dbContext)
            : base(dbContext)
        {

        }
    }
}
