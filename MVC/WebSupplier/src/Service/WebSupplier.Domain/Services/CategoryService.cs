using WebSupplier.Domain.Interfaces.Repositorys;
using WebSupplier.Domain.Models;
using WebSupplier.Domain.Models.Validation;
using WebSupplier.Domain.Tools;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebSupplier.Domain.Interfaces;
using WebSupplier.Domain.Interfaces.Services;

namespace WebSupplier.Domain.Services
{
    public class CategoryService : ServiceBase<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(INotificationService notificationService, ICategoryRepository categoryRepository) : base(notificationService)
        {
            _categoryRepository = categoryRepository;
        }

        public override async Task<Category> FindById(Guid id)
        {
            var result = await _categoryRepository.Find(x => x.Id == id);

            if (result == null) Notify("Category not located.");

            return result;
        }

        public override async Task<PaginationModel<Category>> Pagination(int page, int size, string query = null)
        {
            if (string.IsNullOrEmpty(query))
                return await _categoryRepository.Pagination(page, size, null);
            else
                return await _categoryRepository.Pagination(page, size, x => x.Name.Contains(query));
        }

        public async Task Insert(Category category)
        {
            if (!RunValidation(new CategoryValidation(), category)) return;

            if (_categoryRepository.Find(x => x.Name.Contains(category.Name)).Result != null)
            {
                Notify("The Name already exists for another category.");
                return;
            }

            await _categoryRepository.Insert(category);

            await _categoryRepository.SaveChanges();
        }

        public async Task Update(Category category)
        {
            if (!RunValidation(new CategoryValidation(), category)) return;

            var validDb = await _categoryRepository.Find(x => x.Name.Contains(category.Name));
            if (validDb != null && validDb.Id != category.Id)
            {
                Notify("The Name already exists for another category.");
                return;
            }
            var result = await FindById(category.Id);

            if (result == null) return;

            result.SetName(category.Name);

            await _categoryRepository.Update(result);
            await _categoryRepository.SaveChanges();
        }

        public async Task Delete(Guid id)
        {
            if (id == Guid.Empty) throw new DomainException("Invalid Id");

            var result = await FindById(id);

            if (result == null)
            {
                throw new DomainException("Category not located for remove.");
            }

            await _categoryRepository.Remove(result);
            await _categoryRepository.SaveChanges();
        }

        public async Task<IEnumerable<Category>> ToList()
        {
            return await _categoryRepository.FindAll();
        }
    }
}
