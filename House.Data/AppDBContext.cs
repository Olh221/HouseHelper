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

            modelBuilder.Entity<Role>().HasData(new List<Role> { new Role { ID = 1, Name = "Admin" }, new Role { ID = 2, Name = "User" } });
            modelBuilder.Entity<User>().HasData(new User { ID = 1, PasswordHash = "dfdgg", FirstName = "Admin", LastName = "Admin", PhoneNumber = "6666666", Email = "admin.admin@admin.admin", CompanyName = "Admin", RoleID = 1 });
            modelBuilder.Entity<Status>().HasData(new List<Status> { new Status { ID = 1, Name = "Paid" }, new Status { ID = 2, Name = "In work" }, new Status { ID = 3, Name = "Completed" } });
        }
    }
}
