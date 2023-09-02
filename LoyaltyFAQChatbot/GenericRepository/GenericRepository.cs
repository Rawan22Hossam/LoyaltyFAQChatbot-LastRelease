using LoyaltyFAQChatbot.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LoyaltyFAQChatbot.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationContext _dbContext;
        private readonly DbSet<T> entities = null;   
        public GenericRepository(ApplicationContext context) 
        {
            _dbContext = context;
            entities = context.Set<T>();
        }
        public async Task Add(T enttity) 
        {
            await _dbContext.Set<T>().AddAsync(enttity);
        }
        public async Task<T> GetAsync(Expression<Func<T, bool>> where)
        {
            return await _dbContext.Set<T>().FirstOrDefaultAsync(where);
        }
        public T Get(Expression<Func<T, bool>> where)
        {
            return _dbContext.Set<T>().FirstOrDefault(where);
        }
        public IQueryable<T> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbContext.Set<T>();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return query;
        }
        public IQueryable<T> GetAll(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbContext.Set<T>();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return query;
        }
        public async Task<T> GetById(object id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IQueryable<T>> GetManyAsync(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbContext.Set<T>();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return query.Where(where);
        }
        public IQueryable<T> GetMany(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbContext.Set<T>();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return query.Where(where);
        }
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

    }
}
