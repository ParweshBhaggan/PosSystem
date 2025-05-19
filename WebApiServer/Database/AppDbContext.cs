using Microsoft.EntityFrameworkCore;
using WebApiServer.Models;

namespace WebApiServer.Database
{
    public class AppDbContext : DbContext
    {
        private readonly string _databaseName = "PoS_System";

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Database arugments
            string host = "localhost";
            string port = "5432";
            string database = "postgres";
            string username = "postgres";
            string password = "Parwesh";
            string connectionBuilder = $"Host={host};Port={port};Database={database};Username={username};Password={password};";


            optionsBuilder.UseNpgsql(connectionBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(_databaseName);
        }

    }
}
