using FluentValidation;
using WebSupplier.Domain.Interfaces;
using WebSupplier.Domain.Interfaces.Services;
using WebSupplier.Domain.Models;
using System;
using System.Threading.Tasks;

namespace WebSupplier.Domain.Services
{
    public abstract class ServiceBase<T> : IServiceBase<T> where T : Entity
    {
        private readonly INotificationService _notificationService;

        protected ServiceBase(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public virtual Task<T> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<PaginationModel<T>> Pagination(int page, int size, string query)
        {
            throw new NotImplementedException();
        }

        protected bool RunValidation<Tv, Te>(Tv validacao, Te entidade) where Tv : AbstractValidator<Te> where Te : Entity
        {
            var validator = validacao.Validate(entidade);

            if (validator.IsValid) return true;

            foreach (var item in validator.Errors)
            {
                Notify(item.ErrorMessage);
            }

            return false;
        }

        protected bool OperationValid() => _notificationService.HasError();

        protected void Notify(string error)
        {
            _notificationService.AddErro(error);
        }

        public void Dispose() { }
    }
}
