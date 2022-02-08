using Microsoft.EntityFrameworkCore;
using WebSupplier.Domain.Interfaces.Repositorys;
using WebSupplier.Domain.Models;
using WebSupplier.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebSupplier.Infrastructure.Repository;

namespace WebSupplier.Infrastructure.Repository
{
    public class SupplierRepository : RepositoryBase<Supplier>, ISupplierRepository
    {
        public SupplierRepository(WebSupplierContext context) : base(context)
        {
        }

        public async Task<SupplierJuridical> Find(Expression<Func<SupplierJuridical, bool>> expression)
        {
            return await _context.SupplierJuridical.Where(expression).AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<SupplierPhysical> Find(Expression<Func<SupplierPhysical, bool>> expression)
        {
            return await _context.SupplierPhysical.Where(expression).AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Supplier>> FindAllAndProduct()
        {
            return await _dbSet.Include(x => x.Products).AsNoTracking().ToListAsync();
        }

        public override async Task<Supplier> FindById(Guid id)
        {
            return await _dbSet
                .Include(x => x.Email)
                .Include(x => x.Phones)
                .Include(x => x.Address)
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task InsertAddress(Address address)
        {
            await _context.Address.AddAsync(address);
        }

        public async Task InsertEmail(Email email)
        {
            await _context.Email.AddAsync(email);
        }

        public async Task InsertJu(SupplierJuridical juridical)
        {
            await _context.SupplierJuridical.AddAsync(juridical);
        }

        public async Task InsertPh(SupplierPhysical physical)
        {
            await _context.SupplierPhysical.AddAsync(physical);
        }

        public async Task InsertPhone(Phone newPhone)
        {
            await _context.Phone.AddAsync(newPhone);
        }

        public async Task InsertPhoneRanger(IEnumerable<Phone> phones)
        {
            await _context.Phone.AddRangeAsync(phones);
        }

        public async Task RemoveAddress(Address address)
        {
            _context.Address.Remove(address);
            await Task.CompletedTask;
        }

        public async Task RemoveEmail(Email email)
        {
            _context.Email.Remove(email);
            await Task.CompletedTask;
        }

        public async Task RemovePhone(Phone phoneRemove)
        {
            _context.Phone.Remove(phoneRemove);
            await Task.CompletedTask;
        }

        public async Task RemoveRangePhone(List<Phone> list)
        {
            _context.Phone.RemoveRange(list);
            await Task.CompletedTask;
        }
    }
}
