using Microsoft.EntityFrameworkCore;

namespace Splitwise.DbEntities
{
    public class SplitwiseDbContext : DbContext
    {
        private readonly string? connectionString;

        public SplitwiseDbContext(DbContextOptions<SplitwiseDbContext> options, IConfiguration configuration) : base(options)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<User>().Property(u => u.Name).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Phone).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Password).IsRequired();
        }
    }
}
