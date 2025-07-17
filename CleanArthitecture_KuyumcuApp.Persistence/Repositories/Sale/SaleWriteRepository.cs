using CleanArthitecture_KuyumcuApp.Application.Repositories;
using CleanArthitecture_KuyumcuApp.Domain.Entities;
using CleanArthitecture_KuyumcuApp.Persistence.Context;

namespace CleanArthitecture_KuyumcuApp.Persistence.Repositories;
public class SaleWriteRepository : WriteRepository<Sale>, ISaleWriteRepository
{
    public SaleWriteRepository(AppDbContext context) : base(context)
    {
    }
}
