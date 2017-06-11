using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012219231_ENT.Entities
{
    public class Transporte : Servicio
    {
        public TipoViaje TipoViaje { get; set; }

        public List<LugarViaje> LugarViajes { get; set; }
        public List<Bus> Buses { get; set; }
        public List<Cliente> Clientes { get; set; }

        public Transporte()
        {
            Buses = new List<Bus>();
            LugarViajes = new List<LugarViaje>();
            Clientes = new List<Cliente>();
        }
    }
}