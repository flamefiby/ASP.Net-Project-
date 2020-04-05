using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project1.Models;

namespace Project1.Data
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Car{ get; set; }

        public DbSet<Project1.Models.Customer> Customer { get; set; }

        public DbSet<Project1.Models.Insurance> Insurance { get; set; }

    }
}
