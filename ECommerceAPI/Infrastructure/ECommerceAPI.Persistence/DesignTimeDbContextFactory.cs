using ECommerceAPI.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ECommerceAPI.Persistence;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ECommerceAPIDbContext>
{
    public ECommerceAPIDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<ECommerceAPIDbContext> optionsBuilder = new();
        optionsBuilder.UseNpgsql(Configuration.ConnectionString);
        return new(optionsBuilder.Options);
    }
}
