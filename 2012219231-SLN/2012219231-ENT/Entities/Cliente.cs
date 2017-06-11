using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012219231_ENT.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Correo { get; set; }
        public int Telefono { get; set; }
        public string Dirección { get; set; }
        public int DNI { get; set; }

        public Transporte Transporte { get; set; }
        public int TransporteId { get; set; }

        public List<Venta> Ventas { get; set; }
        public Cliente()
        {
            Ventas = new List<Venta>();
        }

    }
}
