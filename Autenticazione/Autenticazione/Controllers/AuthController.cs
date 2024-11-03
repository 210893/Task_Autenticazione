using Autenticazione.Services;
using Microsoft.AspNetCore.Mvc;

namespace Autenticazione.Controllers
{
    public class AuthController : Controller
    {
        private readonly AmministratoreServices _serviceADM;

        public AuthController(AmministratoreServices service)
        {
            _serviceADM = service;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
    }
}
