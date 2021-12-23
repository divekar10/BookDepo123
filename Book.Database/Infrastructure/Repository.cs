using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Database
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BookDbContex _context;

        public Repository(BookDbContex context)
        {
            _context = context;
        }

        public async void Add(T entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task<IEnumerable<T>> Get()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public virtual void Update(T entity)
        {
            _context.Entry(entity).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
            _context.Set<T>().Update(entity);
            _context.SaveChangesAsync();

        }
    }
}
