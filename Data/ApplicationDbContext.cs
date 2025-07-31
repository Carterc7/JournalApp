using Microsoft.EntityFrameworkCore;
using JournalApp.Models;

namespace JournalApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<JournalPost> JournalPosts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure JournalPost entity
        modelBuilder.Entity<JournalPost>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Title).IsRequired().HasMaxLength(100);
            entity.Property(e => e.Content).IsRequired().HasMaxLength(5000);
            entity.Property(e => e.DateCreated).HasDefaultValueSql("GETDATE()");
            entity.Property(e => e.DateModified).HasDefaultValueSql("GETDATE()");
        });
    }
}