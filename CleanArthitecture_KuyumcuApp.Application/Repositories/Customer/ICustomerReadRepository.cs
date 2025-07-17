using CleanArthitecture_KuyumcuApp.Domain.Entities;

namespace CleanArthitecture_KuyumcuApp.Application.Repositories;
/// <summary>
/// Customer Entity’si için okuma işlemlerini tanımlar.
/// </summary>
public interface ICustomerReadRepository : IReadRepository<Customer>
{
    // Customer'a özel okuma işlemleri buraya yazılır.
}
