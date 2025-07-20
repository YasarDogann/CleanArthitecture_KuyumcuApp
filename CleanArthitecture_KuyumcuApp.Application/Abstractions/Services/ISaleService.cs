using CleanArthitecture_KuyumcuApp.Application.Common;
using CleanArthitecture_KuyumcuApp.Domain.Entities;

namespace CleanArthitecture_KuyumcuApp.Application.Abstractions.Services;
public interface ISaleService
{
    Task<List<Sale>> GetAllSalesAsync();
    Task<Sale> GetByIdAsync(string id);
    Task<ServiceResponse> AddSaleAsync(Sale sale);
    Task<ServiceResponse> UpdateSaleAsync(Sale sale);
    Task<ServiceResponse> DeleteSaleAsync(string id);
}
// Satış işlemleri ile ilgili servis tanımları.