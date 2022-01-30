using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebSupplier.Domain.Interfaces;
using WebSupplier.Domain.Models;
using WebSupplier.Infrastructure.Data;

namespace WebSupplier.Infrastructure.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : Supplier, IAggregateRoot
    {
        private readonly WebSupplierContext _context;               
        protected readonly DbSet<T> _dbSet;

        public RepositoryBase(WebSupplierContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<T> Find(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.Where(expression).FirstOrDefaultAsync();
        }

        public async Task Insert(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task Remove(T entity)
        {
            _dbSet.Remove(entity);
            await Task.CompletedTask;
        }

        public async Task Update(T entity)
        {
            _dbSet.Update(entity);
            await Task.CompletedTask;
        }


        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }


        public void Dispose()
        {
            _context?.Dispose();
        }


    }
}
