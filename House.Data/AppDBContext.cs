using House.Data.Configuration;
using House.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebAppHouseHelper.Data.Configuration;

namespace House.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
           : base(options)
        {
        }
        public DbSet<Order> Order { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<SupplierOrder> SupplierOrder { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Status> Status { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new OrderEntityConfiguration().Configure(modelBuilder.Entity<Order>());
            new UserEntityConfiguration().Configure(modelBuilder.Entity<User>());
            new FeedbackEntityConfiguration().Configure(modelBuilder.Entity<Feedback>());
            new RoleEntityConfiguration().Configure(modelBuilder.Entity<Role>());
            new SupplierEntityConfiguration().Configure(modelBuilder.Entity<Supplier>());
            new SupplierOrderEntityConfiguration().Configure(modelBuilder.Entity<SupplierOrder>());
            new StatusrderEntityConfiguration().Configure(modelBuilder.Entity<Status>());
            new ServiceEntityConfiguration().Configure(modelBuilder.Entity<Service>());

            modelBuilder.Entity<Order>().HasData(new Order { ID = 1, OrderDate = DateTime.Now });
            modelBuilder.Entity<User>().HasData(new User { ID = 1, FirstName = "", LastName = "", PhoneNumber = "", Email = "", CompanyName = "" });
            modelBuilder.Entity<Service>().HasData(new Service { ID = 1, ServiceName = "", ServicePrice = 1, Description = ""});
            modelBuilder.Entity<Supplier>().HasData(new Supplier { ID = 1, SupplierOrders = null });
            modelBuilder.Entity<Feedback>().HasData(new Feedback {ID = 1, Comment = "", Rate = 1 });
            modelBuilder.Entity<Role>().HasData(new Role {ID = 1, Name = "" });
            modelBuilder.Entity<SupplierOrder>().HasData(new SupplierOrder { ID = 1, OrderPrice = 1 });
            modelBuilder.Entity<Status>().HasData(new Status {ID = 1, Name = "" });
        }
    }
}
