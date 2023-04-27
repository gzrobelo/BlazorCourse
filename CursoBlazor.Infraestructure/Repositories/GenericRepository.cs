using CursoBlazor.Application.Interfaces;
using CursoBlazor.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CursoBlazor.Infraestructure.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly BlazorContext _dbContext;
        private readonly DbSet<TEntity> _entitiySet;

        public GenericRepository(BlazorContext dbContext)
        {
            _dbContext = dbContext;
            _entitiySet = _dbContext.Set<TEntity>();
        }

        public void Add(TEntity entity)
           => _dbContext.Add(entity);


        public async Task AddAsync(TEntity entity, CancellationToken cancellationToken = default)
            => await _dbContext.AddAsync(entity, cancellationToken);


        public void AddRange(IEnumerable<TEntity> entities)
            => _dbContext.AddRange(entities);


        public async Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
            => await _dbContext.AddRangeAsync(entities, cancellationToken);


        public TEntity Get(Expression<Func<TEntity, bool>> expression)
            => _entitiySet.FirstOrDefault(expression);


        public IEnumerable<TEntity> GetAll()
            => _entitiySet.AsEnumerable();


        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression)
            => _entitiySet.Where(expression).AsEnumerable();


        public async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default)
            => await _entitiySet.ToListAsync(cancellationToken);


        public async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default)
            => await _entitiySet.Where(expression).ToListAsync(cancellationToken);

        
        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default)
            => await _entitiySet.FirstOrDefaultAsync(expression, cancellationToken);


        public void Remove(TEntity entity)
            => _dbContext.Remove(entity);


        public void RemoveRange(IEnumerable<TEntity> entities)
            => _dbContext.RemoveRange(entities);


        public void Update(TEntity entity)
            => _dbContext.Update(entity);

        public void UpdateRange(IEnumerable<TEntity> entities)
            => _dbContext.UpdateRange(entities);

        
    }

}
