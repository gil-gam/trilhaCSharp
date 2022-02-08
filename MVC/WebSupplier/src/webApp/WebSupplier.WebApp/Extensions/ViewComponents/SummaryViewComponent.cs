﻿using Microsoft.AspNetCore.Mvc;
using WebSupplier.Domain.Interfaces;
using System.Linq;

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
            var result = _notificationService.AllError().Select(x => x.Erro).ToList();
            result.ForEach(x => ModelState.AddModelError(string.Empty, x));
            return View(result);
        }
    }
}
