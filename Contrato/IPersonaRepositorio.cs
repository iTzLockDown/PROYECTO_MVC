using Modelo;

namespace Contrato
{
    public interface IPersonaRepositorio :IDisposable
    {
        List<Persona> TraerTodos();
        bool Grabar(Persona persona);
        bool Editar(Persona persona);
        bool Eliminar(int numero);


    }
}