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
        public int ID;

        public double Total;

        public List<Comanda>? Comandas;
    }
}
