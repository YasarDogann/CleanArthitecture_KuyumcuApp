using CleanArthitecture_KuyumcuApp.Application.Common;
using CleanArthitecture_KuyumcuApp.Domain.Entities;

namespace CleanArthitecture_KuyumcuApp.Application.Abstractions.Services;
public interface ISaleItemService
{
    Task<List<SaleItem>> GetAllSaleItemsAsync();
    Task<SaleItem> GetByIdAsync(string id);
    Task<ServiceResponse> AddSaleItemAsync(SaleItem saleItem);
    Task<ServiceResponse> UpdateSaleItemAsync(SaleItem saleItem);
    Task<ServiceResponse> DeleteSaleItemAsync(string id);
}
// Satış kalemleri (ürün bazlı satış detayı) ile ilgili servis tanımları.