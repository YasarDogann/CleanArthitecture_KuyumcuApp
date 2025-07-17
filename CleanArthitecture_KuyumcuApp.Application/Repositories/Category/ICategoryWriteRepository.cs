using CleanArthitecture_KuyumcuApp.Domain.Entities;

namespace CleanArthitecture_KuyumcuApp.Application.Repositories;
/// <summary>
/// Category Entity'si için yazma işlemlerini tanımlar.
/// IWriteRepository<Category> içerisindeki tüm yazma metotlarını miras alır.
/// </summary>
public interface ICategoryWriteRepository : IWriteRepository<Category>
{
    // Buraya yalnızca Category'ye özel ek yazma işlemleri eklenebilir.
    // Şimdilik gerek yok ama ihtiyaç duyulursa eklenebilir.
}
