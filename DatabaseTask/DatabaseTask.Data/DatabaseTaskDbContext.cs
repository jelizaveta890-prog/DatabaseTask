using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Data;

public class DatabaseTaskDbContext : DbContext
{
    public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
        : base(options)
    {
    }

    public DbSet<Company> Companies { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Child> Children { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<ItemOwnedByCompany> ItemsOwnedByCompany { get; set; }
    public DbSet<Borrow> Borrows { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Intranet> Intranets { get; set; }
    public DbSet<Rank> Ranks { get; set; }
    public DbSet<HealthCare> HealthCares { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Borrow>()
            .HasOne(b => b.ItemOwnedByCompany)
            .WithMany(i => i.Borrows)
            .HasForeignKey(b => b.ItemOwnedByCompanyId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
