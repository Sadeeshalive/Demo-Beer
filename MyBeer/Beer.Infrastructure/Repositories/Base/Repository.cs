using Beer.Core.Repositories.Base;
using Beer.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beer.Infrastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly FavoriteContext _favoriteContext;

        public Repository(FavoriteContext favoriteContext)
        {
            _favoriteContext = favoriteContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            //await _favoriteContext.Set<T>().AddAsync(entity);
            await _favoriteContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _favoriteContext.Set<T>().Remove(entity);
            await _favoriteContext.SaveChangesAsync();
        }

        public Task<IReadOnlyList<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _favoriteContext.Set<T>().FindAsync(id);
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
