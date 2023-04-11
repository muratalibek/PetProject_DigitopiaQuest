using DigitopiaQuest.Models;
using Microsoft.EntityFrameworkCore;

namespace DigitopiaQuest.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(LocalDb)\\PetProjectsDB;Database=DigitopiaQuest;Integrated Security=True;TrustServerCertificate=true;");
        } 
        //Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;

        protected override void OnModelCreating(ModelBuilder optionsBuilder)
        {
            optionsBuilder.Entity<List<string>>()
                .HasNoKey();
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}