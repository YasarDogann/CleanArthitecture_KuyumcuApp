using CleanArthitecture_KuyumcuApp.Application.Abstractions.Services;
using CleanArthitecture_KuyumcuApp.Application.Common;
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

    public async Task<ServiceResponse> AddCustomerAsync(Customer customer)
    {
        if (customer is null)
            return ServiceResponse.Fail("Müşteri bilgisi boş olamaz.");

        await _customerWriteRepository.AddAsync(customer);
        await _customerWriteRepository.SaveAsync();
        return ServiceResponse.Ok("Müşteri başarıyla eklendi.");
    }
    public async Task<ServiceResponse> UpdateCustomerAsync(Customer customer)
    {
        if (customer is null)
            return ServiceResponse.Fail("Müşteri bilgisi eksik.");

        var existing = await _customerReadRepository.GetByIdAsync(customer.Id.ToString());
        if (existing == null)
            return ServiceResponse.Fail("Güncellenecek müşteri bulunamadı.");

        _customerWriteRepository.Update(customer);
        await _customerWriteRepository.SaveAsync();
        return ServiceResponse.Ok("Müşteri güncellendi.");
    }
    public async Task<ServiceResponse> DeleteCustomerAsync(string id)
    {
        var customer = await _customerReadRepository.GetByIdAsync(id);
        if (customer is null)
            return ServiceResponse.Fail("Silinecek müşteri bulunamadı.");

        _customerWriteRepository.Remove(customer);
        await _customerWriteRepository.SaveAsync();
        return ServiceResponse.Ok("Müşteri silindi.");
    }
}
