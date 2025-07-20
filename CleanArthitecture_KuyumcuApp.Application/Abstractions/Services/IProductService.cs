using CleanArthitecture_KuyumcuApp.Application.Common;
using CleanArthitecture_KuyumcuApp.Domain.Entities;

namespace CleanArthitecture_KuyumcuApp.Application.Abstractions.Services;
public interface IProductService
{
    Task<List<Product>> GetAllProductsAsync();
    Task<Product> GetByIdAsync(string id);
    Task<ServiceResponse> AddProductAsync(Product product);
    Task<ServiceResponse> UpdateProductAsync(Product product);
    Task<ServiceResponse> DeleteProductAsync(string id);
}

// Ürün ile ilgili servis işlemlerini tanımlar.