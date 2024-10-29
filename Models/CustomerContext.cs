using Microsoft.EntityFrameworkCore;

namespace CarQuest.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CarInventory> CarInventories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { ID = 1, FirstName = "John", LastName = "Doe", Email = "abc@xyz.edu" },
                new Customer { ID = 2, FirstName = "Emma", LastName = "Stone", Email = "emma@stone.com" },
                new Customer { ID = 3, FirstName = "Chris", LastName = "Evans", Email = "chris@evans.com" },
                new Customer { ID = 4, FirstName = "Scarlett", LastName = "Johansson", Email = "scarlett@johansson.com" },
                new Customer { ID = 5, FirstName = "Robert", LastName = "Downey Jr.", Email = "robert@downey.com" },
                new Customer { ID = 6, FirstName = "Natalie", LastName = "Portman", Email = "natalie@portman.com" },
                new Customer { ID = 7, FirstName = "Harrison", LastName = "Ford", Email = "harrison@ford.com" },
                new Customer { ID = 8, FirstName = "Denzel", LastName = "Washington", Email = "denzel@washington.com" },
                new Customer { ID = 9, FirstName = "Leonardo", LastName = "DiCaprio", Email = "leonardo@dicaprio.com" }
            );

            // seed data for CarInventory
            modelBuilder.Entity<CarInventory>().HasData(
                new CarInventory { ID = 1, Make = "Toyota", Model = "Camry", Year = 2020, CustomerID = 1 },
                new CarInventory { ID = 2, Make = "Honda", Model = "Civic", Year = 2021, CustomerID = 2 }
            );

            modelBuilder.Entity<CarInventory>()
                .HasOne(ci => ci.Customer)
                .WithMany(c => c.CarInventories)
                .HasForeignKey(ci => ci.CustomerID);
        }
    }
}
