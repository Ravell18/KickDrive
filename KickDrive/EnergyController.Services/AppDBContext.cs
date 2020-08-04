using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EnergyController.Models;

namespace EnergyController.Services
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        { 
        }
        public DbSet<Routes> Route { get; set; }
        public DbSet<Vehicles> Vehicle { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ReportRoute> ReportRoutes { get; set; }


    }

}
