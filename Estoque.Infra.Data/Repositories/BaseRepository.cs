using Estoque.Domain.Contracts.Repositories;
using Estoque.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Infra.Data.Repositories
{
    public class BaseRepository<T> where T : class
    {
        protected readonly DataContext dataContext;

        public BaseRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task CreateAsync(T entity)
        {
            dataContext.Entry(entity).State = EntityState.Added;
            await dataContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            dataContext.Entry(entity).State = EntityState.Deleted;
            await dataContext.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            GC.SuppressFinalize(this);
            await dataContext.DisposeAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await dataContext.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> ListAsync()
        {
            return await dataContext.Set<T>().ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            dataContext.Entry(entity).State = EntityState.Modified;
            await dataContext.SaveChangesAsync();
        }
    }
}
