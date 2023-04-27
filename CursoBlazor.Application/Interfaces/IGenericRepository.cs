using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CursoBlazor.Application.Interfaces
{
    //public interface IGenericRepository<T> where T : class
    //{
    //    Task<T> GetByIdAsync(Guid id);
    //    Task<IReadOnlyList<T>> GetAllAsync();
    //    Task<T> AddAsync(T entityToAdd);
    //    Task<T> UpdateAsync(T entityToUpdate);
    //    Task<int> DeleteAsync(Guid id);
    //}

    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity Get(Expression<Func<TEntity, bool>> expression);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression);
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default);
        Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default);
        Task AddAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);
    }
}
