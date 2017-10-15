using InheritanceExample.Entities;
using Microsoft.EntityFrameworkCore;

namespace InheritanceExample
{
    public class MyContext : DbContext
    {
        public DbSet<Hunter> Hunters { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Fox> Foxes { get; set; }
        public DbSet<Wolf> Wolves { get; set; }
        public DbSet<Eagle> Eagles { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
                .HasDiscriminator<string>("Type")
                .HasValue<Fox>("fox")
                .HasValue<Wolf>("wolf")
                .HasValue<Eagle>("eagle");

            modelBuilder.Entity<Wolf>()
                .HasBaseType<Animal>();

            modelBuilder.Entity<Fox>()
                .HasBaseType<Animal>();

            modelBuilder.Entity<Eagle>()
                .HasBaseType<Animal>();

            modelBuilder.Entity<Wolf>()
                .Property(w => w.LegCount)
                .HasColumnName("LegCount");

            modelBuilder.Entity<Fox>()
                .Property(f => f.LegCount)
                .HasColumnName("LegCount");
        }
    }
}
