using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Concrete.EntityFramework
{
    //Context: DB tabloları ile proje classlarını bağlamak
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=Northwind; Trusted_Connection=true;", options =>
             {
                 options.EnableRetryOnFailure();
                 //options.EnableRetryOnFailure(
                 //    maxRetryCount: 3,
                 //    maxRetryDelay: TimeSpan.FromSeconds(10),
                 //    errorNumbersToAdd: new List<int> { 4060 }); //additional error codes to treat as transient
             });
            //optionsBuilder.LogTo(
            //    filter: (eventId, level) => eventId.Id == CoreEventId.ExecutionStrategyRetrying,
            //    logger: (eventData) =>
            //    {
            //        var retryEventData = eventData as ExecutionStrategyEventData;
            //        var exceptions = retryEventData.ExceptionsEncountered;
            //        Console.WriteLine($"Retry #{exceptions.Count} with delay {retryEventData.Delay} due to error: {exceptions.Last().Message}");
            //    });
        }

        //Hangi tablonun hangi classlarla eşleşeceği tanımlanır.
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
