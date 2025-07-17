using CleanArthitecture_KuyumcuApp.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArthitecture_KuyumcuApp.Application.Repositories;
public interface IRepository<T> where T : BaseEntity
{
    DbSet<T> Table { get; }
}
