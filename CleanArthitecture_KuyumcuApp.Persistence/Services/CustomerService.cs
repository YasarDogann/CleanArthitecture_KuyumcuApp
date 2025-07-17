using CleanArthitecture_KuyumcuApp.Application.Abstractions.Services;
using CleanArthitecture_KuyumcuApp.Application.Repositories;
using CleanArthitecture_KuyumcuApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArthitecture_KuyumcuApp.Persistence.Services;
public class CustomerService : ICustomerService
{
    private readonly ICustomerReadRepository _customerReadRepository;
    private readonly ICustomerWriteRepository _customerWriteRepository;

    public CustomerService(ICustomerReadRepository customerReadRepository, ICustomerWriteRepository customerWriteRepository)
    {
        _customerReadRepository = customerReadRepository;
        _customerWriteRepository = customerWriteRepository;
    }

    public async Task<List<Customer>> GetAllCustomersAsync()  // Tüm müşterileri getirir.
    {
        // GetAll() IQueryable döner. ToListAsync ile sorgu çalıştırılır.
        return await _customerReadRepository.GetAll().ToListAsync();
    }

    public async Task<Customer> GetByIdAsync(string id)
    {
        return await _customerReadRepository.GetByIdAsync(id);
    }

    public async Task<bool> AddCustomerAsync(Customer customer)
    {
        var result = await _customerWriteRepository.AddAsync(customer);
        await _customerWriteRepository.SaveAsync();
        return result;
    }
    public async Task<bool> UpdateCustomerAsync(Customer customer)
    {
        var result = _customerWriteRepository.Update(customer);
        await _customerWriteRepository.SaveAsync();
        return result;
    }
    public async Task<bool> DeleteCustomerAsync(string id)
    {
        var result = await _customerWriteRepository.RemoveAsync(id);
        await _customerWriteRepository.SaveAsync();
        return result;
    }
}
