using CleanArthitecture_KuyumcuApp.Domain.Entities;

namespace CleanArthitecture_KuyumcuApp.Application.Repositories;
/// <summary>
/// Product Entity’si için yazma işlemlerini tanımlar.
/// IWriteRepository<Product> içerisindeki tüm write metotlarını miras alır.
/// </summary>
public interface IProductWriteRepository : IWriteRepository<Product>
{
    // Product'a özel yazma işlemleri buraya yazılır.
}