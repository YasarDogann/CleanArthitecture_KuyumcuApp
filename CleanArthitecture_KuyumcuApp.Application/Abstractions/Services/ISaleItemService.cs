using CleanArthitecture_KuyumcuApp.Domain.Entities;

namespace CleanArthitecture_KuyumcuApp.Application.Abstractions.Services;
public interface ISaleItemService
{
    Task<List<SaleItem>> GetAllSaleItemsAsync();
    Task<SaleItem> GetByIdAsync(string id);
    Task<bool> AddSaleItemAsync(SaleItem saleItem);
    Task<bool> UpdateSaleItemAsync(SaleItem saleItem);
    Task<bool> DeleteSaleItemAsync(string id);
}
// Satış kalemleri (ürün bazlı satış detayı) ile ilgili servis tanımları.