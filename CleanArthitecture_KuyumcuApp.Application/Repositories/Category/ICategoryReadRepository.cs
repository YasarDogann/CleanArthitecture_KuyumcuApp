using CleanArthitecture_KuyumcuApp.Domain.Entities;

namespace CleanArthitecture_KuyumcuApp.Application.Repositories;
/// <summary>
/// Category Entity'si için okuma işlemlerini tanımlar.
/// IReadRepository<Category> içerisindeki tüm okuma metotlarını miras alır.
/// </summary>
public interface ICategoryReadRepository : IReadRepository<Category>
{
    // Buraya yalnızca Category'ye özel ek sorgular gelecektir.
    // Örn: Task<Category> GetCategoryWithProductsAsync(Guid id);
}
