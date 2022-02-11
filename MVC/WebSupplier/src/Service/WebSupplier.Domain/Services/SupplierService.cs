using WebSupplier.Domain.Interfaces;
using WebSupplier.Domain.Interfaces.Repositorys;
using WebSupplier.Domain.Interfaces.Services;
using WebSupplier.Domain.Models;
using WebSupplier.Domain.Models.Validation;
using WebSupplier.Domain.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebSupplier.Domain.Services
{
    public class SupplierService : ServiceBase<Supplier>, ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly INotificationService _notificationService;

        public SupplierService(INotificationService notificationService, ISupplierRepository supplierRepository) : base(notificationService)
        {
            _supplierRepository = supplierRepository;
            _notificationService = notificationService;
        }

        public override async Task<PaginationModel<Supplier>> Pagination(int page, int size, string query)
        {
            if (string.IsNullOrEmpty(query))
                return await _supplierRepository.Pagination(page, size, null);
            else
                return await _supplierRepository.Pagination(page, size, x => x.FantasyName.Contains(query));
        }
        public override async Task<Supplier> FindById(Guid id)
        {
            var result = await _supplierRepository.FindById(id);

            if (result == null) Notify("Supplier not found.");

            return result;
        }
        public async Task Insert(Supplier supplier)
        {
            if (!ValidatiSupplier(supplier)) return;

            if (supplier is SupplierJuridical)
            {
                var viewModel = (SupplierJuridical)supplier;
                var result = await _supplierRepository.Find(x => x.Cnpj.Contains(viewModel.Cnpj) || x.FantasyName.Contains(viewModel.FantasyName));
                if (result != null)
                {
                    if (result.Cnpj == viewModel.Cnpj)
                    {
                        Notify("CNPJ already registered to another Supplier.");
                    }
                    if (result.FantasyName == viewModel.FantasyName)
                    {
                        Notify("Fantasy Name already registered to another Supplier.");
                    }
                    return;
                }


                var phone = supplier.Phones.FirstOrDefault();
                SupplierJuridical model = new SupplierJuridical(viewModel.CompanyName, viewModel.Cnpj, viewModel.Active, viewModel.FantasyName,
                                                                    viewModel.Address.ZipCode, viewModel.Address.Street, viewModel.Address.Number, viewModel.Address.Neighborhood, viewModel.Address.City,
                                                                    viewModel.Address.State, viewModel.Address.Complement, viewModel.Address.Reference,
                                                                    viewModel.Email.EmailAddress,
                                                                    phone.Ddd, phone.Number);
                foreach (var item in supplier.Phones.ToList())
                {
                    model.AddPhone(new Phone(model.Id, item.Ddd, item.Number));
                }

                await _supplierRepository.InsertJu(model);
            }
            else
            {
                var viewModel = (SupplierPhysical)supplier;
                var result = await _supplierRepository.Find(x => x.Cpf.Contains(viewModel.Cpf) || x.FantasyName.Contains(viewModel.FantasyName));
                if (result != null)
                {
                    if (result.Cpf == viewModel.Cpf)
                    {
                        Notify("CPF already registered to another Supplier.");
                    }
                    if (result.FantasyName == viewModel.FantasyName)
                    {
                        Notify("Fantasy Name already registered to another Supplier.");
                    }
                    return;
                }


                var phone = supplier.Phones.FirstOrDefault();               

                SupplierPhysical model = new SupplierPhysical(viewModel.FullName, viewModel.Cpf, viewModel.Active, viewModel.FantasyName,
                                                                    viewModel.Address.ZipCode, viewModel.Address.Street, viewModel.Address.Number, viewModel.Address.Neighborhood, viewModel.Address.City,
                                                                    viewModel.Address.State, viewModel.Address.Complement, viewModel.Address.Reference,
                                                                    viewModel.Email.EmailAddress,
                                                                    phone.Ddd, phone.Number);
             

                foreach (var item in supplier.Phones.ToList())
                {
                    model.AddPhone(new Phone(model.Id, item.Ddd, item.Number));
                }

                await _supplierRepository.InsertPh(model);

            }

            await _supplierRepository.SaveChanges();
        }
        public async Task Update(Supplier supplier)
        {
            if (!ValidatiSupplier(supplier)) return;

            var modelDb = await _supplierRepository.FindById(supplier.Id);

            if (modelDb == null)
            {
                Notify("Supplier not found.");
                return;
            }

            if (modelDb.Email.EmailAddress != supplier.Email.EmailAddress)
                modelDb.UpdateEmail(supplier.Email.EmailAddress);

            if (modelDb.Address.ZipCode != supplier.Address.ZipCode)
                modelDb.UpdateAddress(supplier.Address.ZipCode, supplier.Address.Street, supplier.Address.Number,
                                                supplier.Address.Neighborhood, supplier.Address.City, supplier.Address.State,
                                                supplier.Address.Complement, supplier.Address.Reference);

            var phoneViewModel = supplier.Phones.FirstOrDefault();           

            if (phoneViewModel == null)
            {
                return;                
            }
            else
            {                 
                 modelDb.UpdatePhone(phoneViewModel.Ddd, phoneViewModel.Number);
            }

                    

            if (supplier is SupplierJuridical)
            {
                var modelDbJuridical = (SupplierJuridical)modelDb;
                var view = (SupplierJuridical)supplier;
                modelDbJuridical.SetFantasyName(view.FantasyName);
                modelDbJuridical.SetCompanyName(view.CompanyName);
                modelDbJuridical.SetOpenDate(view.OpenDate);

                await _supplierRepository.Update(modelDbJuridical);
            }
            if (supplier is SupplierPhysical)
            {
                var modelDbPhysical = (SupplierPhysical)modelDb;
                var view = (SupplierPhysical)supplier;
                modelDbPhysical.SetFantasyName(view.FantasyName);
                modelDbPhysical.SetFullName(view.FullName);
                modelDbPhysical.SetBirthDate(view.BirthDate);

                await _supplierRepository.Update(modelDbPhysical);
            }

            await _supplierRepository.SaveChanges();
        }

        public async Task<IEnumerable<Supplier>> ToList()
        {
            return await _supplierRepository.FindAll();
        }
        public async Task<IEnumerable<Supplier>> ToListAndProduct()
        {
            return await _supplierRepository.FindAllAndProduct();
        }
        private bool ValidatiSupplier(Supplier supplier)
        {
            if (supplier is SupplierJuridical) RunValidation(new SupplierJuridicalValidation(), (SupplierJuridical)supplier);
            else RunValidation(new SupplierPhysicalValidation(), (SupplierPhysical)supplier);

            RunValidation(new AddressValidation(), supplier.Address);

            RunValidation(new EmailValidation(), supplier.Email);

            foreach (var item in supplier.Phones)
                RunValidation(new PhoneValidation(), item);

            if (!OperationValid())
                return true;
            else
                return false;
        }

        public async Task Delete(Guid id)
        {
            if (id == Guid.Empty) throw new DomainException("Id not found");

            var resultDb = await FindById(id);

            if (resultDb == null) throw new DomainException("Id not found");

            await _supplierRepository.RemoveAddress(resultDb.Address);
            await _supplierRepository.RemoveEmail(resultDb.Email);
            await _supplierRepository.RemoveRangePhone((List<Phone>)resultDb.Phones);
            await _supplierRepository.Remove(resultDb);

            try
            {
                await _supplierRepository.SaveChanges();
            }
            catch
            {
                Notify("It is not possible to exclude this supplier. Delete the products and try again.");
            }
        }
    }
}
