using Microsoft.AspNetCore.Mvc;
using Modelo;

namespace WebCliente.Controllers
{
    public class WebController : Controller
    {
        private readonly ILogger<WebController> _logger;
   
        public WebController(ILogger<WebController> logger)
        {
            _logger = logger;
        }
        public IActionResult Web()
        {
            return View();
        }
    }
}
