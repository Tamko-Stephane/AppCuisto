using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace AppCuisto_MVC.Models
{
    public class AppCuistoDB:DbContext
    {
        
        public DbSet<Cooker> Cookers { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Favorite> Favorites { get; set; }

        //public DbSet<CustomerReference> Customers { get; set; }
        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<SalaryHistory> SalaryHistories { get; set; }
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<LineItem> LineItems { get; set; }
        //public DbSet<Shipment> Shipments { get; set; }
        //public DbSet<Shipper> Shippers { get; set; }
        //public DbSet<ShippingAddress> ShippingAddresses { get; set; }
        //public DbSet<Payment> Payments { get; set; }
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<Promotion> Promotions { get; set; }
        //public DbSet<Return> Returns { get; set; }
        //public DbSet<Product> Products { get; set; }

    }
}