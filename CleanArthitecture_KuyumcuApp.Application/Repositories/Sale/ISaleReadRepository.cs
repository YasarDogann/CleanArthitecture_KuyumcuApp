using CleanArthitecture_KuyumcuApp.Domain.Entities;

namespace CleanArthitecture_KuyumcuApp.Application.Repositories;
/// <summary>
/// Order Entity’si için okuma işlemlerini tanımlar.
/// </summary>
public interface ISaleReadRepository : IReadRepository<Sale>
{
    // Order'a özel okuma işlemleri buraya yazılır.
}
