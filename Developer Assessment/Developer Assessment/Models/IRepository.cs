using System.Linq.Expressions;

namespace Developer_Assessment.Models
{
    public interface IRepository<TEntity, TPrimaryKey>
    { 
        //TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        IQueryable<TEntity> GetAll(); 

        Task<TEntity> InsertAsync(TEntity entity); 

        //Task<TEntity> InsertOrUpdateAsync(TEntity entity); 
        //TEntity Update(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);
    }
}
