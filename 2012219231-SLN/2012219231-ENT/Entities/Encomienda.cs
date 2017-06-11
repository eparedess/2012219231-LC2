using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012219231_ENT.Entities
{
    public class Encomienda : Servicio
    {
        public LugarViaje LugarViaje { get; set; }
        public int LugarViajeId { get; set; }

        public Bus Bus { get; set; }
        public int BusId { get; set; }
    }
}