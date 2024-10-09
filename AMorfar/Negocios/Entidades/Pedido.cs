using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMorfar.Negocios.Entidades
{
    public class Pedido
    {
        [Key]
        public int ID { get; set; }

        public double Total { get; set; }

        //public List<Comanda>? Comandas { get; set;  }
    }
}
