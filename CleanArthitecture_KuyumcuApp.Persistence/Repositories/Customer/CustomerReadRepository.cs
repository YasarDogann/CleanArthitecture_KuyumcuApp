using CleanArthitecture_KuyumcuApp.Application.Repositories;
using CleanArthitecture_KuyumcuApp.Domain.Entities;
using CleanArthitecture_KuyumcuApp.Persistence.Context;

namespace CleanArthitecture_KuyumcuApp.Persistence.Repositories;
public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
{
    public CustomerReadRepository(AppDbContext context) : base(context)
    {
    }
}
