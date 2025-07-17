using CleanArthitecture_KuyumcuApp.Application.Abstractions.Services;
using CleanArthitecture_KuyumcuApp.Application.Repositories;
using CleanArthitecture_KuyumcuApp.Domain.Entities;

namespace CleanArthitecture_KuyumcuApp.Persistence.Services;
public class CategoryService : ICategoryService
{
    private readonly ICategoryReadRepository _categoryReadRepository;
    private readonly ICategoryWriteRepository _categoryWriteRepository;

    public async Task<List<Category>> GetAllCategoriesAsync()
    {
        return _categoryReadRepository.GetAll().ToList();
    }

    public async Task<Category> GetByIdAsync(string id)
    {
        return await _categoryReadRepository.GetByIdAsync(id);
    }

    public async Task<bool> AddCategoryAsync(Category category)
    {
        var result = await _categoryWriteRepository.AddAsync(category);
        await _categoryWriteRepository.SaveAsync();
        return result;
    }
    public async Task<bool> UpdateCategoryAsync(Category category)
    {
        var result = _categoryWriteRepository.Update(category);
        await _categoryWriteRepository.SaveAsync();
        return result;
    }

    public async Task<bool> DeleteCategoryAsync(string id)
    {
        var result = await _categoryWriteRepository.RemoveAsync(id);
        await _categoryWriteRepository.SaveAsync();
        return result;
    }

}
