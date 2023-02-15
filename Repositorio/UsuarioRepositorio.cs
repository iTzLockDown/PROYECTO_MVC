using Contrato;
using Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public static List<Usuario> oUsuario = new List<Usuario>();
        public List<Usuario> TraerTodos()
        {
            
            return oUsuario.ToList();
        }
        public bool Grabar(Usuario usuario)
        {
            
            bool respuesta = false;
            oUsuario.Add(usuario);
            return respuesta;
        }
        public bool Editar(Usuario usuario)
        {
            
            bool respuesta = false;
            
            return respuesta;
        }
        public bool Eliminar(int codigoUsuario)
        {
            bool respuesta = false;

            for(int i =0; i<= oUsuario.Count; i++)
            {
                if (oUsuario[i].codigo == codigoUsuario)
                {
                    oUsuario.RemoveAt(i);
                }
            }
            return respuesta;
        }
        public void Dispose()
        {  
            GC.SuppressFinalize(this); 
        }
    }
}
