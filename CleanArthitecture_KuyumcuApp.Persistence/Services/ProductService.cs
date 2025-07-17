using CleanArthitecture_KuyumcuApp.Application.Abstractions.Services;
using CleanArthitecture_KuyumcuApp.Application.Repositories;
using CleanArthitecture_KuyumcuApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArthitecture_KuyumcuApp.Persistence.Services;
public class ProductService : IProductService
{
    private readonly IProductReadRepository _productReadRepository;
    private readonly IProductWriteRepository _productWriteRepository;

    public ProductService(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
    {
        _productReadRepository = productReadRepository;
        _productWriteRepository = productWriteRepository;
    }
    public async Task<List<Product>> GetAllProductsAsync()   // Tüm ürünleri getir
    {
        return await _productReadRepository.GetAll().ToListAsync();
    }
    public async Task<Product> GetByIdAsync(string id)
    {
        return await _productReadRepository.GetByIdAsync(id);
    }
    public async Task<bool> AddProductAsync(Product product)
    {
        return await _productWriteRepository.AddAsync(product);
    }
    //public  async Task<bool> UpdateProductAsync(Product product)
    //{
    //    return await _productWriteRepository.UpdateAsync(product);
    //}

    //public  async Task<bool> DeleteProductAsync(string id)
    //{
    //    return await _productWriteRepository.DeleteAsync(id);
    //}

}
