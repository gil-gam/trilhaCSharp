using Microsoft.AspNetCore.Mvc;
using WebSupplier.Domain.Interfaces;
using System.Linq;
using WebSupplier.WebApp.Models;

namespace WebSupplier.WebApp.Extensions.ViewComponents
{
    public class SummaryViewComponent : ViewComponent
    {
        private readonly INotificationService _notificationService;

        public SummaryViewComponent(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public IViewComponentResult Invoke()
        {
            var list = _notificationService.AllError().Select(x => x.Erro).ToList();
            list.ForEach(x => ViewData.ModelState.AddModelError(string.Empty, x + " <br />"));
            return View(list);
        }
    }

    public class PaginationViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IPageViewModel modelPagination)
        {
            return View(modelPagination);
        }

    }
}
