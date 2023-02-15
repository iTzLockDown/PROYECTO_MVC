using Contrato;
using Microsoft.AspNetCore.Mvc;
using Modelo;
using Repositorio;

namespace WebCliente.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ILogger<UsuarioController> _logger;
        List<Usuario> oObjeto = null;
        public UsuarioController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
        }
        public IActionResult Usuario()
        {
           
            using (IUsuarioRepositorio oRepositorio = new UsuarioRepositorio())
            {
                oObjeto = oRepositorio.TraerTodos();
            }
            
            return View(oObjeto);
        }
        
        public IActionResult CrearUsuario()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CrearUsuario(Usuario usuario)
        {
            bool respuesta = false;
            using (IUsuarioRepositorio oRepositorio = new UsuarioRepositorio())
            {
                respuesta = oRepositorio.Grabar(usuario);
            }
            return Redirect("Usuario");
        }
        public IActionResult EditarPersona()
        {
            return View();
        }
        [HttpPut]
        public IActionResult EditarPersona(Usuario usuario)
        {
            bool respuesta = false;
            using (IUsuarioRepositorio oRepositorio = new UsuarioRepositorio())
            {
                respuesta = oRepositorio.Editar(usuario);
            }
            return Ok(respuesta);
        }
        public IActionResult EliminarUsuario(int numero)
        {
            bool respuesta = false;
            using (IUsuarioRepositorio oRepositorio = new UsuarioRepositorio())
            {
                respuesta = oRepositorio.Eliminar(numero);
            }
            return Redirect("Usuario");
        }
    }
}
