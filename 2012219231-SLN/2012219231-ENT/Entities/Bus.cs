using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012219231_ENT.Entities
{
    public class Bus
    {
        public int BusId { get; set; }
        public string Placa { get; set; }

        public Transporte Transporte { get; set; }
        public int TransporteId { get; set; }

        public List<Tripulacion> Tripulacions { get; set; }
        public List<Encomienda> Encomiendas { get; set; }

        public Bus()
        {
            Tripulacions = new List<Tripulacion>();
            Encomiendas = new List<Encomienda>();
        }
    }
}