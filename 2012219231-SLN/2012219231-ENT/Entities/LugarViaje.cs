using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012219231_ENT.Entities
{
    public class LugarViaje
    {
        public int LugarViajeId { get; set; }

        public TipoLugar TipoLugar { get; set; }
        public Transporte Transporte { get; set; }
        public int TransporteId { get; set; }

        public string Observacion { get; set; }

        public List<Encomienda> Encomiendas { get; set; }

        public LugarViaje()
        {
            Encomiendas = new List<Encomienda>();
        }
    }
}