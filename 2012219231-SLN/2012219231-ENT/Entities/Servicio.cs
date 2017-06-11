using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012219231_ENT.Entities
{
    public abstract class Servicio
    {
        public int ServicioId { get; set; }

        public DateTime Hora { get; set; }
        public String Fecha { get; set; }
        public string Direccion { get; set; }

        public Venta Venta { get; set; }
        public int VentaId { get; set; }


    }
}
