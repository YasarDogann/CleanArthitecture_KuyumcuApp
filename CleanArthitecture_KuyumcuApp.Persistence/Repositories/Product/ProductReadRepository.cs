using CleanArthitecture_KuyumcuApp.Application.Repositories;
using CleanArthitecture_KuyumcuApp.Domain.Entities;
using CleanArthitecture_KuyumcuApp.Persistence.Context;

namespace CleanArthitecture_KuyumcuApp.Persistence.Repositories;
public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
{
    public ProductReadRepository(AppDbContext context) : base(context)
    {
    }
}
