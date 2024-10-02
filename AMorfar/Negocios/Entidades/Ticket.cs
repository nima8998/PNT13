using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMorfar.Negocios.Entidades
{
    public class Ticket
    {
        [Key]
        public int ID;

        public Pedido? Pedido;

        public double Total, Propina;

    }
}
