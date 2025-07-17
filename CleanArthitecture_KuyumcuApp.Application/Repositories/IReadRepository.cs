using CleanArthitecture_KuyumcuApp.Domain.Common;
using System.Linq.Expressions;

namespace CleanArthitecture_KuyumcuApp.Application.Repositories;
public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
{
    //Okuma işlemlerini tanımlayan generic arayüz
    IQueryable<T> GetAll(bool tracking = true);                                         // Tüm kayıtları getir
    IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate, bool tracking = true);  // Belirtilen filtreye göre kayıtları getirir
    Task<T> GetByIdAsync(Guid id, bool tracking = true);                                // Id'ye göre tek kayıt getirir
    Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate, bool tracking = true);  // Belirtilen filtreye göre tek kayıt getirir.
}
