using CleanArthitecture_KuyumcuApp.Application.Abstractions.Services;
using CleanArthitecture_KuyumcuApp.Application.Common;
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
    public async Task<ServiceResponse> AddProductAsync(Product product)
    {
        if (product == null)
            return ServiceResponse.Fail("Ürün bilgisi boş olamaz.");

        await _productWriteRepository.AddAsync(product);
        await _productWriteRepository.SaveAsync();
        return ServiceResponse.Ok("Ürün başarıyla eklendi."); ;
    }
    public async Task<ServiceResponse> UpdateProductAsync(Product product)
    {
        if (product == null)
            return ServiceResponse.Fail("Ürün bilgisi eksik.");

        var existing = await _productReadRepository.GetByIdAsync(product.Id.ToString());
        if (existing == null)
            return ServiceResponse.Fail("Güncellenecek ürün bulunamadı.");

        _productWriteRepository.Update(product);
        await _productWriteRepository.SaveAsync();
        return ServiceResponse.Ok("Ürün güncellendi.");
    }

    public async Task<ServiceResponse> DeleteProductAsync(string id)
    {
        var product = await _productReadRepository.GetByIdAsync(id);
        if (product == null)
            return ServiceResponse.Fail("Silinecek ürün bulunamadı.");

        _productWriteRepository.Remove(product);
        await _productWriteRepository.SaveAsync();
        return ServiceResponse.Ok("Ürün silindi.");
    }

}
