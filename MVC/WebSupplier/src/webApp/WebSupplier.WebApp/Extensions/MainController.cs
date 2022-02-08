using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebSupplier.Domain.Interfaces;

namespace WebSupplier.WebApp.Extensions
{
    [Authorize]
    public abstract class MainController : Controller
    {
        protected readonly INotificationService _notificationService;
        protected readonly IMapper _mapper;

        protected MainController(INotificationService notificationService, IMapper mapper)
        {
            _notificationService = notificationService;
            _mapper = mapper;
        }

        protected bool OperationValid() => _notificationService.HasError();
    }
}
