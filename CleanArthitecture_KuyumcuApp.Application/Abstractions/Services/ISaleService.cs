using CleanArthitecture_KuyumcuApp.Domain.Entities;

namespace CleanArthitecture_KuyumcuApp.Application.Abstractions.Services;
public interface ISaleService
{
    Task<List<Sale>> GetAllSalesAsync();
    Task<Sale> GetByIdAsync(string id);
    Task<bool> AddSaleAsync(Sale sale);
    Task<bool> UpdateSaleAsync(Sale sale);
    Task<bool> DeleteSaleAsync(string id);
}
// Satış işlemleri ile ilgili servis tanımları.