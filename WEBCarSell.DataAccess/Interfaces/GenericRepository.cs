using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WEBCarSell.DataAccess.Interfaces
{
    public class GenericRepository : IRepository
    {
        private readonly WEBCarSellDBContext _dbContext;

        public GenericRepository(WEBCarSellDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TEntity> Create<TEntity>(TEntity entity) where TEntity : class 
        {
            _dbContext.Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public Task Delete<TEntity>(TEntity entity) where TEntity : ISoftDeletable 
        {
            entity.IsDeleted = true;
            _dbContext.Entry(entity).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public async Task HardDelete<TEntity>(TEntity entity) where TEntity : class 
        {
            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChanges(); 
        }

        public async Task<IEnumerable<TEntity>> GetAll<TEntity>() where TEntity : class 
        {
            return await _dbContext.Set<TEntity>().ToList();
        }

        public async Task<TEntity> GetById<TEntity>(int id) where TEntity : class 
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task Update<TEntity>(TEntity entity) where TEntity : class 
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public async Task<bool> IfExist<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class 
        {
            return await _dbContext.Set<TEntity>().AnyAsync(predicate);
        }
    }
}
