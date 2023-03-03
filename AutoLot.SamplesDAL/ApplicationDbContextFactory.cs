using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLot.SamplesDAL
{
    


        public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
        {

        public ApplicationDbContextFactory()
        {

        }
            public ApplicationDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
                var connectionString = @"Data Source=DESKTOP-HTUFPR1\SQLEXPRESS; Initial Catalog=AutoLotDB; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
           
                optionsBuilder.UseSqlServer(connectionString);
                Console.WriteLine(connectionString);
                return new ApplicationDbContext(optionsBuilder.Options);
            }
        }
    
}
