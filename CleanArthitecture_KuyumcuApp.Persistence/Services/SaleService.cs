using CleanArthitecture_KuyumcuApp.Application.Abstractions.Services;
using CleanArthitecture_KuyumcuApp.Application.Common;
using CleanArthitecture_KuyumcuApp.Application.Repositories;
using CleanArthitecture_KuyumcuApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArthitecture_KuyumcuApp.Persistence.Services;
public class SaleService : ISaleService
{
    private readonly ISaleReadRepository _saleReadRepository;
    private readonly ISaleWriteRepository _saleWriteRepository;

    public SaleService(ISaleReadRepository readRepo, ISaleWriteRepository writeRepo)
    {
        _saleReadRepository = readRepo;
        _saleWriteRepository = writeRepo;
    }
    public async Task<List<Sale>> GetAllSalesAsync()
    {
        return await _saleReadRepository.GetAll().ToListAsync();
    }

    public async Task<Sale> GetByIdAsync(string id)
    {
        return await _saleReadRepository.GetByIdAsync(id);
    }

    public async Task<ServiceResponse> AddSaleAsync(Sale sale)
    {
        if (sale == null)
            return ServiceResponse.Fail("Satış bilgisi boş olamaz.");

        await _saleWriteRepository.AddAsync(sale);
        await _saleWriteRepository.SaveAsync();
        return ServiceResponse.Ok("Satış başarıyla eklendi.");
    }

    public async Task<ServiceResponse> UpdateSaleAsync(Sale sale)
    {
        if (sale == null)
            return ServiceResponse.Fail("Satış bilgisi eksik.");

        var existing = await _saleReadRepository.GetByIdAsync(sale.Id.ToString());
        if (existing == null)
            return ServiceResponse.Fail("Güncellenecek satış bulunamadı.");

        _saleWriteRepository.Update(sale);
        await _saleWriteRepository.SaveAsync();
        return ServiceResponse.Ok("Satış güncellendi.");
    }

    public async Task<ServiceResponse> DeleteSaleAsync(string id)
    {
        var sale = await _saleReadRepository.GetByIdAsync(id);
        if (sale == null)
            return ServiceResponse.Fail("Silinecek satış bulunamadı.");

        _saleWriteRepository.Remove(sale);
        await _saleWriteRepository.SaveAsync();
        return ServiceResponse.Ok("Satış silindi.");
    }
}

/// <summary>
/// Satış işlemleri için somut servis.
/// Burada repository'ler kullanılarak CRUD işlemleri yapılır.
/// </summary>