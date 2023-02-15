using Contrato;
using Microsoft.AspNetCore.Mvc;
using Modelo;
using Repositorio;

namespace WebCliente.Controllers
{
    public class PersonaController : Controller
    {
        private readonly ILogger<PersonaController> _logger;
        List<Persona> oObjeto = null;
        public PersonaController(ILogger<PersonaController> logger)
        {
            _logger = logger;
        }
        public IActionResult Persona()
        {
           
            using (IPersonaRepositorio oRepositorio = new PersonaRepositorio())
            {
                oObjeto = oRepositorio.TraerTodos();
            }
            
            return View(oObjeto);
        }
        
        public IActionResult CrearPersona()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CrearPersona(Persona persona)
        {
            bool respuesta = false;
            using (IPersonaRepositorio oRepositorio = new PersonaRepositorio())
            {
                respuesta = oRepositorio.Grabar(persona);
            }
            return Redirect("Persona");
        }
        public IActionResult EditarPersona()
        {
            return View();
        }
        [HttpPut]
        public IActionResult EditarPersona(Persona persona)
        {
            bool respuesta = false;
            using (IPersonaRepositorio oRepositorio = new PersonaRepositorio())
            {
                respuesta = oRepositorio.Editar(persona);
            }
            return Ok(respuesta);
        }
        public IActionResult EliminarPersona(int numero)
        {
            bool respuesta = false;
            using (IPersonaRepositorio oRepositorio = new PersonaRepositorio())
            {
                respuesta = oRepositorio.Eliminar(numero);
            }
            return Redirect("Persona");
        }
    }
}
