using BookStore.Data;
using Microsoft.EntityFrameworkCore;

namespace BookStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new BookStoreContext();
            //Pending Migrations
            context.Database.Migrate();
            Console.WriteLine("Database created successfully!");
            Console.WriteLine($"Database Name: {context.Database.GetDbConnection().Database}");

            
            Console.WriteLine($"Books table: {context.Books.Count()} records");
            Console.WriteLine($"Authors table: {context.Authors.Count()} records");
            Console.WriteLine($"Categories table: {context.Categories.Count()} records");
        }
    }
}
