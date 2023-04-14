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
            optionsBuilder.UseSqlServer("Data Source=sql5063.site4now.net;Initial Catalog=db_a97950_digitopiaquest;Persist Security Info=True;User ID=db_a97950_digitopiaquest_admin;Password=Kokshe2020;Trust Server Certificate=True");
        }
        //Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;
        //
        //Server=(LocalDb)\\PetProjectsDB;Database=DigitopiaQuest;Integrated Security=True;TrustServerCertificate=true;
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