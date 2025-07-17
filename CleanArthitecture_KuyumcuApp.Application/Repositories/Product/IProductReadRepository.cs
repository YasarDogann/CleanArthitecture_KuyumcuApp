using CleanArthitecture_KuyumcuApp.Domain.Entities;

namespace CleanArthitecture_KuyumcuApp.Application.Repositories;
/// <summary>
/// Product Entity’si için okuma işlemlerini tanımlar.
/// IReadRepository<Product> içerisindeki tüm read metotlarını miras alır.
/// </summary>
public interface IProductReadRepository : IReadRepository<Product>
{
    // Product'a özel okuma işlemleri buraya yazılır.
}
