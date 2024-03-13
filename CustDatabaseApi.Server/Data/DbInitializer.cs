using CustDatabaseApi.Server.Models; // Adjust the namespace based on your project
using Microsoft.EntityFrameworkCore;

namespace CustDatabaseApi.Server.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            // Make sure the database is created
            context.Database.EnsureCreated();

            // Check if there are any customers already in the database
            if (context.Customers.Any())
            {
                return; // DB has been seeded
            }

            var customers = new Customer[]
{
    new Customer{FirstName="John", LastName="Doe", Email="johndoe@example.com"},
    new Customer{FirstName="Jane", LastName="Doe", Email="janedoe@example.com"}
    // Add more customers as needed
};

            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();
        }
    }
}
