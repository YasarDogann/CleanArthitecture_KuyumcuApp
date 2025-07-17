using CleanArthitecture_KuyumcuApp.Domain.Entities;

namespace CleanArthitecture_KuyumcuApp.Application.Abstractions.Services;
public interface IProductService
{
    Task<List<Product>> GetAllProductsAsync();
    Task<Product> GetByIdAsync(string id);
    Task<bool> AddProductAsync(Product product);
    //Task<bool> UpdateProductAsync(Product product);
    //Task<bool> DeleteProductAsync(string id);
}

// Ürün ile ilgili servis işlemlerini tanımlar.