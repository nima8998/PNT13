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
            return persistir.Save(newClient);
        }

        public Persona? Get(string dni)
        {
            return persistir.Get(dni);
        }

        public List<Persona> GetAll()
        {
            return persistir.GetAll();
        }
    }
}
