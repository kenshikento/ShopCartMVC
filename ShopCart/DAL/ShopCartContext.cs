using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopCart.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure;

namespace ShopCart.DAL
{
    public class ShopCartContext : DbContext
    {
        public ShopCartContext() : base("ShopCartContext"){}

        public DbSet<QuantityItem> QuantityItem { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}