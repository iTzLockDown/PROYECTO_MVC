using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrato
{
    public interface IUsuarioRepositorio :IDisposable
    {
        List<Usuario> TraerTodos();
        bool Grabar(Usuario usuario);
        bool Editar(Usuario usuario);
        bool Eliminar(int numero);
    }
}
