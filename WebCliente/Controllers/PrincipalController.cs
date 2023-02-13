using Microsoft.AspNetCore.Mvc;

namespace WebCliente.Controllers
{
    public class PrincipalController : Controller
    {
        private readonly ILogger<PrincipalController> _logger;

        public PrincipalController(ILogger<PrincipalController> logger)
        {
            _logger = logger;
        }
        public IActionResult Principal()
        {
            return View();
        }
    }
}
