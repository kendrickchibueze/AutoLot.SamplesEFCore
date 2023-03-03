using AutoLot.SamplesDAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLot.SamplesDAL
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }




        //Note the DbSet<T> property in the ApplicationDbContext class. This informs EF Core that the Car
        //class maps to the Cars table in the database

        //To make EF Core aware that an entity class is part of the object model, add a DbSet<T> property for the entity
        public DbSet<Car> Cars { get; set; }

        public DbSet<Make> Makes { get; set; }

        public DbSet<Radio> Radios { get; set; }

        public IEnumerable<Driver> Drivers { get; set; } = new List<Driver>();

        public DbSet<CarDriver> CarsToDrivers { get; set; }



        //For TPT, we use fluent Api to tell EFCORE to shift from the default TPH
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Fluent API calls go here
        //    modelBuilder.Entity<BaseEntity>().ToTable("BaseEntities");
        //    modelBuilder.Entity<Car>().ToTable("Cars");

        //}






        //The Fluent API is used to inform EF Core of the backing field.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            new CarConfiguration().Configure(modelBuilder.Entity<Car>());
            new RadioConfiguration().Configure(modelBuilder.Entity<Radio>());
            new DriverConfiguration().Configure(modelBuilder.Entity<Driver>());
        }
    }
}


//The Fluent API is the most powerful of all three. Whether 
//you use data annotations or the Fluent API, know that data annotations overrule the built-in conventions,
//and the methods of the Fluent API overrule everything.