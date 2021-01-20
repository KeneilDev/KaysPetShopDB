using Kays_Pets_UI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kays_Pets_UI.Data
{
    //DbContext represents a session with the database 
   public class KaysPetsContext : DbContext
    {
        public KaysPetsContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }

    }
}
