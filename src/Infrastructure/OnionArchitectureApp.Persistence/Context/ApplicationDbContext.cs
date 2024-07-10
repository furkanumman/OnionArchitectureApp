using Microsoft.EntityFrameworkCore;
using OnionArchitectureApp.Domain.Common;
using OnionArchitectureApp.Domain.Entities;

namespace OnionArchitectureApp.Persistence.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in ChangeTracker.Entries<BaseEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreateDate = DateTime.Now;
                    break;

                default: break;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }

}
