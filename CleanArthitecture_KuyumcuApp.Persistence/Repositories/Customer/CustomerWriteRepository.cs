using CleanArthitecture_KuyumcuApp.Application.Repositories;
using CleanArthitecture_KuyumcuApp.Domain.Entities;
using CleanArthitecture_KuyumcuApp.Persistence.Context;

namespace CleanArthitecture_KuyumcuApp.Persistence.Repositories;
public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
{
    public CustomerWriteRepository(AppDbContext context) : base(context)
    {
    }
}
