using AMorfar.Negocios.Entidades;
using AMorfar.Persistencias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMorfar.Negocios.Actividades
{
    public class ActividadCliente
    {
        PersistirCliente persistir = new();
        public bool Save(Persona newClient)
        {
            try
            {
                return persistir.Save(newClient);

            }catch (Exception e)
            {
                return false;
            }
        }

        public List<Persona>? Get(string busqueda)
        {
            return persistir.Get(busqueda);
        }

        public List<Persona> GetAll()
        {
            return persistir.GetAll();
        }
    }
}
