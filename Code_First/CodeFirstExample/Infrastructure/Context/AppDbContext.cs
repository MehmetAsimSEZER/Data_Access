using CodeFirstExample.Model.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.Infrastructure.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
            Database.Connection.ConnectionString = @"Server=DESKTOP-6QOAOCO\MSSQLSERVER02;Database = FirstDB;Integrated Security=true";
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Order_Detail> Order_Details { get; set; }  

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}
