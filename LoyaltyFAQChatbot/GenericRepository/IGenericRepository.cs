using System.Linq.Expressions;

namespace LoyaltyFAQChatbot.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task Add(T enttity);
        Task<T> GetById(object id);
        Task<T> GetAsync(Expression<Func<T, bool>> where);
        T Get(Expression<Func<T, bool>> where);
        IQueryable<T> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        IQueryable<T> GetAll(params Expression<Func<T, object>>[] includeProperties);
        Task<IQueryable<T>> GetManyAsync(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includeProperties);
        IQueryable<T> GetMany(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includeProperties);
        void SaveChanges();
    }
}
