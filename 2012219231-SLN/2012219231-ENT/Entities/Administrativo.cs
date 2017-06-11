using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012219231_ENT.Entities
{
   public class Administrativo : Empleado
    {
        public List<Venta> Ventas { get; set; }

        public Administrativo()
        {
            Ventas = new List<Venta>();
        }

    }
}
