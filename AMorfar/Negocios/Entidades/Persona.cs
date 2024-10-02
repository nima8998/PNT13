using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMorfar.Negocios.Entidades
{
    public class Persona
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(8), Required]
        public string? DNI { get; set; }

        [MaxLength(50)]
        public string? Nombre { get; set; }

        [MaxLength(50)]
        public string? Apellido { get; set; }

        public List<Comanda>? Comandas { get; set; }
    }
}
