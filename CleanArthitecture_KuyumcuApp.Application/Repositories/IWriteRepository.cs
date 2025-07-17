using CleanArthitecture_KuyumcuApp.Domain.Common;

namespace CleanArthitecture_KuyumcuApp.Application.Repositories;

//Yazma işlemlerini tanımlayan generic arayüz.
public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
{
    Task<bool> AddAsync(T entity);                    // Yeni kayıt ekler
    Task<bool> AddRangeAsync(List<T> entities);       // Toplu kayıt ekler.
    bool Remove(T entity);                            // Kayıt siler.
    Task<bool> RemoveAsync(string id);                  // Id'ye göre kayıt siler.
    bool RemoveRange(List<T> entities);               // Toplu silme işlemi
    bool Update(T entity);                            // Güncelleme
    Task<int> SaveAsync();                            // Değişiklikleri kyaıt eder
    //Task<bool> UpdateAsync(T entity);     
    //Task<bool> DeleteAsync(string id);
}
