using System;
using System.Threading.Tasks;
using MyApp.Domain.Models;

namespace MyApp.Application.Interfaces.Repositories
{
    public interface IUnitOfWork: IAsyncDisposable
    {
        Task<int> SaveChangesAsync();
        IBaseRepositoryAsync<T> Repository<T>() where T : BaseEntity;
    }
}