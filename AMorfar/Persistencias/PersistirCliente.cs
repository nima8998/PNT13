using AMorfar.Negocios.Entidades;
using Clientes.Persistencias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMorfar.Persistencias
{
    public class PersistirCliente
    {
        Contexto contexto = new Contexto();

        public bool Save(Persona newClient)
        {
            bool result = false;
            if (newClient != null)
            {
                contexto.Personas.Add(newClient);
                contexto.SaveChanges();
                result = true;
            }
            return result;
        }

        public List<Persona>? Get(string busqueda)
        {
            List<Persona>? result = (from c in contexto.Personas where c.Nombre.Contains(busqueda) select c)?.ToList();
            return result;

        }

        public List<Persona> GetAll()
        {
            return contexto.Personas.ToList();
        }
    }
}
