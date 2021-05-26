using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Colman_Final_Web_Project.Models;

namespace Colman_Final_Web_Project.Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Colman_Final_Web_Project.Models.Customers> Customers { get; set; }

        public DbSet<Colman_Final_Web_Project.Models.Categories> Categories { get; set; }

        public DbSet<Colman_Final_Web_Project.Models.Products> Products { get; set; }

        public DbSet<Colman_Final_Web_Project.Models.Purchases> Purchases { get; set; }

        public DbSet<Colman_Final_Web_Project.Models.Suppliers> Suppliers { get; set; }
    }
}
