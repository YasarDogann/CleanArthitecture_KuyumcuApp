using CleanArthitecture_KuyumcuApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArthitecture_KuyumcuApp.Persistence.Context;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {}

    // Tabloları temsil eder : DbSet<T>
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Sale> Sales => Set<Sale>();
    public DbSet<SaleItem> SaleItems => Set<SaleItem>();
}
