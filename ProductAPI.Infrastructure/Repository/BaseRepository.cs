using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using ProductAPI.ApplicationCore.Interfaces.Repository;
using ProductAPI.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Infrastructure.Repository
{
    public class BaseRepositoryAsync<T> : IRepositoryAsync<T> where T : class
    {
        private readonly ProductDbContext db;

        public BaseRepositoryAsync(ProductDbContext db)
        {
            this.db = db;
        }
        public async Task<int> DeleteAsync(int id)
        {
            var entity = await GetById(id);
            db.Set<T>().Remove(entity);
            return await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
           return await db.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await db.Set<T>().FindAsync(id);
        }

        public async Task<int> InsertAsync(T entity)
        {
            await db.Set<T>().AddAsync(entity);
            return await db.SaveChangesAsync();
        }

        public Task<int> UpdateAsync(T entity)
        {
            db.Set<T>().Entry(entity).State= EntityState.Modified;
            return db.SaveChangesAsync();
        }
    }
}
