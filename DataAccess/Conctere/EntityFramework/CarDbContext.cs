
using Entities.Conctere;
using Entity.Conctere;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Conctere.EntityFramework
{
   public class CarDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CarDataBase;Trusted_Connection=true");
        }

        public DbSet<Car> CarsData { get; set; }
      

    }
}
