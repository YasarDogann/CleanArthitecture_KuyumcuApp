using CleanArthitecture_KuyumcuApp.Application.Common;
using CleanArthitecture_KuyumcuApp.Domain.Entities;

namespace CleanArthitecture_KuyumcuApp.Application.Abstractions.Services;
public interface ICustomerService
{
    Task<List<Customer>> GetAllCustomersAsync();
    Task<Customer> GetByIdAsync(string id);
    Task<ServiceResponse> AddCustomerAsync(Customer customer);
    Task<ServiceResponse> UpdateCustomerAsync(Customer customer);
    Task<ServiceResponse> DeleteCustomerAsync(string id);
}

// Müşteri ile ilgili servis işlemlerini tanımlar.