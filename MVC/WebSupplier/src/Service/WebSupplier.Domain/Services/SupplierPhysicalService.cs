using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebSupplier.Domain.Interfaces;
using WebSupplier.Domain.Models;

namespace WebSupplier.Domain.Services
{
    public class SupplierPhysicalService : ISupplierPhysicalService
    {
        private readonly ISupplierPhysicalRepository _supplierPhysicalRepository;

        public SupplierPhysicalService(ISupplierPhysicalRepository supplierPhysicalRepository)
        {
            _supplierPhysicalRepository = supplierPhysicalRepository;
        }


        public async Task<IEnumerable<SupplierPhysical>> ToList()
        {
            return await _supplierPhysicalRepository.ToList();
        }

        public async Task AddSupplierPhysical(SupplierPhysical supplierPhysical)
        {
            //validar

            // aplicar a regra de negocio

            //salvar no banco 


            await _supplierPhysicalRepository.Insert(supplierPhysical);

            await _supplierPhysicalRepository.SaveChanges();
            await Task.CompletedTask;
        }

    }
}
