using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012219231_ENT.Entities
{
    public class Venta
    {
        public int VentaId { get; set; }

        public Administrativo Administrativo { get; set; }
        public int AdministrativoId { get; set; }

        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

        public TipoComprobante TipoComprobante { get; set; }
        public TipoPago TipoPago { get; set; }

        public List<Servicio> Servicios { get; set; }

        public Venta()
        {
            Servicios = new List<Servicio>();
        }
    }
}