using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ECommerceWebAPI.Models;
using ECommerceWebAPI.Models.Data;

namespace ECommerceWebAPI.Models.Entity
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext()
        {

        }
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = localhost\\SQLEXPRESS; Database = ECommerceDB; Trusted_Connection = True;");
            }

        }
    }
}
