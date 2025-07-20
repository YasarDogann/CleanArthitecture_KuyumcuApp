using CleanArthitecture_KuyumcuApp.Application.Abstractions.Services;
using CleanArthitecture_KuyumcuApp.Application.Common;
using CleanArthitecture_KuyumcuApp.Application.Repositories;
using CleanArthitecture_KuyumcuApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArthitecture_KuyumcuApp.Persistence.Services;
public class SaleItemService : ISaleItemService
{
    private readonly ISaleItemReadRepository _saleItemReadRepository;
    private readonly ISaleItemWriteRepository _saleItemWriteRepository;

    public SaleItemService(ISaleItemReadRepository readRepo, ISaleItemWriteRepository writeRepo)
    {
        _saleItemReadRepository = readRepo;
        _saleItemWriteRepository = writeRepo;
    }

    public async Task<List<SaleItem>> GetAllSaleItemsAsync()
    {
        return await _saleItemReadRepository.GetAll().ToListAsync();
    }

    public async Task<SaleItem> GetByIdAsync(string id)
    {
        return await _saleItemReadRepository.GetByIdAsync(id);
    }

    public async Task<ServiceResponse> AddSaleItemAsync(SaleItem saleItem)
    {
        if (saleItem == null)
            return ServiceResponse.Fail("Satış kalemi bilgisi boş olamaz.");

        await _saleItemWriteRepository.AddAsync(saleItem);
        await _saleItemWriteRepository.SaveAsync();
        return ServiceResponse.Ok("Satış kalemi başarıyla eklendi.");
    }

    public async Task<ServiceResponse> UpdateSaleItemAsync(SaleItem saleItem)
    {
        if (saleItem == null)
            return ServiceResponse.Fail("Satış kalemi bilgisi eksik.");

        var existing = await _saleItemReadRepository.GetByIdAsync(saleItem.Id.ToString());
        if (existing == null)
            return ServiceResponse.Fail("Güncellenecek satış kalemi bulunamadı.");

        _saleItemWriteRepository.Update(saleItem);
        await _saleItemWriteRepository.SaveAsync();
        return ServiceResponse.Ok("Satış kalemi güncellendi.");
    }

    public async Task<ServiceResponse> DeleteSaleItemAsync(string id)
    {
        var saleItem = await _saleItemReadRepository.GetByIdAsync(id);
        if (saleItem == null)
            return ServiceResponse.Fail("Silinecek satış kalemi bulunamadı.");

        _saleItemWriteRepository.Remove(saleItem);
        await _saleItemWriteRepository.SaveAsync();
        return ServiceResponse.Ok("Satış kalemi silindi.");
    }
}

/// <summary>
/// Satış kalemleri (ürün, hizmet) için somut servis.
/// CRUD işlemleri repository'ler üzerinden yapılır.
/// </summary>