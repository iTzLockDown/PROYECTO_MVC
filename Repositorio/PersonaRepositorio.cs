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
    public class PersonaRepositorio : IPersonaRepositorio
    {
        public static List<Persona> oPersona = new List<Persona>();
        public List<Persona> TraerTodos()
        {
            
            return oPersona.ToList();
        }
        public bool Grabar(Persona persona)
        {
            
            bool respuesta = false;
            oPersona.Add(persona);
            return respuesta;
        }
        public bool Editar(Persona persona)
        {
            
            bool respuesta = false;
            foreach (var item in oPersona.Where(x=> x.Codigo == persona.Codigo))
            {
                if (item == null) 
                {
                    
                }
                else {
                    item.Nombre = persona.Nombre;
                    item.Apellido = persona.Apellido;
                    item.Documento = persona.Documento;
                    item.Direccion = persona.Direccion;
                    item.Email = persona.Email;
                    respuesta = true;
                }
                
            }
            return respuesta;
        }
        public bool Eliminar(int numero)
        {
            bool respuesta = false;

            for(int i =0; i<= oPersona.Count; i++)
            {
                if (oPersona[i].Codigo == numero)
                {
                    oPersona.RemoveAt(i);
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
