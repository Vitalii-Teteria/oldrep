using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WEBCarSell.DataAccess.Interfaces
{
    public interface IRepository 
    {

        Task<IEnumerable<TEntity>> GetAll<TEntity>() where TEntity : class;

        Task<TEntity> GetById<TEntity>(int id) where TEntity : class;

        Task<TEntity> Create<TEntity>(TEntity entity) where TEntity : class;

        Task<TEntity> Update<TEntity>(TEntity entity) where TEntity : class;

        Task<TEntity> Delete<TEntity>(TEntity entity) where TEntity : ISoftDeletable;

        Task<TEntity> HardDelete<TEntity>(TEntity entity) where TEntity : class;

        Task<bool> IfExist<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;

        Task<TEntity> SearchByName<TEntity>(TEntity entity) where TEntity : class;

    }
}
