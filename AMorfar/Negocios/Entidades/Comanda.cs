using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMorfar.Negocios.Entidades
{
    public class Comanda
    {
        public int ID { get; set; } //HOLA MUCHACHOS
        public List<Persona>? Personas { get; set; }
        public List<Producto>? Productos { get; set; }
    }
    //COMMIT: Para guardar los cambios localmente y comprometerse.
    //PULL: Se asegura de tener la ultima versión del proyecto en GitHub y lo guarda localmente en mi PC.
    //PUSH: Sube los cambios en el proyecto al repositorio remoto de donde fue extraído.
}
