using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Developer_Assessment.Models
{
    public class Repository<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey>
        where TEntity : class
    {
        private readonly CDNDbContext _context;

        public Repository(CDNDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        } 


        public Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().FirstOrDefaultAsync(predicate);
        }

        public Task<TEntity> InsertAsync(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            return _context.SaveChangesAsync().ContinueWith(t => entity);
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            return _context.SaveChangesAsync().ContinueWith(t => entity);
        }
    }



}
