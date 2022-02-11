using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebSupplier.Domain.Interfaces;
using WebSupplier.WebApp.Extensions;
using WebSupplier.WebApp.Models;

namespace WebSupplier.WebApp.Controllers
{
    public class HomeController : MainController
    {
        public HomeController(INotificationService notificationService, IMapper mapper) : base(notificationService, mapper)
        {            
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("error/{id:length(3,3)}")]
        [AllowAnonymous]
        public IActionResult Error(int id)
        {
            var modelErro = new ErrorViewModel();

            if (id == 500)
            {
                modelErro.Message = "An error has occurred! Please try again later or contact our support.";
                modelErro.Title = "An error has occurred";
                modelErro.ErroCode = id;
            }
            else if (id == 404)
            {
                modelErro.Message = "Looks like you took a wrong turn.";
                modelErro.Title = "Page not found.";
                modelErro.ErroCode = id;

            }
            else if (id == 403)
            {
                modelErro.Message = "Unauthorized";
                modelErro.Title = "Access Denied!";
                modelErro.ErroCode = id;
            }
            else
            {
                return StatusCode(404);
            }

            return View("Error", modelErro);
        }
    }
}
