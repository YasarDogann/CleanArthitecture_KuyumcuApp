using CleanArthitecture_KuyumcuApp.Domain.Entities;

namespace CleanArthitecture_KuyumcuApp.Application.Repositories;
/// <summary>
/// Customer Entity’si için yazma işlemlerini tanımlar.
/// </summary>
public interface ICustomerWriteRepository : IWriteRepository<Customer>
{
    // Customer'a özel yazma işlemleri buraya yazılır.
}